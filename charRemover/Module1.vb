Module Module1

    Sub Main()
        'Declaration
        Dim X, myChar, C, outString As String
        Dim Counter As Integer

        'Initialisation
        X = ""
        myChar = ""
        C = ""
        Counter = 0
        outString = ""

        Console.Write("Enter string: ")
        X = Console.ReadLine

        Console.Write("Enter character to remove: ")
        C = Console.ReadLine

        For Counter = 1 To Len(X)
            myChar = Mid(X, Counter, 1)
            If myChar <> C Then
                outString = outString & myChar
            End If
        Next

        Console.WriteLine("Result: " & outString)
        Console.ReadKey()
    End Sub

End Module
