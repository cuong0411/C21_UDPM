Module Module1

    Sub Main()
        Dim kq As Long, n As Integer, m As Integer
        Do
            Console.Write("Nhap n = ")
            n = Console.ReadLine
            Console.Write("Nhap m = ")
            m = Console.ReadLine
        Loop While n > m
        kq = TinhTongGiaThua(n, m)
        Console.WriteLine("Tong gia thua tu {0} toi {1} la {2}", n, m, kq)
    End Sub
    Private Function TinhGiaThua(ByVal n As Integer) As Long
        Dim i As Integer, tich As Long = 1
        For i = 1 To n Step 1
            tich *= i
        Next
        Return tich
        'tinhGiaThua = tong
    End Function
    Private Function TinhTongGiaThua(ByVal n As Integer, ByVal m As Integer) As Long
        Dim i As Integer, tong As Long = 0
        For i = n To m Step 1
            tong += TinhGiaThua(i)
        Next
        Return tong
    End Function

End Module
