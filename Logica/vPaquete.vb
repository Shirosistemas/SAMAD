Public Class vPaquete
    Dim Paq_id, Paq_Emp_Id, Paq_TipoProducto, Paq_CubicadorId, Paq_Especie As Integer
    Dim Paq_Numero, Paq_Acabado, Paq_Humedad, Paq_Clasificacion, Paq_Ubicacion, Paq_Observacion As String
    Public Property gPaq_Emp_id()
        Get
            Return Paq_Emp_id
        End Get
        Set(ByVal value)
            Paq_Emp_id = value
        End Set
    End Property
    Public Property gPaq_id()
        Get
            Return Paq_id
        End Get
        Set(ByVal value)
            Paq_id = value
        End Set
    End Property
    Public Property gPaq_TipoProducto()
        Get
            Return Paq_TipoProducto
        End Get
        Set(ByVal value)
            Paq_TipoProducto = value
        End Set
    End Property
    Public Property gPaq_CubicadorId()
        Get
            Return Paq_CubicadorId
        End Get
        Set(ByVal value)
            Paq_CubicadorId = value
        End Set
    End Property
    Public Property gPaq_Numero()
        Get
            Return Paq_Numero
        End Get
        Set(ByVal value)
            Paq_Numero = value
        End Set
    End Property
    Public Property gPaq_Especie()
        Get
            Return Paq_Especie
        End Get
        Set(ByVal value)
            Paq_Especie = value
        End Set
    End Property
    Public Property gPaq_Acabado()
        Get
            Return Paq_Acabado
        End Get
        Set(ByVal value)
            Paq_Acabado = value
        End Set
    End Property
    Public Property gPaq_Humedad()
        Get
            Return Paq_Humedad
        End Get
        Set(ByVal value)
            Paq_Humedad = value
        End Set
    End Property
    Public Property gPaq_Clasificacion
        Get
            Return Paq_Clasificacion
        End Get
        Set(ByVal value)
            Paq_Clasificacion = value
        End Set
    End Property
    Public Property gPaq_Ubicacion()
        Get
            Return Paq_Ubicacion
        End Get
        Set(ByVal value)
            Paq_Ubicacion = value
        End Set
    End Property
    Public Property gPaq_Observacion()
        Get
            Return Paq_Observacion
        End Get
        Set(ByVal value)
            Paq_Observacion = value
        End Set
    End Property
    'Contructor de clases vacio
    Public Sub New()

    End Sub
    Public Sub New(ByVal Paq_id As Integer, ByVal Paq_Emp_Id As Integer,
                   ByVal Paq_TipoProducto As Integer, ByVal Paq_CubicadorId As Integer,
                   ByVal Paq_Numero As String, ByVal Paq_Especie As Integer,
                   ByVal Paq_Acabado As String, ByVal Paq_Humedad As String,
                   ByVal Paq_Clasificacion As String, ByVal Paq_Ubicacion As String,
                   ByVal Paq_Observacion As String)

        gPaq_id = Paq_id
        gPaq_Emp_id = Paq_Emp_Id
        gPaq_Numero = Paq_Numero
        gPaq_Especie = Paq_Especie
        gPaq_TipoProducto = Paq_TipoProducto
        gPaq_Acabado = Paq_Acabado
        gPaq_Humedad = Paq_Humedad
        gPaq_Clasificacion = Paq_Clasificacion
        gPaq_CubicadorId = Paq_CubicadorId
        gPaq_Ubicacion = Paq_Ubicacion
        gPaq_Observacion = Paq_Observacion

    End Sub

End Class
