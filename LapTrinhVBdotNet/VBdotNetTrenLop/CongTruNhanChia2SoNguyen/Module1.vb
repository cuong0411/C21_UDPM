Module Module1

    Sub Main()
        Dim num1 As Integer
        Dim num2 As Integer
        Dim tong As Integer
        Dim hieu As Integer
        Dim tich As Long
        Dim thuong As Double

        Console.Write("Nhap gia tri cho so nguyen thu nhat: ")
        num1 = Console.ReadLine
        Console.Write("Nhap gia tri cho so nguyen thu hai: ")
        num2 = Console.ReadLine

        tong = num1 + num2
        hieu = num1 - num2
        tich = num1 * num2
        thuong = num1 / num2

        Console.WriteLine("Tong cua {0} va {1} la {2}", num1, num2, tong)
        Console.WriteLine("Hieu cua {0} va {1} la {2}", num1, num2, hieu)
        Console.WriteLine("Tich cua {0} va {1} la {2}", num1, num2, tich)
        Console.WriteLine("Thuong cua {0} va {1} la {2:0.00}", num1, num2, thuong)

    End Sub

End Module
