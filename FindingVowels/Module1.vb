Module Module1

    Sub Main()
        Dim x As String
        Dim i, a, y As Integer
        Dim thisChar As Char

        Console.Write("Enter String: ")
        x = Console.ReadLine

        For i = 1 To Len(x)
            thisChar = Mid(x, i, 1)
            y = InStr("AEIOU", UCase(thisChar))
            If y > 0 Then a += 1
        Next

        Console.WriteLine("Number of vowels: " & a)
        Console.ReadKey()
    End Sub

End Module
