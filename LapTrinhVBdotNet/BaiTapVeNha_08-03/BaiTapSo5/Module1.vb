'Nhap so nguyen duong n, tinh tong cac uoc so duong cua n

Module Module1

    Sub Main()
        Dim n As Integer
        Do
            Console.Write("Nhap n > 0: ")
            n = Console.ReadLine()
        Loop While n <= 0
        InUoc(n)
        Console.WriteLine("Tong cac uoc so cua n = {0} la {1}", n, TinhUoc(n))
    End Sub
    Private Function TinhUoc(ByVal n As Integer) As Long
        Dim i As Integer, tong As Long = 0
        For i = 1 To n Step 1
            If n Mod i = 0 Then
                tong += i
            End If
        Next
        Return tong
    End Function
    Private Sub InUoc(ByVal n As Integer)
        Dim i As Integer
        For i = 1 To n Step 1
            If n Mod i = 0 Then
                Console.Write("{0} ", i)
            End If
        Next
        Console.WriteLine()
    End Sub
End Module
