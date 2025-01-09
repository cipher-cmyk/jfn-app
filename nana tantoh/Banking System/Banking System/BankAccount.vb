Friend Class BankAccount
    Public Property AccountNumber As String
    Public Property AccountHolder As String
    Public Property Balance As Decimal

    Public Sub New(accountNumber As String, accountHolder As String)
        Me.AccountNumber = accountNumber
        Me.AccountHolder = accountHolder
        Me.Balance = 0.0D
    End Sub

    Public Function Deposit(amount As Decimal) As String
        If amount <= 0 Then
            Return "Deposit amount must be positive."
        End If
        Balance += amount
        Return $"Deposited: {amount:C}. New Balance: {Balance:C}."
    End Function

    Public Function Withdraw(amount As Decimal) As String
        If amount <= 0 Then
            Return "Withdrawal amount must be positive."
        ElseIf amount > Balance Then
            Return "Insufficient funds."
        End If
        Balance -= amount
        Return $"Withdrew: {amount:C}. New Balance: {Balance:C}."
    End Function
End Class
