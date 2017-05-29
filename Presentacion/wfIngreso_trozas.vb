Public Class wfIngreso_trozas

    Dim Dt, Dtd, Dtdm, Dte, Dtb As New DataTable
    Dim func As New fformato01 'Creacion una variable para hacer referencia a la funcion fconcesiones
    Dim nreg, nregd, xreg, recno As Integer
    Dim sw_guardar As Boolean = False
    Dim sw_guardard As Boolean = False
    Dim nuevo As Boolean = False
    Public nuevoItem As Boolean = False
    Dim modificar As Boolean = False
    Dim modificarItem As Boolean = False
    Dim msg As String = ""
    Dim frm, frmtitu, frmbuscardoc As New frmShowbrow
    Private _left As String

    Dim xTitulo = fxSamad.Titulo

#Region "Funciones y Procedimientos locales "

    Private Sub mostrar_detalle(ByVal registro As Integer)
        Try
            Dim dtl As New vFormato01_det
            Dim func As New fformato01_det 'Creacion una variable para hacer referencia a la funcion fconcesiones
            dtl.gf01d_f01_id = registro
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
                txtTotalVolm3.Text = ""
                txttotalvolm3c.Text = ""
                limpiar_campos_detalle()
            End If
            estado_botones_items()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mostrar_resumen()
        Try
            Dim col As Integer
            Dim dtsr As New vShowbrow
            Dim func As New fshowbrow
            dtsr.gt_tabla = "formato01_det"
            dtsr.gt_campos = "f01d_especie as Especie,count(f01d_especie) as Trozas,sum(f01d_vol_m3) as Volm3"
            dtsr.gt_donde = IIf(txId.Text <> "", String.Format("f01d_f01_id = {0}", txId.Text), "")
            dtsr.gt_agruparpor = "f01d_especie"
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

#End Region
    Private Sub Deshabilitar_datos()

        txId.Enabled = False 'Id del Encabezado
        txFecha.Enabled = False 'Fecha del Encabezado
        txObservacion.Enabled = False
        chkCertificada.Enabled = False
        btnResponsable.Enabled = False
        btnTitular.Enabled = False
        cbTraslado.Enabled = False
        txPeriodo.Enabled = False
    End Sub

    Private Sub AplicarPerfil()
        If vInfraestructura.Usuario.gtipo = "ADMINISTRADOR" Then

        Else
            Panel3.Enabled = False
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub Habilitar_datos()

        txId.Enabled = False 'Id del Encabezado
        txFecha.Enabled = True 'Fecha del Encabezado
        txObservacion.Enabled = True
        chkCertificada.Enabled = True
        btnResponsable.Enabled = True
        btnTitular.Enabled = True
        cbTraslado.Enabled = True
        txPeriodo.Enabled = True
    End Sub

    Private Sub mostrar_encabezado()
        Try

            Dim func As New fformato01 'Creacion una variable para hacer referencia a la funcion flistatrozasd
            Dte = func.mostrar 'Invocamos a la funcion mostrar()

            nreg = Dte.Rows.Count 'Almacenamos la cantidad de filas o registros recuperados

            If nreg <> 0 Then

                txId.Text = Dte.Rows(recno).Item("f01_id").ToString
                txNumero.Text = Dte.Rows(recno).Item("f01_nro").ToString
                txFecha.Text = Dte.Rows(recno).Item("f01_fecha").ToString
                chkCertificada.CheckState = Dte.Rows(recno).Item("f01_certificada").ToString
                txObservacion.Text = Dte.Rows(recno).Item("f01_observacion").ToString
                txtResponsableId.Text = Dte.Rows(recno).Item("f01_responsableid").ToString
                txtResponsableNombre.Text = Dte.Rows(recno).Item("per_nomape").ToString
                txtResponsableCargo.Text = Dte.Rows(recno).Item("per_cargo").ToString
                cbTraslado.Text = Dte.Rows(recno).Item("F01_tipotraslado").ToString
                txTitularId.Text = Dte.Rows(recno).Item("pro_id").ToString
                txtTitular.Text = Dte.Rows(recno).Item("pro_titular").ToString
                txPeriodo.Text = Dte.Rows(recno).Item("f01_periodo").ToString

                habilitar_botones_desplazamiento()
                btnNuevo.Enabled = True
                btnModificar.Enabled = True
                btnGuardar.Enabled = False
                btnDeshacer.Enabled = False
                btnAgregarItem.Enabled = False
                btnSalir.Enabled = True

                If cbTraslado.Text = "FLUVIAL" Then
                    rbFluvial.Enabled = True
                    rbFluvial.Checked = True
                    rbTerrestre.Enabled = False
                Else
                    If cbTraslado.Text = "TERRESTRE" Then
                        rbTerrestre.Enabled = True
                        rbTerrestre.Checked = True
                        rbFluvial.Enabled = False
                    Else
                        rbFluvial.Enabled = True
                        rbFluvial.Checked = True
                        rbTerrestre.Enabled = True
                        rbTerrestre.Checked = False
                    End If
                End If

            Else
                deshabilitar_botones_desplazamiento()
                btnNuevo.Enabled = True
                btnModificar.Enabled = False
                btnGuardar.Enabled = False
                btnDeshacer.Enabled = False
                btnAgregarItem.Enabled = False
                btnSalir.Enabled = True
                ocultar_columnas()
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

        txId.Text = ""
        txNumero.Text = ""
        txFecha.Text = ""
        chkCertificada.CheckState = CheckState.Unchecked
        txObservacion.Text = ""
        txtResponsableCargo.Text = ""
        txtResponsableId.Text = ""
        txtResponsableNombre.Text = ""
        txTitularId.Text = ""
        txtTitular.Text = ""
        txPeriodo.Text = DateTime.Now.Year
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
                        'Dim dts As New vFormato01
                        'Dim func As New fformato01
                        'dts.gf01_nro = txtNro.Text
                        'dts.gf01_fecha = txtFecha.Text
                        'dts.gf01_certificada = chkCertificada.CheckState
                        'dts.gf01_observacion = txtObservacion.Text
                        'dts.gf01_responsable = txtResponsableId.Text
                        'dts.gf01_titular = txtTituId.Text
                        'dts.gf01_tipotraslado = cmbTraslado.Text
                        'dts.gf01_periodo = txtPeriodo.Text

                        Dim dt As New SAMAD.formato01
                        dt.F01_Nro = txNumero.Text
                        dt.F01_Fecha = txFecha.Text
                        dt.F01_Certificada = chkCertificada.CheckState
                        dt.F01_ResponsableId = CInt(txtResponsableId.Text)
                        dt.F01_TipoTraslado = cbTraslado.Text
                        dt.F01_Observacion = txObservacion.Text
                        dt.F01_Pro_id = CInt(txTitularId.Text)
                        dt.F01_periodo = txPeriodo.Text
                        'dt.F01_Lote = txLote.Text
                        'Codigo para insertar registros
                        If nuevo = True Then
                            If New cdFormato01().Formato01Grabar(dt) = True Then
                                MessageBox.Show("Datos guardados correctamente...!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                limpiar()
                                mostrar_encabezado()
                                Deshabilitar_datos()
                                btnNuevo.Enabled = True
                                btnModificar.Enabled = True
                                btnGuardar.Enabled = False
                                btnDeshacer.Enabled = False
                                btnDeshacer.Enabled = False
                                btnSalir.Enabled = True
                                btnEliminarGuia.Enabled = True
                                chkEliminar.Enabled = False
                                btnEliminar.Enabled = False
                                estado_botones_items()
                                btnUlt.PerformClick()
                            Else
                                MessageBox.Show("Datos No fueron registrados, intente de nuevo!!!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                mostrar_encabezado()
                                limpiar()
                            End If
                        ElseIf modificar = True Then
                            dt.F01_id = CInt(txId.Text)
                            If New cdFormato01().Formato01Editar(dt) = True Then
                                MessageBox.Show("Datos editados correctamente...!", "Editando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                limpiar()
                                mostrar_encabezado()
                                Deshabilitar_datos()
                                btnNuevo.Enabled = True
                                btnModificar.Enabled = True
                                btnGuardar.Enabled = False
                                btnDeshacer.Enabled = False
                                btnSalir.Enabled = True
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
            ultimo = Dte.Rows(ulpos).Item("f01_nro").ToString()
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
        btnEliminarGuia.Enabled = False
        btnDeshacer.Enabled = True
        btnSalir.Enabled = False
        limpiar()
        cbTraslado.SelectedIndex = 0
        DataDetalle.DataSource = Nothing
        dataResumen.DataSource = Nothing
        nuevo = True
        modificar = False
        txNumero.Text = optener_siguiente_numero_lista()
        'gbConcesion.BackColor = Color.Khaki
    End Sub

    Private Sub btnResponsable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResponsable.Click

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

    Private Sub frmFormato01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Setup()
    End Sub

    Private Sub Setup()
        recno = nreg
        mostrar_encabezado()
        Deshabilitar_datos()
        AplicarPerfil()

        mostrar_detalle(IIf(txId.Text <> "", txId.Text, 0))

        If txId.Text <> "" Then
            mostrar_resumen()
            formatear_grid()
        End If
        btnUlt.PerformClick()
    End Sub

    Private Sub formatear_grid()

        If Dtdm.Rows.Count <> 0 Then
            'Quitando lo necesario
            DataDetalle.AllowUserToResizeRows = False
            DataDetalle.RowHeadersVisible = False

            'Modificando el ancho de las columnas
            DataDetalle.Columns.Item(1).Width = 30 'Item
            DataDetalle.Columns.Item(2).Width = 30 'Id
            DataDetalle.Columns.Item(3).Width = 30 'F01d_F01_Id
            DataDetalle.Columns.Item(4).Width = 70 'Nro Lote
            DataDetalle.Columns.Item(5).Width = 70 'Nro Gtf
            DataDetalle.Columns.Item(6).Width = 70 'Nro Lista Trozas
            DataDetalle.Columns.Item(7).Width = 60 'Codigo Bosque
            DataDetalle.Columns.Item(8).Width = 60 'Codigo Induatria
            DataDetalle.Columns.Item(9).Width = 170 'Especie Gtf
            DataDetalle.Columns.Item(10).Width = 50 'DM (cm.)
            DataDetalle.Columns.Item(11).Width = 50 'Dm (cm.)
            DataDetalle.Columns.Item(12).Width = 50 'Largo (m.)
            DataDetalle.Columns.Item(13).Width = 50 'Vol._m3
            DataDetalle.Columns.Item(14).Width = 170 'Especie Ind.
            DataDetalle.Columns.Item(15).Width = 50 'DMc (cm.)
            DataDetalle.Columns.Item(16).Width = 50 'Dmc (cm.)
            DataDetalle.Columns.Item(17).Width = 50 'Largoc (m.)
            DataDetalle.Columns.Item(18).Width = 50 'Vol._m3c
            DataDetalle.Columns.Item(19).Width = 50 'Dm (in)
            DataDetalle.Columns.Item(20).Width = 50 'Largo (ft)
            DataDetalle.Columns.Item(21).Width = 50 'Vol. Pt
            DataDetalle.Columns.Item(22).Width = 120 'Procedencia
            DataDetalle.Columns.Item(23).Width = 80 'Abast_Propietario
            DataDetalle.Columns.Item(24).Width = 50 'Propietario
            DataDetalle.Columns.Item(25).Width = 90 'Nom_Patio
            DataDetalle.Columns.Item(26).Width = 70 'Nro_Guia_remision
            DataDetalle.Columns.Item(27).Width = 50 'Emp_Transp
            DataDetalle.Columns.Item(28).Width = 90 'Placa_Veh
            DataDetalle.Columns.Item(29).Width = 90 'Conductor
            DataDetalle.Columns.Item(30).Width = 90 'Utilizado_f04_Id
            DataDetalle.Columns.Item(31).Width = 90 'Tipo
            DataDetalle.Columns.Item(32).Width = 90 'Tipo_calculo
            DataDetalle.Columns.Item(33).Width = 90 'Calidad
            DataDetalle.Columns.Item(34).Width = 90 'F02_id
            DataDetalle.Columns.Item(35).Width = 160 'Observacion
            DataDetalle.Columns.Item(36).Width = 90 'Periodo
            DataDetalle.Columns.Item(37).Width = 50 'Autogenerado
            DataDetalle.Columns.Item(38).Width = 50 'Estatus


            'Ocultando algunas columnas
            DataDetalle.Columns.Item(2).Visible = False
            DataDetalle.Columns.Item(3).Visible = False
            DataDetalle.Columns.Item(22).Visible = False
            DataDetalle.Columns.Item(24).Visible = False
            DataDetalle.Columns.Item(25).Visible = False
            DataDetalle.Columns.Item(26).Visible = False
            DataDetalle.Columns.Item(27).Visible = False
            DataDetalle.Columns.Item(28).Visible = False
            DataDetalle.Columns.Item(29).Visible = False
            DataDetalle.Columns.Item(30).Visible = False
            DataDetalle.Columns.Item(31).Visible = False
            DataDetalle.Columns.Item(32).Visible = False
            DataDetalle.Columns.Item(33).Visible = False
            DataDetalle.Columns.Item(34).Visible = False
            DataDetalle.Columns.Item(36).Visible = False
            DataDetalle.Columns.Item(37).Visible = False
            DataDetalle.Columns.Item(38).Visible = False



            'Cambiando el texto de las cabeceras
            DataDetalle.Columns.Item(1).HeaderText = "Item"
            DataDetalle.Columns.Item(2).HeaderText = "Id"
            DataDetalle.Columns.Item(3).HeaderText = "F01d_F01_Id"
            DataDetalle.Columns.Item(4).HeaderText = "Nro Lote"
            DataDetalle.Columns.Item(5).HeaderText = "Nro Gtf"
            DataDetalle.Columns.Item(6).HeaderText = "Nro_Lista Trozas"
            DataDetalle.Columns.Item(7).HeaderText = "Codigo Bosque"
            DataDetalle.Columns.Item(8).HeaderText = "Codigo Induatria"
            DataDetalle.Columns.Item(9).HeaderText = "Especie Gtf"
            DataDetalle.Columns.Item(10).HeaderText = "DM (cm.)"
            DataDetalle.Columns.Item(11).HeaderText = "Dm (cm.)"
            DataDetalle.Columns.Item(12).HeaderText = "Largo (m.)"
            DataDetalle.Columns.Item(13).HeaderText = "Vol._m3"
            DataDetalle.Columns.Item(14).HeaderText = "Especie Ind."
            DataDetalle.Columns.Item(15).HeaderText = "DMc (cm.)"
            DataDetalle.Columns.Item(16).HeaderText = "Dmc (cm.)"
            DataDetalle.Columns.Item(17).HeaderText = "Largoc (m.)"
            DataDetalle.Columns.Item(18).HeaderText = "Vol._m3c"
            DataDetalle.Columns.Item(19).HeaderText = "Dm (in)"
            DataDetalle.Columns.Item(20).HeaderText = "Largo (ft)"
            DataDetalle.Columns.Item(21).HeaderText = "Vol._Pt"
            DataDetalle.Columns.Item(22).HeaderText = "Procedencia"
            DataDetalle.Columns.Item(23).HeaderText = "Abast_Propietario"
            DataDetalle.Columns.Item(24).HeaderText = "Propietario"
            DataDetalle.Columns.Item(25).HeaderText = "Nom_Patio"
            DataDetalle.Columns.Item(26).HeaderText = "Nro_Guia_remision"
            DataDetalle.Columns.Item(27).HeaderText = "Emp_Transp"
            DataDetalle.Columns.Item(28).HeaderText = "Placa_Veh"
            DataDetalle.Columns.Item(29).HeaderText = "Conductor"
            DataDetalle.Columns.Item(30).HeaderText = "Utilizado_f04_Id"
            DataDetalle.Columns.Item(31).HeaderText = "Tipo"
            DataDetalle.Columns.Item(32).HeaderText = "Tipo_calculo"
            DataDetalle.Columns.Item(33).HeaderText = "Calidad"
            DataDetalle.Columns.Item(34).HeaderText = "F02_id"
            DataDetalle.Columns.Item(35).HeaderText = "Observacion"
            DataDetalle.Columns.Item(36).HeaderText = "Periodo"
            DataDetalle.Columns.Item(37).HeaderText = "Autogenerado"
            DataDetalle.Columns.Item(38).HeaderText = "Estatus"



            DataDetalle.Columns.Item(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataDetalle.Columns.Item(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataDetalle.Columns.Item(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataDetalle.Columns.Item(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataDetalle.Columns.Item(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataDetalle.Columns.Item(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataDetalle.Columns.Item(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataDetalle.Columns.Item(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            DataDetalle.Columns.Item(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            DataDetalle.Columns.Item(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataDetalle.Columns.Item(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataDetalle.Columns.Item(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            DataDetalle.Columns.Item(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            DataDetalle.Columns.Item(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataDetalle.Columns.Item(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            DataDetalle.Columns.Item(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight


            'Centrando todas las columnas del DataGridView
            DataDetalle.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            DataDetalle.Columns.Item(10).DefaultCellStyle.Format = "#0.#0"
            DataDetalle.Columns.Item(11).DefaultCellStyle.Format = "#0.#0"
            DataDetalle.Columns.Item(12).DefaultCellStyle.Format = "#0.#00"
            DataDetalle.Columns.Item(13).DefaultCellStyle.Format = "#0.#00"
            DataDetalle.Columns.Item(15).DefaultCellStyle.Format = "#0.#0"
            DataDetalle.Columns.Item(16).DefaultCellStyle.Format = "#0.#0"
            DataDetalle.Columns.Item(17).DefaultCellStyle.Format = "#0.#00"
            DataDetalle.Columns.Item(18).DefaultCellStyle.Format = "#0.#00"
            DataDetalle.Columns.Item(19).DefaultCellStyle.Format = "#0.#0"
            DataDetalle.Columns.Item(20).DefaultCellStyle.Format = "#0.#00"
            DataDetalle.Columns.Item(21).DefaultCellStyle.Format = "#0.#00"


            DataDetalle.Columns.Item(14).DefaultCellStyle.BackColor = Color.SeaGreen
            DataDetalle.Columns.Item(14).DefaultCellStyle.ForeColor = Color.White
            DataDetalle.Columns.Item(15).DefaultCellStyle.BackColor = Color.SeaGreen
            DataDetalle.Columns.Item(15).DefaultCellStyle.ForeColor = Color.White
            DataDetalle.Columns.Item(16).DefaultCellStyle.BackColor = Color.SeaGreen
            DataDetalle.Columns.Item(16).DefaultCellStyle.ForeColor = Color.White
            DataDetalle.Columns.Item(17).DefaultCellStyle.BackColor = Color.SeaGreen
            DataDetalle.Columns.Item(17).DefaultCellStyle.ForeColor = Color.White
            DataDetalle.Columns.Item(18).DefaultCellStyle.BackColor = Color.SeaGreen
            DataDetalle.Columns.Item(18).DefaultCellStyle.ForeColor = Color.White
            DataDetalle.Columns.Item(19).DefaultCellStyle.BackColor = Color.SeaGreen
            DataDetalle.Columns.Item(19).DefaultCellStyle.ForeColor = Color.White
            DataDetalle.Columns.Item(20).DefaultCellStyle.BackColor = Color.SeaGreen
            DataDetalle.Columns.Item(20).DefaultCellStyle.ForeColor = Color.White
            DataDetalle.Columns.Item(21).DefaultCellStyle.BackColor = Color.SeaGreen
            DataDetalle.Columns.Item(21).DefaultCellStyle.ForeColor = Color.White

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


    Private Sub MuestraProgreso(ByVal sender As Object, ByVal e As ItemEvents)
        mostrar_detalle(txId.Text)
    End Sub

    Private Sub btnAgregarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarItem.Click

        If String.IsNullOrEmpty(txId.Text) = True Then
            MessageBox.Show("Ho hay registro maestro", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim wfDetalle As New wfIngreso_trozas_det
        wfDetalle.xExiste = False
        wfDetalle.xTipotraslado = cbTraslado.Text
        wfDetalle.xRowPapa = txId.Text
        wfDetalle.xPeriodo = txPeriodo.Text.ToString()
        'wfDetalle.txLote.Text = txLote.Text
        wfDetalle.ShowDialog(Me)
        mostrar_detalle(Convert.ToInt32(txId.Text))
    End Sub

    Private Sub btnSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSig.Click
        recno += 1
        If recno <= (nreg - 1) Then
            mostrar_encabezado()
            mostrar_detalle(txId.Text)
            mostrar_resumen()
            formatear_grid()
        Else
            recno = nreg - 1
        End If
    End Sub

    Private Sub btnAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnt.Click
        recno -= 1
        If recno >= 0 Then
            mostrar_encabezado()
            mostrar_detalle(txId.Text)
            mostrar_resumen()
            formatear_grid()
        Else
            recno = 0
        End If
    End Sub

    Private Sub btnPri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPri.Click
        recno = 0
        mostrar_encabezado()
        mostrar_detalle(txId.Text)
        mostrar_resumen()
        formatear_grid()
    End Sub

    Private Sub btnUlt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUlt.Click
        recno = nreg - 1
        mostrar_encabezado()
        mostrar_detalle(txId.Text)
        mostrar_resumen()
        formatear_grid()
    End Sub

    Private Sub sumar_volumenytrozas()
        Try

            Dim totVolm3 As Decimal = Dtdm.Compute("Sum(f01d_vol_m3)", Nothing)
            Dim totVolm3c As Decimal = Dtdm.Compute("Sum(f01d_vol_m3c)", Nothing)
            Dim totVol_pt As Decimal = Dtdm.Compute("Sum(f01d_vol_pt)", Nothing)
            If nregd <> 0 Then
                txtTotalVolm3.Text = totVolm3
                txttotalvolm3c.Text = totVolm3c
                txtVol_pt.Text = totVol_pt
                Dim totTrozas As Integer = Dtdm.Rows.Count
                txtTrozas.Text = totTrozas
            Else
                txtTotalVolm3.Text = ""
                txttotalvolm3c.Text = ""
                txtVol_pt.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub btnDeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeshacer.Click

        recno = recno
        limpiar()
        mostrar_encabezado()
        Deshabilitar_datos()
        mostrar_detalle(IIf(txId.Text <> "", txId.Text, 0))

        If txId.Text <> "" Then
            mostrar_resumen()
            formatear_grid()
        Else
            txNumero.Text = ""
        End If

        habilitar_botones_desplazamiento()
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnGuardar.Enabled = False
        btnDeshacer.Enabled = False
        btnAgregarItem.Enabled = False
        btnSalir.Enabled = True
        chkEliminar.Enabled = False
        btnEliminar.Enabled = False
        btnEditar.Enabled = False
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Habilitar_datos()
        deshabilitar_botones_desplazamiento()
        If nregd <> 0 Then 'Si no hay registros
            btnEditar.Enabled = True
            chkEliminar.Enabled = True
            chkEliminar.CheckState = CheckState.Unchecked
        Else
            btnEditar.Enabled = False
            chkEliminar.Enabled = True
        End If
        btnSalir.Enabled = False
        btnAgregarItem.Enabled = True
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnDeshacer.Enabled = True
        btnEliminarGuia.Enabled = False
        modificar = True
        nuevo = False
    End Sub

    Private Sub chkEliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEliminar.CheckedChanged
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

                        Dim onekey As Integer = Convert.ToInt32(row.Cells("f01d_id").Value)

                        Dim vdb As New vFormato01_det
                        Dim func As New fformato01_det

                        vdb.gf01d_id = onekey
                        Dim db As New samadEntities
                        Dim cutt As String = row.Cells("f01d_autogenerado").Value
                        Dim ingreso = db.formato02_det.FirstOrDefault(Function(p) p.F02d_Cut = cutt)

                        If ingreso Is Nothing Then
                            If func.eliminar(vdb) Then

                                If IsDBNull(row.Cells("f01d_autogenerado").Value) = False Then
                                    'Editando el registro de la table Listatrozasd
                                    Dim cut As String = row.Cells("f01d_autogenerado").Value
                                    Dim auto As String = cut
                                    Dim lenauto As Integer = auto.Length
                                    'Dim xlt_id As Integer = Convert.ToInt32(Mid(auto, 14, lenauto))
                                    Dim arr As String() = auto.Split(New String() {"-", "."}, StringSplitOptions.None)

                                    Dim dtslt As New vListatrozasd
                                    Dim funclt As New flistatrozasd

                                    dtslt.gltdid = arr(3)
                                    dtslt.gltdautogenerado = Nothing

                                    If funclt.editar_autogenerado(dtslt) Then
                                        'MessageBox.Show("CUT Actualizado....!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        xreg = 0
                                        chkEliminar.Checked = False
                                    End If
                                End If
                            Else
                                MessageBox.Show("Registro NO fue eliminado", "Eliminar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            MessageBox.Show("La TROZA ya fue utilizada en el modulo CONSUMO DE TROZAS, No se puede Eliminar", "Eliminar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If



                    End If
                Next
                mostrar_detalle(txId.Text)
                mostrar_resumen()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub buscar_nrolista()
        Dim func As New flistatrozasc 'Creacion una variable para hacer referencia a la funcion flistatrozasd
        Dtb = func.mostrar 'Invocamos a la funcion mostrar()

        Dim busnrolista As String
        Dim foundRows() As Data.DataRow

        busnrolista = String.Format("lt_nrolista = '{0}'", txNumero.Text)

        foundRows = Dtb.Select(busnrolista)
        If UBound(foundRows) = False Then
            MessageBox.Show("Este número de lista ya existe, Vuelva a Ingresar...!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnBuscarGtfs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarNros.Click
        'Enviamos los datos de la consulta sql

        Dim busqueda As New frmFormato01Busqueda

        busqueda.ShowDialog(Me)

        'Datos del Vehiculo
        If busqueda.flag = True Then
            recno = busqueda.matColumnas(0)
            If recno <> 0 Then
                Dim valor As Integer = -1
                Dim index As Integer = 0

                Do While valor <> recno
                    valor = Dte.Rows(index).Item("f01_nro")
                    index += 1
                Loop
                recno = index - 1

                mostrar_encabezado()
                Deshabilitar_datos()
                mostrar_detalle(txId.Text)
                mostrar_resumen()
                formatear_grid()
            End If
        End If
    End Sub


    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Dim ner As New samadEntities
        Dim dma As New SAMAD.formato01_det
        Dim dts As New cdFormato01Det
        Dim xromId As Integer
        Dim wfDetalle As New wfIngreso_trozas_det
        wfDetalle.xExiste = True

        'nuevoItem = True
        'Dim frmDetalle As New frmListatrozasd
        Dim reg As Integer = Dtdm.Rows.Count 'Contamos 
        Dim idRow = DataDetalle.SelectedCells.Item(2).Value
        dma = dts.GetDatosEdicionTroza(xromId)

        wfDetalle.xEstatus = DataDetalle.SelectedCells.Item(38).Value

        If wfDetalle.xEstatus = False Then
            'wfDetalle.txSerie.Focus()
            wfDetalle.Numtroza = DataDetalle.SelectedCells.Item(7).Value

            'wfDetalle.xProcencia = DataDetalle.SelectedCells.Item(22).Value 'Procedencia
            ' wfDetalle.xAbastecimiento = DataDetalle.SelectedCells.Item(23).Value 'Abasteciemiento
            wfDetalle.xRowId = DataDetalle.SelectedCells.Item(2).Value 'id registro.

            wfDetalle.ShowDialog(Me) 'Mostramos el Formulario FrmDetalle
        Else
            MessageBox.Show("Esta troza no puede ser fodificada por que ya fue aserrada", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' End If
    End Sub

    Private Sub registro_seleccionado()

        If nregd <> 0 Then
            txtGuiaRemision.Text = DataDetalle.SelectedCells.Item(26).Value
            'txtPlaca.Text = DataDetalle.SelectedCells.Item(21).Value
            If Not IsDBNull(DataDetalle.SelectedCells.Item(25).Value) Then
                TxtUbicacion.Text = DataDetalle.SelectedCells.Item(25).Value
            Else
                TxtUbicacion.Text = ""
            End If

            If Not IsDBNull(DataDetalle.SelectedCells.Item(35).Value) Then
                TxtObservaDetalle.Text = DataDetalle.SelectedCells.Item(35).Value
            Else
                TxtObservaDetalle.Text = ""
            End If

            If Not IsDBNull(DataDetalle.SelectedCells.Item(28).Value) Then
                txtPlaca.Text = DataDetalle.SelectedCells.Item(28).Value
            Else
                txtPlaca.Text = ""
            End If

            If Not IsDBNull(DataDetalle.SelectedCells.Item(29).Value) Then
                txtConductor.Text = DataDetalle.SelectedCells.Item(29).Value
            Else
                txtConductor.Text = ""
            End If
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
        txtGuiaRemision.Text = ""
        txtPlaca.Text = ""
        TxtUbicacion.Text = ""
        txtConductor.Text = ""
        TxtObservaDetalle.Text = ""
    End Sub

    Private Sub lblResponsable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblResponsable.Click
        Dim frmResponsable As New frmPersonal
        frmResponsable.ShowDialog(Me)
    End Sub

    Private Sub cmbTraslado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTraslado.SelectedIndexChanged
        If cbTraslado.Text = "FLUVIAL" Then
            rbFluvial.Enabled = True
            rbFluvial.Checked = True
            rbTerrestre.Enabled = False
        Else
            If cbTraslado.Text = "TERRESTRE" Then
                rbTerrestre.Enabled = True
                rbTerrestre.Checked = True
                rbFluvial.Enabled = False
            Else
                rbFluvial.Enabled = True
                rbFluvial.Checked = True
                rbTerrestre.Enabled = True
                rbTerrestre.Checked = False
            End If
        End If
    End Sub

    Private Sub btnConcesion_Click(sender As System.Object, e As System.EventArgs) Handles btnTitular.Click
        'Enviamos los datos de la consulta sql

        frmtitu.titulo = "Seleccione Propietario"
        frmtitu.t_tabla = "titulares"
        frmtitu.t_campos = "pro_id,pro_titular,pro_ruc"
        frmtitu.t_donde = "pro_destinock = true"
        frmtitu.t_agruparpor = ""
        frmtitu.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Razón Social", "Ruc"}
        Dim anchos() As Integer = {30, 200, 60}

        ReDim frmtitu.matAnchos(anchos.Length)
        ReDim frmtitu.matTitulos(titulos.Length)
        ReDim frmtitu.matColumnas(titulos.Length)
        titulos.CopyTo(frmtitu.matTitulos, 0)
        anchos.CopyTo(frmtitu.matAnchos, 0)

        frmtitu.ShowDialog(Me)

        'Datos de Propietarios
        If frmtitu.flag = True Then
            txTitularId.Text = frmtitu.matColumnas(0)
            txtTitular.Text = frmtitu.matColumnas(1)
        End If
    End Sub

    Private Sub btnEliminarGuia_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarGuia.Click
        Try
            Dim result = MessageBox.Show("¿Esta seguro de Eliminar el Documento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                Dim db As New samadEntities
                Dim entry = db.formato01.FirstOrDefault(Function(p) p.F01_id = txId.Text)
                db.formato01.DeleteObject(entry)
                db.SaveChanges()
                fauditoria.insertar("fomato01", "Eliminar", txId.Text, "")
                MessageBox.Show("Se Elimino con Éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim func As New fformato01 'Creacion una variable para hacer referencia a la funcion flistatrozasd
                Dte = func.mostrar 'Invocamos a la funcion mostrar()
                nreg = Dte.Rows.Count - 1
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

    Private Sub lblTitular_Click(sender As System.Object, e As System.EventArgs) Handles lblTitular.Click
        Dim frmTitular As New frmTitulares
        frmTitular.ShowDialog(Me)
    End Sub

    'Private Sub txFecha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txFecha.ValueChanged
    '    txPeriodo.Text = Year(txFecha.Text)
    '    txLote.Text = New fxSamad().StrCeros(New cdFormato01().NumeroLote(txPeriodo.Text), 6, True)
    'End Sub

    Private Sub btUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btUpdate.Click
        mostrar_detalle(txId.Text)
        mostrar_resumen()
    End Sub

    Public Sub ActualizarGrid()
        mostrar_detalle(txId.Text)
    End Sub

End Class