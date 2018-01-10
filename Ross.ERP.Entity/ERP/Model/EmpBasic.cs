namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.EmpBasic")]
    public partial class EmpBasic
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string EmpID { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string MiddleInitial { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required]
        [StringLength(35)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Required]
        [StringLength(35)]
        public string Address2 { get; set; }

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
        [StringLength(35)]
        public string Country { get; set; }

        [Required]
        [StringLength(20)]
        public string Phone { get; set; }

        [Required]
        [StringLength(20)]
        public string EmgPhone { get; set; }

        public int Shift { get; set; }

        public decimal LaborRate { get; set; }

        public bool Payroll { get; set; }

        public bool PRSetupReq { get; set; }

        [Required]
        [StringLength(2)]
        public string EmpStatus { get; set; }

        [Required]
        [StringLength(16)]
        public string ExpenseCode { get; set; }

        [Required]
        [StringLength(8)]
        public string PhotoFile { get; set; }

        [Required]
        [StringLength(8)]
        public string JCDept { get; set; }

        [Required]
        [StringLength(30)]
        public string EmgContact { get; set; }

        [Required]
        [StringLength(8)]
        public string SupervisorID { get; set; }

        public int CountryNum { get; set; }

        public bool ServTech { get; set; }

        [Required]
        [StringLength(50)]
        public string EMailAddress { get; set; }

        [Required]
        [StringLength(75)]
        public string DcdUserID { get; set; }

        public bool ProductionWorker { get; set; }

        public bool MaterialHandler { get; set; }

        public bool ShopSupervisor { get; set; }

        public bool CanReportQty { get; set; }

        public bool CanOverrideJob { get; set; }

        public bool CanRequestMaterial { get; set; }

        public bool CanReportScrapQty { get; set; }

        public bool CanReportNCQty { get; set; }

        public bool ShipRecv { get; set; }

        [Required]
        [StringLength(8)]
        public string CnvEmpID { get; set; }

        public bool WarehouseManager { get; set; }

        public bool CanOverrideAllocations { get; set; }

        public bool AllowDirLbr { get; set; }

        public bool ContractEmp { get; set; }

        [Required]
        [StringLength(8)]
        public string ResourceGrpID { get; set; }

        [Required]
        [StringLength(12)]
        public string ResourceID { get; set; }

        [Required]
        [StringLength(8)]
        public string TimeWFGroupID { get; set; }

        public bool ExpenseEntryAllowed { get; set; }

        [Required]
        [StringLength(8)]
        public string ExpenseWFGroupID { get; set; }

        public int ExpenseVendorNum { get; set; }

        public int PerConID { get; set; }

        public bool SyncNameToPerCon { get; set; }

        public bool SyncAddressToPerCon { get; set; }

        public bool SyncPhoneToPerCon { get; set; }

        public bool SyncEmailToPerCon { get; set; }

        public bool CanEnterIndirectTime { get; set; }

        public bool CanEnterProductionTime { get; set; }

        public bool CanEnterProjectTime { get; set; }

        public bool CanEnterServiceTime { get; set; }

        public bool CanEnterSetupTime { get; set; }

        public bool TimeAutoApprove { get; set; }

        public bool ExpenseAutoApprove { get; set; }

        [Required]
        [StringLength(30)]
        public string MobileUserPassword { get; set; }

        public bool AllowIndirect { get; set; }

        public bool AllowProduction { get; set; }

        public bool AllowProject { get; set; }

        public bool AllowService { get; set; }

        public bool AllowSetup { get; set; }

        [Required]
        [StringLength(2)]
        public string DefaultLaborTypePseudo { get; set; }

        [Required]
        [StringLength(10)]
        public string DefaultTimeTypCd { get; set; }

        [Required]
        [StringLength(4)]
        public string DefaultIndirectCode { get; set; }

        [Required]
        [StringLength(16)]
        public string DefaultExpenseCode { get; set; }

        [Required]
        [StringLength(8)]
        public string DefaultResourceGrpID { get; set; }

        [Required]
        [StringLength(12)]
        public string DefaultResourceID { get; set; }

        public decimal DefaultLaborHrs { get; set; }

        [Required]
        [StringLength(4)]
        public string DefaultExpCurrencyCode { get; set; }

        [Required]
        [StringLength(4)]
        public string DefaultClaimCurrencyCode { get; set; }

        public int DefaultPMUID { get; set; }

        [Required]
        [StringLength(4)]
        public string DefaultTaxRegionCode { get; set; }

        public bool DefaultTaxIncluded { get; set; }

        public bool ExpenseAdvReqAllowed { get; set; }

        [Required]
        [StringLength(8)]
        public string ExpenseAdvReqWFGroupID { get; set; }

        public bool ExpenseAdvReqAutoApprove { get; set; }

        [Required]
        [StringLength(12)]
        public string MobileResourceID { get; set; }

        public bool AllowAsAltRemitTo { get; set; }

        [Required]
        [StringLength(50)]
        public string UserNameInJDF { get; set; }

        public byte[] EmployeePhoto { get; set; }

        public bool ExternalMES { get; set; }

        public bool PermitScrap { get; set; }

        public bool PermitDown { get; set; }

        public bool PermitHelp { get; set; }

        public bool PermitJobControl { get; set; }

        public bool PermitNextJobControl { get; set; }

        public bool PermitManualSqc { get; set; }

        public bool PermitVariableSqc { get; set; }

        public bool PermitAttributeSqc { get; set; }

        public bool PermitMaterialLot { get; set; }

        public bool PermitSetupMaterial { get; set; }

        public bool PermitCavities { get; set; }

        public bool PermitPercentRegrind { get; set; }

        public bool PermitSaveProfile { get; set; }

        public bool PermitCalibration { get; set; }

        public bool PermitMachinePm { get; set; }

        public bool PermitToolPm { get; set; }

        public bool PermitLanguage { get; set; }

        public bool PermitPreferences { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }

        public bool DisallowTimeEntry { get; set; }

        public bool PkgInboundAllowed { get; set; }

        public bool PkgOutboundAllowed { get; set; }

        public bool PkgInventoryAllowed { get; set; }

        public bool PkgManufacturingAllowed { get; set; }

        public bool PkgQualityAllowed { get; set; }

        [Required]
        [StringLength(256)]
        public string ImageID { get; set; }

        public bool PkgMasterMixedPrint { get; set; }

        public bool PkgSuppressPrintMessages { get; set; }
    }
}
