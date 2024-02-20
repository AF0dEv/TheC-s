Imports System.IO
Imports System.Linq.Expressions

Public Class Form1
    ' ######################################### REINICIAR #######################################
    Sub Reiniciar()
        lstEquipasOitavos.Items.Clear() ' Limpar List Box
        lstEquipasQuartos.Items.Clear() ' Limpar List Box
        lstEquipasMeias.Items.Clear() ' Limpar List Box
        lstEquipasFinal.Items.Clear() ' Limpar List Box
        lstSorteioQuartos.Items.Clear() ' Limpar List Box
        lstSorteioMeias.Items.Clear() ' Limpar List Box
        lstResultadoQuartos.Items.Clear() ' Limpar List Box
        lstResultadoMeias.Items.Clear() ' Limpar List Box
        lstResultadoFinal.Items.Clear() ' Limpar List Box
        txtVencedor.Clear() ' Limpar List Box
        btnEquipasOitavos.Enabled = True
        btnEquipasQuartos.Enabled = True
        btnSortearQuartos.Enabled = True
    End Sub
    ' ################################ INICIALIZAR COM 16 EQUIPAS ###############################
    Sub InicializarCom16Equipas()
        lstEquipasOitavos.Items.Add("Marítimo")
        lstEquipasOitavos.Items.Add("Arouca")
        lstEquipasOitavos.Items.Add("Porto")
        lstEquipasOitavos.Items.Add("Braga")
        lstEquipasOitavos.Items.Add("Nacional")
        lstEquipasOitavos.Items.Add("Benfica")
        lstEquipasOitavos.Items.Add("Guimarães")
        lstEquipasOitavos.Items.Add("Gil Vicente")
        lstEquipasOitavos.Items.Add("Sporting")
        lstEquipasOitavos.Items.Add("Portimonense")
        lstEquipasOitavos.Items.Add("Rio Ave")
        lstEquipasOitavos.Items.Add("Santa Clara")
        lstEquipasOitavos.Items.Add("Setúbal")
        lstEquipasOitavos.Items.Add("Chaves")
        lstEquipasOitavos.Items.Add("Leixões")
        lstEquipasOitavos.Items.Add("Estoril")
    End Sub
    ' ################################ RANDOMIZAR GOLOS ###############################
    Public Function RandomizarGolos() As Integer
        Dim random As New Random
        Dim num As Integer = random.Next(0, 10)
        Return num
    End Function
    ' #################################### EQUIPAS QUARTOS #####################################
    Public Sub EquipasQuartos()
        ' ############################################# 1ª TENTATIVA (FUNCIONA) ##############################################

        'Dim Marítimo As Integer = 0
        'Dim Arouca As Integer = 1
        'Dim Porto As Integer = 2
        'Dim Braga As Integer = 3
        'Dim Nacional As Integer = 4
        'Dim Benfica As Integer = 5
        'Dim Guimaraes As Integer = 6
        'Dim GilVicente As Integer = 7
        'Dim Sporting As Integer = 8
        'Dim Portimonense As Integer = 9
        'Dim RioAve As Integer = 10
        'Dim SantaClara As Integer = 11
        'Dim Setubal As Integer = 12
        'Dim Chaves As Integer = 13
        'Dim Leixoes As Integer = 14
        'Dim Estoril As Integer = 15
        'Dim Equipa1 As Integer
        'Dim Equipa2 As Integer
        'Dim Equipa3 As Integer
        'Dim Equipa4 As Integer
        'Dim Equipa5 As Integer
        'Dim Equipa6 As Integer
        'Dim Equipa7 As Integer
        'Dim Equipa8 As Integer
        'Equipa1 = RandomizarEquipas()
        'Equipa2 = RandomizarEquipas()
        'While Equipa2 = Equipa1
        '    Equipa2 = RandomizarEquipas()
        'End While
        'Equipa3 = RandomizarEquipas()
        'While Equipa3 = Equipa1 Or Equipa3 = Equipa2
        '    Equipa3 = RandomizarEquipas()
        'End While
        'Equipa4 = RandomizarEquipas()
        'While Equipa4 = Equipa1 Or Equipa4 = Equipa2 Or Equipa4 = Equipa3
        '    Equipa4 = RandomizarEquipas()
        'End While
        'Equipa5 = RandomizarEquipas()
        'While Equipa5 = Equipa1 Or Equipa5 = Equipa2 Or Equipa5 = Equipa3 Or Equipa5 = Equipa4
        '    Equipa5 = RandomizarEquipas()
        'End While
        'Equipa6 = RandomizarEquipas()
        'While Equipa6 = Equipa1 Or Equipa6 = Equipa2 Or Equipa6 = Equipa3 Or Equipa6 = Equipa4 Or Equipa6 = Equipa5
        '    Equipa6 = RandomizarEquipas()
        'End While
        'Equipa7 = RandomizarEquipas()
        'While Equipa7 = Equipa1 Or Equipa7 = Equipa2 Or Equipa7 = Equipa3 Or Equipa7 = Equipa4 Or Equipa7 = Equipa5 Or Equipa7 = Equipa6
        '    Equipa7 = RandomizarEquipas()
        'End While
        'Equipa8 = RandomizarEquipas()
        'While Equipa8 = Equipa1 Or Equipa8 = Equipa2 Or Equipa8 = Equipa3 Or Equipa8 = Equipa4 Or Equipa8 = Equipa5 Or Equipa8 = Equipa6 Or Equipa8 = Equipa7
        '    Equipa8 = RandomizarEquipas()
        'End While
        'If Equipa1 = 0 Then
        '    lstEquipasQuartos.Items.Add("Maritimo")
        'ElseIf Equipa1 = 1 Then
        '    lstEquipasQuartos.Items.Add("Arouca")
        'ElseIf Equipa1 = 2 Then
        '    lstEquipasQuartos.Items.Add("Porto")
        'ElseIf Equipa1 = 3 Then
        '    lstEquipasQuartos.Items.Add("Braga")
        'ElseIf Equipa1 = 4 Then
        '    lstEquipasQuartos.Items.Add("Nacional")
        'ElseIf Equipa1 = 5 Then
        '    lstEquipasQuartos.Items.Add("Benfica")
        'ElseIf Equipa1 = 6 Then
        '    lstEquipasQuartos.Items.Add("Guimarães")
        'ElseIf Equipa1 = 7 Then
        '    lstEquipasQuartos.Items.Add("Gil Vicente")
        'ElseIf Equipa1 = 8 Then
        '    lstEquipasQuartos.Items.Add("Sporting")
        'ElseIf Equipa1 = 9 Then
        '    lstEquipasQuartos.Items.Add("Portimonense")
        'ElseIf Equipa1 = 10 Then
        '    lstEquipasQuartos.Items.Add("Rio Ave")
        'ElseIf Equipa1 = 11 Then
        '    lstEquipasQuartos.Items.Add("Santa Clara")
        'ElseIf Equipa1 = 12 Then
        '    lstEquipasQuartos.Items.Add("Setubal")
        'ElseIf Equipa1 = 13 Then
        '    lstEquipasQuartos.Items.Add("Chaves")
        'ElseIf Equipa1 = 14 Then
        '    lstEquipasQuartos.Items.Add("Leixoes")
        'ElseIf Equipa1 = 15 Then
        '    lstEquipasQuartos.Items.Add("Estoril")
        'End If
        'If Equipa2 = 0 Then
        '    lstEquipasQuartos.Items.Add("Maritimo")
        'ElseIf Equipa2 = 1 Then
        '    lstEquipasQuartos.Items.Add("Arouca")
        'ElseIf Equipa2 = 2 Then
        '    lstEquipasQuartos.Items.Add("Porto")
        'ElseIf Equipa2 = 3 Then
        '    lstEquipasQuartos.Items.Add("Braga")
        'ElseIf Equipa2 = 4 Then
        '    lstEquipasQuartos.Items.Add("Nacional")
        'ElseIf Equipa2 = 5 Then
        '    lstEquipasQuartos.Items.Add("Benfica")
        'ElseIf Equipa2 = 6 Then
        '    lstEquipasQuartos.Items.Add("Guimarães")
        'ElseIf Equipa2 = 7 Then
        '    lstEquipasQuartos.Items.Add("Gil Vicente")
        'ElseIf Equipa2 = 8 Then
        '    lstEquipasQuartos.Items.Add("Sporting")
        'ElseIf Equipa2 = 9 Then
        '    lstEquipasQuartos.Items.Add("Portimonense")
        'ElseIf Equipa2 = 10 Then
        '    lstEquipasQuartos.Items.Add("Rio Ave")
        'ElseIf Equipa2 = 11 Then
        '    lstEquipasQuartos.Items.Add("Santa Clara")
        'ElseIf Equipa2 = 12 Then
        '    lstEquipasQuartos.Items.Add("Setubal")
        'ElseIf Equipa2 = 13 Then
        '    lstEquipasQuartos.Items.Add("Chaves")
        'ElseIf Equipa2 = 14 Then
        '    lstEquipasQuartos.Items.Add("Leixoes")
        'ElseIf Equipa2 = 15 Then
        '    lstEquipasQuartos.Items.Add("Estoril")
        'End If
        'If Equipa3 = 0 Then
        '    lstEquipasQuartos.Items.Add("Maritimo")
        'ElseIf Equipa3 = 1 Then
        '    lstEquipasQuartos.Items.Add("Arouca")
        'ElseIf Equipa3 = 2 Then
        '    lstEquipasQuartos.Items.Add("Porto")
        'ElseIf Equipa3 = 3 Then
        '    lstEquipasQuartos.Items.Add("Braga")
        'ElseIf Equipa3 = 4 Then
        '    lstEquipasQuartos.Items.Add("Nacional")
        'ElseIf Equipa3 = 5 Then
        '    lstEquipasQuartos.Items.Add("Benfica")
        'ElseIf Equipa3 = 6 Then
        '    lstEquipasQuartos.Items.Add("Guimarães")
        'ElseIf Equipa3 = 7 Then
        '    lstEquipasQuartos.Items.Add("Gil Vicente")
        'ElseIf Equipa3 = 8 Then
        '    lstEquipasQuartos.Items.Add("Sporting")
        'ElseIf Equipa3 = 9 Then
        '    lstEquipasQuartos.Items.Add("Portimonense")
        'ElseIf Equipa3 = 10 Then
        '    lstEquipasQuartos.Items.Add("Rio Ave")
        'ElseIf Equipa3 = 11 Then
        '    lstEquipasQuartos.Items.Add("Santa Clara")
        'ElseIf Equipa3 = 12 Then
        '    lstEquipasQuartos.Items.Add("Setubal")
        'ElseIf Equipa3 = 13 Then
        '    lstEquipasQuartos.Items.Add("Chaves")
        'ElseIf Equipa3 = 14 Then
        '    lstEquipasQuartos.Items.Add("Leixoes")
        'ElseIf Equipa3 = 15 Then
        '    lstEquipasQuartos.Items.Add("Estoril")
        'End If
        'If Equipa4 = 0 Then
        '    lstEquipasQuartos.Items.Add("Maritimo")
        'ElseIf Equipa4 = 1 Then
        '    lstEquipasQuartos.Items.Add("Arouca")
        'ElseIf Equipa4 = 2 Then
        '    lstEquipasQuartos.Items.Add("Porto")
        'ElseIf Equipa4 = 3 Then
        '    lstEquipasQuartos.Items.Add("Braga")
        'ElseIf Equipa4 = 4 Then
        '    lstEquipasQuartos.Items.Add("Nacional")
        'ElseIf Equipa4 = 5 Then
        '    lstEquipasQuartos.Items.Add("Benfica")
        'ElseIf Equipa4 = 6 Then
        '    lstEquipasQuartos.Items.Add("Guimarães")
        'ElseIf Equipa4 = 7 Then
        '    lstEquipasQuartos.Items.Add("Gil Vicente")
        'ElseIf Equipa4 = 8 Then
        '    lstEquipasQuartos.Items.Add("Sporting")
        'ElseIf Equipa4 = 9 Then
        '    lstEquipasQuartos.Items.Add("Portimonense")
        'ElseIf Equipa4 = 10 Then
        '    lstEquipasQuartos.Items.Add("Rio Ave")
        'ElseIf Equipa4 = 11 Then
        '    lstEquipasQuartos.Items.Add("Santa Clara")
        'ElseIf Equipa4 = 12 Then
        '    lstEquipasQuartos.Items.Add("Setubal")
        'ElseIf Equipa4 = 13 Then
        '    lstEquipasQuartos.Items.Add("Chaves")
        'ElseIf Equipa4 = 14 Then
        '    lstEquipasQuartos.Items.Add("Leixoes")
        'ElseIf Equipa4 = 15 Then
        '    lstEquipasQuartos.Items.Add("Estoril")
        'End If
        'If Equipa5 = 0 Then
        '    lstEquipasQuartos.Items.Add("Maritimo")
        'ElseIf Equipa5 = 1 Then
        '    lstEquipasQuartos.Items.Add("Arouca")
        'ElseIf Equipa5 = 2 Then
        '    lstEquipasQuartos.Items.Add("Porto")
        'ElseIf Equipa5 = 3 Then
        '    lstEquipasQuartos.Items.Add("Braga")
        'ElseIf Equipa5 = 4 Then
        '    lstEquipasQuartos.Items.Add("Nacional")
        'ElseIf Equipa5 = 5 Then
        '    lstEquipasQuartos.Items.Add("Benfica")
        'ElseIf Equipa5 = 6 Then
        '    lstEquipasQuartos.Items.Add("Guimarães")
        'ElseIf Equipa5 = 7 Then
        '    lstEquipasQuartos.Items.Add("Gil Vicente")
        'ElseIf Equipa5 = 8 Then
        '    lstEquipasQuartos.Items.Add("Sporting")
        'ElseIf Equipa5 = 9 Then
        '    lstEquipasQuartos.Items.Add("Portimonense")
        'ElseIf Equipa5 = 10 Then
        '    lstEquipasQuartos.Items.Add("Rio Ave")
        'ElseIf Equipa5 = 11 Then
        '    lstEquipasQuartos.Items.Add("Santa Clara")
        'ElseIf Equipa5 = 12 Then
        '    lstEquipasQuartos.Items.Add("Setubal")
        'ElseIf Equipa5 = 13 Then
        '    lstEquipasQuartos.Items.Add("Chaves")
        'ElseIf Equipa5 = 14 Then
        '    lstEquipasQuartos.Items.Add("Leixoes")
        'ElseIf Equipa5 = 15 Then
        '    lstEquipasQuartos.Items.Add("Estoril")
        'End If
        'If Equipa6 = 0 Then
        '    lstEquipasQuartos.Items.Add("Maritimo")
        'ElseIf Equipa6 = 1 Then
        '    lstEquipasQuartos.Items.Add("Arouca")
        'ElseIf Equipa6 = 2 Then
        '    lstEquipasQuartos.Items.Add("Porto")
        'ElseIf Equipa6 = 3 Then
        '    lstEquipasQuartos.Items.Add("Braga")
        'ElseIf Equipa6 = 4 Then
        '    lstEquipasQuartos.Items.Add("Nacional")
        'ElseIf Equipa6 = 5 Then
        '    lstEquipasQuartos.Items.Add("Benfica")
        'ElseIf Equipa6 = 6 Then
        '    lstEquipasQuartos.Items.Add("Guimarães")
        'ElseIf Equipa6 = 7 Then
        '    lstEquipasQuartos.Items.Add("Gil Vicente")
        'ElseIf Equipa6 = 8 Then
        '    lstEquipasQuartos.Items.Add("Sporting")
        'ElseIf Equipa6 = 9 Then
        '    lstEquipasQuartos.Items.Add("Portimonense")
        'ElseIf Equipa6 = 10 Then
        '    lstEquipasQuartos.Items.Add("Rio Ave")
        'ElseIf Equipa6 = 11 Then
        '    lstEquipasQuartos.Items.Add("Santa Clara")
        'ElseIf Equipa6 = 12 Then
        '    lstEquipasQuartos.Items.Add("Setubal")
        'ElseIf Equipa6 = 13 Then
        '    lstEquipasQuartos.Items.Add("Chaves")
        'ElseIf Equipa6 = 14 Then
        '    lstEquipasQuartos.Items.Add("Leixoes")
        'ElseIf Equipa6 = 15 Then
        '    lstEquipasQuartos.Items.Add("Estoril")
        'End If
        'If Equipa7 = 0 Then
        '    lstEquipasQuartos.Items.Add("Maritimo")
        'ElseIf Equipa7 = 1 Then
        '    lstEquipasQuartos.Items.Add("Arouca")
        'ElseIf Equipa7 = 2 Then
        '    lstEquipasQuartos.Items.Add("Porto")
        'ElseIf Equipa7 = 3 Then
        '    lstEquipasQuartos.Items.Add("Braga")
        'ElseIf Equipa7 = 4 Then
        '    lstEquipasQuartos.Items.Add("Nacional")
        'ElseIf Equipa7 = 5 Then
        '    lstEquipasQuartos.Items.Add("Benfica")
        'ElseIf Equipa7 = 6 Then
        '    lstEquipasQuartos.Items.Add("Guimarães")
        'ElseIf Equipa7 = 7 Then
        '    lstEquipasQuartos.Items.Add("Gil Vicente")
        'ElseIf Equipa7 = 8 Then
        '    lstEquipasQuartos.Items.Add("Sporting")
        'ElseIf Equipa7 = 9 Then
        '    lstEquipasQuartos.Items.Add("Portimonense")
        'ElseIf Equipa7 = 10 Then
        '    lstEquipasQuartos.Items.Add("Rio Ave")
        'ElseIf Equipa7 = 11 Then
        '    lstEquipasQuartos.Items.Add("Santa Clara")
        'ElseIf Equipa7 = 12 Then
        '    lstEquipasQuartos.Items.Add("Setubal")
        'ElseIf Equipa7 = 13 Then
        '    lstEquipasQuartos.Items.Add("Chaves")
        'ElseIf Equipa7 = 14 Then
        '    lstEquipasQuartos.Items.Add("Leixoes")
        'ElseIf Equipa7 = 15 Then
        '    lstEquipasQuartos.Items.Add("Estoril")
        'End If
        'If Equipa8 = 0 Then
        '    lstEquipasQuartos.Items.Add("Maritimo")
        'ElseIf Equipa8 = 1 Then
        '    lstEquipasQuartos.Items.Add("Arouca")
        'ElseIf Equipa8 = 2 Then
        '    lstEquipasQuartos.Items.Add("Porto")
        'ElseIf Equipa8 = 3 Then
        '    lstEquipasQuartos.Items.Add("Braga")
        'ElseIf Equipa8 = 4 Then
        '    lstEquipasQuartos.Items.Add("Nacional")
        'ElseIf Equipa8 = 5 Then
        '    lstEquipasQuartos.Items.Add("Benfica")
        'ElseIf Equipa8 = 6 Then
        '    lstEquipasQuartos.Items.Add("Guimarães")
        'ElseIf Equipa8 = 7 Then
        '    lstEquipasQuartos.Items.Add("Gil Vicente")
        'ElseIf Equipa8 = 8 Then
        '    lstEquipasQuartos.Items.Add("Sporting")
        'ElseIf Equipa8 = 9 Then
        '    lstEquipasQuartos.Items.Add("Portimonense")
        'ElseIf Equipa8 = 10 Then
        '    lstEquipasQuartos.Items.Add("Rio Ave")
        'ElseIf Equipa8 = 11 Then
        '    lstEquipasQuartos.Items.Add("Santa Clara")
        'ElseIf Equipa8 = 12 Then
        '    lstEquipasQuartos.Items.Add("Setubal")
        'ElseIf Equipa8 = 13 Then
        '    lstEquipasQuartos.Items.Add("Chaves")
        'ElseIf Equipa8 = 14 Then
        '    lstEquipasQuartos.Items.Add("Leixoes")
        'ElseIf Equipa8 = 15 Then
        '    lstEquipasQuartos.Items.Add("Estoril")
        'End If

        ' ############################################# 2ª TENTATIVA (FUNCIONA) ##############################################

        Dim random As New Random ' Para Randomizar os Numeros
        Dim sorteada As String ' Guardar a Equipa Sorteada
        For index = 0 To (lstEquipasOitavos.Items.Count() - 1) / 2 ' Ciclo até Metade das Equipas (8)
            Dim randomIndex As Integer = random.Next(0, lstEquipasOitavos.Items.Count() - 1) ' Randomizar as Equipas Todas
            sorteada = lstEquipasOitavos.Items(randomIndex).ToString() ' Guardar o Nome da Equipa Sorteda
            lstEquipasQuartos.Items.Add(sorteada) ' Atribuir Equipa Sorteada a Nova ListBox
            lstEquipasOitavos.Items.RemoveAt(randomIndex) ' Apagar Essa Equipa na ListBox Anterior
        Next
    End Sub
    ' ###################################### JOGOS QUARTOS ####################################
    Sub JogosQuartos()
        Dim random As New Random
        Dim sorteada As String

        For index = 0 To 3
            Dim randomIndex As Integer = random.Next(0, lstEquipasQuartos.Items.Count())
            sorteada = lstEquipasQuartos.Items(randomIndex).ToString()
            lstEquipasQuartos.Items.RemoveAt(randomIndex)
            Dim nextRandomIndex As Integer = random.Next(0, lstEquipasQuartos.Items.Count())
            Dim nextSorteado As String = lstEquipasQuartos.Items(nextRandomIndex).ToString()
            lstEquipasQuartos.Items.RemoveAt(nextRandomIndex)

            Dim jogo As String = sorteada + " - " + nextSorteado
            lstSorteioQuartos.Items.Add(jogo)
            btnSortearQuartos.Enabled = False
        Next
    End Sub
    ' ###################################### RESULTADOS QUARTOS #############################
    Sub ResultadosQuartos()
        For index = 1 To 10

        Next

        Dim jogoacabado As String = lstEquipasQuartos.Items().ToString() + " " + Convert.ToString(RandomizarGolos) + " - "
        lstResultadoQuartos.Items.Add(jogoacabado)

    End Sub
    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        Reiniciar()
    End Sub
    Private Sub btnEquipasOitavos_Click(sender As Object, e As EventArgs) Handles btnEquipasOitavos.Click
        InicializarCom16Equipas()
        btnEquipasOitavos.Enabled = False 'Desativar Botão
    End Sub

    Private Sub btnEquipasQuartos_Click(sender As Object, e As EventArgs) Handles btnEquipasQuartos.Click
        EquipasQuartos()
        btnEquipasQuartos.Enabled = False ' Desativar Botão
    End Sub

    Private Sub btnSortearQuartos_Click(sender As Object, e As EventArgs) Handles btnSortearQuartos.Click
        JogosQuartos()
    End Sub

    Private Sub btnResultadoQuartos_Click(sender As Object, e As EventArgs) Handles btnResultadoQuartos.Click
        ResultadosQuartos()
    End Sub
End Class
