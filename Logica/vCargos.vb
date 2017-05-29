Public Class vCargos
    Dim idcargo As Integer
    Dim descripcion As String

    'Creación de metodos Setters y Getters

    Public Property gidcargo
        Get
            Return idcargo
        End Get
        Set(ByVal value)
            idcargo = value
        End Set
    End Property
    Public Property gdescripcion
        Get
            Return descripcion
        End Get
        Set(ByVal value)
            descripcion = value
        End Set
    End Property
   
    'Declaramos los contructores
    Public Sub New() 'Constructor en blanco

    End Sub
    'Contructor con parametros
    Public Sub New(ByVal idcargo As Integer, ByVal descripcion As String)

        gidcargo = idcargo
        gdescripcion = descripcion

    End Sub
End Class
