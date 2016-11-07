Public Class frmGrd
    Private Sub frmGrd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.dtInteg' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.DtIntegTableAdapter.FillIntegTable(Me.PhoneNumDBDataSet.dtInteg)

    End Sub

    Private Sub txtFilterKana_TextChanged(sender As Object, e As EventArgs) Handles txtFilterKana.TextChanged

    End Sub
End Class