Public Class Form1
    'Dim obj As New Nova ' Declarar obj Como Objeto da Classe Nova
    'Dim n As Integer
    'n = obj.x <-- Nao funciona pois e uma atribuiçao e nao escreve se atribuiçoes nas classes
    Function qqc() As Integer ' Metodo do Tipo Inteiro
        Dim obj As New Nova
        Dim n As Integer
        n = obj.x
        Return 0
    End Function
End Class
Public Class Nova
    Public x As Integer ' Declarar Variavel Publica x como Inteiro x = membro classe Nova
    Private y As Integer ' Declarar Variavel Privada y como Inteiro y = membro classe Nova
End Class