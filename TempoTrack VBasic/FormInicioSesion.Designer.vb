<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInicioSesion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Usuario = New TextBox()
        Contraseña = New TextBox()
        Button1 = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Location = New Point(12, 344)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 17)
        Label1.TabIndex = 0
        Label1.Text = "Nombre de usuario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Location = New Point(12, 393)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 17)
        Label2.TabIndex = 1
        Label2.Text = "Contraseña"
        ' 
        ' Usuario
        ' 
        Usuario.Location = New Point(12, 362)
        Usuario.Name = "Usuario"
        Usuario.Size = New Size(154, 23)
        Usuario.TabIndex = 2
        ' 
        ' Contraseña
        ' 
        Contraseña.Location = New Point(12, 411)
        Contraseña.Name = "Contraseña"
        Contraseña.Size = New Size(154, 23)
        Contraseña.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(695, 415)
        Button1.Name = "Button1"
        Button1.Size = New Size(93, 23)
        Button1.TabIndex = 4
        Button1.Text = "Iniciar Sesión"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.ForeColor = Color.IndianRed
        Label3.Location = New Point(641, 393)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 5
        ' 
        ' FormInicioSesion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(Contraseña)
        Controls.Add(Usuario)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormInicioSesion"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Usuario As TextBox
    Friend WithEvents Contraseña As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
End Class
