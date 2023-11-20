<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Seller/SellerMaster.Master" AutoEventWireup="true" CodeBehind="Selling.aspx.cs" Inherits="OnlineBookShop.Views.Seller.Selling" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="container-fluid">
        <div class="row"></div>
        <div class="row">
            <div class="col-md-5">
                <h3 class="text-center" style="color:teal;">Book Details</h3>
                <div class="row">
                    <div class="col">
                        <div class="mt-3">
                            <label for="" class="form-label text-success">Book Name</label>
                            <input type="text" placeholder="Name"  runat="server" autocomplete="off" class="form-control" id="BookName1"/>
                        </div>
                    </div>
                    <div class="col">
                        <div class="mt-3">
                            <label for="" class="form-label text-success">Book Price</label>
                            <input type="text" placeholder="Price"  runat="server" autocomplete="off" class="form-control" id="Price1"/>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col">
                        <div class="mt-3">
                            <label for="" class="form-label text-success">Book Name</label>
                            <input type="text" placeholder="Name"  runat="server" autocomplete="off" class="form-control" id="BookName2"/>
                        </div>
                    </div>
                    <div class="col">
                        <div class="mt-3">
                            <label for="" class="form-label text-success">Book Price</label>
                            <input type="text" placeholder="Price"  runat="server" autocomplete="off" class="form-control" id="Price2"/>
                        </div>
                    </div>
                </div>

                <div class="row mt-5">
                    <h4 class="text-center" style="color:teal;">Books List</h4>
                    <div class="col">
                        <asp:GridView ID="SellingList" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" Width="630px" OnSelectedIndexChanged="SellingList_SelectedIndexChanged" >
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
            <div class="col-md-7">
                <h4 class="text-center" style="color:crimson;">Client's Bill</h4>
                <div class="col">
                    <asp:GridView ID="BillList" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" Width="630px" OnSelectedIndexChanged="BillList_SelectedIndexChanged" >
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
                    <div class="col d-grid">
                        <asp:Button Text="Print" runat="server" ID="PrintBtn" class="btn btn-info btn-block" OnClick="PrintBtn_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
