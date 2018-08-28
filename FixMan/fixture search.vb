Public Class frmSearch
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim temp As Integer = 0
        For i As Integer = 0 To frmDatabase.dgdStoreroom.RowCount - 1
            For j As Integer = 0 To frmDatabase.dgdStoreroom.ColumnCount - 1
                If frmDatabase.dgdStoreroom.Rows(i).Cells(j).Value.ToString = txtSearchTerm.Text Then
                    MsgBox("Item found")
                    temp = 1
                End If
            Next
        Next
        If temp = 0 Then
            MsgBox("Item not found")
        End If
    End Sub
End Class