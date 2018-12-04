using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace QRCodePrint.Tools
{
    /// <summary>
    /// GetUseableKanban 的摘要说明
    /// </summary>
    public class GetUseableKanban : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
           
            using (SqlConnection sqlconn =new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["KanbanModal"].ConnectionString))
            {               
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("select main.fbillno,main.fItemCode,main.fModel,main.fcount,main.fthickness,main.fmin_count,main.fblank_batch,main.ftransfer_batch, ");
                stringBuilder.Append("main.fset_count, COUNT(second.fbillno) as useableKb,COUNT(second.fbillno)*main.ftransfer_batch as needMake from (select lkanban.fbillno, ");
                stringBuilder.Append("master.fItemCode,master.fItemName,master.fModel,lkanban.fthickness,lkanban.fmin_count, ");
                stringBuilder.Append("lkanban.fblank_batch,lkanban.ftransfer_batch,lkanban.fset_count, sum(ISNULL(inv.fcount,0)) fcount from  lkm_kanban lkanban ");
                stringBuilder.Append("inner join lkm_Materials master on lkanban.fitemid =master.fInterID ");
                stringBuilder.Append("inner join LKM_MCCItemEntry lke on master.fItemID =lke.fitemid  ");
                stringBuilder.Append("inner join LKM_MCCPTEntry lmentry on lmentry.fConfigID =lke.fConfigID ");
                stringBuilder.Append("inner join lkm_CommonBill lc on lc.fInterID =lmentry.fProTecID ");
                stringBuilder.Append("left join lkm_blank_inventory inv on inv.fitemid =lkanban.fitemid and inv.flineid =lmentry.fConfigID and inv.fproid = lmentry.fProTecID ");
                stringBuilder.Append("where lkanban.fbillno like 'S%'  and lmentry.fProTecID != 56 and fProTecID !=101 ");
                stringBuilder.Append("group by lkanban.fbillno, master.fItemCode,master.fItemName,master.fModel,lkanban.fthickness,lkanban.fmin_count, ");
                stringBuilder.Append("lkanban.fblank_batch,lkanban.ftransfer_batch,lkanban.fset_count) main left join ");
                stringBuilder.Append("lkm_exec_kanban_entry second on main.fbillno =second.fbasic_billno and (second.fstatus =0 or second.fstatus =1) ");
                stringBuilder.Append("group by  main.fbillno,main.fItemCode,main.fModel,main.fcount,main.fthickness,main.fmin_count,main.fblank_batch, ");
                stringBuilder.Append("main.ftransfer_batch,main.fset_count ");
                SqlCommand command = new SqlCommand(stringBuilder.ToString(),sqlconn);               
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                sqlconn.Open();
                adapter.Fill(table);
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(table);
                context.Response.Write(json);   
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