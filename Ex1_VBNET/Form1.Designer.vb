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
        txtN1 = New TextBox()
        txtN2 = New TextBox()
        txtResultado = New TextBox()
        Label1 = New Label()
        ll = New Label()
        SuspendLayout()
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Location = New Point(117, 41)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(75, 23)
        btnCalcular.TabIndex = 0
        btnCalcular.Text = "Calcular"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' txtN1
        ' 
        txtN1.Location = New Point(12, 12)
        txtN1.Name = "txtN1"
        txtN1.Size = New Size(100, 23)
        txtN1.TabIndex = 1
        ' 
        ' txtN2
        ' 
        txtN2.Location = New Point(186, 12)
        txtN2.Name = "txtN2"
        txtN2.Size = New Size(100, 23)
        txtN2.TabIndex = 2
        ' 
        ' txtResultado
        ' 
        txtResultado.Location = New Point(103, 118)
        txtResultado.Name = "txtResultado"
        txtResultado.Size = New Size(100, 23)
        txtResultado.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.InfoText
        Label1.Location = New Point(136, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 25)
        Label1.TabIndex = 4
        Label1.Text = "+"
        ' 
        ' ll
        ' 
        ll.AutoSize = True
        ll.Location = New Point(145, 88)
        ll.Name = "ll"
        ll.Size = New Size(16, 15)
        ll.TabIndex = 5
        ll.Text = "l l"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(298, 167)
        Controls.Add(ll)
        Controls.Add(Label1)
        Controls.Add(txtResultado)
        Controls.Add(txtN2)
        Controls.Add(txtN1)
        Controls.Add(btnCalcular)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtN1 As TextBox
    Friend WithEvents txtN2 As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ll As Label
End Class
