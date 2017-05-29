Public Class ReporteDespachoDet

    Public _despachodet As despacho_det

    Public Property CabeceraDet() As despacho_det
        Get
            Return _despachodet
        End Get
        Set(ByVal value As despacho_det)
            _despachodet = value
        End Set
    End Property

    Public _despachoCat As despacho_catalogo
    Public Property DetalleCat() As despacho_catalogo
        Get
            Return _despachoCat
        End Get
        Set(ByVal value As despacho_catalogo)
            _despachoCat = value
        End Set
    End Property

End Class
