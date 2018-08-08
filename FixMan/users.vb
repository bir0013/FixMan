Imports System.Security
Imports System.Xml


Public Class frmUsers
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmAddUser.Show()
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

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userload()
    End Sub

    Sub userload()
        lstUsers.Items.Clear()
        Dim userfile As New XmlDocument()
        userfile.Load("users.xml")
        Dim usernodes As XmlNodeList = userfile.DocumentElement.SelectNodes("/Creds")
        Dim nodes As XmlNode
        For Each nodes In userfile.SelectNodes("/Creds/User")
            lstUsers.Items.Add(nodes.ChildNodes(1).InnerText)
        Next
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        '#THIS COULD BE IMPROVED AT A LATER DATE##
        Dim response As Integer
        response = MsgBox("Are you sure you want to remove this user?", 36, "Remove User?")
        If response = 6 Then
            End
        End If
    End Sub
End Class