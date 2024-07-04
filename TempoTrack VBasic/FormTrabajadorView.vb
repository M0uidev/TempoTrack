Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Net
Imports System.Text

Public Class FormTrabajadorView
    Private fechaInicioSeleccionada As String = DateTime.Today.ToString("yyyy-MM-dd")
    Private fechaFinSeleccionada As String = DateTime.Today.ToString("yyyy-MM-dd")
    Private fecha As String = DateTime.Today.ToString("yyyy-MM-dd")

    Public Sub FetchData(ByVal url As String, ByVal resultTextBox As TextBox)
        Try
            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Method = "GET"
            request.ContentType = "application/json"

            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            Console.WriteLine(response.StatusCode)

            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()

            Dim formattedJson As String = FormatJson(responseFromServer)
            resultTextBox.Text = formattedJson

            reader.Close()
            dataStream.Close()
            response.Close()
        Catch webEx As WebException
            If webEx.Response IsNot Nothing Then
                Using response As HttpWebResponse = CType(webEx.Response, HttpWebResponse)
                    Dim dataStream As Stream = response.GetResponseStream()
                    Using reader As New StreamReader(dataStream)
                        Dim errorText As String = reader.ReadToEnd()
                        resultTextBox.Text = errorText
                    End Using
                End Using
            Else
                resultTextBox.Text = "WebException: " & webEx.Message
            End If
        Catch ex As Exception
            resultTextBox.Text = "Exception: " & ex.ToString()
        End Try
    End Sub

    Private Function FormatJson(ByVal jsonString As String) As String
        Dim parsedJson = JsonConvert.DeserializeObject(Of JObject)(jsonString)
        Dim transformedJson = TransformJson(parsedJson)
        Return transformedJson
    End Function

    Private Function TransformJson(ByVal json As JObject, Optional ByVal indent As Integer = 0) As String
        Dim formattedJson As New StringBuilder()
        Dim indentation As String = New String(" "c, indent)

        For Each kvp In json
            Dim key As String = Char.ToUpper(kvp.Key(0)) & kvp.Key.Substring(1).Replace("""", "")

            ' Skip specific keys
            Select Case key
                Case "Id", "Fecha_inicio", "Fecha_final", "TrabajadorId", "FechaInicio", "FechaFin"
                    Continue For
            End Select

            If key = "Horas_extras" Then
                key = "Horas Extra"
            End If
            If key = "PromedioHorasPorDia" Then
                key = "Promedio Horas Por Día"
            End If
            If key = "Horas_no_trabajadas" Then
                key = "Horas No Trabajadas"
            End If
            If key = "Horas_trabajadas" Then
                key = "Horas Trabajadas"
            End If


            If key IsNot "" Then
                formattedJson.Append(indentation).Append(key).Append(": ")
            End If


            If TypeOf kvp.Value Is JObject Then
                formattedJson.AppendLine().Append(TransformJson(CType(kvp.Value, JObject), indent + 2))
            Else
                Dim value As String = kvp.Value.ToString().Replace("""", "")
                formattedJson.AppendLine(value)
            End If
        Next

        Return formattedJson.ToString().Trim()
    End Function

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
        FetchData("https://localhost:7167/api/simulador/horasExtra?trabajadorId=" + FormInicioSesion.Id + "&fechaInicio=" + fechaInicioSeleccionada + "&fechaFin=" + fechaFinSeleccionada, TextBox1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FetchData("https://localhost:7167/api/simulador/promedioHorasTrabajadas?trabajadorId=" + FormInicioSesion.Id + "&fechaInicio=" + fechaInicioSeleccionada + "&fechaFin=" + fechaFinSeleccionada, TextBox1)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FetchData("https://localhost:7167/api/simulador/calcularSueldo?trabajadorId=" + FormInicioSesion.Id + "&fecha=" + fecha, TextBox1)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FetchData("https://localhost:7167/api/simulador/diaMenosHorasTrabajadas?trabajadorId=" + FormInicioSesion.Id, TextBox1)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FetchData("https://localhost:7167/api/simulador/horasnoTrabajadas?trabajadorId=" + FormInicioSesion.Id + "&fecha=" + fecha, TextBox1)
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        FetchData("https://localhost:7167/api/simulador/horasTrabajadas?trabajadorId=" + FormInicioSesion.Id + "&fecha=" + fecha, TextBox1)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormContainer.MostrarNuevoForm(FormInicioSesion)
    End Sub
End Class
