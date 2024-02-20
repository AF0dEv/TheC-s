Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Istanciar a Classe nova
        Dim obj As New DataBaseAccess
        ' Definir string connection
        Dim sc As String
        ' Definir a string sql
        Dim ssql As String = "select * from Fornecedores"
        ' Declarar sc
        sc = obj.ConnectionString()
        ' Trazer os fornecedores e atribui-los a grid
        DataGridView1.DataSource = obj.BuscarDados(sc, ssql)
    End Sub
End Class