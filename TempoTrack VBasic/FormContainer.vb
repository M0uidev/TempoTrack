Public Class FormContainer
    Public Sub MostrarNuevoForm(ByVal formToShow As Form)
        formToShow.TopLevel = False
        formToShow.FormBorderStyle = FormBorderStyle.None
        formToShow.Dock = DockStyle.Fill
        Panel1.Controls.Clear()
        Panel1.Controls.Add(formToShow)
        formToShow.Show()
    End Sub
    Private Sub FormContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarNuevoForm(FormInicioSesion)
    End Sub
End Class
