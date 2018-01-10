using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ross.ERP.Entity.DTO
{
    public class DTO_Config
    {
        public decimal AutoRunHour { get; set; }
        public string DMTExePath { get; set; }
        public string DMTLoginUser { get; set; }
        public string DMTPsw { get; set; }
        public string DMTDatabase { get; set; }
        public string ERPConn { get; set; }
        public string PLMConn { get; set; }
        public string Company { get; set; }
        public string Version { get; set; }
        public string AutoUpdateURL { get; set; }
        public string EpicorSysconfig { get; set; }

    }
}
