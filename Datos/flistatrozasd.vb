Imports System.Data.EntityClient
Imports MySql.Data.MySqlClient
Public Class flistatrozasd

    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando

    Public Function mostrar(ByVal dts As vListatrozasd) As DataTable
        Try
            CONECTADO() 'Nos conectamos a la BD

            cmd = New MySqlCommand("mostrar_listatrozasd") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("vltd_ltid", dts.gltd_ltid)

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

    Public Function insertar(ByVal dts As vListatrozasd) As Boolean

        Try
            CONECTADO()
            cmd = New MySqlCommand("insertar_listatrozasd") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vespecie", dts.gltdespecie)
            cmd.Parameters.AddWithValue("vcodificacion", dts.gltdcodificacion)
            cmd.Parameters.AddWithValue("vd1", dts.gltdd1)
            cmd.Parameters.AddWithValue("vd2", dts.gltdd2)
            cmd.Parameters.AddWithValue("vd3", dts.gltdd3)
            cmd.Parameters.AddWithValue("vvolm3", dts.gltdvolm3)
            cmd.Parameters.AddWithValue("vltid", dts.gltd_ltid)
            cmd.Parameters.AddWithValue("vnrolistatrozas", dts.gltdnrolistatrozas)

            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("listatrozasd", "Insertar", id, dts.gltdcodificacion)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return False
        Finally
            DESCONECTADO()
        End Try

    End Function

    Public Function editar(ByVal dts As vListatrozasd) As Boolean

        Try
            CONECTADO()
            cmd = New MySqlCommand("editar_listatrozasd") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.gltdid)
            cmd.Parameters.AddWithValue("vespecie", dts.gltdespecie)
            cmd.Parameters.AddWithValue("vcodificacion", dts.gltdcodificacion)
            cmd.Parameters.AddWithValue("vd1", dts.gltdd1)
            cmd.Parameters.AddWithValue("vd2", dts.gltdd2)
            cmd.Parameters.AddWithValue("vd3", dts.gltdd3)
            cmd.Parameters.AddWithValue("vvolm3", dts.gltdvolm3)
            cmd.Parameters.AddWithValue("vltid", dts.gltd_ltid)
            cmd.Parameters.AddWithValue("vnrolistatrozas", dts.gltdnrolistatrozas)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("listatrozasd", "Editar", dts.gltdid, dts.gltdcodificacion)
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

    Public Function editar_autogenerado(ByVal dts As vListatrozasd) As Boolean
        Try
            CONECTADO()
            cmd = New MySqlCommand("editar_autogenerado") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.gltdid)
            cmd.Parameters.AddWithValue("vautogenerado", dts.gltdautogenerado)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("listatrozasd", "Editar", dts.gltdid, "Autogenerado: " + dts.gltdautogenerado)
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

    Public Function eliminar(ByVal dts As vListatrozasd) As Boolean
        Try
            CONECTADO()
            cmd = New MySqlCommand("eliminar_listatrozasd") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("vid", MySqlDbType.VarChar, 50).Value = dts.gltdid

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("listatrozasd", "Eliminar", dts.gltdid, "")
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

'dataTransferir.DataSource = (From t In db.listatrozasd From z In db.zafrasypoas
'                                            Where t.listatrozasc.Lt_Poa_Id = z.Zyp_id And z.Zyp_Zafra = zafr And z.Zyp_Permiso_Id = id And
'                                            String.IsNullOrEmpty(t.Ltd_Autogenerado) Select t).ToList()

Public Class cdListatrozasd

#Region "Mantenimiento a la Tabla listatrozasd(Altas, Bajas y Cambios)"

    ''' <summary>
    ''' Funcion para agregar un nuevo registro a la tabla listatrozasd
    ''' </summary>
    ''' <param name="rs">entidad.listatrozasd</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ListaTrozasAgregar(ByVal rs As SAMAD.listatrozasd) As Boolean
        Using dm As New samadEntities
            Try
                dm.AddTolistatrozasd(rs)
                dm.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    ''' <summary>
    ''' Funcion para Editar un Registro de la tabla listatrozasd
    ''' </summary>
    ''' <param name="rs">entidad.listatrozasd</param>
    ''' <returns>True or False</returns>
    ''' <remarks></remarks>
    Public Function ListaTrozasEditar(ByVal rs As SAMAD.listatrozasd) As Boolean
        Using dm As New samadEntities
            ' obtenemos el Registro antes de modificarlo
            Dim ra As SAMAD.listatrozasd = (From lt In dm.listatrozasd Where lt.Ltd_Id = rs.Ltd_Id Select lt).First()
            dm.listatrozasd.Detach(ra)
            Dim rn As New SAMAD.listatrozasd
            Try
                rn.Ltd_Id = rs.Ltd_Id
                dm.listatrozasd.Attach(rn)
                dm.listatrozasd.ApplyCurrentValues(rs)
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
    ''' Funcion para obtener el Id del registro de la Troza en tabla Listatrozasd
    ''' </summary>
    ''' <param name="strCodigo">Codigo de Troza</param>
    ''' <returns>valor del Campo ltd_id</returns>
    ''' <remarks></remarks>
    Function TrozaId(ByVal strCodigo As String) As Integer
        Using dm As New samadEntities
            'TrozaId = (From ltd In dm.listatrozasd Where ltd.Ltd_Codificacion = strCodigo Select ltd.Ltd_Id).First()
            TrozaId = (From rs In dm.listatrozasd Where rs.Ltd_Codificacion = strCodigo Select rs.Ltd_Id).First()
        End Using
    End Function

    ''' <summary>
    ''' Funcion para obtener los datos de una troza, segun el Numero de Troza
    ''' </summary>
    ''' <param name="strNumero">Numero de troza a buscar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetTrozaByNumero(ByVal strNumero As String) As SAMAD.listatrozasd
        Using dm As New samadEntities
            Dim dt As SAMAD.listatrozasd = (From rs In dm.listatrozasd Where rs.Ltd_Codificacion = strNumero Select rs).First()
            Return dt
        End Using
    End Function
#End Region

#Region "Consultas que retornan valores booleano"

    ''' <summary>
    ''' Funcion para buscar buscar Codigo de Troza en detalle de troza
    ''' </summary>
    ''' <param name="strCodigo">Codigo a buscar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function BuscarCodigoTrozas(ByVal strCodigo As String, ByVal intTitular As Integer, ByVal strZafra As String) As Boolean
        Using dm As New samadEntities
            'Dim nr = (From lt In dm.listatrozasd Where lt.Ltd_Codificacion = strCodigo Select lt.Ltd_Codificacion).Count()
            Dim nr = (From lt In dm.vmostrar_listatrozas Where lt.Ltd_Codificacion = strCodigo And lt.lt_Titular_Id = intTitular And lt.Lt_Zafra = strZafra Select lt.Ltd_Codificacion).Count()
            Return IIf(nr > 0, True, False)
        End Using
    End Function

    


#End Region

#Region "Listas y Entidades"


    ''' <summary>
    ''' Funcion que obtiene los datos de la troza
    ''' </summary>
    ''' <param name="strNumero">Numero de troza a seleccionar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetTrozaInfo(ByVal strNumero As String, ByVal stridtitular As Integer, strzafra As Integer) As SAMAD.vw_detalle_troza
        Using dm As New samadEntities
            If strzafra = 0 Then
                Dim dt As SAMAD.vw_detalle_troza = (From rs In dm.vw_detalle_troza Where rs.Estatus = False And rs.Lt_Titular_Id = stridtitular And rs.Numtroza = strNumero Select rs).First()
                Return dt
            Else
                Dim dt As SAMAD.vw_detalle_troza = (From rs In dm.vw_detalle_troza Where rs.Estatus = False And rs.Lt_Titular_Id = stridtitular And rs.Lt_Zafra = strzafra And rs.Numtroza = strNumero Select rs).First()
                Return dt
            End If


        End Using
    End Function

    ''' <summary>
    ''' Funcion para buscar una troza
    ''' </summary>
    ''' <param name="strTroza">Numero de Troza a buscar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function TrozaExiste(ByVal strTroza As String) As Boolean
        Using dm As New samadEntities
            Dim nr = (From x In dm.listatrozasd Where x.Ltd_Codificacion = strTroza And x.Estatus = False Select x.Ltd_Codificacion).Count()
            Return IIf(nr > 0, True, False)
        End Using
    End Function
#End Region
End Class