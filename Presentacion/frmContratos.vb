Public Class frmContratos
    Private dt As New DataTable
    Dim func As New fcontratos 'Creacion una variable para hacer referencia a la funcion fconcesiones
    Dim nreg, xreg As Integer
    Dim sw_guardar As Boolean = False
    Dim nuevo As Boolean = False
    Dim modificar As Boolean = False
    Dim msg As String = ""
    Dim frm, frmp As New frmShowbrow

    Dim xTitulo = fxSamad.Titulo

    Private Sub deshabilitar()
        txtId.Enabled = False
        txtDescripcion.Enabled = False
        CbRecurso.Enabled = False
        txtAnno.Enabled = False
        btnEmpresa.Enabled = False
    End Sub

    Private Sub habiltar()
        txtId.Enabled = False
        txtDescripcion.Enabled = True
        CbRecurso.Enabled = True
        txtAnno.Enabled = True
        btnEmpresa.Enabled = True
    End Sub

    Private Sub mostrar()
        Try
            'Dim func As New fcontratos 'Creacion una variable para hacer referencia a la funcion fconcesiones
            'dt = func.mostrar 'Invocamos a la funcion mostrar()
            Dim dt = New fcontratos().mostrar()            
            dataListado.Columns.Item("Eliminar").Visible = False 'Ocultamos la Columna Eliminar
            nreg = dt.Rows.Count 'Almacenamos la cantidad de filas o registros recuperados
            If nreg > 0 Then 'Si las filas al contarlas es diferente de cero
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
        ' buscar()
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
        dataListado.Columns(2).Width = 150
        dataListado.Columns(3).Width = 150
        dataListado.Columns(4).Width = 40
        dataListado.Columns(5).Width = 40
        dataListado.Columns(6).Width = 220

        'Centrando todas las columnas del DataGridView
        dataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'Cambiando el texto de las cabeceras
        dataListado.Columns(1).HeaderText = "Id"
        dataListado.Columns(2).HeaderText = "Permiso"
        dataListado.Columns(3).HeaderText = "Org. Recurso"
        dataListado.Columns(4).HeaderText = "Año"
        dataListado.Columns(5).HeaderText = "Titular Id"
        dataListado.Columns(6).HeaderText = "Titular"


    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet 'Declaramos variable para tener una copiar del DataTable
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            dv.RowFilter = String.Format("con_descripcion Like '%{0}%'", txtBuscar.Text) 'Filtramos la busqueda

            If dv.Count > 0 Then
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

    Private Sub AplicarPerfil()
        If vInfraestructura.Usuario.gtipo = "ADMINISTRADOR" Then

        Else
            Panel2.Enabled = False
        End If
    End Sub

    Private Sub ocultar_columnas()
        dataListado.Columns(1).Visible = False
        dataListado.Columns(5).Visible = False
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
        txtDescripcion.Focus()
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        buscar()
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
        txtDescripcion.Focus()
    End Sub

    Private Sub limpiar()
        txtId.Text = ""
        txtDescripcion.Text = ""
        CbRecurso.Text = ""
        txtAnno.Text = ""
        txtProid.Text = ""
        txtTitular.Text = ""
    End Sub

    Private Function validar_campos() As Boolean
        'Preguntamos si los controles estan vacios, para enviar el mensaje

        If String.IsNullOrEmpty(txtDescripcion.Text) = True Then
            MessageBox.Show("No a Ingresado el número de contrato forestal", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescripcion.BackColor = Color.LightYellow
            txtDescripcion.Focus()
            Return False

        End If

        If String.IsNullOrEmpty(CbRecurso.Text) = True Then
            MessageBox.Show("Debe ingresar el origen del recurso", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CbRecurso.BackColor = Color.LightYellow
            CbRecurso.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtAnno.Text) = True Then
            MessageBox.Show("Debe ingresar año del contrato", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAnno.BackColor = Color.LightYellow
            txtAnno.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtTitular.Text) = True Then
            MessageBox.Show("Debe ingresar nombre del titular del titulo habilitante", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTitular.BackColor = Color.LightYellow
            txtTitular.Focus()
            Return False
        End If
        Return True

    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim result As DialogResult

        If validar_campos() = False Then
            Exit Sub
        Else
            sw_guardar = True
        End If

        If nuevo = True Then
            If New fcontratos().NumeroContratoExiste(txtDescripcion.Text) = True Then
                MessageBox.Show("El Numero de contrato Forestal que ha ingresado, ya fue registrado a nombre de otro titulor", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtDescripcion.Focus()
                Exit Sub
            End If
        End If
        If sw_guardar = True Then 'Guardamos si los controles no estan vacios
            result = MessageBox.Show("Esta seguro de GUARDAR el registro ?", "Guardar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Try
                    Dim dts As New vContratos
                    Dim func As New fcontratos
                    dts.gcondescripcion = txtDescripcion.Text
                    dts.gconrecurso = CbRecurso.Text
                    dts.gconanno = txtAnno.Text
                    dts.gconproid = txtProid.Text
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

        tcDatos.SelectedIndex = 0
        tpDatos.Parent = Nothing
        tpLista.Parent = tcDatos
        tpDatos.Parent = tcDatos
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
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
                        Dim vdb As New vContratos
                        Dim func As New fcontratos

                        vdb.gconid = onekey
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
        'Datos para la consulta sql
        frm.t_tabla = "titulares"
        frm.t_campos = "pro_id,pro_titular,pro_departamento"
        frm.t_donde = ""
        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Títular", "Dpto"}
        Dim anchos() As Integer = {30, 350, 60}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)

        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        'frm.MdiParent = frmPrincipal
        frm.ShowDialog(Me)

        If frm.flag = True Then
            txtProid.Text = frm.matColumnas(0)
            txtTitular.Text = frm.matColumnas(1)
        End If

    End Sub

    Private Sub frmContratos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        deshabilitar()
        mostrar()
        formatear_grid()
        dataListado.Focus()
        registro_seleccionado()
        AplicarPerfil()
    End Sub

    Private Sub registro_seleccionado()
        If nreg = 0 Then
            Return
        End If
        txtId.Text = dataListado.SelectedCells.Item(1).Value
        txtDescripcion.Text = dataListado.SelectedCells.Item(2).Value
        CbRecurso.Text = dataListado.SelectedCells.Item(3).Value
        txtAnno.Text = dataListado.SelectedCells.Item(4).Value
        txtProid.Text = dataListado.SelectedCells.Item(5).Value
        txtTitular.Text = dataListado.SelectedCells.Item(6).Value

       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Datos para la consulta sql
        frm.t_tabla = "zafrasypoas"
        frm.t_campos = "zyp_zafra,zyp_poa"
        frm.t_donde = String.Format("zyp_permiso_id = {0}", txtId.Text)
        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Zafra", "Poa"}
        Dim anchos() As Integer = {100, 100}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)
        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog()
    End Sub

    Private Sub dataListado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataListado.CellDoubleClick
        registro_seleccionado()
        tcDatos.SelectedIndex = 1
    End Sub

   
End Class