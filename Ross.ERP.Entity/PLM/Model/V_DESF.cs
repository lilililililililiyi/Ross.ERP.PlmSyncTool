using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Ross.ERP.Entity.PLM.Model
{
    public class V_DESF
    {
        [Key]
        public string ID { get; set; }
        public string NO { get; set; }
        public string NAME { get; set; }
        public string FNAME { get; set; }
        public string CREATOR { get; set; }
        public string MUSER { get; set; }
        public string DESGROUP { get; set; }
        public DateTime UTIME { get; set; }
        public int MINDIFF { get; set; }
        public int HOURDIFF { get; set; }
        public int DAYDIFF { get; set; }
    }
}
