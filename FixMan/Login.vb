Imports System.Security
Imports System.Xml
Imports System.IO

Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'This code opens the users.xml document to check whether the user entered exists and whether the password entered is correct. It also makes sure that you haven't forgotten to enter information.
        Dim userfile As New XmlDocument()
        userfile.Load("users.xml")
        Dim usernodes As XmlNodeList = userfile.DocumentElement.SelectNodes("/Creds")
        Dim nodes As XmlNode

        If Not txtUsername.Text = String.Empty Then
            For Each nodes In userfile.SelectNodes("/Creds/User")
                If nodes.ChildNodes(0).InnerText = txtUsername.Text Then
                    If nodes.ChildNodes(2).InnerText = getSHA1Hash(txtPassword.Text) Then
                        currentuser = nodes.ChildNodes(1).InnerText
                        InventoryPrivelige = nodes.ChildNodes(3).InnerText
                        EventPrivelige = nodes.ChildNodes(4).InnerText
                        UserPrivelige = nodes.ChildNodes(5).InnerText
                        txtUsername.Focus()
                        txtUsername.Clear()
                        txtPassword.Clear()
                        Me.Hide()
                        frmDatabase.Show()
                        Exit Sub
                    Else
                        MsgBox("Your password is incorrect.")
                        Exit Sub
                    End If
                End If
            Next
            MsgBox("This user does not exist.")
        ElseIf txtUsername.Text = String.Empty Then
            MsgBox("You have not entered a username.")
        End If

        For Each nodes In userfile.SelectNodes("Creds/User")

        Next

        '##THIS IS AN OLD VERSION OF THE LOGIN CODE##
        'For Each nodes In userfile.SelectNodes("/Creds/User")
        '    If nodes.ChildNodes(0).InnerText = txtUsername.Text Then
        '        If nodes.ChildNodes(2).InnerText = getSHA1Hash(txtPassword.Text) Then
        '            currentuser = nodes.ChildNodes(1).InnerText
        '            txtUsername.Focus()
        '            txtUsername.Clear()
        '            txtPassword.Clear()
        '            Me.Hide()
        '            frmDatabase.Show()
        '            Exit Sub
        '        Else
        '            MsgBox("Your password is incorrect.")
        '        End If
        '    Else
        '        'MsgBox("This user does not exist.")
        '    End If
        'Next

        ''##THE FOLLOWING IS TEST CODE!##
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
        'Ends the program. Is currently know to throw "Error creating window handle", which is an very nondescript error
        End
    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        'This code allows the password field to switch between showing password text and showing the system password character when the showpass checkbox is checked/unchecked
        If chkShowPass.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        ElseIf chkShowPass.Checked = False Then
            txtPassword.UseSystemPasswordChar = True
        Else
            Me.Close()
            MsgBox("An error has occured at login. This may be a password security related issue. If this happens again please contact bir0013@mckinnonsc.vic.edu.au")
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This Sub checks every time the solution is loaded that it is setup correctly

        'This checks that user records exist
        If File.Exists("users.xml") = False Then
            frmSetup.Show()
        End If

        'This checks that the directory that stores created/imported fixture info files exists (if it does not, it creates it)
        If Not My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Fixtures") Then
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\Fixtures")
        End If
    End Sub
End Class