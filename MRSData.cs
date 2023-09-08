using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem
{
    class MRSData
    {
        // From tbMRSDownload
        public int ave;
        public string status;
        public string acctno;
        public string zone;
        public decimal senior;
        //public string ledgrp;
        public string name;
        public string address;
        public string metno;
        public string ctgry;
        public int cardno;
        public decimal mon_arr;
        public decimal crrent;
        public decimal days30;
        public decimal days60;
        public decimal days90;
        public decimal arrears;
        public decimal penalty;
        public decimal metdep;
        public decimal dam_met;
        public decimal others;
        public decimal instfee;
        public DateTime datepres;
        public DateTime dateprev;
        public DateTime duedate;
        public DateTime discdate;
        public int presrdg;
        public int prevrdg;
        public int volume;
        public string remark;
        public string refno;
        public string collagents;
        public int masterID;

        //From tbMrsUpload
        public string billno;
        public string billamount;
        public string readtime;
        public string ffcode;
        public string mccode;
        public string encoder;
        public string dateuploaded;

        public MRSData()
        {
            

        }
    }

    
}
