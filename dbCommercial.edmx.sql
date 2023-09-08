
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 06/24/2020 10:43:26
-- Generated from EDMX file: E:\project\CommSys\BillingSystem\BillingSystem\dbCommercial.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [dbCommercial];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[tbAgingSummary]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbAgingSummary];
GO
IF OBJECT_ID(N'[dbo].[tbBAMCases]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbBAMCases];
GO
IF OBJECT_ID(N'[dbo].[tbBAMEntries]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbBAMEntries];
GO
IF OBJECT_ID(N'[dbo].[tbBAMJournalEntry]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbBAMJournalEntry];
GO
IF OBJECT_ID(N'[dbo].[tbBAMLookup]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbBAMLookup];
GO
IF OBJECT_ID(N'[dbo].[tbBankCodes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbBankCodes];
GO
IF OBJECT_ID(N'[dbo].[tbBankCollections]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbBankCollections];
GO
IF OBJECT_ID(N'[dbo].[tbBilling]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbBilling];
GO
IF OBJECT_ID(N'[dbo].[tbBillingCollection]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbBillingCollection];
GO
IF OBJECT_ID(N'[dbo].[tbBillingDelete]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbBillingDelete];
GO
IF OBJECT_ID(N'[dbo].[tbBillingDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbBillingDetails];
GO
IF OBJECT_ID(N'[dbo].[tbBillingSchedule]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbBillingSchedule];
GO
IF OBJECT_ID(N'[dbo].[tbBillingSummary]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbBillingSummary];
GO
IF OBJECT_ID(N'[dbo].[tbBillPrinted]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbBillPrinted];
GO
IF OBJECT_ID(N'[dbo].[tbBillProcessing]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbBillProcessing];
GO
IF OBJECT_ID(N'[dbo].[tbBlacklistAccounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbBlacklistAccounts];
GO
IF OBJECT_ID(N'[dbo].[tbDailySummary]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbDailySummary];
GO
IF OBJECT_ID(N'[dbo].[tbDeptDivisionHeads]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbDeptDivisionHeads];
GO
IF OBJECT_ID(N'[dbo].[tbDiscoEntry]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbDiscoEntry];
GO
IF OBJECT_ID(N'[dbo].[tbDMAEntry]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbDMAEntry];
GO
IF OBJECT_ID(N'[dbo].[tbDMAList]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbDMAList];
GO
IF OBJECT_ID(N'[dbo].[tbDMTRAccnts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbDMTRAccnts];
GO
IF OBJECT_ID(N'[dbo].[tbDownloadAgentsHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbDownloadAgentsHistory];
GO
IF OBJECT_ID(N'[dbo].[tbLedger]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbLedger];
GO
IF OBJECT_ID(N'[dbo].[tbMaintenanceOrder]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbMaintenanceOrder];
GO
IF OBJECT_ID(N'[dbo].[tbMaster]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbMaster];
GO
IF OBJECT_ID(N'[dbo].[tbMasterAccts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbMasterAccts];
GO
IF OBJECT_ID(N'[dbo].[tbMasterAging]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbMasterAging];
GO
IF OBJECT_ID(N'[dbo].[tbMeterLedger]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbMeterLedger];
GO
IF OBJECT_ID(N'[dbo].[tbMeterList]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbMeterList];
GO
IF OBJECT_ID(N'[dbo].[tbMeterReader]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbMeterReader];
GO
IF OBJECT_ID(N'[dbo].[tbMeters]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbMeters];
GO
IF OBJECT_ID(N'[dbo].[tbMeterTransType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbMeterTransType];
GO
IF OBJECT_ID(N'[dbo].[tbMrsDownload]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbMrsDownload];
GO
IF OBJECT_ID(N'[dbo].[tbMRSDownloadHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbMRSDownloadHistory];
GO
IF OBJECT_ID(N'[dbo].[tbMrsUploadEdit]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbMrsUploadEdit];
GO
IF OBJECT_ID(N'[dbo].[tbMRSUploadHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbMRSUploadHistory];
GO
IF OBJECT_ID(N'[dbo].[tbPay]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbPay];
GO
IF OBJECT_ID(N'[dbo].[tbPaySDR]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbPaySDR];
GO
IF OBJECT_ID(N'[dbo].[tbPenaltyHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbPenaltyHistory];
GO
IF OBJECT_ID(N'[dbo].[tbPrepareAcctHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbPrepareAcctHistory];
GO
IF OBJECT_ID(N'[dbo].[tbPrintTemp]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbPrintTemp];
GO
IF OBJECT_ID(N'[dbo].[tbRates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbRates];
GO
IF OBJECT_ID(N'[dbo].[tbRecapSales]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbRecapSales];
GO
IF OBJECT_ID(N'[dbo].[tbSDRLookup]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbSDRLookup];
GO
IF OBJECT_ID(N'[dbo].[tbSeniorHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbSeniorHistory];
GO
IF OBJECT_ID(N'[dbo].[tbSeriesNo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbSeriesNo];
GO
IF OBJECT_ID(N'[dbo].[tbServiceRequest]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbServiceRequest];
GO
IF OBJECT_ID(N'[dbo].[tbServiceRequestCodes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbServiceRequestCodes];
GO
IF OBJECT_ID(N'[dbo].[tbSettings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbSettings];
GO
IF OBJECT_ID(N'[dbo].[tbUsers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbUsers];
GO
IF OBJECT_ID(N'[dbo].[tbZone]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbZone];
GO
IF OBJECT_ID(N'[dbo].[tbZoneLookup]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbZoneLookup];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'tbMasterAccts'
CREATE TABLE [dbo].[tbMasterAccts] (
    [isSenior] bit  NULL,
    [senior_expiry] datetime  NULL,
    [isIF] bit  NULL,
    [bill_last_bill_id] int  NULL,
    [bill_volume] int  NULL,
    [bill_delivery_date] datetime  NULL,
    [IFAmount] decimal(10,2)  NULL,
    [IFPayableMonths] int  NULL,
    [IFBalance] decimal(10,2)  NULL,
    [IFCurrentPayMonth] int  NULL,
    [IFMonthlyPay] decimal(10,2)  NULL,
    [bill_current] decimal(10,2)  NULL,
    [bill_reading_period] char(30)  NULL,
    [bill_balance] decimal(10,2)  NULL,
    [bill_arrears] decimal(10,2)  NULL,
    [arrears_curr_yr] decimal(10,2)  NULL,
    [arrears_prev_yrs] decimal(10,2)  NULL,
    [master_id] int  NOT NULL,
    [masteracct_id] int IDENTITY(1,1) NOT NULL,
    [IFDownpayment] decimal(10,2)  NULL,
    [isMtrDmg] bit  NULL,
    [MtrDmg_Amount] decimal(10,2)  NULL,
    [MtrDmg_Balance] decimal(10,2)  NULL,
    [MtrDmg_Monthly] decimal(10,2)  NULL,
    [MtrDmg_MonthsPayable] smallint  NULL,
    [MtrDmg_Downpayment] decimal(10,2)  NULL,
    [bill_arrears_months] smallint  NULL,
    [rdg_prev] int  NULL,
    [rdg_pres] int  NULL,
    [ave_vol] int  NULL,
    [IFArrears] decimal(10,2)  NULL,
    [MtrDmg_Arrears] decimal(10,2)  NULL,
    [penalty] decimal(10,2)  NULL,
    [senior_amt] decimal(10,2)  NULL
);
GO

-- Creating table 'tbZoneLookups'
CREATE TABLE [dbo].[tbZoneLookups] (
    [zone_lookup_id] int IDENTITY(1,1) NOT NULL,
    [zone_uid] int  NOT NULL
);
GO

-- Creating table 'tbMeterReaders'
CREATE TABLE [dbo].[tbMeterReaders] (
    [mr_id] int IDENTITY(1,1) NOT NULL,
    [mr_name] varchar(30)  NULL,
    [mr_control] varchar(12)  NULL,
    [initials] varchar(5)  NULL
);
GO

-- Creating table 'tbZones'
CREATE TABLE [dbo].[tbZones] (
    [zone_id] int IDENTITY(1,1) NOT NULL,
    [location] char(100)  NULL,
    [mtr_reader] int  NULL,
    [bill_server] char(50)  NULL,
    [zone_name] varchar(4)  NULL,
    [zone_uid] int  NULL
);
GO

-- Creating table 'tbBillingSchedules'
CREATE TABLE [dbo].[tbBillingSchedules] (
    [billing_sched_id] int IDENTITY(1,1) NOT NULL,
    [date_rdg] datetime  NULL,
    [date_bill_start] datetime  NULL,
    [date_bill_end] datetime  NULL,
    [date_processed] datetime  NULL,
    [date_bill_serve] datetime  NULL,
    [date_due_disco_arrears] datetime  NULL,
    [date_due_disco_noarrears] datetime  NULL,
    [date_due_office] datetime  NULL,
    [date_due_bank] datetime  NULL,
    [date_gen_penalty] datetime  NULL,
    [date_download_agents] datetime  NULL,
    [date_to_update_billing] datetime  NULL,
    [billing_id] int  NULL,
    [zone] int  NULL,
    [processed_by] smallint  NULL,
    [date_checked] datetime  NULL,
    [checked_by] smallint  NULL,
    [date_bill_printed] datetime  NULL,
    [bill_printed_by] smallint  NULL
);
GO

-- Creating table 'tbBillProcessings'
CREATE TABLE [dbo].[tbBillProcessings] (
    [bill_process_id] int IDENTITY(1,1) NOT NULL,
    [zone_book] varchar(6)  NULL,
    [meter_reader] varchar(30)  NULL,
    [mrs_controls] varchar(100)  NULL,
    [date_processed] datetime  NULL,
    [processed_by] smallint  NULL,
    [date_checked] datetime  NULL,
    [checked_by] smallint  NULL,
    [date_printed] datetime  NULL,
    [printed_by] smallint  NULL,
    [billing_id] int  NULL
);
GO

-- Creating table 'tbBillings'
CREATE TABLE [dbo].[tbBillings] (
    [billing_id] int IDENTITY(1,1) NOT NULL,
    [billing_desc] varchar(30)  NULL,
    [billing_start] datetime  NULL,
    [billing_end] datetime  NULL,
    [num_of_bills_processed] int  NULL,
    [num_of_bills_arrears] int  NULL,
    [total_bill_amount] decimal(10,2)  NULL,
    [total_arrears_amount] decimal(10,2)  NULL,
    [total_days] decimal(10,2)  NULL,
    [loaded_to_zones] bit  NULL,
    [remarks] varchar(150)  NULL,
    [processed_date] datetime  NULL,
    [processed_by] smallint  NULL,
    [print_counter] smallint  NULL,
    [last_printdate] datetime  NULL,
    [last_printby] smallint  NULL,
    [checked_date] datetime  NULL,
    [checked_by] smallint  NULL,
    [posted_date] datetime  NULL,
    [posted_by] smallint  NULL,
    [bill_month] varchar(8)  NULL
);
GO

-- Creating table 'tbMasters'
CREATE TABLE [dbo].[tbMasters] (
    [master_id] int IDENTITY(1,1) NOT NULL,
    [acctno] char(6)  NOT NULL,
    [name] char(50)  NOT NULL,
    [address] char(100)  NOT NULL,
    [category] int  NULL,
    [date_installed] datetime  NULL,
    [date_encoded] datetime  NULL,
    [encoded_by] char(10)  NULL,
    [remarks] char(250)  NULL,
    [status] char(2)  NULL,
    [last_edit_by] char(18)  NULL,
    [last_edit_date] datetime  NULL,
    [last_disco_date] datetime  NULL,
    [last_reco_date] datetime  NULL,
    [remarks_date] datetime  NULL,
    [remarks_by] char(18)  NULL,
    [zone_id] int  NOT NULL,
    [meter_id] int  NOT NULL,
    [tin_no] varchar(18)  NULL,
    [senior_id] varchar(18)  NULL,
    [last_read_date] datetime  NULL,
    [prev_read_date] datetime  NULL,
    [gps_data] varchar(100)  NULL,
    [cardno] int  NOT NULL
);
GO

-- Creating table 'tbRates'
CREATE TABLE [dbo].[tbRates] (
    [rate_id] int IDENTITY(1,1) NOT NULL,
    [category_code] varchar(4)  NULL,
    [rate_code] varchar(4)  NULL,
    [size] varchar(5)  NULL,
    [min_vol] int  NULL,
    [max_vol] int  NULL,
    [minimum_pay] decimal(18,2)  NULL,
    [r11_20] decimal(18,2)  NULL,
    [r21_30] decimal(18,2)  NULL,
    [r31_40] decimal(18,2)  NULL,
    [r41_50] decimal(18,2)  NULL,
    [r51_up] decimal(18,2)  NULL,
    [mrental] decimal(18,2)  NULL
);
GO

-- Creating table 'tbSettings'
CREATE TABLE [dbo].[tbSettings] (
    [settings_id] int IDENTITY(1,1) NOT NULL,
    [senior_percentage] decimal(6,2)  NULL,
    [senior_volume_cap] int  NULL,
    [meter_mtn] decimal(10,2)  NULL,
    [penalty_percentage] int  NULL,
    [collecting_agents] varchar(200)  NULL,
    [rf_residential] decimal(18,0)  NULL,
    [rf_commercial] decimal(18,0)  NULL,
    [mrs_ipaddress] varchar(15)  NULL
);
GO

-- Creating table 'tbBillingDeletes'
CREATE TABLE [dbo].[tbBillingDeletes] (
    [billdelete_id] int IDENTITY(1,1) NOT NULL,
    [billproc_id] int  NULL,
    [master_id] int  NULL,
    [remarks] varchar(250)  NULL,
    [date_deleted] datetime  NULL,
    [rdg_prev] int  NULL,
    [rdg_pres] int  NULL,
    [volume] int  NULL,
    [deleted_by] int  NULL
);
GO

-- Creating table 'tbServiceRequestCodes'
CREATE TABLE [dbo].[tbServiceRequestCodes] (
    [srcode_id] int IDENTITY(1,1) NOT NULL,
    [sr_code] varchar(3)  NULL,
    [code_desc] varchar(30)  NULL
);
GO

-- Creating table 'tbBillPrinteds'
CREATE TABLE [dbo].[tbBillPrinteds] (
    [billprint_id] int IDENTITY(1,1) NOT NULL,
    [bill_month] varchar(10)  NOT NULL,
    [acctno] varchar(30)  NOT NULL,
    [meter_no] varchar(15)  NOT NULL,
    [fullname] varchar(50)  NOT NULL,
    [address] varchar(70)  NOT NULL,
    [from_to] varchar(20)  NOT NULL,
    [rdg_pres] int  NOT NULL,
    [rdg_prev] int  NOT NULL,
    [volume] int  NOT NULL,
    [current] decimal(10,2)  NOT NULL,
    [mtr_mtn] decimal(10,2)  NOT NULL,
    [arrears] decimal(10,2)  NOT NULL,
    [dmg_mtr] decimal(10,2)  NOT NULL,
    [senior] decimal(10,2)  NOT NULL,
    [if2] decimal(10,2)  NOT NULL,
    [total] decimal(10,2)  NOT NULL,
    [duedate_bank] datetime  NULL,
    [duedate_surcharge] datetime  NULL,
    [surcharge] decimal(10,2)  NOT NULL,
    [total_w_surcharge] decimal(10,2)  NOT NULL,
    [bill_ref_no] varchar(10)  NOT NULL,
    [master_id] int  NOT NULL,
    [billing_id] int  NOT NULL,
    [date_disco] datetime  NULL,
    [card_no] int  NULL,
    [class_type] int  NULL,
    [zone_book] varchar(5)  NULL,
    [uid] int  NOT NULL,
    [date_printed] datetime  NULL
);
GO

-- Creating table 'tbServiceRequests'
CREATE TABLE [dbo].[tbServiceRequests] (
    [sr_id] int IDENTITY(1,1) NOT NULL,
    [sr_no] varchar(6)  NULL,
    [billdetails_id] int  NULL,
    [master_id] int  NULL,
    [complain_id] int  NULL,
    [requested_by] varchar(30)  NULL,
    [request_recd_by] varchar(30)  NULL,
    [request_recd_date] datetime  NULL,
    [inspected_by] varchar(30)  NULL,
    [inspected_date] datetime  NULL,
    [remarks] varchar(250)  NULL,
    [status] smallint  NULL,
    [encoder_id] int  NULL,
    [complain_desc] varchar(150)  NULL,
    [work_done] varchar(150)  NULL,
    [last_rdg] varchar(5)  NULL,
    [initial_rdg] varchar(5)  NULL
);
GO

-- Creating table 'tbDeptDivisionHeads'
CREATE TABLE [dbo].[tbDeptDivisionHeads] (
    [head_id] int IDENTITY(1,1) NOT NULL,
    [DeptDiv] varchar(30)  NULL,
    [DeptDivHead] varchar(30)  NULL,
    [user_id] int  NULL,
    [designation] varchar(50)  NULL
);
GO

-- Creating table 'tbPaySDRs'
CREATE TABLE [dbo].[tbPaySDRs] (
    [SDRdetails_ID] int IDENTITY(1,1) NOT NULL,
    [payID] int  NULL,
    [encoder] varchar(10)  NULL,
    [trans_date] datetime  NULL,
    [sdr_code] varchar(10)  NULL,
    [sdr_amount] decimal(18,0)  NULL
);
GO

-- Creating table 'tbPrintTemps'
CREATE TABLE [dbo].[tbPrintTemps] (
    [row_id] int IDENTITY(1,1) NOT NULL,
    [print_code] varchar(10)  NULL,
    [col_string1] varchar(50)  NULL,
    [col_string2] varchar(50)  NULL,
    [col_string3] varchar(50)  NULL,
    [col_string4] varchar(50)  NULL,
    [col_string5] varchar(50)  NULL,
    [col_decimal1] decimal(18,2)  NULL,
    [col_decimal2] decimal(18,2)  NULL,
    [col_decimal3] decimal(18,2)  NULL,
    [col_decimal4] decimal(18,2)  NULL,
    [col_decimal5] decimal(18,2)  NULL,
    [col_int1] int  NULL,
    [col_int2] int  NULL,
    [col_int3] int  NULL,
    [col_int4] int  NULL,
    [col_int5] int  NULL,
    [col_uid] int  NULL
);
GO

-- Creating table 'tbSDRLookups'
CREATE TABLE [dbo].[tbSDRLookups] (
    [sdr_id] int IDENTITY(1,1) NOT NULL,
    [sdr_code] varchar(10)  NOT NULL,
    [sdr_desc] varchar(30)  NOT NULL
);
GO

-- Creating table 'tbSeniorHistories'
CREATE TABLE [dbo].[tbSeniorHistories] (
    [seniorhistory_id] int IDENTITY(1,1) NOT NULL,
    [master_id] int  NULL,
    [reg_date] datetime  NULL,
    [exp_date] datetime  NULL
);
GO

-- Creating table 'tbSeriesNoes'
CREATE TABLE [dbo].[tbSeriesNoes] (
    [series_id] int IDENTITY(1,1) NOT NULL,
    [form_name] varchar(15)  NULL,
    [series_num] varchar(15)  NULL
);
GO

-- Creating table 'tbMrsDownloads'
CREATE TABLE [dbo].[tbMrsDownloads] (
    [md_ave] int  NULL,
    [md_status] char(20)  NULL,
    [md_acctno] char(30)  NULL,
    [md_zone] char(10)  NULL,
    [md_senior] decimal(10,0)  NULL,
    [md_ledgrp] char(5)  NULL,
    [md_name] char(40)  NULL,
    [md_address] char(50)  NULL,
    [md_metno] char(15)  NULL,
    [md_ctgry] char(10)  NULL,
    [md_cardno] int  NULL,
    [md_mon_arr] decimal(15,2)  NULL,
    [md_crrent] decimal(15,2)  NULL,
    [md_days30] decimal(15,2)  NULL,
    [md_days60] decimal(15,2)  NULL,
    [md_days90] decimal(15,2)  NULL,
    [md_arrears] decimal(20,2)  NULL,
    [md_penalty] decimal(15,2)  NULL,
    [md_metdep] decimal(15,2)  NULL,
    [md_dam_met] decimal(15,2)  NULL,
    [md_others] decimal(15,2)  NULL,
    [md_instfee] decimal(15,2)  NULL,
    [md_datepres] datetime  NULL,
    [md_dateprev] datetime  NULL,
    [md_duedate] datetime  NULL,
    [md_discdate] datetime  NULL,
    [md_presrdg] int  NULL,
    [md_prevrdg] int  NULL,
    [md_volume] int  NULL,
    [md_remark] char(20)  NULL,
    [md_ref] char(20)  NULL,
    [md_collagents] char(75)  NULL,
    [mrsdown_ID] int IDENTITY(1,1) NOT NULL,
    [md_masterID] int  NULL,
    [md_duedateAgents] datetime  NULL
);
GO

-- Creating table 'tbMrsUploads'
CREATE TABLE [dbo].[tbMrsUploads] (
    [md_billmonth] varchar(10)  NULL,
    [md_billno] varchar(max)  NULL,
    [md_acctno] varchar(15)  NULL,
    [md_zone] varchar(10)  NULL,
    [md_ctgry] varchar(max)  NULL,
    [md_prevrdg] varchar(max)  NULL,
    [md_presrdg] varchar(max)  NULL,
    [md_volume] varchar(max)  NULL,
    [md_billamount] varchar(max)  NULL,
    [md_readtime] varchar(max)  NULL,
    [md_ffcode] varchar(max)  NULL,
    [md_mccode] varchar(max)  NULL,
    [md_remark] varchar(max)  NULL,
    [md_encoder] varchar(max)  NULL,
    [md_dateuploaded] varchar(max)  NULL,
    [mrsUP_ID] int IDENTITY(1,1) NOT NULL,
    [md_masterID] int  NULL
);
GO

-- Creating table 'tbMRSDownloadHistories'
CREATE TABLE [dbo].[tbMRSDownloadHistories] (
    [dl_historyID] int IDENTITY(1,1) NOT NULL,
    [dl_date] datetime  NULL,
    [dl_billmonth] varchar(8)  NULL,
    [dl_zonebook] varchar(8)  NULL,
    [dl_doneby] varchar(20)  NULL,
    [dl_numrecords] int  NULL
);
GO

-- Creating table 'tbMRSUploadHistories'
CREATE TABLE [dbo].[tbMRSUploadHistories] (
    [up_historyID] int IDENTITY(1,1) NOT NULL,
    [up_date] datetime  NULL,
    [up_billmonth] varchar(8)  NULL,
    [up_zonebook] varchar(8)  NULL,
    [up_doneby] varchar(20)  NULL,
    [up_numrecords] int  NULL
);
GO

-- Creating table 'tbDownloadAgentsHistories'
CREATE TABLE [dbo].[tbDownloadAgentsHistories] (
    [dlagent_id] int IDENTITY(1,1) NOT NULL,
    [dlagent_date] datetime  NULL,
    [zonebook] varchar(10)  NULL,
    [billmonth] varchar(10)  NULL,
    [downloadby] varchar(30)  NULL,
    [numrec] int  NULL,
    [agent_name] varchar(50)  NULL
);
GO

-- Creating table 'tbBillingDetails'
CREATE TABLE [dbo].[tbBillingDetails] (
    [billingdetails_id] int IDENTITY(1,1) NOT NULL,
    [mrs_ref] varchar(12)  NULL,
    [ave_vol] int  NULL,
    [current] decimal(10,2)  NULL,
    [date_pres] datetime  NULL,
    [date_prev] datetime  NULL,
    [volume] int  NULL,
    [penalty] decimal(10,2)  NULL,
    [mtr_mtn] decimal(10,2)  NULL,
    [rdg_pres] int  NULL,
    [rdg_prev] int  NULL,
    [master_id] int  NOT NULL,
    [billproc_id] int  NOT NULL,
    [readtime] varchar(20)  NULL,
    [arrears] decimal(10,2)  NULL,
    [remarks] varchar(150)  NULL,
    [sr_id] int  NULL,
    [senior] decimal(10,2)  NULL,
    [inst_fee] decimal(10,2)  NULL,
    [mtr_dmg] decimal(10,2)  NULL,
    [bill_ref_num] varchar(10)  NULL,
    [mtr_read_by] int  NULL,
    [read_edit_by] int  NULL,
    [other_fees] decimal(10,2)  NULL,
    [other_fee_code] varchar(15)  NULL,
    [arrears_month] smallint  NULL
);
GO

-- Creating table 'tbPays'
CREATE TABLE [dbo].[tbPays] (
    [pay_id] int IDENTITY(1,1) NOT NULL,
    [master_id] int  NULL,
    [zone_id] varchar(2)  NULL,
    [yrmon] varchar(8)  NULL,
    [status] varchar(1)  NULL,
    [source] varchar(3)  NULL,
    [ledgrp] varchar(1)  NULL,
    [acctno] varchar(6)  NULL,
    [date] datetime  NULL,
    [ref] int  NULL,
    [checkno] varchar(15)  NULL,
    [mode] varchar(2)  NULL,
    [collected] decimal(18,2)  NULL,
    [current] decimal(18,2)  NULL,
    [penalty] decimal(18,2)  NULL,
    [ar_curr] decimal(18,2)  NULL,
    [ar_pri] decimal(18,2)  NULL,
    [metdep] decimal(18,2)  NULL,
    [mtrmain] decimal(18,2)  NULL,
    [dmgmtr] decimal(18,2)  NULL,
    [instfee] decimal(18,2)  NULL,
    [svfee] decimal(18,2)  NULL,
    [tffee] decimal(18,2)  NULL,
    [royalty] decimal(18,2)  NULL,
    [sdrcode] varchar(4)  NULL,
    [sdramt] decimal(18,2)  NULL,
    [encoder] varchar(10)  NULL,
    [name] varchar(30)  NULL,
    [remarks] varchar(30)  NULL,
    [tendered_amt] decimal(18,2)  NULL,
    [change_due] decimal(18,2)  NULL,
    [time_pay] datetime  NULL,
    [senior] decimal(10,2)  NULL
);
GO

-- Creating table 'tbBankCodes'
CREATE TABLE [dbo].[tbBankCodes] (
    [bank_id] int IDENTITY(1,1) NOT NULL,
    [bank_code] varchar(5)  NULL,
    [bank_name] varchar(50)  NULL
);
GO

-- Creating table 'tbRecapSales'
CREATE TABLE [dbo].[tbRecapSales] (
    [recap_id] int IDENTITY(1,1) NOT NULL,
    [billmonth] varchar(10)  NULL,
    [zonebook] varchar(4)  NULL,
    [category] varchar(15)  NULL,
    [vol_ctgr] varchar(15)  NULL,
    [num_con] int  NULL,
    [total_vol] int  NULL,
    [total_amt] decimal(18,2)  NULL,
    [code] varchar(6)  NULL
);
GO

-- Creating table 'tbBillingSummaries'
CREATE TABLE [dbo].[tbBillingSummaries] (
    [summary_id] int IDENTITY(1,1) NOT NULL,
    [zone] varchar(4)  NULL,
    [cum] int  NULL,
    [billed] int  NULL,
    [ar] decimal(18,2)  NULL,
    [sales] decimal(18,2)  NULL,
    [penalty] decimal(18,2)  NULL,
    [billmonth] varchar(10)  NULL
);
GO

-- Creating table 'tbMasterAgings'
CREATE TABLE [dbo].[tbMasterAgings] (
    [aging_id] int IDENTITY(1,1) NOT NULL,
    [master_id] int  NULL,
    [balance] decimal(18,2)  NULL,
    [day1to60] decimal(18,2)  NULL,
    [day61to180] decimal(18,2)  NULL,
    [day181to365] decimal(18,2)  NULL,
    [over365] decimal(18,2)  NULL,
    [day0] decimal(18,2)  NULL,
    [zone_id] int  NULL,
    [status] varchar(1)  NULL,
    [date_generated] datetime  NULL,
    [ctgy] int  NULL,
    [billing_id] int  NULL
);
GO

-- Creating table 'tbPrepareAcctHistories'
CREATE TABLE [dbo].[tbPrepareAcctHistories] (
    [process_id] int IDENTITY(1,1) NOT NULL,
    [prepare_billing_of] varchar(10)  NULL,
    [date_process] datetime  NULL,
    [done_by] varchar(10)  NULL,
    [numrecords] int  NULL,
    [disco_processed] int  NULL,
    [disco_marked] int  NULL,
    [disco_reconnected] int  NULL
);
GO

-- Creating table 'tbDailySummaries'
CREATE TABLE [dbo].[tbDailySummaries] (
    [summary_id] int IDENTITY(1,1) NOT NULL,
    [trans_date] datetime  NULL,
    [done_by] varchar(20)  NULL,
    [collections_office_sales] decimal(18,2)  NULL,
    [collections_office_others] decimal(18,2)  NULL,
    [collections_bank] decimal(18,2)  NULL,
    [balance_master] decimal(18,2)  NULL,
    [balance_instfee] decimal(18,2)  NULL,
    [new_accounts] int  NULL,
    [bam_amt_debit] decimal(18,2)  NULL,
    [bam_count_debit] int  NULL,
    [bills_uploaded] int  NULL,
    [bills_amount] decimal(18,2)  NULL,
    [bam_amt_credit] decimal(18,2)  NULL,
    [bam_count_credit] int  NULL,
    [penalty_amt] decimal(18,2)  NULL,
    [penalty_count] int  NULL
);
GO

-- Creating table 'tbBAMLookups'
CREATE TABLE [dbo].[tbBAMLookups] (
    [bam_id] int IDENTITY(1,1) NOT NULL,
    [bam_desc] varchar(50)  NULL,
    [bam_type] varchar(8)  NULL,
    [bam_code] varchar(8)  NULL
);
GO

-- Creating table 'tbAgingSummaries'
CREATE TABLE [dbo].[tbAgingSummaries] (
    [summary_id] int IDENTITY(1,1) NOT NULL,
    [status] varchar(8)  NULL,
    [billmonth] varchar(8)  NULL,
    [ctgry] int  NULL,
    [total_con] int  NULL,
    [balance] decimal(18,2)  NULL,
    [days0] decimal(18,2)  NULL,
    [days1to60] decimal(18,2)  NULL,
    [days61to180] decimal(18,2)  NULL,
    [days181to365] decimal(18,2)  NULL,
    [over365] decimal(18,2)  NULL
);
GO

-- Creating table 'tbPenaltyHistories'
CREATE TABLE [dbo].[tbPenaltyHistories] (
    [penalty_id] int IDENTITY(1,1) NOT NULL,
    [billmonth] varchar(10)  NULL,
    [zone] varchar(4)  NULL,
    [date_generated] datetime  NULL,
    [due_date] datetime  NULL,
    [done_by] varchar(6)  NULL,
    [total_amount] decimal(18,2)  NULL,
    [record_count] int  NULL,
    [government_only] varchar(3)  NULL
);
GO

-- Creating table 'tbMaintenanceOrders'
CREATE TABLE [dbo].[tbMaintenanceOrders] (
    [morder_id] int IDENTITY(1,1) NOT NULL,
    [acctno] varchar(6)  NULL,
    [master_id] int  NULL,
    [trans_date] datetime  NULL,
    [time_paid] datetime  NULL,
    [or_num] varchar(10)  NULL,
    [totalamt_paid] decimal(18,2)  NULL,
    [date_disco] datetime  NULL,
    [date_reco] datetime  NULL,
    [reco_by] varchar(30)  NULL,
    [prepared_by] varchar(30)  NULL,
    [mtr_no_installed] varchar(15)  NULL,
    [mtr_reading] int  NULL,
    [remarks] varchar(150)  NULL,
    [rfeeamt_paid] decimal(18,2)  NULL,
    [category] int  NULL,
    [dateprinted] datetime  NULL,
    [meterno] varchar(15)  NULL,
    [work_desc] varchar(25)  NULL
);
GO

-- Creating table 'tbMrsUploadEdits'
CREATE TABLE [dbo].[tbMrsUploadEdits] (
    [editUpload_id] int IDENTITY(1,1) NOT NULL,
    [editReason] varchar(150)  NULL,
    [editBy] varchar(30)  NULL,
    [old_refnum] varchar(10)  NULL,
    [old_presrdg] int  NULL,
    [old_prevrdg] int  NULL,
    [old_volume] int  NULL,
    [edit_date] datetime  NULL,
    [old_amount] decimal(18,0)  NULL,
    [old_datepres] datetime  NULL
);
GO

-- Creating table 'tbMeters'
CREATE TABLE [dbo].[tbMeters] (
    [meter_id] int IDENTITY(1,1) NOT NULL,
    [meterno] char(18)  NOT NULL,
    [brand] char(18)  NULL,
    [dia_size] char(5)  NULL,
    [master_id] int  NULL,
    [prev_meter] varchar(150)  NULL,
    [date_installed] datetime  NULL,
    [remarks] varchar(200)  NULL
);
GO

-- Creating table 'tbBillingCollections'
CREATE TABLE [dbo].[tbBillingCollections] (
    [billcol_id] int IDENTITY(1,1) NOT NULL,
    [date_trans] datetime  NULL,
    [zone] int  NULL,
    [bill_amount] decimal(18,2)  NULL,
    [bill_penalty] decimal(18,2)  NULL,
    [bill_mtrmtn] decimal(18,2)  NULL,
    [bill_cum] int  NULL,
    [bill_scno] int  NULL,
    [bam_amount] decimal(18,2)  NULL,
    [bam_cum] int  NULL,
    [bam_scno] int  NULL,
    [col_amount] decimal(18,2)  NULL,
    [col_penalty] decimal(18,2)  NULL,
    [col_mtrmtn] decimal(18,2)  NULL,
    [col_scno] int  NULL,
    [date_generated] datetime  NULL,
    [generated_by] varchar(6)  NULL
);
GO

-- Creating table 'tbLedgers'
CREATE TABLE [dbo].[tbLedgers] (
    [ledger_id] int IDENTITY(1,1) NOT NULL,
    [code] varchar(8)  NULL,
    [ref] varchar(10)  NULL,
    [presrdg] int  NULL,
    [trans_date] datetime  NULL,
    [volume] int  NULL,
    [symbol] varchar(2)  NULL,
    [encoder] varchar(6)  NULL,
    [remarks] varchar(50)  NULL,
    [remarks_date] datetime  NULL,
    [remarks_by] varchar(18)  NULL,
    [master_id] int  NOT NULL,
    [billing_id] int  NULL,
    [amount] decimal(10,2)  NULL,
    [balance] decimal(10,2)  NULL,
    [other] decimal(18,0)  NULL,
    [zoneuid] int  NULL
);
GO

-- Creating table 'tbDiscoEntries'
CREATE TABLE [dbo].[tbDiscoEntries] (
    [disco_id] int IDENTITY(1,1) NOT NULL,
    [disco_date] datetime  NULL,
    [master_id] int  NULL,
    [processed] int  NOT NULL,
    [zoneid] int  NULL,
    [entry_date] datetime  NULL,
    [entry_by] varchar(6)  NULL,
    [processed_date] datetime  NULL,
    [processed_by] varchar(6)  NULL
);
GO

-- Creating table 'tbDMALists'
CREATE TABLE [dbo].[tbDMALists] (
    [dma_id] int IDENTITY(1,1) NOT NULL,
    [subd_name] varchar(30)  NULL,
    [search_str] varchar(30)  NULL
);
GO

-- Creating table 'tbUsers'
CREATE TABLE [dbo].[tbUsers] (
    [user_id] int IDENTITY(1,1) NOT NULL,
    [fullname] varchar(30)  NULL,
    [user_name] varchar(15)  NULL,
    [pass_word] varchar(10)  NULL,
    [admin] int  NULL,
    [Billing] int  NULL,
    [Cashier] int  NULL,
    [Disco] int  NULL,
    [Meter] int  NULL,
    [CSD] int  NULL,
    [last_program_used] varchar(18)  NULL,
    [last_login] datetime  NULL,
    [remarks] varchar(100)  NULL,
    [initials] varchar(5)  NULL,
    [last_computer_used] varchar(30)  NULL,
    [access_code] int  NULL,
    [job_desc] varchar(50)  NULL
);
GO

-- Creating table 'tbBAMCases'
CREATE TABLE [dbo].[tbBAMCases] (
    [bcase_id] int IDENTITY(1,1) NOT NULL,
    [case_desc] varchar(50)  NULL,
    [case_type] varchar(7)  NULL
);
GO

-- Creating table 'tbBAMEntries'
CREATE TABLE [dbo].[tbBAMEntries] (
    [bamdetail_id] int IDENTITY(1,1) NOT NULL,
    [bamcase_id] int  NULL,
    [bamno] varchar(9)  NULL,
    [bam_date] datetime  NULL,
    [acctname] varchar(50)  NULL,
    [acctno] varchar(6)  NULL,
    [zoneno] varchar(4)  NULL,
    [cardno] varchar(6)  NULL,
    [explanation] nvarchar(254)  NULL,
    [acct_title] nvarchar(12)  NULL,
    [bam_type] varchar(4)  NULL,
    [debit] decimal(10,2)  NULL,
    [credit] decimal(10,2)  NULL,
    [billmonth] varchar(50)  NULL,
    [cum_as_billed] varchar(50)  NULL,
    [cum_should_be] varchar(50)  NULL,
    [cum_adjustment] varchar(50)  NULL,
    [master_id] int  NULL,
    [prepared_by_id] int  NULL,
    [approved_by_id] int  NULL,
    [last_reading] int  NULL,
    [approved_date] datetime  NULL,
    [processed] bit  NOT NULL
);
GO

-- Creating table 'tbBlacklistAccounts'
CREATE TABLE [dbo].[tbBlacklistAccounts] (
    [blacklist_id] int IDENTITY(1,1) NOT NULL,
    [master_id] int  NULL,
    [date_encoded] datetime  NULL,
    [added_by] varchar(6)  NULL,
    [status] varchar(7)  NULL,
    [blocked_date] datetime  NULL,
    [unblocked_date] datetime  NULL,
    [unblocked_by] varchar(6)  NULL,
    [block_reason] varchar(250)  NULL,
    [warning_message] varchar(50)  NULL,
    [acctno] varchar(6)  NULL,
    [name] varchar(30)  NULL
);
GO

-- Creating table 'tbDMAEntries'
CREATE TABLE [dbo].[tbDMAEntries] (
    [dmaentry_id] int IDENTITY(1,1) NOT NULL,
    [dma_id] int  NULL,
    [master_id] int  NULL,
    [date_added] datetime  NULL,
    [added_by] varchar(5)  NULL,
    [date_removed] datetime  NULL,
    [removed_by] varchar(5)  NULL
);
GO

-- Creating table 'tbDMTRAccnts'
CREATE TABLE [dbo].[tbDMTRAccnts] (
    [dmtr_id] int IDENTITY(1,1) NOT NULL,
    [master_id] int  NULL,
    [encoded_date] datetime  NULL,
    [encoded_by] varchar(6)  NULL,
    [amount] decimal(18,0)  NULL,
    [balance] decimal(18,0)  NULL,
    [monthly] decimal(18,0)  NULL
);
GO

-- Creating table 'tbMeterLedgers'
CREATE TABLE [dbo].[tbMeterLedgers] (
    [mledger_id] int IDENTITY(1,1) NOT NULL,
    [meter_id] int  NULL,
    [trans_date] datetime  NULL,
    [trans_type] int  NULL,
    [master_id] int  NULL,
    [encoded_by] varchar(5)  NULL,
    [replaced_by] varchar(20)  NULL,
    [encoded_date] datetime  NULL,
    [refnum] varchar(15)  NULL,
    [cur_reading] int  NULL,
    [remarks] varchar(100)  NULL
);
GO

-- Creating table 'tbMeterLists'
CREATE TABLE [dbo].[tbMeterLists] (
    [meter_id] int IDENTITY(1,1) NOT NULL,
    [meter_no] varchar(10)  NULL,
    [meter_code] varchar(2)  NULL,
    [meter_size] int  NULL,
    [meter_brand] varchar(50)  NULL,
    [meter_status] varchar(10)  NULL,
    [added_by] varchar(5)  NULL,
    [added_date] datetime  NULL,
    [initial_reading] int  NULL,
    [last_reading] int  NULL,
    [remarks] varchar(100)  NULL
);
GO

-- Creating table 'tbMeterTransTypes'
CREATE TABLE [dbo].[tbMeterTransTypes] (
    [mTransType_id] int IDENTITY(1,1) NOT NULL,
    [type_desc] varchar(15)  NULL,
    [added_by] varchar(5)  NULL,
    [added_date] datetime  NULL
);
GO

-- Creating table 'tbBankCollections'
CREATE TABLE [dbo].[tbBankCollections] (
    [collect_id] int IDENTITY(1,1) NOT NULL,
    [refnum] varchar(10)  NULL,
    [zone] varchar(5)  NULL,
    [current] decimal(18,2)  NULL,
    [arrears] decimal(18,2)  NULL,
    [others] decimal(18,2)  NULL,
    [senior] decimal(18,2)  NULL,
    [date_posted] datetime  NULL,
    [date_collected] datetime  NULL,
    [master_id] int  NULL,
    [posted_by] varchar(30)  NULL,
    [collect_agent] varchar(10)  NULL,
    [totalamt] decimal(18,2)  NULL,
    [billmonth] varchar(8)  NULL,
    [mtr_mtn] decimal(18,2)  NULL,
    [dmg_mtr] decimal(18,2)  NULL,
    [updated] varchar(3)  NULL,
    [penalty] decimal(18,2)  NULL,
    [advpay] decimal(18,2)  NULL
);
GO

-- Creating table 'tbBAMJournalEntries'
CREATE TABLE [dbo].[tbBAMJournalEntries] (
    [bamjournal_id] int IDENTITY(1,1) NOT NULL,
    [bam_id] int  NULL,
    [account_title] varchar(50)  NULL,
    [account_code] varchar(8)  NULL,
    [amt_debit] decimal(18,2)  NULL,
    [amt_credit] decimal(18,2)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [master_id], [masteracct_id] in table 'tbMasterAccts'
ALTER TABLE [dbo].[tbMasterAccts]
ADD CONSTRAINT [PK_tbMasterAccts]
    PRIMARY KEY CLUSTERED ([master_id], [masteracct_id] ASC);
GO

-- Creating primary key on [zone_lookup_id] in table 'tbZoneLookups'
ALTER TABLE [dbo].[tbZoneLookups]
ADD CONSTRAINT [PK_tbZoneLookups]
    PRIMARY KEY CLUSTERED ([zone_lookup_id] ASC);
GO

-- Creating primary key on [mr_id] in table 'tbMeterReaders'
ALTER TABLE [dbo].[tbMeterReaders]
ADD CONSTRAINT [PK_tbMeterReaders]
    PRIMARY KEY CLUSTERED ([mr_id] ASC);
GO

-- Creating primary key on [zone_id] in table 'tbZones'
ALTER TABLE [dbo].[tbZones]
ADD CONSTRAINT [PK_tbZones]
    PRIMARY KEY CLUSTERED ([zone_id] ASC);
GO

-- Creating primary key on [billing_sched_id] in table 'tbBillingSchedules'
ALTER TABLE [dbo].[tbBillingSchedules]
ADD CONSTRAINT [PK_tbBillingSchedules]
    PRIMARY KEY CLUSTERED ([billing_sched_id] ASC);
GO

-- Creating primary key on [bill_process_id] in table 'tbBillProcessings'
ALTER TABLE [dbo].[tbBillProcessings]
ADD CONSTRAINT [PK_tbBillProcessings]
    PRIMARY KEY CLUSTERED ([bill_process_id] ASC);
GO

-- Creating primary key on [billing_id] in table 'tbBillings'
ALTER TABLE [dbo].[tbBillings]
ADD CONSTRAINT [PK_tbBillings]
    PRIMARY KEY CLUSTERED ([billing_id] ASC);
GO

-- Creating primary key on [master_id] in table 'tbMasters'
ALTER TABLE [dbo].[tbMasters]
ADD CONSTRAINT [PK_tbMasters]
    PRIMARY KEY CLUSTERED ([master_id] ASC);
GO

-- Creating primary key on [rate_id] in table 'tbRates'
ALTER TABLE [dbo].[tbRates]
ADD CONSTRAINT [PK_tbRates]
    PRIMARY KEY CLUSTERED ([rate_id] ASC);
GO

-- Creating primary key on [settings_id] in table 'tbSettings'
ALTER TABLE [dbo].[tbSettings]
ADD CONSTRAINT [PK_tbSettings]
    PRIMARY KEY CLUSTERED ([settings_id] ASC);
GO

-- Creating primary key on [billdelete_id] in table 'tbBillingDeletes'
ALTER TABLE [dbo].[tbBillingDeletes]
ADD CONSTRAINT [PK_tbBillingDeletes]
    PRIMARY KEY CLUSTERED ([billdelete_id] ASC);
GO

-- Creating primary key on [srcode_id] in table 'tbServiceRequestCodes'
ALTER TABLE [dbo].[tbServiceRequestCodes]
ADD CONSTRAINT [PK_tbServiceRequestCodes]
    PRIMARY KEY CLUSTERED ([srcode_id] ASC);
GO

-- Creating primary key on [billprint_id] in table 'tbBillPrinteds'
ALTER TABLE [dbo].[tbBillPrinteds]
ADD CONSTRAINT [PK_tbBillPrinteds]
    PRIMARY KEY CLUSTERED ([billprint_id] ASC);
GO

-- Creating primary key on [sr_id] in table 'tbServiceRequests'
ALTER TABLE [dbo].[tbServiceRequests]
ADD CONSTRAINT [PK_tbServiceRequests]
    PRIMARY KEY CLUSTERED ([sr_id] ASC);
GO

-- Creating primary key on [head_id] in table 'tbDeptDivisionHeads'
ALTER TABLE [dbo].[tbDeptDivisionHeads]
ADD CONSTRAINT [PK_tbDeptDivisionHeads]
    PRIMARY KEY CLUSTERED ([head_id] ASC);
GO

-- Creating primary key on [SDRdetails_ID] in table 'tbPaySDRs'
ALTER TABLE [dbo].[tbPaySDRs]
ADD CONSTRAINT [PK_tbPaySDRs]
    PRIMARY KEY CLUSTERED ([SDRdetails_ID] ASC);
GO

-- Creating primary key on [row_id] in table 'tbPrintTemps'
ALTER TABLE [dbo].[tbPrintTemps]
ADD CONSTRAINT [PK_tbPrintTemps]
    PRIMARY KEY CLUSTERED ([row_id] ASC);
GO

-- Creating primary key on [sdr_id] in table 'tbSDRLookups'
ALTER TABLE [dbo].[tbSDRLookups]
ADD CONSTRAINT [PK_tbSDRLookups]
    PRIMARY KEY CLUSTERED ([sdr_id] ASC);
GO

-- Creating primary key on [seniorhistory_id] in table 'tbSeniorHistories'
ALTER TABLE [dbo].[tbSeniorHistories]
ADD CONSTRAINT [PK_tbSeniorHistories]
    PRIMARY KEY CLUSTERED ([seniorhistory_id] ASC);
GO

-- Creating primary key on [series_id] in table 'tbSeriesNoes'
ALTER TABLE [dbo].[tbSeriesNoes]
ADD CONSTRAINT [PK_tbSeriesNoes]
    PRIMARY KEY CLUSTERED ([series_id] ASC);
GO

-- Creating primary key on [mrsdown_ID] in table 'tbMrsDownloads'
ALTER TABLE [dbo].[tbMrsDownloads]
ADD CONSTRAINT [PK_tbMrsDownloads]
    PRIMARY KEY CLUSTERED ([mrsdown_ID] ASC);
GO

-- Creating primary key on [mrsUP_ID] in table 'tbMrsUploads'
ALTER TABLE [dbo].[tbMrsUploads]
ADD CONSTRAINT [PK_tbMrsUploads]
    PRIMARY KEY CLUSTERED ([mrsUP_ID] ASC);
GO

-- Creating primary key on [dl_historyID] in table 'tbMRSDownloadHistories'
ALTER TABLE [dbo].[tbMRSDownloadHistories]
ADD CONSTRAINT [PK_tbMRSDownloadHistories]
    PRIMARY KEY CLUSTERED ([dl_historyID] ASC);
GO

-- Creating primary key on [up_historyID] in table 'tbMRSUploadHistories'
ALTER TABLE [dbo].[tbMRSUploadHistories]
ADD CONSTRAINT [PK_tbMRSUploadHistories]
    PRIMARY KEY CLUSTERED ([up_historyID] ASC);
GO

-- Creating primary key on [dlagent_id] in table 'tbDownloadAgentsHistories'
ALTER TABLE [dbo].[tbDownloadAgentsHistories]
ADD CONSTRAINT [PK_tbDownloadAgentsHistories]
    PRIMARY KEY CLUSTERED ([dlagent_id] ASC);
GO

-- Creating primary key on [billingdetails_id], [master_id], [billproc_id] in table 'tbBillingDetails'
ALTER TABLE [dbo].[tbBillingDetails]
ADD CONSTRAINT [PK_tbBillingDetails]
    PRIMARY KEY CLUSTERED ([billingdetails_id], [master_id], [billproc_id] ASC);
GO

-- Creating primary key on [pay_id] in table 'tbPays'
ALTER TABLE [dbo].[tbPays]
ADD CONSTRAINT [PK_tbPays]
    PRIMARY KEY CLUSTERED ([pay_id] ASC);
GO

-- Creating primary key on [bank_id] in table 'tbBankCodes'
ALTER TABLE [dbo].[tbBankCodes]
ADD CONSTRAINT [PK_tbBankCodes]
    PRIMARY KEY CLUSTERED ([bank_id] ASC);
GO

-- Creating primary key on [recap_id] in table 'tbRecapSales'
ALTER TABLE [dbo].[tbRecapSales]
ADD CONSTRAINT [PK_tbRecapSales]
    PRIMARY KEY CLUSTERED ([recap_id] ASC);
GO

-- Creating primary key on [summary_id] in table 'tbBillingSummaries'
ALTER TABLE [dbo].[tbBillingSummaries]
ADD CONSTRAINT [PK_tbBillingSummaries]
    PRIMARY KEY CLUSTERED ([summary_id] ASC);
GO

-- Creating primary key on [aging_id] in table 'tbMasterAgings'
ALTER TABLE [dbo].[tbMasterAgings]
ADD CONSTRAINT [PK_tbMasterAgings]
    PRIMARY KEY CLUSTERED ([aging_id] ASC);
GO

-- Creating primary key on [process_id] in table 'tbPrepareAcctHistories'
ALTER TABLE [dbo].[tbPrepareAcctHistories]
ADD CONSTRAINT [PK_tbPrepareAcctHistories]
    PRIMARY KEY CLUSTERED ([process_id] ASC);
GO

-- Creating primary key on [summary_id] in table 'tbDailySummaries'
ALTER TABLE [dbo].[tbDailySummaries]
ADD CONSTRAINT [PK_tbDailySummaries]
    PRIMARY KEY CLUSTERED ([summary_id] ASC);
GO

-- Creating primary key on [bam_id] in table 'tbBAMLookups'
ALTER TABLE [dbo].[tbBAMLookups]
ADD CONSTRAINT [PK_tbBAMLookups]
    PRIMARY KEY CLUSTERED ([bam_id] ASC);
GO

-- Creating primary key on [summary_id] in table 'tbAgingSummaries'
ALTER TABLE [dbo].[tbAgingSummaries]
ADD CONSTRAINT [PK_tbAgingSummaries]
    PRIMARY KEY CLUSTERED ([summary_id] ASC);
GO

-- Creating primary key on [penalty_id] in table 'tbPenaltyHistories'
ALTER TABLE [dbo].[tbPenaltyHistories]
ADD CONSTRAINT [PK_tbPenaltyHistories]
    PRIMARY KEY CLUSTERED ([penalty_id] ASC);
GO

-- Creating primary key on [morder_id] in table 'tbMaintenanceOrders'
ALTER TABLE [dbo].[tbMaintenanceOrders]
ADD CONSTRAINT [PK_tbMaintenanceOrders]
    PRIMARY KEY CLUSTERED ([morder_id] ASC);
GO

-- Creating primary key on [editUpload_id] in table 'tbMrsUploadEdits'
ALTER TABLE [dbo].[tbMrsUploadEdits]
ADD CONSTRAINT [PK_tbMrsUploadEdits]
    PRIMARY KEY CLUSTERED ([editUpload_id] ASC);
GO

-- Creating primary key on [meter_id] in table 'tbMeters'
ALTER TABLE [dbo].[tbMeters]
ADD CONSTRAINT [PK_tbMeters]
    PRIMARY KEY CLUSTERED ([meter_id] ASC);
GO

-- Creating primary key on [billcol_id] in table 'tbBillingCollections'
ALTER TABLE [dbo].[tbBillingCollections]
ADD CONSTRAINT [PK_tbBillingCollections]
    PRIMARY KEY CLUSTERED ([billcol_id] ASC);
GO

-- Creating primary key on [ledger_id], [master_id] in table 'tbLedgers'
ALTER TABLE [dbo].[tbLedgers]
ADD CONSTRAINT [PK_tbLedgers]
    PRIMARY KEY CLUSTERED ([ledger_id], [master_id] ASC);
GO

-- Creating primary key on [disco_id] in table 'tbDiscoEntries'
ALTER TABLE [dbo].[tbDiscoEntries]
ADD CONSTRAINT [PK_tbDiscoEntries]
    PRIMARY KEY CLUSTERED ([disco_id] ASC);
GO

-- Creating primary key on [dma_id] in table 'tbDMALists'
ALTER TABLE [dbo].[tbDMALists]
ADD CONSTRAINT [PK_tbDMALists]
    PRIMARY KEY CLUSTERED ([dma_id] ASC);
GO

-- Creating primary key on [user_id] in table 'tbUsers'
ALTER TABLE [dbo].[tbUsers]
ADD CONSTRAINT [PK_tbUsers]
    PRIMARY KEY CLUSTERED ([user_id] ASC);
GO

-- Creating primary key on [bcase_id] in table 'tbBAMCases'
ALTER TABLE [dbo].[tbBAMCases]
ADD CONSTRAINT [PK_tbBAMCases]
    PRIMARY KEY CLUSTERED ([bcase_id] ASC);
GO

-- Creating primary key on [bamdetail_id] in table 'tbBAMEntries'
ALTER TABLE [dbo].[tbBAMEntries]
ADD CONSTRAINT [PK_tbBAMEntries]
    PRIMARY KEY CLUSTERED ([bamdetail_id] ASC);
GO

-- Creating primary key on [blacklist_id] in table 'tbBlacklistAccounts'
ALTER TABLE [dbo].[tbBlacklistAccounts]
ADD CONSTRAINT [PK_tbBlacklistAccounts]
    PRIMARY KEY CLUSTERED ([blacklist_id] ASC);
GO

-- Creating primary key on [dmaentry_id] in table 'tbDMAEntries'
ALTER TABLE [dbo].[tbDMAEntries]
ADD CONSTRAINT [PK_tbDMAEntries]
    PRIMARY KEY CLUSTERED ([dmaentry_id] ASC);
GO

-- Creating primary key on [dmtr_id] in table 'tbDMTRAccnts'
ALTER TABLE [dbo].[tbDMTRAccnts]
ADD CONSTRAINT [PK_tbDMTRAccnts]
    PRIMARY KEY CLUSTERED ([dmtr_id] ASC);
GO

-- Creating primary key on [mledger_id] in table 'tbMeterLedgers'
ALTER TABLE [dbo].[tbMeterLedgers]
ADD CONSTRAINT [PK_tbMeterLedgers]
    PRIMARY KEY CLUSTERED ([mledger_id] ASC);
GO

-- Creating primary key on [meter_id] in table 'tbMeterLists'
ALTER TABLE [dbo].[tbMeterLists]
ADD CONSTRAINT [PK_tbMeterLists]
    PRIMARY KEY CLUSTERED ([meter_id] ASC);
GO

-- Creating primary key on [mTransType_id] in table 'tbMeterTransTypes'
ALTER TABLE [dbo].[tbMeterTransTypes]
ADD CONSTRAINT [PK_tbMeterTransTypes]
    PRIMARY KEY CLUSTERED ([mTransType_id] ASC);
GO

-- Creating primary key on [collect_id] in table 'tbBankCollections'
ALTER TABLE [dbo].[tbBankCollections]
ADD CONSTRAINT [PK_tbBankCollections]
    PRIMARY KEY CLUSTERED ([collect_id] ASC);
GO

-- Creating primary key on [bamjournal_id] in table 'tbBAMJournalEntries'
ALTER TABLE [dbo].[tbBAMJournalEntries]
ADD CONSTRAINT [PK_tbBAMJournalEntries]
    PRIMARY KEY CLUSTERED ([bamjournal_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [master_id] in table 'tbBillingDetails'
ALTER TABLE [dbo].[tbBillingDetails]
ADD CONSTRAINT [FK_tbMastertbBillingDetail]
    FOREIGN KEY ([master_id])
    REFERENCES [dbo].[tbMasters]
        ([master_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbMastertbBillingDetail'
CREATE INDEX [IX_FK_tbMastertbBillingDetail]
ON [dbo].[tbBillingDetails]
    ([master_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------