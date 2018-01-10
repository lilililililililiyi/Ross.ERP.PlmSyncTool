namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StockPart")]
    public partial class StockPart
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string PartNum { get; set; }

        [StringLength(10)]
        public string UserID { get; set; }

        public DateTime SysTime { get; set; }        
        public StockPart()
        {
            SysTime = DateTime.Now;
        }
    }
}
