Module StrManipulation

    Sub Main()
        'DECLARATIONS
        Dim isValid As Boolean
        Dim myChar As Char
        Dim Str1 As String
        Dim i As Integer

        'initialisations
        isValid = True
        myChar = ""
        Str1 = ""
        i = 0

        'Input
        Console.Write("Enter string to validate: ")
        Str1 = Console.ReadLine

        'PROCESS
        'Length Check
        If Len(Str1) <> 11 Then isValid = False

        'Check fixed position of fixed characters
        If Mid(Str1, 4, 1) <> "-" Or Mid(Str1, 8, 1) <> "-" Then isValid = False

        'GROUP1 "AAA"
        For i = 1 To 3
            myChar = Mid(Str1, i, 1)
            If myChar < "A" Or myChar > "Z" Then isValid = False
        Next

        'GROUP2 "999"
        For i = 5 To 7
            myChar = Mid(Str1, i, 1)
            If myChar < "0" Or myChar > "9" Then isValid = False
        Next

        'GROUP3 "aaa"
        For i = 9 To 11
            myChar = Mid(Str1, i, 1)
            If myChar < "a" Or myChar > "z" Then isValid = False
        Next

        If isValid = True Then
            Console.WriteLine("Entered string is valid.")
        Else
            Console.WriteLine("Entered string is invalid.")
        End If

        Console.ReadKey()
    End Sub

End Module
