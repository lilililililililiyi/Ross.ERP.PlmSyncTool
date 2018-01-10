namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.JobOper_UD")]
    public partial class JobOper_UD
    {
        [Key]
        public Guid ForeignSysRowID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] UD_SysRevID { get; set; }

        public bool IsPrint_c { get; set; }

        [Required]
        public string AsnedTeamLeaders_c { get; set; }

        [Required]
        public string AsnedTeamLeadersName_c { get; set; }

        [Required]
        public string AsnedTeamMates_c { get; set; }

        [Required]
        public string AsnedTeamMatesName_c { get; set; }

        public bool LaborAsned_c { get; set; }

        public bool TeamAsned_c { get; set; }

        public virtual JobOper JobOper { get; set; }
    }
}
