using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ross.ERP.Entity.DTO
{
    public class DTO_MBOO
    {
        public string Company { get; set; }
        public string ECOGroupID { get; set; }
        public string Plant { get; set; }
        public string PartNum { get; set; }
        public string PartDescription { get; set; }
        public string RevisionNum { get; set; }
        public int OprSeq { get; set; }
        public string OpCode { get; set; }
        public decimal ProdStandard { get; set; }
        public string StdFormat { get; set; }
        public string LaborEntryMethod { get; set; }
        public string OprComment { get; set; }
        public string SubContract { get; set; }
        public string DaysOut { get; set; }
        public string VendorNumVendorID { get; set; }
    }
}
