﻿using Ross.ERP.Entity.DTO;
using Ross.ERP.Entity.ERP.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Ross.ERP.Entity
{
    public class ERPRepository
    {
        private string Connection { get; set; }
        private ERP.ERPDbContext ConstDB;
        public BasicDatas BasicDatas { get; set; }
        public ERPRepository(string ConnStr)
        {
            ConstDB = new ERP.ERPDbContext(ConnStr);
            Connection = ConnStr;
        }

        public UserFile GetUser(string UserName)
        {
            UserFile model = new UserFile();
            model = ConstDB.UserFile.Where(o => o.DcdUserID == UserName).FirstOrDefault();
            return model;
        }

        public List<Part> GetPart(string TypeCode = "")
        {
            List<Part> lists = new List<Part>();
            using (ERP.ERPDbContext ERPDB = new ERP.ERPDbContext(Connection))
            {
                if (!string.IsNullOrEmpty(TypeCode))
                    lists = ERPDB.Part.Where(o => o.TypeCode == TypeCode).ToList();
                else
                    lists = ERPDB.Part.ToList();
            }
            return lists;
        }

        public List<PartMtl> GetPartMtl(string PartNum = "")
        {
            List<PartMtl> lists = new List<PartMtl>();
            using (ERP.ERPDbContext ERPDB = new ERP.ERPDbContext(Connection))
            {
                if (!string.IsNullOrEmpty(PartNum))
                    lists = ERPDB.PartMtl.Where(o => o.PartNum == PartNum).ToList();
                else
                    lists = ERPDB.PartMtl.ToList();
            }
            return lists;
        }

        public List<PartOpr> GetPartOpr(string PartNum = "")
        {
            List<PartOpr> lists = new List<PartOpr>();
            using (ERP.ERPDbContext ERPDB = new ERP.ERPDbContext(Connection))
            {
                if (!string.IsNullOrEmpty(PartNum))
                    lists = ERPDB.PartOpr.Where(o => o.PartNum == PartNum).ToList();
                else
                    lists = ERPDB.PartOpr.ToList();
            }
            lists = lists.OrderBy(o => o.OprSeq).ToList();
            return lists;
        }
        /// <summary>
        /// 获取未关闭工单下的自制件
        /// </summary>
        /// <param name="Top"></param>
        /// <returns></returns>
        public List<Part> GetUnClosedPart(int Top = 0)
        {
            List<Part> lists = new List<Part>();
            using (ERP.ERPDbContext ERPDB = new ERP.ERPDbContext(Connection))
            {
                lists = (from a in ERPDB.Part
                         join b in ERPDB.JobAsmbl.Where(o => !o.JobComplete) on a.PartNum equals b.PartNum
                         where a.TypeCode == "M"
                         select a).ToList();
                if (Top > 0)
                    lists = lists.Take(Top).ToList();
            }
            return lists;
        }

        /// <summary>
        /// 获取ERP产品设计BOM
        /// </summary>
        /// <param name="PartNum"></param>
        /// <returns></returns>
        public void GetERPBOM(string PartNum, List<DTO_MBOM> ERPBOM, bool isChild = true)
        {
            var lists = from a in BasicDatas.ErpPartMtl
                        join part in BasicDatas.ErpPart on a.PartNum equals part.PartNum
                        join partMtl in BasicDatas.ErpPart on a.MtlPartNum equals partMtl.PartNum
                        where a.PartNum == PartNum
                        select new { a, part, partMtl };
            foreach (var item in lists)
            {
                DTO_MBOM obj = new DTO_MBOM();
                obj.Company = "001";
                obj.ECOGroupID = "manager";
                obj.MtlPartNum = item.partMtl.PartNum;
                obj.MtlPartDescription = item.partMtl.PartDescription;
                obj.MtlSeq = item.a.MtlSeq;
                obj.PartDescription = item.part.PartDescription;
                obj.PartNum = item.part.PartNum;
                obj.Plant = "MfgSys";
                obj.PullAsAsm = item.partMtl.TypeCode == "M" ? "TRUE" : "FALSE";
                obj.QtyPer = item.a.QtyPer;
                obj.RelatedOperation = 10;
                obj.RevisionNum = "A";
                obj.ViewAsAsm = item.partMtl.TypeCode == "M" ? "TRUE" : "FALSE";
                obj.Source = item.partMtl.TypeCode == "M" ? "自制件" : "外购件";
                ERPBOM.Add(obj);
                if (isChild)
                    GetERPBOM(obj.MtlPartNum, ERPBOM);
            }
        }

        public void GetERPBOMChild(List<DTO_MBOM> lists, string PartNum)
        {
            var datas = from a in BasicDatas.ErpPartMtl
                        join part in BasicDatas.ErpPart on a.PartNum equals part.PartNum
                        join partMtl in BasicDatas.ErpPart on a.MtlPartNum equals partMtl.PartNum
                        where a.PartNum == PartNum
                        select new { a, part, partMtl };
            foreach (var item in datas)
            {
                GetERPBOMChild(lists, item.partMtl.PartNum);
                DTO_MBOM obj = new DTO_MBOM();
                obj.Company = "001";
                obj.ECOGroupID = "manager";
                obj.MtlPartNum = item.partMtl.PartNum;
                obj.MtlPartDescription = item.partMtl.PartDescription;
                obj.MtlSeq = item.a.MtlSeq;
                obj.PartDescription = item.part.PartDescription;
                obj.PartNum = item.part.PartNum;
                obj.Plant = "MfgSys";
                obj.PullAsAsm = item.partMtl.TypeCode == "M" ? "TRUE" : "FALSE";
                obj.QtyPer = item.a.QtyPer;
                obj.RelatedOperation = 10;
                obj.RevisionNum = "A";
                obj.ViewAsAsm = item.partMtl.TypeCode == "M" ? "TRUE" : "FALSE";
                obj.Source = item.partMtl.TypeCode == "M" ? "自制件" : "外购件";
                lists.Add(obj);
            }
        }
        /// <summary>
        /// 获取工单自制半成品
        /// </summary>
        /// <param name="JobComplete"></param>
        /// <param name="IssuedComplete"></param>
        /// <param name="PartNum"></param>
        /// <param name="JobNum"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public List<DTO_JobMtl> GetJobMtl(bool? JobComplete, bool? IssuedComplete, string PartNum, string JobNum = "", int PageSize = 0)
        {
            List<DTO_JobMtl> result = new List<DTO_JobMtl>();

            var lists = (from Asmbl in ConstDB.JobAsmbl.Where(o => o.PartNum == PartNum)
                         join Mtl in ConstDB.JobMtl on new { Asmbl.AssemblySeq, Asmbl.JobNum } equals new { Mtl.AssemblySeq, Mtl.JobNum }
                         select new { Asmbl, Mtl }).ToList();

            if (JobComplete.HasValue)
                lists = lists.Where(o => o.Asmbl.JobComplete == JobComplete).ToList();

            if (IssuedComplete.HasValue)
                lists = lists.Where(o => o.Mtl.IssuedComplete == IssuedComplete).ToList();

            if (!string.IsNullOrEmpty(JobNum))
                lists = lists.Where(o => o.Asmbl.JobNum == JobNum).ToList();

            if (PageSize > 0)
                lists = lists.Take(PageSize).ToList();

            foreach (var item in lists)
            {
                DTO_JobMtl obj = new DTO_JobMtl();
                obj.AssemblySeq = item.Asmbl.AssemblySeq;
                obj.Company = item.Asmbl.Company;
                obj.Description = item.Mtl.Description;
                obj.IssuedComplete = item.Mtl.IssuedComplete;
                obj.IssuedQty = item.Mtl.IssuedQty;
                obj.IUM = item.Mtl.IUM;
                obj.JobComplete = item.Asmbl.JobComplete;
                obj.JobNum = item.Asmbl.JobNum;
                obj.MtlSeq = item.Mtl.MtlSeq;
                obj.PartNum = item.Mtl.PartNum;
                obj.QtyPer = item.Mtl.QtyPer;
                obj.RequiredQty = item.Mtl.RequiredQty;
                result.Add(obj);
            }
            return result;
        }

        /// <summary>
        /// 零部件BOM是否需要更新
        /// </summary>
        /// <param name="PartNum"></param>
        /// <returns></returns>
        public bool PartBOMUpdate(string PartNum)
        {
            bool result = false;
            using (ERP.ERPDbContext ERPDB = new ERP.ERPDbContext(Connection))
            {
                var partOpr = ERPDB.PartOpr.Where(o => o.PartNum == PartNum).FirstOrDefault();
                //当零部件在ERP中没有工序，也就没有BOM，说明需要更新
                if (partOpr == null)
                {
                    result = true;
                }
                else
                {
                    var jobAsm = ERPDB.JobAsmbl.Where(o => o.PartNum == PartNum && o.JobComplete == false).FirstOrDefault();
                    //半成品所在工单未关闭，可以更新
                    if (jobAsm != null)
                    {
                        result = true;
                    }
                    else
                    {
                        var jobMtl = ERPDB.JobMtl.Where(o => o.PartNum == PartNum && o.JobComplete == false).FirstOrDefault();
                        //零部件所在工单未关闭，可以更新
                        if (jobMtl != null)
                        {
                            result = true;
                        }
                    }
                }
            }
            return result;
        }

        public DTO_COMPANY GetCompany()
        {
            DTO_COMPANY model = new DTO_COMPANY();
            using (ERP.ERPDbContext ERPDB = new ERP.ERPDbContext(Connection))
            {
                var Company = ERPDB.Company.FirstOrDefault();
                if (Company != null)
                {
                    var Company_UD = ERPDB.Company_UD.Where(o => o.ForeignSysRowID == Company.SysRowID).FirstOrDefault();
                    if (Company_UD != null)
                    {
                        model.Company = Company.Company1;
                        model.Name = Company.Name;
                        model.LastGetPLMTime = Company_UD.LastGetPLMTime_c;
                    }
                }
            }
            return model;
        }

        public int UpdateLastGetPLMTime(DateTime LastGetTime)
        {
            int result = 0;
            try
            {
                using (ERP.ERPDbContext ERPDB = new ERP.ERPDbContext(Connection))
                {
                    var CompanyUD = ERPDB.Company_UD.FirstOrDefault();
                    CompanyUD.LastGetPLMTime_c = LastGetTime;
                    ERPDB.Entry(CompanyUD).State = EntityState.Modified;
                    result = ERPDB.SaveChanges();
                }
            }
            catch { }
            return result;
        }

        public int GetRevId(string PartNum, string UserID)
        {
            int result = 0;
            try
            {
                using (ERP.ERPDbContext ERPDB = new ERP.ERPDbContext(Connection))
                {
                    SyncHistory model = new SyncHistory();
                    model.Company = "001";
                    model.PartNum = PartNum;
                    model.SyncTime = DateTime.Now;
                    model.UserID = UserID;
                    model.RevName = "R";
                    ERPDB.SyncHistory.Add(model);
                    ERPDB.SaveChanges();
                    result = model.ID;
                }
            }
            catch (Exception e) { }
            return result;
        }

        public int GetPartRev(string PartNum)
        {
            int result = 0;
            try
            {
                using (ERP.ERPDbContext ERPDB = new ERP.ERPDbContext(Connection))
                {
                    var item = ERPDB.PartRev.Where(o => o.PartNum == PartNum).OrderByDescending(o => o.RevisionNum).FirstOrDefault();
                    if (item != null)
                    {
                        if (item.RevisionNum.ToUpper() == "A")
                            result = 0;
                        else
                        {
                            result = int.Parse(item.RevisionNum.Replace("A", ""));
                        }
                    }
                }
            }
            catch (Exception e) { }
            return result;
        }

        public int GetBOORev(string PartNum)
        {
            int result = 0;
            try
            {
                using (ERP.ERPDbContext ERPDB = new ERP.ERPDbContext(Connection))
                {
                    var item = ERPDB.PartOpr.Where(o => o.PartNum == PartNum).OrderByDescending(o => o.RevisionNum).FirstOrDefault();
                    if (item != null)
                    {
                        if (item.RevisionNum.ToUpper() == "A")
                            result = 0;
                        else
                        {
                            result = int.Parse(item.RevisionNum.Replace("A", ""));
                        }
                    }

                }
            }
            catch (Exception e) { }
            return result;
        }

        public bool DelRev(string PartNum, string UserID, int RevNum)
        {
            bool result = false;
            try
            {
                using (ERP.ERPDbContext ERPDB = new ERP.ERPDbContext(Connection))
                {
                    var model = ERPDB.SyncHistory.Where(o => o.PartNum == PartNum && o.UserID == UserID && o.RevNum == RevNum).FirstOrDefault();
                    if (model != null)
                    {
                        ERPDB.Entry(model).State = EntityState.Deleted;
                        ERPDB.SaveChanges();
                        result = true;
                    }
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }
        /// <summary>
        /// 添加库存物料
        /// </summary>
        /// <param name="PartNum"></param>
        /// <param name="UserID"></param>
        /// <returns>返回0失败</returns>
        public int AddStockPart(string PartNum, string UserID)
        {
            int result = 0;
            try
            {
                int count = ConstDB.StockPart.Where(o => o.PartNum == PartNum).Count();
                if (count <= 0)
                {
                    StockPart model = new StockPart();
                    model.PartNum = PartNum;
                    model.UserID = UserID;
                    ConstDB.StockPart.Add(model);
                    result = ConstDB.SaveChanges();
                }
            }
            catch { }
            return result;
        }

        public int DelStockPart(string[] PartNums)
        {
            int result = 0;
            try
            {
                var lists = ConstDB.StockPart.Where(o => PartNums.Contains(o.PartNum)).ToList();
                if (lists.Count > 0)
                {
                    foreach (var obj in lists)
                    {
                        ConstDB.Entry(obj).State = EntityState.Deleted;
                        result += ConstDB.SaveChanges();
                    }
                }
            }
            catch { }
            return result;
        }

        public IList<StockPart> GetStockPart()
        {
            return ConstDB.StockPart.ToList();
        }
    }
}
