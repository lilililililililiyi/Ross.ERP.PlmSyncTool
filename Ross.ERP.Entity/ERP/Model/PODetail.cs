namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.PODetail")]
    public partial class PODetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        public bool OpenLine { get; set; }

        public bool VoidLine { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PONUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int POLine { get; set; }

        [Required]
        public string LineDesc { get; set; }

        [Required]
        [StringLength(6)]
        public string IUM { get; set; }

        public decimal UnitCost { get; set; }

        public decimal DocUnitCost { get; set; }

        public decimal OrderQty { get; set; }

        public decimal XOrderQty { get; set; }

        public bool Taxable { get; set; }

        [Required]
        [StringLength(6)]
        public string PUM { get; set; }

        [Required]
        [StringLength(2)]
        public string CostPerCode { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        [StringLength(50)]
        public string VenPartNum { get; set; }

        [Required]
        public string CommentText { get; set; }

        [Required]
        [StringLength(4)]
        public string ClassID { get; set; }

        [Required]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        public bool RcvInspectionReq { get; set; }

        public int VendorNum { get; set; }

        public decimal AdvancePayBal { get; set; }

        public decimal DocAdvancePayBal { get; set; }

        public bool Confirmed { get; set; }

        public bool DateChgReq { get; set; }

        public bool QtyChgReq { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNumChgReq { get; set; }

        [Required]
        [StringLength(12)]
        public string RevisionNumChgReq { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ConfirmDate { get; set; }

        [Required]
        [StringLength(8)]
        public string ConfirmVia { get; set; }

        public decimal PrcChgReq { get; set; }

        [Required]
        [StringLength(8)]
        public string PurchCode { get; set; }

        public int OrderNum { get; set; }

        public int OrderLine { get; set; }

        public bool Linked { get; set; }

        [Required]
        [StringLength(8)]
        public string ExtCompany { get; set; }

        [Required]
        [StringLength(8)]
        public string GlbCompany { get; set; }

        public bool ContractActive { get; set; }

        public decimal ContractQty { get; set; }

        public decimal ContractUnitCost { get; set; }

        public decimal ContractDocUnitCost { get; set; }

        public decimal Rpt1AdvancePayBal { get; set; }

        public decimal Rpt2AdvancePayBal { get; set; }

        public decimal Rpt3AdvancePayBal { get; set; }

        public decimal Rpt1UnitCost { get; set; }

        public decimal Rpt2UnitCost { get; set; }

        public decimal Rpt3UnitCost { get; set; }

        [Required]
        [StringLength(6)]
        public string ContractQtyUOM { get; set; }

        public decimal Rpt1ContractUnitCost { get; set; }

        public decimal Rpt2ContractUnitCost { get; set; }

        public decimal Rpt3ContractUnitCost { get; set; }

        public decimal BaseQty { get; set; }

        [Required]
        [StringLength(6)]
        public string BaseUOM { get; set; }

        public int BTOOrderNum { get; set; }

        public int BTOOrderLine { get; set; }

        [Required]
        [StringLength(1)]
        public string VendorPartOpts { get; set; }

        [Required]
        [StringLength(1)]
        public string MfgPartOpts { get; set; }

        [Required]
        [StringLength(1)]
        public string SubPartOpts { get; set; }

        public int MfgNum { get; set; }

        [Required]
        [StringLength(50)]
        public string MfgPartNum { get; set; }

        [Required]
        [StringLength(50)]
        public string SubPartNum { get; set; }

        [Required]
        [StringLength(1)]
        public string SubPartType { get; set; }

        public decimal ConfigUnitCost { get; set; }

        public decimal ConfigBaseUnitCost { get; set; }

        public bool ConvOverRide { get; set; }

        [Required]
        [StringLength(50)]
        public string BasePartNum { get; set; }

        [Required]
        [StringLength(12)]
        public string BaseRevisionNum { get; set; }

        [Required]
        [StringLength(50)]
        public string Direction { get; set; }

        [Required]
        [StringLength(50)]
        public string Per { get; set; }

        public bool MaintainPricingUnits { get; set; }

        public bool OverrideConversion { get; set; }

        public bool RowsManualFactor { get; set; }

        public bool KeepRowsManualFactorTmp { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ShipToSupplierDate { get; set; }

        public decimal Factor { get; set; }

        public decimal PricingQty { get; set; }

        public decimal PricingUnitPrice { get; set; }

        [Required]
        [StringLength(6)]
        public string UOM { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }

        public int GroupSeq { get; set; }

        public decimal DocPricingUnitPrice { get; set; }

        public bool OverridePriceList { get; set; }

        [Required]
        [StringLength(10)]
        public string QtyOption { get; set; }

        [Required]
        public string OrigComment { get; set; }

        [Required]
        public string SmartString { get; set; }

        public bool SmartStringProcessed { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }

        [Required]
        [StringLength(50)]
        public string ContractID { get; set; }

        public bool LinkToContract { get; set; }

        public decimal SelCurrPricingUnitPrice { get; set; }

        [Required]
        [StringLength(75)]
        public string ChangedBy { get; set; }

        public DateTime? ChangeDate { get; set; }

        public bool PCLinkRemoved { get; set; }

        [Required]
        [StringLength(10)]
        public string TaxCatID { get; set; }

        public bool NoTaxRecalc { get; set; }

        public decimal InUnitCost { get; set; }

        public decimal DocInUnitCost { get; set; }

        public decimal Rpt1InUnitCost { get; set; }

        public decimal Rpt2InUnitCost { get; set; }

        public decimal Rpt3InUnitCost { get; set; }

        public decimal InAdvancePayBal { get; set; }

        public decimal DocInAdvancePayBal { get; set; }

        public decimal Rpt1InAdvancePayBal { get; set; }

        public decimal Rpt2InAdvancePayBal { get; set; }

        public decimal Rpt3InAdvancePayBal { get; set; }

        public decimal InContractUnitCost { get; set; }

        public decimal DocInContractUnitCost { get; set; }

        public decimal Rpt1InContractUnitCost { get; set; }

        public decimal Rpt2InContractUnitCost { get; set; }

        public decimal Rpt3InContractUnitCost { get; set; }

        public decimal DocExtCost { get; set; }

        public decimal ExtCost { get; set; }

        public decimal Rpt1ExtCost { get; set; }

        public decimal Rpt2ExtCost { get; set; }

        public decimal Rpt3ExtCost { get; set; }

        public decimal DocMiscCost { get; set; }

        public decimal MiscCost { get; set; }

        public decimal Rpt1MiscCost { get; set; }

        public decimal Rpt2MiscCost { get; set; }

        public decimal Rpt3MiscCost { get; set; }
    }
}
