Module Module1

    Sub Main()
        Dim Str1, Str2, Char1, char2, nextChar As String
        Dim Counter As Integer

        Str1 = ""
        Str2 = ""
        Char1 = ""
        char2 = ""
        nextChar = ""
        Counter = 0

        Console.Write("Enter String: ")
        Str1 = Console.ReadLine

        Console.Write("Enter character to remove: ")
        Char1 = Console.ReadLine

        Console.Write("Enter character to replce: ")
        char2 = Console.ReadLine

        For Counter = 1 To Len(Str1)
            nextChar = Mid(Str1, Counter, 1)
            If nextChar = Char1 Then
                nextChar = char2
            End If
            Str2 = Str2 & nextChar
        Next

        Console.WriteLine("Final string = " & Str2)
        Console.ReadKey()
    End Sub

End Module
