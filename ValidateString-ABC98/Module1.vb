Module Module1

    Sub Main()
        Dim inputStr As String = Console.ReadLine
        Dim ifValidStr As Boolean = validateString(inputStr)
        If ifValidStr = True Then
            Console.WriteLine("String is Valid.")
        Else
            Console.WriteLine("String is invalid!")
        End If
        Console.ReadKey()
    End Sub

    Function validateString(ByVal MyStr As String) As Boolean
        Dim isValid As Boolean = False
        Dim ch As Char = ""
        Dim i As Integer = 0

        If Len(MyStr) <> 5 Then
            Return False
        End If

        For i = 1 To 3
            ch = Mid(MyStr, i, 1)
            If ch < "A" Or ch > "Z" Then Return False
        Next

        For i = 4 To 5
            ch = Mid(MyStr, i, 1)
            If ch < "0" Or ch > "9" Then Return False
        Next

        Return True
    End Function
End Module
