﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModifier
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PhonenumLabel As System.Windows.Forms.Label
        Dim MailLabel As System.Windows.Forms.Label
        Dim BikoLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Dim Id_staffLabel As System.Windows.Forms.Label
        Dim Staff_nameLabel As System.Windows.Forms.Label
        Dim Staff_kanaLabel As System.Windows.Forms.Label
        Dim Branch_idLabel As System.Windows.Forms.Label
        Dim Carnum1Label As System.Windows.Forms.Label
        Dim MusenLabel As System.Windows.Forms.Label
        Dim TonLabel As System.Windows.Forms.Label
        Dim BikoLabel1 As System.Windows.Forms.Label
        Dim Branch_idLabel2 As System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClearPhone = New System.Windows.Forms.Button()
        Me.cmbPhonenumChange = New System.Windows.Forms.ComboBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Tbl_PhoneNumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSet = New MAd.PhoneNumDBDataSet()
        Me.lblIntegPhonenum = New System.Windows.Forms.Label()
        Me.Tbl_IntegrateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtBikoPhone = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClearStaff = New System.Windows.Forms.Button()
        Me.cmbStaffBranch = New System.Windows.Forms.ComboBox()
        Me.Tbl_staffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_branchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblStaffName = New System.Windows.Forms.Label()
        Me.cmbStaffNameChange = New System.Windows.Forms.ComboBox()
        Me.lblIntegStaffID = New System.Windows.Forms.Label()
        Me.txtStaffKana = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnClearCar = New System.Windows.Forms.Button()
        Me.cmbCarBranch = New System.Windows.Forms.ComboBox()
        Me.Tbl_carBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_branchBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbCarnumChange = New System.Windows.Forms.ComboBox()
        Me.lblIntegCarnum = New System.Windows.Forms.Label()
        Me.txtCarnum2 = New System.Windows.Forms.TextBox()
        Me.txtCarnum3 = New System.Windows.Forms.TextBox()
        Me.txtCarnum4 = New System.Windows.Forms.TextBox()
        Me.txtMusen = New System.Windows.Forms.TextBox()
        Me.txtTon = New System.Windows.Forms.TextBox()
        Me.txtBikoCar = New System.Windows.Forms.TextBox()
        Me.Tbl_PhoneNumTableAdapter = New MAd.PhoneNumDBDataSetTableAdapters.tbl_PhoneNumTableAdapter()
        Me.TableAdapterManager = New MAd.PhoneNumDBDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_staffTableAdapter = New MAd.PhoneNumDBDataSetTableAdapters.tbl_staffTableAdapter()
        Me.Tbl_carTableAdapter = New MAd.PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter()
        Me.Tbl_IntegrateTableAdapter = New MAd.PhoneNumDBDataSetTableAdapters.tbl_IntegrateTableAdapter()
        Me.lblIntegID = New System.Windows.Forms.Label()
        Me.Tbl_branchTableAdapter = New MAd.PhoneNumDBDataSetTableAdapters.tbl_branchTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStaffBranch = New System.Windows.Forms.Label()
        Me.lblCarBranch = New System.Windows.Forms.Label()
        PhonenumLabel = New System.Windows.Forms.Label()
        MailLabel = New System.Windows.Forms.Label()
        BikoLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        Id_staffLabel = New System.Windows.Forms.Label()
        Staff_nameLabel = New System.Windows.Forms.Label()
        Staff_kanaLabel = New System.Windows.Forms.Label()
        Branch_idLabel = New System.Windows.Forms.Label()
        Carnum1Label = New System.Windows.Forms.Label()
        MusenLabel = New System.Windows.Forms.Label()
        TonLabel = New System.Windows.Forms.Label()
        BikoLabel1 = New System.Windows.Forms.Label()
        Branch_idLabel2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tbl_PhoneNumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_IntegrateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_staffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_branchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Tbl_carBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_branchBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        MailLabel.Location = New System.Drawing.Point(17, 89)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(27, 12)
        MailLabel.TabIndex = 2
        MailLabel.Text = "ﾒｰﾙ"
        '
        'BikoLabel
        '
        BikoLabel.AutoSize = True
        BikoLabel.Location = New System.Drawing.Point(17, 115)
        BikoLabel.Name = "BikoLabel"
        BikoLabel.Size = New System.Drawing.Size(29, 12)
        BikoLabel.TabIndex = 4
        BikoLabel.Text = "備考"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(17, 65)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(29, 12)
        ModelLabel.TabIndex = 6
        ModelLabel.Text = "機種"
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
        Staff_nameLabel.Location = New System.Drawing.Point(12, 59)
        Staff_nameLabel.Name = "Staff_nameLabel"
        Staff_nameLabel.Size = New System.Drawing.Size(29, 12)
        Staff_nameLabel.TabIndex = 2
        Staff_nameLabel.Text = "氏名"
        '
        'Staff_kanaLabel
        '
        Staff_kanaLabel.AutoSize = True
        Staff_kanaLabel.Location = New System.Drawing.Point(12, 84)
        Staff_kanaLabel.Name = "Staff_kanaLabel"
        Staff_kanaLabel.Size = New System.Drawing.Size(44, 12)
        Staff_kanaLabel.TabIndex = 4
        Staff_kanaLabel.Text = "氏名ｶﾅ"
        '
        'Branch_idLabel
        '
        Branch_idLabel.AutoSize = True
        Branch_idLabel.Location = New System.Drawing.Point(12, 109)
        Branch_idLabel.Name = "Branch_idLabel"
        Branch_idLabel.Size = New System.Drawing.Size(29, 12)
        Branch_idLabel.TabIndex = 6
        Branch_idLabel.Text = "所属"
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
        MusenLabel.Location = New System.Drawing.Point(11, 88)
        MusenLabel.Name = "MusenLabel"
        MusenLabel.Size = New System.Drawing.Size(29, 12)
        MusenLabel.TabIndex = 8
        MusenLabel.Text = "無線"
        '
        'TonLabel
        '
        TonLabel.AutoSize = True
        TonLabel.Location = New System.Drawing.Point(11, 113)
        TonLabel.Name = "TonLabel"
        TonLabel.Size = New System.Drawing.Size(29, 12)
        TonLabel.TabIndex = 10
        TonLabel.Text = "車格"
        '
        'BikoLabel1
        '
        BikoLabel1.AutoSize = True
        BikoLabel1.Location = New System.Drawing.Point(11, 138)
        BikoLabel1.Name = "BikoLabel1"
        BikoLabel1.Size = New System.Drawing.Size(29, 12)
        BikoLabel1.TabIndex = 12
        BikoLabel1.Text = "備考"
        '
        'Branch_idLabel2
        '
        Branch_idLabel2.AutoSize = True
        Branch_idLabel2.Location = New System.Drawing.Point(11, 238)
        Branch_idLabel2.Name = "Branch_idLabel2"
        Branch_idLabel2.Size = New System.Drawing.Size(29, 12)
        Branch_idLabel2.TabIndex = 18
        Branch_idLabel2.Text = "車庫"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(553, 342)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "登録"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(634, 342)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "キャンセル"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(10, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 298)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "電話情報"
        '
        'btnClearPhone
        '
        Me.btnClearPhone.Location = New System.Drawing.Point(171, 30)
        Me.btnClearPhone.Name = "btnClearPhone"
        Me.btnClearPhone.Size = New System.Drawing.Size(49, 20)
        Me.btnClearPhone.TabIndex = 23
        Me.btnClearPhone.Text = "クリア"
        Me.btnClearPhone.UseVisualStyleBackColor = True
        '
        'cmbPhonenumChange
        '
        Me.cmbPhonenumChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPhonenumChange.DropDownWidth = 120
        Me.cmbPhonenumChange.FormattingEnabled = True
        Me.cmbPhonenumChange.Location = New System.Drawing.Point(148, 30)
        Me.cmbPhonenumChange.MaxDropDownItems = 30
        Me.cmbPhonenumChange.MaxLength = 50
        Me.cmbPhonenumChange.Name = "cmbPhonenumChange"
        Me.cmbPhonenumChange.Size = New System.Drawing.Size(17, 20)
        Me.cmbPhonenumChange.TabIndex = 17
        '
        'txtMail
        '
        Me.txtMail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PhoneNumBindingSource, "mail", True))
        Me.txtMail.Location = New System.Drawing.Point(55, 86)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(161, 19)
        Me.txtMail.TabIndex = 3
        '
        'Tbl_PhoneNumBindingSource
        '
        Me.Tbl_PhoneNumBindingSource.DataMember = "tbl_PhoneNum"
        Me.Tbl_PhoneNumBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'PhoneNumDBDataSet
        '
        Me.PhoneNumDBDataSet.DataSetName = "PhoneNumDBDataSet"
        Me.PhoneNumDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblIntegPhonenum
        '
        Me.lblIntegPhonenum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_IntegrateBindingSource, "integ_phonenum", True))
        Me.lblIntegPhonenum.Location = New System.Drawing.Point(53, 36)
        Me.lblIntegPhonenum.Name = "lblIntegPhonenum"
        Me.lblIntegPhonenum.Size = New System.Drawing.Size(100, 12)
        Me.lblIntegPhonenum.TabIndex = 15
        Me.lblIntegPhonenum.Text = "IntegPhonenum"
        '
        'Tbl_IntegrateBindingSource
        '
        Me.Tbl_IntegrateBindingSource.DataMember = "tbl_Integrate"
        Me.Tbl_IntegrateBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'txtBikoPhone
        '
        Me.txtBikoPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PhoneNumBindingSource, "biko", True))
        Me.txtBikoPhone.Location = New System.Drawing.Point(55, 112)
        Me.txtBikoPhone.Multiline = True
        Me.txtBikoPhone.Name = "txtBikoPhone"
        Me.txtBikoPhone.Size = New System.Drawing.Size(161, 138)
        Me.txtBikoPhone.TabIndex = 5
        '
        'txtModel
        '
        Me.txtModel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PhoneNumBindingSource, "model", True))
        Me.txtModel.Location = New System.Drawing.Point(55, 62)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(98, 19)
        Me.txtModel.TabIndex = 7
        '
        'GroupBox2
        '
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
        Me.GroupBox2.Location = New System.Drawing.Point(246, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(230, 298)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "社員情報"
        '
        'btnClearStaff
        '
        Me.btnClearStaff.Location = New System.Drawing.Point(170, 30)
        Me.btnClearStaff.Name = "btnClearStaff"
        Me.btnClearStaff.Size = New System.Drawing.Size(49, 20)
        Me.btnClearStaff.TabIndex = 22
        Me.btnClearStaff.Text = "クリア"
        Me.btnClearStaff.UseVisualStyleBackColor = True
        '
        'cmbStaffBranch
        '
        Me.cmbStaffBranch.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "branch_id", True))
        Me.cmbStaffBranch.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_staffBindingSource, "branch_id", True))
        Me.cmbStaffBranch.DataSource = Me.Tbl_branchBindingSource
        Me.cmbStaffBranch.DisplayMember = "branch_name"
        Me.cmbStaffBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaffBranch.FormattingEnabled = True
        Me.cmbStaffBranch.Location = New System.Drawing.Point(80, 106)
        Me.cmbStaffBranch.Name = "cmbStaffBranch"
        Me.cmbStaffBranch.Size = New System.Drawing.Size(99, 20)
        Me.cmbStaffBranch.TabIndex = 20
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
        Me.lblStaffName.Location = New System.Drawing.Point(80, 59)
        Me.lblStaffName.Name = "lblStaffName"
        Me.lblStaffName.Size = New System.Drawing.Size(100, 16)
        Me.lblStaffName.TabIndex = 19
        Me.lblStaffName.Text = "lblStaffName"
        '
        'cmbStaffNameChange
        '
        Me.cmbStaffNameChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaffNameChange.DropDownWidth = 120
        Me.cmbStaffNameChange.FormattingEnabled = True
        Me.cmbStaffNameChange.Location = New System.Drawing.Point(147, 30)
        Me.cmbStaffNameChange.MaxDropDownItems = 30
        Me.cmbStaffNameChange.MaxLength = 50
        Me.cmbStaffNameChange.Name = "cmbStaffNameChange"
        Me.cmbStaffNameChange.Size = New System.Drawing.Size(17, 20)
        Me.cmbStaffNameChange.TabIndex = 18
        '
        'lblIntegStaffID
        '
        Me.lblIntegStaffID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_IntegrateBindingSource, "integ_staff", True))
        Me.lblIntegStaffID.Location = New System.Drawing.Point(80, 34)
        Me.lblIntegStaffID.Name = "lblIntegStaffID"
        Me.lblIntegStaffID.Size = New System.Drawing.Size(100, 12)
        Me.lblIntegStaffID.TabIndex = 17
        Me.lblIntegStaffID.Text = "IntegStaffID"
        '
        'txtStaffKana
        '
        Me.txtStaffKana.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "staff_kana", True))
        Me.txtStaffKana.Location = New System.Drawing.Point(80, 81)
        Me.txtStaffKana.Name = "txtStaffKana"
        Me.txtStaffKana.Size = New System.Drawing.Size(99, 19)
        Me.txtStaffKana.TabIndex = 5
        '
        'GroupBox3
        '
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
        Me.GroupBox3.Location = New System.Drawing.Point(482, 38)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(227, 298)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "車両情報"
        '
        'btnClearCar
        '
        Me.btnClearCar.Location = New System.Drawing.Point(161, 30)
        Me.btnClearCar.Name = "btnClearCar"
        Me.btnClearCar.Size = New System.Drawing.Size(49, 20)
        Me.btnClearCar.TabIndex = 23
        Me.btnClearCar.Text = "クリア"
        Me.btnClearCar.UseVisualStyleBackColor = True
        '
        'cmbCarBranch
        '
        Me.cmbCarBranch.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "branch_id", True))
        Me.cmbCarBranch.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_carBindingSource, "branch_id", True))
        Me.cmbCarBranch.DataSource = Me.Tbl_branchBindingSource2
        Me.cmbCarBranch.DisplayMember = "branch_name"
        Me.cmbCarBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarBranch.FormattingEnabled = True
        Me.cmbCarBranch.Location = New System.Drawing.Point(71, 235)
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
        'Tbl_branchBindingSource2
        '
        Me.Tbl_branchBindingSource2.DataMember = "tbl_branch"
        Me.Tbl_branchBindingSource2.DataSource = Me.PhoneNumDBDataSet
        '
        'cmbCarnumChange
        '
        Me.cmbCarnumChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarnumChange.DropDownWidth = 120
        Me.cmbCarnumChange.FormattingEnabled = True
        Me.cmbCarnumChange.Location = New System.Drawing.Point(140, 30)
        Me.cmbCarnumChange.MaxDropDownItems = 30
        Me.cmbCarnumChange.MaxLength = 50
        Me.cmbCarnumChange.Name = "cmbCarnumChange"
        Me.cmbCarnumChange.Size = New System.Drawing.Size(17, 20)
        Me.cmbCarnumChange.TabIndex = 18
        '
        'lblIntegCarnum
        '
        Me.lblIntegCarnum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_IntegrateBindingSource, "integ_carnum", True))
        Me.lblIntegCarnum.Location = New System.Drawing.Point(71, 34)
        Me.lblIntegCarnum.Name = "lblIntegCarnum"
        Me.lblIntegCarnum.Size = New System.Drawing.Size(100, 12)
        Me.lblIntegCarnum.TabIndex = 18
        Me.lblIntegCarnum.Text = "IntegCarnum"
        '
        'txtCarnum2
        '
        Me.txtCarnum2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "carnum2", True))
        Me.txtCarnum2.Location = New System.Drawing.Point(71, 59)
        Me.txtCarnum2.Name = "txtCarnum2"
        Me.txtCarnum2.Size = New System.Drawing.Size(53, 19)
        Me.txtCarnum2.TabIndex = 3
        '
        'txtCarnum3
        '
        Me.txtCarnum3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "carnum3", True))
        Me.txtCarnum3.Location = New System.Drawing.Point(130, 59)
        Me.txtCarnum3.Name = "txtCarnum3"
        Me.txtCarnum3.Size = New System.Drawing.Size(39, 19)
        Me.txtCarnum3.TabIndex = 5
        '
        'txtCarnum4
        '
        Me.txtCarnum4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "carnum4", True))
        Me.txtCarnum4.Location = New System.Drawing.Point(175, 59)
        Me.txtCarnum4.Name = "txtCarnum4"
        Me.txtCarnum4.Size = New System.Drawing.Size(35, 19)
        Me.txtCarnum4.TabIndex = 7
        '
        'txtMusen
        '
        Me.txtMusen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "musen", True))
        Me.txtMusen.Location = New System.Drawing.Point(71, 85)
        Me.txtMusen.Name = "txtMusen"
        Me.txtMusen.Size = New System.Drawing.Size(100, 19)
        Me.txtMusen.TabIndex = 9
        '
        'txtTon
        '
        Me.txtTon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "ton", True))
        Me.txtTon.Location = New System.Drawing.Point(71, 110)
        Me.txtTon.Name = "txtTon"
        Me.txtTon.Size = New System.Drawing.Size(100, 19)
        Me.txtTon.TabIndex = 11
        '
        'txtBikoCar
        '
        Me.txtBikoCar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "biko", True))
        Me.txtBikoCar.Location = New System.Drawing.Point(71, 135)
        Me.txtBikoCar.Multiline = True
        Me.txtBikoCar.Name = "txtBikoCar"
        Me.txtBikoCar.Size = New System.Drawing.Size(139, 95)
        Me.txtBikoCar.TabIndex = 13
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
        'lblIntegID
        '
        Me.lblIntegID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_IntegrateBindingSource, "integ_id", True))
        Me.lblIntegID.Location = New System.Drawing.Point(63, 342)
        Me.lblIntegID.Name = "lblIntegID"
        Me.lblIntegID.Size = New System.Drawing.Size(40, 12)
        Me.lblIntegID.TabIndex = 16
        Me.lblIntegID.Text = "IntegID"
        '
        'Tbl_branchTableAdapter
        '
        Me.Tbl_branchTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 342)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 12)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "レコードID:"
        '
        'lblStaffBranch
        '
        Me.lblStaffBranch.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "branch_id", True))
        Me.lblStaffBranch.Location = New System.Drawing.Point(97, 342)
        Me.lblStaffBranch.Name = "lblStaffBranch"
        Me.lblStaffBranch.Size = New System.Drawing.Size(28, 12)
        Me.lblStaffBranch.TabIndex = 21
        Me.lblStaffBranch.Text = "lblStaffBranch"
        '
        'lblCarBranch
        '
        Me.lblCarBranch.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "branch_id", True))
        Me.lblCarBranch.Location = New System.Drawing.Point(122, 342)
        Me.lblCarBranch.Name = "lblCarBranch"
        Me.lblCarBranch.Size = New System.Drawing.Size(41, 12)
        Me.lblCarBranch.TabIndex = 20
        Me.lblCarBranch.Text = "lblCarBranch"
        '
        'frmModifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 372)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblCarBranch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStaffBranch)
        Me.Controls.Add(Me.lblIntegID)
        Me.Name = "frmModifier"
        Me.Text = "選択した行の編集"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tbl_PhoneNumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_IntegrateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Tbl_staffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_branchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Tbl_carBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_branchBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PhoneNumDBDataSet As PhoneNumDBDataSet
    Friend WithEvents Tbl_PhoneNumBindingSource As BindingSource
    Friend WithEvents Tbl_PhoneNumTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_PhoneNumTableAdapter
    Friend WithEvents TableAdapterManager As PhoneNumDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtMail As TextBox
    Friend WithEvents txtBikoPhone As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents Tbl_staffBindingSource As BindingSource
    Friend WithEvents Tbl_staffTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_staffTableAdapter
    Friend WithEvents txtStaffKana As TextBox
    Friend WithEvents Tbl_carBindingSource As BindingSource
    Friend WithEvents Tbl_carTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter
    Friend WithEvents txtCarnum2 As TextBox
    Friend WithEvents txtCarnum3 As TextBox
    Friend WithEvents txtCarnum4 As TextBox
    Friend WithEvents txtMusen As TextBox
    Friend WithEvents txtTon As TextBox
    Friend WithEvents txtBikoCar As TextBox
    Friend WithEvents Tbl_IntegrateBindingSource As BindingSource
    Friend WithEvents Tbl_IntegrateTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_IntegrateTableAdapter
    Friend WithEvents lblIntegPhonenum As Label
    Friend WithEvents lblIntegID As Label
    Friend WithEvents lblIntegStaffID As Label
    Friend WithEvents lblIntegCarnum As Label
    Friend WithEvents cmbPhonenumChange As ComboBox
    Friend WithEvents cmbCarnumChange As ComboBox
    Friend WithEvents cmbStaffNameChange As ComboBox
    Friend WithEvents lblStaffName As Label
    Friend WithEvents Tbl_branchBindingSource As BindingSource
    Friend WithEvents Tbl_branchTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_branchTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbStaffBranch As ComboBox
    Friend WithEvents cmbCarBranch As ComboBox
    Friend WithEvents Tbl_branchBindingSource2 As BindingSource
    Friend WithEvents lblStaffBranch As Label
    Friend WithEvents lblCarBranch As Label
    Friend WithEvents btnClearStaff As Button
    Friend WithEvents btnClearPhone As Button
    Friend WithEvents btnClearCar As Button
End Class
