namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.Part")]
    public partial class Part
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        [StringLength(8)]
        public string SearchWord { get; set; }

        [Required]
        public string PartDescription { get; set; }

        [Required]
        [StringLength(4)]
        public string ClassID { get; set; }

        [Required]
        [StringLength(6)]
        public string IUM { get; set; }

        [Required]
        [StringLength(6)]
        public string PUM { get; set; }

        [Required]
        [StringLength(2)]
        public string TypeCode { get; set; }

        public bool NonStock { get; set; }

        public decimal PurchasingFactor { get; set; }

        public decimal UnitPrice { get; set; }

        [Required]
        [StringLength(2)]
        public string PricePerCode { get; set; }

        public decimal InternalUnitPrice { get; set; }

        [Required]
        [StringLength(2)]
        public string InternalPricePerCode { get; set; }

        [Required]
        [StringLength(8)]
        public string ProdCode { get; set; }

        [Required]
        public string MfgComment { get; set; }

        [Required]
        public string PurComment { get; set; }

        [Required]
        [StringLength(2)]
        public string CostMethod { get; set; }

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

        public DateTime? UserDate1 { get; set; }

        public DateTime? UserDate2 { get; set; }

        public DateTime? UserDate3 { get; set; }

        public DateTime? UserDate4 { get; set; }

        public decimal UserDecimal1 { get; set; }

        public decimal UserDecimal2 { get; set; }

        public decimal UserDecimal3 { get; set; }

        public decimal UserDecimal4 { get; set; }

        public int UserInteger1 { get; set; }

        public int UserInteger2 { get; set; }

        [Required]
        [StringLength(10)]
        public string TaxCatID { get; set; }

        public bool InActive { get; set; }

        public int LowLevelCode { get; set; }

        public bool Method { get; set; }

        public bool TrackLots { get; set; }

        public bool TrackDimension { get; set; }

        [Required]
        [StringLength(6)]
        public string DefaultDim { get; set; }

        public bool TrackSerialNum { get; set; }

        [Required]
        [StringLength(12)]
        public string CommodityCode { get; set; }

        [Required]
        [StringLength(8)]
        public string WarrantyCode { get; set; }

        public bool PhantomBOM { get; set; }

        [Required]
        [StringLength(6)]
        public string SalesUM { get; set; }

        public decimal SellingFactor { get; set; }

        public decimal MtlBurRate { get; set; }

        public decimal NetWeight { get; set; }

        public bool UsePartRev { get; set; }

        public int PartsPerContainer { get; set; }

        public decimal PartLength { get; set; }

        public decimal PartWidth { get; set; }

        public decimal PartHeight { get; set; }

        public int LotShelfLife { get; set; }

        public bool WebPart { get; set; }

        public bool RunOut { get; set; }

        [Required]
        [StringLength(50)]
        public string SubPart { get; set; }

        public decimal Diameter { get; set; }

        public decimal Gravity { get; set; }

        public bool OnHold { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OnHoldDate { get; set; }

        [Required]
        [StringLength(8)]
        public string OnHoldReasonCode { get; set; }

        [Required]
        [StringLength(8)]
        public string AnalysisCode { get; set; }

        public bool GlobalPart { get; set; }

        [Required]
        [StringLength(8)]
        public string MtlAnalysisCode { get; set; }

        public bool GlobalLock { get; set; }

        public decimal ISSuppUnitsFactor { get; set; }

        [Required]
        [StringLength(8)]
        public string PDMObjID { get; set; }

        [Required]
        [StringLength(256)]
        public string ImageFileName { get; set; }

        [Required]
        [StringLength(6)]
        public string ISOrigCountry { get; set; }

        [Required]
        [StringLength(30)]
        public string SNPrefix { get; set; }

        [Required]
        [StringLength(80)]
        public string SNFormat { get; set; }

        [Required]
        [StringLength(10)]
        public string SNBaseDataType { get; set; }

        public bool Constrained { get; set; }

        [Required]
        [StringLength(20)]
        public string UPCCode1 { get; set; }

        [Required]
        [StringLength(20)]
        public string UPCCode2 { get; set; }

        [Required]
        [StringLength(20)]
        public string UPCCode3 { get; set; }

        [Required]
        [StringLength(15)]
        public string EDICode { get; set; }

        public bool WebInStock { get; set; }

        public bool ConsolidatedPurchasing { get; set; }

        [Required]
        [StringLength(1)]
        public string PurchasingFactorDirection { get; set; }

        [Required]
        [StringLength(1)]
        public string SellingFactorDirection { get; set; }

        public bool RecDocReq { get; set; }

        public int MDPV { get; set; }

        public bool ShipDocReq { get; set; }

        [Required]
        [StringLength(30)]
        public string ReturnableContainer { get; set; }

        public decimal NetVolume { get; set; }

        public bool QtyBearing { get; set; }

        [Required]
        [StringLength(6)]
        public string NAFTAOrigCountry { get; set; }

        [Required]
        [StringLength(8)]
        public string NAFTAProd { get; set; }

        [Required]
        [StringLength(8)]
        public string NAFTAPref { get; set; }

        [Required]
        [StringLength(8)]
        public string ExpLicType { get; set; }

        [Required]
        [StringLength(25)]
        public string ExpLicNumber { get; set; }

        [Required]
        [StringLength(25)]
        public string ECCNNumber { get; set; }

        [Required]
        [StringLength(8)]
        public string AESExp { get; set; }

        [Required]
        [StringLength(10)]
        public string HTS { get; set; }

        public bool UseHTSDesc { get; set; }

        [Required]
        [StringLength(12)]
        public string SchedBcode { get; set; }

        public bool HazItem { get; set; }

        [Required]
        [StringLength(40)]
        public string HazTechName { get; set; }

        [Required]
        [StringLength(8)]
        public string HazClass { get; set; }

        [Required]
        [StringLength(8)]
        public string HazSub { get; set; }

        [Required]
        [StringLength(8)]
        public string HazGvrnmtID { get; set; }

        [Required]
        public string HazPackInstr { get; set; }

        [Required]
        [StringLength(8)]
        public string RevChargeMethod { get; set; }

        public decimal RCUnderThreshold { get; set; }

        public decimal RCOverThreshold { get; set; }

        [Required]
        [StringLength(8)]
        public string OwnershipStatus { get; set; }

        [Required]
        [StringLength(12)]
        public string UOMClassID { get; set; }

        [Required]
        [StringLength(20)]
        public string SNMask { get; set; }

        [Required]
        [StringLength(80)]
        public string SNMaskExample { get; set; }

        [Required]
        [StringLength(10)]
        public string SNMaskSuffix { get; set; }

        [Required]
        [StringLength(10)]
        public string SNMaskPrefix { get; set; }

        [Required]
        [StringLength(40)]
        public string SNLastUsedSeq { get; set; }

        public bool UseMaskSeq { get; set; }

        [Required]
        [StringLength(6)]
        public string NetWeightUOM { get; set; }

        [Required]
        [StringLength(6)]
        public string NetVolumeUOM { get; set; }

        public bool LotBatch { get; set; }

        public bool LotMfgBatch { get; set; }

        public bool LotMfgLot { get; set; }

        public bool LotHeat { get; set; }

        public bool LotFirmware { get; set; }

        public bool LotBeforeDt { get; set; }

        public bool LotMfgDt { get; set; }

        public bool LotCureDt { get; set; }

        public bool LotExpDt { get; set; }

        [Required]
        [StringLength(20)]
        public string LotPrefix { get; set; }

        public bool LotUseGlobalSeq { get; set; }

        [Required]
        [StringLength(12)]
        public string LotSeqID { get; set; }

        public int LotNxtNum { get; set; }

        public int LotDigits { get; set; }

        public bool LotLeadingZeros { get; set; }

        [Required]
        [StringLength(10)]
        public string LotAppendDate { get; set; }

        public bool BuyToOrder { get; set; }

        public bool DropShip { get; set; }

        public bool IsConfigured { get; set; }

        public bool ExtConfig { get; set; }

        [Required]
        [StringLength(8)]
        public string RefCategory { get; set; }

        public bool CSFCJ5 { get; set; }

        public bool CSFLMW { get; set; }

        public decimal GrossWeight { get; set; }

        [Required]
        [StringLength(6)]
        public string GrossWeightUOM { get; set; }

        [Required]
        [StringLength(50)]
        public string BasePartNum { get; set; }

        [Required]
        [StringLength(50)]
        public string FSAssetClassCode { get; set; }

        public decimal FSSalesUnitPrice { get; set; }

        [Required]
        [StringLength(2)]
        public string FSPricePerCode { get; set; }

        public bool RcvInspectionReq { get; set; }

        [Required]
        [StringLength(256)]
        public string EstimateID { get; set; }

        [Required]
        [StringLength(20)]
        public string EstimateOrPlan { get; set; }

        public bool DiffPrc2PrchUOM { get; set; }

        public bool DupOnJobCrt { get; set; }

        public decimal PricingFactor { get; set; }

        [Required]
        [StringLength(6)]
        public string PricingUOM { get; set; }

        public bool MobilePart { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }

        public bool AGUseGoodMark { get; set; }

        public bool AGProductMark { get; set; }

        [Required]
        [StringLength(3)]
        public string ISRegion { get; set; }

        [Required]
        [StringLength(12)]
        public string INChapterID { get; set; }

        [Required]
        [StringLength(100)]
        public string PESUNATType { get; set; }

        [Required]
        [StringLength(100)]
        public string PESUNATUOM { get; set; }

        public bool DEIsServices { get; set; }

        public bool DEIsSecurityFinancialDerivative { get; set; }

        [Required]
        [StringLength(12)]
        public string DEInternationalSecuritiesID { get; set; }

        public bool LinkToContract { get; set; }

        public bool DEIsInvestment { get; set; }

        [Required]
        [StringLength(3)]
        public string DEPayStatCode { get; set; }

        [Required]
        [StringLength(3)]
        public string DEDenomination { get; set; }

        [Required]
        [StringLength(6)]
        public string PartLengthWidthHeightUM { get; set; }

        [Required]
        [StringLength(6)]
        public string DiameterUM { get; set; }

        public decimal DiameterInside { get; set; }

        public decimal DiameterOutside { get; set; }

        [Required]
        [StringLength(6)]
        public string ThicknessUM { get; set; }

        public decimal Thickness { get; set; }

        public decimal ThicknessMax { get; set; }

        [Required]
        [StringLength(30)]
        public string Durometer { get; set; }

        [Required]
        [StringLength(30)]
        public string Specification { get; set; }

        [Required]
        [StringLength(30)]
        public string EngineeringAlert { get; set; }

        [Required]
        [StringLength(30)]
        public string Condition { get; set; }

        public bool IsCompliant { get; set; }

        public bool IsRestricted { get; set; }

        public bool IsSafetyItem { get; set; }

        [Required]
        [StringLength(30)]
        public string CommercialBrand { get; set; }

        [Required]
        [StringLength(30)]
        public string CommercialSubBrand { get; set; }

        [Required]
        [StringLength(30)]
        public string CommercialCategory { get; set; }

        [Required]
        [StringLength(30)]
        public string CommercialSubCategory { get; set; }

        [Required]
        [StringLength(30)]
        public string CommercialStyle { get; set; }

        [Required]
        [StringLength(30)]
        public string CommercialSize1 { get; set; }

        [Required]
        [StringLength(30)]
        public string CommercialSize2 { get; set; }

        [Required]
        [StringLength(30)]
        public string CommercialColor { get; set; }

        public bool IsGiftCard { get; set; }

        [Required]
        [StringLength(8)]
        public string PhotoFile { get; set; }

        public bool PartPhotoExists { get; set; }

        [Required]
        public string CommentText { get; set; }

        public bool PartSpecificPackingUOM { get; set; }

        [Required]
        [StringLength(256)]
        public string ImageID { get; set; }

        [Required]
        [StringLength(30)]
        public string CNSpecification { get; set; }

        public bool SyncToExternalCRM { get; set; }

        [Required]
        [StringLength(200)]
        public string ExternalCRMPartID { get; set; }

        public DateTime? ExternalCRMLastSync { get; set; }

        public bool ExternalCRMSyncRequired { get; set; }
    }
}
