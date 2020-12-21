Module FnLName

    Sub Main()
        'Declaration
        Dim Str1, firstName, lastName As String
        Dim space, Length As Integer

        'Initialisation
        Str1 = ""
        firstName = ""
        lastName = ""
        space = 0
        Length = 0

        'Input
        Console.Write("Enter string to find first and last names: ") 'PROMPT
        Str1 = Console.ReadLine

        'Process
        space = InStr(Str1, " ")
        Length = Len(Str1)
        firstName = Left(Str1, space - 1)
        lastName = Right(Str1, Length - space)

        'Output
        Console.WriteLine("First name = " & firstName)
        Console.WriteLine("Last name = " & lastName)

        Console.ReadKey()
    End Sub

End Module
