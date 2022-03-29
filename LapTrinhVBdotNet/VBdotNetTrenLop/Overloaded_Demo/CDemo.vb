Public Class CDemo
    Overloads Sub ThongBao(ByVal demo As Integer)
        Console.WriteLine("tham so demo la integer, {0}", demo)
    End Sub
    Overloads Sub ThongBao(ByVal demo As Boolean)
        Console.WriteLine("tham so demo la boolean {0}", demo)
    End Sub
    Overloads Function TinhTong(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer) As Integer
        Return a + b + c
    End Function
    Overloads Function TinhTong(ByVal a As Integer, ByVal b As Integer)
        Return a + b
    End Function
End Class
