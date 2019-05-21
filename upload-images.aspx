<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="upload-images.aspx.cs" Inherits="BootstrapDynamicSlider.upload_images" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <title>Upload Images </title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container" style="padding-top:10px">
        <div class="form-horizontal">
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Upload Image 1 " CssClass="col-md-2 control-label"></asp:Label>
               <div class="col-md-3">
                   <asp:FileUpload ID="img01" runat="server" CssClass="form-control"/>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                       runat="server" ErrorMessage="This field is required" ControlToValidate="img01" CssClass="text-danger"></asp:RequiredFieldValidator>
               </div>
            </div>
             <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Upload Image 2 " CssClass="col-md-2 control-label"></asp:Label>
               <div class="col-md-3">
                   <asp:FileUpload ID="img02" runat="server" CssClass="form-control"/>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                       runat="server" ErrorMessage="This field is required" ControlToValidate="img02" CssClass="text-danger"></asp:RequiredFieldValidator>
               </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Upload Image 3 " CssClass="col-md-2 control-label"></asp:Label>
               <div class="col-md-3">
                   <asp:FileUpload ID="img03" runat="server" CssClass="form-control"/>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
                       runat="server" ErrorMessage="This field is required" ControlToValidate="img03" CssClass="text-danger"></asp:RequiredFieldValidator>
               </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Upload Image 4 " CssClass="col-md-2 control-label"></asp:Label>
               <div class="col-md-3">
                   <asp:FileUpload ID="img04" runat="server" CssClass="form-control"/>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator4" 
                       runat="server" ErrorMessage="This field is required" ControlToValidate="img04" CssClass="text-danger"></asp:RequiredFieldValidator>
               </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Upload Image 5 " CssClass="col-md-2 control-label"></asp:Label>
               <div class="col-md-3">
                   <asp:FileUpload ID="img05" runat="server" CssClass="form-control"/>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator5" 
                       runat="server" ErrorMessage="This field is required" ControlToValidate="img05" CssClass="text-danger"></asp:RequiredFieldValidator>
               </div>
            </div>
            <div class="form-group">
                <div class="col-md-3 col-md-offset-2">
                    <asp:Button ID="btnUpload" runat="server" Text="Uplaod Images" CssClass="btn btn-primary btn-group-lg" OnClick="btnUpload_Click"/>
                    <asp:Label ID="lblMessage" runat="server" CssClass="text-success"></asp:Label>
                </div>
            </div>
        </div>
    
    </div>
    </form>
</body>
</html>