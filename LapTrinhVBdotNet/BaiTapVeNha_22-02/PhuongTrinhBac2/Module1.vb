Module Module1

    Sub Main()
        Dim a As Integer
        Console.Write("Nhap so a = ")
        a = Console.ReadLine

        Dim b As Integer
        Console.Write("Nhap so b = ")
        b = Console.ReadLine

        Dim c As Integer
        Console.Write("Nhap so c = ")
        c = Console.ReadLine

        If a <> 0 Then
            Dim delta As Single
            delta = Math.Pow(b, 2) - 4 * a * c
            If delta < 0 Then
                Console.WriteLine("Phuong trinh vo nghiem")
            ElseIf delta = 0 Then
                Dim nghiem As Single
                nghiem = -b / (2 * a)
                Console.WriteLine("Phuong trinh co 2 nghiem kep x1 = x2 = {0}", nghiem)
            Else
                Dim nghiem1 As Single
                Dim nghiem2 As Single
                nghiem1 = (-b + Math.Sqrt(delta) / (2 * a))
                nghiem2 = (-b - Math.Sqrt(delta) / (2 * a))
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet:")
                Console.WriteLine("x1 = {0:0.00}", nghiem1)
                Console.WriteLine("x2 = {0:0.00}", nghiem2)
            End If
        Else
            If b = 0 Then
                If c = 0 Then
                    Console.WriteLine("Phuong trinh co vo so nghiem")
                Else
                    Console.WriteLine("Phuong trinh vo nghiem")
                End If
            Else
                Dim nghiem As Single
                nghiem = -c / b
                Console.WriteLine("Phuong trinh co 1 nghiem x = {0:0.00}", nghiem)
            End If
        End If
    End Sub

End Module
