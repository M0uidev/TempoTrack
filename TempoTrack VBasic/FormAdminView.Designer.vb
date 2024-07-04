<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdminView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        GroupBox1 = New GroupBox()
        Button8 = New Button()
        Button9 = New Button()
        Button10 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button4 = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 174)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(776, 264)
        TextBox1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(6, 22)
        Button1.Name = "Button1"
        Button1.Size = New Size(171, 23)
        Button1.TabIndex = 1
        Button1.Text = "Trabajadores Con Horas Cero"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(6, 127)
        Button2.Name = "Button2"
        Button2.Size = New Size(171, 23)
        Button2.TabIndex = 2
        Button2.Text = "Horas De Almuerzo"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(692, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(96, 23)
        Button3.TabIndex = 3
        Button3.Text = "Cerrar Sesión"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ControlDark
        GroupBox1.Controls.Add(Button8)
        GroupBox1.Controls.Add(Button9)
        GroupBox1.Controls.Add(Button10)
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(Button6)
        GroupBox1.Controls.Add(Button7)
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(674, 156)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(253, 75)
        Button8.Name = "Button8"
        Button8.Size = New Size(171, 23)
        Button8.TabIndex = 9
        Button8.Text = "Dias Trabajados"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(253, 22)
        Button9.Name = "Button9"
        Button9.Size = New Size(171, 23)
        Button9.TabIndex = 7
        Button9.Text = "Puntualidad"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(245, 128)
        Button10.Name = "Button10"
        Button10.Size = New Size(189, 23)
        Button10.TabIndex = 8
        Button10.Text = "Dias No Trabajados Consecutivos"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(497, 75)
        Button5.Name = "Button5"
        Button5.Size = New Size(171, 23)
        Button5.TabIndex = 6
        Button5.Text = "Ausencias Justificadas"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(497, 22)
        Button6.Name = "Button6"
        Button6.Size = New Size(171, 23)
        Button6.TabIndex = 4
        Button6.Text = "Día Con Mas Horas"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(497, 127)
        Button7.Name = "Button7"
        Button7.Size = New Size(171, 23)
        Button7.TabIndex = 5
        Button7.Text = "Turnos Fin De Semana"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(6, 75)
        Button4.Name = "Button4"
        Button4.Size = New Size(171, 23)
        Button4.TabIndex = 3
        Button4.Text = "Registros Tiempo"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' FormAdminView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Controls.Add(Button3)
        Controls.Add(TextBox1)
        Name = "FormAdminView"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button

End Class
