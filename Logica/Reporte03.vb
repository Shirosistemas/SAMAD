Public Class Reporte03
    Public _aserrio As String
    Public _periodo As String
    Public _proceso As String
    Public _detalle As vw_mostrar_trozas_aserradas
    Public _cabecera As formato02

    Public Property Cabecera As formato02
        Get
            Return _cabecera
        End Get
        Set(ByVal value As formato02)
            _cabecera = value
        End Set
    End Property
    Public Property Detalle As vw_mostrar_trozas_aserradas
        Get
            Return _detalle
        End Get
        Set(ByVal value As vw_mostrar_trozas_aserradas)
            _detalle = value
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

    Public Property Periodo As String
        Get
            Return _periodo
        End Get
        Set(ByVal value As String)
            _periodo = value
        End Set
    End Property

    Public Property Proceso As String
        Get
            Return _proceso
        End Get
        Set(ByVal value As String)
            _proceso = value
        End Set
    End Property

   
End Class
