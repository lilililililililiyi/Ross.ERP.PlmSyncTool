namespace Ross.ERP.Entity.RossLive.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("RossConfig")]
    public partial class RossConfig
    {
        [Column(TypeName = "ntext")]
        public string Units { get; set; }
        [Column(TypeName = "ntext")]
        public string Departs { get; set; }
        [Column(TypeName = "ntext")]
        public string Reasons { get; set; }
        public int TerminalNum { get; set; }
        [StringLength(50)]
        public string Company { get; set; }
        [StringLength(20)]
        public string Telphone { get; set; }
        [StringLength(20)]
        public string Zipcode { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
        [StringLength(20)]
        public string Fax { get; set; }
        public int ID { get; set; }
    }
}
