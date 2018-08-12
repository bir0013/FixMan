Imports System.Xml
Public Class frmEditUser
    Dim selecteduser As Integer

    Dim inventoryrights, eventrights As Integer
    Dim useredit As Boolean

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
        selecteduser = frmUsers.lstUsers.SelectedIndex
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
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click


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

        Select Case True
            Case rdbEventEdit.Checked
                eventrights = 2
            Case rdbEventView.Checked
                eventrights = 1
            Case rdbEventBlock.Checked
                eventrights = 0
            Case Not rdbEventEdit.Checked And Not rdbEventView.Checked And Not rdbEventBlock.Checked
                MsgBox("Please select event priveliges.")
                Exit Sub
        End Select

        useredit = chkUserEdit.Checked

        If frmUsers.lstUsers.Items.Item(selecteduser).ToString = currentuser Then
            Dim userfile As New XmlDocument()
            userfile.Load("users.xml")
            Dim x As XmlNode
            If useredit = True Then
                CommitChanges()
                MsgBox("Changes to your account will not take effect until next login.")
            Else
                For Each x In userfile.SelectNodes("/Creds/User")
                    If x.ChildNodes(5).InnerText = "True" And Not x.ChildNodes(1).InnerText = currentuser Then
                        CommitChanges()
                        MsgBox("Changes to your account will not take effect until next login.")
                        Exit Sub
                    End If
                Next
                MsgBox("No other account exists with permission to edit users. This must be enabled on another account before the current one can be removed.")

            End If
        Else
            CommitChanges()
        End If

        frmUsers.userload()
    End Sub

    Sub CommitChanges()
        Try
            Dim userfile As New XmlDocument
            userfile.Load("users.xml")

            userfile.SelectSingleNode("Creds").ChildNodes(selecteduser).ChildNodes(1).InnerText = txtFullName.Text
            userfile.SelectSingleNode("Creds").ChildNodes(selecteduser).ChildNodes(2).InnerText = getSHA1Hash(txtPassword.Text)
            userfile.SelectSingleNode("Creds").ChildNodes(selecteduser).ChildNodes(3).InnerText = inventoryrights
            userfile.SelectSingleNode("Creds").ChildNodes(selecteduser).ChildNodes(4).InnerText = eventrights
            userfile.SelectSingleNode("Creds").ChildNodes(selecteduser).ChildNodes(5).InnerText = useredit.ToString


            userfile.Save("users.xml")



            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class