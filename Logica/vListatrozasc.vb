Public Class vListatrozasc

    Dim lt_id, lt_titularid, lt_propietarioid, lt_transporteid, lt_conductorid, lt_destinatarioid, lt_contratoid, lt_poaid As Integer
    Dim lt_fecha, lt_fecha_ven As Date
    Dim lt_nrolista, lt_zafra, lt_observacion, lt_deffs, lt_unidad, lt_Ubigeo, lt_tipo_cv, lt_nro_Cv, lt_nroGuiaRem As String
    Dim lt_tipodimension As Boolean

    Public Property gltid
        Get
            Return lt_id
        End Get
        Set(ByVal value)
            lt_id = value
        End Set
    End Property

    Public Property glttitularid
        Get
            Return lt_titularid
        End Get
        Set(ByVal value)
            lt_titularid = value
        End Set
    End Property

    Public Property gltcontratoid
        Get
            Return lt_contratoid
        End Get
        Set(ByVal value)
            lt_contratoid = value
        End Set
    End Property

    Public Property gltpoaid
        Get
            Return lt_poaid
        End Get
        Set(ByVal value)
            lt_poaid = value
        End Set
    End Property

    Public Property gltpropietarioid
        Get
            Return lt_propietarioid
        End Get
        Set(ByVal value)
            lt_propietarioid = value
        End Set
    End Property

    Public Property gltransporteid
        Get
            Return lt_transporteid
        End Get
        Set(ByVal value)
            lt_transporteid = value
        End Set
    End Property

    Public Property gltconductorid
        Get
            Return lt_conductorid
        End Get
        Set(ByVal value)
            lt_conductorid = value
        End Set
    End Property

    Public Property gltdestinatario
        Get
            Return lt_destinatarioid
        End Get
        Set(ByVal value)
            lt_destinatarioid = value
        End Set
    End Property

    Public Property gltnrolista
        Get
            Return lt_nrolista
        End Get
        Set(ByVal value)
            lt_nrolista = value
        End Set
    End Property

    Public Property gltfecha
        Get
            Return lt_fecha
        End Get
        Set(ByVal value)
            lt_fecha = value
        End Set
    End Property
    Public Property gltfecha_ven
        Get
            Return lt_fecha_ven
        End Get
        Set(ByVal value)
            lt_fecha_ven = value
        End Set
    End Property
    Public Property gltobservacion
        Get
            Return lt_observacion
        End Get
        Set(ByVal value)
            lt_observacion = value
        End Set
    End Property

    Public Property glttipodimension
        Get
            Return lt_tipodimension
        End Get
        Set(ByVal value)
            lt_tipodimension = value
        End Set
    End Property
    Public Property gltubigeo
        Get
            Return lt_Ubigeo
        End Get
        Set(ByVal value)
            lt_Ubigeo = value
        End Set
    End Property
    Public Property gltTipoCv
        Get
            Return lt_tipo_cv
        End Get
        Set(ByVal value)
            lt_tipo_cv = value
        End Set
    End Property
    Public Property gltnrocv
        Get
            Return lt_nro_Cv
        End Get
        Set(ByVal value)
            lt_nro_Cv = value
        End Set
    End Property
    Public Property gltnroguia
        Get
            Return lt_nroGuiaRem
        End Get
        Set(ByVal value)
            lt_nroGuiaRem = value
        End Set
    End Property
    Public Property gdeffs
        Get
            Return lt_deffs
        End Get
        Set(ByVal value)
            lt_deffs = value
        End Set
    End Property
    Public Property gltzafra
        Get
            Return lt_zafra
        End Get
        Set(ByVal value)
            lt_zafra = value
        End Set
    End Property

    Public Property fldUnidad
        Get
            Return lt_unidad
        End Get
        Set(value)
            lt_unidad = value
        End Set
    End Property

    Public Sub New()
        'Contructor vacio
    End Sub
    Public Sub New(ByVal lt_id As Integer, ByVal lt_titularid As Integer, ByVal lt_propietarioid As Integer, _
                   ByVal lt_transporteid As Integer, ByVal lt_conductorid As Integer, ByVal lt_destinatarioid As Integer, _
                   ByVal lt_nrolista As String, ByVal lt_fecha As Date, ByVal lt_fecha_ven As Date, ByVal lt_observacion As String, _
                   ByVal lt_contratoid As Integer, ByVal lt_poaid As Integer, ByVal lt_tipodimension As Boolean, ByVal lt_deffs As String, lt_unidad As String, _
                   ByVal lt_tipo_cv As String, ByVal lt_nro_cv As String, ByVal lt_ubigeo As String, ByVal lt_NroGuiaRem As String, ByVal lt_zafra As String)

        gltid = lt_id
        glttitularid = lt_titularid
        gltpropietarioid = lt_propietarioid
        gltcontratoid = lt_contratoid
        gltpoaid = lt_poaid
        gltransporteid = lt_transporteid
        gltconductorid = lt_conductorid
        gltdestinatario = lt_destinatarioid
        gltnrolista = lt_nrolista
        gltfecha = lt_fecha
        gltobservacion = lt_observacion
        glttipodimension = lt_tipodimension
        gdeffs = lt_deffs
        gltfecha_ven = lt_fecha_ven
        gltubigeo = lt_ubigeo
        gltTipoCv = lt_tipo_cv
        gltnrocv = lt_nro_cv
        gltnroguia = lt_NroGuiaRem
        gltzafra = lt_zafra
        fldUnidad = lt_unidad
    End Sub
End Class
