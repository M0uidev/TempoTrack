Imports System.IO
Imports System.Net

Public Class FormInicioSesion
    Private trabajadoresList As New List(Of String)
    Public Id
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Await FetchData("https://localhost:7167/api/simulador/trabajadores", Label3)
        If Usuario.Text = "admin" AndAlso Contraseña.Text = "admin" Then
            FormContainer.MostrarNuevoForm(FormAdminView)
        ElseIf trabajadoresList.Contains(Usuario.Text) Then
            Id = Usuario.Text
            FormContainer.MostrarNuevoForm(FormTrabajadorView)
        ElseIf trabajadoresList.Contains("[" + Usuario.Text) Then ' Se agrega el corchete pq el primer y ultimo item tienen agregado un corchete (no se como arreglarlo)
            Id = Usuario.Text
            FormContainer.MostrarNuevoForm(FormTrabajadorView)
        ElseIf trabajadoresList.Contains(Usuario.Text + "]") Then
            Id = Usuario.Text
            FormContainer.MostrarNuevoForm(FormTrabajadorView)
        Else
            Label3.Text = "Error, intente nuevamente."
        End If
    End Sub
    Private Async Function FetchData(ByVal url As String, ByVal resultLabel As Label) As Task(Of List(Of String))
        Dim trabajadores As New List(Of String)

        Try
            ' Crear una solicitud utilizando una URL que puede recibir un GET
            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            ' Establecer el método de la solicitud como GET
            request.Method = "GET"

            ' Obtener la respuesta
            Dim response As HttpWebResponse = CType(Await request.GetResponseAsync(), HttpWebResponse)
            ' Mostrar el estado
            Console.WriteLine(response.StatusCode)

            ' Obtener el flujo que contiene el contenido devuelto por el servidor
            Dim dataStream As Stream = response.GetResponseStream()
            ' Abrir el flujo usando un StreamReader para facilitar el acceso
            Using reader As New StreamReader(dataStream)
                ' Leer el contenido
                Dim responseFromServer As String = Await reader.ReadToEndAsync()

                ' Suponiendo que la respuesta es una lista separada por comas
                Dim ids As String() = responseFromServer.Split(","c)

                ' Agregar los IDs a la lista trabajadoresList
                trabajadoresList.AddRange(ids)
            End Using
            ' Limpiar los flujos y la respuesta
            response.Close()
        Catch webEx As WebException
            ' Manejar excepciones web, que pueden proporcionar información de error más específica
            If webEx.Response IsNot Nothing Then
                Using response As HttpWebResponse = CType(webEx.Response, HttpWebResponse)
                    Dim dataStream As Stream = response.GetResponseStream()
                    Using reader As New StreamReader(dataStream)
                        Dim errorText As String = reader.ReadToEnd()
                        resultLabel.Text = "WebException: " & response.StatusCode & " - " & errorText
                    End Using
                End Using
            Else
                resultLabel.Text = "WebException: " & webEx.Message
            End If
        Catch ex As Exception
            ' Manejar cualquier otra excepción que pueda ocurrir
            resultLabel.Text = "Se produjo un error: " & ex.Message
        End Try

        Return trabajadores
    End Function

End Class
