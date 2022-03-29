Public Class CBienChe
    Inherits CNhanVien
    Private heSoLuong As Double
    Public Sub New()
        MyBase.New()
        heSoLuong = 0
    End Sub
    Public Overrides Sub Nhap()
        MyBase.Nhap()
        Console.Write("Nhap he so luong: ")
        heSoLuong = Console.ReadLine()
    End Sub
    Public Overrides Sub Xuat()
        MyBase.Xuat()
        Console.WriteLine($"He so luong: {heSoLuong}")
    End Sub
End Class
