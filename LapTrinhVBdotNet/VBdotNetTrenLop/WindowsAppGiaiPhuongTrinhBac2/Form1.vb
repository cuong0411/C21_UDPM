Public Class FormGiaiPhuongTrinhBac2

    Private Sub TextBoxKiemTraHeSoA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxHeSoA.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." And Not e.KeyChar = "-" Then
            e.Handled = True
            MessageBox.Show("Chi nhap so: ", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If e.KeyChar = Chr(Keys.Enter) Then
            TextBoxHeSoB.Select()
        End If
    End Sub
    Private Sub TextBoxKiemTraHeSoB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxHeSoB.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." And Not e.KeyChar = "-" Then
            e.Handled = True
            MessageBox.Show("Chi nhap so: ", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If e.KeyChar = Chr(Keys.Enter) Then
            TextBoxHeSoC.Select()
        End If
    End Sub
    Private Sub TextBoxKiemTraHeSoC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxHeSoC.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." And Not e.KeyChar = "-" Then
            e.Handled = True
            MessageBox.Show("Chi nhap so: ", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If e.KeyChar = Chr(Keys.Enter) Then
            Call ButtonGiai_Click(sender, e)
        End If
    End Sub

    Private Sub FormGiaiPhuongTrinhBac2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxNghiem1.Enabled = False
        TextBoxNghiem2.Enabled = False
        TextBoxKQ.Enabled = False
        TextBoxHeSoA.Select()
    End Sub

    Private Sub ButtonThoat_Click(sender As Object, e As EventArgs) Handles ButtonThoat.Click
        'Application.Exit()

        Dim re As DialogResult
        re = MessageBox.Show("Ban co muon dong form?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If re = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ButtonTiep_Click(sender As Object, e As EventArgs) Handles ButtonTiep.Click
        TextBoxHeSoA.ResetText()
        TextBoxHeSoB.ResetText()
        TextBoxHeSoC.ResetText()
        TextBoxKQ.ResetText()
        TextBoxNghiem1.ResetText()
        TextBoxNghiem2.ResetText()
        TextBoxHeSoA.Select()
    End Sub

    Private Sub ButtonGiai_Click(sender As Object, e As EventArgs) Handles ButtonGiai.Click
        Dim a As Double = TextBoxHeSoA.Text
        Dim b As Double = TextBoxHeSoB.Text
        Dim c As Double = TextBoxHeSoC.Text
        Dim x1 As Double
        Dim x2 As Double
        Dim delta As Double

        If a = 0 Then
            If b = 0 Then
                If c = 0 Then
                    TextBoxKQ.Text = "Phương trình vô số nghiệm"
                Else
                    TextBoxKQ.Text = "Phương trình vô nghiệm"
                End If
            Else
                x1 = -c / b
                TextBoxKQ.Text = "Phuong trinh co 1 nghiem"
                TextBoxNghiem1.Text = x1
            End If
        Else
            delta = b * b - 4 * a * c
            If delta < 0 Then
                TextBoxKQ.Text = "Phuong trinh vo nghiem"
            ElseIf delta = 0 Then
                x1 = -b / (2 * a)
                TextBoxKQ.Text = "Phuong trinh co 1 nghiem kep"
                TextBoxNghiem1.Text = x1
            Else
                x1 = (-b - Math.Sqrt(delta)) / (2 * a)
                x2 = (-b + Math.Sqrt(delta)) / (2 * a)
                TextBoxKQ.Text = "Phuong trinh co 2 nghiem phan biet"
                TextBoxNghiem1.Text = x1
                TextBoxNghiem2.Text = x2
            End If
        End If
    End Sub

End Class
