﻿using System;
using System.Data;
using KKday.Web.B2D.BE.App_Code;
using KKday.Web.B2D.Models.BE.Model.Voucher;
using Npgsql;

namespace KKday.Web.B2D.BE.AppCode.DAL.Voucher
{
    public class VoucherAddonDAL
    {
        // 取得
        public static B2dVoucherAddon GetVoucherAddon(Int64 comp_xid)
        {
            try
            {
                string sqlStmt = @"SELECT * FROM b2b.b2d_voucher_addon
WHERE company_xid=:company_xid";

                NpgsqlParameter[] sqlParams = new NpgsqlParameter[] {
                    new NpgsqlParameter("company_xid", comp_xid)
                };

                var ds = NpgsqlHelper.ExecuteDataset(Website.Instance.SqlConnectionString, CommandType.Text, sqlStmt, sqlParams);

                DataRow dr = ds.Tables[0].Rows[0];

                var vouchAddon = new B2dVoucherAddon()
                {
                    XID = dr.ToInt64("xid"),
                    COMPANY_XID = dr.ToInt64("company_xid"),
                    COMPANY_NAME = dr.ToStringEx("company_name"),
                    EMAIL = dr.ToStringEx("company_email"),
                    LOGO_URL = dr.ToStringEx("company_logo_url"),
                    TEL = dr.ToStringEx("company_tel"),
                    ADDRESS = dr.ToStringEx("company_address") 
                };

                return vouchAddon;
            }
            catch (Exception ex)
            {
                Website.Instance.logger.FatalFormat("{0},{1}", ex.Message, ex.StackTrace);
                throw ex;
            }
             
        }

        public static void UpdateVouchAddon(B2dVoucherAddon addon, string upd_user)
        {
            try
            {
                string sqlStmt = @"UPDATE b2b.b2d_voucher_addon SET company_email=:company_email, company_tel=:company_tel, 
 company_name=:company_name, company_address=:company_address, upd_user=:upd_user, upd_datetime=now()
WHERE company_xid=:company_xid";

                NpgsqlParameter[] sqlParams = new NpgsqlParameter[] {
                    new NpgsqlParameter("company_xid", addon.COMPANY_XID),
                    new NpgsqlParameter("company_email", (object)addon.EMAIL ?? DBNull.Value),
                    new NpgsqlParameter("company_tel", (object)addon.TEL ?? DBNull.Value),
                    new NpgsqlParameter("company_name", (object)addon.COMPANY_NAME ?? DBNull.Value),
                    new NpgsqlParameter("company_address", (object)addon.ADDRESS ?? DBNull.Value),
                    new NpgsqlParameter("upd_user", upd_user)
                };

                NpgsqlHelper.ExecuteNonQuery(Website.Instance.SqlConnectionString, CommandType.Text, sqlStmt, sqlParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void UpdateVoucheLogo(Int64 xid, string logo_url, string upd_user)
        {
            try
            {
                string sqlStmt = @"UPDATE b2b.b2d_voucher_addon SET logo_url=:logo_url,
  upd_user=:upd_user, upd_datetime=Now()
WHERE company_xid=:company_xid";

                NpgsqlParameter[] sqlParams = new NpgsqlParameter[] {
                    new NpgsqlParameter("company_xid", xid),
                    new NpgsqlParameter("logo_url", logo_url),
                    new NpgsqlParameter("upd_user", upd_user)
                };

                NpgsqlHelper.ExecuteNonQuery(Website.Instance.SqlConnectionString, CommandType.Text, sqlStmt, sqlParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
