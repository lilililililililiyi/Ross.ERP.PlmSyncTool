using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ross.ERP.PlmSyncTool.ExportDto
{
    public class MBOM_UD
    {
        public string Company { get; set; }
        public string ECOGroupID { get; set; }
        public string Plant { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public int MtlSeq { get; set; }
        public string MtlPartNum { get; set; }
        public decimal QtyPer { get; set; }
        public int RelatedOperation { get; set; }
        public string PullAsAsm { get; set; }
        public string ViewAsAsm { get; set; }
        public int GroupID { get; set; }
    }

    public class MBOM_JOB
    {
        public string Company { get; set; }
        public string ECOGroupID { get; set; }
        public string Plant { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public int AssemblySeq { get; set; }
        public int MtlSeq { get; set; }
        public string MtlPartNum { get; set; }
        public decimal QtyPer { get; set; }
        public int RelatedOperation { get; set; }
        public string PullAsAsm { get; set; }
        public string ViewAsAsm { get; set; }
        public string JobNum { get; set; }
        public int GroupID { get; set; }
    }
}
