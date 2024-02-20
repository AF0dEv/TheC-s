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
        txtTotal = New TextBox()
        txtNome = New TextBox()
        txtIdade = New TextBox()
        txtValorBase = New TextBox()
        chkEscalao = New CheckBox()
        chkSocio = New CheckBox()
        chkAgravamento = New CheckBox()
        rbtSim = New RadioButton()
        rbtNao = New RadioButton()
        lblTitulo = New Label()
        lblNome = New Label()
        lblConcelho = New Label()
        lblAnoNascimento = New Label()
        lblValorBase = New Label()
        lblDistrito = New Label()
        cbxConcelho = New ComboBox()
        SuspendLayout()
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(566, 395)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(100, 23)
        txtTotal.TabIndex = 1
        ' 
        ' txtNome
        ' 
        txtNome.Location = New Point(122, 57)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(143, 23)
        txtNome.TabIndex = 2
        txtNome.Text = "Escreva aqui Seu Nome........."
        ' 
        ' txtIdade
        ' 
        txtIdade.Location = New Point(122, 99)
        txtIdade.Name = "txtIdade"
        txtIdade.Size = New Size(182, 23)
        txtIdade.TabIndex = 3
        txtIdade.Text = "0"
        ' 
        ' txtValorBase
        ' 
        txtValorBase.Location = New Point(122, 136)
        txtValorBase.Name = "txtValorBase"
        txtValorBase.Size = New Size(152, 23)
        txtValorBase.TabIndex = 4
        txtValorBase.Text = "0"
        ' 
        ' chkEscalao
        ' 
        chkEscalao.AutoSize = True
        chkEscalao.Location = New Point(122, 178)
        chkEscalao.Name = "chkEscalao"
        chkEscalao.Size = New Size(172, 19)
        chkEscalao.TabIndex = 5
        chkEscalao.Text = "Desconto de Escalão? (10%)"
        chkEscalao.UseVisualStyleBackColor = True
        ' 
        ' chkSocio
        ' 
        chkSocio.AutoSize = True
        chkSocio.Location = New Point(122, 203)
        chkSocio.Name = "chkSocio"
        chkSocio.Size = New Size(140, 19)
        chkSocio.TabIndex = 6
        chkSocio.Text = "Desconto Sócio? (5%)"
        chkSocio.UseVisualStyleBackColor = True
        ' 
        ' chkAgravamento
        ' 
        chkAgravamento.AutoSize = True
        chkAgravamento.Location = New Point(122, 228)
        chkAgravamento.Name = "chkAgravamento"
        chkAgravamento.Size = New Size(160, 19)
        chkAgravamento.TabIndex = 7
        chkAgravamento.Text = "Tem Agravamento ? (12€)"
        chkAgravamento.UseVisualStyleBackColor = True
        ' 
        ' rbtSim
        ' 
        rbtSim.AutoSize = True
        rbtSim.Location = New Point(159, 297)
        rbtSim.Name = "rbtSim"
        rbtSim.Size = New Size(45, 19)
        rbtSim.TabIndex = 8
        rbtSim.Text = "SIM"
        rbtSim.UseVisualStyleBackColor = True
        ' 
        ' rbtNao
        ' 
        rbtNao.AutoSize = True
        rbtNao.Checked = True
        rbtNao.Location = New Point(210, 297)
        rbtNao.Name = "rbtNao"
        rbtNao.Size = New Size(51, 19)
        rbtNao.TabIndex = 9
        rbtNao.TabStop = True
        rbtNao.Text = "NÃO"
        rbtNao.UseVisualStyleBackColor = True
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Location = New Point(333, 9)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(147, 15)
        lblTitulo.TabIndex = 10
        lblTitulo.Text = "CÁLCULO VALOR AVENÇA"
        ' 
        ' lblNome
        ' 
        lblNome.AutoSize = True
        lblNome.Location = New Point(74, 65)
        lblNome.Name = "lblNome"
        lblNome.Size = New Size(42, 15)
        lblNome.TabIndex = 11
        lblNome.Text = "NOME"
        ' 
        ' lblConcelho
        ' 
        lblConcelho.AutoSize = True
        lblConcelho.Location = New Point(390, 299)
        lblConcelho.Name = "lblConcelho"
        lblConcelho.Size = New Size(71, 15)
        lblConcelho.TabIndex = 12
        lblConcelho.Text = "CONCELHO"
        ' 
        ' lblAnoNascimento
        ' 
        lblAnoNascimento.AutoSize = True
        lblAnoNascimento.Location = New Point(12, 102)
        lblAnoNascimento.Name = "lblAnoNascimento"
        lblAnoNascimento.Size = New Size(110, 15)
        lblAnoNascimento.TabIndex = 13
        lblAnoNascimento.Text = "ANO NASCIMENTO"
        ' 
        ' lblValorBase
        ' 
        lblValorBase.AutoSize = True
        lblValorBase.Location = New Point(49, 139)
        lblValorBase.Name = "lblValorBase"
        lblValorBase.Size = New Size(73, 15)
        lblValorBase.TabIndex = 14
        lblValorBase.Text = "VALOR BASE"
        ' 
        ' lblDistrito
        ' 
        lblDistrito.AutoSize = True
        lblDistrito.Location = New Point(49, 297)
        lblDistrito.Name = "lblDistrito"
        lblDistrito.Size = New Size(104, 15)
        lblDistrito.TabIndex = 15
        lblDistrito.Text = "Reside no Distrito?"
        ' 
        ' cbxConcelho
        ' 
        cbxConcelho.FormattingEnabled = True
        cbxConcelho.Items.AddRange(New Object() {"Braga", "Amares", "Guimarães"})
        cbxConcelho.Location = New Point(467, 294)
        cbxConcelho.Name = "cbxConcelho"
        cbxConcelho.Size = New Size(191, 23)
        cbxConcelho.TabIndex = 16
        cbxConcelho.Text = "Escolha Aqui o seu Concelho......."
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cbxConcelho)
        Controls.Add(lblDistrito)
        Controls.Add(lblValorBase)
        Controls.Add(lblAnoNascimento)
        Controls.Add(lblConcelho)
        Controls.Add(lblNome)
        Controls.Add(lblTitulo)
        Controls.Add(rbtNao)
        Controls.Add(rbtSim)
        Controls.Add(chkAgravamento)
        Controls.Add(chkSocio)
        Controls.Add(chkEscalao)
        Controls.Add(txtValorBase)
        Controls.Add(txtIdade)
        Controls.Add(txtNome)
        Controls.Add(txtTotal)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtIdade As TextBox
    Friend WithEvents txtValorBase As TextBox
    Friend WithEvents chkEscalao As CheckBox
    Friend WithEvents chkSocio As CheckBox
    Friend WithEvents chkAgravamento As CheckBox
    Friend WithEvents rbtSim As RadioButton
    Friend WithEvents rbtNao As RadioButton
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lblConcelho As Label
    Friend WithEvents lblAnoNascimento As Label
    Friend WithEvents lblValorBase As Label
    Friend WithEvents lblDistrito As Label
    Friend WithEvents cbxConcelho As ComboBox
End Class
