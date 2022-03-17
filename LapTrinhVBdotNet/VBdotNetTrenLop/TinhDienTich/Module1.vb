Module Module1

    Sub Main()
        Dim chieuDai As Integer, chieuRong As Integer
        Dim chuVi As Integer, dienTich As ULong

        Console.Write("Nhap chieu dai: ")
        chieuDai = Console.ReadLine
        Console.Write("Nhap chieu rong: ")
        chieuRong = Console.ReadLine

        chuVi = (chieuRong + chieuDai) * 2
        dienTich = chieuDai * chieuRong

        Console.WriteLine("Dien tich cua tu giac dai {0}, rong {1} = {2}", chieuDai, chieuRong, dienTich)
        Console.WriteLine("Chu vi cua tu giac dai {0}, rong {1} = {2}", chieuDai, chieuRong, chuVi)

    End Sub

End Module
