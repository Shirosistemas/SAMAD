Imports MySql.Data.MySqlClient
Public Class fdeffs
    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando

    Public Function mostrar() As DataTable
        Try
            conectado() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_deffs") 'Llamamos al procedimiento almacenado
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
            MsgBox("Mensaje2:" + ex.ToString)
            Return Nothing 'Retornamos nada
        Finally
            desconectado()
        End Try
    End Function

    Public Function insertar(ByVal dts As vDeffs) As Boolean

        Try
            CONECTADO()
            cmd = New MySqlCommand("insertar_deffs") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vsede", dts.gsede)

            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("deffs", "Insertar", id, dts.gsede)
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

    Public Function editar(ByVal dts As vDeffs) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("editar_deffs") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.gdefid)
            cmd.Parameters.AddWithValue("vsede", dts.gsede)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("deffs", "Editar", dts.gdefid, dts.gsede)
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

    Public Function eliminar(ByVal dts As vDeffs) As Boolean
        Try
            conectado()
            cmd = New MySqlCommand("eliminar_deffs") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("vid", MySqlDbType.VarChar, 50).Value = dts.gdefid

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("deffs", "Eliminar", dts.gdefid, "")
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
    ''' Funcion para validar si un Registro Deff ya existe
    ''' </summary>
    ''' <param name="strDef">Deff a Validar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function DeffExiste(ByVal strDef As String) As Boolean
        Using dm As New samadEntities
            Dim nr = (From d In dm.deffs Where d.def_Sede = strDef Select d.def_Sede).Count()
            Return IIf(nr > 0, True, False)
        End Using
    End Function
End Class
