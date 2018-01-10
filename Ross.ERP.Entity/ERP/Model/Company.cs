namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.Company")]
    public partial class Company
    {
        [Key]
        [Column("Company")]
        [StringLength(8)]
        public string Company1 { get; set; }

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

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        [Required]
        [StringLength(20)]
        public string PhoneNum { get; set; }

        [Required]
        [StringLength(20)]
        public string FaxNum { get; set; }

        [Required]
        [StringLength(20)]
        public string FEIN { get; set; }

        [Required]
        [StringLength(20)]
        public string StateTaxID { get; set; }

        public int CurrentFiscalYear { get; set; }

        [Required]
        [StringLength(15)]
        public string EDICode { get; set; }

        [Required]
        [StringLength(4)]
        public string TaxRegionCode { get; set; }

        public int CountryNum { get; set; }

        public int Number { get; set; }

        [Required]
        [StringLength(20)]
        public string FRxDSN { get; set; }

        [Required]
        [StringLength(8)]
        public string EschedFileSet { get; set; }

        [Required]
        [StringLength(20)]
        public string ExternalID { get; set; }

        [Required]
        [StringLength(50)]
        public string LogoFile { get; set; }

        [Required]
        [StringLength(80)]
        public string EmpPhotoPath { get; set; }

        [Required]
        [StringLength(8)]
        public string CalendarID { get; set; }

        [Required]
        [StringLength(256)]
        public string AuxMailAddr { get; set; }

        [Required]
        [StringLength(75)]
        public string FrxUserid { get; set; }

        [Required]
        [StringLength(20)]
        public string FRxPassWord { get; set; }

        [Required]
        [StringLength(12)]
        public string FiscalCalendarID { get; set; }

        [Required]
        [StringLength(200)]
        public string LegalName { get; set; }

        [Required]
        [StringLength(12)]
        public string TaxRegReason { get; set; }

        [Required]
        [StringLength(12)]
        public string ActTypeCode { get; set; }

        [Required]
        [StringLength(12)]
        public string OrgRegCode { get; set; }

        [Required]
        [StringLength(50)]
        public string ManagerName { get; set; }

        [Required]
        [StringLength(50)]
        public string ChiefAcctName { get; set; }

        [Required]
        [StringLength(10)]
        public string ReportTypePref { get; set; }

        [Required]
        [StringLength(50)]
        public string WIApplication { get; set; }

        public bool WIAutoCreateJob { get; set; }

        public bool WIGetDetails { get; set; }

        public bool WISchedule { get; set; }

        public bool WIRelease { get; set; }

        public bool WIShippingCosts { get; set; }

        public bool DeepCopy { get; set; }

        public bool DeepCopyDupOrRevEst { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }

        [Required]
        public string MapURL { get; set; }

        [Required]
        [StringLength(50)]
        public string MXMunicipio { get; set; }

        public int APBOECheck { get; set; }

        public int COSequenceCert { get; set; }
    }
}
