'CHO MẢNG SỐ NGUYÊN A, N PHẦN TỬ
'1. TÍNH TRUNG BÌNH CÁC SỐ ÂM CÓ TRONG MẢNG
'2. TÌM SỐ NGUYÊN TỐ LỚN NHẤT
'3. CHO BIẾT SỐ NGUYÊN TỐ ĐẦU TIÊN CÓ TRONG MẢNG

Module Module1

    Sub Main()
        Dim soPhanTu As Integer
        Dim mang(100) As Integer

        NhapMang(mang, soPhanTu)
        XuatMang(mang, soPhanTu)

        Console.WriteLine("Tong cac so am co trong mang la {0:0.00}", TinhTBSoAm(mang, soPhanTu))


        Dim kq As Integer = TimMaxNT(mang, soPhanTu)
        If kq <> -1 Then
            Console.WriteLine("So nguyen to lon nhat co trong mang la {0}", kq)
        Else
            Console.WriteLine("Trong mang khong co so nguyen to")
        End If

        Dim soNT As Integer = TimSoNTDauTien(mang, soPhanTu)
        If soNT <> -1 Then
            Console.WriteLine("So nguyen to dau tien co trong mang la {0}", soNT)
        Else
            Console.WriteLine("Trong mang khong co so nguyen to")
        End If

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
        Console.WriteLine()
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

    Private Function TinhTBSoAm(ByVal mang() As Integer, ByVal soPhanTu As Integer) As Double
        Dim tong As Integer = 0, count As Integer = 0
        For i As Integer = 1 To soPhanTu Step 1
            If mang(i) < 0 Then
                tong += mang(i)
                count += 1
            End If
        Next
        If count = 0 Then
            Return tong
        Else
            Return tong / count
        End If
    End Function

    Private Function TimMaxNT(ByVal mang() As Integer, ByVal soPhanTu As Integer) As Integer
        Dim max As Integer = Integer.MinValue
        Dim tonTaiSoNT As Boolean = False
        For i As Integer = 1 To soPhanTu Step 1
            If LaSoNguyenTo(mang(i)) = True Then
                tonTaiSoNT = True
                If max < mang(i) Then
                    max = mang(i)
                End If
            End If
        Next
        If tonTaiSoNT Then
            Return max
        Else
            Return -1
        End If
    End Function

    Private Function TimSoNTDauTien(ByVal mang() As Integer, ByVal soPhanTu As Integer) As Integer
        Dim soNT As Integer
        Dim tonTaiSoNT As Boolean = False
        For i As Integer = 1 To soPhanTu Step 1
            If LaSoNguyenTo(mang(i)) = True Then
                tonTaiSoNT = True
                soNT = mang(i)
                Exit For
            End If
        Next
        If tonTaiSoNT Then
            Return soNT
        Else
            Return -1
        End If
    End Function
End Module
