'Count the number of 2s as digit in all numbers from 0 to n.

'Input:
'The first line of input contains an integer T denoting the number of test cases. Then T test cases follow. Each test case contains the input integer n.

'Output:
'Print the count of the number of 2s as digit in all numbers from 0 to n.

'Constraints:
'1<=T<=100
'1<=N<=10^5

'Example:
'Input:
'2
'22
'100

'Output:
'6
'20
Module Module1

    Sub Main()
        Dim testCases As Integer = 0
        Dim count0 As Integer = 0
        Dim count1 As Integer = 0
        Dim count3 As Integer = 0
        Dim countOf2 As Integer = 0
        Dim inputCount As Integer = 0
        Dim numStr As String = ""
        Dim i As Char = ""
        Dim ansLst(100) As Integer
        Dim arrPos As Integer = 0

        Console.WriteLine("Input:")
        testCases = Console.ReadLine

        For count0 = 1 To testCases
            inputCount = Console.ReadLine
            countOf2 = 0

            For count1 = 0 To inputCount
                numStr = Trim(Str(count1))
                For count3 = 1 To Len(numStr)
                    i = Mid(numStr, count3, 1)
                    If i = "2" Then countOf2 += 1
                Next
            Next

            If countOf2 > 0 Then
                ansLst(arrPos) = countOf2
                arrPos += 1
            End If
        Next

        Console.WriteLine("Output:")
        For count3 = 0 To arrPos - 1
            Console.WriteLine(ansLst(count3))
        Next

        Console.ReadKey()
    End Sub

End Module
