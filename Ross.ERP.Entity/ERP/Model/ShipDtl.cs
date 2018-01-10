namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.ShipDtl")]
    public partial class ShipDtl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShipDtl()
        {
            ShipDtlInfo = new HashSet<ShipDtlInfo>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PackNum { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PackLine { get; set; }

        public int OrderNum { get; set; }

        public int OrderLine { get; set; }

        public int OrderRelNum { get; set; }

        [Required]
        [StringLength(8)]
        public string LineType { get; set; }

        public decimal OurInventoryShipQty { get; set; }

        public decimal OurJobShipQty { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum { get; set; }

        public int Packages { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        public string LineDesc { get; set; }

        [Required]
        [StringLength(6)]
        public string IUM { get; set; }

        [Required]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        [Required]
        public string ShipComment { get; set; }

        public bool ShipCmpl { get; set; }

        [Required]
        [StringLength(8)]
        public string WarehouseCode { get; set; }

        [Required]
        [StringLength(10)]
        public string BinNum { get; set; }

        public bool UpdatedInventory { get; set; }

        [Required]
        [StringLength(50)]
        public string XPartNum { get; set; }

        [Required]
        [StringLength(12)]
        public string XRevisionNum { get; set; }

        public int ShpConNum { get; set; }

        public bool TMBilling { get; set; }

        public bool Invoiced { get; set; }

        [Required]
        [StringLength(6)]
        public string WUM { get; set; }

        [Required]
        [StringLength(30)]
        public string LotNum { get; set; }

        [Required]
        [StringLength(6)]
        public string DimCode { get; set; }

        [Required]
        [StringLength(6)]
        public string DUM { get; set; }

        public decimal DimConvFactor { get; set; }

        [Required]
        public string InvoiceComment { get; set; }

        [Required]
        [StringLength(8)]
        public string WarrantyCode { get; set; }

        public int CustNum { get; set; }

        [Required]
        [StringLength(14)]
        public string ShipToNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EffectiveDate { get; set; }

        public int MaterialDuration { get; set; }

        public int LaborDuration { get; set; }

        public int MiscDuration { get; set; }

        [Required]
        [StringLength(8)]
        public string MaterialMod { get; set; }

        [Required]
        [StringLength(8)]
        public string LaborMod { get; set; }

        [Required]
        [StringLength(8)]
        public string MiscMod { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MaterialExpiration { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LaborExpiration { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MiscExpiration { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastExpiration { get; set; }

        [Required]
        public string WarrantyComment { get; set; }

        public int ContractNum { get; set; }

        [Required]
        [StringLength(8)]
        public string ContractCode { get; set; }

        public bool Onsite { get; set; }

        public bool MatCovered { get; set; }

        public bool LabCovered { get; set; }

        public bool MiscCovered { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        public bool ReadyToInvoice { get; set; }

        public decimal SellingInventoryShipQty { get; set; }

        public decimal SellingJobShipQty { get; set; }

        public decimal SellingFactor { get; set; }

        [Required]
        [StringLength(6)]
        public string SalesUM { get; set; }

        public decimal TotalNetWeight { get; set; }

        [Required]
        [StringLength(8)]
        public string WIPWarehouseCode { get; set; }

        [Required]
        [StringLength(10)]
        public string WIPBinNum { get; set; }

        [Required]
        [StringLength(1)]
        public string SellingFactorDirection { get; set; }

        [Required]
        public string HeaderShipComment { get; set; }

        public int KitParentLine { get; set; }

        [Required]
        [StringLength(75)]
        public string ChangedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ChangeDate { get; set; }

        public int ChangeTime { get; set; }

        [Required]
        [StringLength(6)]
        public string InventoryShipUOM { get; set; }

        [Required]
        [StringLength(6)]
        public string JobShipUOM { get; set; }

        public bool TrackSerialNum { get; set; }

        [Required]
        [StringLength(30)]
        public string JobLotNum { get; set; }

        [Required]
        [StringLength(8)]
        public string BinType { get; set; }

        public bool NotCompliant { get; set; }

        [Required]
        public string ComplianceMsg { get; set; }

        public decimal DiscountPercent { get; set; }

        [Required]
        [StringLength(2)]
        public string PricePerCode { get; set; }

        public decimal Discount { get; set; }

        public decimal DocDiscount { get; set; }

        public decimal Rpt1Discount { get; set; }

        public decimal Rpt2Discount { get; set; }

        public decimal Rpt3Discount { get; set; }

        public decimal ExtPrice { get; set; }

        public decimal DocExtPrice { get; set; }

        public decimal Rpt1ExtPrice { get; set; }

        public decimal Rpt2ExtPrice { get; set; }

        public decimal Rpt3ExtPrice { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal DocUnitPrice { get; set; }

        public decimal Rpt1UnitPrice { get; set; }

        public decimal Rpt2UnitPrice { get; set; }

        public decimal Rpt3UnitPrice { get; set; }

        public decimal PickedAutoAllocatedQty { get; set; }

        public int ShipToCustNum { get; set; }

        public decimal InDiscount { get; set; }

        public decimal DocInDiscount { get; set; }

        public decimal Rpt1InDiscount { get; set; }

        public decimal Rpt2InDiscount { get; set; }

        public decimal Rpt3InDiscount { get; set; }

        public decimal InExtPrice { get; set; }

        public decimal DocInExtPrice { get; set; }

        public decimal Rpt1InExtPrice { get; set; }

        public decimal Rpt2InExtPrice { get; set; }

        public decimal Rpt3InExtPrice { get; set; }

        public decimal InUnitPrice { get; set; }

        public decimal DocInUnitPrice { get; set; }

        public decimal Rpt1InUnitPrice { get; set; }

        public decimal Rpt2InUnitPrice { get; set; }

        public decimal Rpt3InUnitPrice { get; set; }

        public bool InPrice { get; set; }

        public int Obs10_PkgNum { get; set; }

        public int Obs10_PkgLine { get; set; }

        public int MFCustNum { get; set; }

        [Required]
        [StringLength(14)]
        public string MFShipToNum { get; set; }

        public bool UseOTMF { get; set; }

        [Required]
        [StringLength(50)]
        public string OTMFName { get; set; }

        [Required]
        [StringLength(50)]
        public string OTMFAddress1 { get; set; }

        [Required]
        [StringLength(50)]
        public string OTMFAddress2 { get; set; }

        [Required]
        [StringLength(50)]
        public string OTMFAddress3 { get; set; }

        [Required]
        [StringLength(50)]
        public string OTMFCity { get; set; }

        [Required]
        [StringLength(50)]
        public string OTMFState { get; set; }

        [Required]
        [StringLength(10)]
        public string OTMFZIP { get; set; }

        [Required]
        [StringLength(50)]
        public string OTMFContact { get; set; }

        [Required]
        [StringLength(20)]
        public string OTMFFaxNum { get; set; }

        [Required]
        [StringLength(20)]
        public string OTMFPhoneNum { get; set; }

        public int OTMFCountryNum { get; set; }

        public int RenewalNbr { get; set; }

        public bool ShipOvers { get; set; }

        public decimal AllowedOvers { get; set; }

        public decimal AllowedUnders { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }

        public decimal NotAllocatedQty { get; set; }

        [Required]
        [StringLength(12)]
        public string PCID { get; set; }

        public long PCIDItemSeq { get; set; }

        public int PCIDParentLine { get; set; }

        [Required]
        [StringLength(30)]
        public string DockingStation { get; set; }

        public bool UseShipDtlInfo { get; set; }

        [Required]
        [StringLength(50)]
        public string PkgCodePartNum { get; set; }

        [Required]
        [StringLength(50)]
        public string CustContainerPartNum { get; set; }

        [Required]
        [StringLength(12)]
        public string LabelType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipDtlInfo> ShipDtlInfo { get; set; }
    }
}
