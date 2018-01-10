namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SyncHistory")]
    public partial class SyncHistory
    {
        public int ID { get; set; }

        public DateTime SyncTime { get; set; }

        [StringLength(10)]
        public string UserID { get; set; }

        [StringLength(10)]
        public string Company { get; set; }

        [StringLength(50)]
        public string PartNum { get; set; }
        public int RevNum { get; set; }
        [StringLength(10)]
        public string RevName { get; set; }
    }
}
