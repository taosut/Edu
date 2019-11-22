﻿using OneEduDataAccess.BO;
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

namespace EduSendSms_VMG_API_TraSau
{
    public partial class Service1 : ServiceBase
    {
        public bool is_stop = true;
        public string cpMa = "VMG2";
        public List<Thread> threadRun = new List<Thread>();
        public int countThread = 1;
        private readonly VmgService vmgService = new VmgService();
        public Service1()
        {
            InitializeComponent();
            vmgService.Timeout = int.Parse(OneValueConfig.apiTimeout());
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
                                long? err_code = null;
                                if (OneValueConfig.version() == "running")
                                {
                                    if (!string.IsNullOrEmpty(row.BRAND_NAME.Trim()) && !string.IsNullOrEmpty(row.NOI_DUNG_KHONG_DAU.Trim()) && !string.IsNullOrEmpty(row.SDT_NHAN.Trim()))
                                    {
                                        ApiBulkReturn result = new ApiBulkReturn(); ;
                                        try
                                        {
                                            result = vmgService.BulkSendSms(XuLy.Add84(row.SDT_NHAN), row.BRAND_NAME, row.NOI_DUNG_KHONG_DAU, "", OneValueConfig.username(), OneValueConfig.password());
                                            err_code = result.error_code;
                                            if (err_code == 0) trang_thai = 1;
                                            else trang_thai = 3;

                                            res_code = GetStringResultFromCode(result.error_code.ToString());
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
                                ResultEntity res = tinNhanBO.updateTrangThaiTinNhan(row.ID, row.ID_TRUONG, trang_thai.Value, res_code, null, true);
                                if (!res.Res)
                                {
                                    is_stop = true;
                                    XuLy.ghilog("DB", "Not save " + string.Format("ID:{0} Brandname:{1} SDT:{2} MSG:{3} Res:{4}", row.ID, row.BRAND_NAME, row.SDT_NHAN, row.NOI_DUNG_KHONG_DAU, res.Msg));
                                    if (OneValueConfig.version() == "running")
                                    {
                                        vmgService.BulkSendSms("84393208679", row.BRAND_NAME, row.NOI_DUNG_KHONG_DAU, "", OneValueConfig.username(), OneValueConfig.password());
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
            if (array[0] == "0")
                return "DELIVERED";
            return array[0] + "|UNDELIVERED";
        }

        protected override void OnStop()
        {
            is_stop = true;
        }
    }
}
