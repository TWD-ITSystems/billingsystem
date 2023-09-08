using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.models
{
    class ManualBillData
    {
        public string billmonth { get; set; }
        public string acctno { get; set; }
        public string cardno { get; set; }
        public string mtrno { get; set; }
        public string prevDate { get; set; }
        public string presDate { get; set; }
        public int prevReading { get; set; }
        public int presReading { get; set; }
        public string dueDate { get; set; }
        public decimal current { get; set; }
        public decimal arrears { get; set; }
        public decimal instfee { get; set; }
        public decimal mtrmtn { get; set; }
        public decimal totalAmt { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string payAgents { get; set; }
        public string zonebook { get; set; }
        public int volume { get; set; }
        public decimal mtrDamage { get; set; }
    }
}
