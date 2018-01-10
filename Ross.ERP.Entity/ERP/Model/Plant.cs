namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.Plant")]
    public partial class Plant
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Key]
        [Column("Plant", Order = 1)]
        [StringLength(8)]
        public string Plant1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

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
        public string Zip { get; set; }

        public int CountryNum { get; set; }

        [Required]
        [StringLength(20)]
        public string PhoneNum { get; set; }

        [Required]
        [StringLength(20)]
        public string FaxNum { get; set; }

        [Required]
        public string CommentText { get; set; }

        public int PlanningExceptionDays { get; set; }

        [Required]
        [StringLength(3)]
        public string ISRegion { get; set; }

        [Required]
        [StringLength(8)]
        public string PlantCostID { get; set; }

        public int PrepTime { get; set; }

        public int KitTime { get; set; }

        public bool ReqTransferHeader { get; set; }

        [Required]
        [StringLength(8)]
        public string CalendarID { get; set; }

        [Required]
        [StringLength(4)]
        public string AllowShipAction { get; set; }

        public int AutoConfirmWindow { get; set; }

        public bool SingleLineOrder { get; set; }

        public int MaxOpStartDelay { get; set; }

        public int MaxOpLength { get; set; }

        [Required]
        [StringLength(8)]
        public string DefStationID { get; set; }

        public int FiniteHorz { get; set; }

        [Required]
        public string NextUnfirmJob { get; set; }

        [Required]
        public string NextUnfirmTFLine { get; set; }

        public bool AddlHdlgFlag { get; set; }

        public int RCutHorz { get; set; }

        public bool IncLeadTime { get; set; }

        public bool IncTransLeadTime { get; set; }

        public bool IncReceiveTime { get; set; }

        public bool IncKitTime { get; set; }

        public bool IncRCParams { get; set; }

        public int OverloadHorz { get; set; }

        [Required]
        [StringLength(8)]
        public string SchedulingSendAhead { get; set; }

        public int UnfirmSeriesHorizon { get; set; }

        public int AutoFirmHorizon { get; set; }

        [Required]
        [StringLength(50)]
        public string ManagerName { get; set; }

        [Required]
        [StringLength(8)]
        public string BranchID { get; set; }

        [Required]
        [StringLength(8)]
        public string MaintPlant { get; set; }

        [Required]
        [StringLength(8)]
        public string SiteCode { get; set; }

        [Required]
        [StringLength(30)]
        public string SiteDesc1 { get; set; }

        [Required]
        [StringLength(30)]
        public string SiteDesc2 { get; set; }

        [Required]
        [StringLength(2)]
        public string SiteType { get; set; }

        [Required]
        [StringLength(8)]
        public string BusinessTypeCode { get; set; }

        [Required]
        [StringLength(30)]
        public string BusTypeDesc1 { get; set; }

        [Required]
        [StringLength(30)]
        public string BusTypeDesc2 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }

        [Required]
        [StringLength(4)]
        public string AGDefaultInvoicingPoint { get; set; }

        public bool ForceSSTime { get; set; }

        public bool ForceFFTime { get; set; }

        public bool UseLeadTimeDOS { get; set; }

        public bool AllowMinQty { get; set; }

        public bool IgnoreMtlConstraints { get; set; }

        [Required]
        [StringLength(4)]
        public string AGProvinceCode { get; set; }

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
        [StringLength(1)]
        public string AGExtraStreetNumber { get; set; }

        [Required]
        [StringLength(3)]
        public string AGFloor { get; set; }

        [Required]
        [StringLength(3)]
        public string AGApartment { get; set; }

        [Required]
        [StringLength(50)]
        public string MXMunicipio { get; set; }

        public int MaxLateDaysPORel { get; set; }

        [Required]
        [StringLength(50)]
        public string INECCNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string INExciseRange { get; set; }

        [Required]
        [StringLength(50)]
        public string INExciseDivision { get; set; }

        [Required]
        [StringLength(50)]
        public string INExCommissionRate { get; set; }

        [Required]
        [StringLength(20)]
        public string INTINNumber { get; set; }

        [Required]
        [StringLength(20)]
        public string INCSTNumber { get; set; }

        [Required]
        [StringLength(20)]
        public string INSTRegistration { get; set; }

        public bool UseSchedulingMultiJob { get; set; }

        public bool AutoLoadChildJobs { get; set; }

        public bool AutoLoadParentJobs { get; set; }

        public bool MinimizeWIP { get; set; }

        [Required]
        [StringLength(35)]
        public string TimeZoneID { get; set; }

        public bool TimeZoneAdjustForDST { get; set; }

        public bool SyncReqBy { get; set; }

        public int ACWPercentage { get; set; }
    }
}
