<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="QRCodePrint.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2><%: Title %>.</h2>
    <h3>欢迎联系我们</h3>
    <address>
        上海市松江区新桥镇民益路26号<br />       
        <abbr title="Phone">P:</abbr>
        021-37602000
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
     <style>
         #goodluck{
             
                height:50%;
            }


    </style>
</asp:Content>
