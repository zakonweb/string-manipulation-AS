Module RLE

    Sub Main()
        Dim initial, encoded, decoded As String

        Console.Write("Type something: ")
        initial = Console.ReadLine

        encoded = RLEncode(initial)
        decoded = RLDecode(encoded)

        Console.WriteLine("Initial string: " & initial)
        Console.WriteLine("Compressed/Encoded string using RLE: " & encoded)
        Console.WriteLine("Compressed/Encoded string using RLE: " & decoded)

        Console.ReadKey()
    End Sub


    Function RLDecode(i As String) As String
        Dim Loop0, a As Long
        Dim rCount, outP, m As String
        rCount = ""
        outP = ""
        Loop0 = 0

        For Loop0 = 1 To Len(i)
            m = Mid(i, Loop0, 1)
            Select Case m
                Case "0" To "9" : rCount += m
                Case Else
                    If Len(rCount) > 0 Then
                        For a = 1 To rCount
                            outP += m
                        Next
                        rCount = ""
                    Else
                        outP += m
                    End If
            End Select
        Next
        RLDecode = outP
    End Function

    Function RLEncode(i As String) As String
        Dim tmp1, tmp2, outP As String
        Dim Loop0, rCount As Long
        Loop0 = 0
        rCount = 0
        tmp1 = ""
        tmp2 = ""
        outP = ""

        tmp1 = Mid(i, 1, 1)
        tmp2 = tmp1
        rCount = 1

        For Loop0 = 2 To Len(i)
            tmp1 = Mid(i, Loop0, 1)
            If tmp1 <> tmp2 Then
                outP += Ltrim(Rtrim(Str(rCount))) + tmp2
                tmp2 = tmp1
                rCount = 1
            Else
                rCount += 1
            End If
        Next

        outP += Ltrim(Rtrim(Str(rCount)))
        outP += tmp2
        RLEncode = outP
    End Function
End Module
