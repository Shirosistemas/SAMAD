Public Class FrmZafrasypoas
    Private dt As New DataTable
    Dim func As New fzafrasypoas 'Creacion una variable para hacer referencia a la funcion fconcesiones
    Dim nreg, xreg As Integer
    Dim sw_guardar As Boolean = False
    Dim nuevo As Boolean = False
    Dim modificar As Boolean = False
    Dim msg As String = ""
    Dim frm As New frmShowbrow

    Dim xTitulo = fxSamad.Titulo

    Private Sub deshabilitar()
        txtId.Enabled = False
        TxNresolucion.Enabled = False
        TxTipoPm.Enabled = False
        txtZafra.Enabled = False
        txtPoa.Enabled = False
        txtPermisoid.Enabled = False
        txtPermiso.Enabled = False
        btnEmpresa.Enabled = False
        TxtTitular.Enabled = False
    End Sub

    Private Sub AplicarPerfil()
        If vInfraestructura.Usuario.gtipo = "ADMINISTRADOR" Then

        Else

            Panel2.Enabled = False
        End If
    End Sub
    Private Sub habiltar()
        txtId.Enabled = False
        TxNresolucion.Enabled = True
        TxTipoPm.Enabled = True
        txtZafra.Enabled = True
        txtPoa.Enabled = True
        txtPermisoid.Enabled = False
        txtPermiso.Enabled = False
        btnEmpresa.Enabled = True
        TxtTitular.Enabled = False
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fzafrasypoas 'Creacion una variable para hacer referencia a la funcion fconcesiones
            dt = func.mostrar 'Invocamos a la funcion mostrar()
            dataListado.Columns.Item("Eliminar").Visible = False 'Ocultamos la Columna Eliminar

            nreg = dt.Rows.Count 'Almacenamos la cantidad de filas o registros recuperados
            If nreg <> 0 Then 'Si las filas al contarlas es diferente de cero
                dataListado.DataSource = dt
                txtBuscar.Visible = True
                dataListado.ColumnHeadersVisible = True
                lblinexistente.Visible = False
                ocultar_columnas()
            Else
                dataListado.DataSource = Nothing
                txtBuscar.Visible = False
                dataListado.ColumnHeadersVisible = False
                lblinexistente.Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        btnNuevo.Enabled = True
        If nreg <> 0 Then
            btnModificar.Enabled = True
            btnCancelar.Enabled = False
            btnGuardar.Enabled = False
            btnEliminar.Enabled = False
        End If
        buscar()
    End Sub

    Private Sub formatear_grid()
        If nreg = 0 Then
            Return
        End If
        'Quitando lo necesario
        dataListado.AllowUserToResizeRows = False
        dataListado.RowHeadersVisible = False

        'Modificando el ancho de las columnas
        dataListado.Columns(1).Width = 20
        dataListado.Columns(2).Width = 180
        dataListado.Columns(3).Width = 180
        dataListado.Columns(4).Width = 40
        dataListado.Columns(5).Width = 50
        dataListado.Columns(6).Width = 20
        dataListado.Columns(7).Width = 180
        dataListado.Columns(8).Width = 230
        'Centrando todas las columnas del DataGridView
        dataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'Cambiando el texto de las cabeceras
        dataListado.Columns(1).HeaderText = "Id"
        dataListado.Columns(2).HeaderText = "No Resolución"
        dataListado.Columns(3).HeaderText = "Tipo de Plan de Manejo"
        dataListado.Columns(4).HeaderText = "Zafra"
        dataListado.Columns(5).HeaderText = "Poa"
        dataListado.Columns(6).HeaderText = "Permiso Id"
        dataListado.Columns(7).HeaderText = "Permiso"
        dataListado.Columns(8).HeaderText = "Propietario"

    End Sub
    Private Sub buscar()
        Try

            Dim ds As New DataSet 'Declaramos variable para tener una copiar del DataTable
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = String.Format("zyp_poa Like '%{0}%'", txtBuscar.Text) 'Filtramos la busqueda
            If dv.Count <> 0 Then
                lblinexistente.Visible = False
                dataListado.DataSource = dv
                txtBuscar.Enabled = True
                ocultar_columnas()
            Else
                lblinexistente.Visible = True
                dataListado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ocultar_columnas()
        dataListado.Columns(1).Visible = False
        dataListado.Columns(6).Visible = False
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        buscar()
    End Sub
    Private Sub limpiar()
        TxNresolucion.Text = ""
        TxTipoPm.Text = ""
        txtId.Text = ""
        txtZafra.Text = ""
        txtPoa.Text = ""
        txtPermisoid.Text = ""
        txtPermiso.Text = ""
        TxtTitular.Text = ""
    End Sub
    Private Function validar_campos() As Boolean

        'Preguntamos si los controles estan vacios, para enviar el mensaje
        If String.IsNullOrEmpty(TxNresolucion.Text) = True Then
            MessageBox.Show("No a Ingresado la resolucion", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxNresolucion.BackColor = Color.LightYellow
            TxNresolucion.Focus()
            Return False

        End If

        If String.IsNullOrEmpty(TxTipoPm.Text) = True Then
            MessageBox.Show("No ha ingresado el tipo de Plan de Manejo", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxNresolucion.BackColor = Color.LightYellow
            TxTipoPm.BackColor = Color.LightYellow
            TxTipoPm.Focus()
            Return False

        End If

        If String.IsNullOrEmpty(txtZafra.Text) = True Then
            MessageBox.Show("No ha ingresado la Zafra", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtZafra.BackColor = Color.LightYellow
            txtZafra.Focus()
            Return False
        Else
            sw_guardar = True
        End If

        If String.IsNullOrEmpty(txtPoa.Text) = True Then
            MessageBox.Show("No ha ingresado el numero de PO", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPoa.BackColor = Color.LightYellow
            txtPoa.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtPermiso.Text) = True Then
            MessageBox.Show("No ha ingresado el numero de contrato", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPermiso.BackColor = Color.LightYellow
            txtPermiso.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub registro_seleccionado()
        If nreg = 0 Then
            Return
        End If
        txtId.Text = dataListado.SelectedCells.Item(1).Value
        TxNresolucion.Text = dataListado.SelectedCells.Item(2).Value
        TxTipoPm.Text = dataListado.SelectedCells.Item(3).Value
        txtZafra.Text = dataListado.SelectedCells.Item(4).Value
        txtPoa.Text = dataListado.SelectedCells.Item(5).Value
        txtPermiso.Text = dataListado.SelectedCells.Item(6).Value
        txtPermisoid.Text = dataListado.SelectedCells.Item(7).Value
        TxtTitular.Text = dataListado.SelectedCells.Item(8).Value

    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmZafrasypoas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        deshabilitar()
        mostrar()
        formatear_grid()
        dataListado.Focus()
        registro_seleccionado()
        AplicarPerfil()

    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        deshabilitar()
        registro_seleccionado()
        limpiar()
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = False
        btnSalir.Enabled = True
        tcDatos.SelectedIndex = 0
        tpDatos.Parent = Nothing
        tpLista.Parent = tcDatos
        tpDatos.Parent = tcDatos
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim result As DialogResult
        If validar_campos() = False Then
            Exit Sub
        Else
            sw_guardar = True
        End If

        If sw_guardar = True Then 'Guardamos si los controles no estan vacios
            result = MessageBox.Show("Esta seguro de GUARDAR el registro ?", "Guardar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Try
                    Dim dts As New vZafrasypoas
                    Dim func As New fzafrasypoas
                    dts.gzypresolucion = TxNresolucion.Text
                    dts.gzyptipopm = TxTipoPm.Text
                    dts.gzypzafra = txtZafra.Text
                    dts.gzyppoa = txtPoa.Text
                    dts.gzyppermisoid = txtPermisoid.Text

                    'Codigo para insertar registros
                    If nuevo = True Then
                        If func.insertar(dts) Then
                            MessageBox.Show("Datos guardados correctamente...!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            limpiar()
                            deshabilitar()
                            registro_seleccionado()
                            btnNuevo.Enabled = True
                            btnModificar.Enabled = True
                            btnGuardar.Enabled = False
                            btnCancelar.Enabled = False
                            btnEliminar.Enabled = False
                            btnSalir.Enabled = True
                            tcDatos.SelectedIndex = 0
                            tpDatos.Parent = Nothing
                            tpLista.Parent = tcDatos
                            tpDatos.Parent = tcDatos
                            mostrar()
                        Else
                            MessageBox.Show("Datos No fueron registrados, intente de nuevo!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            mostrar()
                            limpiar()
                        End If
                    End If

                    'Codigo para editar registros
                    If modificar = True Then
                        dts.gzypid = txtId.Text
                        If func.editar(dts) Then
                            MessageBox.Show("Datos editados correctamente...!", "Editando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            mostrar()
                            deshabilitar()
                            registro_seleccionado()
                            btnNuevo.Enabled = True
                            btnModificar.Enabled = True
                            btnGuardar.Enabled = False
                            btnCancelar.Enabled = False
                            btnEliminar.Enabled = False
                            btnSalir.Enabled = True
                            tcDatos.SelectedIndex = 0
                            tpDatos.Parent = Nothing
                            tpLista.Parent = tcDatos
                            tpDatos.Parent = tcDatos
                        Else
                            MessageBox.Show("Datos No fueron editados, intente de nuevo!", "Editando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            deshabilitar()
                            registro_seleccionado()
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            MessageBox.Show(msg, "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        nuevo = True
        modificar = False
        tcDatos.SelectedIndex = 1
        tpLista.Parent = Nothing
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnEliminar.Enabled = False
        btnSalir.Enabled = False
        habiltar()
        limpiar()
        TxNresolucion.Focus()
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        modificar = True
        nuevo = False
        sw_guardar = False
        tcDatos.SelectedIndex = 1
        tpLista.Parent = Nothing
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnEliminar.Enabled = False
        btnSalir.Enabled = False
        habiltar()
        TxNresolucion.Focus()
    End Sub
    Private Sub dataListado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataListado.CellClick
        registro_seleccionado()
    End Sub
    Private Sub chkEliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEliminar.CheckedChanged
        If chkEliminar.CheckState = CheckState.Checked Then
            dataListado.Columns.Item("Eliminar").Visible = True
            dataListado.Columns.Item("Eliminar").Width = 20
            dataListado.Columns.Item("Eliminar").HeaderText = ""
        Else
            dataListado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub
    Private Sub dataListado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataListado.CellContentClick
        If e.ColumnIndex = Me.dataListado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.dataListado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
            If chkcell.Value = True Then
                xreg += 1
            Else
                xreg -= 1
            End If
            If xreg <> 0 Then
                btnEliminar.Enabled = True
            Else
                btnEliminar.Enabled = False
            End If
        End If
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Esta seguro de ELIMINAR " & xreg & " registro(s) seleccionado(s)...?", "Eliminar registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dataListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then

                        Dim onekey As Integer = Convert.ToInt32(row.Cells("zyp_id").Value)
                        Dim vdb As New vZafrasypoas
                        Dim func As New fzafrasypoas

                        vdb.gzypid = onekey
                        If func.eliminar(vdb) Then

                        Else
                            MessageBox.Show("Registro NO fue eliminado", "Eliminar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    End If
                Next
                mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpresa.Click

        frm.titulo = "Contratos/Permisos"
        'Datos para la consulta sql
        frm.t_tabla = "vmostrar_contratos"
        frm.t_campos = "con_id,Con_Descripcion,pro_titular"
        frm.t_donde = ""
        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Permiso", "Titular"}
        Dim anchos() As Integer = {30, 180, 200}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)


        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog(Me)

        If frm.flag = True Then
            txtPermisoid.Text = frm.matColumnas(0)
            txtPermiso.Text = frm.matColumnas(1)
            TxtTitular.Text = frm.matColumnas(2)

        End If
    End Sub

    Private Sub dataListado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataListado.CellDoubleClick
        registro_seleccionado()
        tcDatos.SelectedIndex = 1
    End Sub
#Region "CONTROL DE EVENTOS DE LOS TEXTBOX"
    Private Sub TxNresolucion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxNresolucion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            siguientecontrol()
        End If
    End Sub
    Private Sub TxTipoPm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxTipoPm.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            siguientecontrol()
        End If
    End Sub
    Private Sub txtZafra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtZafra.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            siguientecontrol()
        End If
    End Sub
    Private Sub txtpoa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPoa.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            siguientecontrol()
        End If
    End Sub
    Private Sub btnEmpresa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnEmpresa.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            siguientecontrol()
        End If
    End Sub

    Private Sub siguientecontrol()
        SendKeys.Send("{TAB}")
    End Sub
#End Region

   
 
End Class