Public Class Resumen_Trozas_AserradasReport
    Public _Especie As String
    Public _Aserradero As String
    Public _T_trozas As Integer
    Public _Vol_m3_Gtf, _Vol_m3_CA, _Vol_pt As Decimal
    Public Property Aserradero As String
        Get
            Return _Aserradero
        End Get
        Set(ByVal value As String)
            _Aserradero = value
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

    Public Property T_trozas As Integer
        Get
            Return _T_trozas
        End Get
        Set(ByVal value As Integer)
            _T_trozas = value
        End Set
    End Property
    Public Property Vol_m3_Gtf As Decimal
        Get
            Return _Vol_m3_Gtf
        End Get
        Set(ByVal value As Decimal)
            _Vol_m3_Gtf = value
        End Set
    End Property
    Public Property Vol_m3_CA As Decimal
        Get
            Return _Vol_m3_CA
        End Get
        Set(ByVal value As Decimal)
            _Vol_m3_CA = value
        End Set
    End Property
    Public Property Vol_pt As Decimal
        Get
            Return _Vol_pt
        End Get
        Set(ByVal value As Decimal)
            _Vol_pt = value
        End Set
    End Property
End Class
