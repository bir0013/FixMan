Imports System.Security

Public Class frmUsers
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim newuser, newname As String
        Dim newpass As SecureString

        newname = InputBox("Name for new user:")
        newuser = InputBox("Username for new user:")


    End Sub
End Class