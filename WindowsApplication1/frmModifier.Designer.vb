<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModifier
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
        Dim PhonenumLabel As System.Windows.Forms.Label
        Dim MailLabel As System.Windows.Forms.Label
        Dim BikoLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Dim Id_staffLabel As System.Windows.Forms.Label
        Dim Staff_nameLabel As System.Windows.Forms.Label
        Dim Staff_kanaLabel As System.Windows.Forms.Label
        Dim Branch_idLabel As System.Windows.Forms.Label
        Dim Carnum1Label As System.Windows.Forms.Label
        Dim Carnum2Label As System.Windows.Forms.Label
        Dim Carnum3Label As System.Windows.Forms.Label
        Dim Carnum4Label As System.Windows.Forms.Label
        Dim MusenLabel As System.Windows.Forms.Label
        Dim TonLabel As System.Windows.Forms.Label
        Dim BikoLabel1 As System.Windows.Forms.Label
        Dim Branch_idLabel1 As System.Windows.Forms.Label
        Dim Integ_idLabel As System.Windows.Forms.Label
        Dim Integ_phonenumLabel As System.Windows.Forms.Label
        Dim Integ_staffLabel As System.Windows.Forms.Label
        Dim Integ_carnumLabel As System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PhonenumTextBox = New System.Windows.Forms.TextBox()
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        Me.BikoTextBox = New System.Windows.Forms.TextBox()
        Me.ModelTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Id_staffTextBox = New System.Windows.Forms.TextBox()
        Me.Staff_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Staff_kanaTextBox = New System.Windows.Forms.TextBox()
        Me.Branch_idTextBox = New System.Windows.Forms.TextBox()
        Me.Carnum1TextBox = New System.Windows.Forms.TextBox()
        Me.Carnum2TextBox = New System.Windows.Forms.TextBox()
        Me.Carnum3TextBox = New System.Windows.Forms.TextBox()
        Me.Carnum4TextBox = New System.Windows.Forms.TextBox()
        Me.MusenTextBox = New System.Windows.Forms.TextBox()
        Me.TonTextBox = New System.Windows.Forms.TextBox()
        Me.BikoTextBox1 = New System.Windows.Forms.TextBox()
        Me.Branch_idTextBox1 = New System.Windows.Forms.TextBox()
        Me.Tbl_carBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSet = New MAd.PhoneNumDBDataSet()
        Me.Tbl_staffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PhoneNumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PhoneNumTableAdapter = New MAd.PhoneNumDBDataSetTableAdapters.tbl_PhoneNumTableAdapter()
        Me.TableAdapterManager = New MAd.PhoneNumDBDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_staffTableAdapter = New MAd.PhoneNumDBDataSetTableAdapters.tbl_staffTableAdapter()
        Me.Tbl_carTableAdapter = New MAd.PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter()
        Me.Tbl_IntegrateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_IntegrateTableAdapter = New MAd.PhoneNumDBDataSetTableAdapters.tbl_IntegrateTableAdapter()
        Me.Integ_idTextBox = New System.Windows.Forms.TextBox()
        Me.Integ_phonenumTextBox = New System.Windows.Forms.TextBox()
        Me.Integ_staffTextBox = New System.Windows.Forms.TextBox()
        Me.Integ_carnumTextBox = New System.Windows.Forms.TextBox()
        PhonenumLabel = New System.Windows.Forms.Label()
        MailLabel = New System.Windows.Forms.Label()
        BikoLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        Id_staffLabel = New System.Windows.Forms.Label()
        Staff_nameLabel = New System.Windows.Forms.Label()
        Staff_kanaLabel = New System.Windows.Forms.Label()
        Branch_idLabel = New System.Windows.Forms.Label()
        Carnum1Label = New System.Windows.Forms.Label()
        Carnum2Label = New System.Windows.Forms.Label()
        Carnum3Label = New System.Windows.Forms.Label()
        Carnum4Label = New System.Windows.Forms.Label()
        MusenLabel = New System.Windows.Forms.Label()
        TonLabel = New System.Windows.Forms.Label()
        BikoLabel1 = New System.Windows.Forms.Label()
        Branch_idLabel1 = New System.Windows.Forms.Label()
        Integ_idLabel = New System.Windows.Forms.Label()
        Integ_phonenumLabel = New System.Windows.Forms.Label()
        Integ_staffLabel = New System.Windows.Forms.Label()
        Integ_carnumLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Tbl_carBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_staffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PhoneNumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_IntegrateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PhonenumLabel
        '
        PhonenumLabel.AutoSize = True
        PhonenumLabel.Location = New System.Drawing.Point(17, 34)
        PhonenumLabel.Name = "PhonenumLabel"
        PhonenumLabel.Size = New System.Drawing.Size(53, 12)
        PhonenumLabel.TabIndex = 0
        PhonenumLabel.Text = "電話番号"
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(17, 59)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(58, 12)
        MailLabel.TabIndex = 2
        MailLabel.Text = "ﾒｰﾙｱﾄﾞﾚｽ"
        '
        'BikoLabel
        '
        BikoLabel.AutoSize = True
        BikoLabel.Location = New System.Drawing.Point(17, 84)
        BikoLabel.Name = "BikoLabel"
        BikoLabel.Size = New System.Drawing.Size(29, 12)
        BikoLabel.TabIndex = 4
        BikoLabel.Text = "備考"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(17, 109)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(29, 12)
        ModelLabel.TabIndex = 6
        ModelLabel.Text = "機種"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(524, 350)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "決定"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(605, 350)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "キャンセル"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(PhonenumLabel)
        Me.GroupBox1.Controls.Add(Me.PhonenumTextBox)
        Me.GroupBox1.Controls.Add(MailLabel)
        Me.GroupBox1.Controls.Add(Me.MailTextBox)
        Me.GroupBox1.Controls.Add(BikoLabel)
        Me.GroupBox1.Controls.Add(Me.BikoTextBox)
        Me.GroupBox1.Controls.Add(ModelLabel)
        Me.GroupBox1.Controls.Add(Me.ModelTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 298)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "電話番号"
        '
        'PhonenumTextBox
        '
        Me.PhonenumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PhoneNumBindingSource, "phonenum", True))
        Me.PhonenumTextBox.Location = New System.Drawing.Point(81, 31)
        Me.PhonenumTextBox.Name = "PhonenumTextBox"
        Me.PhonenumTextBox.Size = New System.Drawing.Size(100, 19)
        Me.PhonenumTextBox.TabIndex = 1
        '
        'MailTextBox
        '
        Me.MailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PhoneNumBindingSource, "mail", True))
        Me.MailTextBox.Location = New System.Drawing.Point(81, 56)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.Size = New System.Drawing.Size(100, 19)
        Me.MailTextBox.TabIndex = 3
        '
        'BikoTextBox
        '
        Me.BikoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PhoneNumBindingSource, "biko", True))
        Me.BikoTextBox.Location = New System.Drawing.Point(81, 81)
        Me.BikoTextBox.Name = "BikoTextBox"
        Me.BikoTextBox.Size = New System.Drawing.Size(100, 19)
        Me.BikoTextBox.TabIndex = 5
        '
        'ModelTextBox
        '
        Me.ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PhoneNumBindingSource, "model", True))
        Me.ModelTextBox.Location = New System.Drawing.Point(81, 106)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.Size = New System.Drawing.Size(100, 19)
        Me.ModelTextBox.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Id_staffLabel)
        Me.GroupBox2.Controls.Add(Me.Id_staffTextBox)
        Me.GroupBox2.Controls.Add(Staff_nameLabel)
        Me.GroupBox2.Controls.Add(Me.Staff_nameTextBox)
        Me.GroupBox2.Controls.Add(Staff_kanaLabel)
        Me.GroupBox2.Controls.Add(Me.Staff_kanaTextBox)
        Me.GroupBox2.Controls.Add(Branch_idLabel)
        Me.GroupBox2.Controls.Add(Me.Branch_idTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(232, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 298)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "社員情報"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Carnum1Label)
        Me.GroupBox3.Controls.Add(Me.Carnum1TextBox)
        Me.GroupBox3.Controls.Add(Carnum2Label)
        Me.GroupBox3.Controls.Add(Me.Carnum2TextBox)
        Me.GroupBox3.Controls.Add(Carnum3Label)
        Me.GroupBox3.Controls.Add(Me.Carnum3TextBox)
        Me.GroupBox3.Controls.Add(Carnum4Label)
        Me.GroupBox3.Controls.Add(Me.Carnum4TextBox)
        Me.GroupBox3.Controls.Add(MusenLabel)
        Me.GroupBox3.Controls.Add(Me.MusenTextBox)
        Me.GroupBox3.Controls.Add(TonLabel)
        Me.GroupBox3.Controls.Add(Me.TonTextBox)
        Me.GroupBox3.Controls.Add(BikoLabel1)
        Me.GroupBox3.Controls.Add(Me.BikoTextBox1)
        Me.GroupBox3.Controls.Add(Branch_idLabel1)
        Me.GroupBox3.Controls.Add(Me.Branch_idTextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(463, 46)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(217, 298)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "車両情報"
        '
        'Id_staffLabel
        '
        Id_staffLabel.AutoSize = True
        Id_staffLabel.Location = New System.Drawing.Point(18, 34)
        Id_staffLabel.Name = "Id_staffLabel"
        Id_staffLabel.Size = New System.Drawing.Size(44, 12)
        Id_staffLabel.TabIndex = 0
        Id_staffLabel.Text = "id staff:"
        '
        'Id_staffTextBox
        '
        Me.Id_staffTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "id_staff", True))
        Me.Id_staffTextBox.Location = New System.Drawing.Point(86, 31)
        Me.Id_staffTextBox.Name = "Id_staffTextBox"
        Me.Id_staffTextBox.Size = New System.Drawing.Size(100, 19)
        Me.Id_staffTextBox.TabIndex = 1
        '
        'Staff_nameLabel
        '
        Staff_nameLabel.AutoSize = True
        Staff_nameLabel.Location = New System.Drawing.Point(18, 59)
        Staff_nameLabel.Name = "Staff_nameLabel"
        Staff_nameLabel.Size = New System.Drawing.Size(29, 12)
        Staff_nameLabel.TabIndex = 2
        Staff_nameLabel.Text = "氏名"
        '
        'Staff_nameTextBox
        '
        Me.Staff_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "staff_name", True))
        Me.Staff_nameTextBox.Location = New System.Drawing.Point(86, 56)
        Me.Staff_nameTextBox.Name = "Staff_nameTextBox"
        Me.Staff_nameTextBox.Size = New System.Drawing.Size(100, 19)
        Me.Staff_nameTextBox.TabIndex = 3
        '
        'Staff_kanaLabel
        '
        Staff_kanaLabel.AutoSize = True
        Staff_kanaLabel.Location = New System.Drawing.Point(18, 84)
        Staff_kanaLabel.Name = "Staff_kanaLabel"
        Staff_kanaLabel.Size = New System.Drawing.Size(59, 12)
        Staff_kanaLabel.TabIndex = 4
        Staff_kanaLabel.Text = "staff kana:"
        '
        'Staff_kanaTextBox
        '
        Me.Staff_kanaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "staff_kana", True))
        Me.Staff_kanaTextBox.Location = New System.Drawing.Point(86, 81)
        Me.Staff_kanaTextBox.Name = "Staff_kanaTextBox"
        Me.Staff_kanaTextBox.Size = New System.Drawing.Size(100, 19)
        Me.Staff_kanaTextBox.TabIndex = 5
        '
        'Branch_idLabel
        '
        Branch_idLabel.AutoSize = True
        Branch_idLabel.Location = New System.Drawing.Point(18, 109)
        Branch_idLabel.Name = "Branch_idLabel"
        Branch_idLabel.Size = New System.Drawing.Size(54, 12)
        Branch_idLabel.TabIndex = 6
        Branch_idLabel.Text = "branch id:"
        '
        'Branch_idTextBox
        '
        Me.Branch_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "branch_id", True))
        Me.Branch_idTextBox.Location = New System.Drawing.Point(86, 106)
        Me.Branch_idTextBox.Name = "Branch_idTextBox"
        Me.Branch_idTextBox.Size = New System.Drawing.Size(100, 19)
        Me.Branch_idTextBox.TabIndex = 7
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
        'Carnum1TextBox
        '
        Me.Carnum1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "carnum1", True))
        Me.Carnum1TextBox.Location = New System.Drawing.Point(82, 31)
        Me.Carnum1TextBox.Name = "Carnum1TextBox"
        Me.Carnum1TextBox.Size = New System.Drawing.Size(100, 19)
        Me.Carnum1TextBox.TabIndex = 1
        '
        'Carnum2Label
        '
        Carnum2Label.AutoSize = True
        Carnum2Label.Location = New System.Drawing.Point(22, 59)
        Carnum2Label.Name = "Carnum2Label"
        Carnum2Label.Size = New System.Drawing.Size(50, 12)
        Carnum2Label.TabIndex = 2
        Carnum2Label.Text = "carnum2:"
        '
        'Carnum2TextBox
        '
        Me.Carnum2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "carnum2", True))
        Me.Carnum2TextBox.Location = New System.Drawing.Point(82, 56)
        Me.Carnum2TextBox.Name = "Carnum2TextBox"
        Me.Carnum2TextBox.Size = New System.Drawing.Size(100, 19)
        Me.Carnum2TextBox.TabIndex = 3
        '
        'Carnum3Label
        '
        Carnum3Label.AutoSize = True
        Carnum3Label.Location = New System.Drawing.Point(22, 84)
        Carnum3Label.Name = "Carnum3Label"
        Carnum3Label.Size = New System.Drawing.Size(50, 12)
        Carnum3Label.TabIndex = 4
        Carnum3Label.Text = "carnum3:"
        '
        'Carnum3TextBox
        '
        Me.Carnum3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "carnum3", True))
        Me.Carnum3TextBox.Location = New System.Drawing.Point(82, 81)
        Me.Carnum3TextBox.Name = "Carnum3TextBox"
        Me.Carnum3TextBox.Size = New System.Drawing.Size(100, 19)
        Me.Carnum3TextBox.TabIndex = 5
        '
        'Carnum4Label
        '
        Carnum4Label.AutoSize = True
        Carnum4Label.Location = New System.Drawing.Point(22, 109)
        Carnum4Label.Name = "Carnum4Label"
        Carnum4Label.Size = New System.Drawing.Size(50, 12)
        Carnum4Label.TabIndex = 6
        Carnum4Label.Text = "carnum4:"
        '
        'Carnum4TextBox
        '
        Me.Carnum4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "carnum4", True))
        Me.Carnum4TextBox.Location = New System.Drawing.Point(82, 106)
        Me.Carnum4TextBox.Name = "Carnum4TextBox"
        Me.Carnum4TextBox.Size = New System.Drawing.Size(100, 19)
        Me.Carnum4TextBox.TabIndex = 7
        '
        'MusenLabel
        '
        MusenLabel.AutoSize = True
        MusenLabel.Location = New System.Drawing.Point(22, 134)
        MusenLabel.Name = "MusenLabel"
        MusenLabel.Size = New System.Drawing.Size(29, 12)
        MusenLabel.TabIndex = 8
        MusenLabel.Text = "無線"
        '
        'MusenTextBox
        '
        Me.MusenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "musen", True))
        Me.MusenTextBox.Location = New System.Drawing.Point(82, 131)
        Me.MusenTextBox.Name = "MusenTextBox"
        Me.MusenTextBox.Size = New System.Drawing.Size(100, 19)
        Me.MusenTextBox.TabIndex = 9
        '
        'TonLabel
        '
        TonLabel.AutoSize = True
        TonLabel.Location = New System.Drawing.Point(22, 159)
        TonLabel.Name = "TonLabel"
        TonLabel.Size = New System.Drawing.Size(29, 12)
        TonLabel.TabIndex = 10
        TonLabel.Text = "車格"
        '
        'TonTextBox
        '
        Me.TonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "ton", True))
        Me.TonTextBox.Location = New System.Drawing.Point(82, 156)
        Me.TonTextBox.Name = "TonTextBox"
        Me.TonTextBox.Size = New System.Drawing.Size(100, 19)
        Me.TonTextBox.TabIndex = 11
        '
        'BikoLabel1
        '
        BikoLabel1.AutoSize = True
        BikoLabel1.Location = New System.Drawing.Point(22, 184)
        BikoLabel1.Name = "BikoLabel1"
        BikoLabel1.Size = New System.Drawing.Size(29, 12)
        BikoLabel1.TabIndex = 12
        BikoLabel1.Text = "備考"
        '
        'BikoTextBox1
        '
        Me.BikoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "biko", True))
        Me.BikoTextBox1.Location = New System.Drawing.Point(82, 181)
        Me.BikoTextBox1.Name = "BikoTextBox1"
        Me.BikoTextBox1.Size = New System.Drawing.Size(100, 19)
        Me.BikoTextBox1.TabIndex = 13
        '
        'Branch_idLabel1
        '
        Branch_idLabel1.AutoSize = True
        Branch_idLabel1.Location = New System.Drawing.Point(22, 209)
        Branch_idLabel1.Name = "Branch_idLabel1"
        Branch_idLabel1.Size = New System.Drawing.Size(54, 12)
        Branch_idLabel1.TabIndex = 14
        Branch_idLabel1.Text = "branch id:"
        '
        'Branch_idTextBox1
        '
        Me.Branch_idTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_carBindingSource, "branch_id", True))
        Me.Branch_idTextBox1.Location = New System.Drawing.Point(82, 206)
        Me.Branch_idTextBox1.Name = "Branch_idTextBox1"
        Me.Branch_idTextBox1.Size = New System.Drawing.Size(100, 19)
        Me.Branch_idTextBox1.TabIndex = 15
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
        'Tbl_staffBindingSource
        '
        Me.Tbl_staffBindingSource.DataMember = "tbl_staff"
        Me.Tbl_staffBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'Tbl_PhoneNumBindingSource
        '
        Me.Tbl_PhoneNumBindingSource.DataMember = "tbl_PhoneNum"
        Me.Tbl_PhoneNumBindingSource.DataSource = Me.PhoneNumDBDataSet
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
        'Tbl_IntegrateBindingSource
        '
        Me.Tbl_IntegrateBindingSource.DataMember = "tbl_Integrate"
        Me.Tbl_IntegrateBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'Tbl_IntegrateTableAdapter
        '
        Me.Tbl_IntegrateTableAdapter.ClearBeforeFill = True
        '
        'Integ_idLabel
        '
        Integ_idLabel.AutoSize = True
        Integ_idLabel.Location = New System.Drawing.Point(120, 370)
        Integ_idLabel.Name = "Integ_idLabel"
        Integ_idLabel.Size = New System.Drawing.Size(45, 12)
        Integ_idLabel.TabIndex = 7
        Integ_idLabel.Text = "integ id:"
        '
        'Integ_idTextBox
        '
        Me.Integ_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_IntegrateBindingSource, "integ_id", True))
        Me.Integ_idTextBox.Location = New System.Drawing.Point(213, 367)
        Me.Integ_idTextBox.Name = "Integ_idTextBox"
        Me.Integ_idTextBox.Size = New System.Drawing.Size(100, 19)
        Me.Integ_idTextBox.TabIndex = 8
        '
        'Integ_phonenumLabel
        '
        Integ_phonenumLabel.AutoSize = True
        Integ_phonenumLabel.Location = New System.Drawing.Point(120, 395)
        Integ_phonenumLabel.Name = "Integ_phonenumLabel"
        Integ_phonenumLabel.Size = New System.Drawing.Size(87, 12)
        Integ_phonenumLabel.TabIndex = 9
        Integ_phonenumLabel.Text = "integ phonenum:"
        '
        'Integ_phonenumTextBox
        '
        Me.Integ_phonenumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_IntegrateBindingSource, "integ_phonenum", True))
        Me.Integ_phonenumTextBox.Location = New System.Drawing.Point(213, 392)
        Me.Integ_phonenumTextBox.Name = "Integ_phonenumTextBox"
        Me.Integ_phonenumTextBox.Size = New System.Drawing.Size(100, 19)
        Me.Integ_phonenumTextBox.TabIndex = 10
        '
        'Integ_staffLabel
        '
        Integ_staffLabel.AutoSize = True
        Integ_staffLabel.Location = New System.Drawing.Point(120, 420)
        Integ_staffLabel.Name = "Integ_staffLabel"
        Integ_staffLabel.Size = New System.Drawing.Size(60, 12)
        Integ_staffLabel.TabIndex = 11
        Integ_staffLabel.Text = "integ staff:"
        '
        'Integ_staffTextBox
        '
        Me.Integ_staffTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_IntegrateBindingSource, "integ_staff", True))
        Me.Integ_staffTextBox.Location = New System.Drawing.Point(213, 417)
        Me.Integ_staffTextBox.Name = "Integ_staffTextBox"
        Me.Integ_staffTextBox.Size = New System.Drawing.Size(100, 19)
        Me.Integ_staffTextBox.TabIndex = 12
        '
        'Integ_carnumLabel
        '
        Integ_carnumLabel.AutoSize = True
        Integ_carnumLabel.Location = New System.Drawing.Point(120, 445)
        Integ_carnumLabel.Name = "Integ_carnumLabel"
        Integ_carnumLabel.Size = New System.Drawing.Size(73, 12)
        Integ_carnumLabel.TabIndex = 13
        Integ_carnumLabel.Text = "integ carnum:"
        '
        'Integ_carnumTextBox
        '
        Me.Integ_carnumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_IntegrateBindingSource, "integ_carnum", True))
        Me.Integ_carnumTextBox.Location = New System.Drawing.Point(213, 442)
        Me.Integ_carnumTextBox.Name = "Integ_carnumTextBox"
        Me.Integ_carnumTextBox.Size = New System.Drawing.Size(100, 19)
        Me.Integ_carnumTextBox.TabIndex = 14
        '
        'frmModifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 481)
        Me.Controls.Add(Integ_idLabel)
        Me.Controls.Add(Me.Integ_idTextBox)
        Me.Controls.Add(Integ_phonenumLabel)
        Me.Controls.Add(Me.Integ_phonenumTextBox)
        Me.Controls.Add(Integ_staffLabel)
        Me.Controls.Add(Me.Integ_staffTextBox)
        Me.Controls.Add(Integ_carnumLabel)
        Me.Controls.Add(Me.Integ_carnumTextBox)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "frmModifier"
        Me.Text = "選択行の編集"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Tbl_carBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_staffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PhoneNumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_IntegrateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PhonenumTextBox As TextBox
    Friend WithEvents MailTextBox As TextBox
    Friend WithEvents BikoTextBox As TextBox
    Friend WithEvents ModelTextBox As TextBox
    Friend WithEvents Tbl_staffBindingSource As BindingSource
    Friend WithEvents Tbl_staffTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_staffTableAdapter
    Friend WithEvents Id_staffTextBox As TextBox
    Friend WithEvents Staff_nameTextBox As TextBox
    Friend WithEvents Staff_kanaTextBox As TextBox
    Friend WithEvents Branch_idTextBox As TextBox
    Friend WithEvents Tbl_carBindingSource As BindingSource
    Friend WithEvents Tbl_carTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter
    Friend WithEvents Carnum1TextBox As TextBox
    Friend WithEvents Carnum2TextBox As TextBox
    Friend WithEvents Carnum3TextBox As TextBox
    Friend WithEvents Carnum4TextBox As TextBox
    Friend WithEvents MusenTextBox As TextBox
    Friend WithEvents TonTextBox As TextBox
    Friend WithEvents BikoTextBox1 As TextBox
    Friend WithEvents Branch_idTextBox1 As TextBox
    Friend WithEvents Tbl_IntegrateBindingSource As BindingSource
    Friend WithEvents Tbl_IntegrateTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_IntegrateTableAdapter
    Friend WithEvents Integ_idTextBox As TextBox
    Friend WithEvents Integ_phonenumTextBox As TextBox
    Friend WithEvents Integ_staffTextBox As TextBox
    Friend WithEvents Integ_carnumTextBox As TextBox
End Class
