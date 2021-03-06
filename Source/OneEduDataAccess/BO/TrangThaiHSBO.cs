﻿using OneEduDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneEduDataAccess.BO
{
    public class TrangThaiHSBO
    {
        #region Get
        public List<TRANG_THAI_HS> getTrangThaiHS(bool is_all = false, short id_all = 0, string text_all = "Chọn tất cả")
        {
            List<TRANG_THAI_HS> data = new List<TRANG_THAI_HS>();
            var QICache = new DefaultCacheProvider();
            string strKeyCache = QICache.BuildCachedKey("TRANG_THAI_HS", "getTrangThaiHS", is_all, id_all, text_all);
            if (!QICache.IsSet(strKeyCache))
            {
                using (oneduEntities context = new oneduEntities())
                {
                    data = (from p in context.TRANG_THAI_HS orderby p.THU_TU select p).ToList();
                    if (is_all)
                    {
                        if (data == null) data = new List<TRANG_THAI_HS>();
                        TRANG_THAI_HS item_all = new TRANG_THAI_HS();
                        item_all.MA = id_all;
                        item_all.TEN = text_all;
                        data.Insert(0, item_all);
                    }
                    QICache.Set(strKeyCache, data, 300000);
                }
            }
            else
            {
                try
                {
                    data = QICache.Get(strKeyCache) as List<TRANG_THAI_HS>;
                }
                catch
                {
                    QICache.Invalidate(strKeyCache);
                }
            }
            return data;
        }
        #endregion
    }
}
