Module Module1

    Sub Main()
        Dim X As String = "Zafar Ali Khan"
        Dim Y As String = ""
        Dim N As Integer = 0

        N = Len(X)
        Console.WriteLine("Len(X)= " & N)
        Console.ReadKey()

        Y = Left(X, 5)
        Console.WriteLine("Left(X, 5)= " & Y)
        Console.ReadKey()

        Y = Right(X, 4)
        Console.WriteLine("Right(X, 4)= " & Y)
        Console.ReadKey()

        Y = Mid(X, 7, 3)
        Console.WriteLine("Mid(X, 7, 3)= " & Y)
        Console.ReadKey()

        N = InStr(X, "Kh")
        Console.WriteLine("InStr(X, ""Kh"")= " & N)
        Console.ReadKey()

        Y = "Beaconhouse " & "School" & " " & "System."
        Console.WriteLine("Y = ""Beaconhouse "" & ""School "" & ""System.  = ""  " & Y)
        Console.ReadKey()

        N = Asc("Q")
        Console.WriteLine("Asc(""Q"")= " & N)
        Console.ReadKey()

        Y = Chr(80)
        Console.WriteLine("Chr(80)= " & Y)
        Console.ReadKey()

        Y = Str(56.54)
        Console.WriteLine("Str(56.54)= " & Y)
        Console.ReadKey()

        N = Val("123")
        Console.WriteLine("Val(""123"")= " & N)
        Console.ReadKey()


    End Sub

End Module
