Public Class FormTrabajadorView
    Private fechaInicioSeleccionada As String = DateTime.Today.ToString("yyyy-MM-dd")
    Private fechaFinSeleccionada As String = DateTime.Today.ToString("yyyy-MM-dd")
    Private fecha As String = DateTime.Today.ToString("yyyy-MM-dd")

    Private Sub FormTrabajadorView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = DateTime.Today
        DateTimePicker2.Value = DateTime.Today
        DateTimePicker3.Value = DateTime.Today
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        fechaInicioSeleccionada = DateTimePicker1.Value.ToString("yyyy-MM-dd")
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        fechaFinSeleccionada = DateTimePicker2.Value.ToString("yyyy-MM-dd")
    End Sub
    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        fecha = DateTimePicker3.Value.ToString("yyyy-MM-dd")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormAdminView.FetchData("https://localhost:7167/api/simulador/horasExtra?trabajadorId=" + FormInicioSesion.Id + "&fechaInicio=" + fechaInicioSeleccionada + "&fechaFin=" + fechaFinSeleccionada, TextBox1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormAdminView.FetchData("https://localhost:7167/api/simulador/promedioHorasTrabajadas?trabajadorId=" + FormInicioSesion.Id + "&fechaInicio=" + fechaInicioSeleccionada + "&fechaFin=" + fechaFinSeleccionada, TextBox1)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormAdminView.FetchData("https://localhost:7167/api/simulador/calcularSueldo?trabajadorId=" + FormInicioSesion.Id + "&fecha=" + fecha, TextBox1)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FormAdminView.FetchData("https://localhost:7167/api/simulador/diaMenosHorasTrabajadas?trabajadorId=" + FormInicioSesion.Id, TextBox1)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FormAdminView.FetchData("https://localhost:7167/api/simulador/horasnoTrabajadas?trabajadorId=" + FormInicioSesion.Id + "&fecha=" + fecha, TextBox1)
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        FormAdminView.FetchData("https://localhost:7167/api/simulador/horasTrabajadas?trabajadorId=" + FormInicioSesion.Id + "&fecha=" + fecha, TextBox1)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormContainer.MostrarNuevoForm(FormInicioSesion)
    End Sub


End Class
