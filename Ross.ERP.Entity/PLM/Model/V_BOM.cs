using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Ross.ERP.Entity.PLM.Model
{
    [Table("ROSSPLM.V_BOM")]
    public class V_BOM
    {
        [Key]
        public string ID { get; set; }
        public string COMPANY { get; set; }
        public string ECOGROUPID { get; set; }
        public string PLANT { get; set; }
        public string PARTNUM { get; set; }
        public string REVISIONNUM { get; set; }
        public int MTLSEQ { get; set; }
        public string MTLPARTNUM { get; set; }
        public decimal QTYPER { get; set; }
        public int RELATEDOPERATION { get; set; }
        public string PULLASASM { get; set; }
        public string VIEWASASM { get; set; }
        public DateTime MTIME { get; set; }
    }
}
