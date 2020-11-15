Imports Torre.Test.BO
Imports Newtonsoft.Json
Imports RestSharp

Public Class WebFormJobInformation
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargar()
    End Sub
    Protected Sub cargar()

        Dim id As String = serpTagstitle.Text.Trim 'Yd62lOdp



        Dim client As New RestClient("https://torre.co/api/opportunities/" + id)
        client.Timeout = -1
        Dim request As New RestRequest(Method.GET)
        Dim Response As IRestResponse = client.Execute(request)
        Dim contenido = JsonConvert.DeserializeObject(Of Opportunities)(Response.Content)


        'Dim row As New TableRow()
        'Dim cell1 As New TableCell()

        'cell1.Text = "Location: " + contenido.person.location.name
        'row.Cells.Add(cell1)
        'MyTableLocation.Rows.Add(row)




    End Sub
End Class