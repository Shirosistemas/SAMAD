Imports MySql.Data.MySqlClient
Public Class fdespacho_det
    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando

    Public Function mostrar(ByVal id As Integer) As DataTable
        Try
            CONECTADO() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_despacho_det") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'If cmd.ExecuteNonQuery Then 'Si la consulta contiene información
            cmd.Parameters.AddWithValue("vdesd_des_id", id)
            Dim da As New MySqlDataAdapter(cmd)

            Dim dt As New DataTable
            da.Fill(dt) 'Retornamos el contenido al adaptador
            Return dt
            ' Else
            ' Return Nothing 'Retornamos nada
            ' End If
        Catch ex As Exception
            MsgBox("Mensaje2:" + ex.ToString)
            Return Nothing 'Retornamos nada
        Finally
            DESCONECTADO()
        End Try
    End Function

    Public Function insertar(ByVal dts As vDespacho_det) As Boolean

        Try
            CONECTADO()
            cmd = New MySqlCommand("insertar_despacho_det") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vnrogtf", dts.gnrogtf)
            cmd.Parameters.AddWithValue("vespecie", dts.gespecie)
            cmd.Parameters.AddWithValue("vproducto", dts.gproducto)
            cmd.Parameters.AddWithValue("vpiezas", dts.gpiezas)
            cmd.Parameters.AddWithValue("vvolm3", dts.gvolm3)
            cmd.Parameters.AddWithValue("vdesddesid", dts.gdesddesid)
            cmd.Parameters.AddWithValue("vdesdltid", dts.gdesdltid)

            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("despacho_det", "Insertar", id, dts.gnrogtf)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            DESCONECTADO()
        End Try

    End Function

    Public Function editar(ByVal dts As vDespacho_det) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("editar_despacho_det") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.gdesdid)
            cmd.Parameters.AddWithValue("vnrogtf", dts.gnrogtf)
            cmd.Parameters.AddWithValue("vespecie", dts.gespecie)
            cmd.Parameters.AddWithValue("vproducto", dts.gproducto)
            cmd.Parameters.AddWithValue("vpiezas", dts.gpiezas)
            cmd.Parameters.AddWithValue("vvolm3", dts.gvolm3)
            cmd.Parameters.AddWithValue("vdesddesid", dts.gdesddesid)
            cmd.Parameters.AddWithValue("vdesdltid", dts.gdesdltid)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("despacho_det", "Editar", dts.gdesdid, dts.gnrogtf)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function

    Public Function eliminar(ByVal dts As vDespacho_det) As Boolean
        Try
            CONECTADO()
            cmd = New MySqlCommand("eliminar_despacho_det") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("vid", MySqlDbType.VarChar, 50).Value = dts.gdesdid

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("despacho_det", "Eliminar", dts.gdesdid, "")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            DESCONECTADO()
        End Try
    End Function

End Class

Public Class cdDespacho_det

    Function DespachoDetAgregar(ByVal rs As SAMAD.despacho_det) As Boolean
        Using dm As New samadEntities
            dm.AddTodespacho_det(rs)
            dm.SaveChanges()
            Return True
        End Using
    End Function
    Public Function despachpDetEditar(ByVal rs As SAMAD.despacho_det) As Boolean
        Using dm As New samadEntities
            ' obtenemos el Registro antes de modificarlo
            Dim ra As SAMAD.despacho_det = (From v In dm.despacho_det Where v.Desd_Id = rs.Desd_Id Select v).First()
            dm.despacho_det.Detach(ra)
            Dim rn As New SAMAD.despacho_det
            Try
                rn.Desd_Id = rs.Desd_Id
                dm.despacho_det.Attach(rn)
                dm.despacho_det.ApplyCurrentValues(rs)
                dm.SaveChanges()
                Return True
            Catch ex As Exception
                dm.Refresh(Objects.RefreshMode.ClientWins, ra)
                dm.SaveChanges()
                Return False
            End Try
        End Using
    End Function

    Function DespachoDetGrabar(ByVal rs As SAMAD.despacho_det, xexiste As Boolean) As Boolean
        If xexiste = False Then
            Return DespachoDetAgregar(rs)
        Else
            Return despachpDetEditar(rs)
        End If
    End Function

    ''' <summary>
    ''' Funcion para saber si el Paquete ya existe en el Periodo
    ''' </summary>
    ''' <param name="strPaquete"></param>
    ''' <param name="strPeriodo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function DespachoDetExiste(ByVal strPaquete As String, strPeriodo As Integer) As Boolean
        Using dm As New samadEntities
            Dim nr As Integer = (From x In dm.despacho_det Where x.Desd_Codigo = strPaquete And x.Desd_Id = strPeriodo Select x.Desd_Id).Count()
            Return IIf(nr > 0, True, False)
        End Using
    End Function

    ''' <summary>
    ''' Funcion que retorna el Ultimo ID de paquete
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function LastDespachoId() As Integer
        Using dm As New samadEntities
            LastDespachoId = dm.despacho_det.Select(Function(x) x.Desd_Id).Max()
        End Using
    End Function
    Function ExisteRumaDespacho(ByVal strCodigo As String, strPeriodo As String, intTitular As String) As Boolean
        Using dm As New samadEntities
            Dim sn = (From rs In dm.despacho_det From fc In dm.despacho
                            Where fc.Des_Fecha.Value.Year + rs.Desd_Especie + rs.Desd_Codigo = strPeriodo + intTitular + strCodigo Select rs.Desd_Codigo).Count()
            Return IIf(sn > 0, True, False)
        End Using
    End Function
    Function TraerVolumenGTF(ByVal strNumeroGtf As String, ByVal stNombreEspecie As String, ByVal strNumeroContrato As String) As Decimal
        Using dm As New samadEntities
            Dim temp = (From rs In dm.vw_mostrar_listastrozasgtf Where rs.Lt_Nrogtf = strNumeroGtf And rs.Ltd_Especie = stNombreEspecie And rs.Con_Descripcion = strNumeroContrato Select rs.volm3gtf).Sum()

            ''Dim dt As SAMAD.vw_mostrar_listastrozasgtf = temp
            Return temp
        End Using
    End Function
    Function VistaDespachoDet(ByVal despachadoID As Integer) As List(Of SAMAD.despacho_det)
        Using dm As New samadEntities
            Dim ls = (From x In dm.despacho_det Where x.Desd_Id = despachadoID Select x).ToList()
            Return ls
        End Using
    End Function

    Function TraerVolRecepcion(ByVal strNumeroGtf As String, ByVal stNombreEspecie As String, ByVal strNumeroContrato As String) As Decimal
        Using dm As New samadEntities
            Dim temp = (From rs In dm.listavolrecepcion
                        Where
                        rs.F01d_Gtf = strNumeroGtf And
                        rs.F01d_Especie = stNombreEspecie And
                        rs.Con_Descripcion = strNumeroContrato
                        Select rs.VolM3Rec).Sum()
            ''Dim dt As SAMAD.vw_mostrar_listastrozasgtf = temp
            Return temp
        End Using
    End Function

    Function DetalleDespachoCatalogoAgregar(ByVal rs As SAMAD.despacho_catalogo) As Boolean
        Using dm As New samadEntities
            dm.AddTodespacho_catalogo(rs)
            dm.SaveChanges()
            Return True
        End Using
    End Function

    Function CatalogoReportAgregar(ByVal rs As SAMAD.catalogodespachoreport) As Boolean
        Using dm As New samadEntities
            dm.AddTocatalogodespachoreport(rs)
            dm.SaveChanges()
            Return True
        End Using
    End Function

    Function DespachoTieneDetalle(ByVal idRuma As Integer) As Boolean
        Using dm As New samadEntities
            Dim nr = dm.despacho_det.Where(Function(x) x.Desd_Des_Id = idRuma).Select(Function(a) a.Desd_Des_Id).Count()
            Return IIf(nr > 0, True, False)
        End Using
    End Function
End Class