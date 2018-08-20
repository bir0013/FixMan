Imports System.Xml

Public Class frmDatabase
    Private Sub btnAddFixture_Click(sender As Object, e As EventArgs) Handles btnAddFixture.Click
        frmAddFix1.Show()
    End Sub

    Private Sub frmDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCurrentUser.Text = ("Logged in as: " & currentuser)
        UsersToolStripMenuItem.Enabled = UserPrivelige
        If InventoryPrivelige = 0 Then
            btnAddFixture.Enabled = False
            btnRemoveFixture.Enabled = False
            btnViewFixture.Enabled = False
            btnSearchFixture.Enabled = False
            dgdStoreroom.Enabled = False
        ElseIf InventoryPrivelige = 1 Then
            btnAddFixture.Enabled = False
            btnRemoveFixture.Enabled = False
        End If

        If EventPrivelige = 0 Then
            btnOpenEventMan.Enabled = False
            btnOpenFixSheet.Enabled = False
            btnOpenTeamRoster.Enabled = False
        End If
    End Sub

    Private Sub btnSearchFixture_Click(sender As Object, e As EventArgs) Handles btnSearchFixture.Click
        frmSearch.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        '##THIS CODE WILL HAVE TO BE CHECKED FOR PROPER DATA CLEAR##
        frmLogin.Show()
        My.Application.OpenForms.Cast(Of Form)() _
              .Except({frmLogin}) _
              .ToList() _
              .ForEach(Sub(form) form.Close())
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
