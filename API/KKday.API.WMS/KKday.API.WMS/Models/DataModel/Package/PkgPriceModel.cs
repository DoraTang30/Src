﻿using System;
using System.Collections.Generic;

namespace KKday.API.WMS.Models.DataModel.Package {

    public class PkgSaleDateModel {

        public string result { get; set; }
        public string result_msg { get; set; }
        public List<SaleDt> saleDt { get; set; }
    
    }

    public class SaleDt {
        public string pkg_no { get; set; }
        public string sale_day { get; set; }
    }
}
