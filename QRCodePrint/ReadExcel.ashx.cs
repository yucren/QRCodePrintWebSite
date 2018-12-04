using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using LonKing.Model;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using Excel = Microsoft.Office.Interop.Excel;

namespace QRCodePrint
{
    /// <summary>
    /// ReadExcel1 的摘要说明
    /// </summary>
    public class ReadExcel1 : IHttpHandler
    {
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowThreadProcessId(IntPtr hwnd, out int ID);

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            
            HttpPostedFile files = context.Request.Files["excelFile"];
            if (files != null)
            {
                var fileName = new Random().Next(1000000) + Path.GetExtension(files.FileName);
                files.SaveAs(context.Server.MapPath("~/ExcelFiles/") + fileName );
                context.Response.Write(ReadExcelAll(context.Server.MapPath("~/ExcelFiles/") + fileName));
            }
        }
        static string ReadExcelAll(string path)
        {
            int ProcIdXL = 0;
            Excel.Application application = new Excel.Application();
            
            Excel.Workbook workbook = application.Workbooks.Open(Filename:path,ReadOnly:true,IgnoreReadOnlyRecommended:true,Notify:false);

            Excel.Worksheet worksheet = application.Sheets[1];
            Excel.Range dd = worksheet.Range["a1"].CurrentRegion.Offset[1, 0].Resize;
            var ddd = dd.Resize[dd.Rows.Count - 1, dd.Columns.Count];
            List<ItemMaster> itemMasters = new List<ItemMaster>();

            foreach (Excel.Range item in ddd.Rows)
            {
                ItemMaster itemMaster = new ItemMaster();
                for (int i = 2; i <= 5; i++)
                {
                    
                    switch (i)
                    {
                        case 2:
                            try
                            {


                                itemMaster.料号 = Convert.ToString( application.Cells[item.Row, i].Value);
                            }
                            catch (RuntimeBinderException)
                            {

                                itemMaster.料号 = "";
                            }

                            break;
                        case 3:
                            try
                            {


                                itemMaster.品名 = application.Cells[item.Row, i].Value;
                            }
                            catch (RuntimeBinderException)
                            {

                                itemMaster.品名 = "";
                            }
                            break;
                        case 4:
                            try
                            {


                                itemMaster.序列号 =Convert.ToString(application.Cells[item.Row, i].Value);
                            }
                            catch (RuntimeBinderException)
                            {

                                itemMaster.序列号 = "";
                            }
                            break;
                        case 5:
                            try
                            {


                                itemMaster.供应商编码 =Convert.ToString(  application.Cells[item.Row, i].Value);
                            }
                            catch (RuntimeBinderException)
                            {

                                itemMaster.供应商编码 = "";
                            }
                            break;


                        default:
                            break;
                    }                 
                 }
                itemMasters.Add(itemMaster);
            }

          var json = "{\"total\":" + itemMasters.Count + ",\"rows\":" +  JsonConvert.SerializeObject(itemMasters) + "}";

            GetWindowThreadProcessId(new IntPtr(application.Hwnd), out ProcIdXL);
            Process xproc = Process.GetProcessById(ProcIdXL);
            xproc.Kill();
            //workbook.Close(SaveChanges: false);
            //dd = null;
            //ddd = null;
            //workbook = null;
            //worksheet = null;
            //application.Quit();
            //application = null;
            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            //GC.Collect();

            //GC.WaitForPendingFinalizers();
            //int getneration = System.GC.GetGeneration(application);
            //System.Runtime.InteropServices.Marshal.ReleaseComObject(application);
            //GC.Collect(getneration);

            return json;
            //   Console.Read();
        }


    
        static string ReadExcels(string path)
        {
            using (SpreadsheetDocument sp = SpreadsheetDocument.Open(path, true))
            {
                IEnumerable<Sheet> sheets = sp.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();
                List<JObject> jObjects = new List<JObject>();

                if (sheets.Count() == 0)
                {
                    return "";
                }
                string relationId = sheets.First().Id.Value;
                WorksheetPart worksheetPart = (WorksheetPart)sp.WorkbookPart.GetPartById(relationId);
                SharedStringTable sharedStringTable = sp.WorkbookPart.SharedStringTablePart.SharedStringTable;
                IEnumerable<Row> rows = worksheetPart.Worksheet.GetFirstChild<SheetData>().Elements<Row>().Where(r => r.RowIndex > 1);
                Row row1 = worksheetPart.Worksheet.GetFirstChild<SheetData>().Elements<Row>().Where(r => r.RowIndex == 1).First();
                IEnumerable<Cell> cells1 = row1.Elements<Cell>();

                int count = 0;

                foreach (var row in rows)
                {

                    //  Console.WriteLine("行" + int.Parse(row.RowIndex));



                    IEnumerable<Cell> cells = row.Elements<Cell>();
                    //var dd = JsonConvert.SerializeObject(cells);
                    //Console.WriteLine(dd);

                    if (sharedStringTable == null)
                    {
                        return "";
                    }


                    JObject jObject = new JObject();

                    foreach (var item in cells)
                    {




                        var cell2 = cells1.Skip(count).Take(1).First();




                        if (item.DataType != null && item.DataType.Value == CellValues.SharedString)
                        {
                            SharedStringItem item1 = sharedStringTable.Elements<SharedStringItem>().ElementAt(int.Parse(item.CellValue.Text));


                            if (cell2.DataType != null && cell2.DataType.Value == CellValues.SharedString)
                            {
                                SharedStringItem item2 = sharedStringTable.Elements<SharedStringItem>().ElementAt(int.Parse(cell2.CellValue.Text));
                                //    Console.WriteLine(item1.Text.Text);
                                jObject.Add(new JProperty(item2.Text.Text, item1.Text.Text));
                            }
                            else
                            {
                                jObject.Add(new JProperty(cell2.CellValue.Text, item1.Text.Text));


                            }


                            count += 1;
                            continue;

                        }

                        if (cell2.DataType != null && cell2.DataType.Value == CellValues.SharedString)
                        {
                            SharedStringItem item2 = sharedStringTable.Elements<SharedStringItem>().ElementAt(int.Parse(cell2.CellValue.Text));
                            //    Console.WriteLine(item1.Text.Text);



                            jObject.Add(new JProperty(item2.Text.Text, item.CellValue == null ? "" : item.CellValue.Text));


                        }
                        else
                        {
                            jObject.Add(new JProperty(cell2.CellValue.Text, item.CellValue.Text));


                        }


                        //   Console.WriteLine(item.CellValue.Text);
                        //jObjects.Add(new JObject(new JProperty( "gg",item.CellValue.Text)));

                        count += 1;

                    }

                    jObjects.Add(jObject);
                    count = 0;





                }

                var dd = "{\"total\":" + jObjects.Count + ",\"rows\":" + JsonConvert.SerializeObject(jObjects) + "}";
                return dd;
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