Module Module_DSHCN
    Dim mang(30) As CRectangle
    Dim n As Integer
    Public Sub NhapHCN(ByVal hcn As CRectangle)
        Console.Write("Nhap chieu dai: ")
        hcn.SetLength = Console.ReadLine()
        Console.Write("Nhap chieu rong: ")
        hcn.SetWidth = Console.ReadLine()
        Console.Write("Nhap mau cua hcn: ")
        hcn.NhapColor = Console.ReadLine()
        Console.Write("Is filled? ")
        hcn.NhapFilled = Console.ReadLine()
    End Sub

    Public Sub NhapMang(ByVal mang() As CRectangle, ByRef n As Integer)
        Do
            Console.Write("Nhap so phan tu: ")
            n = Console.ReadLine()
        Loop While n <= 0
        ReDim mang(n)
        For i As Integer = 0 To n Step 1
            Console.Write("Nhap phan tu {0}: ", i)
            NhapHCN(mang(i))
        Next
    End Sub
    Public Sub XuatMang(ByVal mang() As CRectangle, ByRef n As Integer)
        For i As Integer = 1 To n Step 1
            Console.WriteLine($"{mang(i).ToString()}")
        Next
        Console.WriteLine()
    End Sub
End Module
