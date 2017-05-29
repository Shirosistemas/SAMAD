Public Class vContratos
    Dim conid, conanno, conproid As Integer
    Dim condescripcion, conrecurso As String

    Public Property gconid
        Get
            Return conid
        End Get
        Set(ByVal value)
            conid = value
        End Set
    End Property

    Public Property gconanno
        Get
            Return conanno
        End Get
        Set(ByVal value)
            conanno = value
        End Set
    End Property
    Public Property gconproid
        Get
            Return conproid
        End Get
        Set(ByVal value)
            conproid = value
        End Set
    End Property
    Public Property gconrecurso
        Get
            Return conrecurso
        End Get
        Set(ByVal value)
            conrecurso = value
        End Set
    End Property
    Public Property gcondescripcion
        Get
            Return condescripcion
        End Get
        Set(ByVal value)
            condescripcion = value
        End Set
    End Property

    Public Sub New()
        'Constructor vacio
    End Sub

    Public Sub New(ByVal conid As Integer, ByVal conanno As Integer, ByVal conproid As Integer, ByVal condescripcion As String, ByVal conrecurso As String)

        gconid = conid
        gconanno = conanno
        gconproid = conproid
        gcondescripcion = condescripcion
        gconrecurso = conrecurso

    End Sub
End Class
