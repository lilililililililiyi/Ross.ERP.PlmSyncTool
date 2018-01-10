namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.JobMtl_UD")]
    public partial class JobMtl_UD
    {
        [Key]
        public Guid ForeignSysRowID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] UD_SysRevID { get; set; }

        public bool beiliao_c { get; set; }

        public bool chejianqueren_c { get; set; }

        public decimal StandByQty_c { get; set; }

        public long AppMtlNum_c { get; set; }

        public decimal AppMtlQty_c { get; set; }

        public DateTime? AppMtlTime_c { get; set; }

        [Required]
        [StringLength(8)]
        public string AppMtlUserID_c { get; set; }

        public decimal PrepMtlQty_c { get; set; }

        public DateTime? PrepMtlTime_c { get; set; }

        [Required]
        [StringLength(8)]
        public string PrepMtlUserID_c { get; set; }

        [Required]
        [StringLength(8)]
        public string GetMtlUserID_c { get; set; }

        public decimal PrepMtlNeedQty_c { get; set; }

        [Required]
        [StringLength(30)]
        public string LotNum_c { get; set; }

        public virtual JobMtl JobMtl { get; set; }
    }
}
