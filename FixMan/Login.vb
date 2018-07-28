Imports System.Security
Imports System.Xml

'##LOGIN WILL HAVE TO CHECK FOR FIRST RUN AND COMPLETE SETUP IF NECESSARY##

Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim userfile As New XmlDocument()
        userfile.Load("users.xml")
        Dim usernodes As XmlNodeList = userfile.DocumentElement.SelectNodes("/Creds")
        Dim nodes As XmlNode
        For Each nodes In userfile.SelectNodes("/Creds/User")
            If nodes.ChildNodes(0).InnerText = txtUsername.Text Then
                If nodes.ChildNodes(2).InnerText = getSHA1Hash(txtPassword.Text) Then
                    currentuser = nodes.ChildNodes(1).InnerText
                    txtUsername.Focus()
                    txtUsername.Clear()
                    txtPassword.Clear()
                    Me.Hide()
                    frmDatabase.Show()
                    Exit Sub
                Else
                    MsgBox("Your password is incorrect.")
                End If
            Else
                MsgBox("This user does not exist.")
            End If
        Next


        ''##THE FOLLOWING IS TEST CODE! PLEASE DELETE!##
        ''currentuser = "Nicholas Xanthoudakis"
        ''Dim pass As String = txtPassword.Text
        ''Dim hash As String = getSHA1Hash(pass)
        'MessageBox.Show(getSHA1Hash(txtPassword.Text))
        ''Me.Hide()
        ''frmDatabase.Show()

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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Ends the program
        End
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        ElseIf chkShowPass.Checked = False Then
            txtPassword.UseSystemPasswordChar = True
        Else
            Me.Close()
            MsgBox("An error has occured at login. This may be a password security related issue. If this happens again please contact bir0013@mckinnonsc.vic.edu.au")
        End If
    End Sub
End Class