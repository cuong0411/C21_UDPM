Module Module1

    Sub Main()
        Dim n As Integer
        Do
            Console.Write("Nhap so nguyen duong n = ")
            n = Console.ReadLine
        Loop While n <= 0

        InSoNguyenDuong(n)
        Dim tong As Long = TinhTong(n)
        Dim trungBinhCong As Single = TinhTrungBinhCong(n)

        Console.WriteLine("Tong = {0}", tong)
        Console.WriteLine("Trung binh cong = {0:0.00}", trungBinhCong)
    End Sub
    Private Sub InSoNguyenDuong(ByVal n As Integer)
        Dim i As Integer
        For i = 1 To n Step 1
            Console.Write("{0} ", i)
        Next
        Console.WriteLine()
    End Sub
    Private Function TinhTong(ByVal n As Integer) As Long
        Dim i As Integer, tong As Long
        For i = 1 To n Step 1
            tong += i
        Next
        Return tong
    End Function
    Private Function TinhTrungBinhCong(ByVal n As Integer) As Single
        Dim tong As Long, trungBinhCong As Single
        tong = TinhTong(n)
        trungBinhCong = tong / n
        Return trungBinhCong
    End Function

End Module
