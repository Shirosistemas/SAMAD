Public Class vPersonal
    Dim perid, percargoid As Integer
    Dim pernomape, percargo, percondicion As String
    Public Property gperid
        Get
            Return perid
        End Get
        Set(ByVal value)
            perid = value
        End Set
    End Property
    Public Property gpernomape
        Get
            Return pernomape
        End Get
        Set(ByVal value)
            pernomape = value
        End Set
    End Property

    Public Property gpercargo
        Get
            Return percargo
        End Get
        Set(ByVal value)
            percargo = value
        End Set
    End Property
    Public Property gpercargoid
        Get
            Return percargoid
        End Get
        Set(ByVal value)
            percargoid = value
        End Set
    End Property
    Public Property gpercondicion
        Get
            Return percondicion
        End Get
        Set(ByVal value)
            percondicion = value
        End Set
    End Property
    Public Sub New()
        'Constructor vacio
    End Sub

    Public Sub New(ByVal perid As Integer, ByVal pernomape As String, ByVal percargoid As Integer, ByVal percargo As String, ByVal percondicion As String)
        gperid = perid
        gpernomape = pernomape
        percargoid = percargoid
        gpercargo = percargo
        gpercondicion = percondicion
    End Sub

End Class
