﻿using BusinessObjects.Services;
using OneEduDataAccess.BO;
using OneEduDataAccess.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EduSendSms_MobiBank_API
{
    public partial class Service1 : ServiceBase
    {
        public bool is_stop = true;
        public string cpMa = "MOBI_BANK";
        public List<Thread> threadRun = new List<Thread>();
        public int countThread = 1;
        private readonly MfsService mfsService = new MfsService();
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            XuLy.ghilog("SysSMS", "Call OnStart");
            try
            {
                is_stop = false;
                for (int i = 0; i < countThread; i++)
                {
                    int indexThread = i;
                    threadRun.Add(new Thread(() => runSend(indexThread)));
                }
                for (int i = 0; i < threadRun.Count; i++)
                {
                    threadRun[i].Start();
                }
            }
            catch (ArgumentException x)
            {
                XuLy.ghilog("SysSMS", "SYS Error OnStart");
            }
            catch (Exception ex)
            {
                XuLy.ghilog("SysSMS", "SYS Error OnStart");
            }
        }

        public void runSend(int indexThread)
        {
            TinNhanBO tinNhanBO = new TinNhanBO();
            XuLy.ghilog("Thread" + indexThread, "start");
            while (!is_stop)
            {
                XuLy.ghilog("Thread" + indexThread, "start turn");
                try
                {
                    List<TIN_NHAN> lstData = new List<TIN_NHAN>();
                    lstData = tinNhanBO.getTinNhanChoGui(cpMa, countThread, indexThread);
                    XuLy.ghilog("SysSMS", "Tổng số: " + lstData.Count);
                    if (lstData != null && lstData.Count > 0)
                    {
                        XuLy.ghilog("Thread" + indexThread, string.Format(@"Lay duoc {0} ban ghi", lstData.Count));
                        #region Vòng lặp
                        foreach (var row in lstData)
                        {
                            if (!is_stop)
                            {
                                string res_code = "";
                                short? trang_thai = null;
                                string err_code = "";
                                if (OneValueConfig.version() == "running")
                                {
                                    if (!string.IsNullOrEmpty(row.BRAND_NAME.Trim()) && !string.IsNullOrEmpty(row.NOI_DUNG_KHONG_DAU.Trim()) && !string.IsNullOrEmpty(row.SDT_NHAN.Trim()))
                                    {
                                        try
                                        {
                                            var result = mfsService.SendSMSAsync(OneValueConfig.ipserver(), OneValueConfig.username(), OneValueConfig.password(), XuLy.Add84(row.SDT_NHAN), row.NOI_DUNG_KHONG_DAU, row.ID.ToString(), row.BRAND_NAME, "0", string.Empty).Result;
                                            err_code = result.ToString();
                                            if (err_code == "1") trang_thai = 1;
                                            else if (err_code == "-1") trang_thai = null;
                                            else trang_thai = 3;

                                            res_code = GetStringResultFromCode(result.ToString());
                                            XuLy.ghilog("Thread" + indexThread, string.Format("get err_code: " + err_code + " - " + res_code));
                                        }
                                        catch
                                        {
                                            trang_thai = 2;
                                            res_code = "DELIVERED|TIME OUT";
                                        }
                                    }
                                    else
                                    {
                                        res_code = "DELIVERED|NOT AVAILABLE";
                                        trang_thai = 3;
                                    }
                                }
                                else
                                {
                                    res_code = "DELIVERED|TEST";
                                    trang_thai = 1;
                                }

                                #region Save
                                ResultEntity res = new ResultEntity();
                                if (trang_thai != null)
                                    res = tinNhanBO.updateTrangThaiTinNhan(row.ID, row.ID_TRUONG, trang_thai.Value, res_code, null, true);
                                else
                                    res = tinNhanBO.updateTrangThaiTinNhan(row.ID, row.ID_TRUONG, trang_thai.Value, res_code, null, false);
                                if (!res.Res)
                                {
                                    is_stop = true;
                                    XuLy.ghilog("DB", "Not save " + string.Format("ID:{0} Brandname:{1} SDT:{2} MSG:{3} Res:{4}", row.ID, row.BRAND_NAME, row.SDT_NHAN, row.NOI_DUNG_KHONG_DAU, res.Msg));
                                    if (OneValueConfig.version() == "running")
                                    {
                                        var x = mfsService.SendSMSAsync(OneValueConfig.ipserver(), OneValueConfig.username(), OneValueConfig.password(), "84888621016", row.NOI_DUNG_KHONG_DAU, row.ID.ToString(), row.BRAND_NAME, "0", string.Empty).Result;
                                    }
                                }
                                else
                                {
                                    XuLy.ghilog("Thread" + indexThread, string.Format("Send at: {0} ID:{1} Brandname:{2} SDT:{3} MSG:{4} Res:{5}", DateTime.Now.ToString("yyyyMMddhhmmss"), row.ID, row.BRAND_NAME, row.SDT_NHAN, row.NOI_DUNG_KHONG_DAU, res_code));
                                }
                                #endregion
                            }
                        }
                        #endregion
                    }
                    else
                    {
                        XuLy.ghilog("Thread" + indexThread, "Lay duoc 0 ban ghi");
                        Thread.Sleep(2000);
                    }
                }
                catch (Exception ex)
                {
                    XuLy.ghilog("Error", ex.ToString());
                }
                XuLy.ghilog("Thread" + indexThread, "stop turn");
                Thread.Sleep(2000);
            }
            XuLy.ghilog("Thread" + indexThread, "stop");
        }

        private string GetStringResultFromCode(string result)
        {
            string[] array = result.Split('|');
            if (array[0] == "1")
                return "DELIVERED";
            return array[0] + "|UNDELIVERED";
        }

        protected override void OnStop()
        {
            is_stop = true;
        }
    }
}