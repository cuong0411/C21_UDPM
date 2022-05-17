Public Class FrmSinhVien
    Private Sub ButtonCapNhat_Click(sender As Object, e As EventArgs) Handles ButtonCapNhat.Click
        ListBoxLopA.Items.Add(TextBoxNhap.Text)
        TextBoxNhap.ResetText()
        TextBoxNhap.Select()
    End Sub

    Private Sub TextBoxNhap_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNhap.TextChanged
        If TextBoxNhap.TextLength > 0 Then
            ButtonCapNhat.Enabled = True
        Else
            ButtonCapNhat.Enabled = False
        End If
    End Sub

    Private Sub ButtonAddToB_Click(sender As Object, e As EventArgs) Handles ButtonAddToB.Click
        Dim noiDung As String

        If ListBoxLopA.SelectedItem Is Nothing Then
            MessageBox.Show("Xin hay chon", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            For Each noiDung In ListBoxLopA.SelectedItems
                ListBoxLopB.Items.Add(noiDung)
                'ListBoxLopA.Items.Remove(noiDung)
            Next
            'For i As Integer = 0 To ListBoxLopA.SelectedItems.Count - 1 Step 1
            '    noiDung = ListBoxLopA.SelectedItems.Item(i)
            '    ListBoxLopB.Items.Add(noiDung)
            'Next
            For i As Integer = ListBoxLopA.SelectedItems.Count - 1 To 0 Step -1
                ListBoxLopA.Items.Remove(ListBoxLopA.SelectedItems.Item(i))
            Next
        End If

    End Sub

    Private Sub ButtonAddAllToB_Click(sender As Object, e As EventArgs) Handles ButtonAddAllToB.Click
        'For Each noiDung As String In ListBoxLopA.Items
        '    ListBoxLopB.Items.Add(noiDung)
        'Next
        ListBoxLopB.Items.AddRange(ListBoxLopA.Items)
        ListBoxLopA.Items.Clear()
    End Sub

    Private Sub ButtonAddToA_Click(sender As Object, e As EventArgs) Handles ButtonAddToA.Click
        Dim noiDung As String

        If ListBoxLopB.SelectedItem Is Nothing Then
            MessageBox.Show("Xin hay chon", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            For Each noiDung In ListBoxLopB.SelectedItems
                ListBoxLopA.Items.Add(noiDung)
            Next
            For i As Integer = ListBoxLopB.SelectedItems.Count - 1 To 0 Step -1
                ListBoxLopB.Items.Remove(ListBoxLopB.SelectedItems.Item(i))
            Next
        End If
    End Sub

    Private Sub ButtonAddAllToA_Click(sender As Object, e As EventArgs) Handles ButtonAddAllToA.Click
        For Each noiDung As String In ListBoxLopB.Items
            ListBoxLopA.Items.Add(noiDung)
        Next
        ListBoxLopB.Items.Clear()
    End Sub
End Class
