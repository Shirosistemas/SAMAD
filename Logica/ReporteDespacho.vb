Public Class ReporteDespacho
    'Public _titular As String
    'Public _persona As String
    'Public _poa As String
    Public _detalle As despacho_det
    Public _cabecera As vw_listadodespachocabecera
    'Public _zafra As Integer
    'Public _poa As String
    'Public _aserrio As String

    Public Property Cabecera() As vw_listadodespachocabecera
        Get
            Return _cabecera
        End Get
        Set(ByVal value As vw_listadodespachocabecera)
            _cabecera = value
        End Set
    End Property

    Public Property Detalle() As despacho_det
        Get
            Return _detalle
        End Get
        Set(ByVal value As despacho_det)
            _detalle = value
        End Set
    End Property

    'Public _detallecat As despacho_catalogo
    'Public Property Catalogo() As despacho_catalogo
    '    Get
    '        Return _detallecat
    '    End Get
    '    Set(ByVal value As despacho_catalogo)
    '        _detallecat = value
    '    End Set
    'End Property




End Class
