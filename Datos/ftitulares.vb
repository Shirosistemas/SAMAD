Imports MySql.Data.MySqlClient

Public Class ftitulares

    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando

    Public Function mostrar() As DataTable
        Try
            conectado() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_titulares") 'Llamamos al procedimiento almacenado
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

    Public Function insertar(ByVal dts As vTitulares) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("insertar_titulares") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vtitular", dts.gtitular)
            cmd.Parameters.AddWithValue("vdni", dts.gdni)
            cmd.Parameters.AddWithValue("vruc", dts.gruc)
            cmd.Parameters.AddWithValue("vreplegal", dts.grepresentante_legal)
            cmd.Parameters.AddWithValue("vdepartamento", dts.gdepartamento)
            cmd.Parameters.AddWithValue("vprovincia", dts.gprovincia)
            cmd.Parameters.AddWithValue("vdistrito", dts.gdistrito)
            cmd.Parameters.AddWithValue("vsector", dts.gsector)
            cmd.Parameters.AddWithValue("vpropietariock", dts.gpropietariock)
            cmd.Parameters.AddWithValue("vdestinock", dts.gdestinock)
            cmd.Parameters.AddWithValue("vtransporteck", dts.gtransporteck)
            cmd.Parameters.AddWithValue("vdireccion", dts.gdireccion)

            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("titulares", "Insertar", id, dts.gtitular)
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

    Public Function editar(ByVal dts As vTitulares) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("editar_titulares") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.gproid)
            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vtitular", dts.gtitular)
            cmd.Parameters.AddWithValue("vdni", dts.gdni)
            cmd.Parameters.AddWithValue("vruc", dts.gruc)
            cmd.Parameters.AddWithValue("vreplegal", dts.grepresentante_legal)
            cmd.Parameters.AddWithValue("vdepartamento", dts.gdepartamento)
            cmd.Parameters.AddWithValue("vprovincia", dts.gprovincia)
            cmd.Parameters.AddWithValue("vdistrito", dts.gdistrito)
            cmd.Parameters.AddWithValue("vsector", dts.gsector)
            cmd.Parameters.AddWithValue("vpropietariock", dts.gpropietariock)
            cmd.Parameters.AddWithValue("vdestinock", dts.gdestinock)
            cmd.Parameters.AddWithValue("vtransporteck", dts.gtransporteck)
            cmd.Parameters.AddWithValue("vdireccion", dts.gdireccion)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("titulares", "Editar", dts.gproid, dts.gtitular)
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

    Public Function eliminar(ByVal dts As vTitulares) As Boolean
        Try
            Dim db As New samadEntities
            Dim id As Integer = dts.gproid
            Dim numpro = db.procesos.Where(Function(p) p.Pro_id = id).Count()
            If numpro > 0 Then
                MessageBox.Show("Esta Entidad Posee " + numpro.ToString() + " Procesos Configurados, Elimine Primero los Procesos antes de Eliminar la entidad", "Eliminar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return True
            End If
            conectado()
            cmd = New MySqlCommand("eliminar_titulares") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("vid", MySqlDbType.VarChar, 50).Value = dts.gproid

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("titulares", "Eliminar", dts.gproid, "")
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
    ''' Funcion para validar si el Numero RUC de un Titular ya existe registrado
    ''' </summary>
    ''' <param name="strRuc">Numero Ruc a Validar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function NumeroRucExiste(ByVal strRuc As String) As Boolean
        Using dm As New samadEntities
            Dim nr = (From t In dm.titulares Where t.Pro_Ruc = strRuc Select t.Pro_Ruc).Count()
            Return IIf(nr > 0, True, False)
        End Using
    End Function

    Function NomTitularExiste(ByVal NomTitular As String) As Boolean
        Using dm As New samadEntities
            Dim nr = (From t In dm.titulares Where t.Pro_Titular = NomTitular Select t.Pro_Titular).Count()
            Return IIf(nr > 0, True, False)
        End Using
    End Function

    ''' <summary>
    ''' Funcion para validar si el Titular existe en listatrozasc
    ''' </summary>
    ''' <param name="idTitular">Id titular a validar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function TitularEnListaTrozasc(ByVal idTitular As Integer) As Boolean
        Using dm As New samadEntities
            Dim nr = (From lt In dm.listatrozasc Where lt.Lt_Titular_Id = idTitular Select lt.Lt_Titular_Id).Count()
            Return IIf(nr > 0, True, False)
        End Using
    End Function
End Class
