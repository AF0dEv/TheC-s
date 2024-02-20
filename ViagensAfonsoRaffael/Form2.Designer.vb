<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        txtMarcaAdicionar = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnCriaViatura = New Button()
        SuspendLayout()
        ' 
        ' txtMarcaAdicionar
        ' 
        txtMarcaAdicionar.Location = New Point(138, 60)
        txtMarcaAdicionar.Name = "txtMarcaAdicionar"
        txtMarcaAdicionar.Size = New Size(100, 23)
        txtMarcaAdicionar.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(161, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 15)
        Label1.TabIndex = 1
        Label1.Text = "MARCA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(125, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 15)
        Label2.TabIndex = 2
        Label2.Text = "CRIAÇÃO AUTOMÓVEL"
        ' 
        ' btnCriaViatura
        ' 
        btnCriaViatura.Location = New Point(292, 83)
        btnCriaViatura.Name = "btnCriaViatura"
        btnCriaViatura.Size = New Size(75, 23)
        btnCriaViatura.TabIndex = 3
        btnCriaViatura.Text = "CRIAR"
        btnCriaViatura.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(379, 118)
        Controls.Add(btnCriaViatura)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtMarcaAdicionar)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtMarcaAdicionar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCriaViatura As Button
End Class
