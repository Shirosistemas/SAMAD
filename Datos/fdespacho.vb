Imports MySql.Data.MySqlClient
Public Class fdespacho
    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando

    Public Function mostrar() As DataTable
        Try
            conectado() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_despacho") 'Llamamos al procedimiento almacenado
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

    Public Function insertar(ByVal dts As vDespacho) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("insertar_despacho") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vnrodoc", dts.gnrodoc)
            cmd.Parameters.AddWithValue("vubigeo", dts.gubigeo)
            cmd.Parameters.AddWithValue("varffs", dts.garffs)
            cmd.Parameters.AddWithValue("vfecha", dts.gfecha)
            cmd.Parameters.AddWithValue("vfechaven", dts.gfechaven)
            cmd.Parameters.AddWithValue("vperiodo", dts.gperiodo)
            cmd.Parameters.AddWithValue("vtitularid", dts.gtitularid)
            cmd.Parameters.AddWithValue("vpropietarioid", dts.gpropietarioid)
            cmd.Parameters.AddWithValue("vtipocv", dts.gtipocv)
            cmd.Parameters.AddWithValue("vnrocv", dts.gnrocv)
            cmd.Parameters.AddWithValue("vnroguiarem", dts.gnroguiarem)
            cmd.Parameters.AddWithValue("vdestinatarioid", dts.gdestinatarioid)
            cmd.Parameters.AddWithValue("vtransportistaid", dts.gtransportistaid)
            cmd.Parameters.AddWithValue("vvehiculoid", dts.gvehiculoid)
            cmd.Parameters.AddWithValue("vcontratoid", dts.gcontratoid)
            cmd.Parameters.AddWithValue("vtipotransporte", dts.tipTrans)
         

            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("despacho", "Insertar", id, dts.gnrodoc)
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

    Public Function editar(ByVal dts As vDespacho) As Boolean

        Try
            CONECTADO()
            cmd = New MySqlCommand("editar_despacho") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.gdesid)

            cmd.Parameters.AddWithValue("vnrodoc", dts.gnrodoc)
            cmd.Parameters.AddWithValue("vubigeo", dts.gubigeo)
            cmd.Parameters.AddWithValue("varffs", dts.garffs)
            cmd.Parameters.AddWithValue("vfecha", dts.gfecha)
            cmd.Parameters.AddWithValue("vfechaven", dts.gfechaven)
            cmd.Parameters.AddWithValue("vperiodo", dts.gperiodo)
            cmd.Parameters.AddWithValue("vtitularid", dts.gtitularid)
            cmd.Parameters.AddWithValue("vpropietarioid", dts.gpropietarioid)
            cmd.Parameters.AddWithValue("vtipocv", dts.gtipocv)
            cmd.Parameters.AddWithValue("vnrocv", dts.gnrocv)
            cmd.Parameters.AddWithValue("vnroguiarem", dts.gnroguiarem)
            cmd.Parameters.AddWithValue("vdestinatarioid", dts.gdestinatarioid)
            cmd.Parameters.AddWithValue("vtransportistaid", dts.gtransportistaid)
            cmd.Parameters.AddWithValue("vvehiculoid", dts.gvehiculoid)
            cmd.Parameters.AddWithValue("vcontratoid", dts.gcontratoid)
            cmd.Parameters.AddWithValue("vtipotransporte", dts.tipTrans)


            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("despacho", "Editar", dts.gdesid, dts.gnrodoc)
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

    Public Function eliminar(ByVal dts As vDespacho) As Boolean
        Try
            CONECTADO()
            cmd = New MySqlCommand("eliminar_despacho") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("vid", MySqlDbType.VarChar, 50).Value = dts.gdesid

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("despacho", "Editar", dts.gdesid, "")
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

Public Class cdDespacho
#Region "Funciones Miscelaneas"

    ''' <summary>
    ''' Genera el Numero de Documento continuo segun el Periodo
    ''' </summary>
    ''' <param name="strPeriodo">Periodo del Documento - es el año </param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function NumeroEmpaquetado(ByVal strPeriodo As String) As String
        Using dm As New samadEntities
            ' Primer Metodo
            'Dim UltimoNumero = dm.empaquetado.Where(Function(x) Year(x.Emp_Fecha) = strPeriodo).Select(Function(x) x.Emp_NroDoc).Max()
            'Segundo Metodo
            Dim UltimoNumero = (From x In dm.empaquetado Where Year(x.Emp_Fecha) = strPeriodo Select x.Emp_NroDoc).Max()
            NumeroEmpaquetado = New fxSamad().StrCeros(UltimoNumero, 6, True)
        End Using
    End Function

    Function DespachoDespachoDet(ByVal intPapaDespacho As Integer) As Boolean
        Using dm As New samadEntities
            Dim nr = (From x In dm.despacho_det Where x.Desd_Des_Id = intPapaDespacho Select x.Desd_Id).Count()
            Return IIf(nr > 0, True, False)
        End Using
    End Function
#End Region


End Class