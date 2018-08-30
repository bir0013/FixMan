Imports System.IO
Imports System.Xml

Public Class frmAddFix1
    Private Sub btnManual_Click(sender As Object, e As EventArgs) Handles btnManual.Click
        'This button throws over to frmFixAdd2
        Me.Close()
        frmAddFix2.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim res As DialogResult = dlgImportFixture.ShowDialog()
        If res = Windows.Forms.DialogResult.Cancel Then
            dlgImportFixture.FileName = String.Empty
            Exit Sub
        End If

        Dim Valid As Boolean
        Dim quantity As String

        Dim fixfile As New XmlDocument()
        fixfile.Load(dlgImportFixture.FileName)
        If Not fixfile.DocumentElement.ChildNodes(0).Name = "Fixture" Then
            MsgBox("Please select a valid fixture type file.")
            Exit Sub
        End If

        While Valid = False
            quantity = InputBox("How many of this fixture do you have?")
            If IsNumeric(quantity) Then
                Valid = True
            Else
                Valid = False
                MsgBox("Please enter a numeric value.")
            End If
        End While

        AddToStoreroom(dlgImportFixture.FileName, quantity)
        'If Not My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Fixtures") Then
        '    My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\Fixtures")
        'End If
        'My.Computer.FileSystem.CopyDirectory(dlgImportFixture.FileName, Application.StartupPath & "\Fixtures")
        Try
            Dim sourcepath As String = dlgImportFixture.FileName
            Dim DestPath As String = Application.StartupPath & "\Fixtures"
            If Not My.Computer.FileSystem.DirectoryExists(DestPath) Then
                My.Computer.FileSystem.CreateDirectory(DestPath)
            End If
            Dim file = New FileInfo(dlgImportFixture.FileName)
            file.CopyTo(Path.Combine(DestPath, file.Name), True)
        Catch ex As Exception
            If Not ex.GetType.ToString = "System.IO.IOException" Then
                MsgBox(ex.Message)
            Else
                Me.Close()
                Exit Sub
            End If
        End Try
    End Sub
End Class