Public Class vDespacho
    Dim desid, titularid, destinatarioid, propietarioid, transportistaid, vehiculoid, contratoid, periodo As Integer
    Dim fecha, fechaven As Date
    Dim nrodoc, ttrans, natest, canref, ubigeo, arffs, tipocv, nrocv, nroguiarem As String
    Dim monsolest, monsolcan As Decimal
    Public Property gdesid
        Get
            Return desid
        End Get
        Set(ByVal value)
            desid = value
        End Set
    End Property
    Public Property gubigeo
        Get
            Return ubigeo
        End Get
        Set(ByVal value)
            ubigeo = value
        End Set
    End Property
    Public Property garffs
        Get
            Return arffs
        End Get
        Set(ByVal value)
            arffs = value
        End Set
    End Property

    Public Property gperiodo
        Get
            Return periodo
        End Get
        Set(ByVal value)
            periodo = value
        End Set
    End Property
    Public Property gnrodoc
        Get
            Return nrodoc
        End Get
        Set(ByVal value)
            nrodoc = value
        End Set
    End Property
    Public Property gfecha
        Get
            Return fecha
        End Get
        Set(ByVal value)
            fecha = value
        End Set
    End Property
    Public Property gfechaven
        Get
            Return fechaven
        End Get
        Set(ByVal value)
            fechaven = value
        End Set
    End Property
    Public Property gtitularid
        Get
            Return titularid
        End Get
        Set(ByVal value)
            titularid = value
        End Set
    End Property
    Public Property gpropietarioid
        Get
            Return propietarioid
        End Get
        Set(ByVal value)
            propietarioid = value
        End Set
    End Property
    Public Property gtipocv
        Get
            Return tipocv
        End Get
        Set(ByVal value)
            tipocv = value
        End Set
    End Property
    Public Property gnrocv
        Get
            Return nrocv
        End Get
        Set(ByVal value)
            nrocv = value
        End Set
    End Property
    Public Property gnroguiarem
        Get
            Return nroguiarem
        End Get
        Set(ByVal value)
            nroguiarem = value
        End Set
    End Property
    Public Property gdestinatarioid
        Get
            Return destinatarioid
        End Get
        Set(ByVal value)
            destinatarioid = value
        End Set
    End Property
    Public Property gtransportistaid
        Get
            Return transportistaid
        End Get
        Set(ByVal value)
            transportistaid = value
        End Set
    End Property
    Public Property gvehiculoid
        Get
            Return vehiculoid
        End Get
        Set(ByVal value)
            vehiculoid = value
        End Set
    End Property
    Public Property gcontratoid
        Get
            Return contratoid
        End Get
        Set(ByVal value)
            contratoid = value
        End Set
    End Property
    Public Property tipTrans() As String
        Get
            Return ttrans
        End Get
        Set(ByVal value As String)
            ttrans = value
        End Set
    End Property
   

    Public Sub New()
        'Contructor vacio
    End Sub
    Public Sub New(ByVal desid As Integer, ByVal titularid As Integer, ByVal ubigeo As String, _
                   ByVal destinatarioid As Integer, ByVal propietarioid As Integer, ByVal transportistaid As Integer, ByVal periodo As Integer, _
                   ByVal vehiculoid As Integer, ByVal contratoid As Integer, ByVal nrodoc As String, ByVal fecha As Date, ByVal fechaven As Date, ByVal tipotranport As String, ByVal arffs As String, ByVal tipocv As String, ByVal nrocv As String, ByVal nroguiarem As String)

        gdesid = desid
        gubigeo = ubigeo
        garffs = arffs
        gtitularid = titularid
        gdestinatarioid = destinatarioid
        gpropietarioid = propietarioid
        gtipocv = tipocv
        gnrocv = nrocv
        gnroguiarem = nroguiarem
        gperiodo = periodo
        gtransportistaid = transportistaid
        gvehiculoid = vehiculoid
        gcontratoid = contratoid
        gfecha = fecha
        gfechaven = fechaven
        gnrodoc = nrodoc
        tipTrans = tipotranport
       

    End Sub
End Class
