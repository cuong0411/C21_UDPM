Public Class CHCN
    'thuoc tinh
    Private chieuDai As Integer
    Private chieuRong As Integer
    Private dienTich As Integer
    'property
    Property NhapChieuDai As Integer
        Get
            Return chieuDai
        End Get
        Set(value As Integer)
            chieuDai = value
        End Set
    End Property
    Property NhapChieuRong As Integer
        Get
            Return chieuRong
        End Get
        Set(value As Integer)
            chieuRong = value
        End Set
    End Property
    'constructor
    Public Sub New()
        chieuDai = 0
        chieuRong = 0
        dienTich = 0
    End Sub
    Public Sub New(ByVal cd As Integer, ByVal cr As Integer)
        chieuDai = cd
        chieuRong = cr
        dienTich = TinhDT()
    End Sub
    'nhap, xuat hcn
    Public Sub NhapHCN()
        Console.Write("Nhap chieu dai: ")
        chieuDai = Console.ReadLine()
        Console.Write("Nhap chieu rong: ")
        chieuRong = Console.ReadLine()
        dienTich = TinhDT()
    End Sub
    Public Sub XuatHCN()
        Console.WriteLine($"Hinh chu nhat da nhap co: chieu dai = {chieuDai}, chieu rong = {chieuRong} => dt: {dienTich}")
    End Sub
    'tinh dien tich hcn
    Public Function TinhDT() As Integer
        dienTich = chieuDai * chieuRong
        Return dienTich
    End Function
    'so sanh dien tich 2 hcn
    Public Sub SoSanhDT(ByVal dt2)
        If dienTich < dt2 Then
            Console.WriteLine("DT HCN dau tien lon hon")
        ElseIf dienTich = dt2 Then
            Console.WriteLine("DT 2 HCN bang nhau")
        Else
            Console.WriteLine("DT HCN thu hai lon hon")
        End If
    End Sub
End Class
