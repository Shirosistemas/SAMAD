Public Class vClientes
    Dim clieid As Integer
    Dim nomraz, tipodoc, numdoc, direccion, telefono, contacto As String

    Public Property gclieid
        Get
            Return clieid
        End Get
        Set(ByVal value)
            clieid = value
        End Set
    End Property
    Public Property gnomraz
        Get
            Return nomraz
        End Get
        Set(ByVal value)
            nomraz = value
        End Set
    End Property
    Public Property gtipodoc
        Get
            Return tipodoc
        End Get
        Set(ByVal value)
            tipodoc = value
        End Set
    End Property
    Public Property gnumdoc
        Get
            Return numdoc
        End Get
        Set(ByVal value)
            numdoc = value
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
    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(ByVal value)
            telefono = value
        End Set
    End Property
    Public Property gcontacto
        Get
            Return contacto
        End Get
        Set(ByVal value)
            contacto = value
        End Set
    End Property
    Public Sub New()
        'Constructor vacio
    End Sub
    Public Sub New(ByVal clieid As Integer, ByVal nomraz As String, ByVal tipodoc As String, ByVal numdoc As String, _
                   ByVal direccion As String, ByVal telefono As String, ByVal contacto As String)
        gclieid = clieid
        gnomraz = nomraz
        gtipodoc = tipodoc
        gnumdoc = numdoc
        gdireccion = direccion
        gtelefono = telefono
        gcontacto = contacto

    End Sub
End Class
