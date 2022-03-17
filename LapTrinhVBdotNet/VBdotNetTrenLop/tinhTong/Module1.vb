Module Module1

    Sub Main()
        'Dim N As Integer
        'Console.Write("Nhap vao N: ")
        'N = Console.ReadLine()
        'Tinhtong_1(N)

        Dim num1 As Integer, num2 As Integer
        Console.Write("Nhap num1 = ")
        num1 = Console.ReadLine
        Console.Write("Nhap num2 = ")
        num2 = Console.ReadLine
        Console.WriteLine("2 so truoc khi hoan vi la {0}, {1}", num1, num2)
        HoanVi(num1, num2)
        Console.WriteLine("2 so sau khi hoan vi la {0}, {1}", num1, num2)
    End Sub

    Private Sub Tinhtong_1(ByVal n As Integer)
        Dim i As Integer, s As Long = 0
        For i = 1 To n Step 1
            s += i
        Next
        Console.Write("Ket qua tinh tong tu 1 toi {0} = ", n)
        Console.WriteLine(s)
    End Sub

    Private Sub HoanVi(ByRef num1 As Integer, ByRef num2 As Integer)

        Dim trungGian As Integer
        trungGian = num2
        num2 = num1
        num1 = trungGian

    End Sub
End Module
