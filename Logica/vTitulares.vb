Public Class vTitulares
    Dim proid, departamento, provincia, distrito As Integer
    Dim titular, dni, ruc, representante_legal, sector, direccion As String
    Dim propietariock, destinock, transporteck As Boolean

    'Creación de metodos Setters y Getters

    Public Property gproid
        Get
            Return proid
        End Get
        Set(ByVal value)
            proid = value
        End Set
    End Property
    Public Property gtitular
        Get
            Return titular
        End Get
        Set(ByVal value)
            titular = value
        End Set
    End Property
    Public Property gruc
        Get
            Return ruc
        End Get
        Set(ByVal value)
            ruc = value
        End Set
    End Property
    Public Property gdni
        Get
            Return dni
        End Get
        Set(ByVal value)
            dni = value
        End Set
    End Property
    Public Property grepresentante_legal
        Get
            Return representante_legal
        End Get
        Set(ByVal value)
            representante_legal = value
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
    Public Property gsector
        Get
            Return sector
        End Get
        Set(ByVal value)
            sector = value
        End Set
    End Property
    Public Property gpropietariock
        Get
            Return propietariock
        End Get
        Set(ByVal value)
            propietariock = value
        End Set
    End Property
    Public Property gdestinock
        Get
            Return destinock
        End Get
        Set(ByVal value)
            destinock = value
        End Set
    End Property
    Public Property gtransporteck
        Get
            Return transporteck
        End Get
        Set(ByVal value)
            transporteck = value
        End Set
    End Property
    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(ByVal value)
            direccion = value
        End Set
    End Property
    'Declaramos los contructores
    Public Sub New() 'Constructor en blanco

    End Sub
    'Constructor con parametros
    Public Sub New(ByVal proid As Integer, ByVal titular As String, ByVal dni As String, ByVal ruc As String, ByVal representante_legal As String, ByVal departamento As Integer, _
                   ByVal provincia As Integer, ByVal distrito As Integer, ByVal sector As String, ByVal direccion As String, _
                   ByVal propietariock As Boolean, ByVal destinick As Boolean, ByVal transporteck As Boolean)
        gproid = proid
        gtitular = titular
        gdni = dni
        gruc = ruc
        grepresentante_legal = representante_legal
        gdepartamento = departamento
        gprovincia = provincia
        gdistrito = distrito
        gsector = sector
        gpropietariock = propietariock
        gdestinock = destinick
        gtransporteck = transporteck
        gdireccion = direccion
    End Sub

End Class
