Public Class MainMenuForm

    Private Sub MainMenuForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlAbout.Visible = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Do you wanna exit the application?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Would you like to logout?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Me.Hide()
        ApplyForm.Show()
    End Sub

    Private Sub btnComp_Click(sender As Object, e As EventArgs) Handles btnComp.Click
        Me.Hide()
        LoanComputationForm.Show()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        pnlAbout.Visible = Not pnlAbout.Visible
    End Sub

End Class