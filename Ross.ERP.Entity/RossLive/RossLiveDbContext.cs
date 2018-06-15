namespace Ross.ERP.Entity.RossLive
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Model;

    public partial class RossLiveDbContext : DbContext
    {
        public RossLiveDbContext()
            : base("name=RossLiveDbContext")
        {
        }

        public virtual DbSet<RossPowers> RossPowers { get; set; }
        public virtual DbSet<RossUsers> RossUsers { get; set; }
        public virtual DbSet<UpdateLogs> UpdateLogs { get; set; }
        public virtual DbSet<RossConfig> RossConfig { get; set; }
        public virtual DbSet<PartDegs> PartDegs { get; set; }
        public virtual DbSet<RossNewParts> RossNewParts { get; set; }

    }
}
