Module Module1

    Sub Main()
        Dim str1, alphaStr As String
        Dim nextChar As Char
        Dim Count As Integer
        Dim isPangram As Boolean

        str1 = ""
        alphaStr = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        nextChar = ""
        Count = 0
        isPangram = True

        Console.Write("Enter String: ")
        str1 = Console.ReadLine
        str1 = UCase(str1)

        For Count = 1 To Len(alphaStr)
            nextChar = Mid(alphaStr, Count, 1)
            If InStr(str1, nextChar) = 0 Then
                isPangram = False
                Exit For
            End If
        Next

        If isPangram = True Then
            Console.WriteLine("Sentense enetred is pangram.")
        Else
            Console.WriteLine("Sentense enetred is NOT pangram.")
        End If
        Console.ReadKey()
    End Sub

End Module
