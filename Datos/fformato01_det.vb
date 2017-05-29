Imports MySql.Data.MySqlClient
Public Class fformato01_det
    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando

    Public Function mostrar(ByVal dts As vFormato01_det) As DataTable
        Try
            CONECTADO() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_formato01_det") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("vf01d_f01id", dts.gf01d_f01_id)
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


    Public Function insertar(ByVal dts As vFormato01_det) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("insertar_formato01_det") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vf01id", dts.gf01d_f01_id)
            cmd.Parameters.AddWithValue("vguiaremision", dts.gf01d_guiaremision)
            cmd.Parameters.AddWithValue("vgtf", dts.gf01d_gtf)
            cmd.Parameters.AddWithValue("vespecie", dts.gf01d_especie)
            cmd.Parameters.AddWithValue("vcorrelativo", dts.gf01d_correlativo)
            cmd.Parameters.AddWithValue("vcodindustria", dts.gf01d_codindustria)
            cmd.Parameters.AddWithValue("vplaca", dts.gf01d_placa)
            cmd.Parameters.AddWithValue("vd1", dts.gf01d_d1)
            cmd.Parameters.AddWithValue("vd2", dts.gf01d_d2)
            cmd.Parameters.AddWithValue("vd3", dts.gf01d_d3)
            cmd.Parameters.AddWithValue("vvolm3", dts.gf01d_vol_m3)
            cmd.Parameters.AddWithValue("vespeciec", dts.gf01d_especiec)
            cmd.Parameters.AddWithValue("vd1c", dts.gf01d_d1c)
            cmd.Parameters.AddWithValue("vd2c", dts.gf01d_d2c)
            cmd.Parameters.AddWithValue("vd3c", dts.gf01d_d3c)
            cmd.Parameters.AddWithValue("vvolm3c", dts.gf01d_vol_m3c)
            cmd.Parameters.AddWithValue("vobservacion", dts.gf01d_observacion)
            cmd.Parameters.AddWithValue("vubicacion", dts.gf01d_ubicacion)
            cmd.Parameters.AddWithValue("vautogenerado", dts.gf01d_autogenerado)
            cmd.Parameters.AddWithValue("vveh_placa", dts.gf01d_veh_placa)
            cmd.Parameters.AddWithValue("vconductor", dts.gf01d_conductor)
            cmd.Parameters.AddWithValue("vprocedencia", dts.gf01d_procedencia)
            cmd.Parameters.AddWithValue("vtipo", dts.gf01d_tipo)
            cmd.Parameters.AddWithValue("vunidad", dts.gf01d_unidad)
            cmd.Parameters.AddWithValue("vnumlote", dts.fldLote)
            cmd.Parameters.AddWithValue("vowner", dts.fldOwner)
            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("formato01_det", "Insertar", id, dts.gf01d_gtf + "-" + dts.gf01d_codindustria)
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

    Public Function editar(ByVal dts As vFormato01_det) As Boolean

        Try
            CONECTADO()
            cmd = New MySqlCommand("editar_formato01_det") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.gf01d_id)
            cmd.Parameters.AddWithValue("vf01id", dts.gf01d_f01_id)
            cmd.Parameters.AddWithValue("vguiaremision", dts.gf01d_guiaremision)
            cmd.Parameters.AddWithValue("vgtf", dts.gf01d_gtf)
            cmd.Parameters.AddWithValue("vespecie", dts.gf01d_especie)
            cmd.Parameters.AddWithValue("vcorrelativo", dts.gf01d_correlativo)
            cmd.Parameters.AddWithValue("vcodindustria", dts.gf01d_codindustria)
            cmd.Parameters.AddWithValue("vplaca", dts.gf01d_placa)
            cmd.Parameters.AddWithValue("vd1", dts.gf01d_d1)
            cmd.Parameters.AddWithValue("vd2", dts.gf01d_d2)
            cmd.Parameters.AddWithValue("vd3", dts.gf01d_d3)
            cmd.Parameters.AddWithValue("vvolm3", dts.gf01d_vol_m3)
            cmd.Parameters.AddWithValue("vespeciec", dts.gf01d_especiec)
            cmd.Parameters.AddWithValue("vd1c", dts.gf01d_d1c)
            cmd.Parameters.AddWithValue("vd2c", dts.gf01d_d2c)
            cmd.Parameters.AddWithValue("vd3c", dts.gf01d_d3c)
            cmd.Parameters.AddWithValue("vvolm3c", dts.gf01d_vol_m3c)
            cmd.Parameters.AddWithValue("vobservacion", dts.gf01d_observacion)
            cmd.Parameters.AddWithValue("vubicacion", dts.gf01d_ubicacion)
            cmd.Parameters.AddWithValue("vautogenerado", dts.gf01d_autogenerado)
            cmd.Parameters.AddWithValue("vveh_placa", dts.gf01d_veh_placa)
            cmd.Parameters.AddWithValue("vconductor", dts.gf01d_conductor)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("formato01_det", "Editar", dts.gf01d_id, dts.gf01d_gtf + "-" + dts.gf01d_codindustria)
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

    Public Function editar_trozas_utilizadas(ByVal dts As vFormato01_det) As Boolean
        Try
            CONECTADO()
            cmd = New MySqlCommand("editar_trozautilizada") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.gf01d_id)
            cmd.Parameters.AddWithValue("vutilizada_f04_id", dts.gf01d_utilizado_f04_id)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("formato01_det", "Editar", dts.gf01d_id, "Troza Utilizada:" + dts.gf01d_utilizado_f04_id)
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

    Public Function eliminar(ByVal dts As vFormato01_det) As Boolean
        Try
            conectado()
            cmd = New MySqlCommand("eliminar_formato01_det") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("vid", MySqlDbType.VarChar, 50).Value = dts.gf01d_id

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("formato01_det", "Eliminar", dts.gf01d_id, "")
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
    ''' Funcion para obtener la informacion de la troza a recepcionar
    ''' </summary>
    ''' <param name="strTroza">codigo de troza a filtrar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function DatosTroza(ByVal strTroza As String) As SAMAD.vw_detalle_troza
        Try
            Using dm As New samadEntities
                Dim dt As SAMAD.vw_detalle_troza = (From t In dm.vw_detalle_troza Where t.Numtroza = strTroza Select t).First()
                Return dt
            End Using
        Catch ex As Exception
            Return New SAMAD.vw_detalle_troza
        End Try
        
    End Function
End Class

Public Class cdFormato01Det


#Region "Mantenimiento a la Tabla Formato01_det(Alts, Bajas y Cambios)"

    ''' <summary>
    ''' Funcion para Agregar un Nuevo registro a la tabla Formato01_det
    ''' </summary>
    ''' <param name="rs"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Formato01DAgregar(ByVal rs As SAMAD.formato01_det) As Boolean
        Using dm As New samadEntities
            Try
                dm.AddToformato01_det(rs)
                dm.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    Public Function Formato01DEditar(ByVal rs As SAMAD.formato01_det) As Boolean
        Using dm As New samadEntities
            ' obtenemos el Registro antes de modificarlo
            Dim ra As SAMAD.formato01_det = (From t In dm.formato01_det Where t.F01d_Id = t.F01d_Id Select t).First()
            dm.formato01_det.Detach(ra)
            Dim rn As New SAMAD.formato01_det
            Try
                rn.F01d_Id = rs.F01d_Id
                dm.formato01_det.Attach(rn)
                dm.formato01_det.ApplyCurrentValues(rs)
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
    ''' Funcion para Grabar o Editar el Registro, segun se indique en xExiste
    ''' </summary>
    ''' <param name="rs"></param>
    ''' <param name="xExiste"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GrabarFormato01Det(ByVal rs As SAMAD.formato01_det, xExiste As Boolean) As Boolean
        If xExiste = True Then
            Return Formato01DEditar(rs)
        Else
            Return Formato01DAgregar(rs)
        End If
    End Function
#End Region


#Region "Funciones que retornan valor booleano"

    ''' <summary>
    ''' Funcion para verificar si el Codigode Industria existe en x Periodo
    ''' </summary>
    ''' <param name="strCodigo">Codigo a validar</param>
    ''' <param name="strPeriodo">Periodo en el que se validara</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function CodigoIndustriaExiste(ByVal strCodigo As String, strPeriodo As String, strLote As String) As Boolean
        Using dm As New samadEntities
            Dim sn = (From rs In dm.formato01_det Where rs.F01d_CodIndustria + rs.Periodo = strCodigo + strPeriodo + strLote Select rs.F01d_Id).Count()
            Return IIf(sn > 0, True, False)
        End Using
    End Function
    Function CodigoBosqueExiste(ByVal strCodigo As String, strPeriodo As String, intTitular As Integer) As Boolean
        Using dm As New samadEntities

            Dim sn = (From rs In dm.formato01_det From fc In dm.formato01
                       Where fc.F01_periodo = strPeriodo And fc.F01_Pro_id = intTitular And rs.F01d_Correlativo = strCodigo And rs.Estatus = 0 Select rs.F01d_Correlativo).Count()


            'Dim sn = (From rs In dm.formato01_det From fc In dm.formato01
            'Where fc.F01_periodo + fc.F01_Pro_id + rs.F01d_Correlativo = strPeriodo + intTitular + strCodigo And rs.Estatus = 0 Select rs.F01d_Correlativo).Count()
            Return IIf(sn > 0, True, False)
        End Using
    End Function
    Function VerificaSiExisteRegistroBosque(ByVal strCodigo As String, strPeriodo As String, intTitular As Integer) As Boolean
        Dim prosigue As Boolean
        Using dm As New samadEntities
            Dim PRUEBA1 As String
            PRUEBA1 = strPeriodo & intTitular & strCodigo
            'Dim sm = (From rs In dm.formato01_det From fc In dm.formato01
            '                Where fc.F01_periodo + fc.F01_Pro_id + rs.F01d_Correlativo = strPeriodo + intTitular + strCodigo And rs.Estatus = 1 Select rs.F01d_Correlativo).Count()
            Dim sm = dm.vw_verificaexistecodigocorrelativo.Where(Function(rs) rs.PeriodoF01 = strPeriodo And rs.TitularF01 = intTitular And rs.CodCorrelativo = strCodigo).Select(Function(rs) rs.CodCorrelativo).Count()
            'Dim sm = (From rs In dm.vw_verificaexistecodigocorrelativo Where rs.PeriodoF01 + rs.TitularF01 + rs.CodCorrelativo = PRUEBA1 Select rs.CodCorrelativo).Count
            If sm > 0 Then
                MessageBox.Show("El codigo de bosque N° " + strCodigo + " ya se encuentra registrado", "Consumo de Trozas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                prosigue = False

            ElseIf CodigoBosqueExiste(strCodigo, strPeriodo, intTitular) = False Then
                MessageBox.Show("El codigo de bosque N° " + strCodigo + " no esta disponible", "Consumo de Trozas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                prosigue = False
            Else
                prosigue = True
            End If

            Return prosigue  'IIf(sm > 0, True, False)
        End Using
    End Function

    Function CodigoIndustriaExisteA(ByVal strCodigo As String, strPeriodo As String, intTitular As Integer) As Boolean
        Using dm As New samadEntities
            Dim sn = (From rs In dm.formato01_det From fc In dm.formato01
                            Where fc.F01_periodo + fc.F01_Pro_id + rs.F01d_CodIndustria = strPeriodo + intTitular + strCodigo And rs.Estatus = 0 Select rs.F01d_CodIndustria).Count()
            Return IIf(sn > 0, True, False)
        End Using
    End Function
    Function VerificaSiExisteRegistroIndustria(ByVal strCodigo As String, strPeriodo As String, intTitular As Integer) As Boolean
        Dim prosigue As Boolean
        Using dm As New samadEntities
            'Dim sm = (From rs In dm.formato01_det From fc In dm.formato01
            '                Where fc.F01_periodo + fc.F01_Pro_id + rs.F01d_CodIndustria = strPeriodo + intTitular + strCodigo And rs.Estatus = 1 Select rs.F01d_CodIndustria).Count()
            Dim sm = (From rs In dm.vw_verificaexistecodigoindustria Where rs.PeriodoF01 = strPeriodo And rs.TitularF01 = intTitular And rs.CodIndustria = strCodigo Select rs.CodIndustria).Count()

            If sm > 0 Then
                MessageBox.Show("El codigo de industria N° " + strCodigo + " ya se encuentra registrado", "Consumo de Trozas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                prosigue = False
            ElseIf CodigoIndustriaExisteA(strCodigo, strPeriodo, intTitular) = False Then
                MessageBox.Show("El codigo de industria N° " + strCodigo + " no esta disponible", "Consumo de Trozas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                prosigue = False
            Else
                prosigue = True
            End If

            Return prosigue  'IIf(sm > 0, True, False)
        End Using
    End Function
    Function CodigoLoteExiste(ByVal intIdEspecie As Integer) As Boolean
        Using dm As New samadEntities
            Dim sn = (From rs In dm.formato01_det Where rs.EspecieId = intIdEspecie Select rs.F01d_Lote).Count()
            Return IIf(sn > 0, True, False)
        End Using
    End Function


#End Region

#Region "Funciones Varias"

    ''' <summary>
    ''' Funcion para obtener los datos de la Troza desde la Tabla Formato01_det
    ''' </summary>
    ''' <param name="strNumero">Numero de TRoza a seleccionar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetNumeroTroza(ByVal strNumero As String) As SAMAD.formato01_det
        Using dm As New samadEntities
            Dim dt As SAMAD.formato01_det = (From rs In dm.formato01_det Where rs.F01d_Correlativo = strNumero And rs.Estatus = 0 Select rs).First()
            Return dt
        End Using
    End Function

    Function GetNumeroTrozaIndustria(ByVal strNumero As String) As SAMAD.formato01_det
        Using dm As New samadEntities
            Dim dt As SAMAD.formato01_det = (From rs In dm.formato01_det Where rs.F01d_CodIndustria = strNumero And rs.Estatus = 0 Select rs).FirstOrDefault()
            Return dt
        End Using
    End Function

    'retorna la informacion guardada en el formato01_det
    Function GetDatosEdicionTroza(ByVal intIdT As Integer) As SAMAD.formato01_det
        Using dm As New samadEntities
            Dim dt As SAMAD.formato01_det = (From rs In dm.formato01_det Where rs.F01d_Id = intIdT And rs.Estatus = 0 Select rs).FirstOrDefault()
            Return dt
        End Using
    End Function

    Function GetNumeroLote(ByVal intIdEspecie As Integer) As SAMAD.formato01_det
        Using dm As New samadEntities
            Dim dt As SAMAD.formato01_det = (From rs In dm.formato01_det Where rs.EspecieId = intIdEspecie And rs.Estatus = 0 Select rs).First()
            Return dt
        End Using
    End Function


#End Region
End Class