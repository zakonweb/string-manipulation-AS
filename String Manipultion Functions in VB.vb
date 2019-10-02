Module Module1

    Sub Main()
        Dim X As String = "Zafar Ali Khan"
        Dim Y As String = ""
        Dim N As Integer = 0

        N = Len(X)
        Console.WriteLine("Len(X)= " & N)

        Y = Left(X, 5)
        Console.WriteLine("Left(X, 5)= " & Y)

        Y = Right(X, 4)
        Console.WriteLine("Right(X, 4)= " & Y)

        Y = Mid(X, 7, 3)
        Console.WriteLine("Mid(X, 7, 3)= " & Y)

        N = InStr(X, "Kh")
        Console.WriteLine("InStr(X, ""Kh"")= " & N)

        Y = "Beaconhouse " & "School" & " " & "System."
        Console.WriteLine("Y = ""Beaconhouse "" & ""School "" & ""System.  = ""  " & Y)

        N = Asc("Q")
        Console.WriteLine("Asc(""Q"")= " & N)

        Y = Chr(80)
        Console.WriteLine("Chr(80)= " & Y)

        Y = Str(56.54)
        Console.WriteLine("Str(56.54)= " & Y)

        N = Val("123")
        Console.WriteLine("Val(""123"")= " & N)
        Console.ReadKey()


    End Sub

End Module
