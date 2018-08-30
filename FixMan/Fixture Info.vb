Imports System.Xml

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

        Dim fix As New XmlDocument
        fix.Load(Application.StartupPath & "\Fixtures\" & selectedfixture & ".xml")
        Dim nodes As XmlNode

        For Each nodes In fix.SelectNodes("/Root/Fixture/Files/File")
            lstDocuments.Items.Add(nodes.InnerText)
        Next
        For Each nodes In fix.SelectNodes("/Root/Fixture/Control/Protocol")
            lstControl.Items.Add(nodes.InnerText)
        Next
        For Each nodes In fix.SelectNodes("/Root/Fixture/Effects/Effect")
            lstEffects.Items.Add(nodes.InnerText)
        Next

        picImage.Image = Base64ToImage(fix.DocumentElement.ChildNodes(0).ChildNodes(2).InnerText)
        lblManufacturer.Text = fix.DocumentElement.ChildNodes(0).ChildNodes(0).InnerText
        lblModel.Text = fix.DocumentElement.ChildNodes(0).ChildNodes(1).InnerText
        lblType.Text = fix.DocumentElement.ChildNodes(0).ChildNodes(3).InnerText
        lblSource.Text = fix.DocumentElement.ChildNodes(0).ChildNodes(4).InnerText
        lblBeam.Text = fix.DocumentElement.ChildNodes(0).ChildNodes(5).InnerText
        lblColourTemp.Text = fix.DocumentElement.ChildNodes(0).ChildNodes(6).InnerText
        lblTPD.Text = fix.DocumentElement.ChildNodes(0).ChildNodes(7).InnerText
        rtbNotes.Text = fix.DocumentElement.ChildNodes(0).ChildNodes(17).InnerText
        If fix.DocumentElement.ChildNodes(0).ChildNodes(20).InnerText = "true" Then
            lblColourMix.Text = "ColourMix is supported"
        ElseIf fix.DocumentElement.ChildNodes(0).ChildNodes(20).InnerText = "false" Then
            lblColourMix.Text = "ColourMix is not supportedt"
        End If

        If fix.DocumentElement.ChildNodes(0).ChildNodes(14).InnerText = fix.DocumentElement.ChildNodes(0).ChildNodes(15).InnerText Then
            lblAngle.Text = fix.DocumentElement.ChildNodes(0).ChildNodes(14).InnerText & "°"
        ElseIf fix.DocumentElement.ChildNodes(0).ChildNodes(16).InnerText = "true" Then
            lblAngle.Text = fix.DocumentElement.ChildNodes(0).ChildNodes(14).InnerText & "° - " & fix.DocumentElement.ChildNodes(0).ChildNodes(15).InnerText & "° with automated zoom"
        Else
            lblAngle.Text = fix.DocumentElement.ChildNodes(0).ChildNodes(14).InnerText & "° - " & fix.DocumentElement.ChildNodes(0).ChildNodes(15).InnerText & "° (no automated zoom)"
        End If

        Dim colourloops As Integer = 0
        For Each nodes In fix.SelectNodes("/Root/Fixture/ColourDataType/Type")
            If nodes.InnerText = "Text" Then
                AddTextGridView("colour", fix.DocumentElement.ChildNodes(0).ChildNodes(18).ChildNodes(colourloops).InnerText)
            ElseIf nodes.InnerText = "Image" Then
                AddImageGridView("colour", fix.DocumentElement.ChildNodes(0).ChildNodes(18).ChildNodes(colourloops).InnerText)
            End If
            colourloops += 1
        Next

        Dim goboloops As Integer = 0
        For Each nodes In fix.SelectNodes("/Root/Fixture/GoboDataType/Type")
            If nodes.InnerText = "Text" Then
                AddTextGridView("gobo", fix.DocumentElement.ChildNodes(0).ChildNodes(19).ChildNodes(goboloops).InnerText)
            ElseIf nodes.InnerText = "Image" Then
                AddImageGridView("gobo", fix.DocumentElement.ChildNodes(0).ChildNodes(19).ChildNodes(goboloops).InnerText)
            End If
            goboloops += 1
        Next
    End Sub

    Private Sub lstDocuments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDocuments.SelectedIndexChanged
        webDocViewer.Navigate(lstDocuments.SelectedItem.ToString)
    End Sub

    Sub AddTextGridView(ByRef EffectType, ByRef Text)
        'This procedure handles distribution of text string data in the two data grid view in this form (for colour and gobo)
        'This is a modified version of the AddTextGridView Sub in frmAddFix2

        If Not Text = String.Empty Then
            'This adds to dgdColours
            If EffectType = "colour" Then
                If colourhorizontal = 3 Then
                    dgdColours.Rows.Add()
                    colourvertical += 1
                    colourhorizontal = 0
                End If
                dgdColours.Rows(colourvertical).Cells(colourhorizontal).Value = Text
                dgdColours.Rows(colourvertical).Cells(colourhorizontal).Tag = "Text"

                colourhorizontal += 1

                'This adds to dgdGobos
            ElseIf EffectType = "gobo" Then
                If gobohorizontal = 3 Then
                    dgdGobos.Rows.Add()
                    gobovertical += 1
                    gobohorizontal = 0
                End If
                dgdGobos.Rows(gobovertical).Cells(gobohorizontal).Value = Text
                dgdGobos.Rows(gobovertical).Cells(gobohorizontal).Tag = "Text"

                gobohorizontal += 1
            Else
                'I thought it would be nice to add this little extra bit of error checking :)
                MsgBox("WOW! You should never ever see this error. It's no big deal, just means that something has passed an incorrect value to the current procedure. Contact bir0013@mckinnonsc.vic.edu.au if you have this problem again.")
            End If
        Else
            MsgBox("Please enter a name.")
        End If
    End Sub

    Sub AddImageGridView(ByRef EffectType, ByRef Image64)
        'This procedure handles distribution of image data in the two data grid view in this form (for colour and gobo)
        'This is a modified version of the AddTextGridView Sub in frmAddFix2

        Dim img As Image = Base64ToImage(Image64)

        Dim imagecell As New DataGridViewImageCell
        imagecell.ImageLayout = DataGridViewImageCellLayout.Zoom

        If Not Image64 = String.Empty Then
            'This adds to dgdColours
            If EffectType = "colour" Then
                If colourhorizontal = 3 Then
                    dgdColours.Rows.Add()
                    colourvertical += 1
                    colourhorizontal = 0
                End If
                dgdColours.Rows(colourvertical).Cells(colourhorizontal) = imagecell
                dgdColours.Rows(colourvertical).Cells(colourhorizontal).Value = img
                dgdColours.Rows(colourvertical).Cells(colourhorizontal).Tag = "Image"

                colourhorizontal += 1

                'This adds to dgdGobos
            ElseIf EffectType = "gobo" Then
                If gobohorizontal = 3 Then
                    dgdGobos.Rows.Add()
                    gobovertical += 1
                    gobohorizontal = 0
                End If
                dgdGobos.Rows(gobovertical).Cells(gobohorizontal) = imagecell
                dgdGobos.Rows(gobovertical).Cells(gobohorizontal).Value = img
                dgdGobos.Rows(gobovertical).Cells(gobohorizontal).Tag = "Image"

                gobohorizontal += 1
            Else
                'I thought it would be nice to add this little extra bit of error checking :)
                MsgBox("WOW! You should never ever see this error. It's no big deal, just means that something has passed an incorrect value to the current procedure. Contact bir0013@mckinnonsc.vic.edu.au if you have this problem again.")
            End If
        End If
    End Sub
End Class