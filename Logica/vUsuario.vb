Public Class vUsuario
    Dim us_id As Integer
    Dim nombre, password, tipo As String

    Public Property gus_id
        Get
            Return us_id
        End Get
        Set(ByVal value)
            us_id = value
        End Set
    End Property
    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(ByVal value)
            nombre = value
        End Set
    End Property
    Public Property gpassword
        Get
            Return password
        End Get
        Set(ByVal value)
            password = value
        End Set
    End Property
    Public Property gtipo
        Get
            Return tipo
        End Get
        Set(ByVal value)
            tipo = value
        End Set
    End Property

    Public Sub New()
      
    End Sub

    Public Sub New(ByVal us_id As Integer, ByVal nombre As String, ByVal password As String, ByVal tipo As String)
        gus_id = us_id
        gnombre = nombre
        gpassword = password
        gtipo = tipo
    End Sub
End Class
