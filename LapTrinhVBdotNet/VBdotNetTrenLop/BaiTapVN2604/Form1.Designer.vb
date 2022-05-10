<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmThaotacso
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelNhap = New System.Windows.Forms.Label()
        Me.TextBoxNhap = New System.Windows.Forms.TextBox()
        Me.ButtonCapNhat = New System.Windows.Forms.Button()
        Me.GroupBoxChucNang = New System.Windows.Forms.GroupBox()
        Me.ButtonXoaCuoi = New System.Windows.Forms.Button()
        Me.ButtonXoaDau = New System.Windows.Forms.Button()
        Me.ButtonXoaDangChon = New System.Windows.Forms.Button()
        Me.ButtonLeCuoi = New System.Windows.Forms.Button()
        Me.ButtonChanDau = New System.Windows.Forms.Button()
        Me.ButtonTangHai = New System.Windows.Forms.Button()
        Me.ButtonKetThuc = New System.Windows.Forms.Button()
        Me.ListBoxSoNguyen = New System.Windows.Forms.ListBox()
        Me.GroupBoxChucNang.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelNhap
        '
        Me.LabelNhap.Location = New System.Drawing.Point(72, 60)
        Me.LabelNhap.Name = "LabelNhap"
        Me.LabelNhap.Size = New System.Drawing.Size(179, 57)
        Me.LabelNhap.TabIndex = 0
        Me.LabelNhap.Text = "Nhập số nguyên:"
        Me.LabelNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxNhap
        '
        Me.TextBoxNhap.Location = New System.Drawing.Point(294, 60)
        Me.TextBoxNhap.Name = "TextBoxNhap"
        Me.TextBoxNhap.Size = New System.Drawing.Size(401, 31)
        Me.TextBoxNhap.TabIndex = 1
        '
        'ButtonCapNhat
        '
        Me.ButtonCapNhat.Location = New System.Drawing.Point(765, 60)
        Me.ButtonCapNhat.Name = "ButtonCapNhat"
        Me.ButtonCapNhat.Size = New System.Drawing.Size(205, 57)
        Me.ButtonCapNhat.TabIndex = 2
        Me.ButtonCapNhat.Text = "Cập nhật"
        Me.ButtonCapNhat.UseVisualStyleBackColor = True
        '
        'GroupBoxChucNang
        '
        Me.GroupBoxChucNang.Controls.Add(Me.ButtonXoaCuoi)
        Me.GroupBoxChucNang.Controls.Add(Me.ButtonXoaDau)
        Me.GroupBoxChucNang.Controls.Add(Me.ButtonXoaDangChon)
        Me.GroupBoxChucNang.Controls.Add(Me.ButtonLeCuoi)
        Me.GroupBoxChucNang.Controls.Add(Me.ButtonChanDau)
        Me.GroupBoxChucNang.Controls.Add(Me.ButtonTangHai)
        Me.GroupBoxChucNang.Location = New System.Drawing.Point(474, 202)
        Me.GroupBoxChucNang.Name = "GroupBoxChucNang"
        Me.GroupBoxChucNang.Size = New System.Drawing.Size(496, 519)
        Me.GroupBoxChucNang.TabIndex = 3
        Me.GroupBoxChucNang.TabStop = False
        Me.GroupBoxChucNang.Text = "Chức năng"
        '
        'ButtonXoaCuoi
        '
        Me.ButtonXoaCuoi.Location = New System.Drawing.Point(51, 445)
        Me.ButtonXoaCuoi.Name = "ButtonXoaCuoi"
        Me.ButtonXoaCuoi.Size = New System.Drawing.Size(408, 59)
        Me.ButtonXoaCuoi.TabIndex = 5
        Me.ButtonXoaCuoi.Text = "Xóa phần tử cuối"
        Me.ButtonXoaCuoi.UseVisualStyleBackColor = True
        '
        'ButtonXoaDau
        '
        Me.ButtonXoaDau.Location = New System.Drawing.Point(51, 365)
        Me.ButtonXoaDau.Name = "ButtonXoaDau"
        Me.ButtonXoaDau.Size = New System.Drawing.Size(408, 59)
        Me.ButtonXoaDau.TabIndex = 4
        Me.ButtonXoaDau.Text = "Xóa phần tử đầu"
        Me.ButtonXoaDau.UseVisualStyleBackColor = True
        '
        'ButtonXoaDangChon
        '
        Me.ButtonXoaDangChon.Location = New System.Drawing.Point(51, 288)
        Me.ButtonXoaDangChon.Name = "ButtonXoaDangChon"
        Me.ButtonXoaDangChon.Size = New System.Drawing.Size(408, 59)
        Me.ButtonXoaDangChon.TabIndex = 3
        Me.ButtonXoaDangChon.Text = "Xóa phần tử đang chọn"
        Me.ButtonXoaDangChon.UseVisualStyleBackColor = True
        '
        'ButtonLeCuoi
        '
        Me.ButtonLeCuoi.Location = New System.Drawing.Point(51, 203)
        Me.ButtonLeCuoi.Name = "ButtonLeCuoi"
        Me.ButtonLeCuoi.Size = New System.Drawing.Size(408, 59)
        Me.ButtonLeCuoi.TabIndex = 2
        Me.ButtonLeCuoi.Text = "Chọn số lẻ cuối"
        Me.ButtonLeCuoi.UseVisualStyleBackColor = True
        '
        'ButtonChanDau
        '
        Me.ButtonChanDau.Location = New System.Drawing.Point(51, 118)
        Me.ButtonChanDau.Name = "ButtonChanDau"
        Me.ButtonChanDau.Size = New System.Drawing.Size(408, 59)
        Me.ButtonChanDau.TabIndex = 1
        Me.ButtonChanDau.Text = "Chọn số chẵn đầu"
        Me.ButtonChanDau.UseVisualStyleBackColor = True
        '
        'ButtonTangHai
        '
        Me.ButtonTangHai.Location = New System.Drawing.Point(51, 42)
        Me.ButtonTangHai.Name = "ButtonTangHai"
        Me.ButtonTangHai.Size = New System.Drawing.Size(408, 59)
        Me.ButtonTangHai.TabIndex = 0
        Me.ButtonTangHai.Text = "Tăng mỗi phần tử lên hai"
        Me.ButtonTangHai.UseVisualStyleBackColor = True
        '
        'ButtonKetThuc
        '
        Me.ButtonKetThuc.Location = New System.Drawing.Point(77, 750)
        Me.ButtonKetThuc.Name = "ButtonKetThuc"
        Me.ButtonKetThuc.Size = New System.Drawing.Size(893, 43)
        Me.ButtonKetThuc.TabIndex = 4
        Me.ButtonKetThuc.Text = "Kết thúc"
        Me.ButtonKetThuc.UseVisualStyleBackColor = True
        '
        'ListBoxSoNguyen
        '
        Me.ListBoxSoNguyen.FormattingEnabled = True
        Me.ListBoxSoNguyen.ItemHeight = 25
        Me.ListBoxSoNguyen.Location = New System.Drawing.Point(77, 202)
        Me.ListBoxSoNguyen.Name = "ListBoxSoNguyen"
        Me.ListBoxSoNguyen.Size = New System.Drawing.Size(284, 504)
        Me.ListBoxSoNguyen.TabIndex = 5
        '
        'FrmThaotacso
        '
        Me.AcceptButton = Me.ButtonCapNhat
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 805)
        Me.Controls.Add(Me.ListBoxSoNguyen)
        Me.Controls.Add(Me.ButtonKetThuc)
        Me.Controls.Add(Me.GroupBoxChucNang)
        Me.Controls.Add(Me.ButtonCapNhat)
        Me.Controls.Add(Me.TextBoxNhap)
        Me.Controls.Add(Me.LabelNhap)
        Me.Name = "FrmThaotacso"
        Me.Text = "Thao tac so"
        Me.GroupBoxChucNang.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelNhap As Label
    Friend WithEvents TextBoxNhap As TextBox
    Friend WithEvents ButtonCapNhat As Button
    Friend WithEvents GroupBoxChucNang As GroupBox
    Friend WithEvents ButtonKetThuc As Button
    Friend WithEvents ListBoxSoNguyen As ListBox
    Friend WithEvents ButtonXoaCuoi As Button
    Friend WithEvents ButtonXoaDau As Button
    Friend WithEvents ButtonXoaDangChon As Button
    Friend WithEvents ButtonLeCuoi As Button
    Friend WithEvents ButtonChanDau As Button
    Friend WithEvents ButtonTangHai As Button
End Class
