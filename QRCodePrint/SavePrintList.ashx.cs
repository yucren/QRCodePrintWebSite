using LonKing.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using QRCodePrint.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace QRCodePrint
{
    /// <summary>
    /// SavePrintList 的摘要说明
    /// </summary>
    public class SavePrintList : IHttpHandler,IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            bool auth = context.User.Identity.IsAuthenticated;
            if (!auth)
            {
                context.Response.Redirect("~/account/login.aspx?ReturnUrl=" + context.Request.Url, true);

            }
            else
            {

            


            IsoDateTimeConverter isoDateTime = new IsoDateTimeConverter()
            {

                DateTimeFormat = "yyyy-MM-dd HH:mm:ss",
                Culture = new System.Globalization.CultureInfo("zh")


            };


            if (context.Request["action"] == "print")
            {
                
                var json = context.Session["json"].ToString();
                if (context.Session["json"] != null)
                {
                    try
                    {
                        using (QrCodeModel qr = new QrCodeModel())
                        {

                            var itemMasters = JsonConvert.DeserializeObject(json, typeof(ItemMaster[])) as ItemMaster[];

                            var qRCodeLists = from itemMaster in itemMasters
                                              select new QRCodeList
                                              {
                                                  ItemMaster = itemMaster.料号,
                                                  ItemName = itemMaster.品名,
                                                  SerialNo = itemMaster.序列号,
                                                  SupplierCode = itemMaster.供应商编码,
                                                  PrintDate = DateTime.Now,
                                                  UserName = context.User.Identity.Name


                                              };

                            qr.QRCodeLists.AddRange(qRCodeLists);
                            qr.SaveChanges();
                        }
                    }
                    catch (Exception)
                    {
                        context.Response.Write("发生错误，保存失败");

                    }


                }


            }
            else if (context.Request["action"] =="getList" && (context.Request["q"] ==null || context.Request["q"] ==""))
            {
                try
                {
                    var page = Convert.ToInt32(context.Request["page"]);
                    var   rows = Convert.ToInt32(context.Request["rows"]);
                    using (QrCodeModel qr = new QrCodeModel())
                    {
                        var qRjson = qr.QRCodeLists.OrderByDescending(m=>m.PrintDate).Skip(rows*(page -1)).Take(rows);

                        var json = "{\"total\":" + qr.QRCodeLists.Count() + ",\"rows\":" + JsonConvert.SerializeObject(qRjson, isoDateTime) + "}";
                        context.Response.Write(json);
                    }
                }
                catch (Exception)
                {

                    
                }
               
            }
            else if (context.Request["q"] !="")
            {

                var q = context.Request["q"];
        
       
                    using (QrCodeModel qr = new QrCodeModel())
                    {
                        qr.Database.Log = (x) =>
                        {
                            File.AppendAllText(@"c:\qrcodewebLog.txt", x);



                        };
                        var qAarry = q.Split(',');
                        var qRjson = qr.QRCodeLists.Where(x=>qAarry.Contains(x.ItemMaster)).OrderByDescending(m=>m.PrintDate) ;

                        //var qRjson = qr.QRCodeLists.Where(m=> m.ItemMaster.Contains(q)).OrderByDescending(m=>m.PrintDate) ;

                        var json = "{\"total\":" + qr.QRCodeLists.Count() + ",\"rows\":" + JsonConvert.SerializeObject(qRjson,isoDateTime) + "}";
                        context.Response.Write(json);
                      
                        

                    }
                             


            }

            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}