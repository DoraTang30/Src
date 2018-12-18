using System;
using System.Collections.Generic;
using KKday.Web.B2D.BE.Models.DataModel;
using KKday.Web.B2D.EC.Models.Model.Account;
using KKday.Web.B2D.BE.Proxy;
using Newtonsoft.Json.Linq;
using KKday.Web.B2D.Models.BE.Model.Order;

namespace KKday.Web.B2D.BE.Models.Repository

{
    public class OrderRepository
    {
        public static OrderListModel GetOrderList(B2dAccount acct, OrderOptionModel option)
        {
            OrderRQModel rq = new OrderRQModel()
            {
                company_xid = 123,//acct.COMPANY_XID,
                channel_oid = 456,//UserData.CHANNEL_OID,
                locale_lang = acct.LOCALE,
                current_currency = acct.CURRENCY,
                state = "TW",//acct.CHANNEL_OID,
                option = option
            };

            var jsonResult = OrderProxy.GetOrderList(rq);

            OrderListModel order_list = new OrderListModel();
            JObject jsonObject = JObject.Parse(jsonResult);
            //order_list = jsonObject["order"].ToObject<List<OrderModel>>();

            order_list.ORDERS = new List<OrderModel>();
            order_list.PAGES = (Int32)jsonObject["order_qty"] / option.page_size + (((Int32)jsonObject["order_qty"] % option.page_size != 0) ? 1 : 0);
            order_list.CURRENT_PAGE = (Int32)jsonObject["current_page"];

            foreach (JToken item in jsonObject["order"].AsJEnumerable())
            {
                order_list.ORDERS.Add(new OrderModel()
                {
                    ORDER_NO = item["orderNo"].ToString(),
                    ORDER_MID = item["orderMid"].ToString(),
                    ORDER_OID = item["orderOid"].ToString(),
                    ORDER_DATE = item["crtDt"].ToString(),
                    PROD_SDATE = item["begLstGoDt"].ToString(),
                    ORDER_STATUS = item["orderStatusTxt"].ToString(),
                    PROD_NAME = item["productName"].ToString(),
                    PKG_NAME = item["packageName"].ToString(),
                    QTY = item["qtyTotal"].ToString()
                });
            }

            return order_list;
        }

        public static JObject GetOrderDetail(B2dAccount acct,string mid)
        {
            OrderRQModel rq = new OrderRQModel()
            {
                company_xid = 123,//acct.COMPANY_XID,
                locale_lang = "zh-tw",//acct.LOCALE,
                current_currency = "TWD",//acct.CURRENCY,
                state = "TW"//acct.COUNRTY_CODE,
            };

            var jsonResult = OrderProxy.GetOrderDetail(rq,mid);

            JObject jsonObject = JObject.Parse(jsonResult);

            //OrderModel order = new OrderModel();
            //order_list = jsonObject["order"].ToObject<List<OrderModel>>();

            return jsonObject;
        }

        //訂單明細左邊&上方欄
        public static OrderInfoModel GetOrderInfo(JToken obj)
        {
            OrderInfoModel order_info = new OrderInfoModel();

            //左邊欄
            if(obj["productName"]!=null) order_info.PROD_NAME = obj["productName"].ToString();
            if (obj["packageName"] != null) order_info.PKG_NAME = obj["packageName"].ToString();
            if (obj["eventTime"] != null) order_info.EVENT = obj["eventTime"].ToString();
            if (obj["begLstGoDtGMT"] != null) order_info.ORDER_SDATE = obj["begLstGoDtGMT"].ToString();
            if (obj["price1Qty"] != null) order_info.ADT_QTY = obj["price1Qty"].ToString();
            if (obj["price2Qty"] != null) order_info.CHD_QTY = obj["price2Qty"].ToString();
            if (obj["price3Qty"] != null) order_info.INF_QTY = obj["price3Qty"].ToString();
            if (obj["price4Qty"] != null) order_info.OLD_QTY = obj["price4Qty"].ToString();
            if (obj["price1"] != null) order_info.ADT_PRICE = obj["currPrice1"].ToString();
            if (obj["price2"] != null) order_info.CHD_PRICE = obj["currPrice2"].ToString();
            if (obj["price3"] != null) order_info.INF_PRICE = obj["currPrice3"].ToString();
            if (obj["price4"] != null) order_info.OLD_PRICE = obj["currPrice4"].ToString();
            if (obj["pmgwCurrPriceTotal"] != null) order_info.TOTALPRICE = obj["pmgwCurrPriceTotal"].ToString();
            if (obj["currPricePay"] != null) order_info.TOTALPAY = obj["currPricePay"].ToString();
            if (obj["pmgwCurrFeeCancel"] != null) order_info.CANCELFEE = obj["pmgwCurrFeeCancel"].ToString();
            if (obj["pmgwCurrPriceRefund"] != null) order_info.REFUNDPRICE = obj["pmgwCurrPriceRefund"].ToString();

            //上方欄
            if (obj["orderMid"] != null) order_info.ORDER_MID = obj["orderMid"].ToString();
            if (obj["contactLastname"] != null && obj["contactFirstname"] != null) order_info.CONN_NAME = string.Format("{0}{1}", obj["contactLastname"], obj["contactFirstname"]);
            if (obj["contactEmail"] != null) order_info.CONN_EMAIL = obj["contactEmail"].ToString();
            if (obj["telCountryCd"] != null && obj["contactTel"] != null) order_info.CONN_TEL = string.Format("{0}{1}{2}", "+", obj["telCountryCd"], obj["contactTel"]);
            if (obj["userCrtDtGMTNm"] != null) order_info.CRT_DATE = obj["userCrtDtGMTNm"].ToString();

            return order_info;
        }

        //訂單明細中下方的「旅客資料」
        public static List<OMDL_CUST_DATA> GetOrderCus(JToken obj)
        {
            List<OMDL_CUST_DATA> order_cus = new List<OMDL_CUST_DATA>();
            OMDL_CUST_DATA cus = new OMDL_CUST_DATA();

            foreach (var item in obj)
            {
                if (item["englishName"] != null)
                {
                    if (item["englishName"]["lastName"] != null && item["englishName"]["firstName"] != null)
                    {
                        var lastName = item["englishName"]["lastName"];
                        var firstName = item["englishName"]["firstName"];
                        cus.englishName = string.Format("{0}{1}{2}", lastName, " ", firstName);
                    }
                }
                if (item["gender"] != null) cus.gender = item["gender"].ToString();
                if (item["meal"] != null && item["meal"]["mealName"] != null) cus.meal = item["meal"]["mealName"].ToString();
                if (item["nationality"] != null)
                {
                    nationalityInfo national = new nationalityInfo();

                    if (item["nationality"]["nationalityCode"] != null) national.nationalityCode = item["nationality"]["nationalityCode"].ToString();
                    if (item["nationality"]["TWIdentity_number"] != null) national.TWIdentity_number = item["nationality"]["TWIdentity_number"].ToString();
                    if (item["nationality"]["MTPNumber"] != null) national.MTPNumber = item["nationality"]["MTPNumber"].ToString();
                    if (item["nationality"]["HKMOIdentityNumber"] != null) national.HKMOIdentityNumber = item["nationality"]["HKMOIdentityNumber"].ToString();

                    cus.nationality = national;
                }
                if (item["birthday"] != null) cus.birthday = item["birthday"].ToString();
                if (item["passport"] != null)
                {
                    passportInfo pass = new passportInfo();

                    if (item["passport"]["passportNo"] != null) pass.passportNo = item["passport"]["passportNo"].ToString();
                    if (item["passport"]["passportExpDate"] != null) pass.passportExpDate = item["passport"]["passportExpDate"].ToString();

                    cus.passport = pass;
                }
                if (item["localName"] != null)
                {
                    if (item["localName"]["lastName"] != null && item["localName"]["firstName"] != null)
                    {
                        var lastName = item["localName"]["lastName"];
                        var firstName = item["localName"]["firstName"];
                        cus.localName = string.Format("{0}{1}{2}", lastName, " ", firstName);
                    }
                }
                if (item["height"] != null)
                {
                    if (item["height"]["value"] != null && item["height"]["unit"] != null)
                    {
                        cus.height = string.Format("{0}{1}", item["height"]["value"], item["height"]["unit"]);
                    }
                }
                if (item["weight"] != null)
                {
                    if (item["weight"]["value"] != null && item["weight"]["unit"] != null)
                    {
                        cus.weight = string.Format("{0}{1}", item["weight"]["value"], item["weight"]["unit"]);
                    }
                }
                if (item["shoeSize"] != null)
                {
                    if (item["shoeSize"]["type"] != null && item["shoeSize"]["unit"] != null && item["shoeSize"]["value"] != null)
                    {
                        string type = item["shoeSize"]["type"].ToString();
                        string unit = item["shoeSize"]["unit"].ToString();
                        double? value = (double?)item["shoeSize"]["value"];
                        cus.shoeSize = string.Format("{0}{1}{2}", type, value, unit);
                    }
                }
                if (item["glassDiopter"] != null) cus.glassDiopter = (double?)item["glassDiopter"];

                order_cus.Add(cus);
            }

            return order_cus;
        }

        //訂單明細中下方的「訂購資料」
        public static List<OMDLModuleModel> GetOrderModule(JToken obj)
        {
            List <OMDLModuleModel> order_module = new List<OMDLModuleModel>();
            OMDLModuleModel model = new OMDLModuleModel();

            foreach (var item in obj)
            {
                if (item["module_type"].ToString() == "OMDL_CONTACT_DATA")
                {
                    OMDL_CONTACT_DATA conn = new OMDL_CONTACT_DATA();
                    contactAppInfo app = new contactAppInfo();

                    if (item["module_data"]["contactName"] != null)
                    {
                        string lastname = (string)item["module_data"]["contactName"]["lastName"];
                        string firstname = (string)item["module_data"]["contactName"]["firstName"];

                        conn.contactName = string.Format("{0}{1}{2}", lastname, " ", firstname);
                    }
                    if (item["module_data"]["contactTel"] != null && (Boolean)item["module_data"]["contactTel"]["haveTel"] == true)
                    {
                        string telcode = (string)item["module_data"]["contactTel"]["telCountryCode"];
                        string tel = (string)item["module_data"]["contactTel"]["telNumber"];

                        conn.contactTel = string.Format("{0}{1}{2}", "+", telcode, tel);
                    }
                    if (item["module_data"]["contactApp"] != null && (Boolean)item["module_data"]["contactApp"]["haveApp"] == true)
                    {
                        app.appName = (string)item["module_data"]["contactApp"]["appName"];
                        app.appAccount= (string)item["module_data"]["contactApp"]["appAccount"];

                        conn.contactApp = app;
                    }

                    model.ORDER_CONTACT = conn;
                }
                if (item["module_type"].ToString() == "OMDL_SEND_DATA")
                {
                    OMDL_SEND_DATA send = new OMDL_SEND_DATA();
                    receiveAddressInfo addr = new receiveAddressInfo();
                    sendToHotelInfo htl = new sendToHotelInfo();
                    shipInfoInfo ship = new shipInfoInfo();

                    if (item["module_data"]["receiverName"] != null)
                    {
                        string firstName = (string)item["module_data"]["receiverName"]["firstName"];
                        string lastName = (string)item["module_data"]["receiverName"]["lastName"];

                        send.receiverName = string.Format("{0}{1}{2}", lastName, " ", firstName);
                    }
                    if (item["module_data"]["receiverTel"] != null)
                    {
                        string telcode = (string)item["module_data"]["receiverTel"]["telCountryCode"];
                        string tel = (string)item["module_data"]["receiverTel"]["telNumber"];

                        send.receiverTel = string.Format("{0}{1}{2}", "+", telcode, tel);
                    }
                    if (item["module_data"]["sendToCountry"] != null)
                    {
                        if (item["module_data"]["sendToCountry"]["countryName"] != null) addr.countryName = (string)item["module_data"]["sendToCountry"]["countryName"];
                        if (item["module_data"]["sendToCountry"]["cityName"] != null) addr.countryName = (string)item["module_data"]["sendToCountry"]["cityName"];
                        if (item["module_data"]["sendToCountry"]["zipCode"] != null) addr.countryName = (string)item["module_data"]["sendToCountry"]["zipCode"];
                        if (item["module_data"]["sendToCountry"]["address"] != null) addr.countryName = (string)item["module_data"]["sendToCountry"]["address"];

                        send.sendToCountry = addr;
                    }
                    if (item["module_data"]["sendToHotel"] != null)
                    {
                        if (item["module_data"]["sendToHotel"]["hotelName"] != null) htl.hotelName = (string)item["module_data"]["sendToHotel"]["hotelName"];
                        if (item["module_data"]["sendToHotel"]["hotelAddress"] != null) htl.hotelAddress = (string)item["module_data"]["sendToHotel"]["hotelAddress"];
                        if (item["module_data"]["sendToHotel"]["hotelTel"] != null) htl.hotelTel = (string)item["module_data"]["sendToHotel"]["hotelTel"];
                        if (item["module_data"]["sendToHotel"]["buyerPassportEnglishName"] != null)
                        {
                            string lastname = (string)item["module_data"]["sendToHotel"]["buyerPassportEnglishName"]["lastName"];
                            string firstname = (string)item["module_data"]["sendToHotel"]["buyerPassportEnglishName"]["firstName"];

                            htl.buyerPassportEnglishName = string.Format("{0}{1}{2}", lastname," ",firstname);
                        }
                        if (item["module_data"]["sendToHotel"]["buyerLocalName"] != null) 
                        {
                            string lastname = (string)item["module_data"]["sendToHotel"]["buyerLocalName"]["lastName"];
                            string firstname = (string)item["module_data"]["sendToHotel"]["buyerLocalName"]["firstName"];

                            htl.buyerLocalName = string.Format("{0}{1}{2}", lastname, " ", firstname);
                        }
                        if (item["module_data"]["receiverTel"]["bookingOrderNo"] != null) htl.bookingOrderNo = (string)item["module_data"]["receiverTel"]["bookingOrderNo"];
                        if (item["module_data"]["receiverTel"]["bookingWebsite"] != null) htl.bookingWebsite = (string)item["module_data"]["receiverTel"]["bookingWebsite"];
                        if (item["module_data"]["receiverTel"]["checkInDate"] != null) htl.checkInDate = (string)item["module_data"]["receiverTel"]["checkInDate"];
                        if (item["module_data"]["receiverTel"]["checkOutDate"] != null) htl.checkOutDate = (string)item["module_data"]["receiverTel"]["checkOutDate"];

                        send.sendToHotel = htl;
                    }
                    if (item["module_data"]["shipInfo"] != null)
                    {
                        if (item["module_data"]["shipInfo"]["shipDate"] != null) ship.shipDate = (string)item["module_data"]["shipInfo"]["shipDate"];
                        if (item["module_data"]["shipInfo"]["trackingNumber"] != null) ship.trackingNumber = (string)item["module_data"]["shipInfo"]["trackingNumber"];

                        send.shipInfo = ship;
                    }

                    model.ORDER_SEND = send;
                }
                if (item["module_type"].ToString() == "OMDL_SHUTTLE")
                {
                    OMDL_SHUTTLE shuttle = new OMDL_SHUTTLE();
                    designatedLocationInfo local = new designatedLocationInfo();
                    designatedByCustomerInfo cus = new designatedByCustomerInfo();
                    charterRouteInfo bus = new charterRouteInfo();

                    if (item["module_data"]["shuttleDate"] != null) shuttle.shuttleDate = (string)item["module_data"]["shuttleDate"];
                    if (item["module_data"]["designatedLocation"] != null)
                    {
                        if (item["module_data"]["designatedLocation"]["locationName"] != null) local.locationName = (string)item["module_data"]["designatedLocation"]["locationName"];
                        if (item["module_data"]["designatedLocation"]["locationAddress"] != null) local.locationAddress = (string)item["module_data"]["designatedLocation"]["locationAddress"];
                        if (item["module_data"]["designatedLocation"]["imageUrl"] != null) local.imageUrl = (string)item["module_data"]["designatedLocation"]["imageUrl"];
                        if (item["module_data"]["designatedLocation"]["timeRangeStart"] != null) local.timeRangeStart = (string)item["module_data"]["designatedLocation"]["timeRangeStart"];
                        if (item["module_data"]["designatedLocation"]["timeRangeEnd"] != null) local.timeRangeEnd = (string)item["module_data"]["designatedLocation"]["timeRangeEnd"];

                        shuttle.designatedLocation = local;
                    }
                    if (item["module_data"]["designatedByCustomer"] != null)
                    {
                        pickUpInfo pick = new pickUpInfo();
                        if (item["module_data"]["designatedByCustomer"]["pickUp"] != null)
                        {
                            if (item["module_data"]["designatedByCustomer"]["pickUp"]["location"] != null) pick.location = (string)item["module_data"]["designatedByCustomer"]["pickUp"]["location"];
                            if (item["module_data"]["designatedByCustomer"]["pickUp"]["time"] != null) pick.time = (string)item["module_data"]["designatedByCustomer"]["pickUp"]["time"];
                            cus.pickUp = pick;
                        }
                        if (item["module_data"]["designatedByCustomer"]["dropOff"] != null) cus.dropOff = (string)item["module_data"]["designatedByCustomer"]["dropOff"]["location"];

                        shuttle.designatedByCustomer = cus;
                    }
                    if (item["module_data"]["charterRoute"] != null)
                    {
                        if (item["module_data"]["charterRoute"]["isCustom"] != null) bus.isCustom = (Boolean)item["module_data"]["charterRoute"]["isCustom"];
                        if (item["module_data"]["charterRoute"]["customRoutes"] != null) bus.customRoutes = new []{(string)item["module_data"]["charterRoute"]["customRoutes"]}; 
                        if (item["module_data"]["charterRoute"]["routeLocal"] != null) bus.routeLocal = (string)item["module_data"]["charterRoute"]["routeLocal"];

                        shuttle.charterRoute = bus;
                    }

                    model.ORDER_SHUTTLE = shuttle;
                }
                if (item["module_type"].ToString() == "OMDL_RENT_CAR")
                {
                    OMDL_RENT_CAR car = new OMDL_RENT_CAR();
                    pickUpInfo_forCar pick = new pickUpInfo_forCar();
                    dropOffInfo_forCar drop = new dropOffInfo_forCar();

                    if (item["module_data"]["pickUp"] !=null)
                    {
                        if (item["module_data"]["pickUp"]["officeID"] != null) pick.officeID = (string)item["module_data"]["pickUp"]["officeID"];
                        if (item["module_data"]["pickUp"]["officeName"] != null) pick.officeName = (string)item["module_data"]["pickUp"]["officeName"];
                        if (item["module_data"]["pickUp"]["addressEng"] != null) pick.addressEng = (string)item["module_data"]["pickUp"]["addressEng"];
                        if (item["module_data"]["pickUp"]["addressLocal"] != null) pick.addressLocal = (string)item["module_data"]["pickUp"]["addressLocal"];
                        if (item["module_data"]["pickUp"]["datetime"] != null) pick.datetime = (string)item["module_data"]["pickUp"]["datetime"];

                        car.pickUp = pick;
                    }
                    if (item["module_data"]["dropOff"] != null)
                    {
                        if (item["module_data"]["dropOff"]["officeID"] != null) drop.officeID = (string)item["module_data"]["pickUp"]["officeID"];
                        if (item["module_data"]["dropOff"]["officeName"] != null) drop.officeName = (string)item["module_data"]["pickUp"]["officeName"];
                        if (item["module_data"]["dropOff"]["addressEng"] != null) drop.addressEng = (string)item["module_data"]["pickUp"]["addressEng"];
                        if (item["module_data"]["dropOff"]["addressLocal"] != null) drop.addressLocal = (string)item["module_data"]["pickUp"]["addressLocal"];
                        if (item["module_data"]["dropOff"]["datetime"] != null) drop.datetime = (string)item["module_data"]["pickUp"]["datetime"];

                        car.dropOff = drop;
                    }

                    model.ORDER_RENTCAR = car;
                }
                if (item["module_type"].ToString() == "OMDL_PSGR_DATA")
                {
                    OMDL_PSGR_DATA psgr = new OMDL_PSGR_DATA();
                    qtyChildSeatInfo chd_seat = new qtyChildSeatInfo();
                    qtyInfantSeatInfo inf_seat = new qtyInfantSeatInfo();

                    if (item["module_data"]["qtyAdult"] != null) psgr.qtyAdult = (int?)item["moduleData"]["qtyAdult"];
                    if (item["module_data"]["qtyChild"] != null) psgr.qtyChild = (int?)item["moduleData"]["qtyChild"];
                    if (item["module_data"]["qtyInfant"] != null) psgr.qtyInfant = (int?)item["moduleData"]["qtyInfant"];
                    if (item["module_data"]["qtyCarryLuggage"] != null) psgr.qtyCarryLuggage = (int?)item["moduleData"]["qtyCarryLuggage"];
                    if (item["module_data"]["qtyCheckedLuggage"] != null) psgr.qtyCheckedLuggage = (int?)item["moduleData"]["qtyCheckedLuggage"];
                    if (item["module_data"]["qtyChildSeat"] != null)
                    {
                        if (item["module_data"]["qtyChildSeat"]["selfProvided"] != null) chd_seat.selfProvided = (int?)item["moduleData"]["qtyChildSeat"]["selfProvided"];
                        if (item["module_data"]["qtyChildSeat"]["supplierProvided"] != null) chd_seat.supplierProvided = (int?)item["moduleData"]["qtyChildSeat"]["supplierProvided"];
                        psgr.qtyChildSeat = chd_seat;
                    }
                    if (item["module_data"]["qtyInfantSeat"] != null)
                    {
                        if (item["module_data"]["qtyInfantSeat"]["selfProvided"] != null) inf_seat.selfProvided = (int?)item["moduleData"]["qtyInfantSeat"]["selfProvided"];
                        if (item["module_data"]["qtyInfantSeat"]["supplierProvided"] != null) inf_seat.supplierProvided = (int?)item["moduleData"]["qtyInfantSeat"]["supplierProvided"];
                        psgr.qtyInfantSeat = inf_seat;
                    }

                    model.ORDER_PSG = psgr;
                }
                if (item["module_type"].ToString() == "OMDL_FLIGHT_INFO")
                {
                    OMDL_FLIGHT_INFO fly = new OMDL_FLIGHT_INFO();
                    arrivalInfo arr = new arrivalInfo();
                    departureInfo dep = new departureInfo();

                    if (item["module_data"]["arrival"] != null)
                    {
                        if (item["module_data"]["arrival"]["flightType"] != null) arr.flightType = (string)item["module_data"]["arrival"]["flightType"];
                        if (item["module_data"]["arrival"]["airport"] != null) arr.airport = (string)item["module_data"]["arrival"]["airport"];
                        if (item["module_data"]["arrival"]["terminalNo"] != null) arr.terminalNo = (string)item["module_data"]["arrival"]["terminalNo"];
                        if (item["module_data"]["arrival"]["airline"] != null) arr.airline = (string)item["module_data"]["arrival"]["airline"];
                        if (item["module_data"]["arrival"]["flightNo"] != null) arr.flightNo = (string)item["module_data"]["arrival"]["flightNo"];
                        if (item["module_data"]["arrival"]["arrivalDatetime"] != null) 
                        {
                            string arr_date = "";
                            string arr_hour = "";
                            string arr_min = "";

                            if (item["module_data"]["arrival"]["arrivalDatetime"]["date"] != null) arr_date = (string)item["module_data"]["arrival"]["arrivalDatetime"]["date"];
                            if (item["module_data"]["arrival"]["arrivalDatetime"]["hour"] != null) arr_hour = (string)item["module_data"]["arrival"]["arrivalDatetime"]["hour"];
                            if (item["module_data"]["arrival"]["arrivalDatetime"]["minute"] != null) arr_min = (string)item["module_data"]["arrival"]["arrivalDatetime"]["minute"];

                            arr.arrivalDatetime = string.Format("{0}{1}{2}{3}{4}", arr_date, " ", arr_hour, ":", arr_min);
                        }
                        fly.arrival = arr;
                    }
                    if (item["module_data"]["departure"] != null)
                    {
                        if (item["module_data"]["departure"]["flightType"] != null) dep.flightType = (string)item["module_data"]["arrival"]["flightType"];
                        if (item["module_data"]["departure"]["airport"] != null) dep.airport = (string)item["module_data"]["arrival"]["airport"];
                        if (item["module_data"]["departure"]["terminalNo"] != null) dep.terminalNo = (string)item["module_data"]["arrival"]["terminalNo"];
                        if (item["module_data"]["departure"]["airline"] != null) dep.airline = (string)item["module_data"]["arrival"]["airline"];
                        if (item["module_data"]["departure"]["flightNo"] != null) dep.flightNo = (string)item["module_data"]["arrival"]["flightNo"];
                        if (item["module_data"]["departure"]["departureDatetime"] != null)
                        {
                            string dep_date = "";
                            string dep_hour = "";
                            string dep_min = "";

                            if (item["module_data"]["departure"]["departureDatetime"]["date"] != null) dep_date = (string)item["module_data"]["departure"]["departureDatetime"]["date"];
                            if (item["module_data"]["departure"]["departureDatetime"]["hour"] != null) dep_hour = (string)item["module_data"]["departure"]["departureDatetime"]["hour"];
                            if (item["module_data"]["departure"]["departureDatetime"]["minute"] != null) dep_min = (string)item["module_data"]["departure"]["departureDatetime"]["minute"];

                            dep.departureDatetime = string.Format("{0}{1}{2}{3}{4}", dep_date, " ", dep_hour, ":", dep_min);
                        }
                        fly.departure = dep;
                    }

                    model.ORDER_FLY = fly;
                }
                if (item["module_type"].ToString() == "OMDL_OTHER_DATA")
                {
                    OMDL_OTHER_DATA other = new OMDL_OTHER_DATA();

                    if (item["module_data"]["mobileModelNumber"] != null) other.mobileModelNumber = (string)item["module_data"]["mobileModelNumber"];
                    if (item["module_data"]["mobileIMEI"] != null) other.mobileIMEI = (string)item["module_data"]["mobileIMEI"];
                    if (item["module_data"]["activationDate"] != null) other.activationDate = (string)item["module_data"]["activationDate"];

                    if (item["module_data"]["exchangeLocationName"] != null) other.exchangeLocationName = (string)item["module_data"]["exchangeLocationName"];
                    if (item["module_data"]["exchangeLocationAddress"] != null) other.exchangeLocationAddress = (string)item["module_data"]["exchangeLocationAddress"];
                    if (item["module_data"]["exchangeLocationNote"] != null) other.exchangeLocationNote = (string)item["module_data"]["exchangeLocationNote"];
                    if (item["module_data"]["exchangeLocationBusinessHours"] != null) other.exchangeLocationBusinessHours = (string)item["module_data"]["exchangeLocationBusinessHours"];

                    model.ORDER_OTHERS = other;
                }

                order_module.Add(model);
            }

            return order_module;
        }
        //用不到
        //public QueryParamsModel GetQueryParamModel(string filter, string sorting, int size, int current_page)
        //{
        //    var rec_count = GetAccountsCount(filter);
        //    var total_pages = (int)(rec_count / size) + ((rec_count % size != 0) ? 1 : 0);

        //    return new QueryParamsModel()
        //    {
        //        Filter = filter,
        //        Sorting = sorting,
        //        Paging = new Pagination()
        //        {
        //            current_page = current_page,
        //            total_pages = total_pages,
        //            page_size = size
        //        }
        //    };
        //}

        //// 取得共有多少筆訂單[分頁用]
        //public int GetAccountsCount(string filter)
        //{
        //    try
        //    {
        //        var _filter = GetFieldFiltering(filter);
        //        //var order_list= OrderProxy.GetOrderList(_filter);

        //        return 0;//order_list.Count;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //#region Fields Mapping

        //private string GetFieldFiltering(string filter)
        //{
        //    var jObjFilter = string.IsNullOrEmpty(filter) ? new JObject() : JObject.Parse(filter);
        //    var _filter = "";

        //    // Full Name
        //    if (!string.IsNullOrEmpty((string)jObjFilter["name"]))
        //        _filter += $" AND LOWER(name_first || name_last) LIKE '%{jObjFilter["name"]}%' ";
        //    // Company Name
        //    if (!string.IsNullOrEmpty((string)jObjFilter["comp_name"]))
        //        _filter += $" AND LOWER(comp_name) LIKE '%{jObjFilter["comp_name"]}%' ";
        //    // Email
        //    if (!string.IsNullOrEmpty((string)jObjFilter["email"]))
        //        _filter += $" AND LOWER(email) LIKE '%{jObjFilter["email"]}%' ";
        //    // enable
        //    if (!string.IsNullOrEmpty((string)jObjFilter["status"]))
        //        _filter += $" AND enable = '{jObjFilter["status"]}' ";

        //    return _filter;
        //}

        //private string GetFieldSorting(string sorting)
        //{
        //    var _sorting = "";

        //    switch (sorting)
        //    {
        //        case "name": _sorting = "name"; break;
        //        case "email": _sorting = "email"; break;
        //        case "comp_name": _sorting = "comp_name"; break;
        //        case "enable": _sorting = "enable"; break;
        //        case "xid": _sorting = "xid"; break;

        //        default: break;
        //    }

        //    return _sorting;
        //}

        //#endregion Fields Mapping
    }
}
