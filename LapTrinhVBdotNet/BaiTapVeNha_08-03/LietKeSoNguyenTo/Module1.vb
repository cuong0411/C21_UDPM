Module Module1

    Sub Main()
        Dim n As Integer
        Do
            Console.Write("Nhap n = ")
            n = Console.ReadLine()
        Loop While n <= 0
        InSoNguyenTo(n)
    End Sub

    Private Function LaSoNguyenTo(ByVal n As Integer) As Boolean
        Dim kq As Boolean = True
        If n < 2 Then
            kq = False
        ElseIf n = 2 Then
            kq = True
        Else
            Dim i As Integer
            For i = 2 To n - 1 Step 1
                If n Mod i = 0 Then
                    kq = False
                    Exit For
                End If
            Next
        End If
        Return kq
    End Function
    Private Sub InSoNguyenTo(ByVal n As Integer)
        Dim i As Integer
        For i = 1 To n Step 1
            If LaSoNguyenTo(i) = True Then
                Console.Write("{0} ", i)
            End If
        Next
        Console.WriteLine()
    End Sub

End Module
