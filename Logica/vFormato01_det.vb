Public Class vFormato01_det
    Dim f01d_id, f01d_f01_id, f01d_utilizado_f04_id, f01d_propietarioid As Integer
    Dim f01d_guiaremision, F01d_gtf, f01d_correlativo, f01d_codindustria, f01d_placa, f01d_especie, f01d_especiec, f01d_observacion, f01d_ubicacion, f01d_autogenerado, f01d_veh_placa, f01d_conductor, f01d_procedencia, f01d_tipo, f01d_unidad As String
    Dim f01d_d1, f01d_d2, f01d_d3, f01d_vol_m3, f01d_d1c, f01d_d2c, f01d_d3c, f01d_vol_m3c As Decimal
    Dim f01d_lote As String

    Public Property gf01d_id
        Get
            Return f01d_id
        End Get
        Set(ByVal value)
            f01d_id = value
        End Set
    End Property
    Public Property gf01d_f01_id
        Get
            Return f01d_f01_id
        End Get
        Set(ByVal value)
            f01d_f01_id = value
        End Set
    End Property
    Public Property gf01d_guiaremision
        Get
            Return f01d_guiaremision
        End Get
        Set(ByVal value)
            f01d_guiaremision = value
        End Set
    End Property
    Public Property gf01d_gtf
        Get
            Return f01d_gtf
        End Get
        Set(ByVal value)
            f01d_gtf = value
        End Set
    End Property
    Public Property gf01d_correlativo
        Get
            Return f01d_correlativo
        End Get
        Set(ByVal value)
            f01d_correlativo = value
        End Set
    End Property
    Public Property gf01d_codindustria
        Get
            Return f01d_codindustria
        End Get
        Set(ByVal value)
            f01d_codindustria = value
        End Set
    End Property
    Public Property gf01d_placa
        Get
            Return f01d_placa
        End Get
        Set(ByVal value)
            f01d_placa = value
        End Set
    End Property
    Public Property gf01d_especie
        Get
            Return f01d_especie
        End Get
        Set(ByVal value)
            f01d_especie = value
        End Set
    End Property
    Public Property gf01d_especiec
        Get
            Return f01d_especiec
        End Get
        Set(ByVal value)
            f01d_especiec = value
        End Set
    End Property
    Public Property gf01d_d1
        Get
            Return f01d_d1
        End Get
        Set(ByVal value)
            f01d_d1 = value
        End Set
    End Property
    Public Property gf01d_d2
        Get
            Return f01d_d2
        End Get
        Set(ByVal value)
            f01d_d2 = value
        End Set
    End Property
    Public Property gf01d_d3
        Get
            Return f01d_d3
        End Get
        Set(ByVal value)
            f01d_d3 = value
        End Set
    End Property
    Public Property gf01d_d1c
        Get
            Return f01d_d1c
        End Get
        Set(ByVal value)
            f01d_d1c = value
        End Set
    End Property
    Public Property gf01d_d2c
        Get
            Return f01d_d2c
        End Get
        Set(ByVal value)
            f01d_d2c = value
        End Set
    End Property
    Public Property gf01d_d3c
        Get
            Return f01d_d3c
        End Get
        Set(ByVal value)
            f01d_d3c = value
        End Set
    End Property
    Public Property gf01d_observacion
        Get
            Return f01d_observacion
        End Get
        Set(ByVal value)
            f01d_observacion = value
        End Set
    End Property
    Public Property gf01d_ubicacion
        Get
            Return f01d_ubicacion
        End Get
        Set(ByVal value)
            f01d_ubicacion = value
        End Set
    End Property
    Public Property gf01d_vol_m3
        Get
            Return f01d_vol_m3
        End Get
        Set(ByVal value)
            f01d_vol_m3 = value
        End Set
    End Property
    Public Property gf01d_vol_m3c
        Get
            Return f01d_vol_m3c
        End Get
        Set(ByVal value)
            f01d_vol_m3c = value
        End Set
    End Property
    Public Property gf01d_autogenerado
        Get
            Return f01d_autogenerado
        End Get
        Set(ByVal value)
            f01d_autogenerado = value
        End Set
    End Property
    Public Property gf01d_veh_placa
        Get
            Return f01d_veh_placa
        End Get
        Set(ByVal value)
            f01d_veh_placa = value
        End Set
    End Property
    Public Property gf01d_conductor
        Get
            Return f01d_conductor
        End Get
        Set(ByVal value)
            f01d_conductor = value
        End Set
    End Property
    Public Property gf01d_utilizado_f04_id
        Get
            Return f01d_utilizado_f04_id
        End Get
        Set(ByVal value)
            f01d_utilizado_f04_id = value
        End Set
    End Property
    Public Property gf01d_procedencia
        Get
            Return f01d_procedencia
        End Get
        Set(ByVal value)
            f01d_procedencia = value
        End Set
    End Property
    Public Property gf01d_tipo
        Get
            Return f01d_tipo
        End Get
        Set(ByVal value)
            f01d_tipo = value
        End Set
    End Property
    Public Property gf01d_unidad
        Get
            Return f01d_unidad
        End Get
        Set(ByVal value)
            f01d_unidad = value
        End Set
    End Property


    Public Property fldLote
        Get
            Return f01d_lote
        End Get
        Set(value)
            f01d_lote = value
        End Set
    End Property

    Public Property fldOwner
        Get
            Return f01d_propietarioId
        End Get
        Set(value)
            f01d_propietarioid = value
        End Set
    End Property

    Public Sub New()
        'Constructor vacio
    End Sub

    Public Sub New(ByVal f01d_id As Integer, ByVal f01d_f01_id As Integer, ByVal f01d_guiaremision As String, ByVal f01d_gtf As String, _
                   ByVal f01d_correlativo As String, ByVal f01d_codindustria As String, ByVal f01d_placa As String, ByVal f01d_especie As String, ByVal f01d_especiec As String, _
                   ByVal f01d_d1 As Decimal, ByVal f01d_d2 As Decimal, ByVal f01d_d3 As Decimal, ByVal f01d_d1c As Decimal, ByVal f01d_d2c As Decimal, _
                   ByVal f01d_d3c As Decimal, ByVal f01d_observacion As String, ByVal f01d_ubicacion As String, ByVal f01d_vol_m3 As Decimal, _
                   ByVal f01d_vol_m3c As Decimal, ByVal f01d_autogenerado As String, ByVal f01d_veh_marca As String, ByVal f01d_conductor As String, _
                   ByVal f01d_utilizado_f04_id As Integer, f01d_tipo As String, f01d_procedencia As String, f01d_unidad As String, f01d_lote As String, f01d_propietarioId As Integer)

        gf01d_id = f01d_id
        gf01d_f01_id = f01d_f01_id
        gf01d_guiaremision = f01d_guiaremision
        gf01d_gtf = f01d_gtf
        gf01d_correlativo = f01d_correlativo
        gf01d_codindustria = f01d_codindustria
        gf01d_placa = f01d_placa
        gf01d_especie = f01d_especie
        gf01d_especiec = f01d_especiec
        gf01d_d1 = f01d_d1
        gf01d_d2 = f01d_d2
        gf01d_d3 = f01d_d3
        gf01d_vol_m3 = f01d_vol_m3
        gf01d_d1c = f01d_d1c
        gf01d_d2c = f01d_d2c
        gf01d_d3c = f01d_d3c
        gf01d_vol_m3c = f01d_vol_m3c
        gf01d_observacion = f01d_observacion
        gf01d_ubicacion = f01d_ubicacion
        gf01d_autogenerado = f01d_autogenerado
        gf01d_veh_placa = f01d_veh_placa
        gf01d_conductor = f01d_conductor
        gf01d_utilizado_f04_id = f01d_utilizado_f04_id
        gf01d_procedencia = f01d_procedencia
        gf01d_tipo = f01d_tipo
        gf01d_unidad = f01d_unidad
        fldLote = f01d_lote
        fldOwner = f01d_propietarioId
    End Sub
End Class
