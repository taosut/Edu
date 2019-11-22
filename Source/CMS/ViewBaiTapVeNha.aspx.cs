﻿using CMS.XuLy;
using OneEduDataAccess;
using OneEduDataAccess.BO;
using OneEduDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace CMS
{
    public partial class ViewBaiTapVeNha : System.Web.UI.Page
    {
        BaiTapVeNhaChiTietBO btvnChiTietBO = new BaiTapVeNhaChiTietBO();
        LopBO lopBO = new LopBO();
        long? id_lop;
        string ngay_bai_tap = "";
        public List<ViewBaiTapVeNhaEntity> lstBTVN = new List<ViewBaiTapVeNhaEntity>();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblBTVN.Text = "Bài tập về nhà ngày " + DateTime.Now.ToString("dd/MM/yyyy");
            if (Request.QueryString.Get("id_lop") != null)
            {
                try
                {
                    id_lop = Convert.ToInt64(Request.QueryString.Get("id_lop"));
                }
                catch (Exception ex) { }
            }
            if (!IsPostBack)
            {
                if (id_lop != null)
                {
                    LOP lop = lopBO.getLopById(id_lop.Value);
                    if (lop != null)
                    {
                        ngay_bai_tap = DateTime.Now.ToString("ddMMyyyy");

                        List<BAI_TAP_VE_NHA> title = btvnChiTietBO.getBaiTapVeNhaChung(lop.ID_TRUONG, lop.ID_NAM_HOC, id_lop.Value, ngay_bai_tap);
                        if (title.Count > 0) lblMes.Text = title[0].NOI_DUNG;
                        else lblMes.Text = "Không có dữ liệu";

                        lstBTVN = btvnChiTietBO.getBaiTapVeNhaByHocSinh(lop.ID_TRUONG, lop.ID_NAM_HOC, id_lop.Value, ngay_bai_tap);
                        
                    }
                }
            }
        }
    }
}