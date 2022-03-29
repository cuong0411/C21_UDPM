Public Class CHopDong
    Inherits CNhanVien
    Private soGio As Integer
    Public Sub New()
        MyBase.New()
        soGio = 0
    End Sub
    Public Overrides Sub Nhap()
        MyBase.Nhap()
        Console.Write("Nhap so gio lam viec: ")
        soGio = Console.ReadLine()
    End Sub
    Public Overrides Sub Xuat()
        MyBase.Xuat()
        Console.WriteLine($"So gio lam viec: {soGio}")
    End Sub
End Class
