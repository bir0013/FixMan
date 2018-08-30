Public Class frmSearch
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'This searches all cells in frmDatabase.dgdStoreroom to see whether the text in any cell matches that of txtSearchTerm (partial match is implemented).
        dgdSearchResult.Rows.Clear()
        Dim temp As Integer = 0
        For i As Integer = 0 To frmDatabase.dgdStoreroom.RowCount - 1
            For j As Integer = 0 To frmDatabase.dgdStoreroom.ColumnCount - 1
                If frmDatabase.dgdStoreroom.Rows(i).Cells(j).Value.ToString.ToLower.Contains(txtSearchTerm.Text.ToLower) Then
                    'dgdSearchResult.Rows.Add(frmDatabase.dgdStoreroom.Rows(i).Clone)
                    Dim row As DataGridViewRow
                    row = DirectCast(frmDatabase.dgdStoreroom.Rows(i).Clone(), DataGridViewRow)
                    Dim intColIndex As Integer = 0
                    For Each cell As DataGridViewCell In frmDatabase.dgdStoreroom.Rows(i).Cells
                        row.Cells(intColIndex).Value = cell.Value
                        intColIndex += 1
                    Next
                    row.Cells(j).Style.BackColor = Color.Orange
                    dgdSearchResult.Rows.Add(row)
                    temp = 1
                    Exit For
                End If
            Next
        Next
        If temp = 0 Then
            MsgBox("Seach term not found")
        End If
    End Sub

    Private Sub frmSearch_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Ensures that txtSearchTerm is focused
        txtSearchTerm.Focus()
    End Sub
End Class