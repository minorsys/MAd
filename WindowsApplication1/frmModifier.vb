Public Class frmModifier

    Private frm_Grd As frmGrd

    Public Sub SetSelectedRecord(ByVal pcode As String, ByVal f As frmGrd)
        '呼び出し元フォームを格納する
        frm_Grd = f

        '電話番号マスタのデータをデータソースにセット
        Me.Tbl_PhoneNumTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_PhoneNum)

        '受け取ったコードを利用して、該当する電話番号データをデータソースにセット
        Me.Tbl_PhoneNumTableAdapter.FillByPcode(Me.PhoneNumDBDataSet.tbl_PhoneNum, pcode)


    End Sub

    Private Sub Tbl_PhoneNumBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_PhoneNumBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PhoneNumDBDataSet)

    End Sub

    Private Sub frmModifier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_Integrate' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_IntegrateTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_Integrate)
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_car' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        'Me.Tbl_carTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_car)
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_staff' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        'Me.Tbl_staffTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_staff)
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_PhoneNum' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        'Me.Tbl_PhoneNumTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_PhoneNum)

    End Sub
End Class