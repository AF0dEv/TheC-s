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
        rbtM = New RadioButton()
        rbtF = New RadioButton()
        txtSexo = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' rbtM
        ' 
        rbtM.AutoSize = True
        rbtM.Location = New Point(33, 42)
        rbtM.Name = "rbtM"
        rbtM.Size = New Size(36, 19)
        rbtM.TabIndex = 0
        rbtM.TabStop = True
        rbtM.Text = "M"
        rbtM.UseVisualStyleBackColor = True
        ' 
        ' rbtF
        ' 
        rbtF.AutoSize = True
        rbtF.Location = New Point(174, 42)
        rbtF.Name = "rbtF"
        rbtF.Size = New Size(31, 19)
        rbtF.TabIndex = 1
        rbtF.TabStop = True
        rbtF.Text = "F"
        rbtF.UseVisualStyleBackColor = True
        ' 
        ' txtSexo
        ' 
        txtSexo.Location = New Point(200, 122)
        txtSexo.Name = "txtSexo"
        txtSexo.Size = New Size(100, 23)
        txtSexo.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(63, 125)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 15)
        Label1.TabIndex = 3
        Label1.Text = "O Sexo selecionado -->"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(312, 171)
        Controls.Add(Label1)
        Controls.Add(txtSexo)
        Controls.Add(rbtF)
        Controls.Add(rbtM)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents rbtM As RadioButton
    Friend WithEvents rbtF As RadioButton
    Friend WithEvents txtSexo As TextBox
    Friend WithEvents Label1 As Label
End Class
