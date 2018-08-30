Public Class frmAbout
    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This gets the current version number for the solution and displays it in lblVersion
        lblVersion.Text = "Version: " & My.Application.Info.Version.ToString
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes the form
        Me.Close()
    End Sub
End Class