namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.UserFile")]
    public partial class UserFile
    {
        [Key]
        [StringLength(75)]
        public string DcdUserID { get; set; }
        public string Name { get; set; }
    }
}
