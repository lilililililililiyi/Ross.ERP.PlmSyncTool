using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Ross.ERP.Entity.PLM.Model
{
    [Table("ROSSPLM.V_PART")]
    public class V_PART
    {
        [Key]
        public string ID { get; set; }
        public string COMPANY { get; set; }
        public string PARTNUM { get; set; }
        public string PARTDESCRIPTION { get; set; }
        public string CLASSID { get; set; }
        public string UOMCLASSID { get; set; }
        public string SALESUM { get; set; }
        public string IUM { get; set; }
        public string PUM { get; set; }
        public string TYPECODE { get; set; }
        public string COSTMETHOD { get; set; }
        public string TRACKLOTS { get; set; }
        public string NONSTOCK { get; set; }
        public string PARTPLANT_NONSTOCK { get; set; }
        public string PARTPLANT_COSTMETHOD { get; set; }
        public string PARTPLANT_PLANT { get; set; }
        public string PARTPLANT_PRIMWHSE { get; set; }
        public string PARTREV_REVISIONNUM { get; set; }
        public string PARTREV_REVSHORTDESC { get; set; }
        public string PARTREV_APPROVED { get; set; }
        public string PARTREV_EFFECTIVEDATE { get; set; }        
        public string PARTWHSE_WAREHOUSECODE { get; set; }
        public DateTime UTIME { get; set; }
    }
}
