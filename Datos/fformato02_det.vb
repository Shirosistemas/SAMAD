Imports MySql.Data.MySqlClient
Public Class fformato02_det
    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando

    Public Function mostrar(ByVal dts As vFormato02_det) As DataTable
        Try
            conectado() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_formato02_det") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("vf02d_f02id", dts.gf02d_f02_id)
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

    Public Function insertar(ByVal dts As vFormato02_det) As Boolean

        Try
            CONECTADO()
            cmd = New MySqlCommand("insertar_formato02_det") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vf02id", dts.gf02d_f02_id)
            cmd.Parameters.AddWithValue("vcodificacion", dts.gf02d_codificacion)
            cmd.Parameters.AddWithValue("vcodindustria", dts.gf02d_codindustria)
            cmd.Parameters.AddWithValue("vcut", dts.gf02d_cut)
            cmd.Parameters.AddWithValue("vespecie", dts.gf02d_especie)
            cmd.Parameters.AddWithValue("vd1", dts.gf02d_d1)
            cmd.Parameters.AddWithValue("vd2", dts.gf02d_d2)
            cmd.Parameters.AddWithValue("vd3", dts.gf02d_d3)
            cmd.Parameters.AddWithValue("vvolm3", dts.gf02d_volm3)
            cmd.Parameters.AddWithValue("vd1c", dts.gf02d_d1c)
            cmd.Parameters.AddWithValue("vd2c", dts.gf02d_d2c)
            cmd.Parameters.AddWithValue("vd3c", dts.gf02d_d3c)
            cmd.Parameters.AddWithValue("vvolm3c", dts.gf02d_volm3c)
            cmd.Parameters.AddWithValue("vdpulgada", dts.gf02d_d_pulgada)
            cmd.Parameters.AddWithValue("vLpies", dts.gf02d_dpies)
            cmd.Parameters.AddWithValue("vVolpt", dts.gf02d_vol_pt)
            cmd.Parameters.AddWithValue("vobservacion", dts.gf02d_observacion)
            'cmd.Parameters.AddWithValue("vUnidad",dts.gf02d
            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("formato02_det", "Insertar", id, dts.gf02d_codificacion)
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

    Public Function editar(ByVal dts As vFormato02_det) As Boolean

        Try
            CONECTADO()
            cmd = New MySqlCommand("editar_formato02_det") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.gf02d_id)
            cmd.Parameters.AddWithValue("vf02id", dts.gf02d_f02_id)
            cmd.Parameters.AddWithValue("vcodificacion", dts.gf02d_codificacion)
            cmd.Parameters.AddWithValue("vcodindustria", dts.gf02d_codindustria)
            cmd.Parameters.AddWithValue("vcut", dts.gf02d_cut)
            cmd.Parameters.AddWithValue("vespecie", dts.gf02d_especie)
            cmd.Parameters.AddWithValue("vd1", dts.gf02d_d1)
            cmd.Parameters.AddWithValue("vd2", dts.gf02d_d2)
            cmd.Parameters.AddWithValue("vd3", dts.gf02d_d3)
            cmd.Parameters.AddWithValue("vvolm3", dts.gf02d_volm3)
            cmd.Parameters.AddWithValue("vd1c", dts.gf02d_d1c)
            cmd.Parameters.AddWithValue("vd2c", dts.gf02d_d2c)
            cmd.Parameters.AddWithValue("vd3c", dts.gf02d_d3c)
            cmd.Parameters.AddWithValue("vvolm3c", dts.gf02d_volm3c)
            cmd.Parameters.AddWithValue("vdpulgada", dts.gf02d_d_pulgada)
            cmd.Parameters.AddWithValue("vLpies", dts.gf02d_dpies)
            cmd.Parameters.AddWithValue("vVolpt", dts.gf02d_vol_pt)
            cmd.Parameters.AddWithValue("vobservacion", dts.gf02d_observacion)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("formato02_det", "Editar", dts.gf02d_id, dts.gf02d_codificacion)
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

    Public Function eliminar(ByVal dts As vFormato02_det) As Boolean
        Try
            CONECTADO()
            cmd = New MySqlCommand("eliminar_formato02_det") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("vid", MySqlDbType.VarChar, 50).Value = dts.gf02d_id

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("formato02_det", "Eliminar", dts.gf02d_id, "")
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



#Region "Mantenimiento a la Tabla Formato02_det(Altas, Bajas y Cambios)"

    ''' <summary>
    ''' Funcion para agregar un Nuevo registro a la tabla Formato02_det
    ''' </summary>
    ''' <param name="rs"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function AgregarNuevoRegistro(ByVal rs As SAMAD.formato02_det) As Boolean
        Using dm As New samadEntities
            Try
                dm.AddToformato02_det(rs)
                dm.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    ''' <summary>
    ''' Funcion para Editar el Los datos de un Contrato
    ''' </summary>
    ''' <param name="rs"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EditarRegistroExistente(ByVal rs As SAMAD.formato02_det) As Boolean
        Using dm As New samadEntities
            ' obtenemos el Registro antes de modificarlo
            Dim ra As SAMAD.formato02_det = (From v In dm.formato02_det Where v.F02d_Id = rs.F02d_Id Select v).First()
            dm.formato02_det.Detach(ra)
            Dim rn As New SAMAD.formato02_det
            Try
                rn.F02d_Id = rs.F02d_Id
                dm.formato02_det.Attach(rn)
                dm.formato02_det.ApplyCurrentValues(rs)
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
    ''' Funcion para seleccionar los datos de una Troza
    ''' </summary>
    ''' <param name="strNumero">Trioza a seleccionar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetByNumeroTroza(ByVal strNumero As String) As SAMAD.formato02_det
        Try
            Using dm As New samadEntities
                Dim dt As SAMAD.formato02_det = (From d In dm.formato02_det Where d.F02d_Codificacion = strNumero Select d).First()
                Return dt
            End Using
        Catch ex As Exception
            Return New SAMAD.formato02_det
        End Try
    End Function
#End Region

End Class


Public Class cdFormato02det

#Region "Mantenimiento a la tabla Formato02_det(Altas, Bajas y Cambios)"

    ''' <summary>
    ''' Funcion para agregar un Nuevo Registro a la Tabla Formato02_det
    ''' </summary>
    ''' <param name="rs"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Formato02DAgregar(ByVal rs As SAMAD.formato02_det) As Boolean
        Using dm As New samadEntities
            Try
                dm.AddToformato02_det(rs)
                dm.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    ''' <summary>
    ''' Funcion para Editar un Registro de la Tabla Formato02_det
    ''' </summary>
    ''' <param name="rs"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Formato02DEditar(ByVal rs As SAMAD.formato02_det) As Boolean
        Using dm As New samadEntities
            ' obtenemos el Registro antes de modificarlo
            Dim ra As SAMAD.formato02_det = (From t In dm.formato02_det Where t.F02d_Id = rs.F02d_Id Select t).First()
            dm.formato02_det.Detach(ra)
            Dim rn As New SAMAD.formato02_det
            Try
                rn.F02d_Id = rs.F02d_Id
                dm.formato02_det.Attach(rn)
                dm.formato02_det.ApplyCurrentValues(rs)
                dm.SaveChanges()
                Return True
            Catch ex As Exception
                dm.Refresh(Objects.RefreshMode.ClientWins, ra)
                dm.SaveChanges()
                Return False
            End Try
        End Using
    End Function

    Function GrabarEnFormato02Det(ByVal rs As SAMAD.formato02_det, xExiste As Boolean) As Boolean
        If xExiste = False Then
            Return Formato02DAgregar(rs)
        Else
            Return Formato02DEditar(rs)
        End If
    End Function

    Function CodigoBosqueRepite(ByVal strCodigo As String, strPeriodo As String, intTitular As Integer) As Boolean
        Using dm As New samadEntities
            Dim sn = (From rs In dm.formato02_det From fc In dm.formato02
                            Where rs.F02d_Codificacion + rs.F02d_Periodo + fc.f02_emp_id = strCodigo + strPeriodo + intTitular Select rs.F02d_Codificacion).Count()
            Return IIf(sn > 0, True, False)
        End Using
    End Function
    Function CodigoIndustriaRepite(ByVal strCodigo As String, strPeriodo As String, intTitular As Integer) As Boolean
        Using dm As New samadEntities
            Dim sn = (From rs In dm.formato02_det From fc In dm.formato02
                            Where rs.F02d_CodIndustria + rs.F02d_Periodo + fc.f02_emp_id = strCodigo + strPeriodo + intTitular Select rs.F02d_CodIndustria).Count()
            Return IIf(sn > 0, True, False)
        End Using
    End Function
#End Region
End Class