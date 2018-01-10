namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.Part_UD")]
    public partial class Part_UD
    {
        [Key]
        public Guid ForeignSysRowID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] UD_SysRevID { get; set; }

        [Required]
        [StringLength(50)]
        public string BinNum_c { get; set; }

        [Required]
        public string Character01 { get; set; }

        [Required]
        public string Character02 { get; set; }

        [Required]
        public string Character03 { get; set; }

        [Required]
        public string Character04 { get; set; }

        [Required]
        public string Character05 { get; set; }

        public decimal CustomsDuties_c { get; set; }

        public int Number01_c { get; set; }

        public int Number02_c { get; set; }

        public int Number03_c { get; set; }

        public int Number04_c { get; set; }

        [Required]
        [StringLength(50)]
        public string Shortchar02 { get; set; }

        [Required]
        [StringLength(50)]
        public string WarehouseKeeper_c { get; set; }
    }
}
