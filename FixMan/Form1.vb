'######################################################################################
'
'# Title: FixMan (Fixture Manager)                                                    #
'# Date of initial release: 30/8/2018                                                 #
'# Author: Michael Birkett                                                            #
'# Description: FixMan is a piece of software intended to help Audio/Visual teams to  #
'# keep track of the inventory of stage lighting instruments.                         #
'
'######################################################################################
Imports System.Xml

Public Class frmDatabase
    Dim openfile As String
    Private Sub btnAddFixture_Click(sender As Object, e As EventArgs) Handles btnAddFixture.Click
        'Shows frmAddFix1 (which allows the user to choose how they want to add a fixture to the database).
        frmAddFix1.Show()
    End Sub

    Private Sub frmDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This sets up the frmDatabase element access dependent on user privelige levels
        lblCurrentUser.Text = ("Logged in as: " & currentuser)
        UsersToolStripMenuItem.Enabled = UserPrivelige
        If InventoryPrivelige = 0 Then
            btnAddFixture.Enabled = False
            tsmAddFixture.Enabled = False
            msmAddFixture.Enabled = False
            btnRemoveFixture.Enabled = False
            tsmRemoveFixture.Enabled = False
            msmRemoveFixture.Enabled = False
            btnViewFixture.Enabled = False
            tsmViewFixture.Enabled = False
            msmViewFixture.Enabled = False
            btnSearchFixture.Enabled = False
            tsmSearchStoreroom.Enabled = False
            msmSearchFixture.Enabled = False
            dgdStoreroom.Enabled = False
        ElseIf InventoryPrivelige = 1 Then
            btnAddFixture.Enabled = False
            btnRemoveFixture.Enabled = False
        End If

        'This code is for future functionality
        'If EventPrivelige = 0 Then
        '    btnOpenEventMan.Enabled = False
        '    btnOpenFixSheet.Enabled = False
        '    btnOpenTeamRoster.Enabled = False
        'End If
    End Sub

    Private Sub btnSearchFixture_Click(sender As Object, e As EventArgs) Handles btnSearchFixture.Click
        'This shows the frmSearch form (which allows users to search for fixtures in the database)
        frmSearch.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        'This allows the user to logout so that a different user can login
        Dim response As Integer
        'This confirms the user's choice to logout.
        response = MsgBox("Are you sure you want to logout?", 36, "Logout?")
        If response = 6 Then
            'This asks whether the user wishes to save their work before logout occurs.
            response = MsgBox("Would you like to save your work?", 36, "Save?")
            If response = 6 Then
                btnSaveStoreroom.PerformClick()
                btnSaveEvent.PerformClick()
            End If
            frmLogin.Show()
            My.Application.OpenForms.Cast(Of Form)() _
              .Except({frmLogin}) _
              .ToList() _
              .ForEach(Sub(form) form.Close())
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This exits the solution
        Dim response As Integer
        'This confirms the user's choice to exit.
        response = MsgBox("Are you sure you want to exit?", 36, "Exit?")
        If response = 6 Then
            'This asks wether the user wishes to save their work before logout occurs.
            response = MsgBox("Would you like to save your work?", 36, "Save?")
            If response = 6 Then
                btnSaveStoreroom.PerformClick()
                btnSaveEvent.PerformClick()
                Application.Exit()
            End If
            Application.Exit()
        End If
    End Sub

    Private Sub btnOpenEventMan_Click(sender As Object, e As EventArgs) Handles btnOpenEventMan.Click
        frmEventView.Show()
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        frmUsers.Show()
    End Sub

    Private Sub btnSaveStoreroom_Click(sender As Object, e As EventArgs) Handles btnSaveStoreroom.Click
        'This saves the current database
        Dim filename As String
        Dim strm As New XmlDocument
        Dim fixturetype As XmlNode
        Dim currentfix As XmlNode
        Dim fixtypeid As XmlNode
        Dim qtyid As XmlNode
        Dim qty As XmlNode

        Dim Valid As Boolean
        Dim Name As String

        If currentstoreroom = String.Empty Then
            While Valid = False
                Dim res As DialogResult = dlgSaveStoreroom.ShowDialog()
                If res = Windows.Forms.DialogResult.Cancel Then
                    dlgSaveStoreroom.FileName = String.Empty
                    Exit Sub
                End If
                Name = dlgSaveStoreroom.FileName
                If Not Name = String.Empty Then
                    Valid = True
                Else
                    Valid = False
                    MsgBox("Please enter a name.")
                End If
            End While
            filename = Name
        Else
            filename = currentstoreroom
            'MsgBox(filename)
            strm.Load(filename)
            strm.RemoveAll()
        End If

        Dim root As XmlNode = strm.CreateElement("Storeroom")
        strm.AppendChild(root)

        'This takes the fixture manufacturer, model and quantity from each row of dgdStoreroom and stores it in an XML file
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
        currentstoreroom = filename
        lblCurrentStoreroom.Text = System.IO.Path.GetFileName(filename)
    End Sub

    Private Sub btnRemoveFixture_Click(sender As Object, e As EventArgs) Handles btnRemoveFixture.Click
        'This removes any selected rows from dgdStoreroom
        If Not dgdStoreroom.Rows.Count > 0 Then
            MsgBox("There are no fixtures in the current Storeroom.")
            Exit Sub
        End If
        For Each row In dgdStoreroom.SelectedRows
            dgdStoreroom.Rows.Remove(row)
        Next
    End Sub

    Private Sub btnLoadStoreroom_Click(sender As Object, e As EventArgs) Handles btnLoadStoreroom.Click
        Dim res As DialogResult = dlgOpenStoreroom.ShowDialog()
        If res = Windows.Forms.DialogResult.Cancel Then
            dlgOpenStoreroom.FileName = String.Empty
            Exit Sub
        End If

        Try
            Dim userfile As New XmlDocument()
            userfile.Load(openfile)
            If Not userfile.DocumentElement.Name = "Storeroom" Then
                MsgBox("Please select a valid storeroom file.")
                Exit Sub
            End If
            dgdStoreroom.Rows.Clear()
            Dim usernodes As XmlNodeList = userfile.DocumentElement.SelectNodes("/Storeroom")
            Dim nodes As XmlNode
            For Each nodes In userfile.SelectNodes("/Storeroom/Fixture")
                AddToStoreroom(Application.StartupPath & "\Fixtures\" & nodes.ChildNodes(0).InnerText & ".xml", nodes.ChildNodes(1).InnerText)
            Next
        Catch ex As Exception
            MsgBox(ex.Message & " Make sure that any fixture types in this database exist in the 'Fixtures' folder in the application directory.")
            Exit Sub
        End Try
        lblCurrentStoreroom.Text = System.IO.Path.GetFileName(dlgOpenStoreroom.FileName)
        currentstoreroom = dlgOpenStoreroom.FileName
    End Sub

    Private Sub dlgOpenStoreroom_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dlgOpenStoreroom.FileOk
        'This is some helper code for btnLoadStoreroom
        openfile = dlgOpenStoreroom.FileName
    End Sub

    Private Sub btnViewFixture_Click(sender As Object, e As EventArgs) Handles btnViewFixture.Click
        'This checks to make sure that there is a dgdStoreroom row to select and there is only one selected before assigning the selected fixture to selectedfixture variable and opening frmFixtureInfo
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
        'This clears dgdStoreroom and sets currentstoreroom to string.empty after checking if the user wants to save their work.
        Dim response As Integer
        response = MsgBox("Would you like to save your work?", 36, "Save?")
        If response = 6 Then
            btnSaveStoreroom.PerformClick()
        End If
        lblCurrentStoreroom.Text = String.Empty
        dgdStoreroom.Rows.Clear()
        currentstoreroom = String.Empty
    End Sub

    'All of the following subs are just links to buttons for the strip and context menus
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub NewStoreroomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewStoreroomToolStripMenuItem.Click
        btnNewStoreroom.PerformClick()
    End Sub

    Private Sub LoadStoreroomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadStoreroomToolStripMenuItem.Click
        btnLoadStoreroom.PerformClick()
    End Sub

    Private Sub SaveStoreroomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveStoreroomToolStripMenuItem.Click
        btnSaveStoreroom.PerformClick()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        btnLogout.PerformClick()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        btnExit.PerformClick()
    End Sub

    Private Sub AddFixtureToStoreroomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles msmAddFixture.Click
        btnAddFixture.PerformClick()
    End Sub

    Private Sub RemoveFixtureFromStoreroomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles msmRemoveFixture.Click
        btnRemoveFixture.PerformClick()
    End Sub

    Private Sub ViewSelectedFixtureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles msmViewFixture.Click
        btnViewFixture.PerformClick()
    End Sub

    Private Sub tsmAddFixture_Click(sender As Object, e As EventArgs) Handles tsmAddFixture.Click
        btnAddFixture.PerformClick()
    End Sub

    Private Sub tsmRemoveFixture_Click(sender As Object, e As EventArgs) Handles tsmRemoveFixture.Click
        btnRemoveFixture.PerformClick()
    End Sub

    Private Sub tsmViewFixture_Click(sender As Object, e As EventArgs) Handles tsmViewFixture.Click
        btnViewFixture.PerformClick()
    End Sub

    Private Sub msmSearchFixture_Click(sender As Object, e As EventArgs) Handles msmSearchFixture.Click
        frmSearch.Show()
    End Sub
End Class
