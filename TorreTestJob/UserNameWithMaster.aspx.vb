Imports Torre.Test.BO
Imports Newtonsoft.Json
Imports RestSharp

Public Class UserNameWithMaster
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        cargar()



    End Sub

    Protected Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged


    End Sub

    Protected Sub cargar()

        Dim username As String = txtUserName.Text.Trim '"andressau8"



        Dim client As New RestClient("https://bio.torre.co/api/bios/" + username)
        client.Timeout = -1
        Dim request As New RestRequest(Method.GET)
        Dim Response As IRestResponse = client.Execute(request)
        Dim contenido = JsonConvert.DeserializeObject(Of User)(Response.Content)

        fullname.Text = contenido.person.name
        professionalHeadLine.Text = contenido.person.professionalHeadline
        picture.ImageUrl = contenido.person.picture ' https://starrgate.s3.amazonaws.com:443/users/5e2e67374cfcf52d742d6428948e50454aea6ceb/profile_mVxqJ4l.jpg
        Facebook.Text = contenido.person.links(0).address
        Instagram1.Text = contenido.person.links(1).address
        Linkedin.Text = contenido.person.links(2).address

        Dim row As New TableRow()
        Dim cell1 As New TableCell()

        cell1.Text = "Location: " + contenido.person.location.name
        row.Cells.Add(cell1)
        MyTableLocation.Rows.Add(row)

        Dim row2 As New TableRow()
        Dim cell2 As New TableCell()
        cell2.Text = "Experiences: "
        For i = 0 To contenido.experiences.Count - 1
            cell2.Text += contenido.experiences(i).name + "; "
        Next
        row2.Cells.Add(cell2)
        MyTableExperiences.Rows.Add(row2)


        Dim row3 As New TableRow()
        Dim cell3 As New TableCell()
        cell3.Text = "Jobs: "
        For i = 0 To contenido.jobs.Count - 1
            cell3.Text += contenido.jobs(i).name + "; "
        Next
        row3.Cells.Add(cell3)
        MyTableJobs.Rows.Add(row3)

        Dim row5 As New TableRow()
        Dim cell5 As New TableCell()
        cell5.Text = "Projects: "
        For i = 0 To contenido.projects.Count - 1
            cell5.Text += contenido.projects(i).name + "; "
        Next
        row5.Cells.Add(cell5)
        MyTableProjects.Rows.Add(row5)



        Dim row4 As New TableRow()
        Dim cell4 As New TableCell()
        cell3.Text = "Education: "
        For i = 0 To contenido.education.Count - 1
            cell3.Text += contenido.education(i).name + "; "
        Next
        row4.Cells.Add(cell4)
        MyTableEducation.Rows.Add(row4)


        Dim row6 As New TableRow()
        Dim cell6 As New TableCell()
        cell6.Text = "Languages: "
        For i = 0 To contenido.languages.Count - 1
            cell6.Text += contenido.languages(i).language + "|Fluency: " + contenido.languages(i).fluency + "; "
        Next
        row6.Cells.Add(cell6)
        MyTableLanguages.Rows.Add(row6)

        contenido = Nothing


    End Sub
End Class