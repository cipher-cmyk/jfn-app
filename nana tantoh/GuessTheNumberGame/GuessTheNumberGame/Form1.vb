Public Class Form1
    Private numberToGuess As Integer
    Private attempts As Integer
    Private Random As New Random()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartNewGame()
    End Sub

    Private Sub StartNewGame()
        numberToGuess = Random.Next(1, 101) ' Random number between 1 and 100
        attempts = 10
        lblAttempts.Text = "Attempts Left: " & attempts.ToString()
        lblFeedback.Text = ""
        txtGuess.Clear()
        txtGuess.Focus()
        btnRestart.Enabled = False
        btnGuess.Enabled = True
    End Sub

    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        Dim guess As Integer

        If Not Integer.TryParse(txtGuess.Text, guess) OrElse guess < 1 OrElse guess > 100 Then
            MessageBox.Show("Please enter a valid number between 1 and 100.")
            txtGuess.Clear()
            txtGuess.Focus()
            Return
        End If

        attempts -= 1

        If guess < numberToGuess Then
            lblFeedback.Text = "Too low!"
        ElseIf guess > numberToGuess Then
            lblFeedback.Text = "Too high!"
        Else
            lblFeedback.Text = $"Congratulations! You've guessed the number {numberToGuess}!"
            EndGame()
            Return
        End If

        If attempts = 0 Then
            lblFeedback.Text = $"Sorry, you've run out of attempts. The number was {numberToGuess}."
            EndGame()
        Else
            lblAttempts.Text = "Attempts Left: " & attempts.ToString()
        End If

        txtGuess.Clear()
        txtGuess.Focus()
    End Sub

    Private Sub EndGame()
        btnGuess.Enabled = False
        btnRestart.Enabled = True
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        StartNewGame()
    End Sub

    Private Sub lblFeedback_Click(sender As Object, e As EventArgs) Handles lblFeedback.Click

    End Sub
End Class