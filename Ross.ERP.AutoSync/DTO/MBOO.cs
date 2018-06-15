using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ross.ERP.AutoSync.DTO
{
    public class MBOO
    {
        public string Company { get; set; }
        public string ECOGroupID { get; set; }
        public string Plant { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public int OprSeq { get; set; }
        public string OpCode { get; set; }
        public string CommentText { get; set; }
        public decimal ProdStandard { get; set; }
        public string StdFormat { get; set; }
        public string LaborEntryMethod { get; set; }
        public string SubContract { get; set; }
        public string DaysOut { get; set; }
        public string VendorNumVendorID { get; set; }
    }
    
}
