Public Class frmConductores
    Private dt As New DataTable
    Dim func As New fconductores 'Creacion una variable para hacer referencia a la funcion fconcesiones
    Dim nreg, xreg As Integer
    Dim sw_guardar As Boolean = False
    Dim nuevo As Boolean = False
    Dim modificar As Boolean = False
    Dim msg As String = ""
    Dim frm As New frmShowbrow

    Dim xTitulo = fxSamad.Titulo

    Private Sub registro_seleccionado()
        If nreg = 0 Then
            Return
        End If
        txtId.Text = dataListado.SelectedCells.Item(1).Value
        txtNombre.Text = dataListado.SelectedCells.Item(2).Value
        txtnrolicencia.Text = dataListado.SelectedCells.Item(3).Value
        txtDni.Text = dataListado.SelectedCells.Item(4).Value
        txtemtrazon.Text = dataListado.SelectedCells.Item(5).Value
        txtemtid.Text = dataListado.SelectedCells.Item(6).Value
    End Sub

    Private Sub deshabilitar()
        txtId.Enabled = False
        txtNombre.Enabled = False
        txtnrolicencia.Enabled = False
        txtDni.Enabled = False
        txtemtrazon.Enabled = False
        txtemtid.Enabled = False
        btnEmpresa.Enabled = False
    End Sub

    Private Sub habiltar()
        txtId.Enabled = False
        txtNombre.Enabled = True
        txtnrolicencia.Enabled = True
        txtDni.Enabled = True
        txtemtrazon.Enabled = False
        txtemtid.Enabled = False
        btnEmpresa.Enabled = True
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fconductores 'Creacion una variable para hacer referencia a la funcion fconcesiones
            dt = func.mostrar 'Invocamos a la funcion mostrar()
            dataListado.Columns.Item("Eliminar").Visible = False 'Ocultamos la Columna Eliminar

            nreg = dt.Rows.Count 'Almacenamos la cantidad de filas o registros recuperados
            If nreg <> 0 Then 'Si las filas al contarlas es diferente de cero
                dataListado.DataSource = dt
                txtBuscar.Enabled = True
                dataListado.ColumnHeadersVisible = True
                lblinexistente.Visible = False
            Else
                dataListado.DataSource = Nothing
                txtBuscar.Enabled = False
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
        dataListado.Columns(3).Width = 100
        dataListado.Columns(4).Width = 60
        dataListado.Columns(5).Width = 220
        dataListado.Columns(6).Width = 180
        'Centrando todas las columnas del DataGridView
        dataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'Cambiando el texto de las cabeceras
        dataListado.Columns(1).HeaderText = "Id"
        dataListado.Columns(2).HeaderText = "Nombres y Apellidos"
        dataListado.Columns(3).HeaderText = "Nro. Licencia"
        dataListado.Columns(4).HeaderText = "Dni"
        dataListado.Columns(5).HeaderText = "Empresa Id"
        dataListado.Columns(6).HeaderText = "Empresa Transp."

    End Sub

    Private Sub buscar()
        Try

            Dim ds As New DataSet 'Declaramos variable para tener una copiar del DataTable
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = String.Format("con_nomape Like '%{0}%'", txtBuscar.Text) 'Filtramos la busqueda
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

    Private Sub chkEliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEliminar.CheckedChanged
        If chkEliminar.CheckState = CheckState.Checked Then
            dataListado.Columns.Item("Eliminar").Visible = True
            dataListado.Columns.Item("Eliminar").Width = 20
            dataListado.Columns.Item("Eliminar").HeaderText = ""
        Else
            dataListado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub limpiar()
        txtId.Text = ""
        txtNombre.Text = ""
        txtnrolicencia.Text = ""
        txtDni.Text = ""
        txtemtrazon.Text = ""
        txtemtid.Text = ""
    End Sub

    Private Sub validar_campos()

        'Preguntamos si los controles estan vacios, para enviar el mensaje
        If txtNombre.Text <> "" Then
            If txtnrolicencia.Text <> "" Then
                If txtemtid.Text <> "" Then
                    sw_guardar = True
                    msg = "Los datos de guardaron con exito...!!!"
                Else
                    sw_guardar = False
                    msg = "Debe ingresar la EMPRESA DE TRANSPORTE"
                End If
            Else
                If txtemtid.Text <> "" Then
                    sw_guardar = False
                    msg = "Debe ingresar el NRO.LICENCIA"
                Else
                    sw_guardar = False
                    msg = "Debe ingresar el NRO.LICENCIA y la EMPRESA DE TRANSPORTE"
                End If
            End If
        Else

            If txtnrolicencia.Text <> "" Then
                If txtemtid.Text <> "" Then
                    sw_guardar = False
                    msg = "Debe ingresar el NOMBRE y APELLIDO"
                Else
                    sw_guardar = False
                    msg = "Debe ingresar el NOMBRE y APELLIDO y la EMPRESA DE TRANSPORTE"
                End If
            Else
                If txtemtid.Text <> "" Then
                    sw_guardar = False
                    msg = "Debe ingresar el NOMBRE y APELLIDO y el NRO.LICENCIA"
                Else
                    sw_guardar = False
                    msg = "Debe ingresar todos los datos...!!"
                End If
            End If
        End If
    End Sub

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
        txtNombre.Focus()
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
        txtNombre.Focus()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim result As DialogResult
        validar_campos()

        If sw_guardar = True Then 'Guardamos si los controles no estan vacios
            result = MessageBox.Show("Esta seguro de GUARDAR el registro ?", "Guardar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Try
                    Dim dts As New vConductores
                    Dim func As New fconductores

                    dts.gconnomape = txtNombre.Text
                    dts.gconnrolicencia = txtnrolicencia.Text
                    dts.gcondni = txtDni.Text
                    dts.gconemtid = txtemtid.Text

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
                        dts.gconid = txtId.Text
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
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub

    Private Sub AplicarPerfil()
        If vInfraestructura.Usuario.gtipo = "ADMINISTRADOR" Then

        Else
            Panel2.Enabled = False
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
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("con_id").Value)
                        If New fconductores().ConductorListaTrozasc(onekey) = True Then
                            MessageBox.Show("Imposible Eliminar este Registro conducto, ya que tiene GTF asignados", xtitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Continue For
                        End If
                        Dim vdb As New vConductores
                        Dim func As New fconductores
                        vdb.gconid = onekey
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

    Private Sub btnEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpresa.Click

        frm.titulo = "Listado de Empresas de Transporte"
        'Enviamos los datos de la consulta sql
        frm.t_tabla = "titulares"
        frm.t_campos = "pro_id,pro_titular"
        frm.t_donde = "Pro_Transporteck =  true"
        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Razon Social"}
        Dim anchos() As Integer = {30, 250}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)

        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog(Me)

        If frm.flag = True Then
            txtemtid.Text = frm.matColumnas(0)
            txtemtrazon.Text = frm.matColumnas(1)
        End If
    End Sub

    Private Sub frmConductores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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