Imports System.Runtime.CompilerServices

Friend Module IntegerExtensions
    <Extension>
    Friend Function URightShift(operand As Integer, n As Integer) As Integer
        If (operand >= 0) Then
            Return operand >> n
        End If

        Return (operand >> n) + (2 << Not n)
    End Function
End Module