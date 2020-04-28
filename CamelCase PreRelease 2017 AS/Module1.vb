Module Module1

    Sub Main()
        Dim mySTR, myWord, myArr(10) As String
        Dim myChar As Char, i, j As Integer, ArrFinished As Boolean

        Console.Write("Enter CamelCase string: ")
        mySTR = Console.ReadLine

        ArrFinished = False
        i = 1
        myWord = Left(mySTR, 1)

        For j = 2 To Len(mySTR)
            myChar = Mid(mySTR, j, 1)
            If myChar >= "A" And myChar <= "Z" Then
                myArr(i) = myWord
                myWord = myChar
                i += 1
                If i > 10 Then
                    ArrFinished = True
                    Exit For
                End If
            Else
                myWord = myWord & myChar
            End If
        Next
        If ArrFinished = False Then myArr(i) = myWord

        For j = i + 1 To 10
            myArr(j) = "(Empty)"
        Next

        For j = 1 To 10
            Console.WriteLine(myArr(j))
        Next

        Console.ReadKey()
    End Sub

End Module
