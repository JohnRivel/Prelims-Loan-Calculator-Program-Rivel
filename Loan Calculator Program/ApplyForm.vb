Public Class ApplyForm

    Public Sub Clear()
        txtCustomerName.Clear()
        txtAddress.Clear()
        txtContactInfo.Clear()
        txtSalary.Clear()
        txtOccupation.Clear()
        TxtCompanyName.Clear()
        txtLoanAmount.Clear()
        cboLTerm.SelectedIndex = -1
        cboLType.SelectedIndex = -1
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.Clear()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MessageBox.Show("Going back will clear all and any information", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Clear()
            MainMenuForm.Refresh()
            MainMenuForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click

        Dim interest As Double
        Dim total As Double
        Dim monthly As Double
        Dim maxPayment As Double
        Dim status As String
        Dim remarks As String

        If txtCustomerName.Text = "" Or txtAddress.Text = "" Or txtContactInfo.Text = "" Or txtOccupation.Text = "" Or TxtCompanyName.Text = "" Or txtSalary.Text = "" Or txtLoanAmount.Text = "" Or cboLType.Text = "" Or cboLTerm.Text = "" Then

            MessageBox.Show("Please complete all the required information", "Missing Information")
            Exit Sub

        End If

        If txtContactInfo.Text.Length <> 11 Then
            MessageBox.Show("Invalid contact number, it must contain 11 digits")
            Exit Sub
        End If

        If Val(txtSalary.Text) <= 0 Then
            MessageBox.Show("Please enter a valid monthly salary")
            txtSalary.Focus()
            Exit Sub
        End If

        If Val(txtLoanAmount.Text) <= 0 Then
            MessageBox.Show("Please enter a valid loan amount")
            txtLoanAmount.Focus()
            Exit Sub
        End If

        If cboLType.Text = "Personal Loan" Then
            interest = Val(txtLoanAmount.Text) * 0.1

        ElseIf cboLType.Text = "Appliance Loan" Then
            interest = Val(txtLoanAmount.Text) * 0.08

        ElseIf cboLType.Text = "Gadget Loan" Then
            interest = Val(txtLoanAmount.Text) * 0.12

        ElseIf cboLType.Text = "Student Loan" Then
            interest = Val(txtLoanAmount.Text) * 0.05

        End If

        total = Val(txtLoanAmount.Text) + interest
        monthly = total / Val(cboLTerm.Text)
        maxPayment = Val(txtSalary.Text) * 0.35

        If monthly <= maxPayment Then

            If Val(txtSalary.Text) >= 20000 Then
                status = "APPROVED"
                remarks = "Congratulations! Your loan has been approved"
            Else
                status = "DISAPPROVED"
                remarks = "Sorry, Salary must meet the minimum ₱20,000 requirement"
            End If

        Else
            status = "DISAPPROVED"
            remarks = "Monthly payment exceeds 35% of your salary"
        End If

        LoanComputationForm.lblCustomerName.Text = txtCustomerName.Text
        LoanComputationForm.lblAddress.Text = txtAddress.Text
        LoanComputationForm.lblContactNumber.Text = txtContactInfo.Text
        LoanComputationForm.lblOccupation.Text = txtOccupation.Text
        LoanComputationForm.lblCompanyName.Text = TxtCompanyName.Text
        LoanComputationForm.lblMonthlySalary.Text = "₱" & Val(txtSalary.Text).ToString("N0")
        LoanComputationForm.lblLoanType.Text = cboLType.Text
        LoanComputationForm.lblLoanAmount.Text = "₱" & Val(txtLoanAmount.Text).ToString("N0")
        LoanComputationForm.lblLoanTerm.Text = cboLTerm.Text
        LoanComputationForm.lblInterestRate.Text = "₱" & interest.ToString("N0")
        LoanComputationForm.lblTotalPayment.Text = "₱" & total.ToString("N0")
        LoanComputationForm.lblMonthlyAmortization.Text = "₱" & monthly.ToString("N0")
        LoanComputationForm.lblLoanStatus.Text = status
        LoanComputationForm.lblRemarks.Text = remarks

        LoanComputationForm.Show()
        Me.Hide()
    End Sub

End Class