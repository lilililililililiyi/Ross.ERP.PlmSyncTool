namespace Ross.ERP.Entity.RossLive.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RossUsers
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string UserID { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        public DateTime? LastLoginTime { get; set; }

        public string Powers { get; set; }

        [StringLength(50)]
        public string Depart { get; set; }
    }
}
