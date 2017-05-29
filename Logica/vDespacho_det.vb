Public Class vDespacho_det
    Dim desdid, desddesid, desdltid, piezas As Integer
    Dim nrogtf, producto, especie As String
    Dim volm3 As Decimal
    Public Property gdesdid
        Get
            Return desdid
        End Get
        Set(ByVal value)
            desdid = value
        End Set
    End Property
    Public Property gdesddesid
        Get
            Return desddesid
        End Get
        Set(ByVal value)
            desddesid = value
        End Set
    End Property
    Public Property gdesdltid
        Get
            Return desdltid
        End Get
        Set(ByVal value)
            desdltid = value
        End Set
    End Property
    Public Property gnrogtf
        Get
            Return nrogtf
        End Get
        Set(ByVal value)
            nrogtf = value
        End Set
    End Property
    Public Property gproducto
        Get
            Return producto
        End Get
        Set(ByVal value)
            producto = value
        End Set
    End Property
    Public Property gvolm3
        Get
            Return volm3
        End Get
        Set(ByVal value)
            volm3 = value
        End Set
    End Property
    Public Property gpiezas
        Get
            Return piezas
        End Get
        Set(ByVal value)
            piezas = value
        End Set
    End Property
    Public Property gespecie
        Get
            Return especie
        End Get
        Set(ByVal value)
            especie = value
        End Set
    End Property
    Public Sub New()
        'Contructor vacio
    End Sub
    Public Sub New(ByVal desdid As Integer, ByVal desddesid As Integer, ByVal piezas As Integer, ByVal producto As String, _
                   ByVal nrogtf As String, ByVal volm3 As Decimal, ByVal especie As String, ByVal desdltid As Integer)

        gdesdid = desdid
        gdesddesid = desddesid
        gnrogtf = nrogtf
        gpiezas = piezas
        gproducto = producto
        gvolm3 = volm3
        gespecie = especie
        gdesdltid = desdltid

    End Sub

End Class
