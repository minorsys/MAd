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
End Class