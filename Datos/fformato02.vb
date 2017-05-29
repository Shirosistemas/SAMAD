Imports MySql.Data.MySqlClient
Public Class fformato02
    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando

    Public Function mostrar() As DataTable
        Try
            conectado() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_formato02") 'Llamamos al procedimiento almacenado
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

    Public Function insertar(ByVal dts As vFormato02) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("insertar_formato02") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vfecha", dts.gf02_fecha)
            cmd.Parameters.AddWithValue("vcertificada", dts.gf02_certificada)
            cmd.Parameters.AddWithValue("vnrodoc", dts.gf02_nrodoc)
            cmd.Parameters.AddWithValue("vresponsable", dts.gf02_responsableid)
            cmd.Parameters.AddWithValue("vobservacion", dts.gf02_observacion)
            cmd.Parameters.AddWithValue("vnroope", dts.gf02_nroope)
            cmd.Parameters.AddWithValue("vturnoid", dts.gf02_turnoid)
            cmd.Parameters.AddWithValue("vproc_id", dts.gf02_proc_id)
            cmd.Parameters.AddWithValue("vperiodo", dts.gf02_periodo)
            cmd.Parameters.AddWithValue("vemp_id", dts.gf02_emp_id)
            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("formato02", "Insertar", id, dts.gf02_nrodoc)
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

    Public Function editar(ByVal dts As vFormato02) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("editar_formato02") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.gf02_id)
            cmd.Parameters.AddWithValue("vfecha", dts.gf02_fecha)
            cmd.Parameters.AddWithValue("vcertificada", dts.gf02_certificada)
            cmd.Parameters.AddWithValue("vnrodoc", dts.gf02_nrodoc)
            cmd.Parameters.AddWithValue("vresponsable", dts.gf02_responsableid)
            cmd.Parameters.AddWithValue("vobservacion", dts.gf02_observacion)
            cmd.Parameters.AddWithValue("vnroope", dts.gf02_nroope)
            cmd.Parameters.AddWithValue("vturnoid", dts.gf02_turnoid)
            cmd.Parameters.AddWithValue("vproc_id", dts.gf02_proc_id)
            cmd.Parameters.AddWithValue("vperiodo", dts.gf02_periodo)
            cmd.Parameters.AddWithValue("vemp_id", dts.gf02_emp_id)
            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("formato02", "Editar", dts.gf02_id, dts.gf02_nrodoc)
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

    Public Function eliminar(ByVal dts As vFormato02) As Boolean
        Try
            conectado()
            cmd = New MySqlCommand("eliminar_formato02") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("vid", MySqlDbType.VarChar, 50).Value = dts.gf02_id

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("formato02", "Eliminar", dts.gf02_id, "")
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

Public Class cdFormato02


#Region "Mantenimiento a la tabla Formato02(Alts, Bajas y Cambios)"


#End Region


#Region "Funciones Miscelaneas"

    ''' <summary>
    ''' Funcion para generar el Numero de Lote de Corte (Consecutivo segun el Periodo)
    ''' </summary>
    ''' <param name="xPeriodo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function NumeroLote(ByVal xPeriodo As Integer) As String
        'Using dm As New samadEntities
        '    Dim nl = (From rs In dm.formato02 Where rs.f02_periodo = xPeriodo Select rs.Lote_corte).Max()
        '    Return nl
        'End Using
        Return False
    End Function
#End Region
End Class