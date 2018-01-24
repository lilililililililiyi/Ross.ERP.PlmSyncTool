using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ross.ERP.PlmSyncTool.ExportDto
{
    public class POWERS
    {
        public bool IsCheck { get; set; }
        public int ID { get; set; }
        public string PowerIndex { get; set; }
        public string PowerName { get; set; }
        public bool InActive { get; set; }
        public int ParentID { get; set; }
    }
}
