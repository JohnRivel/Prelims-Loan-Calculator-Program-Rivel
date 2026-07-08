Public Class LoginForm
    Private Sub chkPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkPass.CheckedChanged
        txtPass.UseSystemPasswordChar = Not chkPass.Checked
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsn.Text = "admin" And txtPass.Text = "admin123456" Then
            MessageBox.Show("Login Successful!")
            Me.Hide()
            MainMenuForm.Show()
            txtUsn.Clear()
            txtPass.Clear()


        Else
            MessageBox.Show("Invalid username or password.")
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class