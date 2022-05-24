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
        Me.LabelDDH = New System.Windows.Forms.Label()
        Me.GroupBoxTTCT = New System.Windows.Forms.GroupBox()
        Me.TextBoxDiaChi = New System.Windows.Forms.TextBox()
        Me.TextBoxKH = New System.Windows.Forms.TextBox()
        Me.DateTimePickerND = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxSDH = New System.Windows.Forms.TextBox()
        Me.LabelDC = New System.Windows.Forms.Label()
        Me.LabelND = New System.Windows.Forms.Label()
        Me.LabelHTKH = New System.Windows.Forms.Label()
        Me.LabelSDH = New System.Windows.Forms.Label()
        Me.GroupBoxTTC = New System.Windows.Forms.GroupBox()
        Me.ListViewDDH = New System.Windows.Forms.ListView()
        Me.ButtonThem = New System.Windows.Forms.Button()
        Me.ButtonSua = New System.Windows.Forms.Button()
        Me.ButtonXoa = New System.Windows.Forms.Button()
        Me.ButtonThoat = New System.Windows.Forms.Button()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBoxTTCT.SuspendLayout()
        Me.GroupBoxTTC.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelDDH
        '
        Me.LabelDDH.AutoSize = True
        Me.LabelDDH.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDDH.Location = New System.Drawing.Point(320, 27)
        Me.LabelDDH.Name = "LabelDDH"
        Me.LabelDDH.Size = New System.Drawing.Size(686, 55)
        Me.LabelDDH.TabIndex = 0
        Me.LabelDDH.Text = "DANH MỤC ĐƠN ĐẶT HÀNG"
        '
        'GroupBoxTTCT
        '
        Me.GroupBoxTTCT.Controls.Add(Me.TextBoxDiaChi)
        Me.GroupBoxTTCT.Controls.Add(Me.TextBoxKH)
        Me.GroupBoxTTCT.Controls.Add(Me.DateTimePickerND)
        Me.GroupBoxTTCT.Controls.Add(Me.TextBoxSDH)
        Me.GroupBoxTTCT.Controls.Add(Me.LabelDC)
        Me.GroupBoxTTCT.Controls.Add(Me.LabelND)
        Me.GroupBoxTTCT.Controls.Add(Me.LabelHTKH)
        Me.GroupBoxTTCT.Controls.Add(Me.LabelSDH)
        Me.GroupBoxTTCT.Location = New System.Drawing.Point(49, 131)
        Me.GroupBoxTTCT.Name = "GroupBoxTTCT"
        Me.GroupBoxTTCT.Size = New System.Drawing.Size(1165, 240)
        Me.GroupBoxTTCT.TabIndex = 1
        Me.GroupBoxTTCT.TabStop = False
        Me.GroupBoxTTCT.Text = "Thông tin chi tiết"
        '
        'TextBoxDiaChi
        '
        Me.TextBoxDiaChi.Location = New System.Drawing.Point(794, 145)
        Me.TextBoxDiaChi.Name = "TextBoxDiaChi"
        Me.TextBoxDiaChi.Size = New System.Drawing.Size(328, 31)
        Me.TextBoxDiaChi.TabIndex = 7
        '
        'TextBoxKH
        '
        Me.TextBoxKH.Location = New System.Drawing.Point(794, 44)
        Me.TextBoxKH.Name = "TextBoxKH"
        Me.TextBoxKH.Size = New System.Drawing.Size(328, 31)
        Me.TextBoxKH.TabIndex = 6
        '
        'DateTimePickerND
        '
        Me.DateTimePickerND.Location = New System.Drawing.Point(213, 139)
        Me.DateTimePickerND.Name = "DateTimePickerND"
        Me.DateTimePickerND.Size = New System.Drawing.Size(394, 31)
        Me.DateTimePickerND.TabIndex = 5
        '
        'TextBoxSDH
        '
        Me.TextBoxSDH.Location = New System.Drawing.Point(213, 41)
        Me.TextBoxSDH.Name = "TextBoxSDH"
        Me.TextBoxSDH.Size = New System.Drawing.Size(243, 31)
        Me.TextBoxSDH.TabIndex = 4
        '
        'LabelDC
        '
        Me.LabelDC.AutoSize = True
        Me.LabelDC.Location = New System.Drawing.Point(663, 145)
        Me.LabelDC.Name = "LabelDC"
        Me.LabelDC.Size = New System.Drawing.Size(84, 25)
        Me.LabelDC.TabIndex = 3
        Me.LabelDC.Text = "Địa chỉ:"
        '
        'LabelND
        '
        Me.LabelND.AutoSize = True
        Me.LabelND.Location = New System.Drawing.Point(55, 145)
        Me.LabelND.Name = "LabelND"
        Me.LabelND.Size = New System.Drawing.Size(104, 25)
        Me.LabelND.TabIndex = 2
        Me.LabelND.Text = "Ngày đặt:"
        '
        'LabelHTKH
        '
        Me.LabelHTKH.AutoSize = True
        Me.LabelHTKH.Location = New System.Drawing.Point(560, 47)
        Me.LabelHTKH.Name = "LabelHTKH"
        Me.LabelHTKH.Size = New System.Drawing.Size(199, 25)
        Me.LabelHTKH.TabIndex = 1
        Me.LabelHTKH.Text = "Họ tên khách hàng:"
        '
        'LabelSDH
        '
        Me.LabelSDH.AutoSize = True
        Me.LabelSDH.Location = New System.Drawing.Point(55, 47)
        Me.LabelSDH.Name = "LabelSDH"
        Me.LabelSDH.Size = New System.Drawing.Size(140, 25)
        Me.LabelSDH.TabIndex = 0
        Me.LabelSDH.Text = "Số đơn hàng:"
        '
        'GroupBoxTTC
        '
        Me.GroupBoxTTC.Controls.Add(Me.ListViewDDH)
        Me.GroupBoxTTC.Location = New System.Drawing.Point(49, 497)
        Me.GroupBoxTTC.Name = "GroupBoxTTC"
        Me.GroupBoxTTC.Size = New System.Drawing.Size(1165, 240)
        Me.GroupBoxTTC.TabIndex = 2
        Me.GroupBoxTTC.TabStop = False
        Me.GroupBoxTTC.Text = "Thông tin chung"
        '
        'ListViewDDH
        '
        Me.ListViewDDH.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListViewDDH.FullRowSelect = True
        Me.ListViewDDH.GridLines = True
        Me.ListViewDDH.HideSelection = False
        Me.ListViewDDH.Location = New System.Drawing.Point(24, 38)
        Me.ListViewDDH.Name = "ListViewDDH"
        Me.ListViewDDH.Size = New System.Drawing.Size(1115, 179)
        Me.ListViewDDH.TabIndex = 0
        Me.ListViewDDH.UseCompatibleStateImageBehavior = False
        Me.ListViewDDH.View = System.Windows.Forms.View.Details
        '
        'ButtonThem
        '
        Me.ButtonThem.Location = New System.Drawing.Point(513, 420)
        Me.ButtonThem.Name = "ButtonThem"
        Me.ButtonThem.Size = New System.Drawing.Size(128, 54)
        Me.ButtonThem.TabIndex = 3
        Me.ButtonThem.Text = "Thêm"
        Me.ButtonThem.UseVisualStyleBackColor = True
        '
        'ButtonSua
        '
        Me.ButtonSua.Location = New System.Drawing.Point(680, 420)
        Me.ButtonSua.Name = "ButtonSua"
        Me.ButtonSua.Size = New System.Drawing.Size(128, 54)
        Me.ButtonSua.TabIndex = 4
        Me.ButtonSua.Text = "Sửa"
        Me.ButtonSua.UseVisualStyleBackColor = True
        '
        'ButtonXoa
        '
        Me.ButtonXoa.Location = New System.Drawing.Point(877, 420)
        Me.ButtonXoa.Name = "ButtonXoa"
        Me.ButtonXoa.Size = New System.Drawing.Size(128, 54)
        Me.ButtonXoa.TabIndex = 5
        Me.ButtonXoa.Text = "Xoá"
        Me.ButtonXoa.UseVisualStyleBackColor = True
        '
        'ButtonThoat
        '
        Me.ButtonThoat.Location = New System.Drawing.Point(1061, 420)
        Me.ButtonThoat.Name = "ButtonThoat"
        Me.ButtonThoat.Size = New System.Drawing.Size(128, 54)
        Me.ButtonThoat.TabIndex = 6
        Me.ButtonThoat.Text = "Thoát"
        Me.ButtonThoat.UseVisualStyleBackColor = True
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Số đơn hàng"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Ngày đặt"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Họ tên khách hàng"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Địa chỉ"
        Me.ColumnHeader4.Width = 100
        '
        'FrmCuong
        '
        Me.AcceptButton = Me.ButtonThem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 790)
        Me.Controls.Add(Me.ButtonThoat)
        Me.Controls.Add(Me.ButtonXoa)
        Me.Controls.Add(Me.ButtonSua)
        Me.Controls.Add(Me.ButtonThem)
        Me.Controls.Add(Me.GroupBoxTTC)
        Me.Controls.Add(Me.GroupBoxTTCT)
        Me.Controls.Add(Me.LabelDDH)
        Me.Name = "FrmCuong"
        Me.Text = "FrmCuong"
        Me.GroupBoxTTCT.ResumeLayout(False)
        Me.GroupBoxTTCT.PerformLayout()
        Me.GroupBoxTTC.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelDDH As Label
    Friend WithEvents GroupBoxTTCT As GroupBox
    Friend WithEvents TextBoxDiaChi As TextBox
    Friend WithEvents TextBoxKH As TextBox
    Friend WithEvents DateTimePickerND As DateTimePicker
    Friend WithEvents TextBoxSDH As TextBox
    Friend WithEvents LabelDC As Label
    Friend WithEvents LabelND As Label
    Friend WithEvents LabelHTKH As Label
    Friend WithEvents LabelSDH As Label
    Friend WithEvents GroupBoxTTC As GroupBox
    Friend WithEvents ListViewDDH As ListView
    Friend WithEvents ButtonThem As Button
    Friend WithEvents ButtonSua As Button
    Friend WithEvents ButtonXoa As Button
    Friend WithEvents ButtonThoat As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
