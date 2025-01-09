<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AccountNumber = New System.Windows.Forms.Label()
        Me.AccountHolder = New System.Windows.Forms.Label()
        Me.Balance = New System.Windows.Forms.Label()
        Me.DepositedAmount = New System.Windows.Forms.Label()
        Me.WithdrawedAmount = New System.Windows.Forms.Label()
        Me.txtAccountNumber = New System.Windows.Forms.TextBox()
        Me.txtAccountHolder = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.txtWithdraw = New System.Windows.Forms.TextBox()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.btnWIthdraw = New System.Windows.Forms.Button()
        Me.btnCheckBalance = New System.Windows.Forms.Button()
        Me.lstTransactions = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'AccountNumber
        '
        Me.AccountNumber.AutoSize = True
        Me.AccountNumber.Location = New System.Drawing.Point(12, 9)
        Me.AccountNumber.Name = "AccountNumber"
        Me.AccountNumber.Size = New System.Drawing.Size(87, 13)
        Me.AccountNumber.TabIndex = 0
        Me.AccountNumber.Text = "Account Number"
        '
        'AccountHolder
        '
        Me.AccountHolder.AutoSize = True
        Me.AccountHolder.Location = New System.Drawing.Point(12, 41)
        Me.AccountHolder.Name = "AccountHolder"
        Me.AccountHolder.Size = New System.Drawing.Size(81, 13)
        Me.AccountHolder.TabIndex = 1
        Me.AccountHolder.Text = "Account Holder"
        '
        'Balance
        '
        Me.Balance.AutoSize = True
        Me.Balance.Location = New System.Drawing.Point(12, 72)
        Me.Balance.Name = "Balance"
        Me.Balance.Size = New System.Drawing.Size(46, 13)
        Me.Balance.TabIndex = 2
        Me.Balance.Text = "Balance"
        '
        'DepositedAmount
        '
        Me.DepositedAmount.AutoSize = True
        Me.DepositedAmount.Location = New System.Drawing.Point(12, 104)
        Me.DepositedAmount.Name = "DepositedAmount"
        Me.DepositedAmount.Size = New System.Drawing.Size(82, 13)
        Me.DepositedAmount.TabIndex = 3
        Me.DepositedAmount.Text = "Deposit Amount"
        '
        'WithdrawedAmount
        '
        Me.WithdrawedAmount.AutoSize = True
        Me.WithdrawedAmount.Location = New System.Drawing.Point(12, 137)
        Me.WithdrawedAmount.Name = "WithdrawedAmount"
        Me.WithdrawedAmount.Size = New System.Drawing.Size(91, 13)
        Me.WithdrawedAmount.TabIndex = 4
        Me.WithdrawedAmount.Text = "Withdraw Amount"
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.Location = New System.Drawing.Point(105, 9)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Size = New System.Drawing.Size(467, 20)
        Me.txtAccountNumber.TabIndex = 5
        '
        'txtAccountHolder
        '
        Me.txtAccountHolder.Location = New System.Drawing.Point(105, 41)
        Me.txtAccountHolder.Name = "txtAccountHolder"
        Me.txtAccountHolder.Size = New System.Drawing.Size(467, 20)
        Me.txtAccountHolder.TabIndex = 6
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(64, 72)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(508, 20)
        Me.txtBalance.TabIndex = 7
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(112, 101)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(460, 20)
        Me.txtDeposit.TabIndex = 8
        '
        'txtWithdraw
        '
        Me.txtWithdraw.Location = New System.Drawing.Point(121, 134)
        Me.txtWithdraw.Name = "txtWithdraw"
        Me.txtWithdraw.Size = New System.Drawing.Size(451, 20)
        Me.txtWithdraw.TabIndex = 9
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Location = New System.Drawing.Point(121, 188)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(75, 43)
        Me.btnCreateAccount.TabIndex = 10
        Me.btnCreateAccount.Text = "Create Account"
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'btnDeposit
        '
        Me.btnDeposit.Location = New System.Drawing.Point(248, 188)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(75, 43)
        Me.btnDeposit.TabIndex = 11
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'btnWIthdraw
        '
        Me.btnWIthdraw.Location = New System.Drawing.Point(374, 188)
        Me.btnWIthdraw.Name = "btnWIthdraw"
        Me.btnWIthdraw.Size = New System.Drawing.Size(75, 43)
        Me.btnWIthdraw.TabIndex = 12
        Me.btnWIthdraw.Text = "Withdraw"
        Me.btnWIthdraw.UseVisualStyleBackColor = True
        '
        'btnCheckBalance
        '
        Me.btnCheckBalance.Location = New System.Drawing.Point(497, 188)
        Me.btnCheckBalance.Name = "btnCheckBalance"
        Me.btnCheckBalance.Size = New System.Drawing.Size(75, 43)
        Me.btnCheckBalance.TabIndex = 13
        Me.btnCheckBalance.Text = "Check Balance"
        Me.btnCheckBalance.UseVisualStyleBackColor = True
        '
        'lstTransactions
        '
        Me.lstTransactions.FormattingEnabled = True
        Me.lstTransactions.Location = New System.Drawing.Point(12, 264)
        Me.lstTransactions.Name = "lstTransactions"
        Me.lstTransactions.Size = New System.Drawing.Size(560, 95)
        Me.lstTransactions.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 371)
        Me.Controls.Add(Me.lstTransactions)
        Me.Controls.Add(Me.btnCheckBalance)
        Me.Controls.Add(Me.btnWIthdraw)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.txtWithdraw)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtAccountHolder)
        Me.Controls.Add(Me.txtAccountNumber)
        Me.Controls.Add(Me.WithdrawedAmount)
        Me.Controls.Add(Me.DepositedAmount)
        Me.Controls.Add(Me.Balance)
        Me.Controls.Add(Me.AccountHolder)
        Me.Controls.Add(Me.AccountNumber)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AccountNumber As Label
    Friend WithEvents AccountHolder As Label
    Friend WithEvents Balance As Label
    Friend WithEvents DepositedAmount As Label
    Friend WithEvents WithdrawedAmount As Label
    Friend WithEvents txtAccountNumber As TextBox
    Friend WithEvents txtAccountHolder As TextBox
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents txtWithdraw As TextBox
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnWIthdraw As Button
    Friend WithEvents btnCheckBalance As Button
    Friend WithEvents lstTransactions As ListBox
End Class
