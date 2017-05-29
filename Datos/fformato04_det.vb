Imports MySql.Data.MySqlClient
Public Class fformato04_det
    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando

    Public Function mostrar(ByVal dts As vFormato04_det) As DataTable
        Try
            CONECTADO() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_formato04_det") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("vf04d_f04id", dts.gf04d_f04_id)
            'If cmd.ExecuteNonQuery Then 'Si la consulta contiene información

            Dim da As New MySqlDataAdapter(cmd)

            Dim dt As New DataTable
            da.Fill(dt) 'Retornamos el contenido al adaptador
            Return dt
            ' Else
            ' Return Nothing 'Retornamos nada
            ' End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return Nothing 'Retornamos nada
        Finally
            DESCONECTADO()
        End Try
    End Function

    Public Function insertar(ByVal dts As vFormato04_det) As Boolean

        Try
            CONECTADO()
            cmd = New MySqlCommand("insertar_formato04_det") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vf04d_f04_id", dts.gf04d_f04_id)
            cmd.Parameters.AddWithValue("vcut", dts.gf04d_cut)
            cmd.Parameters.AddWithValue("vcodigo", dts.gf04d_codigo)
            cmd.Parameters.AddWithValue("vespecie", dts.gf04d_especie)
            cmd.Parameters.AddWithValue("vcalidad", dts.gf04d_calidad)
            cmd.Parameters.AddWithValue("vespesor", dts.gf04d_espesor)
            cmd.Parameters.AddWithValue("vancho", dts.gf04d_ancho)
            cmd.Parameters.AddWithValue("vlargo", dts.gf04d_largo)
            cmd.Parameters.AddWithValue("vproducto_id", dts.gf04d_producto_id)
            cmd.Parameters.AddWithValue("vnropiezasp", dts.gf04d_nropiezasp)
            cmd.Parameters.AddWithValue("vnropiezass", dts.gf04d_nropiezass)
            cmd.Parameters.AddWithValue("vvolptp", dts.gf04d_volptp)
            cmd.Parameters.AddWithValue("vvolpts", dts.gf04d_volpts)
            cmd.Parameters.AddWithValue("vobservacion", dts.gf04d_observacion)
            cmd.Parameters.AddWithValue("vcodind", dts.gf04d_codind)


            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("formato04_det", "Insertar", id, dts.gf04d_codind)
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

    Public Function editar(ByVal dts As vFormato04_det) As Boolean

        Try
            CONECTADO()
            cmd = New MySqlCommand("editar_formato04_det") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.gf04d_id)
            cmd.Parameters.AddWithValue("vf04id", dts.gf04d_f04_id)
            cmd.Parameters.AddWithValue("vcut", dts.gf04d_cut)
            cmd.Parameters.AddWithValue("vcodigo", dts.gf04d_codigo)
            cmd.Parameters.AddWithValue("vespecie", dts.gf04d_especie)
            cmd.Parameters.AddWithValue("vcalidad", dts.gf04d_calidad)
            cmd.Parameters.AddWithValue("vespesor", dts.gf04d_espesor)
            cmd.Parameters.AddWithValue("vancho", dts.gf04d_ancho)
            cmd.Parameters.AddWithValue("vlargo", dts.gf04d_largo)
            cmd.Parameters.AddWithValue("vproducto_id", dts.gf04d_producto_id)
            cmd.Parameters.AddWithValue("vnropiezasp", dts.gf04d_nropiezasp)
            cmd.Parameters.AddWithValue("vnropiezass", dts.gf04d_nropiezass)
            cmd.Parameters.AddWithValue("vvolptp", dts.gf04d_volptp)
            cmd.Parameters.AddWithValue("vvolpts", dts.gf04d_volpts)
            cmd.Parameters.AddWithValue("vobservacion", dts.gf04d_observacion)
            cmd.Parameters.AddWithValue("vcodind", dts.gf04d_codind)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("formato04_det", "Editar", dts.gf04d_id, dts.gf04d_codind)
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

    Public Function eliminar(ByVal dts As vFormato04_det) As Boolean
        Try
            conectado()
            cmd = New MySqlCommand("eliminar_formato04_det") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("vid", MySqlDbType.VarChar, 50).Value = dts.gf04d_id

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("formato04_det", "Eliminar", dts.gf04d_id, "")
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
End Class


Public Class cdFormato04_rumas

#Region "Formato04_rumas"

#Region "Mantenimiento a la Tabla Formato04_rumas(Altas, Bajas y Cambios)"

    ''' <summary>
    ''' Funcion para agregar un Nuevo registro a la Tabla Formato04_rumas
    ''' </summary>
    ''' <param name="rs"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Function RumasAgregar(ByVal rs As SAMAD.formato04_rumas) As Boolean
        Using dm As New samadEntities
            Try
                dm.AddToformato04_rumas(rs)
                dm.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    ''' <summary>
    ''' Funcion para editar un Regisro de la Tabla rumas
    ''' </summary>
    ''' <param name="rs"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function RumasEditar(ByVal rs As SAMAD.formato04_rumas) As Boolean
        Using dm As New samadEntities
            ' obtenemos el Registro antes de modificarlo
            Dim ra As SAMAD.formato04_rumas = (From v In dm.formato04_rumas Where v.RowId = rs.RowId Select v).First()
            dm.formato04_rumas.Detach(ra)
            Dim rn As New SAMAD.formato04_rumas
            Try
                rn.RowId = rs.RowId
                dm.formato04_rumas.Attach(rn)
                dm.formato04_rumas.ApplyCurrentValues(rs)
                dm.SaveChanges()
                Return True
            Catch ex As Exception
                dm.Refresh(Objects.RefreshMode.ClientWins, ra)
                dm.SaveChanges()
                Return False
            End Try
        End Using
    End Function

    'Funcion para Grabar o editar un nuevo registro en la Tabla Rumas
    Function GrabarRumas(ByVal rs As SAMAD.formato04_rumas, xExiste As Boolean) As Boolean
        If xExiste = True Then
            Return RumasEditar(rs)
        Else
            Return RumasAgregar(rs)
        End If
    End Function

#End Region

#Region "Consultas de Valores Booleanos"

    ''' <summary>
    ''' Funcion para Verificar si un codigo de Ruma ya Existe en el Periodo
    ''' </summary>
    ''' <param name="strRuma"></param>
    ''' <param name="strPeriodo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 

    Function RumaExiste(ByVal strRuma As String, strPeriodo As String) As Boolean
        Using dm As New samadEntities
            ' Dim nr = (From rs In dm.formato04_rumas Where rs.Codigo_ruma = strRuma Select rs.RowId).Count()
            'Return IIf(nr > 0, True, False)
            Dim nr = (From fr In dm.formato04_rumas From z In dm.formato04 Where fr.F04_Id = z.F04_Id And fr.Codigo_ruma = strRuma And z.F04_Periodo = strPeriodo Select fr.RowId).Count()
            Return IIf(nr > 0, True, False)
        End Using
    End Function

    ''' <summary>
    ''' Funcion para saber si una ruma tiene registros de detalle
    ''' </summary>
    ''' <param name="idRuma">Codigi de ruma a consultar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function RumaTieneDetalle(ByVal idRuma As Integer) As Boolean
        Using dm As New samadEntities
            Dim nr = dm.formato04_rumas_det.Where(Function(x) x.RumaId = idRuma).Select(Function(a) a.RumaId).Count()
            Return IIf(nr > 0, True, False)
        End Using
    End Function

#End Region

#End Region


#Region "Formato04_rumas_det"

#Region "Mantenimiento  (Altas, Bajas y Cambios)"

    ''' <summary>
    ''' Funcion para Grabar el Detalle de la Ruma
    ''' </summary>
    ''' <param name="rs"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function DetalleRumaGrabar(ByVal rs As SAMAD.formato04_rumas_det) As Boolean
        Using dm As New samadEntities
            Try
                dm.AddToformato04_rumas_det(rs)
                dm.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    ''' <summary>
    ''' Funcion para Editar el registro de un detalle de Ruma
    ''' </summary>
    ''' <param name="rs"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function DetalleRumaEditar(ByVal rs As SAMAD.formato04_rumas_det) As Boolean
        Using dm As New samadEntities
            Dim ra As SAMAD.formato04_rumas_det = (From x In dm.formato04_rumas_det Where x.RowId = rs.RowId Select x).First()
            dm.formato04_rumas_det.Detach(ra)
            Dim nr As New SAMAD.formato04_rumas_det
            Try
                nr.RowId = rs.RowId
                dm.formato04_rumas_det.Attach(nr)
                dm.formato04_rumas_det.ApplyCurrentValues(rs)
                dm.SaveChanges()
                Return True
            Catch ex As Exception
                dm.Refresh(Objects.RefreshMode.ClientWins, ra)
                Return False
            End Try
        End Using
    End Function

    ''' <summary>
    ''' Funcion para borrar el Registro de un detalle de Ruma, y Actualizar la Tabla Formato04_rumas
    ''' </summary>
    ''' <param name="iRowId">Id del Registro a borrar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function DetalleRumaBorrar(ByVal iRowId As Integer) As Boolean
        Using dm As New samadEntities
            Dim rumadetalle As SAMAD.formato04_rumas_det = (From x In dm.formato04_rumas_det Where x.RowId = iRowId Select x).First()

            Try
                Dim ruma As SAMAD.formato04_rumas = (From x In dm.formato04_rumas Where x.RowId = rumadetalle.RumaId Select x).First()
                ruma.Cantidad = ruma.Cantidad - rumadetalle.Cantidad
                ruma.VolM3 = ruma.VolM3 - rumadetalle.Vol_m3
                ruma.VolPT = ruma.VolPT - rumadetalle.Vol_pt
                dm.DeleteObject(rumadetalle)
                dm.SaveChanges()
                Return RumasEditar(ruma)
            Catch ex As Exception
                dm.Refresh(Objects.RefreshMode.ClientWins, rumadetalle)
                Return False
            End Try
        End Using
    End Function

    Function GrabarDetalleRuma(ByVal rs As SAMAD.formato04_rumas_det, xExiste As Boolean) As Boolean
        If xExiste = False Then
            'Nuevo registro
            Return DetalleRumaGrabar(rs)
        Else
            'Edita un registro Existente
            Return DetalleRumaEditar(rs)
        End If
    End Function
#End Region

#Region "Consulas Booleanas"
    Function EstadoEspecieEnProduccion(ByVal idEspecie As Integer, idOrden As Integer) As Boolean
        Using dm As New samadEntities
            'Dim xEstatus = (From x In dm.formato02_det Where x.EspecieId = idEspecie And x.F02d_F02_Id = idOrden Select x.Estatus).FirstOrDefault() '
            Dim xEstatus As vw_formato02a = dm.vw_formato02a.Where(Function(x) x.EspecieID = idEspecie And x.F02_NroDoc = idOrden).FirstOrDefault()
            Return IIf(xEstatus.Estatus = 0, False, True)
        End Using
    End Function

#End Region
#End Region

#Region "Funciones de Listas y Entidades"

    ''' <summary>
    ''' Lista de las Rumas que Pertenecen a una Production x
    ''' </summary>
    ''' <param name="xPapa"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ListaFormato04det(ByVal xPapa As Integer) As List(Of SAMAD.formato04_rumas)
        Using dm As New samadEntities
            Dim ls = (From t In dm.formato04_rumas Where t.F04_Id = xPapa Select t).ToList()
            Return ls
        End Using
    End Function

    'Funcion para mostrar el detalle de la produccion segun las rumas
    Function ListadeRumas(ByVal xPapa As Integer) As IList
        Using dm As New samadEntities
            ' lstContrato = (From c In dm.contratos.Include("titulares") Where c.Con_id = intId Select New With {.id = c.Con_id, c.Con_Descripcion, c.Con_Anno, c.Con_Pro_Id, c.titulares.Pro_Titular}).ToList()
            Dim ls = (From r In dm.formato04_rumas Where r.F04_Id = xPapa Select New With {.Id = r.RowId, .Codigo = r.Codigo_ruma, .Especie = r.EspecieId, .Lote = r.Lote_troza, .Cantidad = r.Cantidad, .VM3 = r.VolM3, .VPT = r.VolPT}).ToList()
            Return ls
        End Using
    End Function

    Function DetalledeRuma(ByVal xRumaId As Integer) As IList
        Using dm As New samadEntities
            Dim ls = (From r In dm.formato04_rumas_det Where r.RumaId = xRumaId Select New With {.Id = r.RowId, .Espesor = r.Espesor, .Ancho = r.Ancho, .Largo = r.Largo, .Cant = r.Cantidad, .VM3 = r.Vol_m3, .VPT = r.Vol_pt}).ToList()
            Return ls
        End Using
    End Function

    ''' <summary>
    ''' Funcio para seleccionar una RUMA
    ''' </summary>
    ''' <param name="intRumaId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetRumaById(ByVal intRumaId As Integer) As SAMAD.formato04_rumas
        Using dm As New samadEntities
            Dim dt As SAMAD.formato04_rumas = (From x In dm.formato04_rumas Where x.RowId = intRumaId Select x).First()
            Return dt
        End Using
    End Function

    Function GetNumeroRuma(ByVal strNumero As String) As SAMAD.vw_rumas_despacho
        Using dm As New samadEntities
            Dim dt As SAMAD.vw_rumas_despacho = (From rs In dm.vw_rumas_despacho Where rs.Codigo_ruma = strNumero And rs.Estatus = 0 Select rs).FirstOrDefault()
            Return dt
        End Using
    End Function
#End Region

#Region "Funciones Miscelaneas(No Ordenadas)"




    Function VistaRumas() As List(Of SAMAD.vw_rumas)
        Using dm As New samadEntities
            Dim ls = (From x In dm.vw_rumas Select x).ToList()
            Return ls
        End Using
    End Function

    ' - Buscar una ruma por su RowId
    Function BuscarRumaxId(ByVal xRowId As Integer) As Boolean
        Using dm As New samadEntities
            Dim cr = (From x In dm.formato04_rumas Where x.RowId = xRowId Select x.RowId).Count()
            Return IIf(cr > 0, True, False)
        End Using
    End Function

    Function CodigoLoteAserrio(ByVal strCodigo As String, strPeriodo As String, intTitular As String) As Boolean
        Using dm As New samadEntities
            Dim sn = (From rs In dm.formato04_rumas From fc In dm.formato04
                            Where fc.F04_Periodo + rs.Especie + rs.Codigo_ruma = strPeriodo + intTitular + strCodigo And rs.Objetivo_producto = "Producto para Venta" And rs.Estatus = 0 Select rs.Codigo_ruma).Count()
            Return IIf(sn > 0, True, False)
        End Using
    End Function
    Function VerificaRumaDespachada(ByVal strCodigo As String, strPeriodo As String, intTitular As String) As Boolean
        Dim prosigue As Boolean
        Using dm As New samadEntities
            Dim sm = (From rs In dm.vw_verificarumadespacho
            Where rs.periodo + rs.especie + rs.codigoruma = strPeriodo + intTitular + strCodigo And rs.objetivo = "Producto para Venta" Select rs.cuantos).Count()
            If sm > 0 Then
                MessageBox.Show("El lote de Aserrio o Paquete " + strCodigo + " ha sido despachada en su totalidad", "Despaho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                prosigue = False
            ElseIf CodigoLoteAserrio(strCodigo, strPeriodo, intTitular) = False Then
                MessageBox.Show("El lote de Aserrio o Paquete " + strCodigo + " no esta disponible para este despacho", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                prosigue = False
            Else
                prosigue = True
            End If

            Return prosigue  'IIf(sm > 0, True, False)
        End Using
    End Function


    ''' <summary>
    ''' Funcion para listar el detalle de una Ruma
    ''' </summary>
    ''' <param name="xRumaId">Ruma a seleccionar el detalle</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function RumaDetalle(ByVal xRumaId As Integer) As List(Of SAMAD.formato04_rumas_det)
        Using dm As New samadEntities
            Dim ls = (From rs In dm.formato04_rumas_det Where rs.RumaId = xRumaId Select rs).ToList()
            Return ls
        End Using
    End Function

    ''' <summary>
    ''' Funcion para borrar un registro de la Tabla Formato04_rumas
    ''' </summary>
    ''' <param name="idRuma">Id del Registro a Borrar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function BorrarRuma(ByVal idRuma As Integer) As Boolean
        Using dm As New samadEntities
            Dim dt As SAMAD.formato04_rumas = (From rs In dm.formato04_rumas Where rs.RowId = idRuma Select rs).First()
            dm.DeleteObject(dt)
            Try
                dm.SaveChanges()
                Return True
            Catch ex As Exception
                dm.Refresh(Objects.RefreshMode.ClientWins, dt)
                Return False
            End Try
        End Using
    End Function

    ''' <summary>
    ''' Funcionn para actualizar los valores de la tabla Rumas
    ''' </summary>
    ''' <param name="intRumaId"></param>
    ''' <param name="Volm3"></param>
    ''' <param name="volpt"></param>
    ''' <param name="Cantpieza"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ActualizaM3Rumas(ByVal intRumaId As Integer, Volm3 As Decimal, volpt As Decimal, Cantpieza As Integer, ckCierre As Integer) As Boolean
        Dim dt = GetRumaById(intRumaId)
        dt.VolM3 = dt.VolM3 + Volm3
        dt.VolPT = dt.VolPT + volpt
        dt.Estatus = ckCierre
        dt.Cantidad = dt.Cantidad + Cantpieza
        Return RumasEditar(dt)
    End Function
#End Region


End Class