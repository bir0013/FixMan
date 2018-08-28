﻿Imports System.Xml

Public Class frmDatabase
    Dim openfile As String
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
        response = MsgBox("Are you sure you want to exit?", 36, "Exit?")
        If response = 6 Then
            response = MsgBox("Would you like to save your work?", 36, "Save?")
            If response = 6 Then
                btnSaveStoreroom.PerformClick()
                btnSaveEvent.PerformClick()
                End
            End If
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

        Dim Valid As Boolean
        Dim Name As String

        If lblCurrentStoreroom.Text = "" Then
            While Valid = False
                Name = InputBox("What would you like to name this storeroom?")
                If Not Name = String.Empty Then
                    Valid = True
                Else
                    Valid = False
                    MsgBox("Please enter a name.")
                End If
            End While
            filename = Name & ".xml"
        Else
            filename = lblCurrentStoreroom.Text
            filename = filename.Remove(0, 9)
            'MsgBox(filename)
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

    Private Sub btnLoadStoreroom_Click(sender As Object, e As EventArgs) Handles btnLoadStoreroom.Click
        dlgOpenStoreroom.ShowDialog()

        Try
            Dim userfile As New XmlDocument()
            userfile.Load(openfile)
            If Not userfile.DocumentElement.Name = "Storeroom" Then
                MsgBox("Please select a valid storeroom file.")
                Exit Sub
            End If
            Dim usernodes As XmlNodeList = userfile.DocumentElement.SelectNodes("/Storeroom")
            Dim nodes As XmlNode
            For Each nodes In userfile.SelectNodes("/Storeroom/Fixture")
                AddToStoreroom(Application.StartupPath & "\Fixtures\" & nodes.ChildNodes(0).InnerText & ".xml", nodes.ChildNodes(1).InnerText)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub dlgOpenStoreroom_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dlgOpenStoreroom.FileOk
        openfile = dlgOpenStoreroom.FileName
    End Sub

    Private Sub btnViewFixture_Click(sender As Object, e As EventArgs) Handles btnViewFixture.Click
        If Not dgdStoreroom.Rows.Count > 0 Then
            MsgBox("There are no fixtures in the current Storeroom.")
            Exit Sub
        End If
        If dgdStoreroom.SelectedRows.Count > 1 Then
            MsgBox("Please select a single fixture.")
            Exit Sub
        End If

        selectedfixture = dgdStoreroom.Rows(dgdStoreroom.CurrentRow.Index).Cells(1).Value & " " & dgdStoreroom.Rows(dgdStoreroom.CurrentRow.Index).Cells(2).Value

        frmFixtureInfo.Show()

        'MsgBox(selectedfixture)
    End Sub

    Private Sub btnNewStoreroom_Click(sender As Object, e As EventArgs) Handles btnNewStoreroom.Click


        Dim response As Integer
        response = MsgBox("Would you like to save your work?", 36, "Save?")
        If response = 6 Then
            btnSaveStoreroom.PerformClick()
        End If
        lblCurrentStoreroom.Text = String.Empty
        dgdStoreroom.Rows.Clear()

    End Sub
End Class
