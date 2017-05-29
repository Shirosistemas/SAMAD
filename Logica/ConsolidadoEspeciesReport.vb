Public Class ConsolidadoEspeciesReport
    Public _titular As String
    Public _especie As String
    Public _trozas As Integer
    Public _volumen As Decimal

    Public Property Titular As String
        Get
            Return _titular
        End Get
        Set(ByVal value As String)
            _titular = value
        End Set
    End Property
    Public Property Especie As String
        Get
            Return _especie
        End Get
        Set(ByVal value As String)
            _especie = value
        End Set
    End Property
    Public Property Trozas As Integer
        Get
            Return _trozas
        End Get
        Set(ByVal value As Integer)
            _trozas = value
        End Set
    End Property
    Public Property Volumen As Decimal
        Get
            Return _volumen
        End Get
        Set(ByVal value As Decimal)
            _volumen = value
        End Set
    End Property

End Class
