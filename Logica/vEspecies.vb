Public Class vEspecies
    Dim idespecie As Integer
    Dim nombre_comun, nombre_cientifico As String

    'Creación de metodos Setters y Getters

    Public Property gidespecie
        Get
            Return idespecie
        End Get
        Set(ByVal value)
            idespecie = value
        End Set
    End Property
    Public Property gnombre_comun
        Get
            Return nombre_comun
        End Get
        Set(ByVal value)
            nombre_comun = value
        End Set
    End Property
    Public Property gnombre_cientifico
        Get
            Return nombre_cientifico
        End Get
        Set(ByVal value)
            nombre_cientifico = value
        End Set
    End Property
    'Declaramos los contructores
    Public Sub New() 'Constructor en blanco

    End Sub
    'Contructor con parametros
    Public Sub New(ByVal idespecie As Integer, ByVal nombre_comun As String, ByVal nombre_cientifico As String)

        gidespecie = idespecie
        gnombre_comun = nombre_comun
        gnombre_cientifico = nombre_cientifico
        
    End Sub

End Class
