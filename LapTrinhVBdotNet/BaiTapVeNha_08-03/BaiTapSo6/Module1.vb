'Kiem tra gio, phut, giay

Module Module1

    Sub Main()
        Dim gio As Integer, phut As Integer, giay As Integer

        Console.Write("Nhap gio = ")
        gio = Console.ReadLine()
        Console.Write("Nhap phut = ")
        phut = Console.ReadLine()
        Console.Write("Nhap giay = ")
        giay = Console.ReadLine()

        KiemTraGio(gio)
        KiemTraPhut(phut)
        KiemTraGiay(giay)

    End Sub

    Private Sub KiemTraGio(ByVal gio As Integer)
        If gio >= 0 And gio <= 23 Then
            Console.WriteLine("Gio hop le")
        Else
            Console.WriteLine("Gio khong hop le")
        End If
    End Sub
    Private Sub KiemTraPhut(ByVal phut As Integer)
        If phut >= 0 And phut <= 59 Then
            Console.WriteLine("Phut hop le")
        Else
            Console.WriteLine("Phut khong hop le")
        End If
    End Sub
    Private Sub KiemTraGiay(ByVal giay As Integer)
        If giay >= 0 And giay <= 59 Then
            Console.WriteLine("Giay hop le")
        Else
            Console.WriteLine("Giay khong hop le")
        End If
    End Sub

End Module
