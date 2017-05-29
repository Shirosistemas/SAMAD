Public Class frmFormato02

    Dim Dt, Dtd, Dtdm, Dte, Dtb, Dtdta As New DataTable
    Dim func As New fformato02 'Creacion una variable para hacer referencia a la funcion fconcesiones
    Dim nreg, nregd, xreg, recno, Pro_id, Proc_id As Integer
    Dim sw_guardar As Boolean = False
    Dim sw_guardard As Boolean = False
    Dim nuevo As Boolean = False
    Dim nuevoItem As Boolean = False
    Dim modificar As Boolean = False
    Dim modificarItem As Boolean = False
    Dim msg As String = ""
    Dim frm, frmbuscardoc, frmtur As New frmShowbrow
    Private _left As String

    Dim xTitulo = fxSamad.Titulo
    Dim xNumtroza As String

    Public Sub ListarInfo()
        mostrar_encabezado()
        mostrar_detalle(TxtId.Text)
        mostrar_resumen()
        sumar_volumenytrozas()
        formatear_grid()
    End Sub

    Private Sub AplicarPerfil()
        If vInfraestructura.Usuario.gtipo = "ADMINISTRADOR" Then

        Else
            GroupBox1.Enabled = False
            Panel3.Enabled = False
        End If
    End Sub

    Private Sub Deshabilitar_datos()

        TxtId.Enabled = False 'Id del Encabezado
        txtFecha.Enabled = False 'Fecha del Encabezado
        txtObservacion.Enabled = False
        chkCertificada.Enabled = False
        txtEmpresaDesc.ButtonCustom.Enabled = False
        txtResponsableCargo.ButtonCustom.Enabled = False
        TxtProceso.ButtonCustom.Enabled = False
        txtTurnoHoriario.ButtonCustom.Enabled = False
        txtNroOpe.Enabled = False
        txtPeriodo.Enabled = False
        'txLote.Enabled = False
    End Sub

    Private Sub Habilitar_datos()

        TxtId.Enabled = False 'Id del Encabezado
        txtFecha.Enabled = True 'Fecha del Encabezado
        txtObservacion.Enabled = True
        chkCertificada.Enabled = True
        txtResponsableCargo.ButtonCustom.Enabled = True
        txtEmpresaDesc.ButtonCustom.Enabled = True
        TxtProceso.ButtonCustom.Enabled = True
        txtTurnoHoriario.ButtonCustom.Enabled = True
        txtNroOpe.Enabled = True
        txtPeriodo.Enabled = True
        'txLote.Enabled = True
    End Sub

    Private Sub mostrar_encabezado()
        Try

            Dim func As New fformato02 'Creacion una variable para hacer referencia a la funcion flistatrozasd
            Dte = func.mostrar 'Invocamos a la funcion mostrar()

            nreg = Dte.Rows.Count 'Almacenamos la cantidad de filas o registros recuperados

            If nreg <> 0 Then

                TxtId.Text = Dte.Rows(recno).Item("f02_id").ToString
                txtNroDoc.Text = Dte.Rows(recno).Item("f02_nrodoc").ToString
                txtFecha.Text = Dte.Rows(recno).Item("f02_fecha").ToString
                chkCertificada.CheckState = Dte.Rows(recno).Item("f02_certificada").ToString
                txtObservacion.Text = Dte.Rows(recno).Item("f02_observacion").ToString
                txtResponsableId.Text = Dte.Rows(recno).Item("f02_responsable_id").ToString
                txtResponsableNombre.Text = Dte.Rows(recno).Item("per_nomape").ToString
                txtResponsableCargo.Text = Dte.Rows(recno).Item("per_cargo").ToString
                txtNroOpe.Text = Dte.Rows(recno).Item("F02_nroope").ToString
                txtTurno_Id.Text = Dte.Rows(recno).Item("F02_turno_id").ToString
                txtTurnoDescrip.Text = Dte.Rows(recno).Item("tur_descrip").ToString
                txtTurnoHoriario.Text = Dte.Rows(recno).Item("tur_horario").ToString

                txtEmpresaDesc.Text = Dte.Rows(recno).Item("pro_titular").ToString
                txtEmpresaID.Text = Dte.Rows(recno).Item("pro_id").ToString
                TxtProceso.Text = Dte.Rows(recno).Item("proc_descripcion").ToString
                txtPeriodo.Text = Dte.Rows(recno).Item("f02_periodo").ToString

                habilitar_botones_desplazamiento()
                btnNuevo.Enabled = True
                btnModificar.Enabled = True
                btnGuardar.Enabled = False
                btnDeshacer.Enabled = False
                estado_botones_items()
                btnSalir.Enabled = True
            Else
                deshabilitar_botones_desplazamiento()
                ocultar_columnas()
                btnNuevo.Enabled = True
                btnModificar.Enabled = False
                btnGuardar.Enabled = False
                btnDeshacer.Enabled = False
                estado_botones_items()
                btnSalir.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Private Sub limpiar()

        TxtId.Text = ""
        txtNroDoc.Text = ""
        txtFecha.Text = ""
        chkCertificada.CheckState = CheckState.Unchecked
        txtObservacion.Text = ""
        txtPeriodo.Text = ""
        TxtProceso.Text = ""
        txtResponsableCargo.Text = ""
        txtResponsableId.Text = ""
        txtResponsableNombre.Text = ""
        txtNroOpe.Text = ""
        txtTurno_Id.Text = ""
        txtTurnoDescrip.Text = ""
        txtTurnoHoriario.Text = ""
        txtEmpresaDesc.Text = ""
        txtEmpresaID.Text = ""
        txtPeriodo.Text = DateTime.Now.Year
    End Sub

    Private Sub siguientecontrol()
        SendKeys.Send("{TAB}")
    End Sub

    Private Sub validar_campos()

        'Preguntamos si los controles estan vacios, para enviar el mensaje

    End Sub

    Private Sub DataDetalle_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataDetalle.CellClick
        registro_seleccionado()
    End Sub

    Private Sub dataDetalle_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataDetalle.CellContentClick
        If e.ColumnIndex = Me.DataDetalle.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.DataDetalle.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
            If chkcell.Value = True Then
                xreg += 1
            Else
                xreg -= 1
            End If
            If xreg <> 0 Then
                btnEliminar.Enabled = True
                btnEditar.Enabled = True
            Else
                btnEliminar.Enabled = False
                btnEditar.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
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
                        Dim dts As New vFormato02
                        Dim func As New fformato02

                        dts.gf02_nrodoc = txtNroDoc.Text
                        dts.gf02_fecha = txtFecha.Text
                        dts.gf02_certificada = chkCertificada.CheckState
                        dts.gf02_observacion = txtObservacion.Text
                        dts.gf02_responsableid = txtResponsableId.Text
                        dts.gf02_nroope = txtNroOpe.Text
                        dts.gf02_turnoid = txtTurno_Id.Text
                        dts.gf02_proc_id = Proc_id
                        dts.gf02_periodo = txtPeriodo.Text
                        dts.gf02_emp_id = txtEmpresaID.Text
                        'dts.fldLote = txLote.Text
                        'Codigo para insertar registros
                        If nuevo = True Then
                            If func.insertar(dts) Then
                                MessageBox.Show("Datos guardados correctamente...!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                limpiar()
                                mostrar_encabezado()
                                Deshabilitar_datos()
                                btnNuevo.Enabled = True
                                btnModificar.Enabled = True
                                btnGuardar.Enabled = False
                                btnDeshacer.Enabled = False
                                btnEliminarGuia.Enabled = True
                                btnSalir.Enabled = True
                                chkEliminar.Enabled = False
                                btnEliminar.Enabled = False
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
                            dts.gf02_id = TxtId.Text
                            If func.editar(dts) Then
                                MessageBox.Show("Datos editados correctamente...!", "Editando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                limpiar()
                                mostrar_encabezado()
                                Deshabilitar_datos()
                                btnNuevo.Enabled = True
                                btnModificar.Enabled = True
                                btnGuardar.Enabled = False
                                btnDeshacer.Enabled = False
                                btnSalir.Enabled = True
                                btnEliminarGuia.Enabled = True
                                chkEliminar.Enabled = False
                                btnEliminar.Enabled = False
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

    Function optener_siguiente_numero_lista()
        Dim ulpos As Integer
        Dim numero, ultimo, numstring, siguiente As String
        ulpos = Dte.Rows.Count - 1
        If ulpos <> -1 Then
            ultimo = Dte.Rows(ulpos).Item("f02_nrodoc").ToString()
            numero = Convert.ToInt32(Mid(ultimo, 5, 6) + 1)
        Else
            numero = 1
        End If
        numstring = Microsoft.VisualBasic.Right("000000" + numero, 6)
        siguiente = numstring
        Return siguiente
    End Function

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Habilitar_datos()
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnDeshacer.Enabled = True
        btnSalir.Enabled = False
        btnEliminarGuia.Enabled = False

        'Botones del Detalle
        deshabilitar_botones_desplazamiento()
        estado_botones_items()

        limpiar()
        DataDetalle.DataSource = Nothing
        dataResumen.DataSource = Nothing
        nuevo = True
        modificar = False
        txtNroDoc.Text = optener_siguiente_numero_lista()
        'gbConcesion.BackColor = Color.Khaki
    End Sub

    Private Sub formatear_grid()

        If Dtdm.Rows.Count <> 0 Then
            'Quitando lo necesario
            DataDetalle.AllowUserToResizeRows = False
            DataDetalle.RowHeadersVisible = False

            'Modificando el ancho de las columnas
            DataDetalle.Columns.Item(1).Width = 30 'Item
            DataDetalle.Columns.Item(2).Width = 30 'F02d_Id
            DataDetalle.Columns.Item(3).Width = 150 'F02d_F02_Id
            DataDetalle.Columns.Item(4).Width = 60 'Codificacion
            DataDetalle.Columns.Item(5).Width = 60 'Cod Industria
            DataDetalle.Columns.Item(6).Width = 120 'Cut
            DataDetalle.Columns.Item(7).Width = 140 'Especie
            DataDetalle.Columns.Item(8).Width = 60 'D1
            DataDetalle.Columns.Item(9).Width = 60 'D2
            DataDetalle.Columns.Item(10).Width = 60 'D3
            DataDetalle.Columns.Item(11).Width = 60 'Volm3
            DataDetalle.Columns.Item(12).Width = 110 'Obs

            'Ocultando algunas columnas
            DataDetalle.Columns.Item(2).Visible = False
            DataDetalle.Columns.Item(3).Visible = False
            DataDetalle.Columns.Item(12).Visible = False

            'Cambiando el texto de las cabeceras
            DataDetalle.Columns(1).HeaderText = "Item"
            DataDetalle.Columns(2).HeaderText = "Id"
            DataDetalle.Columns(3).HeaderText = "Formato02 Id"
            DataDetalle.Columns(4).HeaderText = "Cod. Bosque"
            DataDetalle.Columns(5).HeaderText = "Cod. Industria"
            DataDetalle.Columns(6).HeaderText = "Cut"
            DataDetalle.Columns(7).HeaderText = "Especie"
            DataDetalle.Columns(8).HeaderText = "DM>(cm.)"
            DataDetalle.Columns(9).HeaderText = "Dm<(cm.)"
            DataDetalle.Columns(10).HeaderText = "Largo"
            DataDetalle.Columns(11).HeaderText = "Vol. M3"
            'AQUI AGREGAR.
            DataDetalle.Columns(12).HeaderText = "DMc>(cm.)"
            DataDetalle.Columns(13).HeaderText = "Dmc<(cm.)"
            DataDetalle.Columns(14).HeaderText = "Largoc"
            DataDetalle.Columns(15).HeaderText = "Vol. M3c"
            DataDetalle.Columns(16).HeaderText = "D In."
            DataDetalle.Columns(17).HeaderText = "Largo Ft."
            DataDetalle.Columns(18).HeaderText = "Vol. Pt"

            DataDetalle.Columns(19).HeaderText = "Observacion"

            DataDetalle.Columns.Item(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataDetalle.Columns.Item(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataDetalle.Columns.Item(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataDetalle.Columns.Item(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

            'Centrando todas las columnas del DataGridView
            DataDetalle.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            DataDetalle.Columns.Item(8).DefaultCellStyle.Format = "#0.#0"
            DataDetalle.Columns.Item(9).DefaultCellStyle.Format = "#0.#0"
            DataDetalle.Columns.Item(10).DefaultCellStyle.Format = "#0.#0"
            DataDetalle.Columns.Item(11).DefaultCellStyle.Format = "#0.#00"

            DataDetalle.Columns.Item(12).DefaultCellStyle.Format = "#0.#0"
            DataDetalle.Columns.Item(13).DefaultCellStyle.Format = "#0.#0"
            DataDetalle.Columns.Item(14).DefaultCellStyle.Format = "#0.#0"
            DataDetalle.Columns.Item(15).DefaultCellStyle.Format = "#0.#00"
            DataDetalle.Columns.Item(16).DefaultCellStyle.Format = "#0.#0"
            DataDetalle.Columns.Item(17).DefaultCellStyle.Format = "#0.#0"
            DataDetalle.Columns.Item(18).DefaultCellStyle.Format = "#0.#00"

            'Centrando todos los Encabezados de las columnas del DataGridView
            DataDetalle.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ocultar_columnas()
            sumar_volumenytrozas()
        End If
        ocultar_columnas()
    End Sub

    Private Sub ocultar_columnas()
        DataDetalle.Columns.Item("Eliminar").Visible = False
    End Sub

    Private Sub btnAgregarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarItem.Click
        If String.IsNullOrEmpty(TxtId.Text) = True Then
            MessageBox.Show("No hay datos de Encabezado", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        nuevoItem = True

        Dim wfDetalle As New frmFormato02_det
        wfDetalle.xRowpapa = TxtId.Text
        'wfDetalle.xLote = txLote.Text
        wfDetalle.xPeriodo = txtPeriodo.Text
        wfDetalle.aserrio = txtEmpresaID.Text

        'Formulario para ingreso Troza por troza
        'Dim reg As Integer = Dtdm.Rows.Count 'Contamos 

        'frmDetalle.txF02dId.Text = reg + 1
        'frmDetalle.txtbuscar.Focus()
        'frmDetalle.xExiste = False
        'frmDetalle.RowPapa = TxtId.Text
        wfDetalle.ShowDialog(Me) 'Mostramos el Formulario FrmDetalle
    End Sub

    Private Sub btnSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSig.Click
        recno += 1
        If recno <= (nreg - 1) Then
            mostrar_encabezado()
            mostrar_detalle(TxtId.Text)
            mostrar_resumen()
            formatear_grid()
            estado_botones_items()
        Else
            recno = nreg - 1
        End If
    End Sub

    Private Sub btnAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnt.Click
        recno -= 1
        If recno >= 0 Then
            mostrar_encabezado()
            mostrar_detalle(TxtId.Text)
            mostrar_resumen()
            formatear_grid()
            estado_botones_items()
        Else
            recno = 0
        End If
    End Sub

    Private Sub btnPri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPri.Click
        recno = 0
        mostrar_encabezado()
        mostrar_detalle(TxtId.Text)
        mostrar_resumen()
        formatear_grid()
        estado_botones_items()
    End Sub

    Private Sub btnUlt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUlt.Click
        recno = nreg - 1
        mostrar_encabezado()
        mostrar_detalle(TxtId.Text)
        mostrar_resumen()
        formatear_grid()
        estado_botones_items()
    End Sub

    Private Sub sumar_volumenytrozas()
        Try

            Dim totVolm3 As Decimal = Dtdm.Compute("Sum(f02d_volm3)", Nothing)
            Dim totVolm3c As Decimal = Dtdm.Compute("sum(f02d_volm3c)", Nothing)
            Dim totVolpt As Decimal = Dtdm.Compute("sum(f02d_vol_pt)", Nothing)
            If nregd <> 0 Then
                txtTotVolm3.Text = totVolm3
                txtTotVolm3c.Text = totVolm3c
                txtTotVolPt.Text = totVolpt

                Dim totTrozas As Integer = Dtdm.Rows.Count
                txtTrozas.Text = totTrozas
            Else
                txtTotVolm3.Text = ""
                txtTotVolm3c.Text = ""
                txtTotVolPt.Text = ""

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mostrar_detalle(ByVal registro As Integer)
        Try
            Dim dtl As New vFormato02_det
            Dim func As New fformato02_det 'Creacion una variable para hacer referencia a la funcion fconcesiones

            dtl.gf02d_f02_id = registro

            Dtdm = func.mostrar(dtl) 'Invocamos a la funcion mostrar()
            DataDetalle.Columns.Item("Eliminar").Visible = False 'Ocultamos la Columna Eliminar
            nregd = Dtdm.Rows.Count 'Almacenamos la cantidad de filas o registros recuperados

            If nregd <> 0 Then 'Si las filas al contarlas es diferente de cero
                DataDetalle.DataSource = Dtdm
                DataDetalle.ColumnHeadersVisible = True
                formatear_grid()

                registro_seleccionado()
                sumar_volumenytrozas()
                ocultar_columnas()

            Else
                DataDetalle.DataSource = Nothing
                DataDetalle.ColumnHeadersVisible = False
                txtTrozas.Text = ""
                txtTotVolm3c.Text = ""
                limpiar_campos_detalle()
            End If
            estado_botones_items()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeshacer.Click

        recno = recno
        mostrar_encabezado()
        Deshabilitar_datos()
        mostrar_detalle(IIf(TxtId.Text <> "", TxtId.Text, 0))
        If TxtId.Text <> "" Then
            mostrar_resumen()
            formatear_grid()
        Else
            txtNroDoc.Text = ""
        End If
        habilitar_botones_desplazamiento()
        'limpiar()
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnGuardar.Enabled = False
        btnDeshacer.Enabled = False
        btnAgregarItem.Enabled = False
        btnEliminarGuia.Enabled = True
        btnSalir.Enabled = True

        habilitar_botones_desplazamiento()
        btnAgregarItem.Enabled = True
        btnEditar.Enabled = True
        chkEliminar.Enabled = True
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Habilitar_datos()

        btnSalir.Enabled = False
        btnAgregarItem.Enabled = True
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnDeshacer.Enabled = True

        deshabilitar_botones_desplazamiento()
        btnAgregarItem.Enabled = False
        btnEditar.Enabled = False

        chkEliminar.Enabled = False
        nuevo = False
        modificar = True
    End Sub

    Private Sub chkEliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEliminar.Click, chkEliminar.CheckedChanged
        If chkEliminar.CheckState = CheckState.Checked Then
            DataDetalle.Columns.Item("Eliminar").Visible = True
            DataDetalle.Columns.Item("Eliminar").Width = 20
            DataDetalle.Columns.Item("Eliminar").HeaderText = ""
            chkSeleccAll.Visible = True
        Else
            DataDetalle.Columns.Item("Eliminar").Visible = False
            chkSeleccAll.Visible = False
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim result As DialogResult
        result = MessageBox.Show("Esta seguro de ELIMINAR " & xreg & " registro(s) seleccionado(s)...?", "Eliminar registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In DataDetalle.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then

                        Dim onekey As Integer = Convert.ToInt32(row.Cells("f02d_id").Value)
                        Dim cutt As String = row.Cells("f02d_cut").Value.ToString()
                        'Dim codtroza As String = row.Cells("").Value.ToString()

                        Dim vdb As New vFormato02_det
                        Dim func As New fformato02_det

                        vdb.gf02d_id = onekey
                        Dim db As New samadEntities
                        Dim entrada = db.formato04_det.FirstOrDefault(Function(p) p.F04d_Cut = cutt)
                        If entrada Is Nothing Then
                            If func.eliminar(vdb) Then
                                HabilitarTrozaConsumida(cutt)
                            Else
                                MessageBox.Show("Registro NO fue eliminado", "Eliminar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            MessageBox.Show("El registro se utilizo al menos una vez en el modulo de PRODUCCIÒN DE ASERRIO, No se puede Eliminar", "Eliminar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    End If
                Next
                mostrar_detalle(TxtId.Text)
                mostrar_resumen()
                formatear_grid()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub HabilitarTrozaConsumida(ByVal trozaConsumo As String)
        Dim dm As New samadEntities
        Dim xListat As formato01_det = dm.formato01_det.First(Function(x) x.F01d_Autogenerado = trozaConsumo)
        xListat.Estatus = 0
        dm.SaveChanges()
    End Sub

    Private Sub buscar_nrolista()
        Dim func As New flistatrozasc 'Creacion una variable para hacer referencia a la funcion flistatrozasd
        Dtb = func.mostrar 'Invocamos a la funcion mostrar()

        Dim busnrolista As String
        Dim foundRows() As Data.DataRow

        busnrolista = String.Format("lt_nrolista = '{0}'", txtNroDoc.Text)

        foundRows = Dtb.Select(busnrolista)
        If UBound(foundRows) = False Then
            MessageBox.Show("Este número de lista ya existe, Vuelva a Ingresar...!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnBuscarGtfs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarNros.Click
        'Enviamos los datos de la consulta sql

        Dim busqueda As New frmFormato02Busqueda

        busqueda.ShowDialog(Me)

        'Datos del Vehiculo
        If busqueda.flag = True Then
            recno = busqueda.matColumnas(0)
            If recno <> 0 Then
                Dim valor As Integer = -1
                Dim index As Integer = 0
                Do While valor <> recno
                    valor = Dte.Rows(index).Item("f02_id")
                    index += 1
                Loop
                recno = index - 1

                mostrar_encabezado()
                Deshabilitar_datos()
                mostrar_detalle(TxtId.Text)
                mostrar_resumen()
                formatear_grid()
            End If
        End If
    End Sub

    Private Sub mostrar_resumen()
        Try

            Dim col As Integer
            Dim dtsr As New vShowbrow
            Dim func As New fshowbrow

            dtsr.gt_tabla = "formato02_det"
            dtsr.gt_campos = "f02d_especie as Especie,count(f02d_especie) as Trozas,sum(f02d_volm3) as Volm3"
            dtsr.gt_donde = "f02d_f02_id =" + TxtId.Text
            dtsr.gt_agruparpor = "f02d_especie"
            dtsr.gt_ordenarpor = ""

            Dt = func.mostrar(dtsr) 'Invocamos a la funcion mostrar()

            If Dt.Rows.Count <> -1 Then 'Si las filas al contarlas es diferente de cero
                col = Dt.Columns.Count
                dataResumen.AllowUserToResizeRows = False
                dataResumen.RowHeadersVisible = False
                dataResumen.DataSource = Dt
                'Formateando las columnas
                dataResumen.Columns.Item(0).Width = 120
                dataResumen.Columns.Item(1).Width = 40
                dataResumen.Columns.Item(2).Width = 60

                dataResumen.Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                dataResumen.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

                dataResumen.ColumnHeadersVisible = True
                dataResumen.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Else
                dataResumen.DataSource = Nothing
                dataResumen.ColumnHeadersVisible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        nuevoItem = True

        Dim frmDetalle As New frmFormato02_det

        Dim reg As Integer = Dtdm.Rows.Count 'Contamos 
        frmDetalle.xExiste = True
        frmDetalle.ShowDialog(Me) 'Mostramos el Formulario FrmDetalle

    End Sub

    Private Sub registro_seleccionado()
        If nregd <> 0 Then
            TxtObservaDetalle.Text = DataDetalle.SelectedCells.Item(11).Value
        End If
    End Sub

    Private Sub estado_botones_items()
        If nregd <> 0 Then
            btnAgregarItem.Enabled = True
            btnEditar.Enabled = True
            btnEliminar.Enabled = False
            chkEliminar.Enabled = True
        Else
            btnAgregarItem.Enabled = True
            btnEditar.Enabled = False
            btnEliminar.Enabled = False
            chkEliminar.Enabled = False
        End If
    End Sub

    Private Sub limpiar_campos_detalle()
        TxtObservaDetalle.Text = ""
    End Sub

    Private Sub lblResponsable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblResponsable.Click
        Dim frmResponsable As New frmPersonal
        frmResponsable.ShowDialog(Me)
    End Sub

    Private Sub frmFormato02_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Setup()
    End Sub

    Private Sub Setup()
        recno = nreg
        mostrar_encabezado()
        Deshabilitar_datos()
        mostrar_detalle(IIf(TxtId.Text <> "", TxtId.Text, 0))
        If TxtId.Text <> "" Then
            mostrar_resumen()
            formatear_grid()
        End If
        btnUlt.PerformClick()
        AplicarPerfil()

    End Sub

    Private Sub btnEliminarGuia_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarGuia.Click
        Try
            If String.IsNullOrEmpty(TxtId.Text) = True Then
                MessageBox.Show("No hay informacopn para borrar", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim result = MessageBox.Show("¿Esta seguro de Eliminar el Documento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                Dim db As New samadEntities
                Dim entry = db.formato02.FirstOrDefault(Function(p) p.F02_Id = TxtId.Text)
                db.formato02.DeleteObject(entry)
                db.SaveChanges()
                fauditoria.insertar("formato02", "Eliminar", TxtId.Text, "")
                MessageBox.Show("Se Elimino con Éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
                Setup()
            End If
        Catch ex As Exception
            MessageBox.Show("Asegurese que el documento no tenga Items, \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkSeleccAll_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSeleccAll.CheckedChanged
        If chkSeleccAll.CheckState = CheckState.Checked Then
            For Each row As DataGridViewRow In DataDetalle.Rows
                row.Cells("Eliminar").Value = True
            Next
            btnEliminar.Enabled = True
        Else
            For Each row As DataGridViewRow In DataDetalle.Rows
                row.Cells("Eliminar").Value = False
            Next
            btnEliminar.Enabled = False

        End If
    End Sub

    Private Sub btUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btUpdate.Click
        ListarInfo()
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Dim wfEmergente As New frmTitulares
        wfEmergente.ShowDialog(Me)
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click
        Dim wfEmergente As New frmProcesos
        wfEmergente.ShowDialog(Me)
    End Sub

    Private Sub txtFecha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtFecha.ValueChanged
        txtPeriodo.Text = Year(txtFecha.Text)
        'txLote.Text = New fxSamad().StrCeros(New cdFormato01().NumeroLote(txtPeriodo.Text), 6, True)
    End Sub

    Private Sub txtNroOpe_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNroOpe.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                txtTurnoHoriario.Focus()
            Case Keys.Tab, Keys.Enter
                e.Handled = True
                If String.IsNullOrEmpty(txtNroOpe.Text) = True Then
                    MessageBox.Show("Por favor ingrese número de orden de produccion", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtNroOpe.Focus()
                    Exit Sub
                End If
                If IsNumeric(txtNroOpe.Text) = True Then
                    txtNroOpe.Text = Microsoft.VisualBasic.Right("00000" + txtNroOpe.Text, 5)
                End If
                txtTurnoHoriario.Focus()
        End Select
    End Sub

    Private Sub txtEmpresaDesc_ButtonCustomClick(sender As System.Object, e As System.EventArgs) Handles txtEmpresaDesc.ButtonCustomClick
        'Enviamos los datos de la consulta sql
        frm.titulo = "Lista de Empresas de Aserrío"
        frm.t_tabla = "vw_empresas_aserrios"
        frm.t_campos = "Pro_id,Pro_Titular"
        frm.t_donde = ""
        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Descripcion"}
        Dim anchos() As Integer = {30, 200}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)
        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog(Me)

        'Datos del Titular
        If frm.flag = True Then
            txtEmpresaDesc.Text = frm.matColumnas(1)
            txtEmpresaID.Text = frm.matColumnas(0)
            Pro_id = frm.matColumnas(0)

            TxtProceso.Text = ""
            Proc_id = 0
        End If
    End Sub

    Private Sub TxtProcesos_ButtonCustomClick(sender As System.Object, e As System.EventArgs) Handles TxtProceso.ButtonCustomClick
        'Enviamos los datos de la consulta sql
        frm.titulo = "Lista del Procesos"
        frm.t_tabla = "procesos"
        frm.t_campos = "Proc_id,Proc_descripcion,pro_id"
        frm.t_donde = String.Format("pro_id = {0}", txtEmpresaID.Text)
        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Descripción"}
        Dim anchos() As Integer = {30, 200, 90}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)
        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog(Me)

        'Datos del Titular
        If frm.flag = True Then
            TxtProceso.Text = frm.matColumnas(1)
            Proc_id = frm.matColumnas(0)
        End If
    End Sub

    Private Sub txtResponsableCargo_ButtonCustomClick(sender As System.Object, e As System.EventArgs) Handles txtResponsableCargo.ButtonCustomClick

        'Enviamos los datos de la consulta sql
        frm.titulo = "Lista del Personal"
        frm.t_tabla = "personal"
        frm.t_campos = "per_id,per_nomape,per_cargo"
        frm.t_donde = ""
        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Nombres y Apellidos", "Cargo"}
        Dim anchos() As Integer = {30, 200, 90}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)
        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog(Me)

        'Datos del Titular
        If frm.flag = True Then
            txtResponsableId.Text = frm.matColumnas(0)
            txtResponsableNombre.Text = frm.matColumnas(1)
            txtResponsableCargo.Text = frm.matColumnas(2)
        End If
    End Sub

    Private Sub txtTurnoHoriario_ButtonCustomClick(sender As System.Object, e As System.EventArgs) Handles txtTurnoHoriario.ButtonCustomClick
        'Enviamos los datos de la consulta sql
        frmtur.titulo = "Lista de Turnos"
        frmtur.t_tabla = "turnos"
        frmtur.t_campos = "tur_id,tur_descrip,tur_horario"
        frmtur.t_donde = ""
        frmtur.t_agruparpor = ""
        frmtur.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Turno", "Horario"}
        Dim anchos() As Integer = {30, 100, 150}

        ReDim frmtur.matAnchos(anchos.Length)
        ReDim frmtur.matTitulos(titulos.Length)
        ReDim frmtur.matColumnas(titulos.Length)
        titulos.CopyTo(frmtur.matTitulos, 0)
        anchos.CopyTo(frmtur.matAnchos, 0)

        frmtur.ShowDialog(Me)

        'Datos del Titular
        If frmtur.flag = True Then
            txtTurno_Id.Text = frmtur.matColumnas(0)
            txtTurnoDescrip.Text = frmtur.matColumnas(1)
            txtTurnoHoriario.Text = frmtur.matColumnas(2)
        End If
    End Sub

    Private Sub txtEmpresaDesc_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEmpresaDesc.TextChanged

    End Sub
End Class