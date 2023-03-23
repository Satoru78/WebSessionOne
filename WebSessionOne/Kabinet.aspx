<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kabinet.aspx.cs" Inherits="WebSessionOne.Kabinet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Добавление данных</title>
    <style type="text/css">
        .center {      
            justify-content: center;
            align-items: center;
            height: 100vh;
        }
        .auto-style1 {
            margin-top: 0px;
        }
    </style>
</head>
<body>

<form id="form1" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Личный кабинет" BackColor="#FF9900" Width="400px"></asp:Label>
        <br />
        Общая информация:<br /> Фамилия :
        <br />
        <br />
        Имя:<br />
        <br />
        Отчество:<br />
        <br />
        <asp:Label ID="Label2" runat="server" BackColor="#FF9900" BorderColor="#FF9900" Text="Список ранее поданных заявок" Width="400px"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
            <Columns >
              
                <asp:TemplateField HeaderText="Тип заявки">
                    <ItemTemplate><%#Eval("IDTypeRequest") %></ItemTemplate>
                </asp:TemplateField>
              
                <asp:TemplateField   HeaderText="Подразделение" >
                    <ItemTemplate><%#Eval("Subdivision") %></ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Дата" >
                    <ItemTemplate><%#Eval("Date") %></ItemTemplate>
                </asp:TemplateField>

                 <asp:TemplateField HeaderText="Время">
                    <ItemTemplate><%#Eval("Time") %></ItemTemplate>
                </asp:TemplateField>
           
                 <asp:TemplateField  HeaderText="Статус заявки">
                    <ItemTemplate><%#Eval("IDStatusRequest") %></ItemTemplate>
                </asp:TemplateField>

                
                 <asp:TemplateField  HeaderText="Причина">
                    <ItemTemplate><%#Eval("Reason") %></ItemTemplate>
                </asp:TemplateField>

          
                 <asp:TemplateField HeaderText="Заявитель">
                    <ItemTemplate><%#Eval("IDVisitor") %></ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="Button1" runat="server" BackColor="Transparent" BorderColor="#FF9900" OnClick="Button1_Click" Text="Назад" Width="150px" />
        <br />
        <br />
        </asp:Panel>
</form>
    </body>
</html>


