Public Class vPaqueteDeta
    Dim Paqd_id, Paqd_Paq_Id, Paqd_Piezas As Integer
    Dim Paqd_Espesor, Paqd_Ancho, Paqd_Largo, Paqd_Volpt As Decimal
    Public Property gPaqd_Piezas()
        Get
            Return Paqd_Piezas
        End Get
        Set(ByVal value)
            Paqd_Piezas = value
        End Set
    End Property
    Public Property gPaqd_id()
        Get
            Return Paqd_id
        End Get
        Set(ByVal value)
            Paqd_id = value
        End Set
    End Property
    Public Property gPaqd_Paq_Id()
        Get
            Return Paqd_Paq_Id
        End Get
        Set(ByVal value)
            Paqd_Paq_Id = value
        End Set
    End Property
    Public Property gPaqd_Espesor()
        Get
            Return Paqd_Espesor
        End Get
        Set(ByVal value)
            Paqd_Espesor = value
        End Set
    End Property
    Public Property gPaqd_Ancho()
        Get
            Return Paqd_Ancho
        End Get
        Set(ByVal value)
            Paqd_Ancho = value
        End Set
    End Property
    Public Property gPaqd_Largo()
        Get
            Return Paqd_Largo
        End Get
        Set(ByVal value)
            Paqd_Largo = value
        End Set
    End Property
    Public Property gPaqd_Volpt()
        Get
            Return Paqd_Volpt
        End Get
        Set(ByVal value)
            Paqd_Volpt = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal Paqd_id As Integer, ByVal Paqd_Paq_Id As Integer,
                   ByVal Paqd_Piezas As Integer,
                   ByVal Paqd_Espesor As Decimal, ByVal ByPaqd_Ancho As Decimal,
                   ByVal Paqd_Largo As Decimal, ByVal Paqd_Volpt As Decimal)

        gPaqd_id = Paqd_id
        gPaqd_Paq_Id = Paqd_Paq_Id
        gPaqd_Piezas = Paqd_Piezas
        gPaqd_Espesor = Paqd_Espesor
        gPaqd_Ancho = Paqd_Ancho
        gPaqd_Largo = Paqd_Largo
        gPaqd_Volpt = Paqd_Volpt

    End Sub
End Class
