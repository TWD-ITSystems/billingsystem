using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem
{
    class BillFile
    {
        public int AVE{get;set;}
        public int CTR { get; set; }
        public string STATUS { get; set; }
        public string ACCTNO { get; set; }
        public string ZONE { get; set; }
        public string LEDGRP { get; set; }
        public string NAME { get; set; }
        public string ADDRESS { get; set; }
        public string METNO { get; set; }
        public string CTGRY { get; set; }
        public int CARDNO { get; set; }
        public decimal ARREARS { get; set; }
        public int PREVRDG { get; set; }
        public DateTime DATEPREV { get; set; }
        public decimal DAYS30 { get; set; }
        public decimal DAYS60 { get; set; }
        public decimal DAYS90 { get; set; }    
        public decimal IF2_BAL { get; set; }
        public decimal IF2_PAY { get; set; }
        public decimal IF2_TPAY { get; set; }
        public int IF2_MONS { get; set; }
        public DateTime IF2_DT_STR { get; set; }
        public decimal OTHERS { get; set; }
        public decimal CURRENT { get; set; }
    }
}
