using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ross.ERP.Entity.DTO
{
    public class DTO_JobMtl
    {
        public string Company { get; set; }        
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int MtlSeq { get; set; }
        public string PartNum { get; set; }
        public string Description { get; set; }
        public decimal QtyPer { get; set; }
        public decimal RequiredQty { get; set; }
        public string IUM { get; set; }
        public decimal IssuedQty { get; set; }
        public bool JobComplete { get; set; }
        public bool IssuedComplete { get; set; }
    }
}
