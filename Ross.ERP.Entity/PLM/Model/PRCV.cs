namespace Ross.ERP.Entity.PLM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ROSSPLM.PRCV")]
    public partial class PRCV
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
        public string NO { get; set; }

        [StringLength(200)]
        public string NAME { get; set; }

        [StringLength(200)]
        public string ENAME { get; set; }

        [StringLength(200)]
        public string DRTNAME { get; set; }

        public short? VER { get; set; }

        [StringLength(50)]
        public string PTYPE { get; set; }

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

        [StringLength(200)]
        public string SMEMO { get; set; }

        [StringLength(50)]
        public string SUSER01 { get; set; }

        [StringLength(50)]
        public string SUSER02 { get; set; }

        [StringLength(50)]
        public string SUSER03 { get; set; }

        [StringLength(50)]
        public string SUSER04 { get; set; }

        [StringLength(50)]
        public string SUSER05 { get; set; }

        [StringLength(50)]
        public string SUSER06 { get; set; }

        [StringLength(50)]
        public string SUSER07 { get; set; }

        [StringLength(50)]
        public string SUSER08 { get; set; }

        [StringLength(50)]
        public string SUSER09 { get; set; }

        [StringLength(50)]
        public string SUSER10 { get; set; }

        public decimal? FUSER01 { get; set; }

        public decimal? FUSER02 { get; set; }

        public decimal? FUSER03 { get; set; }

        public decimal? FUSER04 { get; set; }

        public decimal? FUSER05 { get; set; }

        public DateTime? DUSER01 { get; set; }

        public DateTime? DUSER02 { get; set; }

        public DateTime? DUSER03 { get; set; }

        public DateTime? DUSER04 { get; set; }

        public DateTime? DUSER05 { get; set; }

        public bool? CZZT { get; set; }

        public bool? SEL { get; set; }

        [StringLength(200)]
        public string MODNAME { get; set; }
    }
}
