using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace BillingSystem
{
    class GlobalFunctions
    {
        const decimal MINIMUM_VOLUME = 10;
        const string DELETE_PASSWORD = "billing";

        
        public bool deleteBillEntry(int billdetail_id)
        {           
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                try
                {
                    tbBillingDetail billdetail = dbcontext.tbBillingDetails.First(i => i.billingdetails_id == billdetail_id);
                    dbcontext.tbBillingDetails.DeleteObject(billdetail);
                    dbcontext.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }  // end deleteBillEntry

        public string getPassword(string mode)
        {
            string temp = "";
            if (mode.Equals("delete"))
            {
                temp = DELETE_PASSWORD;
            }
            return temp;
        }   // end getPassword

        public int getMasterID(string acctno)
        {
            int master_id = 0;
            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                try
                {
                    int query = (from tbmaster in context.tbMasters
                                 where tbmaster.acctno.Equals(acctno)
                                 select tbmaster.master_id).Single();
                    master_id = query;
                }
                catch {
                    master_id = 0;
                }
            }
            return master_id;
        } // end getMasterID

        public string getMasterName(int masterID)
        {
            string name = "";
            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                try
                {
                    string query = (from tbmaster in context.tbMasters
                                 where tbmaster.master_id == masterID
                                 select tbmaster.name).Single();
                    name = query;
                }
                catch { }
            }
            return name;
        }

        public string getMasterAddress(int masterID)
        {
            string result = "";
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                string address = dbcontext.tbMasters.SingleOrDefault(x => x.master_id == masterID).address;
                result = address;
            }
            return result;
        }

        public string getZoneName(int zoneID)
        {
            string zone_name = "";
            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                try
                {
                    string query = (from tbzone in context.tbZones
                                    where tbzone.zone_id == zoneID
                                    select tbzone.zone_name).Single();
                    zone_name = query;    
                }
                catch { }                
            }
            return zone_name;
        } // end getZoneName

        public string getZoneName(string acctno)
        {
            string zone_name = "";
            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                try
                {
                    string query = (from tbzone in context.tbZones
                                    join tbmaster in context.tbMasters on tbzone.zone_id equals tbmaster.zone_id
                                    where tbmaster.acctno.Equals(acctno)
                                    select tbzone.zone_name).Single();
                    zone_name = query;
                }
                catch { }
            }
            return zone_name;
        } // end getZoneName
        
        public decimal getMeterMtn()
        {
            decimal meter_mtn = 0;

            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                var query = (from tbsettings in context.tbSettings
                                        select tbsettings.meter_mtn).Single();

                meter_mtn = (decimal)query;
            }
            return meter_mtn;
        } // end getMeterMtn

        public decimal processCurrent(int master_id, int vol)
        {
            int category = 0;
            string meter_no = "";
            decimal minimum = 0, r11_20 = 0, r21_30 = 0, r31_40 = 0, r41_50 = 0, r51_up = 0, mtrmain = 0;
            int minmax = 0;
            using (dbCommercialEntities dbContext = new dbCommercialEntities())
            {
                var query = (from en in dbContext.tbMasters
                             join o in dbContext.tbMeters on en.meter_id equals o.meter_id
                             where en.master_id == master_id
                             select new { category = en.category, mtr_no = o.meterno }).Single();

                category = Convert.ToInt32(query.category);
                meter_no = query.mtr_no;

                string str_category = category.ToString();
                string str_metercode = meter_no.Substring(0, 1);
                var rates = (from re in dbContext.tbRates
                             where re.category_code.Equals(str_category) &&
                                   re.rate_code.Equals(str_metercode) &&
                                   re.min_vol <= vol && re.max_vol >= vol
                             select new
                             {
                                 min_pay = re.minimum_pay,
                                 min_vol = re.max_vol,
                                 r11_20 = re.r11_20,
                                 r21_30 = re.r21_30,
                                 r31_40 = re.r31_40,
                                 r41_50 = re.r41_50,
                                 r51_up = re.r51_up,
                                 mtrmain = re.mrental
                             }).SingleOrDefault();
                if (rates != null)
                {
                    minimum = decimal.Parse(rates.min_pay.ToString());
                    minmax = int.Parse(rates.min_vol.ToString());
                    r11_20 = decimal.Parse(rates.r11_20.ToString());
                    r21_30 = decimal.Parse(rates.r21_30.ToString());
                    r31_40 = decimal.Parse(rates.r31_40.ToString());
                    r41_50 = decimal.Parse(rates.r41_50.ToString());
                    r51_up = decimal.Parse(rates.r51_up.ToString());
                    mtrmain = decimal.Parse(rates.mtrmain.ToString());
                }
                else
                {
                    return 0;
                }

                decimal test = vol / MINIMUM_VOLUME;
                int intPart = (int)Math.Truncate(test);
                int fracPart = (int)vol % (int)MINIMUM_VOLUME;
                decimal newCurrent = minimum;
                int tempVol = vol;
                tempVol = tempVol - (int)MINIMUM_VOLUME; // deduct minimum            
                if (vol >= 51)
                {
                    tempVol = vol - 50;
                    newCurrent = newCurrent + (r11_20 * 10) + (r21_30 * 10) + (r31_40 * 10) + (r41_50 * 10);
                    newCurrent = newCurrent + (tempVol * r51_up);
                }
                else if (vol > 10)
                {
                    for (int i = 1; i <= intPart; i++)
                    {

                        switch (i)
                        {
                            case 1:
                                if (tempVol >= 10)
                                {

                                    newCurrent += r11_20 * 10;
                                    tempVol -= 10;
                                }
                                else
                                {
                                    newCurrent += r11_20 * tempVol;
                                }
                                break;
                            case 2:
                                if (tempVol >= 10)
                                {
                                    newCurrent += r21_30 * 10;
                                    tempVol -= 10;
                                }
                                else
                                {
                                    newCurrent += r21_30 * tempVol;
                                }
                                break;
                            case 3:
                                if (tempVol >= 10)
                                {
                                    newCurrent += r31_40 * 10;
                                    tempVol -= 10;
                                }
                                else
                                {
                                    newCurrent += r31_40 * tempVol;
                                }
                                break;
                            case 4:
                                if (tempVol >= 10)
                                {
                                    newCurrent += r41_50 * 10;
                                    tempVol -= 10;
                                }
                                else
                                {
                                    newCurrent += r41_50 * tempVol;
                                }
                                break;
                            case 5:
                                if (tempVol >= 10)
                                {
                                    newCurrent += r51_up * 10;
                                    tempVol -= 10;
                                }
                                else
                                {
                                    newCurrent += r51_up * tempVol;
                                }
                                break;

                        } // switch

                    }  // for

                } // if

                return newCurrent;
            }  //using
        } // end Process Current

        public decimal computeSenior(decimal master_id,decimal current,int vol)
        {
            decimal senior_discount = 0;

            using(dbCommercialEntities context = new dbCommercialEntities())
            {
                var masacct = (from mast in context.tbMasterAccts
                              where mast.master_id == master_id
                              select new { isSenior = mast.isSenior}).Single();
                if (masacct.isSenior == true)
                {
                    var query = (from en in context.tbSettings
                                 where en.settings_id == 1
                                 select new
                                 {
                                     senior_percent = en.senior_percentage,
                                     senior_vol_cap = en.senior_volume_cap
                                 }).Single();

                    if (vol <= query.senior_vol_cap)
                    {
                        senior_discount = current * ((decimal)query.senior_percent / 100);
                    }
                }
            }
            return senior_discount;
        }   // end computeSenior

        public decimal computePenalty(decimal current)
        {
            decimal penalty = 0,penalty_percent=0;
            

            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                var query = (from en in context.tbSettings
                             where en.settings_id == 1
                             select new { penalty_percent = en.penalty_percentage,
                                          mtrMtn = en.meter_mtn
                             }).Single();
                penalty_percent = (decimal)query.penalty_percent;
               // penalty = (current - (decimal)query.mtrMtn) * (penalty_percent / 100);
                penalty = current * (penalty_percent / 100);
             }
            return roundOff(penalty);
        }    // end computePenalty

        public int getAverageVolume(int master_id)
        {
            int ave_vol = 0;

            try
            {
                using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                {
                    int query = (int)(from tbMastAcct in dbcontext.tbMasterAccts
                                 where tbMastAcct.master_id == master_id
                                 select tbMastAcct.ave_vol).Single();
                    ave_vol = query;
                }
            }
            catch { }
            return ave_vol;
        }   // end getAverageVolume

        public decimal getIF2(int master_id)
        {
            decimal if2pay = 0;

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbMasterAcct IFRecord = (from m_act in dbcontext.tbMasterAccts
                                          where m_act.master_id == master_id
                                          select m_act).Single();

                if ((IFRecord.isIF == false) && (IFRecord == null)) return 0;
                if (IFRecord.IFBalance >= IFRecord.IFMonthlyPay)
                {
                    if2pay = IFRecord.IFMonthlyPay.HasValue?(decimal)IFRecord.IFMonthlyPay:0;                    
                }
                else
                {
                    if2pay = IFRecord.IFBalance.HasValue ? (decimal)IFRecord.IFBalance:0;
                }

            }
            return if2pay;
        } // end getIF2

      


        public decimal getDmgMtr(int master_id)
        {
            decimal dmgmtrpay = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbMasterAcct dmgRecord = (from em in dbcontext.tbMasterAccts
                                          where em.master_id == master_id
                                          select em).SingleOrDefault();
                if ((dmgRecord.isIF == false) && (dmgRecord == null)) return 0;
                if (dmgRecord.MtrDmg_Balance >= dmgRecord.MtrDmg_Monthly)
                {
                    dmgmtrpay = dmgRecord.MtrDmg_Monthly.HasValue ? (decimal)dmgRecord.MtrDmg_Monthly : 0;
                }
                else
                {
                    dmgmtrpay = dmgRecord.MtrDmg_Balance.HasValue ? (decimal)dmgRecord.MtrDmg_Balance : 0;
                }
            }
            return dmgmtrpay = 0;
        }//end getDmgMtr

        public string getPrevDate(int masterID)
        {
            string result = "";

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var prevDate = dbcontext.tbMasters.FirstOrDefault(x => x.master_id == masterID).prev_read_date;
                if (prevDate.HasValue)
                {
                    result = prevDate.Value.ToShortDateString();
                }               
            }
            return result;
        }

        public decimal getArrears(int master_id)
        {
            decimal arrears = 0,bill_balance=0;


            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbMasterAcct arrears_rec = (from tbMastAct in dbcontext.tbMasterAccts
                                            where tbMastAct.master_id == master_id
                                            select tbMastAct).Single();

                bill_balance = arrears_rec.bill_balance.HasValue?(decimal)arrears_rec.bill_balance:0;                                              
                arrears = bill_balance;
            }
            return arrears;
        } // end getArrears    

        public string getLastReadDate(int master_id,int billing_id)
        {
            string temp = "";            
            DateTime? readDate = new DateTime();
            DateTime? recoDate = new DateTime();
            DateTime? discoDate = new DateTime();
            DateTime? instDate = new DateTime();
            DateTime? billstart;
            DateTime? billend;

            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                var query = (from en in context.tbMasters
                             where en.master_id == master_id
                             select en).SingleOrDefault();

                var queryBilling = (from en in context.tbBillings
                                    where en.billing_id == billing_id
                                    select en).SingleOrDefault();

                if (queryBilling != null)
                {
                    billstart = queryBilling.billing_start.Value;
                    billend = queryBilling.billing_end.Value;
                }
                else
                {
                    billstart = null;
                    billend = null;
                }

                if (query != null)
                {
                    readDate = query.last_read_date.HasValue ? (DateTime?)query.last_read_date : null;
                    recoDate = query.last_reco_date.HasValue ? (DateTime?)query.last_reco_date : null;
                    discoDate = query.last_disco_date.HasValue ? (DateTime?)query.last_disco_date : null;
                    instDate = query.date_installed.HasValue ? (DateTime?)query.date_installed : null;
                }

                if (recoDate != null && discoDate != null)
                {
                    if (discoDate > recoDate)
                    {
                        if (discoDate > billstart)
                        {
                            temp = discoDate.Value.ToShortDateString();
                        }
                    }
                    else
                    {
                        if (recoDate > billstart)
                        {
                            temp = billend.Value.ToShortDateString();
                        }
                    }
                    return temp.ToString();
                }
                else if (recoDate == null && discoDate == null)
                {
                    temp = instDate.Value.ToShortDateString();
                    return temp.ToString();
                }
                else if (recoDate == null && discoDate != null)
                {
                    if (discoDate > instDate)
                    {
                        temp = discoDate.Value.ToShortDateString();
                    }
                }
            }   
            return temp.ToString();
        }   // end getLastReadDate

        public string getPreviousReadDate(int master_id, int billing_id)
        {
            string temp = "";
            DateTime? readDate = new DateTime();
            DateTime? recoDate = new DateTime();
            DateTime? discoDate = new DateTime();
            DateTime? instDate = new DateTime();
            DateTime? billstart;
            DateTime? billend;

            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                var query = (from en in context.tbMasters
                             where en.master_id == master_id
                             select en).SingleOrDefault();

                var queryBilling = (from en in context.tbBillings
                                    where en.billing_id == billing_id
                                    select en).SingleOrDefault();

                if (queryBilling != null)
                {
                    billstart = queryBilling.billing_start.Value;
                    billend = queryBilling.billing_end.Value;
                }
                else
                {
                    billstart = null;
                    billend = null;
                }

                if (query != null)
                {
                    readDate = query.last_read_date.HasValue ? (DateTime?)query.last_read_date : null;
                    recoDate = query.last_reco_date.HasValue ? (DateTime?)query.last_reco_date : null;
                    discoDate = query.last_disco_date.HasValue ? (DateTime?)query.last_disco_date : null;
                    instDate = query.date_installed.HasValue ? (DateTime?)query.date_installed : null;
                }

                if (recoDate != null && discoDate != null)
                {
                    if (discoDate > recoDate)
                    {
                        if (discoDate > billstart)
                        {
                            temp = discoDate.Value.ToShortDateString();
                        }
                    }
                    else
                    {
                        if (recoDate > billstart)
                        {
                            temp = billend.Value.ToShortDateString();
                        }
                    }
                    return temp.ToString();
                }
                else if (recoDate == null && discoDate == null)
                {
                    temp = instDate.Value.ToShortDateString();
                    return temp.ToString();
                }
                else if (recoDate == null && discoDate != null)
                {
                    if (discoDate > instDate)
                    {
                        temp = billstart.Value.ToShortDateString();
                    }
                }
            }
            return temp.ToString();
        }   // end getPreviousReadDate

        public string getMeterNumber(int mtr_id)
        {
            string retval = "";

            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                var query = (from en in context.tbMeters
                             where en.meter_id == mtr_id
                             select en).SingleOrDefault();
                if (query != null)
                {
                    retval = query.meterno;
                }
                else
                {
                    retval = "";
                }
            }

            return retval;
        } // end getMeterNumber

        public string getMeterNumber(string acctno)
        {
            string retval = "";

            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                var masterid = context.tbMasters.FirstOrDefault(x => x.acctno.Equals(acctno)).master_id;
                if (masterid > 0)
                {
                    var meterno = context.tbMeters.OrderByDescending(p=>p.meter_id).FirstOrDefault(x => x.master_id == masterid).meterno;
                    if (meterno != null)
                    {
                        retval = meterno.ToString();
                    }
                }
            }

            return retval;
        } // end getMeterNumber

        public decimal roundOff(decimal curr)
        {
            decimal a, b, c;
            string str = "";
            a = curr;            
            b = a - Math.Floor(a);
            c = Math.Round(a, 2, MidpointRounding.ToEven);
            a = c;
            str = c.ToString("0.00").Substring(c.ToString("0.00").Length-1,1);
            switch (Convert.ToInt32(str))
            {
                case 0: break;
                case 1: a = a - 0.01m;break;                    
                case 2: a = a - 0.02m;break;                    
                case 3: a = a + 0.02m;break;                    
                case 4: a = a + 0.01m;break;                    
                case 5: break;
                case 6: a = a - 0.01m;break;                    
                case 7: a = a - 0.02m;break;                    
                case 8: a = a + 0.02m;break;
                case 9: a = a + 0.01m; break;
            }
            return a;
        }   //end roundOff

        public string getMtrReaderEncoderName(int mode, int uid)
        {
            string str="";

            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                if (mode == 0) // get Meter Reader name;
                {
                    string query = (from en in context.tbMeterReaders
                                    where en.mr_id == uid
                                    select en.initials).Single();
                    str = query;
                }
                else if (mode == 1)
                {
                    string query = (from en in context.tbUsers
                                    where en.user_id == uid
                                    select en.initials).Single();
                    str = query;
                }
            }
            return str;
        } // end  getMtrReaderEncoderName      

        public DateTime? getBillDeliveryDate(int billingID, int zoneID)
        {
            DateTime? deliveryDate = new DateTime();

            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                try
                {
                    var query = (from en in context.tbBillingSchedules
                                 where en.billing_id == billingID && en.zone == getZoneUID(zoneID)
                                 select en.date_bill_serve).Single();
                    deliveryDate = (DateTime)query;
                }
                catch
                {
                    deliveryDate = null;
                }
            }
            return deliveryDate;
        }  // end getBillDeliveryDate

        public DateTime? getZoneReadingDate(int billingID, int zoneID)
        {
            DateTime? readingDate = new DateTime();

            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                var query = (from en in context.tbBillingSchedules
                             where en.billing_id == billingID && en.zone == getZoneUID(zoneID)
                             select en.date_rdg).SingleOrDefault();
                readingDate = query;
            }
            return readingDate;
        } // end getZoneReadingDate

        public int getBillingID(int billproc_id)
        {
            int retval = 0;

            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                var query = (from en in context.tbBillProcessings
                             where en.bill_process_id == billproc_id
                             select en.billing_id).SingleOrDefault();
                if (query.HasValue)
                {
                    retval = query.Value;
                }
            }

            return retval;

        } // end getBillingID(billproc_id)

        public string getBillMonth(int billing_id)
        {
            string retval = "";

            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                var query = (from en in context.tbBillings
                             where en.billing_id == billing_id
                             select en.billing_desc).SingleOrDefault();
                if (query != null)
                {
                    retval = query;
                }
            }

            return retval;
        }

        public int getBillingID(string billmonth)
        {
            int retval = 0;

            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                var query = (from en in context.tbBillings 
                             where en.billing_desc.Equals(billmonth)
                             select en).SingleOrDefault();
                if (query != null)
                {
                    retval = query.billing_id;
                }
            }

            return retval;

        } // end getBillingID(billmonth)

        public DateTime? getDateInstalled(int master_id)
        {
            DateTime? installDate = new DateTime();
            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                try
                {
                    var query = (from en in context.tbMasters
                                 where en.master_id == master_id
                                 select en.date_installed).Single();
                    installDate = (DateTime)query;
                }
                catch
                {
                    installDate = null;
                }
            }
            return installDate;
        }   // end getDateInstalled

        public int getZoneUID(int zoneID)
        {
            int zUID = 0;

            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                var query = (from en in context.tbZones
                             where en.zone_id == zoneID
                             select en.zone_uid).SingleOrDefault();
                if (query != null)
                {
                    zUID = (int)query;
                }
            }
            return zUID;
        } // end getZoneUID

        public int getZoneUID(string zone)
        {
            int zUID = 0;

            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                var query = (from en in context.tbZones
                             where en.zone_name.Equals(zone)
                             select en.zone_uid).SingleOrDefault();
                if (query != null)
                {
                    zUID = (int)query;
                }
            }
            return zUID;
        } // end getZoneUID

        public int checkBillFinalized(int billing_id,string zone)
        {
            int retval = 0;
            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                var query = (from en in context.tbBillProcessings
                             where en.billing_id == billing_id && en.zone_book == zone
                             select en).SingleOrDefault();

                if (query == null) return 0;
                retval = query.date_checked.HasValue ? query.bill_process_id : 0;
            }
            return retval;
        } // end checkIfProcessed

        public DateTime? getBillPrinted(int billproc_id)
        {
            DateTime? retval = new DateTime();
            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                var query = (from en in context.tbBillProcessings
                             where en.bill_process_id == billproc_id
                             select en.date_printed).SingleOrDefault();
                if (query.HasValue)
                {
                    retval = Convert.ToDateTime(query.Value.ToShortDateString());
                }
                else
                {
                    retval = null;
                }
            }
            return retval;
        }       // end getBillPrinted...

        public int generateUID()  //based on year,month,day,random num(1-500)
        {
            string tempStr="";
            int retval = 0;
            DateTime curr = new DateTime();

            curr = DateTime.Now;
            tempStr = string.Format("{0}{1}{2}{3}", curr.Year, curr.Month, curr.Day,new Random().Next(1,500));
            retval = int.TryParse(tempStr, out retval) ? retval : 0;

            return retval;
        } //end generateUID

        public decimal getMinimumPay()
        {
            decimal retval = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = (from en in dbcontext.tbRates
                             orderby en.rate_id
                             select en).FirstOrDefault();
                if (query != null)
                {
                    retval = Convert.ToDecimal(query.minimum_pay);
                }
            }
            return retval;
        }

        public string getMRS_IPADDRESS()
        {
            string retval = "";
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbSetting settings = dbcontext.tbSettings.First();
                retval = settings.mrs_ipaddress;
            }
            return retval;
        }

        public decimal getSENIOR_PERCENTAGE()
        {
            decimal retval = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbSetting settings = dbcontext.tbSettings.First();
                retval = Convert.ToDecimal(settings.senior_percentage);
            }
            return retval;
        }

        public void saveLastLogin(int userID)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbUser query = (from em in dbcontext.tbUsers
                                where em.user_id == userID
                                select em).SingleOrDefault();
                query.last_program_used = "Billing";
                query.last_login = DateTime.Now;
                query.last_computer_used = Environment.MachineName;
                dbcontext.SaveChanges();
            }

        }

        public decimal getPenaltyPercent()
        {
            decimal penalty_percent = 0;


            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                var query = (from en in context.tbSettings
                             where en.settings_id == 1
                             select new
                             {
                                 penalty_percent = en.penalty_percentage
                             }).Single();
                penalty_percent = (decimal)query.penalty_percent;
                // penalty = (current - (decimal)query.mtrMtn) * (penalty_percent / 100);
            }
            return penalty_percent;
        }

        public int getMeterReaderID(string initials)
        {

            int idnum = 0;

            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                int query = context.tbMeterReaders.Where(x => x.initials.Equals(initials)).Select(x => x.mr_id).SingleOrDefault();

                    idnum = query;

                
            }
            return idnum;
        }

        public string getMtrReaderByZone(string zonebook)
        {
            string result = "";
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = (from em in dbcontext.tbZones
                             join en in dbcontext.tbMeterReaders on em.mtr_reader equals en.mr_id
                             where em.zone_name.Equals(zonebook)
                             select new
                             {
                                 mtrInitial = en.initials
                             }).SingleOrDefault();

                if (query != null)
                {
                    result = query.mtrInitial;
                }
            }
            return result;
        }

        public void saveLogFile(string filename,string data,bool mode=true)
        {
            using (StreamWriter tr = new StreamWriter(filename,mode))
            {
                tr.WriteLine(data);
            }
        } // end ErrorLog

        public int saveNewMeterNo(int masterID,string metno)
        {
            int retval = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbMeter newMeter = new tbMeter();
                newMeter.meterno = metno;
                newMeter.master_id = masterID;
                dbcontext.AddTotbMeters(newMeter);
                dbcontext.SaveChanges();
                retval = newMeter.meter_id;
            }
            return retval;
        }

        public int saveNewMeterNo(int masterID, string metno,string oldmeter,DateTime date_installed,string remarks)
        {
            int retval = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbMeter newMeter = new tbMeter();
                newMeter.meterno = metno;
                newMeter.master_id = masterID;
                newMeter.date_installed = date_installed.Date;
                newMeter.remarks = remarks;
                newMeter.prev_meter = oldmeter;
                dbcontext.AddTotbMeters(newMeter);
                dbcontext.SaveChanges();
                retval = newMeter.meter_id;
            }
            return retval;
        }

        public int updateMeterNo(int masterID, string metno)
        {
            int retval = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbMeter mtr = dbcontext.tbMeters.FirstOrDefault(x => x.master_id == masterID);
                if (mtr != null)
                {
                    mtr.meterno = metno;
                    retval = mtr.meter_id;
                    dbcontext.SaveChanges();
                }
                else
                {
                   retval = saveNewMeterNo(masterID, metno);
                }
            }
            return retval;
        }

        public int getSeniorCap()
        {
            int retval = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                int volcap = Convert.ToInt32(dbcontext.tbSettings.First().senior_volume_cap);
                retval = volcap;
            }

            return retval;
        }

        public string getAcctNo(int masterid)
        {
            string retval = "";
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbMasters.FirstOrDefault(x => x.master_id == masterid);

                if (query != null)
                {
                    retval = query.acctno;
                }

            }
            return retval;
        }

        public int getZoneID(int masterid)
        {
            int retval = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbMasters.FirstOrDefault(x => x.master_id == masterid);

                if (query != null)
                {
                    retval = query.zone_id;
                }

            }
            return retval;
        }

        public int getZoneID(string zone)
        {
            int zID = 0;

            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                var query = (from en in context.tbZones
                             where en.zone_name.Equals(zone)
                             select en.zone_id).SingleOrDefault();
                if (query != null)
                {
                    zID = (int)query;
                }
            }
            return zID;
        }

        
        public int getCardNo(int masterid)
        {
            int retval = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbMasters.FirstOrDefault(x => x.master_id == masterid).cardno;
                if (query != null)
                {
                    retval = Convert.ToInt32(query);
                }
            }
            return retval;
        }

        public string getUserInitials(int userid)
        {
            string retval;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbUser query = dbcontext.tbUsers.First(x => x.user_id == userid);
                retval = query.initials;
            }
            return retval;
        }

        public decimal getBalance(int masterid)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbMasterAccts.FirstOrDefault(x => x.master_id == masterid);
                if (query != null)
                {
                    return Convert.ToDecimal(query.bill_balance);
                }
                else
                {
                    return 0;
                }
            }
        }

        public int getCategory(int masterid)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                int query = (int)dbcontext.tbMasters.First(x => x.master_id == masterid).category;
                return query;
            }
        }

        public string nformat(decimal? num)
        {
            if (num == null) num = 0;
            return string.Format("{0:n}", num);
        }

        public decimal sformat(string amt)
        {
            decimal con_amt = 0;
            con_amt = decimal.TryParse(amt, out con_amt) ? con_amt : 0;
            return con_amt;
        }

        public string getAcctName(string acctno)
        {
            string retval = "";

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbMasters.FirstOrDefault(x => x.acctno.Equals(acctno));
                if (query != null)
                {
                    retval = query.name.Substring(0, 30);
                }
            }
            return retval;
        }

        public int getZoneUIDbyMaster(int masterID)
        {
            int zoneID = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                zoneID = Convert.ToInt32(getZoneID(masterID));
                int zuid = 0;
                if (zoneID != 0)
                {
                    var zoneuid = dbcontext.tbZones.First(x => x.zone_id == zoneID).zone_uid;
                    zuid = Convert.ToInt32(zoneuid);
                }
                return zuid;
            }
        }

        public string getUserFullName(int userid)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                string queryUser = dbcontext.tbUsers.FirstOrDefault(x => x.user_id == userid).fullname;
                return queryUser;
            }
        }

        public string getZoneReadingDateString(int billingID, int zoneID)
        {
            string retval = "";
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                int zoneUID = getZoneUID(zoneID);
                var query = dbcontext.tbBillingSchedules.FirstOrDefault(x => x.billing_id == billingID && x.zone == zoneUID);
                if (query != null)
                {
                    retval = query.date_rdg.Value.ToShortDateString();
                }
            }
            return retval;
        }

        public DateTime getRecoDate(int masterID)
        {
            DateTime retval = new DateTime();
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbMasters.FirstOrDefault(x => x.master_id == masterID);
                if (query != null)
                {
                    retval = Convert.ToDateTime(query.last_reco_date);
                }
                else if (query == null)
                {
                    retval = new DateTime(1900, 1, 1);
                }
            }
            return retval;
        }

        public string getStatus(int masterID)
        {
            string retval = "";
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbMasters.FirstOrDefault(x => x.master_id == masterID);
                if (query != null)
                {
                    retval = query.status;
                }
            }
            return retval;
        }

        public string getUserJobDesc(int userID)
        {
            string retval = "";
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbUsers.FirstOrDefault(x => x.user_id == userID);
                if (query != null)
                {
                    retval = query.job_desc;
                }
            }
            return retval;
        }

        public string getDeptDivHead(int divID)
        {
            string retval = "";
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbDeptDivisionHeads.FirstOrDefault(x => x.head_id == divID);
                if (query != null)
                {
                    retval = query.DeptDivHead;
                }
            }
            return retval;
        }

        public string getDeptDivHeadDescription(int divID)
        {
            string retval = "";
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbDeptDivisionHeads.FirstOrDefault(x => x.head_id == divID);
                if (query != null)
                {
                    retval = query.designation;
                }
            }
            return retval;

        }

        public void setActiveMeter(int masterID, int meterID)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbMaster query = dbcontext.tbMasters.Single(x => x.master_id == masterID);
                query.meter_id = meterID;
                dbcontext.SaveChanges();
            }
        }

        public string getDeptName(int divID)
        {
            string retval = "";
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbDeptDivisionHeads.FirstOrDefault(x => x.head_id == divID);
                if (query != null)
                {
                    retval = query.DeptDiv;
                }
            }
            return retval;

        }

        public int getBAMCodeID(string bamcode)
        {
            int result = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbBAMLookup bam = dbcontext.tbBAMLookups.First(x => x.bam_code.Equals(bamcode));
                result = bam.bam_id;
            }
            return result;
        }

        public string getCurrentBillMonth()
        {
            string retval = "";
            string currMonth = DateTime.Today.Month.ToString();
            string currYear = DateTime.Today.Year.ToString();
            string curr = string.Format("{0}-{1}",currMonth,currYear);
            using(dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var billMonth = dbcontext.tbBillings.SingleOrDefault(x=>x.billing_desc.Equals(curr)).billing_desc;
                if (billMonth != null)
                {
                    retval = billMonth;
                }
            }
            return retval ;
        }

        public int getCurrentBillingID()
        {
            int retval = 0;
            string currMonth = DateTime.Today.Month.ToString();
            string currYear = DateTime.Today.Year.ToString();
            string curr = string.Format("{0}-{1}",currMonth,currYear);
            using(dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var billingID = dbcontext.tbBillings.SingleOrDefault(x=>x.billing_desc.Equals(curr));
                if (billingID != null) retval = billingID.billing_id;
            }
            return retval ;
        }

        public bool checkIfPenalized(int billingID, int masterID)
        {
            bool retval = false;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var penalty = dbcontext.tbLedgers.SingleOrDefault(x => x.billing_id == billingID && x.master_id == masterID && x.code.Equals("PNLT"));
                //var penalty = dbcontext.tbLedgers.SingleOrDefault(x => x.billing_id == billingID && x.master_id == masterID);
                if (penalty != null)
                {
                    retval = true;
                }
            }
            return retval;
        }

        public DateTime getLastDateOfMonth(out DateTime firstDate, string billmonth)
        {
            string[] strBillMonth = billmonth.Split('-');

            int lastDayofmonth = DateTime.DaysInMonth(Convert.ToInt32(strBillMonth[1]),Convert.ToInt32(strBillMonth[0]));
            firstDate = new DateTime(Convert.ToInt32(strBillMonth[1]),Convert.ToInt32(strBillMonth[0]),1);
            return new DateTime(Convert.ToInt32(strBillMonth[1]), Convert.ToInt32(strBillMonth[0]), lastDayofmonth, 23, 59, 59);
        }

        public int getLastReading(int masterID)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbMasterAcct mastacct = dbcontext.tbMasterAccts.FirstOrDefault(x=>x.master_id==masterID);
                if (mastacct != null)
                {
                    return Convert.ToInt32(mastacct.rdg_pres);
                }
                return 0;
            }
        }

        public  int getServiceRequestCodeID(string sr_code)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                return dbcontext.tbServiceRequestCodes.FirstOrDefault(x => x.sr_code.Equals(sr_code)).srcode_id;
            }
        }

        public int getLastServiceRequestNo()
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                string vq = dbcontext.tbServiceRequests.OrderByDescending(x => x.sr_id).Select(x => x.sr_no).First().ToString();
                return Convert.ToInt32(vq);
            }
        }

        public int getTotalNumberAccounts()
        {
            int total = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                total = dbcontext.tbMasters.Count();
            }
            return total;
        }

    } // end class GlobalFunctions
}  // end Namespace


