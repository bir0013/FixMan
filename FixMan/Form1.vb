Imports System.Xml

Public Class frmDatabase
    Private Sub btnAddFixture_Click(sender As Object, e As EventArgs) Handles btnAddFixture.Click
        frmAddFix1.Show()
    End Sub

    Private Sub frmDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCurrentUser.Text = ("Logged in as: " & currentuser)

        'Dim config As New XmlReader( '##FILE MUST BE ADDED##






    End Sub

    Private Sub btnSearchFixture_Click(sender As Object, e As EventArgs) Handles btnSearchFixture.Click
        frmSearch.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        '##THIS CODE WILL HAVE TO BE CHECKED FOR PROPER DATA CLEAR##
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        '#THIS COULD BE IMPROVED AT A LATER DATE##
        Dim response As Integer
        response = MsgBox("Are you sure you want to save and exit?", 36, "Exit?")
        If response = 6 Then
            btnSaveStoreroom.PerformClick()
            btnSaveEvent.PerformClick()
            End
        End If
    End Sub

    Private Sub btnOpenEventMan_Click(sender As Object, e As EventArgs) Handles btnOpenEventMan.Click
        frmEventView.Show()
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        frmUsers.Show()
    End Sub
End Class
