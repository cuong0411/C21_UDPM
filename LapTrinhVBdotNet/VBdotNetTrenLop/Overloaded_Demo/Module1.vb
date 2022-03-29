'Overloaded properties and methods
Module Module1

    Sub Main()
        Math.Abs()
        Dim a As New CDemo
        a.ThongBao(1)
        a.ThongBao(True)
        Dim tong As Integer
        tong = a.TinhTong(1, 2, 3)
        Console.WriteLine(tong)
        tong = a.TinhTong(1, 2)
        Console.WriteLine(tong)

        Console.WriteLine(TinhTong(1, 2, 3))
        Console.WriteLine(TinhTong(1, 2))
    End Sub
    Public Function TinhTong(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer) As Integer
        Return a + b + c
    End Function
    Public Function TinhTong(ByVal a As Integer, ByVal b As Integer)
        Return a + b
    End Function

End Module
