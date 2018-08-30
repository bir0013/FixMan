Imports System.Xml
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
        Next

        '### THIS IS WHEN ALL FIXTURE INFO WILL BE COMITTED TO FILE ###

        Dim newfile As New XmlTextWriter(Application.StartupPath & "\Fixtures\" & FixManufacturer & " " & FixModel & ".xml", System.Text.Encoding.UTF8)
        newfile.WriteStartDocument()
        newfile.WriteStartElement("Root")
        newfile.Close()

        Dim fixfile = XDocument.Load(Application.StartupPath & "\Fixtures\" & FixManufacturer & " " & FixModel & ".xml")
        Dim fixinfo = New XElement("Fixture",
                                   New XElement("Manufacturer", FixManufacturer),
                                   New XElement("Model", FixModel),
                                   New XElement("Image", FixImage),
                                   New XElement("Type", FixType),
                                   New XElement("Source", FixSource),
                                   New XElement("Optical", FixOptical),
                                   New XElement("SourceColourTemp", FixColourTemp),
                                   New XElement("TotalPowerDraw", FixTotalPowerDraw),
                                   New XElement("Control"),
                                   New XElement("Effects"),
                                   New XElement("ColourDataType"),
                                   New XElement("GoboDataType"),
                                   New XElement("Files"),
                                    New XElement("Beam"),
                                                New XElement("MinAngle", FixBeamAngle.FixBeamMin),
                                                New XElement("MaxAngle", FixBeamAngle.FixBeamMax),
                                                New XElement("IsAutomatic", FixBeamAngle.FixBeamAuto),
                                    New XElement("Notes", FixNotes),
                                    New XElement("Colours"),
                                    New XElement("Gobos"),
                                    New XElement("IsColourMix", FixColourMix))

        fixfile.Element("Root").Add(fixinfo)

        For Each x In FixControl
            fixfile.Element("Root").Element("Fixture").Element("Control").Add(New XElement("Protocol", x))
        Next
        For Each x In FixEffects
            fixfile.Element("Root").Element("Fixture").Element("Effects").Add(New XElement("Effect", x))
        Next
        For Each x In FixColourDataType
            fixfile.Element("Root").Element("Fixture").Element("ColourDataType").Add(New XElement("Type", x))
        Next
        For Each x In FixGoboDataType
            fixfile.Element("Root").Element("Fixture").Element("GoboDataType").Add(New XElement("Type", x))
        Next
        For Each x In FixFiles
            fixfile.Element("Root").Element("Fixture").Element("Files").Add(New XElement("File", x))
        Next
        For Each x In FixColours
            fixfile.Element("Root").Element("Fixture").Element("Colours").Add(New XElement("Colour", x))
        Next
        For Each x In FixGobos
            fixfile.Element("Root").Element("Fixture").Element("Gobos").Add(New XElement("Gobo", x))
        Next

        fixfile.Save(Application.StartupPath & "\Fixtures\" & FixManufacturer & " " & FixModel & ".xml")

        Dim Valid As Boolean
        Dim quantity As String

        While Valid = False
            quantity = InputBox("How many of this fixture do you have?")
            If IsNumeric(quantity) Then
                Valid = True
            Else
                Valid = False
                'put a msgbox here if you like
            End If
        End While

        AddToStoreroom(Application.StartupPath & "\Fixtures\" & FixManufacturer & " " & FixModel & ".xml", quantity)

        frmAddFix2.Close()
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim response As Integer
        response = MsgBox("Are you sure you want to cancel? All information for this fixture will be lost.", 36, "Cancel?")
        If response = 6 Then
            frmAddFix2.Close()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frmAddFix2.Show()
    End Sub
End Class