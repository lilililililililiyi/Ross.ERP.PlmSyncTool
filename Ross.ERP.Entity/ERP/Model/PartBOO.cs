namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.PartBOO")]
    public partial class PartBOO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string EndPartNum { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string EndRevision { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BomSequence { get; set; }

        public int BomLevel { get; set; }

        [Required]
        [StringLength(50)]
        public string MtlPartNum { get; set; }

        [Required]
        [StringLength(12)]
        public string MtlRevision { get; set; }

        [Required]
        public string PartDescription { get; set; }

        public decimal QtyPer { get; set; }

        public decimal QtyRequired { get; set; }

        [Required]
        [StringLength(3)]
        public string BOMType { get; set; }

        public bool Approved { get; set; }

        public int OprSeq { get; set; }

        [Required]
        [StringLength(8)]
        public string OpCode { get; set; }

        public decimal EstSetHours { get; set; }

        public decimal EstProdHours { get; set; }

        [Required]
        [StringLength(50)]
        public string IndMtlPartNum { get; set; }

        [Required]
        [StringLength(5)]
        public string ResourceGrpID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid SysRowID { get; set; }
    }
}
