Public Class Reporte02
    Public _titular As String
    Public _persona As String
    'Public _poa As String
    Public _detalle As formato01_det
    Public _cabecera As formato01
    Public _zafra As Integer
    Public _poa As String
    Public _aserrio As String

    Public Property Cabecera As formato01
        Get
            Return _cabecera
        End Get
        Set(ByVal value As formato01)
            _cabecera = value
        End Set
    End Property
    Public Property Detalle As formato01_det
        Get
            Return _detalle
        End Get
        Set(ByVal value As formato01_det)
            _detalle = value
        End Set
    End Property
    Public Property Titular As String
        Get
            Return _titular
        End Get
        Set(ByVal value As String)
            _titular = value
        End Set
    End Property
    'Public Property Destinatario As String
    '    Get
    '        Return _destinatario
    '    End Get
    '    Set(ByVal value As String)
    '        _destinatario = value
    '    End Set
    'End Property
    Public Property Persona As String
        Get
            Return _persona
        End Get
        Set(ByVal value As String)
            _persona = value
        End Set
    End Property

    Public Property Zafra As Integer
        Get
            Return _zafra
        End Get
        Set(ByVal value As Integer)
            _zafra = value
        End Set
    End Property

    Public Property POA As String
        Get
            Return _poa
        End Get
        Set(ByVal value As String)
            _poa = value
        End Set
    End Property

    Public Property Aserrio As String
        Get
            Return _aserrio
        End Get
        Set(ByVal value As String)
            _aserrio = value
        End Set
    End Property
    'Public Property Poa As String
    '    Get
    '        Return _poa
    '    End Get
    '    Set(ByVal value As String)
    '        _poa = value
    '    End Set
    'End Property

    'Public Sub New(ByVal titular As String, ByVal destinatario As String, ByVal propietario As String, ByVal poa As String, ByVal detalle As listatrozasd, ByVal cabecera As listatrozasc)
    '    Me.Cabecera = cabecera
    '    Me.Detalle = detalle
    '    Me.Titular = titular
    '    Me.Destinatario = destinatario
    '    Me.Propietario = propietario
    '    Me.Poa = poa
    'End Sub
End Class
