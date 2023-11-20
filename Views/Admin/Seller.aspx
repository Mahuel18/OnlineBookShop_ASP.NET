<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Seller.aspx.cs" Inherits="OnlineBookShop.Views.Admin.Seller" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col">
                <h3 class="text-center">Manage Sellers</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <div class="mb-3">
                    <label for="" class="form-label text-success">Seller Name</label>
                    <input type="text" placeholder="Name" autocomplete="off" runat="server" id="SNameTb" class="form-control"/>
                </div>
                <div class="mb-3">
                    <label for="" class="form-label text-success">Seller Email</label>
                    <input type="email" placeholder="Email" autocomplete="off" runat="server" id="EmailTb" class="form-control"/>
                </div>
                <div class="mb-3">
                    <label for="" class="form-label text-success">Seller Phone</label>
                    <input type="text" placeholder="Phone" autocomplete="off" runat="server" id="PhoneTb" class="form-control"/>
                </div>
                <div class="mb-3">
                    <label for="" class="form-label text-success">Seller Address</label>
                    <input type="text" placeholder="Address" autocomplete="off" runat="server" id="AddressTb" class="form-control"/>
                </div>
                <div class="row">
                    <asp:Label runat="server" ID="ErrMsg" CssClass="text-danger text-center"></asp:Label>
                    <div class="col d-grid">
                        <asp:Button Text="Update" ID="UpdateBtn" runat="server" class="btn btn-warning btn-block" OnClick="UpdateBtn_Click" />
                    </div>
                    <div class="col d-grid">
                        <asp:Button Text="Save" ID="SaveBtn" runat="server" class="btn btn-success btn-block" OnClick="SaveBtn_Click" />
                    </div>
                    <div class="col d-grid">
                        <asp:Button Text="Delete" ID="DeleteBtn" runat="server" class="btn btn-danger btn-block" OnClick="DeleteBtn_Click" />
                    </div>
                </div>
            </div>
            <div class="col-md-8">
                <asp:GridView ID="SellerList" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" Width="630px" OnSelectedIndexChanged="SellerList_SelectedIndexChanged" >
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
