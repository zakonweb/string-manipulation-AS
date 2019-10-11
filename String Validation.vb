Module Module1

    Sub Main()
        Dim String1 As String = ""
        Dim Format As Boolean = True
        Dim pos As Integer = 0
        Dim chr1 As Char = ""

        Console.Write("Enter the string: ")
        String1 = Console.ReadLine

        If Len(String1) <> 12 Then
            Format = False
        End If

        If Format = True Then
            If Mid(String1, 5, 1) <> "-" Or Mid(String1, 9, 1) Then
                Format = False
            End If
        End If

        If Format = True Then
            For pos = 6 To 8
                chr1 = Mid(String1, pos, 1)
                If chr1 < "0" Or chr1 > "9" Then
                    Format = False
                End If
            Next
        End If

        If Format = True Then
            For pos = 1 To 4
                chr1 = Mid(String1, pos, 1)
                If chr1 < "a" Or chr1 > "z" Then
                    Format = False
                End If
            Next
        End If

        If Format = True Then
            For pos = 10 To 12
                chr1 = Mid(String1, pos, 1)
                If chr1 < "A" Or chr1 > "Z" Then
                    Format = False
                End If
            Next
        End If

        If Format = False Then
            Console.WriteLine("The format is invalid ")
        Else : Console.WriteLine("The format is Valid ")
            Console.ReadKey()
        End If
    End Sub

End Module
