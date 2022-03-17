Module Module1

    Sub Main()
        Dim x As Integer
        x = 10
        Console.WriteLine("gia tri cua x = " & x)
        Console.WriteLine("gia tri cua x = {0}", x)

        Dim y As Double
        y = 34.454545
        Console.WriteLine("gia tri cua y la {0:0.00}", y) 'dinh dang output

        Dim z As Integer
        Console.Write("Nhap gia tri cua x: ")
        z = Console.ReadLine()
        Console.WriteLine("gia tri cua z la {0}", z)

        'VS 2015
        'Console.ReadKey()
    End Sub

End Module
