using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using LonKing.Model;
using QRCodePrint.Models;
using QRCodePrint.Models.ItemMasterFinderTableAdapters;

namespace QRCodePrint.Tools
{
    /// <summary>
    /// GetItemmaster 的摘要说明
    /// </summary>
    public class GetItemmaster : IHttpHandler,IRequiresSessionState
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
                var page = Convert.ToInt32(context.Request["page"]);
                var rows = Convert.ToInt32(context.Request["rows"]);
                var q = context.Request["q"];
                using (U9Context db = new U9Context())
                {

                    var itemInfor = from itemmaster in db.CBO_ItemMaster
                                    join uom in db.Base_UOM on
                                     itemmaster.InventoryUOM equals uom.ID
                                    join uomtrl in db.Base_UOM_Trl
                                    on uom.ID equals uomtrl.ID
                                    join inv in db.CBO_InventoryInfo
                                    on itemmaster.InventoryInfo equals inv.ID
                                    join wh in db.CBO_Wh
                                    on inv.Warehouse equals wh.ID
                                    join whtrl in db.CBO_Wh_Trl
                                    on wh.ID equals whtrl.ID
                                    join org in db.Base_Organization
                                    on itemmaster.Org equals org.ID
                                    join orgtrl in db.Base_Organization_Trl
                                    on org.ID equals orgtrl.ID
                                    where org.Code == "505"
                                    orderby itemmaster.Code
                                    select new
                                    {
                                        itemId = itemmaster.ID,
                                        itemName = itemmaster.Name,
                                        itemCode = itemmaster.Code,
                                        unit = uomtrl.Name,
                                        unitCode = uom.Code,
                                        whName = whtrl.Name,
                                        whCode = wh.Code,
                                        orgName = orgtrl.Name,
                                        orgCode = org.Code
                                    };
                    string json = "";
                    var action = context.Request["action"];
                    if (action == "selectItem")
                    {


                        var itemInfors = itemInfor.Where(m => m.itemCode == q).First();
                        json =  Newtonsoft.Json.JsonConvert.SerializeObject(itemInfors);




                    }
                    else
                    {
                        if (context.Request["q"] == null || context.Request["q"] == "")
                        {
                            var itemInfors = itemInfor.Skip((page - 1) * rows).Take(rows);
                            json = "{\"total\":" + itemInfor.Count() + ",\"rows\":" + Newtonsoft.Json.JsonConvert.SerializeObject(itemInfors) + "}";


                        }
                        else
                        {

                            var items = itemInfor.Where(m => m.itemCode.Contains(q));

                            var itemInfors = items.Skip((page - 1) * rows).Take(rows);
                            json = "{\"total\":" + items.Count() + ",\"rows\":" + Newtonsoft.Json.JsonConvert.SerializeObject(itemInfors) + "}";

                        }
                    }


                    

                    //  context.Response.ContentType = "text/html";





                    context.Response.Write(json);


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