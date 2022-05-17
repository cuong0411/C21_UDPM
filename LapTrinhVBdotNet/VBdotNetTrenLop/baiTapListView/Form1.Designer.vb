<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNhanVien
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
        Me.LabelDanhMuc = New System.Windows.Forms.Label()
        Me.GroupBoxThongTinChiTiet = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxDiaChi = New System.Windows.Forms.TextBox()
        Me.TextBoxDienThoai = New System.Windows.Forms.TextBox()
        Me.TextBoxHoTen = New System.Windows.Forms.TextBox()
        Me.LabelDiaChi = New System.Windows.Forms.Label()
        Me.LabelDienThoai = New System.Windows.Forms.Label()
        Me.LabelNgaySinh = New System.Windows.Forms.Label()
        Me.LabelHoTen = New System.Windows.Forms.Label()
        Me.GroupBoxThongTinChung = New System.Windows.Forms.GroupBox()
        Me.ListViewNhanVien = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonThem = New System.Windows.Forms.Button()
        Me.ButtonXoa = New System.Windows.Forms.Button()
        Me.ButtonSua = New System.Windows.Forms.Button()
        Me.Thoat = New System.Windows.Forms.Button()
        Me.GroupBoxThongTinChiTiet.SuspendLayout()
        Me.GroupBoxThongTinChung.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelDanhMuc
        '
        Me.LabelDanhMuc.AutoSize = True
        Me.LabelDanhMuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDanhMuc.Location = New System.Drawing.Point(339, 29)
        Me.LabelDanhMuc.Name = "LabelDanhMuc"
        Me.LabelDanhMuc.Size = New System.Drawing.Size(395, 44)
        Me.LabelDanhMuc.TabIndex = 0
        Me.LabelDanhMuc.Text = "Danh Mục Nhân Viên"
        '
        'GroupBoxThongTinChiTiet
        '
        Me.GroupBoxThongTinChiTiet.Controls.Add(Me.DateTimePickerNgaySinh)
        Me.GroupBoxThongTinChiTiet.Controls.Add(Me.TextBoxDiaChi)
        Me.GroupBoxThongTinChiTiet.Controls.Add(Me.TextBoxDienThoai)
        Me.GroupBoxThongTinChiTiet.Controls.Add(Me.TextBoxHoTen)
        Me.GroupBoxThongTinChiTiet.Controls.Add(Me.LabelDiaChi)
        Me.GroupBoxThongTinChiTiet.Controls.Add(Me.LabelDienThoai)
        Me.GroupBoxThongTinChiTiet.Controls.Add(Me.LabelNgaySinh)
        Me.GroupBoxThongTinChiTiet.Controls.Add(Me.LabelHoTen)
        Me.GroupBoxThongTinChiTiet.Location = New System.Drawing.Point(125, 120)
        Me.GroupBoxThongTinChiTiet.Name = "GroupBoxThongTinChiTiet"
        Me.GroupBoxThongTinChiTiet.Size = New System.Drawing.Size(815, 176)
        Me.GroupBoxThongTinChiTiet.TabIndex = 1
        Me.GroupBoxThongTinChiTiet.TabStop = False
        Me.GroupBoxThongTinChiTiet.Text = "Thông tin chi tiết"
        '
        'DateTimePickerNgaySinh
        '
        Me.DateTimePickerNgaySinh.Location = New System.Drawing.Point(172, 119)
        Me.DateTimePickerNgaySinh.Name = "DateTimePickerNgaySinh"
        Me.DateTimePickerNgaySinh.Size = New System.Drawing.Size(277, 31)
        Me.DateTimePickerNgaySinh.TabIndex = 8
        '
        'TextBoxDiaChi
        '
        Me.TextBoxDiaChi.Location = New System.Drawing.Point(610, 111)
        Me.TextBoxDiaChi.Name = "TextBoxDiaChi"
        Me.TextBoxDiaChi.Size = New System.Drawing.Size(199, 31)
        Me.TextBoxDiaChi.TabIndex = 7
        '
        'TextBoxDienThoai
        '
        Me.TextBoxDienThoai.Location = New System.Drawing.Point(610, 56)
        Me.TextBoxDienThoai.Name = "TextBoxDienThoai"
        Me.TextBoxDienThoai.Size = New System.Drawing.Size(199, 31)
        Me.TextBoxDienThoai.TabIndex = 6
        '
        'TextBoxHoTen
        '
        Me.TextBoxHoTen.Location = New System.Drawing.Point(172, 56)
        Me.TextBoxHoTen.Name = "TextBoxHoTen"
        Me.TextBoxHoTen.Size = New System.Drawing.Size(277, 31)
        Me.TextBoxHoTen.TabIndex = 4
        '
        'LabelDiaChi
        '
        Me.LabelDiaChi.AutoSize = True
        Me.LabelDiaChi.Location = New System.Drawing.Point(486, 111)
        Me.LabelDiaChi.Name = "LabelDiaChi"
        Me.LabelDiaChi.Size = New System.Drawing.Size(78, 25)
        Me.LabelDiaChi.TabIndex = 3
        Me.LabelDiaChi.Text = "Địa chỉ"
        '
        'LabelDienThoai
        '
        Me.LabelDienThoai.AutoSize = True
        Me.LabelDienThoai.Location = New System.Drawing.Point(486, 62)
        Me.LabelDienThoai.Name = "LabelDienThoai"
        Me.LabelDienThoai.Size = New System.Drawing.Size(109, 25)
        Me.LabelDienThoai.TabIndex = 2
        Me.LabelDienThoai.Text = "Điện thoại"
        '
        'LabelNgaySinh
        '
        Me.LabelNgaySinh.AutoSize = True
        Me.LabelNgaySinh.Location = New System.Drawing.Point(55, 111)
        Me.LabelNgaySinh.Name = "LabelNgaySinh"
        Me.LabelNgaySinh.Size = New System.Drawing.Size(108, 25)
        Me.LabelNgaySinh.TabIndex = 1
        Me.LabelNgaySinh.Text = "Ngày sinh"
        '
        'LabelHoTen
        '
        Me.LabelHoTen.AutoSize = True
        Me.LabelHoTen.Location = New System.Drawing.Point(55, 62)
        Me.LabelHoTen.Name = "LabelHoTen"
        Me.LabelHoTen.Size = New System.Drawing.Size(75, 25)
        Me.LabelHoTen.TabIndex = 0
        Me.LabelHoTen.Text = "Họ tên"
        '
        'GroupBoxThongTinChung
        '
        Me.GroupBoxThongTinChung.Controls.Add(Me.ListViewNhanVien)
        Me.GroupBoxThongTinChung.Location = New System.Drawing.Point(125, 417)
        Me.GroupBoxThongTinChung.Name = "GroupBoxThongTinChung"
        Me.GroupBoxThongTinChung.Size = New System.Drawing.Size(919, 313)
        Me.GroupBoxThongTinChung.TabIndex = 2
        Me.GroupBoxThongTinChung.TabStop = False
        Me.GroupBoxThongTinChung.Text = "Thông tin chung"
        '
        'ListViewNhanVien
        '
        Me.ListViewNhanVien.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListViewNhanVien.FullRowSelect = True
        Me.ListViewNhanVien.GridLines = True
        Me.ListViewNhanVien.HideSelection = False
        Me.ListViewNhanVien.Location = New System.Drawing.Point(25, 30)
        Me.ListViewNhanVien.Name = "ListViewNhanVien"
        Me.ListViewNhanVien.Size = New System.Drawing.Size(878, 277)
        Me.ListViewNhanVien.TabIndex = 0
        Me.ListViewNhanVien.UseCompatibleStateImageBehavior = False
        Me.ListViewNhanVien.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Họ tên"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Ngày sinh"
        Me.ColumnHeader2.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Địa chỉ"
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Điện thoại"
        Me.ColumnHeader4.Width = 90
        '
        'ButtonThem
        '
        Me.ButtonThem.Location = New System.Drawing.Point(415, 328)
        Me.ButtonThem.Name = "ButtonThem"
        Me.ButtonThem.Size = New System.Drawing.Size(105, 44)
        Me.ButtonThem.TabIndex = 3
        Me.ButtonThem.Text = "Thêm"
        Me.ButtonThem.UseVisualStyleBackColor = True
        '
        'ButtonXoa
        '
        Me.ButtonXoa.Location = New System.Drawing.Point(552, 328)
        Me.ButtonXoa.Name = "ButtonXoa"
        Me.ButtonXoa.Size = New System.Drawing.Size(105, 44)
        Me.ButtonXoa.TabIndex = 4
        Me.ButtonXoa.Text = "Xóa"
        Me.ButtonXoa.UseVisualStyleBackColor = True
        '
        'ButtonSua
        '
        Me.ButtonSua.Location = New System.Drawing.Point(680, 328)
        Me.ButtonSua.Name = "ButtonSua"
        Me.ButtonSua.Size = New System.Drawing.Size(105, 44)
        Me.ButtonSua.TabIndex = 5
        Me.ButtonSua.Text = "Sửa"
        Me.ButtonSua.UseVisualStyleBackColor = True
        '
        'Thoat
        '
        Me.Thoat.Location = New System.Drawing.Point(804, 328)
        Me.Thoat.Name = "Thoat"
        Me.Thoat.Size = New System.Drawing.Size(105, 44)
        Me.Thoat.TabIndex = 6
        Me.Thoat.Text = "Thoát"
        Me.Thoat.UseVisualStyleBackColor = True
        '
        'FrmNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 742)
        Me.Controls.Add(Me.Thoat)
        Me.Controls.Add(Me.ButtonSua)
        Me.Controls.Add(Me.ButtonXoa)
        Me.Controls.Add(Me.ButtonThem)
        Me.Controls.Add(Me.GroupBoxThongTinChung)
        Me.Controls.Add(Me.GroupBoxThongTinChiTiet)
        Me.Controls.Add(Me.LabelDanhMuc)
        Me.Name = "FrmNhanVien"
        Me.Text = "FrmBT8"
        Me.GroupBoxThongTinChiTiet.ResumeLayout(False)
        Me.GroupBoxThongTinChiTiet.PerformLayout()
        Me.GroupBoxThongTinChung.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelDanhMuc As Label
    Friend WithEvents GroupBoxThongTinChiTiet As GroupBox
    Friend WithEvents TextBoxDiaChi As TextBox
    Friend WithEvents TextBoxDienThoai As TextBox
    Friend WithEvents TextBoxHoTen As TextBox
    Friend WithEvents LabelDiaChi As Label
    Friend WithEvents LabelDienThoai As Label
    Friend WithEvents LabelNgaySinh As Label
    Friend WithEvents LabelHoTen As Label
    Friend WithEvents GroupBoxThongTinChung As GroupBox
    Friend WithEvents ListViewNhanVien As ListView
    Friend WithEvents ButtonThem As Button
    Friend WithEvents ButtonXoa As Button
    Friend WithEvents ButtonSua As Button
    Friend WithEvents Thoat As Button
    Friend WithEvents DateTimePickerNgaySinh As DateTimePicker
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
