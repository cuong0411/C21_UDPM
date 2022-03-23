Module Module1

    Sub Main()

        Dim chuoi1 = "Lap trinh VB.Net"
        Console.WriteLine("Do dai chuoi1 la {0}", chuoi1.Length)
        Console.WriteLine("Chuoi1 viet in hoa: " + chuoi1.ToUpper)
        Console.WriteLine("Chuoi1 viet thuong: " + chuoi1.ToLower)

        Dim ngay As String = "01-01-2022"
        Dim mangMgay() As String = Split(ngay, "-")
        For i As Integer = 0 To mangMgay.Length - 1 Step 1
            Console.Write("{0} ", mangMgay(i))
        Next
        Console.WriteLine()

        Dim Ngay2 As String = Join(mangMgay, "/")
        Console.WriteLine(Ngay2)

        Console.WriteLine("Vi tri chuoi 'VB.net' trong 'Lap trinh VB.Net' la {0}",
                          InStr(chuoi1, "VB.Net", CompareMethod.Text))

        Dim chuoi2 As String = "VB.Net"
        Dim chuoi3 As String = "Java"
        chuoi1 = chuoi1.Replace(chuoi2, chuoi3)
        Console.WriteLine(chuoi1)

    End Sub

End Module
