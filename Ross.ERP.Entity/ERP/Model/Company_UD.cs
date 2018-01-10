namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.Company_UD")]
    public partial class Company_UD
    {
        [Key]
        public Guid ForeignSysRowID { get; set; }
        [MaxLength(8)]
        [Timestamp]
        public byte[] UD_SysRevID { get; set; }
        public DateTime LastGetPLMTime_c { get; set; }
        [Required]
        public string DBConnectString_c { get; set; }
    }
}
