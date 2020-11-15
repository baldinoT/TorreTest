<%@ Page Title="Genoma" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="UserNameWithMaster.aspx.vb" Inherits="TorreTestJob.UserNameWithMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
    <h2><%: Title %> </h2>

    
    <!--
    <h2><%: Title %>
        <asp:TextBox ID="linkId" runat="server" Width="209px"></asp:TextBox>
    </h2> -->

    <p>Introduce a Valid username and press Enter:   
        <asp:TextBox ID="txtUserName" runat="server" Height="16px" Width="229px">andressau8</asp:TextBox>
        <asp:Image ID="picture" runat="server" Height="96px" Width="133px" />
    </p>
    
<!--
    <p>
        <asp:Table ID="Table2" runat="server" Width="945px" Height="16px">
            <asp:TableRow>
                <asp:TableCell><asp:Label ID="Instagram" runat="server" Text="Instagram"></asp:Label></asp:TableCell>
                <asp:TableCell>celda2</asp:TableCell>
                <asp:TableCell>celda3</asp:TableCell>
                <asp:TableHeaderCell>celda4 </asp:TableHeaderCell>
            </asp:TableRow>
        </asp:Table>
    </p>
    -->

   

    <p>
        <asp:Label ID="fullname" runat="server" Text="FullName" style="font-family: Arial Black
          ; font-size:18px; color:blue;margin-left: 0px" Width="640px"></asp:Label>
    </p>
    <p>Professional Headline:
        <asp:Label ID="professionalHeadLine" runat="server" Height="18px" Text="Professional HeadLine" Width="506px"></asp:Label>
    </p>
   
    <!-- links: -->
    <p>
        FaceBook: 
        <asp:Label ID="Facebook" runat="server" Text="Facebook" Width="579px" Style="margin-left: 13px"></asp:Label> </p>
   
     <p>LinkedIn:<asp:Label ID="Linkedin" runat="server" Text="Linkedin" style="margin-left: 30px" Width="579px"></asp:Label></p>
        
    <p>Instagram: <asp:Label ID="Instagram1" runat="server" Text="Instagram" style="margin-left: 19px" Width="577px"></asp:Label> </p>

    
       <asp:Table ID="MyTableLocation" runat="server" Width="697px" Height="20px">
       <asp:TableRow>
           <asp:TableCell></asp:TableCell>
           
           
       </asp:TableRow>

    </asp:Table>

    <asp:Table ID="MyTableExperiences" runat="server" Width="697px" Height="20px">
       <asp:TableRow>
           <asp:TableCell></asp:TableCell>
           
           
       </asp:TableRow>

    </asp:Table>

    <asp:Table ID="MyTableJobs" runat="server" Width="697px" Height="20px">
       <asp:TableRow>
           <asp:TableCell></asp:TableCell>
           
           
       </asp:TableRow>

    </asp:Table>

    <asp:Table ID="MyTableEducation" runat="server" Width="697px" Height="20px">
       <asp:TableRow>
           <asp:TableCell></asp:TableCell>
           
           
           
       </asp:TableRow>

        
    </asp:Table>

       <asp:Table ID="MyTableProjects" runat="server" Width="697px" Height="20px">
       <asp:TableRow>
           <asp:TableCell></asp:TableCell>
           
       </asp:TableRow>

    </asp:Table>

  
   <asp:Table ID="MyTableLanguages" runat="server" Width="697px" Height="20px">
       <asp:TableRow>
           <asp:TableCell></asp:TableCell>
           
       </asp:TableRow>

    </asp:Table>


</asp:Content>
