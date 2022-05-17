<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCuong
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
        Me.LabelHoTen = New System.Windows.Forms.Label()
        Me.LabelTuoi = New System.Windows.Forms.Label()
        Me.LabelChucVu = New System.Windows.Forms.Label()
        Me.TextBoxHoTen = New System.Windows.Forms.TextBox()
        Me.TextBoxTuoi = New System.Windows.Forms.TextBox()
        Me.CheckBoxGioiTinh = New System.Windows.Forms.CheckBox()
        Me.ComboBoxChucVu = New System.Windows.Forms.ComboBox()
        Me.ListBoxTenDaNhap = New System.Windows.Forms.ListBox()
        Me.ListBoxChuyenCongTac = New System.Windows.Forms.ListBox()
        Me.ButtonThemVao = New System.Windows.Forms.Button()
        Me.ButtonKetThuc = New System.Windows.Forms.Button()
        Me.ButtonAddRight = New System.Windows.Forms.Button()
        Me.ButtonAddLeft = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelHoTen
        '
        Me.LabelHoTen.AutoSize = True
        Me.LabelHoTen.Location = New System.Drawing.Point(44, 39)
        Me.LabelHoTen.Name = "LabelHoTen"
        Me.LabelHoTen.Size = New System.Drawing.Size(110, 25)
        Me.LabelHoTen.TabIndex = 0
        Me.LabelHoTen.Text = "Họ và tên:"
        '
        'LabelTuoi
        '
        Me.LabelTuoi.AutoSize = True
        Me.LabelTuoi.Location = New System.Drawing.Point(44, 107)
        Me.LabelTuoi.Name = "LabelTuoi"
        Me.LabelTuoi.Size = New System.Drawing.Size(60, 25)
        Me.LabelTuoi.TabIndex = 1
        Me.LabelTuoi.Text = "Tuổi:"
        '
        'LabelChucVu
        '
        Me.LabelChucVu.AutoSize = True
        Me.LabelChucVu.Location = New System.Drawing.Point(44, 165)
        Me.LabelChucVu.Name = "LabelChucVu"
        Me.LabelChucVu.Size = New System.Drawing.Size(97, 25)
        Me.LabelChucVu.TabIndex = 2
        Me.LabelChucVu.Text = "Chức vụ:"
        '
        'TextBoxHoTen
        '
        Me.TextBoxHoTen.Location = New System.Drawing.Point(158, 33)
        Me.TextBoxHoTen.Name = "TextBoxHoTen"
        Me.TextBoxHoTen.Size = New System.Drawing.Size(355, 31)
        Me.TextBoxHoTen.TabIndex = 3
        '
        'TextBoxTuoi
        '
        Me.TextBoxTuoi.Location = New System.Drawing.Point(158, 101)
        Me.TextBoxTuoi.Name = "TextBoxTuoi"
        Me.TextBoxTuoi.Size = New System.Drawing.Size(122, 31)
        Me.TextBoxTuoi.TabIndex = 4
        '
        'CheckBoxGioiTinh
        '
        Me.CheckBoxGioiTinh.AutoSize = True
        Me.CheckBoxGioiTinh.Location = New System.Drawing.Point(312, 106)
        Me.CheckBoxGioiTinh.Name = "CheckBoxGioiTinh"
        Me.CheckBoxGioiTinh.Size = New System.Drawing.Size(128, 29)
        Me.CheckBoxGioiTinh.TabIndex = 6
        Me.CheckBoxGioiTinh.Text = "Nam giới"
        Me.CheckBoxGioiTinh.UseVisualStyleBackColor = True
        '
        'ComboBoxChucVu
        '
        Me.ComboBoxChucVu.FormattingEnabled = True
        Me.ComboBoxChucVu.Location = New System.Drawing.Point(158, 157)
        Me.ComboBoxChucVu.Name = "ComboBoxChucVu"
        Me.ComboBoxChucVu.Size = New System.Drawing.Size(201, 33)
        Me.ComboBoxChucVu.TabIndex = 7
        '
        'ListBoxTenDaNhap
        '
        Me.ListBoxTenDaNhap.FormattingEnabled = True
        Me.ListBoxTenDaNhap.ItemHeight = 25
        Me.ListBoxTenDaNhap.Location = New System.Drawing.Point(76, 263)
        Me.ListBoxTenDaNhap.Name = "ListBoxTenDaNhap"
        Me.ListBoxTenDaNhap.Size = New System.Drawing.Size(353, 329)
        Me.ListBoxTenDaNhap.TabIndex = 9
        '
        'ListBoxChuyenCongTac
        '
        Me.ListBoxChuyenCongTac.FormattingEnabled = True
        Me.ListBoxChuyenCongTac.ItemHeight = 25
        Me.ListBoxChuyenCongTac.Location = New System.Drawing.Point(540, 263)
        Me.ListBoxChuyenCongTac.Name = "ListBoxChuyenCongTac"
        Me.ListBoxChuyenCongTac.Size = New System.Drawing.Size(353, 329)
        Me.ListBoxChuyenCongTac.TabIndex = 10
        '
        'ButtonThemVao
        '
        Me.ButtonThemVao.Location = New System.Drawing.Point(692, 36)
        Me.ButtonThemVao.Name = "ButtonThemVao"
        Me.ButtonThemVao.Size = New System.Drawing.Size(161, 53)
        Me.ButtonThemVao.TabIndex = 11
        Me.ButtonThemVao.Text = "Thêm vào"
        Me.ButtonThemVao.UseVisualStyleBackColor = True
        '
        'ButtonKetThuc
        '
        Me.ButtonKetThuc.Location = New System.Drawing.Point(692, 137)
        Me.ButtonKetThuc.Name = "ButtonKetThuc"
        Me.ButtonKetThuc.Size = New System.Drawing.Size(161, 53)
        Me.ButtonKetThuc.TabIndex = 12
        Me.ButtonKetThuc.Text = "Kết thúc"
        Me.ButtonKetThuc.UseVisualStyleBackColor = True
        '
        'ButtonAddRight
        '
        Me.ButtonAddRight.Location = New System.Drawing.Point(450, 328)
        Me.ButtonAddRight.Name = "ButtonAddRight"
        Me.ButtonAddRight.Size = New System.Drawing.Size(78, 60)
        Me.ButtonAddRight.TabIndex = 13
        Me.ButtonAddRight.Text = ">>"
        Me.ButtonAddRight.UseVisualStyleBackColor = True
        '
        'ButtonAddLeft
        '
        Me.ButtonAddLeft.Location = New System.Drawing.Point(450, 423)
        Me.ButtonAddLeft.Name = "ButtonAddLeft"
        Me.ButtonAddLeft.Size = New System.Drawing.Size(78, 60)
        Me.ButtonAddLeft.TabIndex = 14
        Me.ButtonAddLeft.Text = "<<"
        Me.ButtonAddLeft.UseVisualStyleBackColor = True
        '
        'FrmCuong
        '
        Me.AcceptButton = Me.ButtonThemVao
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 696)
        Me.Controls.Add(Me.ButtonAddLeft)
        Me.Controls.Add(Me.ButtonAddRight)
        Me.Controls.Add(Me.ButtonKetThuc)
        Me.Controls.Add(Me.ButtonThemVao)
        Me.Controls.Add(Me.ListBoxChuyenCongTac)
        Me.Controls.Add(Me.ListBoxTenDaNhap)
        Me.Controls.Add(Me.ComboBoxChucVu)
        Me.Controls.Add(Me.CheckBoxGioiTinh)
        Me.Controls.Add(Me.TextBoxTuoi)
        Me.Controls.Add(Me.TextBoxHoTen)
        Me.Controls.Add(Me.LabelChucVu)
        Me.Controls.Add(Me.LabelTuoi)
        Me.Controls.Add(Me.LabelHoTen)
        Me.Name = "FrmCuong"
        Me.Text = "frmCuong"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelHoTen As Label
    Friend WithEvents LabelTuoi As Label
    Friend WithEvents LabelChucVu As Label
    Friend WithEvents TextBoxHoTen As TextBox
    Friend WithEvents TextBoxTuoi As TextBox
    Friend WithEvents CheckBoxGioiTinh As CheckBox
    Friend WithEvents ComboBoxChucVu As ComboBox
    Friend WithEvents ListBoxTenDaNhap As ListBox
    Friend WithEvents ListBoxChuyenCongTac As ListBox
    Friend WithEvents ButtonThemVao As Button
    Friend WithEvents ButtonKetThuc As Button
    Friend WithEvents ButtonAddRight As Button
    Friend WithEvents ButtonAddLeft As Button
End Class
