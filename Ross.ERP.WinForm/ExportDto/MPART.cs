using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ross.ERP.PlmSyncTool.ExportDto
{
    public class MPART
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string PartDescription { get; set; }
        public string ClassId { get; set; }
        public string UOMClassID { get; set; }
        public string SalesUM { get; set; }
        public string IUM { get; set; }
        public string PUM { get; set; }
        public string TypeCode { get; set; }
        public string CostMethod { get; set; }
        public string PartPlant_Plant { get; set; }
        public string PartPlant_PrimWhse { get; set; }
        public string PartPlant_CostMethod { get; set; }
        public string PartPlant_NonStock { get; set; }
        public string PartRev_RevisionNum { get; set; }
        public string PartRev_RevShortDesc { get; set; }
        public string PartRev_Approved { get; set; }
        public string PartRev_EffectiveDate { get; set; }
        public string TrackLots { get; set; }
        public string NonStock { get; set; }
    }
}
