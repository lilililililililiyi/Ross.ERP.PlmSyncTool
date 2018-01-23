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

        public List<UpdateLogs> GetUptLog(DateTime dt, int top = 1000)
        {
            return RLDB.UpdateLogs
                .Where(o => o.SysTime >= dt)
                .OrderByDescending(o => o.SysTime).Take(top).ToList();
        }

        public int AddUptLog(UpdateLogs input)
        {
            int result = 0;
            try
            {
                RLDB.UpdateLogs.Add(input);
                result = RLDB.SaveChanges();
            }
            catch { }
            return result;
        }
    }
}
