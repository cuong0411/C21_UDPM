Module Module1

    Sub Main()
        Dim hsA As New CHocSinh
        hsA.nhapThongTin()
        hsA.xuatThongTin()

        Dim hsB As New CHocSinh
        hsB._hoTen = "Cuong"
        hsB._diemToan = 9.0
        hsB._diemVan = 6.5
        hsB._diemTB = 5.0
        hsB.xuatThongTin()

        Dim hsC As New CHocSinh
        hsC.xuatThongTin()

        Dim hsD As New CHocSinh(10.0)
        hsD.xuatThongTin()
    End Sub

End Module
