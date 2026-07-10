<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoanApplicationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCust = New System.Windows.Forms.Label()
        Me.lblCustomeName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblOccupation = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblSal = New System.Windows.Forms.Label()
        Me.lblCmp = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtContactInfo = New System.Windows.Forms.TextBox()
        Me.txtOccupation = New System.Windows.Forms.TextBox()
        Me.TxtCompanyName = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.lblLoan = New System.Windows.Forms.Label()
        Me.lblLType = New System.Windows.Forms.Label()
        Me.cboLType = New System.Windows.Forms.ComboBox()
        Me.lblLAmount = New System.Windows.Forms.Label()
        Me.txtLoanAmount = New System.Windows.Forms.TextBox()
        Me.lblLTerm = New System.Windows.Forms.Label()
        Me.cboLTerm = New System.Windows.Forms.ComboBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.pnlBackground = New System.Windows.Forms.Panel()
        Me.pnlBackground.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(201, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(230, 33)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Loan Application"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCust
        '
        Me.lblCust.AutoSize = True
        Me.lblCust.BackColor = System.Drawing.Color.Transparent
        Me.lblCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCust.ForeColor = System.Drawing.Color.Black
        Me.lblCust.Location = New System.Drawing.Point(62, 78)
        Me.lblCust.Name = "lblCust"
        Me.lblCust.Size = New System.Drawing.Size(188, 24)
        Me.lblCust.TabIndex = 2
        Me.lblCust.Text = "Customer Information"
        '
        'lblCustomeName
        '
        Me.lblCustomeName.AutoSize = True
        Me.lblCustomeName.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomeName.ForeColor = System.Drawing.Color.Black
        Me.lblCustomeName.Location = New System.Drawing.Point(63, 132)
        Me.lblCustomeName.Name = "lblCustomeName"
        Me.lblCustomeName.Size = New System.Drawing.Size(152, 24)
        Me.lblCustomeName.TabIndex = 3
        Me.lblCustomeName.Text = "Customer Name:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Black
        Me.lblAddress.Location = New System.Drawing.Point(63, 184)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(85, 24)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "Address:"
        '
        'lblOccupation
        '
        Me.lblOccupation.AutoSize = True
        Me.lblOccupation.BackColor = System.Drawing.Color.Transparent
        Me.lblOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOccupation.ForeColor = System.Drawing.Color.Black
        Me.lblOccupation.Location = New System.Drawing.Point(63, 288)
        Me.lblOccupation.Name = "lblOccupation"
        Me.lblOccupation.Size = New System.Drawing.Size(112, 24)
        Me.lblOccupation.TabIndex = 6
        Me.lblOccupation.Text = "Occupation:"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.BackColor = System.Drawing.Color.Transparent
        Me.lblContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.Color.Black
        Me.lblContact.Location = New System.Drawing.Point(63, 236)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(152, 24)
        Me.lblContact.TabIndex = 5
        Me.lblContact.Text = "Contact Number:"
        '
        'lblSal
        '
        Me.lblSal.AutoSize = True
        Me.lblSal.BackColor = System.Drawing.Color.Transparent
        Me.lblSal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSal.ForeColor = System.Drawing.Color.Black
        Me.lblSal.Location = New System.Drawing.Point(66, 392)
        Me.lblSal.Name = "lblSal"
        Me.lblSal.Size = New System.Drawing.Size(137, 24)
        Me.lblSal.TabIndex = 8
        Me.lblSal.Text = "Monthly Salary:"
        '
        'lblCmp
        '
        Me.lblCmp.AutoSize = True
        Me.lblCmp.BackColor = System.Drawing.Color.Transparent
        Me.lblCmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCmp.ForeColor = System.Drawing.Color.Black
        Me.lblCmp.Location = New System.Drawing.Point(66, 340)
        Me.lblCmp.Name = "lblCmp"
        Me.lblCmp.Size = New System.Drawing.Size(152, 24)
        Me.lblCmp.TabIndex = 7
        Me.lblCmp.Text = "Company Name:"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(67, 155)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(131, 26)
        Me.txtCustomerName.TabIndex = 9
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(67, 207)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(131, 26)
        Me.txtAddress.TabIndex = 10
        '
        'txtContactInfo
        '
        Me.txtContactInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactInfo.Location = New System.Drawing.Point(67, 259)
        Me.txtContactInfo.Name = "txtContactInfo"
        Me.txtContactInfo.Size = New System.Drawing.Size(131, 26)
        Me.txtContactInfo.TabIndex = 11
        '
        'txtOccupation
        '
        Me.txtOccupation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOccupation.Location = New System.Drawing.Point(67, 311)
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.Size = New System.Drawing.Size(131, 26)
        Me.txtOccupation.TabIndex = 12
        '
        'TxtCompanyName
        '
        Me.TxtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCompanyName.Location = New System.Drawing.Point(67, 363)
        Me.TxtCompanyName.Name = "TxtCompanyName"
        Me.TxtCompanyName.Size = New System.Drawing.Size(131, 26)
        Me.TxtCompanyName.TabIndex = 13
        '
        'txtSalary
        '
        Me.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(67, 415)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(131, 26)
        Me.txtSalary.TabIndex = 14
        '
        'lblLoan
        '
        Me.lblLoan.AutoSize = True
        Me.lblLoan.BackColor = System.Drawing.Color.Transparent
        Me.lblLoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoan.ForeColor = System.Drawing.Color.Black
        Me.lblLoan.Location = New System.Drawing.Point(380, 78)
        Me.lblLoan.Name = "lblLoan"
        Me.lblLoan.Size = New System.Drawing.Size(112, 24)
        Me.lblLoan.TabIndex = 15
        Me.lblLoan.Text = "Loan Details"
        '
        'lblLType
        '
        Me.lblLType.AutoSize = True
        Me.lblLType.BackColor = System.Drawing.Color.Transparent
        Me.lblLType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLType.ForeColor = System.Drawing.Color.Black
        Me.lblLType.Location = New System.Drawing.Point(381, 132)
        Me.lblLType.Name = "lblLType"
        Me.lblLType.Size = New System.Drawing.Size(105, 24)
        Me.lblLType.TabIndex = 16
        Me.lblLType.Text = "Loan Type:"
        '
        'cboLType
        '
        Me.cboLType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLType.FormattingEnabled = True
        Me.cboLType.Items.AddRange(New Object() {"Personal Loan", "Appliance Loan", "Gadget Loan", "Student Loan"})
        Me.cboLType.Location = New System.Drawing.Point(385, 155)
        Me.cboLType.Name = "cboLType"
        Me.cboLType.Size = New System.Drawing.Size(172, 28)
        Me.cboLType.TabIndex = 17
        '
        'lblLAmount
        '
        Me.lblLAmount.AutoSize = True
        Me.lblLAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblLAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLAmount.ForeColor = System.Drawing.Color.Black
        Me.lblLAmount.Location = New System.Drawing.Point(381, 207)
        Me.lblLAmount.Name = "lblLAmount"
        Me.lblLAmount.Size = New System.Drawing.Size(128, 24)
        Me.lblLAmount.TabIndex = 18
        Me.lblLAmount.Text = "Loan Amount:"
        '
        'txtLoanAmount
        '
        Me.txtLoanAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoanAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanAmount.Location = New System.Drawing.Point(385, 230)
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.Size = New System.Drawing.Size(172, 26)
        Me.txtLoanAmount.TabIndex = 19
        '
        'lblLTerm
        '
        Me.lblLTerm.AutoSize = True
        Me.lblLTerm.BackColor = System.Drawing.Color.Transparent
        Me.lblLTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLTerm.ForeColor = System.Drawing.Color.Black
        Me.lblLTerm.Location = New System.Drawing.Point(381, 288)
        Me.lblLTerm.Name = "lblLTerm"
        Me.lblLTerm.Size = New System.Drawing.Size(107, 24)
        Me.lblLTerm.TabIndex = 20
        Me.lblLTerm.Text = "Loan Term:"
        '
        'cboLTerm
        '
        Me.cboLTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLTerm.FormattingEnabled = True
        Me.cboLTerm.Items.AddRange(New Object() {"12 Months", "24 Months", "36 Months"})
        Me.cboLTerm.Location = New System.Drawing.Point(385, 309)
        Me.cboLTerm.Name = "cboLTerm"
        Me.cboLTerm.Size = New System.Drawing.Size(172, 28)
        Me.cboLTerm.TabIndex = 21
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 553)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(91, 36)
        Me.btnBack.TabIndex = 22
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(340, 392)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 36)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCompute
        '
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(466, 392)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(91, 36)
        Me.btnCompute.TabIndex = 24
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'pnlBackground
        '
        Me.pnlBackground.BackColor = System.Drawing.Color.Lavender
        Me.pnlBackground.Controls.Add(Me.btnCompute)
        Me.pnlBackground.Controls.Add(Me.btnClear)
        Me.pnlBackground.Controls.Add(Me.cboLTerm)
        Me.pnlBackground.Controls.Add(Me.lblLTerm)
        Me.pnlBackground.Controls.Add(Me.txtLoanAmount)
        Me.pnlBackground.Controls.Add(Me.lblLAmount)
        Me.pnlBackground.Controls.Add(Me.cboLType)
        Me.pnlBackground.Controls.Add(Me.lblLType)
        Me.pnlBackground.Controls.Add(Me.lblLoan)
        Me.pnlBackground.Controls.Add(Me.txtSalary)
        Me.pnlBackground.Controls.Add(Me.TxtCompanyName)
        Me.pnlBackground.Controls.Add(Me.txtOccupation)
        Me.pnlBackground.Controls.Add(Me.txtContactInfo)
        Me.pnlBackground.Controls.Add(Me.txtAddress)
        Me.pnlBackground.Controls.Add(Me.txtCustomerName)
        Me.pnlBackground.Controls.Add(Me.lblSal)
        Me.pnlBackground.Controls.Add(Me.lblCmp)
        Me.pnlBackground.Controls.Add(Me.lblOccupation)
        Me.pnlBackground.Controls.Add(Me.lblContact)
        Me.pnlBackground.Controls.Add(Me.lblAddress)
        Me.pnlBackground.Controls.Add(Me.lblCustomeName)
        Me.pnlBackground.Controls.Add(Me.lblCust)
        Me.pnlBackground.Controls.Add(Me.lblTitle)
        Me.pnlBackground.Location = New System.Drawing.Point(87, 28)
        Me.pnlBackground.Name = "pnlBackground"
        Me.pnlBackground.Size = New System.Drawing.Size(725, 506)
        Me.pnlBackground.TabIndex = 25
        '
        'LoanApplicationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Loan_Calculator_Program.My.Resources.Resources.AbstractBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 601)
        Me.Controls.Add(Me.pnlBackground)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "LoanApplicationForm"
        Me.Text = "ApplyForm"
        Me.pnlBackground.ResumeLayout(False)
        Me.pnlBackground.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCust As Label
    Friend WithEvents lblCustomeName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblOccupation As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblSal As Label
    Friend WithEvents lblCmp As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtContactInfo As TextBox
    Friend WithEvents txtOccupation As TextBox
    Friend WithEvents TxtCompanyName As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents lblLoan As Label
    Friend WithEvents lblLType As Label
    Friend WithEvents cboLType As ComboBox
    Friend WithEvents lblLAmount As Label
    Friend WithEvents txtLoanAmount As TextBox
    Friend WithEvents lblLTerm As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCompute As Button
    Friend WithEvents cboLTerm As ComboBox
    Friend WithEvents pnlBackground As Panel
End Class
