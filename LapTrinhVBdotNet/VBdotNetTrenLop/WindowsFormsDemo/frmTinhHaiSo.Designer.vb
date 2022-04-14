<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTinhHaiSo
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
        Me.TextBoxSoThuNhat = New System.Windows.Forms.TextBox()
        Me.LabelSoThuNhat = New System.Windows.Forms.Label()
        Me.LabelSoThuHai = New System.Windows.Forms.Label()
        Me.TextBoxSoThuHai = New System.Windows.Forms.TextBox()
        Me.ButtonTinh = New System.Windows.Forms.Button()
        Me.LabelKetQua = New System.Windows.Forms.Label()
        Me.TextBoxKetQua = New System.Windows.Forms.TextBox()
        Me.LabelNhapSo = New System.Windows.Forms.Label()
        Me.TextBoxNumberOnly = New System.Windows.Forms.TextBox()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxSoThuNhat
        '
        Me.TextBoxSoThuNhat.Location = New System.Drawing.Point(276, 149)
        Me.TextBoxSoThuNhat.Name = "TextBoxSoThuNhat"
        Me.TextBoxSoThuNhat.Size = New System.Drawing.Size(184, 31)
        Me.TextBoxSoThuNhat.TabIndex = 0
        Me.TextBoxSoThuNhat.Text = "Nhập số thứ nhất"
        '
        'LabelSoThuNhat
        '
        Me.LabelSoThuNhat.AllowDrop = True
        Me.LabelSoThuNhat.AutoSize = True
        Me.LabelSoThuNhat.Location = New System.Drawing.Point(23, 149)
        Me.LabelSoThuNhat.Name = "LabelSoThuNhat"
        Me.LabelSoThuNhat.Size = New System.Drawing.Size(217, 25)
        Me.LabelSoThuNhat.TabIndex = 1
        Me.LabelSoThuNhat.Text = "Nhập vào số thứ nhất"
        '
        'LabelSoThuHai
        '
        Me.LabelSoThuHai.AllowDrop = True
        Me.LabelSoThuHai.AutoSize = True
        Me.LabelSoThuHai.Location = New System.Drawing.Point(23, 218)
        Me.LabelSoThuHai.Name = "LabelSoThuHai"
        Me.LabelSoThuHai.Size = New System.Drawing.Size(163, 25)
        Me.LabelSoThuHai.TabIndex = 3
        Me.LabelSoThuHai.Text = "Nhập số thứ hai"
        '
        'TextBoxSoThuHai
        '
        Me.TextBoxSoThuHai.Location = New System.Drawing.Point(276, 218)
        Me.TextBoxSoThuHai.Name = "TextBoxSoThuHai"
        Me.TextBoxSoThuHai.Size = New System.Drawing.Size(184, 31)
        Me.TextBoxSoThuHai.TabIndex = 2
        Me.TextBoxSoThuHai.Text = "Nhập số thứ hai"
        '
        'ButtonTinh
        '
        Me.ButtonTinh.Location = New System.Drawing.Point(28, 322)
        Me.ButtonTinh.Name = "ButtonTinh"
        Me.ButtonTinh.Size = New System.Drawing.Size(91, 49)
        Me.ButtonTinh.TabIndex = 4
        Me.ButtonTinh.Text = "Tinh"
        Me.ButtonTinh.UseVisualStyleBackColor = True
        '
        'LabelKetQua
        '
        Me.LabelKetQua.AutoSize = True
        Me.LabelKetQua.Location = New System.Drawing.Point(271, 328)
        Me.LabelKetQua.Name = "LabelKetQua"
        Me.LabelKetQua.Size = New System.Drawing.Size(84, 25)
        Me.LabelKetQua.TabIndex = 5
        Me.LabelKetQua.Text = "KetQua"
        '
        'TextBoxKetQua
        '
        Me.TextBoxKetQua.Location = New System.Drawing.Point(458, 322)
        Me.TextBoxKetQua.Name = "TextBoxKetQua"
        Me.TextBoxKetQua.Size = New System.Drawing.Size(184, 31)
        Me.TextBoxKetQua.TabIndex = 6
        '
        'LabelNhapSo
        '
        Me.LabelNhapSo.AutoSize = True
        Me.LabelNhapSo.Location = New System.Drawing.Point(672, 623)
        Me.LabelNhapSo.Name = "LabelNhapSo"
        Me.LabelNhapSo.Size = New System.Drawing.Size(180, 25)
        Me.LabelNhapSo.TabIndex = 7
        Me.LabelNhapSo.Text = "Chỉ được nhập số"
        '
        'TextBoxNumberOnly
        '
        Me.TextBoxNumberOnly.Location = New System.Drawing.Point(907, 616)
        Me.TextBoxNumberOnly.Name = "TextBoxNumberOnly"
        Me.TextBoxNumberOnly.Size = New System.Drawing.Size(184, 31)
        Me.TextBoxNumberOnly.TabIndex = 8
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(276, 420)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(184, 49)
        Me.ButtonReset.TabIndex = 9
        Me.ButtonReset.Text = "Làm lại"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(276, 519)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(184, 49)
        Me.ButtonExit.TabIndex = 10
        Me.ButtonExit.Text = "Thoát"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'frmTinhHaiSo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 705)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.TextBoxNumberOnly)
        Me.Controls.Add(Me.LabelNhapSo)
        Me.Controls.Add(Me.TextBoxKetQua)
        Me.Controls.Add(Me.LabelKetQua)
        Me.Controls.Add(Me.ButtonTinh)
        Me.Controls.Add(Me.LabelSoThuHai)
        Me.Controls.Add(Me.TextBoxSoThuHai)
        Me.Controls.Add(Me.LabelSoThuNhat)
        Me.Controls.Add(Me.TextBoxSoThuNhat)
        Me.Name = "frmTinhHaiSo"
        Me.Text = "frmTinhHaiSo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxSoThuNhat As TextBox
    Friend WithEvents LabelSoThuNhat As Label
    Friend WithEvents LabelSoThuHai As Label
    Friend WithEvents TextBoxSoThuHai As TextBox
    Friend WithEvents ButtonTinh As Button
    Friend WithEvents LabelKetQua As Label
    Friend WithEvents TextBoxKetQua As TextBox
    Friend WithEvents LabelNhapSo As Label
    Friend WithEvents TextBoxNumberOnly As TextBox
    Friend WithEvents ButtonReset As Button
    Friend WithEvents ButtonExit As Button
End Class
