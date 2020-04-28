Module Module1

    Sub Main()
        Dim myChar, thisChar, nextChar As Char
        Dim Highest, Count, i, j As Integer
        Dim Phrase As String

        myChar = ""
        Highest = 0
        Count = 0

        Console.Write("Enter Phrase: ")
        Phrase = Console.ReadLine

        For i = 1 To Len(Phrase)
            nextChar = Mid(Phrase, i, 1)
            Count = 0
            For j = 1 To Len(Phrase)
                thisChar = Mid(Phrase, j, 1)
                If thisChar = nextChar Then Count = Count + 1
            Next

            If Count > Highest Then
                Highest = Count
                myChar = nextChar
            End If
        Next
        Console.WriteLine(myChar & " appeared " & Highest & " number of times.")
        Console.ReadKey()
    End Sub

End Module
