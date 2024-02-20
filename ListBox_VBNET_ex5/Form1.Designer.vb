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
        lstNomes = New ListBox()
        txtNome = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' lstNomes
        ' 
        lstNomes.FormattingEnabled = True
        lstNomes.ItemHeight = 15
        lstNomes.Items.AddRange(New Object() {"Ana", "Rui"})
        lstNomes.Location = New Point(12, 12)
        lstNomes.Name = "lstNomes"
        lstNomes.Size = New Size(120, 94)
        lstNomes.TabIndex = 0
        ' 
        ' txtNome
        ' 
        txtNome.Location = New Point(12, 112)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(100, 23)
        txtNome.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(138, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 15)
        Label1.TabIndex = 2
        Label1.Text = "<-- Lista Nomes"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(118, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 15)
        Label2.TabIndex = 3
        Label2.Text = "<-- Nome Selecionado"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNome)
        Controls.Add(lstNomes)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstNomes As ListBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
