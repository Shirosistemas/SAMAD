Public Class vZafrasypoas

    Dim zypid, zypermisoid As Integer
    Dim zyppoa, zypzafra, zypresolucion, zyptipopm As String

    Public Property gzypid
        Get
            Return zypid
        End Get
        Set(ByVal value)
            zypid = value
        End Set
    End Property

    Public Property gzypresolucion
        Get
            Return zypresolucion
        End Get
        Set(ByVal value)
            zypresolucion = value
        End Set
    End Property

    Public Property gzyptipopm
        Get
            Return zyptipopm
        End Get
        Set(ByVal value)
            zyptipopm = value
        End Set
    End Property

    Public Property gzypzafra
        Get
            Return zypzafra
        End Get
        Set(ByVal value)
            zypzafra = value
        End Set
    End Property

    Public Property gzyppoa
        Get
            Return zyppoa
        End Get
        Set(ByVal value)
            zyppoa = value
        End Set
    End Property

    Public Property gzyppermisoid
        Get
            Return zypermisoid
        End Get
        Set(ByVal value)
            zypermisoid = value
        End Set
    End Property

    Public Sub New()
        'Constructor vacio
    End Sub

    Public Sub New(ByVal zypid As Integer, ByVal zypresolucion As String, ByVal zyptipopm As String, ByVal zypzafra As String, ByVal zyppermisoid As Integer, ByVal zyppoa As String)

        gzypid = zypid
        gzypresolucion = zypresolucion
        gzyptipopm = zyptipopm
        gzypzafra = zypzafra
        gzyppoa = zyppoa
        gzyppermisoid = zyppermisoid


    End Sub
End Class
