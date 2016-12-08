<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddRecord
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
        Dim Branch_idLabel2 As System.Windows.Forms.Label
        Dim Carnum1Label As System.Windows.Forms.Label
        Dim MusenLabel As System.Windows.Forms.Label
        Dim TonLabel As System.Windows.Forms.Label
        Dim BikoLabel1 As System.Windows.Forms.Label
        Dim Id_staffLabel As System.Windows.Forms.Label
        Dim Staff_nameLabel As System.Windows.Forms.Label
        Dim Staff_kanaLabel As System.Windows.Forms.Label
        Dim Branch_idLabel As System.Windows.Forms.Label
        Dim PhonenumLabel As System.Windows.Forms.Label
        Dim MailLabel As System.Windows.Forms.Label
        Dim BikoLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbTon = New System.Windows.Forms.ComboBox()
        Me.btnClearCar = New System.Windows.Forms.Button()
        Me.cmbCarBranch = New System.Windows.Forms.ComboBox()
        Me.Tbl_carBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSet = New MAd.PhoneNumDBDataSet()
        Me.Tbl_branchBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbCarnumChange = New System.Windows.Forms.ComboBox()
        Me.lblIntegCarnum = New System.Windows.Forms.Label()
        Me.Tbl_IntegrateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtCarnum2 = New System.Windows.Forms.TextBox()
        Me.txtCarnum3 = New System.Windows.Forms.TextBox()
        Me.txtCarnum4 = New System.Windows.Forms.TextBox()
        Me.txtMusen = New System.Windows.Forms.TextBox()
        Me.txtTon = New System.Windows.Forms.TextBox()
        Me.txtBikoCar = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClearStaff = New System.Windows.Forms.Button()
        Me.cmbStaffBranch = New System.Windows.Forms.ComboBox()
        Me.Tbl_staffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_branchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblStaffName = New System.Windows.Forms.Label()
        Me.cmbStaffNameChange = New System.Windows.Forms.ComboBox()
        Me.lblIntegStaffID = New System.Windows.Forms.Label()
        Me.txtStaffKana = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClearPhone = New System.Windows.Forms.Button()
        Me.cmbPhonenumChange = New System.Windows.Forms.ComboBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Tbl_PhoneNumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblIntegPhonenum = New System.Windows.Forms.Label()
        Me.txtBikoPhone = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblCarBranch = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStaffBranch = New System.Windows.Forms.Label()
        Me.lblIntegID = New System.Windows.Forms.Label()
        Me.Tbl_PhoneNumTableAdapter = New MAd.PhoneNumDBDataSetTableAdapters.tbl_PhoneNumTableAdapter()
        Me.TableAdapterManager = New MAd.PhoneNumDBDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_staffTableAdapter = New MAd.PhoneNumDBDataSetTableAdapters.tbl_staffTableAdapter()
        Me.Tbl_carTableAdapter = New MAd.PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter()
        Me.Tbl_IntegrateTableAdapter = New MAd.PhoneNumDBDataSetTableAdapters.tbl_IntegrateTableAdapter()
        Me.Tbl_branchTableAdapter = New MAd.PhoneNumDBDataSetTableAdapters.tbl_branchTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Branch_idLabel2 = New System.Windows.Forms.Label()
        Carnum1Label = New System.Windows.Forms.Label()
        MusenLabel = New System.Windows.Forms.Label()
        TonLabel = New System.Windows.Forms.Label()
        BikoLabel1 = New System.Windows.Forms.Label()
        Id_staffLabel = New System.Windows.Forms.Label()
        Staff_nameLabel = New System.Windows.Forms.Label()
        Staff_kanaLabel = New System.Windows.Forms.Label()
        Branch_idLabel = New System.Windows.Forms.Label()
        PhonenumLabel = New System.Windows.Forms.Label()
        MailLabel = New System.Windows.Forms.Label()
        BikoLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Tbl_carBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_branchBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_IntegrateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_staffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_branchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tbl_PhoneNumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Branch_idLabel2
        '
        Branch_idLabel2.AutoSize = True
        Branch_idLabel2.Location = New System.Drawing.Point(13, 234)
        Branch_idLabel2.Name = "Branch_idLabel2"
        Branch_idLabel2.Size = New System.Drawing.Size(29, 12)
        Branch_idLabel2.TabIndex = 18
        Branch_idLabel2.Text = "車庫"
        '
        'Carnum1Label
        '
        Carnum1Label.AutoSize = True
        Carnum1Label.Location = New System.Drawing.Point(13, 34)
        Carnum1Label.Name = "Carnum1Label"
        Carnum1Label.Size = New System.Drawing.Size(29, 12)
        Carnum1Label.TabIndex = 0
        Carnum1Label.Text = "車番"
        '
        'MusenLabel
        '
        MusenLabel.AutoSize = True
        MusenLabel.Location = New System.Drawing.Point(13, 84)
        MusenLabel.Name = "MusenLabel"
        MusenLabel.Size = New System.Drawing.Size(29, 12)
        MusenLabel.TabIndex = 8
        MusenLabel.Text = "無線"
        '
        'TonLabel
        '
        TonLabel.AutoSize = True
        TonLabel.Location = New System.Drawing.Point(13, 109)
        TonLabel.Name = "TonLabel"
        TonLabel.Size = New System.Drawing.Size(29, 12)
        TonLabel.TabIndex = 10
        TonLabel.Text = "車格"
        '
        'BikoLabel1
        '
        BikoLabel1.AutoSize = True
        BikoLabel1.Location = New System.Drawing.Point(13, 134)
        BikoLabel1.Name = "BikoLabel1"
        BikoLabel1.Size = New System.Drawing.Size(29, 12)
        BikoLabel1.TabIndex = 12
        BikoLabel1.Text = "備考"
        '
        'Id_staffLabel
        '
        Id_staffLabel.AutoSize = True
        Id_staffLabel.Location = New System.Drawing.Point(12, 34)
        Id_staffLabel.Name = "Id_staffLabel"
        Id_staffLabel.Size = New System.Drawing.Size(44, 12)
        Id_staffLabel.TabIndex = 0
        Id_staffLabel.Text = "id staff:"
        '
        'Staff_nameLabel
        '
        Staff_nameLabel.AutoSize = True
        Staff_nameLabel.Location = New System.Drawing.Point(13, 84)
        Staff_nameLabel.Name = "Staff_nameLabel"
        Staff_nameLabel.Size = New System.Drawing.Size(29, 12)
        Staff_nameLabel.TabIndex = 2
        Staff_nameLabel.Text = "氏名"
        '
        'Staff_kanaLabel
        '
        Staff_kanaLabel.AutoSize = True
        Staff_kanaLabel.Location = New System.Drawing.Point(13, 109)
        Staff_kanaLabel.Name = "Staff_kanaLabel"
        Staff_kanaLabel.Size = New System.Drawing.Size(44, 12)
        Staff_kanaLabel.TabIndex = 4
        Staff_kanaLabel.Text = "氏名ｶﾅ"
        '
        'Branch_idLabel
        '
        Branch_idLabel.AutoSize = True
        Branch_idLabel.Location = New System.Drawing.Point(13, 134)
        Branch_idLabel.Name = "Branch_idLabel"
        Branch_idLabel.Size = New System.Drawing.Size(29, 12)
        Branch_idLabel.TabIndex = 6
        Branch_idLabel.Text = "所属"
        '
        'PhonenumLabel
        '
        PhonenumLabel.AutoSize = True
        PhonenumLabel.Location = New System.Drawing.Point(18, 38)
        PhonenumLabel.Name = "PhonenumLabel"
        PhonenumLabel.Size = New System.Drawing.Size(29, 12)
        PhonenumLabel.TabIndex = 0
        PhonenumLabel.Text = "番号"
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(17, 90)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(27, 12)
        MailLabel.TabIndex = 2
        MailLabel.Text = "ﾒｰﾙ"
        '
        'BikoLabel
        '
        BikoLabel.AutoSize = True
        BikoLabel.Location = New System.Drawing.Point(17, 116)
        BikoLabel.Name = "BikoLabel"
        BikoLabel.Size = New System.Drawing.Size(29, 12)
        BikoLabel.TabIndex = 4
        BikoLabel.Text = "備考"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(17, 66)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(29, 12)
        ModelLabel.TabIndex = 6
        ModelLabel.Text = "機種"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.cmbTon)
        Me.GroupBox3.Controls.Add(Me.btnClearCar)
        Me.GroupBox3.Controls.Add(Branch_idLabel2)
        Me.GroupBox3.Controls.Add(Me.cmbCarBranch)
        Me.GroupBox3.Controls.Add(Me.cmbCarnumChange)
        Me.GroupBox3.Controls.Add(Me.lblIntegCarnum)
        Me.GroupBox3.Controls.Add(Carnum1Label)
        Me.GroupBox3.Controls.Add(Me.txtCarnum2)
        Me.GroupBox3.Controls.Add(Me.txtCarnum3)
        Me.GroupBox3.Controls.Add(Me.txtCarnum4)
        Me.GroupBox3.Controls.Add(MusenLabel)
        Me.GroupBox3.Controls.Add(Me.txtMusen)
        Me.GroupBox3.Controls.Add(TonLabel)
        Me.GroupBox3.Controls.Add(Me.txtTon)
        Me.GroupBox3.Controls.Add(BikoLabel1)
        Me.GroupBox3.Controls.Add(Me.txtBikoCar)
        Me.GroupBox3.Location = New System.Drawing.Point(502, 43)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(235, 273)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "車両情報"
        '
        'cmbTon
        '
        Me.cmbTon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTon.DropDownWidth = 120
        Me.cmbTon.FormattingEnabled = True
        Me.cmbTon.Location = New System.Drawing.Point(177, 105)
        Me.cmbTon.MaxDropDownItems = 30
        Me.cmbTon.MaxLength = 50
        Me.cmbTon.Name = "cmbTon"
        Me.cmbTon.Size = New System.Drawing.Size(17, 20)
        Me.cmbTon.TabIndex = 17
        '
        'btnClearCar
        '
        Me.btnClearCar.Location = New System.Drawing.Point(161, 30)
        Me.btnClearCar.Name = "btnClearCar"
        Me.btnClearCar.Size = New System.Drawing.Size(49, 20)
        Me.btnClearCar.TabIndex = 11
        Me.btnClearCar.Text = "クリア"
        Me.btnClearCar.UseVisualStyleBackColor = True
        '
        'cmbCarBranch
        '
        Me.cmbCarBranch.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_carBindingSource, "branch_id", True))
        Me.cmbCarBranch.DataSource = Me.Tbl_branchBindingSource2
        Me.cmbCarBranch.DisplayMember = "branch_name"
        Me.cmbCarBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarBranch.FormattingEnabled = True
        Me.cmbCarBranch.Location = New System.Drawing.Point(73, 231)
        Me.cmbCarBranch.Name = "cmbCarBranch"
        Me.cmbCarBranch.Size = New System.Drawing.Size(100, 20)
        Me.cmbCarBranch.TabIndex = 19
        Me.cmbCarBranch.ValueMember = "id_branch"
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
        'Tbl_branchBindingSource2
        '
        Me.Tbl_branchBindingSource2.DataMember = "tbl_branch"
        Me.Tbl_branchBindingSource2.DataSource = Me.PhoneNumDBDataSet
        '
        'cmbCarnumChange
        '
        Me.cmbCarnumChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarnumChange.DropDownWidth = 120
        Me.cmbCarnumChange.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbCarnumChange.FormattingEnabled = True
        Me.cmbCarnumChange.Location = New System.Drawing.Point(140, 30)
        Me.cmbCarnumChange.MaxDropDownItems = 50
        Me.cmbCarnumChange.MaxLength = 50
        Me.cmbCarnumChange.Name = "cmbCarnumChange"
        Me.cmbCarnumChange.Size = New System.Drawing.Size(17, 23)
        Me.cmbCarnumChange.TabIndex = 10
        '
        'lblIntegCarnum
        '
        Me.lblIntegCarnum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_IntegrateBindingSource, "integ_carnum", True))
        Me.lblIntegCarnum.Location = New System.Drawing.Point(71, 34)
        Me.lblIntegCarnum.Name = "lblIntegCarnum"
        Me.lblIntegCarnum.Size = New System.Drawing.Size(100, 12)
        Me.lblIntegCarnum.TabIndex = 18
        '
        'Tbl_IntegrateBindingSource
        '
        Me.Tbl_IntegrateBindingSource.DataMember = "tbl_Integrate"
        Me.Tbl_IntegrateBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'txtCarnum2
        '
        Me.txtCarnum2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "carnum2", True))
        Me.txtCarnum2.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtCarnum2.Location = New System.Drawing.Point(73, 55)
        Me.txtCarnum2.Name = "txtCarnum2"
        Me.txtCarnum2.Size = New System.Drawing.Size(53, 19)
        Me.txtCarnum2.TabIndex = 12
        '
        'txtCarnum3
        '
        Me.txtCarnum3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "carnum3", True))
        Me.txtCarnum3.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtCarnum3.Location = New System.Drawing.Point(132, 55)
        Me.txtCarnum3.Name = "txtCarnum3"
        Me.txtCarnum3.Size = New System.Drawing.Size(39, 19)
        Me.txtCarnum3.TabIndex = 13
        '
        'txtCarnum4
        '
        Me.txtCarnum4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "carnum4", True))
        Me.txtCarnum4.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtCarnum4.Location = New System.Drawing.Point(177, 55)
        Me.txtCarnum4.Name = "txtCarnum4"
        Me.txtCarnum4.Size = New System.Drawing.Size(35, 19)
        Me.txtCarnum4.TabIndex = 14
        '
        'txtMusen
        '
        Me.txtMusen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "musen", True))
        Me.txtMusen.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtMusen.Location = New System.Drawing.Point(73, 81)
        Me.txtMusen.Name = "txtMusen"
        Me.txtMusen.Size = New System.Drawing.Size(100, 19)
        Me.txtMusen.TabIndex = 15
        '
        'txtTon
        '
        Me.txtTon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "ton", True))
        Me.txtTon.Location = New System.Drawing.Point(73, 106)
        Me.txtTon.Name = "txtTon"
        Me.txtTon.ReadOnly = True
        Me.txtTon.Size = New System.Drawing.Size(100, 19)
        Me.txtTon.TabIndex = 16
        '
        'txtBikoCar
        '
        Me.txtBikoCar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "biko", True))
        Me.txtBikoCar.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtBikoCar.Location = New System.Drawing.Point(73, 131)
        Me.txtBikoCar.Multiline = True
        Me.txtBikoCar.Name = "txtBikoCar"
        Me.txtBikoCar.Size = New System.Drawing.Size(139, 95)
        Me.txtBikoCar.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.btnClearStaff)
        Me.GroupBox2.Controls.Add(Me.cmbStaffBranch)
        Me.GroupBox2.Controls.Add(Me.lblStaffName)
        Me.GroupBox2.Controls.Add(Me.cmbStaffNameChange)
        Me.GroupBox2.Controls.Add(Id_staffLabel)
        Me.GroupBox2.Controls.Add(Me.lblIntegStaffID)
        Me.GroupBox2.Controls.Add(Staff_nameLabel)
        Me.GroupBox2.Controls.Add(Staff_kanaLabel)
        Me.GroupBox2.Controls.Add(Me.txtStaffKana)
        Me.GroupBox2.Controls.Add(Branch_idLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(257, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 273)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "社員情報"
        '
        'btnClearStaff
        '
        Me.btnClearStaff.Location = New System.Drawing.Point(170, 30)
        Me.btnClearStaff.Name = "btnClearStaff"
        Me.btnClearStaff.Size = New System.Drawing.Size(49, 20)
        Me.btnClearStaff.TabIndex = 7
        Me.btnClearStaff.Text = "クリア"
        Me.btnClearStaff.UseVisualStyleBackColor = True
        '
        'cmbStaffBranch
        '
        Me.cmbStaffBranch.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_staffBindingSource, "branch_id", True))
        Me.cmbStaffBranch.DataSource = Me.Tbl_branchBindingSource
        Me.cmbStaffBranch.DisplayMember = "branch_name"
        Me.cmbStaffBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaffBranch.FormattingEnabled = True
        Me.cmbStaffBranch.Location = New System.Drawing.Point(81, 131)
        Me.cmbStaffBranch.Name = "cmbStaffBranch"
        Me.cmbStaffBranch.Size = New System.Drawing.Size(99, 20)
        Me.cmbStaffBranch.TabIndex = 9
        Me.cmbStaffBranch.ValueMember = "id_branch"
        '
        'Tbl_staffBindingSource
        '
        Me.Tbl_staffBindingSource.DataMember = "tbl_staff"
        Me.Tbl_staffBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'Tbl_branchBindingSource
        '
        Me.Tbl_branchBindingSource.DataMember = "tbl_branch"
        Me.Tbl_branchBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'lblStaffName
        '
        Me.lblStaffName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "staff_name", True))
        Me.lblStaffName.Location = New System.Drawing.Point(81, 84)
        Me.lblStaffName.Name = "lblStaffName"
        Me.lblStaffName.Size = New System.Drawing.Size(100, 16)
        Me.lblStaffName.TabIndex = 19
        '
        'cmbStaffNameChange
        '
        Me.cmbStaffNameChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaffNameChange.DropDownWidth = 180
        Me.cmbStaffNameChange.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbStaffNameChange.FormattingEnabled = True
        Me.cmbStaffNameChange.Location = New System.Drawing.Point(147, 30)
        Me.cmbStaffNameChange.MaxDropDownItems = 50
        Me.cmbStaffNameChange.MaxLength = 50
        Me.cmbStaffNameChange.Name = "cmbStaffNameChange"
        Me.cmbStaffNameChange.Size = New System.Drawing.Size(17, 23)
        Me.cmbStaffNameChange.TabIndex = 6
        '
        'lblIntegStaffID
        '
        Me.lblIntegStaffID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_IntegrateBindingSource, "integ_staff", True))
        Me.lblIntegStaffID.Location = New System.Drawing.Point(80, 34)
        Me.lblIntegStaffID.Name = "lblIntegStaffID"
        Me.lblIntegStaffID.Size = New System.Drawing.Size(100, 12)
        Me.lblIntegStaffID.TabIndex = 17
        '
        'txtStaffKana
        '
        Me.txtStaffKana.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "staff_kana", True))
        Me.txtStaffKana.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.txtStaffKana.Location = New System.Drawing.Point(81, 106)
        Me.txtStaffKana.Name = "txtStaffKana"
        Me.txtStaffKana.Size = New System.Drawing.Size(99, 19)
        Me.txtStaffKana.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnClearPhone)
        Me.GroupBox1.Controls.Add(Me.cmbPhonenumChange)
        Me.GroupBox1.Controls.Add(PhonenumLabel)
        Me.GroupBox1.Controls.Add(MailLabel)
        Me.GroupBox1.Controls.Add(Me.txtMail)
        Me.GroupBox1.Controls.Add(Me.lblIntegPhonenum)
        Me.GroupBox1.Controls.Add(BikoLabel)
        Me.GroupBox1.Controls.Add(Me.txtBikoPhone)
        Me.GroupBox1.Controls.Add(ModelLabel)
        Me.GroupBox1.Controls.Add(Me.txtModel)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(242, 273)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "電話情報"
        '
        'btnClearPhone
        '
        Me.btnClearPhone.Location = New System.Drawing.Point(171, 30)
        Me.btnClearPhone.Name = "btnClearPhone"
        Me.btnClearPhone.Size = New System.Drawing.Size(49, 20)
        Me.btnClearPhone.TabIndex = 2
        Me.btnClearPhone.Text = "クリア"
        Me.btnClearPhone.UseVisualStyleBackColor = True
        '
        'cmbPhonenumChange
        '
        Me.cmbPhonenumChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPhonenumChange.DropDownWidth = 160
        Me.cmbPhonenumChange.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbPhonenumChange.FormattingEnabled = True
        Me.cmbPhonenumChange.Location = New System.Drawing.Point(148, 30)
        Me.cmbPhonenumChange.MaxDropDownItems = 50
        Me.cmbPhonenumChange.MaxLength = 50
        Me.cmbPhonenumChange.Name = "cmbPhonenumChange"
        Me.cmbPhonenumChange.Size = New System.Drawing.Size(17, 23)
        Me.cmbPhonenumChange.TabIndex = 1
        '
        'txtMail
        '
        Me.txtMail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PhoneNumBindingSource, "mail", True))
        Me.txtMail.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtMail.Location = New System.Drawing.Point(55, 87)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(161, 19)
        Me.txtMail.TabIndex = 4
        '
        'Tbl_PhoneNumBindingSource
        '
        Me.Tbl_PhoneNumBindingSource.DataMember = "tbl_PhoneNum"
        Me.Tbl_PhoneNumBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'lblIntegPhonenum
        '
        Me.lblIntegPhonenum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_IntegrateBindingSource, "integ_phonenum", True))
        Me.lblIntegPhonenum.Location = New System.Drawing.Point(53, 36)
        Me.lblIntegPhonenum.Name = "lblIntegPhonenum"
        Me.lblIntegPhonenum.Size = New System.Drawing.Size(100, 12)
        Me.lblIntegPhonenum.TabIndex = 15
        '
        'txtBikoPhone
        '
        Me.txtBikoPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PhoneNumBindingSource, "biko", True))
        Me.txtBikoPhone.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtBikoPhone.Location = New System.Drawing.Point(55, 113)
        Me.txtBikoPhone.Multiline = True
        Me.txtBikoPhone.Name = "txtBikoPhone"
        Me.txtBikoPhone.Size = New System.Drawing.Size(161, 138)
        Me.txtBikoPhone.TabIndex = 5
        '
        'txtModel
        '
        Me.txtModel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PhoneNumBindingSource, "model", True))
        Me.txtModel.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtModel.Location = New System.Drawing.Point(55, 63)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(98, 19)
        Me.txtModel.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(662, 325)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "キャンセル"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(581, 325)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 20
        Me.btnOK.Text = "登録"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblCarBranch
        '
        Me.lblCarBranch.Location = New System.Drawing.Point(86, 346)
        Me.lblCarBranch.Name = "lblCarBranch"
        Me.lblCarBranch.Size = New System.Drawing.Size(41, 12)
        Me.lblCarBranch.TabIndex = 29
        Me.lblCarBranch.Text = "lblCarBranch"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 12)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "レコードID:"
        '
        'lblStaffBranch
        '
        Me.lblStaffBranch.Location = New System.Drawing.Point(61, 346)
        Me.lblStaffBranch.Name = "lblStaffBranch"
        Me.lblStaffBranch.Size = New System.Drawing.Size(28, 12)
        Me.lblStaffBranch.TabIndex = 30
        Me.lblStaffBranch.Text = "lblStaffBranch"
        '
        'lblIntegID
        '
        Me.lblIntegID.Location = New System.Drawing.Point(62, 330)
        Me.lblIntegID.Name = "lblIntegID"
        Me.lblIntegID.Size = New System.Drawing.Size(74, 12)
        Me.lblIntegID.TabIndex = 27
        Me.lblIntegID.Text = "IntegID"
        '
        'Tbl_PhoneNumTableAdapter
        '
        Me.Tbl_PhoneNumTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_branchTableAdapter = Nothing
        Me.TableAdapterManager.tbl_carTableAdapter = Nothing
        Me.TableAdapterManager.tbl_feeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_IntegrateTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PhoneNumTableAdapter = Me.Tbl_PhoneNumTableAdapter
        Me.TableAdapterManager.tbl_staffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MAd.PhoneNumDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_staffTableAdapter
        '
        Me.Tbl_staffTableAdapter.ClearBeforeFill = True
        '
        'Tbl_carTableAdapter
        '
        Me.Tbl_carTableAdapter.ClearBeforeFill = True
        '
        'Tbl_IntegrateTableAdapter
        '
        Me.Tbl_IntegrateTableAdapter.ClearBeforeFill = True
        '
        'Tbl_branchTableAdapter
        '
        Me.Tbl_branchTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 24)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "新規"
        '
        'frmAddRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 364)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblCarBranch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStaffBranch)
        Me.Controls.Add(Me.lblIntegID)
        Me.KeyPreview = True
        Me.Name = "frmAddRecord"
        Me.Text = "新しい行の追加"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Tbl_carBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_branchBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_IntegrateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Tbl_staffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_branchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tbl_PhoneNumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnClearCar As Button
    Friend WithEvents cmbCarBranch As ComboBox
    Friend WithEvents cmbCarnumChange As ComboBox
    Friend WithEvents lblIntegCarnum As Label
    Friend WithEvents txtCarnum2 As TextBox
    Friend WithEvents txtCarnum3 As TextBox
    Friend WithEvents txtCarnum4 As TextBox
    Friend WithEvents txtMusen As TextBox
    Friend WithEvents txtTon As TextBox
    Friend WithEvents txtBikoCar As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnClearStaff As Button
    Friend WithEvents cmbStaffBranch As ComboBox
    Friend WithEvents lblStaffName As Label
    Friend WithEvents cmbStaffNameChange As ComboBox
    Friend WithEvents lblIntegStaffID As Label
    Friend WithEvents txtStaffKana As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClearPhone As Button
    Friend WithEvents cmbPhonenumChange As ComboBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents lblIntegPhonenum As Label
    Friend WithEvents txtBikoPhone As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents lblCarBranch As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStaffBranch As Label
    Friend WithEvents lblIntegID As Label
    Friend WithEvents Tbl_PhoneNumBindingSource As BindingSource
    Friend WithEvents PhoneNumDBDataSet As PhoneNumDBDataSet
    Friend WithEvents Tbl_IntegrateBindingSource As BindingSource
    Friend WithEvents Tbl_staffBindingSource As BindingSource
    Friend WithEvents Tbl_branchBindingSource As BindingSource
    Friend WithEvents Tbl_carBindingSource As BindingSource
    Friend WithEvents Tbl_branchBindingSource2 As BindingSource
    Friend WithEvents Tbl_PhoneNumTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_PhoneNumTableAdapter
    Friend WithEvents TableAdapterManager As PhoneNumDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_staffTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_staffTableAdapter
    Friend WithEvents Tbl_carTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter
    Friend WithEvents Tbl_IntegrateTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_IntegrateTableAdapter
    Friend WithEvents Tbl_branchTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_branchTableAdapter
    Friend WithEvents cmbTon As ComboBox
    Friend WithEvents Label2 As Label
End Class
