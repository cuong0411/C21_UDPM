<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSinhVien
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
        Me.LabelDSSV = New System.Windows.Forms.Label()
        Me.LabelHoTen = New System.Windows.Forms.Label()
        Me.TextBoxNhap = New System.Windows.Forms.TextBox()
        Me.ButtonCapNhat = New System.Windows.Forms.Button()
        Me.ButtonAddToB = New System.Windows.Forms.Button()
        Me.ButtonXoa = New System.Windows.Forms.Button()
        Me.ButtonAddToA = New System.Windows.Forms.Button()
        Me.ButtonAddAllToA = New System.Windows.Forms.Button()
        Me.ButtonAddAllToB = New System.Windows.Forms.Button()
        Me.GroupBoxLopA = New System.Windows.Forms.GroupBox()
        Me.ListBoxLopA = New System.Windows.Forms.ListBox()
        Me.GroupBoxLopB = New System.Windows.Forms.GroupBox()
        Me.ListBoxLopB = New System.Windows.Forms.ListBox()
        Me.ButtonKetThuc = New System.Windows.Forms.Button()
        Me.GroupBoxLopA.SuspendLayout()
        Me.GroupBoxLopB.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelDSSV
        '
        Me.LabelDSSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDSSV.Location = New System.Drawing.Point(307, 33)
        Me.LabelDSSV.Name = "LabelDSSV"
        Me.LabelDSSV.Size = New System.Drawing.Size(489, 68)
        Me.LabelDSSV.TabIndex = 0
        Me.LabelDSSV.Text = "Danh Sách Sinh Viên"
        Me.LabelDSSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelHoTen
        '
        Me.LabelHoTen.AutoSize = True
        Me.LabelHoTen.Location = New System.Drawing.Point(47, 121)
        Me.LabelHoTen.Name = "LabelHoTen"
        Me.LabelHoTen.Size = New System.Drawing.Size(110, 25)
        Me.LabelHoTen.TabIndex = 1
        Me.LabelHoTen.Text = "Họ và tên:"
        '
        'TextBoxNhap
        '
        Me.TextBoxNhap.Location = New System.Drawing.Point(238, 121)
        Me.TextBoxNhap.Name = "TextBoxNhap"
        Me.TextBoxNhap.Size = New System.Drawing.Size(487, 31)
        Me.TextBoxNhap.TabIndex = 2
        '
        'ButtonCapNhat
        '
        Me.ButtonCapNhat.Location = New System.Drawing.Point(829, 121)
        Me.ButtonCapNhat.Name = "ButtonCapNhat"
        Me.ButtonCapNhat.Size = New System.Drawing.Size(169, 67)
        Me.ButtonCapNhat.TabIndex = 3
        Me.ButtonCapNhat.Text = "Cập nhật"
        Me.ButtonCapNhat.UseVisualStyleBackColor = True
        '
        'ButtonAddToB
        '
        Me.ButtonAddToB.Location = New System.Drawing.Point(499, 393)
        Me.ButtonAddToB.Name = "ButtonAddToB"
        Me.ButtonAddToB.Size = New System.Drawing.Size(73, 49)
        Me.ButtonAddToB.TabIndex = 6
        Me.ButtonAddToB.Text = ">"
        Me.ButtonAddToB.UseVisualStyleBackColor = True
        '
        'ButtonXoa
        '
        Me.ButtonXoa.Location = New System.Drawing.Point(141, 765)
        Me.ButtonXoa.Name = "ButtonXoa"
        Me.ButtonXoa.Size = New System.Drawing.Size(174, 67)
        Me.ButtonXoa.TabIndex = 7
        Me.ButtonXoa.Text = "Xóa"
        Me.ButtonXoa.UseVisualStyleBackColor = True
        '
        'ButtonAddToA
        '
        Me.ButtonAddToA.Location = New System.Drawing.Point(602, 393)
        Me.ButtonAddToA.Name = "ButtonAddToA"
        Me.ButtonAddToA.Size = New System.Drawing.Size(73, 49)
        Me.ButtonAddToA.TabIndex = 8
        Me.ButtonAddToA.Text = "<"
        Me.ButtonAddToA.UseVisualStyleBackColor = True
        '
        'ButtonAddAllToA
        '
        Me.ButtonAddAllToA.Location = New System.Drawing.Point(602, 469)
        Me.ButtonAddAllToA.Name = "ButtonAddAllToA"
        Me.ButtonAddAllToA.Size = New System.Drawing.Size(73, 49)
        Me.ButtonAddAllToA.TabIndex = 9
        Me.ButtonAddAllToA.Text = "<<"
        Me.ButtonAddAllToA.UseVisualStyleBackColor = True
        '
        'ButtonAddAllToB
        '
        Me.ButtonAddAllToB.Location = New System.Drawing.Point(499, 469)
        Me.ButtonAddAllToB.Name = "ButtonAddAllToB"
        Me.ButtonAddAllToB.Size = New System.Drawing.Size(73, 49)
        Me.ButtonAddAllToB.TabIndex = 10
        Me.ButtonAddAllToB.Text = ">>"
        Me.ButtonAddAllToB.UseVisualStyleBackColor = True
        '
        'GroupBoxLopA
        '
        Me.GroupBoxLopA.Controls.Add(Me.ListBoxLopA)
        Me.GroupBoxLopA.Location = New System.Drawing.Point(52, 242)
        Me.GroupBoxLopA.Name = "GroupBoxLopA"
        Me.GroupBoxLopA.Size = New System.Drawing.Size(431, 460)
        Me.GroupBoxLopA.TabIndex = 11
        Me.GroupBoxLopA.TabStop = False
        Me.GroupBoxLopA.Text = "Lớp A"
        '
        'ListBoxLopA
        '
        Me.ListBoxLopA.FormattingEnabled = True
        Me.ListBoxLopA.ItemHeight = 25
        Me.ListBoxLopA.Location = New System.Drawing.Point(27, 46)
        Me.ListBoxLopA.Name = "ListBoxLopA"
        Me.ListBoxLopA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBoxLopA.Size = New System.Drawing.Size(381, 379)
        Me.ListBoxLopA.TabIndex = 0
        '
        'GroupBoxLopB
        '
        Me.GroupBoxLopB.Controls.Add(Me.ListBoxLopB)
        Me.GroupBoxLopB.Location = New System.Drawing.Point(695, 255)
        Me.GroupBoxLopB.Name = "GroupBoxLopB"
        Me.GroupBoxLopB.Size = New System.Drawing.Size(431, 460)
        Me.GroupBoxLopB.TabIndex = 12
        Me.GroupBoxLopB.TabStop = False
        Me.GroupBoxLopB.Text = "Lớp B"
        '
        'ListBoxLopB
        '
        Me.ListBoxLopB.FormattingEnabled = True
        Me.ListBoxLopB.ItemHeight = 25
        Me.ListBoxLopB.Location = New System.Drawing.Point(27, 46)
        Me.ListBoxLopB.Name = "ListBoxLopB"
        Me.ListBoxLopB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBoxLopB.Size = New System.Drawing.Size(381, 379)
        Me.ListBoxLopB.TabIndex = 0
        '
        'ButtonKetThuc
        '
        Me.ButtonKetThuc.Location = New System.Drawing.Point(824, 765)
        Me.ButtonKetThuc.Name = "ButtonKetThuc"
        Me.ButtonKetThuc.Size = New System.Drawing.Size(174, 67)
        Me.ButtonKetThuc.TabIndex = 13
        Me.ButtonKetThuc.Text = "Kết thúc"
        Me.ButtonKetThuc.UseVisualStyleBackColor = True
        '
        'FrmSinhVien
        '
        Me.AcceptButton = Me.ButtonCapNhat
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1209, 858)
        Me.Controls.Add(Me.ButtonKetThuc)
        Me.Controls.Add(Me.GroupBoxLopB)
        Me.Controls.Add(Me.GroupBoxLopA)
        Me.Controls.Add(Me.ButtonAddAllToB)
        Me.Controls.Add(Me.ButtonAddAllToA)
        Me.Controls.Add(Me.ButtonAddToA)
        Me.Controls.Add(Me.ButtonXoa)
        Me.Controls.Add(Me.ButtonAddToB)
        Me.Controls.Add(Me.ButtonCapNhat)
        Me.Controls.Add(Me.TextBoxNhap)
        Me.Controls.Add(Me.LabelHoTen)
        Me.Controls.Add(Me.LabelDSSV)
        Me.Name = "FrmSinhVien"
        Me.Text = "Quản lý sinh viên"
        Me.GroupBoxLopA.ResumeLayout(False)
        Me.GroupBoxLopB.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelDSSV As Label
    Friend WithEvents LabelHoTen As Label
    Friend WithEvents TextBoxNhap As TextBox
    Friend WithEvents ButtonCapNhat As Button
    Friend WithEvents ButtonAddToB As Button
    Friend WithEvents ButtonXoa As Button
    Friend WithEvents ButtonAddToA As Button
    Friend WithEvents ButtonAddAllToA As Button
    Friend WithEvents ButtonAddAllToB As Button
    Friend WithEvents GroupBoxLopA As GroupBox
    Friend WithEvents ListBoxLopA As ListBox
    Friend WithEvents GroupBoxLopB As GroupBox
    Friend WithEvents ListBoxLopB As ListBox
    Friend WithEvents ButtonKetThuc As Button
End Class
