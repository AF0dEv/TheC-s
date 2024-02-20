Public Class Viagem


    Dim obj As New DataBaseAccess
    Dim sc As String = obj.ConnectionString()
    Dim ssql As String
    Dim DtViagem As DataTable
    ''' <summary>
    ''' Criar Viagnes
    ''' </summary>
    ''' <param name="duracao"> Duração em Dias</param>
    ''' <param name="km"> Quilometragem Percorrida</param>
    ''' <param name="viatura">Id da Viatura</param>
    ''' <returns></returns>
    Public Function criarViagem(duracao As String, km As String, viatura As String)
        Try
            ssql = "INSERT INTO Viagens (duracao, quilometragem, id_viatura) 
                    VALUES (" + duracao + ", " + km + ", '" + viatura + "')"
            MessageBox.Show(ssql)
            DtViagem = obj.BuscarDados(sc, ssql)

        Catch ex As Exception
        Throw ex
        End Try

        Return DtViagem
    End Function
    ''' <summary>
    ''' Buscar Viagens a BD
    ''' </summary>
    ''' <param name="sql">String em SQL</param>
    ''' <returns></returns>
    Public Function getViagem(sql As String)

        Try
            DtViagem = obj.BuscarDados(sc, sql)
        Catch ex As Exception
            Throw ex
        End Try

        Return DtViagem

    End Function
    ''' <summary>
    ''' Eliminar Registos de Viagem
    ''' </summary>
    ''' <param name="id">id da viagem a eliminar</param>
    Sub eliminarViagem(id As String)

        Try

            ssql = "DELETE FROM Viagens WHERE id = " + id + ";"
            obj.BuscarDados(sc, ssql)

        Catch ex As Exception

        End Try

    End Sub
End Class
