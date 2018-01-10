namespace Ross.ERP.Entity.PLM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ROSSPLM.PRODUCT")]
    public partial class PRODUCT
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

        public short? VER { get; set; }

        [StringLength(50)]
        public string PTYPE { get; set; }

        [StringLength(200)]
        public string ENAME { get; set; }

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

        [StringLength(200)]
        public string SERIES { get; set; }

        [StringLength(200)]
        public string ORIGINNO { get; set; }

        [StringLength(200)]
        public string DESCRIBE { get; set; }

        [StringLength(200)]
        public string MONITOR { get; set; }

        public bool? SJCZ { get; set; }

        public bool? GYCZ { get; set; }

        [StringLength(200)]
        public string PROJNO { get; set; }

        public DateTime? ADUSER01 { get; set; }

        public DateTime? ADUSER02 { get; set; }

        public DateTime? ADUSER03 { get; set; }

        public DateTime? ADUSER04 { get; set; }

        public DateTime? ADUSER05 { get; set; }

        public long? AFUSER01 { get; set; }

        public long? AFUSER02 { get; set; }

        public long? AFUSER03 { get; set; }

        public long? AFUSER04 { get; set; }

        public long? AFUSER05 { get; set; }

        [StringLength(50)]
        public string ASUSER01 { get; set; }

        [StringLength(50)]
        public string ASUSER02 { get; set; }

        [StringLength(50)]
        public string ASUSER03 { get; set; }

        [StringLength(50)]
        public string ASUSER04 { get; set; }

        [StringLength(50)]
        public string ASUSER05 { get; set; }

        [StringLength(50)]
        public string ASUSER06 { get; set; }

        [StringLength(50)]
        public string ASUSER07 { get; set; }

        [StringLength(50)]
        public string ASUSER08 { get; set; }

        [StringLength(50)]
        public string ASUSER09 { get; set; }

        [StringLength(50)]
        public string ASUSER10 { get; set; }

        [StringLength(200)]
        public string SROLE { get; set; }
    }
}
