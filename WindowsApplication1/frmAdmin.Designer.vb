<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnMasterPhone = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnMasterCar = New System.Windows.Forms.Button()
        Me.btnMasterStaff = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnImportPhone = New System.Windows.Forms.Button()
        Me.btnExportPhone = New System.Windows.Forms.Button()
        Me.btnImportStaff = New System.Windows.Forms.Button()
        Me.btnExportStaff = New System.Windows.Forms.Button()
        Me.btnImportCar = New System.Windows.Forms.Button()
        Me.btnExportCar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMasterPhone
        '
        Me.btnMasterPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMasterPhone.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMasterPhone.ForeColor = System.Drawing.Color.Black
        Me.btnMasterPhone.Location = New System.Drawing.Point(9, 18)
        Me.btnMasterPhone.Name = "btnMasterPhone"
        Me.btnMasterPhone.Size = New System.Drawing.Size(98, 23)
        Me.btnMasterPhone.TabIndex = 1
        Me.btnMasterPhone.Text = "電話番号"
        Me.btnMasterPhone.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExportCar)
        Me.GroupBox1.Controls.Add(Me.btnImportCar)
        Me.GroupBox1.Controls.Add(Me.btnExportStaff)
        Me.GroupBox1.Controls.Add(Me.btnImportStaff)
        Me.GroupBox1.Controls.Add(Me.btnExportPhone)
        Me.GroupBox1.Controls.Add(Me.btnImportPhone)
        Me.GroupBox1.Controls.Add(Me.btnMasterCar)
        Me.GroupBox1.Controls.Add(Me.btnMasterStaff)
        Me.GroupBox1.Controls.Add(Me.btnMasterPhone)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 115)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "マスタ管理"
        '
        'btnMasterCar
        '
        Me.btnMasterCar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMasterCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMasterCar.Location = New System.Drawing.Point(9, 76)
        Me.btnMasterCar.Name = "btnMasterCar"
        Me.btnMasterCar.Size = New System.Drawing.Size(98, 23)
        Me.btnMasterCar.TabIndex = 3
        Me.btnMasterCar.Text = "車両情報"
        Me.btnMasterCar.UseVisualStyleBackColor = False
        '
        'btnMasterStaff
        '
        Me.btnMasterStaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMasterStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMasterStaff.Location = New System.Drawing.Point(9, 47)
        Me.btnMasterStaff.Name = "btnMasterStaff"
        Me.btnMasterStaff.Size = New System.Drawing.Size(98, 23)
        Me.btnMasterStaff.TabIndex = 2
        Me.btnMasterStaff.Text = "社員情報"
        Me.btnMasterStaff.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(167, 142)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnImportPhone
        '
        Me.btnImportPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnImportPhone.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImportPhone.ForeColor = System.Drawing.Color.Black
        Me.btnImportPhone.Location = New System.Drawing.Point(113, 18)
        Me.btnImportPhone.Name = "btnImportPhone"
        Me.btnImportPhone.Size = New System.Drawing.Size(98, 23)
        Me.btnImportPhone.TabIndex = 4
        Me.btnImportPhone.Text = "csvインポート"
        Me.btnImportPhone.UseVisualStyleBackColor = False
        '
        'btnExportPhone
        '
        Me.btnExportPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExportPhone.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExportPhone.ForeColor = System.Drawing.Color.Black
        Me.btnExportPhone.Location = New System.Drawing.Point(217, 18)
        Me.btnExportPhone.Name = "btnExportPhone"
        Me.btnExportPhone.Size = New System.Drawing.Size(98, 23)
        Me.btnExportPhone.TabIndex = 5
        Me.btnExportPhone.Text = "csvエクスポート"
        Me.btnExportPhone.UseVisualStyleBackColor = False
        '
        'btnImportStaff
        '
        Me.btnImportStaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnImportStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImportStaff.Location = New System.Drawing.Point(114, 46)
        Me.btnImportStaff.Name = "btnImportStaff"
        Me.btnImportStaff.Size = New System.Drawing.Size(98, 23)
        Me.btnImportStaff.TabIndex = 6
        Me.btnImportStaff.Text = "csvインポート"
        Me.btnImportStaff.UseVisualStyleBackColor = False
        '
        'btnExportStaff
        '
        Me.btnExportStaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExportStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExportStaff.Location = New System.Drawing.Point(217, 46)
        Me.btnExportStaff.Name = "btnExportStaff"
        Me.btnExportStaff.Size = New System.Drawing.Size(98, 23)
        Me.btnExportStaff.TabIndex = 7
        Me.btnExportStaff.Text = "csvエクスポート"
        Me.btnExportStaff.UseVisualStyleBackColor = False
        '
        'btnImportCar
        '
        Me.btnImportCar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnImportCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImportCar.Location = New System.Drawing.Point(114, 75)
        Me.btnImportCar.Name = "btnImportCar"
        Me.btnImportCar.Size = New System.Drawing.Size(98, 23)
        Me.btnImportCar.TabIndex = 8
        Me.btnImportCar.Text = "csvインポート"
        Me.btnImportCar.UseVisualStyleBackColor = False
        '
        'btnExportCar
        '
        Me.btnExportCar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExportCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExportCar.Location = New System.Drawing.Point(218, 75)
        Me.btnExportCar.Name = "btnExportCar"
        Me.btnExportCar.Size = New System.Drawing.Size(98, 23)
        Me.btnExportCar.TabIndex = 9
        Me.btnExportCar.Text = "csvエクスポート"
        Me.btnExportCar.UseVisualStyleBackColor = False
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 273)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAdmin"
        Me.Text = "管理メニュー"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMasterPhone As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnMasterCar As Button
    Friend WithEvents btnMasterStaff As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnExportPhone As Button
    Friend WithEvents btnImportPhone As Button
    Friend WithEvents btnExportCar As Button
    Friend WithEvents btnImportCar As Button
    Friend WithEvents btnExportStaff As Button
    Friend WithEvents btnImportStaff As Button
End Class
