Public Class vFormato04_det
    Dim f04d_id, f04d_f04_id, f04d_producto_id, f04d_nropiezasp, f04d_nropiezass As Integer
    Dim f04d_cut, F04d_codigo, f04d_especie, f04d_calidad, f04d_observacion, f04d_codind As String
    Dim f04d_espesor, f04d_ancho, f04d_largo, f04d_volptp, f04d_volpts As Decimal
    Public Property gf04d_id
        Get
            Return f04d_id
        End Get
        Set(ByVal value)
            f04d_id = value
        End Set
    End Property
    Public Property gf04d_f04_id
        Get
            Return f04d_f04_id
        End Get
        Set(ByVal value)
            f04d_f04_id = value
        End Set
    End Property
    Public Property gf04d_producto_id
        Get
            Return f04d_producto_id
        End Get
        Set(ByVal value)
            f04d_producto_id = value
        End Set
    End Property
    Public Property gf04d_nropiezasp
        Get
            Return f04d_nropiezasp
        End Get
        Set(ByVal value)
            f04d_nropiezasp = value
        End Set
    End Property
    Public Property gf04d_nropiezass
        Get
            Return f04d_nropiezass
        End Get
        Set(ByVal value)
            f04d_nropiezass = value
        End Set
    End Property
    Public Property gf04d_cut
        Get
            Return f04d_cut
        End Get
        Set(ByVal value)
            f04d_cut = value
        End Set
    End Property
    Public Property gf04d_codigo
        Get
            Return F04d_codigo
        End Get
        Set(ByVal value)
            F04d_codigo = value
        End Set
    End Property
    Public Property gf04d_especie
        Get
            Return f04d_especie
        End Get
        Set(ByVal value)
            f04d_especie = value
        End Set
    End Property
    Public Property gf04d_calidad
        Get
            Return f04d_calidad
        End Get
        Set(ByVal value)
            f04d_calidad = value
        End Set
    End Property
    Public Property gf04d_espesor
        Get
            Return f04d_espesor
        End Get
        Set(ByVal value)
            f04d_espesor = value
        End Set
    End Property
    Public Property gf04d_ancho
        Get
            Return f04d_ancho
        End Get
        Set(ByVal value)
            f04d_ancho = value
        End Set
    End Property
    Public Property gf04d_largo
        Get
            Return f04d_largo
        End Get
        Set(ByVal value)
            f04d_largo = value
        End Set
    End Property
    Public Property gf04d_volptp
        Get
            Return f04d_volptp
        End Get
        Set(ByVal value)
            f04d_volptp = value
        End Set
    End Property
    Public Property gf04d_volpts
        Get
            Return f04d_volpts
        End Get
        Set(ByVal value)
            f04d_volpts = value
        End Set
    End Property
    Public Property gf04d_observacion
        Get
            Return f04d_observacion
        End Get
        Set(ByVal value)
            f04d_observacion = value
        End Set
    End Property
    Public Property gf04d_codind
        Get
            Return f04d_codind
        End Get
        Set(ByVal value)
            f04d_codind = value
        End Set
    End Property
    
    Public Sub New()
        'Constructor vacio
    End Sub
    Public Sub New(ByVal f04d_id As Integer, ByVal f04d_f04_id As Integer, ByVal f04d_cut As String, ByVal f04d_codigo As String, _
                   ByVal f04d_calidad As String, ByVal f04d_especie As String, ByVal f04d_producto_id As Integer, ByVal f04d_nropiezasp As Integer, _
                   ByVal f04d_nropiezass As Integer, ByVal f04d_espesor As Decimal, ByVal f04d_ancho As Decimal, ByVal f04d_largo As Decimal, _
                   ByVal f04d_volptp As Decimal, ByVal f04d_volpts As Decimal, ByVal f04d_observacion As String)

        gf04d_id = f04d_id
        gf04d_f04_id = f04d_f04_id
        gf04d_producto_id = f04d_producto_id
        gf04d_codigo = f04d_codigo
        gf04d_cut = f04d_cut
        gf04d_especie = f04d_especie
        gf04d_espesor = f04d_espesor
        gf04d_ancho = f04d_ancho
        gf04d_largo = f04d_largo
        gf04d_volptp = f04d_volptp
        gf04d_volpts = f04d_volpts
        gf04d_calidad = f04d_calidad
        gf04d_nropiezasp = f04d_nropiezasp
        gf04d_nropiezass = f04d_nropiezass
        gf04d_observacion = f04d_observacion

    End Sub
End Class
