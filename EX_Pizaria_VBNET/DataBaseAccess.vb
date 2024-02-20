﻿Imports System.Data.SqlClient

Public Class DataBaseAccess
    '################################################################################
    'MÉTODO QUE DEVOLVE A STRING COM A CONEXÃO À BASE DE DADOS
    'nota: pode haver várias SC; escolher qual a que se pretende usar
    Public Function ConnectionString() As String

        'Dim SCantiga As String = "Data Source=121.1............ "
        'Dim SCnova As String = "Data Source=89.1............... "
        'Dim SCLeopardo = "Data Source=leopar...;"
        'Dim SCLagostim = "Data Source=10.30.10.1,62444;Initial Catalog=adamastor2022;User ID=sa;Password=123...;"
        Dim SCLagostimExterna = "Data Source=62.28.39.135,62444;Initial Catalog=EFAafonso;User ID=sa;Password=123.Abc##;"

        'retornar a que é pretendida:
        Return SCLagostimExterna

    End Function
    '################################################################################
    'MÉTODO QUE DEVOLVE A DATABLE A PARTIR DOS PARÂMETROS
    ' SC (string connection) e ssql (query à BD).
    Public Function BuscarDados(SC As String, ssql As String) As DataTable

        Dim Con As SqlConnection = New SqlConnection(SC)
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
