namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.PartClassPlt")]
    public partial class PartClassPlt
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string ClassID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(8)]
        public string OwnerPlant { get; set; }

        public int ReceiveTime { get; set; }

        public int PlanTimeFence { get; set; }

        public int ReschedOutDelta { get; set; }

        public int ReschedInDelta { get; set; }

        public bool GlobalPartClassPlt { get; set; }

        public bool GlobalLock { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }
    }
}
