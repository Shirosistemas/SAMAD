Imports MySql.Data.MySqlClient

Public Class fconductores
    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando

    Public Function mostrar() As DataTable
        Try
            CONECTADO() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_conductores") 'Llamamos al procedimiento almacenado
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
            DESCONECTADO()
        End Try
    End Function

    Public Function insertar(ByVal dts As vConductores) As Boolean

        Try
            CONECTADO()
            cmd = New MySqlCommand("insertar_conductores") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vconnomape", dts.gconnomape)
            cmd.Parameters.AddWithValue("vconnrolicencia", dts.gconnrolicencia)
            cmd.Parameters.AddWithValue("vcondni", dts.gcondni)
            cmd.Parameters.AddWithValue("vconemtid", dts.gconemtid)

            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("conductores", "Insertar", id, dts.gconnomape)
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

    Public Function editar(ByVal dts As vConductores) As Boolean

        Try
            CONECTADO()
            cmd = New MySqlCommand("editar_conductores") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.gconid)
            cmd.Parameters.AddWithValue("vconnomape", dts.gconnomape)
            cmd.Parameters.AddWithValue("vconnrolicencia", dts.gconnrolicencia)
            cmd.Parameters.AddWithValue("vcondni", dts.gcondni)
            cmd.Parameters.AddWithValue("vconemtid", dts.gconemtid)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("conductores", "Editar", dts.gconid, dts.gconnomape)
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

    Public Function eliminar(ByVal dts As vConductores) As Boolean
        Try
            CONECTADO()
            cmd = New MySqlCommand("eliminar_conductores") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("vid", MySqlDbType.VarChar, 50).Value = dts.gconid

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("conductores", "Eliminar", dts.gconid, "")
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


#Region "Mantenimiento a la Tabla de Conductores(Altas, Bajs y cambios)"

    ''' <summary>
    ''' Funcion para validar si el codigo Conductor Existe en la Tabla Listatrozasc
    ''' </summary>
    ''' <param name="intConductor">Id conductor a validar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ConductorListaTrozasc(ByVal intConductor As Integer) As Boolean
        Using dm As New samadEntities
            Dim nr = (From ltc In dm.listatrozasc Where ltc.Lt_Conductor_Id = intConductor Select ltc.Lt_Conductor_Id).Count()
            Return IIf(nr > 0, True, False)
        End Using
    End Function

#End Region


End Class



Public Class cdConductores


    Function GetNombreConductor(ByVal idConductor As Integer) As String
        Using dm As New samadEntities
            Dim nc = (From rs In dm.conductores Where rs.Con_Id = idConductor Select rs.Con_NomApe).FirstOrDefault()
            Return nc
        End Using
    End Function
End Class