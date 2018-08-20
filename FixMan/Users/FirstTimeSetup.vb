Imports System.Xml

Public Class frmSetup
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
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

        Try
            Dim newfile As New XmlTextWriter("users.xml", System.Text.Encoding.UTF8)
            newfile.WriteStartDocument()
            newfile.WriteStartElement("Creds")
            newfile.Close()

            Dim userfile = XDocument.Load("users.xml")
            Dim newUser = New XElement("User",
                                       New XElement("ID", txtUsername.Text),
                                       New XElement("LongName", txtFullName.Text),
                                       New XElement("Pass", getSHA1Hash(txtPassword.Text)),
                                       New XElement("InventoryRights", "2"),
                                       New XElement("EventRights", "2"),
                                       New XElement("UserEdit", "True"))
            userfile.Element("Creds").Add(newUser)

            userfile.Save("users.xml")

            frmUsers.userload()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
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

    Private Sub frmSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        frmLogin.Hide()
    End Sub
End Class