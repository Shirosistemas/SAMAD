Imports MySql.Data.MySqlClient

Public Class fusuarios
    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando

    Public Function conectar() As Boolean
        Try
            Return conectado() 'Nos conectamos a la BD
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function mostrar() As DataTable
        Try
            CONECTADO() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_usuarios") 'Llamamos al procedimiento almacenado
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
            DESCONECTADO()
        End Try
    End Function

    Public Function Login(ByVal usuario As String, ByVal password As String) As DataTable
        Try
            conectado() 'Nos conectamos a la BD
            cmd = New MySqlCommand("Select * from usuarios where usu_nombre='" & usuario & "' And usu_password='" & password & "'")
            cmd.CommandType = CommandType.Text

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

    Public Function insertar(ByVal dts As vUsuario) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("insertar_usuario") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vnombre", dts.gnombre)
            cmd.Parameters.AddWithValue("vpassword", dts.gpassword)
            cmd.Parameters.AddWithValue("vtipo", dts.gtipo)

            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("usuarios", "Insertar", id, dts.gnombre)
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

    Public Function editar(ByVal dts As vUsuario) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("editar_usuario") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.gus_id)
            cmd.Parameters.AddWithValue("vnombre", dts.gnombre)
            cmd.Parameters.AddWithValue("vpassword", dts.gpassword)
            cmd.Parameters.AddWithValue("vtipo", dts.gtipo)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("usuarios", "Editar", dts.gus_id, dts.gnombre)
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

    Public Function eliminar(ByVal dts As vUsuario) As Boolean
        Try
            conectado()
            cmd = New MySqlCommand("eliminar_usuarios") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("uid", MySqlDbType.VarChar, 50).Value = dts.gus_id

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("usuarios", "Eliminar", dts.gus_id, "")
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

#Region "Nuevo Codigo"

    ''' <summary>
    ''' Lista los Usuarios de la Tabla Usuarios
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function lstUsuarios() As List(Of SAMAD.usuarios)
        Using db As New samadEntities
            Dim lst = (From rs In db.usuarios Select rs).ToList()
            Return lst
        End Using
    End Function

    ''' <summary>
    ''' Funcion que retorna los datos del usuario pasado por parametro
    ''' </summary>
    ''' <param name="strUser">Nombre de Usuario</param>
    ''' <returns>datatable</returns>
    ''' <remarks></remarks>
    Function dtUsuario(ByVal strUser As String) As usuarios
        Using db As New samadEntities
            Dim dt = (From rs In db.usuarios Where rs.usu_nombre = strUser Select rs).First()
            Return dt
        End Using
    End Function

    ''' <summary>
    ''' Function para verificar si un Usuario Existe en la Tabla usuarios
    ''' </summary>
    ''' <param name="strUsername">Usuario a buscar en el registro</param>
    ''' <returns>True or False</returns>
    ''' <remarks></remarks>
    Function UsuarioExiste(ByVal strUsername As String) As Boolean
        Using db As New samadEntities()
            Dim xCantidad = (From rs In db.usuarios Where rs.usu_nombre = strUsername Select rs).Count()
            Return IIf(xCantidad > 0, True, False)
        End Using
    End Function

    

#End Region
End Class
