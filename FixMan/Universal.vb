Module Universal
    'General login and init variables
    Public currentuser, currentstoreroom, currentevent As String

    'User level permissions variables
    Public InventoryPrivelidge, TeamPrivelidge, FixSchedulePrivelidge, FilePrivelidge As String

    'Add fixture variables
    Public FixImage, FixManufacturer, FixModel, FixSource, FixType, FixOptical As String
    Public FixColourTemp, FixTotalPowerDraw As Integer
    Public FixControl, FixEffects, FixFiles As New List(Of String)



    Public FixNotes As String



    Public Structure BeamAngleInfo
        Public FixBeamMin As Integer
        Public FixBeamMax As Integer
        Public FixBeamAuto As Boolean
    End Structure

    Public FixBeamAngle As BeamAngleInfo

End Module
