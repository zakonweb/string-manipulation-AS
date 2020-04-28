Module Module1

    Sub Main()
        Dim X As String
        Dim C As Char
        Dim Pos As Integer

        Console.Write("Enter X, Format (999+AAAA+aa!)  : ")
        X = Console.ReadLine

        If Len(X) <> 12 Then
            Console.WriteLine("Invalid Format")
            Console.ReadKey()
            End
        End If

        If Mid(X, 4, 1) <> "+" Or _
            Mid(X, 9, 1) <> "+" Or _
            Mid(X, 12, 1) <> "!" Then

            Console.WriteLine("Invalid Format")
            Console.ReadKey()
            End
        End If

        For Pos = 1 To 3
            C = Mid(X, Pos, 1)
            If C < "0" Or C > "9" Then
                Console.WriteLine("Invalid Format")
                Console.ReadKey()
                End
            End If
        Next

        For Pos = 5 To 8
            C = Mid(X, Pos, 1)
            If C < "A" Or C > "Z" Then
                Console.WriteLine("Invalid Format")
                Console.ReadKey()
                End
            End If
        Next

        For Pos = 10 To 11
            C = Mid(X, Pos, 1)
            If C < "a" Or C > "z" Then
                Console.WriteLine("Invalid Format")
                Console.ReadKey()
                End
            End If
        Next

        Console.WriteLine("Valid Format")
        Console.ReadKey()
    End Sub

End Module
