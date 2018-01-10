namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.JobOpDtl")]
    public partial class JobOpDtl
    {
        [Required]
        [StringLength(8)]
        public string Company { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum { get; set; }

        public int AssemblySeq { get; set; }

        public int OprSeq { get; set; }

        public int OpDtlSeq { get; set; }

        [Required]
        [StringLength(2)]
        public string SetupOrProd { get; set; }

        [Required]
        [StringLength(20)]
        public string CapabilityID { get; set; }

        [Required]
        [StringLength(8)]
        public string ResourceGrpID { get; set; }

        [Required]
        [StringLength(12)]
        public string ResourceID { get; set; }

        public decimal ConcurrentCapacity { get; set; }

        public decimal DailyProdRate { get; set; }

        public int NumResources { get; set; }

        public decimal EstSetHours { get; set; }

        public decimal EstProdHours { get; set; }

        public decimal ProdStandard { get; set; }

        [Required]
        [StringLength(2)]
        public string StdFormat { get; set; }

        [Required]
        [StringLength(2)]
        public string StdBasis { get; set; }

        public int OpsPerPart { get; set; }

        public decimal ProdLabRate { get; set; }

        public decimal SetupLabRate { get; set; }

        public decimal ProdBurRate { get; set; }

        public decimal SetupBurRate { get; set; }

        public bool ProdComplete { get; set; }

        public bool SetupComplete { get; set; }

        public decimal ActProdHours { get; set; }

        public decimal ActProdRwkHours { get; set; }

        public decimal ActSetupHours { get; set; }

        public decimal ActSetupRwkHours { get; set; }

        public int SetupPctComplete { get; set; }

        public decimal ActBurCost { get; set; }

        public decimal ActLabCost { get; set; }

        public decimal ReworkBurCost { get; set; }

        public decimal ReworkLabCost { get; set; }

        public bool ResourceLock { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SysCreateDate { get; set; }

        public int SysCreateTime { get; set; }

        [Required]
        [StringLength(30)]
        public string OpDtlDesc { get; set; }

        public decimal EstSetHoursPerMch { get; set; }

        public bool OverrideRates { get; set; }

        public decimal ProdCrewSize { get; set; }

        public decimal SetUpCrewSize { get; set; }

        public bool RemovedFromPlan { get; set; }

        public bool IsPrimaryProd { get; set; }

        public bool IsPrimarySetup { get; set; }

        public bool AutoSystemAdded { get; set; }

        public bool MobileAllocatedResource { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        [Key]
        public Guid SysRowID { get; set; }
    }
}
