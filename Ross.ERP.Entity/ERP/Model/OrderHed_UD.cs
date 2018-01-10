namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.OrderHed_UD")]
    public partial class OrderHed_UD
    {
        [Key]
        public Guid ForeignSysRowID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] UD_SysRevID { get; set; }

        public decimal changzhi_c { get; set; }

        public bool CheckBox01_c { get; set; }

        public bool CheckBox02_c { get; set; }

        public bool CheckBox03_c { get; set; }

        public bool CheckBox04_c { get; set; }

        public bool CheckBox05_c { get; set; }

        public DateTime? Date01_c { get; set; }

        public DateTime? Date02_c { get; set; }

        public DateTime? Date03_c { get; set; }

        public DateTime? Date04_c { get; set; }

        public DateTime? Date05_c { get; set; }

        public decimal Number01_c { get; set; }

        public decimal Number02_c { get; set; }

        public decimal Number03_c { get; set; }

        public decimal Number04_c { get; set; }

        public decimal Number05_c { get; set; }
    }
}
