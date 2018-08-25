<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="WareHouseCodeList.aspx.cs" Inherits="QRCodePrint.WareHouseCodeList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>二维码打印列表</title>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
     <script type="text/javascript">            
         $(function () {
             window.onbeforeprint = function () {
                 //   $('#PrintButton').click();
                 //alert("打印完成");

             };


             window.onafterprint = function () {

                 $.post("SavePrintList.ashx", { action: "print" }, function (data) {

                     $.messager.show({
                         title: "温馨提示",
                         msg: data,
                         style: {
                             left: 500,

                             top: 300,


                         }
                     });

                     //  alert("打印完成");
                 });


             };
         });
        //打印
        function printdiv(printpage) {
            var headstr = "<html><head><title";
                headstr += "></title></head><body>";
            var footstr = "</body></html>";
            var printData = document.getElementById(printpage).innerHTML;
            var oldstr = document.body.innerHTML;
            document.body.innerHTML = headstr + printData + footstr;
            window.print();
            document.body.innerHTML = oldstr;
            //this.window.close();
            return true;
          
         };
        //打印完成后,置打印标志位
         function doPrint() {
          //  $('#PrintButton').click();
            printdiv('codeprint');
            
         
         };
        
          

    </script>
    <style type="text/css" media="print">
        html,body{

            margin:0;
            /*margin-top:5px;
            margin-left:3px;*/

        }
        img{


            max-height:100%;
        }
        table{
            max-width:100%;

        }
        /*table {
          page-break-after:auto;
          page-break-inside:auto;
          page-break-before:auto;
     }
    tr {
          page-break-after:auto;
          page-break-inside:auto;
          page-break-before:auto;
     }*/
        .noprint, #PrintButton {
            display: none;
        }
        .ftitle
        {                       
            margin:0.1px;
            overflow:hidden;
        }       
        </style>
    <style media="screen">

         #PrintButton {
            display: none;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server" autocomplete="on">
        <div class="noprint">
        <input type="button" value="打印" onclick="doPrint()" />
            <asp:Button   ID="PrintButton" runat="server" Text="二维码打印" OnClick="PrintButton_Click" />    
    </div>
    <div id="codeprint"><%--webkit-transform: rotate(-90deg); -moz-transform: rotate(-90deg);--%>
        <asp:ListView ID="ListView1" runat="server">
            <ItemTemplate>
                <div style="height:100px;overflow:hidden">
                <table style="border: 1px solid black; border-radius: 3px; width:140px; height:85px; text-align: center; font-size: 7px;">
                    <tr>
                        <td>
                            <img src="tools/BarCode.ashx?id=<%#Eval("fInfo") %>" alt="" style="height: 85px; float: right;" />
                        </td>
                        <td>
                            <div style="text-align: left;height:85px; overflow:hidden;word-break: break-all;margin-left:-3px;" >
      
                                <div class="ftitle" style="height:20px;word-break: break-all;margin-top: 0px;">[<%#Eval("ItemMaster") %>]</div>
    
                                <div class="ftitle" style="height:20px;width:auto;word-break: break-all;overflow-y:hidden">[<%#Eval("ItemName")%>]</div>
                                <div class="ftitle" style="height:20px;width:auto;word-break: break-all;overflow-y:hidden">[<%#Eval("SupplierCode")%>]</div>
                                <span>SN:</span>
                                <div class="ftitle" style="height:10px;width:auto;word-break: break-all"><%#Eval("SerialNo").ToString().Length<=0 ?"N/A":Eval("SerialNo") %></div>
                            </div>    
                        </td>
                    </tr>                
                </table>
               </div>
            </ItemTemplate>
        </asp:ListView>
    </div>
    </form>
</body>
</html>
