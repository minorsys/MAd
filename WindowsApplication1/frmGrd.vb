﻿Public Class frmGrd

    Private Sub frmGrd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.dtInteg' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        'Me.DtIntegTableAdapter.FillIntegTable(Me.PhoneNumDBDataSet.dtInteg)

        'コネクションを指定する
        Using connection As New SqlClient.SqlConnection(My.Settings.PhoneNumDBConnectionString)

            'コマンドをコネクションから作成する
            Dim command As SqlClient.SqlCommand = connection.CreateCommand

            'コネクションを開く
            connection.Open()

            'データリーダーの定義
            Dim dr As SqlClient.SqlDataReader

            '### 所属コンボボックス、車庫コンボボックスの設定###
            '先頭に(全て)を追加する
            cmbBranchStaff.Items.Add("(すべて)")
            cmbBranchCar.Items.Add("(すべて)")

            'データコマンドの定義
            command.CommandText = "SELECT * FROM tbl_branch ORDER BY id_branch"

            'データリーダーからのデータの読出し
            dr = command.ExecuteReader()
            Do While dr.Read
                '読みだしたデータをコンボボックスに追加する
                cmbBranchStaff.Items.Add(dr("id_branch") & ":" & dr("branch_name"))
                cmbBranchCar.Items.Add(dr("id_branch") & ":" & dr("branch_name"))
            Loop

            'データリーダーを閉じる
            dr.Close()

            'コネクションを閉じる
            connection.Close()

            '2つのコンボボックスで既定の状態として、先頭の(すべて)を選択する
            cmbBranchStaff.SelectedIndex = 0
            cmbBranchCar.SelectedIndex = 0

        End Using

        '指定された条件でデータベースを読み込む
        LoadDatabase()

    End Sub

    Public Sub LoadDatabase()
        Dim fs As String = ""
        Dim sql As String

        '電話番号フィルタの条件指定(部分一致)と条件式の作成
        If txtFilterPhonenum.Text <> "" Then
            fs = "tbl_phonenum.phonenum like '%" & txtFilterPhonenum.Text & "%'"
        End If

        '氏名フィルタの条件指定(部分一致)と条件式の作成
        If txtFilterKana.Text <> "" Then
            fs = "tbl_staff.staff_kana like '%" & txtFilterKana.Text & "%'"
        End If

        '所属コンボボックスの条件指定と条件式の作成
        If cmbBranchStaff.SelectedIndex > 0 Then
            If fs <> "" Then
                fs &= "AND "
            End If

            fs &= "tbl_staff.branch_id = '" & Strings.Left(cmbBranchStaff.Text, cmbBranchStaff.Text.IndexOf(":")) & "'"

        End If

        '車庫コンボボックスの条件指定と条件式の作成
        If cmbBranchCar.SelectedIndex > 0 Then
            If fs <> "" Then
                fs &= "AND "
            End If

            fs &= "tbl_car.branch_id = '" & Strings.Left(cmbBranchCar.Text, cmbBranchCar.Text.IndexOf(":")) & "'"

        End If

        'SQLステートメントの定義
        sql = "SELECT tbl_Integrate.integ_id, tbl_Integrate.integ_phonenum, tbl_Integrate.integ_staff, tbl_Integrate.integ_carnum, " &
                                  "tbl_PhoneNum.phonenum, tbl_PhoneNum.mail, tbl_PhoneNum.biko, tbl_PhoneNum.model, tbl_staff.id_staff, " &
                                  "tbl_staff.staff_name, tbl_staff.staff_kana, tbl_staff.branch_id, tbl_car.branch_id AS car_branch, tbl_car.biko AS car_biko, " &
                                  "tbl_car.ton, tbl_car.musen, tbl_car.carnum4, tbl_car.carnum3, tbl_car.carnum2, tbl_car.carnum1, " &
                                  "tbl_branch_1.branch_name, tbl_branch_1.id_branch, tbl_branch.id_branch As staff_branch_id, " &
                                  "tbl_branch.branch_name AS staff_branch_name FROM tbl_PhoneNum RIGHT OUTER JOIN tbl_car INNER JOIN " &
                                  "tbl_branch As tbl_branch_1 On tbl_car.branch_id = tbl_branch_1.id_branch " &
                                    "RIGHT OUTER JOIN tbl_Integrate ON tbl_car.carnum1 = tbl_Integrate.integ_carnum " &
                                    "LEFT OUTER JOIN tbl_branch INNER JOIN tbl_staff ON tbl_branch.id_branch = tbl_staff.branch_id ON tbl_Integrate.integ_staff = tbl_staff.id_staff ON " &
                                  "tbl_PhoneNum.phonenum = tbl_Integrate.integ_phonenum"

        '条件が指定されているときには、WHERE句を追加する
        If fs <> "" Then
            sql &= " WHERE " & fs


        End If

        'データアダプタにSQLステートメントを設定する
        Dim da As New SqlClient.SqlDataAdapter(sql, My.Settings.PhoneNumDBConnectionString)

        'データテーブルをクリアする
        Me.PhoneNumDBDataSet.dtInteg.Clear()

        'データテーブルにデータアダプタを介してデータをセットする
        da.Fill(Me.PhoneNumDBDataSet.dtInteg)

    End Sub

    '電話番号フィルター変更時、データベースを再読み込み
    Private Sub txtFilterPhonenum_TextChanged(sender As Object, e As EventArgs) Handles txtFilterPhonenum.TextChanged
        LoadDatabase()
    End Sub

    '氏名ｶﾅフィルター変更時、データベースを再読み込み
    Private Sub txtFilterKana_TextChanged(sender As Object, e As EventArgs) Handles txtFilterKana.TextChanged
        LoadDatabase()
    End Sub

    '所属コンボボックス変更時、データベースを再読み込み
    Private Sub cmbBranchStaff_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBranchStaff.SelectedIndexChanged
        LoadDatabase()

    End Sub

    '車庫コンボボックス変更時、データベースを再読み込み
    Private Sub cmbBranchCar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBranchCar.SelectedIndexChanged
        LoadDatabase()

    End Sub


    Private Sub shiboriDatabase(ByVal fs As String)
        Dim sql As String

        'SQLステートメントの定義
        sql = "SELECT tbl_Integrate.integ_id, tbl_Integrate.integ_phonenum, tbl_Integrate.integ_staff, tbl_Integrate.integ_carnum, " &
                                  "tbl_PhoneNum.phonenum, tbl_PhoneNum.mail, tbl_PhoneNum.biko, tbl_PhoneNum.model, tbl_staff.id_staff, " &
                                  "tbl_staff.staff_name, tbl_staff.staff_kana, tbl_staff.branch_id, tbl_car.branch_id AS car_branch, tbl_car.biko AS car_biko, " &
                                  "tbl_car.ton, tbl_car.musen, tbl_car.carnum4, tbl_car.carnum3, tbl_car.carnum2, tbl_car.carnum1, " &
                                  "tbl_branch_1.branch_name, tbl_branch_1.id_branch, tbl_branch.id_branch As staff_branch_id, " &
                                  "tbl_branch.branch_name AS staff_branch_name FROM tbl_PhoneNum RIGHT OUTER JOIN tbl_car INNER JOIN " &
                                  "tbl_branch As tbl_branch_1 On tbl_car.branch_id = tbl_branch_1.id_branch " &
                                    "RIGHT OUTER JOIN tbl_Integrate ON tbl_car.carnum1 = tbl_Integrate.integ_carnum " &
                                    "LEFT OUTER JOIN tbl_branch INNER JOIN tbl_staff ON tbl_branch.id_branch = tbl_staff.branch_id ON tbl_Integrate.integ_staff = tbl_staff.id_staff ON " &
                                  "tbl_PhoneNum.phonenum = tbl_Integrate.integ_phonenum"


        sql &= " WHERE " & fs




            'データアダプタにSQLステートメントを設定する
            Dim da As New SqlClient.SqlDataAdapter(Sql, My.Settings.PhoneNumDBConnectionString)

        'データテーブルをクリアする
        Me.PhoneNumDBDataSet.dtInteg.Clear()

        'データテーブルにデータアダプタを介してデータをセットする
        da.Fill(Me.PhoneNumDBDataSet.dtInteg)
    End Sub

    '絞り込みア行
    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ｱ-ｵ]%'"

        shiboriDatabase(fs)
    End Sub

    '絞り込みカ行
    Private Sub btnKa_Click(sender As Object, e As EventArgs) Handles btnKa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ｶ-ｺ]%'"

        shiboriDatabase(fs)
    End Sub

    '絞り込みサ行
    Private Sub btnSa_Click(sender As Object, e As EventArgs) Handles btnSa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ｻ-ｿ]%'"

        shiboriDatabase(fs)
    End Sub

    '絞り込みタ行
    Private Sub btnTa_Click(sender As Object, e As EventArgs) Handles btnTa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ﾀ-ﾄ]%'"

        shiboriDatabase(fs)
    End Sub

    '絞り込みナ行
    Private Sub btnNa_Click(sender As Object, e As EventArgs) Handles btnNa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ﾅ-ﾉ]%'"

        shiboriDatabase(fs)
    End Sub

    '絞り込みハ行
    Private Sub btnHa_Click(sender As Object, e As EventArgs) Handles btnHa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ﾊ-ﾎ]%'"

        shiboriDatabase(fs)
    End Sub

    '絞り込みマ行
    Private Sub btnMa_Click(sender As Object, e As EventArgs) Handles btnMa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ﾏ-ﾓ]%'"

        shiboriDatabase(fs)
    End Sub

    '絞り込みヤ行
    Private Sub btnYa_Click(sender As Object, e As EventArgs) Handles btnYa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ﾔ-ﾖ]%'"

        shiboriDatabase(fs)
    End Sub

    '絞り込みラ行
    Private Sub btnRa_Click(sender As Object, e As EventArgs) Handles btnRa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ﾗ-ﾛ]%'"

        shiboriDatabase(fs)
    End Sub

    '絞り込みワ行
    Private Sub btnWa_Click(sender As Object, e As EventArgs) Handles btnWa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ﾜ-ｦ]%'"

        shiboriDatabase(fs)
    End Sub

    '絞り込み1000未満
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim fs As String
        fs = "tbl_car.carnum1 like '___'"

        shiboriDatabase(fs)
    End Sub

    '絞り込み1000番台
    Private Sub btn1000_Click(sender As Object, e As EventArgs) Handles btn1000.Click
        Dim fs As String
        fs = "tbl_car.carnum1 like '1___'"

        shiboriDatabase(fs)
    End Sub

    '絞り込み2000番台
    Private Sub btn2000_Click(sender As Object, e As EventArgs) Handles btn2000.Click
        Dim fs As String
        fs = "tbl_car.carnum1 like '2___'"

        shiboriDatabase(fs)
    End Sub

    '絞り込み3000番台
    Private Sub btn3000_Click(sender As Object, e As EventArgs) Handles btn3000.Click
        Dim fs As String
        fs = "tbl_car.carnum1 like '3___'"

        shiboriDatabase(fs)
    End Sub

    '絞り込み4000番台
    Private Sub btn4000_Click(sender As Object, e As EventArgs) Handles btn4000.Click
        Dim fs As String
        fs = "tbl_car.carnum1 like '4___'"

        shiboriDatabase(fs)
    End Sub

    '絞り込み5000番台
    Private Sub btn5000_Click(sender As Object, e As EventArgs) Handles btn5000.Click
        Dim fs As String
        fs = "tbl_car.carnum1 like '5___'"

        shiboriDatabase(fs)
    End Sub

    '絞り込み6000番台
    Private Sub btn6000_Click(sender As Object, e As EventArgs) Handles btn6000.Click
        Dim fs As String
        fs = "tbl_car.carnum1 like '6___'"

        shiboriDatabase(fs)
    End Sub

    '絞り込み7000番台
    Private Sub btn7000_Click(sender As Object, e As EventArgs) Handles btn7000.Click
        Dim fs As String
        fs = "tbl_car.carnum1 like '7___'"

        shiboriDatabase(fs)
    End Sub

    '絞り込み8000番台
    Private Sub btn8000_Click(sender As Object, e As EventArgs) Handles btn8000.Click
        Dim fs As String
        fs = "tbl_car.carnum1 like '8___'"

        shiboriDatabase(fs)
    End Sub

    '絞り込み9000番台
    Private Sub btn9000_Click(sender As Object, e As EventArgs) Handles btn9000.Click
        Dim fs As String
        fs = "tbl_car.carnum1 like '9___'"

        shiboriDatabase(fs)
    End Sub

    '[選択行の表示]ボタン
    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        'データグリッドビューが空のときは終了する
        If grdMain.Rows.Count = 0 Then Return

        Dim row As Integer
        Dim code As String

        'データグリッドビューの行番号を取得する
        row = grdMain.CurrentRow.Index
        '行番号から電話番号を取得する
        code = grdMain.Item(0, row).Value.ToString

        Dim frm As New frmModifier
        '[選択行の編集]フォームのSetSelectedRecordプロシージャを呼び出し、
        '指定した電話番号のデータを表示する
        frm.SetSelectedRecord(code, Me)
        '[選択行の編集]フォームを表示する
        frm.ShowDialog(Me)

        '[選択行の編集］フォームから戻ったら、このフォームを更新する
        LoadDatabase()

    End Sub
End Class