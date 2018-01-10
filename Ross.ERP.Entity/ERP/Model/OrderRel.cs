namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.OrderRel")]
    public partial class OrderRel
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderNum { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderLine { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderRelNum { get; set; }

        [Required]
        [StringLength(8)]
        public string LineType { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReqDate { get; set; }

        public decimal OurReqQty { get; set; }

        [Required]
        [StringLength(14)]
        public string ShipToNum { get; set; }

        [Required]
        [StringLength(4)]
        public string ShipViaCode { get; set; }

        public bool OpenRelease { get; set; }

        public bool FirmRelease { get; set; }

        public bool Make { get; set; }

        public decimal OurJobQty { get; set; }

        public decimal OurJobShippedQty { get; set; }

        public bool VoidRelease { get; set; }

        public decimal OurStockQty { get; set; }

        [Required]
        [StringLength(8)]
        public string WarehouseCode { get; set; }

        public decimal OurStockShippedQty { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        [Required]
        [StringLength(3)]
        public string TaxExempt { get; set; }

        public int ShpConNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NeedByDate { get; set; }

        [Required]
        [StringLength(30)]
        public string Reference { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        public decimal SellingReqQty { get; set; }

        public decimal SellingJobQty { get; set; }

        public decimal SellingJobShippedQty { get; set; }

        public decimal SellingStockQty { get; set; }

        public decimal SellingStockShippedQty { get; set; }

        public bool SelectForPicking { get; set; }

        [Required]
        [StringLength(8)]
        public string StagingWarehouseCode { get; set; }

        [Required]
        [StringLength(10)]
        public string StagingBinNum { get; set; }

        [Required]
        [StringLength(2)]
        public string PickError { get; set; }

        public decimal CumeQty { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CumeDate { get; set; }

        public bool Linked { get; set; }

        public int ICPONum { get; set; }

        public int ICPOLine { get; set; }

        public int ICPORelNum { get; set; }

        [Required]
        [StringLength(8)]
        public string ExtCompany { get; set; }

        [Required]
        [StringLength(30)]
        public string ScheduleNumber { get; set; }

        [Required]
        [StringLength(14)]
        public string MarkForNum { get; set; }

        [Required]
        [StringLength(50)]
        public string DropShipName { get; set; }

        [Required]
        [StringLength(30)]
        public string RAN { get; set; }

        [Required]
        [StringLength(30)]
        public string DemandReference { get; set; }

        public bool DemandSchedRejected { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DatePickTicketPrinted { get; set; }

        public bool ResDelivery { get; set; }

        public bool SatDelivery { get; set; }

        public bool SatPickup { get; set; }

        public bool VerbalConf { get; set; }

        public bool Hazmat { get; set; }

        public bool DocOnly { get; set; }

        [Required]
        [StringLength(500)]
        public string RefNotes { get; set; }

        public bool ApplyChrg { get; set; }

        public decimal ChrgAmount { get; set; }

        public bool COD { get; set; }

        public bool CODFreight { get; set; }

        public bool CODCheck { get; set; }

        public decimal CODAmount { get; set; }

        [Required]
        [StringLength(8)]
        public string GroundType { get; set; }

        public bool NotifyFlag { get; set; }

        [Required]
        [StringLength(500)]
        public string NotifyEMail { get; set; }

        public bool DeclaredIns { get; set; }

        public decimal DeclaredAmt { get; set; }

        public bool ServSatDelivery { get; set; }

        public bool ServSatPickup { get; set; }

        public bool ServSignature { get; set; }

        public bool ServAlert { get; set; }

        public bool ServPOD { get; set; }

        public bool ServAOD { get; set; }

        public bool ServHomeDel { get; set; }

        [Required]
        [StringLength(8)]
        public string DeliveryType { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ServDeliveryDate { get; set; }

        [Required]
        [StringLength(20)]
        public string ServPhone { get; set; }

        [Required]
        [StringLength(100)]
        public string ServInstruct { get; set; }

        public bool ServRelease { get; set; }

        [Required]
        [StringLength(50)]
        public string ServAuthNum { get; set; }

        [Required]
        [StringLength(50)]
        public string ServRef1 { get; set; }

        [Required]
        [StringLength(50)]
        public string ServRef2 { get; set; }

        [Required]
        [StringLength(50)]
        public string ServRef3 { get; set; }

        [Required]
        [StringLength(50)]
        public string ServRef4 { get; set; }

        [Required]
        [StringLength(50)]
        public string ServRef5 { get; set; }

        public bool OverrideCarrier { get; set; }

        public bool OverrideService { get; set; }

        [Required]
        [StringLength(30)]
        public string DockingStation { get; set; }

        [Required]
        [StringLength(30)]
        public string Location { get; set; }

        [Required]
        [StringLength(30)]
        public string TransportID { get; set; }

        public int ShipbyTime { get; set; }

        [Required]
        [StringLength(75)]
        public string ChangedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ChangeDate { get; set; }

        public int ChangeTime { get; set; }

        public bool TaxConnectCalc { get; set; }

        public bool GetDfltTaxIds { get; set; }

        [Required]
        [StringLength(4)]
        public string TaxRegionCode { get; set; }

        public bool UseOTS { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSName { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSAddress1 { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSAddress2 { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSAddress3 { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSCity { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSState { get; set; }

        [Required]
        [StringLength(10)]
        public string OTSZIP { get; set; }

        [Required]
        [StringLength(20)]
        public string OTSResaleID { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSContact { get; set; }

        [Required]
        [StringLength(20)]
        public string OTSFaxNum { get; set; }

        [Required]
        [StringLength(20)]
        public string OTSPhoneNum { get; set; }

        public int OTSCountryNum { get; set; }

        [Required]
        [StringLength(50)]
        public string SubShipTo { get; set; }

        [Required]
        [StringLength(50)]
        public string ShipRouting { get; set; }

        public bool BuyToOrder { get; set; }

        public int VendorNum { get; set; }

        [Required]
        [StringLength(4)]
        public string PurPoint { get; set; }

        public bool DropShip { get; set; }

        public int PONum { get; set; }

        public int POLine { get; set; }

        public int PORelNum { get; set; }

        public bool OpenOrder { get; set; }

        [Required]
        [StringLength(2)]
        public string OTSSaveAs { get; set; }

        [Required]
        [StringLength(10)]
        public string OTSSaveCustID { get; set; }

        public bool OTSCustSaved { get; set; }

        public int ShipToCustNum { get; set; }

        [Required]
        [StringLength(6)]
        public string IUM { get; set; }

        [Required]
        [StringLength(6)]
        public string SalesUM { get; set; }

        [Required]
        [StringLength(20)]
        public string RelStatus { get; set; }

        [Required]
        public string ComplianceMsg { get; set; }

        public decimal PrevSellQty { get; set; }

        [Required]
        [StringLength(50)]
        public string PrevPartNum { get; set; }

        [Required]
        [StringLength(50)]
        public string PrevXPartNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PrevNeedByDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PrevReqDate { get; set; }

        [Required]
        [StringLength(14)]
        public string PrevShipToNum { get; set; }

        public int MFCustNum { get; set; }

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

        [Required]
        [StringLength(8)]
        public string ECCPlant { get; set; }

        [Required]
        [StringLength(20)]
        public string WIOrderLine { get; set; }

        [Required]
        [StringLength(20)]
        public string WIOrder { get; set; }

        [Required]
        [StringLength(256)]
        public string WebSKU { get; set; }

        public bool ShipOvers { get; set; }

        public decimal WIItemPrice { get; set; }

        public decimal WIItemShipCost { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }

        [Required]
        [StringLength(10)]
        public string EntityUseCode { get; set; }

        [Required]
        [StringLength(12)]
        public string PhaseID { get; set; }

        [Required]
        [StringLength(14)]
        public string OTSShipToNum { get; set; }

        public bool WasRecInvoiced { get; set; }

        [Required]
        [StringLength(50)]
        public string ContractID { get; set; }

        public bool LinkToContract { get; set; }

        public bool ReadyToFulfill { get; set; }
    }
}
