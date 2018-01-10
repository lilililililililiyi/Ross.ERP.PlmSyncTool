namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.PartRevInspPlan")]
    public partial class PartRevInspPlan
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(12)]
        public string AltMethod { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SeqPlan { get; set; }

        [Required]
        [StringLength(50)]
        public string InspPlanPartNum { get; set; }

        [Required]
        [StringLength(20)]
        public string SpecID { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        public int SampleSize { get; set; }

        public decimal SampleSizePct { get; set; }

        public bool IsDefault { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }
    }
}
