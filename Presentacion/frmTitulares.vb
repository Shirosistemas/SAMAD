Public Class frmTitulares
    Private dt As New DataTable
    Dim func As New ftitulares 'Creacion una variable para hacer referencia a la funcion fconcesiones
    Dim nreg, xreg, dptoId, provId, DistId As Integer
    Dim propietario, destinatario, transportista As String
    Dim sw_guardar As Boolean = False
    Dim nuevo As Boolean = False
    Dim modificar As Boolean = False
    Dim msg As String = ""
    Dim frmdep, frmprov, frmdist As New frmShowbrow

    Dim xTitulo = fxSamad.Titulo

    Private Sub AplicarPerfil()
        If vInfraestructura.Usuario.gtipo = "ADMINISTRADOR" Then

        Else

            Panel2.Enabled = False
        End If
    End Sub

    Private Sub frmPropietarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        deshabilitar()
        mostrar()
        formatear_grid()
        dataListado.Focus()
        registro_seleccionado()
        AplicarPerfil()

    End Sub

    Private Sub deshabilitar()
        txtId.Enabled = False
        txtTitular.Enabled = False
        TxNoDni.Enabled = False
        TxNomRespLegal.Enabled = False
        txtRuc.Enabled = False
        txtDepartamento.Enabled = False
        txtProvincia.Enabled = False
        txtDistrito.Enabled = False
        txtSector.Enabled = False
        chkPropietario.Enabled = False
        chkDestino.Enabled = False
        chkTransporte.Enabled = False
        txtDireccion.Enabled = False
        'txtDepaid.Enabled = False
        'txtProvid.Enabled = False
        'txtDistid.Enabled = False
        btnDepa.Enabled = False
        btnProv.Enabled = False
        btnDist.Enabled = False
    End Sub

    Private Sub habiltar()
        txtId.Enabled = False
        txtTitular.Enabled = True
        TxNoDni.Enabled = True
        txtRuc.Enabled = True
        TxNomRespLegal.Enabled = True
        txtDepartamento.Enabled = False
        txtProvincia.Enabled = False
        txtSector.Enabled = True
        txtDistrito.Enabled = False
        chkPropietario.Enabled = True
        chkDestino.Enabled = True
        chkTransporte.Enabled = True
        txtDireccion.Enabled = True
        'txtDepaid.Enabled = False
        'txtProvid.Enabled = False
        'txtDistid.Enabled = False
        btnDepa.Enabled = True
        btnProv.Enabled = True
        btnDist.Enabled = True
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New ftitulares 'Creacion una variable para hacer referencia a la funcion fconcesiones
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
        dataListado.Columns(1).Width = 30
        dataListado.Columns(2).Width = 250
        dataListado.Columns(3).Width = 80
        dataListado.Columns(4).Width = 90
        dataListado.Columns(5).Width = 250
        dataListado.Columns(6).Width = 70
        dataListado.Columns(7).Width = 150
        dataListado.Columns(8).Width = 70
        dataListado.Columns(9).Width = 150
        dataListado.Columns(10).Width = 70
        dataListado.Columns(11).Width = 150
        dataListado.Columns(12).Width = 150
        dataListado.Columns(13).Width = 250
        dataListado.Columns(14).Width = 70
        dataListado.Columns(15).Width = 70
        dataListado.Columns(16).Width = 70

        'Centrando todas las columnas del DataGridView
        dataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'Cambiando el texto de las cabeceras
        dataListado.Columns(2).HeaderText = "Títular"
        dataListado.Columns(3).HeaderText = "No DNI"
        dataListado.Columns(4).HeaderText = "Ruc"
        dataListado.Columns(5).HeaderText = "Represetante legal"
        dataListado.Columns(6).HeaderText = "Id dpto"
        dataListado.Columns(7).HeaderText = "Departamento"
        dataListado.Columns(8).HeaderText = "Id prov"
        dataListado.Columns(9).HeaderText = "Provincia"
        dataListado.Columns(10).HeaderText = "Id_dist"
        dataListado.Columns(11).HeaderText = "Distrito"
        dataListado.Columns(12).HeaderText = "Sector"
        dataListado.Columns(13).HeaderText = "Dirección"
        dataListado.Columns(14).HeaderText = "Propietario"
        dataListado.Columns(15).HeaderText = "Destino"
        dataListado.Columns(16).HeaderText = "Transporte"


  

    End Sub

    Private Sub buscar()
        Try

            Dim ds As New DataSet 'Declaramos variable para tener una copiar del DataTable
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            'dv.RowFilter = "con_titular" & " Like " & txtBuscar.Text & "%" 'Filtramos la busqueda
            dv.RowFilter = String.Format("pro_titular Like '%{0}%'", txtBuscar.Text) 'Filtramos la busqueda
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

        End Try
    End Sub

    Private Sub ocultar_columnas()
        dataListado.Columns(1).Visible = False
        dataListado.Columns(6).Visible = False
        dataListado.Columns(8).Visible = False
        dataListado.Columns(10).Visible = False
        dataListado.Columns(14).Visible = False
        dataListado.Columns(15).Visible = False
        dataListado.Columns(16).Visible = False
    End Sub

    Private Sub limpiar()
        txtId.Text = ""
        txtTitular.Text = ""
        TxNoDni.Text = ""
        txtRuc.Text = ""
        TxNomRespLegal.Text = ""
        txtSector.Text = ""
        txtProvincia.Text = ""
        txtDepartamento.Text = ""
        txtDireccion.Text = ""
        txtDistrito.Text = ""
        dptoId = 0
        provId = 0
        DistId = 0
        chkPropietario.CheckState = CheckState.Unchecked
        chkDestino.CheckState = CheckState.Unchecked
        chkTransporte.CheckState = CheckState.Unchecked
    End Sub

    Private Sub txtTitular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTitular.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            siguientecontrol()
        End If
    End Sub
    Private Sub TXNODNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxNoDni.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            siguientecontrol()
        End If
    End Sub
    Private Sub siguientecontrol()
        SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtRuc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRuc.KeyPress

        ' "0123456789.-" Valores o caracteres que solo aceptara el TextBox
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
            siguientecontrol()
        End If
    End Sub
    Private Sub TxNomRespLegal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxNomRespLegal.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            siguientecontrol()
        End If
    End Sub
    Private Sub txtSector_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSector.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            siguientecontrol()
        End If
    End Sub
    Private Sub txtDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDireccion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            siguientecontrol()
        End If
    End Sub
    Private Sub btnGuardar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnGuardar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            siguientecontrol()
        End If
    End Sub
    Private Function validar_campos() As Boolean

        'Preguntamos si los controles estan vacios, para enviar el mensaje

        If String.IsNullOrEmpty(txtTitular.Text) = True Then
            MessageBox.Show("No ha ingresado el nombre o razón social de la empresa", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTitular.BackColor = Color.LightYellow
            txtTitular.Focus()
            'sw_guardar = False
            Return False

        End If


        If String.IsNullOrEmpty(TxNoDni.Text) = True Then
            If MessageBox.Show("No se ha ingresado en número de DNI, ¿Desea grabar el registro sin esta informacion?", xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                TxNoDni.BackColor = Color.LightYellow
                sw_guardar = False
                TxNoDni.Focus()
                Return False
            Else
                TxNoDni.Text = "S/N"
            End If
        End If

        If String.IsNullOrEmpty(txtRuc.Text) = True Then
            MessageBox.Show("No ha ingresado el número de RUC", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRuc.BackColor = Color.LightYellow
            'sw_guardar = False
            txtRuc.Focus()
            Return False

        End If


        If String.IsNullOrEmpty(TxNomRespLegal.Text) = True Then
            If MessageBox.Show("No se ha ingresado el nombre del representante legal, ¿Desea grabar el registro sin esta informacion?", xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                TxNomRespLegal.BackColor = Color.LightYellow
                sw_guardar = True
                TxNomRespLegal.Focus()
                Return False
            Else
                TxNomRespLegal.Text = "S/N"
            End If

        End If

        If String.IsNullOrEmpty(txtRuc.Text) = True Then
            MessageBox.Show("No ha ingresado el número de RUC", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRuc.BackColor = Color.LightYellow
            'sw_guardar = False
            txtRuc.Focus()
            Return False

        End If


        If String.IsNullOrEmpty(txtDepartamento.Text) = True Then
            MessageBox.Show("No ha ingresado el nombre del departamento", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDepartamento.BackColor = Color.LightYellow
            txtDepartamento.Focus()
            Return False
        End If
     

        If String.IsNullOrEmpty(txtProvincia.Text) = True Then
            MessageBox.Show("No ha ingresado el nombre de la Provincia", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtProvincia.BackColor = Color.LightYellow
            'sw_guardar = False
            txtProvincia.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtDistrito.Text) = True Then
            MessageBox.Show("No ha ingresado el nombre del Distrito", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDistrito.BackColor = Color.LightYellow
            'sw_guardar = False
            txtDistrito.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtSector.Text) = True Then
            If MessageBox.Show("No se ha ingresado el nombre del sector, ¿Desea grabar el registro sin esta informacion?", xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                txtSector.BackColor = Color.LightYellow
                'sw_guardar = False
                txtSector.Focus()
                Return False
            Else
                txtSector.Text = "S/N"
            End If

        End If

        If String.IsNullOrEmpty(txtDireccion.Text) = True Then
            MessageBox.Show("No ha ingresado la dirección", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDireccion.BackColor = Color.LightYellow
            'sw_guardar = False
            txtDireccion.Focus()
            Return False
 
        End If

        Return True

    End Function

    Private Sub dataListado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataListado.CellClick
        registro_seleccionado()
    End Sub

    Private Sub registro_seleccionado()
        If nreg = 0 Then
            Return
        End If
        txtId.Text = dataListado.SelectedCells.Item(1).Value
        txtTitular.Text = dataListado.SelectedCells.Item(2).Value
        TxNoDni.Text = dataListado.SelectedCells.Item(3).Value
        txtRuc.Text = dataListado.SelectedCells.Item(4).Value
        TxNomRespLegal.Text = dataListado.SelectedCells.Item(5).Value
        dptoId = dataListado.SelectedCells.Item(6).Value
        txtDepartamento.Text = dataListado.SelectedCells.Item(7).Value
        provId = dataListado.SelectedCells.Item(8).Value
        txtProvincia.Text = dataListado.SelectedCells.Item(9).Value
        DistId = dataListado.SelectedCells.Item(10).Value
        txtDistrito.Text = dataListado.SelectedCells.Item(11).Value
        txtSector.Text = dataListado.SelectedCells.Item(12).Value
        If IsDBNull(dataListado.SelectedCells.Item(13).Value) = False Then
            txtDireccion.Text = dataListado.SelectedCells.Item(13).Value
        Else
            txtDireccion.Text = "S/D"
        End If
        If IsDBNull(dataListado.SelectedCells.Item(14).Value) = False Then
            chkPropietario.CheckState = dataListado.SelectedCells.Item(14).Value
        Else
            chkPropietario.CheckState = CheckState.Unchecked
        End If
        If IsDBNull(dataListado.SelectedCells.Item(15).Value) = False Then
            chkDestino.CheckState = dataListado.SelectedCells.Item(15).Value
        Else
            chkPropietario.CheckState = CheckState.Unchecked
        End If
        If IsDBNull(dataListado.SelectedCells.Item(16).Value) = False Then
            chkTransporte.CheckState = dataListado.SelectedCells.Item(16).Value
        Else
            chkPropietario.CheckState = CheckState.Unchecked
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

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
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
        txtTitular.Focus()
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

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim result As DialogResult

        If validar_campos() = False Then
            Exit Sub
        Else
            sw_guardar = True
        End If

        If nuevo = True Then
            If New ftitulares().NomTitularExiste(txtTitular.Text) = True Then
                MessageBox.Show("El Nombre razón social que esta ingresando ya esta registrado", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtTitular.Focus()
                Exit Sub
            End If
            'Validamos que el Numero RUC no se repita(Solo en caso que el registro sea Nuevo)
            If New ftitulares().NumeroRucExiste(txtRuc.Text) = True Then
                MessageBox.Show("El numero R.U.C que esta ingresando ya existe registrado a otro titular", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtRuc.Focus()
                Exit Sub
            End If
        End If

        If sw_guardar = True Then 'Guardamos si los controles no estan vacios
            result = MessageBox.Show("Esta seguro de GUARDAR el registro ?", "Guardar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Try
                    Dim dts As New vTitulares
                    Dim func As New ftitulares

                    dts.gtitular = txtTitular.Text
                    dts.gdni = TxNoDni.Text
                    dts.gruc = txtRuc.Text
                    dts.grepresentante_legal = TxNomRespLegal.Text
                    dts.gdepartamento = dptoId
                    dts.gprovincia = provId
                    dts.gdistrito = DistId
                    dts.gsector = txtSector.Text
                    dts.gpropietariock = chkPropietario.CheckState
                    dts.gdestinock = chkDestino.CheckState
                    dts.gtransporteck = chkTransporte.CheckState
                    dts.gdireccion = txtDireccion.Text

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
                        dts.gproid = txtId.Text
                        If func.editar(dts) Then
                            MessageBox.Show("Datos editados correctamente...!", "Editando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            mostrar()
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
                        Else
                            MessageBox.Show("Datos No fueron editados, intente de nuevo!", "Editando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            mostrar()
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

    Private Sub chkEliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEliminar.CheckedChanged
        If chkEliminar.CheckState = CheckState.Checked Then
            dataListado.Columns.Item("Eliminar").Visible = True
            dataListado.Columns.Item("Eliminar").Width = 20
            dataListado.Columns.Item("Eliminar").HeaderText = ""
        Else
            dataListado.Columns.Item("Eliminar").Visible = False
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

                        Dim onekey As Integer = Convert.ToInt32(row.Cells("pro_id").Value)
                        If New ftitulares().TitularEnListaTrozasc(onekey) = True Then
                            MessageBox.Show("Imposible borrar este titular, ya que tiene asignados GTF", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Continue For
                        End If
                        Dim vdb As New vTitulares
                        Dim func As New ftitulares

                        vdb.gproid = onekey
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
        txtTitular.Focus()
    End Sub

    Private Sub dataListado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataListado.CellDoubleClick
        registro_seleccionado()
        tcDatos.SelectedIndex = 1
    End Sub

    Private Sub txtRuc_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRuc.Validating
        If txtRuc.Text <> "" Then
            If txtRuc.Text.Length <> 11 Then
                MessageBox.Show("Debe ingresar 11 Digitos para el RUC", "Mensaje")
            End If
        End If
    End Sub

    Private Sub btnDeffs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepa.Click
        'Enviamos los datos de la consulta sql

        frmdep.titulo = "Seleccione Departamento"
        frmdep.t_tabla = "ubdepartamento"
        frmdep.t_campos = "iddepa,departamento"
        frmdep.t_donde = ""
        frmdep.t_agruparpor = ""
        frmdep.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Departamento"}
        Dim anchos() As Integer = {50, 200}

        ReDim frmdep.matAnchos(anchos.Length)
        ReDim frmdep.matTitulos(titulos.Length)
        ReDim frmdep.matColumnas(titulos.Length)
        titulos.CopyTo(frmdep.matTitulos, 0)
        anchos.CopyTo(frmdep.matAnchos, 0)

        frmdep.ShowDialog(Me)

        'Datos del Departamento
        If frmdep.flag = True Then
            dptoId = frmdep.matColumnas(0)
            txtDepartamento.Text = frmdep.matColumnas(1)
        End If
    End Sub

    Private Sub btnProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProv.Click
        'Enviamos los datos de la consulta sql
        If dptoId <> 0 Then
            frmprov.titulo = "Seleccione Provincia"
            frmprov.t_tabla = "ubprovincia"
            frmprov.t_campos = "idprov,provincia,iddepa"
            frmprov.t_donde = String.Format("iddepa={0}", dptoId)
            frmprov.t_agruparpor = ""
            frmprov.t_ordenarpor = ""

            'Enviamos los formatosy tiulos de las columnas en un Array
            Dim titulos() As String = {"Id", "Provincia", "IdProv"}
            Dim anchos() As Integer = {50, 200}

            ReDim frmprov.matAnchos(anchos.Length)
            ReDim frmprov.matTitulos(titulos.Length)
            ReDim frmprov.matColumnas(titulos.Length)
            titulos.CopyTo(frmprov.matTitulos, 0)
            anchos.CopyTo(frmprov.matAnchos, 0)

            frmprov.ShowDialog(Me)

            'Datos del Titular
            If frmprov.flag = True Then
                provId = frmprov.matColumnas(0)
                txtProvincia.Text = frmprov.matColumnas(1)
            End If
        Else
            MessageBox.Show("Lo siento debe ingresar el Departamento", "Mensaje")
        End If
    End Sub

    Private Sub btnDist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDist.Click

        If provId <> 0 Then
            frmdist.titulo = "Seleccione Provincia"
            frmdist.t_tabla = "ubdistrito"
            frmdist.t_campos = "iddist,distrito,idprov"
            frmdist.t_donde = String.Format("idprov={0}", provId)
            frmdist.t_agruparpor = ""
            frmdist.t_ordenarpor = ""

            'Enviamos los formatosy tiulos de las columnas en un Array
            Dim titulos() As String = {"Id", "Provincia", "IdProv"}
            Dim anchos() As Integer = {50, 200}

            ReDim frmdist.matAnchos(anchos.Length)
            ReDim frmdist.matTitulos(titulos.Length)
            ReDim frmdist.matColumnas(titulos.Length)
            titulos.CopyTo(frmdist.matTitulos, 0)
            anchos.CopyTo(frmdist.matAnchos, 0)

            frmdist.ShowDialog(Me)

            'Datos del Titular
            If frmdist.flag = True Then
                DistId = frmdist.matColumnas(0)
                txtDistrito.Text = frmdist.matColumnas(1)
            End If
        Else
            MessageBox.Show("Lo siento debe ingresar la Provincia", "Mensaje")
        End If
    End Sub

  
End Class