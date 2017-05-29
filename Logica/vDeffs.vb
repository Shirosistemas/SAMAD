Public Class vDeffs
    Dim defid As Integer
    Dim sede As String

    'Creación de metodos Setters y Getters

    Public Property gdefid
        Get
            Return defid
        End Get
        Set(ByVal value)
            defid = value
        End Set
    End Property
    Public Property gsede
        Get
            Return sede
        End Get
        Set(ByVal value)
            sede = value
        End Set
    End Property

    'Declaramos los contructores
    Public Sub New() 'Constructor en blanco

    End Sub
    'Contructor con parametros
    Public Sub New(ByVal defid As Integer, ByVal sede As String)

        gdefid = defid
        gsede = sede

    End Sub
End Class
