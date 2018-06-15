using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Ross.ERP.Entity.PLM.Model
{
    [Table("ROSSPLM.V_BOO")]
    public class V_BOO
    {
        [Key]
        public string ID { get; set; }
        public string COMPANY { get; set; }
        public string ECOGROUPID { get; set; }
        public string PLANT { get; set; }
        public string PARTNUM { get; set; }
        public string REVISIONNUM { get; set; }
        public int OPRSEQ { get; set; }
        public string OPCODE { get; set; }
        public decimal PRODSTANDARD { get; set; }
        public string STDFORMAT { get; set; }
        public string LABORENTRYMETHOD { get; set; }
        public string COMMENTTEXT { get; set; }
        public string SUBCONTRACT { get; set; }
        public int DAYSOUT { get; set; }
        public int VENDORNUMVENDORID { get; set; }
        public DateTime MTIME { get; set; }
    }
}
