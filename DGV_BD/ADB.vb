Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Public Class ADB
    Public Property ssql As String
    Public Property sc As String
    Public Function GetData() As DataTable
        Dim Con As SqlConnection = New SqlConnection(sc)
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
