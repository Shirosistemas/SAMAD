Public Class frmOrigenes

    Private dt As New DataTable
    Dim func As New forigenes 'Creacion una variable para hacer referencia a la funcion fconcesiones
    Dim nreg, xreg As Integer
    Dim sw_guardar As Boolean = False
    Dim nuevo As Boolean = False
    Dim modificar As Boolean = False
    Dim msg As String = ""
    Private Sub AplicarPerfil()
        If vInfraestructura.Usuario.gtipo = "ADMINISTRADOR" Then

        Else

            Panel2.Enabled = False
        End If
    End Sub
    Private Sub deshabilitar()
        txtId.Enabled = False
        txtLugar.Enabled = False
        txtDepartamento.Enabled = False
        txtProvincia.Enabled = False
        txtDistrito.Enabled = False
    End Sub
    Private Sub habiltar()
        txtId.Enabled = False
        txtLugar.Enabled = True
        txtDepartamento.Enabled = True
        txtProvincia.Enabled = True
        txtDistrito.Enabled = True
    End Sub
    Private Sub mostrar()
        Try
            Dim func As New forigenes 'Creacion una variable para hacer referencia a la funcion fconcesiones
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

        'Quitando lo necesario
        dataListado.AllowUserToResizeRows = False
        dataListado.RowHeadersVisible = False

        'Modificando el ancho de las columnas
        dataListado.Columns(1).Width = 30
        dataListado.Columns(2).Width = 180
        dataListado.Columns(3).Width = 100
        dataListado.Columns(4).Width = 80
        dataListado.Columns(5).Width = 100

        'Centrando todas las columnas del DataGridView
        dataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'Cambiando el texto de las cabeceras
        dataListado.Columns(2).HeaderText = "Lugar"
        dataListado.Columns(3).HeaderText = "Dpto"
        dataListado.Columns(4).HeaderText = "Provincia"
        dataListado.Columns(5).HeaderText = "Distrito"

    End Sub
    Private Sub buscar()
        Try

            Dim ds As New DataSet 'Declaramos variable para tener una copiar del DataTable
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            'dv.RowFilter = "con_titular" & " Like " & txtBuscar.Text & "%" 'Filtramos la busqueda
            dv.RowFilter = String.Format("ori_lugar Like '%{0}%'", txtBuscar.Text) 'Filtramos la busqueda
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
        dataListado.Columns(4).Visible = False
    End Sub
    Private Sub limpiar()
        txtId.Text = ""
        txtLugar.Text = ""
        txtProvincia.Text = ""
        txtDepartamento.Text = ""
        txtDistrito.Text = ""
    End Sub
    Private Sub siguientecontrol()
        SendKeys.Send("{TAB}")
    End Sub
    Private Sub validar_campos()

        'Preguntamos si los controles estan vacios, para enviar el mensaje
        If txtLugar.Text <> "" Then
            If txtDepartamento.Text <> "" Then
                If txtProvincia.Text <> "" Then
                    If txtDistrito.Text <> "" Then
                        sw_guardar = True
                        msg = "Datos guardados con exito...!!"
                    Else
                        sw_guardar = False
                        msg = "Debe ingresar el DISTRITO"
                    End If
                Else
                    If txtDistrito.Text <> "" Then
                        sw_guardar = False
                        msg = "Debe ingresar la PROVINCIA"
                    Else
                        sw_guardar = False
                        msg = "Debe ingresar la PROVINCIA y el DISTRITO"
                    End If
                End If
            Else
                If txtProvincia.Text <> "" Then
                    If txtDistrito.Text <> "" Then
                        sw_guardar = False
                        msg = "Debe ingresar el DEPARTAMENTO"
                    Else
                        sw_guardar = False
                        msg = "Debe ingresar el DEPARTAMENTO y el DISTRITO"
                    End If
                Else
                    If txtDistrito.Text <> "" Then
                        sw_guardar = False
                        msg = "Debe ingresar el DEPARTAMENTO y la PROVINCIA"
                    Else
                        sw_guardar = False
                        msg = "Debe ingresar el DEPARTAMENTO, la PROVINCIA y el DISTRITO"
                    End If
                End If
            End If
        Else
            If txtDepartamento.Text <> "" Then
                If txtProvincia.Text <> "" Then
                    If txtDistrito.Text <> "" Then
                        sw_guardar = False
                        msg = "Debe ingresar el LUGAR"
                    Else
                        sw_guardar = False
                        msg = "Debe ingresar el LUGAR y el DISTRITO"
                    End If
                Else
                    If txtDistrito.Text <> "" Then
                        sw_guardar = False
                        msg = "Debe ingresar el LUGAR y la PROVINCIA"
                    Else
                        sw_guardar = False
                        msg = "Debe ingresar el LUGAR, la PROVINCIA y el DISTRITO"
                    End If
                End If
            Else
                If txtProvincia.Text <> "" Then
                    If txtDistrito.Text <> "" Then
                        sw_guardar = False
                        msg = "Debe ingresar el LUGAR y el DEPARTAMENTO"
                    Else
                        sw_guardar = False
                        msg = "Debe ingresar el LUGAR, el DEPARTAMENTO y el DISTRITO"
                    End If
                Else
                    If txtDistrito.Text <> "" Then
                        sw_guardar = False
                        msg = "Debe ingresar el LUGAR, el DEPARTAMENTO y la PROVINCIA"
                    Else
                        sw_guardar = False
                        msg = "Debe ingresar todos los datos...!!!"
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub dataListado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataListado.CellClick
        registro_seleccionado()
    End Sub
    Private Sub registro_seleccionado()
        txtId.Text = dataListado.SelectedCells.Item(1).Value
        txtLugar.Text = dataListado.SelectedCells.Item(2).Value
        txtDepartamento.Text = dataListado.SelectedCells.Item(3).Value
        txtProvincia.Text = dataListado.SelectedCells.Item(4).Value
        txtDistrito.Text = dataListado.SelectedCells.Item(5).Value
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
        txtLugar.Focus()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        deshabilitar()
        registro_seleccionado()
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = True
        btnSalir.Enabled = True
        tcDatos.SelectedIndex = 0
        tpDatos.Parent = Nothing
        tpLista.Parent = tcDatos
        tpDatos.Parent = tcDatos
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim result As DialogResult
        validar_campos()

        If sw_guardar = True Then 'Guardamos si los controles no estan vacios
            result = MessageBox.Show("Esta seguro de GUARDAR el registro ?", "Guardar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Try
                    Dim dts As New vOrigenes
                    Dim func As New forigenes

                    dts.glugar = txtLugar.Text
                    dts.gdepartamento = txtDepartamento.Text
                    dts.gprovincia = txtProvincia.Text
                    dts.gdistrito = txtDistrito.Text

                    'Codigo para insertar registros
                    If nuevo = True Then
                        If func.insertar(dts) Then
                            MessageBox.Show("Datos guardados correctamente...!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                            MessageBox.Show("Datos No fueron registrados, intente de nuevo!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            mostrar()
                            limpiar()
                        End If
                    End If

                    'Codigo para editar registros
                    If modificar = True Then
                        dts.goriid = txtId.Text
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

                        Dim onekey As Integer = Convert.ToInt32(row.Cells("ori_id").Value)
                        Dim vdb As New vOrigenes
                        Dim func As New forigenes

                        vdb.goriid = onekey
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
        txtLugar.Focus()
    End Sub

    Private Sub frmOrigenes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        deshabilitar()
        mostrar()
        formatear_grid()
        dataListado.Focus()
        registro_seleccionado()
        AplicarPerfil()

    End Sub

    Private Sub dataListado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataListado.CellDoubleClick
        registro_seleccionado()
        tcDatos.SelectedIndex = 1
    End Sub
End Class