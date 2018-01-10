namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.ShipHead")]
    public partial class ShipHead
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PackNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ShipDate { get; set; }

        [Required]
        [StringLength(4)]
        public string ShipViaCode { get; set; }

        [Required]
        [StringLength(75)]
        public string ShipPerson { get; set; }

        [Required]
        [StringLength(75)]
        public string EntryPerson { get; set; }

        [Required]
        [StringLength(15)]
        public string ShipLog { get; set; }

        [Required]
        public string LabelComment { get; set; }

        [Required]
        public string ShipComment { get; set; }

        public bool Invoiced { get; set; }

        [Required]
        [StringLength(14)]
        public string ShipToNum { get; set; }

        public bool ReadyToInvoice { get; set; }

        public int CustNum { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        [Required]
        [StringLength(50)]
        public string TrackingNumber { get; set; }

        [Required]
        [StringLength(30)]
        public string LegalNumber { get; set; }

        public bool Voided { get; set; }

        public bool ExternalDeliveryNote { get; set; }

        [Required]
        [StringLength(40)]
        public string ExternalID { get; set; }

        public bool ICReceived { get; set; }

        [Required]
        [StringLength(20)]
        public string XRefPackNum { get; set; }

        public int BTCustNum { get; set; }

        public int BTConNum { get; set; }

        [Required]
        [StringLength(12)]
        public string ShipStatus { get; set; }

        [Required]
        [StringLength(20)]
        public string ShipGroup { get; set; }

        [Required]
        [StringLength(50)]
        public string PkgCode { get; set; }

        [Required]
        [StringLength(8)]
        public string PkgClass { get; set; }

        public decimal Weight { get; set; }

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

        [Required]
        [StringLength(50)]
        public string MFTransNum { get; set; }

        [Required]
        [StringLength(50)]
        public string MFCallTag { get; set; }

        [Required]
        [StringLength(50)]
        public string MFPickupNum { get; set; }

        public decimal MFDiscFreight { get; set; }

        [Required]
        [StringLength(30)]
        public string MFTemplate { get; set; }

        public bool MFUse3B { get; set; }

        [Required]
        [StringLength(50)]
        public string MF3BAccount { get; set; }

        public decimal MFDimWeight { get; set; }

        [Required]
        [StringLength(30)]
        public string MFZone { get; set; }

        public decimal MFFreightAmt { get; set; }

        public decimal MFOtherAmt { get; set; }

        public bool MFOversized { get; set; }

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

        public int BOLNum { get; set; }

        public int BOLLine { get; set; }

        public bool CommercialInvoice { get; set; }

        public bool ShipExprtDeclartn { get; set; }

        public bool CertOfOrigin { get; set; }

        public bool LetterOfInstr { get; set; }

        public bool HazardousShipment { get; set; }

        public bool IntrntlShip { get; set; }

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

        [Required]
        [StringLength(75)]
        public string ChangedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ChangeDate { get; set; }

        public int ChangeTime { get; set; }

        [Required]
        [StringLength(8)]
        public string FFID { get; set; }

        public bool IndividualPackIDs { get; set; }

        [Required]
        [StringLength(50)]
        public string FFAddress3 { get; set; }

        public int DeliveryConf { get; set; }

        public bool AddlHdlgFlag { get; set; }

        public bool NonStdPkg { get; set; }

        public int FFCountryNum { get; set; }

        [Required]
        [StringLength(50)]
        public string PayBTAddress3 { get; set; }

        public int PayBTCountryNum { get; set; }

        [Required]
        [StringLength(20)]
        public string PayBTPhone { get; set; }

        [Required]
        [StringLength(50)]
        public string WayBillNbr { get; set; }

        [Required]
        [StringLength(4)]
        public string FreightedShipViaCode { get; set; }

        public bool UPSQuantumView { get; set; }

        [Required]
        [StringLength(50)]
        public string UPSQVShipFromName { get; set; }

        [Required]
        public string UPSQVMemo { get; set; }

        public decimal PkgLength { get; set; }

        public decimal PkgWidth { get; set; }

        public decimal PkgHeight { get; set; }

        public bool EDIReady { get; set; }

        public bool PhantomPack { get; set; }

        public int ReplicatedFrom { get; set; }

        [Required]
        [StringLength(30)]
        public string ReplicatedStat { get; set; }

        [Required]
        [StringLength(6)]
        public string PkgSizeUOM { get; set; }

        [Required]
        [StringLength(6)]
        public string WeightUOM { get; set; }

        public bool UseOTS { get; set; }

        [Required]
        [StringLength(12)]
        public string TranDocTypeID { get; set; }

        public bool DocumentPrinted { get; set; }

        public int OTSOrderNum { get; set; }

        public bool TaxCalculated { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TaxCalcDate { get; set; }

        [Required]
        [StringLength(4)]
        public string CurrencyCode { get; set; }

        public decimal Rounding { get; set; }

        public decimal Rpt1Rounding { get; set; }

        public decimal Rpt2Rounding { get; set; }

        public decimal Rpt3Rounding { get; set; }

        public decimal DocRounding { get; set; }

        public decimal Rpt1TotalTax { get; set; }

        public decimal Rpt2TotalTax { get; set; }

        public decimal Rpt3TotalTax { get; set; }

        public decimal OrderAmt { get; set; }

        public decimal DocOrderAmt { get; set; }

        public decimal Rpt1OrderAmt { get; set; }

        public decimal Rpt2OrderAmt { get; set; }

        public decimal Rpt3OrderAmt { get; set; }

        [Required]
        [StringLength(4)]
        public string TaxRegionCode { get; set; }

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

        public decimal TotalTax { get; set; }

        public decimal DocTotalTax { get; set; }

        public decimal TotalDiscount { get; set; }

        public decimal Rpt1TotalDiscount { get; set; }

        public decimal Rpt2TotalDiscount { get; set; }

        public decimal Rpt3TotalDiscount { get; set; }

        public decimal DocTotalDiscount { get; set; }

        public int ShipToCustNum { get; set; }

        [Required]
        [StringLength(6)]
        public string DeviceUOM { get; set; }

        [Required]
        [StringLength(6)]
        public string ManifestSizeUOM { get; set; }

        [Required]
        [StringLength(6)]
        public string ManifestWtUOM { get; set; }

        public decimal ManifestWeight { get; set; }

        public decimal ManifestLength { get; set; }

        public decimal ManifestWidth { get; set; }

        public decimal ManifestHeight { get; set; }

        [Required]
        [StringLength(12)]
        public string RateGrpCode { get; set; }

        public bool InPrice { get; set; }

        public bool PBHoldNoInv { get; set; }

        public int Obs10_PkgNum { get; set; }

        public decimal ReconcileQty { get; set; }

        [Required]
        [StringLength(30)]
        public string ScheduleNumber { get; set; }

        public int CounterASN { get; set; }

        [Required]
        [StringLength(5)]
        public string OurBank { get; set; }

        public bool ERSOrder { get; set; }

        public bool AutoPrintReady { get; set; }

        public bool ShipOvers { get; set; }

        public bool WIPackSlipCreated { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }

        [Required]
        [StringLength(14)]
        public string AGAuthorizationCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AGAuthorizationDate { get; set; }

        [Required]
        [StringLength(20)]
        public string AGCarrierCUIT { get; set; }

        public bool AGCOTMark { get; set; }

        [Required]
        [StringLength(1)]
        public string AGDocumentLetter { get; set; }

        [Required]
        [StringLength(4)]
        public string AGInvoicingPoint { get; set; }

        [Required]
        [StringLength(8)]
        public string AGLegalNumber { get; set; }

        [Required]
        [StringLength(1)]
        public string AGPrintingControlType { get; set; }

        [Required]
        [StringLength(10)]
        public string AGTrackLicense { get; set; }

        [Required]
        [StringLength(8)]
        public string DispatchReason { get; set; }

        [Required]
        [StringLength(3)]
        public string AGShippingWay { get; set; }

        [Required]
        [StringLength(20)]
        public string OurSupplierCode { get; set; }

        public DateTime? ASNPrintedDate { get; set; }

        [Required]
        [StringLength(14)]
        public string EDIShipToNum { get; set; }
    }
}
