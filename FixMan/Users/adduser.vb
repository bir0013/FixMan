Imports System.Xml

Public Class frmAddUser
    Private Sub chkShowConfirm_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowConfirm.CheckedChanged
        'This code allows the password confirm field to switch between showing password text and showing the system password character when the showpass checkbox is checked/unchecked
        If chkShowConfirm.Checked = True Then
            txtConfirmPassword.UseSystemPasswordChar = False
        ElseIf chkShowConfirm.Checked = False Then
            txtConfirmPassword.UseSystemPasswordChar = True
        Else
            Me.Close()
            MsgBox("An error has occured. This may be a password security related issue. If this happens again please contact bir0013@mckinnonsc.vic.edu.au")
        End If
    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        'This code allows the password field to switch between showing password text and showing the system password character when the showpass checkbox is checked/unchecked
        If chkShowPass.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        ElseIf chkShowPass.Checked = False Then
            txtPassword.UseSystemPasswordChar = True
        Else
            Me.Close()
            MsgBox("An error has occured. This may be a password security related issue. If this happens again please contact bir0013@mckinnonsc.vic.edu.au")
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'This appends users.xml with the new user account and its information
        Dim inventoryrights, eventrights As Integer
        Dim useredit As Boolean

        If txtUsername.Text = String.Empty Then
            MsgBox("Please enter a username")
            Exit Sub
        End If

        If Not txtPassword.Text = txtConfirmPassword.Text Then
            MsgBox("Your passwords do not match.")
            Exit Sub
        End If

        For Each item In frmUsers.lstUsers.Items
            If item.ToString = txtUsername.Text Then
                MsgBox("This username is taken.")
                Exit Sub
            End If
        Next

        Select Case True
            Case rdbInventoryEdit.Checked
                inventoryrights = 2
            Case rdbInventoryView.Checked
                inventoryrights = 1
            Case rdbInventoryBlock.Checked
                inventoryrights = 0
            Case Not rdbInventoryEdit.Checked And Not rdbInventoryView.Checked And Not rdbInventoryBlock.Checked
                MsgBox("Please select inventory priveliges.")
                Exit Sub
        End Select

        'This is code for future functionality
        eventrights = 2
        'Select Case True
        '    Case rdbEventEdit.Checked
        '        eventrights = 2
        '    Case rdbEventView.Checked
        '        eventrights = 1
        '    Case rdbEventBlock.Checked
        '        eventrights = 0
        '    Case Not rdbEventEdit.Checked And Not rdbEventView.Checked And Not rdbEventBlock.Checked
        '        MsgBox("Please select event priveliges.")
        '        Exit Sub
        'End Select

        useredit = chkUserEdit.Checked

        Try
            Dim userfile = XDocument.Load("users.xml")
            Dim newUser = New XElement("User",
                                       New XElement("ID", txtUsername.Text),
                                       New XElement("LongName", txtFullName.Text),
                                       New XElement("Pass", getSHA1Hash(txtPassword.Text)),
                                       New XElement("InventoryRights", inventoryrights),
                                       New XElement("EventRights", eventrights),
                                       New XElement("UserEdit", useredit.ToString))
            userfile.Element("Creds").Add(newUser)

            userfile.Save("users.xml")

            frmUsers.userload()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Function getSHA1Hash(ByVal strToHash As String) As String
        'This function takes a string input and returns a SHA1 encrypted version
        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = sha1Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult

    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class