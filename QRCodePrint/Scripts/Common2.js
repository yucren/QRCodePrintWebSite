function endEditing() {
    if (editIndex == undefined) { return true }
    if ($('#box').datagrid('validateRow', editIndex)) {
        $('#box').datagrid('endEdit', editIndex);
        editIndex = undefined;
        return true;
    } else {
        return false;
    }
};
var editIndex = undefined;
function onClickCell(index, field) {
    if (endEditing()) {
        $('#box').datagrid('selectRow', index)
            .datagrid('editCell', { index: index, field: field });
        editIndex = index;
    }
};

$(function () {

    $("body").click(function () {

     //   alert("how are you");

    });

    $.extend($.fn.datagrid.methods, {
        editCell: function (jq, param) {
            return jq.each(function () {
                var opts = $(this).datagrid('options');
                var fields = $(this).datagrid('getColumnFields', true).concat($(this).datagrid('getColumnFields'));
                for (var i = 0; i < fields.length; i++) {
                    var col = $(this).datagrid('getColumnOption', fields[i]);
                    col.editor1 = col.editor;
                    if (fields[i] != param.field) {
                        col.editor = null;
                    }
                }
                $(this).datagrid('beginEdit', param.index);
                for (var i = 0; i < fields.length; i++) {
                    var col = $(this).datagrid('getColumnOption', fields[i]);
                    col.editor = col.editor1;
                }
            });
        }
    });

    
   

  //  $('footer').hide();
    $.extend($.fn.validatebox.defaults.rules, {
        maxLength: {

            validator: function (value, param) {
                return value.length <= param[0];
            },
            message: 'Please enter at least {0} characters.',
        },
        number: {
            validator: function (value) {
                var patten =  new RegExp("^\\d{4,20}$","g");
                              

                return patten.test(value);  
            },
            message:"最少输入四位数字",

        },


    });

$('#box').datagrid({
//url:"http://192.168.60.115/readexcel.ashx",
//title:"龙工(上海)挖掘机制造有限公司二维码打印平台",
fit:true,
fitColumns:false,
singleSelect:false,
toolbar:'#tt',
rownumbers:true,
ctrlSelect:true,
checkOnSelect:true,
selectOnCheck: true,
pagination:true,
showHeader:true,


columns:[[
{
	field:'行号',
	title:"行号",
	checkbox:true,
        
},
{

field:'料号',
    title: "料号",
    width:100,
    editor: {
        type: 'textbox',
        options: {
            required: true,
            validType:['maxLength[50]','number'],
        },


    },
},
{
field:'品名',
    title: "品名",
    width: 100,
    editor: {
        type: 'textbox',
        //options: {
        //    required: true,
        //  //  validType:'maxLength[10]',
        //},


    },
},
{
field:'序列号',
    title: "序列号",
    width: 100,
    editor: {
        type: 'textbox',
        //options: {
        //    required: true,
        //  //  validType:'maxLength[10]',
        //},


    },
},
{
field:'供应商编码',
    title: "供应商编码",
    width: 100,
    editor: {
        type: 'textbox',
        //options: {
        //    required: true,
        //  //  validType:'maxLength[10]',
        //},


    },
}
    ]],
    onClickCell: onClickCell,




    });

   

});
var editRow = undefined;
var count = 0;
var action = {

    edit: function (event) {
        var row = $('#box').datagrid('getSelected');
        var rownum = $('#box').datagrid('getRowIndex', row);
        if (editRow != undefined) {

            if (editRow != rownum) {
                alert('请先保存之前的数据,再编辑');
                $('#box').datagrid('clearSelections');
                $('#box').datagrid('highlightRow', editRow);
                $('#box').datagrid("selectRow", editRow);
               
               

                return;

            }

          

        }
        

       
        editRow = rownum;

        if (editRow === undefined || editRow===-1) {
         //   alert("请选择要更改的行");
           // $.messager.alert("警告", "请选择要更改的行", "info");
            $.messager.show({
                title: "温馨提示",
                msg: "未选择任何行",
                style: {
                    left: event.clientX + 20,

                    top: event.clientY + 20,


                },
            });
            editRow = undefined;
        }
        else {
            $('#box').datagrid('beginEdit', rownum);
            console.log(editRow);
        }
        console.log(event.clientX)
        console.log(event.clientY)

        //  $('#box').datagrid('selectRow', 1);
       
      

    },
    save: function () {
        var rows = $('#box').datagrid('getChanges');
       
    //    alert(rows.length + ' rows are changed!');
        if (editRow !=undefined) {
          //  console.log(editRow);
         //   $('#box').datagrid('endEdit', editRow);
            $('#box').datagrid("acceptChanges");
            editRow = undefined;

        }
        else {
            var row = $('#box').datagrid('getSelected');
            var rownum = $('#box').datagrid('getRowIndex', row);
            $('#box').datagrid("endEdit", rownum);
         //   alert("未更改任何行");
        }

        



    },
    add: function () {
       
        if (count == 0 && editRow != undefined    ) {
            alert("请先保存修改数据");
        }
        else {
            count += 1;
            
            $('#box').datagrid("appendRow", {
                

            });
            editRow = $('#box').datagrid('getRows').length - 1;
            $('#box').datagrid('selectRow', editRow)
                .datagrid('beginEdit', editRow);
            console.log(count);
            console.log(editRow);


        }
        
   

    },
    undo: function () {
       // $('#box').datagrid('endEdit', editRow);
        var rows = $('#box').datagrid('getChanges');
     //   alert(rows.length + ' rows are changed!');
        if (rows.length !=0) {
            $('#box').datagrid("rejectChanges");
            editRow = undefined;
        }
       

    },
    remove: function () {

        var row = $('#box').datagrid('getSelected');
        var rownum = $('#box').datagrid('getRowIndex', row);
        $('#box').datagrid("deleteRow", rownum);


    },


};
function PrintQRCode()
{
  // var json= $('#box').datagrid('getSelections');    
  // console.log(json);
  //  $('#jsonInput').val(JSON.stringify(json));

  ////  console.log($('#jsonInput').val());
  //  var jsonform = document.getElementById('jsonForm').submit();

  //  console.log(jsonform);

 //   $.ajax({
 //    url:"http://localhost:47481/WareHouseCode.aspx",
 //    type:'post',
 //    cache:false,
 //    contentType:'text/html',
 //    success:function(result)
 //    {
 //          console.log(result);

 //    },
 //    error:function(xhr,type,errorThrown){
	// 	//异常处理；
	// 	console.log(errorThrown);
	// },
 //    data:JSON.stringify(json),




 //   })



    var rows = $('#box').datagrid("getSelections");
    var json = JSON.stringify(rows);
    $.post(url = 'WareHouseCode', data = { jsonInput: json }, success = function (data) {
        //$('#win').window({

        console.log(data);

        //    content: data,
        //});
        $('#win').window({
            width: 600,
            height: 400,
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


};



function getData() {
    var rows = [];


    return rows;
}

function pagerFilter(data) {
    if (typeof data.length == 'number' && typeof data.splice == 'function') {	// is array
        data = {
            total: data.length,
            rows: data
        }
    }
    var dg = $(this);
    var opts = dg.datagrid('options');
    var pager = dg.datagrid('getPager');
    pager.pagination({
        onSelectPage: function (pageNum, pageSize) {
            opts.pageNumber = pageNum;
            opts.pageSize = pageSize;
            pager.pagination('refresh', {
                pageNumber: pageNum,
                pageSize: pageSize
            });
            dg.datagrid('loadData', data);
        }
    });
    if (!data.originalRows) {
        data.originalRows = (data.rows);
    }
    var start = (opts.pageNumber - 1) * parseInt(opts.pageSize);
    var end = start + parseInt(opts.pageSize);
    data.rows = (data.originalRows.slice(start, end));
    return data;
}

$(function () {
    $('#box').datagrid({ loadFilter: pagerFilter })
});


function upExcel() {
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

        //    console.log(result);
            $('#box').datagrid('loadData', JSON.parse(result));
        },


    });


}


