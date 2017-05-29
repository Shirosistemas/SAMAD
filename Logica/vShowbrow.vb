Public Class vShowbrow

    Private t_tabla, t_campos, t_donde, t_agruparpor, t_ordenarpor As String 'variables para definir la consulta sql
    Private f_h1, f_h2, f_h3 As String 'Variables Formato String
    Private f_w1, f_w2, f_w3 As Integer 'Variables Formato Integer

    Public Property gt_tabla
        Get
            Return t_tabla
        End Get
        Set(ByVal value)
            t_tabla = value
        End Set
    End Property

    Public Property gt_campos
        Get
            Return t_campos
        End Get
        Set(ByVal value)
            t_campos = value
        End Set
    End Property

    Public Property gt_donde
        Get
            Return t_donde
        End Get
        Set(ByVal value)
            t_donde = value
        End Set
    End Property

    Public Property gt_agruparpor
        Get
            Return t_agruparpor
        End Get
        Set(ByVal value)
            t_agruparpor = value
        End Set
    End Property

    Public Property gt_ordenarpor
        Get
            Return t_ordenarpor
        End Get
        Set(ByVal value)
            t_ordenarpor = value
        End Set
    End Property
    'Declaramos los contructores

    Public Sub New() 'Constructor en blanco

    End Sub
    'Contructor con parametros

    Public Sub New(ByVal t_tabla As String, ByVal t_campos As String, ByVal t_donde As String, ByVal t_agruparpor As String, ByVal t_ordenarpor As String)

        gt_tabla = t_tabla
        gt_campos = t_campos
        gt_donde = t_donde
        gt_agruparpor = t_agruparpor
        gt_ordenarpor = t_ordenarpor

    End Sub

End Class
