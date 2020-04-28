Module Module1

    Sub Main()
        Dim STR1, STR2, STR3 As String
        Dim nextChar1, nextChar2 As Char
        Dim hasChanged As Boolean
        Dim C1, C2 As Integer

        STR1 = ""
        STR2 = ""
        STR3 = ""
        nextChar1 = ""
        nextChar2 = ""
        hasChanged = False

        Console.Write("Enter String 1: ")
        STR1 = Console.ReadLine
        STR1 = UCase(STR1)

        Console.Write("Enter String 2: ")
        STR2 = Console.ReadLine
        STR2 = UCase(STR2)

        If Len(STR1) = Len(STR2) Then
            For C1 = 1 To Len(STR1)
                nextChar1 = Mid(STR1, C1, 1)
                STR3 = ""
                hasChanged = False
                For C2 = 1 To Len(STR2)
                    nextChar2 = Mid(STR2, C2, 1)
                    If nextChar2 <> nextChar1 Then
                        STR3 = STR3 & nextChar2
                    Else
                        If hasChanged = False Then
                            hasChanged = True
                        Else
                            STR3 = STR3 & nextChar1
                        End If
                    End If
                Next
                STR2 = STR3
            Next
        End If
        If STR2 = "" Then
            Console.WriteLine("It is ANAGRAM.")
        Else
            Console.WriteLine("It is NOT ANAGRAM.")
        End If
        Console.ReadKey()
    End Sub
End Module
