﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KKday.Web.B2D.EC.Models.Model.Pmch;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using KKday.Web.B2D.EC.AppCode;
using KKday.Web.B2D.EC.Models.Repostory.Booking;
using KKday.Web.B2D.EC.Models.Model.Booking;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KKday.Web.B2D.EC.Controllers
{
    public class FinalController : Controller
    {
        // GET: /<controller>/

        public IActionResult Index()
        {
            return View();
        }


        //付款後導回
        public IActionResult Success(string id,string jsondata)
        {
            //回傳的連結有訂編 (記log)
            //透過訂編將redis 的資料抓回送出去的資料
            //取b2dredis 內的paymentDtl
            string payDtlStr = RedisHelper.getProdInfotoRedis("b2d:ec:payDtl:" + id);
            PaymentDtl  payDtl= JsonConvert.DeserializeObject<PaymentDtl>(payDtlStr);

            //從kkday redis 取出
            //組出token res:pmgwTransNo, res:pmgwMethod ,res:pmch_resp ceil res:payAmount order_mid
            //md5($pmgw_trans_no.$pmgw_method.$trans_curr_cd.$trans_amt.$pmch_ref_no.$key);
            //PmchSslResponse res = JsonConvert.DeserializeObject<PmchSslResponse>(jsondata); //舊版
            PmchSslResponse2 res = JsonConvert.DeserializeObject<PmchSslResponse2>(jsondata); //新版
            string transNo = GibberishAES.OpenSSLDecrypt(res.data.pmgw_trans_no, "pmgw@%#@trans*no");
            //CallJsonPay req = JsonConvert.DeserializeObject<CallJsonPay>(RedisHelper.getProdInfotoRedis("b2d:ec:pmchSslRequest:" + id)); //using KKday.Web.B2D.EC.AppCode;
            CallJsonPay2 req = JsonConvert.DeserializeObject<CallJsonPay2>(RedisHelper.getProdInfotoRedis("b2d:ec:pmchSslRequest:" + id)); //using KKday.Web.B2D.EC.AppCode;

            string token = "kk%$#@pay";
            string pmgwMethod = res.data.pmgw_method;

            string payCurrency = res.data.pay_currency;
            string payAmount = Math.Ceiling(res.data.pay_amount).ToString();
            string pmgwValidToken =  MD5Tool.GetMD5(transNo + pmgwMethod + payCurrency + payAmount + id+ token);

            KKapiHelper helper = new KKapiHelper();
            //必須要再呼叫一次要讓FA 知道這個授權是kkday做的!而不是robot
            string isSuccess = helper.PaymentValid(transNo, pmgwValidToken);

            //如果ok就upd
            distributorInfo fakeContact = DataSettingRepostory.fakeContact();
            //helper.PayUpdSuccessUpdOrder(id, transNo, payDtl, req, res, fakeContact);//舊版
            helper.PayUpdSuccessUpdOrder2(id, transNo, payDtl, req, res, fakeContact); //新版


            return View("Success");
        }


        //付款中途停止導回
        public IActionResult Failure([FromBody] PmchSslResponse jsondata)
        {

            return View("Cancel");
        }
    }
}
