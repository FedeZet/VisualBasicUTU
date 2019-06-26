Module NDTransformador
    Public Function NDConvertidor(ByVal Numero As Integer)
        Select Case Numero
            Case 1
                Return "Lunes"
            Case 2
                Return "Martes"
            Case 3
                Return "Miércoles"
            Case 4
                Return "Jueves"
            Case 5
                Return "Viernes"
            Case 6
                Return "Sábado"
            Case 7
                Return "Domingo"
            Case Else
                Return "Error"
        End Select
    End Function
End Module
