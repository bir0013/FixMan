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
    End Sub
End Class