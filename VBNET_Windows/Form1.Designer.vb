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
        btnOlaMundo = New Button()
        txtOlaMundo = New TextBox()
        SuspendLayout()
        ' 
        ' btnOlaMundo
        ' 
        btnOlaMundo.Location = New Point(12, 12)
        btnOlaMundo.Name = "btnOlaMundo"
        btnOlaMundo.Size = New Size(75, 23)
        btnOlaMundo.TabIndex = 0
        btnOlaMundo.Text = "OK"
        btnOlaMundo.UseVisualStyleBackColor = True
        ' 
        ' txtOlaMundo
        ' 
        txtOlaMundo.Location = New Point(12, 100)
        txtOlaMundo.Name = "txtOlaMundo"
        txtOlaMundo.Size = New Size(187, 23)
        txtOlaMundo.TabIndex = 1
        txtOlaMundo.Text = ".........."
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(264, 155)
        Controls.Add(txtOlaMundo)
        Controls.Add(btnOlaMundo)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnOlaMundo As Button
    Friend WithEvents txtOlaMundo As TextBox
End Class
