<%@ Page Title="Job Information" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="WebFormJobInformation.aspx.vb" Inherits="TorreTestJob.WebFormJobInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    

  
    <p><asp:Image ID="picture" runat="server" Height="96px" Width="677px" ImageUrl="https://res.cloudinary.com/torre-technologies-co/image/upload/v1603820162/origin/opportunities/69489970_1079555802249314_6382519202279849984_n_u8s4ao.jpg" /></p>
    <p>Introduce a Valid Id press Enter:   
        <asp:TextBox ID="txtobjective" runat="server" Height="16px" Width="229px">Yd62lOdp</asp:TextBox>
        
    </p>

   <p>remote: 
        <asp:Label ID="remote" runat="server" Text="Yes" Width="579px" Style="margin-left: 13px"></asp:Label> </p>
   
     <p>anywhere:<asp:Label ID="anywhere" runat="server" Text="Anywhere" style="margin-left: 30px" Width="579px"></asp:Label></p>

  
   <p>
        <asp:Label ID="serpTagstitle" runat="server" Text="serpTags.title" style="font-family: Arial Black
          ; font-size:18px; color:blue;margin-left: 0px" Width="640px"></asp:Label>
    </p>
    <p>
        <asp:Label ID="description" runat="server" Text="Description" style="margin-left: 13px" Width="640px"></asp:Label>
     </p>
     
    <p><asp:Label ID="identifiername" runat="server" Text="IdentifierName" style="margin-left: 13px" Width="535px"></asp:Label>
        <asp:Image ID="logo" runat="server" Height="96px" Width="133px" />
    </p>

    <p><asp:Label ID="validthrough" runat="server" Text="validthrough" style="margin-left: 13px" Width="535px"></asp:Label></p>

    <p><asp:Label ID="basesalary" runat="server" Text="base salary:min, max, usd, month" style="margin-left: 13px" Width="535px"></asp:Label></p>
     
   <p><asp:Label ID="ownername" runat="server" Text="Owner.name" style="margin-left: 13px" Width="535px"></asp:Label>
       <asp:Image ID="ownerpicture" runat="server" Height="96px" Width="133px" />

   </p>

   <p><asp:Label ID="agreementype" runat="server" Text="agreement.type" style="margin-left: 13px" Width="535px"></asp:Label>
   </p>


     <asp:Table ID="MyTableDetails" runat="server" Width="697px" Height="20px">
       <asp:TableRow>
           <asp:TableCell></asp:TableCell>
           
           
       </asp:TableRow>

    </asp:Table>

   <asp:Table ID="MytableApplicantLocationRequirements" runat="server" Width="697px" Height="20px">
       <asp:TableRow>
           <asp:TableCell></asp:TableCell>
       </asp:TableRow>
    </asp:Table>




</asp:Content>
