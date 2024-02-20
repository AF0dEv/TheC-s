Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim obj As New DataBaseAccess 'INSTANCIAR A CLASSE FORNECIDA

        Dim sc As String = obj.ConnectionString 'qual a string connection?
        Dim ssql As String = "Select * From produtos;" 'que dados trazer? 

        DataGridView1.DataSource = obj.BuscarDados(sc, ssql)

    End Sub
End Class
