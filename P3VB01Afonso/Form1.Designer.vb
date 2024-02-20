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
        dgvBD = New DataGridView()
        cbxEscalao = New ComboBox()
        rbtTodos = New RadioButton()
        rbtBraga = New RadioButton()
        rbtPorto = New RadioButton()
        rbtBeja = New RadioButton()
        txtIdCandidatos = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnBuscarID = New Button()
        GroupBox1 = New GroupBox()
        CType(dgvBD, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvBD
        ' 
        dgvBD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBD.Location = New Point(12, 213)
        dgvBD.Name = "dgvBD"
        dgvBD.Size = New Size(776, 225)
        dgvBD.TabIndex = 0
        ' 
        ' cbxEscalao
        ' 
        cbxEscalao.FormattingEnabled = True
        cbxEscalao.Location = New Point(12, 27)
        cbxEscalao.Name = "cbxEscalao"
        cbxEscalao.Size = New Size(121, 23)
        cbxEscalao.TabIndex = 1
        ' 
        ' rbtTodos
        ' 
        rbtTodos.AutoSize = True
        rbtTodos.Checked = True
        rbtTodos.Location = New Point(6, 37)
        rbtTodos.Name = "rbtTodos"
        rbtTodos.Size = New Size(56, 19)
        rbtTodos.TabIndex = 2
        rbtTodos.TabStop = True
        rbtTodos.Text = "Todos"
        rbtTodos.UseVisualStyleBackColor = True
        ' 
        ' rbtBraga
        ' 
        rbtBraga.AutoSize = True
        rbtBraga.Location = New Point(109, 37)
        rbtBraga.Name = "rbtBraga"
        rbtBraga.Size = New Size(55, 19)
        rbtBraga.TabIndex = 3
        rbtBraga.TabStop = True
        rbtBraga.Text = "Braga"
        rbtBraga.UseVisualStyleBackColor = True
        ' 
        ' rbtPorto
        ' 
        rbtPorto.AutoSize = True
        rbtPorto.Location = New Point(6, 62)
        rbtPorto.Name = "rbtPorto"
        rbtPorto.Size = New Size(54, 19)
        rbtPorto.TabIndex = 4
        rbtPorto.TabStop = True
        rbtPorto.Text = "Porto"
        rbtPorto.UseVisualStyleBackColor = True
        ' 
        ' rbtBeja
        ' 
        rbtBeja.AutoSize = True
        rbtBeja.Location = New Point(109, 62)
        rbtBeja.Name = "rbtBeja"
        rbtBeja.Size = New Size(47, 19)
        rbtBeja.TabIndex = 5
        rbtBeja.TabStop = True
        rbtBeja.Text = "Beja"
        rbtBeja.UseVisualStyleBackColor = True
        ' 
        ' txtIdCandidatos
        ' 
        txtIdCandidatos.Location = New Point(12, 151)
        txtIdCandidatos.Name = "txtIdCandidatos"
        txtIdCandidatos.Size = New Size(100, 23)
        txtIdCandidatos.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 15)
        Label1.TabIndex = 7
        Label1.Text = "Escalão"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 15)
        Label2.TabIndex = 8
        Label2.Text = "Localidades"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 15)
        Label3.TabIndex = 9
        Label3.Text = "ID Candidatos"
        ' 
        ' btnBuscarID
        ' 
        btnBuscarID.Location = New Point(118, 151)
        btnBuscarID.Name = "btnBuscarID"
        btnBuscarID.Size = New Size(75, 23)
        btnBuscarID.TabIndex = 10
        btnBuscarID.Text = "Buscar ID"
        btnBuscarID.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(rbtTodos)
        GroupBox1.Controls.Add(rbtBraga)
        GroupBox1.Controls.Add(rbtPorto)
        GroupBox1.Controls.Add(rbtBeja)
        GroupBox1.Location = New Point(12, 56)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(181, 89)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Controls.Add(btnBuscarID)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(txtIdCandidatos)
        Controls.Add(cbxEscalao)
        Controls.Add(dgvBD)
        Name = "Form1"
        Text = "Form1"
        CType(dgvBD, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvBD As DataGridView
    Friend WithEvents cbxEscalao As ComboBox
    Friend WithEvents rbtTodos As RadioButton
    Friend WithEvents rbtBraga As RadioButton
    Friend WithEvents rbtPorto As RadioButton
    Friend WithEvents rbtBeja As RadioButton
    Friend WithEvents txtIdCandidatos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBuscarID As Button
    Friend WithEvents GroupBox1 As GroupBox

End Class
