namespace Ross.ERP.Entity.PLM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ROSSPLM.MPART")]
    public partial class MPART
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
        public string DEGREE { get; set; }

        [StringLength(50)]
        public string DSNWEIGHT { get; set; }

        [StringLength(200)]
        public string MTLMARK { get; set; }

        [StringLength(200)]
        public string ORIGIN { get; set; }

        [StringLength(200)]
        public string ORIGINNAME { get; set; }

        [StringLength(50)]
        public string SOURCE { get; set; }

        [StringLength(50)]
        public string UNIT { get; set; }

        [StringLength(200)]
        public string STANDARDNO { get; set; }

        [StringLength(200)]
        public string SPECS { get; set; }

        [StringLength(200)]
        public string COLORNO { get; set; }

        [StringLength(200)]
        public string ITEMNO { get; set; }

        [StringLength(15)]
        public string STNDCOST { get; set; }

        [StringLength(200)]
        public string EORIGINNO { get; set; }

        [StringLength(200)]
        public string ADMSMEMO { get; set; }

        [StringLength(50)]
        public string EPARTID { get; set; }

        [StringLength(50)]
        public string FACEAREA { get; set; }

        [StringLength(50)]
        public string CUBAGE { get; set; }

        [StringLength(50)]
        public string BARYCENTERX { get; set; }

        [StringLength(50)]
        public string BARYCENTERY { get; set; }

        [StringLength(50)]
        public string BARYCENTERZ { get; set; }

        public bool? ISPARAM { get; set; }

        [StringLength(2000)]
        public string PARAMIN { get; set; }

        [StringLength(2000)]
        public string PARAMEXP { get; set; }

        [StringLength(2000)]
        public string PARAMOUT { get; set; }

        [StringLength(50)]
        public string GYLX { get; set; }

        public DateTime? ADUSER01 { get; set; }

        public DateTime? ADUSER02 { get; set; }

        public DateTime? ADUSER03 { get; set; }

        public DateTime? ADUSER04 { get; set; }

        public DateTime? ADUSER05 { get; set; }

        public decimal? AFUSER01 { get; set; }

        public decimal? AFUSER02 { get; set; }

        public decimal? AFUSER03 { get; set; }

        public decimal? AFUSER04 { get; set; }

        public decimal? AFUSER05 { get; set; }

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

        public bool? CZZT { get; set; }

        [StringLength(200)]
        public string ITEMGROUP { get; set; }

        [StringLength(50)]
        public string PMUSER { get; set; }

        public DateTime? PMTIME { get; set; }

        [StringLength(200)]
        public string PARTFNAME { get; set; }
    }
}
