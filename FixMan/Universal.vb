Imports System.IO
Imports System.Xml

Module Universal
    'General login and init variables
    Public currentuser, currentstoreroom, currentevent As String

    'User level permissions variables
    Public InventoryPrivelige, EventPrivelige, UserPrivelige As String

    'Selected fixture variable for frmFixInfo
    Public selectedfixture As String

    'Add fixture variables
    Public FixImage As String

    Public FixManufacturer, FixModel, FixSource, FixType, FixOptical As String
    Public FixColourTemp, FixTotalPowerDraw As Integer
    Public FixControl, FixEffects, FixFiles, FixGoboDataType, FixColourDataType, FixGobos, FixColours As New List(Of String)

    Public FixNotes As String

    Public Structure BeamAngleInfo
        Public FixBeamMin As Integer
        Public FixBeamMax As Integer
        Public FixBeamAuto As Boolean
    End Structure

    Public FixBeamAngle As BeamAngleInfo


    Public Sub AddToStoreroom(ByRef TypeFile As String, ByRef Qty As Integer)
        'This sub is used to add the information from a fixture info file into frmDatabase.dgdStoreroom
        Try
            Dim file As New XmlDocument()
            file.Load(TypeFile)
            Dim usernodes As XmlNodeList = file.DocumentElement.SelectNodes("/Root")
            frmDatabase.dgdStoreroom.Rows.Add(Base64ToImage(file.DocumentElement.ChildNodes(0).ChildNodes(2).InnerText), file.DocumentElement.ChildNodes(0).ChildNodes(0).InnerText, file.DocumentElement.ChildNodes(0).ChildNodes(1).InnerText, file.DocumentElement.ChildNodes(0).ChildNodes(4).InnerText, file.DocumentElement.ChildNodes(0).ChildNodes(3).InnerText, file.DocumentElement.ChildNodes(0).ChildNodes(5).InnerText, file.DocumentElement.ChildNodes(0).ChildNodes(7).InnerText, Qty)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Function Base64ToImage(ByVal base64string As String) As System.Drawing.Image
        'This function was published as a code snippet to snipplr.com by mracoker on 02/01/2010

        'Setup image and get data stream together
        Dim img As System.Drawing.Image
        Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream
        Dim b64 As String = base64string.Replace(" ", "+")
        Dim b() As Byte

        'Converts the base64 encoded msg to image data
        b = Convert.FromBase64String(b64)
        MS = New System.IO.MemoryStream(b)

        'creates image
        img = System.Drawing.Image.FromStream(MS)

        Return img
    End Function
End Module
