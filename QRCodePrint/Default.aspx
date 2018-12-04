<%@ Page Title="龙工欢迎您" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QRCodePrint._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
 
     <div id=box>
        
    </div>
    <div id="tb">
    <a href="#" class="easyui-linkbutton" data-options="iconCls:'icon-edit'" onclick="action.genelist(event)">批量生成二维码</a>
    </div>
    
    <div id="tt" style="padding: 10px">
    <a href="#" class="easyui-linkbutton" data-options="iconCls:'icon-add'" onclick="action.add(event)">新增</a>
    <a href="#" class="easyui-linkbutton" data-options="iconCls:'icon-edit'" onclick="action.edit(event)">编辑</a>
    <a href="#" class="easyui-linkbutton" data-options="iconCls:'icon-remove'" onclick="action.remove()" >删除</a>
    <a href="#" class="easyui-linkbutton" data-options="iconCls:'icon-undo'" onclick="action.undo()" >撤销</a>
    <a href="#" class="easyui-linkbutton" data-options="iconCls:'icon-save'" onclick="action.save()">保存</a>
    <a href="#" class="easyui-linkbutton" data-options="iconCls:'icon-save'" onclick="action.saveList()">批量生成二维码</a>
    <input id="printList" name="printList" value=""  /> 
    <input id="itemListSelect" name="itemListSelect" value="" />

    <!-- <input class="easyui-filebox" name="excelFile" style="width:20%;" data-options="buttonText:'上传Excel文件'"> -->
    <label style="margin-left:1%;margin-right:2%"><input  style="display:inline;width:170px"  id="excelFile" type="file" accept="application/vnd.openxmlformats-officedocument.spreadsheetml.sheet,application/vnd.ms-excel" name="excelFile" required="required" onchange="upfile()"></label>
    <!--  <input type="button" name="submit" value="上传文件" onclick="upExcel()"> -->
  <%--  <a href="#" class="easyui-linkbutton" onclick="removeExcel()" data-options="iconCls:'icon-upload'">取消上传</a>--%>
<form style="display: inline" id="jsonForm" action="WareHouseCode" method="post" enctype="application/x-www-form-urlencoded" target="_blank">
        <input type="hidden" id="jsonInput" name="jsonInput">
        <a href="#"  style="margin-left:2px" class="easyui-linkbutton" data-options="iconCls:'icon-print'" onclick="PrintQRCode(event)">二维码打印</a>

    </form>
        </div>

    
        <div style="display:none" id="win">      

		<div   class="easyui-layout" data-options="fit:true">            

			<%--<div data-options="region:'east',split:true" style="width:100px"></div>--%>
			<div data-options="region:'center'" style="padding:10px;">
			   <form method="post" action="Default.aspx" enctype="application/x-www-form-urlencoded" style='Height:100%;Width:100%' target="_self">			   
                <asp:Table ID="Table1" HorizontalAlign="Center" runat="server" BackColor="#3399FF" BorderStyle="Ridge" BorderWidth="1px" Height="100%"  Width="100%">
                    <asp:TableHeaderRow>
                        <asp:TableHeaderCell>数据项</asp:TableHeaderCell>
                        <asp:TableHeaderCell>数据值</asp:TableHeaderCell>
                    </asp:TableHeaderRow>
                    <asp:TableRow>
                        <asp:TableCell>料号</asp:TableCell>
              <asp:TableCell><input  id="itemCode" required="required" /></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>品名</asp:TableCell>
                 <asp:TableCell><input style="width:450px" id="itemName" type="text" required="required" /></asp:TableCell>

                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>序列号前缀</asp:TableCell>
               <asp:TableCell><input id="itemSN" type="text"   required="required" /></asp:TableCell>

                    </asp:TableRow>
                   
                    <asp:TableRow>
                        <asp:TableCell>供应商编码</asp:TableCell>
               <asp:TableCell><input id="SupplierCode" type="text" required="required" /></asp:TableCell>

                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>数量</asp:TableCell>
                        <asp:TableCell>
                 <input id="Count"  type="number" min="1" max="50" required="required" pattern="\d" />

                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableFooterRow>
                       <asp:TableCell ColumnSpan="2">
               <div id="glistpager" style="background:#efefef;border:1px solid #ccc;"></div> 
                       </asp:TableCell>
                    </asp:TableFooterRow>
                   <%-- <asp:TableRow>
                        <asp:TableCell ColumnSpan="2" HorizontalAlign="Center">
                      <input id="generateAC" type="button" onclick="generateCode()" value="生成"/>
                        </asp:TableCell>
                    </asp:TableRow>--%>
                </asp:Table>

                   </form>
                



            <%-- <span>&emsp;&emsp;&emsp;料号</span><input  id="itemrCode"  required="required"   style="width:300px"/> 
            <br />
            <span>&emsp;&emsp;&emsp;品名</span> <input id="itemName" class="easyui-textbox"  style="width:300px"/> 
             <br />
            <span>&emsp;规格型号</span> <input id="itemSP" class="easyui-textbox"  style="width:300px"> 
                 <br />
            <span>&emsp;&emsp;序列号</span><input id="itemSN"  class="easyui-textbox"  style="width:300px"/> 
             <br />
            <span>供应商编码</span><input id="supplierCode" class="easyui-textbox"  style="width:300px"/> 
                <br />
                <br />
                <br />
            <span>&emsp;生成数量</span><input type="text" class="easyui-numberbox" value="100" data-options="min:0,precision:0"/>

           </form> 
			</div>
			<div data-options="region:'south',border:false" style="text-align:right;padding:5px 0 0;">
				<a class="easyui-linkbutton" data-options="iconCls:'icon-ok'" href="javascript:void(0)" onclick="action.generateCode()" style="width:80px">Ok</a>
				<a class="easyui-linkbutton" data-options="iconCls:'icon-cancel'" href="javascript:void(0)" onclick="javascript:alert('cancel')" style="width:80px">Cancel</a>
			</div>
		</div>--%>
                </div>
            <div data-options="region:'south',border:false" style="text-align:right;padding:5px 0 0;">
				<a class="easyui-linkbutton" data-options="iconCls:'icon-ok'" href="javascript:void(0)" onclick="generateCode()" style="width:80px">生产</a>
				<a class="easyui-linkbutton" data-options="iconCls:'icon-cancel'" href="javascript:void(0)" onclick="javascript:alert('cancel')" style="width:80px">取消</a>
			</div>
            </div>
            
     </div>
    <script src="Scripts/PrintArea-master/js/jquery.printarea.js"></script>
   <script>
       function Itemmaster(lineno, itemcode, itemname, itemsn, spcode) {
           this.lineno = lineno;
           this.itemcode = itemcode;
           this.itemname = itemname;
           this.itemsn = itemsn;
           this.spcode = spcode;
       };

       function generateCode() {
           $('#win').window('close');
           var itemcode = $('#itemCode').val();
          // alert(itemcode);
        var itemName = $('#itemName').val();
        var itemSN = $('#itemSN').val();
        var supplierCode = $('#SupplierCode').val();
           var count = $('#Count').val();
           if (count ==="") {
               $.messager.alert('我的消息','这是一个提示信息！','info');
           }
           else {

           
              var  itemsArray = new Array();

            
         //  alert(cout);
           for (var i = 0; i < count; i++) {
               var no = "";
               if ((i+1).toString().length < count.toString().length) {
                  no= new Array( count.toString().length - (i+1).toString().length +1  ).join("0");       

               };
               no += (i + 1).toString();
               itemsArray.push({
                    行号: i.toString(),
                    料号: itemcode,
                    品名:itemName,
                    序列号:itemSN +no,
                    供应商编码:supplierCode,

               });             
               
               $('#box').datagrid({
                   data: itemsArray,
                   loadFilter: pagerFilter


               });
            //$('#box').datagrid('insertRow',{
            //    index: i,
            //   // loadFilter: pagerFilter,
            //    row: {
            //        行号: i.toString(),
            //        料号: itemcode,
            //        品名:itemName,
            //        序列号:itemSN +no,
            //        供应商编码:supplierCode,
            //    },
            //   })
           //   $('#box').datagrid({ loadFilter: pagerFilter })
        }}
       };
       $(function () {
             
           window.onafterprint = function () {

             
              // $('#win').window("close");

           };

           $('#printList').combogrid({
               panelWidth: 800,
               panelHeight: 500,
               width: 200,
               title: "已打印查询",
               prompt: "已打印查询",

               // value:'006',  

               idField: 'Id',
               textField: 'ItemMaster',
               url: 'SavePrintList.ashx',
               queryParams: {

                   action: "getList",

               },
               mode: "remote",
               rownumbers: true,
               pagination: true,
               multiple: true,
               fitColumns: true,
               onClickIcon: function () {

                  if (document.cookie.includes("Valid")) {
                       console.log("helloworld");
                           $.messager.show({

                               title: '温馨提示',
                               msg:"请登陆后查询",
                        })
                       // return false;
                       }
               },
               //onLoadSuccess: function () {
               //    console.log("goodluck");
               //},
               onBeforeLoad: function () {
                //    alert("请登陆后查询");
                 //  console.log(document.cookie);
                   console.log(document.cookie.includes("Valid"));

                    if (document.cookie.includes("Valid")) {
                       
                        return false;
                       }

               },
               //onLoadError: function () {                

               // //   alert("请登陆后查询");

               //},
               toolbar: [{
                   iconCls: 'icon-print', handler: function () {

                       $('#printList').combogrid("hidePanel");
                   


                       var rows = $('#printList').combogrid("grid").datagrid("getSelections");
                       console.log(rows);
                       var json = JSON.stringify(rows);
                       $.post(url = 'WareHouseCode', data = { rePrint: json }, success = function (data) {
                           //$('#win').window({

                     //      console.log(data);

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
                                },
                                //    {
                                //    iconCls: "icon-print",
                                //    handler: function () {


                                //        $("#codeprint").printArea();
                                //    }                                 



                                //},
                                    ],
                       
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
                  // alert(document.cookie);


                //   console.log(document.cookie.includes("Valid"));
                  
                      
                           $('#printList').combogrid("grid").datagrid("load");
                       
                   


               },
});  




           $('footer').hide();


       }





       );

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
        url: "ReadExcel.ashx",
        data: data,
        type: "Post",
        dataType: "text",
        cache: false,//上传文件无需缓存
        processData: false,//用于对data参数进行序列化处理 这里必须false
        contentType: false, //必须
        beforeSend: function () {

            $.messager.progress({

                title: "提示",
                msg: "加载中。。。。。。",
                

            });

        },
        success: function (result) {
            //$('#box').datagrid({
            //    url: "http://192.168.60.3/readexcel.ashx",
            //});

          //  console.log(result);
            $('#box').datagrid('loadData', JSON.parse(result));
            $.messager.progress('close');

        },


    })
       };
       function removeExcel() {
           alert("dd");
           $("#excelFile").val("");
        //   $('#box').datagrid()


       };
       function SetAfterPrint() {



           $.post("SavePrintList.ashx", { action: "print" })};


      
       function printThis() {
            SetAfterPrint();
var el = document.getElementById("codeprint");
var iframe = document.createElement('IFRAME');
var doc = null;
iframe.setAttribute('style', 'position:absolute;width:0px;height:0px;left:500px;top:500px;');
document.body.appendChild(iframe);
doc = iframe.contentWindow.document;
// 引入打印的专有CSS样式，根据实际修改
           // doc.write("<LINK rel="stylesheet" type="text/css" href="css/print.css">");
           doc.write(el.outerHTML);
          
doc.close();
// 获取iframe的焦点，从iframe开始打印
iframe.contentWindow.focus();
           iframe.contentWindow.print();
           
if (navigator.userAgent.indexOf("MSIE") > 0)
{
    document.body.removeChild(iframe);
           }
           
       };

       $(function () {

           $('#itemListSelect').combogrid({
               panelWidth: 800,
               panelHeight: 500,
               width: 150,
               url: 'tools/GetItemmaster.ashx',
               idField: 'itemId',
               textField: 'itemCode',
               title: "物料代码查询",
               prompt: '请输入要查询的料号',
               mode: "remote",
               rownumbers: true,
               pagination: true,
               multiple: true,
               fitColumns: true,
               toolbar:'#tb',
               //toolbar: [

               //    {
               //        iconCls: 'icon-search',
               //        title:'生成二维码',
               //        handler: function () {

               //            alert('helloworld');
               //        }


               //    }
               //],
               columns: [[
                   {
                       field: 'itemId',
                       title: 'ID',
                       checkbox:true,
                   },

                   {

                       field: 'itemCode',
                       title: '料号',
                   }, {
                       field: 'itemName',
                       title: '品名',
                   }, {
                       field: 'unit',
                       title: '单位',
                   }, {
                       field: 'whName',
                       title: '存储地点',
                   }, {
                       field: 'orgName',
                       title: '组织',
                   }
               ]],
           });

        //   $('#itemListSelect').combogrid('textbox').unbind()//先解绑所有事件，要不输入的内容找不到匹配项，回车时输入框内容会被清空
        //.keydown(function (e) {
        //    if (e.keyCode == 13) {
        //        var keyValue = $('#itemListSelect').combogrid('textbox').val();
        //        var queryParams = $('#itemListSelect').combogrid("grid").datagrid('options').queryParams;
        //        queryParams.q = keyValue;//keyword;///这里变量名搞错了，是keyValue，不是keyword
        //        //下面这句不需要，因为queryParams是对象，地址引用，可以直接更改optinos.queryParams的内容
        //        //$('#cc').combogrid("grid").datagrid('options').queryParams = queryParams;
        //        //重新加载
        //        $('#itemListSelect').combogrid("grid").datagrid("reload");

        //        $('#itemListSelect').combogrid("setValue", keyValue);
        //        //将查询条件存入隐藏域
        //        //$('#hdKeyword').val(keyValue)
        //    }
        //});




       });

   </script>
    

</asp:Content>
