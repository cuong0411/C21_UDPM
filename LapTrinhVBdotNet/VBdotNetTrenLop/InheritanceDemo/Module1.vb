Module Module1

    Sub Main()
        Console.WriteLine("Thong tin nhan vien")
        Dim nv As New CNhanVien
        nv.Nhap()
        nv.Xuat()

        Console.WriteLine("Thong tin nhan vien bien che")
        Dim nvbc As New CBienChe
        nvbc.Nhap()
        nvbc.Xuat()

        Console.WriteLine("Thong tin nhan vien hop dong")
        Dim nvhd As New CHopDong
        nvhd.Nhap()
        nvhd.Xuat()
    End Sub

End Module
