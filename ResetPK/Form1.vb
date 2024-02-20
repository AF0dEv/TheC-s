Public Class Form1
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim obj As New DataBaseAccess
        Dim sc As String = obj.ConnectionString()
        Dim sql As String
        sql = "DELETE FROM Produtos; dbcc checkident ('Produtos', reseed, 0)"
        obj.BuscarDados(sc, sql)
    End Sub
End Class
