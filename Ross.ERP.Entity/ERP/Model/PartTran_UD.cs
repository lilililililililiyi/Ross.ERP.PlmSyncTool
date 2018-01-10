namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.PartTran_UD")]
    public partial class PartTran_UD
    {
        [Key]
        public Guid ForeignSysRowID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] UD_SysRevID { get; set; }

        [Required]
        [StringLength(100)]
        public string GetMtlEmpID_c { get; set; }

        [Required]
        [StringLength(100)]
        public string ReturnMtlEmpID_c { get; set; }

        public virtual PartTran PartTran { get; set; }
    }
}
