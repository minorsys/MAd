<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterCar
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
        Me.components = New System.ComponentModel.Container()
        Me.cmbTon = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Carnum1Label = New System.Windows.Forms.Label()
        Me.txtCarnum1 = New System.Windows.Forms.TextBox()
        Me.Carnum2Label = New System.Windows.Forms.Label()
        Me.txtCarnum2 = New System.Windows.Forms.TextBox()
        Me.Carnum3Label = New System.Windows.Forms.Label()
        Me.txtCarnum3 = New System.Windows.Forms.TextBox()
        Me.Carnum4Label = New System.Windows.Forms.Label()
        Me.txtCarnum4 = New System.Windows.Forms.TextBox()
        Me.MusenLabel = New System.Windows.Forms.Label()
        Me.txtMusen = New System.Windows.Forms.TextBox()
        Me.TonLabel = New System.Windows.Forms.Label()
        Me.BikoLabel = New System.Windows.Forms.Label()
        Me.txtBiko = New System.Windows.Forms.TextBox()
        Me.Branch_idLabel = New System.Windows.Forms.Label()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.Tbl_carBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSet = New MAd.PhoneNumDBDataSet()
        Me.TblbranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_carTableAdapter = New MAd.PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter()
        Me.TableAdapterManager = New MAd.PhoneNumDBDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_branchTableAdapter = New MAd.PhoneNumDBDataSetTableAdapters.tbl_branchTableAdapter()
        Me.Tbl_carBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_carBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        CType(Me.Tbl_carBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblbranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_carBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_carBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbTon
        '
        Me.cmbTon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTon.FormattingEnabled = True
        Me.cmbTon.Location = New System.Drawing.Point(82, 135)
        Me.cmbTon.Name = "cmbTon"
        Me.cmbTon.Size = New System.Drawing.Size(92, 20)
        Me.cmbTon.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(152, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 12)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "(半角数字4桁)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 12)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "(き)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 12)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "(100)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(152, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 12)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "(足立)"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(219, 342)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(55, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "閉じる"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(156, 342)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(57, 23)
        Me.btnRegister.TabIndex = 9
        Me.btnRegister.Text = "登録"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Carnum1Label
        '
        Me.Carnum1Label.AutoSize = True
        Me.Carnum1Label.Location = New System.Drawing.Point(22, 13)
        Me.Carnum1Label.Name = "Carnum1Label"
        Me.Carnum1Label.Size = New System.Drawing.Size(53, 12)
        Me.Carnum1Label.TabIndex = 24
        Me.Carnum1Label.Text = "車両番号"
        '
        'txtCarnum1
        '
        Me.txtCarnum1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtCarnum1.Location = New System.Drawing.Point(82, 10)
        Me.txtCarnum1.Name = "txtCarnum1"
        Me.txtCarnum1.Size = New System.Drawing.Size(64, 19)
        Me.txtCarnum1.TabIndex = 1
        '
        'Carnum2Label
        '
        Me.Carnum2Label.AutoSize = True
        Me.Carnum2Label.Location = New System.Drawing.Point(36, 38)
        Me.Carnum2Label.Name = "Carnum2Label"
        Me.Carnum2Label.Size = New System.Drawing.Size(29, 12)
        Me.Carnum2Label.TabIndex = 27
        Me.Carnum2Label.Text = "地名"
        '
        'txtCarnum2
        '
        Me.txtCarnum2.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtCarnum2.Location = New System.Drawing.Point(82, 35)
        Me.txtCarnum2.Name = "txtCarnum2"
        Me.txtCarnum2.Size = New System.Drawing.Size(64, 19)
        Me.txtCarnum2.TabIndex = 2
        '
        'Carnum3Label
        '
        Me.Carnum3Label.AutoSize = True
        Me.Carnum3Label.Location = New System.Drawing.Point(22, 63)
        Me.Carnum3Label.Name = "Carnum3Label"
        Me.Carnum3Label.Size = New System.Drawing.Size(53, 12)
        Me.Carnum3Label.TabIndex = 30
        Me.Carnum3Label.Text = "分類番号"
        '
        'txtCarnum3
        '
        Me.txtCarnum3.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtCarnum3.Location = New System.Drawing.Point(82, 60)
        Me.txtCarnum3.Name = "txtCarnum3"
        Me.txtCarnum3.Size = New System.Drawing.Size(64, 19)
        Me.txtCarnum3.TabIndex = 3
        '
        'Carnum4Label
        '
        Me.Carnum4Label.AutoSize = True
        Me.Carnum4Label.Location = New System.Drawing.Point(22, 88)
        Me.Carnum4Label.Name = "Carnum4Label"
        Me.Carnum4Label.Size = New System.Drawing.Size(43, 12)
        Me.Carnum4Label.TabIndex = 32
        Me.Carnum4Label.Text = "ひらがな"
        '
        'txtCarnum4
        '
        Me.txtCarnum4.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtCarnum4.Location = New System.Drawing.Point(82, 85)
        Me.txtCarnum4.Name = "txtCarnum4"
        Me.txtCarnum4.Size = New System.Drawing.Size(64, 19)
        Me.txtCarnum4.TabIndex = 4
        '
        'MusenLabel
        '
        Me.MusenLabel.AutoSize = True
        Me.MusenLabel.Location = New System.Drawing.Point(22, 113)
        Me.MusenLabel.Name = "MusenLabel"
        Me.MusenLabel.Size = New System.Drawing.Size(53, 12)
        Me.MusenLabel.TabIndex = 34
        Me.MusenLabel.Text = "無線番号"
        '
        'txtMusen
        '
        Me.txtMusen.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtMusen.Location = New System.Drawing.Point(82, 110)
        Me.txtMusen.Name = "txtMusen"
        Me.txtMusen.Size = New System.Drawing.Size(64, 19)
        Me.txtMusen.TabIndex = 5
        '
        'TonLabel
        '
        Me.TonLabel.AutoSize = True
        Me.TonLabel.Location = New System.Drawing.Point(36, 138)
        Me.TonLabel.Name = "TonLabel"
        Me.TonLabel.Size = New System.Drawing.Size(29, 12)
        Me.TonLabel.TabIndex = 37
        Me.TonLabel.Text = "車格"
        '
        'BikoLabel
        '
        Me.BikoLabel.AutoSize = True
        Me.BikoLabel.Location = New System.Drawing.Point(36, 190)
        Me.BikoLabel.Name = "BikoLabel"
        Me.BikoLabel.Size = New System.Drawing.Size(29, 12)
        Me.BikoLabel.TabIndex = 38
        Me.BikoLabel.Text = "備考"
        '
        'txtBiko
        '
        Me.txtBiko.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtBiko.Location = New System.Drawing.Point(82, 187)
        Me.txtBiko.Multiline = True
        Me.txtBiko.Name = "txtBiko"
        Me.txtBiko.Size = New System.Drawing.Size(192, 149)
        Me.txtBiko.TabIndex = 8
        '
        'Branch_idLabel
        '
        Me.Branch_idLabel.AutoSize = True
        Me.Branch_idLabel.Location = New System.Drawing.Point(36, 163)
        Me.Branch_idLabel.Name = "Branch_idLabel"
        Me.Branch_idLabel.Size = New System.Drawing.Size(29, 12)
        Me.Branch_idLabel.TabIndex = 39
        Me.Branch_idLabel.Text = "所属"
        '
        'cmbBranch
        '
        Me.cmbBranch.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_carBindingSource, "branch_id", True))
        Me.cmbBranch.DataSource = Me.TblbranchBindingSource
        Me.cmbBranch.DisplayMember = "branch_name"
        Me.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.ItemHeight = 12
        Me.cmbBranch.Location = New System.Drawing.Point(82, 160)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(92, 20)
        Me.cmbBranch.TabIndex = 40
        Me.cmbBranch.ValueMember = "id_branch"
        '
        'Tbl_carBindingSource
        '
        Me.Tbl_carBindingSource.DataMember = "tbl_car"
        Me.Tbl_carBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'PhoneNumDBDataSet
        '
        Me.PhoneNumDBDataSet.DataSetName = "PhoneNumDBDataSet"
        Me.PhoneNumDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblbranchBindingSource
        '
        Me.TblbranchBindingSource.DataMember = "tbl_branch"
        Me.TblbranchBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'Tbl_carTableAdapter
        '
        Me.Tbl_carTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_branchTableAdapter = Me.Tbl_branchTableAdapter
        Me.TableAdapterManager.tbl_carTableAdapter = Me.Tbl_carTableAdapter
        Me.TableAdapterManager.tbl_feeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_IntegrateTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PhoneNumTableAdapter = Nothing
        Me.TableAdapterManager.tbl_staffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MAd.PhoneNumDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_branchTableAdapter
        '
        Me.Tbl_branchTableAdapter.ClearBeforeFill = True
        '
        'Tbl_carBindingNavigator
        '
        Me.Tbl_carBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_carBindingNavigator.BindingSource = Me.Tbl_carBindingSource
        Me.Tbl_carBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_carBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_carBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_carBindingNavigatorSaveItem})
        Me.Tbl_carBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_carBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_carBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_carBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_carBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_carBindingNavigator.Name = "Tbl_carBindingNavigator"
        Me.Tbl_carBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_carBindingNavigator.Size = New System.Drawing.Size(332, 25)
        Me.Tbl_carBindingNavigator.TabIndex = 45
        Me.Tbl_carBindingNavigator.Text = "BindingNavigator1"
        Me.Tbl_carBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "新規追加"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目の総数"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "削除"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "最初に移動"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "前に戻る"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "現在の場所"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "次に移動"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "最後に移動"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tbl_carBindingNavigatorSaveItem
        '
        Me.Tbl_carBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_carBindingNavigatorSaveItem.Name = "Tbl_carBindingNavigatorSaveItem"
        Me.Tbl_carBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_carBindingNavigatorSaveItem.Text = "データの保存"
        '
        'frmMasterCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(307, 378)
        Me.Controls.Add(Me.Tbl_carBindingNavigator)
        Me.Controls.Add(Me.cmbTon)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Carnum1Label)
        Me.Controls.Add(Me.txtCarnum1)
        Me.Controls.Add(Me.Carnum2Label)
        Me.Controls.Add(Me.txtCarnum2)
        Me.Controls.Add(Me.Carnum3Label)
        Me.Controls.Add(Me.txtCarnum3)
        Me.Controls.Add(Me.Carnum4Label)
        Me.Controls.Add(Me.txtCarnum4)
        Me.Controls.Add(Me.MusenLabel)
        Me.Controls.Add(Me.txtMusen)
        Me.Controls.Add(Me.TonLabel)
        Me.Controls.Add(Me.BikoLabel)
        Me.Controls.Add(Me.txtBiko)
        Me.Controls.Add(Me.Branch_idLabel)
        Me.Controls.Add(Me.cmbBranch)
        Me.KeyPreview = True
        Me.Name = "frmMasterCar"
        Me.Text = "車両マスタ新規"
        CType(Me.Tbl_carBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblbranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_carBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_carBindingNavigator.ResumeLayout(False)
        Me.Tbl_carBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbTon As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents Carnum1Label As Label
    Friend WithEvents txtCarnum1 As TextBox
    Friend WithEvents Carnum2Label As Label
    Friend WithEvents txtCarnum2 As TextBox
    Friend WithEvents Carnum3Label As Label
    Friend WithEvents txtCarnum3 As TextBox
    Friend WithEvents Carnum4Label As Label
    Friend WithEvents txtCarnum4 As TextBox
    Friend WithEvents MusenLabel As Label
    Friend WithEvents txtMusen As TextBox
    Friend WithEvents TonLabel As Label
    Friend WithEvents BikoLabel As Label
    Friend WithEvents txtBiko As TextBox
    Friend WithEvents Branch_idLabel As Label
    Friend WithEvents cmbBranch As ComboBox
    Friend WithEvents PhoneNumDBDataSet As PhoneNumDBDataSet
    Friend WithEvents Tbl_carBindingSource As BindingSource
    Friend WithEvents Tbl_carTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter
    Friend WithEvents TableAdapterManager As PhoneNumDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_branchTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_branchTableAdapter
    Friend WithEvents Tbl_carBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Tbl_carBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TblbranchBindingSource As BindingSource
End Class
