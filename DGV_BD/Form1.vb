Imports System.Threading.Tasks.Dataflow

Public Class Form1
    Dim obj As New ADB
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obj.sc = "Data Source=10.30.10.2,62555;Initial Catalog=AfonsoAdamastor;User ID=EFAafonso;Password=123.Abc##;"
        obj.ssql = "SELECT * FROM Produtos"
        dgvDino.DataSource = obj.GetData()
    End Sub
End Class
