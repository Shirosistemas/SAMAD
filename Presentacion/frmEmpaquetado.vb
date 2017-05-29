Public Class frmEmpaquetado
    Dim Dt, Dtd, Dtdm, Dted, Dte, Dtep, Dtb, Dtepd As New DataTable
    Dim func As New fformato01 'Creacion una variable para hacer referencia a la funcion fconcesiones
    Dim nreg, nregpd, nregd, xreg, recno As Integer
    Dim sw_guardar As Boolean = False
    Dim sw_guardard As Boolean = False
    Dim nuevo As Boolean = False
    Public nuevoDeta As Boolean = False
    Dim nuevoItem As Boolean = False
    Dim modificar As Boolean = False
    Public modificarDeta As Boolean = False
    Dim modificarItem As Boolean = False
    Dim msg As String = ""
    Dim frm, frmbuscardoc As New frmShowbrow
    Dim registroSeleccionadoId As Integer
    Private _left As String

    Private Sub AplicarPerfil()
        If vInfraestructura.Usuario.gtipo = "ADMINISTRADOR" Then

        Else
            Panel3.Enabled = False
            Panel4.Enabled = False
            Panel5.Enabled = False

        End If
    End Sub

    Private Sub habilitar()
        txtNroDoc.Enabled = False
        txtFecha.Enabled = True
        txtAserraderoId.Enabled = False
        txtAserraderoNombre.Enabled = False
        txtObservacion.Enabled = True
        txtTotPaq.Enabled = False
        txtTotPiezas.Enabled = False
        txtTotalVolpt.Enabled = False

        btnAserradero.Enabled = True
    End Sub

    Private Sub deshabilitar()

        txtNroDoc.Enabled = False
        txtFecha.Enabled = False
        txtAserraderoId.Enabled = False
        txtAserraderoNombre.Enabled = False
        txtObservacion.Enabled = False
        txtTotPaq.Enabled = False
        txtTotPiezas.Enabled = False
        txtTotalVolpt.Enabled = False

        btnAserradero.Enabled = False

    End Sub

    Private Sub limpiar()
        TxtId.Text = ""
        txtAserraderoId.Text = ""
        txtAserraderoNombre.Text = ""
        txtFecha.Text = ""
        txtObservacion.Text = ""
    End Sub

    Private Sub formatear_grid()

        'Ocultando Columnas
        If nregd > 0 Then
            dgwDataDetalle.Columns.Item("Eliminar").Visible = False
            dgwDataDetalle.Columns.Item("Paq_id").Visible = False
            dgwDataDetalle.Columns.Item("Paq_Emp_ID").Visible = False
            dgwDataDetalle.Columns.Item("Paq_Especie").Visible = False
            dgwDataDetalle.Columns.Item("Paq_TipoProducto").Visible = False
            dgwDataDetalle.Columns.Item("Paq_CubicadorId").Visible = False
            dgwDataDetalle.Columns.Item("Paq_Observacion").Visible = False

            'Ancho de las Columnas
            dgwDataDetalle.Columns.Item("Item").Width = 40
            dgwDataDetalle.Columns.Item("Paq_id").Width = 40
            dgwDataDetalle.Columns.Item("Paq_Numero").Width = 60
            dgwDataDetalle.Columns.Item("Espe_NombreComun").Width = 130
            dgwDataDetalle.Columns.Item("Prod_Descrip").Width = 140
            dgwDataDetalle.Columns.Item("Paq_Acabado").Width = 80
            dgwDataDetalle.Columns.Item("Paq_Humedad").Width = 70
            dgwDataDetalle.Columns.Item("Paq_Clasificacion").Width = 70
            dgwDataDetalle.Columns.Item("Per_NomApe").Width = 160
            dgwDataDetalle.Columns.Item("Paq_Ubicacion").Width = 90


            dgwDataDetalle.Columns.Item("Item").HeaderText = "Item"
            dgwDataDetalle.Columns.Item("Paq_id").HeaderText = "Id"
            dgwDataDetalle.Columns.Item("Paq_Emp_ID").HeaderText = "Paq_Emp_ID"
            dgwDataDetalle.Columns.Item("Paq_Numero").HeaderText = "N°Paq."
            dgwDataDetalle.Columns.Item("Paq_Especie").HeaderText = "Paq_Especie"
            dgwDataDetalle.Columns.Item("Espe_NombreComun").HeaderText = "Especie"
            dgwDataDetalle.Columns.Item("Paq_TipoProducto").HeaderText = "Prod_Descrip"
            dgwDataDetalle.Columns.Item("Prod_Descrip").HeaderText = "Producto"
            dgwDataDetalle.Columns.Item("Paq_Acabado").HeaderText = "Acabado"
            dgwDataDetalle.Columns.Item("Paq_Humedad").HeaderText = "Humedad"
            dgwDataDetalle.Columns.Item("Paq_Clasificacion").HeaderText = "Clasificacion"
            dgwDataDetalle.Columns.Item("Paq_CubicadorId").HeaderText = "Paq_CubicadorId"
            dgwDataDetalle.Columns.Item("Per_NomApe").HeaderText = "Cubicador"
            dgwDataDetalle.Columns.Item("Paq_Ubicacion").HeaderText = "Ubicación"
            dgwDataDetalle.Columns.Item("Paq_Observacion").HeaderText = "Paq_Observacion"
        End If
    End Sub

    Private Sub mostrar_detallepaquete(ByVal registro As Integer)
        Try

            Dim dtl As New vPaqueteDeta
            Dim func As New fPaqueteDeta 'Creacion una variable para hacer referencia a la funcion flistatrozasd

            dtl.gPaqd_Paq_Id = registro
            Dtepd = func.mostrarPaqueteDetalle(dtl) 'Invocamos a la funcion mostrar()
            nregpd = Dtepd.Rows.Count 'Almacenamos la cantidad de filas o registros recuperados

            If nregpd > 0 Then
                dgwPaquetesDetalle.DataSource = Dtepd
            Else
                dgwPaquetesDetalle.DataSource = Nothing

            End If
            estado_botones_items_detalle()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mostrar_detalle(ByVal registro As Integer)
        Try

            Dim dtl As New vPaquete
            Dim func As New fPaquete 'Creacion una variable para hacer referencia a la funcion flistatrozasd

            dtl.gPaq_Emp_id = registro
            Dted = func.mostrarDetalle(dtl) 'Invocamos a la funcion mostrar()
            nregd = Dted.Rows.Count 'Almacenamos la cantidad de filas o registros recuperados

            If nregd > 0 Then

                dgwDataDetalle.DataSource = Dted
                dgwPaquetesDetalle.DataSource = Dtepd
                dgwDataDetalle.ColumnHeadersVisible = True
                sumar_volumenypaquetes()
            Else

                dgwDataDetalle.DataSource = Nothing
                dgwPaquetesDetalle.DataSource = Nothing
                dgwDataDetalle.ColumnHeadersVisible = False
                txtPaquete.Text = ""
            End If
            estado_botones_items()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mostrar_encabezado()
        Try
            Dim func As New fEmpaquetado 'Creacion una variable para hacer referencia a la funcion flistatrozasd
            Dte = func.mostrar 'Invocamos a la funcion mostrar()

            nreg = Dte.Rows.Count 'Almacenamos la cantidad de filas o registros recuperados

            If nreg <> 0 Then

                TxtId.Text = Dte.Rows(recno).Item("Emp_id").ToString
                txtNroDoc.Text = Dte.Rows(recno).Item("Emp_NroDoc").ToString
                txtFecha.Text = Dte.Rows(recno).Item("Emp_Fecha")
                chkCertificada.CheckState = Dte.Rows(recno).Item("Emp_Certificado").ToString
                txtAserraderoId.Text = Dte.Rows(recno).Item("Emp_AserraderoId").ToString
                txtAserraderoNombre.Text = Dte.Rows(recno).Item("pro_titular").ToString

                habilitar_botones_desplazamiento()
                btnNuevo.Enabled = True
                btnModificar.Enabled = True
                btnGuardar.Enabled = False
                btnDeshacer.Enabled = False
                btnSalir.Enabled = True
            Else
                deshabilitar_botones_desplazamiento()
                'ocultar_columnas()
                btnNuevo.Enabled = True
                btnModificar.Enabled = False
                btnGuardar.Enabled = False
                btnDeshacer.Enabled = False
                btnSalir.Enabled = True
            End If
            estado_botones_items()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function obtener_siguiente_numero_lista()
        Dim ulpos As Integer
        Dim numero, ultimo, numstring, siguiente As String
        ulpos = Dte.Rows.Count - 1
        If ulpos <> -1 Then
            ultimo = Dte.Rows(ulpos).Item("Emp_NroDoc").ToString()
            numero = Convert.ToInt32(Mid(ultimo, 5, 6) + 1)
        Else
            numero = 1
        End If
        numstring = Microsoft.VisualBasic.Right("000000" + numero, 6)
        siguiente = numstring
        Return siguiente
    End Function

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAserradero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAserradero.Click
        'Enviamos los datos de la consulta sql
        frm.titulo = "Lista del Aserraderos"
        frm.t_tabla = "Titulares"
        frm.t_campos = "pro_id,pro_titular"
        frm.t_donde = ""
        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Aserraderos"}
        Dim anchos() As Integer = {30, 200}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)
        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog(Me)

        'Datos del Titular
        If frm.flag = True Then
            txtAserraderoId.Text = frm.matColumnas(0)
            txtAserraderoNombre.Text = frm.matColumnas(1)
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.MouseCaptureChanged
        nuevo = True
        modificar = False
        habilitar()
        limpiar()
        estado_botones_items()
        txtNroDoc.Text = obtener_siguiente_numero_lista()
        mostrar_detalle(0)
        mostrar_detallepaquete(0)
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnDeshacer.Enabled = True
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.MouseCaptureChanged
        nuevo = False
        modificar = True
        habilitar()
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnDeshacer.Enabled = True
    End Sub

    Private Sub estado_botones_items()
        If nregd <> 0 Then
            btnAgregarPaq.Enabled = True
            btnEditarPaq.Enabled = True
            btnEliminarPaq.Enabled = False
            chkEliminar.Enabled = True
        Else
            btnAgregarPaq.Enabled = True
            btnEditarPaq.Enabled = False
            btnEliminarPaq.Enabled = False
            chkEliminar.Enabled = False
        End If
    End Sub

    Private Sub estado_botones_items_detalle()
        If nregpd <> 0 Then

            btnNuevoDetalle.Enabled = True
            btnEditarDetalle.Enabled = True
            btnEliminarDetalle.Enabled = True

        Else
            btnNuevoDetalle.Enabled = True
            btnEditarDetalle.Enabled = False
            btnEliminarDetalle.Enabled = False
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim funcl As New flibreria
        Dim todook As Boolean = funcl.ValidaControles(gbDatos.Controls)

        If todook = True Then
            Dim result As DialogResult

            'validar_campos()
            sw_guardar = True
            If sw_guardar = True Then 'Guardamos si los controles no estan vacios
                result = MessageBox.Show("Esta seguro de GUARDAR el registro ?", "Guardar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If result = DialogResult.OK Then
                    Try
                        'Guardando los datos de Encabezado
                        Dim dts As New vEmpaquetado
                        Dim func As New fEmpaquetado

                        dts.gEmp_NroDoc = txtNroDoc.Text
                        dts.gEmp_Fecha = txtFecha.Text
                        dts.gEmp_Certificado = chkCertificada.CheckState
                        'dts.gf02_observacion = txtObservacion.Text
                        dts.gEmp_AserraderoId = txtAserraderoId.Text
                        'Codigo para insertar registros
                        If nuevo = True Then
                            If func.insertar(dts) Then
                                MessageBox.Show("Datos guardados correctamente...!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                limpiar()
                                deshabilitar()
                                mostrar_encabezado()
                                btnNuevo.Enabled = True
                                btnModificar.Enabled = True
                                btnGuardar.Enabled = False
                                btnDeshacer.Enabled = False
                                btnAgregarPaq.Enabled = True
                                btnEditarPaq.Enabled = True
                                btnEliminarPaq.Enabled = True
                                btnSalir.Enabled = True
                                chkEliminar.Enabled = False
                                btnEliminarPaq.Enabled = False
                                estado_botones_items()
                                btnUlt.PerformClick()
                            Else
                                MessageBox.Show("Datos No fueron registrados, intente de nuevo!!!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                mostrar_encabezado()
                                limpiar()
                            End If
                        End If

                        'Codigo para editar registros
                        If modificar = True Then
                            dts.gEmp_Id = TxtId.Text
                            If func.editar(dts) Then
                                MessageBox.Show("Datos editados correctamente...!", "Editando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                limpiar()
                                mostrar_encabezado()
                                deshabilitar()
                                btnNuevo.Enabled = True
                                btnModificar.Enabled = True
                                btnGuardar.Enabled = False
                                btnDeshacer.Enabled = False
                                btnSalir.Enabled = True
                                chkEliminar.Enabled = False
                                btnEliminarPaq.Enabled = False
                                estado_botones_items()
                            Else
                                MessageBox.Show("Datos No fueron editados, intente de nuevo!", "Editando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                mostrar_encabezado()
                            End If
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Else
                MessageBox.Show(msg, "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnDeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeshacer.Click
        deshabilitar()
        limpiar()
        mostrar_encabezado()
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnGuardar.Enabled = False
        btnDeshacer.Enabled = False
    End Sub

    Private Sub btnAgregarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPaq.Click
        Dim paquete As New frmPaquete
        nuevoDeta = True
        modificar = False
        paquete.ShowDialog(Me)
        sumar_volumenypaquetes()
        formatear_grid()
        mostrar_detalle(TxtId.Text)
    End Sub

    Private Sub btnPri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPri.Click
        recno = 0
        mostrar_encabezado()
        mover_registros_cabecera()
    End Sub

    Private Sub btnSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSig.Click
        recno += 1
        If recno <= (nreg - 1) Then
            mostrar_encabezado()
            mover_registros_cabecera()
        Else
            recno = nreg - 1
        End If
    End Sub

    Private Sub btnAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnt.Click
        recno -= 1
        If recno >= 0 Then
            mostrar_encabezado()
            mover_registros_cabecera()
        Else
            recno = 0
        End If
    End Sub

    Private Sub btnUlt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUlt.Click
        recno = nreg - 1
        mostrar_encabezado()
        mover_registros_cabecera()
    End Sub

    Private Sub btnEditarPaq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarPaq.Click
        Dim paquete As New frmPaquete
        nuevoDeta = False
        modificarDeta = True
        registro_seleccionado()
        mostrar_detalle(TxtId.Text)
        mostrar_detallepaquete(dgwDataDetalle.SelectedCells.Item(2).Value)
        formatear_paquete_detalle()
    End Sub

    Private Sub registro_seleccionado()
        Dim paquete As New frmPaquete
        paquete.txtId.Text = dgwDataDetalle.SelectedCells.Item(2).Value
        paquete.txtNumPaq.Text = dgwDataDetalle.SelectedCells.Item(4).Value
        paquete.txtEspecieId.Text = dgwDataDetalle.SelectedCells.Item(5).Value
        paquete.txtEspecieNombre.Text = dgwDataDetalle.SelectedCells.Item(6).Value
        paquete.txtProductoId.Text = dgwDataDetalle.SelectedCells.Item(7).Value
        paquete.txtProductoNombre.Text = dgwDataDetalle.SelectedCells.Item(8).Value
        paquete.txtAcabado.Text = dgwDataDetalle.SelectedCells.Item(9).Value
        paquete.txtHumedad.Text = dgwDataDetalle.SelectedCells.Item(10).Value
        paquete.txtClasificacion.Text = dgwDataDetalle.SelectedCells.Item(11).Value
        paquete.txtCubicadorId.Text = dgwDataDetalle.SelectedCells.Item(12).Value
        paquete.txtCubicadorNombre.Text = dgwDataDetalle.SelectedCells.Item(13).Value
        paquete.txtUbicacion.Text = dgwDataDetalle.SelectedCells.Item(14).Value
        paquete.txtObservacion.Text = dgwDataDetalle.SelectedCells.Item(15).Value
        formatear_paquete_detalle()
        paquete.ShowDialog()
    End Sub

    Private Sub formatear_paquete_detalle()

        If nregpd <> 0 Then

            dgwPaquetesDetalle.AllowUserToResizeRows = False
            dgwPaquetesDetalle.RowHeadersVisible = False
            dgwPaquetesDetalle.Columns.Item("Paqd_id").Visible = False
            dgwPaquetesDetalle.Columns.Item("Paqd_Paq_Id").Visible = False
            dgwPaquetesDetalle.Columns.Item("Paqd_Piezas").Width = 70
            dgwPaquetesDetalle.Columns.Item("Paqd_Espesor").Width = 70
            dgwPaquetesDetalle.Columns.Item("Paqd_Ancho").Width = 70
            dgwPaquetesDetalle.Columns.Item("Paqd_Largo").Width = 70
            dgwPaquetesDetalle.Columns.Item("Paqd_Volpt").Width = 70

            dgwPaquetesDetalle.Columns.Item("Paqd_id").HeaderText = ""
            dgwPaquetesDetalle.Columns.Item("Paqd_Paq_Id").HeaderText = ""
            dgwPaquetesDetalle.Columns.Item("Paqd_Piezas").HeaderText = "Piezas"
            dgwPaquetesDetalle.Columns.Item("Paqd_Espesor").HeaderText = "Espesor"
            dgwPaquetesDetalle.Columns.Item("Paqd_Ancho").HeaderText = "Ancho"
            dgwPaquetesDetalle.Columns.Item("Paqd_Largo").HeaderText = "Largo"
            dgwPaquetesDetalle.Columns.Item("Paqd_Volpt").HeaderText = "Volpt"

            'Centrando columnas
            dgwPaquetesDetalle.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            dgwPaquetesDetalle.Columns.Item("Paqd_Piezas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            dgwPaquetesDetalle.Columns.Item("Paqd_Espesor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            dgwPaquetesDetalle.Columns.Item("Paqd_Ancho").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            dgwPaquetesDetalle.Columns.Item("Paqd_Largo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            dgwPaquetesDetalle.Columns.Item("Paqd_Volpt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

            'txtPaquete.Text = "PAQUETE N° " + Convert.ToString(dgwDataDetalle.SelectedCells.Item(4).Value)
        End If
    End Sub

    Private Sub chkEliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEliminar.CheckedChanged
        If chkEliminar.CheckState = CheckState.Checked Then
            dgwDataDetalle.Columns.Item("Eliminar").Visible = True
            dgwDataDetalle.Columns.Item("Eliminar").Width = 20
            dgwDataDetalle.Columns.Item("Eliminar").HeaderText = ""
        Else
            dgwDataDetalle.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub dgwDataDetalle_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDataDetalle.CellClick
        'If Dted.Rows.Count <> 0 Then
        frmPaqueteDeta.lblProducto.Text = dgwDataDetalle.SelectedCells.Item(8).Value
        txtPaquete.Text = "PAQUETE N° " + Convert.ToString(dgwDataDetalle.SelectedCells.Item(4).Value)
        estado_botones_items_detalle()
        registroSeleccionadoId = dgwDataDetalle.SelectedCells.Item(2).Value
        mostrar_detallepaquete(registroSeleccionadoId)
        formatear_paquete_detalle()
        sumar_volumenypaquetes()
        'End If
    End Sub

    Private Sub registro_seleccionado_detalle()
        Dim paqueteDeta As New frmPaqueteDeta
        paqueteDeta.txtId.Text = dgwPaquetesDetalle.SelectedCells.Item(0).Value
        paqueteDeta.txtEspesor.Text = dgwPaquetesDetalle.SelectedCells.Item(2).Value
        paqueteDeta.txtAncho.Text = dgwPaquetesDetalle.SelectedCells.Item(3).Value
        paqueteDeta.txtLargo.Text = dgwPaquetesDetalle.SelectedCells.Item(4).Value
        paqueteDeta.txtVolPt.Text = dgwPaquetesDetalle.SelectedCells.Item(5).Value
        paqueteDeta.txtNumPiezas.Text = dgwPaquetesDetalle.SelectedCells.Item(6).Value

        paqueteDeta.ShowDialog()
    End Sub

    Private Sub btnEditarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        nuevoDeta = False
        modificarDeta = True
        registro_seleccionado_detalle()
        mostrar_detallepaquete(registroSeleccionadoId)
        formatear_paquete_detalle()
    End Sub

    Private Sub habilitar_botones_desplazamiento()
        btnPri.Enabled = True
        btnSig.Enabled = True
        btnAnt.Enabled = True
        btnUlt.Enabled = True
    End Sub

    Private Sub deshabilitar_botones_desplazamiento()
        btnPri.Enabled = False
        btnSig.Enabled = False
        btnAnt.Enabled = False
        btnUlt.Enabled = False
    End Sub

    Public Sub sumar_volumenypaquetes()
        Try
            Dim totVolpt As Decimal = 0
            Dim totPzas As Integer = 0

            Dim totPaquete As Integer = Dted.Rows.Count
            If nregd > 0 Then
                txtTotPaq.Text = totPaquete
            Else
                txtTotPaq.Text = ""
            End If

            Dim filasSeleccionadas As Integer = dgwDataDetalle.Rows.GetRowCount(DataGridViewElementStates.Selected)

            If nregpd > 0 Then
                If filasSeleccionadas > 0 Then
                    totVolpt = Dtepd.Compute("Sum(Paqd_Volpt)", Nothing)
                    totPzas = Dtepd.Compute("Sum(Paqd_piezas)", Nothing)
                    txtTotalVolpt.Text = totVolpt
                    txtTotPiezas.Text = totPzas
                Else
                    txtTotalVolpt.Text = ""
                    txtTotPiezas.Text = ""
                End If
            End If
            Me.Text = registroSeleccionadoId
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnEditarDetalle_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarDetalle.Click
        nuevoDeta = False
        modificarDeta = True
        registro_seleccionado_detalle()
        mostrar_detallepaquete(registroSeleccionadoId)
        formatear_paquete_detalle()
    End Sub

    Private Sub btnNuevoDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoDetalle.Click
        Dim frmPaqDeta As New frmPaqueteDeta
        nuevoDeta = True
        modificarDeta = False
        Dim result As DialogResult
        frmPaqDeta.txtVolPt.Enabled = False

        frmPaqDeta.ShowDialog(Me)

        If frmPaqDeta.sw2 = True Then
            sw_guardar = True
            If sw_guardar = True Then 'Guardamos si los controles no estan vacios
                result = MessageBox.Show("Esta seguro de GUARDAR el registro ?", "Guardar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If result = DialogResult.OK Then
                    Try
                        'Guardando los datos de Encabezado
                        Dim dts As New vPaqueteDeta
                        Dim func As New fPaqueteDeta

                        dts.gPaqd_Paq_Id = dgwDataDetalle.SelectedCells.Item(2).Value
                        dts.gPaqd_Espesor = frmPaqDeta.txtEspesor.Text
                        dts.gPaqd_Ancho = frmPaqDeta.txtAncho.Text
                        dts.gPaqd_Largo = frmPaqDeta.txtLargo.Text
                        dts.gPaqd_Volpt = frmPaqDeta.txtVolPt.Text
                        dts.gPaqd_Piezas = frmPaqDeta.txtNumPiezas.Text

                        If nuevoDeta = True Then
                            If func.insertar(dts) Then
                                MessageBox.Show("Datos guardados correctamente...!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                limpiar()
                                deshabilitar()
                                btnGuardar.Enabled = False
                                mostrar_detallepaquete(registroSeleccionadoId)
                                formatear_paquete_detalle()
                                sumar_volumenypaquetes()
                            Else
                                MessageBox.Show("Datos No fueron registrados, intente de nuevo!!!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            End If
                        End If

                        If modificarDeta = True Then
                            dts.gPaqd_id = TxtId.Text
                            If func.editar(dts) Then
                                MessageBox.Show("Datos editados correctamente...!", "Editando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                limpiar()
                                deshabilitar()
                                btnGuardar.Enabled = False
                                mostrar_detallepaquete(registroSeleccionadoId)
                                formatear_paquete_detalle()
                                sumar_volumenypaquetes()
                            Else
                                MessageBox.Show("Datos No fueron editados, intente de nuevo!", "Editando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Else
                MessageBox.Show(msg, "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Private Sub frmEmpaquetado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar_encabezado()
        btnUlt.PerformClick()
    End Sub

    Private Sub mover_registros_cabecera()

        'Mover Cabecera
        deshabilitar()
        mostrar_detalle(IIf(TxtId.Text <> "", TxtId.Text, 0))
        formatear_grid()

        If nregd > 0 Then
            mostrar_detallepaquete(IIf(IsDBNull(registroSeleccionadoId) = False, registroSeleccionadoId, 0))
            formatear_paquete_detalle()
            sumar_volumenypaquetes()
        End If

    End Sub

End Class