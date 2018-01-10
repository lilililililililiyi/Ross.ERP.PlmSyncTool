namespace Ross.ERP.Entity.RossLive.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RossPowers
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string PowerIndex { get; set; }

        [StringLength(50)]
        public string PowerName { get; set; }
    }
}
