Public Class Contact
    Public Property Name As String
    Public Property Phone As String
    Public Property Email As String

    Public Sub New(name As String, phone As String, email As String)
        Me.Name = name
        Me.Phone = phone
        Me.Email = email
    End Sub

    Public Overrides Function ToString() As String
        Return $"{Name}, {Phone}, {Email}"
    End Function

End Class
