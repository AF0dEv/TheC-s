Imports System.Text.RegularExpressions

Public Class Viatura
    Public id As Integer
    Public designacao As String
    ''' <summary>
    ''' Cria Viaturas na BD
    ''' </summary>
    ''' <param name="marca">Marca do Veiculo</param>
    ''' <returns></returns>
    Public Function Criar(marca As String)
        Dim obj As New DataBaseAccess
        Dim sc As String = obj.ConnectionString()
        Dim dt As DataTable
        Dim sql As String
        Try
            sql = "INSERT INTO Viaturas(designacao)
                            VALUES('" + marca + "')"

            dt = obj.BuscarDados(sc, sql)

        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
    ''' <summary>
    ''' Eliminar Viaturas 
    ''' </summary>
    ''' <param name="pos"> Posiçao da Viatura na DGV</param>
    ''' <returns></returns>
    Public Function Eliminar(pos As String)
        Dim obj As New DataBaseAccess
        Dim sc As String = obj.ConnectionString()
        Dim dt As DataTable
        Dim dtt As DataTable
        Dim sql As String
        sql = "DELETE FROM Viaturas 
               WHERE id = " + pos
        Try
            dt = obj.BuscarDados(sc, sql)

        Catch ex As Exception
            Dim resposta As DialogResult = MessageBox.Show("Não é Possivel Eliminar esta Viatura, Este Registo existe em Viagens." & vbCrLf & "Deseja Eliminar a Viagem?", "ERRO:", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If resposta = DialogResult.Yes Then
                Dim ssql As String = "DELETE FROM Viagens
                                      WHERE id_Viatura = " + pos
                dtt = obj.BuscarDados(sc, ssql)
                dt = obj.BuscarDados(sc, sql)
            End If
        End Try
        Return dt
    End Function
    ''' <summary>
    ''' Listar Viaturas na DGV
    ''' </summary>
    ''' <param name="sql">String em SQL</param>
    ''' <returns></returns>
    Public Function ListarViaturas(sql As String)
        Dim obj As New DataBaseAccess
        Dim sc As String = obj.ConnectionString()
        Dim dt As DataTable
        dt = obj.BuscarDados(sc, sql)
        Return dt
    End Function
End Class
