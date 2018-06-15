using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ross.ERP.Entity.RossLive.Model
{
    public class RossNewParts
    {
        public int ID { get; set; }
        [StringLength(10)]
        public string Company { get; set; }
        [StringLength(50)]
        public string PartNum { get; set; }
        [StringLength(500)]
        public string PartDescription { get; set; }
        [StringLength(4)]
        public string ClassId { get; set; }
        [StringLength(10)]
        public string UOMClassID { get; set; }
        [StringLength(6)]
        public string IUM { get; set; }
        [StringLength(2)]
        public string TypeCode { get; set; }
        public DateTime? SysTime { get; set; }

    }
}
