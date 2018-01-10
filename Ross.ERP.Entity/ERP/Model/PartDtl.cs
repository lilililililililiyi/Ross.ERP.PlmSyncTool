namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.PartDtl")]
    public partial class PartDtl
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string Type { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool RequirementFlag { get; set; }

        public decimal Quantity { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum { get; set; }

        public int AssemblySeq { get; set; }

        public int JobSeq { get; set; }

        public int OrderNum { get; set; }

        public int OrderLine { get; set; }

        public int OrderRelNum { get; set; }

        public int PONum { get; set; }

        public int POLine { get; set; }

        public int PORelNum { get; set; }

        [Required]
        public string PartDescription { get; set; }

        [Required]
        [StringLength(6)]
        public string IUM { get; set; }

        [Required]
        [StringLength(2)]
        public string SourceFile { get; set; }

        public int CustNum { get; set; }

        public bool StockTrans { get; set; }

        public bool FirmRelease { get; set; }

        [Required]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        public int TargetOrderNum { get; set; }

        public int TargetOrderLine { get; set; }

        public int TargetOrderRelNum { get; set; }

        [Required]
        [StringLength(8)]
        public string TargetWarehouseCode { get; set; }

        [Required]
        [StringLength(14)]
        public string TargetJobNum { get; set; }

        public int TargetAssemblySeq { get; set; }

        public int TargetMtlSeq { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        public int InvLinkNum { get; set; }

        public int PlantTranNum { get; set; }

        public int TFOrdLine { get; set; }

        [Required]
        [StringLength(14)]
        public string TFOrdNum { get; set; }

        [Required]
        [StringLength(14)]
        public string TFLineNum { get; set; }

        [Required]
        [StringLength(20)]
        public string SourceDBRecid { get; set; }

        public bool NonPart { get; set; }

        public bool BOMChanged { get; set; }

        public decimal BaseQty { get; set; }

        [Required]
        [StringLength(6)]
        public string BaseQtyUOM { get; set; }

        public decimal InvtyQty { get; set; }

        [Required]
        [StringLength(6)]
        public string InvtyQtyUOM { get; set; }

        public bool JobFirm { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PartDtlSeq { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid SysRowID { get; set; }

        [Required]
        [StringLength(50)]
        public string ContractID { get; set; }
    }
}
