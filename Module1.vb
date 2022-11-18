Module Module1

    Sub Main()
        Dim x, b As String
        Dim a, c As Integer
        Dim thisChar As Char

        x = "ZAFAR ALI KHAN"
        b = "AEIOU"

        For c = 1 To Len(x)
            thisChar = Mid(x, c, 1)
            a = Asc(thisChar)
            Console.WriteLine(thisChar & " = " & a)
        Next

        Console.ReadKey()
    End Sub

End Module