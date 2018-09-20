﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using KKday.API.WMS.Models.Search;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;

namespace KKday.API.WMS.AppCode.Proxy {
    public class SearchProxy {
        // 取得商品列表
        public static DataSet GetProductAsync(SearchRQModel rq) {

            DataSet ds = new DataSet();

            var _uri = "https://api-search.sit.kkday.com/v1/search/prod/";

            try {

                using (var handler = new HttpClientHandler()) {
                    // Ignore Certificate Error!!
                    handler.ServerCertificateCustomValidationCallback =
                               (message, cert, chain, errors) => true;

                    string jsonResult;

                    using (var client = new HttpClient(handler)) {

                        #region Uri with QueryStrings

                        string today = DateTime.Now.ToString("yyyyMMdd");

                        var query = new Dictionary<string, string> {
                            ["lang"] = rq.lang ?? "",
                            ["currency"] = rq.currency ?? "",
                            ["start"] = rq.start ?? "0",
                            ["count"] = rq.count ?? "10",
                            ["q"] = rq.q ?? "",
                            ["price_from"] = rq.price_from ?? "0",
                            ["price_to"] = rq.price_to ?? "999999",
                            ["date_from"] = rq.date_from ?? today,
                            ["date_to"] = rq.date_to ?? "21000101",
                            ["locale"] = rq.locale ?? "",
                            ["sort"] = rq.sort ?? "",
                            ["source"] = rq.source ?? "",
                            ["member_uuid"] = rq.member_uuid ?? "",
                            ["footprint_id"] = rq.footprint_id ?? "",
                            ["ip"] = rq.ip ?? "",
                            ["multiprice_platform"] = rq.multiprice_platform ?? "01",
                        };

                        // ===> using Microsoft.AspNetCore.WebUtilities;
                        _uri = QueryHelpers.AddQueryString(_uri, query);

                        //非空值才能當作搜尋條件 空值的話都不帶入
                        if (rq.prod_ids != null) {
                            _uri += "&prod_ids[]=" + string.Join("&prod_ids[]=", rq.prod_ids);
                        }

                        if (rq.country_keys != null) {
                            _uri += "&country_keys[]=" + string.Join("&country_keys[]=", rq.country_keys);
                        }

                        if (rq.city_keys != null) {
                            _uri += "&city_keys[]=" + string.Join("&city_keys[]=", rq.city_keys);
                        }

                        if (rq.cat_main_keys != null) {
                            _uri += "&cat_main_keys[]=" + string.Join("&cat_main_keys[]=", rq.cat_main_keys);
                        }

                        if (rq.cat_keys != null) {
                            _uri += "&cat_keys[]=" + string.Join("&cat_keys[]=", rq.cat_keys);
                        }

                        if (rq.durations != null) {
                            _uri += "&durations[]=" + string.Join("&durations[]=", rq.durations);
                        }

                        if (rq.stats != null) {
                            _uri += "&stats[]=" + string.Join("&stats[]=", rq.stats);
                        }

                        if (rq.facets != null) {
                            _uri += "&facets[]=" + string.Join("&facets[]=", rq.facets);
                        }


                        #endregion Uri with QueryStrings

                        using (HttpRequestMessage request =
                               new HttpRequestMessage(HttpMethod.Get, _uri)) {
                            request.Headers.Add("x-auth-key", "kkdaysearchapi_Rfd_fsg+x+TcJy");

                            var response = client.SendAsync(request).Result;
                            jsonResult = response.Content.ReadAsStringAsync().Result;

                        }
                    }

                    var jsonObj = JsonConvert.DeserializeObject(jsonResult);
                }


            } catch (Exception ex) {

                throw ex;
                // Website.Instance.logger.FatalFormat("{0},{1}", ex.Message, ex.StackTrace);
            }

            return ds;
        }
    }
}