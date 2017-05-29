Public Class vFormato01
    Dim f01_id, f01_responsable, f01_titular As Integer
    Dim f01_fecha As Date
    Dim f01_certificada As Boolean
    Dim f01_nro, f01_observacion, f01_tipotraslado, f01_periodo As String
    Public Property gf01_id
        Get
            Return f01_id
        End Get
        Set(ByVal value)
            f01_id = value
        End Set
    End Property
    Public Property gf01_fecha
        Get
            Return f01_fecha
        End Get
        Set(ByVal value)
            f01_fecha = value
        End Set
    End Property
    Public Property gf01_certificada
        Get
            Return f01_certificada
        End Get
        Set(ByVal value)
            f01_certificada = value
        End Set
    End Property
    Public Property gf01_nro
        Get
            Return f01_nro
        End Get
        Set(ByVal value)
            f01_nro = value
        End Set
    End Property
    Public Property gf01_responsable
        Get
            Return f01_responsable
        End Get
        Set(ByVal value)
            f01_responsable = value
        End Set
    End Property
    Public Property gf01_observacion
        Get
            Return f01_observacion
        End Get
        Set(ByVal value)
            f01_observacion = value
        End Set
    End Property
    Public Property gf01_tipotraslado
        Get
            Return f01_tipotraslado
        End Get
        Set(ByVal value)
            f01_tipotraslado = value
        End Set
    End Property
    Public Property gf01_titular
        Get
            Return f01_titular
        End Get
        Set(ByVal value)
            f01_titular = value
        End Set
    End Property
    Public Property gf01_periodo
        Get
            Return f01_periodo
        End Get
        Set(ByVal value)
            f01_periodo = value
        End Set
    End Property
    Public Sub New()
        'Constructor vacio
    End Sub
    Public Sub New(ByVal f01_id As Integer, ByVal f01_fecha As Date, ByVal f01_certificada As Boolean, _
                   ByVal f01_nro As String, ByVal f01_responsable As Integer, ByVal f01_observacion As String, ByVal f01_tipotraslado As String, ByVal f01_titular As Integer, ByVal f01_periodo As String)

        gf01_id = f01_id
        gf01_fecha = f01_fecha
        gf01_certificada = f01_certificada
        gf01_nro = f01_nro
        gf01_responsable = f01_responsable
        gf01_tipotraslado = f01_tipotraslado
        gf01_observacion = f01_observacion
        gf01_titular = f01_titular
        gf01_periodo = f01_periodo
    End Sub
End Class
