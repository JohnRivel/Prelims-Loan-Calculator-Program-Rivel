Public Class MainMenuForm
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        LoginForm.Show()

    End Sub
End Class