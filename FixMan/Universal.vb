Module Universal
    'General login and init variables
    Public currentuser, currentstoreroom, currentevent As String

    'User level permissions variables
    Public InventoryPrivelige, EventPrivelige, UserPrivelige As String

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

End Module
