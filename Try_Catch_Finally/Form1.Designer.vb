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
        btnDuplicar = New Button()
        SuspendLayout()
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(133, 12)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(100, 23)
        txtTotal.TabIndex = 0
        ' 
        ' btnDuplicar
        ' 
        btnDuplicar.Location = New Point(3, 12)
        btnDuplicar.Name = "btnDuplicar"
        btnDuplicar.Size = New Size(124, 23)
        btnDuplicar.TabIndex = 1
        btnDuplicar.Text = "Duplicar n TextBox"
        btnDuplicar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(242, 50)
        Controls.Add(btnDuplicar)
        Controls.Add(txtTotal)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnDuplicar As Button
End Class
