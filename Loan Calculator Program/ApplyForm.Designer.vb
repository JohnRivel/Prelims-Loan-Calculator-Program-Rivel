<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ApplyForm
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
        Me.lvlTitle = New System.Windows.Forms.Label()
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
        Me.SuspendLayout()
        '
        'lvlTitle
        '
        Me.lvlTitle.AutoSize = True
        Me.lvlTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlTitle.Location = New System.Drawing.Point(319, 29)
        Me.lvlTitle.Name = "lvlTitle"
        Me.lvlTitle.Size = New System.Drawing.Size(247, 31)
        Me.lvlTitle.TabIndex = 1
        Me.lvlTitle.Text = "APPLY FOR LOAN"
        Me.lvlTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCust
        '
        Me.lblCust.AutoSize = True
        Me.lblCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCust.Location = New System.Drawing.Point(151, 112)
        Me.lblCust.Name = "lblCust"
        Me.lblCust.Size = New System.Drawing.Size(216, 25)
        Me.lblCust.TabIndex = 2
        Me.lblCust.Text = "Customer Information"
        '
        'lblCustomeName
        '
        Me.lblCustomeName.AutoSize = True
        Me.lblCustomeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomeName.Location = New System.Drawing.Point(152, 166)
        Me.lblCustomeName.Name = "lblCustomeName"
        Me.lblCustomeName.Size = New System.Drawing.Size(128, 20)
        Me.lblCustomeName.TabIndex = 3
        Me.lblCustomeName.Text = "Customer Name:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(152, 218)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(72, 20)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "Address:"
        '
        'lblOccupation
        '
        Me.lblOccupation.AutoSize = True
        Me.lblOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOccupation.Location = New System.Drawing.Point(152, 322)
        Me.lblOccupation.Name = "lblOccupation"
        Me.lblOccupation.Size = New System.Drawing.Size(94, 20)
        Me.lblOccupation.TabIndex = 6
        Me.lblOccupation.Text = "Occupation:"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(152, 270)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(129, 20)
        Me.lblContact.TabIndex = 5
        Me.lblContact.Text = "Contact Number:"
        '
        'lblSal
        '
        Me.lblSal.AutoSize = True
        Me.lblSal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSal.Location = New System.Drawing.Point(155, 426)
        Me.lblSal.Name = "lblSal"
        Me.lblSal.Size = New System.Drawing.Size(116, 20)
        Me.lblSal.TabIndex = 8
        Me.lblSal.Text = "Monthly Salary:"
        '
        'lblCmp
        '
        Me.lblCmp.AutoSize = True
        Me.lblCmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCmp.Location = New System.Drawing.Point(155, 374)
        Me.lblCmp.Name = "lblCmp"
        Me.lblCmp.Size = New System.Drawing.Size(126, 20)
        Me.lblCmp.TabIndex = 7
        Me.lblCmp.Text = "Company Name:"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(156, 189)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(131, 26)
        Me.txtCustomerName.TabIndex = 9
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(156, 241)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(131, 26)
        Me.txtAddress.TabIndex = 10
        '
        'txtContactInfo
        '
        Me.txtContactInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactInfo.Location = New System.Drawing.Point(156, 293)
        Me.txtContactInfo.Name = "txtContactInfo"
        Me.txtContactInfo.Size = New System.Drawing.Size(131, 26)
        Me.txtContactInfo.TabIndex = 11
        '
        'txtOccupation
        '
        Me.txtOccupation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOccupation.Location = New System.Drawing.Point(156, 345)
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.Size = New System.Drawing.Size(131, 26)
        Me.txtOccupation.TabIndex = 12
        '
        'TxtCompanyName
        '
        Me.TxtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCompanyName.Location = New System.Drawing.Point(156, 397)
        Me.TxtCompanyName.Name = "TxtCompanyName"
        Me.TxtCompanyName.Size = New System.Drawing.Size(131, 26)
        Me.TxtCompanyName.TabIndex = 13
        '
        'txtSalary
        '
        Me.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(156, 449)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(131, 26)
        Me.txtSalary.TabIndex = 14
        '
        'lblLoan
        '
        Me.lblLoan.AutoSize = True
        Me.lblLoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoan.Location = New System.Drawing.Point(469, 112)
        Me.lblLoan.Name = "lblLoan"
        Me.lblLoan.Size = New System.Drawing.Size(132, 25)
        Me.lblLoan.TabIndex = 15
        Me.lblLoan.Text = "Loan Details"
        '
        'lblLType
        '
        Me.lblLType.AutoSize = True
        Me.lblLType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLType.Location = New System.Drawing.Point(470, 166)
        Me.lblLType.Name = "lblLType"
        Me.lblLType.Size = New System.Drawing.Size(87, 20)
        Me.lblLType.TabIndex = 16
        Me.lblLType.Text = "Loan Type:"
        '
        'cboLType
        '
        Me.cboLType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLType.FormattingEnabled = True
        Me.cboLType.Items.AddRange(New Object() {"Personal Loan", "Appliance Loan", "Gadget Loan", "Student Loan"})
        Me.cboLType.Location = New System.Drawing.Point(474, 189)
        Me.cboLType.Name = "cboLType"
        Me.cboLType.Size = New System.Drawing.Size(172, 28)
        Me.cboLType.TabIndex = 17
        '
        'lblLAmount
        '
        Me.lblLAmount.AutoSize = True
        Me.lblLAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLAmount.Location = New System.Drawing.Point(470, 241)
        Me.lblLAmount.Name = "lblLAmount"
        Me.lblLAmount.Size = New System.Drawing.Size(109, 20)
        Me.lblLAmount.TabIndex = 18
        Me.lblLAmount.Text = "Loan Amount:"
        '
        'txtLoanAmount
        '
        Me.txtLoanAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoanAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanAmount.Location = New System.Drawing.Point(474, 264)
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.Size = New System.Drawing.Size(172, 26)
        Me.txtLoanAmount.TabIndex = 19
        '
        'lblLTerm
        '
        Me.lblLTerm.AutoSize = True
        Me.lblLTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLTerm.Location = New System.Drawing.Point(470, 322)
        Me.lblLTerm.Name = "lblLTerm"
        Me.lblLTerm.Size = New System.Drawing.Size(89, 20)
        Me.lblLTerm.TabIndex = 20
        Me.lblLTerm.Text = "Loan Term:"
        '
        'cboLTerm
        '
        Me.cboLTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLTerm.FormattingEnabled = True
        Me.cboLTerm.Items.AddRange(New Object() {"12 Months", "24 Months", "36 Months"})
        Me.cboLTerm.Location = New System.Drawing.Point(474, 343)
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
        Me.btnClear.Location = New System.Drawing.Point(429, 426)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 36)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCompute
        '
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(555, 426)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(91, 36)
        Me.btnCompute.TabIndex = 24
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'ApplyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 601)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.cboLTerm)
        Me.Controls.Add(Me.lblLTerm)
        Me.Controls.Add(Me.txtLoanAmount)
        Me.Controls.Add(Me.lblLAmount)
        Me.Controls.Add(Me.cboLType)
        Me.Controls.Add(Me.lblLType)
        Me.Controls.Add(Me.lblLoan)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.TxtCompanyName)
        Me.Controls.Add(Me.txtOccupation)
        Me.Controls.Add(Me.txtContactInfo)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.lblSal)
        Me.Controls.Add(Me.lblCmp)
        Me.Controls.Add(Me.lblOccupation)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblCustomeName)
        Me.Controls.Add(Me.lblCust)
        Me.Controls.Add(Me.lvlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ApplyForm"
        Me.Text = "ApplyForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvlTitle As Label
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
End Class
