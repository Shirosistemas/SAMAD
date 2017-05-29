Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style

Public Class frmFormato04

    Dim dtHeader As DataTable
    Dim recno As Integer = 0
    Dim xId_Aserr As Integer = 0

    Dim xVolPt As Decimal = 0
    Dim xVolm3 As Decimal = 0

    Dim pzPrimer As Integer = 0
    Dim pzSegunda As Integer = 0

    Dim VolPtPrimera As Decimal = 0
    Dim VolPtSegunda As Decimal = 0
    Dim Volm3Primera As Decimal = 0
    Dim Volm3Segunda As Decimal = 0

    Dim xExiste As Boolean = False
    Dim xTitulo = fxSamad.Titulo
    Dim xDoIt As Boolean = False
    Friend recargagrilla As Boolean

    Public Sub actualizar()
        MostrarEncabezados()
    End Sub

#Region "Funciones y Procedimientos Locales del Sistema"
    Dim Dt As DataTable

    Private Sub MostrarEncabezados()
        dtHeader = New fformato04().mostrar()
        If dtHeader.Rows.Count = 1 Then
            recno = 0
        End If

        If dtHeader.Rows.Count > 0 Then
            txId.Text = dtHeader.Rows(recno).Item("f04_id").ToString
            txtNro.Text = dtHeader.Rows(recno).Item("f04_nro").ToString
            dtFecha.Text = dtHeader.Rows(recno).Item("f04_fecha").ToString
            'chkCertificada.CheckState = dtHeader.Rows(recno).Item("f04_certificada").ToString
            cbMaterial.Text = dtHeader.Rows(recno).Item("f04_tipoconteo").ToString
            'lblTipomaterial.Text = dtHeader.Rows(recno).Item("f04_creacion").ToString 'Colocando valor a la Etiueta de Tipo de producto
            lblResumen.Text = "RESUMEN FORMATO N° " + txtNro.Text
            'lblProduccionDia.Text = "PRODUCCION TOTAL - DIA : " + dtFecha.Text
            txTurnoId.Text = dtHeader.Rows(recno).Item("f04_turno_id").ToString
            txTurno.Text = dtHeader.Rows(recno).Item("tur_horario").ToString
            txObservacion.Text = dtHeader.Rows(recno).Item("f04_observacion").ToString
            txOrdenProd.Text = dtHeader.Rows(recno).Item("f04_ordenproduccion").ToString
            txResponsableId.Text = dtHeader.Rows(recno).Item("f04_responsable_id").ToString
            txResponsable.Text = dtHeader.Rows(recno).Item("per_nomape").ToString
            txCargo.Text = dtHeader.Rows(recno).Item("per_cargo").ToString
            txF02Id.Text = dtHeader.Rows(recno).Item("f04_f02_id").ToString
            txNumF02.Text = dtHeader.Rows(recno).Item("f02_nrodoc").ToString
            txEmpresa.Text = dtHeader.Rows(recno).Item("pro_titular").ToString
            txEmpresaId.Text = dtHeader.Rows(recno).Item("pro_id").ToString
            txPeriodo.Text = dtHeader.Rows(recno).Item("f04_periodo").ToString
            'chkSeguimiento.Checked = dtHeader.Rows(recno).Item("f04_seguimiento").ToString
            'cbProducto.Text = dtHeader.Rows(recno).Item("f04_creacion").ToString
            DetalledeRumas()
            resume_lote()
        Else
            LimpiarControles()
        End If
    End Sub

    Private Sub HabilitarControles(ByVal xEstado As Boolean)
        ' Botones de Comando
        btNuevo.Enabled = Not xEstado
        btEditar.Enabled = Not xEstado
        btBorrar.Enabled = Not xEstado
        btGrabar.Enabled = xEstado
        btUndo.Enabled = xEstado
        btPrimero.Enabled = Not xEstado
        btSiguiente.Enabled = Not xEstado
        btAnterior.Enabled = Not xEstado
        btUltimo.Enabled = Not xEstado
        btAgregar.Enabled = Not xEstado
        btEditaD.Enabled = Not xEstado
        dtFecha.Enabled = xEstado
        txObservacion.ReadOnly = xEstado
        'txPeriodo.ReadOnly = xEstado
        txOrdenProd.ReadOnly = xEstado
        txNumF02.ButtonCustom.Visible = xEstado
        txTurno.ButtonCustom.Visible = xEstado
        txEmpresa.ButtonCustom.Enabled = xEstado
        txCargo.ButtonCustom.Enabled = xEstado
        txObservacion.ReadOnly = Not xEstado
        txPeriodo.ReadOnly = Not xEstado
        txOrdenProd.ReadOnly = Not xEstado
        'cbProducto.Enabled = xEstado
        cbMaterial.Enabled = xEstado
        'chkCertificada.Enabled = Not xEstado

    End Sub

    Private Sub LimpiarControles()
        'cbProducto.Text = ""
        txF02Id.Text = ""
        txNumF02.Text = ""
        dtFecha.Value = Date.Now()
        cbMaterial.Text = ""
        txTurnoId.Text = ""
        txTurno.Text = ""
        'chkCertificada.Checked = False
        txEmpresaId.Text = ""
        txEmpresa.Text = ""
        txResponsableId.Text = ""
        txResponsable.Text = ""
        txCargo.Text = ""
        txObservacion.Text = ""
        txPeriodo.Text = dtFecha.Value.Year().ToString
        txOrdenProd.Text = ""
    End Sub
    Private Sub mostrar_resumen_nro_doc()
        Try
            Dim col As Integer
            Dim dtsr As New vShowbrow
            Dim func As New fshowbrow
            dtsr.gt_tabla = "formato04_rumas"
            dtsr.gt_campos = "especie as Especie,sum(cantidad) as Cantidad,sum(volPt) as Vol_Pt,sum(VolM3) as Volm3"
            dtsr.gt_donde = IIf(txId.Text <> "", String.Format("f04_id = {0}", txId.Text), "")
            dtsr.gt_agruparpor = "especie"
            dtsr.gt_ordenarpor = ""
            Dt = func.mostrar(dtsr) 'Invocamos a la funcion mostrar()
            If Dt.Rows.Count <> -1 Then 'Si las filas al contarlas es diferente de cero
                col = Dt.Columns.Count
                dataResumen.AllowUserToResizeRows = False
                dataResumen.RowHeadersVisible = False
                dataResumen.DataSource = Dt
                'Formateando las columnas
                dataResumen.Columns.Item(0).Width = 160
                dataResumen.Columns.Item(1).Width = 70
                dataResumen.Columns.Item(2).Width = 70
                dataResumen.Columns.Item(3).Width = 70
                dataResumen.Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                dataResumen.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                dataResumen.Columns.Item(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                dataResumen.ColumnHeadersVisible = True
                dataResumen.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Else
                dataResumen.DataSource = Nothing
                dataResumen.ColumnHeadersVisible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Mostrar_ProduccionTotal()

        Try
            Dim col As Integer
            Dim dtsr As New vShowbrow
            Dim func As New fshowbrow

            lblProduccionDia.Text = "PRODUCCION TOTAL - DESDE :" + FechaInicioDatePicker.Value.ToShortDateString() + " HASTA :" + FechaFinDateTimePicker.Value.ToShortDateString()
            dtsr.gt_tabla = "vmostrar_producciontotal"
            dtsr.gt_campos = "Lote_Trozas,Lote_Aserrio,Especie,Producto,Cantidad,VolPT,VolM3,Fecha"
            Dim fecinicio As String = FechaInicioDatePicker.Value.Year.ToString() + "-" + FechaInicioDatePicker.Value.Month.ToString() + "-" + FechaInicioDatePicker.Value.Day.ToString()
            Dim fecfin As String = FechaFinDateTimePicker.Value.Year.ToString() + "-" + FechaFinDateTimePicker.Value.Month.ToString() + "-" + FechaFinDateTimePicker.Value.Day.ToString()
            dtsr.gt_donde = "Fecha >= '" + fecinicio + "' and Fecha <= '" + fecfin + "'"
            dtsr.gt_agruparpor = "Lote_Trozas,Lote_Aserrio,Especie"
            dtsr.gt_ordenarpor = ""
            Dt = func.mostrar(dtsr) 'Invocamos a la funcion mostrar()
            If Dt.Rows.Count <> -1 Then 'Si las filas al contarlas es diferente de cero
                col = Dt.Columns.Count
                dataListadoDia.AllowUserToResizeRows = False
                dataListadoDia.RowHeadersVisible = False
                dataListadoDia.DataSource = Dt
                'Formateando las columnas
                dataListadoDia.Columns.Item(0).Width = 70
                dataListadoDia.Columns.Item(1).Width = 70
                dataListadoDia.Columns.Item(2).Width = 150
                dataListadoDia.Columns.Item(3).Width = 150
                dataListadoDia.Columns.Item(4).Width = 70
                dataListadoDia.Columns.Item(5).Width = 70
                dataListadoDia.Columns.Item(6).Width = 70
                dataListadoDia.Columns.Item(7).Width = 70

                dataListadoDia.Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                dataListadoDia.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                dataListadoDia.Columns.Item(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                dataListadoDia.Columns.Item(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                dataListadoDia.Columns.Item(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                dataListadoDia.Columns.Item(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                dataListadoDia.Columns.Item(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

                dataListadoDia.ColumnHeadersVisible = True
                dataListadoDia.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Else
                dataListadoDia.DataSource = Nothing
                dataListadoDia.ColumnHeadersVisible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub resumen_clasificacion()
        Dim xPanel As GridPanel = sgRumas.PrimaryGrid
        Dim xRow As GridRow = Nothing
        Dim sd As New samadEntities
        'If xPanel.Rows.Count() > 0 Then
        If txId.Text <> "" Then
            Try
                pzPrimer = IIf(IsDBNull(sd.formato04_rumas.Where(Function(x) x.F04_Id = txId.Text And x.ClasificaProducto = "PRIMERA").Select(Function(x) x.Cantidad).Sum()), 0, (sd.formato04_rumas.Where(Function(x) x.F04_Id = txId.Text And x.ClasificaProducto = "PRIMERA").Select(Function(x) x.Cantidad).Sum()))
                pzSegunda = IIf(IsDBNull(sd.formato04_rumas.Where(Function(x) x.F04_Id = txId.Text And x.ClasificaProducto = "SEGUNDA").Select(Function(x) x.Cantidad).Sum()), 0, (sd.formato04_rumas.Where(Function(x) x.F04_Id = txId.Text And x.ClasificaProducto = "SEGUNDA").Select(Function(x) x.Cantidad).Sum()))
                VolPtPrimera = IIf(IsDBNull(sd.formato04_rumas.Where(Function(x) x.F04_Id = txId.Text And x.ClasificaProducto = "PRIMERA").Select(Function(x) x.VolPT).Sum()), 0, (sd.formato04_rumas.Where(Function(x) x.F04_Id = txId.Text And x.ClasificaProducto = "PRIMERA").Select(Function(x) x.VolPT).Sum()))
                VolPtSegunda = IIf(IsDBNull(sd.formato04_rumas.Where(Function(x) x.F04_Id = txId.Text And x.ClasificaProducto = "SEGUNDA").Select(Function(x) x.VolPT).Sum()), 0, (sd.formato04_rumas.Where(Function(x) x.F04_Id = txId.Text And x.ClasificaProducto = "SEGUNDA").Select(Function(x) x.VolPT).Sum()))
                'Volm3Primera = sd.formato04_rumas.Where(Function(x) x.F04_Id = txId.Text And x.ClasificaProducto = "PRIMERA").Select(Function(x) x.VolM3).Sum()
                'Volm3Segunda = sd.formato04_rumas.Where(Function(x) x.F04_Id = txId.Text And x.ClasificaProducto = "SEGUNDA").Select(Function(x) x.VolM3).Sum()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            pzPrimer = 0
            pzSegunda = 0
            VolPtPrimera = 0
            VolPtSegunda = 0
            'Volm3Primera = 0
            'Volm3Segunda = 0
        End If
        txtTotalPzasp.Text = pzPrimer
        txtTotalpzass.Text = pzSegunda
        txtTotalVolptp.Text = VolPtPrimera
        txtTotalVolpts.Text = VolPtSegunda

    End Sub

    Private Sub resume_lote()
        Try
            Dim xPanel As GridPanel = sgRumas.PrimaryGrid
            Dim xRow As GridRow = Nothing
            Dim dm As New samadEntities
            'Dim xProducto As String
            'If xPanel.Rows.Count() > 0 Then
            If txId.Text <> "" Then
                Try
                    xVolPt = dm.formato04_rumas.Where(Function(x) x.F04_Id = txId.Text).Select(Function(x) x.VolPT).Sum()
                    xVolm3 = dm.formato04_rumas.Where(Function(x) x.F04_Id = txId.Text).Select(Function(x) x.VolM3).Sum()
                Catch ex As Exception
                End Try
            Else
                xVolPt = 0
                xVolm3 = 0
            End If
            txVolPT.Text = xVolPt
            txVolM3.Text = xVolm3
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Funcion para Generar Automaticamente el Numero de Orden de Produccion
    'Consecutiva a partir del Periodo (Año de Proceso)

    Private Function NumeroDoctoProduccion() As String
        Try
            Dim dm As New samadEntities
            Dim xLast = dm.formato04.Where(Function(x) x.F04_Periodo = txPeriodo.Text).Select(Function(x) x.F04_OrdenProduccion).Max()
            NumeroDoctoProduccion = New fxSamad().StrCeros(xLast, 6, True)
            Dim xNext = dm.formato04.Where(Function(x) x.F04_Periodo = txPeriodo.Text).Select(Function(x) x.F04_Nro).Max()
            txtNro.Text = New fxSamad().StrCeros(xNext, 6, True)
        Catch ex As Exception
            Return "0"
        End Try
    End Function

    Private Function ValidarCampos() As Boolean
        'If String.IsNullOrEmpty(cbProducto.Text) = True Then
        '    MessageBox.Show("Seleccione el Tipo de Producción", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    cbMaterial.Focus()
        '    Return False
        'End If
        If String.IsNullOrEmpty(cbMaterial.Text) = True Then
            MessageBox.Show("Seleccione el Tipo de Material", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbMaterial.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txF02Id.Text) = True Then
            MessageBox.Show("Debe seleccionar la Orden de Corte en Aserrio", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txNumF02.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txTurnoId.Text) = True Then
            MessageBox.Show("Debe seleccionar el Turno de Produccion", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txTurno.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txEmpresaId.Text) = True Then
            MessageBox.Show("Debe seleccionar la Empresa o Aserrio", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txEmpresa.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txResponsable.Text) = True Then
            MessageBox.Show("Debe seleccionar el Responsable de Cubicación", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txResponsable.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txOrdenProd.Text) = True Then
            MessageBox.Show("No se ha ingresado la Orden de Producción", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txOrdenProd.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub DetalledeRumas()
        If String.IsNullOrEmpty(txId.Text) = False Then
            Dim dt As New DataSet
            Dim cn As New MySqlConnection(New fxSamad().GetCadenaConexionSamad())
            Dim da As New MySqlDataAdapter("SELECT a.RowId as Id, a.Codigo_ruma as Lote_Aserrio,b.Espe_NombreComun as Especie,a.Lote_troza as Lote, a.Cantidad as Cantidad, a.TipUnidad, a.VolM3, a.VolPT FROM formato04_rumas as a INNER JOIN especies as b ON a.EspecieId = b.Espe_Id Where a.f04_id='" & txId.Text & "'", cn)
            da.Fill(dt, "Rumas")
            CType(New MySqlDataAdapter("SELECT c.Orden as Itm,c.Espesor,c.Ancho, c.Largo,c.Cantidad,c.F04TipoUnidad as TipoUnidad, c.Vol_m3 as VolM3,c.Vol_pt as VolPT,c.RumaId as Ruma FROM formato04_rumas_det  as c ;", cn), MySqlDataAdapter).Fill(dt, "Detalle")
            dt.Relations.Add("1", dt.Tables("Rumas").Columns("Id"), dt.Tables("Detalle").Columns("Ruma"), False)

            sgRumas.PrimaryGrid.DataSource = dt
            'sgRumas.PrimaryGrid.Columns.Item("Ruma").Visible = False
            sgRumas.PrimaryGrid.ColumnHeader.RowHeight = 24

            If dt.Tables.Count > 0 Then
                btBorraRuma.Enabled = True

            Else
                btBorraRuma.Enabled = False
            End If
        End If
    End Sub
#End Region



    Private Sub frmFormato04_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataSet
        MostrarEncabezados()
        HabilitarControles(False)

        mostrar_resumen_nro_doc()
        resumen_clasificacion()
        resume_lote()
        btUltimo.PerformClick()

    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btNuevo.Click        
        LimpiarControles()
        HabilitarControles(True)
        xDoIt = True
        NumeroDoctoProduccion()
        sgRumas.PrimaryGrid.DataSource = Nothing
        dataResumen.DataSource = Nothing
        dataListadoDia.DataSource = Nothing
    End Sub

    Private Sub btUndo_Click(sender As System.Object, e As System.EventArgs) Handles btUndo.Click
        xDoIt = False
        HabilitarControles(False)
        MostrarEncabezados()
    End Sub

    Private Sub txNumF02_ButtonCustomClick(sender As System.Object, e As System.EventArgs) Handles txNumF02.ButtonCustomClick
        Dim wfBuscar As New frmShowbrow
        wfBuscar.titulo = "Nro de Formatos 02 Ingresados al Aserrio"
        wfBuscar.t_tabla = "Formato02"
        wfBuscar.t_campos = "f02_id,f02_fecha,f02_nrodoc,f02_emp_id,f02_NroOpe"
        wfBuscar.t_donde = ""
        wfBuscar.t_agruparpor = ""
        wfBuscar.t_ordenarpor = ""
        Dim titulos() As String = {"Id", "Fecha", "N° Formato", "Id_Aserr"}
        Dim anchos() As Integer = {30, 70, 100, 50}
        ReDim wfBuscar.matAnchos(anchos.Length)
        ReDim wfBuscar.matTitulos(titulos.Length)
        ReDim wfBuscar.matColumnas(titulos.Length)
        titulos.CopyTo(wfBuscar.matTitulos, 0)
        anchos.CopyTo(wfBuscar.matAnchos, 0)
        wfBuscar.ShowDialog(Me)
        If wfBuscar.flag = True Then
            txF02Id.Text = wfBuscar.matColumnas(0)
            txNumF02.Text = wfBuscar.matColumnas(2)
            xId_Aserr = wfBuscar.matColumnas(3)
            txOrdenProd.Text = wfBuscar.matColumnas(4)
        End If
        wfBuscar = Nothing
    End Sub

    Private Sub txTurno_ButtonCustomClick(sender As System.Object, e As System.EventArgs) Handles txTurno.ButtonCustomClick
        Dim wfBuscar As New frmShowbrow
        wfBuscar.titulo = "Turnos de Trabajo"
        wfBuscar.t_tabla = "turnos"
        wfBuscar.t_campos = "tur_id,tur_descrip,tur_horario"
        wfBuscar.t_donde = ""
        wfBuscar.t_agruparpor = ""
        wfBuscar.t_ordenarpor = ""
        Dim titulos() As String = {"Id", "Turno", "Horario"}
        Dim anchos() As Integer = {30, 100, 150}
        ReDim wfBuscar.matAnchos(anchos.Length)
        ReDim wfBuscar.matTitulos(titulos.Length)
        ReDim wfBuscar.matColumnas(titulos.Length)
        titulos.CopyTo(wfBuscar.matTitulos, 0)
        anchos.CopyTo(wfBuscar.matAnchos, 0)
        wfBuscar.ShowDialog(Me)
        If wfBuscar.flag = True Then
            txTurnoId.Text = wfBuscar.matColumnas(0)
            txTurno.Text = wfBuscar.matColumnas(2)
        End If
        wfBuscar = Nothing
    End Sub

    Private Sub txEmpresa_ButtonCustomClick(sender As System.Object, e As System.EventArgs) Handles txEmpresa.ButtonCustomClick
        Dim wfBuscar As New frmShowbrow
        wfBuscar.titulo = "Lista de Empresas Acerrios"
        wfBuscar.t_tabla = "titulares"
        wfBuscar.t_campos = "Pro_id,Pro_Titular,Pro_Ruc"
        wfBuscar.t_donde = String.Format("Pro_id = {0}", xId_Aserr)
        wfBuscar.t_agruparpor = ""
        wfBuscar.t_ordenarpor = ""
        Dim titulos() As String = {"Id", "Descripcion", "Ruc"}
        Dim anchos() As Integer = {30, 200, 90}
        ReDim wfBuscar.matAnchos(anchos.Length)
        ReDim wfBuscar.matTitulos(titulos.Length)
        ReDim wfBuscar.matColumnas(titulos.Length)
        titulos.CopyTo(wfBuscar.matTitulos, 0)
        anchos.CopyTo(wfBuscar.matAnchos, 0)
        wfBuscar.ShowDialog(Me)
        If wfBuscar.flag = True Then
            txEmpresaId.Text = wfBuscar.matColumnas(0)
            txEmpresa.Text = wfBuscar.matColumnas(1)
        End If
        wfBuscar = Nothing
    End Sub

    Private Sub dtFecha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtFecha.ValueChanged
        If xDoIt = True Then
            txPeriodo.Text = dtFecha.Value.Year.ToString()
            txOrdenProd.Text = NumeroDoctoProduccion()
        End If        
    End Sub

    Private Sub btGrabar_Click(sender As System.Object, e As System.EventArgs) Handles btGrabar.Click
        If ValidarCampos() = True Then
            Dim dt As New SAMAD.formato04
            If xExiste = True Then
                dt.F04_Id = txId.Text
            End If
            dt.F04_Nro = txtNro.Text
            dt.F04_Fecha = dtFecha.Value
            'dt.F04_Certificada = chkCertificada.CheckState
            'dt.F04_Creacion = cbProducto.Text
            dt.F04_TipoConteo = cbMaterial.Text
            'dt.F04_TipoCubicacion_Id = 1
            dt.F04_Turno_Id = txTurnoId.Text
            dt.F04_Nro_doc = txNumF02.Text
            dt.F04_Responsable_Id = txResponsableId.Text
            dt.F04_OrdenProduccion = txOrdenProd.Text
            dt.F04_Observacion = txObservacion.Text
            dt.F04_F02_Id = txF02Id.Text
            dt.F04_Pro_id = txEmpresaId.Text
            dt.F04_Periodo = txPeriodo.Text
            'dt.F04_Seguimiento = chkSeguimiento.CheckState
            Try
                If New cdFormato04().GrabarEnFormato04(dt, xExiste) = True Then
                    MostrarEncabezados()
                    HabilitarControles(False)
                    resume_lote()
                    resumen_clasificacion()
                    btUltimo.PerformClick()
                End If
            Catch ex As Exception
                MessageBox.Show(Err.ToString(), xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    'Private Sub txCargo_Click(sender As System.Object, e As System.EventArgs) Handles txCargo.Click
    '    Dim wfBuscar As New frmShowbrow
    '    'Enviamos los datos de la consulta sql
    '    wfBuscar.titulo = "Lista del Personal"
    '    wfBuscar.t_tabla = "Personal"
    '    wfBuscar.t_campos = "per_id,per_nomape,per_cargo"
    '    wfBuscar.t_donde = ""
    '    wfBuscar.t_agruparpor = ""
    '    wfBuscar.t_ordenarpor = ""
    '    Dim titulos() As String = {"Id", "Nombres y Apellidos", "Cargo"}
    '    Dim anchos() As Integer = {30, 200, 90}
    '    ReDim wfBuscar.matAnchos(anchos.Length)
    '    ReDim wfBuscar.matTitulos(titulos.Length)
    '    ReDim wfBuscar.matColumnas(titulos.Length)
    '    titulos.CopyTo(wfBuscar.matTitulos, 0)
    '    anchos.CopyTo(wfBuscar.matAnchos, 0)
    '    wfBuscar.ShowDialog(Me)
    '    If wfBuscar.flag = True Then
    '        txResponsableId.Text = wfBuscar.matColumnas(0)
    '        txResponsable.Text = wfBuscar.matColumnas(1)
    '        txCargo.Text = wfBuscar.matColumnas(2)
    '    End If
    '    wfBuscar = Nothing
    'End Sub

    Private Sub btPrimero_Click(sender As System.Object, e As System.EventArgs) Handles btPrimero.Click        
        recno = 0
        MostrarEncabezados()
        resume_lote()
        resumen_clasificacion()
        mostrar_resumen_nro_doc()
    End Sub

    Private Sub btSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles btSiguiente.Click
        recno = recno + 1
        If recno > dtHeader.Rows.Count - 1 Then
            recno = dtHeader.Rows.Count - 1
        End If
        MostrarEncabezados()
        resume_lote()
        resumen_clasificacion()
        mostrar_resumen_nro_doc()
    End Sub

    Private Sub btAnterior_Click(sender As System.Object, e As System.EventArgs) Handles btAnterior.Click
        recno = recno - 1
        If recno < 0 Then
            recno = 0
        End If
        MostrarEncabezados()
        resume_lote()
        resumen_clasificacion()
        mostrar_resumen_nro_doc()
    End Sub

    Private Sub btUltimo_Click(sender As System.Object, e As System.EventArgs) Handles btUltimo.Click
        recno = dtHeader.Rows.Count - 1
        MostrarEncabezados()
        resume_lote()
        resumen_clasificacion()
        mostrar_resumen_nro_doc()
    End Sub

    Private Sub btAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btAgregar.Click
        Dim xPanel As GridPanel = sgRumas.PrimaryGrid
        If String.IsNullOrEmpty(txId.Text) = True Then
            MessageBox.Show("No existen datos de Cabecera", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim ultreg As Integer
        ultreg = dtHeader.Rows.Count

        Dim wfDetalle As New frmFormato04_det
        wfDetalle.xFecha = dtFecha.Value
        wfDetalle.xExiste = False
        wfDetalle.xIdPapa = txId.Text
        wfDetalle.xF02pro = txNumF02.Text
        'If xPanel.Rows.Count() = 0 Then
        'wfDetalle.xF02pro = recno
        'Else
        'wfDetalle.xF02pro = txF02Id.Text
        'End If
        wfDetalle.xPeriodo = txPeriodo.Text
        wfDetalle.xTproduccion = cbMaterial.SelectedIndex
        wfDetalle.lbNumero.Text = txNumF02.Text  'txtNro.Text.ToString()
        wfDetalle.lbRowPapa.Text = txId.Text
        wfDetalle.xEmpresaId = txEmpresaId.Text
        wfDetalle.ShowDialog(Me)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        DetalledeRumas()
    End Sub

    Private Sub sgRumas_Click(sender As System.Object, e As System.EventArgs) Handles sgRumas.Click
        Dim xPanel As GridPanel = sgRumas.PrimaryGrid
        Dim xRow As GridRow = Nothing
        Dim dm As New samadEntities
        Dim xProducto As String
        If xPanel.Rows.Count() > 0 Then
            xRow = xPanel.ActiveRow
            txRuma.Text = xRow.Cells(0).Value

            xProducto = dm.formato04_rumas.Where(Function(x) x.RumaId = txRuma.Text).Select(Function(d) d.Descripcion_ruma).FirstOrDefault()
            lblTipomaterial.Text = xProducto
        End If
    End Sub

    ' Borra todo el Documento Maestro, y sus detalles
    Private Sub btBorrar_Click(sender As System.Object, e As System.EventArgs) Handles btBorrar.Click
        If String.IsNullOrEmpty(txId.Text) = True Then
            MessageBox.Show("No hay registro disponible para borrar", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If New cdFormato04().ProduccionRumas(txId.Text) = True Then
            MessageBox.Show("Esta produccion tiene registro de RUMAS dependientes, no es posible borrar el Registro", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If New fxSamad().BORRAR("formato04", "f04_id=" & txId.Text) = False Then
            MessageBox.Show("registro borrado con Exito", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtHeader = New fformato04().mostrar()
            recno = dtHeader.Rows.Count - 1
            xDoIt = False
            HabilitarControles(False)
            MostrarEncabezados()
            'btAnterior.PerformClick()
            Exit Sub
        End If
    End Sub

    ' Borra el registro de la Ruma y sus detalles (Registro de la GRID)
    Private Sub btBorraRuma_Click(sender As System.Object, e As System.EventArgs) Handles btBorraRuma.Click
        If String.IsNullOrEmpty(txRuma.Text) = True Then
            MessageBoxEx.Show("Debe seleccionar el Registro que desea borrar", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If New cdFormato04_rumas().RumaTieneDetalle(CInt(txRuma.Text)) = True Then
            MessageBox.Show("No es posible borrar este registro porque esta Ruma tiene detalle", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If MessageBox.Show("¿Realmente desea borrar este Registro de RUMA?", xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim xa = New fxSamad().BORRAR("formato04_rumas", "rowid=" & txRuma.Text)
        DetalledeRumas()
    End Sub

    Private Sub btEditar_Click(sender As System.Object, e As System.EventArgs) Handles btEditar.Click
        If sgRumas.PrimaryGrid.Rows.Count > 0 Then
            MessageBox.Show("No es posible editar este registro, porque ya tiene detalle de RUMAS", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        HabilitarControles(True)
    End Sub


    Private Sub btUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btUpdate.Click
        DetalledeRumas()
    End Sub

    Private Sub mostrarBT_Click(sender As System.Object, e As System.EventArgs) Handles mostrarBT.Click
        'cabecera = False
        Mostrar_ProduccionTotal()
    End Sub

  
    Private Sub txCargo_ButtonCustomClick(sender As System.Object, e As System.EventArgs) Handles txCargo.ButtonCustomClick
        Dim wfBuscar As New frmShowbrow
        'Enviamos los datos de la consulta sql
        wfBuscar.titulo = "Lista del Personal"
        wfBuscar.t_tabla = "Personal"
        wfBuscar.t_campos = "per_id,per_nomape,per_cargo"
        wfBuscar.t_donde = ""
        wfBuscar.t_agruparpor = ""
        wfBuscar.t_ordenarpor = ""
        Dim titulos() As String = {"Id", "Nombres y Apellidos", "Cargo"}
        Dim anchos() As Integer = {30, 200, 90}
        ReDim wfBuscar.matAnchos(anchos.Length)
        ReDim wfBuscar.matTitulos(titulos.Length)
        ReDim wfBuscar.matColumnas(titulos.Length)
        titulos.CopyTo(wfBuscar.matTitulos, 0)
        anchos.CopyTo(wfBuscar.matAnchos, 0)
        wfBuscar.ShowDialog(Me)
        If wfBuscar.flag = True Then
            txResponsableId.Text = wfBuscar.matColumnas(0)
            txResponsable.Text = wfBuscar.matColumnas(1)
            txCargo.Text = wfBuscar.matColumnas(2)
        End If
        wfBuscar = Nothing
    End Sub

   
End Class