Imports MySql.Data.MySqlClient
Public Class fformato01

    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando

    Public Function mostrar() As DataTable
        Try
            conectado() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_formato01") 'Llamamos al procedimiento almacenado
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

    ' - Esta funcion puede descartarse, se sustituye con la Funcion Formato01Grabar
    Public Function insertar(ByVal dts As vFormato01) As Boolean
        Try
            conectado()
            cmd = New MySqlCommand("insertar_formato01") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vfecha", dts.gf01_fecha)
            cmd.Parameters.AddWithValue("vcertificada", dts.gf01_certificada)
            cmd.Parameters.AddWithValue("vnro", dts.gf01_nro)
            cmd.Parameters.AddWithValue("vresponsable", dts.gf01_responsable)
            cmd.Parameters.AddWithValue("vobservacion", dts.gf01_observacion)
            cmd.Parameters.AddWithValue("vtipotraslado", dts.gf01_tipotraslado)
            cmd.Parameters.AddWithValue("vtitular", dts.gf01_titular)
            cmd.Parameters.AddWithValue("vperiodo", dts.gf01_periodo)
            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("formato01", "Insertar", id, dts.gf01_nro)
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

    ' - Esta Funcion de Editar puede descartarse, ya que se sustituye por la funcion Formato01Editar
    Public Function editar(ByVal dts As vFormato01) As Boolean
        Try
            conectado()
            cmd = New MySqlCommand("editar_formato01") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.gf01_id)
            cmd.Parameters.AddWithValue("vfecha", dts.gf01_fecha)
            cmd.Parameters.AddWithValue("vcertificada", dts.gf01_certificada)
            cmd.Parameters.AddWithValue("vnro", dts.gf01_nro)
            cmd.Parameters.AddWithValue("vresponsable", dts.gf01_responsable)
            cmd.Parameters.AddWithValue("vobservacion", dts.gf01_observacion)
            cmd.Parameters.AddWithValue("vtipotraslado", dts.gf01_tipotraslado)
            cmd.Parameters.AddWithValue("vtitular", dts.gf01_titular)
            cmd.Parameters.AddWithValue("vperiodo", dts.gf01_periodo)
            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("formato01", "Editar", dts.gf01_id, dts.gf01_nro)
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


    Public Function eliminar(ByVal dts As vFormato01) As Boolean
        Try
            conectado()
            cmd = New MySqlCommand("eliminar_formato01") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("vid", MySqlDbType.VarChar, 50).Value = dts.gf01_id

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("formato01", "Eliminar", dts.gf01_id, "")
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

Public Class cdFormato01

#Region "Natenimiento a la Tabla Formato01(Altas, Bajas y Cambios)"

    ''' <summary>
    ''' Funcion para agregar un Nuevo registro a la Tabla Formato01
    ''' </summary>
    ''' <param name="rs">entidad.formato01</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Formato01Grabar(ByVal rs As SAMAD.formato01) As Boolean
        Using dm As New samadEntities
            Try
                dm.AddToformato01(rs)
                dm.SaveChanges()
                fauditoria.insertar("formato01", "insertar", rs.F01_id, rs.F01_Nro)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    ''' <summary>
    ''' Funcion para editar un registro de la Tabla formato01
    ''' </summary>
    ''' <param name="rs">entidad.formato01</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Formato01Editar(ByVal rs As SAMAD.formato01) As Boolean
        Using dm As New samadEntities
            'Dim ra As SAMAD.formato01 = (From f In dm.formato01 Where f.F01_id = rs.F01_id Select f).First()
            Dim rn As New SAMAD.formato01
            Try
                rn.F01_id = rs.F01_id
                dm.formato01.Attach(rn)
                'dm.formato01.ApplyCurrentValues(rs)
                dm.SaveChanges()
                fauditoria.insertar("formato01", "Editar", rs.F01_id, rs.F01_Nro)
                Return True
            Catch ex As Exception
                'dm.Refresh(Objects.RefreshMode.ClientWins, ra)
                'dm.SaveChanges()
                Return False
            End Try
        End Using
    End Function
#End Region

#Region "Funciones Miscelaneas"

    ''' <summary>
    ''' Funcion para obtener el Numero de lote mayor segun el periodo
    ''' </summary>
    ''' <param name="xPeriodo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function NumeroLote(ByVal xPeriodo As Integer) As String
        Using dm As New samadEntities
            Dim nl = (From rs In dm.formato01 Where rs.F01_periodo = xPeriodo Select rs.F01_Lote).Max()
            Return nl
        End Using
    End Function
#End Region
End Class