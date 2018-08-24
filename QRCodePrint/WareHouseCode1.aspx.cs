using LonKing.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QRCodePrint
{
    public partial class WareHouseCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool auth = User.Identity.IsAuthenticated;
            if (!auth)
            {
                Response.Redirect("~/account/login.aspx?ReturnUrl=" + Page.Request.Url, true);

            }
            else
            {
                var json = Request["jsonInput"];
                ItemMaster[] itemMasters = JsonConvert.DeserializeObject(json, typeof(ItemMaster[])) as ItemMaster[];
                //var username = Request["username"];
                //Response.Write(username);

                //var jsonStream = Request.InputStream;
                //StreamReader streamReader = new StreamReader(jsonStream, Encoding.UTF8);




                //var lkm = new LonKing.BLL.LKM_WarehouseCenter();
                //interlist = Request.Params["id"];
                //var id = Request.Params["id"].Split(',');
                ////var code = Request.Params["code"].Split(',');   
                //var dt = new DataTable[id.Count()];    
                //for (int i = 0; i < id.Count(); i++)//查询勾选的条码添加到table列表
                //{
                //    dt[i] = lkm.GetList4Code("finterid =" + id[i]).Tables[0];
                //}
                //var newDataTable = dt[0].Clone();                //创建新表 克隆以有表的架构。
                //var objArray = new object[newDataTable.Columns.Count];   //定义与表列数相同的对象数组 存放表的一行的值。
                //for (int i = 0; i < dt.Count(); i++)
                //{
                //    for (int j = 0; j < dt[i].Rows.Count; j++)
                //    {
                //        dt[i].Rows[j].ItemArray.CopyTo(objArray, 0); //将表的一行的值存放数组中。
                //        newDataTable.Rows.Add(objArray); //将数组的值添加到新表中。
                //    }
                //}
                ////var data = lkm.GetList("fitemid ='1004208067884337'");//测试
                ListView1.DataSource = itemMasters;
                ListView1.DataBind();
            }

           


        }
    }
}