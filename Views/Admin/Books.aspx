<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="OnlineBookShop.Views.Admin.Books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="container-fluid">
    <div class="row">
        <div class="col">
            <h3 class="text-center">Manage Books</h3>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <div class="mb-3">
                <label for="" class="form-label text-success">Book Title</label>
                <input type="text" placeholder="Title" runat="server" id="BNameTb" autocomplete="off" class="form-control"/>
            </div>
            <div class="mb-3">
                <label for="" class="form-label text-success">Author</label>
                <asp:DropDownList ID="BAuthCb" runat="server"  class="form-control" ></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="" class="form-label text-success">Categories</label>
                <asp:DropDownList ID="BCatCb" runat="server" class="form-control" ></asp:DropDownList>
            </div>
                        <div class="mb-3">
                <label for="" class="form-label text-success">Price</label>
                <input type="text" id="BPriceTb" runat="server" placeholder="Price" autocomplete="off" class="form-control"/>
            </div>
                        <div class="mb-3">
                <label for="" class="form-label text-success">Quantity</label>
                <input type="text" id="BQuanTb" runat="server" placeholder="Quantity" autocomplete="off" class="form-control"/>
            </div>
            <div class="row">
                <asp:Label runat="server" ID="ErrMsg" CssClass="text-danger text-center"></asp:Label>
                <div class="col d-grid">
                    <asp:Button Text="Update" runat="server" ID="UpdateBtn" class="btn btn-warning btn-block" OnClick="UpdateBtn_Click" />
                </div>
                <div class="col d-grid">
                    <asp:Button Text="Save" runat="server" ID="SaveBtn" class="btn btn-success btn-block" OnClick="SaveBtn_Click" />
                </div>
                <div class="col d-grid">
                    <asp:Button Text="Delete" runat="server" ID="DeleteBtn" class="btn btn-danger btn-block" OnClick="DeleteBtn_Click" />
                </div>
            </div>
        </div>
        <div class="col-md-8">
            <asp:GridView ID="BookList" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" Width="630px" OnSelectedIndexChanged="BookList_SelectedIndexChanged" >
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="teal" Font-Bold="False" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
        </div>
    </div>
</div>
</asp:Content>
