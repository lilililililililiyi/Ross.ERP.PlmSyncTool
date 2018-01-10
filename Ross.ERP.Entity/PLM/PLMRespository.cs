using Newtonsoft.Json;
using Ross.ERP.Entity.DTO;
using Ross.ERP.Entity.PLM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ross.ERP.Entity
{
    public class PLMRespository
    {
        private string Connection { get; set; }
        private PLM.PLMDbContext PLMDB;
        private IList<DTO_Unit> Units;
        public PLMRespository(string ConnStr, string ConfigUnit = "")
        {
            Connection = ConnStr;
            PLMDB = new PLM.PLMDbContext(ConnStr);
            Units = JsonConvert.DeserializeObject<IList<DTO_Unit>>(ConfigUnit);
        }

        public async Task<List<MBOM>> GetMBOM()
        {
            return await Task.Run(() =>
            {
                return PLMDB.MBOM.Where(o => o.DEL == false && o.STATE == "A").ToList();
            });

        }
        public async Task<List<MPART>> GetMPART()
        {
            return await Task.Run(() =>
            {
                return PLMDB.MPART.Where(o => o.DEL == false && o.STATE == "A").ToList();
            });
        }
        public async Task<List<CONS>> GetCONS()
        {
            return await Task.Run(() =>
            {
                return PLMDB.CONS.Where(o => o.DEL == false && o.STATE == "A").ToList();
            });
        }

        public async Task<List<CONS_OBJOF>> GetCONS_OBJOF()
        {
            return await Task.Run(() =>
            {
                return PLMDB.CONS_OBJOF.Where(o => o.DEL == false && o.STATE == "A").ToList();
            });
        }

        public async Task<List<MATERIAL>> GetMaterial(int top = 10)
        {
            return await Task.Run(() =>
            {
                return PLMDB.MATERIAL.Take(top).ToList();
            });

        }
        /// <summary>
        /// 获取更新的BOM物料
        /// </summary>
        /// <param name="LastGetTime"></param>
        /// <returns></returns>
        public List<DTO_MBOM> GetModBOM(DateTime LastGetTime)
        {
            List<DTO_MBOM> result = new List<DTO_MBOM>();
            var PRODATA = GetNewPLMBOO(LastGetTime);
            string[] PartNums = new string[PRODATA.Count];
            for (int i = 0; i < PRODATA.Count; i++)
            {
                PartNums[i] = PRODATA[i].PartNum.Trim();
            }
            using (PLM.PLMDbContext PLMDB = new PLM.PLMDbContext(Connection))
            {
                var MPART_DATA = from a in PLMDB.MPART
                                 where (a.CTIME > LastGetTime || a.MTIME > LastGetTime || a.DELTIME > LastGetTime)
                                 select a;

                var data = from a in PLMDB.MBOM
                           join b in MPART_DATA on a.PID equals b.ID
                           join c in PLMDB.MPART on a.CID equals c.ID
                           where a.DEL == false && a.STATE == "A" && (PartNums.Contains(b.NO.Trim()) || PartNums.Contains(c.NO.Trim()))
                           orderby a.MTIME descending, b.MTIME descending
                           select new { bom = a, part = b };

                foreach (var item in data)
                {
                    DTO_MBOM obj = new DTO_MBOM();
                    obj.Company = "001";
                    obj.ECOGroupID = "manager";
                    obj.MtlSeq = item.bom.BOMPST.Value;
                    obj.PartDescription = item.part.NAME;
                    obj.PartNum = item.part.NO;
                    obj.Plant = "MfgSys";
                    obj.PullAsAsm = ChkWGJ(item.part.SMEMO, "FALSE", "TRUE");
                    obj.QtyPer = item.bom.BNUM.Value;
                    obj.RelatedOperation = 10;
                    obj.RevisionNum = "A";
                    obj.ViewAsAsm = ChkWGJ(item.part.SMEMO, "FALSE", "TRUE");
                    obj.Source = item.part.SOURCE;
                    result.Add(obj);
                }
            }
            return result.ToList();
        }

        /// <summary>
        /// 获取新物料档案
        /// </summary>
        /// <param name="LastGetTime"></param>
        /// <returns></returns>
        public List<DTO_MPART> GetNewPLMPart(DateTime? dt, string PartNums = "")
        {
            List<DTO_MPART> Lists = new List<DTO_MPART>();
            List<MPART> ListMPart = BasicDatas.PLM_MPART.ToList();
            List<MATERIAL> ListMATERIAL = BasicDatas.PLM_MATERIAL.ToList();
            List<PRODUCT> ListProduct = BasicDatas.PLM_PRODUCT.ToList();
            List<MTL> ListMtl = BasicDatas.PLM_MTL.ToList();
            if (dt.HasValue)
            {
                ListMPart = ListMPart.Where(o => o.CTIME >= dt || o.MTIME >= dt).ToList();
                ListMATERIAL = ListMATERIAL.Where(o => o.CTIME >= dt || o.MTIME >= dt).ToList();
                ListProduct = ListProduct.Where(o => o.CTIME >= dt || o.MTIME >= dt).ToList();
                ListMtl = ListMtl.Where(o => o.CTIME >= dt || o.MTIME >= dt).ToList();
            }
            if (!string.IsNullOrEmpty(PartNums))
            {
                ListMPart = ListMPart.Where(o => PartNums.Contains(o.NO)).ToList();
                ListMATERIAL = ListMATERIAL.Where(o => PartNums.Contains(o.NO)).ToList();
                ListProduct = ListProduct.Where(o => PartNums.Contains(o.NO)).ToList();
                ListMtl = ListMtl.Where(o => PartNums.Contains(o.NO)).ToList();
            }
            Lists = ConvertMPART(ListMPart, ListMATERIAL, ListProduct, ListMtl);
            return Lists;
        }

        public List<DTO_MPART> ConvertMPART(List<MPART> ListMPart, List<MATERIAL> ListMaterial, List<PRODUCT> ListProduct, List<MTL> ListMtl)
        {
            List<DTO_MPART> lists = new List<DTO_MPART>();
            if (ListMPart != null && ListMPart.Count > 0)
            {
                foreach (var item in ListMPart)
                {
                    DTO_MPART obj = new DTO_MPART();
                    obj.Company = "001";
                    obj.CostMethod = "A";
                    obj.IUM = CvtUM(item.UNIT);
                    obj.PartDescription = item.NAME + " " + item.ASUSER01 + " " + item.SPECS + " " + item.MTLMARK + " " + item.SMEMO + " " + item.ASUSER02 + " " + item.EORIGINNO + " " + item.STANDARDNO;
                    obj.PartNum = item.NO;
                    obj.PartPlant_Plant = "MfgSys";
                    obj.PartPlant_PrimWhse = ChkWGJ(item.SMEMO, "WGJ", "BCP");
                    obj.PartRev_RevisionNum = ChkWGJ(item.SMEMO, "", "A");
                    obj.PartRev_RevShortDesc = ChkWGJ(item.SMEMO, "", "A");
                    obj.PUM = CvtUM(item.UNIT);
                    obj.SalesUM = CvtUM(item.UNIT);
                    obj.TypeCode = ChkWGJ(item.SMEMO, "P", "M");
                    obj.UOMClassID = CvtUMClassID(obj.IUM);
                    obj.ClassId = CvtClssId(obj.TypeCode, obj.PartNum);
                    obj.PartRev_Approved = obj.TypeCode == "M" ? "TRUE" : "";
                    obj.PartRev_EffectiveDate = obj.TypeCode == "M" ? DateTime.Now.ToString() : "";
                    if (lists.Where(o => o.PartNum == item.NO).Count() <= 0)
                    {
                        lists.Add(obj);
                    }
                }
            }
            if (ListMaterial != null && ListMaterial.Count > 0)
            {
                foreach (var item in ListMaterial)
                {
                    DTO_MPART obj = new DTO_MPART();
                    obj.Company = "001";
                    obj.CostMethod = "A";
                    obj.IUM = CvtUM(item.MTLUNITNAME);
                    obj.PartDescription = item.NAME + " " + item.MTLSPECS + " " + item.MTLCATANAME + " " + item.MTLMARK + " " + item.MTLSTANDNO + " " + item.MTLDENSITY + " " + item.SMEMO;
                    obj.PartNum = item.NO;
                    obj.PartPlant_Plant = "MfgSys";
                    obj.PartPlant_PrimWhse = "WGJ";
                    obj.PartRev_RevisionNum = "";
                    obj.PartRev_RevShortDesc = "";
                    obj.PUM = CvtUM(item.MTLUNITNAME);
                    obj.SalesUM = CvtUM(item.MTLUNITNAME);
                    obj.TypeCode = "P";
                    obj.UOMClassID = CvtUMClassID(obj.IUM);
                    obj.ClassId = CvtClssId("P", obj.PartNum);
                    obj.PartRev_Approved = obj.TypeCode == "M" ? "TRUE" : "";
                    obj.PartRev_EffectiveDate = obj.TypeCode == "M" ? DateTime.Now.ToString() : "";
                    if (lists.Where(o => o.PartNum == item.NO).Count() <= 0)
                    {
                        lists.Add(obj);
                    }
                }
            }
            if (ListProduct != null && ListProduct.Count > 0)
            {
                foreach (var item in ListProduct)
                {
                    DTO_MPART obj = new DTO_MPART();
                    obj.Company = "001";
                    obj.CostMethod = "A";
                    obj.IUM = "PCS";
                    obj.PartDescription = item.NAME + " " + item.SERIES + " " + item.DESCRIBE + " " + item.SMEMO;
                    obj.PartNum = item.NO;
                    obj.PartPlant_Plant = "MfgSys";
                    obj.PartPlant_PrimWhse = "WGJ";
                    obj.PartRev_RevisionNum = "A";
                    obj.PartRev_RevShortDesc = "A";
                    obj.PUM = "PCS";
                    obj.SalesUM = "PCS";
                    obj.TypeCode = "M";
                    obj.UOMClassID = CvtUMClassID(obj.IUM);
                    obj.ClassId = "PC06";
                    obj.PartRev_Approved = "TRUE";
                    obj.PartRev_EffectiveDate = DateTime.Now.ToString();
                    if (lists.Where(o => o.PartNum == item.NO).Count() <= 0)
                    {
                        lists.Add(obj);
                    }
                }
            }
            if (ListMtl != null && ListMtl.Count > 0)
            {
                foreach (var item in ListMtl)
                {
                    DTO_MPART obj = new DTO_MPART();
                    obj.Company = "001";
                    obj.CostMethod = "A";
                    obj.IUM = CvtUM(item.UNITNAME);
                    obj.PartDescription = item.NAME + " " + item.XH + " " + item.GG + " " + item.CL + " " + item.ZZS + " " + item.PTYPE + " " + item.SMEMO;
                    obj.PartNum = item.NO;
                    obj.PartPlant_Plant = "MfgSys";
                    obj.PartPlant_PrimWhse = "WGJ";
                    obj.PartRev_RevisionNum = "";
                    obj.PartRev_RevShortDesc = "";
                    obj.PUM = CvtUM(item.UNITNAME);
                    obj.SalesUM = CvtUM(item.UNITNAME);
                    obj.TypeCode = "P";
                    obj.UOMClassID = CvtUMClassID(obj.IUM);
                    obj.ClassId = "PC01";
                    obj.PartRev_Approved = "";
                    obj.PartRev_EffectiveDate = "";
                    if (lists.Where(o => o.PartNum == item.NO).Count() <= 0)
                    {
                        lists.Add(obj);
                    }
                }
            }
            return lists;
        }
        /// <summary>
        /// 获取BOM下所有物料档案
        /// </summary>
        /// <param name="PartNum"></param>
        /// <returns></returns>
        public List<DTO_MPART> GetPLMBOMPart(string PartNum, out List<DTO_MBOM> MBom)
        {
            List<string> PartNums = new List<string>();
            PartNums.Add(PartNum);
            List<DTO_MBOM> PLM_MBOM = new List<DTO_MBOM>();
            GetPLMBOM(PartNum, PLM_MBOM);
            MBom = PLM_MBOM;
            foreach (var item in PLM_MBOM)
            {
                if (!string.IsNullOrEmpty(item.MtlPartNum))
                {
                    if (!PartNums.Contains(item.MtlPartNum.Trim()))
                        PartNums.Add(item.MtlPartNum.Trim());
                }
            }
            List<DTO_MPART> lists = new List<DTO_MPART>();
            List<MPART> ListMPart = new List<MPART>();

            ListMPart = BasicDatas.PLM_MPART.Where(o => o.DEL == false && o.STATE == "A" && PartNums.Contains(o.NO)).Distinct().ToList();
            List<MATERIAL> ListMtl = new List<MATERIAL>();
            ListMtl = BasicDatas.PLM_MATERIAL.Where(o => o.DEL == false && o.STATE == "A" && PartNums.Contains(o.NO)).Distinct().ToList();

            foreach (var item in ListMPart)
            {
                DTO_MPART obj = new DTO_MPART();
                obj.Company = "001";
                obj.CostMethod = "A";
                obj.IUM = CvtUM(item.UNIT);
                obj.PartDescription = item.NAME + " " + item.ASUSER01 + " " + item.SPECS + " " + item.MTLMARK + " " + item.SMEMO + " " + item.ASUSER02 + " " + item.EORIGINNO + " " + item.STANDARDNO;
                obj.PartNum = string.IsNullOrEmpty(item.NO) ? "" : item.NO.Trim();
                obj.PartPlant_Plant = "MfgSys";
                obj.PartPlant_PrimWhse = ChkWGJ(item.SMEMO, "WGJ", "BCP");
                obj.PartRev_RevisionNum = ChkWGJ(item.SMEMO, "", "A");
                obj.PartRev_RevShortDesc = ChkWGJ(item.SMEMO, "", "A");
                obj.PUM = CvtUM(item.UNIT);
                obj.SalesUM = CvtUM(item.UNIT);
                obj.TypeCode = ChkWGJ(item.SMEMO, "P", "M");
                obj.UOMClassID = CvtUMClassID(obj.IUM);
                obj.ClassId = CvtClssId(obj.TypeCode, obj.PartNum);
                obj.PartRev_Approved = obj.TypeCode == "M" ? "TRUE" : "";
                obj.PartRev_EffectiveDate = obj.TypeCode == "M" ? DateTime.Now.ToString() : "";
                lists.Add(obj);
            }

            foreach (var item in ListMtl)
            {
                DTO_MPART obj = new DTO_MPART();
                obj.Company = "001";
                obj.CostMethod = "A";
                obj.IUM = CvtUM(item.MTLUNITNAME);
                obj.PartDescription = item.NAME + " " + item.MTLSPECS + " " + item.MTLCATANAME + " " + item.MTLMARK + " " + item.MTLSTANDNO + " " + item.MTLDENSITY + " " + item.SMEMO;
                obj.PartNum = item.NO;
                obj.PartPlant_Plant = "MfgSys";
                obj.PartPlant_PrimWhse = "WGJ";
                obj.PartRev_RevisionNum = "";
                obj.PartRev_RevShortDesc = "";
                obj.PUM = CvtUM(item.MTLUNITNAME);
                obj.SalesUM = CvtUM(item.MTLUNITNAME);
                obj.TypeCode = "P";
                obj.UOMClassID = CvtUMClassID(obj.IUM);
                obj.ClassId = CvtClssId("P", obj.PartNum);
                lists.Add(obj);
            }
            return lists;
        }

        private string CvtClssId(string typeCode, string partNum)
        {
            string result = "PC01";
            try
            {
                if (typeCode.ToUpper() == "P")
                {
                    result = "PC01";
                }
                else
                {
                    if (partNum.StartsWith("12"))
                        result = "PC05";
                    else if (partNum.StartsWith("11"))
                        result = "PC06";
                }
            }
            catch { }
            return result;
        }

        private string CvtUM(string IUM)
        {
            try
            {
                var model = Units.Where(o => o.Name.ToUpper() == IUM.ToUpper()).FirstOrDefault();
                return model.Value;
            }
            catch
            {
                return "PCS";
            }
        }
        private string CvtUMClassID(string IUM)
        {
            try
            {
                var model = Units.Where(o => o.Value.ToUpper() == IUM.ToUpper()).FirstOrDefault();
                return model.ClassId;
            }
            catch
            {
                return "Count";
            }
        }
        /// <summary>
        /// 获取PLM产品设计BOM，迭代
        /// </summary>
        /// <param name="PartNum"></param>
        /// <param name="MBOM"></param>
        public void GetPLMBOM(string PartNum, List<DTO_MBOM> MBOM, bool isChild = true)
        {
            var data = from a in BasicDatas.PLM_MBOM
                       join b in BasicDatas.PLM_MPART on a.PID equals b.ID
                       join c in BasicDatas.PLM_MPART on a.CID equals c.ID
                       where b.NO == PartNum
                       select new { bom = a, part = b, partmtl = c };
            var data2 = from cn in BasicDatas.PLM_CONS
                        join cno in BasicDatas.PLM_CONS_OBJOF on cn.ID equals cno.ITEMID2
                        join mp in BasicDatas.PLM_MPART on cno.ITEMID1 equals mp.ID
                        where mp.NO == PartNum
                        select new { cn, cno, mp };

            foreach (var item in data)
            {
                DTO_MBOM obj = new DTO_MBOM();
                obj.Company = "001";
                obj.ECOGroupID = "manager";
                obj.MtlPartNum = item.partmtl.NO.Trim();
                obj.MtlPartDescription = item.partmtl.NAME;
                obj.MtlSeq = item.bom.BOMPST.Value;
                obj.PartDescription = item.part.NAME;
                obj.PartNum = item.part.NO.Trim();
                obj.Plant = "MfgSys";
                obj.PullAsAsm = ChkWGJ(item.partmtl.SMEMO, "FALSE", "TRUE");
                obj.QtyPer = item.bom.BNUM.Value;
                obj.RelatedOperation = 10;
                obj.RevisionNum = "A";
                obj.ViewAsAsm = ChkWGJ(item.partmtl.SMEMO, "FALSE", "TRUE");
                obj.Source = item.partmtl.SOURCE;
                if (MBOM.Where(o => o.Company == obj.Company && o.PartNum == obj.PartNum && o.MtlSeq == obj.MtlSeq).Count() <= 0)
                {
                    MBOM.Add(obj);
                }
                if (isChild && obj.PullAsAsm == "TRUE")
                    GetPLMBOM(obj.MtlPartNum, MBOM);
            }
            foreach (var item in data2)
            {
                DTO_MBOM obj = new DTO_MBOM();
                obj.Company = "001";
                obj.ECOGroupID = "manager";
                obj.MtlPartNum = item.cn.NO;
                obj.MtlPartDescription = item.cn.NAME;
                obj.MtlSeq = 999;
                obj.PartDescription = item.mp.NAME;
                obj.PartNum = item.mp.NO;
                obj.Plant = "MfgSys";
                obj.PullAsAsm = "FALSE";
                obj.QtyPer = item.cn.MTLMZ.HasValue ? item.cn.MTLMZ.Value : 0;
                obj.RelatedOperation = 10;
                obj.RevisionNum = "A";
                obj.ViewAsAsm = "FALSE";
                obj.Source = item.mp.SOURCE;
                if (MBOM.Where(o => o.Company == obj.Company && o.PartNum == obj.PartNum && o.MtlSeq == obj.MtlSeq).Count() <= 0)
                {
                    MBOM.Add(obj);
                }
                if (isChild && obj.PullAsAsm == "TRUE")
                    GetPLMBOM(obj.MtlPartNum, MBOM);
            }
        }
        private string ChkWGJ(string val, string rtn, string def)
        {
            try
            {
                if (val == null)
                    return def;
                else
                    return val.Contains("WG") ? rtn : def;
            }
            catch
            {
                return def;
            }
        }

        public List<DTO_MBOO> GetPLMBOO(string PartNum)
        {
            List<DTO_MBOO> result = new List<DTO_MBOO>();
            using (PLM.PLMDbContext PLMDB = new PLM.PLMDbContext(Connection))
            {
                var data = from a in PLMDB.PROCESS
                           join b in PLMDB.PROCESS_OBJOF on a.ID equals b.ITEMID2
                           join c in PLMDB.PRCV on b.ITEMID1 equals c.ID
                           join d in PLMDB.PRCV_OBJOF on c.ID equals d.ITEMID2
                           join e in PLMDB.MPART on d.ITEMID1 equals e.ID
                           where e.NO.Trim() == PartNum.Trim() && a.DEL == false && b.DEL == false && c.DEL == false && d.DEL == false && e.DEL == false && a.WKAID != "3" && b.WKAID != "3" && c.WKAID != "3" && d.WKAID != "3" && e.WKAID != "3" && a.STATE == "A" && a.GNO.Value > 0 && c.SEL == true
                           select new { pc = a, pco = b, pr = c, pro = d, mp = e };

                foreach (var item in data)
                {
                    DTO_MBOO obj = new DTO_MBOO();
                    obj.Company = "001";
                    obj.DaysOut = IsSubcontract(item.pc.NO) ? "5" : "";
                    obj.ECOGroupID = "manager";
                    obj.LaborEntryMethod = "T";
                    obj.OpCode = item.pc.NO;
                    obj.OprComment = item.pc.DETAILS;
                    obj.OprSeq = item.pc.GNO.HasValue ? int.Parse(item.pc.GNO.Value.ToString()) : 0;
                    obj.PartDescription = item.mp.NAME;
                    obj.PartNum = item.mp.NO;
                    obj.Plant = "MfgSys";
                    obj.ProdStandard = (item.pc.MACHT.HasValue ? item.pc.MACHT.Value : 0) + (item.pc.PRET.HasValue ? item.pc.PRET.Value : 0);
                    obj.RevisionNum = "A";
                    obj.StdFormat = "HP";
                    obj.SubContract = IsSubcontract(item.pc.NO) ? "TRUE" : "";
                    obj.VendorNumVendorID = IsSubcontract(item.pc.NO) ? "999" : "";
                    result.Add(obj);
                }
            }
            return result;
        }

        private bool IsSubcontract(string NO)
        {
            try
            {
                var obj = BasicDatas.ErpOpMaster.Where(o => o.OpCode.ToUpper() == NO.ToUpper()).FirstOrDefault();
                return obj.Subcontract;
            }
            catch
            {
                return false;
            }
        }

        public List<DTO_MBOO> GetNewPLMBOO(DateTime dt)
        {
            List<DTO_MBOO> result = new List<DTO_MBOO>();
            using (PLM.PLMDbContext PLMDB = new PLM.PLMDbContext(Connection))
            {
                var data = from a in PLMDB.PROCESS
                           join b in PLMDB.PROCESS_OBJOF on a.ID equals b.ITEMID2
                           join c in PLMDB.PRCV on b.ITEMID1 equals c.ID
                           join d in PLMDB.PRCV_OBJOF on c.ID equals d.ITEMID2
                           join e in PLMDB.MPART on d.ITEMID1 equals e.ID
                           where (a.CTIME > dt || a.MTIME > dt) && a.DEL == false && b.DEL == false && c.DEL == false && d.DEL == false && e.DEL == false && a.WKAID != "3" && b.WKAID != "3" && c.WKAID != "3" && d.WKAID != "3" && e.WKAID != "3" && a.STATE == "A" && a.GNO.Value > 0 && c.SEL == true
                           select new { pc = a, pco = b, pr = c, pro = d, mp = e };

                foreach (var item in data)
                {
                    DTO_MBOO obj = new DTO_MBOO();
                    obj.Company = "001";
                    obj.DaysOut = IsSubcontract(item.pc.NO) ? "5" : "";
                    obj.ECOGroupID = "manager";
                    obj.LaborEntryMethod = "T";
                    obj.OpCode = item.pc.NO;
                    obj.OprComment = item.pc.DETAILS;
                    obj.OprSeq = item.pc.GNO.HasValue ? int.Parse(item.pc.GNO.Value.ToString()) : 0;
                    obj.PartDescription = item.mp.NAME;
                    obj.PartNum = item.mp.NO;
                    obj.Plant = "MfgSys";
                    obj.ProdStandard = (item.pc.MACHT.HasValue ? item.pc.MACHT.Value : 0) + (item.pc.PRET.HasValue ? item.pc.PRET.Value : 0);
                    obj.RevisionNum = "A";
                    obj.StdFormat = "HP";
                    obj.SubContract = IsSubcontract(item.pc.NO) ? "TRUE" : "";
                    obj.VendorNumVendorID = IsSubcontract(item.pc.NO) ? "999" : "";
                    result.Add(obj);
                }
            }
            return result;
        }
    }
}
