Module Module1

    Sub Main()
        Dim myStr, myChar As String
        Dim Counter, vCount As Integer
        Const vowels = "aA"

        myStr = ""
        myChar = ""
        vCount = 0
        Counter = 0

        Console.Write("Enter string to look for vowels: ")
        myStr = Console.ReadLine

        For Counter = 1 To Len(myStr)
            myChar = Mid(myStr, Counter, 1)
            If InStr(vowels, myChar) > 0 Then
                vCount = vCount + 1
            End If
        Next

        Console.WriteLine("Number of vowels in the given string = " & vCount)
        Console.ReadKey()
    End Sub

End Module
