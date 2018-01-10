using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ross.ERP.PlmSyncTool.ExportDto
{
    public class JOBMTL
    {
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int MtlSeq { get; set; }
        public string PartNum { get; set; }
        public string MtlPartNum { get; set; }
        public string MtlDescription { get; set; }        
        public decimal QtyPer { get; set; }
        public string IUM { get; set; }
        public int GroupID { get; set; }
    }
}
