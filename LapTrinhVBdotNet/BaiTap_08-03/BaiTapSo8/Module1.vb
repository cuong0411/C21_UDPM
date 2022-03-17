Module Module1

    Sub Main()
        Dim n As Integer
        Do
            Console.WriteLine("Nhap n > 0")
            Console.Write("n = ")
            n = Console.ReadLine
        Loop While n <= 0
        Dim S1 As Long = TinhTongS1(n)
        Dim S2 As Single = TinhTongS2(n)
        Console.WriteLine("S1 = {0}", S1)
        Console.WriteLine("S2 = {0}", S2)
    End Sub
    Private Function TinhTongS1(ByVal n As Integer) As Long
        Dim i As Integer, tong As Long
        For i = 1 To n Step 1
            tong += i
        Next
        Return tong
    End Function
    Private Function TinhTongS2(ByVal n As Integer) As Single
        Dim i As Integer, tong As Single
        For i = 1 To n Step 1
            tong += 1 / i
        Next
        Return tong
    End Function
End Module
