<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        cbxLocalidades = New ComboBox()
        txtLocalidade = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' cbxLocalidades
        ' 
        cbxLocalidades.FormattingEnabled = True
        cbxLocalidades.Items.AddRange(New Object() {"Vila Real", "Setubal", "Guimaraes"})
        cbxLocalidades.Location = New Point(62, 12)
        cbxLocalidades.Name = "cbxLocalidades"
        cbxLocalidades.Size = New Size(121, 23)
        cbxLocalidades.TabIndex = 0
        ' 
        ' txtLocalidade
        ' 
        txtLocalidade.Location = New Point(83, 175)
        txtLocalidade.Name = "txtLocalidade"
        txtLocalidade.Size = New Size(100, 23)
        txtLocalidade.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(67, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 15)
        Label1.TabIndex = 2
        Label1.Text = "Escolha 1 Localidade"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(256, 230)
        Controls.Add(Label1)
        Controls.Add(txtLocalidade)
        Controls.Add(cbxLocalidades)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbxLocalidades As ComboBox
    Friend WithEvents txtLocalidade As TextBox
    Friend WithEvents Label1 As Label
End Class
