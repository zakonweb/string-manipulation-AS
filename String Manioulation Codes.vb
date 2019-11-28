Module Module1
    Sub Main()
        Dim MenuPick As Integer
        Do
            Console.Clear()
            Console.WriteLine("1: Show First name of STR1 and Last name of STR2 together.")
            Console.WriteLine("2: Show after picking Middle word of a STR.")
            Console.WriteLine("3: Show isolated Words of a STR.")
            Console.WriteLine("4: Show a STR after truncating delected Character.")
            Console.WriteLine("5: Inverse a STR.")
            Console.WriteLine("6: Input two STR and determine isAnagram?")
            Console.WriteLine("7: Show isolated Types like letters, numbers or specials.")
            Console.WriteLine("0: To Exit program.")
            MenuPick = Console.ReadLine
            Select Case MenuPick
                Case 0 'This case to avoid Case Else when pressed 0 to Exit
                Case 1 : Call FirstLast()
                Case 2 : Call pickMiddle()
                Case 3 : Call isolateWords()
                Case 4 : Call truncateChar()
                Case 5 : Call InverseSTR()
                Case 6 : Call isAnagram()
                Case 7 : Call isolateTypes()
                Case Else
                    Console.WriteLine("Wrong Choice. Try again or enter 0 to exit.")
                    Console.ReadKey()
            End Select
        Loop Until MenuPick = 0
    End Sub

    Sub FirstLast()
        Dim STR1, STR2, firstName, secondName As String
        Dim SpacePos, lenSTR As Integer
        Console.Write("Enter first string of two words: ")
        STR1 = Console.ReadLine()
        Console.Write("Enter second string of two words: ")
        STR2 = Console.ReadLine()
        SpacePos = InStr(STR1, " ")
        firstName = Left(STR1, SpacePos - 1)
        SpacePos = InStr(STR2, " ")
        lenSTR = Len(STR2)
        secondName = Right(STR2, lenSTR - SpacePos)
        Console.WriteLine(firstName & " " & secondName)
        Console.ReadKey()
    End Sub

    Sub pickMiddle()
        Dim STR1, middleName As String
        Dim SpacePos1, SpacePos2 As Integer
        Console.Write("Enter Name composed of three words: ")
        STR1 = Console.ReadLine()
        SpacePos1 = InStr(STR1, " ")
        SpacePos2 = InStr(SpacePos1 + 1, STR1, " ")
        middleName = Mid(STR1, SpacePos1 + 1, SpacePos2 - SpacePos1 - 1)
        Console.WriteLine(middleName)
        Console.ReadKey()
    End Sub

    Sub isolateWords()
        Dim myWord, STR1, Character As String
        Dim COUNT As Integer
        STR1 = ""
        myWord = ""
        Console.Write("Enter a sentense: ")
        STR1 = Console.ReadLine()
        For COUNT = 1 To Len(STR1)
            Character = Mid(STR1, COUNT, 1)
            If Character <> " " Then
                myWord = myWord & Character
            End If
            If Character = " " Or COUNT = Len(STR1) Then
                Console.WriteLine(myWord)
                myWord = ""
            End If
        Next COUNT
        Console.ReadKey()
    End Sub

    Sub truncateChar()
        Dim STR1, STR2, Character, myWORD As String
        Dim COUNT As Integer
        STR1 = ""
        myWORD = ""
        Console.Write("Enter a string: ")
        STR1 = Console.ReadLine()
        Console.Write("What to truncate: ")
        STR2 = Console.ReadLine()
        For COUNT = 1 To Len(STR1)
            Character = Mid(STR1, COUNT, 1)
            If Character <> STR2 Then
                myWORD = myWORD & Character
            End If
        Next COUNT
        Console.WriteLine(myWORD)
        Console.ReadKey()
    End Sub

    Sub InverseSTR()
        Dim STR1, Character, myWORD As String
        Dim COUNT As Integer
        STR1 = ""
        myWORD = ""
        Console.Write("Enter a string: ")
        STR1 = Console.ReadLine()
        For COUNT = Len(STR1) To 1 Step -1
            Character = Mid(STR1, COUNT, 1)
            myWORD = myWORD & Character
        Next COUNT
        Console.WriteLine(myWORD)
        Console.ReadKey()
    End Sub

    Sub isAnagram()
        Dim STR1, STR2, Character, myWORD As String
        Dim COUNT, Sum1, Sum2 As Integer
        STR1 = ""
        myWORD = ""
        Console.Write("Enter 1st string: ")
        STR1 = Console.ReadLine()
        Console.Write("Enter 2nd string: ")
        STR2 = Console.ReadLine()
        For COUNT = 1 To Len(STR1)
            Character = Mid(STR1, COUNT, 1)
            Sum1 = Sum1 + Asc(Character)
        Next COUNT
        For COUNT = 1 To Len(STR2)
            Character = Mid(STR2, COUNT, 1)
            Sum2 = Sum2 + Asc(Character)
        Next COUNT
        If Sum1 = Sum2 Then
            Console.WriteLine("IT IS ANAGRAM")
        Else
            Console.WriteLine("IT IS NOT ANAGRAM")
        End If
        Console.ReadKey()
    End Sub

    Sub isolateTypes()
        Dim STR1, MY_LTR, Character, MY_NUM, MY_SYM As String
        Dim COUNT As Integer
        STR1 = ""
        MY_LTR = ""
        Character = ""
        MY_NUM = ""
        MY_SYM = ""
        Console.Write("Enter astring: ")
        STR1 = Console.ReadLine()
        For COUNT = 1 To Len(STR1)
            Character = Mid(STR1, COUNT, 1)
            If Asc(UCase(Character)) >= 65 And Asc(UCase(Character)) <= 90 Then
                MY_LTR = MY_LTR & Character
            ElseIf Asc(Character) >= 48 And Asc(Character) <= 57 Then
                MY_NUM = MY_NUM & Character
            Else
                MY_SYM = MY_SYM & Character
            End If
        Next COUNT
        Console.WriteLine("LETTER ARE = " & MY_LTR)
        Console.WriteLine("NUMBERS ARE = " & MY_NUM)
        Console.WriteLine("SYMBOLS ARE = " & MY_SYM)
        Console.ReadKey()
    End Sub

End Module
