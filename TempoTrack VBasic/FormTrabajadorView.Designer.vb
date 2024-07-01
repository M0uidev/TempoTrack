<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTrabajadorView
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
        Button1 = New Button()
        TextBox1 = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker3 = New DateTimePicker()
        Label4 = New Label()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(6, 65)
        Button1.Name = "Button1"
        Button1.Size = New Size(168, 23)
        Button1.TabIndex = 1
        Button1.Text = "Horas Extra"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 174)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ScrollBars = ScrollBars.Horizontal
        TextBox1.Size = New Size(498, 264)
        TextBox1.TabIndex = 2
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(692, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(96, 23)
        Button2.TabIndex = 4
        Button2.Text = "Cerrar Sesión"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(9, 15)
        Button3.Name = "Button3"
        Button3.Size = New Size(168, 23)
        Button3.TabIndex = 5
        Button3.Text = "Promedio Horas Trabajadas"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(4, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 15)
        Label1.TabIndex = 8
        Label1.Text = "Fecha Inicio:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(4, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 9
        Label2.Text = "Fecha Fin:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(4, 30)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(160, 23)
        DateTimePicker1.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(567, 177)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 11
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(4, 74)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(160, 23)
        DateTimePicker2.TabIndex = 13
        ' 
        ' DateTimePicker3
        ' 
        DateTimePicker3.Location = New Point(4, 118)
        DateTimePicker3.Name = "DateTimePicker3"
        DateTimePicker3.Size = New Size(160, 23)
        DateTimePicker3.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(4, 100)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 14
        Label4.Text = "Fecha:"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(6, 118)
        Button4.Name = "Button4"
        Button4.Size = New Size(168, 23)
        Button4.TabIndex = 16
        Button4.Text = "Calcular Sueldo"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(185, 15)
        Button5.Name = "Button5"
        Button5.Size = New Size(168, 23)
        Button5.TabIndex = 18
        Button5.Text = "Dia Menos Horas Trabajadas"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(182, 65)
        Button6.Name = "Button6"
        Button6.Size = New Size(168, 23)
        Button6.TabIndex = 19
        Button6.Text = "Horas No Trabajadas"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(182, 118)
        Button7.Name = "Button7"
        Button7.Size = New Size(168, 23)
        Button7.TabIndex = 20
        Button7.Text = "Horas Trabajadas"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ControlDark
        GroupBox1.Controls.Add(Button6)
        GroupBox1.Controls.Add(Button7)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Location = New Point(208, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(359, 147)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        GroupBox1.Text = "Servicios"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ControlDark
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(DateTimePicker3)
        GroupBox2.Controls.Add(DateTimePicker1)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(DateTimePicker2)
        GroupBox2.Location = New Point(12, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(173, 147)
        GroupBox2.TabIndex = 22
        GroupBox2.TabStop = False
        ' 
        ' FormTrabajadorView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Name = "FormTrabajadorView"
        Text = "FormTrabajadorView"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
