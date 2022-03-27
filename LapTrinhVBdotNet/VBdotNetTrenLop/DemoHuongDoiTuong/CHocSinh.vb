Public Class CHocSinh
    ' Fields
    Private hoTen As String
    Private diemToan As Single
    Private diemVan As Single
    Private diemTB As Single
    ' Property
    Property _hoTen() As String
        Set(value As String)
            hoTen = value
        End Set
        Get
            Return hoTen
        End Get
    End Property
    Property _diemToan() As Single
        Set(value As Single)
            diemToan = value
        End Set
        Get
            Return diemToan
        End Get
    End Property
    Property _diemVan() As Single
        Set(value As Single)
            diemVan = value
        End Set
        Get
            Return diemVan
        End Get
    End Property
    Property _diemTB() As Single
        Set(value As Single)
            diemTB = value
        End Set
        Get
            Return diemTB
        End Get
    End Property
    ' constructor khong tham so
    Public Sub New()
        hoTen = "Ana"
        diemToan = 5
        diemVan = 4
        diemTB = 4.5
    End Sub
    ' constructor co 1 tham so
    Public Sub New(ByVal a As Integer)
        hoTen = "Ana"
        diemToan = a
        diemVan = 4
        diemTB = 4.5
    End Sub
    ' Methods
    Public Sub nhapThongTin()
        ' Cac lenh nhap
        Console.Write("Nhap ho ten: ")
        hoTen = Console.ReadLine()
        Console.Write("Nhap diem van: ")
        diemVan = Console.ReadLine()
        Console.Write("Nhap diem toan: ")
        diemToan = Console.ReadLine()
        diemTB = (diemVan + diemToan) / 2
    End Sub

    Public Sub xuatThongTin()
        ' Cac lenh xuat
        Console.WriteLine($"Thong tin da nhap la: {hoTen}, toan: {diemToan:0.00}, van: {diemVan:0.00}, diemTB: {diemTB:0.00}")
        'Console.WriteLine("Thong tin da nhap la: {0}, toan: {1:0.0}, van: {2:0.0}, dtb: {3:0.0}",
        'hoTen, diemVan, diemToan, diemTB)
    End Sub

End Class
