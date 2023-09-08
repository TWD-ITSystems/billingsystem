using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingSystem
{
    class CDAV
    {
        private String SID;
        private double amountDue;
        private DateTime dueDate;

        public string Generate()
        {
            int[] sid_fxweight = new int[] { 0, 10, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] chk2_fxweight = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 2, 3, 4 };
            String newSID;

            String result;
            int product = 0;
            int chk_digit1;
            int chk_digit2;
            int digit = 0;

            newSID = SID.ToString();
            newSID = SID.PadLeft(10, '0');


            for (int i = 0; i < 10; i++)
            {
                char c = newSID[i];
                digit = Convert.ToInt16(c.ToString());
                product = product + (digit * sid_fxweight[i]);               
            }
           
            chk_digit1 = product % 9;
            if (chk_digit1 == 0 || chk_digit1 == 10) chk_digit1 = 9;

            DateTime dateMinus13 = dueDate.AddDays(-13);
            string strminus13 = dateMinus13.ToString("yyMMdd");
            int integerdateMinus13 = int.Parse(strminus13);
            int amtx100 = Convert.ToInt32(amountDue * 100);
            int sidchk1 = int.Parse(newSID + chk_digit1.ToString());


            int total2 = sidchk1 + integerdateMinus13 + Math.Abs(amtx100);
            string strTotal2 = total2.ToString().PadLeft(11, '0');
            string strTotalReverse = Reverse(strTotal2);

            product = 0;
            for (int x = 0; x < 11; x++)
            {
                char c = strTotalReverse[x];
                digit = int.Parse(c.ToString());
                product = product + (digit * chk2_fxweight[x]);
            }

            chk_digit2 = product % 11;
            if (chk_digit2 == 0 || chk_digit2 == 10) chk_digit2 = 9;          
            result = newSID + chk_digit1.ToString() + dateMinus13.ToString("MMdd") + chk_digit2.ToString();
            return result;
        }


        public string Reverse(string str)
        {
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

#region get/set methods
        public String SID1
        {
            get { return SID; }
            set { SID = value; }
        }       
        public double AmountDue
        {
            get { return amountDue; }
            set { amountDue = value; }
        }      

        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }
#endregion
    } // end class CDAV


}
