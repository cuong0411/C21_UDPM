Module Module1

    Sub Main()
        Const PI As Single = Math.PI
        Dim x As Integer, a As Single
        Dim sin As Single, cos As Single
        Dim tan As Single, cogtan As Single

        Console.Write("Nhap goc x: ")
        x = Console.ReadLine

        a = (x * PI) / 180

        sin = Math.Sin(a)
        cos = Math.Cos(a)
        tan = Math.Tan(a)
        cogtan = 1 / tan

        Console.WriteLine("sin({0}) = {1}", x, sin)
        Console.WriteLine("cos({0}) = {1}", x, cos)
        Console.WriteLine("tan({0}) = {1}", x, tan)
        Console.WriteLine("cogtan({0}) = {1}", x, cogtan)

    End Sub

End Module
