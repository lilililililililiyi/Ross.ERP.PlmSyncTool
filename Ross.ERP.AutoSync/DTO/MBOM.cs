﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ross.ERP.AutoSync.DTO
{
    public class MBOM
    {
        public string Company { get; set; }
        public string ECOGroupID { get; set; }
        public string Plant { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public int MtlSeq { get; set; }
        public string MtlPartNum { get; set; }
        public decimal QtyPer { get; set; }
        public int RelatedOperation { get; set; }
        public string PullAsAsm { get; set; }
        public string ViewAsAsm { get; set; }
    }    
}
