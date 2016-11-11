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
        Me.btnMasterStaff = New System.Windows.Forms.Button()
        Me.btnMasterCar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMasterPhone
        '
        Me.btnMasterPhone.Location = New System.Drawing.Point(9, 18)
        Me.btnMasterPhone.Name = "btnMasterPhone"
        Me.btnMasterPhone.Size = New System.Drawing.Size(98, 23)
        Me.btnMasterPhone.TabIndex = 0
        Me.btnMasterPhone.Text = "電話番号"
        Me.btnMasterPhone.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Text = "新規登録"
        '
        'btnMasterStaff
        '
        Me.btnMasterStaff.Location = New System.Drawing.Point(9, 47)
        Me.btnMasterStaff.Name = "btnMasterStaff"
        Me.btnMasterStaff.Size = New System.Drawing.Size(98, 23)
        Me.btnMasterStaff.TabIndex = 1
        Me.btnMasterStaff.Text = "社員情報"
        Me.btnMasterStaff.UseVisualStyleBackColor = True
        '
        'btnMasterCar
        '
        Me.btnMasterCar.Location = New System.Drawing.Point(9, 76)
        Me.btnMasterCar.Name = "btnMasterCar"
        Me.btnMasterCar.Size = New System.Drawing.Size(98, 23)
        Me.btnMasterCar.TabIndex = 2
        Me.btnMasterCar.Text = "車両情報"
        Me.btnMasterCar.UseVisualStyleBackColor = True
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 261)
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
End Class
