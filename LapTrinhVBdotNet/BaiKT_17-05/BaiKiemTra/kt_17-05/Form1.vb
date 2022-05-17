Public Class FrmCuong
    Private Sub FrmCuong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxChucVu.Items.Add("Giám đốc")
        ComboBoxChucVu.Items.Add("Kế toán")
        ComboBoxChucVu.Items.Add("Kỹ thuật")
        ComboBoxChucVu.Items.Add("Bán hàng")
        ComboBoxChucVu.Items.Add("Nhân viên")

        CheckBoxGioiTinh.Checked = True

        ComboBoxChucVu.SelectedIndex = 3

        ButtonAddLeft.Enabled = False
        ButtonAddRight.Enabled = False
    End Sub

    Private Sub ButtonThemVao_Click(sender As Object, e As EventArgs) Handles ButtonThemVao.Click
        Dim duLieu As String
        Dim gioiTinh As String

        If CheckBoxGioiTinh.Checked = True Then
            gioiTinh = "Nam"
        Else
            gioiTinh = "Nữ"
        End If

        If TextBoxHoTen.TextLength <= 0 Then
            MessageBox.Show("Bạn chưa nhập họ tên")
        ElseIf TextBoxTuoi.TextLength <= 0 Then
            MessageBox.Show("Bạn chưa nhập tuổi")
        ElseIf TextBoxtuoi.Text = 0 Then
            MessageBox.Show("Tuổi không được bằng 0")
        Else
            duLieu = TextBoxHoTen.Text + " - " + TextBoxTuoi.Text + " - " + gioiTinh + " - " + ComboBoxChucVu.SelectedItem
            ListBoxTenDaNhap.Items.Add(duLieu)
            TextBoxHoTen.ResetText()
            TextBoxTuoi.ResetText()

            TextBoxHoTen.Select()
        End If
    End Sub

    Private Sub TextBoxTuoi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTuoi.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Chi nhap so: ", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ButtonAddRight_Click(sender As Object, e As EventArgs) Handles ButtonAddRight.Click
        ListBoxChuyenCongTac.Items.AddRange(ListBoxTenDaNhap.Items)
        ListBoxTenDaNhap.Items.Clear()
    End Sub
    Private Sub ButtonAddLeft_Click(sender As Object, e As EventArgs) Handles ButtonAddLeft.Click
        ListBoxTenDaNhap.Items.AddRange(ListBoxChuyenCongTac.Items)
        ListBoxChuyenCongTac.Items.Clear()
    End Sub

    Private Sub ListBoxTenDaNhap_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTenDaNhap.SelectedIndexChanged
        If ListBoxTenDaNhap.Items.Count > 0 Then
            ButtonAddRight.Enabled = True
        Else
            ButtonAddRight.Enabled = False
        End If
    End Sub
    Private Sub ListBoxChuyenCongTac_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxChuyenCongTac.SelectedIndexChanged
        If ListBoxChuyenCongTac.Items.Count > 0 Then
            ButtonAddLeft.Enabled = True
        Else
            ButtonAddLeft.Enabled = False
        End If
    End Sub

    Private Sub ListBoxTenDaNhap_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxTenDaNhap.DoubleClick
        Dim noiDung As String
        noiDung = ListBoxTenDaNhap.SelectedItem
        ListBoxChuyenCongTac.Items.Add(noiDung)
        ListBoxTenDaNhap.Items.Remove(noiDung)
    End Sub

    Private Sub ListBoxChuyenCongTac_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxChuyenCongTac.DoubleClick
        Dim noiDung As String
        noiDung = ListBoxChuyenCongTac.SelectedItem
        ListBoxTenDaNhap.Items.Add(noiDung)
        ListBoxChuyenCongTac.Items.Remove(noiDung)
    End Sub

    Private Sub FrmCuong_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim i As DialogResult
        i = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If i = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub FrmCuong_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub ButtonKetThuc_Click(sender As Object, e As EventArgs) Handles ButtonKetThuc.Click
        Me.Close()
    End Sub

End Class
