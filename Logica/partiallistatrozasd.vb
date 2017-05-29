Partial Public Class reporte01
    Public _titular As String
    Public _destinatario As String
    Public _propietario As String
    Public _poa As String
    Public _detalle As listatrozasd
    Public _cabecera As listatrozasc

    Public Property Cabecera As listatrozasc
        Get
            Return _cabecera
        End Get
        Set(ByVal value As listatrozasc)
            _cabecera = value
        End Set
    End Property
    Public Property Detalle As listatrozasd
        Get
            Return _detalle
        End Get
        Set(ByVal value As listatrozasd)
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
    Public Property Destinatario As String
        Get
            Return _destinatario
        End Get
        Set(ByVal value As String)
            _destinatario = value
        End Set
    End Property
    Public Property Propietario As String
        Get
            Return _propietario
        End Get
        Set(ByVal value As String)
            _propietario = value
        End Set
    End Property
    Public Property Poa As String
        Get
            Return _poa
        End Get
        Set(ByVal value As String)
            _poa = value
        End Set
    End Property

    'Public Sub New(ByVal titular As String, ByVal destinatario As String, ByVal propietario As String, ByVal poa As String, ByVal detalle As listatrozasd, ByVal cabecera As listatrozasc)
    '    Me.Cabecera = cabecera
    '    Me.Detalle = detalle
    '    Me.Titular = titular
    '    Me.Destinatario = destinatario
    '    Me.Propietario = propietario
    '    Me.Poa = poa
    'End Sub

End Class
