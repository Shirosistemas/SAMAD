Imports MySql.Data.MySqlClient
Public Class fvehiculos
    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando

    Public Function mostrar() As DataTable
        Try
            conectado() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_vehiculos") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

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

    Public Function insertar(ByVal dts As vVehiculos) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("insertar_vehiculos") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vvehemtid", dts.gvehemtid)
            cmd.Parameters.AddWithValue("vvehmarca", dts.gvehmarca)
            cmd.Parameters.AddWithValue("vtipovehic", dts.gvtipovehic)
            cmd.Parameters.AddWithValue("vvehplaca", dts.gvehplaca)
            cmd.Parameters.AddWithValue("vvehnroinscripcion", dts.gvehnroinscripcion)
            cmd.Parameters.AddWithValue("vvehtipo", dts.gvehtipo)

            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("vehiculos", "Insertar", id, dts.gvehplaca)
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

    Public Function editar(ByVal dts As vVehiculos) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("editar_vehiculos") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.gvehid)
            cmd.Parameters.AddWithValue("vvehemtid", dts.gvehemtid)
            cmd.Parameters.AddWithValue("vvehmarca", dts.gvehmarca)
            cmd.Parameters.AddWithValue("vtipovehic", dts.gvtipovehic)
            cmd.Parameters.AddWithValue("vvehplaca", dts.gvehplaca)
            cmd.Parameters.AddWithValue("vvehnroinscripcion", dts.gvehnroinscripcion)
            cmd.Parameters.AddWithValue("vvehtipo", dts.gvehtipo)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("vehiculos", "Editar", dts.gvehid, dts.gvehplaca)
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

    Public Function eliminar(ByVal dts As vVehiculos) As Boolean
        Try
            conectado()
            cmd = New MySqlCommand("eliminar_vehiculos") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("vid", MySqlDbType.VarChar, 50).Value = dts.gvehid

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("vehiculos", "Eliminar", dts.gvehid, "")
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

    ''' <summary>
    ''' Funcion para validar si el Numero de Placa asignado a un vehiculo ya existe
    ''' </summary>
    ''' <param name="strPlaca">Numero Placa a Validar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function PlacaVehiculoExiste(ByVal strPlaca As String) As Boolean
        Using dm As New samadEntities
            Dim nr = (From v In dm.vehiculos Where v.Veh_Placa = strPlaca Select v.Veh_Placa).Count()
            Return IIf(nr > 0, True, False)
        End Using
    End Function

    ''' <summary>
    ''' Funcion para validar si el Id de Vehiculo esta Asignado en la tabla Listatrozasc
    ''' </summary>
    ''' <param name="intId">Codigo de Vehiculo a validar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function VehiculoEnListaTrozasc(ByVal intId As Integer) As Boolean
        Using dm As New samadEntities
            Dim nr = (From v In dm.listatrozasc Where v.Lt_Transporte_Id = intId Select v.Lt_Transporte_Id).Count()
            Return IIf(nr > 0, True, False)
        End Using
    End Function
End Class
