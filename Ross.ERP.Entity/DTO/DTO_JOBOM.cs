using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ross.ERP.Entity.DTO
{
    public class DTO_JOBOM
    {
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        /// <summary>
        /// 物料序号
        /// </summary>
        public int MtlSeq { get; set; }
        public string PartNum { get; set; }
        public string Description { get; set; }
        public int RelatedOperation { get; set; }
        public string WarehouseCode { get; set; }
        public int Parent { get; set; }
        public int Child { get; set; }
        public int BomLevel { get; set; }
        public string RevisionNum { get; set; }
        /// <summary>
        /// 是否是工单物料
        /// </summary>
        public bool IsMtl { get; set; }
    }
}
