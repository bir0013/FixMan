Imports System.Xml
Public Class frmEditUser
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



    Private Sub frmEditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim userfile As New XmlDocument()
            userfile.Load("users.xml")
            'Dim usernodes As XmlNodeList = userfile.DocumentElement.SelectNodes("/Creds")
            Dim node As XmlNode = userfile.SelectSingleNode("Creds/User/LongName[. = '" & frmUsers.lstUsers.SelectedItem.ToString & "']")
            If node IsNot Nothing Then
                txtUsername.Text = node.ParentNode.ChildNodes(0).InnerText
                txtFullName.Text = node.ParentNode.ChildNodes(1).InnerText
                If node.ParentNode.ChildNodes(5).InnerText = "True" Then
                    chkUserEdit.Checked = True
                End If
                Select Case True
                    Case node.ParentNode.ChildNodes(3).InnerText = 2
                        rdbInventoryEdit.Checked = True
                    Case node.ParentNode.ChildNodes(3).InnerText = 1
                        rdbInventoryView.Checked = True
                    Case node.ParentNode.ChildNodes(3).InnerText = 0
                        rdbInventoryBlock.Checked = True
                End Select

                Select Case True
                    Case node.ParentNode.ChildNodes(4).InnerText = 2
                        rdbEventEdit.Checked = True
                    Case node.ParentNode.ChildNodes(4).InnerText = 1
                        rdbEventView.Checked = True
                    Case node.ParentNode.ChildNodes(4).InnerText = 0
                        rdbEventBlock.Checked = True
                End Select
                userfile.Save("users.xml")
                'MsgBox(lstUsers.SelectedItem.ToString)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class