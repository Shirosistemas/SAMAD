Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Public Class wfEmpaquetado

    'Dim dtPakete As List(Of SAMAD.vw_empaquetado)
    Dim dtPakete As DataTable
    Dim xTitulo = fxSamad.Titulo
    Dim recno As Integer = 0
    Dim xExiste As Boolean = False
    Friend actualiza As Boolean = False
    Public xId_Aserradero01 As Integer = 0

    Public Sub actualiza_grid()
        ListarDetallePaquete()
    End Sub


#Region "Funciones y Procedimientos Locales"

    Private Sub ListarEncabezados()
        'dtPakete = New cdEmpaquetado().PakequeHeaderLista()
        dtPakete = New fEmpaquetado().mostrar()

        If dtPakete.Rows.Count() > 0 Then
            xId_Aserradero01 = dtPakete.Rows(recno).Item("Emp_AserraderoId").ToString()
            txNumero.Text = dtPakete.Rows(recno).Item("Emp_NroDoc").ToString()
            dtFecha.Value = dtPakete.Rows(recno).Item("Emp_Fecha").ToString()
            chkCertificada.Checked = dtPakete.Rows(recno).Item("Emp_Certificado").ToString()
            txRowId.Text = dtPakete.Rows(recno).Item("RowId").ToString()
            txExpresaId.Text = dtPakete.Rows(recno).Item("Emp_AserraderoId").ToString()
            txEmpresa.Text = dtPakete.Rows(recno).Item("Pro_Titular").ToString()
            txCubicadorId.Text = dtPakete.Rows(recno).Item("Emp_CubicadorId").ToString()
            txCubicador.Text = dtPakete.Rows(recno).Item("Emp_Cubicador").ToString()
            txComentario.Text = dtPakete.Rows(recno).Item("Emp_observacion").ToString()
            txRecno.Text = recno & " de " & dtPakete.Rows.Count
            ListarDetallePaquete()
        Else
            'Limpiar Controles
            sgDetalle.PrimaryGrid.Rows.Clear()
        End If
    End Sub

    Private Sub ListarDetallePaquete()
        If String.IsNullOrEmpty(txRowId.Text) = False Then
            Dim dt As New DataSet
            Dim cn As New MySqlConnection(New fxSamad().GetCadenaConexionSamad())
            'Dim da As New MySqlDataAdapter("SELECT a.RowId as Id, a.Codigo_ruma as Ruma,b.Espe_NombreComun as Especie,a.Lote_origen as Lote, a.Cantidad_pieszas Piezas, a.VolM3, a.VolPT,a.f04_id Regno FROM formato04_rumas as a INNER JOIN especies as b ON a.EspecieId = b.Espe_Id Where a.f04_id='" & txId.Text & "'", cn)
            Dim da As New MySqlDataAdapter("SELECT p.RowId AS ID,p.Numpaquete AS Paquete,e.Espe_NombreComun AS Especie,p.Acabado,p.Humedad,p.Cantidad,p.Volm3,p.Volpt,p.EmpaquetadoId AS pid FROM paquete AS p INNER JOIN especies AS e ON p.EspecieId = e.Espe_Id  Where p.empaquetadoid=" & txRowId.Text, cn)
            da.Fill(dt, "Paquete")
            CType(New MySqlDataAdapter("SELECT pd.RowId,pd.Espesor,pd.Ancho,pd.Largo,pd.Cantidad,pd.VolM3,pd.VolPT,pd.PaqueteId FROM paquete_deta AS pd;", cn), MySqlDataAdapter).Fill(dt, "Detalle")
            dt.Relations.Add("1", dt.Tables("paquete").Columns("Id"), dt.Tables("Detalle").Columns("paqueteid"), False)
            sgDetalle.PrimaryGrid.DataSource = dt
            sgDetalle.PrimaryGrid.ColumnHeader.RowHeight = 24
            'If dt.Tables.Count > 0 Then
            'btBorraRuma.Enabled = True
            'Else
            '   btBorraRuma.Enabled = False
            'End If
        End If
    End Sub

    Private Sub HabilitarControles(ByVal xEstado As Boolean)
        btNuevo.Enabled = Not xEstado
        btEditar.Enabled = Not xEstado
        btGrabar.Enabled = xEstado
        BtEliminar.Enabled = Not xEstado
        btAtras.Enabled = xEstado
        dtFecha.Enabled = xEstado
        txPeriodo.Enabled = xEstado
        txComentario.ReadOnly = Not xEstado
        chkCertificada.Enabled = xEstado
        txEmpresa.ButtonCustom.Visible = xEstado
        txEmpresa.Enabled = xEstado
        txCubicador.Enabled = xEstado
        txCubicador.ButtonCustom.Visible = xEstado
    End Sub

    Private Sub LimpiarControles()
        dtFecha.Value = Date.Now()
        txRowId.Text = ""
        txExpresaId.Text = ""
        txEmpresa.Text = ""
        txComentario.Text = ""
        txCubicadorId.Text = ""
        txCubicador.Text = ""
        chkCertificada.Checked = False
        txNumero.Text = New cdEmpaquetado().NumeroEmpaquetado(Year(dtFecha.Value).ToString())
    End Sub

    
#End Region

    Private Sub btSalir_Click(sender As System.Object, e As System.EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub wfEmpaquetado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' dtPakete = New cdEmpaquetado().PakequeHeaderLista()
        HabilitarControles(False)

        ListarEncabezados()
        recno = dtPakete.Rows.Count
        btUltimo_Click(Me, e)

        

    End Sub

    Public Sub refresca(ByVal refr As Boolean)
        If actualiza = True Then
            'btUltimo_Click(Me, e)
            ListarDetallePaquete()
        End If
    End Sub
    Private Sub txEmpresa_ButtonCustomClick(sender As System.Object, e As System.EventArgs) Handles txEmpresa.ButtonCustomClick
        Dim wfBuscar As New frmShowbrow
        wfBuscar.titulo = "Lista de Empresas Aserrios"
        wfBuscar.t_tabla = "vmostrar_EmpAserio_paq"
        wfBuscar.t_campos = "F04_Pro_Id,Pro_Titular"
        wfBuscar.t_donde = ""
        wfBuscar.t_agruparpor = "F04_Pro_Id,Pro_Titular"
        wfBuscar.t_ordenarpor = ""
        Dim titulos() As String = {"Id", "Descripcion"}
        Dim anchos() As Integer = {30, 200}
        ReDim wfBuscar.matAnchos(anchos.Length)
        ReDim wfBuscar.matTitulos(titulos.Length)
        ReDim wfBuscar.matColumnas(titulos.Length)
        titulos.CopyTo(wfBuscar.matTitulos, 0)
        anchos.CopyTo(wfBuscar.matAnchos, 0)
        wfBuscar.ShowDialog(Me)
        If wfBuscar.flag = True Then
            txExpresaId.Text = wfBuscar.matColumnas(0)
            txEmpresa.Text = wfBuscar.matColumnas(1)
        End If
        wfBuscar = Nothing

    End Sub


    Private Sub btAdd_Click(sender As System.Object, e As System.EventArgs) Handles btAdd.Click
        If String.IsNullOrEmpty(txRowId.Text) = True Then
            MessageBox.Show("No hay registros de encabezados para este Empaquetado", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim wfDetalle As New wfEmpaquetado_detalle
        wfDetalle.xEmpquetadoId = txRowId.Text
        wfDetalle.xPeriodo = Year(dtFecha.Value)
        wfDetalle.xIdaserradero = txExpresaId.Text
        'wfDetalle.xrecno = txRecno.Text
        wfDetalle.xExiste = False
        wfDetalle.ShowDialog(Me)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        ListarDetallePaquete()
    End Sub

   

    Private Sub btGrabar_Click(sender As System.Object, e As System.EventArgs) Handles btGrabar.Click
        If String.IsNullOrEmpty(txExpresaId.Text) = True Then
            MessageBox.Show("No se ha seleccionado el nombre del Aserradero", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txEmpresa.Focus()
            Exit Sub
        End If
        Dim em As New samadEntities
        Dim dt As New SAMAD.empaquetado
        Dim res_exist = em.empaquetado.Where(Function(x) x.Emp_NroDoc = txNumero.Text And x.Emp_AserraderoId = txExpresaId.Text).ToList().Count()
        If res_exist > 0 Then
            xExiste = True
        Else
            xExiste = False
        End If

        If xExiste = True Then
            dt.RowId = txRowId.Text
        End If
        dt.Emp_NroDoc = txNumero.Text
        dt.Emp_Fecha = dtFecha.Value
        dt.Emp_Certificado = chkCertificada.CheckState
        dt.Emp_AserraderoId = txExpresaId.Text
        dt.Emp_CubicadorId = txExpresaId.Text
        dt.Emp_Cubicador = txCubicador.Text
        dt.Emp_Periodo = txPeriodo.Text
        dt.Emp_observacion = txComentario.Text


        If New cdEmpaquetado().PaqueteHeaderGrabar(dt, xExiste) = False Then
            MessageBox.Show("No se pudo guardar los datos del Documento de Control de empaquetado", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        btUltimo_Click(Me, e)
        HabilitarControles(False)

    End Sub

    Private Sub btNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btNuevo.Click
        LimpiarControles()
        HabilitarControles(True)
        sgDetalle.PrimaryGrid.DataSource = Nothing
    End Sub


    Private Sub txCubicador_ButtonCustomClick(sender As System.Object, e As System.EventArgs) Handles txCubicador.ButtonCustomClick
        'Enviamos los datos de la consulta sql
        Dim wfBuscar As New frmShowbrow
        wfBuscar.titulo = "Personal Cubicador"
        wfBuscar.t_tabla = "personal"
        wfBuscar.t_campos = "per_id,per_nomape,per_cargo"
        wfBuscar.t_donde = ""
        wfBuscar.t_agruparpor = ""
        wfBuscar.t_ordenarpor = ""
        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Nombres y Apellidos", "Cargo"}
        Dim anchos() As Integer = {30, 200, 90}
        ReDim wfBuscar.matAnchos(anchos.Length)
        ReDim wfBuscar.matTitulos(titulos.Length)
        ReDim wfBuscar.matColumnas(titulos.Length)
        titulos.CopyTo(wfBuscar.matTitulos, 0)
        anchos.CopyTo(wfBuscar.matAnchos, 0)
        wfBuscar.ShowDialog(Me)
        'Datos del Titular
        If wfBuscar.flag = True Then
            txCubicadorId.Text = wfBuscar.matColumnas(0)
            txCubicador.Text = wfBuscar.matColumnas(1)
        End If
        wfBuscar = Nothing
    End Sub

    Private Sub dtFecha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtFecha.ValueChanged
        txPeriodo.Text = Year(dtFecha.Value.ToShortDateString()) 'Year(txFecha.Text)
        'txLote.Text = New fxSamad().StrCeros(New cdFormato01().NumeroLote(txPeriodo.Text), 6, True)
    End Sub

    Private Sub btPrimero_Click(sender As System.Object, e As System.EventArgs) Handles btPrimero.Click
        recno = 0
        ListarEncabezados()
    End Sub

    Private Sub btAnterior_Click(sender As System.Object, e As System.EventArgs) Handles btAnterior.Click
        recno = recno - 1
        If recno < 0 Then
            recno = 0
        End If
        ListarEncabezados()
    End Sub

    Private Sub btSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles btSiguiente.Click
        recno = recno + 1
        If recno > dtPakete.Rows.Count - 1 Then
            recno = dtPakete.Rows.Count - 1
        End If
        ListarEncabezados()
    End Sub

    Private Sub btUltimo_Click(sender As System.Object, e As System.EventArgs) Handles btUltimo.Click
        If dtPakete.Rows.Count = 0 Then
            recno = dtPakete.Rows.Count
        Else
            recno = dtPakete.Rows.Count - 1
        End If
        ListarEncabezados()
    End Sub


    Private Sub BtEliminar_Click(sender As System.Object, e As System.EventArgs) Handles BtEliminar.Click
        If String.IsNullOrEmpty(txRowId.Text) = True Then
            MessageBox.Show("No hay registro disponible para borrar", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If New cdEmpaquetado().EmpaquetadoPaquetes(txRowId.Text) = True Then
            MessageBox.Show("Esta produccion tiene registro de RUMAS dependientes, no es posible borrar el Registro", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If New fxSamad().BORRAR("empaquetado", "RowId=" & txRowId.Text) = False Then
            MessageBox.Show("Registro borrado con exito", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'Exit Sub
            btAnterior_Click(Me, e)
        End If
    End Sub

    Private Sub btEditar_Click(sender As System.Object, e As System.EventArgs) Handles btEditar.Click
        If sgDetalle.PrimaryGrid.Rows.Count > 0 Then
            MessageBox.Show("No es posible editar este registro, porque ya tiene detalle de RUMAS", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        HabilitarControles(True)
    End Sub

    Private Sub btBorrar_Click(sender As System.Object, e As System.EventArgs) Handles btBorrar.Click
        If sgDetalle.PrimaryGrid.Rows.Count > 0 Then
            If String.IsNullOrEmpty(txLoteAserrio.Text) = True Then
                MessageBoxEx.Show("Debe seleccionar el Registro que desea borrar", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If New cdPaquete_det().PaqueteTieneDetalle(CInt(txLoteAserrio.Text)) = True Then
                MessageBox.Show("No es posible borrar este registro porque este Paquete tiene detalle", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If MessageBox.Show("¿Realmente desea borrar este Registro de Paquete?", xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            Dim xa = New fxSamad().BORRAR("paquete", "rowid=" & txLoteAserrio.Text)
            ListarDetallePaquete()
            txLoteAserrio.Clear()
        End If
    End Sub

    Private Sub btAtras_Click(sender As System.Object, e As System.EventArgs) Handles btAtras.Click
        HabilitarControles(False)
        ListarEncabezados()
    End Sub

    Private Sub sgDetalle_Click(sender As System.Object, e As System.EventArgs) Handles sgDetalle.Click
        Dim xPanel As GridPanel = sgDetalle.PrimaryGrid
        Dim xRow As GridRow = Nothing
        Dim dm As New samadEntities

        If xPanel.Rows.Count() > 0 Then
            xRow = xPanel.ActiveRow
            txLoteAserrio.Text = xRow.Cells(0).Value
        End If
    End Sub
End Class