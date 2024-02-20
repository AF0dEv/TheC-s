<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViagemForm
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
        gboxViagem = New GroupBox()
        btnSairViagem = New Button()
        btnCriarViagem = New Button()
        cbxViagem = New ComboBox()
        lblViaturaViagem = New Label()
        txtKm = New TextBox()
        lblKm = New Label()
        txtDuracaoViagem = New TextBox()
        lblDuracao = New Label()
        gboxViagem.SuspendLayout()
        SuspendLayout()
        ' 
        ' gboxViagem
        ' 
        gboxViagem.Controls.Add(btnSairViagem)
        gboxViagem.Controls.Add(btnCriarViagem)
        gboxViagem.Controls.Add(cbxViagem)
        gboxViagem.Controls.Add(lblViaturaViagem)
        gboxViagem.Controls.Add(txtKm)
        gboxViagem.Controls.Add(lblKm)
        gboxViagem.Controls.Add(txtDuracaoViagem)
        gboxViagem.Controls.Add(lblDuracao)
        gboxViagem.Location = New Point(11, 8)
        gboxViagem.Name = "gboxViagem"
        gboxViagem.Size = New Size(362, 310)
        gboxViagem.TabIndex = 0
        gboxViagem.TabStop = False
        gboxViagem.Text = "Viagens"
        ' 
        ' btnSairViagem
        ' 
        btnSairViagem.BackColor = Color.Red
        btnSairViagem.Location = New Point(282, 261)
        btnSairViagem.Name = "btnSairViagem"
        btnSairViagem.Size = New Size(68, 43)
        btnSairViagem.TabIndex = 7
        btnSairViagem.Text = "SAIR"
        btnSairViagem.UseVisualStyleBackColor = False
        ' 
        ' btnCriarViagem
        ' 
        btnCriarViagem.BackColor = SystemColors.ButtonShadow
        btnCriarViagem.Location = New Point(220, 57)
        btnCriarViagem.Name = "btnCriarViagem"
        btnCriarViagem.Size = New Size(130, 87)
        btnCriarViagem.TabIndex = 6
        btnCriarViagem.Text = "CRIAR"
        btnCriarViagem.UseVisualStyleBackColor = False
        ' 
        ' cbxViagem
        ' 
        cbxViagem.FormattingEnabled = True
        cbxViagem.Location = New Point(33, 227)
        cbxViagem.Name = "cbxViagem"
        cbxViagem.Size = New Size(146, 23)
        cbxViagem.TabIndex = 5
        ' 
        ' lblViaturaViagem
        ' 
        lblViaturaViagem.AutoSize = True
        lblViaturaViagem.Location = New Point(33, 197)
        lblViaturaViagem.Name = "lblViaturaViagem"
        lblViaturaViagem.Size = New Size(126, 15)
        lblViaturaViagem.TabIndex = 4
        lblViaturaViagem.Text = "Selecione uma viatura:"
        ' 
        ' txtKm
        ' 
        txtKm.Location = New Point(31, 146)
        txtKm.Name = "txtKm"
        txtKm.Size = New Size(148, 23)
        txtKm.TabIndex = 3
        ' 
        ' lblKm
        ' 
        lblKm.AutoSize = True
        lblKm.Location = New Point(28, 116)
        lblKm.Name = "lblKm"
        lblKm.Size = New Size(140, 15)
        lblKm.TabIndex = 2
        lblKm.Text = "Insira os Km percorridos: "
        ' 
        ' txtDuracaoViagem
        ' 
        txtDuracaoViagem.Location = New Point(28, 73)
        txtDuracaoViagem.Name = "txtDuracaoViagem"
        txtDuracaoViagem.Size = New Size(151, 23)
        txtDuracaoViagem.TabIndex = 1
        ' 
        ' lblDuracao
        ' 
        lblDuracao.AutoSize = True
        lblDuracao.Location = New Point(28, 47)
        lblDuracao.Name = "lblDuracao"
        lblDuracao.Size = New Size(151, 15)
        lblDuracao.TabIndex = 0
        lblDuracao.Text = "Insira a duração da viagem:"
        ' 
        ' ViagemForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(402, 339)
        Controls.Add(gboxViagem)
        Name = "ViagemForm"
        Text = "ViagemForm"
        gboxViagem.ResumeLayout(False)
        gboxViagem.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents gboxViagem As GroupBox
    Friend WithEvents lblKm As Label
    Friend WithEvents txtDuracaoViagem As TextBox
    Friend WithEvents lblDuracao As Label
    Friend WithEvents lblViaturaViagem As Label
    Friend WithEvents txtKm As TextBox
    Friend WithEvents btnSairViagem As Button
    Friend WithEvents btnCriarViagem As Button
    Friend WithEvents cbxViagem As ComboBox
End Class
