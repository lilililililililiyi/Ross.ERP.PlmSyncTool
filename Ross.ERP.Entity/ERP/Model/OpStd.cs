namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.OpStd")]
    public partial class OpStd
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string ResourceGrpID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(8)]
        public string OpCode { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(5)]
        public string OpStdID { get; set; }

        [Required]
        [StringLength(30)]
        public string Description { get; set; }

        public decimal SetupHours { get; set; }

        public decimal ProdStandard { get; set; }

        [Required]
        [StringLength(2)]
        public string StdFormat { get; set; }

        [Required]
        [StringLength(2)]
        public string StdBasis { get; set; }

        public decimal APSContainerSize { get; set; }

        [Required]
        [StringLength(8)]
        public string SetupGroup { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }
    }
}
