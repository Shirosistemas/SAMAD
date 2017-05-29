Public Class vEmpaquetado
    Dim Emp_Id, Emp_AserraderoId As Integer
    Dim Emp_NroDoc As String
    Dim Emp_Fecha As Date
    Dim Emp_Certificado As Boolean
    Public Property gEmp_Id()
        Get
            Return Emp_Id
        End Get
        Set(ByVal value)
            Emp_Id = value
        End Set
    End Property
    Public Property gEmp_AserraderoId()
        Get
            Return Emp_AserraderoId
        End Get
        Set(ByVal value)
            Emp_AserraderoId = value
        End Set
    End Property
    Public Property gEmp_NroDoc()
        Get
            Return Emp_NroDoc
        End Get
        Set(ByVal value)
            Emp_NroDoc = value
        End Set
    End Property
    Public Property gEmp_Fecha()
        Get
            Return Emp_Fecha
        End Get
        Set(ByVal value)
            Emp_Fecha = value
        End Set
    End Property
    Public Property gEmp_Certificado()
        Get
            Return Emp_Certificado
        End Get
        Set(ByVal value)
            Emp_Certificado = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal Emp_Id As Integer, ByVal Emp_AserraderoId As Integer,
                   ByVal Emp_NroDoc As Integer, ByVal Emp_Fecha As Date,
                   ByVal Emp_Certificado As Boolean)

        gEmp_Id = Emp_Id
        gEmp_AserraderoId = Emp_AserraderoId
        gEmp_NroDoc = Emp_NroDoc
        gEmp_Fecha = Emp_Fecha
        gEmp_Certificado = Emp_Certificado

    End Sub
End Class
