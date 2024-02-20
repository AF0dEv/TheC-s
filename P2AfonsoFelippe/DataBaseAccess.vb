Imports System.Data.SqlClient

Public Class DataBaseAccess

    Dim strConn As String = "Data Source=62.28.39.135,62444;Initial Catalog=bdFelippeAfonso_Produtos;User ID=EFAFELIPPE;Password=123.Abc##;"

    Public Function BuscarDados(ssql As String) As DataTable

        Dim Con As SqlConnection = New SqlConnection(strConn)
        Con.Open()

        Dim cmd As SqlCommand = New SqlCommand(ssql, Con)

        Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)

        Dim dt As New DataTable()
        adapter.Fill(dt)

        adapter.Dispose()
        Con.Close()

        Return dt

    End Function

End Class
