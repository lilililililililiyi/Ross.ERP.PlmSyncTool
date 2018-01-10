using Newtonsoft.Json;
using Ross.ERP.Entity.DTO;
using Ross.ERP.Entity.RossLive.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ross.ERP.Entity
{
    public class RossLiveRespository
    {
        private string Connection { get; set; }
        private RossLive.RossLiveDbContext RLDB;
        public RossLiveRespository()
        {
            Connection = "RossLiveDbContext";
            RLDB = new RossLive.RossLiveDbContext();
        }
    }
}
