Public Class vProductos
    Dim prod_id As Integer
    Dim espesordesde, espesorhasta, anchodesde, anchohasta, largodesde, largohasta As Decimal
    Dim descrip As String, tipoconteo As String, tipocorte, lineaprod As String
    Public Property gprod_id
        Get
            Return prod_id
        End Get
        Set(ByVal value)
            prod_id = value
        End Set
    End Property
    Public Property gdescrip
        Get
            Return descrip
        End Get
        Set(ByVal value)
            descrip = value
        End Set
    End Property
    Public Property gespesordesde
        Get
            Return espesordesde
        End Get
        Set(ByVal value)
            espesordesde = value
        End Set
    End Property
    Public Property gespesorhasta
        Get
            Return espesorhasta
        End Get
        Set(ByVal value)
            espesorhasta = value
        End Set
    End Property
    Public Property ganchodesde
        Get
            Return anchodesde
        End Get
        Set(ByVal value)
            anchodesde = value
        End Set
    End Property
    Public Property ganchohasta
        Get
            Return anchohasta
        End Get
        Set(ByVal value)
            anchohasta = value
        End Set
    End Property
    Public Property glargodesde
        Get
            Return largodesde
        End Get
        Set(ByVal value)
            largodesde = value
        End Set
    End Property
    Public Property glargohasta
        Get
            Return largohasta
        End Get
        Set(ByVal value)
            largohasta = value
        End Set
    End Property
    Public Property gtipoconteo
        Get
            Return tipoconteo
        End Get
        Set(ByVal value)
            tipoconteo = value
        End Set
    End Property
    Public Property gtipocorte
        Get
            Return tipocorte
        End Get
        Set(ByVal value)
            tipocorte = value
        End Set
    End Property
    Public Property glineaprod
        Get
            Return lineaprod
        End Get
        Set(ByVal value)
            lineaprod = value
        End Set
    End Property

    Public Sub New()
        'Constructor vacio
    End Sub
    Public Sub New(ByVal prod_id As Integer, ByVal descrip As String, ByVal espesordesde As Decimal, ByVal espesorhasta As Decimal, _
                   ByVal anchodesde As Decimal, ByVal anchohasta As Decimal, ByVal largodesde As Decimal, ByVal largohasta As Decimal, _
                   ByVal tipoconteo As String, ByVal tipocorte As String)

        gprod_id = prod_id
        gdescrip = descrip
        gespesordesde = espesordesde
        gespesorhasta = espesorhasta
        ganchodesde = anchodesde
        ganchohasta = anchohasta
        glargodesde = largodesde
        glargohasta = largohasta
        gtipoconteo = tipoconteo
        gtipocorte = tipocorte

    End Sub
End Class
