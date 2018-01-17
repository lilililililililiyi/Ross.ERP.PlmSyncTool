using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ross.ERP.PlmTool.DTO
{
    public class CheckResult
    {
        public string PartNum { get; set; }
        public string PartDesc { get; set; }
        public string ErrorType { get; set; }
        public string Message { get; set; }
        public int ErrorGrade { get; set; }
        public string ParentPartNum { get; set; }
    }
}
