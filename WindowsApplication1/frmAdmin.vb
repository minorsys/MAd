Public Class frmAdmin
    Private Sub btnMasterPhone_Click(sender As Object, e As EventArgs) Handles btnMasterPhone.Click
        Dim frm As New frmMasterGrdPhone
        frm.ShowDialog(Me)

    End Sub

    Private Sub btnMasterStaff_Click(sender As Object, e As EventArgs) Handles btnMasterStaff.Click
        Dim frm As New frmMasterGrdStaff
        frm.ShowDialog(Me)

    End Sub

    Private Sub btnMasterCar_Click(sender As Object, e As EventArgs) Handles btnMasterCar.Click
        Dim frm As New frmMasterGrdCar
        frm.ShowDialog(Me)

    End Sub

    '[閉じる]ボタン
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    '[電話番号エクスポート]ボタン
    Private Sub btnExportPhone_Click(sender As Object, e As EventArgs) Handles btnExportPhone.Click
        Dim sr As IO.StreamWriter

        Dim exfolder As String
        Dim linetext As String

        '待機カーソルの表示
        Me.Cursor = Cursors.WaitCursor

        '保存先フォルダの指定
        exfolder = Application.StartupPath & "\データ出力\"

        'フォルダが存在しない場合には作成する
        If IO.Directory.Exists(exfolder) = False Then
            IO.Directory.CreateDirectory(exfolder)
        End If

        'ファイルを作成する
        sr = New IO.StreamWriter(exfolder & "phonenum.csv", False, System.Text.Encoding.GetEncoding("Shift_JIS"))

        'コネクションを指定する
        Using connection As New SqlClient.SqlConnection(My.Settings.PhoneNumDBConnectionString)
            'コマンドを定義する
            Dim command As New SqlClient.SqlCommand("select * from tbl_phonenum", connection)

            'コネクションを開く
            connection.Open()

            'データリーダーからのデータの読出し
            Dim dr As SqlClient.SqlDataReader = command.ExecuteReader()

            'データの分だけ処理を繰り返す
            Do While dr.Read
                '書き込むデータの生成(カンマ区切り)
                linetext = dr("phonenum") & ","
                linetext &= dr("mail") & ","
                linetext &= dr("biko") & ","
                linetext &= dr("model") & ","

                'ファイルの書き込み
                sr.WriteLine(linetext)

            Loop

            'データリーダーを閉じる
            dr.Close()

            'コネクションを閉じる
            connection.Close()

        End Using

        'ファイルを閉じる
        sr.Close()

        '待機カーソルを戻す
        Me.Cursor = Cursors.Default

        MsgBox("電話番号データを以下のフォルダにエクスポートしました" & vbCrLf & vbCrLf & exfolder)

    End Sub

    '[社員csvエクスポート]ボタン
    Private Sub btnExportStaff_Click(sender As Object, e As EventArgs) Handles btnExportStaff.Click
        Dim sr As IO.StreamWriter

        Dim exfolder As String
        Dim linetext As String

        '待機カーソルの表示
        Me.Cursor = Cursors.WaitCursor

        '保存先フォルダの指定
        exfolder = Application.StartupPath & "\データ出力\"

        'フォルダが存在しない場合には作成する
        If IO.Directory.Exists(exfolder) = False Then
            IO.Directory.CreateDirectory(exfolder)
        End If

        'ファイルを作成する
        sr = New IO.StreamWriter(exfolder & "staff.csv", False, System.Text.Encoding.GetEncoding("Shift_JIS"))

        'コネクションを指定する
        Using connection As New SqlClient.SqlConnection(My.Settings.PhoneNumDBConnectionString)
            'コマンドを定義する
            Dim command As New SqlClient.SqlCommand("select * from tbl_staff", connection)

            'コネクションを開く
            connection.Open()

            'データリーダーからのデータの読出し
            Dim dr As SqlClient.SqlDataReader = command.ExecuteReader()

            'データの分だけ処理を繰り返す
            Do While dr.Read
                '書き込むデータの生成(カンマ区切り)
                linetext = dr("id_staff") & ","
                linetext &= dr("staff_name") & ","
                linetext &= dr("staff_kana") & ","
                linetext &= dr("branch_id") & ","

                'ファイルの書き込み
                sr.WriteLine(linetext)

            Loop

            'データリーダーを閉じる
            dr.Close()

            'コネクションを閉じる
            connection.Close()

        End Using

        'ファイルを閉じる
        sr.Close()

        '待機カーソルを戻す
        Me.Cursor = Cursors.Default

        MsgBox("電話番号データを以下のフォルダにエクスポートしました" & vbCrLf & vbCrLf & exfolder)

    End Sub

    '[車両情報エクスポート]ボタン
    Private Sub btnExportCar_Click(sender As Object, e As EventArgs) Handles btnExportCar.Click
        Dim sr As IO.StreamWriter

        Dim exfolder As String
        Dim linetext As String

        '待機カーソルの表示
        Me.Cursor = Cursors.WaitCursor

        '保存先フォルダの指定
        exfolder = Application.StartupPath & "\データ出力\"

        'フォルダが存在しない場合には作成する
        If IO.Directory.Exists(exfolder) = False Then
            IO.Directory.CreateDirectory(exfolder)
        End If

        'ファイルを作成する
        sr = New IO.StreamWriter(exfolder & "car.csv", False, System.Text.Encoding.GetEncoding("Shift_JIS"))

        'コネクションを指定する
        Using connection As New SqlClient.SqlConnection(My.Settings.PhoneNumDBConnectionString)
            'コマンドを定義する
            Dim command As New SqlClient.SqlCommand("select * from tbl_car", connection)

            'コネクションを開く
            connection.Open()

            'データリーダーからのデータの読出し
            Dim dr As SqlClient.SqlDataReader = command.ExecuteReader()

            'データの分だけ処理を繰り返す
            Do While dr.Read
                '書き込むデータの生成(カンマ区切り)
                linetext = dr("carnum1") & ","
                linetext &= dr("carnum2") & ","
                linetext &= dr("carnum3") & ","
                linetext &= dr("carnum4") & ","
                linetext &= dr("musen") & ","
                linetext &= dr("ton") & ","
                linetext &= dr("biko") & ","
                linetext &= dr("branch_id") & ","


                'ファイルの書き込み
                sr.WriteLine(linetext)

            Loop

            'データリーダーを閉じる
            dr.Close()

            'コネクションを閉じる
            connection.Close()

        End Using

        'ファイルを閉じる
        sr.Close()

        '待機カーソルを戻す
        Me.Cursor = Cursors.Default

        MsgBox("車両データを以下のフォルダにエクスポートしました" & vbCrLf & vbCrLf & exfolder)
    End Sub
End Class