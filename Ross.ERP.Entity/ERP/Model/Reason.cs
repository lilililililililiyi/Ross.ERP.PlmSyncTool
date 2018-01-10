namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.Reason")]
    public partial class Reason
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string ReasonType { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(8)]
        public string ReasonCode { get; set; }

        [Required]
        [StringLength(30)]
        public string Description { get; set; }

        public bool DMRRejOpr { get; set; }

        public bool DMRRejMtl { get; set; }

        public bool DMRRejSub { get; set; }

        public bool DMRRejInv { get; set; }

        public bool DMRAcceptOpr { get; set; }

        public bool DMRAcceptMtl { get; set; }

        public bool DMRAcceptSub { get; set; }

        public bool DMRAcceptInv { get; set; }

        public bool InspFailOpr { get; set; }

        public bool InspFailMtl { get; set; }

        public bool InspFailSub { get; set; }

        public bool InspFailInv { get; set; }

        public bool Scrap { get; set; }

        public bool NonConfOpr { get; set; }

        public bool NonConfMtl { get; set; }

        public bool NonConfSub { get; set; }

        public bool NonConfOther { get; set; }

        public bool QACause { get; set; }

        public bool QACorrectiveAct { get; set; }

        public bool InvAdjCountDiscrepancy { get; set; }

        public bool Passed { get; set; }

        public bool GlobalReason { get; set; }

        public bool GlobalLock { get; set; }

        [Required]
        [StringLength(50)]
        public string JDFWorkType { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }

        public bool NonConfInv { get; set; }
    }
}
