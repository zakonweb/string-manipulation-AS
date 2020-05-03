Module Module1

    Sub Main()
        Dim myStr As String
        Dim b As Integer
        Dim isFound As Boolean = False

        Console.Write("Enter phrase to check Pangram: ")
        myStr = Console.ReadLine
        If Len(myStr) < 26 Then
            Console.WriteLine("It is not Pangram.")
            Console.ReadKey()
        Else
            For b = 65 To 90
                isFound = False
                If InStr(UCase(myStr), Chr(b)) > 0 Then isFound = True
                If isFound = False Then
                    Console.WriteLine("It is not Pangram.")
                    Console.ReadKey()
                    Exit For
                End If
            Next b
            If isFound = True Then
                Console.WriteLine("It is a Pangram.")
                Console.ReadKey()
            End If
        End If
    End Sub


End Module
