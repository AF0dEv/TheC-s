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
        btnCalcular = New Button()
        cbxPizzas = New ComboBox()
        cbxBebidas = New ComboBox()
        txtPrecoBebida = New TextBox()
        txtPrecoPizza = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        chkQueijo = New CheckBox()
        chkAzeitona = New CheckBox()
        chkPepino = New CheckBox()
        Label3 = New Label()
        txtQtdExtra = New TextBox()
        txtTotal = New TextBox()
        txtQtdPizza = New TextBox()
        txtQtdBebida = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txtPrecoExtra = New TextBox()
        Label9 = New Label()
        rbtSim = New RadioButton()
        rbtNao = New RadioButton()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label21 = New Label()
        Label22 = New Label()
        dgvBD = New DataGridView()
        CType(dgvBD, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Location = New Point(315, 723)
        btnCalcular.Margin = New Padding(3, 4, 3, 4)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(86, 31)
        btnCalcular.TabIndex = 0
        btnCalcular.Text = "Calcular"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' cbxPizzas
        ' 
        cbxPizzas.FormattingEnabled = True
        cbxPizzas.Items.AddRange(New Object() {"4 Estações", "Margarida", "Ananas"})
        cbxPizzas.Location = New Point(38, 186)
        cbxPizzas.Margin = New Padding(3, 4, 3, 4)
        cbxPizzas.Name = "cbxPizzas"
        cbxPizzas.Size = New Size(205, 28)
        cbxPizzas.TabIndex = 1
        cbxPizzas.Text = "Selecione uma Pizza.............."
        ' 
        ' cbxBebidas
        ' 
        cbxBebidas.FormattingEnabled = True
        cbxBebidas.Items.AddRange(New Object() {"Coca-Cola", "Água"})
        cbxBebidas.Location = New Point(514, 186)
        cbxBebidas.Margin = New Padding(3, 4, 3, 4)
        cbxBebidas.Name = "cbxBebidas"
        cbxBebidas.Size = New Size(206, 28)
        cbxBebidas.TabIndex = 2
        cbxBebidas.Text = "Selecione uma Bebida................."
        ' 
        ' txtPrecoBebida
        ' 
        txtPrecoBebida.Location = New Point(514, 242)
        txtPrecoBebida.Margin = New Padding(3, 4, 3, 4)
        txtPrecoBebida.Name = "txtPrecoBebida"
        txtPrecoBebida.Size = New Size(114, 27)
        txtPrecoBebida.TabIndex = 3
        txtPrecoBebida.Text = "0"
        ' 
        ' txtPrecoPizza
        ' 
        txtPrecoPizza.Location = New Point(38, 242)
        txtPrecoPizza.Margin = New Padding(3, 4, 3, 4)
        txtPrecoPizza.Name = "txtPrecoPizza"
        txtPrecoPizza.Size = New Size(114, 27)
        txtPrecoPizza.TabIndex = 4
        txtPrecoPizza.Text = "0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 162)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 5
        Label1.Text = "Pizzas"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(514, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 20)
        Label2.TabIndex = 6
        Label2.Text = "Bebidas"
        ' 
        ' chkQueijo
        ' 
        chkQueijo.AutoSize = True
        chkQueijo.Location = New Point(214, 457)
        chkQueijo.Margin = New Padding(3, 4, 3, 4)
        chkQueijo.Name = "chkQueijo"
        chkQueijo.Size = New Size(80, 24)
        chkQueijo.TabIndex = 7
        chkQueijo.Text = "QUEIJO"
        chkQueijo.UseVisualStyleBackColor = True
        ' 
        ' chkAzeitona
        ' 
        chkAzeitona.AutoSize = True
        chkAzeitona.Location = New Point(300, 457)
        chkAzeitona.Margin = New Padding(3, 4, 3, 4)
        chkAzeitona.Name = "chkAzeitona"
        chkAzeitona.Size = New Size(101, 24)
        chkAzeitona.TabIndex = 8
        chkAzeitona.Text = "AZEITONA"
        chkAzeitona.UseVisualStyleBackColor = True
        ' 
        ' chkPepino
        ' 
        chkPepino.AutoSize = True
        chkPepino.Location = New Point(404, 457)
        chkPepino.Margin = New Padding(3, 4, 3, 4)
        chkPepino.Name = "chkPepino"
        chkPepino.Size = New Size(81, 24)
        chkPepino.TabIndex = 9
        chkPepino.Text = "PEPINO"
        chkPepino.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(383, 520)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 20)
        Label3.TabIndex = 10
        Label3.Text = "Quantidade"
        ' 
        ' txtQtdExtra
        ' 
        txtQtdExtra.Location = New Point(371, 489)
        txtQtdExtra.Margin = New Padding(3, 4, 3, 4)
        txtQtdExtra.Name = "txtQtdExtra"
        txtQtdExtra.Size = New Size(114, 27)
        txtQtdExtra.TabIndex = 11
        txtQtdExtra.Text = "0"
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(300, 688)
        txtTotal.Margin = New Padding(3, 4, 3, 4)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(114, 27)
        txtTotal.TabIndex = 12
        txtTotal.Text = "0"
        ' 
        ' txtQtdPizza
        ' 
        txtQtdPizza.Location = New Point(38, 297)
        txtQtdPizza.Margin = New Padding(3, 4, 3, 4)
        txtQtdPizza.Name = "txtQtdPizza"
        txtQtdPizza.Size = New Size(114, 27)
        txtQtdPizza.TabIndex = 13
        txtQtdPizza.Text = "0"
        ' 
        ' txtQtdBebida
        ' 
        txtQtdBebida.Location = New Point(514, 297)
        txtQtdBebida.Margin = New Padding(3, 4, 3, 4)
        txtQtdBebida.Name = "txtQtdBebida"
        txtQtdBebida.Size = New Size(114, 27)
        txtQtdBebida.TabIndex = 14
        txtQtdBebida.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(35, 218)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 15
        Label4.Text = "Preço"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(35, 273)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 20)
        Label5.TabIndex = 16
        Label5.Text = "Quantidade"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(514, 218)
        Label6.Name = "Label6"
        Label6.Size = New Size(46, 20)
        Label6.TabIndex = 17
        Label6.Text = "Preço"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(514, 273)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 20)
        Label7.TabIndex = 18
        Label7.Text = "Quantidade"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(248, 520)
        Label8.Name = "Label8"
        Label8.Size = New Size(46, 20)
        Label8.TabIndex = 19
        Label8.Text = "Preço"
        ' 
        ' txtPrecoExtra
        ' 
        txtPrecoExtra.Location = New Point(214, 489)
        txtPrecoExtra.Margin = New Padding(3, 4, 3, 4)
        txtPrecoExtra.Name = "txtPrecoExtra"
        txtPrecoExtra.Size = New Size(114, 27)
        txtPrecoExtra.TabIndex = 20
        txtPrecoExtra.Text = "0"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.WindowText
        Label9.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = SystemColors.Window
        Label9.Location = New Point(326, 427)
        Label9.Name = "Label9"
        Label9.Size = New Size(75, 26)
        Label9.TabIndex = 21
        Label9.Text = "Extras"
        ' 
        ' rbtSim
        ' 
        rbtSim.AutoSize = True
        rbtSim.Location = New Point(291, 615)
        rbtSim.Margin = New Padding(3, 4, 3, 4)
        rbtSim.Name = "rbtSim"
        rbtSim.Size = New Size(55, 24)
        rbtSim.TabIndex = 22
        rbtSim.Text = "Sim"
        rbtSim.UseVisualStyleBackColor = True
        ' 
        ' rbtNao
        ' 
        rbtNao.AutoSize = True
        rbtNao.Checked = True
        rbtNao.Location = New Point(371, 615)
        rbtNao.Margin = New Padding(3, 4, 3, 4)
        rbtNao.Name = "rbtNao"
        rbtNao.Size = New Size(58, 24)
        rbtNao.TabIndex = 23
        rbtNao.TabStop = True
        rbtNao.Text = "Não"
        rbtNao.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(312, 591)
        Label10.Name = "Label10"
        Label10.Size = New Size(111, 20)
        Label10.TabIndex = 24
        Label10.Text = "Tem Desconto?"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = SystemColors.Info
        Label11.BorderStyle = BorderStyle.Fixed3D
        Label11.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(40, 9)
        Label11.Name = "Label11"
        Label11.Size = New Size(672, 83)
        Label11.TabIndex = 25
        Label11.Text = "Pizzaria Casa di PêJota"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = SystemColors.WindowText
        Label12.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = SystemColors.Window
        Label12.Location = New Point(330, 99)
        Label12.Name = "Label12"
        Label12.Size = New Size(80, 26)
        Label12.TabIndex = 26
        Label12.Text = "Preços"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.BackColor = SystemColors.MenuHighlight
        Label21.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label21.Location = New Point(263, 562)
        Label21.Name = "Label21"
        Label21.Size = New Size(207, 29)
        Label21.TabIndex = 35
        Label21.Text = "DESCONTO - 10%"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label22.Location = New Point(320, 643)
        Label22.Name = "Label22"
        Label22.Size = New Size(81, 41)
        Label22.TabIndex = 36
        Label22.Text = "Total"
        ' 
        ' dgvBD
        ' 
        dgvBD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBD.Location = New Point(249, 128)
        dgvBD.Name = "dgvBD"
        dgvBD.RowHeadersWidth = 51
        dgvBD.RowTemplate.Height = 29
        dgvBD.Size = New Size(236, 291)
        dgvBD.TabIndex = 37
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(732, 776)
        Controls.Add(dgvBD)
        Controls.Add(Label22)
        Controls.Add(Label21)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(rbtNao)
        Controls.Add(rbtSim)
        Controls.Add(Label9)
        Controls.Add(txtPrecoExtra)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtQtdBebida)
        Controls.Add(txtQtdPizza)
        Controls.Add(txtTotal)
        Controls.Add(txtQtdExtra)
        Controls.Add(Label3)
        Controls.Add(chkPepino)
        Controls.Add(chkAzeitona)
        Controls.Add(chkQueijo)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPrecoPizza)
        Controls.Add(txtPrecoBebida)
        Controls.Add(cbxBebidas)
        Controls.Add(cbxPizzas)
        Controls.Add(btnCalcular)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        CType(dgvBD, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents cbxPizzas As ComboBox
    Friend WithEvents cbxBebidas As ComboBox
    Friend WithEvents txtPrecoBebida As TextBox
    Friend WithEvents txtPrecoPizza As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chkQueijo As CheckBox
    Friend WithEvents chkAzeitona As CheckBox
    Friend WithEvents chkPepino As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQtdExtra As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtQtdPizza As TextBox
    Friend WithEvents txtQtdBebida As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPrecoExtra As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents rbtSim As RadioButton
    Friend WithEvents rbtNao As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents dgvBD As DataGridView
End Class
