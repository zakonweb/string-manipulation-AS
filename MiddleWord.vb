Module Module1
Sub main()
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
End Module
