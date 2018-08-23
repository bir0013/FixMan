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

    Private Sub btnSaveStoreroom_Click(sender As Object, e As EventArgs) Handles btnSaveStoreroom.Click
        Dim filename As String
        Dim strm As New XmlDocument
        Dim fixturetype As XmlNode
        Dim currentfix As XmlNode
        Dim fixtypeid As XmlNode
        Dim qtyid As XmlNode
        Dim qty As XmlNode

        If lblCurrentStoreroom.Text = "" Then
            filename = InputBox("What would you like to name this file?") & ".xml"
        Else
            filename = lblCurrentStoreroom.Text
            filename = filename.Remove(0, 9)
            MsgBox(filename)
            strm.Load(filename)
            strm.RemoveAll()
        End If

        Dim root As XmlNode = strm.CreateElement("Storeroom")
        strm.AppendChild(root)

        For loops = 0 To dgdStoreroom.Rows.Count - 1
            currentfix = strm.CreateElement("Fixture")
            root.AppendChild(currentfix)
            fixtypeid = strm.CreateElement("FixtureType")
            currentfix.AppendChild(fixtypeid)
            fixturetype = strm.CreateTextNode(dgdStoreroom.Rows(loops).Cells(1).Value & " " & dgdStoreroom.Rows(loops).Cells(2).Value)
            fixtypeid.AppendChild(fixturetype)
            qtyid = strm.CreateElement("Quantity")
            currentfix.AppendChild(qtyid)
            qty = strm.CreateTextNode(dgdStoreroom.Rows(loops).Cells(7).Value)
            qtyid.AppendChild(qty)
        Next
        strm.Save(filename)
        lblCurrentStoreroom.Text = "Current: " & filename
    End Sub

    Private Sub btnRemoveFixture_Click(sender As Object, e As EventArgs) Handles btnRemoveFixture.Click
        For Each row In dgdStoreroom.SelectedRows
            dgdStoreroom.Rows.Remove(row)
        Next
    End Sub
End Class
