Module Module1

    Sub Main()
        Dim InString, NewString, NextChar As String
        Dim Index, Selected, NewValue As Integer

        NewString = "0"
        Selected = 0

        Console.Write("Enter New String: ")
        InString = Console.ReadLine

        For Index = 1 To Len(InString)
            NextChar = Mid(InString, Index, 1)

            If NextChar < "0" Or NextChar > "9" Then
                NewValue = Val(NewString)

                If NewValue > Selected Then
                    Selected = NewValue
                    Console.WriteLine(Selected)
                End If
                NewString = "0"
            Else
                NewString = NewString & NextChar
            End If
        Next
        Console.WriteLine(Selected)

        Console.ReadKey()
    End Sub
End Module
