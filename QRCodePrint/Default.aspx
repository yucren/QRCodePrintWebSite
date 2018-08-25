<%@ Page Title="龙工欢迎您" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QRCodePrint._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
     
     <div id=box>
        
    </div>
    <div id="tt" style="padding: 10px">
     <a href="#" class="easyui-linkbutton" data-options="iconCls:'icon-add'" onclick="action.add(event)">新增</a>
    <a href="#" class="easyui-linkbutton" data-options="iconCls:'icon-edit'" onclick="action.edit(event)">编辑</a>
    <a href="#" class="easyui-linkbutton" data-options="iconCls:'icon-remove'" onclick="action.remove()" >删除</a>
         <a href="#" class="easyui-linkbutton" data-options="iconCls:'icon-undo'" onclick="action.undo()" >撤销</a>
    <a href="#" class="easyui-linkbutton" data-options="iconCls:'icon-save'" onclick="action.save()">保存</a>
    <input id="printList" name="printList" value="" /> 


    <!-- <input class="easyui-filebox" name="excelFile" style="width:20%;" data-options="buttonText:'上传Excel文件'"> -->
    <label>请上传解密后的新版Excel文件<input  style="display:inline" id="excelFile" type="file" name="excelFile" required="required" onchange="upfile()"></label>
    <!--  <input type="button" name="submit" value="上传文件" onclick="upExcel()"> -->
  <%--  <a href="#" class="easyui-linkbutton" onclick="removeExcel()" data-options="iconCls:'icon-upload'">取消上传</a>--%>
<form style="display: inline" id="jsonForm" action="WareHouseCode" method="post" enctype="application/x-www-form-urlencoded" target="_blank">
        <input type="hidden" id="jsonInput" name="jsonInput">
        <a href="#" style="margin-left: 20px" class="easyui-linkbutton" data-options="iconCls:'icon-print'" onclick="PrintQRCode()">二维码打印</a>

    </form>
        <div id="win">



        </div>
   

</div>
   <script>
       $(function () {
             
           window.onafterprint = function () {

             
              // $('#win').window("close");

           };

           $('#printList').combogrid({    
               panelWidth: 800,
               panelHeight:500,
               
   // value:'006',  
     
    idField:'ItemMaster',    
    textField:'ItemMaster',    
               url: 'SavePrintList.ashx',
               queryParams: {

                   action: "getList",

               },
               mode: "remote",
               rownumbers: true,
               pagination: true,
               multiple: true,
               toolbar: [{
                   iconCls: 'icon-print', handler: function () {

                       $('#printList').combogrid("hidePanel");
                   


                       var rows =$('#printList').combogrid("grid").datagrid("getSelections");
                       var json = JSON.stringify(rows);
                       $.post(url = 'WareHouseCode', data = { rePrint: json }, success = function (data) {
                           //$('#win').window({

                           console.log(data);

                           //    content: data,
                           //});
                            $('#win').window({ 
                    width:600,    
                    height:400,    
                    modal: true,
                                zIndex: 100000,
                                content: $(data).find("#codeprint").prop("outerHTML"),
                                tools: [{
                                    iconCls: "icon-print",
                                    handler: function () {


                                        printThis();
                                    }


                                }],
                       
                });  
                         
                       });
                       

                   }
               }],
             
               columns: [[
        {field:"Id",title:"Id",checkbox:true},
        { field: 'ItemMaster', title: '料号', width: 100 }, 
       {field:'ItemName',title:'品名',width:100},
        {field:'SerialNo',title:'序列号',width:100},    
        {field:'SupplierCode',title:'供应商编码',width:70},    
        { field: 'UserName', title: '用户名', width: 100 },
                   { field: 'PrintDate', title: '打印日期', width: 150 },
                   //{
                   //    field: "modifyTool", title: "操作", formatter: function (value, row, index) {

                   //        return "<a href='#' onclick='alert(\"goodluck\");'>修改</a>";
                   //    }
                   //},

               ]],
               onShowPanel: function () {
                  
                   $('#printList').combogrid("grid").datagrid("load");


               },
});  




           $('footer').hide();
           var fileObj = document.getElementById("excelFile").files[0]; // js 获取文件对象

           if (typeof (fileObj) != "undefined" || fileObj.size > 0) {            

               upfile();
           }

       });

       function upfile() {
            var fileObj = document.getElementById("excelFile").files[0]; // js 获取文件对象
    if (typeof (fileObj) == "undefined" || fileObj.size <= 0) {
        alert("请选择Excel文件");
        return;
    }
    var formFile = new FormData();
    formFile.append("action", "UploadVMKImagePath");
    formFile.append("excelFile", fileObj); //加入文件对象
    var data = formFile;
    $.ajax({

        url: "http://localhost/ReadExcel.ashx",
        data: data,
        type: "Post",
        dataType: "text",
        cache: false,//上传文件无需缓存
        processData: false,//用于对data参数进行序列化处理 这里必须false
        contentType: false, //必须
        success: function (result) {
            //$('#box').datagrid({
            //    url: "http://192.168.60.3/readexcel.ashx",
            //});

          //  console.log(result);
            $('#box').datagrid('loadData', JSON.parse(result));
        },


    })
       };
       function removeExcel() {
           alert("dd");
           $("#excelFile").val("");
        //   $('#box').datagrid()


       };
       function printThis() {
var el = document.getElementById("codeprint");
var iframe = document.createElement('IFRAME');
var doc = null;
iframe.setAttribute('style', 'position:absolute;width:0px;height:0px;left:500px;top:500px;');
document.body.appendChild(iframe);
doc = iframe.contentWindow.document;
// 引入打印的专有CSS样式，根据实际修改
// doc.write("<LINK rel="stylesheet" type="text/css" href="css/print.css">");
doc.write('<div>' + el.innerHTML + '</div>');
doc.close();
// 获取iframe的焦点，从iframe开始打印
iframe.contentWindow.focus();
iframe.contentWindow.print();
if (navigator.userAgent.indexOf("MSIE") > 0)
{
    document.body.removeChild(iframe);
}
       };
      
   </script>
</asp:Content>

