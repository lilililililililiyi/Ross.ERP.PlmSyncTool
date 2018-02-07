using Ross.ERP.Entity.ERP.Model;
using Ross.ERP.Entity.PLM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ross.ERP.Entity
{
    public class BasicDatas
    {
        /// <summary>
        /// ERP缓存物料档案数据
        /// </summary>
        public static IList<Part> ErpPart { get; set; }
        /// <summary>
        /// ERP缓存BOM数据
        /// </summary>
        public static IList<PartMtl> ErpPartMtl { get; set; }
        public static IList<PartRev> ErpPartRev { get; set; }
        public static IList<OpMaster> ErpOpMaster { get; set; }
        public static IList<StockPart> StockPart { get; set; }
        /// <summary>
        /// PLM缓存BOM数据
        /// </summary>
        public static IList<MBOM> PLM_MBOM { get; set; }
        /// <summary>
        /// PLM缓存零部件数据
        /// </summary>
        public static IList<MPART> PLM_MPART { get; set; }
        /// <summary>
        /// PLM缓存材料消耗定额
        /// </summary>
        public static IList<CONS> PLM_CONS { get; set; }
        /// <summary>
        /// PLM缓存零部件和材料定额的关系
        /// </summary>
        public static IList<CONS_OBJOF> PLM_CONS_OBJOF { get; set; }
        /// <summary>
        /// PLM缓存材料数据
        /// </summary>
        public static IList<MATERIAL> PLM_MATERIAL { get; set; }
        /// <summary>
        /// PLM缓存产品数据
        /// </summary>
        public static IList<PRODUCT> PLM_PRODUCT { get; set; }
        /// <summary>
        /// PLM缓存辅料数据
        /// </summary>
        public static IList<MTL> PLM_MTL { get; set; }
        public string ERP_ConnStr { get; set; }
        public string PLM_ConnStr { get; set; }
        public static string CurrentUser { get; set; }

        public BasicDatas(string _ERP_ConnStr, string _PLM_ConnStr)
        {
            ERP_ConnStr = _ERP_ConnStr;
            PLM_ConnStr = _PLM_ConnStr;
        }

        public void LoadERPPart()
        {
            using (ERP.ERPDbContext ERPDB = new ERP.ERPDbContext(ERP_ConnStr))
            {
                ErpPart = ERPDB.Part.ToList();
                StockPart = ERPDB.StockPart.ToList();
                ErpPartRev = ERPDB.PartRev.ToList();
            }
        }

        public void LoadERPPartMtl()
        {
            using (ERP.ERPDbContext ERPDB = new ERP.ERPDbContext(ERP_ConnStr))
            {
                ErpPartMtl = ERPDB.PartMtl.ToList();
                ErpOpMaster = ERPDB.OpMaster.ToList();
            }
        }

        public void LoadPLM_MBOM()
        {
            using (PLM.PLMDbContext PLMDB = new PLM.PLMDbContext(PLM_ConnStr))
            {
                PLM_MBOM = PLMDB.MBOM.Where(o => o.DEL == false && o.STATE == "A").ToList();
            }
        }

        public void LoadPLM_MPART()
        {
            using (PLM.PLMDbContext PLMDB = new PLM.PLMDbContext(PLM_ConnStr))
            {
                PLM_MPART = PLMDB.MPART.Where(o => o.DEL == false && o.STATE == "A").ToList();
            }
        }
        public void LoadPLM_CONS()
        {
            using (PLM.PLMDbContext PLMDB = new PLM.PLMDbContext(PLM_ConnStr))
            {
                PLM_CONS = PLMDB.CONS.Where(o => o.DEL == false && o.STATE == "A").ToList();
            }
        }
        public void LoadPLM_CONS_OBJOF()
        {
            using (PLM.PLMDbContext PLMDB = new PLM.PLMDbContext(PLM_ConnStr))
            {
                PLM_CONS_OBJOF = PLMDB.CONS_OBJOF.Where(o => o.DEL == false && o.STATE == "A").ToList();
            }
        }

        public void LoadPLM_MATERIAL()
        {
            using (PLM.PLMDbContext PLMDB = new PLM.PLMDbContext(PLM_ConnStr))
            {
                PLM_MATERIAL = PLMDB.MATERIAL.Where(o => o.DEL == false && o.STATE == "A").ToList();
            }

        }
        public void LoadPLM_PRODUCT()
        {
            using (PLM.PLMDbContext PLMDB = new PLM.PLMDbContext(PLM_ConnStr))
            {
                PLM_PRODUCT = PLMDB.PRODUCT.Where(o => o.DEL == false && o.STATE == "A").ToList();
            }

        }
        public void LoadPLM_MTL()
        {
            using (PLM.PLMDbContext PLMDB = new PLM.PLMDbContext(PLM_ConnStr))
            {
                PLM_MTL = PLMDB.MTL.Where(o => o.DEL == false && o.STATE == "A").ToList();
            }

        }
    }
}
