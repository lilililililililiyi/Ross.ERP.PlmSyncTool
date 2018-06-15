using Ross.ERP.Entity.RossLive.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public async Task<List<UpdateLogs>> GetUptLog(DateTime? dt, int top = 1000)
        {
            return await Task.Run(() =>
            {
                List<UpdateLogs> result = new List<UpdateLogs>();
                if (dt != null)
                {
                    result = RLDB.UpdateLogs.Where(o => o.SysTime >= dt).ToList();
                }
                if (top > 0)
                {
                    result = RLDB.UpdateLogs.Take(top).ToList();
                }
                return result.OrderByDescending(o => o.SysTime).ToList();
            });
        }

        public int InsertUptLog(UpdateLogs input)
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

        public int InsertOrUpdatePower(RossPowers input)
        {
            int result = 0;
            try
            {
                if (input.ID.Equals(0))
                {
                    RLDB.RossPowers.Add(input);
                    RLDB.SaveChanges();
                    result = input.ID;
                }
                else
                {
                    RLDB.Entry(input).State = EntityState.Modified;
                    RLDB.SaveChanges();
                    result = input.ID;
                }
            }
            catch { }
            return result;
        }
        public RossPowers GetPower(int ID)
        {
            return RLDB.RossPowers.Where(o => o.ID == ID).FirstOrDefault();
        }
        public async Task<List<RossPowers>> GetPowers(int ParentId = 0)
        {
            return await Task.Run(() =>
            {
                List<RossPowers> lists = RLDB.RossPowers.ToList();
                if (ParentId > 0)
                {
                    lists = lists.Where(o => o.ParentID == ParentId).ToList();
                }
                return lists;
            });
        }

        public int InsertOrUpdateUser(RossUsers input)
        {
            int result = 0;
            try
            {
                if (input.ID.Equals(0))
                {
                    RLDB.RossUsers.Add(input);
                    RLDB.SaveChanges();
                    result = input.ID;
                }
                else
                {
                    RLDB.Entry(input).State = EntityState.Modified;
                    RLDB.SaveChanges();
                    result = input.ID;
                }
            }
            catch { }
            return result;
        }

        public async Task<List<RossUsers>> GetUsers(string UserName = "")
        {
            return await Task.Run(() =>
            {
                List<RossUsers> lists = RLDB.RossUsers.ToList();
                if (!string.IsNullOrEmpty(UserName))
                {
                    lists = lists.Where(o => o.UserName == UserName).ToList();
                }
                return lists;
            });
        }
        public RossUsers GetUser(string UserID)
        {
            return RLDB.RossUsers.Where(o => o.UserID == UserID).FirstOrDefault();
        }
        public RossUsers GetUser(string UserID, string Password)
        {
            return RLDB.RossUsers.Where(o => o.UserID == UserID && o.Password == Password).FirstOrDefault();
        }

        public RossConfig GetRossCfg()
        {
            try
            {
                return RLDB.RossConfig.FirstOrDefault();
            }
            catch(Exception e)
            {
                return null;
            }
        }
        public string UpdateRossCfg(RossConfig input)
        {
            try
            {
                RLDB.Entry(input).State = EntityState.Modified;
                RLDB.SaveChanges();
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public List<PartDegs> GetPartDeg(string partnum="")
        {
            var datas = RLDB.PartDegs.ToList();
            if (!string.IsNullOrEmpty(partnum))
            {
                datas = datas.Where(o => o.PartNum == partnum).ToList();
            }
            return datas;
        }
        public int DeleteAllNewPart()
        {
            return RLDB.Database.ExecuteSqlCommand("DELETE FROM RossNewParts");
        }
        
        public int InsertOrUpdateNewPart(RossNewParts input)
        {
            int result = 0;
            try
            {
                if (input.ID.Equals(0))
                {
                    RLDB.RossNewParts.Add(input);
                    RLDB.SaveChanges();
                    result = input.ID;
                }
                else
                {
                    RLDB.Entry(input).State = EntityState.Modified;
                    RLDB.SaveChanges();
                    result = input.ID;
                }
            }
            catch(Exception ex) { }
            return result;
        }
    }
}
