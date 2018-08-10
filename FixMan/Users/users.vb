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
        Try
            Dim userfile As New XmlDocument()
            userfile.Load("users.xml")
            Dim usernodes As XmlNodeList = userfile.DocumentElement.SelectNodes("/Creds")
            Dim nodes As XmlNode
            For Each nodes In userfile.SelectNodes("/Creds/User")
                lstUsers.Items.Add(nodes.ChildNodes(1).InnerText)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        '#THIS COULD BE IMPROVED AT A LATER DATE##
        Dim response As Integer
        If Not lstUsers.SelectedItems.Count > 0 Then
            MsgBox("Please select a user.")
            userload()
            Exit Sub
        End If
        response = MsgBox("Are you sure you want to remove this user?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Remove User?")
        If response = MsgBoxResult.Yes Then
            If Not lstUsers.SelectedItem.ToString = currentuser Then
                Dim userfile As New XmlDocument()
                userfile.Load("users.xml")
                Dim node As XmlNode = userfile.SelectSingleNode("Creds/User/LongName[. = '" & lstUsers.SelectedItem.ToString & "']")
                If node IsNot Nothing Then
                    node.ParentNode.ParentNode.RemoveChild(node.ParentNode)
                    userfile.Save("users.xml")
                    'MsgBox(lstUsers.SelectedItem.ToString)
                End If
            ElseIf lstUsers.SelectedItem.ToString = currentuser Then
                response = MsgBox("Are you sure you want to remove your own user? You will no longer have access to your account.", 36, "Remove User?")
                If response = MsgBoxResult.Yes Then
                    Dim userfile As New XmlDocument()
                    userfile.Load("users.xml")
                    Dim x As XmlNode
                    For Each x In userfile.SelectNodes("/Creds/User")
                        If x.ChildNodes(5).InnerText = "True" And Not x.ChildNodes(1).InnerText = lstUsers.SelectedItem.ToString Then
                            Dim node As XmlNode = userfile.SelectSingleNode("Creds/User/LongName[. = '" & lstUsers.SelectedItem.ToString & "']")
                            If node IsNot Nothing Then
                                node.ParentNode.ParentNode.RemoveChild(node.ParentNode)
                                userfile.Save("users.xml")
                                'MsgBox(lstUsers.SelectedItem.ToString)
                                frmDatabase.btnLogout.PerformClick()
                                Exit Sub
                            End If
                        End If
                    Next
                    MsgBox("No other account exists with permission to edit users. This must be enabled on another account before the current one can be removed.")
                End If
            End If
        End If

        userload()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lstUsers.SelectedItems.Count > 0 Then
            frmEditUser.Show()
        Else
            MsgBox("Please select a user.")
        End If
    End Sub
End Class



'For Each nodes In userfile.SelectNodes("/Creds/User")
'If nodes.ChildNodes(0).InnerText = txtUsername.Text Then
'If nodes.ChildNodes(2).InnerText = getSHA1Hash(txtPassword.Text) Then
'currentuser = nodes.ChildNodes(1).InnerText
'txtUsername.Focus()
'txtUsername.Clear()
'txtPassword.Clear()
'Me.Hide()
'frmDatabase.Show()
'Exit Sub
'Else
'MsgBox("Your password is incorrect.")
'Exit Sub
'End If
'End If
'Next