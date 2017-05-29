Imports MySql.Data.MySqlClient
Public Class flistatrozasc
    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando

    Public Function mostrar() As DataTable
        Try
            conectado() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_listatrozasc") 'Llamamos al procedimiento almacenado
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

    Public Function insertar(ByVal dts As vListatrozasc) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("insertar_listatrozasc") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vnrolista", dts.gltnrolista)
            cmd.Parameters.AddWithValue("vfecha", dts.gltfecha)
            cmd.Parameters.AddWithValue("vtitular_id", dts.glttitularid)
            cmd.Parameters.AddWithValue("vpropietario_id", dts.gltpropietarioid)
            cmd.Parameters.AddWithValue("vpropietario_id", dts.gltpropietarioid)
            cmd.Parameters.AddWithValue("vltubigeo", dts.gltubigeo)
            cmd.Parameters.AddWithValue("vltfecha_ven", dts.gltfecha_ven)
            cmd.Parameters.AddWithValue("vltzafra", dts.gltzafra)
            cmd.Parameters.AddWithValue("vlttipocv", dts.gltTipoCv)
            cmd.Parameters.AddWithValue("vltnrocv", dts.gltnrocv)
            cmd.Parameters.AddWithValue("vltnroguiarem", dts.gltnroguia)
            cmd.Parameters.AddWithValue("vtransporte_id", dts.gltransporteid)
            cmd.Parameters.AddWithValue("vcontrato_id", dts.gltcontratoid)
            cmd.Parameters.AddWithValue("vpoa_id", dts.gltpoaid)
            cmd.Parameters.AddWithValue("vconductor_id", dts.gltconductorid)
            cmd.Parameters.AddWithValue("vdestinatario_id", dts.gltdestinatario)
            cmd.Parameters.AddWithValue("vtipodimension", dts.glttipodimension)
            cmd.Parameters.AddWithValue("vobservacion", dts.gltobservacion)
            cmd.Parameters.AddWithValue("vdeffs", dts.gdeffs)
            cmd.Parameters.AddWithValue("vunidad", dts.fldUnidad)
            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("listatrozasc", "Insertar", id, dts.gltnrolista)
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

    Public Function editar(ByVal dts As vListatrozasc) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("editar_listatrozasc") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.gltid)
            cmd.Parameters.AddWithValue("vnrolista", dts.gltnrolista)
            cmd.Parameters.AddWithValue("vfecha", dts.gltfecha)
            cmd.Parameters.AddWithValue("vtitular_id", dts.glttitularid)
            cmd.Parameters.AddWithValue("vpropietario_id", dts.gltpropietarioid)
            cmd.Parameters.AddWithValue("vltubigeo", dts.gltubigeo)
            cmd.Parameters.AddWithValue("vltfecha_ven", dts.gltfecha_ven)
            cmd.Parameters.AddWithValue("vltzafra", dts.gltzafra)
            cmd.Parameters.AddWithValue("vlttipocv", dts.gltTipoCv)
            cmd.Parameters.AddWithValue("vltnrocv", dts.gltnrocv)
            cmd.Parameters.AddWithValue("vltnroguiarem", dts.gltnroguia)
            cmd.Parameters.AddWithValue("vcontrato_id", dts.gltcontratoid)
            cmd.Parameters.AddWithValue("vtransporte_id", dts.gltransporteid)
            cmd.Parameters.AddWithValue("vpoa_id", dts.gltpoaid)
            cmd.Parameters.AddWithValue("vconductor_id", dts.gltconductorid)
            cmd.Parameters.AddWithValue("vdestinatario_id", dts.gltdestinatario)
            cmd.Parameters.AddWithValue("vtipodimension", dts.glttipodimension)
            cmd.Parameters.AddWithValue("vobservacion", dts.gltobservacion)
            cmd.Parameters.AddWithValue("vdeffs", dts.gdeffs)
            cmd.Parameters.AddWithValue("vunidad", dts.fldUnidad)
            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("listatrozasc", "Editar", dts.gltid, dts.gltnrolista)
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

    Public Function eliminar(ByVal dts As vListatrozasc) As Boolean
        Try
            conectado()
            cmd = New MySqlCommand("eliminar_listatrozasc") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("vid", MySqlDbType.VarChar, 50).Value = dts.gltid

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("listatrozasc", "Eliminar", dts.gltid, "")
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
    ''' Funcion para validar si el numero de Lista Existe
    ''' </summary>
    ''' <param name="strNumero">No de lista a validar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GtfExiste(ByVal strNumero As String) As Boolean
        Using dm As New samadEntities
            Dim nr = (From lt In dm.listatrozasc Where lt.Lt_Nrogtf = strNumero Select lt.Lt_Nrogtf).Count()
            Return IIf(nr > 0, True, False)
        End Using
    End Function
End Class

Public Class cdListatrozasc

#Region "Mantenimiento a la Tabla Listatrozasc (Altas, Bajas, Cambios)"

    ''' <summary>
    ''' Funcion para agregar un Nuevo registro en la tabla Listatrozasc
    ''' </summary>
    ''' <param name="rs">entdad con los datos a grabar</param>
    ''' <returns>True or False</returns>
    ''' <remarks></remarks>
    Function ListaTrozasAgregar(ByVal rs As SAMAD.listatrozasc) As Boolean
        Using dm As New samadEntities
            Try
                dm.AddTolistatrozasc(rs)
                dm.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    ''' <summary>
    ''' Funcion para editar un Registro de la Tabla Listatrozasc
    ''' </summary>
    ''' <param name="rs"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ListaTrozasEditar(ByVal rs As SAMAD.listatrozasc) As Boolean
        Using dm As New samadEntities
            Dim ra As SAMAD.listatrozasc = (From x In dm.listatrozasc Where x.Lt_id = rs.Lt_id Select x).First()            
            dm.listatrozasc.Detach(ra)            
            Dim rn As New SAMAD.listatrozasc
            Try
                rn.Lt_id = rs.Lt_id
                dm.listatrozasc.Attach(rn)
                dm.listatrozasc.ApplyCurrentValues(rs)
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
    ''' Funcion para Seleccionar la Accion en la Tabla ListaTrozasc
    ''' </summary>
    ''' <param name="rs">datos a grabar</param>
    ''' <param name="xNuevo">True si es un nuevo registro, False es Editar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GrabarListaTrozas(ByVal rs As SAMAD.listatrozasc, xNuevo As Boolean) As Boolean
        If xNuevo = True Then
            Return ListaTrozasAgregar(rs)
        Else
            Return ListaTrozasEditar(rs)
        End If
    End Function
#End Region

    ''' <summary>
    ''' Funcion para el encabezado del Formulario ListaTrozas
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function HeaderListaTrozas() As List(Of SAMAD.vwlista_trozasc)
        Using dm As New samadEntities
            Dim ls = (From x In dm.vwlista_trozasc Select x).ToList()
            Return ls
        End Using
    End Function
End Class