<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WareHouseCode1.aspx.cs" Inherits="QRCodePrint.WareHouseCode" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

  
     <script type="text/javascript">            
        
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
            printdiv('codeprint');
          



            });
         
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
            
             /*page-break-after:auto;
          page-break-inside:auto;
          page-break-before:auto;*/

        }
        /*table {
          page-break-after:auto;
          page-break-inside:auto;
          page-break-before:auto;
     }*/
    /*tr {
          page-break-after:auto;
          page-break-inside:auto;
          page-break-before:auto;
     }*/
        .noprint,footer,#ctl01  {
            display: none;
        }
        .ftitle
        {                       
            margin:0.1px;
            overflow:hidden;
        }       
        </style>
     <div class="noprint">
        <input type="button" value="打印" onclick="doPrint()" />        
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
      
                                <div class="ftitle" style="height:20px;word-break: break-all;margin-top: 0px;">[<%#Eval("料号") %>]</div>
    
                                <div class="ftitle" style="height:20px;width:auto;word-break: break-all;overflow-y:hidden">[<%#Eval("品名")%>]</div>
                                <div class="ftitle" style="height:20px;width:auto;word-break: break-all;overflow-y:hidden">[<%#Eval("供应商编码")%>]</div>
                                <span>SN:</span>
                                <div class="ftitle" style="height:10px;width:auto;word-break: break-all"><%#Eval("序列号").ToString().Length<=0 ?"N/A":Eval("序列号") %></div>
                            </div>    
                        </td>
                    </tr>                
                </table>
               </div>
            </ItemTemplate>
        </asp:ListView>
    </div>
   
</asp:Content>
