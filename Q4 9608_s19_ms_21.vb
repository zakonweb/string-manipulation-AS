Module Module1

    Sub Main()
        Dim InString As String = "  X   Y and  Z"
        Dim NewString As String = ""
        Dim Index As Integer = 0
        Dim AfterSpace As Boolean = False
        Dim NextChar As String = ""
        Const Space = " "

        For Index = 1 To Len(InString)
            NextChar = Mid(InString, Index, 1)
            If AfterSpace = True Then
                If NextChar <> Space Then
                    NewString = NewString & NextChar
                    AfterSpace = False
                End If
            Else
                NewString = NewString & NextChar
                If NextChar = Space Then
                    AfterSpace = True
                End If
            End If
        Next

        Console.WriteLine(NewString)
        Console.ReadKey()
    End Sub

End Module
