Public Class frmVehiculos
    Private dt As New DataTable
    Dim func As New fvehiculos 'Creacion una variable para hacer referencia a la funcion fconcesiones
    Dim nreg, xreg As Integer
    Dim sw_guardar As Boolean = False
    Dim nuevo As Boolean = False
    Dim modificar As Boolean = False
    Dim msg As String = ""
    Dim frm As New frmShowbrow

    Dim xTitulo = fxSamad.Titulo

    Private Sub AplicarPerfil()
        If vInfraestructura.Usuario.gtipo = "ADMINISTRADOR" Then

        Else

            Panel2.Enabled = False
        End If
    End Sub

    Private Sub registro_seleccionado()
        If nreg = 0 Then
            Return
        End If
        txtId.Text = dataListado.SelectedCells.Item(1).Value
        txtMarca.Text = dataListado.SelectedCells.Item(2).Value
        TxTipo_Vehic.Text = dataListado.SelectedCells.Item(3).Value
        TxtPlaca.Text = dataListado.SelectedCells.Item(4).Value
        TxtNroinscripcion.Text = dataListado.SelectedCells.Item(5).Value
        If IsDBNull(dataListado.SelectedCells.Item(6).Value) = False Then
            cmbTipo.Text = dataListado.SelectedCells.Item(6).Value
        Else
            cmbTipo.Text = ""
        End If
        txtRazonSocial.Text = dataListado.SelectedCells.Item(7).Value
        txtEmtId.Text = dataListado.SelectedCells.Item(8).Value
    End Sub

    Private Sub deshabilitar()
        txtId.Enabled = False
        txtMarca.Enabled = False
        TxTipo_Vehic.Enabled = False
        TxtPlaca.Enabled = False
        TxtNroinscripcion.Enabled = False
        txtEmtId.Enabled = False
        txtRazonSocial.Enabled = False
        cmbTipo.Enabled = False
        btnEmpresa.Enabled = False
    End Sub

    Private Sub habiltar()
        txtId.Enabled = False
        txtMarca.Enabled = True
        TxTipo_Vehic.Enabled = True
        TxtPlaca.Enabled = True
        TxtNroinscripcion.Enabled = True
        txtEmtId.Enabled = False
        txtRazonSocial.Enabled = False
        cmbTipo.Enabled = True
        btnEmpresa.Enabled = True
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fvehiculos 'Creacion una variable para hacer referencia a la funcion fconcesiones
            dt = func.mostrar 'Invocamos a la funcion mostrar()
            dataListado.Columns.Item("Eliminar").Visible = False 'Ocultamos la Columna Eliminar

            nreg = dt.Rows.Count 'Almacenamos la cantidad de filas o registros recuperados
            If nreg <> 0 Then 'Si las filas al contarlas es diferente de cero
                dataListado.DataSource = dt
                txtBuscar.Visible = True
                dataListado.ColumnHeadersVisible = True
                lblinexistente.Visible = False
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
        dataListado.Columns(2).Width = 190
        dataListado.Columns(3).Width = 120
        dataListado.Columns(4).Width = 70
        dataListado.Columns(5).Width = 70
        dataListado.Columns(6).Width = 80
        dataListado.Columns(7).Width = 200
        dataListado.Columns(8).Width = 200
        'Centrando todas las columnas del DataGridView
        dataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dataListado.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'Cambiando el texto de las cabeceras
        dataListado.Columns(1).HeaderText = "Id"
        dataListado.Columns(2).HeaderText = "Marca/Vehículo"
        dataListado.Columns(3).HeaderText = "Tipo de Vehículo"
        dataListado.Columns(4).HeaderText = "Placa"
        dataListado.Columns(5).HeaderText = "Nro.Inscrip."
        dataListado.Columns(6).HeaderText = "Tipo transporte"
        dataListado.Columns(7).HeaderText = "Empresa de Transp."
        dataListado.Columns(8).HeaderText = "Empresa Id"
    End Sub

    Private Sub buscar()
        Try

            Dim ds As New DataSet 'Declaramos variable para tener una copiar del DataTable
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = String.Format("veh_placa Like '%{0}%'", txtBuscar.Text) 'Filtramos la busqueda
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
        dataListado.Columns(8).Visible = False
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

    Private Sub frmMaquinarias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        deshabilitar()
        mostrar()
        formatear_grid()
        dataListado.Focus()
        registro_seleccionado()
        AplicarPerfil()

    End Sub

    Private Sub limpiar()
        txtId.Text = ""
        txtMarca.Text = ""
        TxTipo_Vehic.Text = ""
        TxtPlaca.Text = ""
        TxtNroinscripcion.Text = ""
        cmbTipo.Text = ""
        txtEmtId.Text = ""
        txtRazonSocial.Text = ""
    End Sub

    Private Function validar_campos() As Boolean

        'Preguntamos si los controles estan vacios, para enviar el mensaje

        If String.IsNullOrEmpty(txtMarca.Text) = True Then
            MessageBox.Show("Debe ingresar la EMPRESA", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMarca.BackColor = Color.LightYellow
            txtMarca.Focus()
            Return False

        End If

        If String.IsNullOrEmpty(TxTipo_Vehic.Text) = True Then
            MessageBox.Show("Debe ingresar tipo de vehículo", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxTipo_Vehic.BackColor = Color.LightYellow
            TxTipo_Vehic.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(TxtPlaca.Text) = True Then
            MessageBox.Show("Debe ingresar Placa del Vehículo", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtPlaca.BackColor = Color.LightYellow
            TxtPlaca.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(TxtNroinscripcion.Text) = True Then
            MessageBox.Show("Debe ingresar el NRO.INSCRIPCION", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtNroinscripcion.BackColor = Color.LightYellow
            TxtNroinscripcion.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtRazonSocial.Text) = True Then
            MessageBox.Show("Debe ingresar el NRO.INSCRIPCION", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRazonSocial.BackColor = Color.LightYellow
            txtRazonSocial.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub dataListado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataListado.CellClick
        registro_seleccionado()
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
        txtMarca.Focus()
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
        txtMarca.Focus()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim result As DialogResult

        If validar_campos() = False Then
            Exit Sub
        Else
            sw_guardar = True
        End If


        If nuevo = True Then
            If New fvehiculos().PlacaVehiculoExiste(TxtPlaca.Text) = True Then
                MessageBox.Show("El numero de placa asignado a este Vehiculo ya existe registrado", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TxtPlaca.Focus()
                Exit Sub
            End If
        End If
        If sw_guardar = True Then 'Guardamos si los controles no estan vacios
            result = MessageBox.Show("Esta seguro de GUARDAR el registro ?", "Guardar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Try
                    Dim dts As New vVehiculos
                    Dim func As New fvehiculos

                    dts.gvehmarca = txtMarca.Text
                    dts.gvtipovehic = TxTipo_Vehic.Text
                    dts.gvehplaca = TxtPlaca.Text
                    dts.gvehnroinscripcion = TxtNroinscripcion.Text
                    dts.gvehemtid = txtEmtId.Text
                    dts.gvehtipo = cmbTipo.Text

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
                        dts.gvehid = txtId.Text
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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
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
    End Sub

    Private Sub btnEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpresa.Click
        'Enviamos los datos de la consulta sql
        frm.t_tabla = "titulares"
        frm.t_campos = "pro_id,pro_titular,pro_transporteck"
        frm.t_donde = "pro_transporteck=1"
        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Empresa"}
        Dim anchos() As Integer = {30, 250}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)

        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog(Me)

        If frm.flag = True Then
            txtEmtId.Text = frm.matColumnas(0)
            txtRazonSocial.Text = frm.matColumnas(1)
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Esta seguro de ELIMINAR " & xreg & " registro(s) seleccionado(s)...?", "Eliminar registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dataListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("veh_id").Value)
                        If New fvehiculos().VehiculoEnListaTrozasc(onekey) = True Then
                            MessageBox.Show("Imposible eliminar este Vehiculo, porque tiene GTF asignados", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Continue For
                        End If
                        Dim vdb As New vVehiculos
                        Dim func As New fvehiculos
                        vdb.gvehid = onekey
                        If func.eliminar(vdb) Then

                        Else
                            MessageBox.Show("Registro NO fue eliminado", "Eliminar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Next
                chkEliminar.Checked = False
                mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub dataListado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataListado.CellDoubleClick
        registro_seleccionado()
        tcDatos.SelectedIndex = 1
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Dim frmEmpresa As New frmTitulares
        frmEmpresa.ShowDialog(Me)
    End Sub


#Region "COMPORTAMIENTO DE LOS CONTROLES"
    Private Sub txtMarca_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMarca.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            siguientecontrol()
        End If
    End Sub
    Private Sub TxTipo_Vehic_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxTipo_Vehic.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            siguientecontrol()
        End If
    End Sub
    Private Sub TxtPlaca_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPlaca.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            siguientecontrol()
        End If
    End Sub
    Private Sub TxtNroinscripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroinscripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            siguientecontrol()
        End If
    End Sub
    Private Sub CMBTIPO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipo.KeyPress
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