Imports MySql.Data.MySqlClient
Public Class fformato04
    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando

    Public Function mostrar() As DataTable
        Try
            conectado() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_formato04") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

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
            desconectado()
        End Try
    End Function

    Public Function insertar(ByVal dts As vFormato04) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("insertar_formato04") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vfecha", dts.gf04_fecha)
            cmd.Parameters.AddWithValue("vcertificada", dts.gf04_certificada)
            cmd.Parameters.AddWithValue("vnro", dts.gf04_nro)
            cmd.Parameters.AddWithValue("vcreacion", dts.gf04_creacion)
            cmd.Parameters.AddWithValue("vtipoconteo", dts.gf04_tipoconteo)
            cmd.Parameters.AddWithValue("vtipocubicacion_id", dts.gf04_tipocubicacion_id)
            cmd.Parameters.AddWithValue("vturno_id", dts.gf04_turno_id)
            cmd.Parameters.AddWithValue("vresponsable_id", dts.gf04_responsable_id)
            cmd.Parameters.AddWithValue("vordenproduccion", dts.gf04_ordenproduccion)
            cmd.Parameters.AddWithValue("vobservacion", dts.gf04_observacion)
            cmd.Parameters.AddWithValue("vf02_id", dts.gf04_F02_id)
            cmd.Parameters.AddWithValue("vperiodo", dts.gf04_periodo)
            cmd.Parameters.AddWithValue("vtitular", dts.gf04_pro_id)
            cmd.Parameters.AddWithValue("vseguimiento", dts.gf04_seguimiento)

            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("formato04", "Insertar", id, dts.gf04_nro)
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

    Public Function editar(ByVal dts As vFormato04) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("editar_formato04") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.gf04_id)
            cmd.Parameters.AddWithValue("vfecha", dts.gf04_fecha)
            cmd.Parameters.AddWithValue("vcertificada", dts.gf04_certificada)
            cmd.Parameters.AddWithValue("vnro", dts.gf04_nro)
            cmd.Parameters.AddWithValue("vcreacion", dts.gf04_creacion)
            cmd.Parameters.AddWithValue("vtipoconteo", dts.gf04_tipoconteo)
            cmd.Parameters.AddWithValue("vtipocubicacion_id", dts.gf04_tipocubicacion_id)
            cmd.Parameters.AddWithValue("vturno_id", dts.gf04_turno_id)
            cmd.Parameters.AddWithValue("vresponsable_id", dts.gf04_responsable_id)
            cmd.Parameters.AddWithValue("vordenproduccion", dts.gf04_ordenproduccion)
            cmd.Parameters.AddWithValue("vobservacion", dts.gf04_observacion)
            cmd.Parameters.AddWithValue("vf02_id", dts.gf04_F02_id)
            cmd.Parameters.AddWithValue("vperiodo", dts.gf04_periodo)
            cmd.Parameters.AddWithValue("vtitular", dts.gf04_pro_id)
            cmd.Parameters.AddWithValue("vseguimiento", dts.gf04_seguimiento)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("formato04", "Editar", dts.gf04_id, dts.gf04_nro)
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

    Public Function eliminar(ByVal dts As vFormato04) As Boolean
        Try
            conectado()
            cmd = New MySqlCommand("eliminar_formato04") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("vid", MySqlDbType.VarChar, 50).Value = dts.gf04_id

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("formato04", "Editar", dts.gf04_id, "")
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


Public Class cdFormato04

#Region "Mantenimiento a la Tabla Formato04(Altas,Bajas y Cambios)"

    ''' <summary>
    ''' Funcion para agregar un nuevo registro a la tabla Formato04
    ''' </summary>
    ''' <param name="rs"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Formato04Agregar(ByVal rs As SAMAD.formato04) As Boolean
        Using dm As New samadEntities
            Try
                dm.AddToformato04(rs)
                dm.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    ''' <summary>
    ''' Funcion para Editar un registro de la tabla Formato04
    ''' </summary>
    ''' <param name="rs"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Formato04Editar(ByVal rs As SAMAD.formato04) As Boolean
        Using dm As New samadEntities
            ' obtenemos el Registro antes de modificarlo
            Dim ra As SAMAD.formato04 = (From v In dm.formato04 Where v.F04_Id = rs.F04_Id Select v).First()
            dm.formato04.Detach(ra)
            Dim rn As New SAMAD.formato04
            Try
                rn.F04_Id = rs.F04_Id
                dm.formato04.Attach(rn)
                dm.formato04.ApplyCurrentValues(rs)
                dm.SaveChanges()
                Return True
            Catch ex As Exception
                dm.Refresh(Objects.RefreshMode.ClientWins, ra)
                dm.SaveChanges()
                Return False
            End Try
        End Using
    End Function

    ''' <summary>
    ''' Funcion para Grabar o editar un registro en la Tabla Formato04
    ''' </summary>
    ''' <param name="rs"></param>
    ''' <param name="xExiste">True Editar, False agregar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GrabarEnFormato04(ByVal rs As SAMAD.formato04, xExiste As Boolean) As Boolean
        If xExiste = True Then
            Return Formato04Editar(rs)
        Else
            Return Formato04Agregar(rs)
        End If
    End Function
#End Region



#Region "Funciones Miscelaneas"
   

    ''' <summary>
    ''' Funcion para validar si una produccion tiene Rumas
    ''' </summary>
    ''' <param name="intPapaRuma"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ProduccionRumas(ByVal intPapaRuma As Integer) As Boolean
        Using dm As New samadEntities
            Dim nr = (From x In dm.formato04_rumas Where x.F04_Id = intPapaRuma Select x.F04_Id).Count()
            Return IIf(nr > 0, True, False)
        End Using
    End Function


   

#End Region

End Class