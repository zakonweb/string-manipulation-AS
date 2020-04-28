Module Module1

    Sub Main()
        Dim a, rows, col As Integer
        a = 0
        rows = 0
        col = 0

        a = 1
        While a <= 5
            Console.WriteLine(a)
            a = a + 1
        End While

        Console.ReadKey()

        For rows = 1 To 5
            For col = 1 To 5
                Console.Write(rows)
            Next col
            Console.WriteLine()
        Next rows
        Console.ReadKey()

        For rows = 1 To 5
            For col = 1 To rows
                Console.Write(col)
            Next col
            Console.WriteLine()
        Next rows
        Console.ReadKey()

        For rows = 5 To 1 Step -1
            For col = 1 To rows
                Console.Write(rows)
            Next col
            Console.WriteLine()
        Next rows
        Console.ReadKey()

        For rows = 5 To 1 Step -1
            For col = rows To 1 Step -1
                Console.Write(col)
            Next col
            Console.WriteLine()
        Next rows
        Console.ReadKey()

    End Sub

End Module
