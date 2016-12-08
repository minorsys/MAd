Public Class frmModifier
    '###frmGrdからのデータの流れ###
    'public sub SetSelectedRecordが実行されると、frmGrdから受け取ったIntegIDをもとに、Tbl_IntegTableAdapterにデータソースをセットする
    '3つのラベルlblIntegPhonenum,lblIntegStaffID,IntegCarnumはTblIntegBindingSourceをデータソースにもつので、該当するレコードがセットされる。
    'ラベルのtext値が変更されると、textChangedイベントが発生する。
    '各イベントプロシージャ内ではラベルのtext値をキューにして、電話、社員、車両の3テーブルのテーブルアダプタにデータソースをセットする。
    'フォーム内の各テキストボックスは各テーブルをデータソースにもつので、該当するレコードがセットされる。

    '###電話、社員、車両の各レコードを変更する流れ###
    '3つテーブルに対応する各コンボボックスの(cmbPhonenumChangeほか)のSelectedValueChangedイベントが発生すると、
    'コンボボックスで選択されたtext値を、lblIntegPhonenum他3つのラベルに代入する。


    Private frm_Grd As frmGrd

    Public Sub SetSelectedRecord(ByVal code As String, ByVal f As frmGrd)
        '呼び出し元フォームを格納する
        frm_Grd = f

        '電話番号マスタのデータをデータソースにセット
        'Me.Tbl_PhoneNumTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_PhoneNum)

        '受け取ったコードを利用して、該当するIntegテーブルのデータをデータソースにセット
        Me.Tbl_IntegrateTableAdapter.FillByCode(Me.PhoneNumDBDataSet.tbl_Integrate, code)

    End Sub


    Private Sub frmModifier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_branch' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_branchTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_branch)
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_car' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        'Me.Tbl_carTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_car)
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_staff' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        'Me.Tbl_staffTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_staff)
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_PhoneNum' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        'Me.Tbl_PhoneNumTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_PhoneNum)

        'コネクションを指定する
        Using connection As New SqlClient.SqlConnection(My.Settings.PhoneNumDBConnectionString)

            'コマンドをコネクションから作成する
            Dim command As SqlClient.SqlCommand = connection.CreateCommand

            'コネクションを開く
            connection.Open()

            'データリーダーの定義
            Dim dr As SqlClient.SqlDataReader

            '先頭に(全て)を追加する
            cmbPhonenumChange.Items.Add("")
            cmbStaffNameChange.Items.Add("")
            cmbCarnumChange.Items.Add("")

            '### 電話番号変更用コンボボックスの設定###
            'データコマンドの定義
            command.CommandText = "SELECT phonenum FROM tbl_phonenum ORDER BY phonenum"

            'データリーダーからのデータの読出し
            dr = command.ExecuteReader()
            Do While dr.Read
                '読みだしたデータをコンボボックスに追加する
                cmbPhonenumChange.Items.Add(dr("phonenum"))
            Loop

            'データリーダーを閉じる
            dr.Close()

            '###氏名変更用コンボボックス###
            'データコマンドの定義
            command.CommandText = "SELECT id_staff, staff_name, staff_kana FROM tbl_staff ORDER BY staff_kana"
            'データリーダーからのデータの読出し
            dr = command.ExecuteReader()
            Do While dr.Read
                '読みだしたデータをコンボボックスに追加する
                cmbStaffNameChange.Items.Add(dr("id_staff") & " " & dr("staff_name"))
            Loop
            'データリーダーを閉じる
            dr.Close()

            '###車番変更用コンボボックス###
            command.CommandText = "SELECT carnum1 FROM tbl_car ORDER BY carnum1"
            'データリーダーからのデータの読出し
            dr = command.ExecuteReader()
            Do While dr.Read
                '読みだしたデータをコンボボックスに追加する
                cmbCarnumChange.Items.Add(dr("carnum1"))
            Loop

            'データリーダーを閉じる
            dr.Close()

            'コネクションを閉じる
            connection.Close()

            '3つのコンボボックスで既定の状態として、先頭の空行を選択する
            cmbPhonenumChange.SelectedIndex = 0
            cmbStaffNameChange.SelectedIndex = 0
            cmbCarnumChange.SelectedIndex = 0

        End Using

        'フォーム開始時、所属コンボボックスの値が自動でセットされないでindex = 0になってしまうので苦肉の策
        cmbStaffBranch.SelectedValue = lblStaffBranch.Text
        cmbCarBranch.SelectedValue = lblCarBranch.Text

        '### 車格コンボボックスに値をセット ###
        cmbTon.Items.Add("2t平")
        cmbTon.Items.Add("2t平PG")
        cmbTon.Items.Add("2tU")
        cmbTon.Items.Add("3tU")
        cmbTon.Items.Add("4tU")
        cmbTon.Items.Add("7tU")
        cmbTon.Items.Add("10tU")
        cmbTon.Items.Add("15tU")
        cmbTon.Items.Add("その他")

    End Sub

    '###frmGrdから受け取ったレコードをラベルに出力する###
    '電話番号
    Private Sub lblIntegPhonenum_TextChanged(sender As Object, e As EventArgs) Handles lblIntegPhonenum.TextChanged
        Dim pcode As String = lblIntegPhonenum.Text
        Me.Tbl_PhoneNumTableAdapter.FillByPcode(Me.PhoneNumDBDataSet.tbl_PhoneNum, pcode)

    End Sub

    '社員ID
    Private Sub lblIntegStaffID_TextChanged(sender As Object, e As EventArgs) Handles lblIntegStaffID.TextChanged
        Dim scode As String = lblIntegStaffID.Text
        Me.Tbl_staffTableAdapter.FillByScode(Me.PhoneNumDBDataSet.tbl_staff, scode)

    End Sub

    '車番
    Private Sub lblIntegCarnum_TextChanged(sender As Object, e As EventArgs) Handles lblIntegCarnum.TextChanged
        Dim carcode As String = lblIntegCarnum.Text
        Me.Tbl_carTableAdapter.FillByCarcode(Me.PhoneNumDBDataSet.tbl_car, carcode)
    End Sub

    '###電話番号変更コンボボックスの値が変更されたら、ラベルの電話番号の値を変更する###
    Private Sub cmbPhonenumChange_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbPhonenumChange.SelectedValueChanged
        If cmbPhonenumChange.SelectedIndex > 0 Then
            lblIntegPhonenum.Text = cmbPhonenumChange.Text
        End If
    End Sub

    '###氏名変更コンボボックスの値が変更されたら、ラベルの社員IDの値を変更###
    Private Sub cmbStaffNameChange_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbStaffNameChange.SelectedValueChanged
        If cmbStaffNameChange.SelectedIndex > 0 Then
            lblIntegStaffID.Text = Strings.Left(cmbStaffNameChange.Text, 5)
        End If
    End Sub

    '###車番変更コンボボックスの値が変更されたら、ラベルの車番の値を変更する###
    Private Sub cmbCarnumChange_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbCarnumChange.SelectedValueChanged
        If cmbCarnumChange.SelectedIndex > 0 Then
            lblIntegCarnum.Text = cmbCarnumChange.Text
        End If
    End Sub

    '[キャンセル]ボタン
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        '呼び出し元のフォームを表示する
        frm_Grd.Visible = True

        'このフォームを閉じる
        Me.Close()

    End Sub

    '[登録]ボタンを押すと、現在表示されている内容で各テーブルのレコードを更新する
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        '登録する内容がデータ型と一致しているかチェック
        If Not CheckEditData() Then
            Return
        End If


        '保存確認と保存処理
        If MsgBox("これまでの修正内容をデータベースに保存しますか？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            '編集状態を確定する
            Me.Tbl_IntegrateBindingSource.EndEdit()
            Me.Tbl_PhoneNumBindingSource.EndEdit()
            Me.Tbl_staffBindingSource.EndEdit()
            Me.Tbl_carBindingSource.EndEdit()

            'テーブルアダプタを介して、レコードを更新する
            Me.Tbl_IntegrateTableAdapter.Update(Me.PhoneNumDBDataSet.tbl_Integrate)
            Me.Tbl_PhoneNumTableAdapter.Update(Me.PhoneNumDBDataSet.tbl_PhoneNum)
            Me.Tbl_staffTableAdapter.Update(Me.PhoneNumDBDataSet.tbl_staff)
            Me.Tbl_carTableAdapter.Update(Me.PhoneNumDBDataSet.tbl_car)

            'フォームを閉じる
            Me.Close()
        End If
    End Sub

    '[クリア]ボタンを押すと、lblInteg～を空白にする。(LblInteg～はTblIntegにバインドしている)
    Private Sub btnClearPhone_Click(sender As Object, e As EventArgs) Handles btnClearPhone.Click
        lblIntegPhonenum.Text = ""
    End Sub

    Private Sub btnClearStaff_Click(sender As Object, e As EventArgs) Handles btnClearStaff.Click
        lblIntegStaffID.Text = ""
    End Sub

    Private Sub btnClearCar_Click(sender As Object, e As EventArgs) Handles btnClearCar.Click
        lblIntegCarnum.Text = ""
    End Sub

    Private Function CheckEditData() As Boolean

        '電話番号情報の検査 電話番号が選択されてなければスキップ
        If lblIntegPhonenum.Text <> "" Then


            'データの検査(機種名)
            With txtModel
                If Not CheckMaxLengthPhone("model", .Text) Then
                    MsgBox("機種名は半角20字以内で入力してください")
                    .Select()
                    Return False
                End If
            End With

            With txtMail
                'データの検査(メール)
                If Not CheckMaxLengthPhone("mail", .Text) Then
                    MsgBox("メールアドレスは半角50字以内で入力してください")
                    .Select()
                    Return False
                End If
            End With

            'データの検査(備考)
            With txtBikoPhone
                If Not CheckMaxLengthPhone("biko", .Text) Then
                    MsgBox("備考は全角50字以内で入力してください")
                    .Select()
                    Return False
                End If
            End With

        End If

        '社員情報の検査　社員が選択されていなければスキップ
        If lblIntegStaffID.Text <> "" Then
            'データの検査(氏名ｶﾅ)
            With txtStaffKana
                If Not CheckMaxLengthStaff("staff_kana", .Text) Then
                    MsgBox("氏名ｶﾅは半角20字以内で入力してください")
                    .Select()
                    Return False
                End If
            End With

            'データの検査(所属)
            With cmbStaffBranch
                If .SelectedIndex = -1 Then
                    MsgBox("社員の所属が選択されていません")
                    .Select()
                    Return False
                End If
            End With

        End If

        '車両情報の検査　車両が選択されていなければスキップ
        If lblIntegCarnum.Text <> "" Then
            'データの検査(車番2)
            With txtCarnum2
                If Not CheckMaxLengthCar("carnum2", .Text) Then
                    MsgBox("車番2は全角4字以内で入力してください")
                    .Select()
                    Return False
                End If
            End With

            'データの検査(車番3)
            With txtCarnum3
                If Not CheckMaxLengthCar("carnum3", .Text) Then
                    MsgBox("車番3は半角3字以内で入力してください")
                    .Select()
                    Return False
                End If
            End With

            'データの検査(車番4)
            With txtCarnum4
                If Not CheckMaxLengthCar("carnum4", .Text) Then
                    MsgBox("車番4は全角1文字で入力してください")
                    .Select()
                    Return False
                End If
            End With

            'データの検査(無線)
            With txtMusen
                If Not CheckMaxLengthCar("musen", .Text) Then

                    MsgBox("無線番号は半角4字以内で入力してください")
                    .Select()
                    Return False
                End If
            End With

            'データの検査(車格)
            With txtTon
                If Not CheckMaxLengthCar("ton", .Text) Then
                    MsgBox("車格は半角4字以内で入力してください")
                    .Select()
                    Return False
                End If
            End With

            'データの検査(備考)
            With txtBikoCar
                If Not CheckMaxLengthCar("biko", .Text) Then
                    MsgBox("備考は全角50字以内で入力してください")
                    .Select()
                    Return False
                End If
            End With

            'データの検査(車庫)
            With cmbCarBranch
                If .SelectedIndex = -1 Then
                    MsgBox("車両の所属が選択されていません")
                    .Select()
                    Return False

                End If
            End With
        End If

        '全ての検査を通過した
        Return True

    End Function

    '桁数チェック-電話番号(指定された列のサイズと文字列の比較)
    Private Function CheckMaxLengthPhone(ByVal fieldname As String, ByVal value As String)
        'データセットから列の情報を読み取る
        Dim column As DataColumn = PhoneNumDBDataSet.tbl_PhoneNum.Columns(fieldname)
        'シフトJISで文字列のバイト数を取得する
        Dim length As Integer = System.Text.Encoding.GetEncoding(932).GetByteCount(value)

        '指定されたサイズを超えたときはエラーになる
        If length > column.MaxLength Then
            Return False
        Else
            Return True
        End If
    End Function

    '桁数チェック-社員(指定された列のサイズと文字列の比較)
    Private Function CheckMaxLengthStaff(ByVal fieldname As String, ByVal value As String)
        'データセットから列の情報を読み取る
        Dim column As DataColumn = PhoneNumDBDataSet.tbl_staff.Columns(fieldname)
        'シフトJISで文字列のバイト数を取得する
        Dim length As Integer = System.Text.Encoding.GetEncoding(932).GetByteCount(value)

        '指定されたサイズを超えたときはエラーになる
        If length > column.MaxLength Then
            Return False
        Else
            Return True
        End If
    End Function

    '桁数チェック-車両(指定された列のサイズと文字列の比較)
    Private Function CheckMaxLengthCar(ByVal fieldname As String, ByVal value As String)
        'データセットから列の情報を読み取る
        Dim column As DataColumn = PhoneNumDBDataSet.tbl_car.Columns(fieldname)
        'シフトJISで文字列のバイト数を取得する
        Dim length As Integer = System.Text.Encoding.GetEncoding(932).GetByteCount(value)

        '指定されたサイズを超えたときはエラーになる
        If length > column.MaxLength Then
            Return False
        Else
            Return True
        End If
    End Function

    '車格コンボボックスの値が変更されたら、車格テキストボックスに代入
    Private Sub cmbTon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTon.SelectedIndexChanged
        txtTon.Text = cmbTon.SelectedItem
    End Sub

    'キーボードショートカット
    Private Sub frmModifier_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()

        End Select
    End Sub
End Class