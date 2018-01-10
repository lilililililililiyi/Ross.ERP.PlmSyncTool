namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.PartMtlInsp")]
    public partial class PartMtlInsp
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
        public int MtlSeq { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlanSeq { get; set; }

        [Required]
        [StringLength(50)]
        public string InspPlanPartNum { get; set; }

        [Required]
        [StringLength(20)]
        public string SpecID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }
    }
}
