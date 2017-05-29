Public Class vFormato04
    Dim f04_id, f04_responsable_id, f04_turno_id, f04_tipocubicacion_id, f04_f02_id, f04_pro_id As Integer
    Dim f04_fecha As Date
    Dim f04_certificada, f04_seguimiento As Boolean
    Dim f04_nro, f04_observacion, f04_ordenproduccion, f04_creacion, f04_tipoconteo, f04_periodo As String
    Public Property gf04_id
        Get
            Return f04_id
        End Get
        Set(ByVal value)
            f04_id = value
        End Set
    End Property
    Public Property gf04_fecha
        Get
            Return f04_fecha
        End Get
        Set(ByVal value)
            f04_fecha = value
        End Set
    End Property
    Public Property gf04_certificada
        Get
            Return f04_certificada
        End Get
        Set(ByVal value)
            f04_certificada = value
        End Set
    End Property
    Public Property gf04_nro
        Get
            Return f04_nro
        End Get
        Set(ByVal value)
            f04_nro = value
        End Set
    End Property
    Public Property gf04_creacion
        Get
            Return f04_creacion
        End Get
        Set(ByVal value)
            f04_creacion = value
        End Set
    End Property
    Public Property gf04_tipoconteo
        Get
            Return f04_tipoconteo
        End Get
        Set(ByVal value)
            f04_tipoconteo = value
        End Set
    End Property
    Public Property gf04_tipocubicacion_id
        Get
            Return f04_tipocubicacion_id
        End Get
        Set(ByVal value)
            f04_tipocubicacion_id = value
        End Set
    End Property
    Public Property gf04_turno_id
        Get
            Return f04_turno_id
        End Get
        Set(ByVal value)
            f04_turno_id = value
        End Set
    End Property
    Public Property gf04_responsable_id
        Get
            Return f04_responsable_id
        End Get
        Set(ByVal value)
            f04_responsable_id = value
        End Set
    End Property
    Public Property gf04_F02_id
        Get
            Return f04_f02_id
        End Get
        Set(ByVal value)
            f04_f02_id = value
        End Set
    End Property
    Public Property gf04_ordenproduccion
        Get
            Return f04_ordenproduccion
        End Get
        Set(ByVal value)
            f04_ordenproduccion = value
        End Set
    End Property
    Public Property gf04_observacion
        Get
            Return f04_observacion
        End Get
        Set(ByVal value)
            f04_observacion = value
        End Set
    End Property
    Public Property gf04_pro_id
        Get
            Return f04_pro_id
        End Get
        Set(ByVal value)
            f04_pro_id = value
        End Set
    End Property
    Public Property gf04_periodo
        Get
            Return f04_periodo
        End Get
        Set(ByVal value)
            f04_periodo = value
        End Set
    End Property
    Public Property gf04_seguimiento
        Get
            Return f04_seguimiento
        End Get
        Set(ByVal value)
            f04_seguimiento = value
        End Set
    End Property
    Public Sub New()
        'Constructor vacio
    End Sub
    Public Sub New(ByVal f04_id As Integer, ByVal f04_fecha As Date, ByVal f04_certificada As Boolean, _
                   ByVal f04_nro As String, ByVal f04_creacion As String, ByVal f04_tipoconteo As String, _
                   ByVal f04_tipocubicacion_id As Integer, ByVal f04_turno_id As Integer, ByVal f04_f02_id As Integer, _
                   ByVal f04_responsable_id As Integer, ByVal f04_ordenproduccion As String, ByVal f04_observacion As String)

        gf04_id = f04_id
        gf04_fecha = f04_fecha
        gf04_certificada = f04_certificada
        gf04_nro = f04_nro
        gf04_creacion = f04_creacion
        gf04_tipoconteo = f04_tipoconteo
        gf04_tipocubicacion_id = f04_tipocubicacion_id
        gf04_turno_id = f04_turno_id
        gf04_responsable_id = f04_responsable_id
        gf04_ordenproduccion = f04_ordenproduccion
        gf04_observacion = f04_observacion
        gf04_F02_id = f04_f02_id

    End Sub
End Class
