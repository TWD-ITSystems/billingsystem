using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem.models
{
    class NotificationTransaction
    {
        public int notifytrans_id { get; set; }
        public int msgclass_id { get; set; }
        public string values_list { get; set; }
        public int sendtype_id { get; set; }
        public string destination { get; set; }
        public DateTime date_sent { get; set; }
        public int status { get; set; }
        public string added_by { get; set; }
        public DateTime added_date { get; set; }
        public int master_id { get; set; }
    }
}
