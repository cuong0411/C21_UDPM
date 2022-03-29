Public Class CNhanVien
    Protected maSo As Integer
    Protected hoTen As String
    Public Sub New()
        maSo = 0
        hoTen = ""
    End Sub
    Public Overridable Sub Nhap()
        Console.Write("Nhap ma so nhan vien: ")
        maSo = Console.ReadLine()
        Console.Write("Nhap ho ten nhan vien: ")
        hoTen = Console.ReadLine()
    End Sub
    Public Overridable Sub Xuat()
        Console.WriteLine($"Ma so: {maSo}, ho ten: {hoTen}")
    End Sub
End Class
