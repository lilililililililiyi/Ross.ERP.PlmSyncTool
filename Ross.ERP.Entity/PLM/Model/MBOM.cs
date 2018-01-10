namespace Ross.ERP.Entity.PLM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ROSSPLM.MBOM")]
    public partial class MBOM
    {
        [StringLength(50)]
        public string ID { get; set; }

        public bool? DEL { get; set; }

        [StringLength(1)]
        public string MSYM { get; set; }

        [StringLength(50)]
        public string WKAID { get; set; }

        [StringLength(50)]
        public string DESIGNNO { get; set; }

        [StringLength(50)]
        public string BLDESIGNNO { get; set; }

        [StringLength(50)]
        public string CREATOR { get; set; }

        public DateTime? CTIME { get; set; }

        [StringLength(50)]
        public string MUSER { get; set; }

        public DateTime? MTIME { get; set; }

        [StringLength(50)]
        public string CHKUSR { get; set; }

        public DateTime? CHKTIME { get; set; }

        [StringLength(50)]
        public string DUSER { get; set; }

        public DateTime? DELTIME { get; set; }

        [StringLength(50)]
        public string ALTERUSER { get; set; }

        [StringLength(100)]
        public string OWNER { get; set; }

        [StringLength(1)]
        public string STATE { get; set; }

        public decimal? BNUM { get; set; }

        public short? BOMPST { get; set; }

        [StringLength(50)]
        public string CID { get; set; }

        [StringLength(50)]
        public string CTN { get; set; }

        [StringLength(50)]
        public string PID { get; set; }

        [StringLength(50)]
        public string PTN { get; set; }

        [StringLength(200)]
        public string ASMEMO { get; set; }

        [StringLength(200)]
        public string PARAMEXP { get; set; }

        [StringLength(200)]
        public string PARAMOUT { get; set; }

        [StringLength(50)]
        public string BSUSER01 { get; set; }

        [StringLength(50)]
        public string BSUSER02 { get; set; }

        [StringLength(50)]
        public string BSUSER03 { get; set; }

        [StringLength(50)]
        public string BSUSER04 { get; set; }

        [StringLength(50)]
        public string BSUSER05 { get; set; }

        [StringLength(50)]
        public string BSUSER06 { get; set; }

        [StringLength(50)]
        public string BSUSER07 { get; set; }

        [StringLength(50)]
        public string BSUSER08 { get; set; }

        [StringLength(50)]
        public string BSUSER09 { get; set; }

        [StringLength(50)]
        public string BSUSER10 { get; set; }

        public decimal? BFUSER01 { get; set; }

        public decimal? BFUSER02 { get; set; }

        public decimal? BFUSER03 { get; set; }

        public decimal? BFUSER04 { get; set; }

        public decimal? BFUSER05 { get; set; }

        public DateTime? BDUSER01 { get; set; }

        public DateTime? BDUSER02 { get; set; }

        public DateTime? BDUSER03 { get; set; }

        public DateTime? BDUSER04 { get; set; }

        public DateTime? BDUSER05 { get; set; }

        public short? SERIAL { get; set; }

        [StringLength(200)]
        public string SMEMO { get; set; }
    }
}
