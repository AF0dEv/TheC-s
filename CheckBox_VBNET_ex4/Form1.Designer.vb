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
        chkCiclismo = New CheckBox()
        chkAtletismo = New CheckBox()
        chkNatacao = New CheckBox()
        txtResultado = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' chkCiclismo
        ' 
        chkCiclismo.AutoSize = True
        chkCiclismo.Location = New Point(12, 45)
        chkCiclismo.Name = "chkCiclismo"
        chkCiclismo.Size = New Size(72, 19)
        chkCiclismo.TabIndex = 0
        chkCiclismo.Text = "Ciclismo"
        chkCiclismo.UseVisualStyleBackColor = True
        ' 
        ' chkAtletismo
        ' 
        chkAtletismo.AutoSize = True
        chkAtletismo.Location = New Point(12, 70)
        chkAtletismo.Name = "chkAtletismo"
        chkAtletismo.Size = New Size(77, 19)
        chkAtletismo.TabIndex = 1
        chkAtletismo.Text = "Atletismo"
        chkAtletismo.UseVisualStyleBackColor = True
        ' 
        ' chkNatacao
        ' 
        chkNatacao.AutoSize = True
        chkNatacao.Location = New Point(12, 95)
        chkNatacao.Name = "chkNatacao"
        chkNatacao.Size = New Size(70, 19)
        chkNatacao.TabIndex = 2
        chkNatacao.Text = "Natação"
        chkNatacao.UseVisualStyleBackColor = True
        ' 
        ' txtResultado
        ' 
        txtResultado.Location = New Point(141, 223)
        txtResultado.Name = "txtResultado"
        txtResultado.Size = New Size(100, 23)
        txtResultado.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(128, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 15)
        Label1.TabIndex = 5
        Label1.Text = "Selecione Desportos"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(80, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 15)
        Label2.TabIndex = 6
        Label2.Text = "Contar Qts Selecionados"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(353, 272)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtResultado)
        Controls.Add(chkNatacao)
        Controls.Add(chkAtletismo)
        Controls.Add(chkCiclismo)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents chkCiclismo As CheckBox
    Friend WithEvents chkAtletismo As CheckBox
    Friend WithEvents chkNatacao As CheckBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
