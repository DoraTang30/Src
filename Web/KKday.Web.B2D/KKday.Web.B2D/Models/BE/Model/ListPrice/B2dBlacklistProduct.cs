﻿using System;
namespace KKday.Web.B2D.Models.BE.Model.ListPrice
{
    [Serializable]
    public class B2dBlacklistProduct
    {
        public Int64 XID { get; set; }
        public string PROD_NO { get; set; }
        public string PROD_NAME { get; set; }
    }
}
