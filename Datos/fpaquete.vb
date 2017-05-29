Imports MySql.Data.MySqlClient
Public Class fPaquete
    Inherits conexion
    Dim cmd As New MySqlCommand

    Public Function buscarPaquete(ByVal dts As vPaquete) As DataTable
        Try
            CONECTADO()
            cmd = New MySqlCommand("buscar_paquete")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("vPaq_Numero", dts.gPaq_Numero)

            Dim da As New MySqlDataAdapter(cmd)

            Dim dt As New DataTable
            da.Fill(dt)

            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            DESCONECTADO()
        End Try
    End Function

    Public Function mostrarDetalle(ByVal dts As vPaquete) As DataTable
        Try
            CONECTADO()
            cmd = New MySqlCommand("mostrar_paquete")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("vPaq_Emp_Id", dts.gPaq_Emp_id)

            Dim da As New MySqlDataAdapter(cmd)

            Dim dt As New DataTable
            da.Fill(dt)
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            DESCONECTADO()
        End Try
    End Function

    Public Function insertar(ByVal dts As vPaquete) As Boolean
        Try
            CONECTADO()
            cmd = New MySqlCommand("insertar_paquete") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos 
            cmd.Parameters.AddWithValue("vPaq_Emp_id", dts.gPaq_Emp_id)
            cmd.Parameters.AddWithValue("vPaq_Numero", dts.gPaq_Numero)
            cmd.Parameters.AddWithValue("vPaq_Especie", dts.gPaq_Especie)
            cmd.Parameters.AddWithValue("vPaq_TipoProducto", dts.gPaq_TipoProducto)
            cmd.Parameters.AddWithValue("vPaq_Acabado", dts.gPaq_Acabado)
            cmd.Parameters.AddWithValue("vPaq_Humedad", dts.gPaq_Humedad)
            cmd.Parameters.AddWithValue("vPaq_Clasificacion", dts.gPaq_Clasificacion)
            cmd.Parameters.AddWithValue("vPaq_CubicadorId", dts.gPaq_CubicadorId)
            cmd.Parameters.AddWithValue("vPaq_Ubicacion", dts.gPaq_Ubicacion)
            cmd.Parameters.AddWithValue("vPaq_Observacion", dts.gPaq_Observacion)

            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("paquete", "Insertar", id, dts.gPaq_Numero)
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

    Public Function editar(ByVal dts As vPaquete) As Boolean

        Try
            CONECTADO()
            cmd = New MySqlCommand("editar_paquete") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos 
            cmd.Parameters.AddWithValue("vPaq_Id", dts.gPaq_id)
            cmd.Parameters.AddWithValue("vPaq_Emp_id", dts.gPaq_Emp_id)
            cmd.Parameters.AddWithValue("vPaq_Numero", dts.gPaq_Numero)
            cmd.Parameters.AddWithValue("vPaq_Especie", dts.gPaq_Especie)
            cmd.Parameters.AddWithValue("vPaq_TipoProducto", dts.gPaq_TipoProducto)
            cmd.Parameters.AddWithValue("vPaq_Acabado", dts.gPaq_Acabado)
            cmd.Parameters.AddWithValue("vPaq_Humedad", dts.gPaq_Humedad)
            cmd.Parameters.AddWithValue("vPaq_Clasificacion", dts.gPaq_Clasificacion)
            cmd.Parameters.AddWithValue("vPaq_CubicadorId", dts.gPaq_CubicadorId)
            cmd.Parameters.AddWithValue("vPaq_Ubicacion", dts.gPaq_Ubicacion)
            cmd.Parameters.AddWithValue("vPaq_Observacion", dts.gPaq_Observacion)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("paquete", "Editar", dts.gPaq_id, dts.gPaq_Numero)
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

    Public Function eliminar(ByVal dts As vPaquete) As Boolean

        Try
            CONECTADO()
            cmd = New MySqlCommand("eliminar_paquete") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos 
            cmd.Parameters.AddWithValue("vPaq_id", dts.gPaq_id)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("paquete", "Eliminar", dts.gPaq_id, "")
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