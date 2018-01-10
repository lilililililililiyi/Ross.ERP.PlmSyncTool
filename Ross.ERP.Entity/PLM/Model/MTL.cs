namespace Ross.ERP.Entity.PLM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ROSSPLM.MTL")]
    public partial class MTL
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
        public string SPECS { get; set; }

        [StringLength(50)]
        public string MTLMARK { get; set; }

        [StringLength(50)]
        public string UNITNAME { get; set; }

        [StringLength(50)]
        public string FSIZE { get; set; }

        [StringLength(50)]
        public string DENSITY { get; set; }

        [StringLength(50)]
        public string MPRECISION { get; set; }

        [StringLength(50)]
        public string COLOR { get; set; }

        public decimal? MTLK { get; set; }

        [StringLength(50)]
        public string INTENSITY { get; set; }

        public decimal? MPRICE { get; set; }

        [StringLength(50)]
        public string XH { get; set; }

        [StringLength(50)]
        public string GG { get; set; }

        [StringLength(50)]
        public string CL { get; set; }

        [StringLength(50)]
        public string ZZS { get; set; }
    }
}
