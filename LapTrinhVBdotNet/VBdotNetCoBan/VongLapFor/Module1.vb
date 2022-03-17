Module Module1

    Sub Main()
        For i As Integer = 0 To 30 Step 3
            If i Mod 2 = 0 Then
                Continue For
            ElseIf i Mod 9 = 0 Then
                Exit For
            Else
                Console.WriteLine("gia tri cua i: {0}", i)
            End If
        Next
    End Sub

End Module
