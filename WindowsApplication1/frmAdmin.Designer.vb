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
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
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
        Me.btnMasterPhone.TabIndex = 0
        Me.btnMasterPhone.Text = "電話番号"
        Me.btnMasterPhone.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnMasterCar)
        Me.GroupBox1.Controls.Add(Me.btnMasterStaff)
        Me.GroupBox1.Controls.Add(Me.btnMasterPhone)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(119, 115)
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
        Me.btnMasterCar.TabIndex = 2
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
        Me.btnMasterStaff.TabIndex = 1
        Me.btnMasterStaff.Text = "社員情報"
        Me.btnMasterStaff.UseVisualStyleBackColor = False
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(21, 133)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(98, 23)
        Me.btnExport.TabIndex = 2
        Me.btnExport.Text = "CSVエクスポート"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(202, 196)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 231)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnExport)
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
    Friend WithEvents btnExport As Button
    Friend WithEvents btnClose As Button
End Class
