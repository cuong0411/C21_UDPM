'tim USCLN va BSCNN cua 2 so nguyen duong a, b

Module Module1

    Sub Main()
        Dim a As Integer, b As Integer
        Do
            Console.Write("Nhap a = ")
            a = Console.ReadLine()
            Console.Write("Nhap b = ")
            b = Console.ReadLine()
        Loop While a <= 0 Or b <= 0

        Console.WriteLine("USCLN cua a = {0} va b = {1} la {2}", a, b, TimUSCLN(a, b))
        Console.WriteLine("BSCNN cua a = {0} va b = {1} la {2}", a, b, TimBSCNN(a, b))

    End Sub

    Private Function TimUSCLN(ByVal a As Integer, ByVal b As Integer) As Integer
        Dim min As Integer, i As Integer, uscln As Integer
        min = If((a < b), a, b)
        For i = 1 To min Step 1
            If a Mod i = 0 And b Mod i = 0 Then
                uscln = i
            End If
        Next
        Return uscln
    End Function

    Private Function TimBSCNN(ByVal a As Integer, ByVal b As Integer) As Integer
        Dim max As Integer, i As Integer, bscnn As Integer
        max = If((a > b), a, b)
        For i = max To a * b Step 1
            If i Mod a = 0 And i Mod b = 0 Then
                bscnn = i
                Exit For
            End If
        Next
        Return bscnn
    End Function
End Module
