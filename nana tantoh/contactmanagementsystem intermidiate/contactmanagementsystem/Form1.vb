Public Class Form1
    Private contacts As New List(Of Contact)()

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim name As String = txtName.Text.Trim()
        Dim phone As String = txtPhone.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()

        If String.IsNullOrWhiteSpace(name) Or String.IsNullOrWhiteSpace(phone) Or String.IsNullOrWhiteSpace(email) Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim newContact As New Contact(name, phone, email)
        contacts.Add(newContact)
        MessageBox.Show("Contact created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearFields()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim selectedIndex As Integer = lstContacts.SelectedIndex
        If selectedIndex >= 0 Then
            contacts(selectedIndex).Name = txtName.Text.Trim()
            contacts(selectedIndex).Phone = txtPhone.Text.Trim()
            contacts(selectedIndex).Email = txtEmail.Text.Trim()
            MessageBox.Show("Contact edited successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
        Else
            MessageBox.Show("Please select a contact to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim selectedIndex As Integer = lstContacts.SelectedIndex
        If selectedIndex >= 0 Then
            contacts.RemoveAt(selectedIndex)
            MessageBox.Show("Contact deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
        Else
            MessageBox.Show("Please select a contact to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        lstContacts.Items.Clear()
        For Each contact In contacts
            lstContacts.Items.Add(contact)
        Next
    End Sub

    Private Sub ClearFields()
        txtName.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        lstContacts.ClearSelected()

    End Sub
End Class
