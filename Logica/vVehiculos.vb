Public Class vVehiculos
    Dim vehid, vehemtid As Integer
    Dim vehmarca, vtipovehic, vehplaca, vehnroinscripcion, vehtipo As String

    Public Property gvehid
        Get
            Return vehid
        End Get
        Set(ByVal value)
            vehid = value
        End Set
    End Property

    Public Property gvehemtid
        Get
            Return vehemtid
        End Get
        Set(ByVal value)
            vehemtid = value
        End Set
    End Property
    Public Property gvehmarca
        Get
            Return vehmarca
        End Get
        Set(ByVal value)
            vehmarca = value
        End Set
    End Property
    Public Property gvtipovehic
        Get
            Return vtipovehic
        End Get
        Set(ByVal value)
            vtipovehic = value
        End Set
    End Property
    Public Property gvehplaca
        Get
            Return vehplaca
        End Get
        Set(ByVal value)
            vehplaca = value
        End Set
    End Property
    Public Property gvehnroinscripcion
        Get
            Return vehnroinscripcion
        End Get
        Set(ByVal value)
            vehnroinscripcion = value
        End Set
    End Property
    Public Property gvehtipo
        Get
            Return vehtipo
        End Get
        Set(ByVal value)
            vehtipo = value
        End Set
    End Property

    Public Sub New()
        'Constructor vacio
    End Sub
    Public Sub New(ByVal vehid As Integer, ByVal vehemtid As Integer, ByVal vehmarca As String, ByVal vtipovehic As String, ByVal vehplaca As String, ByVal vehnroinscripcion As String, ByVal vehtipo As String)

        gvehid = vehid
        gvehmarca = vehmarca
        gvtipovehic = vtipovehic
        gvehplaca = vehplaca
        gvehnroinscripcion = vehnroinscripcion
        gvehtipo = vehtipo

    End Sub
End Class
