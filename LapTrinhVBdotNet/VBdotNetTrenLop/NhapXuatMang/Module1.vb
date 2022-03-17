Module Module1

    Sub Main()
        Dim soPhanTu As Integer
        Dim mang(100) As Integer

        NhapMang(mang, soPhanTu)
        XuatMang(mang, soPhanTu)

        Dim tong As Integer = TinhTongSoNT(mang, soPhanTu)
        Console.WriteLine("Tong cac so nguyen to trong mang la: {0}", tong)

    End Sub

    Private Sub XuatMang(ByVal mang() As Integer, ByVal soPhanTu As Integer)
        For i As Integer = 1 To soPhanTu Step 1
            Console.Write($"{mang(i)} ")
            'Console.Write("{0} ", mang(i))
        Next
        Console.WriteLine()
    End Sub

    Private Sub NhapMang(ByRef mang() As Integer, ByRef soPhanTu As Integer)
        Do
            Console.Write("Nhap so phan tu: ")
            soPhanTu = Console.ReadLine()
        Loop While soPhanTu <= 0
        ReDim mang(soPhanTu)
        For i As Integer = 1 To soPhanTu Step 1
            Console.Write("Nhap phan tu {0}: ", i)
            mang(i) = Console.ReadLine()
        Next
    End Sub

    Private Function TinhTongSoNT(ByVal mang() As Integer, ByVal soPhanTu As Integer) As Integer
        Dim tong As Integer = 0
        For i As Integer = 1 To soPhanTu Step 1
            If LaSoNguyenTo(mang(i)) = True Then
                tong += mang(i)
            End If
        Next
        Return tong
    End Function

    Private Function LaSoNguyenTo(ByVal n As Integer) As Boolean
        Dim kq As Boolean = True
        If n < 2 Then
            kq = False
        ElseIf n = 2 Then
            kq = True
        Else
            Dim i As Integer
            For i = 2 To n - 1 Step 1
                If n Mod i = 0 Then
                    kq = False
                    Exit For
                End If
            Next
        End If
        Return kq
    End Function

End Module
