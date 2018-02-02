namespace Ross.ERP.Entity.RossLive.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("RossConfig")]
    public partial class RossConfig
    {
        public string Units { get; set; }
        [StringLength(50)]
        public string Company { get; set; }
        public int ID { get; set; }
    }
}
