Imports System.Net
Imports System.IO
Public Class FormAdminView
    Public Sub FetchData(ByVal url As String, ByVal resultTextBox As TextBox)
        Try
            ' Crear una solicitud utilizando una URL que puede recibir un GET
            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            ' Establecer el método de la solicitud como GET
            request.Method = "GET"
            ' Establecer el tipo de contenido de la solicitud
            request.ContentType = "application/json"

            ' Obtener la respuesta
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            ' Mostrar el estado
            Console.WriteLine(response.StatusCode)

            ' Obtener el flujo que contiene el contenido devuelto por el servidor
            Dim dataStream As Stream = response.GetResponseStream()
            ' Abrir el flujo usando un StreamReader para facilitar el acceso
            Dim reader As New StreamReader(dataStream)
            ' Leer el contenido
            Dim responseFromServer As String = reader.ReadToEnd()

            ' Mostrar el contenido en el TextBox seleccionado
            resultTextBox.Text = responseFromServer

            ' Limpiar los flujos y la respuesta
            reader.Close()
            dataStream.Close()
            response.Close()
        Catch webEx As WebException
            ' Manejar excepciones web, que pueden proporcionar información de error más específica
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
            resultTextBox.Text = "WebException: " & ex.ToString
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FetchData("https://localhost:7167/api/simulador/TrabajadoresConHorasCero", TextBox1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FetchData("https://localhost:7167/api/simulador/horasDeAlmuerzo", TextBox1)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormContainer.MostrarNuevoForm(FormInicioSesion)
    End Sub
End Class