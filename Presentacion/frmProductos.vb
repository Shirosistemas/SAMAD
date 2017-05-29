Public Class frmProductos

    'Private dt As New DataTable
    'Dim func As New fproductos 'Creacion una variable para hacer referencia a la funcion fconcesiones
    Dim dt As List(Of productos)
    Dim nreg, xreg As Integer
    Dim sw_guardar As Boolean = False
    Dim nuevo As Boolean = False
    Dim modificar As Boolean = False
    Dim msg As String = ""
    Dim idclasecomer As Integer
    Private Sub AplicarPerfil()
        If vInfraestructura.Usuario.gtipo = "ADMINISTRADOR" Then

        Else

            Panel2.Enabled = False
        End If
    End Sub
    Private Sub registro_seleccionado()

        If nreg > 0 Then

            txtId.Text = dataListado.SelectedCells.Item(1).Value
            cbTipoProducto.Text = dataListado.SelectedCells.Item(2).Value
            txtDescrip.Text = dataListado.SelectedCells.Item(3).Value
            cmbClaseComercial.SelectedItem = dataListado.SelectedCells.Item(5).Value
            txtRendimiento.Text = dataListado.SelectedCells.Item(6).Value
            cbUnidMedAb.SelectedItem = dataListado.SelectedCells.Item(7).Value
            cbUnidMedL.SelectedItem = dataListado.SelectedCells.Item(8).Value

            txtEspesorDesde.Text = dataListado.SelectedCells.Item(9).Value
            cbOperadorE.Text = dataListado.SelectedCells.Item(10).Value
            txtAnchoDesde.Text = dataListado.SelectedCells.Item(11).Value
            cbOperadorA.Text = dataListado.SelectedCells.Item(12).Value
            txtLargoDesde.Text = dataListado.SelectedCells.Item(13).Value
            cbOperadorL.Text = dataListado.SelectedCells.Item(14).Value

            lineaprodCB.SelectedItem = dataListado.SelectedCells.Item(15).Value
            txtSisCubicacion.Text = dataListado.SelectedCells.Item(16).Value
            txtSimboloCubi.Text = dataListado.SelectedCells.Item(17).Value

            mostrar_tipoproducto()

        End If

    End Sub
    Private Sub deshabilitar()

        txtId.Enabled = False
        txtDescrip.Enabled = False
        txtEspesorDesde.Enabled = False
        cbOperadorE.Enabled = False
        txtAnchoDesde.Enabled = False
        cbOperadorA.Enabled = False
        txtLargoDesde.Enabled = False
        cbOperadorL.Enabled = False
        cmbClaseComercial.Enabled = False
        cbTipoProducto.Enabled = False
        TxFacEsp.Enabled = False

    End Sub
    Private Sub habiltar()

        txtId.Enabled = False
        txtDescrip.Enabled = True
        txtEspesorDesde.Enabled = True
        cbOperadorE.Enabled = True
        txtAnchoDesde.Enabled = True
        cbOperadorA.Enabled = True
        txtLargoDesde.Enabled = True
        cbOperadorL.Enabled = True
        cmbClaseComercial.Enabled = True
        cbTipoProducto.Enabled = True
        
    End Sub
    Private Sub mostrar()
        Try
            'Dim func As New fproductos 'Creacion una variable para hacer referencia a la funcion fconcesiones
            'dt = func.mostrar 'Invocamos a la funcion mostrar()
            Dim db As New samadEntities
            dt = db.productos.ToList()
            dataListado.Columns.Item("Eliminar").Visible = False 'Ocultamos la Columna Eliminar

            nreg = dt.Count 'Almacenamos la cantidad de filas o registros recuperados
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
            MsgBox("Mensaje : Procedimiento Mostrar()" + ex.Message)
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
        dataListado.Columns.Item(1).Width = 20
        dataListado.Columns.Item(2).Width = 60
        dataListado.Columns.Item(3).Width = 260
        dataListado.Columns.Item(4).Width = 60
        dataListado.Columns.Item(5).Width = 260
        dataListado.Columns.Item(6).Width = 70
        dataListado.Columns.Item(7).Width = 70
        dataListado.Columns.Item(8).Width = 70
        dataListado.Columns.Item(9).Width = 70
        dataListado.Columns.Item(10).Width = 70
        dataListado.Columns.Item(11).Width = 70
        dataListado.Columns.Item(12).Width = 70
        dataListado.Columns.Item(13).Width = 70
        dataListado.Columns.Item(14).Width = 70
        dataListado.Columns.Item(15).Width = 60
        dataListado.Columns.Item(16).Width = 60
        dataListado.Columns.Item(17).Width = 60
        dataListado.Columns.Item(18).Width = 60


        dataListado.Columns(4).Visible = False
        'Centrando todas las columnas del DataGridView

        dataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dataListado.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dataListado.Columns.Item(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dataListado.Columns.Item(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dataListado.Columns.Item(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dataListado.Columns.Item(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dataListado.Columns.Item(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dataListado.Columns.Item(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dataListado.Columns.Item(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dataListado.Columns.Item(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dataListado.Columns.Item(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dataListado.Columns.Item(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dataListado.Columns.Item(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dataListado.Columns.Item(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dataListado.Columns.Item(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        'Cambiando el texto de las cabeceras
        dataListado.Columns(1).HeaderText = "Id"
        dataListado.Columns(2).HeaderText = "Tipo Producto"
        dataListado.Columns(3).HeaderText = "Descrip. Producto"
        dataListado.Columns(5).HeaderText = "Clasificacio"
        dataListado.Columns(6).HeaderText = "Rend. %"
        dataListado.Columns(7).HeaderText = "Unid. Medida Ab"
        dataListado.Columns(8).HeaderText = "Unid. Medida L"
        dataListado.Columns(9).HeaderText = "Espesor"
        dataListado.Columns(10).HeaderText = "operador E"
        dataListado.Columns(11).HeaderText = "Ancho"
        dataListado.Columns(12).HeaderText = "Operador A"
        dataListado.Columns(13).HeaderText = "largo"
        dataListado.Columns(14).HeaderText = "Operador L"
        dataListado.Columns(15).HeaderText = "Funcion de Calculo"
        dataListado.Columns(16).HeaderText = "Sistema de Calculo"
        dataListado.Columns(17).HeaderText = "Simbolo"
        dataListado.Columns(18).HeaderText = "Fac. Esp."

        'Centrando todos los Encabezados de las columnas del DataGridView
        dataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        ocultar_columnas()

    End Sub
    Private Sub buscar()
        Try

            'Dim ds As New DataSet 'Declaramos variable para tener una copiar del DataTable
            'ds.Tables.Add(dt.Copy)
            'Dim dv As New DataView(ds.Tables(0))
            ' dv.RowFilter = String.Format("prod_descrip Like '%{0}%'", txtBuscar.Text) 'Filtramos la busqueda
            Dim db As New samadEntities

            If dt.Count <> 0 Then
                lblinexistente.Visible = False
                dataListado.DataSource = db.productos.Where(Function(p) p.Prod_NomProducto.Contains(txtBuscar.Text)).ToList()
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
        Try
            'dataListado.Columns(1).Visible = False
            dataListado.Columns.Item("Eliminar").Visible = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        modificar = True
        nuevo = False
        tcDatos.SelectedIndex = 1
        tpLista.Parent = Nothing
        sw_guardar = False
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnEliminar.Enabled = False
        btnSalir.Enabled = False
        habiltar()
        txtDescrip.Focus()
        CargarClaseComercial()
        CargarTipoCubicacion()
        CargarUnidadMedAb()
        CargarUnidadMedL()


    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        buscar()
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
        txtDescrip.Focus()
        CargarClaseComercial()
        CargarUnidadMedAb()
        CargarUnidadMedL()
        CargarTipoCubicacion()
    End Sub
    Private Sub limpiar()
        txtId.Text = ""
        txtDescrip.Text = ""
        txtEspesorDesde.Text = ""
        txtAnchoDesde.Text = ""
        txtLargoDesde.Text = ""
        cbTipoProducto.Text = ""
        cbTipoProducto.SelectedIndex = 0
    End Sub
    Private Sub validar_campos()

        'Preguntamos si los controles estan vacios, para enviar el mensaje
        If txtDescrip.Text <> "" Then
            sw_guardar = True
            msg = "Datos guardados con exito...!"
        Else
            sw_guardar = False
            msg = "Debe Ingresar la DESCRIPCION"
        End If

    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim result As DialogResult
        validar_campos()
        Dim db As New samadEntities
        If sw_guardar = True Then 'Guardamos si los controles no estan vacios
            result = MessageBox.Show("Esta seguro de GUARDAR el registro ?", "Guardar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Try
                   
                    If nuevo = True Then
                        Try
                            Dim pr As New productos
                            pr.Prod_TipoProducto = cbTipoProducto.Text
                            pr.Prod_NomProducto = txtDescrip.Text
                            pr.Prod_ClasificacionId = idclasecomer
                            pr.Prod_ClasificacionCom = cmbClaseComercial.Text
                            pr.Prod_Rendimiento = txtRendimiento.Text
                            pr.Prod_UnidadMedidaAb = cbUnidMedAb.Text
                            pr.Prod_UnidadMedidaL = cbUnidMedL.Text

                            pr.Prod_Espesor = CDbl(IIf(txtEspesorDesde.Text = "", 0, txtEspesorDesde.Text))

                            If cbOperadorE.Text <> "" Then
                                pr.Prod_OperadorE = cbOperadorE.Text
                            End If

                            pr.Prod_Ancho = CDbl(IIf(txtAnchoDesde.Text = "", 0, txtAnchoDesde.Text))

                            If cbOperadorA.Text <> "" Then
                                pr.Prod_OperadorA = cbOperadorA.Text
                            End If

                            pr.Prod_Largo = CDbl(IIf(txtLargoDesde.Text = "", 0, txtLargoDesde.Text))

                            If cbOperadorL.Text <> "" Then
                                pr.Prod_OperadorL = cbOperadorL.Text
                            End If

                            pr.Prod_FuncionCalculo = lineaprodCB.Text
                            pr.Prod_SistemaCalculo = txtSisCubicacion.Text
                            pr.Prod_Simbolo = txtSimboloCubi.Text
                            pr.Prod_Fe = TxFacEsp.Text
                            'Codigo para insertar registros
                            db.productos.AddObject(pr)
                            db.SaveChanges()
                            fauditoria.insertar("Productos", "Insertar", pr.Prod_Id, "")
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
                        Catch ex As Exception
                            MessageBox.Show("Datos No fueron registrados, intente de nuevo!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            mostrar()
                            limpiar()
                        End Try
                    End If

                    'Codigo para editar registros
                    If modificar = True Then
                        Try
                            Dim m As productos = db.productos.FirstOrDefault(Function(p) p.Prod_Id = txtId.Text)
                            m.Prod_TipoProducto = cbTipoProducto.Text
                            m.Prod_NomProducto = txtDescrip.Text
                            m.Prod_ClasificacionId = idclasecomer
                            m.Prod_ClasificacionCom = cmbClaseComercial.Text
                            m.Prod_Rendimiento = txtRendimiento.Text
                            m.Prod_UnidadMedidaAb = cbUnidMedAb.Text
                            m.Prod_UnidadMedidaL = cbUnidMedL.Text

                            m.Prod_Espesor = CDbl(IIf(txtEspesorDesde.Text = "", 0, txtEspesorDesde.Text))

                            If cbOperadorE.Text <> "" Then
                                m.Prod_OperadorE = cbOperadorE.Text
                            End If

                            m.Prod_Ancho = CDbl(IIf(txtAnchoDesde.Text = "", 0, txtAnchoDesde.Text))

                            If cbOperadorA.Text <> "" Then
                                m.Prod_OperadorA = cbOperadorA.Text
                            End If

                            m.Prod_Largo = CDbl(IIf(txtLargoDesde.Text = "", 0, txtLargoDesde.Text))

                            If cbOperadorL.Text <> "" Then
                                m.Prod_OperadorL = cbOperadorL.Text
                            End If
                            
                            m.Prod_FuncionCalculo = lineaprodCB.Text
                            m.Prod_SistemaCalculo = txtSisCubicacion.Text
                            m.Prod_Simbolo = txtSimboloCubi.Text
                            m.Prod_Fe = TxFacEsp.Text
                            db.SaveChanges()
                            fauditoria.insertar("Productos", "Insertar", m.Prod_Id, "")
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
                        Catch ex As Exception
                            MessageBox.Show("Datos No fueron editados, intente de nuevo!", "Editando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            deshabilitar()
                            registro_seleccionado()
                        End Try
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
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("ID").Value)

                        Try
                            Dim db As New samadEntities
                            Dim d = db.productos.FirstOrDefault(Function(p) p.Prod_Id = onekey)
                            db.productos.DeleteObject(d)
                            db.SaveChanges()
                            fauditoria.insertar("Productos", "Eliminar", d.Prod_Id, "")
                        Catch ex As Exception
                            MessageBox.Show("Registro NO fue eliminado", "Eliminar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try

                    End If
                Next
                xreg = 0
                mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub frmProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        deshabilitar()
        mostrar()
        formatear_grid()
        dataListado.Focus()
        registro_seleccionado()
        AplicarPerfil()
        'Dim db As New samadEntities
        'lineaprodCB.DataSource = db.linea.ToList()
    End Sub
    Private Sub dataListado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataListado.CellContentClick, dataListado.CellDoubleClick
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
    Private Sub dataListado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        registro_seleccionado()
        tcDatos.SelectedIndex = 1
    End Sub

    Private Sub tpDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tpDatos.Click
        registro_seleccionado()
        tcDatos.SelectedIndex = 1
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
    Private Sub txtBuscar_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub
    Private Sub tcDatos_Selecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles tcDatos.Selecting
        If tcDatos.SelectedIndex = 1 Then
            registro_seleccionado()
        End If
    End Sub
    Private Sub txtEspesorDesde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEspesorDesde.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            e.Handled = True
            If txtEspesorDesde.Text = CChar("") Then
                txtEspesorDesde.Text = "0"
            Else
                txtEspesorDesde.Text = Format(txtEspesorDesde.Text * 1, "##0.00")
                cbOperadorL.Focus()
            End If
        End If

        ' "0123456789.-" Valores o caracteres que solo aceptara el TextBox

        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub
    Private Sub txtAnchoDesde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnchoDesde.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            e.Handled = True
            If txtAnchoDesde.Text = CChar("") Then
                txtAnchoDesde.Text = "0"
            Else
                txtAnchoDesde.Text = Format(txtAnchoDesde.Text * 1, "##0.00")
                cbOperadorA.Focus()
            End If
        End If

        ' "0123456789.-" Valores o caracteres que solo aceptara el TextBox

        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub
    Private Sub txtAnchoDesde_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAnchoDesde.LostFocus
        If IsNumeric(txtAnchoDesde.Text) Then
            If txtAnchoDesde.Text <> 0 Then
                txtAnchoDesde.Text = Format(txtAnchoDesde.Text * 1, "##0.00")
            End If
        End If
    End Sub
    Private Sub txtAnchoHasta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'If IsNumeric(txtAnchoHasta.Text) Then
        '    If txtAnchoHasta.Text <> 0 Then
        '        txtAnchoHasta.Text = Format(txtAnchoHasta.Text * 1, "##0.00")
        '    End If
        'End If
    End Sub
    Private Sub txtLargoDesde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLargoDesde.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            e.Handled = True
            If txtLargoDesde.Text = CChar("") Then
                txtLargoDesde.Text = "0"
            Else
                txtLargoDesde.Text = Format(txtLargoDesde.Text * 1, "##0.00")
                cbOperadorL.Focus()
            End If
        End If

        ' "0123456789.-" Valores o caracteres que solo aceptara el TextBox

        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub

    Private Sub txtLargoDesde_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLargoDesde.LostFocus
        If IsNumeric(txtLargoDesde.Text) Then
            If txtLargoDesde.Text <> 0 Then
                txtLargoDesde.Text = Format(txtLargoDesde.Text * 1, "##0.00")
            End If
        End If
    End Sub
    Private Sub txtEspesorHasta_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'If txtEspesorHasta.Text <> "" Then
        '    If Convert.ToDecimal(txtEspesorHasta.Text) < Convert.ToDecimal(txtEspesorDesde.Text) Then
        '        MessageBox.Show("El 'Espesor hasta', debe ser mayor al 'Espesor desde'", "Mensaje")
        '        txtEspesorHasta.Focus()
        '    End If
        'End If
    End Sub
    Private Sub txtAnchoHasta_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'If txtAnchoHasta.Text <> "" Then
        '    If Convert.ToDecimal(txtAnchoHasta.Text) < Convert.ToDecimal(txtAnchoDesde.Text) Then
        '        MessageBox.Show("El 'Ancho hasta', debe ser mayor al 'Ancho desde'", "Mensaje")
        '        txtAnchoHasta.Focus()
        '    End If
        'End If
    End Sub
    Private Sub txtLargoHasta_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'If txtLargoHasta.Text <> "" Then
        '    If Convert.ToDecimal(txtLargoHasta.Text) < Convert.ToDecimal(txtLargoDesde.Text) Then
        '        MessageBox.Show("El 'Largo hasta', debe ser mayor al 'Largo desde'", "Mensaje")
        '        txtLargoHasta.Focus()
        '    End If
        'End If
    End Sub
    Private Sub mostrar_tipoproducto()

        If cbTipoProducto.Text.Equals("PP") Then
            lblTipoCubicacion.Text = "Producto en Proceso"
            GroupBox1.Enabled = False
          
        Else
            If cbTipoProducto.Text.Equals("PT") Then
                lblTipoCubicacion.Text = "Producto Terminado"
                GroupBox1.Enabled = True
            End If
        End If

    End Sub


    Private Sub cmbTipoProducto_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbTipoProducto.SelectedIndexChanged
        mostrar_tipoproducto()
    End Sub
    Private Sub CargarClaseComercial()
        Dim rendimiento, valorcombo As String
        Dim dm As New samadEntities
        cmbClaseComercial.DataSource = Nothing
        cmbClaseComercial.DataSource = dm.linea.Select(Function(x) x.Lin_Nombre).ToList()

        valorcombo = cmbClaseComercial.Text

        rendimiento = dm.linea.Where(Function(x) x.Lin_Nombre = valorcombo).Select(Function(e) e.Lin_Porcentual).FirstOrDefault
        txtRendimiento.Text = rendimiento

    End Sub

    Private Sub cmbClaseComercial_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbClaseComercial.SelectedIndexChanged
        Dim vcom, re As String
        Dim dm As New samadEntities
        vcom = cmbClaseComercial.Text
        re = dm.linea.Where(Function(x) x.Lin_Nombre = vcom).Select(Function(y) y.Lin_Porcentual).FirstOrDefault
        idclasecomer = dm.linea.Where(Function(x) x.Lin_Nombre = vcom).Select(Function(y) y.Lin_id).FirstOrDefault
        txtRendimiento.Text = re


    End Sub
    Private Sub CargarUnidadMedAb()
        Dim valorcombo As String
        Dim dm As New samadEntities
        cbUnidMedAb.DataSource = Nothing
        cbUnidMedAb.DataSource = dm.unidad_medida_ab.Select(Function(x) x.Uni_Abreviatura).ToList()

        valorcombo = cbUnidMedAb.Text
    End Sub
    Private Sub CargarUnidadMedL()
        Dim valorcombo As String
        Dim dm As New samadEntities
        cbUnidMedL.DataSource = Nothing
        cbUnidMedL.DataSource = dm.unidad_medida_l.Select(Function(x) x.Unil_Abreviatura).ToList()
        valorcombo = cbUnidMedL.Text
    End Sub
    Private Sub CargarTipoCubicacion()
        Dim siscubi, simbolcubi, FacEsp, valorcombo As String
        Dim dm As New samadEntities
        lineaprodCB.DataSource = Nothing
        lineaprodCB.DataSource = dm.tipo_calculo_volumen.Select(Function(x) x.TipCal_Cod).Distinct()
        valorcombo = lineaprodCB.Text
        siscubi = dm.tipo_calculo_volumen.Where(Function(x) x.TipCal_Cod = valorcombo).Select(Function(e) e.TipCal_Volumen).FirstOrDefault
        txtSisCubicacion.Text = siscubi
        simbolcubi = dm.tipo_calculo_volumen.Where(Function(x) x.TipCal_Cod = valorcombo).Select(Function(e) e.TipCal_Simbolo).FirstOrDefault
        txtSimboloCubi.Text = simbolcubi
        FacEsp = dm.tipo_calculo_volumen.Where(Function(x) x.TipCal_Cod = valorcombo).Select(Function(e) e.TipCal_Fe).FirstOrDefault
        TxFacEsp.Text = FacEsp
    End Sub

    Private Sub lineaprodCB_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lineaprodCB.SelectedIndexChanged
        Dim vcom, suc, sim, fe As String
        Dim dm As New samadEntities
        vcom = lineaprodCB.Text
        suc = dm.tipo_calculo_volumen.Where(Function(x) x.TipCal_Cod = vcom).Select(Function(y) y.TipCal_Volumen).FirstOrDefault
        txtSisCubicacion.Text = suc

        sim = dm.tipo_calculo_volumen.Where(Function(x) x.TipCal_Cod = vcom).Select(Function(z) z.TipCal_Simbolo).FirstOrDefault
        txtSimboloCubi.Text = sim

        fe = IIf(IsDBNull(dm.tipo_calculo_volumen.Where(Function(x) x.TipCal_Cod = vcom).Select(Function(z) z.TipCal_Fe).FirstOrDefault()) = True, 0, dm.tipo_calculo_volumen.Where(Function(x) x.TipCal_Cod = vcom).Select(Function(z) z.TipCal_Fe).FirstOrDefault())
        TxFacEsp.Text = fe
    End Sub

   
End Class