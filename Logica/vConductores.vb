Public Class vConductores
    Dim conid, conemtid As Integer
    Dim connomape, condni, connrolicencia As String

    Public Property gconid
        Get
            Return conid
        End Get
        Set(ByVal value)
            conid = value
        End Set
    End Property
    Public Property gconemtid
        Get
            Return conemtid
        End Get
        Set(ByVal value)
            conemtid = value
        End Set
    End Property
    Public Property gconnomape
        Get
            Return connomape
        End Get
        Set(ByVal value)
            connomape = value
        End Set
    End Property
    Public Property gconnrolicencia
        Get
            Return connrolicencia
        End Get
        Set(ByVal value)
            connrolicencia = value
        End Set
    End Property

    Public Property gcondni
        Get
            Return condni
        End Get
        Set(ByVal value)
            condni = value
        End Set
    End Property
    Public Sub New()
        'constructor vacio
    End Sub
    Public Sub New(ByVal conid As Integer, ByVal conemtid As Integer, ByVal connomape As String, ByVal connrolicencia As String, ByVal condni As String)

        gconid = conid
        gconnomape = connomape
        gconnrolicencia = connrolicencia
        gconemtid = conemtid
        gcondni = condni

    End Sub

End Class
