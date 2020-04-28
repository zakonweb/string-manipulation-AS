Module Module1

    Sub Main()
        'Declaration
        Dim X, myChar, C As String
        Dim Counter, cCount As Integer

        'Initialisation
        X = ""
        myChar = ""
        C = ""
        Counter = 0
        cCount = 0

        Console.Write("Enter string to search in: ")
        X = Console.ReadLine

        Console.Write("Enter character to look and count for: ")
        C = Console.ReadLine

        For Counter = 1 To Len(X)
            myChar = Mid(X, Counter, 1)
            If UCase(myChar) = UCase(C) Then
                cCount = cCount + 1
            End If
        Next

        Console.WriteLine(cCount)
        Console.ReadKey()
    End Sub

End Module
