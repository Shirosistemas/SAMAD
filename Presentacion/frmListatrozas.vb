
Public Class frmListatrozas

    Dim Dt, Dtd, Dtdm, Dte, Dtb, row As New DataTable
    Dim func As New ftitulares 'Creacion una variable para hacer referencia a la funcion fconcesiones
    Dim nreg, nregd, xreg, recno, filtro_trans, xZafraPoId, xTituloId, xContratoId, xPoaId, xPropietarioId, xDestinatarioId, xTransporteId, xConductorId, xVeh_Emt_Id As Integer
    Dim sw_guardar As Boolean = False
    Dim sw_guardard As Boolean = False
    Dim nuevo As Boolean = False
    Dim nuevoItem As Boolean = False
    Dim modificar As Boolean = False
    Dim cabecera As Boolean = False
    Dim modificarItem As Boolean = False
    Dim msg As String = ""
    Dim frm, frmc, frmp, frmp1, frmpp, frmd, frmpl, frmco As New frmShowbrow
    Dim frmbuscar As New frmListatrozasBuscar
    Dim guiarem As String

    Private _left As String

    Dim xTitulo = fxSamad.Titulo

    Dim dts As New List(Of SAMAD.vwlista_trozasc)

#Region "Funciones y procedimientos del Formulario"

    Public Sub GrabarRegistroDetalle()
        'mostrar_encabezado()
        mostrar_detalle(TxtId.Text)
        mostrar_resumen()
        sumar_volumenytrozas()
        formatear_grid()

    End Sub

#End Region

    Private Sub AplicarPerfil()
        If vInfraestructura.Usuario.gtipo = "ADMINISTRADOR" Then

        Else
            GroupBox1.Enabled = False
            Panel3.Enabled = False
        End If
    End Sub

    Private Sub Deshabilitar_datos()
        btnNroLista.Enabled = False
        btnEliminarGuia.Enabled = False
        TxtId.Enabled = False 'Id del Encabezado
        txtFecha.Enabled = False 'Fecha del Encabezado
        TxFecha_ven.Enabled = False
        btnDeffs.Enabled = False
        Label3.Enabled = False
        lblPoa.Enabled = False
        'Concesion
        btnConcesion.Enabled = False
        BtnUbigeo.Enabled = False
        lblTitular.Enabled = False
        lblContrato.Enabled = False

        btnContrato.Enabled = False
        btnPoa.Enabled = False

        'Propietario
        btnPropietario.Enabled = False
        lblPropietario.Enabled = False
        TxTipo_cm_CV.Enabled = False
        TxNro_Cv_Serie.Enabled = False
        TxNro_Com_Cv.Enabled = False

        'Transporte
        TxNroSerie.Enabled = False
        TxNroGuia.Enabled = False
        btnPlaca.Enabled = False
        btnConductor.Enabled = False
        lblVehiculo.Enabled = False
        lblConductor.Enabled = False

        'Destino
        btnDestino.Enabled = False
        lblDeestino.Enabled = False

        chkTipoDimension.Enabled = False

    End Sub

    Private Sub Habilitar_datos()
        TxtId.Enabled = False 'Id del Encabezado
        txtFecha.Enabled = True 'Fecha del Encabezado
        btnNroLista.Enabled = True
        TxFecha_ven.Enabled = True
        btnDeffs.Enabled = True
        btnContrato.Enabled = True
        btnPoa.Enabled = True
        Label3.Enabled = True
        lblPoa.Enabled = True

        'Concesion
        btnConcesion.Enabled = True
        BtnUbigeo.Enabled = True
        lblContrato.Enabled = True
        lblTitular.Enabled = True

        'Propietario
        btnPropietario.Enabled = True
        lblPropietario.Enabled = True
        TxTipo_cm_CV.Enabled = True
        TxNro_Cv_Serie.Enabled = True
        TxNro_Com_Cv.Enabled = True

        'Transporte
        TxNroSerie.Enabled = True
        TxNroGuia.Enabled = True
        btnPlaca.Enabled = True
        btnConductor.Enabled = True
        lblVehiculo.Enabled = True
        lblConductor.Enabled = True

        'Destino
        btnDestino.Enabled = True
        lblDeestino.Enabled = True

        chkTipoDimension.Enabled = True
    End Sub

    Private Sub mostrar_encabezado()
        dts = New cdListatrozasc().HeaderListaTrozas()
        Try
            'Dim func As New flistatrozasc 'Creacion una variable para hacer referencia a la funcion flistatrozasd
            'Dte = func.mostrar 'Invocamos a la funcion mostrar()
            'nreg = Dte.Rows.Count 'Almacenamos la cantidad de filas o registros recuperados
            nreg = dts.Count
            If nreg <> 0 Then
                TxtId.Text = dts(recno).Lt_id
                btnNroLista.Text = dts(recno).Lt_Nrogtf
                txSerie.Text = Mid(btnNroLista.Text, 1, 3)
                txNumero.Text = Mid(btnNroLista.Text, 5, btnNroLista.Text.Length - 4)
                Label32.Text = "RESUMEN - GTF: " + dts(recno).Lt_Nrogtf
                TxUbigeo.Text = dts(recno).Lt_Ubigeo
                txtFecha.Text = dts(recno).Lt_Fecha
                TxFecha_ven.Text = dts(recno).Lt_fecha_ven
                chkTipoDimension.CheckState = dts(recno).Lt_TipoDimension

                'Datos del Titular
                xTituloId = dts(recno).Lt_Titular_Id
                txt_Con_Titular.Text = dts(recno).lt_titular
                txt_Con_Ruc.Text = dts(recno).titular_ruc
                TxRep_legal.Text = dts(recno).lt_rep_legal
                txt_Con_Depto.Text = dts(recno).departamento
                txt_Con_Provincia.Text = dts(recno).provincia
                txt_Con_Distrito.Text = dts(recno).distrito
                txt_Con_Sector.Text = dts(recno).Pro_Sector
                txDeffs.Text = dts(recno).Lt_Deffs

                'Datos de propietario
                xPropietarioId = dts(recno).Lt_Propietario_Id
                txt_Pro_Nombre.Text = dts(recno).prop_nomraz
                TxDni_P.Text = dts(recno).lt_dni_p
                txt_Pro_Ruc.Text = dts(recno).prop_ruc
                TxDireccion_P.Text = dts(recno).lt_direccion_p
                TxDepto_P.Text = dts(recno).pro_departament
                TxProv_p.Text = dts(recno).pro_provincia
                TxDist_p.Text = dts(recno).pro_distrito

                TxTipo_cm_CV.Text = dts(recno).Lt_Tipo_Cv

                TxNro_Cv_Serie.Text = Mid(dts(recno).Lt_Nro_Cv, 1, 3)
                TxNro_Com_Cv.Text = Mid(dts(recno).Lt_Nro_Cv, 5, Len(dts(recno).Lt_Nro_Cv) - 4)

                'Datos de contrato/permiso
                xContratoId = dts(recno).Lt_Contrato_Id
                txt_Con_Contrato.Text = dts(recno).Con_Descripcion
                TxTipo_Doc_Pm.Text = dts(recno).lt_TipoPm

                'Datos de poa
                xPoaId = dts(recno).Lt_Poa_Id
                txt_Con_Poa.Text = dts(recno).Zyp_Poa
                txtLtd_Zafra.Text = dts(recno).Lt_Zafra
                Tx_Resolucion.Text = dts(recno).lt_Resolucion
                TxOrigen_Rec.Text = dts(recno).Lt_Origen_Rec

                'Datos de vehiculo
                xTransporteId = dts(recno).Lt_Transporte_Id
                txt_veh_placa.Text = dts(recno).Veh_Placa
                txtTipo.Text = dts(recno).Veh_Tipo
                TxTipo_vehic.Text = dts(recno).Lt_Tipo_Vehic

                TxNroSerie.Text = Mid(dts(recno).Lt_NroGuia_rem, 1, 3)
                TxNroGuia.Text = Mid(dts(recno).Lt_NroGuia_rem, 5, Len(dts(recno).Lt_NroGuia_rem) - 4)

                'Datos del conductor
                xConductorId = dts(recno).Lt_Conductor_Id
                txt_Conductor_Nombre.Text = dts(recno).con_nomape
                txt_Conductor_Dni.Text = dts(recno).Con_Dni
                txt_Conductor_Licencia.Text = dts(recno).Con_NroLicencia

                'Datos de destino
                xDestinatarioId = dts(recno).Lt_Destinatario_Id
                txt_Des_Nombre.Text = dts(recno).des_nomraz
                TxDni_D.Text = dts(recno).lt_dni_d
                txt_Des_Depto.Text = dts(recno).des_departamento
                txt_Des_Provincia.Text = dts(recno).des_provincia
                txt_Des_Distrito.Text = dts(recno).des_distrito
                txt_Des_Direccion.Text = dts(recno).des_direccion
                txt_Des_Ruc.Text = dts(recno).des_ruc

                'If txtTipo.Text = "FLUVIAL" Then
                '    lblVehiculo.Text = "Enbarcación"
                '    txt_veh_placa.Text = dts(recno).veh_marca
                'Else
                '    lblVehiculo.Text = "Placa Veh."
                '    txt_veh_placa.Text = dts(recno).veh_placa
                'End If

                habilitar_botones_desplazamiento()
                btnNuevo.Enabled = True
                btnModificar.Enabled = True
                btnEliminarGuia.Enabled = True
                btnGuardar.Enabled = False
                btnDeshacer.Enabled = False
                btnAgregarItem.Enabled = False
                btnSalir.Enabled = True
            Else
                deshabilitar_botones_desplazamiento()
                btnNuevo.Enabled = True
                btnModificar.Enabled = False
                btnEliminarGuia.Enabled = True
                btnGuardar.Enabled = False
                btnDeshacer.Enabled = False
                btnAgregarItem.Enabled = False
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
        txtNrolista.Text = ""
        TxUbigeo.Text = ""
        txtFecha.Text = ""
        TxFecha_ven.Text = ""
        txDeffs.Text = ""

        'Datos del Titular
        xTituloId = 0
        txt_Con_Titular.Text = ""
        txt_Con_Ruc.Text = ""
        TxRep_legal.Text = ""
        txt_Con_Depto.Text = ""
        txt_Con_Provincia.Text = ""
        txt_Con_Distrito.Text = ""
        txt_Con_Sector.Text = ""

        'Datos de propietario
        xPropietarioId = 0
        txt_Pro_Nombre.Text = ""
        TxDni_P.Text = ""
        txt_Pro_Ruc.Text = ""
        TxDireccion_P.Text = ""
        TxDepto_P.Text = ""
        TxProv_p.Text = ""
        TxDist_p.Text = ""
        TxTipo_cm_CV.Text = ""
        TxNro_Cv_Serie.Text = ""

        'Datos de contrato/permiso
        xContratoId = 0
        txt_Con_Contrato.Text = ""
        TxOrigen_Rec.Text = ""

        'Datos de poa
        xPoaId = 0
        txt_Con_Poa.Text = ""
        txtLtd_Zafra.Text = ""
        Tx_Resolucion.Text = ""
        TxTipo_Doc_Pm.Text = ""


        'Datos de vehiculo
        TxNroSerie.Text = ""
        TxNroGuia.Text = ""
        xTransporteId = 0
        txt_veh_placa.Text = ""
        txtTipo.Text = ""



        'Datos del conductor
        xContratoId = 0
        TxNroSerie.Text = ""
        TxNroGuia.Text = ""
        txtTipo.Text = ""
        TxTipo_vehic.Text = ""
        txt_veh_placa.Text = ""
        txt_Conductor_Nombre.Text = ""
        txt_Conductor_Dni.Text = ""
        txt_Conductor_Licencia.Text = ""

        'Datos de destino
        xDestinatarioId = 0
        txt_Des_Nombre.Text = ""
        TxDni_D.Text = ""
        txt_Des_Depto.Text = ""
        txt_Des_Provincia.Text = ""
        txt_Des_Distrito.Text = ""
        txt_Des_Direccion.Text = ""
        txt_Des_Ruc.Text = ""

        txtTrozas.Text = ""
        txtTotalVolm3.Text = ""

    End Sub

    Public Sub siguientecontrol()
        SendKeys.Send("{TAB}")
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
        Dim todook As Boolean = False
        Dim vali1 As Boolean = funcl.ValidaControles(gbConcesion.Controls)
        If vali1 = True Then
            Dim vali2 As Boolean = funcl.ValidaControles(gbDestino.Controls)
            If vali2 = True Then
                Dim vali3 As Boolean = funcl.ValidaControles(gbPropietario.Controls)
                If vali3 = True Then
                    Dim vali4 As Boolean = funcl.ValidaControles(gbTransporte.Controls)
                    If vali4 = True Then
                        todook = True
                    End If
                End If
            End If
        End If
        If todook = True Then
            Try
                Dim result As DialogResult
                If nuevo = True Then
                    If New flistatrozasc().GtfExiste(txSerie.Text & "-" & txNumero.Text) = True Then
                        btnNroLista.Text = optener_siguiente_numero_lista()
                    End If
                End If
                Dim dt As New SAMAD.listatrozasc
                If nuevo = False Then
                    result = MessageBox.Show("Desea guardar los Cambios?", xTitulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If result = False Then
                        Exit Sub
                    End If
                    dt.Lt_id = TxtId.Text
                End If
                dt.Lt_Nrogtf = btnNroLista.Text
                dt.Lt_Ubigeo = TxUbigeo.Text
                dt.Lt_Fecha = txtFecha.Text
                dt.Lt_fecha_ven = TxFecha_ven.Text
                dt.Lt_Titular_Id = xTituloId
                dt.Lt_Propietario_Id = xPropietarioId
                dt.Lt_Tipo_Cv = TxTipo_cm_CV.Text
                dt.Lt_Nro_Cv = TxNro_Cv_Serie.Text & "-" & TxNro_Com_Cv.Text
                dt.Lt_NroGuia_rem = TxNroSerie.Text & "-" & TxNroGuia.Text
                dt.Lt_Contrato_Id = xContratoId
                dt.Lt_Poa_Id = xPoaId
                dt.Lt_Zafra = txtLtd_Zafra.Text
                dt.Lt_Transporte_Id = xTransporteId
                dt.Lt_Conductor_Id = xConductorId
                dt.Lt_Destinatario_Id = xDestinatarioId
                dt.Lt_TipoDimension = False
                dt.Lt_Deffs = txDeffs.Text
                dt.Lt_unidad = "Smalian"
                dt.Estatus = 0
                If New cdListatrozasc().GrabarListaTrozas(dt, nuevo) = False Then
                    MessageBox.Show("No se pudo guardar la Información", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                mostrar_encabezado()
                limpiar()
                Deshabilitar_datos()
                btnNuevo.Enabled = True
                btnModificar.Enabled = True
                btnGuardar.Enabled = False
                BtnImportGTF.Enabled = True
                btnDeshacer.Enabled = False
                btnSalir.Enabled = True
                btnEliminarGuia.Enabled = True
                estado_botones_items()
                btnUlt.PerformClick()
                mostrar_resumen_gfts()

            Catch ex As Exception
                MessageBox.Show(ex.ToString(), xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Habilitar_datos()
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnDeshacer.Enabled = True
        btnSalir.Enabled = False
        btnNroLista.Text = ""
        btnAgregarItem.Enabled = False
        btnEditar.Enabled = False
        chkEliminar.Enabled = False
        limpiar()
        DataDetalle.DataSource = Nothing
        dataResumen.DataSource = Nothing
        nuevo = True
        modificar = False
        btnEliminarGuia.Enabled = False
        txtNrolista.Text = optener_siguiente_numero_lista()
    End Sub

    Private Sub btnConcesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConcesion.Click
        'Enviamos los datos de la consulta sql

        frm.t_tabla = "vmostrar_titulares"
        frm.t_campos = "pro_id,pro_titular,pro_ruc,Pro_Rep_Legal,departamento,provincia,distrito,pro_sector,pro_propietariock,pro_destinock,pro_transporteck,pro_direccion,Pro_Dni"
        frm.t_donde = "pro_propietariock=1"
        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Razón Social", "Ruc", "Representante Legal", "Dpto", "Provincia", "Distrito", "Sector", "Propietario", "Destino", "Transporte", "Dirección", "No DNI"}
        Dim anchos() As Integer = {30, 280, 60, 280, 90, 90, 90, 90, 90, 90, 90, 100, 100}
        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)
        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog(Me)

        'Datos del Titular
        If frm.flag = True Then
            'txTitularId.Text = frm.matColumnas(0)
            xTituloId = frm.matColumnas(0)
            txt_Con_Titular.Text = frm.matColumnas(1)
            txt_Con_Ruc.Text = frm.matColumnas(2)
            TxRep_legal.Text = frm.matColumnas(3)
            txt_Con_Depto.Text = frm.matColumnas(4)
            txt_Con_Provincia.Text = frm.matColumnas(5)
            txt_Con_Distrito.Text = frm.matColumnas(6)
            txt_Con_Sector.Text = frm.matColumnas(7)
            btnNroLista.Text = optener_siguiente_numero_lista()
            btnNroLista.Enabled = True
            'PRUEBA()

            'Si el check de propietario esta activado
            If IsDBNull(frm.matColumnas(8)) = False Then
                If frm.matColumnas(8) = 1 Then
                    xPropietarioId = frm.matColumnas(0)
                    txt_Pro_Nombre.Text = frm.matColumnas(1)
                    TxDni_P.Text = frm.matColumnas(12)
                    txt_Pro_Ruc.Text = frm.matColumnas(2)
                    TxDireccion_P.Text = frm.matColumnas(11)
                    TxDepto_P.Text = frm.matColumnas(4)
                    TxProv_p.Text = frm.matColumnas(5)
                    TxDist_p.Text = frm.matColumnas(6)
                Else
                    xPropietarioId = ""
                    txt_Pro_Nombre.Text = ""
                    TxDni_P.Text = ""
                    txt_Pro_Ruc.Text = ""
                    TxDireccion_P.Text = ""
                    TxDepto_P.Text = ""
                    TxProv_p.Text = ""
                    TxDist_p.Text = ""
                End If
            End If

            'Si el check de destino esta activado
            If IsDBNull(frm.matColumnas(8)) = False Then
                If frm.matColumnas(8) = 1 Then
                    xDestinatarioId = frm.matColumnas(0)
                    txt_Des_Nombre.Text = frm.matColumnas(1)
                    TxDni_D.Text = frm.matColumnas(12)
                    txt_Des_Ruc.Text = frm.matColumnas(2)
                    txt_Des_Depto.Text = frm.matColumnas(3)
                    txt_Des_Provincia.Text = frm.matColumnas(4)
                    txt_Des_Distrito.Text = frm.matColumnas(5)
                    txt_Des_Direccion.Text = frm.matColumnas(11)
                Else
                    xDestinatarioId = ""
                    txt_Des_Nombre.Text = ""
                    TxDni_D.Text = ""
                    txt_Des_Ruc.Text = ""
                    txt_Des_Depto.Text = ""
                    txt_Des_Provincia.Text = ""
                    txt_Des_Distrito.Text = ""
                    txt_Des_Direccion.Text = ""
                End If
            End If

            'Si el check de Transporte esta activado
            If IsDBNull(frm.matColumnas(9)) = False Then
                If frm.matColumnas(9) = 1 Then
                    filtro_trans = frm.matColumnas(0)
                Else
                    filtro_trans = 0
                End If
            End If

        End If
    End Sub

    Private Sub btnContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContrato.Click
        'Enviamos los datos de la consulta sql
        If xTituloId <> 0 Then
            frmc.titulo = txt_Con_Titular.Text
            frmc.t_tabla = "contratos"
            frmc.t_campos = "con_id,con_descripcion,con_recurso,con_anno"
            frmc.t_donde = String.Format("con_pro_id = {0}", xTituloId)
            frmc.t_agruparpor = ""
            frmc.t_ordenarpor = ""

            'Enviamos los formatosy tiulos de las columnas en un Array
            Dim titulos() As String = {"Id", "Contrato/Permiso", "Origen del recurso", "Año"}
            Dim anchos() As Integer = {30, 200, 200, 60}

            ReDim frmc.matAnchos(anchos.Length)
            ReDim frmc.matTitulos(titulos.Length)
            ReDim frmc.matColumnas(titulos.Length)
            titulos.CopyTo(frmc.matTitulos, 0)
            anchos.CopyTo(frmc.matAnchos, 0)

            'frm.MdiParent = frmPrincipal
            frmc.ShowDialog(Me)

            'Datos de Contrato y Poa
            If frmc.flag = True Then
                xContratoId = frmc.matColumnas(0)
                txt_Con_Contrato.Text = frmc.matColumnas(1)
                TxOrigen_Rec.Text = frmc.matColumnas(2)
            End If
        Else
            MessageBox.Show("Debe ingresar primero el Titular", "Mensaje")
        End If
    End Sub

    Private Sub frmListatrozas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Setup()
    End Sub

    Private Sub Setup()
        cabecera = True
        recno = nreg
        mostrar_encabezado()
        Deshabilitar_datos()
        mostrar_detalle(IIf(TxtId.Text <> "", TxtId.Text, 0))
        If TxtId.Text <> "" Then
            mostrar_resumen()
            formatear_grid()
        End If
        FechaInicioDatePicker.Value = DateTime.Now
        FechaFinDateTimePicker.Value = DateTime.Now

        formatear_grid()
        mostrar_resumen()
        mostrar_resumen_gfts()
        btnUlt.PerformClick()
        AplicarPerfil()
    End Sub

    Private Sub btnPoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPoa.Click
        'Enviamos los datos de la consulta sql
        If xContratoId <> 0 Then
            frmp.titulo = txt_Con_Titular.Text
            frmp.t_tabla = "zafrasypoas"
            frmp.t_campos = "zyp_id,zyp_resolucion,zyp_tipopm,zyp_poa,zyp_zafra"
            frmp.t_donde = String.Format("zyp_permiso_id = {0}", xContratoId)
            frmp.t_agruparpor = ""
            frmp.t_ordenarpor = ""

            'Enviamos los formatosy tiulos de las columnas en un Array
            Dim titulos() As String = {"Id", "Resolucion", "Tipo Pm", "Poa", "Zafra"}
            Dim anchos() As Integer = {30, 150, 120, 70, 70}

            ReDim frmp.matAnchos(anchos.Length)
            ReDim frmp.matTitulos(titulos.Length)
            ReDim frmp.matColumnas(titulos.Length)
            titulos.CopyTo(frmp.matTitulos, 0)
            anchos.CopyTo(frmp.matAnchos, 0)

            frmp.ShowDialog(Me)

            'Datos de Contrato y Poa
            If frmp.flag = True Then
                xPoaId = frmp.matColumnas(0)
                Tx_Resolucion.Text = frmp.matColumnas(1)
                TxTipo_Doc_Pm.Text = frmp.matColumnas(2)
                txt_Con_Poa.Text = frmp.matColumnas(3)
                txtLtd_Zafra.Text = frmp.matColumnas(4)
            End If
        Else
            MessageBox.Show("Debe ingresar primero el Contrato", "Mensaje")
        End If
    End Sub

    Private Sub btnPropietario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPropietario.Click
        'Enviamos los datos de la consulta sql

        frmpp.titulo = "Seleccione Propietario"
        frmpp.t_tabla = "vmostrar_titulares"
        frmpp.t_campos = "pro_id,pro_titular,Pro_Dni,pro_ruc,pro_direccion,departamento,provincia,distrito"
        frmpp.t_donde = ""
        frmpp.t_agruparpor = ""
        frmpp.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Razón Social", "No DNI", "Ruc", "DIRECCION", "DEPARTAMENTO", "PROVINCIA", "DISTRITO"}
        Dim anchos() As Integer = {30, 200, 60, 60, 280, 120, 120, 120}

        ReDim frmpp.matAnchos(anchos.Length)
        ReDim frmpp.matTitulos(titulos.Length)
        ReDim frmpp.matColumnas(titulos.Length)
        titulos.CopyTo(frmpp.matTitulos, 0)
        anchos.CopyTo(frmpp.matAnchos, 0)

        frmpp.ShowDialog(Me)

        'Datos de Propietarios
        If frmpp.flag = True Then
            xPropietarioId = frmpp.matColumnas(0)
            txt_Pro_Nombre.Text = frmpp.matColumnas(1)
            TxDni_P.Text = frmpp.matColumnas(2)
            txt_Pro_Ruc.Text = frmpp.matColumnas(3)
            TxDireccion_P.Text = frmpp.matColumnas(4)
            TxDepto_P.Text = frmpp.matColumnas(5)
            TxProv_p.Text = frmpp.matColumnas(6)
            TxDist_p.Text = frmpp.matColumnas(7)

        End If
    End Sub

    Private Sub btnDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDestino.Click

        frmd.t_tabla = "vmostrar_titulares"
        frmd.t_campos = "pro_id,pro_titular,pro_dni,pro_ruc,pro_direccion,departamento,provincia,distrito"
        frmd.t_donde = "pro_destinock=1"
        frmd.t_agruparpor = ""
        frmd.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Razón Social", "No DNI", "Ruc", "Direccion", "Dpto", "Provincia", "Distrito"}
        Dim anchos() As Integer = {30, 200, 60, 60, 220, 120, 120, 120, 120}

        ReDim frmd.matAnchos(anchos.Length)
        ReDim frmd.matTitulos(titulos.Length)
        ReDim frmd.matColumnas(titulos.Length)
        titulos.CopyTo(frmd.matTitulos, 0)
        anchos.CopyTo(frmd.matAnchos, 0)

        frmd.ShowDialog(Me)

        'Datos de Propietarios
        If frmd.flag = True Then
            xDestinatarioId = frmd.matColumnas(0)
            txt_Des_Nombre.Text = frmd.matColumnas(1)
            TxDni_D.Text = frmd.matColumnas(2)
            txt_Des_Ruc.Text = frmd.matColumnas(3)
            txt_Des_Direccion.Text = frmd.matColumnas(4)
            txt_Des_Depto.Text = frmd.matColumnas(5)
            txt_Des_Provincia.Text = frmd.matColumnas(6)
            txt_Des_Distrito.Text = frmd.matColumnas(7)

        End If
    End Sub

    Private Sub btnPlaca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlaca.Click
        'Enviamos los datos de la consulta sql

        frmpl.titulo = "Vehículos"
        frmpl.t_tabla = "vehiculos"
        frmpl.t_campos = "veh_id,veh_tipo,veh_placa,veh_tipo_vehic,Veh_Emt_Id"
        frmpl.t_donde = ""
        frmpl.t_agruparpor = ""
        frmpl.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Tipo Trans", "Tipo_vehiculo", "Placa, Empre_t_Id"}
        Dim anchos() As Integer = {30, 90, 90, 90, 100, 50}

        ReDim frmpl.matAnchos(anchos.Length)
        ReDim frmpl.matTitulos(titulos.Length)
        ReDim frmpl.matColumnas(titulos.Length)
        titulos.CopyTo(frmpl.matTitulos, 0)
        anchos.CopyTo(frmpl.matAnchos, 0)

        frmpl.ShowDialog(Me)

        'Datos del Vehiculo
        If frmpl.flag = True Then
            xTransporteId = frmpl.matColumnas(0)
            txtTipo.Text = frmpl.matColumnas(1)
            TxTipo_vehic.Text = frmpl.matColumnas(2)
            txt_veh_placa.Text = frmpl.matColumnas(3)
            xVeh_Emt_Id = frmpl.matColumnas(4)
            'txtTipo.Text = frmpl.matColumnas(3)
            'If frmpl.matColumnas(3) = "TERRESTRE" Then
            '    lblVehiculo.Text = "Placa Veh."
            'Else
            '    lblVehiculo.Text = "Embarcacón"
            'End If

        End If
    End Sub

    Private Sub btnConductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConductor.Click
        'Enviamos los datos de la consulta sql
        If xTransporteId <> 0 Then
            frmco.titulo = "Conductores"
            frmco.t_tabla = "conductores"
            frmco.t_campos = "con_id,con_nomape,con_nrolicencia,con_dni, con_Emt_Id"
            frmco.t_donde = String.Format("con_Emt_Id = {0}", xVeh_Emt_Id)
            frmco.t_agruparpor = ""
            frmco.t_ordenarpor = ""

            'Enviamos los formatosy tiulos de las columnas en un Array
            Dim titulos() As String = {"Id", "Conductor", "Licencia", "Dni"}
            Dim anchos() As Integer = {30, 180, 90, 60}

            ReDim frmco.matAnchos(anchos.Length)
            ReDim frmco.matTitulos(titulos.Length)
            ReDim frmco.matColumnas(titulos.Length)
            titulos.CopyTo(frmco.matTitulos, 0)
            anchos.CopyTo(frmco.matAnchos, 0)

            frmco.ShowDialog(Me)

            'Datos del Vehiculo
            If frmco.flag = True Then
                xConductorId = frmco.matColumnas(0)
                txt_Conductor_Nombre.Text = frmco.matColumnas(1)
                txt_Conductor_Licencia.Text = frmco.matColumnas(2)
                txt_Conductor_Dni.Text = frmco.matColumnas(3)
            End If
        Else

            MessageBox.Show("Debe ingresar un Vehículo Primero", "Mensaje")

        End If

    End Sub

    Private Sub formatear_grid()

        If Dtdm.Rows.Count <> 0 Then
            'Quitando lo necesario
            DataDetalle.AllowUserToResizeRows = False
            DataDetalle.RowHeadersVisible = False

            'Modificando el ancho de las columnas
            DataDetalle.Columns.Item(1).Width = 50
            DataDetalle.Columns.Item(2).Width = 50
            DataDetalle.Columns.Item(3).Width = 150
            DataDetalle.Columns.Item(4).Width = 120
            DataDetalle.Columns.Item(5).Width = 90
            DataDetalle.Columns.Item(6).Width = 90
            DataDetalle.Columns.Item(7).Width = 90
            DataDetalle.Columns.Item(8).Width = 90
            DataDetalle.Columns.Item(9).Width = 90
            DataDetalle.Columns.Item(10).Width = 90
            DataDetalle.Columns.Item(11).Width = 90

            DataDetalle.Columns.Item(9).Visible = False
            DataDetalle.Columns.Item(2).Visible = False
            DataDetalle.Columns.Item(10).Visible = False
            'Cambiando el texto de las cabeceras
            DataDetalle.Columns(1).HeaderText = "Item"
            DataDetalle.Columns(2).HeaderText = "Id"
            DataDetalle.Columns(3).HeaderText = "Especie"
            DataDetalle.Columns(4).HeaderText = "Codificación"
            DataDetalle.Columns(5).HeaderText = "D> (Mayor)"
            DataDetalle.Columns(6).HeaderText = "D< (Menor)"
            DataDetalle.Columns(7).HeaderText = "Largo"
            DataDetalle.Columns(8).HeaderText = "Vol.M3"
            DataDetalle.Columns(9).HeaderText = "Lt_id"
            DataDetalle.Columns(10).HeaderText = "Cut"
            DataDetalle.Columns(11).HeaderText = "N° Lista Trozas"

            If chkTipoDimension.CheckState = CheckState.Checked Then
                DataDetalle.Columns(5).HeaderText = "Diametro Promedio"
                DataDetalle.Columns.Item(6).Visible = False
            Else
                DataDetalle.Columns.Item(6).Visible = True
            End If

            DataDetalle.Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataDetalle.Columns.Item(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataDetalle.Columns.Item(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataDetalle.Columns.Item(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataDetalle.Columns.Item(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataDetalle.Columns.Item(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

            'Centrando todas las columnas del DataGridView
            DataDetalle.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            DataDetalle.Columns.Item(5).DefaultCellStyle.Format = "#0.#0"
            DataDetalle.Columns.Item(6).DefaultCellStyle.Format = "#0.#0"
            DataDetalle.Columns.Item(7).DefaultCellStyle.Format = "#0.#0"
            DataDetalle.Columns.Item(8).DefaultCellStyle.Format = "#0.#00"

            'Centrando todos los Encabezados de las columnas del DataGridView
            DataDetalle.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ocultar_columnas()
            sumar_volumenytrozas()
        End If
    End Sub

    Private Sub ocultar_columnas()
        DataDetalle.Columns.Item("Eliminar").Visible = False
    End Sub

    Private Sub btnAgregarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarItem.Click
        'nuevoItem = True
        If String.IsNullOrEmpty(xTituloId) = True Then
            MessageBox.Show("Debe ingresar almenos el Titular", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim wfDetalle As New frmListatrozasd

        Dim reg As Integer = Dtdm.Rows.Count 'Contamos
        wfDetalle.txRowId.Text = reg + 1
        If chkTipoDimension.CheckState = CheckState.Checked Then
            wfDetalle.lbld2.Visible = False
            wfDetalle.txD2.Visible = False
            wfDetalle.lbltitd2.Visible = False
            wfDetalle.lbld1.Text = "Dia.Prom"
        Else
            wfDetalle.lbld2.Visible = True
            wfDetalle.txD2.Visible = True
            wfDetalle.lbltitd2.Visible = True

        End If
        wfDetalle.Promedio = chkTipoDimension.Checked
        'wfDetalle.ListaId = TxtId.Text
        wfDetalle.NumeroGTF = btnNroLista.Text
        wfDetalle.xExiste = False
        wfDetalle.RowPapa = TxtId.Text
        wfDetalle.xZafra = txtLtd_Zafra.Text
        wfDetalle.xTitular = xTituloId


        wfDetalle.ShowDialog(Me)
    End Sub

    Private Sub btnSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSig.Click
        recno += 1
        If recno <= (nreg - 1) Then
            mostrar_encabezado()
            mostrar_detalle(TxtId.Text)
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
            mostrar_detalle(TxtId.Text)
            mostrar_resumen()
            formatear_grid()
        Else
            recno = 0
            mostrar_resumen()
            formatear_grid()

        End If
    End Sub

    Private Sub btnPri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPri.Click
        recno = 0
        mostrar_encabezado()
        mostrar_detalle(TxtId.Text)
        mostrar_resumen()
        formatear_grid()

    End Sub

    Private Sub btnUlt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUlt.Click
        recno = nreg - 1
        mostrar_encabezado()
        mostrar_detalle(TxtId.Text)
        mostrar_resumen()
        formatear_grid()

    End Sub

    Private Sub sumar_volumenytrozas()

        Dim totVolm3 As Decimal = CType(Dtdm.Compute("Sum(ltd_vol_m3)", Nothing), Decimal)
        txtTotalVolm3.Text = totVolm3

        Dim totTrozas As Integer = Dtdm.Rows.Count
        txtTrozas.Text = totTrozas
    End Sub

    Private Sub mostrar_detalle(ByVal registro As Integer)
        Try
            Dim dtl As New vListatrozasd
            Dim func As New flistatrozasd 'Creacion una variable para hacer referencia a la funcion fconcesiones

            dtl.gltd_ltid = registro
            Dtdm = func.mostrar(dtl) 'Invocamos a la funcion mostrar()
            DataDetalle.Columns.Item("Eliminar").Visible = False 'Ocultamos la Columna Eliminar

            nregd = Dtdm.Rows.Count 'Almacenamos la cantidad de filas o registros recuperados

            If nregd <> 0 Then 'Si las filas al contarlas es diferente de cero
                DataDetalle.DataSource = Dtdm
                DataDetalle.ColumnHeadersVisible = True
                sumar_volumenytrozas()
                ocultar_columnas()
            Else
                DataDetalle.DataSource = Nothing
                DataDetalle.ColumnHeadersVisible = False
            End If
            estado_botones_items()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeshacer.Click
        recno = recno
        limpiar()
        mostrar_encabezado()
        Deshabilitar_datos()
        mostrar_detalle(IIf(TxtId.Text <> "", TxtId.Text, 0))
        If TxtId.Text <> "" Then
            mostrar_resumen()
            formatear_grid()
        Else
            txtNrolista.Text = ""
        End If
        mostrar_resumen()
        formatear_grid()

        habilitar_botones_desplazamiento()
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnGuardar.Enabled = False
        btnDeshacer.Enabled = False
        btnSalir.Enabled = True
        btnNroLista.Enabled = False
        'txtNrolista.Visible = False
        'txtNrolista.Enabled = False
        txSerie.Visible = False
        txNumero.Visible = False
        lblNroLista.Visible = False
        btnEliminarGuia.Enabled = True
        estado_botones_items()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Habilitar_datos()
        btnEliminarGuia.Enabled = True
        deshabilitar_botones_desplazamiento()
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnDeshacer.Enabled = True
        btnNroLista.Enabled = True
        btnAgregarItem.Enabled = False
        btnEditar.Enabled = False
        btnSalir.Enabled = False
        chkEliminar.Enabled = False
        modificar = True
        nuevo = False
        btnEliminarGuia.Enabled = False
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

                        Dim onekey As Integer = Convert.ToInt32(row.Cells("ltd_id").Value)
                        Dim vdb As New vListatrozasd
                        Dim func As New flistatrozasd

                        Dim db As New samadEntities

                        Dim cut = db.listatrozasd.FirstOrDefault(Function(p) p.Ltd_Id = onekey).Ltd_Autogenerado

                        If cut Is Nothing Then
                            vdb.gltdid = onekey
                            If func.eliminar(vdb) Then

                            Else
                                MessageBox.Show("Registro NO fue eliminado", "Eliminar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            MessageBox.Show("La TROZA ya fue utilizada en el Modulo RECEPCIÒN DE TROZAS, no se puede eliminar", "Eliminar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    End If
                Next
                mostrar_detalle(TxtId.Text)
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

        busnrolista = String.Format("Lt_Nrogtf = '{0}'", txtNrolista.Text)

        foundRows = Dtb.Select(busnrolista)
        If UBound(foundRows) = False Then
            MessageBox.Show("Este número de lista ya existe, Vuelva a Ingresar...!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub buscar_nrolista_titular()
        Dim busnrolista As String = Nothing
        Dim foundRows() As Data.DataRow = Nothing
        ' - Ojo, lo deshabilito porque no hay razon de generar un nuevo GTF ya que lo que quiero es cambiar el numero
        'optener_siguiente_numero_lista()
        Dim db As New samadEntities
        Dim en = db.listatrozasc.FirstOrDefault(Function(p) p.Lt_Nrogtf = txSerie.Text & "-" & txNumero.Text)
        If Not en Is Nothing Then
            MessageBox.Show("Este número de lista ya existe, Vuelva a Ingresar...!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim result As DialogResult
            result = MessageBox.Show("Esta seguro de Reemplazar por el Nro de lista : " & txSerie.Text & "-" & txNumero.Text & " ..?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                'btnNroLista.Text = txtNrolista.Text
                btnNroLista.Text = txSerie.Text & "-" & txNumero.Text
                ''txtNrolista.Enabled = False
                'txtNrolista.Visible = False
                txSerie.Visible = False
                txNumero.Visible = False
                lblNroLista.Visible = False
            End If
        End If
    End Sub

    Private Sub mostrar_resumen()
        Try
            Dim col As Integer
            Dim dtsr As New vShowbrow
            Dim func As New fshowbrow

            dtsr.gt_tabla = "listatrozasd"
            dtsr.gt_campos = "ltd_especie as Especie,count(ltd_especie)as Trozas,sum(ltd_vol_m3) as Volm3"
            dtsr.gt_donde = IIf(TxtId.Text <> "", String.Format("ltd_lt_id = {0}", TxtId.Text), "")
            dtsr.gt_agruparpor = "ltd_especie"
            dtsr.gt_ordenarpor = ""

            Dt = func.mostrar(dtsr) 'Invocamos a la funcion mostrar()

            If Dt.Rows.Count <> 0 Then 'Si las filas al contarlas es diferente de cero
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
        Dim wfDetalle As New frmListatrozasd
        wfDetalle.xExiste = True

        'nuevoItem = True
        'Dim frmDetalle As New frmListatrozasd
        Dim reg As Integer = Dtdm.Rows.Count 'Contamos 

        'Condicionando el Ingreso de los datos a 1 o 2 Diametros
        If chkTipoDimension.CheckState = CheckState.Checked Then
            wfDetalle.lbld2.Visible = False
            wfDetalle.txD2.Visible = False
            wfDetalle.lbltitd2.Visible = False
            wfDetalle.lbld1.Text = "Dia.Prom"
        Else
            wfDetalle.lbld2.Visible = True
            wfDetalle.txD2.Visible = True
            wfDetalle.lbltitd2.Visible = True
            wfDetalle.lbld1.Text = "D>(Mayor)"
        End If
        'wfDetalle.txSerie.Focus()
        wfDetalle.Numtroza = DataDetalle.SelectedCells.Item(4).Value
        wfDetalle.ShowDialog(Me) 'Mostramos el Formulario FrmDetalle
        mostrar_detalle(TxtId.Text)
        mostrar_resumen()
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnDeshacer.Enabled = True
        btnSalir.Enabled = True
        sumar_volumenytrozas()
        formatear_grid()
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

    Private Sub btnNroLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNroLista.Click
        ''lblNroLista.Visible = True
        ''txtNrolista.Visible = True
        ''txtNrolista.Enabled = True
        'txtNrolista.Text = Microsoft.VisualBasic.Right("000000", 6)
        ''txtNrolista.Focus()
        '- Nuevo Codigo
        lblNroLista.Visible = True
        txSerie.Visible = True
        txNumero.Visible = True
        'txSerie.Select(0, txSerie.Text.Length)
        txSerie.SelectAll()
        txSerie.Focus()

    End Sub

    'Private Sub txtNrolista_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNrolista.KeyPress
    '    If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
    '        'btnNroLista.Text = txtNrolista.Text
    '        e.Handled = True
    '        buscar_nrolista_titular()
    '    End If
    'End Sub

    Private Sub btnTitularform_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmTitular As New frmTitulares
        frmTitular.ShowDialog(Me)
    End Sub

    Private Sub lblTitular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitular.Click
        Dim frmTitular As New frmTitulares
        frmTitular.ShowDialog(Me)
    End Sub

    Private Sub lblContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblContrato.Click
        Dim frmContrato As New frmContratos
        frmContrato.ShowDialog(Me)
    End Sub

    Private Sub lblPoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPoa.Click
        Dim frmPoa As New FrmZafrasypoas
        frmPoa.ShowDialog(Me)
    End Sub

    Private Sub lblVehiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblVehiculo.Click
        Dim frmVehiculo As New frmVehiculos
        frmVehiculo.ShowDialog(Me)
    End Sub

    Private Sub lblConductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblConductor.Click
        Dim frmConductor As New frmConductores
        frmConductor.ShowDialog(Me)
    End Sub

    Private Sub lblDeestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDeestino.Click
        Dim frmDestino As New frmTitulares
        frmDestino.ShowDialog(Me)
    End Sub

    Private Sub lblPropietario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPropietario.Click
        Dim frmPropietario As New frmTitulares
        frmPropietario.ShowDialog(Me)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeffs.Click
        'Enviamos los datos de la consulta sql

        frm.t_tabla = "deffs"
        frm.t_campos = "def_id,def_sede"
        frm.t_donde = ""
        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Sede"}
        Dim anchos() As Integer = {30, 200}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)
        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog(Me)

        'Datos del Titular
        If frm.flag = True Then
            txDeffs.Text = frm.matColumnas(1)
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Dim frmDeffs As New FrmDeffs
        frmDeffs.ShowDialog(Me)
    End Sub

    Private Sub mostrar_resumen_gfts()
        Try

            Dim col As Integer
            Dim dtsr As New vShowbrow
            Dim func As New fshowbrow

            dtsr.gt_tabla = "vmostrar_listatrozasportitular"
            dtsr.gt_campos = "lt_id, pro_titular as Titular,lt_nrogtf as Gtf,lt_Fecha,Trozas,Volm3,Zyp_Poa as Nro_POA"
            'dtsr.gt_donde = IIf(TxtId.Text <> "", String.Format("ltd_lt_id = {0}", TxtId.Text), "")
            Dim desde As String = FechaInicioDatePicker.Value.Year.ToString() + "-" + FechaInicioDatePicker.Value.Month.ToString() + "-" + FechaInicioDatePicker.Value.Day.ToString()
            Dim hasta As String = FechaFinDateTimePicker.Value.Year.ToString() + "-" + FechaFinDateTimePicker.Value.Month.ToString() + "-" + FechaFinDateTimePicker.Value.Day.ToString()
            dtsr.gt_donde = "lt_Fecha >= '" + desde + "' and lt_Fecha <= '" + hasta + "'"
            dtsr.gt_agruparpor = ""
            dtsr.gt_ordenarpor = ""

            Dt = func.mostrar(dtsr) 'Invocamos a la funcion mostrar()

            If Dt.Rows.Count <> 0 Then 'Si las filas al contarlas es diferente de cero
                col = Dt.Columns.Count
                dataGtfs.AllowUserToResizeRows = False
                dataGtfs.RowHeadersVisible = False
                dataGtfs.DataSource = Dt
                'Formateando las columnas

                dataGtfs.Columns.Item(0).Visible = False
                dataGtfs.Columns.Item(1).Width = 200
                dataGtfs.Columns.Item(2).Width = 120
                dataGtfs.Columns.Item(3).Width = 120
                dataGtfs.Columns.Item(4).Width = 70
                dataGtfs.Columns.Item(5).Width = 70
                dataGtfs.Columns.Item(6).Width = 70

                dataGtfs.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                dataGtfs.Columns.Item(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                dataGtfs.Columns.Item(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                dataGtfs.Columns.Item(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                dataGtfs.Columns.Item(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

                dataGtfs.ColumnHeadersVisible = True
                dataGtfs.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Else
                dataGtfs.DataSource = Nothing
                dataGtfs.ColumnHeadersVisible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarGtfs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarGtfs.Click
        'Enviamos los datos de la consulta sql
        Try
            frmbuscar.ShowDialog(Me)

            'Datos del Vehiculo
            If frmbuscar.flag = True Then
                recno = frmbuscar.matColumnas(0)
                If recno <> 0 Then
                    Dim valor As Integer = -1
                    Dim index As Integer = 0
                    Do While valor <> recno
                        valor = Dte.Rows(index).Item("lt_id")
                        index += 1
                    Loop
                    recno = index - 1
                    Deshabilitar_datos()
                    mostrar_encabezado()
                    mostrar_detalle(TxtId.Text)
                    mostrar_resumen()
                    formatear_grid()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminarGuia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarGuia.Click
        Try
            Dim result = MessageBox.Show("¿Esta seguro de Eliminar la Guia de Transporte Forestal?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                Dim db As New samadEntities
                Dim entry = db.listatrozasc.Where(Function(p) p.Lt_id = TxtId.Text).FirstOrDefault
                db.listatrozasc.DeleteObject(entry)
                db.SaveChanges()
                fauditoria.insertar("listatrozasc", "Eliminar", TxtId.Text, "")
                MessageBox.Show("Se Elimino con Éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dts = New cdListatrozasc().HeaderListaTrozas()
                nreg = dts.Count - 1
                Setup()
            End If
        Catch ex As Exception
            MessageBox.Show("No Puede Eliminar este Documento, Contiene Trozas Registradas", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            btnEliminarGuia.Enabled = True
        End If
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub PRUEBA()
        'Enviamos los datos de la consulta sql
        frmp.t_tabla = "vmostrar_listatrozasportitular"
        frmp.t_campos = "Lt_Nrogtf,pro_titular,lt_id"
        frmp.t_donde = String.Format("PRO_ID = {0}", xTituloId)
        frmp.t_agruparpor = ""
        frmp.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Contrato/Permiso", "Año"}
        Dim anchos() As Integer = {30, 200, 60}

        ReDim frmp.matAnchos(anchos.Length)
        ReDim frmp.matTitulos(titulos.Length)
        ReDim frmp.matColumnas(titulos.Length)
        titulos.CopyTo(frmp.matTitulos, 0)
        anchos.CopyTo(frmp.matAnchos, 0)

        'frm.MdiParent = frmPrincipal
        frmp.ShowDialog(Me)

    End Sub

    Private Sub mostrarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mostrarBT.Click
        cabecera = False
        mostrar_resumen_gfts()
    End Sub

    Private Sub dataGtfs_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dataGtfs.SelectionChanged
        Try
            Dim col As Integer
            Dim dtsr As New vShowbrow
            Dim func As New fshowbrow

            If dataGtfs.SelectedRows.Count = 0 Then
                Return
            End If

            Dim dg As DataGridViewRow = dataGtfs.SelectedRows(0)

            If cabecera Then
                Return
            End If

            Label32.Text = "RESUMEN - GTF: " + dg.Cells(2).Value.ToString()
            dtsr.gt_tabla = "listatrozasd"
            dtsr.gt_campos = "ltd_especie as Especie,count(ltd_especie)as Trozas,sum(ltd_vol_m3) as Volm3"
            dtsr.gt_donde = IIf(dg.Cells(0).Value.ToString() <> "", String.Format("ltd_lt_id = {0}", dg.Cells(0).Value.ToString()), "")
            dtsr.gt_agruparpor = "ltd_especie"
            dtsr.gt_ordenarpor = ""

            Dt = func.mostrar(dtsr) 'Invocamos a la funcion mostrar()

            If Dt.Rows.Count <> 0 Then 'Si las filas al contarlas es diferente de cero
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

    Function optener_numero_gtf()

        Dim func As New fshowbrow
        Dim dtsr As New vShowbrow
        dtsr.gt_tabla = "vmostrar_listatrozasportitular"
        dtsr.gt_campos = "Lt_Nrogtf,pro_titular,pro_id"
        dtsr.gt_donde = String.Format("pro_titular = '{0}'", txt_Con_Titular.Text)
        dtsr.gt_agruparpor = ""
        dtsr.gt_ordenarpor = "Lt_Nrogtf"

        row = func.mostrar(dtsr) 'Inv

        Dim ulpos As Integer
        Dim serie1, numero1, ultimo1, numstring1, siguiente1 As String

        ulpos = row.Rows.Count - 1

        'Me.Text = ulpos.ToString
        If ulpos <> -1 Then
            ultimo1 = row.Rows(ulpos).Item("Lt_Nrogtf").ToString()
            serie1 = Mid(ultimo1, 1, 3)
            numero1 = Convert.ToInt32(Mid(ultimo1, 5, 6))
            'Me.Text = ultimo
        Else
            serie1 = "001"
            numero1 = 1
        End If
        numstring1 = Microsoft.VisualBasic.Right("000000" + numero1, 6)
        siguiente1 = serie1 + "-" + numstring1

        Return siguiente1

    End Function

    Private Function optener_siguiente_numero_lista()
        Dim xSerie As String = "0", xNext As String = "0"
        If String.IsNullOrEmpty(xTituloId) = False Then
            Using dm As New samadEntities
                Dim xNumero = (From x In dm.listatrozasc Where x.Lt_Titular_Id = xTituloId Select x.Lt_Nrogtf).Max()
                If String.IsNullOrEmpty(xNumero) = True Then
                    xSerie = "001"
                    xNext = New fxSamad().StrCeros(0, 6, True)
                Else
                    xSerie = Mid(xNumero, 1, 3)
                    xNext = New fxSamad().StrCeros(Mid(xNumero, 5, 6), 6, True)
                End If
            End Using
        End If
        Return xSerie & "-" & xNext
    End Function

    Private Sub txSerie_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txSerie.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                btnDeshacer_Click(sender, e)
            Case Keys.Enter
                If String.IsNullOrEmpty(txSerie.Text) = True Then
                    MessageBox.Show("Ingrese el Numero de serie", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txSerie.Focus()
                    Exit Sub
                End If
                txSerie.Text = Microsoft.VisualBasic.Right("000" + txSerie.Text, 3)
                If txNumero.Text.Length() > 0 Then
                    txNumero.SelectAll()
                End If
                txNumero.Focus()
        End Select
    End Sub

    Private Sub txNumero_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txNumero.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                txSerie.SelectAll()
                txNumero.Undo()
                txSerie.Focus()
            Case Keys.Enter
                If String.IsNullOrEmpty(txNumero.Text) = True Then
                    MessageBox.Show("Ingrese el Numero de GTF", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txNumero.Focus()
                    Exit Sub
                End If
                txNumero.Text = Microsoft.VisualBasic.Right("000000" + txNumero.Text, 6)
                buscar_nrolista_titular()
        End Select
    End Sub

    Private Sub btDetalle_Click(sender As System.Object, e As System.EventArgs)
        GrabarRegistroDetalle()
    End Sub


    Private Sub BtnUbigeo_Click(sender As System.Object, e As System.EventArgs) Handles BtnUbigeo.Click
        'Enviamos los datos de la consulta sql

        frm.t_tabla = "UBIGEO"
        frm.t_campos = "Id,departamento,codigo"
        frm.t_donde = ""
        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Departamento", "Codigo"}
        Dim anchos() As Integer = {30, 200, 30}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)
        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog(Me)

        'Datos del Titular
        If frm.flag = True Then
            TxUbigeo.Text = frm.matColumnas(2)
        End If
    End Sub
#Region "CONTROL DE NUMEROS DE DOCUMENTOS COMPROBANTES Y GUIAS DE REMISION"
    Private Sub TxNro_Cv_Serie_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxNro_Cv_Serie.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                TxNro_Com_Cv.Focus()
            Case Keys.Tab, Keys.Enter
                e.Handled = True
                If String.IsNullOrEmpty(TxNro_Cv_Serie.Text) = True Then
                    MessageBox.Show("Por favor ingrese el Numero de Serie", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    TxNro_Cv_Serie.Focus()
                    Exit Sub
                End If
                If IsNumeric(TxNro_Cv_Serie.Text) = True Then
                    TxNro_Cv_Serie.Text = Microsoft.VisualBasic.Right("000" + TxNro_Cv_Serie.Text, 3)
                End If
                TxNro_Com_Cv.Focus()
        End Select
    End Sub

    Private Sub TxNro_Cv_Serie_Click(sender As Object, e As System.EventArgs) Handles TxNro_Cv_Serie.Click
        TxNro_Cv_Serie.SelectionLength = TxNro_Cv_Serie.Text.Length
    End Sub
    Private Sub TxNro_Com_Cv_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxNro_Com_Cv.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                btnDestino.Focus()
            Case Keys.Tab, Keys.Enter
                e.Handled = True
                If String.IsNullOrEmpty(TxNro_Com_Cv.Text) = True Then
                    MessageBox.Show("Por favor ingrese el Numero de Serie", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    TxNro_Com_Cv.Focus()
                    Exit Sub
                End If
                If IsNumeric(TxNro_Com_Cv.Text) = True Then
                    TxNro_Com_Cv.Text = Microsoft.VisualBasic.Right("000000" + TxNro_Com_Cv.Text, 6)
                    Me.TabControl1.SelectedTab = TabPage2
                End If

                btnDestino.Focus()
        End Select
    End Sub

    Private Sub TxNro_Com_Cv_Click(sender As Object, e As System.EventArgs) Handles TxNro_Com_Cv.Click
        TxNro_Com_Cv.SelectionLength = TxNro_Com_Cv.Text.Length
    End Sub

    Private Sub TxNroSerie_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxNroSerie.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                TxNroGuia.Focus()
            Case Keys.Tab, Keys.Enter
                e.Handled = True
                If String.IsNullOrEmpty(TxNroSerie.Text) = True Then
                    MessageBox.Show("Por favor ingrese el Numero de Serie", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    TxNroSerie.Focus()
                    Exit Sub
                End If
                If IsNumeric(TxNroSerie.Text) = True Then
                    TxNroSerie.Text = Microsoft.VisualBasic.Right("000" + TxNroSerie.Text, 3)
                End If
                TxNroGuia.Focus()
        End Select
    End Sub

    Private Sub TxNroSerie_Click(sender As Object, e As System.EventArgs) Handles TxNroSerie.Click
        TxNroSerie.SelectionLength = TxNroSerie.Text.Length
    End Sub

    Private Sub TxNroGuia_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxNroGuia.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                btnPlaca.Focus()
            Case Keys.Tab, Keys.Enter
                e.Handled = True
                If String.IsNullOrEmpty(TxNroSerie.Text) = True Then
                    MessageBox.Show("Por favor ingrese el Numero de Guia", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    TxNroGuia.Focus()
                    Exit Sub
                End If
                If IsNumeric(TxNroGuia.Text) = True Then
                    TxNroGuia.Text = Microsoft.VisualBasic.Right("000000" + TxNroGuia.Text, 6)
                End If
                btnPlaca.Focus()
        End Select
    End Sub

    Private Sub TxNroGuia_Click(sender As Object, e As System.EventArgs) Handles TxNroGuia.Click
        TxNroGuia.SelectionLength = TxNroGuia.Text.Length
    End Sub

#End Region


    'Private Sub TxNro_Com_Cv_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxNro_Com_Cv.KeyPress
    '    Me.TabControl1.SelectedTab = TabPage2
    'End Sub

    Private Sub Importar_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs)
        FrmImportarGTF.ShowDialog(Me)
    End Sub

    Private Sub BtnImportGTF_Click(sender As System.Object, e As System.EventArgs) Handles BtnImportGTF.Click
        FrmImportarGTF.ShowDialog(Me)
    End Sub
End Class