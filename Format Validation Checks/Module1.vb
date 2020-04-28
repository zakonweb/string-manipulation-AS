Module Module1

    Sub Main()
        Dim NIC, CH As String
        Dim count As Integer
        Dim myAns As String = ""

        Do
            NIC = "" : CH = ""
            'Console.Clear()
            Console.Write("Enter String in Format 99999-AAAAAAA-9 : ")
            NIC = Console.ReadLine

            '1. Length Check
            If Len(NIC) <> 15 Then
                Console.WriteLine("Not Valid")
                Console.ReadKey()

                GoTo comehere
            End If

            '2. Identify fixed positions and check for them
            If Mid(NIC, 6, 1) <> "-" Or _
               Mid(NIC, 14, 1) <> "-" Then

                Console.WriteLine("Not Valid")
                Console.ReadKey()
                GoTo comehere
            End If

            '3. Identify Groups and check for them.
            For count = 1 To 5
                CH = Mid(NIC, count, 1)
                If CH < "0" Or CH > "9" Then
                    Console.WriteLine("Not Valid")
                    Console.ReadKey()
                    GoTo comehere
                End If
            Next count

            For count = 7 To 13
                CH = Mid(NIC, count, 1)
                If CH >= "A" And CH <= "Z" Then
                Else
                    Console.WriteLine("Not Valid")
                    Console.ReadKey()
                    GoTo comehere
                End If
            Next count

            For count = 15 To 15
                CH = Mid(NIC, count, 1)
                If CH >= "0" And CH <= "9" Then
                Else
                    Console.WriteLine("Not Valid")
                    Console.ReadKey()
                    GoTo comehere
                End If
            Next count

            Console.WriteLine("Valid String")
            Console.ReadKey()

comeHere:
            Console.Write("Again? (Y/N)")
            myAns = Console.ReadLine
        Loop Until UCase(myAns) = "N"
    End Sub

End Module
