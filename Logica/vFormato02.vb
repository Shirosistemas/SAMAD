Public Class vFormato02
    Dim f02_id, f02_responsableid, f02_turnoid, f02_proc_id, f02_emp_id As Integer
    Dim f02_fecha As Date
    Dim f02_certificada As Boolean
    Dim f02_nrodoc, f02_observacion, f02_nroope, f02, f02_periodo As String

    Public Property gf02_id
        Get
            Return f02_id
        End Get
        Set(ByVal value)
            f02_id = value
        End Set
    End Property

    Public Property gf02_fecha
        Get
            Return f02_fecha
        End Get
        Set(ByVal value)
            f02_fecha = value
        End Set
    End Property

    Public Property gf02_certificada
        Get
            Return f02_certificada
        End Get
        Set(ByVal value)
            f02_certificada = value
        End Set
    End Property

    Public Property gf02_nrodoc
        Get
            Return f02_nrodoc
        End Get
        Set(ByVal value)
            f02_nrodoc = value
        End Set
    End Property

    Public Property gf02_responsableid
        Get
            Return f02_responsableid
        End Get
        Set(ByVal value)
            f02_responsableid = value
        End Set
    End Property

    Public Property gf02_turnoid
        Get
            Return f02_turnoid
        End Get
        Set(ByVal value)
            f02_turnoid = value
        End Set
    End Property

    Public Property gf02_observacion
        Get
            Return f02_observacion
        End Get
        Set(ByVal value)
            f02_observacion = value
        End Set
    End Property

    Public Property gf02_nroope
        Get
            Return f02_nroope
        End Get
        Set(ByVal value)
            f02_nroope = value
        End Set
    End Property

    Public Property gf02_proc_id
        Get
            Return f02_proc_id
        End Get
        Set(ByVal value)
            f02_proc_id = value
        End Set
    End Property

    Public Property gf02_periodo
        Get
            Return f02_periodo
        End Get
        Set(ByVal value)
            f02_periodo = value
        End Set
    End Property

    Public Property gf02_emp_id
        Get
            Return f02_emp_id
        End Get
        Set(value)
            f02_emp_id = value
        End Set
    End Property

    Public Sub New()
        'Constructor vacio
    End Sub

    Public Sub New(ByVal f02_id As Integer, ByVal f02_fecha As Date, ByVal f02_certificada As Boolean, ByVal f02_turnoid As Integer, _
                   ByVal f02_nrodoc As String, ByVal f02_responsableid As Integer, ByVal f02_observacion As String, ByVal f01_nroope As String, ByVal f02_proc_id As Integer, ByVal f01_periodo As String,
                   f02_emp_id As Integer)

        gf02_id = f02_id
        gf02_fecha = f02_fecha
        gf02_certificada = f02_certificada
        gf02_nrodoc = f02_nrodoc
        gf02_responsableid = f02_responsableid
        gf02_nroope = f02_nroope
        gf02_observacion = f02_observacion
        gf02_turnoid = f02_turnoid
        gf02_proc_id = f02_proc_id
        gf02_periodo = f02_periodo
        gf02_emp_id = f02_emp_id
    End Sub
End Class
