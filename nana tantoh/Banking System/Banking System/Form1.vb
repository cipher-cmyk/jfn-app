Imports Banking_System

Public Class Form1
    Private accounts As New Dictionary(Of String, BankAccount)
    Private account As BankAccount

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Dim accountNumber As String = txtAccountNumber.Text
        Dim accountHolder As String = txtAccountHolder.Text

        If String.IsNullOrWhiteSpace(accountNumber) Or String.IsNullOrWhiteSpace(accountHolder) Then
            MessageBox.Show("Account Number and Account Holder are required.")
            Return
        End If

        If accounts.ContainsKey(accountNumber) Then
            MessageBox.Show("Account already exists.")
            Return
        End If

        Dim account As New BankAccount(accountNumber, accountHolder)
        accounts.Add(accountNumber, account)
        MessageBox.Show("Account created successfully.")
        txtBalance.Text = account.Balance.ToString("C")
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Dim accountNumber As String = txtAccountNumber.Text
        Dim amount As Decimal

        If Not accounts.TryGetValue(accountNumber, account) Then
            MessageBox.Show("Account not found.")
            Return
        End If

        If Decimal.TryParse(txtDeposit.Text, amount) Then
            Dim message As String = account.Deposit(amount)
            lstTransactions.Items.Add(message)
            txtBalance.Text = account.Balance.ToString("C")
        Else
            MessageBox.Show("Invalid deposit amount.")
        End If
    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWIthdraw.Click
        Dim accountNumber As String = txtAccountNumber.Text
        Dim amount As Decimal

        If Not accounts.TryGetValue(accountNumber, account) Then
            MessageBox.Show("Account not found.")
            Return
        End If

        If Decimal.TryParse(txtWithdraw.Text, amount) Then
            Dim message As String = account.Withdraw(amount)
            lstTransactions.Items.Add(message)
            txtBalance.Text = account.Balance.ToString("C")
        Else
            MessageBox.Show("Invalid withdrawal amount.")
        End If
    End Sub

    Private Sub btnCheckBalance_Click(sender As Object, e As EventArgs) Handles btnCheckBalance.Click
        Dim accountNumber As String = txtAccountNumber.Text

        If accounts.TryGetValue(accountNumber, account) Then
            txtBalance.Text = account.Balance.ToString("C")
        Else
            MessageBox.Show("Account not found.")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class