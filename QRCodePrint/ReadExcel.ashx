<%@ WebHandler Language="C#" Class="ReadExcel" %>

using System;
using System.Web;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


public class ReadExcel : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        HttpPostedFile files = context.Request.Files["excelFile"];
        if (files != null)
        {

            files.SaveAs(context.Server.MapPath("~/") + files.FileName);
            context.Response.Write(ReadExcels(context.Server.MapPath("~/") + files.FileName));
        }


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
    public bool IsReusable {
        get {
            return false;
        }
    }

}