Public Class FrmThaotacso
    Private Sub FrmThaotacso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonCapNhat.Enabled = False
        TextBoxNhap.Select()
        'CloseButton()

    End Sub
    Private Function KiemTraListBox() As Boolean
        If (ListBoxSoNguyen.Items.Count > 0) Then
            Return True
        End If
        Return False
    End Function
    Private Sub CloseButton()
        Dim e As Boolean = KiemTraListBox()
        ButtonTangHai.Enabled = e
        ButtonChanDau.Enabled = e
        ButtonLeCuoi.Enabled = e
        ButtonXoaDangChon.Enabled = e
        ButtonXoaDau.Enabled = e
        ButtonXoaCuoi.Enabled = e
    End Sub
    Private Sub ButtonTangHai_Click(sender As Object, e As EventArgs) Handles ButtonTangHai.Click
        Dim length As Integer = ListBoxSoNguyen.Items.Count
        For i As Integer = 0 To length - 1 Step 1
            ListBoxSoNguyen.Items(i) += 2
        Next
    End Sub

    Private Sub ButtonCapNhat_Click(sender As Object, e As EventArgs) Handles ButtonCapNhat.Click
        ListBoxSoNguyen.Items.Add(TextBoxNhap.Text)
        TextBoxNhap.ResetText()
        TextBoxNhap.Select()
    End Sub

    Private Sub ButtonChanDau_Click(sender As Object, e As EventArgs) Handles ButtonChanDau.Click
        'Dim length As Integer = ListBoxSoNguyen.Items.Count
        'Dim flag As Integer = 0
        'For i As Integer = 0 To length - 1 Step 1
        '    If ListBoxSoNguyen.Items(i) Mod 2 = 0 Then
        '        flag = 1
        '        ListBoxSoNguyen.SelectedIndex = i
        '        Exit For
        '    End If
        'Next

        'If flag = 0 Then
        '    MessageBox.Show("Khong co phan tu chan trong list", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If

        'co sua bai
        Dim n As Integer = ListBoxSoNguyen.Items.Count
        For i As Integer = 0 To n Step 1
            If Convert.ToInt32(ListBoxSoNguyen.Items(i)) Mod 2 = 0 Then
                MessageBox.Show(ListBoxSoNguyen.Items(i))
                ListBoxSoNguyen.SelectedIndex = i
                Exit For
            End If
        Next
    End Sub

    Private Sub TextBoxNhap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNhap.KeyPress
        'chi duoc nhap so
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "-" Then
            e.Handled = True
            MessageBox.Show("Chi nhap so: ", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ButtonLeCuoi_Click(sender As Object, e As EventArgs) Handles ButtonLeCuoi.Click
        Dim flag As Integer = 0
        Dim length As Integer = ListBoxSoNguyen.Items.Count
        For i As Integer = length - 1 To 0 Step -1
            If ListBoxSoNguyen.Items(i) Mod 2 <> 0 Then
                flag = 1
                ListBoxSoNguyen.SelectedIndex = i
                Exit For
            End If
        Next

        If flag = 0 Then
            MessageBox.Show("Khong co phan tu le trong list", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ButtonXoaDangChon_Click(sender As Object, e As EventArgs) Handles ButtonXoaDangChon.Click
        If ListBoxSoNguyen.SelectedItem Is Nothing Then
            MessageBox.Show("Xin hay chon so de xoa", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ListBoxSoNguyen.Items.Remove(ListBoxSoNguyen.SelectedItem)
        End If

    End Sub

    Private Sub ButtonXoaDau_Click(sender As Object, e As EventArgs) Handles ButtonXoaDau.Click
        Dim length As Integer = ListBoxSoNguyen.Items.Count
        If length = 0 Then
            MessageBox.Show("Khong co du lieu", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ListBoxSoNguyen.Items.RemoveAt(0)
        End If
    End Sub

    Private Sub ButtonXoaCuoi_Click(sender As Object, e As EventArgs) Handles ButtonXoaCuoi.Click

        Dim length As Integer = ListBoxSoNguyen.Items.Count
        If length = 0 Then
            MessageBox.Show("Khong co du lieu", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ListBoxSoNguyen.Items.RemoveAt(ListBoxSoNguyen.Items.Count - 1)
        End If
    End Sub

    Private Sub ButtonKetThuc_Click(sender As Object, e As EventArgs) Handles ButtonKetThuc.Click
        Me.Close()
    End Sub

    Private Sub FrmThaotacso_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim i As DialogResult
        i = MessageBox.Show("Ban co muon dong form hay khong", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If i = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub FrmThaotacso_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub TextBoxNhap_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNhap.TextChanged
        If TextBoxNhap.TextLength > 0 Then
            ButtonCapNhat.Enabled = True
        Else
            ButtonCapNhat.Enabled = False
        End If
    End Sub
End Class
