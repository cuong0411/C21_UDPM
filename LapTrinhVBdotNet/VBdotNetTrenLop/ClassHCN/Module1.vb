﻿'BTVN 22/03
Module Module1

    Sub Main()
        Dim hcn1 = New CHCN()
        hcn1.NhapHCN()
        hcn1.XuatHCN()

        Dim hcn2 = New CHCN()
        hcn2.NhapChieuDai = 5
        hcn2.NhapChieuRong = 3
        hcn2.XuatHCN()

        Dim hcn3 = New CHCN()
        hcn3.XuatHCN()

        Dim hcn4 = New CHCN(10, 4)
        hcn4.XuatHCN()

    End Sub

End Module
