'Module Module1

'    Sub Main()
'        Dim hcn1 As New CRectangle(4, 6, "white", True)
'        Console.WriteLine($"Dien tich hcn {hcn1.GetArea()}")
'        Console.WriteLine($"Chu vi hinh hcn {hcn1.GetPerimeter()}")
'        Console.WriteLine(hcn1.ToString())
'    End Sub

'End Module

Module Module1
    Sub Main()
        Dim n As Integer
        Dim mang(30) As CRectangle
        Dim ds As New CDSHCN()
        ds.NhapMang(mang, n)
        ds.XuatMang(mang, n)
    End Sub

End Module
