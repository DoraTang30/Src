﻿using System;
using System.Data;
using KKday.API.WMS.AppCode.DAL;
using Newtonsoft.Json.Linq;
using KKday.API.WMS.Models.DataModel.Booking;
using KKday.API.WMS.AppCode.Proxy;
using System.Collections.Generic;
using Npgsql;


namespace KKday.API.WMS.Models.Repository.Booking
{
    public class BookingRepository
    {


        public static void InsertOrder()
        {



            NpgsqlConnection conn = new NpgsqlConnection(Website.Instance.Configuration["ConnectionStrings:NpgsqlConnection"]);
            conn.Open();
            NpgsqlTransaction trans = conn.BeginTransaction();
            String sql = null;
            NpgsqlParameter[] np = null;
            DateTime now = DateTime.Now;
            try
            {
                InsertOrders(trans, sql, np, now);
                InsertOrderSource(trans, sql, np, now);
                InsertOrderLst(trans, sql, np, now);
                InsertOrderCus(trans, sql, np, now);
                InsertOrderDiscountRuleMst(trans, sql, np, now);
                InsertOrderDiscountRuleDtl(trans, sql, np, now);

                trans.Commit();

                conn.Close();



            }
            catch (Exception ex)
            {
                // 如果還沒commit 回傳false
                if(!trans.IsCompleted){
                    trans.Rollback();
                    conn.Close();
                }

                Website.Instance.logger.FatalFormat($"getCurrency  Error :{ex.Message},{ex.StackTrace}");

                throw ex;

            }

            //return currency;

        }

        public static void InsertOrders(NpgsqlTransaction trans, String sql, NpgsqlParameter[] np, DateTime now)
        {
            sql = @"INSERT INTO b2b.orders(
    order_no, kkday_order_oid, kkday_order_mid, order_date, order_type, order_status, order_amt, order_b2c_amt, connect_name, connect_tel, connect_mail, order_note)
    VALUES (:order_no, :kkday_order_oid, :kkday_order_mid, :order_date, :order_type, :order_status, :order_amt, :order_b2c_amt, :connect_name, :connect_tel, :connect_mail, :order_note); ";


            np = new NpgsqlParameter[]{
                        new NpgsqlParameter("order_no","1"),
                        new NpgsqlParameter("kkday_order_oid","2"),
                        new NpgsqlParameter("kkday_order_mid","3"),
                        new NpgsqlParameter("order_date",now),
                        new NpgsqlParameter("order_type","5"),
                        new NpgsqlParameter("order_status",null),
                        new NpgsqlParameter("order_amt",7),
                        new NpgsqlParameter("order_b2c_amt",8),
                        new NpgsqlParameter("connect_name","9"),
                        new NpgsqlParameter("connect_tel","10"),
                        new NpgsqlParameter("connect_mail","11"),
                        new NpgsqlParameter("order_note","12")
                    };

            NpgsqlHelper.ExecuteNonQuery(trans, CommandType.Text, sql, np);
            // The number of rows affected if known; -1 otherwise.
            //if (NpgsqlHelper.ExecuteNonQuery(trans, CommandType.Text, sql, np) > 0 )
            //{
            //trans.Commit();
            //}

        }

        public static void InsertOrderSource(NpgsqlTransaction trans, String sql, NpgsqlParameter[] np, DateTime now)
        {
            sql = @"INSERT INTO b2b.order_source(
    order_no, booking_type, company_xid, channel_oid, connect_name, connect_tel, connect_mail, order_note, client_ip, source_pk1, source_pk2, source_pk3, source_pk4, crt_datetime)
    VALUES (:order_no, :booking_type, :company_xid, :channel_oid, :connect_name, :connect_tel, :connect_mail, :order_note, :client_ip, :source_pk1, :source_pk2, :source_pk3, :source_pk4, :crt_datetime); ";


            np = new NpgsqlParameter[]{
                     new NpgsqlParameter("order_no","1"),
                     new NpgsqlParameter("booking_type","5"),
                     new NpgsqlParameter("company_xid",6),
                     new NpgsqlParameter("channel_oid",7),
                     new NpgsqlParameter("connect_name","9"),
                     new NpgsqlParameter("connect_tel","10"),
                     new NpgsqlParameter("connect_mail","11"),
                     new NpgsqlParameter("order_note","12"),
                     new NpgsqlParameter("client_ip","ip"),
                     new NpgsqlParameter("source_pk1","0"),
                     new NpgsqlParameter("source_pk2","0"),
                     new NpgsqlParameter("source_pk3","0"),
                     new NpgsqlParameter("source_pk4","0"),
                     new NpgsqlParameter("crt_datetime",now)
                    };

            NpgsqlHelper.ExecuteNonQuery(trans, CommandType.Text, sql, np);

        }

        public static void InsertOrderLst(NpgsqlTransaction trans, String sql, NpgsqlParameter[] np, DateTime now)
        {
            sql = @"INSERT INTO b2b.order_lst(
    order_no, lst_seqno, cus_seqno, prod_no, prod_name, prod_amt, prod_b2c_amt, prod_currency, discount_xid, prod_cond1, prod_cond2, pkg_no, pkg_name, pkg_date, op_status, sc_status, fa_status)
    VALUES (:order_no, :lst_seqno, :cus_seqno, :prod_no, :prod_name, :prod_amt, :prod_b2c_amt, :prod_currency, :discount_xid, :prod_cond1, :prod_cond2, :pkg_no, :pkg_name, :pkg_date, :op_status, :sc_status, :fa_status); ";


                np = new NpgsqlParameter[]{
                     new NpgsqlParameter("order_no","1"),
                     new NpgsqlParameter("lst_seqno",2),
                     new NpgsqlParameter("cus_seqno",3),
                     new NpgsqlParameter("prod_no","4"),
                     new NpgsqlParameter("prod_name","5"),
                     new NpgsqlParameter("prod_amt",6),
                     new NpgsqlParameter("prod_b2c_amt",7),
                     new NpgsqlParameter("prod_currency","8"),
                     new NpgsqlParameter("discount_xid",9),
                     new NpgsqlParameter("prod_cond1","10"),
                     new NpgsqlParameter("prod_cond2","11"),
                     new NpgsqlParameter("pkg_no","12"),
                     new NpgsqlParameter("pkg_name","13"),
                     new NpgsqlParameter("pkg_date","14"),
                     new NpgsqlParameter("op_status","15"),
                     new NpgsqlParameter("sc_status","16"),
                     new NpgsqlParameter("fa_status","17")
                    };

                NpgsqlHelper.ExecuteNonQuery(trans, CommandType.Text, sql, np);
        }

        public static void InsertOrderCus(NpgsqlTransaction trans, String sql, NpgsqlParameter[] np, DateTime now)
        {
            sql = @"INSERT INTO b2b.order_cus(
    order_no, cus_seqno, lst_seqno, cus_type, cus_name_e_last, cus_name_e_first, cus_sex, cus_tel, cus_mail)
    VALUES (:order_no, :cus_seqno, :lst_seqno, :cus_type, :cus_name_e_last, :cus_name_e_first, :cus_sex, :cus_tel, :cus_mail); ";


            np = new NpgsqlParameter[]{
                     new NpgsqlParameter("order_no","1"),
                     new NpgsqlParameter("cus_seqno",1),
                     new NpgsqlParameter("lst_seqno",2),
                     new NpgsqlParameter("cus_type","3"),
                     new NpgsqlParameter("cus_name_e_last","4"),
                     new NpgsqlParameter("cus_name_e_first","5"),
                     new NpgsqlParameter("cus_sex","6"),
                     new NpgsqlParameter("cus_tel","7"),
                     new NpgsqlParameter("cus_mail","8")
                    };

            NpgsqlHelper.ExecuteNonQuery(trans, CommandType.Text, sql, np);

        }

        public static void InsertOrderDiscountRuleMst(NpgsqlTransaction trans, String sql, NpgsqlParameter[] np, DateTime now)
        {
            sql = @"INSERT INTO b2b.order_discount_rule_mst(
    xid, lst_seqno, disc_name, disc_amt, disc_currency, disc_note, order_no)
    VALUES (:xid, :lst_seqno, :disc_name, :disc_amt, :disc_currency, :disc_note, :order_no); ";


            np = new NpgsqlParameter[]{
                     new NpgsqlParameter("xid",1),
                     new NpgsqlParameter("lst_seqno",2),
                     new NpgsqlParameter("disc_name","3"),
                     new NpgsqlParameter("disc_amt",4),
                     new NpgsqlParameter("disc_currency","5"),
                     new NpgsqlParameter("disc_note","6"),
                     new NpgsqlParameter("order_no","4")
                    };

            NpgsqlHelper.ExecuteNonQuery(trans, CommandType.Text, sql, np);

        }

        public static void InsertOrderDiscountRuleDtl(NpgsqlTransaction trans, String sql, NpgsqlParameter[] np, DateTime now)
        {
            sql = @"INSERT INTO b2b.order_discount_rule_dtl(
    xid, mst_xid, order_lst_seqno, order_no)
    VALUES (:xid, :mst_xid, :order_lst_seqno, :order_no); ";


            np = new NpgsqlParameter[]{
                     new NpgsqlParameter("xid",1),
                     new NpgsqlParameter("mst_xid",2),
                     new NpgsqlParameter("order_lst_seqno",3),
                     new NpgsqlParameter("order_no","4")
                    };

            NpgsqlHelper.ExecuteNonQuery(trans, CommandType.Text, sql, np);

        }



    }
}
