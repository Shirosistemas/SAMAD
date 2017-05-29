Public Class vListatrozasd
    Dim ltdid, ltd_ltid As Integer
    Dim ltdespecie, ltdcodificacion, ltdautogenerado, ltdnrolistatrozas As String
    Dim ltdd1, ltdd2, ltdd3, ltdvolm3 As Decimal
    Public Property gltdid
        Get
            Return ltdid
        End Get
        Set(ByVal value)
            ltdid = value
        End Set
    End Property
    Public Property gltd_ltid
        Get
            Return ltd_ltid
        End Get
        Set(ByVal value)
            ltd_ltid = value
        End Set
    End Property
    Public Property gltdespecie
        Get
            Return ltdespecie
        End Get
        Set(ByVal value)
            ltdespecie = value
        End Set
    End Property
    Public Property gltdcodificacion
        Get
            Return ltdcodificacion
        End Get
        Set(ByVal value)
            ltdcodificacion = value
        End Set
    End Property
    Public Property gltdd1
        Get
            Return ltdd1
        End Get
        Set(ByVal value)
            ltdd1 = value
        End Set
    End Property
    Public Property gltdd2
        Get
            Return ltdd2
        End Get
        Set(ByVal value)
            ltdd2 = value
        End Set
    End Property
    Public Property gltdd3
        Get
            Return ltdd3
        End Get
        Set(ByVal value)
            ltdd3 = value
        End Set
    End Property
    Public Property gltdvolm3
        Get
            Return ltdvolm3
        End Get
        Set(ByVal value)
            ltdvolm3 = value
        End Set
    End Property
    Public Property gltdautogenerado
        Get
            Return ltdautogenerado
        End Get
        Set(ByVal value)
            ltdautogenerado = value
        End Set
    End Property
    Public Property gltdnrolistatrozas
        Get
            Return ltdnrolistatrozas
        End Get
        Set(ByVal value)
            ltdnrolistatrozas = value
        End Set
    End Property
    Public Sub New()
        'Constructor vacio
    End Sub
    Public Sub New(ByVal ltdid As Integer, ByVal ltd_ltid As Integer, ByVal ltdespecie As String, _
                   ByVal ltdcodificacion As String, ByVal ltdd1 As Decimal, ByVal ltdd2 As Decimal, _
                   ByVal ltdd3 As Decimal, ByVal ltdvolm3 As Decimal, ByVal ltdautogenerado As String, ByVal ltdnrolistatrozas As String)

        gltdid = ltdid
        gltd_ltid = ltd_ltid
        gltdespecie = ltdespecie
        gltdcodificacion = ltdcodificacion
        gltdd1 = ltdd1
        gltdd2 = ltdd2
        gltdd3 = ltdd3
        gltdvolm3 = ltdvolm3
        gltdautogenerado = ltdautogenerado
        gltdnrolistatrozas = ltdnrolistatrozas

    End Sub
End Class
