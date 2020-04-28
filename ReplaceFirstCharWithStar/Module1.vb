Module Module1

    Sub Main()
        Dim S2 As String
        Dim S2F As Char
        Dim myChar As Char

        Console.WriteLine("Enter a statement")
        S2 = Console.ReadLine
        S2F = Left(S2, 1)
        Console.Write(S2F)
        For COUNT = 1 To Len(S2) - 1
            myChar = Mid(S2, (COUNT + 1), 1)
            If myChar = S2F Then
                myChar = "*"
            End If
            Console.Write(myChar)
        Next
        Console.ReadKey()
    End Sub
End Module
