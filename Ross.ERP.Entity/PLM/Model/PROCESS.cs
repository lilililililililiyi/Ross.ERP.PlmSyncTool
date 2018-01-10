namespace Ross.ERP.Entity.PLM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ROSSPLM.PROCESS")]
    public partial class PROCESS
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

        [StringLength(50)]
        public string BNUM { get; set; }

        [StringLength(50)]
        public string OPNUM { get; set; }

        [StringLength(50)]
        public string STEPNO { get; set; }

        [StringLength(50)]
        public string STEPNAME { get; set; }

        [StringLength(50)]
        public string DEPTNO { get; set; }

        [StringLength(200)]
        public string DEPTNAME { get; set; }

        public decimal? PRET { get; set; }

        public decimal? MACHT { get; set; }

        public decimal? GNO { get; set; }

        [StringLength(2000)]
        public string DETAILS { get; set; }

        [StringLength(200)]
        public string DEVICENO { get; set; }

        [StringLength(200)]
        public string DEVICENAME { get; set; }

        [StringLength(100)]
        public string DEVICMODE { get; set; }

        [StringLength(50)]
        public string STEPNUM { get; set; }

        public bool? CZZT { get; set; }

        public short? SCCC { get; set; }
    }
}
