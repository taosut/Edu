﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneEduDataAccess
{
    public class DSGiaoVienTheoToEntity
    {
        public long ID { get; set; }
        public string TEN { get; set; }
        public string HO_TEN { get; set; }
        public string SDT { get; set; }
        public long? SO_TIN_TRONG_NGAY { get; set; }
    }
}