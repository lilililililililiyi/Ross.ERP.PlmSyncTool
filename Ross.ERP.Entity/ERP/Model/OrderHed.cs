namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.OrderHed")]
    public partial class OrderHed
    {
        public bool OpenOrder { get; set; }

        public bool VoidOrder { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderNum { get; set; }

        public int CustNum { get; set; }

        [Required]
        [StringLength(50)]
        public string PONum { get; set; }

        public bool OrderHeld { get; set; }

        [Required]
        [StringLength(75)]
        public string EntryPerson { get; set; }

        [Required]
        [StringLength(14)]
        public string ShipToNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RequestDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OrderDate { get; set; }

        [Required]
        [StringLength(15)]
        public string FOB { get; set; }

        [Required]
        [StringLength(4)]
        public string ShipViaCode { get; set; }

        [Required]
        [StringLength(4)]
        public string TermsCode { get; set; }

        public decimal DiscountPercent { get; set; }

        public int PrcConNum { get; set; }

        public int ShpConNum { get; set; }

        [Required]
        public string SalesRepList { get; set; }

        [Required]
        public string OrderComment { get; set; }

        [Required]
        public string ShipComment { get; set; }

        [Required]
        public string InvoiceComment { get; set; }

        [Required]
        public string PickListComment { get; set; }

        public decimal DepositBal { get; set; }

        public decimal DocDepositBal { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NeedByDate { get; set; }

        public bool CreditOverride { get; set; }

        [Required]
        [StringLength(75)]
        public string CreditOverrideUserID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreditOverrideDate { get; set; }

        [Required]
        [StringLength(8)]
        public string CreditOverrideTime { get; set; }

        public decimal CreditOverrideLimit { get; set; }

        public bool SndAlrtShp { get; set; }

        public decimal ExchangeRate { get; set; }

        [Required]
        [StringLength(4)]
        public string CurrencyCode { get; set; }

        public bool LockRate { get; set; }

        [Required]
        [StringLength(54)]
        public string CardMemberName { get; set; }

        [Required]
        [StringLength(20)]
        public string CardNumber { get; set; }

        [Required]
        [StringLength(4)]
        public string CardType { get; set; }

        public int ExpirationMonth { get; set; }

        public int ExpirationYear { get; set; }

        [Required]
        [StringLength(4)]
        public string CardID { get; set; }

        [Required]
        [StringLength(17)]
        public string CardmemberReference { get; set; }

        [Required]
        [StringLength(6)]
        public string AllocPriorityCode { get; set; }

        [Required]
        [StringLength(6)]
        public string ReservePriorityCode { get; set; }

        public bool ShipOrderComplete { get; set; }

        public bool WebOrder { get; set; }

        [Required]
        [StringLength(99)]
        public string CCApprovalNum { get; set; }

        public bool EDIOrder { get; set; }

        public bool EDIAck { get; set; }

        public bool Linked { get; set; }

        public int ICPONum { get; set; }

        [Required]
        [StringLength(8)]
        public string ExtCompany { get; set; }

        [Required]
        [StringLength(40)]
        public string WebEntryPerson { get; set; }

        public bool AckEmailSent { get; set; }

        public bool ApplyOrderBasedDisc { get; set; }

        public bool AutoOrderBasedDisc { get; set; }

        [Required]
        [StringLength(2)]
        public string EntryMethod { get; set; }

        public int HDCaseNum { get; set; }

        public bool CounterSale { get; set; }

        public bool CreateInvoice { get; set; }

        public bool CreatePackingSlip { get; set; }

        public bool LockQty { get; set; }

        [Required]
        [StringLength(256)]
        public string ProcessCard { get; set; }

        public decimal CCAmount { get; set; }

        public decimal CCFreight { get; set; }

        public decimal CCTax { get; set; }

        public decimal CCTotal { get; set; }

        public decimal CCDocAmount { get; set; }

        public decimal CCDocFreight { get; set; }

        public decimal CCDocTax { get; set; }

        public decimal CCDocTotal { get; set; }

        [Required]
        [StringLength(50)]
        public string CCStreetAddr { get; set; }

        [Required]
        [StringLength(10)]
        public string CCZip { get; set; }

        public int BTCustNum { get; set; }

        public int BTConNum { get; set; }

        public decimal RepRate4 { get; set; }

        public decimal RepRate5 { get; set; }

        public int RepSplit1 { get; set; }

        public int RepSplit2 { get; set; }

        public int RepSplit3 { get; set; }

        public int RepSplit4 { get; set; }

        public int RepSplit5 { get; set; }

        public decimal RepRate1 { get; set; }

        public decimal RepRate2 { get; set; }

        public decimal RepRate3 { get; set; }

        public int OutboundSalesDocCtr { get; set; }

        public int OutboundShipDocsCtr { get; set; }

        public int DemandContractNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DoNotShipBeforeDate { get; set; }

        public bool ResDelivery { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DoNotShipAfterDate { get; set; }

        public bool SatDelivery { get; set; }

        public bool SatPickup { get; set; }

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

        [Column(TypeName = "date")]
        public DateTime? CancelAfterDate { get; set; }

        public bool DemandRejected { get; set; }

        public bool OverrideCarrier { get; set; }

        public bool OverrideService { get; set; }

        public bool CreditCardOrder { get; set; }

        public int DemandHeadSeq { get; set; }

        [Required]
        [StringLength(8)]
        public string PayFlag { get; set; }

        [Required]
        [StringLength(50)]
        public string PayAccount { get; set; }

        [Required]
        [StringLength(50)]
        public string PayBTAddress1 { get; set; }

        [Required]
        [StringLength(50)]
        public string PayBTAddress2 { get; set; }

        [Required]
        [StringLength(50)]
        public string PayBTCity { get; set; }

        [Required]
        [StringLength(50)]
        public string PayBTState { get; set; }

        [Required]
        [StringLength(10)]
        public string PayBTZip { get; set; }

        [Required]
        [StringLength(50)]
        public string PayBTCountry { get; set; }

        public bool DropShip { get; set; }

        public bool CommercialInvoice { get; set; }

        public bool ShipExprtDeclartn { get; set; }

        public bool CertOfOrigin { get; set; }

        public bool LetterOfInstr { get; set; }

        [Required]
        [StringLength(8)]
        public string FFID { get; set; }

        [Required]
        [StringLength(50)]
        public string FFAddress1 { get; set; }

        [Required]
        [StringLength(50)]
        public string FFAddress2 { get; set; }

        [Required]
        [StringLength(50)]
        public string FFCity { get; set; }

        [Required]
        [StringLength(50)]
        public string FFState { get; set; }

        [Required]
        [StringLength(10)]
        public string FFZip { get; set; }

        [Required]
        [StringLength(50)]
        public string FFCountry { get; set; }

        [Required]
        [StringLength(50)]
        public string FFContact { get; set; }

        [Required]
        [StringLength(50)]
        public string FFCompName { get; set; }

        [Required]
        [StringLength(20)]
        public string FFPhoneNum { get; set; }

        public bool IntrntlShip { get; set; }

        [Required]
        [StringLength(75)]
        public string ChangedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ChangeDate { get; set; }

        public int ChangeTime { get; set; }

        public bool AutoPrintReady { get; set; }

        public bool EDIReady { get; set; }

        public bool IndividualPackIDs { get; set; }

        [Required]
        [StringLength(50)]
        public string FFAddress3 { get; set; }

        public int DeliveryConf { get; set; }

        public bool AddlHdlgFlag { get; set; }

        public bool NonStdPkg { get; set; }

        public bool ServSignature { get; set; }

        public bool ServAlert { get; set; }

        public bool ServHomeDel { get; set; }

        [Required]
        [StringLength(8)]
        public string DeliveryType { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ServDeliveryDate { get; set; }

        [Required]
        [StringLength(100)]
        public string ServInstruct { get; set; }

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

        public int FFCountryNum { get; set; }

        [Required]
        [StringLength(20)]
        public string ServPhone { get; set; }

        public bool ServRelease { get; set; }

        [Required]
        [StringLength(50)]
        public string ServAuthNum { get; set; }

        [Required]
        [StringLength(50)]
        public string PayBTAddress3 { get; set; }

        public int PayBTCountryNum { get; set; }

        [Required]
        [StringLength(20)]
        public string PayBTPhone { get; set; }

        public bool UPSQuantumView { get; set; }

        [Required]
        [StringLength(50)]
        public string UPSQVShipFromName { get; set; }

        [Required]
        public string UPSQVMemo { get; set; }

        public bool ReadyToCalc { get; set; }

        public decimal TotalCharges { get; set; }

        public decimal TotalMisc { get; set; }

        public decimal TotalDiscount { get; set; }

        public decimal TotalComm { get; set; }

        public decimal TotalAdvBill { get; set; }

        public int TotalLines { get; set; }

        public int TotalReleases { get; set; }

        public int TotalRelDates { get; set; }

        public decimal DocTotalCharges { get; set; }

        public decimal DocTotalMisc { get; set; }

        public decimal DocTotalDiscount { get; set; }

        public decimal DocTotalComm { get; set; }

        public decimal TotalTax { get; set; }

        public decimal DocTotalTax { get; set; }

        public decimal DocTotalAdvBill { get; set; }

        public decimal TotalShipped { get; set; }

        public decimal TotalInvoiced { get; set; }

        public int TotalCommLines { get; set; }

        public decimal SRCommAmt1 { get; set; }

        public decimal SRCommAmt2 { get; set; }

        public decimal SRCommAmt3 { get; set; }

        public decimal SRCommAmt4 { get; set; }

        public decimal SRCommAmt5 { get; set; }

        public decimal SRCommableAmt1 { get; set; }

        public decimal SRCommableAmt2 { get; set; }

        public decimal SRCommableAmt3 { get; set; }

        public decimal SRCommableAmt4 { get; set; }

        public decimal SRCommableAmt5 { get; set; }

        public decimal Rounding { get; set; }

        public decimal Rpt1DepositBal { get; set; }

        public decimal DocRounding { get; set; }

        public decimal Rpt2DepositBal { get; set; }

        public decimal Rpt3DepositBal { get; set; }

        public decimal Rpt1TotalCharges { get; set; }

        public decimal Rpt2TotalCharges { get; set; }

        public decimal Rpt3TotalCharges { get; set; }

        public decimal Rpt1TotalAdvBill { get; set; }

        public decimal Rpt2TotalAdvBill { get; set; }

        public decimal Rpt3TotalAdvBill { get; set; }

        public decimal Rpt1TotalMisc { get; set; }

        public decimal Rpt2TotalMisc { get; set; }

        public decimal Rpt3TotalMisc { get; set; }

        public decimal Rpt1TotalDiscount { get; set; }

        public decimal Rpt2TotalDiscount { get; set; }

        public decimal Rpt3TotalDiscount { get; set; }

        public decimal Rpt1TotalComm { get; set; }

        public decimal Rpt2TotalComm { get; set; }

        public decimal Rpt3TotalComm { get; set; }

        public decimal Rpt1TotalTax { get; set; }

        public decimal Rpt2TotalTax { get; set; }

        public decimal Rpt1Rounding { get; set; }

        public decimal Rpt2Rounding { get; set; }

        public decimal Rpt3Rounding { get; set; }

        [Required]
        [StringLength(12)]
        public string RateGrpCode { get; set; }

        public decimal Rpt3TotalTax { get; set; }

        public decimal Rpt1CCAmount { get; set; }

        public decimal Rpt2CCAmount { get; set; }

        public decimal Rpt3CCAmount { get; set; }

        public decimal Rpt1CCFreight { get; set; }

        public decimal Rpt2CCFreight { get; set; }

        public decimal Rpt3CCFreight { get; set; }

        public decimal Rpt1CCTax { get; set; }

        public decimal Rpt2CCTax { get; set; }

        public decimal Rpt3CCTax { get; set; }

        public decimal Rpt1CCTotal { get; set; }

        public decimal Rpt2CCTotal { get; set; }

        public decimal Rpt3CCTotal { get; set; }

        public decimal OrderAmt { get; set; }

        public decimal DocOrderAmt { get; set; }

        public decimal Rpt1OrderAmt { get; set; }

        public decimal Rpt2OrderAmt { get; set; }

        public decimal Rpt3OrderAmt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TaxPoint { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TaxRateDate { get; set; }

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

        public decimal TotalWHTax { get; set; }

        public decimal DocTotalWHTax { get; set; }

        public decimal Rpt1TotalWHTax { get; set; }

        public decimal Rpt2TotalWHTax { get; set; }

        public decimal Rpt3TotalWHTax { get; set; }

        public decimal TotalSATax { get; set; }

        public decimal DocTotalSATax { get; set; }

        public decimal Rpt1TotalSATax { get; set; }

        public decimal Rpt2TotalSATax { get; set; }

        public decimal Rpt3TotalSATax { get; set; }

        [Required]
        [StringLength(2)]
        public string OTSSaveAs { get; set; }

        [Required]
        [StringLength(10)]
        public string OTSSaveCustID { get; set; }

        public bool OTSCustSaved { get; set; }

        public int ShipToCustNum { get; set; }

        [Required]
        [StringLength(20)]
        public string OrderStatus { get; set; }

        public bool HoldSetByDemand { get; set; }

        public bool InPrice { get; set; }

        public decimal InTotalCharges { get; set; }

        public decimal InTotalMisc { get; set; }

        public decimal InTotalDiscount { get; set; }

        public decimal DocInTotalCharges { get; set; }

        public decimal DocInTotalMisc { get; set; }

        public decimal DocInTotalDiscount { get; set; }

        public decimal Rpt1InTotalCharges { get; set; }

        public decimal Rpt2InTotalCharges { get; set; }

        public decimal Rpt3InTotalCharges { get; set; }

        public decimal Rpt1InTotalMisc { get; set; }

        public decimal Rpt2InTotalMisc { get; set; }

        public decimal Rpt3InTotalMisc { get; set; }

        public decimal Rpt1InTotalDiscount { get; set; }

        public decimal Rpt2InTotalDiscount { get; set; }

        public decimal Rpt3InTotalDiscount { get; set; }

        [Required]
        [StringLength(20)]
        public string ARLOCID { get; set; }

        [Required]
        [StringLength(5)]
        public string OurBank { get; set; }

        public bool ERSOrder { get; set; }

        public bool LOCHold { get; set; }

        [Required]
        [StringLength(4)]
        public string PSCurrCode { get; set; }

        [Required]
        [StringLength(4)]
        public string InvCurrCode { get; set; }

        [Required]
        [StringLength(30)]
        public string LegalNumber { get; set; }

        [Required]
        [StringLength(12)]
        public string TranDocTypeID { get; set; }

        [Required]
        [StringLength(20)]
        public string XRefContractNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? XRefContractDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DemandProcessDate { get; set; }

        public int DemandProcessTime { get; set; }

        [Required]
        [StringLength(30)]
        public string LastScheduleNumber { get; set; }

        [Required]
        [StringLength(25)]
        public string LastTCtrlNum { get; set; }

        [Required]
        [StringLength(25)]
        public string LastBatchNum { get; set; }

        [Required]
        [StringLength(50)]
        public string ECCOrderNum { get; set; }

        [Required]
        [StringLength(255)]
        public string ECCPONum { get; set; }

        [Required]
        [StringLength(100)]
        public string WIOrder { get; set; }

        [Required]
        [StringLength(50)]
        public string WIApplication { get; set; }

        [Required]
        [StringLength(50)]
        public string WIUsername { get; set; }

        [Required]
        [StringLength(75)]
        public string WIUserID { get; set; }

        public bool WICreditCardorder { get; set; }

        [Required]
        [StringLength(50)]
        public string OrderCSR { get; set; }

        [Required]
        [StringLength(30)]
        public string UserChar1 { get; set; }

        [Required]
        [StringLength(30)]
        public string UserChar2 { get; set; }

        [Required]
        [StringLength(30)]
        public string UserChar3 { get; set; }

        [Required]
        [StringLength(30)]
        public string UserChar4 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UserDate1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UserDate2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UserDate3 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UserDate4 { get; set; }

        public decimal UserDecimal1 { get; set; }

        public decimal UserDecimal2 { get; set; }

        public int UserInteger1 { get; set; }

        public int UserInteger2 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }

        public bool IsCSRSet { get; set; }

        [Required]
        [StringLength(4)]
        public string ECCPaymentMethod { get; set; }

        public bool AGUseGoodDefaultMark { get; set; }

        [Required]
        [StringLength(14)]
        public string OTSShipToNum { get; set; }

        [Required]
        public string ProFormaInvComment { get; set; }

        [Required]
        [StringLength(100)]
        public string ccToken { get; set; }

        public bool InvcOrderCmp { get; set; }

        public bool ReprintSOAck { get; set; }

        public int CounterSOAck { get; set; }

        [Required]
        [StringLength(8)]
        public string DispatchReason { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        public bool ReadyToFulfill { get; set; }

        public int ShipByTime { get; set; }

        public int TWFiscalYear { get; set; }

        [Required]
        [StringLength(8)]
        public string TWFiscalYearSuffix { get; set; }

        public int TWFiscalPeriod { get; set; }

        [Required]
        [StringLength(2)]
        public string TWGUIGroup { get; set; }

        [Required]
        [StringLength(8)]
        public string TWGUIRegNumSeller { get; set; }

        [Required]
        [StringLength(8)]
        public string TWGUIRegNumBuyer { get; set; }

        public decimal OrderOpenCredit { get; set; }

        public decimal ClosedNotShipped { get; set; }
    }
}
