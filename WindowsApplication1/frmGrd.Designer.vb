<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrd))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DtIntegBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.DtIntegBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSet = New MAd.PhoneNumDBDataSet()
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
        Me.DtIntegBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.grdMain = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbBranchStaff = New System.Windows.Forms.ComboBox()
        Me.txtFilterPhonenum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFilterKana = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnKa = New System.Windows.Forms.Button()
        Me.btnSa = New System.Windows.Forms.Button()
        Me.btnTa = New System.Windows.Forms.Button()
        Me.btnNa = New System.Windows.Forms.Button()
        Me.btnHa = New System.Windows.Forms.Button()
        Me.btnMa = New System.Windows.Forms.Button()
        Me.btnYa = New System.Windows.Forms.Button()
        Me.btnRa = New System.Windows.Forms.Button()
        Me.btnWa = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn1000 = New System.Windows.Forms.Button()
        Me.btn2000 = New System.Windows.Forms.Button()
        Me.btn3000 = New System.Windows.Forms.Button()
        Me.btn4000 = New System.Windows.Forms.Button()
        Me.btn5000 = New System.Windows.Forms.Button()
        Me.btn6000 = New System.Windows.Forms.Button()
        Me.btn7000 = New System.Windows.Forms.Button()
        Me.btn8000 = New System.Windows.Forms.Button()
        Me.btn9000 = New System.Windows.Forms.Button()
        Me.DtIntegTableAdapter = New MAd.PhoneNumDBDataSetTableAdapters.dtIntegTableAdapter()
        Me.TableAdapterManager = New MAd.PhoneNumDBDataSetTableAdapters.TableAdapterManager()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbBranchCar = New System.Windows.Forms.ComboBox()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFilterClear = New System.Windows.Forms.Button()
        CType(Me.DtIntegBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DtIntegBindingNavigator.SuspendLayout()
        CType(Me.DtIntegBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DtIntegBindingNavigator
        '
        Me.DtIntegBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DtIntegBindingNavigator.BindingSource = Me.DtIntegBindingSource
        Me.DtIntegBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DtIntegBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DtIntegBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DtIntegBindingNavigatorSaveItem})
        Me.DtIntegBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DtIntegBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DtIntegBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DtIntegBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DtIntegBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DtIntegBindingNavigator.Name = "DtIntegBindingNavigator"
        Me.DtIntegBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DtIntegBindingNavigator.Size = New System.Drawing.Size(1087, 31)
        Me.DtIntegBindingNavigator.TabIndex = 0
        Me.DtIntegBindingNavigator.Text = "BindingNavigator1"
        Me.DtIntegBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 28)
        Me.BindingNavigatorAddNewItem.Text = "新規追加"
        '
        'DtIntegBindingSource
        '
        Me.DtIntegBindingSource.DataMember = "dtInteg"
        Me.DtIntegBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'PhoneNumDBDataSet
        '
        Me.PhoneNumDBDataSet.DataSetName = "PhoneNumDBDataSet"
        Me.PhoneNumDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目の総数"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 28)
        Me.BindingNavigatorDeleteItem.Text = "削除"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "最初に移動"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "前に戻る"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "現在の場所"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 28)
        Me.BindingNavigatorMoveNextItem.Text = "次に移動"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 28)
        Me.BindingNavigatorMoveLastItem.Text = "最後に移動"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'DtIntegBindingNavigatorSaveItem
        '
        Me.DtIntegBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DtIntegBindingNavigatorSaveItem.Enabled = False
        Me.DtIntegBindingNavigatorSaveItem.Image = CType(resources.GetObject("DtIntegBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DtIntegBindingNavigatorSaveItem.Name = "DtIntegBindingNavigatorSaveItem"
        Me.DtIntegBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 28)
        Me.DtIntegBindingNavigatorSaveItem.Text = "データの保存"
        '
        'grdMain
        '
        Me.grdMain.AllowUserToAddRows = False
        Me.grdMain.AllowUserToDeleteRows = False
        Me.grdMain.AllowUserToResizeColumns = False
        Me.grdMain.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.grdMain.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.grdMain.AutoGenerateColumns = False
        Me.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.grdMain.DataSource = Me.DtIntegBindingSource
        Me.grdMain.Location = New System.Drawing.Point(115, 88)
        Me.grdMain.Margin = New System.Windows.Forms.Padding(4)
        Me.grdMain.Name = "grdMain"
        Me.grdMain.ReadOnly = True
        Me.grdMain.RowHeadersWidth = 25
        Me.grdMain.RowTemplate.Height = 21
        Me.grdMain.Size = New System.Drawing.Size(709, 284)
        Me.grdMain.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "integ_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "integ_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "integ_phonenum"
        Me.DataGridViewTextBoxColumn2.HeaderText = "integ_phonenum"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "integ_staff"
        Me.DataGridViewTextBoxColumn3.HeaderText = "integ_staff"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "integ_carnum"
        Me.DataGridViewTextBoxColumn4.HeaderText = "integ_carnum"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "phonenum"
        Me.DataGridViewTextBoxColumn5.HeaderText = "電話番号"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 130
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "mail"
        Me.DataGridViewTextBoxColumn6.HeaderText = "mail"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "biko"
        Me.DataGridViewTextBoxColumn7.HeaderText = "biko"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "model"
        Me.DataGridViewTextBoxColumn8.HeaderText = "model"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "id_staff"
        Me.DataGridViewTextBoxColumn9.HeaderText = "id_staff"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "staff_name"
        Me.DataGridViewTextBoxColumn10.HeaderText = "氏名"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 130
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "staff_kana"
        Me.DataGridViewTextBoxColumn11.HeaderText = "staff_kana"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "branch_id"
        Me.DataGridViewTextBoxColumn12.HeaderText = "branch_id"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "car_branch"
        Me.DataGridViewTextBoxColumn13.HeaderText = "car_branch"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "car_biko"
        Me.DataGridViewTextBoxColumn14.HeaderText = "car_biko"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "staff_branch_name"
        Me.DataGridViewTextBoxColumn24.HeaderText = "所属"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 80
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "carnum1"
        Me.DataGridViewTextBoxColumn20.HeaderText = "車番"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 80
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "ton"
        Me.DataGridViewTextBoxColumn15.HeaderText = "車格"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 80
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "musen"
        Me.DataGridViewTextBoxColumn16.HeaderText = "無線"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 80
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "carnum4"
        Me.DataGridViewTextBoxColumn17.HeaderText = "carnum4"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "carnum3"
        Me.DataGridViewTextBoxColumn18.HeaderText = "carnum3"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "carnum2"
        Me.DataGridViewTextBoxColumn19.HeaderText = "carnum2"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "branch_name"
        Me.DataGridViewTextBoxColumn21.HeaderText = "車庫"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 80
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "id_branch"
        Me.DataGridViewTextBoxColumn22.HeaderText = "id_branch"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Visible = False
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "staff_branch_id"
        Me.DataGridViewTextBoxColumn23.HeaderText = "staff_branch_id"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Visible = False
        '
        'cmbBranchStaff
        '
        Me.cmbBranchStaff.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbBranchStaff.FormattingEnabled = True
        Me.cmbBranchStaff.Location = New System.Drawing.Point(329, 16)
        Me.cmbBranchStaff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbBranchStaff.Name = "cmbBranchStaff"
        Me.cmbBranchStaff.Size = New System.Drawing.Size(77, 20)
        Me.cmbBranchStaff.TabIndex = 2
        '
        'txtFilterPhonenum
        '
        Me.txtFilterPhonenum.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtFilterPhonenum.Location = New System.Drawing.Point(76, 17)
        Me.txtFilterPhonenum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFilterPhonenum.Name = "txtFilterPhonenum"
        Me.txtFilterPhonenum.Size = New System.Drawing.Size(75, 19)
        Me.txtFilterPhonenum.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "電話番号"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(159, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "氏名ｶﾅ"
        '
        'txtFilterKana
        '
        Me.txtFilterKana.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtFilterKana.Location = New System.Drawing.Point(209, 17)
        Me.txtFilterKana.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFilterKana.Name = "txtFilterKana"
        Me.txtFilterKana.Size = New System.Drawing.Size(75, 19)
        Me.txtFilterKana.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(294, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "所属"
        '
        'btnA
        '
        Me.btnA.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnA.Location = New System.Drawing.Point(19, 88)
        Me.btnA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(27, 22)
        Me.btnA.TabIndex = 9
        Me.btnA.Text = "ｱ"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnKa
        '
        Me.btnKa.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnKa.Location = New System.Drawing.Point(19, 116)
        Me.btnKa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnKa.Name = "btnKa"
        Me.btnKa.Size = New System.Drawing.Size(27, 22)
        Me.btnKa.TabIndex = 10
        Me.btnKa.Text = "ｶ"
        Me.btnKa.UseVisualStyleBackColor = True
        '
        'btnSa
        '
        Me.btnSa.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnSa.Location = New System.Drawing.Point(19, 145)
        Me.btnSa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSa.Name = "btnSa"
        Me.btnSa.Size = New System.Drawing.Size(27, 22)
        Me.btnSa.TabIndex = 11
        Me.btnSa.Text = "ｻ"
        Me.btnSa.UseVisualStyleBackColor = True
        '
        'btnTa
        '
        Me.btnTa.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnTa.Location = New System.Drawing.Point(19, 174)
        Me.btnTa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTa.Name = "btnTa"
        Me.btnTa.Size = New System.Drawing.Size(27, 22)
        Me.btnTa.TabIndex = 12
        Me.btnTa.Text = "ﾀ"
        Me.btnTa.UseVisualStyleBackColor = True
        '
        'btnNa
        '
        Me.btnNa.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnNa.Location = New System.Drawing.Point(19, 202)
        Me.btnNa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNa.Name = "btnNa"
        Me.btnNa.Size = New System.Drawing.Size(27, 22)
        Me.btnNa.TabIndex = 13
        Me.btnNa.Text = "ﾅ"
        Me.btnNa.UseVisualStyleBackColor = True
        '
        'btnHa
        '
        Me.btnHa.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnHa.Location = New System.Drawing.Point(19, 232)
        Me.btnHa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHa.Name = "btnHa"
        Me.btnHa.Size = New System.Drawing.Size(27, 22)
        Me.btnHa.TabIndex = 14
        Me.btnHa.Text = "ﾊ"
        Me.btnHa.UseVisualStyleBackColor = True
        '
        'btnMa
        '
        Me.btnMa.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnMa.Location = New System.Drawing.Point(19, 261)
        Me.btnMa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMa.Name = "btnMa"
        Me.btnMa.Size = New System.Drawing.Size(27, 22)
        Me.btnMa.TabIndex = 15
        Me.btnMa.Text = "ﾏ"
        Me.btnMa.UseVisualStyleBackColor = True
        '
        'btnYa
        '
        Me.btnYa.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnYa.Location = New System.Drawing.Point(19, 290)
        Me.btnYa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnYa.Name = "btnYa"
        Me.btnYa.Size = New System.Drawing.Size(27, 22)
        Me.btnYa.TabIndex = 16
        Me.btnYa.Text = "ﾔ"
        Me.btnYa.UseVisualStyleBackColor = True
        '
        'btnRa
        '
        Me.btnRa.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnRa.Location = New System.Drawing.Point(19, 319)
        Me.btnRa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRa.Name = "btnRa"
        Me.btnRa.Size = New System.Drawing.Size(27, 22)
        Me.btnRa.TabIndex = 17
        Me.btnRa.Text = "ﾗ"
        Me.btnRa.UseVisualStyleBackColor = True
        '
        'btnWa
        '
        Me.btnWa.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnWa.Location = New System.Drawing.Point(19, 348)
        Me.btnWa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnWa.Name = "btnWa"
        Me.btnWa.Size = New System.Drawing.Size(27, 22)
        Me.btnWa.TabIndex = 18
        Me.btnWa.Text = "ﾜ"
        Me.btnWa.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn1.Location = New System.Drawing.Point(51, 88)
        Me.btn1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(57, 22)
        Me.btn1.TabIndex = 20
        Me.btn1.Text = "1-"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn1000
        '
        Me.btn1000.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn1000.Location = New System.Drawing.Point(51, 116)
        Me.btn1000.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn1000.Name = "btn1000"
        Me.btn1000.Size = New System.Drawing.Size(57, 22)
        Me.btn1000.TabIndex = 21
        Me.btn1000.Text = "1000-"
        Me.btn1000.UseVisualStyleBackColor = True
        '
        'btn2000
        '
        Me.btn2000.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn2000.Location = New System.Drawing.Point(51, 145)
        Me.btn2000.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn2000.Name = "btn2000"
        Me.btn2000.Size = New System.Drawing.Size(57, 22)
        Me.btn2000.TabIndex = 22
        Me.btn2000.Text = "2000-"
        Me.btn2000.UseVisualStyleBackColor = True
        '
        'btn3000
        '
        Me.btn3000.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn3000.Location = New System.Drawing.Point(51, 174)
        Me.btn3000.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn3000.Name = "btn3000"
        Me.btn3000.Size = New System.Drawing.Size(57, 22)
        Me.btn3000.TabIndex = 23
        Me.btn3000.Text = "3000-"
        Me.btn3000.UseVisualStyleBackColor = True
        '
        'btn4000
        '
        Me.btn4000.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn4000.Location = New System.Drawing.Point(51, 202)
        Me.btn4000.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn4000.Name = "btn4000"
        Me.btn4000.Size = New System.Drawing.Size(57, 22)
        Me.btn4000.TabIndex = 24
        Me.btn4000.Text = "4000-"
        Me.btn4000.UseVisualStyleBackColor = True
        '
        'btn5000
        '
        Me.btn5000.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn5000.Location = New System.Drawing.Point(51, 232)
        Me.btn5000.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn5000.Name = "btn5000"
        Me.btn5000.Size = New System.Drawing.Size(57, 22)
        Me.btn5000.TabIndex = 25
        Me.btn5000.Text = "5000-"
        Me.btn5000.UseVisualStyleBackColor = True
        '
        'btn6000
        '
        Me.btn6000.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn6000.Location = New System.Drawing.Point(51, 261)
        Me.btn6000.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn6000.Name = "btn6000"
        Me.btn6000.Size = New System.Drawing.Size(57, 22)
        Me.btn6000.TabIndex = 26
        Me.btn6000.Text = "6000-"
        Me.btn6000.UseVisualStyleBackColor = True
        '
        'btn7000
        '
        Me.btn7000.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn7000.Location = New System.Drawing.Point(51, 290)
        Me.btn7000.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn7000.Name = "btn7000"
        Me.btn7000.Size = New System.Drawing.Size(57, 22)
        Me.btn7000.TabIndex = 27
        Me.btn7000.Text = "7000-"
        Me.btn7000.UseVisualStyleBackColor = True
        '
        'btn8000
        '
        Me.btn8000.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn8000.Location = New System.Drawing.Point(51, 319)
        Me.btn8000.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn8000.Name = "btn8000"
        Me.btn8000.Size = New System.Drawing.Size(57, 22)
        Me.btn8000.TabIndex = 28
        Me.btn8000.Text = "8000-"
        Me.btn8000.UseVisualStyleBackColor = True
        '
        'btn9000
        '
        Me.btn9000.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn9000.Location = New System.Drawing.Point(51, 348)
        Me.btn9000.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn9000.Name = "btn9000"
        Me.btn9000.Size = New System.Drawing.Size(57, 22)
        Me.btn9000.TabIndex = 29
        Me.btn9000.Text = "9000-"
        Me.btn9000.UseVisualStyleBackColor = True
        '
        'DtIntegTableAdapter
        '
        Me.DtIntegTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tbl_branchTableAdapter = Nothing
        Me.TableAdapterManager.tbl_carTableAdapter = Nothing
        Me.TableAdapterManager.tbl_feeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_IntegrateTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PhoneNumTableAdapter = Nothing
        Me.TableAdapterManager.tbl_staffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MAd.PhoneNumDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(421, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "車庫"
        '
        'cmbBranchCar
        '
        Me.cmbBranchCar.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbBranchCar.FormattingEnabled = True
        Me.cmbBranchCar.Location = New System.Drawing.Point(456, 16)
        Me.cmbBranchCar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbBranchCar.Name = "cmbBranchCar"
        Me.cmbBranchCar.Size = New System.Drawing.Size(77, 20)
        Me.cmbBranchCar.TabIndex = 30
        '
        'btnModify
        '
        Me.btnModify.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnModify.Location = New System.Drawing.Point(115, 50)
        Me.btnModify.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(89, 22)
        Me.btnModify.TabIndex = 33
        Me.btnModify.Text = "選択行の編集"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnAdmin.Location = New System.Drawing.Point(19, 11)
        Me.btnAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(89, 22)
        Me.btnAdmin.TabIndex = 34
        Me.btnAdmin.Text = "管理メニュー"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFilterClear)
        Me.GroupBox1.Controls.Add(Me.txtFilterPhonenum)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFilterKana)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbBranchCar)
        Me.GroupBox1.Controls.Add(Me.cmbBranchStaff)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(210, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(614, 47)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "絞り込み"
        '
        'btnFilterClear
        '
        Me.btnFilterClear.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnFilterClear.Location = New System.Drawing.Point(550, 14)
        Me.btnFilterClear.Name = "btnFilterClear"
        Me.btnFilterClear.Size = New System.Drawing.Size(49, 23)
        Me.btnFilterClear.TabIndex = 36
        Me.btnFilterClear.Text = "解除"
        Me.btnFilterClear.UseVisualStyleBackColor = True
        '
        'frmGrd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 384)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btn9000)
        Me.Controls.Add(Me.btn8000)
        Me.Controls.Add(Me.btn7000)
        Me.Controls.Add(Me.btn6000)
        Me.Controls.Add(Me.btn5000)
        Me.Controls.Add(Me.btn4000)
        Me.Controls.Add(Me.btn3000)
        Me.Controls.Add(Me.btn2000)
        Me.Controls.Add(Me.btn1000)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btnWa)
        Me.Controls.Add(Me.btnRa)
        Me.Controls.Add(Me.btnYa)
        Me.Controls.Add(Me.btnMa)
        Me.Controls.Add(Me.btnHa)
        Me.Controls.Add(Me.btnNa)
        Me.Controls.Add(Me.btnTa)
        Me.Controls.Add(Me.btnSa)
        Me.Controls.Add(Me.btnKa)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.grdMain)
        Me.Controls.Add(Me.DtIntegBindingNavigator)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmGrd"
        Me.Text = "MAd"
        CType(Me.DtIntegBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DtIntegBindingNavigator.ResumeLayout(False)
        Me.DtIntegBindingNavigator.PerformLayout()
        CType(Me.DtIntegBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PhoneNumDBDataSet As PhoneNumDBDataSet
    Friend WithEvents DtIntegBindingSource As BindingSource
    Friend WithEvents DtIntegTableAdapter As PhoneNumDBDataSetTableAdapters.dtIntegTableAdapter
    Friend WithEvents TableAdapterManager As PhoneNumDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DtIntegBindingNavigator As BindingNavigator
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
    Friend WithEvents DtIntegBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents grdMain As DataGridView
    Friend WithEvents cmbBranchStaff As ComboBox
    Friend WithEvents txtFilterPhonenum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFilterKana As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnA As Button
    Friend WithEvents btnKa As Button
    Friend WithEvents btnSa As Button
    Friend WithEvents btnTa As Button
    Friend WithEvents btnNa As Button
    Friend WithEvents btnHa As Button
    Friend WithEvents btnMa As Button
    Friend WithEvents btnYa As Button
    Friend WithEvents btnRa As Button
    Friend WithEvents btnWa As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn1000 As Button
    Friend WithEvents btn2000 As Button
    Friend WithEvents btn3000 As Button
    Friend WithEvents btn4000 As Button
    Friend WithEvents btn5000 As Button
    Friend WithEvents btn6000 As Button
    Friend WithEvents btn7000 As Button
    Friend WithEvents btn8000 As Button
    Friend WithEvents btn9000 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbBranchCar As ComboBox
    Friend WithEvents btnModify As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnFilterClear As Button
End Class
