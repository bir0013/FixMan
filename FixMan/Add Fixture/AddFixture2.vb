Imports System.IO

Public Class frmAddFix2
    Dim colourhorizontal, colourvertical As Integer
    Dim gobohorizontal, gobovertical As Integer
    Private Sub frmAddFix2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        'This initialises the comboboxes for optical system and fixture type
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
        'This calls the procedure that adds text to datagridviews for dgdColours
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
        'This calls the procedure that adds text to datagridviews for dgdGobos
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
            'This adds to dgdColours
            If EffectType = "colour" Then
                If colourhorizontal = 3 Then
                    dgdColours.Rows.Add()
                    colourvertical += 1
                    colourhorizontal = 0
                End If
                dgdColours.Rows(colourvertical).Cells(colourhorizontal).Value = text
                dgdColours.Rows(colourvertical).Cells(colourhorizontal).Tag = "Text"

                colourhorizontal += 1

                'This adds to dgdGobos
            ElseIf EffectType = "gobo" Then
                If gobohorizontal = 3 Then
                    dgdGobos.Rows.Add()
                    gobovertical += 1
                    gobohorizontal = 0
                End If
                dgdGobos.Rows(gobovertical).Cells(gobohorizontal).Value = text
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

    Sub AddImageGridView(ByRef EffectType)
        'This procedure handles distribution of image data in the two data grid view in this form (for colour and gobo)
        'When btnColourImage or btnGoboImage is pressed, they will activate this procedure and give it the effect type identifier.

        Dim res As DialogResult = dlgOpenImage.ShowDialog()
        If res = Windows.Forms.DialogResult.Cancel Then
            dlgOpenImage.FileName = String.Empty
            Exit Sub
        End If

        Dim img As Image = Image.FromFile(dlgOpenImage.FileName)

        Dim imagecell As New DataGridViewImageCell
        imagecell.ImageLayout = DataGridViewImageCellLayout.Zoom

        If Not dlgOpenImage.FileName = String.Empty Then
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
        Else
            MsgBox("Please enter a name.")
        End If

        dlgOpenImage.FileName = String.Empty
    End Sub

    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
        'This is for adding an image of the fixture being entered
        Dim res As DialogResult = dlgOpenImage.ShowDialog()
        If res = Windows.Forms.DialogResult.Cancel Then
            dlgOpenImage.FileName = String.Empty
            Exit Sub
        End If

        Dim image As Image = Image.FromFile(dlgOpenImage.FileName)
        lblImageLocation.Text = dlgOpenImage.FileName
        picImage.Image = image
        dlgOpenImage.FileName = String.Empty
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'This Sub is responsible for putting all information entered in frmAddFix2 into temp variables so that they can be commited to file later

        'These variables are used to keep track of position when scrolling through and getting information from the colour and gobo datagridviews
        Dim colourverticalscroll As Integer = 0
        Dim colourhorizontalscroll As Integer = 0
        Dim goboverticalscroll As Integer = 0
        Dim gobohorizontalscroll As Integer = 0

        'This is where most of the information is stored
        If picImage.Image Is Nothing Then
            FixImage = ImageToBase64(My.Resources.noimage)
        Else
            FixImage = ImageToBase64(picImage.Image)
        End If

        FixManufacturer = txtManufacturer.Text
        FixModel = txtModel.Text
        FixSource = txtSource.Text
        FixType = cmbType.Text
        FixOptical = cmbBeamType.Text
        FixBeamAngle.FixBeamMin = nudBeamAngleFrom.Value
        FixBeamAngle.FixBeamMax = nudBeamAngleTo.Value
        FixBeamAngle.FixBeamAuto = chkAutoZoom.Checked


        'This takes all control protocols from lstControl and stores them in the FixControl list
        If lstControl.Items.Count > 0 Then
            For Each item In lstControl.Items
                FixControl.Add(item)
            Next
        End If

        'This is for colour temp and total power draw (I have structured the storing so that it happens in the order that each section appears on the form)
        FixColourTemp = nudColourTemp.Value
        FixTotalPowerDraw = nudPowerDraw.Value

        'This is responsible for taking all text and images from dgdColours and storing them in FixColours (and also FixColourDataType, which is used to keep track of which entries in FixColours correspond with which data type)
        For loops = 1 To ((colourvertical * 3) + colourhorizontal)
            If dgdColours.Rows(colourverticalscroll).Cells(colourhorizontalscroll).Tag = "Text" Then
                FixColourDataType.Add(dgdColours.Rows(colourverticalscroll).Cells(colourhorizontalscroll).Tag)
                FixColours.Add(dgdColours.Rows(colourverticalscroll).Cells(colourhorizontalscroll).Value)
            ElseIf dgdColours.Rows(colourverticalscroll).Cells(colourhorizontalscroll).Tag = "Image" Then
                FixColourDataType.Add(dgdColours.Rows(colourverticalscroll).Cells(colourhorizontalscroll).Tag)
                FixColours.Add(ImageToBase64(dgdColours.Rows(colourverticalscroll).Cells(colourhorizontalscroll).Value))
            End If
            If colourhorizontalscroll = 2 Then
                colourverticalscroll += 1
                colourhorizontalscroll = 0
            End If
            colourhorizontalscroll += 1
        Next

        'This is responsible for taking all text and images from dgdColours and storing them in FixColours (and also FixColourDataType, which is used to keep track of which entries in FixColours correspond with which data type)
        For loops = 1 To ((gobovertical * 3) + gobohorizontal)
            If dgdGobos.Rows(goboverticalscroll).Cells(gobohorizontalscroll).Tag = "Text" Then
                FixGoboDataType.Add(dgdGobos.Rows(goboverticalscroll).Cells(gobohorizontalscroll).Tag)
                FixGobos.Add(dgdGobos.Rows(goboverticalscroll).Cells(gobohorizontalscroll).Value)
            ElseIf dgdGobos.Rows(goboverticalscroll).Cells(gobohorizontalscroll).Tag = "Image" Then
                FixGoboDataType.Add(dgdGobos.Rows(goboverticalscroll).Cells(gobohorizontalscroll).Tag)
                FixGobos.Add(ImageToBase64(dgdGobos.Rows(goboverticalscroll).Cells(gobohorizontalscroll).Value))
            End If
            If gobohorizontalscroll = 2 Then
                goboverticalscroll += 1
                gobohorizontalscroll = 0
            End If
            gobohorizontalscroll += 1
        Next

        'This takes all effects from lstEffects and stores them in the FixEffects list
        If lstEffects.Items.Count > 0 Then
            For Each item In lstEffects.Items
                FixEffects.Add(item)
            Next
        End If

        'This stores any notes written about the fixture
        FixNotes = rtbNotes.Text

        Me.Hide()
        frmAddFix3.Show()
    End Sub

    Private Sub btnColourImage_Click(sender As Object, e As EventArgs) Handles btnColourImage.Click
        'This calls the procedure that adds images to datagridviews for dgdColours
        AddImageGridView("colour")
    End Sub

    Private Sub btnGoboImage_Click(sender As Object, e As EventArgs) Handles btnGoboImage.Click
        'This calls the procedure that adds images to datagridviews for dgdGobos
        AddImageGridView("gobo")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'This cancel the information entry process after confirming with the user
        Dim response As Integer
        response = MsgBox("Are you sure you want to cancel? All information for this fixture will be lost.", 36, "Cancel?")
        If response = 6 Then
            Me.Hide()
        End If
    End Sub

    Private Sub btnColourRemove_Click(sender As Object, e As EventArgs) Handles btnColourRemove.Click
        'This is for removing entries in dgdColours

        '### THIS ONLY REMOVES THE LAST CELL ###
        Try
            If TypeOf dgdColours.Rows(colourvertical).Cells(colourhorizontal - 1).Value Is Image Then
                dgdColours.Rows(colourvertical).Cells(colourhorizontal - 1) = New DataGridViewTextBoxCell With {
                    .Value = String.Empty
                }
                If colourhorizontal = 1 Then
                    dgdColours.Rows.RemoveAt(colourvertical)
                    colourvertical -= 1
                    colourhorizontal = 3
                Else
                    colourhorizontal -= 1
                End If
            Else
                dgdColours.Rows(colourvertical).Cells(colourhorizontal - 1).Value = String.Empty
                If colourhorizontal = 1 Then
                    dgdColours.Rows.RemoveAt(colourvertical)
                    colourvertical -= 1
                    colourhorizontal = 3
                Else
                    colourhorizontal -= 1
                End If
            End If
        Catch ex As Exception
            If TypeOf ex Is ArgumentOutOfRangeException Then
                MsgBox("There is nothing to remove.")
            Else
                MsgBox(ex.Message)
            End If
        End Try
    End Sub

    Private Sub btnGoboRemove_Click(sender As Object, e As EventArgs) Handles btnGoboRemove.Click
        'This is for removing entries in dgdGobos

        '### THIS ONLY REMOVES THE LAST CELL ###
        Try
            If TypeOf dgdGobos.Rows(gobovertical).Cells(gobohorizontal - 1).Value Is Image Then
                dgdGobos.Rows(gobovertical).Cells(gobohorizontal - 1) = New DataGridViewTextBoxCell With {
                    .Value = String.Empty
                }
                If gobohorizontal = 1 Then
                    dgdGobos.Rows.RemoveAt(gobovertical)
                    gobovertical -= 1
                    gobohorizontal = 3
                Else
                    gobohorizontal -= 1
                End If
            Else
                dgdGobos.Rows(gobovertical).Cells(gobohorizontal - 1).Value = String.Empty
                If gobohorizontal = 1 Then
                    dgdGobos.Rows.RemoveAt(gobovertical)
                    gobovertical -= 1
                    gobohorizontal = 3
                Else
                    gobohorizontal -= 1
                End If
            End If
        Catch ex As Exception
            If TypeOf ex Is ArgumentOutOfRangeException Then
                MsgBox("There is nothing to remove.")
            Else
                MsgBox(ex.Message)
            End If
        End Try
    End Sub


    Private Sub txtControl_KeyUp(sender As Object, e As KeyEventArgs) Handles txtControl.KeyUp
        'This acts as manual "accept button" when entering data in txtControl
        If e.KeyCode = Keys.Enter Then
            btnAddControl.PerformClick()
        End If
    End Sub

    Private Sub txtEffects_KeyUp(sender As Object, e As KeyEventArgs) Handles txtEffects.KeyUp
        'This acts as manual "accept button" when entering data in txtEffects
        If e.KeyCode = Keys.Enter Then
            btnAddEffect.PerformClick()
        End If
    End Sub

    Function ImageToBase64(ByRef img As Image)
        'This function converts images to base64strings to be stored later

        '### THIS METHOD OF STORAGE THAT THIS IS USED FOR IS VERY MEMORY INTENSIVE ###

        Dim format As Imaging.ImageFormat = img.RawFormat
        Using ms As New MemoryStream()
            img.Save(ms, format)
            Dim imagebytes As Byte() = ms.ToArray()
            Dim base64string As String = Convert.ToBase64String(imagebytes)
            Return base64string
        End Using
    End Function

    Private Sub frmAddFix2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'This clears all temporary fixture info lists
        FixControl.Clear()
        FixEffects.Clear()
        FixGoboDataType.Clear()
        FixColourDataType.Clear()
        FixGobos.Clear()
        FixColours.Clear()
    End Sub
End Class