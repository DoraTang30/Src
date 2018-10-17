﻿using System;
using System.Collections.Generic;
using System.Data;
using KKday.Web.B2D.BE.App_Code;
using KKday.Web.B2D.BE.Models.Company;
using Npgsql;

namespace KKday.Web.B2D.BE.AppCode.DAL.Company
{
    public class ComapnyDAL
    {
        public static int GetCompanyCount(string filter)
        {
            try
            {
                string sqlStmt = @"SELECT Count(*) FROM b2b.b2d_company {WHERE} ";

                sqlStmt = sqlStmt.Replace("{WHERE}", !string.IsNullOrEmpty(filter) ? "\nWHERE " + filter : string.Empty);

                int total_count = Convert.ToInt32(NpgsqlHelper.ExecuteScalar(Website.Instance.SqlConnectionString, CommandType.Text, sqlStmt));
                return total_count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<B2D_Company> GetCompanies(string filter, int skip, int size, string sorting)
        {
            try
            {
                List<B2D_Company> companies = new List<B2D_Company>();

                string sqlStmt = @"SELECT * FROM b2b.b2d_company {WHERE} {ORDERBY}
LIMIT :Size OFFSET :Skip"; 

                sqlStmt = sqlStmt.Replace("{WHERE}", !string.IsNullOrEmpty(filter) ? "\nWHERE " + filter : string.Empty); 
                sqlStmt = sqlStmt.Replace("{ORDERBY}", !string.IsNullOrEmpty(sorting) ? "\nORDER BY " + sorting : string.Empty);

                List<NpgsqlParameter> sqlParams = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("Size", size),
                    new NpgsqlParameter("Skip", skip)
                };

                DataSet ds = NpgsqlHelper.ExecuteDataset(Website.Instance.SqlConnectionString, CommandType.Text, sqlStmt, sqlParams.ToArray());
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    companies.Add(new B2D_Company()
                    {
                        XID = dr.ToInt64("xid"),
                        STATUS = dr.ToStringEx("status"),
                        COMP_COOPERATION = dr.ToStringEx("comp_cooperation"),
                        PAYMENT_TYPE = dr.ToStringEx("payment_type"),
                        MANAGER_ACCOUNT_XID = dr.ToInt64("manager_account_xid"),
                        PARENT_COMP_XID = dr.ToInt64("parent_comp_xid"),
                        COMP_NAME = dr.ToStringEx("comp_name"),
                        COMP_URL = dr.ToStringEx("comp_url"),
                        COMP_LICENSE = dr.ToStringEx("comp_license"),
                        COMP_LICENSE_2 = dr.ToStringEx("comp_license_2"),
                        COMP_LOCALE = dr.ToStringEx("comp_locale"),
                        COMP_CURRENCY = dr.ToStringEx("comp_currency"),
                        COMP_INVOICE = dr.ToStringEx("comp_invoice"),
                        COMP_COUNTRY = dr.ToStringEx("comp_country"),
                        COMP_TEL_COUNTRY_CODE = dr.ToStringEx("comp_tel_country_code"),
                        COMP_TEL = dr.ToStringEx("comp_tel"),
                        COMP_ADDRESS = dr.ToStringEx("comp_address"),
                        CHARGE_MAN_FIRST = dr.ToStringEx("charge_man_first"),
                        CHARGE_MAN_LAST = dr.ToStringEx("charge_man_last"),
                        CREDITCARD_NO = dr.ToStringEx("creditcard_no"),
                        CREDITCARD_VALID = dr.ToStringEx("creditcard_valid"),
                        CREDITCARD_CVC = dr.ToStringEx("creditcard_cvc"),
                        CONTACT_USER = dr.ToStringEx("contact_user"),
                        CONTACT_USER_EMAIL = dr.ToStringEx("contact_user_email"),
                        FINANCE_USER = dr.ToStringEx("finance_user"),
                        SALES_USER = dr.ToStringEx("sales_user")
                    });
                }

                return companies;
            }
            catch (Exception ex)
            {
                Website.Instance._log.FatalFormat("{0}.{1}", ex.Message, ex.StackTrace);
                throw ex;
            }
        }
        
        public static B2D_Company GetCompany(Int64 xid)
        {
            try
            {
                string sqlStmt = @"SELECT * FROM b2b.b2d_company WHERE xid=:XID";

                DataSet ds = NpgsqlHelper.ExecuteDataset(Website.Instance.SqlConnectionString, CommandType.Text, sqlStmt, new NpgsqlParameter("XID", xid));
                DataRow dr = ds.Tables[0].Rows[0];

                B2D_Company company = new B2D_Company()
                {
                    XID = dr.ToInt64("xid"),
                    STATUS = dr.ToStringEx("status"),
                    COMP_COOPERATION = dr.ToStringEx("comp_cooperation"),
                    PAYMENT_TYPE = dr.ToStringEx("payment_type"),
                    MANAGER_ACCOUNT_XID = dr.ToInt64("manager_account_xid"),
                    PARENT_COMP_XID = dr.ToInt64("parent_comp_xid"),
                    COMP_NAME = dr.ToStringEx("comp_name"),
                    COMP_URL = dr.ToStringEx("comp_url"),
                    COMP_LICENSE = dr.ToStringEx("comp_license"),
                    COMP_LICENSE_2 = dr.ToStringEx("comp_license_2"),
                    COMP_LOCALE = dr.ToStringEx("comp_locale"),
                    COMP_CURRENCY = dr.ToStringEx("comp_currency"),
                    COMP_INVOICE = dr.ToStringEx("comp_invoice"),
                    COMP_COUNTRY = dr.ToStringEx("comp_country"),
                    COMP_TEL_COUNTRY_CODE = dr.ToStringEx("comp_tel_country_code"),
                    COMP_TEL = dr.ToStringEx("comp_tel"),
                    COMP_ADDRESS = dr.ToStringEx("comp_address"),
                    CHARGE_MAN_FIRST = dr.ToStringEx("charge_man_first"),
                    CHARGE_MAN_LAST = dr.ToStringEx("charge_man_last"),
                    CREDITCARD_NO = dr.ToStringEx("creditcard_no"),
                    CREDITCARD_VALID = dr.ToStringEx("creditcard_vaild"),
                    CREDITCARD_CVC = dr.ToStringEx("creditcard_cvc"),
                    CONTACT_USER = dr.ToStringEx("contact_user"),
                    CONTACT_USER_EMAIL = dr.ToStringEx("contact_user_email"),
                    FINANCE_USER = dr.ToStringEx("finance_user"),
                    SALES_USER = dr.ToStringEx("sales_user")
                };

                return company;
            }
            catch (Exception ex)
            {
                Website.Instance._log.FatalFormat("{0}.{1}", ex.Message, ex.StackTrace);
                throw ex;
            }
        }

        ////////////////

        public static void UpdateCompany(B2D_Company company)
        {
            try
            {
                string sqlStmt = @"UPDATE b2b.b2d_company SET 
 status=:STATUS, comp_cooperation=:COMP_COOPERATION, payment_type=:PAYMENT_TYPE,
 manager_account_xid=:MANAGER_ACCOUNT_XID, parent_comp_xid=:PARENT_COMP_XID, comp_name=:COMP_NAME, 
 comp_url=:COMP_URL, comp_license=:COMP_LICENSE, comp_license_2=:COMP_LICENSE_2, comp_locale=:COMP_LOCALE,
 comp_currency=:COMP_CURRENCY, comp_invoice=:COMP_INVOICE, comp_country=:COMP_COUNTRY, comp_tel_country_code=:COMP_TEL_COUNTRY_CODE,
 comp_tel=:COMP_TEL, comp_address=:COMP_ADDRESS, charge_man_first=:CHARGE_MAN_FIRST,
 charge_man_last=:CHARGE_MAN_LAST, creditcard_no=:CREDITCARD_NO, creditcard_vaild=:CREDITCARD_VAILD,
 creditcard_cvc=:CREDITCARD_CVC, contact_user=:CONTACT_USER, contact_user_email=:CONTACT_USER_EMAIL, finance_user=:FINANCE_USER, 
 sales_user=:SALES_USER
WHERE xid=:XID";

                NpgsqlParameter[] sqlParams = new NpgsqlParameter[] {
                    new NpgsqlParameter("STATUS", company.STATUS),
                    new NpgsqlParameter("COMP_COOPERATION", company.COMP_COOPERATION),
                    new NpgsqlParameter("PAYMENT_TYPE", company.PAYMENT_TYPE),
                    new NpgsqlParameter("MANAGER_ACCOUNT_XID", company.MANAGER_ACCOUNT_XID),
                    new NpgsqlParameter("PARENT_COMP_XID", company.PARENT_COMP_XID),
                    new NpgsqlParameter("COMP_NAME", company.COMP_NAME),
                    new NpgsqlParameter("COMP_URL", company.COMP_URL),
                    new NpgsqlParameter("COMP_LICENSE", company.COMP_LICENSE),
                    new NpgsqlParameter("COMP_LICENSE_2", company.COMP_LICENSE_2),
                    new NpgsqlParameter("COMP_LOCALE", company.COMP_LOCALE),
                    new NpgsqlParameter("COMP_CURRENCY", company.COMP_CURRENCY),
                    new NpgsqlParameter("COMP_INVOICE", company.COMP_INVOICE),
                    new NpgsqlParameter("COMP_COUNTRY", company.COMP_COUNTRY),
                    new NpgsqlParameter("COMP_TEL_COUNTRY_CODE", company.COMP_TEL_COUNTRY_CODE),
                    new NpgsqlParameter("COMP_TEL", company.COMP_TEL),
                    new NpgsqlParameter("COMP_ADDRESS", company.COMP_ADDRESS),
                    new NpgsqlParameter("CHARGE_MAN_FIRST", company.CHARGE_MAN_FIRST),
                    new NpgsqlParameter("CHARGE_MAN_LAST", company.CHARGE_MAN_LAST),
                    new NpgsqlParameter("CREDITCARD_NO", company.CREDITCARD_NO),
                    new NpgsqlParameter("CREDITCARD_VALID", company.CREDITCARD_VALID),
                    new NpgsqlParameter("CREDITCARD_CVC", company.CREDITCARD_CVC),
                    new NpgsqlParameter("CONTACT_USER", company.CONTACT_USER),
                    new NpgsqlParameter("CONTACT_USER_EMAIL", company.CONTACT_USER_EMAIL),
                    new NpgsqlParameter("FINANCE_USER", company.FINANCE_USER),
                    new NpgsqlParameter("SALES_USER", company.SALES_USER)
                };

                NpgsqlHelper.ExecuteNonQuery(Website.Instance.SqlConnectionString, CommandType.Text, sqlStmt, sqlParams);
            }
            catch (Exception ex)
            {
                Website.Instance._log.FatalFormat("{0}.{1}", ex.Message, ex.StackTrace);
                throw ex;
            }
        }
    }
}
