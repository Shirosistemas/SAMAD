Imports System.Data.SqlClient

Public Class vFormato02_det

    Dim f02d_id, f02d_f02_id As Integer
    Dim f02d_codificacion, f02d_codindustria, f02d_cut, f02d_especie, f02d_observacion, f02d_unidad As String
    Dim f02d_d1, f02d_d2, f02d_d3, f02d_volm3, f02d_d1c, f02d_d2c, f02d_d3c, f02d_volm3c, f02d_d_pulgada, f02d_dpies, f02d_vol_pt As Decimal

    Public Property gf02d_id
        Get
            Return f02d_id
        End Get
        Set(ByVal value)
            f02d_id = value
        End Set
    End Property

    Public Property gf02d_f02_id
        Get
            Return f02d_f02_id
        End Get
        Set(ByVal value)
            f02d_f02_id = value
        End Set
    End Property

    Public Property gf02d_codificacion
        Get
            Return f02d_codificacion
        End Get
        Set(ByVal value)
            f02d_codificacion = value
        End Set
    End Property

    Public Property gf02d_codindustria
        Get
            Return f02d_codindustria
        End Get
        Set(ByVal value)
            f02d_codindustria = value
        End Set
    End Property

    Public Property gf02d_cut
        Get
            Return f02d_cut
        End Get
        Set(ByVal value)
            f02d_cut = value
        End Set
    End Property

    Public Property gf02d_especie
        Get
            Return f02d_especie
        End Get
        Set(ByVal value)
            f02d_especie = value
        End Set
    End Property

    Public Property gf02d_d1
        Get
            Return f02d_d1
        End Get
        Set(ByVal value)
            f02d_d1 = value
        End Set
    End Property

    Public Property gf02d_d2
        Get
            Return f02d_d2
        End Get
        Set(ByVal value)
            f02d_d2 = value
        End Set
    End Property

    Public Property gf02d_d3
        Get
            Return f02d_d3
        End Get
        Set(ByVal value)
            f02d_d3 = value
        End Set
    End Property

    Public Property gf02d_d1c
        Get
            Return f02d_d1c
        End Get
        Set(ByVal value)
            f02d_d1c = value
        End Set
    End Property

    Public Property gf02d_d2c
        Get
            Return f02d_d2c
        End Get
        Set(ByVal value)
            f02d_d2c = value
        End Set
    End Property

    Public Property gf02d_d3c
        Get
            Return f02d_d3c
        End Get
        Set(ByVal value)
            f02d_d3c = value
        End Set
    End Property

    Public Property gf02d_d_pulgada
        Get
            Return f02d_d_pulgada
        End Get
        Set(ByVal value)
            f02d_d_pulgada = value
        End Set
    End Property

    Public Property gf02d_dpies
        Get
            Return f02d_dpies
        End Get
        Set(ByVal value)
            f02d_dpies = value
        End Set
    End Property

    Public Property gf02d_vol_pt
        Get
            Return f02d_vol_pt
        End Get
        Set(ByVal value)
            f02d_vol_pt = value
        End Set
    End Property

    Public Property gf02d_observacion
        Get
            Return f02d_observacion
        End Get
        Set(ByVal value)
            f02d_observacion = value
        End Set
    End Property

    Public Property gf02d_volm3
        Get
            Return f02d_volm3
        End Get
        Set(ByVal value)
            f02d_volm3 = value
        End Set
    End Property
    Public Property gf02d_volm3c
        Get
            Return f02d_volm3c
        End Get
        Set(ByVal value)
            f02d_volm3c = value
        End Set
    End Property

    Public Property fldUnidad
        Get
            Return f02d_unidad
        End Get
        Set(value)
            f02d_unidad = value
        End Set
    End Property


    Public Sub New()
        'Constructor vacio
    End Sub

    Public Sub New(ByVal f02d_id As Integer, ByVal f02d_f02_id As Integer, ByVal f02d_codificacion As String, ByVal codindustria As String, _
                   ByVal f02d_cut As String, ByVal f02d_especie As String, ByVal f02d_d1 As Decimal, ByVal f02d_d2 As Decimal, _
                   ByVal f02d_d3 As Decimal, ByVal f02d_observacion As String, ByVal f02d_volm3 As Decimal, ByVal f02d_d1c As Decimal,
                   ByVal f02d_d2c As Decimal, ByVal f02d_d3c As Decimal, ByVal f02d_volm3c As Decimal, f02d_d_pulgada As Decimal, f02d_dpies As Decimal, f02d_vol_pt As Decimal, f02d_unidad As String)

        gf02d_id = f02d_id
        gf02d_f02_id = f02d_f02_id
        gf02d_codificacion = f02d_codificacion
        gf02d_codindustria = f02d_codindustria
        gf02d_cut = f02d_cut
        gf02d_especie = f02d_especie
        gf02d_d1 = f02d_d1
        gf02d_d2 = f02d_d2
        gf02d_d3 = f02d_d3
        gf02d_volm3 = f02d_volm3
        gf02d_d1c = f02d_d1c
        gf02d_d2c = f02d_d2c
        gf02d_d3c = f02d_d3c
        gf02d_volm3c = f02d_volm3c
        gf02d_d_pulgada = f02d_d_pulgada
        gf02d_dpies = f02d_dpies
        gf02d_vol_pt = f02d_vol_pt

        gf02d_observacion = f02d_observacion

    End Sub

End Class
