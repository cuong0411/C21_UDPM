Public Class FrmCuong
    Private Sub FrmCuong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxSDH.Text = "DH0012N"
        TextBoxKH.Text = "Dương Thành Phết"
        DateTimePickerND.Value = "25/08/2013"
        TextBoxDiaChi.Text = "Q8, TP.HCM"

        Dim lvItem As ListViewItem
        lvItem = ListViewDDH.Items.Add(TextBoxSDH.Text)
        lvItem.SubItems.Add(DateTimePickerND.Text)
        lvItem.SubItems.Add(TextBoxKH.Text)
        lvItem.SubItems.Add(TextBoxDiaChi.Text)
    End Sub

    Private Sub ListViewDDH_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewDDH.MouseClick
        TextBoxSDH.Text = ListViewDDH.SelectedItems(0).Text
        DateTimePickerND.Value = ListViewDDH.SelectedItems(0).SubItems(1).Text
        TextBoxKH.Text = ListViewDDH.SelectedItems(0).SubItems(2).Text
        TextBoxDiaChi.Text = ListViewDDH.SelectedItems(0).SubItems(3).Text
    End Sub

    Private Sub ButtonSua_Click(sender As Object, e As EventArgs) Handles ButtonSua.Click
        Dim re As DialogResult
        If ListViewDDH.SelectedItems.Count > 0 Then
            re = MessageBox.Show("Ban chac sua khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If re = DialogResult.Yes Then
                ListViewDDH.SelectedItems(0).Text = TextBoxSDH.Text
                ListViewDDH.SelectedItems(0).SubItems(1).Text = DateTimePickerND.Text
                ListViewDDH.SelectedItems(0).SubItems(2).Text = TextBoxKH.Text
                ListViewDDH.SelectedItems(0).SubItems(3).Text = TextBoxDiaChi.Text

            End If
        Else
            MessageBox.Show("Bạn chưa chọn dòng nào!")
        End If
    End Sub
    Private Sub ResetTextBox()
        TextBoxSDH.ResetText()
        TextBoxKH.ResetText()
        DateTimePickerND.Value = "25/08/2013"
        TextBoxDiaChi.ResetText()
    End Sub
    Private Sub ButtonThem_Click(sender As Object, e As EventArgs) Handles ButtonThem.Click
        If TextBoxSDH.Text = "" Then
            MessageBox.Show("Phải nhập số đơn hàng")
        ElseIf TextBoxKH.Text = "" Then
            MessageBox.Show("Phải nhập họ tên khách hàng")
        ElseIf TextBoxDiaChi.Text = "" Then
            MessageBox.Show("Phải nhập địa chỉ")
        Else
            Dim lvItem As ListViewItem
            lvItem = ListViewDDH.Items.Add(TextBoxSDH.Text)
            lvItem.SubItems.Add(DateTimePickerND.Text)
            lvItem.SubItems.Add(TextBoxKH.Text)
            lvItem.SubItems.Add(TextBoxDiaChi.Text)
            ResetTextBox()
        End If
    End Sub
    Private Sub ButtonXoa_Click(sender As Object, e As EventArgs) Handles ButtonXoa.Click
        Dim re As DialogResult
        If ListViewDDH.SelectedItems.Count > 0 Then
            re = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If re = DialogResult.Yes Then
                For Each i As ListViewItem In ListViewDDH.SelectedItems
                    ListViewDDH.Items.Remove(i)
                Next
            End If
            ResetTextBox()
        Else
            MessageBox.Show("Bạn chưa chọn dòng nào!")
        End If
    End Sub

    Private Sub ButtonThoat_Click(sender As Object, e As EventArgs) Handles ButtonThoat.Click
        Me.Close()
    End Sub

    Private Sub FrmCuong_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim i As DialogResult
        i = MessageBox.Show("Bạn có muốn đóng form không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If i = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub FrmCuong_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

End Class
