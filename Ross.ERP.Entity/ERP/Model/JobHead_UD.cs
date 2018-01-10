namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.JobHead_UD")]
    public partial class JobHead_UD
    {
        [Key]
        public Guid ForeignSysRowID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] UD_SysRevID { get; set; }

        [Required]
        [StringLength(50)]
        public string Character01_c { get; set; }

        [Required]
        [StringLength(50)]
        public string Character02_c { get; set; }

        public bool CheckBox01_c { get; set; }

        public bool CheckBox02_c { get; set; }

        public bool CheckBox03_c { get; set; }

        public bool CheckBox04_c { get; set; }

        public bool CheckBox05_c { get; set; }

        public bool CheckBox06_c { get; set; }

        public bool CheckBox07_c { get; set; }

        public bool CheckBox08_c { get; set; }

        public bool CheckBox09_c { get; set; }

        public bool CheckBox10_c { get; set; }

        public DateTime? Date01_c { get; set; }

        public DateTime? Date02_c { get; set; }

        public DateTime? Date03_c { get; set; }

        public DateTime? Date04_c { get; set; }

        public DateTime? Date05_c { get; set; }

        public DateTime? Date06_c { get; set; }

        public DateTime? Date07_c { get; set; }

        public DateTime? Date08_c { get; set; }

        public DateTime? Date09_c { get; set; }

        public DateTime? Date10_c { get; set; }

        public int LeadTime_c { get; set; }

        public decimal Number01_c { get; set; }

        public decimal Number02_c { get; set; }

        public decimal Number03_c { get; set; }

        public decimal Number04_c { get; set; }

        public decimal Number05_c { get; set; }

        public decimal Number06_c { get; set; }

        public decimal Number07_c { get; set; }

        public decimal Number08_c { get; set; }

        public decimal Number09_c { get; set; }

        public decimal Number10_c { get; set; }

        public decimal Number11_c { get; set; }

        public decimal Number12_c { get; set; }

        public decimal Number13_c { get; set; }

        public decimal Number14_c { get; set; }

        public decimal Number15_c { get; set; }

        public decimal Number16_c { get; set; }

        public decimal Number17_c { get; set; }

        public decimal Number18_c { get; set; }

        public decimal Number19_c { get; set; }

        public decimal Number20_c { get; set; }

        public virtual JobHead JobHead { get; set; }
    }
}
