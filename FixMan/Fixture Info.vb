Public Class frmFixtureInfo
    Dim colourhorizontal, colourvertical As Integer
    Dim gobohorizontal, gobovertical As Integer
    Private Sub frmFixtureInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = selectedfixture

        'This initialises the variables that keep track of datagridview scroll
        colourhorizontal = 0
        colourvertical = 0
        gobohorizontal = 0
        gobovertical = 0

        'This initialises the datagridview for colours and gobos
        dgdColours.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        dgdGobos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        dgdColours.RowTemplate.Height = 70
        dgdGobos.RowTemplate.Height = 70

        dgdColours.Columns.Add("Column1", "")
        dgdColours.Columns.Add("Column2", "")
        dgdColours.Columns.Add("Column3", "")
        dgdColours.Rows.Add()
        dgdGobos.Columns.Add("Column1", "")
        dgdGobos.Columns.Add("Column2", "")
        dgdGobos.Columns.Add("Column3", "")
        dgdGobos.Rows.Add()
    End Sub
End Class