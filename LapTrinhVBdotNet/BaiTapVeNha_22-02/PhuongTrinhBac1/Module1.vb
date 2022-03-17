Module Module1

    Sub Main()
        Dim a As Integer, b As Integer
        Dim nghiem As Single

        Console.Write("Nhap so a = ")
        a = Console.ReadLine
        Console.Write("Nhap so b = ")
        b = Console.ReadLine

        If a = 0 Then
            If b = 0 Then
                Console.WriteLine("Phuong trinh co vo so nghiem")
            Else
                Console.WriteLine("Phuong trinh vo nghiem")
            End If
        Else
            nghiem = -b / a
            Console.WriteLine("Nghiem cua phuong trinh la x = {0:0.00}", nghiem)
        End If
    End Sub

End Module
