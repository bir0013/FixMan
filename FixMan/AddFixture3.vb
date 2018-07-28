Public Class frmAddFix3
    Dim filecount As Integer
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        dlgOpenFile.ShowDialog()

        lstFiles.Items.Add(dlgOpenFile.FileName)
        filecount += 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lstFiles.Items.Remove(lstFiles.SelectedItem)
        If filecount <> 0 Then
            filecount -= 1
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        For i = 0 To filecount - 1
            FixFiles.Add(lstFiles.Items.Item(i))
            MsgBox(FixFiles.Item(i))
        Next
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim response As Integer
        response = MsgBox("Are you sure you want to cancel? All information for this fixture will be lost.", 36, "Cancel?")
        If response = 6 Then
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frmAddFix2.Show()
    End Sub
End Class