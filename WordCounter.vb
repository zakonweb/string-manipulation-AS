Module Module1

    Sub Main()
        Dim myStr, myChar As String
        Dim Counter, wordCount As Integer

        myStr = ""
        myChar = ""
        Counter = 0
        wordCount = 0

        Console.Write("Enter string to count words: ")
        myStr = Console.ReadLine

        For Counter = 1 To Len(myStr)
            myChar = Mid(myStr, Counter, 1)
            If myChar = " " Then
                wordCount = wordCount + 1
            End If
        Next

        If Right(myStr, 1) <> " " Then
            wordCount = wordCount + 1
        End If

        Console.WriteLine("The word count in sentense """ & myStr & """ is = " & wordCount)
        Console.ReadKey()

    End Sub

End Module
