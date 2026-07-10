<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenuForm
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
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnComp = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.pnlBG = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlAbout = New System.Windows.Forms.Panel()
        Me.lblUsermanual = New System.Windows.Forms.LinkLabel()
        Me.lblAboutTitle = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblInfo1 = New System.Windows.Forms.Label()
        Me.lblInfo2 = New System.Windows.Forms.Label()
        Me.pnlBG.SuspendLayout()
        Me.pnlAbout.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnApply
        '
        Me.btnApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.Location = New System.Drawing.Point(29, 163)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(171, 40)
        Me.btnApply.TabIndex = 0
        Me.btnApply.Text = "Apply for Loan"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnComp
        '
        Me.btnComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComp.Location = New System.Drawing.Point(29, 221)
        Me.btnComp.Name = "btnComp"
        Me.btnComp.Size = New System.Drawing.Size(171, 40)
        Me.btnComp.TabIndex = 1
        Me.btnComp.Text = "Loan Computation"
        Me.btnComp.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(29, 282)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(171, 40)
        Me.btnAbout.TabIndex = 2
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'pnlBG
        '
        Me.pnlBG.Controls.Add(Me.Label1)
        Me.pnlBG.Location = New System.Drawing.Point(249, 1)
        Me.pnlBG.Name = "pnlBG"
        Me.pnlBG.Size = New System.Drawing.Size(634, 603)
        Me.pnlBG.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Background preview"
        '
        'pnlAbout
        '
        Me.pnlAbout.BackColor = System.Drawing.Color.Transparent
        Me.pnlAbout.Controls.Add(Me.lblInfo2)
        Me.pnlAbout.Controls.Add(Me.lblUsermanual)
        Me.pnlAbout.Controls.Add(Me.lblAboutTitle)
        Me.pnlAbout.Controls.Add(Me.lblInfo1)
        Me.pnlAbout.Location = New System.Drawing.Point(249, 1)
        Me.pnlAbout.Name = "pnlAbout"
        Me.pnlAbout.Size = New System.Drawing.Size(634, 603)
        Me.pnlAbout.TabIndex = 4
        '
        'lblUsermanual
        '
        Me.lblUsermanual.AutoSize = True
        Me.lblUsermanual.LinkColor = System.Drawing.Color.DimGray
        Me.lblUsermanual.Location = New System.Drawing.Point(506, 550)
        Me.lblUsermanual.Name = "lblUsermanual"
        Me.lblUsermanual.Size = New System.Drawing.Size(67, 13)
        Me.lblUsermanual.TabIndex = 1
        Me.lblUsermanual.TabStop = True
        Me.lblUsermanual.Text = "User Manual"
        '
        'lblAboutTitle
        '
        Me.lblAboutTitle.AutoSize = True
        Me.lblAboutTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutTitle.Location = New System.Drawing.Point(19, 20)
        Me.lblAboutTitle.Name = "lblAboutTitle"
        Me.lblAboutTitle.Size = New System.Drawing.Size(330, 42)
        Me.lblAboutTitle.TabIndex = 0
        Me.lblAboutTitle.Text = "About the Program"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(12, 551)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 38)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(153, 551)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(79, 38)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'lblInfo1
        '
        Me.lblInfo1.AutoSize = True
        Me.lblInfo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo1.Location = New System.Drawing.Point(22, 117)
        Me.lblInfo1.Name = "lblInfo1"
        Me.lblInfo1.Size = New System.Drawing.Size(504, 72)
        Me.lblInfo1.TabIndex = 2
        Me.lblInfo1.Text = "This application helps users to apply different type of loans, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "computes the int" &
    "erest, gives status,  monthly amortization," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and display the total amount" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblInfo2
        '
        Me.lblInfo2.AutoSize = True
        Me.lblInfo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo2.Location = New System.Drawing.Point(22, 231)
        Me.lblInfo2.Name = "lblInfo2"
        Me.lblInfo2.Size = New System.Drawing.Size(156, 100)
        Me.lblInfo2.TabIndex = 3
        Me.lblInfo2.Text = "Created by:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rivel, John Cristian I." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "From:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BSIT31E3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MainMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 601)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnComp)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.pnlBG)
        Me.Controls.Add(Me.pnlAbout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MainMenuForm"
        Me.Text = "MainMenuForm"
        Me.pnlBG.ResumeLayout(False)
        Me.pnlBG.PerformLayout()
        Me.pnlAbout.ResumeLayout(False)
        Me.pnlAbout.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnApply As Button
    Friend WithEvents btnComp As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents pnlBG As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlAbout As Panel
    Friend WithEvents lblAboutTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUsermanual As LinkLabel
    Friend WithEvents lblInfo1 As Label
    Friend WithEvents lblInfo2 As Label
End Class
