
Option Explicit On

Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports System.Linq

Public Class wfIngreso_trozas_det

    Friend xExiste As Boolean
    Friend xTipotraslado As String
    Friend xRowPapa As Integer
    Friend xPeriodo As String
    Friend xProcencia As String
    Friend xAbastecimiento As String
    Friend Numtroza As String
    Friend xRowId As Integer
    Friend xEstatus As Integer

    Dim xTitulo = fxSamad.Titulo
    Dim IDZAFRA As Integer
    Dim XZAFRA As Integer
    Dim ContratoId As Integer
    Dim ListaTrozas As List(Of listatrozasd)
    Dim xDoIt As Boolean
    Dim xGtf As String
    Dim xLtd_lt_Id As Integer
    Dim ListaTrozasd As List(Of listatrozasc)
    Dim xRow As GridRow = Nothing


#Region "Funciones y Procedimientos locales del Sistema(Nuevo Codigo)"

    'Private Sub GrabarRegisto()
    '    Dim dt As New SAMAD.formato01_det
    '    If xExiste = True Then
    '        dt.F01d_Id = xRowId
    '    End If
    '    dt.F01d_F01_Id = xRowPapa
    '    dt.F01d_GuiaRemision = TxSerie_Gr.Text & "-" & txGuia.Text
    '    dt.F01d_Gtf = xGtf
    '    dt.F01d_Lista_trozas = TxNlista.Text
    '    dt.F01d_Correlativo = txNumtroza.Text
    '    dt.F01d_Especie = txEspecie.Text
    '    dt.F01d_D1 = txtD1.Text
    '    dt.F01d_D2 = txtD2.Text
    '    dt.F01d_D3 = txtD3.Text
    '    dt.F01d_Especiec = txEspeciec.Text
    '    dt.F01d_Observacion = txObservacion.Text
    '    dt.F01d_Ubicacion = TxUbicacion.Text
    '    dt.F01d_Vol_M3 = txtVol3.Text
    '    dt.F01d_Autogenerado = txtAutogenerado.Text
    '    dt.f01d_Veh_Placa = txPlaca.Text
    '    dt.f01d_Conductor = txConductor.Text
    '    dt.F01d_CodIndustria = txtCodIndustria.Text
    '    dt.F01d_Tipo = xTipotraslado
    '    dt.F01d_PropietarioId = TxProcedenciaId.Text
    '    dt.F01d_Procedencia = TxProcedencia.Text
    '    dt.F01d_Abastecimiento = CbAbastecimiento.Text
    '    dt.F01d_unidad = cbUnidad.Text
    '    dt.F01d_Lote = txLote.Text
    '    dt.F01d_PropietarioId = TxPropietarioId.Text
    '    dt.F01d_Emp_Transp_id = txtEmpresa_transpid.Text
    '    dt.F01d_Calidad = CbCalidad.Text
    '    If cbUnidad.SelectedIndex = 0 Then
    '        dt.F01d_D1c = txtD1c.Text
    '        dt.F01d_D2c = txtD2c.Text
    '        dt.F01d_D3c = txtD3c.Text
    '        dt.F01d_Vol_M3c = txtVolm3c.Text
    '    Else
    '        dt.F01d_Dm_pulgada = txtD2c.Text
    '        dt.F01d_Long_pie = txtD3c.Text
    '        dt.F01d_Vol_pt = txtVolm3c.Text
    '    End If
    'End Sub

    Private Sub CalcularM3()
        Try
            If cbUnidad.SelectedIndex = 0 Then
                txtVolm3c.Text = New fxSamad().FormulaSmalian(CDec(txtD1c.Text), CDec(txtD2c.Text), CDbl(txtD3c.Text), 3)
            Else
                txtVolm3c.Text = New fxSamad().FormulaDoyle(CDec(txtD2c.Text), CDbl(txtD3c.Text), 3)
            End If
        Catch ex As Exception
            txtVolm3c.Text = "0.00"
        End Try

    End Sub

    Private Sub ListarTrozas()
        Dim xPanel As GridPanel = dgDetalle.PrimaryGrid
        Dim x As Long = 0
        Dim xTotalM3 As Decimal = 0
        Dim xRow As GridRow = Nothing
        xPanel.Rows.Clear()
        If ListaTrozas.Count > 0 Then
            For x = 0 To ListaTrozas.Count - 1
                xRow = New GridRow(ListaTrozas(x).Ltd_Id, ListaTrozas(x).Ltd_Especie, ListaTrozas(x).Ltd_Codificacion, ListaTrozas(x).Ltd_D1, ListaTrozas(x).Ltd_D2, ListaTrozas(x).Ltd_D3, ListaTrozas(x).Ltd_Vol_M3)
                xPanel.Rows.Add(xRow)
                xTotalM3 = xTotalM3 + ListaTrozas(x).Ltd_Vol_M3
            Next
        End If
        txCantrozas.Text = ListaTrozas.Count()
        txTotalM3.Text = xTotalM3
    End Sub

    Private Sub VerDatosTroza()
        Dim xespcie As String

        Dim dt = New cdListatrozasd().GetTrozaInfo(txTrozaId.Text, txTitularId.Text, XZAFRA)
            'TxPropietarioId.Text = dt.PropietarioId
            'TxPropietario.Text = dt.Nombre_propietario
            txEspecieId.Text = dt.EspecieId
            txEspecie.Text = dt.especie
            txEspeciec.Text = dt.especie

            If TxEspecieLt.Text = "" Then
                'inserta id y nombre de especie para la generacion del nro de lote x especie
                txIdEspecieLte.Text = dt.EspecieId
                TxEspecieLt.Text = dt.especie
                xespcie = TxEspecieLt.Text
                'fin
            Else
                If txIdEspecieLte.Text = txEspecieId.Text Then
                    TxEspecieLt.Text = TxEspecieLt.Text
                Else
                    If MessageBox.Show("Especie diferente a del Lote Asignado, Desea seguier usando el Nro. de Lote para esta Especie?", "Advertencia", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
                        TxEspecieLt.Text = TxEspecieLt.Text
                    Else
                        txIdEspecieLte.Text = dt.EspecieId
                        TxEspecieLt.Text = dt.especie

                    End If
                End If
            End If


            TxNgtf.Text = dt.Lt_Nrogtf
            TxNlista.Text = dt.Ltd_NroListaTrozas
            txNumtroza.Text = dt.Numtroza
            txtD1.Text = dt.Ltd_D1
            txtD2.Text = dt.Ltd_D2
            txtD3.Text = dt.Ltd_D3
            txtVol3.Text = dt.Ltd_Vol_M3
            txtAutogenerado.Text = dt.Lt_Nrogtf & "." & dt.PropietarioId & "." & dt.RowId
            If rbNomedir.Checked = False Then
                Dim xVm3 As Decimal = 0
                txtD1c.Text = ""
                txtD2c.Text = ""
                txtD3c.Text = ""
                txtVolm3c.Text = ""
                txtD1c.WatermarkText = dt.Ltd_D1
                txtD2c.WatermarkText = dt.Ltd_D2
                txtD3c.WatermarkText = dt.Ltd_D3
                txtVolm3c.WatermarkText = New fxSamad().VolMet3(CDec(dt.Ltd_D1), dt.Ltd_D2, CDbl(dt.Ltd_D3), cbUnidad.SelectedIndex)
                If CheckBox3.Checked = True Then
                    txtD1c.Text = dt.Ltd_D1
                    txtD2c.Text = dt.Ltd_D2
                    txtD3c.Text = dt.Ltd_D3
                    txtVolm3c.Text = New fxSamad().VolMet3(CDec(dt.Ltd_D1), dt.Ltd_D2, CDbl(dt.Ltd_D3), cbUnidad.SelectedIndex)
                End If
            Else
                txtD1c.Text = dt.Ltd_D1
                txtD2c.Text = dt.Ltd_D2
                txtD3c.Text = dt.Ltd_D3
                txtVolm3c.Text = New fxSamad().VolMet3(CDec(dt.Ltd_D1), dt.Ltd_D2, CDbl(dt.Ltd_D3), cbUnidad.SelectedIndex)

        End If

            xGtf = dt.Lt_Nrogtf
        IDZAFRA = dt.Lt_Poa_Id
        xLtd_lt_Id = dt.Ltd_Lt_Id

    End Sub
    Private Sub Carga_transporte()

    End Sub
    Private Sub ActualizaListaTrozas()
        Dim dm As New samadEntities
        ''ListaTrozas = dm.listatrozasd.Where(Function(p) p.listatrozasc.Lt_Titular_Id = txTitularId.Text And p.Ltd_NroListaTrozas = cbGtf.Text And p.Estatus = 0).ToList()
        'ListaTrozas = dm.listatrozasd.Where(Function(p) p.listatrozasc.Lt_Titular_Id = txTitularId.Text And p.listatrozasc.Lt_Nrogtf = cbGtf.Text And p.Estatus = 0).ToList()
        ListaTrozas = dm.listatrozasd.Where(Function(p) p.listatrozasc.Lt_Titular_Id = txTitularId.Text And p.Estatus = 0).ToList()

        ListarTrozas()

    End Sub

#End Region

    Private Sub wfIngreso_trozas_det_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim xPanel As GridPanel = dgDetalle.PrimaryGrid

        rbNomedir.Checked = True

        If xExiste = False Then
            xPanel.MultiSelect = True

        Else
            'Cargar el registro a Editar
            txTrozaId.Text = Numtroza
            'TxProcedencia.Text = xProcencia
            'CbAbastecimiento.Text = xAbastecimiento
            xPanel.MultiSelect = False
            Llena_DatosParaEdicion()
        End If
    End Sub

    Private Sub Llena_DatosParaEdicion()
        Dim ne As New samadEntities
        Dim dm As New SAMAD.formato01_det
        Dim dt As New cdFormato01Det


        dm = dt.GetDatosEdicionTroza(xRowId)
        'Dim dmr = ne.formato01_det.Where(Function(x) x.F01d_Id = xRowId And x.Estatus = 0).ToList.FirstOrDefault()

        If Not dm Is Nothing Then
            TxProcedenciaId.Text = dm.f01d_Pro_Id
            TxProcedencia.Text = dm.F01d_Procedencia
            CbAbastecimiento.Text = dm.F01d_Abastecimiento
            TxPropietarioId.Text = dm.F01d_PropietarioId
            TxPropietario.Text = dm.F01d_Propietario
            TxUbicacionId.Text = dm.f01d_Ub_Id
            TxUbicacion.Text = dm.F01d_Ubicacion
            TxSerie_Gr.Text = Mid(dm.F01d_GuiaRemision, 1, 3)
            txGuia.Text = Mid(dm.F01d_GuiaRemision, 5, 6)
            txtEmpresa_transpid.Text = IIf(IsNothing(dm.F01d_Emp_Transp_id) = True, "", dm.F01d_Emp_Transp_id)
            txtEmpresa_transp.Text = IIf(IsNothing(dm.F01d_Emp_Transp) = True, "", dm.F01d_Emp_Transp)
            txConductorId.Text = dm.f01d_con_Id
            txConductor.Text = dm.f01d_Conductor
            txCamionId.Text = dm.f01d_veh_Id
            txPlaca.Text = dm.f01d_Veh_Placa
            txObservacion.Text = dm.F01d_Observacion
            txTitularId.Text = dm.F01d_TitularId
            txTitular.Text = dm.F01d_Titular
            TxNgtf.Text = dm.F01d_Gtf
            TxNlista.Text = dm.F01d_Lista_trozas
            txEspecie.Text = dm.F01d_Especie
            txNumtroza.Text = dm.F01d_Correlativo
            txtD1.Text = dm.F01d_D1
            txtD2.Text = dm.F01d_D2
            txtD3.Text = dm.F01d_D3
            txtVol3.Text = dm.F01d_Vol_M3


            cbUnidad.Text = dm.F01d_unidad
            txEspecieId.Text = dm.EspecieId
            txEspeciec.Text = dm.F01d_Especiec
            txtAutogenerado.Text = dm.F01d_Autogenerado
            txtCodIndustria.Text = dm.F01d_CodIndustria
            CbCalidad.Text = dm.F01d_Calidad
            txtD1c.Text = dm.F01d_D1c
            txtD2c.Text = dm.F01d_D2c
            txtD3c.Text = dm.F01d_D3c
            txtVolm3c.Text = dm.F01d_Vol_M3c


            txIdEspecieLte.Text = dm.EspecieId.ToString()
            TxEspecieLt.Text = dm.F01d_Especiec
            txLote.Text = dm.F01d_Lote

            CheckBox3.Enabled = False
        End If

    End Sub

#Region "SE RALIZA LA FILTRACION DE LA LISTA DE TROZAS INGRESADAS EN EL FORMULARIO GUIAS DE TRANSPORTE FORESTAL"

    '******* Primer Filtro por titular de Titulo Habilitante*******************

    Private Sub txTitular_ButtonCustomClick(sender As System.Object, e As System.EventArgs) Handles txTitular.ButtonCustomClick
        Dim wfBuscar As New frmShowbrow
        wfBuscar.titulo = "Titulares "
        wfBuscar.t_tabla = "vw_titulares01"
        wfBuscar.t_campos = "TitularId,Nombre_titular,Num_contrato,ContratoId"
        wfBuscar.t_donde = ""
        wfBuscar.t_agruparpor = ""
        wfBuscar.t_ordenarpor = ""
        Dim titulos() As String = {"Id Titular", "Nombre Titularl", "Num contrato"}
        Dim anchos() As Integer = {60, 250, 100, 0}
        ReDim wfBuscar.matAnchos(anchos.Length)
        ReDim wfBuscar.matTitulos(titulos.Length)
        ReDim wfBuscar.matColumnas(titulos.Length)
        titulos.CopyTo(wfBuscar.matTitulos, 0)
        anchos.CopyTo(wfBuscar.matAnchos, 0)
        wfBuscar.ShowDialog(Me)
        If wfBuscar.flag = True Then
            ContratoId = wfBuscar.matColumnas(3)
            txTitularId.Text = wfBuscar.matColumnas(0)
            txTitular.Text = wfBuscar.matColumnas(1)
            Dim dm As New samadEntities
            xDoIt = False
            cbZafra.DataSource = dm.zafrasypoas.Where(Function(p) p.Zyp_Permiso_Id = ContratoId).Select(Function(p) p.Zyp_Zafra).Distinct().ToList()
            cbZafra.SelectedItem = Nothing
            ListaTrozas = (From ld In dm.listatrozasd From lc In dm.listatrozasc
                                Where ld.Ltd_Lt_Id = lc.Lt_id And lc.Lt_Contrato_Id = ContratoId And ld.Estatus = 0
                                Select ld).ToList()
            ' dgTrozas.DataSource = ListaTrozas
            cbUnidad.Text = "Smalian"
            ListarTrozas()
            xDoIt = True
            'TodosRB.Checked = True
        End If
        '------------        
        wfBuscar = Nothing
    End Sub

    '*************Segundo Filtro Por Zafra Basado Solo en los datos de Filtrado anterior***********
    Private Sub cbZafra_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbZafra.SelectedIndexChanged
        If xDoIt = True Then
            Dim dm As New samadEntities
            'Dim xzafra As Integer

            XZAFRA = cbZafra.SelectedItem
            If Not XZAFRA = 1 Then
                xDoIt = False
                cbPoa.DataSource = dm.zafrasypoas.Where(Function(p) p.Zyp_Zafra = XZAFRA And p.Zyp_Permiso_Id = ContratoId)
                cbPoa.SelectedItem = Nothing
                ListaTrozas = (From t In dm.listatrozasd From z In dm.zafrasypoas
                               Where t.listatrozasc.Lt_Poa_Id = z.Zyp_id And z.Zyp_Zafra = XZAFRA And z.Zyp_Permiso_Id = ContratoId And
                              t.Estatus = 0 Select t).ToList()
                ListarTrozas()
                xDoIt = True
            End If
        End If
    End Sub

    '********************Tercer Filtro Por Pca Basado Solo en los datos del Filtrado anterior****************

    Private Sub cbPoa_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbPoa.SelectedIndexChanged
        If xDoIt = True Then
            Dim db As New samadEntities
            Dim xpoa As zafrasypoas
            xpoa = cbPoa.SelectedItem
            If Not xpoa Is Nothing Then
                xDoIt = False
                cbGtf.DataSource = db.listatrozasc.Where(Function(p) p.Lt_Poa_Id = xpoa.Zyp_id And p.Estatus = 0).ToList()
                cbGtf.SelectedItem = Nothing
                ListaTrozas = db.listatrozasd.Where(Function(p) p.listatrozasc.Lt_Poa_Id = xpoa.Zyp_id And p.Estatus = 0).ToList()
                ListarTrozas()
                xDoIt = True
            End If
        End If
    End Sub

    '***************Cuarto Filtro Por Nro GTF Basado Solo en los datos del Filtrado anterior***************

    Private Sub cbGtf_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbGtf.SelectedIndexChanged
        If xDoIt = True Then
            Dim dm As New samadEntities
            Dim xGtf As listatrozasc = cbGtf.SelectedItem
            If Not xGtf Is Nothing Then
                Dim dConductor = dm.conductores.Where(Function(t) t.Con_Id = xGtf.Lt_Conductor_Id).FirstOrDefault()
                txConductorId.Text = dConductor.Con_Id
                txConductor.Text = dConductor.Con_NomApe
                Dim dVehiculo = dm.vehiculos.Where(Function(v) v.Veh_Emt_Id = xGtf.Lt_Transporte_Id).FirstOrDefault()
                txCamionId.Text = dVehiculo.Veh_Id
                txPlaca.Text = dVehiculo.Veh_Placa
                Dim NomEmpTransporte = dm.titulares.Where(Function(x) x.Pro_Id = dVehiculo.Veh_Emt_Id).FirstOrDefault()
                txtEmpresa_transp.Text = NomEmpTransporte.Pro_Titular
                Dim NomPropietario = dm.titulares.Where(Function(y) y.Pro_Id = xGtf.Lt_Propietario_Id).FirstOrDefault()
                TxPropietario.Text = NomPropietario.Pro_Titular
                TxPropietarioId.Text = NomPropietario.Pro_Id
                Dim Nroserie = xGtf.Lt_NroGuia_rem
                TxSerie_Gr.Text = Mid(Nroserie, 1, 3)
                txGuia.Text = Mid(Nroserie, 5, Len(Nroserie) - 4)

                ListaTrozas = dm.listatrozasd.Where(Function(p) p.Ltd_Lt_Id = xGtf.Lt_id And p.Estatus = 0).ToList()
            End If
            ListarTrozas()
        End If
    End Sub

#End Region

#Region "Comportamiento de las Opciones Asignar todas latrozas por GTf y por correlativo"

    'Comportamiento del Evento RbNgtf_CheckedChanged si se seleccionan para agregar a la Recepcion de Trozas por Todo el Numero de GTF

    Private Sub RbNgtf_CheckedChanged(sender As System.Object, e As System.EventArgs)
        cbUnidad.Enabled = False
        dgDetalle.Enabled = False
        'cbUnidad.Enabled = ""
        txEspeciec.Text = ""
        txtCodIndustria.Text = ""
        txtD1c.Text = ""
        txtD2c.Text = ""
        txtD3c.Text = ""
        txtVolm3c.Text = ""
        uD1.Text = "m."
        uD2.Text = "m."
        uD3.Text = "m."
        uVol.Text = "m3"

        txtD1c.Enabled = False
        txtD2c.Enabled = False
        txtD3c.Enabled = False
        TxCorrelativo.Enabled = False
        rbRemedir.Enabled = False
        rbNomedir.Enabled = False
        txtCodIndustria.Enabled = False
        CbCalidad.Enabled = False
        'GroupPanel4.Enabled = False

        'Me.CheckBox1.Checked = False
    End Sub

    Private Sub RbCorrelativo_CheckedChanged(sender As System.Object, e As System.EventArgs)
        'cbUnidad.Enabled = False
        dgDetalle.Enabled = False
        'cbUnidad.Enabled = ""
        'txtD1c.Text = ""
        'txtD2c.Text = ""
        'txtD3c.Text = ""
        'txtVolm3c.Text = ""
        TxCorrelativo.Enabled = True
        rbRemedir.Enabled = True
        rbNomedir.Enabled = True
        'txtCodIndustria.Enabled = True
        'CbCalidad.Enabled = True
        GroupPanel4.Enabled = True

    End Sub
#End Region

#Region "las Opciones para decidir si se va Realizar medidas Planta de transformacion y el tipo de calculo de volumen que se va ha utilizar"

    Private Sub rbRemedir_Click(sender As Object, e As System.EventArgs) Handles rbRemedir.Click
        If Me.CheckBox2.Checked = True Then
            'dgDetalle.Enabled = True
            cbUnidad.Enabled = True
            txtD1c.Text = ""
            txtD2c.Text = ""
            txtD3c.Text = ""
            txtVolm3c.Text = ""
            txtD1c.Focus()
            SeleccionUnidad()
        Else
            dgDetalle.Enabled = True
            cbUnidad.Enabled = True
            txtD1c.Text = ""
            txtD2c.Text = ""
            txtD3c.Text = ""
            txtVolm3c.Text = ""
            txtD1c.Focus()
            SeleccionUnidad()
        End If
 
    End Sub

    Private Sub rbNomedir_Click(sender As Object, e As System.EventArgs) Handles rbNomedir.Click
        dgDetalle.Enabled = True
        cbUnidad.Enabled = False
        cbUnidad.Text = "Smalian"
        If cbUnidad.SelectedIndex = 0 Then
            txtD1c.Text = txtD1.Text
            txtD2c.Text = txtD2.Text
            txtD3c.Text = txtD3.Text
            txtVolm3c.Text = txtVol3.Text
            uD1.Text = "m."
            uD2.Text = "m."
            uD3.Text = "m."
            uVol.Text = "m3"
            txtD1c.Enabled = False
            txtD2c.Enabled = False
            txtD3c.Enabled = False
        End If
        'txtD1c.ReadOnly = False
        'txtD1c.Focus()
    End Sub


    'Si Se decidio Realizar Mediadas de las trozas al ingresar a la Planta de transformacion de debera seleccionar una dala obciones de calculo contenidas en el combobox

    Private Sub SeleccionUnidad()
        If rbRemedir.Checked Then
            If cbUnidad.Text = "Smalian" Then
                uD1.Text = "m."
                uD2.Text = "m."
                uD3.Text = "m."
                uVol.Text = "Vol. M3"
                txtD1c.Enabled = True
                txtD2c.Enabled = True
                txtD3c.Enabled = True

            End If
            'Else
            If cbUnidad.Text = "Doyle" Then
                uD2.Text = "Pulg."
                uD3.Text = "Pies"
                uD1.Text = "__"
                'uVol.Text = "pies tablares"
                txtD1c.Enabled = False
                txtD2c.Enabled = True
                txtD3c.Enabled = True
                uVol.Text = "Vol. pt"
                txtD1c.Text = 0
                txtD2c.Text = ""
                txtD3c.Text = ""
                txtVolm3c.Text = ""
            End If
        End If
    End Sub
    Private Sub cbUnidad_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbUnidad.SelectedIndexChanged
        SeleccionUnidad()
    End Sub
#End Region

#Region "Filtro usando la Clase ShowBrows par Asiganr Registros a textbos"

    'DATOS DE REFERENCIAS: Se refieres al registro de los datos de procedencia y propietario final de troza a recepcionar en planta de transformacion

    'Registra a travez de un maestro el lugar o procedencia de la madera Rolliza

    Private Sub TxProcedencia_ButtonCustomClick(sender As Object, e As System.EventArgs) Handles TxProcedencia.ButtonCustomClick
        Dim wfBuscar As New frmShowbrow
        wfBuscar.titulo = "Procedencia de la Madera"
        wfBuscar.t_tabla = "procedencia"
        wfBuscar.t_campos = "pro_id,pro_nombre"
        wfBuscar.t_donde = ""
        wfBuscar.t_agruparpor = ""
        wfBuscar.t_ordenarpor = ""
        Dim titulos() As String = {"Codigo", "Nombre"}
        Dim anchos() As Integer = {50, 180}
        ReDim wfBuscar.matAnchos(anchos.Length)
        ReDim wfBuscar.matTitulos(titulos.Length)
        ReDim wfBuscar.matColumnas(titulos.Length)
        titulos.CopyTo(wfBuscar.matTitulos, 0)
        anchos.CopyTo(wfBuscar.matAnchos, 0)
        wfBuscar.ShowDialog(Me)
        If wfBuscar.flag = True Then
            TxProcedenciaId.Text = wfBuscar.matColumnas(0)
            TxProcedencia.Text = wfBuscar.matColumnas(1)
        End If
    End Sub

    'Comportamiento del Combobox en el evento seleccion y Kypres del sistema de abastecimiento de madera rolliza optado por la industra 
    Private Sub CbAbastecimiento_Keydown(sender As System.Object, e As System.EventArgs) Handles CbAbastecimiento.KeyDown
        txLote.Select()
        txLote.Focus()
    End Sub

    Private Sub txLote_Click(sender As Object, e As System.EventArgs) Handles txLote.Click
        txLote.SelectionLength = txLote.Text.Length
    End Sub

    'Comportamiento del TextBox en el Evento KeyDown para el registro del Nro Lote

    Private Sub txLote__KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txLote.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                txLote.Focus()
            Case Keys.Tab, Keys.Enter
                e.Handled = True
                If String.IsNullOrEmpty(txLote.Text) = True Then
                    MessageBox.Show("Por favor ingrese el Numero de Lote", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txLote.Focus()
                    Exit Sub
                End If
                If IsNumeric(txLote.Text) = True Then
                    txLote.Text = Microsoft.VisualBasic.Right("000000" + txLote.Text, 6)
                End If
                'txtCodIndustria.Select()

        End Select
    End Sub

    'Comportamiento del TextBox txpropietario en el Eventp KeyDown Para el Registro de Propietario del producto

    Private Sub txpropietario_ButtonCustomClick(sender As Object, e As System.EventArgs) Handles TxPropietario.ButtonCustomClick
        Dim wfBuscar As New frmShowbrow
        wfBuscar.titulo = "Propietario Final de la Madera"
        wfBuscar.t_tabla = "titulares"
        wfBuscar.t_campos = "Pro_id,Pro_Titular,Pro_Ruc"
        wfBuscar.t_donde = "Pro_Propietariock = true"
        wfBuscar.t_agruparpor = ""
        wfBuscar.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Descripcion", "Ruc"}
        Dim anchos() As Integer = {30, 200, 90}

        ReDim wfBuscar.matAnchos(anchos.Length)
        ReDim wfBuscar.matTitulos(titulos.Length)
        ReDim wfBuscar.matColumnas(titulos.Length)
        titulos.CopyTo(wfBuscar.matTitulos, 0)
        anchos.CopyTo(wfBuscar.matAnchos, 0)
        wfBuscar.ShowDialog(Me)
        If wfBuscar.flag = True Then
            TxPropietarioId.Text = wfBuscar.matColumnas(0)
            TxPropietario.Text = wfBuscar.matColumnas(1)
        End If
        wfBuscar = Nothing
    End Sub

    'Comportamiento del TextBox txubicacion en el Eventp KeyDown Para el Registro de Ubicacion del producto (Tozad)

    Private Sub txUbicacion_ButtonCustomClick(sender As System.Object, e As System.EventArgs) Handles TxUbicacion.ButtonCustomClick
        Dim wfBuscar As New frmShowbrow
        wfBuscar.titulo = "Lista de Ubicaciones"
        wfBuscar.t_tabla = "ubicacion"
        wfBuscar.t_campos = "ubi_id,ubi_nombre,ubi_proid"
        wfBuscar.t_donde = ""
        wfBuscar.t_agruparpor = ""
        wfBuscar.t_ordenarpor = ""
        Dim titulos() As String = {"Id", "Nombre", "Propietario"}
        Dim anchos() As Integer = {50, 260, 100}
        ReDim wfBuscar.matAnchos(anchos.Length)
        ReDim wfBuscar.matTitulos(titulos.Length)
        ReDim wfBuscar.matColumnas(titulos.Length)
        titulos.CopyTo(wfBuscar.matTitulos, 0)
        anchos.CopyTo(wfBuscar.matAnchos, 0)
        wfBuscar.ShowDialog(Me)
        If wfBuscar.flag = True Then
            TxUbicacionId.Text = wfBuscar.matColumnas(0)
            TxUbicacion.Text = wfBuscar.matColumnas(1)
        End If
    End Sub



    'Comportamiento de los textbox para el registro del numero de Guia de Remicion
    'Inserta la Seri
    Private Sub TxSerie_Gr_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxSerie_Gr.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                'btEspecie.Focus()
            Case Keys.Tab, Keys.Enter
                e.Handled = True
                If String.IsNullOrEmpty(TxSerie_Gr.Text) = True Then
                    MessageBox.Show("Por favor ingrese el Numero de Serie de la Guia de Remision", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    TxSerie_Gr.Focus()
                    Exit Sub
                End If
                If IsNumeric(TxSerie_Gr.Text) = True Then
                    TxSerie_Gr.Text = Microsoft.VisualBasic.Right("000" + TxSerie_Gr.Text, 3)
                End If
                txGuia.Select()
                txGuia.Focus()
        End Select
    End Sub
    Private Sub TxSerie_Gr_Click(sender As Object, e As System.EventArgs) Handles TxSerie_Gr.Click
        TxSerie_Gr.SelectionLength = TxSerie_Gr.Text.Length
    End Sub

    'Inserta el Nro de la Guia

    Private Sub txGuia_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txGuia.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                'btEspecie.Focus()
            Case Keys.Tab, Keys.Enter
                e.Handled = True
                If String.IsNullOrEmpty(txGuia.Text) = True Then
                    MessageBox.Show("Por favor ingrese el Numero de la Guia de Remision", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txGuia.Focus()
                    Exit Sub
                End If
                If IsNumeric(txGuia.Text) = True Then
                    txGuia.Text = Microsoft.VisualBasic.Right("000000" + txGuia.Text, 6)
                End If
                txtEmpresa_transp.Select()

        End Select
    End Sub
    Private Sub txGuia_Click(sender As Object, e As System.EventArgs) Handles txGuia.Click
        txGuia.SelectionLength = txGuia.Text.Length
    End Sub

    'Registra y asigna busqueda de Enpresas de Tansporte al Textbox txtEmpresa_transp

    Private Sub txtEmpresa_transp_ButtonCustomClick1(sender As Object, e As System.EventArgs) Handles txtEmpresa_transp.ButtonCustomClick
        Dim wfBuscar As New frmShowbrow
        wfBuscar.titulo = "Lista de Empresas Acerrios"
        wfBuscar.t_tabla = "titulares"
        wfBuscar.t_campos = "Pro_id,Pro_Titular,Pro_Ruc"
        wfBuscar.t_donde = "Pro_Transporteck = true"
        wfBuscar.t_agruparpor = ""
        wfBuscar.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Descripcion", "Ruc"}
        Dim anchos() As Integer = {30, 200, 90}

        ReDim wfBuscar.matAnchos(anchos.Length)
        ReDim wfBuscar.matTitulos(titulos.Length)
        ReDim wfBuscar.matColumnas(titulos.Length)
        titulos.CopyTo(wfBuscar.matTitulos, 0)
        anchos.CopyTo(wfBuscar.matAnchos, 0)
        wfBuscar.ShowDialog()
        If wfBuscar.flag = True Then
            txtEmpresa_transpid.Text = wfBuscar.matColumnas(0)
            txtEmpresa_transp.Text = wfBuscar.matColumnas(1)
            txConductor.Enabled = True
        End If
        wfBuscar = Nothing

    End Sub

    'Registra y asigna busqueda del conductor filtrado por Enpresas de Tansporte al Textbox txConductor

    Private Sub txConductor_ButtonCustomClick(sender As Object, e As System.EventArgs) Handles txConductor.ButtonCustomClick
        Dim wfBuscar As New frmShowbrow
        wfBuscar.titulo = "Conductores"
        wfBuscar.t_tabla = "conductores"
        wfBuscar.t_campos = "con_id,con_nomape,con_nrolicencia,con_dni,Con_Emt_id"
        wfBuscar.t_donde = "Con_Emt_id=" + txtEmpresa_transpid.Text
        wfBuscar.t_agruparpor = ""
        wfBuscar.t_ordenarpor = ""
        Dim titulos() As String = {"Id", "Conductor", "Licencia", "Dni"}
        Dim anchos() As Integer = {30, 180, 90, 60}
        ReDim wfBuscar.matAnchos(anchos.Length)
        ReDim wfBuscar.matTitulos(titulos.Length)
        ReDim wfBuscar.matColumnas(titulos.Length)
        titulos.CopyTo(wfBuscar.matTitulos, 0)
        anchos.CopyTo(wfBuscar.matAnchos, 0)
        wfBuscar.ShowDialog(Me)
        If wfBuscar.flag = True Then
            txConductorId.Text = wfBuscar.matColumnas(0)
            txConductor.Text = wfBuscar.matColumnas(1)

        End If
        txPlaca.Enabled = True
    End Sub

    'Registra y asigna busqueda de la Placa de Vehiculo filtrado por Enpresas de Tansporte al Textbox  txPlaca

    Private Sub txPlaca_ButtonCustomClick(sender As Object, e As System.EventArgs) Handles txPlaca.ButtonCustomClick
        Dim wfBuscar As New frmShowbrow
        wfBuscar.titulo = "Lista de Vehiculos"
        wfBuscar.t_tabla = "vehiculos"
        wfBuscar.t_campos = "veh_id,veh_placa,veh_marca,Veh_Emt_id"
        wfBuscar.t_donde = "Veh_Emt_id = " + txtEmpresa_transpid.Text
        wfBuscar.t_agruparpor = ""
        wfBuscar.t_ordenarpor = ""
        Dim titulos() As String = {"Id", "Placa", "Marca"}
        Dim anchos() As Integer = {50, 100, 100}
        ReDim wfBuscar.matAnchos(anchos.Length)
        ReDim wfBuscar.matTitulos(titulos.Length)
        ReDim wfBuscar.matColumnas(titulos.Length)
        titulos.CopyTo(wfBuscar.matTitulos, 0)
        anchos.CopyTo(wfBuscar.matAnchos, 0)
        wfBuscar.ShowDialog(Me)
        If wfBuscar.flag = True Then
            txCamionId.Text = wfBuscar.matColumnas(0)
            txPlaca.Text = wfBuscar.matColumnas(1)
        End If
        txEspecie.Select()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txEspeciec_ButtonCustomClick(sender As System.Object, e As System.EventArgs) Handles txEspeciec.ButtonCustomClick
        Dim wfBuscar As New frmShowbrow
        wfBuscar.titulo = "Especies Maderables"
        wfBuscar.t_tabla = "especies"
        wfBuscar.t_campos = "espe_id,espe_nombrecomun"
        wfBuscar.t_donde = ""
        wfBuscar.t_agruparpor = ""
        wfBuscar.t_ordenarpor = ""
        Dim titulos() As String = {"Id", "Nombre Común"}
        Dim anchos() As Integer = {50, 200}
        ReDim wfBuscar.matAnchos(anchos.Length)
        ReDim wfBuscar.matTitulos(titulos.Length)
        ReDim wfBuscar.matColumnas(titulos.Length)
        titulos.CopyTo(wfBuscar.matTitulos, 0)
        anchos.CopyTo(wfBuscar.matAnchos, 0)
        wfBuscar.ShowDialog(Me)
        If wfBuscar.flag = True Then
            txEspeciec.Text = wfBuscar.matColumnas(1)
        End If
    End Sub
#End Region

    Private Sub inden_cambio_esp()
        Dim idespecieLt As Integer
        Dim especielte As String

        idespecieLt = txIdEspecieLte.Text
        especielte = TxEspecieLt.Text

        If idespecieLt = txIdEspecieLte.Text And especielte = TxEspecieLt.Text Then
            MessageBox.Show("hola es repetido")

        ElseIf especielte <> TxEspecieLt.Text And especielte <> TxEspecieLt.Text Then
            MessageBox.Show("Es repetido")
        End If
    End Sub

    Private Sub dgDetalle_Click(sender As System.Object, e As System.EventArgs) Handles dgDetalle.Click
        Dim xPanel As GridPanel = dgDetalle.PrimaryGrid
        If CheckBox3.Checked Or CheckBox2.Checked = True Then

        Else
            If dgDetalle.GetSelectedRows.Count = 1 Then
                txTrozaId.Text = ""
                xRow = xPanel.ActiveRow()

                If CheckBox3.Checked = True Then
                    Limpiar_TextBox_br()
                Else
                    If IsNothing(xPanel.ActiveRow()) = True Then
                        Limpia_Textboxs_error()
                    Else
                        Agrega_datos_VerDatosTrozas()
                    End If
                End If

            Else
                Limpia_TextBox_Clic_Grid_Varios()
            End If
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        Dim ent = New samadEntities
        If String.IsNullOrEmpty(txTitularId.Text) = True Then
            MessageBox.Show("No hay registro que agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim res = ent.formato01_det.Where(Function(x) x.F01d_F01_Id = txTitularId.Text And x.Periodo = xPeriodo And x.F01d_CodIndustria = txtCodIndustria.Text).FirstOrDefault()
            If Not res Is Nothing Then
                MessageBox.Show("El código de industria ya esta se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        If xExiste = False Then
            If CheckBox3.Checked = True Then
                If dgDetalle.PrimaryGrid.Rows.Count > 0 Then
                    'DATOS DE REFERENCIAS
                    '
                    If VALIDA_DATOS_DE_REFERENCIAS() = False Then
                        Exit Sub
                    End If
                    If ChkTransporte.Checked = True Then

                    Else
                        VALIDA_DATOS_TRANSPORTISTA()
                    End If


                    If String.IsNullOrEmpty(cbGtf.Text) = True Then
                        If MessageBox.Show("Debe seleccionar un Número de GTF", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                            cbGtf.BackColor = Color.LightYellow
                            cbGtf.Focus()
                            'Return True
                            'Exit Sub
                        End If
                    End If
                    'GroupPanel4.Enabled = False
                    For Each oRow As GridRow In dgDetalle.PrimaryGrid.Rows
                        txTrozaId.Text = oRow.Cells(2).Value
                        VerDatosTroza()
                        SaveRecord()
                    Next

                    ListaTrozas = Nothing

                    'Dim xlistac As listatrozasc = dm.listatrozasc.First(Function(x) x.Lt_Nrogtf = cbGtf.Text)
                    'xlistac.Estatus = 1
                    'dm.SaveChanges()
                    Dim xPanel As GridPanel = dgDetalle.PrimaryGrid
                    xPanel.Rows.Clear()
                Else
                    MessageBox.Show("No existe ningun registro en el detalle")
                End If
            Else
                ''************************************************
                ''*
                ''************************************************
                If dgDetalle.GetSelectedRows.Count = 1 Or CheckBox2.Checked = True Then

                    'DATOS DE REFERENCIAS
                    If VALIDA_DATOS_DE_REFERENCIAS() = False Then
                        Exit Sub
                    End If
                    'DATOS DE TRANSPORTES
                    VALIDA_DATOS_TRANSPORTISTA()
                    'DATOS DE MEDICION EN LA RECEPCION DE PATIO PLANTA DE ASERRIO
                    VALIDACION_MEDICION_INDUSTRIA()
                    SaveRecord()
                Else

                    'DATOS DE REFERENCIAS
                    VALIDA_DATOS_DE_REFERENCIAS()
                    'DATOS DE TRANSPORTES
                    VALIDA_DATOS_TRANSPORTISTA()
                    For Each oRow As GridRow In dgDetalle.GetSelectedRows
                        txTrozaId.Text = oRow.Cells(2).Value
                        VerDatosTroza()
                        SaveRecord()
                    Next
                End If
            End If
        Else
            SaveRecord()
            Me.Close()
        End If
        wfIngreso_trozas.ActualizarGrid()
        Limpiar_TextBox_br()

    End Sub

    Private Sub SaveRecord()
        Dim guiarem As String
        Dim dt As New SAMAD.formato01_det
        If xExiste = True Then
            dt.F01d_Id = xRowId
        End If
        guiarem = TxSerie_Gr.Text & "-" & txGuia.Text
        dt.F01d_F01_Id = xRowPapa
        If guiarem <> "" Then
            dt.F01d_GuiaRemision = guiarem
        End If
        dt.F01d_Gtf = xGtf
        If TxNlista.Text <> "" Then
            dt.F01d_Lista_trozas = TxNlista.Text
        End If
        If txNumtroza.Text <> "" Then
            dt.F01d_Correlativo = txNumtroza.Text
        End If
        If txEspecie.Text <> "" Then
            dt.F01d_Especie = txEspecie.Text
        End If
        dt.F01d_D1 = CDbl(IIf(txtD1.Text = "", 0, txtD1.Text))
        dt.F01d_D2 = CDbl(IIf(txtD2.Text = "", 0, txtD2.Text))
        dt.F01d_D3 = CDbl(IIf(txtD3.Text = "", 0, txtD3.Text))
        If txEspeciec.Text <> "" Then
            dt.F01d_Especiec = txEspeciec.Text
        End If
        If txObservacion.Text <> "" Then
            dt.F01d_Observacion = txObservacion.Text
        End If
        dt.f01d_Ub_Id = TxUbicacionId.Text
        dt.F01d_Ubicacion = TxUbicacion.Text
        If txtVol3.Text <> "" Then
            dt.F01d_Vol_M3 = txtVol3.Text
        End If
        dt.F01d_Autogenerado = txtAutogenerado.Text
        If txCamionId.Text <> "" Then
            dt.f01d_veh_Id = txCamionId.Text
        End If
        If txPlaca.Text <> "" Then
            dt.f01d_Veh_Placa = txPlaca.Text
        End If
        If txConductor.Text <> "" Then
            dt.f01d_con_Id = txConductorId.Text
            dt.f01d_Conductor = txConductor.Text
        End If
        If txtCodIndustria.Text <> "" Then
            dt.F01d_CodIndustria = txtCodIndustria.Text
        End If
        dt.EspecieId = txEspecieId.Text
        dt.F01d_Tipo = xTipotraslado
        dt.f01d_Pro_Id = TxProcedenciaId.Text
        dt.F01d_Procedencia = TxProcedencia.Text
        dt.F01d_Abastecimiento = CbAbastecimiento.Text
        dt.F01d_unidad = cbUnidad.Text
        dt.F01d_Lote = txLote.Text
        dt.F01d_PropietarioId = TxPropietarioId.Text
        dt.F01d_Propietario = TxPropietario.Text
        dt.F01d_TitularId = txTitularId.Text
        dt.F01d_Titular = txTitular.Text
        dt.F01d_ZYP_ID = IDZAFRA
        If txtEmpresa_transpid.Text <> "" Then
            dt.F01d_Emp_Transp_id = txtEmpresa_transpid.Text
            dt.F01d_Emp_Transp = txtEmpresa_transp.Text
        End If
        If CbCalidad.Text <> "" Then
            dt.F01d_Calidad = CbCalidad.Text
        End If

        If cbUnidad.SelectedIndex = 0 Then

            If CheckBox3.Checked = True Then
                dt.F01d_D1c = CDbl(IIf(txtD1c.Text = "", 0, txtD1c.Text))
                dt.F01d_D2c = CDbl(IIf(txtD2c.Text = "", 0, txtD2c.Text))
                dt.F01d_D3c = CDbl(IIf(txtD3c.Text = "", 0, txtD3c.Text))
                dt.F01d_Vol_M3c = CDbl(IIf(txtVolm3c.Text = "", 0, txtVolm3c.Text))

                dt.F01d_Dm_pulgada = 0
                dt.F01d_Long_pie = 0
                dt.F01d_Vol_pt = 0

            End If

            If rbNomedir.Checked = True Then
                dt.F01d_D1c = 0 'CDbl(IIf(txtD1c.Text = "", 0, txtD1c.Text))
                dt.F01d_D2c = 0 'CDbl(IIf(txtD2c.Text = "", 0, txtD2c.Text))
                dt.F01d_D3c = 0 'CDbl(IIf(txtD3c.Text = "", 0, txtD3c.Text))
                dt.F01d_Vol_M3c = 0 'CDbl(IIf(txtVolm3c.Text = "", 0, txtVolm3c.Text))

                dt.F01d_Dm_pulgada = 0
                dt.F01d_Long_pie = 0
                dt.F01d_Vol_pt = 0

            End If

            If rbRemedir.Checked = True Then
                dt.F01d_D1c = CDbl(IIf(txtD1c.Text = "", 0, txtD1c.Text))
                dt.F01d_D2c = CDbl(IIf(txtD2c.Text = "", 0, txtD2c.Text))
                dt.F01d_D3c = CDbl(IIf(txtD3c.Text = "", 0, txtD3c.Text))
                dt.F01d_Vol_M3c = CDbl(IIf(txtVolm3c.Text = "", 0, txtVolm3c.Text))

                dt.F01d_Dm_pulgada = 0
                dt.F01d_Long_pie = 0
                dt.F01d_Vol_pt = 0

            End If
        Else

            dt.F01d_D1c = 0
            dt.F01d_D2c = 0
            dt.F01d_D3c = 0
            dt.F01d_Vol_M3c = 0


            dt.F01d_Dm_pulgada = CDbl(IIf(txtD2c.Text = "", 0, txtD2c.Text))
            dt.F01d_Long_pie = CDbl(IIf(txtD3c.Text = "", 0, txtD3c.Text))
            dt.F01d_Vol_pt = CDbl(IIf(txtVolm3c.Text = "", 0, txtVolm3c.Text))
        End If

        dt.Periodo = xPeriodo
        dt.Estatus = 0
        If New cdFormato01Det().GrabarFormato01Det(dt, xExiste) = True Then
            Dim dm As New samadEntities
            Dim xListat As listatrozasd = dm.listatrozasd.First(Function(p) p.Ltd_Codificacion = txTrozaId.Text)
            xListat.Ltd_Autogenerado = txtAutogenerado.Text
            xListat.Estatus = 1
            dm.SaveChanges()
            'TxPropietario.Text = ""
            'TxPropietarioId.Text = ""
            txEspecie.Text = ""
            txEspeciec.Text = ""
            txtAutogenerado.Text = ""
            txtD1.Text = ""
            txtD2.Text = ""
            txtD3.Text = ""
            txtVol3.Text = ""
            txtVolm3c.Text = ""
            txtD1c.Text = ""
            txtD2c.Text = ""
            txtD3c.Text = ""
            txNumtroza.Text = ""
            TxNgtf.Text = ""
            TxNlista.Text = ""


            If (txtCodIndustria.Text <> "") Then
                txtCodIndustria.Text = New fxSamad().StrCeros(txtCodIndustria.Text, 6, True)
            End If

            If CheckBox3.Checked = False Then
                ActualizaListaTrozas()
            End If


            'Actualizar el Formulario padre
            wfIngreso_trozas.btUpdate.PerformClick()
            If xExiste = True Then
                Me.Close()
            End If
        Else
            MessageBox.Show("No se pudo guardar el registro", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function VALIDA_DATOS_DE_REFERENCIAS() As Boolean

        If String.IsNullOrEmpty(TxProcedencia.Text) = True Then
            If MessageBox.Show("No se ha indicado la procedencia de esta troza, ¿Desea grabar el registro sin esta informacion?", xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                TxProcedencia.BackColor = Color.LightYellow
                TxProcedencia.Focus()
                Return False
            End If
        End If

        If String.IsNullOrEmpty(CbAbastecimiento.Text) = True Then
            If MessageBox.Show("No se ha indicado el modo de Abasteciemieinto de Trozas, ¿Desea grabar el registro sin esta informacion?", xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                CbAbastecimiento.BackColor = Color.LightYellow
                CbAbastecimiento.Focus()
                Return False
            End If
        End If
        If String.IsNullOrEmpty(txLote.Text) = True Then
            If MessageBox.Show("No se ha ingresado el numero de lote, ¿Desea grabar el registro sin esta informacion?", xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                txLote.BackColor = Color.LightYellow
                txLote.Focus()
                Return False
            End If
        End If
        If String.IsNullOrEmpty(TxPropietario.Text) = True Then
            If MessageBox.Show("No se ha indicado el Propietario o Dueño, ¿Desea grabar el registro sin esta informacion?", xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                TxPropietario.BackColor = Color.LightYellow
                TxPropietario.Focus()
                Return False
            End If
        End If
        If String.IsNullOrEmpty(TxUbicacion.Text) = True Then
            If MessageBox.Show("No se ha indicado la Ubicación de esta troza, ¿Desea grabar el registro sin esta informacion?", xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                TxUbicacion.BackColor = Color.LightYellow
                TxUbicacion.Focus()
                Return False
            End If
        End If
        If String.IsNullOrEmpty(TxCorrelativo.Text) = True Then
            MessageBox.Show("No hay troza que registrar", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxCorrelativo.BackColor = Color.LightYellow
            TxCorrelativo.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txEspecie.Text) = True Then
            MessageBox.Show("No hay trozas que registrar", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub VALIDA_DATOS_TRANSPORTISTA()
        If String.IsNullOrEmpty(TxSerie_Gr.Text) = True Then
            If MessageBox.Show("No se ha ingresado la serie de la guía de remision, ¿Desea grabar el registro sin esta informacion?", xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                TxSerie_Gr.BackColor = Color.LightYellow
                TxSerie_Gr.Focus()
                Exit Sub
            End If
        End If

        If String.IsNullOrEmpty(txGuia.Text) = True Then
            If MessageBox.Show("No se ha ingresado la guía de remision, ¿Desea grabar el registro sin esta informacion?", xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                txGuia.BackColor = Color.LightYellow
                txGuia.Focus()
                Exit Sub
            End If
        End If

        If String.IsNullOrEmpty(txtEmpresa_transp.Text) = True Then
            If MessageBox.Show("No se ha indicado la Empresa de Transporte", xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                txtEmpresa_transp.BackColor = Color.LightYellow
                txtEmpresa_transp.Focus()
                Exit Sub
            End If
        End If

        If String.IsNullOrEmpty(txConductor.Text) = True Then
            If MessageBox.Show("No se ha indicado el Conductor del Vehiculo", xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                txConductor.BackColor = Color.LightYellow
                txConductor.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub VALIDACION_MEDICION_INDUSTRIA()

        If String.IsNullOrEmpty(txtCodIndustria.Text) = True Then
            MessageBox.Show("Falta el Codigo de Industria", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCodIndustria.BackColor = Color.LightYellow
            txtCodIndustria.Focus()
            Exit Sub
        End If
        If New cdFormato01Det().CodigoIndustriaExiste(txtCodIndustria.Text, xPeriodo, txLote.Text) = True Then
            MessageBox.Show("El Código ingresado a esta troza, ya existe en el Periodo " & xPeriodo, xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCodIndustria.SelectAll()
            txtCodIndustria.Focus()
            Exit Sub
        End If

        '***********CONDICION SI ES QUE ESTA SELECIONADA LA OBCION REMEDIR**************

        If rbRemedir.Checked = True Then
            'cbUnidad.Enabled = True
            ''dgDetalle.Enabled = False
            ''cbUnidad.Enabled = ""
            'txtD1c.Text = ""
            'txtD2c.Text = ""
            'txtD3c.Text = ""
            'txtVolm3c.Text = ""
            'TxCorrelativo.Enabled = True
            'rbRemedir.Enabled = True
            'rbNomedir.Enabled = True
            'txtCodIndustria.Enabled = True
            'CbCalidad.Enabled = True
            'GroupPanel4.Enabled = True
            If cbUnidad.SelectedIndex = 0 Then
                If String.IsNullOrEmpty(txtD1c.Text) = True Then
                    MessageBox.Show("No se a ingresado el Diametro mayor de esta Troza", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtD1c.Focus()
                    Exit Sub
                End If
            Else
                txtD1c.Text = 0
            End If
 
            If String.IsNullOrEmpty(txtD2c.Text) = True Then
                MessageBox.Show("No se ha Ingresado el díametro menor de esta Troza", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtD2c.Focus()
                Exit Sub
            End If
            If String.IsNullOrEmpty(txtD3c.Text) = True Then
                MessageBox.Show("No se ha Ingresado el Largo de esta Troza", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtD3c.Focus()
                Exit Sub
            End If
        End If
        If rbNomedir.Checked = True Then
            cbUnidad.Enabled = True
            'dgDetalle.Enabled = False
            'cbUnidad.Enabled = ""
            txtD1c.Text = ""
            txtD2c.Text = ""
            txtD3c.Text = ""
            txtVolm3c.Text = ""
            TxCorrelativo.Enabled = True
            rbRemedir.Enabled = True
            rbNomedir.Enabled = True
            txtCodIndustria.Enabled = True
            CbCalidad.Enabled = True
            GroupPanel4.Enabled = True
        End If
    End Sub

#Region "COMPORTAMIENTO DE LOS TEXTBOX Y BOTONES DE ESTE FORMULARIO EN LOS EVENTOS CLIC, KYDOWNS Y KEYPRES*********************"

    'Comportamiento del TextBox TxCorrelativo para la Opcion Asignacion de Trozas por NUmero correlatibo de Bosque
    Private Sub TxCorrelativo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxCorrelativo.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                'TxCorrelativo()

            Case Keys.Tab, Keys.Enter
                e.Handled = True
                If String.IsNullOrEmpty(TxCorrelativo.Text) = True Then
                    MessageBox.Show("Por favor ingrese el Correlativo de Busqueda", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    TxCorrelativo.Focus()
                    Exit Sub
                End If
                If IsNumeric(TxCorrelativo.Text) = True Then
                    TxCorrelativo.Text = Microsoft.VisualBasic.Right("000000" + TxCorrelativo.Text, 6)
                End If
                If New cdListatrozasd().TrozaExiste(TxCorrelativo.Text) = False Then
                    MessageBox.Show("Numero de troza no existe", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    TxCorrelativo.Focus()
                    Exit Sub
                End If
                txTrozaId.Text = TxCorrelativo.Text
                VerDatosTroza()
                'TxPropietario.Select()
                'txtCodIndustria.Text = "000001"
                txtCodIndustria.Focus()
                txtCodIndustria.Select()
                copia_transporte()

        End Select
    End Sub
    Private Sub TxCorrelativo_Click(sender As Object, e As System.EventArgs) Handles TxCorrelativo.Click
        TxCorrelativo.SelectionLength = TxCorrelativo.Text.Length
    End Sub

    Private Sub txtCodIndustria_Click(sender As Object, e As System.EventArgs) Handles txtCodIndustria.Click
        txtCodIndustria.SelectionLength = txtCodIndustria.Text.Length
    End Sub

    Private Sub txtCodIndustria_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCodIndustria.KeyDown
        If e.KeyCode = Keys.Enter Then
            'If String.IsNullOrEmpty(txtCodIndustria.Text) = True Then
            '    MessageBox.Show("Debe ingresar el Codigo de Industria", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    txtCodIndustria.Focus()
            '    Exit Sub
            'End If
            'txtCodIndustria.Text = (Integer.Parse(xLastTRoza.F01d_CodIndustria) + 1).ToString().PadLeft(6, "0")
            'txtCodIndustria.Text = Microsoft.VisualBasic.Right("000000" + txtCodIndustria.Text, 6)
            'txtCodIndustria.Text = (Integer.Parse(CInt(txtCodIndustria.Text)).ToString().PadLeft(6, "0"))

            txtCodIndustria.Text = txtCodIndustria.Text.ToString().PadLeft(6, "0")
            If rbNomedir.Checked = True Then
                btnAgregar.Select()
                btnAgregar.Focus()
            Else
                CbCalidad.SelectAll()
                CbCalidad.Focus()
            End If
  
        End If
    End Sub
    Private Sub CbCalidad_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles CbCalidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrEmpty(CbCalidad.Text) = True Then
                MessageBox.Show("Debe ingresar la Calidad de Troza", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCodIndustria.Focus()
                Exit Sub
            End If
            'txtCodIndustria.Text = (Integer.Parse(xLastTRoza.F01d_CodIndustria) + 1).ToString().PadLeft(6, "0")
            'txtCodIndustria.Text = Microsoft.VisualBasic.Right("000000" + txtCodIndustria.Text, 6)
            'txtCodIndustria.Text = (Integer.Parse(CInt(txtCodIndustria.Text)).ToString().PadLeft(6, "0"))
            'txtCodIndustria.Text = txtCodIndustria.Text.ToString().PadLeft(6, "0")
            txtD1c.SelectAll()
            txtD1c.Focus()
        End If
    End Sub
    Private Sub txtD1c_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtD1c.KeyPress
        ' Solo Numeros
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
            siguientecontrol()
        End If
    End Sub
    Private Sub txtD2c_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtD2c.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                txtD1c.SelectAll()
                txtD1.Focus()
            Case Keys.Enter, Keys.Tab
                txtD3c.SelectAll()
                txtD3c.Focus()
        End Select
    End Sub
    Private Sub txtD2c_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtD2c.KeyPress
        ' Solo Numeros
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
            'siguientecontrol()
        End If
    End Sub

    Private Sub txtD3c_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtD3c.KeyPress
        ' Solo Numeros
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub

    Private Sub txtD1c_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtD1c.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                txtCodIndustria.SelectAll()
                txtCodIndustria.Focus()
            Case Keys.Enter, Keys.Tab
                txtD2c.SelectAll()
                txtD2c.Focus()
        End Select
    End Sub

    Private Sub txtCodIndustria_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCodIndustria.KeyUp
        Select Case e.KeyCode
            'Case Keys.Enter
            '    btnAgregar.Select()
            Case Keys.Left

            Case Keys.Right
                CbCalidad.SelectAll()
                CbCalidad.Focus()
            Case Keys.Up
                'Tu Codigo
            Case Keys.Down
                txtD1c.SelectAll()
                txtD1c.Focus()
        End Select
    End Sub
    Private Sub CbCalidad_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles CbCalidad.KeyUp
        Select Case e.KeyCode
            Case Keys.Left
                txtCodIndustria.SelectAll()
                txtCodIndustria.Focus()
            Case Keys.Right
                'Tu Codigo
            Case Keys.Up
                'Tu Codigo
            Case Keys.Down
                txtD1c.SelectAll()
                txtD1c.Focus()
        End Select
    End Sub
    Private Sub txtD1c_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtD1c.KeyUp
        Select Case e.KeyCode
            Case Keys.Left
                'Tu Codigo
            Case Keys.Right
                CbCalidad.SelectAll()
                CbCalidad.Focus()
            Case Keys.Up
                txtCodIndustria.SelectAll()
                txtCodIndustria.Focus()
            Case Keys.Down
                txtD2c.SelectAll()
                txtD2c.Focus()
        End Select
    End Sub
    Private Sub txtD2c_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtD2c.KeyUp
        Select Case e.KeyCode
            Case Keys.Left
                'Tu Codigo
            Case Keys.Right
                'Tu Codigo
            Case Keys.Up
                txtD1c.SelectAll()
                txtD1c.Focus()
            Case Keys.Down
                txtD3c.SelectAll()
                txtD3c.Focus()
        End Select
    End Sub
    Private Sub txtD3c_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtD3c.KeyUp
        Select Case e.KeyCode
            Case Keys.Left
                'Tu Codigo
            Case Keys.Right
                'Tu Codigo
            Case Keys.Up
                txtD2c.SelectAll()
                txtD2c.Focus()
            Case Keys.Down
                'Tu Codigo
        End Select
    End Sub
    Private Sub txtCodIndustria_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtCodIndustria.PreviewKeyDown
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txtD1c_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtD1c.PreviewKeyDown
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txtD2c_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtD2c.PreviewKeyDown
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txtD3c_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtD3c.PreviewKeyDown
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub
    Private Sub cbcalidad_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CbCalidad.PreviewKeyDown
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txtD2c_Leave(sender As System.Object, e As System.EventArgs) Handles txtD2c.Leave

        If cbUnidad.SelectedIndex = 0 Then

            Dim DM1 As Double
            Dim DM2 As Double
            Dim DM3 As Double

            If txtD1c.Text = "" Then
                DM1 = 0
            Else
                DM1 = CDbl(txtD1c.Text)
            End If


            If txtD2c.Text = "" Then
                DM2 = 0
            Else
                DM2 = CDbl(txtD2c.Text)
            End If

            If txtD3c.Text = "" Then
                DM3 = 0
            Else
                DM3 = CDbl(txtD3c.Text)
            End If

            If DM2 > DM1 = True Then
                MessageBox.Show("El valor del Diametro Menor no puede ser superior al Diametro Mayor", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtD2c.SelectAll()
                txtD2c.Focus()
                Exit Sub
            End If
        End If
        'CalcularM3()
    End Sub

    Private Sub txtD3c_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtD3c.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape

            Case Keys.Enter, Keys.Tab
                If String.IsNullOrEmpty(txtD3c.Text) Then
                    MessageBox.Show("Por favor ingrese el Largo de la Troza", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtD3c.Focus()
                    Exit Sub
                End If

                btnAgregar.Focus()
        End Select
    End Sub

    Private Sub txtD1c_Leave(sender As System.Object, e As System.EventArgs) Handles txtD1c.Leave
        CalcularM3()

        If txtD1c.Text = "" Then
            'MessageBox.Show("Por favor ingrese el Largo de la Troza", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txtD3c_Leave(sender As System.Object, e As System.EventArgs) Handles txtD3c.Leave
        CalcularM3()
    End Sub
#End Region

#Region "*****************COMPORTAMIENTO DE LAS ETIQUETAS DE COLO VERDE PASTEL EN EL EVENTO DOBLE CLIC********************************"

    Private Sub lblConductor_Click(sender As System.Object, e As System.EventArgs)
        'Habrir el Formulario Conductores        
        Dim wfEmergente As New frmConductores
        wfEmergente.ShowDialog(Me)
    End Sub

    Private Sub lblPlaca_Click(sender As System.Object, e As System.EventArgs)
        'Abrir el Formulario Vehiculos
        Dim wfEmergente As New frmVehiculos
        wfEmergente.ShowDialog(Me)
    End Sub
#End Region

    Private Sub Limpiar_TextBox_br()
        txCamionId.Text = ""
        txPlaca.Text = ""
        TxPropietarioId.Text = ""
        TxPropietario.Text = ""
        txEspecie.Text = ""
        txEspeciec.Text = ""
        txNumtroza.Text = ""
        txtD1.Text = ""
        txtD2.Text = ""
        txtD3.Text = ""
        txtVol3.Text = ""
        txtAutogenerado.Text = ""
        'If rbNomedir.Checked = False Then
        'Dim xVm3 As Decimal = 0
        txtD1c.Text = ""
        txtD2c.Text = ""
        txtD3c.Text = ""
        txtVolm3c.Text = ""
        txtD1c.WatermarkText = ""
        txtD2c.WatermarkText = ""
        txtD3c.WatermarkText = ""
        'txtVolm3c.WatermarkText = New fxSamad().VolMet3(CDec(dt.Ltd_D1), dt.Ltd_D2, CDbl(dt.Ltd_D3), cbUnidad.SelectedIndex)
        'Else
        txtD1c.Text = ""
        txtD2c.Text = ""
        txtD3c.Text = ""
        txtVolm3c.Text = 0
        'End If
        'txTitular.Focus()
    End Sub

    Private Sub Limpia_Textboxs_error()
        MessageBox.Show("No se ha seleccionado ningun registro", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        txCamionId.Text = ""
        txPlaca.Text = ""
        TxPropietarioId.Text = ""
        TxPropietario.Text = ""
        txEspecie.Text = ""
        txEspeciec.Text = ""
        txNumtroza.Text = ""
        txtD1.Text = ""
        txtD2.Text = ""
        txtD3.Text = ""
        txtVol3.Text = ""
        txtAutogenerado.Text = ""
        'If rbNomedir.Checked = False Then
        'Dim xVm3 As Decimal = 0
        txtD1c.Text = ""
        txtD2c.Text = ""
        txtD3c.Text = ""
        txtVolm3c.Text = ""
        txtD1c.WatermarkText = ""
        txtD2c.WatermarkText = ""
        txtD3c.WatermarkText = ""
        'txtVolm3c.WatermarkText = New fxSamad().VolMet3(CDec(dt.Ltd_D1), dt.Ltd_D2, CDbl(dt.Ltd_D3), cbUnidad.SelectedIndex)
        'Else
        txtD1c.Text = ""
        txtD2c.Text = ""
        txtD3c.Text = ""
        txtVolm3c.Text = 0
        'End If
        txTitular.Focus()
    End Sub

    Private Sub Agrega_nro_Lote()
        Dim dm As New samadEntities
        Dim xnroLote As formato01_det = dm.formato01_det.Where(Function(p) p.EspecieId = txIdEspecieLte.Text).OrderByDescending(Function(x) x.F01d_Id).FirstOrDefault()
        If Not xnroLote Is Nothing Then
            Try
                txLote.Text = (Integer.Parse(xnroLote.F01d_Lote) + 1).ToString().PadLeft(6, "0")
            Catch ex As Exception
                txLote.Text = "000001"
            End Try
        Else
            txLote.Text = "000001"
        End If
        txLote.Focus()
    End Sub


    Private Sub Agrega_datos_VerDatosTrozas()
        txTrozaId.Text = xRow.Cells(2).Value
        VerDatosTroza()
        Dim dm As New samadEntities
        Dim xLastTRoza As formato01_det = dm.formato01_det.Where(Function(p) p.F01d_F01_Id = xRowPapa).OrderByDescending(Function(x) x.F01d_Id).FirstOrDefault()
        If Not xLastTRoza Is Nothing Then
            Try
                txtCodIndustria.Text = (Integer.Parse(xLastTRoza.F01d_CodIndustria) + 1).ToString().PadLeft(6, "0")
            Catch ex As Exception
                txtCodIndustria.Text = "000001"
            End Try
        Else
            txtCodIndustria.Text = "000001"
        End If
        'txIdEspecieLte.Text = xLastTRoza.EspecieId
        'TxEspecieLt.Text = xLastTRoza.F01d_Especie
        txtCodIndustria.Focus()
    End Sub

    Private Sub Limpia_TextBox_Clic_Grid_Varios()
        cbUnidad.Enabled = False
        'cbUnidad.Enabled = ""
        txtD1c.Text = ""
        txtD2c.Text = ""
        txtD3c.Text = ""
        txtVolm3c.Text = ""
        uD1.Text = "m."
        uD2.Text = "m."
        uD3.Text = "m."
        uVol.Text = "m3"

        txtD1c.Enabled = False
        txtD2c.Enabled = False
        txtD3c.Enabled = False
        TxCorrelativo.Enabled = False
        rbRemedir.Enabled = False
        rbNomedir.Enabled = False
        txtCodIndustria.Enabled = False
        CbCalidad.Enabled = False
        BtnGenNlote.Enabled = False
    End Sub

    Private Sub BtnGenNlote_Click(sender As System.Object, e As System.EventArgs) Handles BtnGenNlote.Click
        Agrega_nro_Lote()
    End Sub

    
  
    Private Sub Label37_Click(sender As System.Object, e As System.EventArgs) Handles Label37.Click
        Dim frmProcedencia As New frmProcedencia
        frmProcedencia.ShowDialog(Me)
    End Sub

    Private Sub Label35_Click(sender As System.Object, e As System.EventArgs) Handles Label35.Click
        Dim frmTitular As New frmTitulares
        frmTitular.ShowDialog(Me)
    End Sub

    Private Sub Label36_Click(sender As System.Object, e As System.EventArgs) Handles Label36.Click
        Dim frmUbicacion As New frmUbicacion
        frmUbicacion.ShowDialog(Me)
    End Sub

    Private Sub lblConductor_Click_1(sender As System.Object, e As System.EventArgs) Handles lblConductor.Click
        Dim frmConductores As New frmConductores
        frmConductores.ShowDialog(Me)
    End Sub

    Private Sub lblPlaca_Click_1(sender As System.Object, e As System.EventArgs) Handles lblPlaca.Click
        Dim frmVehiculos As New frmVehiculos
        frmVehiculos.ShowDialog(Me)
    End Sub

    Private Sub Label25_Click(sender As System.Object, e As System.EventArgs) Handles Label25.Click
        Dim frmTitulares As New frmVehiculos
        frmTitulares.ShowDialog(Me)
    End Sub

    'Private Sub quitarCheck()
    '    If Me.RbNgtf.Checked Or Me.RbCorrelativo.Checked = True Then
    '        Me.dgDetalle.Enabled = True
    '        Me.RbNgtf.Checked = False
    '        Me.RbCorrelativo.Checked = False
    '        Me.TxCorrelativo.Enabled = False
    '        GroupPanel4.Enabled = True
    '    Else
    '        Me.dgDetalle.Enabled = False
    '        Me.RbNgtf.Checked = False
    '        Me.RbCorrelativo.Checked = False
    '        Me.TxCorrelativo.Enabled = False
    '    End If
    'End Sub
    Private Sub desactivarchek3()
        If Me.CheckBox3.Checked = True Then
            Me.CheckBox3.Checked = False
        Else
            Me.CheckBox3.Checked = False

        End If
    End Sub
    Private Sub desactivarChek()
        If Me.CheckBox2.Checked = True Then
            Me.CheckBox2.Checked = False
        Else
            Me.CheckBox2.Checked = False

        End If
    End Sub

    Private Sub RbNgtf_Click(sender As Object, e As System.EventArgs)
        Me.desactivarChek()
    End Sub

    Private Sub RbCorrelativo_Click(sender As Object, e As System.EventArgs)
        Me.desactivarChek()
    End Sub
#Region "control de saltos al presionar enter"
    Private Sub siguientecontrol()
        SendKeys.Send("{TAB}")
    End Sub
    'Private Sub txtD1c_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtD1c.KeyPress
    '    If e.KeyChar = ChrW(Keys.Enter) Then
    '        e.Handled = True
    '        siguientecontrol()
    '    End If
    'End Sub
    'Private Sub txtD2c_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtD2c.KeyPress
    '    If e.KeyChar = ChrW(Keys.Enter) Then
    '        e.Handled = True
    '        siguientecontrol()
    '    End If
    'End Sub

#End Region
   

    'Private Sub TxCorrelativo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxCorrelativo.KeyPress
    '    txtCodIndustria.Focus()
    '    txtCodIndustria.Select()
    'End Sub

    Private Sub CheckBox3_Click(sender As System.Object, e As System.EventArgs) Handles CheckBox3.Click
        If CheckBox3.Checked = True Then
            cbUnidad.Enabled = False
            'dgDetalle.Enabled = False
            'cbUnidad.Enabled = ""
            txEspeciec.Text = ""
            txtCodIndustria.Text = ""
            txtD1c.Text = ""
            txtD2c.Text = ""
            txtD3c.Text = ""
            txtVolm3c.Text = ""
            uD1.Text = "m."
            uD2.Text = "m."
            uD3.Text = "m."
            uVol.Text = "m3"

            TxNgtf.Text = ""
            TxNlista.Text = ""
            txEspecie.Text = ""
            txNumtroza.Text = ""
            txtD1.Text = ""
            txtD2.Text = ""
            txtD3.Text = ""
            txtVol3.Text = ""

            txtD1c.Enabled = False
            txtD2c.Enabled = False
            txtD3c.Enabled = False
            TxCorrelativo.Enabled = False
            rbRemedir.Enabled = False
            rbNomedir.Enabled = False
            txtCodIndustria.Enabled = False
            CbCalidad.Enabled = False
            'GroupPanel4.Enabled = False

            'Me.CheckBox1.Checked = False
            Me.desactivarChek()

        Else
            'cbUnidad.Enabled = True
            'dgDetalle.Enabled = True
            rbRemedir.Enabled = True
            rbNomedir.Enabled = True
            Me.desactivarChek()
        End If

    End Sub

    Private Sub CheckBox2_Click(sender As System.Object, e As System.EventArgs) Handles CheckBox2.Click
        If CheckBox2.Checked = True Then
            'cbUnidad.Enabled = False
            'dgDetalle.Enabled = False
            'cbUnidad.Enabled = ""
            'txtD1c.Text = ""
            'txtD2c.Text = ""
            'txtD3c.Text = ""
            'txtVolm3c.Text = ""
            TxCorrelativo.Enabled = True
            rbRemedir.Enabled = True
            rbNomedir.Enabled = True
            txtCodIndustria.Enabled = True
            'txtCodIndustria.Enabled = True
            'CbCalidad.Enabled = True
            'GroupPanel4.Enabled = True
            desactivarchek3()
            TxCorrelativo.Select()
            TxCorrelativo.Focus()
        Else
            'cbUnidad.Enabled = False
            'dgDetalle.Enabled = True
            'cbUnidad.Enabled = ""
            'txtD1c.Text = ""
            'txtD2c.Text = ""
            'txtD3c.Text = ""
            'txtVolm3c.Text = ""
            TxCorrelativo.Enabled = False
            rbRemedir.Enabled = True
            rbNomedir.Enabled = True
            txtCodIndustria.Enabled = False
            'CbCalidad.Enabled = True
            'GroupPanel4.Enabled = True
            desactivarchek3()
        End If

    End Sub
 
    Private Sub txtCodIndustria_Validated(sender As System.Object, e As System.EventArgs) Handles txtCodIndustria.Validated

        If String.IsNullOrEmpty(txtCodIndustria.Text) = True Then
            MessageBox.Show("Debe ingresar el Codigo de Industria", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCodIndustria.Focus()
            Exit Sub
        End If
        'txtCodIndustria.Text = (Integer.Parse(xLastTRoza.F01d_CodIndustria) + 1).ToString().PadLeft(6, "0")
        'txtCodIndustria.Text = Microsoft.VisualBasic.Right("000000" + txtCodIndustria.Text, 6)
        'txtCodIndustria.Text = (Integer.Parse(CInt(txtCodIndustria.Text)).ToString().PadLeft(6, "0"))
        txtCodIndustria.Text = txtCodIndustria.Text.ToString().PadLeft(6, "0")
        CbCalidad.SelectAll()
        CbCalidad.Focus()
    End Sub

    Private Sub txLote_Validated(sender As System.Object, e As System.EventArgs) Handles txLote.Validated
        
        If String.IsNullOrEmpty(txLote.Text) = True Then

            MessageBox.Show("Por favor ingrese el Numero de Lote", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txLote.Focus()
            Exit Sub
        End If
        If IsNumeric(txLote.Text) = True Then

            txLote.Text = Microsoft.VisualBasic.Right("000000" + txLote.Text, 6)

        End If

    End Sub

    Private Sub Actualiza_Click(sender As System.Object, e As System.EventArgs)
        ListarTrozas()
    End Sub
    Private Sub copia_transporte()
        If xDoIt = True Then
            Dim dm As New samadEntities
            Dim lt As New cdListatrozasc
            'xLtd_lt_Id
            Dim dato = dm.listatrozasc.Where(Function(r) r.Lt_id = xLtd_lt_Id).FirstOrDefault

            If Not dato Is Nothing Then
                Dim dConductor = dm.conductores.Where(Function(t) t.Con_Id = dato.Lt_Conductor_Id).FirstOrDefault()
                txConductorId.Text = dConductor.Con_Id
                txConductor.Text = dConductor.Con_NomApe
                Dim dVehiculo = dm.vehiculos.Where(Function(v) v.Veh_Id = dato.Lt_Transporte_Id).FirstOrDefault()
                txCamionId.Text = dVehiculo.Veh_Id
                txPlaca.Text = dVehiculo.Veh_Placa
                Dim NomEmpTransporte = dm.titulares.Where(Function(x) x.Pro_Id = dVehiculo.Veh_Emt_Id).FirstOrDefault()
                txtEmpresa_transp.Text = NomEmpTransporte.Pro_Titular
                Dim NomPropietario = dm.titulares.Where(Function(y) y.Pro_Id = dato.Lt_Propietario_Id).FirstOrDefault()
                TxPropietario.Text = NomPropietario.Pro_Titular
                TxPropietarioId.Text = NomPropietario.Pro_Id
                Dim Nroserie = dato.Lt_NroGuia_rem
                TxSerie_Gr.Text = Mid(Nroserie, 1, 3)
                txGuia.Text = Mid(Nroserie, 5, Len(Nroserie) - 4)

                'ListaTrozas = dm.listatrozasd.Where(Function(p) p.Ltd_Lt_Id = xGtf.Lt_id And p.Estatus = 0).ToList()
            End If
            'ListarTrozas()
        End If
    End Sub

    Private Sub ChkTransporte_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkTransporte.CheckedChanged
        If ChkTransporte.Checked = True Then
            'copia_transporte()

        End If
    End Sub

   
End Class




Public Class ItemEvents


    Inherits EventArgs

    Private _item As Integer
    Public Property Item() As Integer
        Get
            Return _item
        End Get
        Set(ByVal value As Integer)
            _item = value
        End Set
    End Property
End Class
