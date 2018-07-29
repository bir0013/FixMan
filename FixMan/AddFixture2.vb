

Public Class frmAddFix2
    Dim colourhorizontal, colourvertical As Integer
    Dim gobohorizontal, gobovertical As Integer
    Private Sub frmAddFix2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colourhorizontal = 0
        colourvertical = 0
        gobohorizontal = 0
        gobovertical = 0

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

        cmbBeamType.Items.Add("Spot")
        cmbBeamType.Items.Add("Wash")
        cmbBeamType.Items.Add("Parabolic Aluminized Reflector (PAR)")
        cmbBeamType.Items.Add("Fresnel")
        cmbBeamType.Items.Add("Pebble Convex (PC)")
        cmbBeamType.Items.Add("PARnel")
        cmbBeamType.Items.Add("Ellipsoidal Reflector Spotlight (ERS)")
        cmbBeamType.Items.Add("Scoop")
        cmbBeamType.Items.Add("Cyc Strip (Bank)")
        cmbBeamType.Items.Add("Cyc Flood (Single)")
        cmbBeamType.Items.Add("Beam Projector")
        cmbBeamType.Items.Add("Other")

        cmbType.Items.Add("Conventional")
        cmbType.Items.Add("Intelligent (Moving Head)")
        cmbType.Items.Add("Intelligent (Moving Mirror)")
        cmbType.Items.Add("Intelligent (Static)")
        cmbType.Items.Add("Static Effect")
        cmbType.Items.Add("Other")
    End Sub
    Private Sub btnColourText_Click(sender As Object, e As EventArgs) Handles btnColourText.Click
        AddTextGridView("colour")

        'Dim colourtext As String

        'colourtext = InputBox("What's the name of the colour?")

        'If Not colourtext = String.Empty Then
        '    If colourhorizontal = 3 Then
        '        dgdColours.Rows.Add()
        '        colourvertical += 1
        '        colourhorizontal = 0
        '    End If


        '    dgdColours.Rows(colourvertical).Cells(colourhorizontal).Value = colourtext
        '    colourhorizontal += 1
        'Else
        '    MsgBox("Please enter a name.")
        'End If
    End Sub

    Private Sub btnAddControl_Click(sender As Object, e As EventArgs) Handles btnAddControl.Click
        'This button adds control protocols entered in txtControl to lstControl
        If Not txtControl.Text = String.Empty Then
            lstControl.Items.Add(txtControl.Text)
            txtControl.Clear()
            txtControl.Focus()
        End If
    End Sub

    Private Sub btnGoboText_Click(sender As Object, e As EventArgs) Handles btnGoboText.Click
        AddTextGridView("gobo")
        'Dim gobotext As String

        'gobotext = InputBox("What's the name of the colour?")

        'If Not gobotext = String.Empty Then
        '    If colourhorizontal = 3 Then
        '        dgdColours.Rows.Add()
        '        colourvertical += 1
        '        colourhorizontal = 0
        '    End If


        '    dgdColours.Rows(colourvertical).Cells(colourhorizontal).Value = gobotext
        '    colourhorizontal += 1
        'Else
        '    MsgBox("Please enter a name.")
        '    btnGoboText.PerformClick()
        'End If
    End Sub



    Private Sub btnAddEffect_Click(sender As Object, e As EventArgs) Handles btnAddEffect.Click
        'This button adds effects entered in txtEffects to lstEffects
        If Not txtEffects.Text = String.Empty Then
            lstEffects.Items.Add(txtEffects.Text)
            txtEffects.Clear()
            txtEffects.Focus()
        End If
    End Sub

    Sub AddTextGridView(ByRef EffectType)
        'This procedure handles distribution of text string data in the two data grid view in this form (for colour and gobo)
        'When btnColourText or btnGoboText is pressed, they will activate this procedure and give it the effect type identifier.

        Dim text As String

        text = InputBox("What is the name of the " & EffectType & "?")

        'If Not text = String.Empty Then
        '    If colourhorizontal = 3 Then
        '        dgdColours.Rows.Add()
        '        colourvertical += 1
        '        colourhorizontal = 0
        '    End If

        '    dgdColours.Rows(colourvertical).Cells(colourhorizontal).Value = text
        '    colourhorizontal += 1
        'Else
        '    MsgBox("Please enter a name.")
        '    btnGoboText.PerformClick()
        'End If

        If Not text = String.Empty Then
            If EffectType = "colour" Then
                If colourhorizontal = 3 Then
                    dgdColours.Rows.Add()
                    colourvertical += 1
                    colourhorizontal = 0
                End If
                dgdColours.Rows(colourvertical).Cells(colourhorizontal).Value = text

                '### THIS CODE MAY BE CHANGED LATER. IT ADDS CELL TAG. ###
                dgdColours.Rows(colourvertical).Cells(colourhorizontal).Tag = text

                colourhorizontal += 1
            ElseIf EffectType = "gobo" Then
                If gobohorizontal = 3 Then
                    dgdGobos.Rows.Add()
                    gobovertical += 1
                    gobohorizontal = 0
                End If
                dgdGobos.Rows(gobovertical).Cells(gobohorizontal).Value = text

                '### THIS CODE MAY BE CHANGED LATER. IT ADDS CELL TAG. ###
                dgdGobos.Rows(gobovertical).Cells(gobohorizontal).Tag = text

                gobohorizontal += 1
            Else
                MsgBox("WOW! You should never ever see this error. It's no big deal, just means that something has passed an incorrect value to the current procedure. Contact bir0013@mckinnonsc.vic.edu.au if you have this problem again.")
            End If
        Else
            MsgBox("Please enter a name.")
        End If
    End Sub

    Sub AddImageGridView(ByRef EffectType)
        'This procedure handles distribution of image data in the two data grid view in this form (for colour and gobo)
        'When btnColourImage or btnGoboImage is pressed, they will activate this procedure and give it the effect type identifier.

        dlgOpenImage.ShowDialog()

        Dim img As Image = Image.FromFile(dlgOpenImage.FileName)

        Dim imagecell As New DataGridViewImageCell
        imagecell.ImageLayout = DataGridViewImageCellLayout.Zoom

        If Not dlgOpenImage.FileName = String.Empty Then
            If EffectType = "colour" Then
                If colourhorizontal = 3 Then
                    dgdColours.Rows.Add()
                    colourvertical += 1
                    colourhorizontal = 0
                End If
                dgdColours.Rows(colourvertical).Cells(colourhorizontal) = imagecell
                dgdColours.Rows(colourvertical).Cells(colourhorizontal).Value = img

                '### THIS CODE MAY BE CHANGED LATER. IT ADDS CELL TAG. ###
                dgdColours.Rows(colourvertical).Cells(colourhorizontal).Tag = img

                colourhorizontal += 1
            ElseIf EffectType = "gobo" Then
                If gobohorizontal = 3 Then
                    dgdGobos.Rows.Add()
                    gobovertical += 1
                    gobohorizontal = 0
                End If
                dgdGobos.Rows(gobovertical).Cells(gobohorizontal) = imagecell
                dgdGobos.Rows(gobovertical).Cells(gobohorizontal).Value = img

                '### THIS CODE MAY BE CHANGED LATER. IT ADDS CELL TAG. ###
                dgdGobos.Rows(gobovertical).Cells(gobohorizontal).Tag = img

                gobohorizontal += 1
            Else
                MsgBox("WOW! You should never ever see this error. It's no big deal, just means that something has passed an incorrect value to the current procedure. Contact bir0013@mckinnonsc.vic.edu.au if you have this problem again.")
            End If
        Else
            MsgBox("Please enter a name.")
        End If
    End Sub

    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
        dlgOpenImage.ShowDialog()
        Dim image As Image = Image.FromFile(dlgOpenImage.FileName)
        lblImageLocation.Text = dlgOpenImage.FileName
        picImage.Image = image
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        FixImage = picImage.Image
        FixManufacturer = txtManufacturer.Text
        FixModel = txtModel.Text
        FixSource = txtSource.Text
        FixType = cmbType.Text
        FixOptical = cmbBeamType.Text
        FixBeamAngle.FixBeamMin = nudBeamAngleFrom.Value
        FixBeamAngle.FixBeamMax = nudBeamAngleTo.Value
        FixBeamAngle.FixBeamAuto = chkAutoZoom.Checked

        If lstControl.SelectedItems.Count > 0 Then
            For Each item As ListViewItem.ListViewSubItem In lstControl.SelectedItems(0).SubItems
                FixControl.Add(item.Text)
            Next
        End If

        FixTotalPowerDraw = nudPowerDraw.Value

        '### CODE FOR COLOURS GOES HERE ###

        '### CODE FOR GOBOS GOES HERE ###

        If lstEffects.SelectedItems.Count > 0 Then
            For Each item As ListViewItem.ListViewSubItem In lstEffects.SelectedItems(0).SubItems
                FixEffects.Add(item.Text)
            Next
        End If

        FixNotes = rtbNotes.Text

        Me.Hide()
        frmAddFix3.Show()
    End Sub

    Private Sub btnColourImage_Click(sender As Object, e As EventArgs) Handles btnColourImage.Click
        AddImageGridView("colour")
    End Sub

    Private Sub btnGoboImage_Click(sender As Object, e As EventArgs) Handles btnGoboImage.Click
        AddImageGridView("gobo")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim response As Integer
        response = MsgBox("Are you sure you want to cancel? All information for this fixture will be lost.", 36, "Cancel?")
        If response = 6 Then
            Me.Hide()
        End If
    End Sub


    Private Sub txtControl_KeyUp(sender As Object, e As KeyEventArgs) Handles txtControl.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnAddControl.PerformClick()
        End If
    End Sub

    Private Sub txtEffects_KeyUp(sender As Object, e As KeyEventArgs) Handles txtEffects.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnAddEffect.PerformClick()
        End If
    End Sub
End Class