Public Class frmUnidadMedidaLargo
    'Private dt As New DataTable
    Dim dt As List(Of unidad_medida_l)
    'Dim func As New fespecies 'Creacion una variable para hacer referencia a la funcion fconcesiones
    Dim nreg, xreg As Integer
    Dim sw_guardar As Boolean = False
    Dim nuevo As Boolean = False
    Dim modificar As Boolean = False
    Dim msg As String = ""
    Private Sub frmCargos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        deshabilitar()
        mostrar()
        formatear_grid()
        dataListado.Focus()
        registro_seleccionado()
        AplicarPerfil()
    End Sub
    Private Sub AplicarPerfil()
        If vInfraestructura.Usuario.gtipo = "ADMINISTRADOR" Then

        Else
            Panel2.Enabled = False
        End If
    End Sub
    Private Sub registro_seleccionado()
        Try
            If nreg = 0 Then
                Return
            End If
            txtId.Text = dataListado.SelectedCells.Item(1).Value
            txtAbreviatura.Text = dataListado.SelectedCells.Item(2).Value
            txtDescripcion.Text = dataListado.SelectedCells.Item(3).Value
        Catch ex As Exception

        End Try
    End Sub
    Private Sub deshabilitar()

        txtId.Enabled = False
        txtAbreviatura.Enabled = False
        txtDescripcion.Enabled = False
    End Sub
    Private Sub habiltar()

        txtId.Enabled = False
        txtAbreviatura.Enabled = True
        txtDescripcion.Enabled = True

    End Sub
    Private Sub mostrar()
        Try
            'Dim func As New fcargos 'Creacion una variable para hacer referencia a la funcion fconcesiones
            'dt = func.mostrar 'Invocamos a la funcion mostrar()
            Dim db As New samadEntities
            dt = db.unidad_medida_l.ToList()

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
            MsgBox("Mensaje : Procedimiento Mostrar()" + ex.ToString())
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
        dataListado.Columns(1).Width = 10
        dataListado.Columns(2).Width = 200
        dataListado.Columns(3).Width = 200

        'Centrando todas las columnas del DataGridView
        dataListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'Cambiando el texto de las cabeceras
        dataListado.Columns(1).HeaderText = "Id"
        dataListado.Columns(2).HeaderText = "Abreviatura"
        dataListado.Columns(3).HeaderText = "Descripcion"

    End Sub
    Private Sub buscar()
        Try
            Dim db As New samadEntities

            If dt.Count <> 0 Then
                lblinexistente.Visible = False
                dataListado.DataSource = db.unidad_medida_l.Where(Function(p) p.Unil_Descripcion.Contains(txtBuscar.Text)).ToList()
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
            dataListado.Columns(1).Visible = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
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
        txtAbreviatura.Focus()
    End Sub
    Private Sub limpiar()
        txtId.Text = ""
        txtAbreviatura.Text = ""
        txtDescripcion.Text = ""
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
        txtAbreviatura.Focus()
    End Sub
    Private Sub validar_campos()

        'Preguntamos si los controles estan vacios, para enviar el mensaje
        If txtAbreviatura.Text <> "" Then
            sw_guardar = True
            msg = "Datos guardados con exito...!"
        Else
            sw_guardar = False
            msg = "Debe Ingresar la ABREVIATURA"
        End If
        If txtDescripcion.Text <> "" Then
            sw_guardar = True
            msg = "Datos guardados con exito...!"
        Else
            sw_guardar = False
            msg = "Debe Ingresar una DESCRIPCION"
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
                            Dim pr As New unidad_medida_l
                            pr.Unil_Abreviatura = txtAbreviatura.Text
                            pr.Unil_Descripcion = txtDescripcion.Text
                            db.unidad_medida_l.AddObject(pr)
                            db.SaveChanges()
                            fauditoria.insertar("linea", "Insertar", pr.Unil_id, "")
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
                            Dim m As unidad_medida_l = db.unidad_medida_l.FirstOrDefault(Function(p) p.Unil_id = txtId.Text)
                            m.Unil_Abreviatura = txtAbreviatura.Text
                            m.Unil_Descripcion = txtDescripcion.Text
                            db.SaveChanges()
                            fauditoria.insertar("linea", "Insertar", m.Unil_id, "")
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
    Private Sub chkEliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEliminar.CheckedChanged

        If chkEliminar.CheckState = CheckState.Checked Then
            dataListado.Columns.Item("Eliminar").Visible = True
            dataListado.Columns.Item("Eliminar").Width = 20
            dataListado.Columns.Item("Eliminar").HeaderText = ""
        Else
            dataListado.Columns.Item("Eliminar").Visible = False
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
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Try
                            Dim db As New samadEntities
                            Dim d = db.unidad_medida_l.FirstOrDefault(Function(p) p.Unil_id = onekey)
                            db.unidad_medida_l.DeleteObject(d)
                            db.SaveChanges()
                            fauditoria.insertar("linea", "Eliminar", d.Unil_id, "")
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
    Private Sub dataListado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataListado.CellDoubleClick
        registro_seleccionado()
        tcDatos.SelectedIndex = 1
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Dim r As New rCargos

        Dim rv As New frmReporte
        rv.Viewer.ReportSource = r
        rv.Show()


        'Dim dtsr As New vShowbrow
        'Dim func As New fshowbrowds
        'Dim ds As New DataSet 'Variabla DataSet

        'dtsr.gt_tabla = "cargos"
        'dtsr.gt_campos = "car_id,car_descripcion"
        'dtsr.gt_donde = ""
        'dtsr.gt_agruparpor = ""
        'dtsr.gt_ordenarpor = ""

        'ds = func.mostrar(dtsr) 'Invocamos a la funcion mostrar()

        ''Creando el directorio destino de los archivos xml, si no existe
        'If System.IO.Directory.Exists("C:\Xml") = False Then
        '    System.IO.Directory.CreateDirectory("C:\Xml")
        '    ds.WriteXml("C:\Xml\cargos.xml", XmlWriteMode.WriteSchema)
        'Else
        '    ds.WriteXml("C:\Xml\cargos.xml", XmlWriteMode.WriteSchema)
        'End If
        'frmMostrarReportes.objReporteName = "rptCargos"
        'frmMostrarReportes.ShowDialog(Me)
    End Sub

    Private Sub tpDatos_Click(sender As System.Object, e As System.EventArgs) Handles tpDatos.Click

    End Sub
End Class