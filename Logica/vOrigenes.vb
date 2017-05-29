Public Class vOrigenes
    Dim oriid As Integer
    Dim lugar, departamento, provincia, distrito As String

    Public Property goriid
        Get
            Return oriid
        End Get
        Set(ByVal value)
            oriid = value
        End Set
    End Property
    Public Property glugar
        Get
            Return lugar
        End Get
        Set(ByVal value)
            lugar = value
        End Set
    End Property
    Public Property gdepartamento
        Get
            Return departamento
        End Get
        Set(ByVal value)
            departamento = value
        End Set
    End Property
    Public Property gprovincia
        Get
            Return provincia
        End Get
        Set(ByVal value)
            provincia = value
        End Set
    End Property
    Public Property gdistrito
        Get
            Return distrito
        End Get
        Set(ByVal value)
            distrito = value
        End Set
    End Property
    Public Sub New()
        'Constructoe vacio
    End Sub
    Public Sub New(ByVal oriid As Integer, ByVal lugar As String, ByVal departamento As String, ByVal provincia As String, ByVal distrito As String)

        goriid = oriid
        glugar = lugar
        gdepartamento = departamento
        gprovincia = provincia
        gdistrito = distrito

    End Sub
End Class
