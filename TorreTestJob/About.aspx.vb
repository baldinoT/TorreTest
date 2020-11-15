Imports Torre.Test.BO
Imports Newtonsoft.Json
Imports RestSharp



Public Class About
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim client As New RestClient("https://bio.torre.co/api/bios/andressau8")
        client.Timeout = -1
        Dim request As New RestRequest(Method.GET)
        Dim Response As IRestResponse = client.Execute(request)
        Dim contenido = JsonConvert.DeserializeObject(Of User)(Response.Content)

        Dim b As New Organization
        Dim a As New Strength

        b.Name = "baldino"
        b.Id = 1234

        a.Id = "hola"
        a.Name = 6789
    End Sub
End Class