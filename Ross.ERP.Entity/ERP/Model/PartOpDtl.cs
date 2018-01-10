namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.PartOpDtl")]
    public partial class PartOpDtl
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OprSeq { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OpDtlSeq { get; set; }

        [Required]
        [StringLength(20)]
        public string CapabilityID { get; set; }

        [Required]
        [StringLength(8)]
        public string ResourceGrpID { get; set; }

        [Required]
        [StringLength(12)]
        public string ResourceID { get; set; }

        public decimal SetupHours { get; set; }

        public decimal ProdHours { get; set; }

        public int NumResources { get; set; }

        [Required]
        [StringLength(2)]
        public string SetupOrProd { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(12)]
        public string AltMethod { get; set; }

        public bool BaseMethodOverridden { get; set; }

        [Required]
        [StringLength(30)]
        public string OpDtlDesc { get; set; }

        [Required]
        [StringLength(12)]
        public string ParentAltMethod { get; set; }

        public int ParentOprSeq { get; set; }

        public int ParentOpDtlSeq { get; set; }

        public decimal ConcurrentCapacity { get; set; }

        public decimal DailyProdRate { get; set; }

        public decimal ProdCrewSize { get; set; }

        public decimal SetUpCrewSize { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }
    }
}
