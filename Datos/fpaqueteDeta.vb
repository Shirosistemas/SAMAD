Imports MySql.Data.MySqlClient
Public Class fPaqueteDeta
    Inherits conexion
    Dim cmd As New MySqlCommand

    Public Function mostrarPaqueteDetalle(ByVal dts As vPaqueteDeta) As DataTable
        Try
            CONECTADO()
            cmd = New MySqlCommand("mostrar_paquetedeta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("vPaq_Emp_ID", dts.gPaqd_Paq_Id)

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

    Public Function insertar(ByVal dts As vPaqueteDeta) As Boolean
        Try
            conectado()
            cmd = New MySqlCommand("insertar_paquetedeta") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vPaqd_Paq_Id", dts.gPaqd_Paq_Id)
            cmd.Parameters.AddWithValue("vPaqd_Piezas", dts.gPaqd_Piezas)
            cmd.Parameters.AddWithValue("vPaqd_Espesor", dts.gPaqd_Espesor)
            cmd.Parameters.AddWithValue("vPaqd_Ancho", dts.gPaqd_Ancho)
            cmd.Parameters.AddWithValue("vPaqd_Largo", dts.gPaqd_Largo)
            cmd.Parameters.AddWithValue("vPaqd_Volpt", dts.gPaqd_Volpt)

            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("paquete_deta", "Insertar", Convert.ToInt32(id), "ID Paq:" + dts.gPaqd_Paq_Id.ToString())
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

    Public Function editar(ByVal dts As vPaqueteDeta) As Boolean
        Try
            CONECTADO()
            cmd = New MySqlCommand("editar_paquetedeta") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos 
            cmd.Parameters.AddWithValue("vPaqd_Id", dts.gPaqd_id)
            cmd.Parameters.AddWithValue("vPaqd_Paq_Id", dts.gPaqd_Paq_Id)
            cmd.Parameters.AddWithValue("vPaqd_Piezas", dts.gPaqd_Piezas)
            cmd.Parameters.AddWithValue("vPaqd_Espesor", dts.gPaqd_Espesor)
            cmd.Parameters.AddWithValue("vPaqd_Ancho", dts.gPaqd_Ancho)
            cmd.Parameters.AddWithValue("vPaqd_Largo", dts.gPaqd_Largo)
            cmd.Parameters.AddWithValue("vPaqd_Volpt", dts.gPaqd_Volpt)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("paquete_deta", "Editar", dts.gPaqd_id, "ID Paq:" + dts.gPaqd_Paq_Id)
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

    Public Function eliminar(ByVal dts As vPaqueteDeta) As Boolean
        Try
            CONECTADO()
            cmd = New MySqlCommand("eliminar_paquetedeta") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos 
            cmd.Parameters.AddWithValue("vPaqd_Id", dts.gPaqd_id)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("paquete_deta", "Eliminar", dts.gPaqd_id, "")
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


Public Class cdPaquete_det

#Region "Paquete"

#Region "Mantenimiento a la Tabla de Paquete (Altas, Bajas y Cambios)"



    Function PaqueteAgregar(ByVal rs As SAMAD.paquete) As Boolean
        Using dm As New samadEntities
            dm.AddTopaquete(rs)
            dm.SaveChanges()
            Return True
        End Using
    End Function
    Public Function PaqueteEditar(ByVal rs As SAMAD.paquete) As Boolean
        Using dm As New samadEntities
            ' obtenemos el Registro antes de modificarlo
            Dim ra As SAMAD.paquete = (From v In dm.paquete Where v.RowId = rs.RowId Select v).First()
            dm.paquete.Detach(ra)
            Dim rn As New SAMAD.paquete
            Try
                rn.RowId = rs.RowId
                dm.paquete.Attach(rn)
                dm.paquete.ApplyCurrentValues(rs)
                dm.SaveChanges()
                Return True
            Catch ex As Exception
                dm.Refresh(Objects.RefreshMode.ClientWins, ra)
                dm.SaveChanges()
                Return False
            End Try
        End Using
    End Function

    Function PaqueteGrabar(ByVal rs As SAMAD.paquete, xexiste As Boolean) As Boolean
        If xexiste = False Then
            Return PaqueteAgregar(rs)
        Else
            Return PaqueteEditar(rs)
        End If
    End Function

    ''' <summary>
    ''' Funcion para saber si el Paquete ya existe en el Periodo
    ''' </summary>
    ''' <param name="strPaquete"></param>
    ''' <param name="strPeriodo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function PaqueteExiste(ByVal strPaquete As String, strPeriodo As String) As Boolean
        Using dm As New samadEntities
            Dim nr As Integer = (From x In dm.paquete Where x.Numpaquete = strPaquete And x.Periodo = strPeriodo Select x.Numpaquete).Count()
            Return IIf(nr > 0, True, False)
        End Using
    End Function

    ''' <summary>
    ''' Funcion que retorna el Ultimo ID de paquete
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function LastPaqueteId() As Integer
        Using dm As New samadEntities
            LastPaqueteId = dm.paquete.Select(Function(x) x.RowId).Max()
        End Using
    End Function

#End Region


#Region "Paquete Detalle"

    ' - Mantenimiento a la Tabla Paquete_deta(Altas, Bajas y Cambios)

    Function DetallePaqueteAgregar(ByVal rs As SAMAD.paquete_deta) As Boolean
        Using dm As New samadEntities
            dm.AddTopaquete_deta(rs)
            dm.SaveChanges()
            Return True
        End Using
    End Function

    Function DetallePaqueteEditar(ByVal rs As SAMAD.paquete_deta) As Boolean
        Using dm As New samadEntities
            Dim ra As SAMAD.paquete_deta = (From x In dm.paquete_deta Where x.RowId = rs.RowId Select x).First()

            Dim ruma As SAMAD.paquete = (From x In dm.paquete Where x.RowId = ra.PaqueteId Select x).First()
            ruma.Cantidad = ruma.Cantidad - ra.Cantidad
            ruma.Volm3 = ruma.Volm3 - ra.VolM3
            ruma.Volpt = ruma.Volpt - ra.VolPT
            'dm.DeleteObject(ra)
            dm.SaveChanges()
            PaqueteEditar(ruma)
            dm.paquete_deta.Detach(ra)
            'dm.formato04_rumas_det.Detach(ra)
            Dim nr As New SAMAD.paquete_deta
            Try
                nr.RowId = rs.RowId
                dm.paquete_deta.Attach(nr)
                dm.paquete_deta.ApplyCurrentValues(rs)
                dm.SaveChanges()
                Return True
            Catch ex As Exception
                dm.Refresh(Objects.RefreshMode.ClientWins, ra)
                Return False
            End Try
        End Using
    End Function
    Public Function RumasEditar(ByVal rs As SAMAD.formato04_rumas) As Boolean
        Using dm As New samadEntities
            ' obtenemos el Registro antes de modificarlo
            Dim ra As SAMAD.formato04_rumas = (From v In dm.formato04_rumas Where v.RowId = rs.RowId Select v).First()
            dm.formato04_rumas.Detach(ra)
            Dim rn As New SAMAD.formato04_rumas
            Try
                rn.RowId = rs.RowId
                dm.formato04_rumas.Attach(rn)
                dm.formato04_rumas.ApplyCurrentValues(rs)
                dm.SaveChanges()
                Return True
            Catch ex As Exception
                dm.Refresh(Objects.RefreshMode.ClientWins, ra)
                dm.SaveChanges()
                Return False
            End Try
        End Using
    End Function
    Function DescuentaRumas(ByVal iRowId As Integer) As Boolean
        Using dm As New samadEntities
            Dim paque As SAMAD.paquete = (From x In dm.paquete Where x.RowId = iRowId Select x).First()

            Try
                Dim ruma As SAMAD.formato04_rumas = (From x In dm.formato04_rumas Where x.RumaId = paque.RumaId Select x).First()
                ruma.Cantidad = ruma.Cantidad - paque.UtiCantidad
                ruma.VolM3 = ruma.VolM3 - paque.UtiVolM3
                ruma.VolPT = ruma.VolPT - paque.UtiVolPt
                'dm.DeleteObject(paquetedetalle)
                dm.SaveChanges()
                'Return RumasEditar(ruma)
                Return True
            Catch ex As Exception
                dm.Refresh(Objects.RefreshMode.ClientWins, paque)
                Return False
            End Try
        End Using
    End Function

    Function DetallePaqueteBorrar(ByVal iRowId As Integer) As Boolean
        Using dm As New samadEntities
            Dim paquetedetalle As SAMAD.paquete_deta = (From x In dm.paquete_deta Where x.RowId = iRowId Select x).First()

            Try
                Dim ruma As SAMAD.paquete = (From x In dm.paquete Where x.RowId = paquetedetalle.PaqueteId Select x).First()
                ruma.Cantidad = ruma.Cantidad - paquetedetalle.Cantidad
                ruma.Volm3 = ruma.Volm3 - paquetedetalle.VolM3
                ruma.Volpt = ruma.Volpt - paquetedetalle.VolPT
                dm.DeleteObject(paquetedetalle)
                dm.SaveChanges()
                Return PaqueteEditar(ruma)
            Catch ex As Exception
                dm.Refresh(Objects.RefreshMode.ClientWins, paquetedetalle)
                Return False
            End Try
        End Using
    End Function

    Function GrabarDetallePaquete(ByVal rs As SAMAD.paquete_deta, xExiste As Boolean) As Boolean
        If xExiste = False Then
            'Nuevo registro
            Return DetallePaqueteAgregar(rs)
        Else
            'Edita un registro Existente
            Return DetallePaqueteEditar(rs)
        End If
    End Function

    Function VistaPaquetes() As List(Of SAMAD.paquete)
        Using dm As New samadEntities
            Dim ls = (From x In dm.paquete Select x).ToList()
            Return ls
        End Using
    End Function

    Function PaqueteDetalle(ByVal xRumaId As Integer) As List(Of SAMAD.paquete_deta)
        Using dm As New samadEntities
            Dim ls = (From rs In dm.paquete_deta Where rs.PaqueteId = xRumaId Select rs).ToList()
            Return ls
        End Using
    End Function

    Function PaqueteTieneDetalle(ByVal idRuma As Integer) As Boolean
        Using dm As New samadEntities
            Dim nr = dm.paquete_deta.Where(Function(x) x.PaqueteId = idRuma).Select(Function(a) a.RowId).Count()
            Return IIf(nr > 0, True, False)
        End Using
    End Function
#End Region

    Function GetPaquetaById(ByVal intRumaId As Integer) As SAMAD.paquete
        Using dm As New samadEntities
            Dim dt As SAMAD.paquete = (From x In dm.paquete Where x.RowId = intRumaId Select x).First()
            Return dt
        End Using
    End Function

    Function GetNumeroPaquete(ByVal strNumero As String) As SAMAD.vw_paquete_despacho
        Using dm As New samadEntities
            Dim dt As SAMAD.vw_paquete_despacho = (From rs In dm.vw_paquete_despacho Where rs.Numpaquete = strNumero And rs.Estatus = 0 Select rs).First()
            Return dt
        End Using
    End Function

    Function CodigoPaquete(ByVal strCodigo As String, strPeriodo As String, intTitular As Integer) As Boolean
        Using dm As New samadEntities
            Dim sn = (From rs In dm.paquete_deta From fc In dm.paquete
                            Where fc.Periodo + fc.EspecieId + fc.Numpaquete = strPeriodo + intTitular + strCodigo And fc.Estatus = 0 Select fc.Numpaquete).Count()
            Return IIf(sn > 0, True, False)
        End Using
    End Function

    Function VerificaPaqueteDespachado(ByVal strCodigo As String, strPeriodo As String, intTitular As Integer) As Boolean
        Dim prosigue As Boolean
        Using dm As New samadEntities
            'Dim sn = (From rs In dm.
            '                Where fc.Periodo + fc.EspecieId + fc.Numpaquete = strPeriodo + intTitular + strCodigo And fc.Estatus = 0 Select fc.Numpaquete).Count()
            'Return IIf(sn > 0, True, False)
            Dim sm = (From rs In dm.vw_verificapaquetedespacho
            Where rs.periodo + rs.especieid + rs.codigopaquete = strPeriodo + intTitular + strCodigo Select rs.cuantos).Count()
            If sm > 0 Then
                MessageBox.Show("El paquete " + strCodigo + " ha sido despachada en su totalidad", "Despaho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                prosigue = False
            ElseIf CodigoPaquete(strCodigo, strPeriodo, intTitular) = False Then
                MessageBox.Show("El paquete " + strCodigo + " no esta disponible para este despacho", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                prosigue = False
            Else
                prosigue = True
            End If

            Return prosigue  'IIf(sm > 0, True, False)
        End Using
    End Function

    Function ActualizaM3Rumas(ByVal intRumaId As Integer, Volm3 As Decimal, volpt As Decimal, Cantpieza As Integer, ckCierre As Integer) As Boolean
        Dim dt = GetPaquetaById(intRumaId)
        dt.Volm3 = dt.Volm3 + Volm3
        dt.Volpt = dt.Volpt + volpt
        'dt.Estatus = ckCierre
        dt.Cantidad = dt.Cantidad + Cantpieza
        Return PaqueteEditar(dt)
    End Function

    Function BorrarPaquete(ByVal idRuma As Integer) As Boolean
        Using dm As New samadEntities
            Dim dt As SAMAD.paquete = (From rs In dm.paquete Where rs.RowId = idRuma Select rs).First()
            dm.DeleteObject(dt)
            Try
                dm.SaveChanges()
                Return True
            Catch ex As Exception
                dm.Refresh(Objects.RefreshMode.ClientWins, dt)
                Return False
            End Try
        End Using
    End Function
#End Region
End Class


