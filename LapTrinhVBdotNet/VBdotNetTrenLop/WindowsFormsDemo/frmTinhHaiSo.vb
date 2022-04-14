Public Class frmTinhHaiSo
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles LabelSoThuHai.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSoThuHai.TextChanged

    End Sub

    Private Sub ButtonTinh_Click(sender As Object, e As EventArgs) Handles ButtonTinh.Click
        Dim so1 As Single
        Dim so2 As Single
        Dim kq As Single
        so1 = TextBoxSoThuNhat.Text
        so2 = TextBoxSoThuHai.Text
        kq = so1 + so2
        LabelKetQua.Text = kq
        TextBoxKetQua.Text = kq
        MessageBox.Show("Ket qua tinh: " + kq.ToString(), "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub TextBoxSo1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxSoThuNhat.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True 'không cho người dùng thao tác, không làm gì cả
            MessageBox.Show("Chi nhap so", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub TextBoxSo2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxSoThuHai.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
            MessageBox.Show("Chi nhap so", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub TextBoxKetQua_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxKetQua.KeyPress

    End Sub

    Private Sub TextBoxNumberOnly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNumberOnly.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
            MessageBox.Show("Chi nhap so", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        TextBoxSoThuNhat.ResetText()
        TextBoxSoThuHai.Text = ""
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        End
    End Sub
End Class