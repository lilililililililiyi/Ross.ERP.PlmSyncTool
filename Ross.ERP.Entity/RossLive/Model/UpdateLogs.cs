namespace Ross.ERP.Entity.RossLive.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UpdateLogs
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string LogTitle { get; set; }

        [Column(TypeName = "text")]
        public string PartNums { get; set; }

        [Column(TypeName = "text")]
        public string ErrorLog { get; set; }

        [Column(TypeName = "text")]
        public string CompleteLog { get; set; }

        [StringLength(8)]
        public string Status { get; set; }

        public DateTime? SysTime { get; set; }

        public UpdateLogs()
        {
            SysTime = DateTime.Now;
        }
    }
}
