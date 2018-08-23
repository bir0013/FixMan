Imports System.IO

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
        dlgImportFixture.ShowDialog()
        AddToStoreroom(dlgImportFixture.FileName, InputBox("How many of this fixture do you have?"))
        'If Not My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Fixtures") Then
        '    My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\Fixtures")
        'End If
        'My.Computer.FileSystem.CopyDirectory(dlgImportFixture.FileName, Application.StartupPath & "\Fixtures")
        Dim sourcepath As String = dlgImportFixture.FileName
        Dim DestPath As String = Application.StartupPath & "\Fixtures"
        If Not My.Computer.FileSystem.DirectoryExists(DestPath) Then
            My.Computer.FileSystem.CreateDirectory(DestPath)
        End If
        Dim file = New FileInfo(dlgImportFixture.FileName)
        file.CopyTo(Path.Combine(DestPath, file.Name), True)
    End Sub
End Class