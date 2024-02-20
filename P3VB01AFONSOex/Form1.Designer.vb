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
        cbxEscalao = New ComboBox()
        cbxLocal = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        dgvBD = New DataGridView()
        txtIdCandidato = New TextBox()
        txtNomeCandidato = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        CType(dgvBD, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cbxEscalao
        ' 
        cbxEscalao.FormattingEnabled = True
        cbxEscalao.Location = New Point(12, 100)
        cbxEscalao.Name = "cbxEscalao"
        cbxEscalao.Size = New Size(121, 23)
        cbxEscalao.TabIndex = 0
        ' 
        ' cbxLocal
        ' 
        cbxLocal.FormattingEnabled = True
        cbxLocal.Location = New Point(170, 100)
        cbxLocal.Name = "cbxLocal"
        cbxLocal.Size = New Size(121, 23)
        cbxLocal.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 15)
        Label1.TabIndex = 2
        Label1.Text = "Escalão"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(170, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 15)
        Label2.TabIndex = 3
        Label2.Text = "Local"
        ' 
        ' dgvBD
        ' 
        dgvBD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBD.Location = New Point(371, 100)
        dgvBD.Name = "dgvBD"
        dgvBD.Size = New Size(240, 150)
        dgvBD.TabIndex = 4
        ' 
        ' txtIdCandidato
        ' 
        txtIdCandidato.Location = New Point(12, 169)
        txtIdCandidato.Name = "txtIdCandidato"
        txtIdCandidato.Size = New Size(100, 23)
        txtIdCandidato.TabIndex = 5
        ' 
        ' txtNomeCandidato
        ' 
        txtNomeCandidato.Location = New Point(170, 169)
        txtNomeCandidato.Name = "txtNomeCandidato"
        txtNomeCandidato.Size = New Size(100, 23)
        txtNomeCandidato.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(170, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 15)
        Label3.TabIndex = 7
        Label3.Text = "Nome Candidato"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 151)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 15)
        Label4.TabIndex = 8
        Label4.Text = "Id Candidato"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(278, 246)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 9
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtNomeCandidato)
        Controls.Add(txtIdCandidato)
        Controls.Add(dgvBD)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cbxLocal)
        Controls.Add(cbxEscalao)
        Name = "Form1"
        Text = "Form1"
        CType(dgvBD, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbxEscalao As ComboBox
    Friend WithEvents cbxLocal As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvBD As DataGridView
    Friend WithEvents txtIdCandidato As TextBox
    Friend WithEvents txtNomeCandidato As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button

End Class
