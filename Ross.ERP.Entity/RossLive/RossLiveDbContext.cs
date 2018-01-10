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

    }
}