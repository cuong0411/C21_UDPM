'nhap so nguyen n, cho biet n la so chan hay le, am hay khong am

Module Module1

    Sub Main()

        Dim n As Integer
        Console.Write("Nhap so nguyen n: ")
        n = Console.ReadLine

        If n Mod 2 = 0 Then
            Console.WriteLine("n={0} la so chan", n)
        Else
            Console.WriteLine("n={0} la so le", n)
        End If

        If n < 0 Then
            Console.WriteLine("n={0} la so am", n)
        Else
            Console.WriteLine("n={0} la so khong am", n)
        End If

    End Sub

End Module
