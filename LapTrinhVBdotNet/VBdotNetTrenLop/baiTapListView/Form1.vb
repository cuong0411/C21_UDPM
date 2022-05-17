Public Class FrmNhanVien
    Private Sub ButtonThem_Click(sender As Object, e As EventArgs) Handles ButtonThem.Click
        If TextBoxHoTen.Text = "" Then
            MessageBox.Show("Phai nhap ho ten")
        ElseIf TextBoxDienThoai.Text = "" Then
            MessageBox.Show("Phai nhap dien thoai")
        ElseIf TextBoxDiaChi.Text = "" Then
            MessageBox.Show("Phai nhap dia chi")
        Else
            Dim lvItem As ListViewItem
            lvItem = ListViewNhanVien.Items.Add(TextBoxHoTen.Text)
            lvItem.SubItems.Add(DateTimePickerNgaySinh.Text)
            lvItem.SubItems.Add(TextBoxDiaChi.Text)
            lvItem.SubItems.Add(TextBoxDienThoai.Text)

            SetNull()
        End If
    End Sub

    'Private Sub ListViewNhanVien_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewNhanVien.SelectedIndexChanged
    '    TextBoxHoTen.Text = ListViewNhanVien.SelectedItems(0).Text
    '    DateTimePickerNgaySinh.Text = ListViewNhanVien.SelectedItems(0).SubItems(1).Text
    '    TextBoxDiaChi.Text = ListViewNhanVien.SelectedItems(0).SubItems(2).Text
    '    TextBoxDienThoai.Text = ListViewNhanVien.SelectedItems(0).SubItems(3).Text
    'End Sub

    Private Sub ListViewNhanVien_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewNhanVien.MouseClick
        TextBoxHoTen.Text = ListViewNhanVien.SelectedItems(0).Text
        DateTimePickerNgaySinh.CustomFormat = ListViewNhanVien.SelectedItems(0).SubItems(1).Text
        TextBoxDiaChi.Text = ListViewNhanVien.SelectedItems(0).SubItems(2).Text
        TextBoxDienThoai.Text = ListViewNhanVien.SelectedItems(0).SubItems(3).Text
        SetControl(False)
    End Sub

    Private Sub ButtonXoa_Click(sender As Object, e As EventArgs) Handles ButtonXoa.Click
        Dim re As DialogResult
        If ListViewNhanVien.SelectedItems.Count > 0 Then
            re = MessageBox.Show("Ban chac xoa khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If re = DialogResult.Yes Then
                ' thuc hien xoa
                ' ListViewNhanVien.Items.RemoveAt(ListViewNhanVien.SelectedItems(0).Index)
                For Each i As ListViewItem In ListViewNhanVien.SelectedItems
                    ListViewNhanVien.Items.Remove(i)
                Next

            End If
        Else
            MessageBox.Show("Ban chua chon dong nao")
        End If

        SetNull()
    End Sub

    Private Sub ButtonSua_Click(sender As Object, e As EventArgs) Handles ButtonSua.Click
        Dim re As DialogResult
        If ListViewNhanVien.SelectedItems.Count > 0 Then
            re = MessageBox.Show("Ban chac sua khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If re = DialogResult.Yes Then
                ' thuc hien sua
                ListViewNhanVien.SelectedItems(0).Text = TextBoxHoTen.Text
                ListViewNhanVien.SelectedItems(0).SubItems(1).Text = DateTimePickerNgaySinh.Text
                ListViewNhanVien.SelectedItems(0).SubItems(2).Text = TextBoxDiaChi.Text
                ListViewNhanVien.SelectedItems(0).SubItems(3).Text = TextBoxDienThoai.Text

            End If
        Else
            MessageBox.Show("Ban chua chon dong nao")
        End If


    End Sub

    Private Sub FrmNhanVien_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim i As DialogResult
        i = MessageBox.Show("Ban co muon dong form hay khong", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If i = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub FrmNhanVien_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        Me.Close()
    End Sub
    Private Sub SetControl(ByVal f As Boolean)
        ButtonThem.Enabled = f
        ButtonXoa.Enabled = Not f
        ButtonSua.Enabled = Not f
    End Sub
    Private Sub SetNull()
        TextBoxHoTen.ResetText()
        TextBoxDienThoai.ResetText()
        TextBoxDiaChi.ResetText()
        DateTimePickerNgaySinh.Value = DateTime.Now
        TextBoxHoTen.Select()
    End Sub

    Private Sub FrmNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetNull()
        SetControl(True)
    End Sub
End Class
