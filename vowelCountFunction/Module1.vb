Module Module1

    Sub Main()
        Dim myStr As String
        Console.Write("Enter string to find vowels: ")
        myStr = Console.ReadLine

        Console.WriteLine("Vowel count = " & vowelCount(myStr))
        Console.ReadKey()
    End Sub

    Function vowelCount(ByVal s As String) As Integer
        Dim c, a As Integer
        Dim ch As Char
        For a = 1 To Len(s)
            ch = Mid(s, a, 1)
            If InStr("aeiouAEIOU", ch) > 0 Then c = c + 1
        Next
        Return c
    End Function


    Function vowelCount1(ByVal s As String) As Integer
        Dim c, a As Integer
        Dim ch As Char
        For a = 1 To Len(s)
            ch = Mid(s, a, 1)
            Select Case ch
                Case "a", "e", "i", "o", "u" : c = c + 1
                Case "A", "E", "I", "O", "U" : c = c + 1
            End Select
        Next
        Return c
    End Function

    Function vowelCount2(ByVal s As String) As Integer
        Dim c, a As Integer
        Dim ch As Char
        For a = 1 To Len(s)
            ch = Mid(s, a, 1)
            If ch = "a" Or ch = "e" Or ch = "i" Or ch = "o" Or ch = "u" Then c = c + 1
            If ch = "A" Or ch = "E" Or ch = "I" Or ch = "O" Or ch = "U" Then c = c + 1
        Next
        Return c
    End Function

End Module
