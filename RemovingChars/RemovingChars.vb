Module Module1

    Sub Main()
        Dim myStr, finalStr, myChar, nextChar As String
        Dim Index As Integer

        myStr = ""
        finalStr = ""
        myChar = ""
        nextChar = ""
        Index = 0

        Console.Write("Enter string: ")
        myStr = Console.ReadLine

        Console.Write("Enter character to remove: ")
        myChar = Console.ReadLine

        For Index = 1 To Len(myStr)
            nextChar = Mid(myStr, Index, 1)
            If nextChar <> myChar Then
                finalStr = finalStr & nextChar
            End If
        Next

        Console.WriteLine("Final string is = " & finalStr)
        Console.ReadKey()
    End Sub

End Module
