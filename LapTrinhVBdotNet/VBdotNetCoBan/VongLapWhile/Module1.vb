Module Module1

    Sub Main()
        Dim input As Integer
        Console.Write("Nhap 10 de thoat vong lap: ")
        input = Console.ReadLine

        While input <> 10
            Console.WriteLine("Hay nhap 10 di!")
            input = Console.ReadLine
        End While
        Console.WriteLine("Bai bai")
    End Sub

End Module
