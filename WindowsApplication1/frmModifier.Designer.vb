<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.cmbPhonenumChange = New System.Windows.Forms.ComboBox()
        Me.Tbl_PhoneNumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSet = New MAd.PhoneNumDBDataSet()
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        Me.lblIntegPhonenum = New System.Windows.Forms.Label()
        Me.Tbl_IntegrateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BikoTextBox = New System.Windows.Forms.TextBox()
        Me.ModelTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblStaffName = New System.Windows.Forms.Label()
        Me.Tbl_staffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbStaffNameChange = New System.Windows.Forms.ComboBox()
        Me.lblIntegStaffID = New System.Windows.Forms.Label()
        Me.Staff_kanaTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbCarnumChange = New System.Windows.Forms.ComboBox()
        Me.lblIntegCarnum = New System.Windows.Forms.Label()
        Me.Carnum2TextBox = New System.Windows.Forms.TextBox()
        Me.Tbl_carBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Carnum3TextBox = New System.Windows.Forms.TextBox()
        Me.Carnum4TextBox = New System.Windows.Forms.TextBox()
        Me.MusenTextBox = New System.Windows.Forms.TextBox()
        Me.TonTextBox = New System.Windows.Forms.TextBox()
        Me.BikoTextBox1 = New System.Windows.Forms.TextBox()
        Me.Tbl_PhoneNumTableAdapter = New MAd.PhoneNumDBDataSetTableAdapters.tbl_PhoneNumTableAdapter()
        Me.TableAdapterManager = New MAd.PhoneNumDBDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_staffTableAdapter = New MAd.PhoneNumDBDataSetTableAdapters.tbl_staffTableAdapter()
        Me.Tbl_carTableAdapter = New MAd.PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter()
        Me.Tbl_IntegrateTableAdapter = New MAd.PhoneNumDBDataSetTableAdapters.tbl_IntegrateTableAdapter()
        Me.lblIntegID = New System.Windows.Forms.Label()
        Me.Tbl_branchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_branchTableAdapter = New MAd.PhoneNumDBDataSetTableAdapters.tbl_branchTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Branch_idComboBox = New System.Windows.Forms.ComboBox()
        Me.Branch_idComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_branchBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.GroupBox3.SuspendLayout()
        CType(Me.Tbl_carBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_branchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Carnum1Label.Location = New System.Drawing.Point(22, 34)
        Carnum1Label.Name = "Carnum1Label"
        Carnum1Label.Size = New System.Drawing.Size(29, 12)
        Carnum1Label.TabIndex = 0
        Carnum1Label.Text = "車番"
        '
        'MusenLabel
        '
        MusenLabel.AutoSize = True
        MusenLabel.Location = New System.Drawing.Point(20, 88)
        MusenLabel.Name = "MusenLabel"
        MusenLabel.Size = New System.Drawing.Size(29, 12)
        MusenLabel.TabIndex = 8
        MusenLabel.Text = "無線"
        '
        'TonLabel
        '
        TonLabel.AutoSize = True
        TonLabel.Location = New System.Drawing.Point(20, 113)
        TonLabel.Name = "TonLabel"
        TonLabel.Size = New System.Drawing.Size(29, 12)
        TonLabel.TabIndex = 10
        TonLabel.Text = "車格"
        '
        'BikoLabel1
        '
        BikoLabel1.AutoSize = True
        BikoLabel1.Location = New System.Drawing.Point(20, 138)
        BikoLabel1.Name = "BikoLabel1"
        BikoLabel1.Size = New System.Drawing.Size(29, 12)
        BikoLabel1.TabIndex = 12
        BikoLabel1.Text = "備考"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(521, 335)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "決定"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(602, 335)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "キャンセル"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbPhonenumChange)
        Me.GroupBox1.Controls.Add(PhonenumLabel)
        Me.GroupBox1.Controls.Add(MailLabel)
        Me.GroupBox1.Controls.Add(Me.MailTextBox)
        Me.GroupBox1.Controls.Add(Me.lblIntegPhonenum)
        Me.GroupBox1.Controls.Add(BikoLabel)
        Me.GroupBox1.Controls.Add(Me.BikoTextBox)
        Me.GroupBox1.Controls.Add(ModelLabel)
        Me.GroupBox1.Controls.Add(Me.ModelTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 298)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "電話情報"
        '
        'cmbPhonenumChange
        '
        Me.cmbPhonenumChange.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_PhoneNumBindingSource, "phonenum", True))
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
        'MailTextBox
        '
        Me.MailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PhoneNumBindingSource, "mail", True))
        Me.MailTextBox.Location = New System.Drawing.Point(55, 86)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.Size = New System.Drawing.Size(161, 19)
        Me.MailTextBox.TabIndex = 3
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
        'BikoTextBox
        '
        Me.BikoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PhoneNumBindingSource, "biko", True))
        Me.BikoTextBox.Location = New System.Drawing.Point(55, 112)
        Me.BikoTextBox.Multiline = True
        Me.BikoTextBox.Name = "BikoTextBox"
        Me.BikoTextBox.Size = New System.Drawing.Size(161, 138)
        Me.BikoTextBox.TabIndex = 5
        '
        'ModelTextBox
        '
        Me.ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PhoneNumBindingSource, "model", True))
        Me.ModelTextBox.Location = New System.Drawing.Point(55, 62)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.Size = New System.Drawing.Size(98, 19)
        Me.ModelTextBox.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Branch_idComboBox)
        Me.GroupBox2.Controls.Add(Me.lblStaffName)
        Me.GroupBox2.Controls.Add(Me.cmbStaffNameChange)
        Me.GroupBox2.Controls.Add(Id_staffLabel)
        Me.GroupBox2.Controls.Add(Me.lblIntegStaffID)
        Me.GroupBox2.Controls.Add(Staff_nameLabel)
        Me.GroupBox2.Controls.Add(Staff_kanaLabel)
        Me.GroupBox2.Controls.Add(Me.Staff_kanaTextBox)
        Me.GroupBox2.Controls.Add(Branch_idLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(255, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(199, 298)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "社員情報"
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
        'Tbl_staffBindingSource
        '
        Me.Tbl_staffBindingSource.DataMember = "tbl_staff"
        Me.Tbl_staffBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'cmbStaffNameChange
        '
        Me.cmbStaffNameChange.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_PhoneNumBindingSource, "phonenum", True))
        Me.cmbStaffNameChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaffNameChange.DropDownWidth = 120
        Me.cmbStaffNameChange.FormattingEnabled = True
        Me.cmbStaffNameChange.Location = New System.Drawing.Point(163, 30)
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
        'Staff_kanaTextBox
        '
        Me.Staff_kanaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "staff_kana", True))
        Me.Staff_kanaTextBox.Location = New System.Drawing.Point(80, 81)
        Me.Staff_kanaTextBox.Name = "Staff_kanaTextBox"
        Me.Staff_kanaTextBox.Size = New System.Drawing.Size(99, 19)
        Me.Staff_kanaTextBox.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Branch_idLabel2)
        Me.GroupBox3.Controls.Add(Me.Branch_idComboBox1)
        Me.GroupBox3.Controls.Add(Me.cmbCarnumChange)
        Me.GroupBox3.Controls.Add(Me.lblIntegCarnum)
        Me.GroupBox3.Controls.Add(Carnum1Label)
        Me.GroupBox3.Controls.Add(Me.Carnum2TextBox)
        Me.GroupBox3.Controls.Add(Me.Carnum3TextBox)
        Me.GroupBox3.Controls.Add(Me.Carnum4TextBox)
        Me.GroupBox3.Controls.Add(MusenLabel)
        Me.GroupBox3.Controls.Add(Me.MusenTextBox)
        Me.GroupBox3.Controls.Add(TonLabel)
        Me.GroupBox3.Controls.Add(Me.TonTextBox)
        Me.GroupBox3.Controls.Add(BikoLabel1)
        Me.GroupBox3.Controls.Add(Me.BikoTextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(460, 31)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(217, 298)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "車両情報"
        '
        'cmbCarnumChange
        '
        Me.cmbCarnumChange.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_PhoneNumBindingSource, "phonenum", True))
        Me.cmbCarnumChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarnumChange.DropDownWidth = 120
        Me.cmbCarnumChange.FormattingEnabled = True
        Me.cmbCarnumChange.Location = New System.Drawing.Point(163, 30)
        Me.cmbCarnumChange.MaxDropDownItems = 30
        Me.cmbCarnumChange.MaxLength = 50
        Me.cmbCarnumChange.Name = "cmbCarnumChange"
        Me.cmbCarnumChange.Size = New System.Drawing.Size(17, 20)
        Me.cmbCarnumChange.TabIndex = 18
        '
        'lblIntegCarnum
        '
        Me.lblIntegCarnum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_IntegrateBindingSource, "integ_carnum", True))
        Me.lblIntegCarnum.Location = New System.Drawing.Point(80, 34)
        Me.lblIntegCarnum.Name = "lblIntegCarnum"
        Me.lblIntegCarnum.Size = New System.Drawing.Size(100, 12)
        Me.lblIntegCarnum.TabIndex = 18
        Me.lblIntegCarnum.Text = "IntegCarnum"
        '
        'Carnum2TextBox
        '
        Me.Carnum2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "carnum2", True))
        Me.Carnum2TextBox.Location = New System.Drawing.Point(82, 56)
        Me.Carnum2TextBox.Name = "Carnum2TextBox"
        Me.Carnum2TextBox.Size = New System.Drawing.Size(37, 19)
        Me.Carnum2TextBox.TabIndex = 3
        '
        'Tbl_carBindingSource
        '
        Me.Tbl_carBindingSource.DataMember = "tbl_car"
        Me.Tbl_carBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'Carnum3TextBox
        '
        Me.Carnum3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "carnum3", True))
        Me.Carnum3TextBox.Location = New System.Drawing.Point(125, 56)
        Me.Carnum3TextBox.Name = "Carnum3TextBox"
        Me.Carnum3TextBox.Size = New System.Drawing.Size(30, 19)
        Me.Carnum3TextBox.TabIndex = 5
        '
        'Carnum4TextBox
        '
        Me.Carnum4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "carnum4", True))
        Me.Carnum4TextBox.Location = New System.Drawing.Point(159, 56)
        Me.Carnum4TextBox.Name = "Carnum4TextBox"
        Me.Carnum4TextBox.Size = New System.Drawing.Size(21, 19)
        Me.Carnum4TextBox.TabIndex = 7
        '
        'MusenTextBox
        '
        Me.MusenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "musen", True))
        Me.MusenTextBox.Location = New System.Drawing.Point(80, 85)
        Me.MusenTextBox.Name = "MusenTextBox"
        Me.MusenTextBox.Size = New System.Drawing.Size(100, 19)
        Me.MusenTextBox.TabIndex = 9
        '
        'TonTextBox
        '
        Me.TonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "ton", True))
        Me.TonTextBox.Location = New System.Drawing.Point(80, 110)
        Me.TonTextBox.Name = "TonTextBox"
        Me.TonTextBox.Size = New System.Drawing.Size(100, 19)
        Me.TonTextBox.TabIndex = 11
        '
        'BikoTextBox1
        '
        Me.BikoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "biko", True))
        Me.BikoTextBox1.Location = New System.Drawing.Point(80, 135)
        Me.BikoTextBox1.Multiline = True
        Me.BikoTextBox1.Name = "BikoTextBox1"
        Me.BikoTextBox1.Size = New System.Drawing.Size(100, 95)
        Me.BikoTextBox1.TabIndex = 13
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
        Me.lblIntegID.Location = New System.Drawing.Point(63, 9)
        Me.lblIntegID.Name = "lblIntegID"
        Me.lblIntegID.Size = New System.Drawing.Size(100, 10)
        Me.lblIntegID.TabIndex = 16
        Me.lblIntegID.Text = "IntegID"
        '
        'Tbl_branchBindingSource
        '
        Me.Tbl_branchBindingSource.DataMember = "tbl_branch"
        Me.Tbl_branchBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'Tbl_branchTableAdapter
        '
        Me.Tbl_branchTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 12)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "レコードID:"
        '
        'Branch_idComboBox
        '
        Me.Branch_idComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "branch_id", True))
        Me.Branch_idComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_staffBindingSource, "branch_id", True))
        Me.Branch_idComboBox.DataSource = Me.Tbl_branchBindingSource
        Me.Branch_idComboBox.DisplayMember = "branch_name"
        Me.Branch_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Branch_idComboBox.FormattingEnabled = True
        Me.Branch_idComboBox.Location = New System.Drawing.Point(80, 106)
        Me.Branch_idComboBox.Name = "Branch_idComboBox"
        Me.Branch_idComboBox.Size = New System.Drawing.Size(99, 20)
        Me.Branch_idComboBox.TabIndex = 20
        Me.Branch_idComboBox.ValueMember = "id_branch"
        '
        'Branch_idLabel2
        '
        Branch_idLabel2.AutoSize = True
        Branch_idLabel2.Location = New System.Drawing.Point(20, 238)
        Branch_idLabel2.Name = "Branch_idLabel2"
        Branch_idLabel2.Size = New System.Drawing.Size(29, 12)
        Branch_idLabel2.TabIndex = 18
        Branch_idLabel2.Text = "車庫"
        '
        'Branch_idComboBox1
        '
        Me.Branch_idComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "branch_id", True))
        Me.Branch_idComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_carBindingSource, "branch_id", True))
        Me.Branch_idComboBox1.DataSource = Me.Tbl_branchBindingSource2
        Me.Branch_idComboBox1.DisplayMember = "branch_name"
        Me.Branch_idComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Branch_idComboBox1.FormattingEnabled = True
        Me.Branch_idComboBox1.Location = New System.Drawing.Point(80, 235)
        Me.Branch_idComboBox1.Name = "Branch_idComboBox1"
        Me.Branch_idComboBox1.Size = New System.Drawing.Size(100, 20)
        Me.Branch_idComboBox1.TabIndex = 19
        Me.Branch_idComboBox1.ValueMember = "id_branch"
        '
        'Tbl_branchBindingSource2
        '
        Me.Tbl_branchBindingSource2.DataMember = "tbl_branch"
        Me.Tbl_branchBindingSource2.DataSource = Me.PhoneNumDBDataSet
        '
        'frmModifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 371)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblIntegID)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "frmModifier"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tbl_PhoneNumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_IntegrateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Tbl_staffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Tbl_carBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_branchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MailTextBox As TextBox
    Friend WithEvents BikoTextBox As TextBox
    Friend WithEvents ModelTextBox As TextBox
    Friend WithEvents Tbl_staffBindingSource As BindingSource
    Friend WithEvents Tbl_staffTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_staffTableAdapter
    Friend WithEvents Staff_kanaTextBox As TextBox
    Friend WithEvents Tbl_carBindingSource As BindingSource
    Friend WithEvents Tbl_carTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter
    Friend WithEvents Carnum2TextBox As TextBox
    Friend WithEvents Carnum3TextBox As TextBox
    Friend WithEvents Carnum4TextBox As TextBox
    Friend WithEvents MusenTextBox As TextBox
    Friend WithEvents TonTextBox As TextBox
    Friend WithEvents BikoTextBox1 As TextBox
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
    Friend WithEvents Branch_idComboBox As ComboBox
    Friend WithEvents Branch_idComboBox1 As ComboBox
    Friend WithEvents Tbl_branchBindingSource2 As BindingSource
End Class
