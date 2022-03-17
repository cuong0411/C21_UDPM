Module Module1

    Sub Main()
        Dim a As Integer
        Console.Write("Nhap canh a = ")
        a = Console.ReadLine

        Dim b As Integer
        Console.Write("Nhap canh b = ")
        b = Console.ReadLine

        Dim c As Integer
        Console.Write("Nhap canh c = ")
        c = Console.ReadLine

        If (a > 0) And (b > 0) And (c > 0) Then
            If (a + b > c) And (a + c > b) And (b + c > a) Then
                Dim cv As Integer = a + b + c
                Dim p As Single = cv / 2
                Dim dt As Single

                dt = Math.Sqrt(p * (p - a) * (p - b) * (p - c))

                Console.WriteLine("Chu vi tam giac = {0:0.00}", cv)
                Console.WriteLine("Dien tich tam giac = {0:0.00}", dt)
            Else
                Console.WriteLine("Khong tao thanh tam giac")
            End If
        Else
            Console.WriteLine("Canh cua tam giac phai lon hon 0")
        End If
    End Sub

End Module
