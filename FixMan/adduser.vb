Imports System.Xml

Public Class frmAddUser
    Private Sub chkShowConfirm_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowConfirm.CheckedChanged
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
        Dim inventoryrights, eventrights As Integer
        Dim useredit As Boolean

        Select Case True
            Case rdbInventoryEdit.Checked
                inventoryrights = 2
            Case rdbInventoryView.Checked
                inventoryrights = 1
            Case rdbInventoryBlock.Checked
                inventoryrights = 0
        End Select

        Select Case True
            Case rdbEventEdit.Checked
                eventrights = 2
            Case rdbEventView.Checked
                eventrights = 1
            Case rdbEventBlock.Checked
                eventrights = 0
        End Select

        useredit = chkUserEdit.Checked

        '### THIS IS NOT CURRENTLY OPERATIONAL ###
        Dim userfile = XDocument.Load("users.xml")
        Dim newUser = New XElement("User",
                                   New XElement("ID", txtUsername.Text),
                                   New XElement("LongName", txtFullName.Text),
                                   New XElement("Pass", getSHA1Hash(txtPassword.Text)),
                                   New XElement("InventoryRights", inventoryrights),
                                   New XElement("EventRights", eventrights),
                                   New XElement("UserEdit", useredit.ToString))
        userfile.Element("Creds").Add(newUser)

        frmUsers.userload()
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
End Class