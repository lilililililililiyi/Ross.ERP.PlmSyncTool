namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.Vendor")]
    public partial class Vendor
    {
        public bool Inactive { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Required]
        [StringLength(8)]
        public string VendorID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VendorNum { get; set; }

        [Required]
        [StringLength(50)]
        public string Address1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Address2 { get; set; }

        [Required]
        [StringLength(50)]
        public string Address3 { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string State { get; set; }

        [Required]
        [StringLength(10)]
        public string ZIP { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        [Required]
        [StringLength(20)]
        public string TaxPayerID { get; set; }

        [Required]
        [StringLength(4)]
        public string PurPoint { get; set; }

        [Required]
        [StringLength(4)]
        public string TermsCode { get; set; }

        [Required]
        [StringLength(4)]
        public string GroupCode { get; set; }

        public bool Print1099 { get; set; }

        public bool OneCheck { get; set; }

        public bool PrintLabels { get; set; }

        [Required]
        [StringLength(20)]
        public string FaxNum { get; set; }

        [Required]
        [StringLength(20)]
        public string PhoneNum { get; set; }

        [Required]
        public string Comment { get; set; }

        public bool PayHold { get; set; }

        public int PrimPCon { get; set; }

        [Required]
        [StringLength(20)]
        public string AccountRef { get; set; }

        [Required]
        [StringLength(15)]
        public string DefaultFOB { get; set; }

        public bool RcvInspectionReq { get; set; }

        [Required]
        [StringLength(4)]
        public string CurrencyCode { get; set; }

        [Required]
        [StringLength(4)]
        public string TaxRegionCode { get; set; }

        public int CountryNum { get; set; }

        [Required]
        [StringLength(8)]
        public string LangNameID { get; set; }

        [Required]
        [StringLength(4)]
        public string BorderCrossing { get; set; }

        [Required]
        [StringLength(50)]
        public string FormatStr { get; set; }

        public bool ElecPayment { get; set; }

        [Required]
        [StringLength(9)]
        public string PrimaryBankID { get; set; }

        public bool Approved { get; set; }

        public bool ICVend { get; set; }

        [Required]
        [StringLength(50)]
        public string EMailAddress { get; set; }

        public bool WebVendor { get; set; }

        [Required]
        public string VendURL { get; set; }

        public int EarlyBuffer { get; set; }

        public int LateBuffer { get; set; }

        [Required]
        [StringLength(4)]
        public string OnTimeRating { get; set; }

        [Required]
        [StringLength(4)]
        public string QualityRating { get; set; }

        [Required]
        [StringLength(4)]
        public string PriceRating { get; set; }

        [Required]
        [StringLength(4)]
        public string ServiceRating { get; set; }

        [Required]
        [StringLength(40)]
        public string ExternalId { get; set; }

        public int VendPILimit { get; set; }

        public bool GlobalVendor { get; set; }

        public bool ICTrader { get; set; }

        [Required]
        [StringLength(8)]
        public string TaxAuthorityCode { get; set; }

        public bool GlobalLock { get; set; }

        public decimal MinOrderValue { get; set; }

        [Required]
        [StringLength(8)]
        public string CalendarID { get; set; }

        [Required]
        [StringLength(15)]
        public string EDICode { get; set; }

        public bool ConsolidatedPurchasing { get; set; }

        public bool LocalPurchasing { get; set; }

        public bool ResDelivery { get; set; }

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

        public bool ServSignature { get; set; }

        public bool ServAlert { get; set; }

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

        public bool CPay { get; set; }

        public bool IndividualPackIDs { get; set; }

        public bool IntrntlShip { get; set; }

        public bool CertOfOrigin { get; set; }

        public bool CommercialInvoice { get; set; }

        public bool ShipExprtDeclartn { get; set; }

        public bool LetterOfInstr { get; set; }

        [Required]
        [StringLength(8)]
        public string FFID { get; set; }

        [Required]
        [StringLength(50)]
        public string FFCompName { get; set; }

        [Required]
        [StringLength(50)]
        public string FFContact { get; set; }

        [Required]
        [StringLength(50)]
        public string FFAddress1 { get; set; }

        [Required]
        [StringLength(50)]
        public string FFAddress2 { get; set; }

        [Required]
        [StringLength(50)]
        public string FFAddress3 { get; set; }

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

        public bool NonStdPkg { get; set; }

        public int DeliveryConf { get; set; }

        public bool AddlHdlgFlag { get; set; }

        public bool UPSQuantumView { get; set; }

        [Required]
        [StringLength(50)]
        public string UPSQVShipFromName { get; set; }

        [Required]
        public string UPSQVMemo { get; set; }

        [Required]
        [StringLength(20)]
        public string FFPhoneNum { get; set; }

        public int FFCountryNum { get; set; }

        [Required]
        [StringLength(8)]
        public string RevChargeMethod { get; set; }

        public bool ManagedCust { get; set; }

        [Required]
        [StringLength(10)]
        public string ManagedCustID { get; set; }

        public int ManagedCustNum { get; set; }

        public int PMUID { get; set; }

        public bool HasBank { get; set; }

        [Required]
        [StringLength(25)]
        public string PmtAcctRef { get; set; }

        [Required]
        [StringLength(12)]
        public string APInvoiceITCode { get; set; }

        [Required]
        [StringLength(12)]
        public string DebitMemoITCode { get; set; }

        [Required]
        [StringLength(12)]
        public string MiscPayITCode { get; set; }

        [Required]
        [StringLength(12)]
        public string APInvoiceAdjITCode { get; set; }

        [Required]
        [StringLength(200)]
        public string LegalName { get; set; }

        [Required]
        [StringLength(12)]
        public string TaxRegReason { get; set; }

        [Required]
        [StringLength(12)]
        public string OrgRegCode { get; set; }

        public bool AdvTaxInv { get; set; }

        public bool AllowAsAltRemitTo { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }

        [Required]
        [StringLength(8)]
        public string THBranchID { get; set; }

        [Required]
        [StringLength(20)]
        public string ParamCode { get; set; }

        [Required]
        [StringLength(4)]
        public string AGAFIPResponsibilityCode { get; set; }

        [Required]
        [StringLength(20)]
        public string AGGrossIncomeTaxID { get; set; }

        [Required]
        [StringLength(4)]
        public string AGIDDocumentTypeCode { get; set; }

        [Required]
        [StringLength(4)]
        public string AGProvinceCode { get; set; }

        public bool AGUseGoodDefaultMark { get; set; }

        [Required]
        [StringLength(3)]
        public string AGApartment { get; set; }

        [Required]
        [StringLength(1)]
        public string AGExtraStreetNumber { get; set; }

        [Required]
        [StringLength(3)]
        public string AGFloor { get; set; }

        [Required]
        [StringLength(5)]
        public string AGLocationCode { get; set; }

        [Required]
        [StringLength(40)]
        public string AGNeighborhood { get; set; }

        [Required]
        [StringLength(40)]
        public string AGStreet { get; set; }

        [Required]
        [StringLength(8)]
        public string AGStreetNumber { get; set; }

        [Required]
        [StringLength(20)]
        public string COOneTimeID { get; set; }

        public bool NoBankingReference { get; set; }

        public bool PEGoodsContributor { get; set; }

        public bool PEWithholdAgent { get; set; }

        public bool PECollectionAgent { get; set; }

        public bool PENotFound { get; set; }

        public bool PENoAddress { get; set; }

        [Required]
        [StringLength(1)]
        public string PEIdentityDocType { get; set; }

        public bool COIsOneTimeVend { get; set; }

        [Required]
        [StringLength(60)]
        public string PEDocumentID { get; set; }

        public int MaxLateDaysPORel { get; set; }

        [Required]
        [StringLength(15)]
        public string Code1099ID { get; set; }

        [Required]
        [StringLength(20)]
        public string TIN { get; set; }

        [Required]
        [StringLength(2)]
        public string TINType { get; set; }

        public bool SecondTINNotice { get; set; }

        [Required]
        [StringLength(4)]
        public string NameControl { get; set; }

        [Required]
        [StringLength(4)]
        public string ShipViaCode { get; set; }

        public bool NonUS { get; set; }

        [Required]
        [StringLength(12)]
        public string FormTypeID { get; set; }

        [Required]
        [StringLength(30)]
        public string INSupplierType { get; set; }

        [Required]
        [StringLength(25)]
        public string INCSTNumber { get; set; }

        [Required]
        [StringLength(12)]
        public string INPANNumber { get; set; }

        [Required]
        [StringLength(1)]
        public string DEOrgType { get; set; }

        public bool PaymentReporting { get; set; }

        public bool ExternalPurchasing { get; set; }

        [Required]
        [StringLength(10)]
        public string MXRetentionCode { get; set; }

        [Required]
        [StringLength(50)]
        public string Reporting1099Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Reporting1099Name2 { get; set; }

        public bool FATCA { get; set; }

        [Required]
        [StringLength(20)]
        public string AccountNum { get; set; }

        [Required]
        [StringLength(8)]
        public string TWGUIRegNum { get; set; }

        [Required]
        [StringLength(10)]
        public string MXTARCode { get; set; }
    }
}
