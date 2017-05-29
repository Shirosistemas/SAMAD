Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports Microsoft.Reporting.WinForms

'Imports SAMAD.des


Public Class frmDespacho
    Dim Dt, Dtd, Dtdm, Dte, Dtb, Dtdta As New DataTable
    Dim func As New fformato02 'Creacion una variable para hacer referencia a la funcion fconcesiones
    Dim nreg, nregd, xreg, recno As Integer
    Dim sw_guardar As Boolean = False
    Dim sw_guardard As Boolean = False
    Dim nuevo As Boolean = False
    Dim nuevoItem As Boolean = False
    Dim modificar As Boolean = False
    Dim modificarItem As Boolean = False
    Dim msg As String = ""
    Dim frm, frmNroLista, frmbuscardoc, frmtur, frmpp, frmd, frmco, frmpl As New frmShowbrow
    Dim xrumapaqueteid As Integer
    Dim xtPeriodo As Integer
    Dim xVeh_Emt_Id As Integer
    Dim txtPeriodo As Integer
    Private _left As String
    Friend recargalita As Boolean
    Dim listaCodigoRumasPaqueteEdit As List(Of despacho_catalogo)
    Dim xTitulo = fxSamad.Titulo
    Dim xNroCV, xNroGuiaRem As String

    Private Sub AplicarPerfil()
        If vInfraestructura.Usuario.gtipo = "ADMINISTRADOR" Then

        Else
            Panel3.Enabled = False
            Panel4.Enabled = False
        End If
    End Sub

    Private Sub Deshabilitar_datos()

        txtId.Enabled = False 'Id del Encabezado
        BtnUbigeo.Enabled = False
        btnDeffs.Enabled = False
        LblArffs.Enabled = False
        lblPropietario.Enabled = False
        lblDeestino.Enabled = False
        lblVehiculo.Enabled = False
        lblConductor.Enabled = False
        TxTipo_com_CV.Enabled = False
        TxNro_Cv_Serie.Enabled = False
        TxNro_Com_Cv.Enabled = False
        TxNroSerie.Enabled = False
        TxNroGuia.Enabled = False
        TxFecha_Ven.Enabled = False
        txtFecha.Enabled = False
        cbTipoTransporte.Enabled = False
        btnConcesion.Enabled = False
        btnPropietario.Enabled = False
        btnDestino.Enabled = False
        btnConductor.Enabled = False
        btnPlaca.Enabled = False

    End Sub

    Private Sub Habilitar_datos()
        txtId.Enabled = False 'Id del Encabezado
        BtnUbigeo.Enabled = True
        btnDeffs.Enabled = True
        LblArffs.Enabled = True
        lblPropietario.Enabled = True
        lblDeestino.Enabled = True
        lblVehiculo.Enabled = True
        lblConductor.Enabled = True
        TxTipo_com_CV.Enabled = True
        TxNro_Cv_Serie.Enabled = True
        TxNro_Com_Cv.Enabled = True
        TxNroSerie.Enabled = True
        TxNroGuia.Enabled = True
        txtFecha.Enabled = True
        TxFecha_Ven.Enabled = True
        cbTipoTransporte.Enabled = True
        btnConcesion.Enabled = True
        btnPropietario.Enabled = True
        btnDestino.Enabled = True
        btnConductor.Enabled = True
        btnPlaca.Enabled = True

    End Sub

    Private Sub mostrar_encabezado()
        Try
            Dim func As New fdespacho 'Creacion una variable para hacer referencia a la funcion flistatrozasd
            Dte = func.mostrar 'Invocamos a la funcion mostrar()
            nreg = Dte.Rows.Count 'Almacenamos la cantidad de filas o registros recuperados


            If nreg <> 0 Then
                txtId.Text = Dte.Rows(recno).Item("des_id").ToString
                txtNroDoc.Text = Dte.Rows(recno).Item("des_nrodoc").ToString
                TxUbigeo.Text = Dte.Rows(recno).Item("des_ubigeo").ToString
                txDeffs.Text = Dte.Rows(recno).Item("des_Arffs").ToString
                txtFecha.Text = Dte.Rows(recno).Item("des_fecha").ToString
                TxFecha_Ven.Text = Dte.Rows(recno).Item("des_fecha_ven").ToString
                cbTipoTransporte.Text = Dte.Rows(recno).Item("des_tipotransporte").ToString

                'Datos del Titular
                txt_Con_Id.Text = Dte.Rows(recno).Item("des_titular_id").ToString
                txt_Con_Titular.Text = Dte.Rows(recno).Item("des_titular_nombre").ToString
                TxRep_legal.Text = Dte.Rows(recno).Item("des_rep_legal").ToString
                txt_Con_Depto.Text = Dte.Rows(recno).Item("departamento").ToString
                txt_Con_Provincia.Text = Dte.Rows(recno).Item("provincia").ToString
                txt_Con_Distrito.Text = Dte.Rows(recno).Item("distrito").ToString
                xtPeriodo = Dte.Rows(recno).Item("des_periodo").ToString
                'txtNroPermiso.Text = Dte.Rows(recno).Item("pro_sector").ToString

                'Datos de propietario
                txt_Pro_Id.Text = Dte.Rows(recno).Item("des_propietario_id").ToString
                txt_Pro_Nombre.Text = Dte.Rows(recno).Item("des_propietario_nombre").ToString
                txtRucRusP.Text = Dte.Rows(recno).Item("prop_ruc").ToString
                txtDniLEP.Text = Dte.Rows(recno).Item("prop_dni").ToString
                txtDireccion.Text = Dte.Rows(recno).Item("des_direccion_p").ToString
                TxDepto_P.Text = Dte.Rows(recno).Item("departamento_p").ToString
                TxProv_p.Text = Dte.Rows(recno).Item("provincia_p").ToString
                TxDist_p.Text = Dte.Rows(recno).Item("distrito_p").ToString
                TxTipo_com_CV.Text = Dte.Rows(recno).Item("des_tipo_cv")

                xNroCV = Dte.Rows(recno).Item("des_nro_cv").ToString
                TxNro_Cv_Serie.Text = Mid(xNroCV, 1, 3)
                TxNro_Com_Cv.Text = Mid(xNroCV, 5, xNroCV.Length - 4)

                xNroGuiaRem = Dte.Rows(recno).Item("des_nro_guia_rem").ToString
                TxNroSerie.Text = Mid(xNroGuiaRem, 1, 3)
                TxNroGuia.Text = Mid(xNroGuiaRem, 5, xNroGuiaRem.Length - 4)

                'Datos de contrato/permiso
                txt_Contrato_Id.Text = Dte.Rows(recno).Item("des_contrato_id").ToString
                txt_Con_Contrato.Text = Dte.Rows(recno).Item("nrocontrato").ToString
                TxOrigen_Rec.Text = Dte.Rows(recno).Item("des_recurso").ToString
                TxNroResolucion.Text = Dte.Rows(recno).Item("des_resolucion").ToString
                TxTipopm.Text = Dte.Rows(recno).Item("des_tipopm").ToString

                ''Datos de poa
                'txt_Poa_Id.Text = Dte.Rows(recno).Item("lt_poa_id").ToString
                'txt_Con_Poa.Text = Dte.Rows(recno).Item("zyp_poa").ToString

                'Datos de vehiculo
                txt_veh_id.Text = Dte.Rows(recno).Item("des_transportista_id").ToString
                txt_veh_placa.Text = Dte.Rows(recno).Item("veh_placa").ToString
                txtTipo.Text = Dte.Rows(recno).Item("veh_tipo").ToString
                TxTipo_vehic.Text = Dte.Rows(recno).Item("Veh_Tipo_vehic").ToString

                'Datos del conductor
                txt_Conductor_Id.Text = Dte.Rows(recno).Item("des_transportista_id").ToString
                txt_Conductor_Nombre.Text = Dte.Rows(recno).Item("des_conductor_nombre").ToString
                txt_Conductor_Dni.Text = Dte.Rows(recno).Item("con_dni").ToString
                txt_Conductor_Licencia.Text = Dte.Rows(recno).Item("con_nrolicencia").ToString

                'Datos de destino
                txt_Des_Id.Text = Dte.Rows(recno).Item("des_destinatario_id").ToString
                txt_Des_Nombre.Text = Dte.Rows(recno).Item("des_destinatario_nombre").ToString
                txt_Des_Depto.Text = Dte.Rows(recno).Item("des_dpto").ToString
                txt_Des_Provincia.Text = Dte.Rows(recno).Item("des_prov").ToString
                txt_Des_Distrito.Text = Dte.Rows(recno).Item("des_dist").ToString
                txt_Des_Direccion.Text = Dte.Rows(recno).Item("des_direccion").ToString
                txt_Des_Ruc.Text = Dte.Rows(recno).Item("des_ruc").ToString
                txtDniLED.Text = Dte.Rows(recno).Item("des_dni").ToString

                'recibos 
              

                habilitar_botones_desplazamiento()
                btnNuevo.Enabled = True
                btnModificar.Enabled = True
                btnGuardar.Enabled = False
                btnDeshacer.Enabled = False
                btnAgregarItem.Enabled = False
                btnSalir.Enabled = True
            Else
                deshabilitar_botones_desplazamiento()
                btnNuevo.Enabled = True
                btnModificar.Enabled = False
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

        txtId.Text = ""
        cbTipoTransporte.Text = ""
        'Datos del Titular
        txt_Con_Id.Text = ""
        txt_Con_Titular.Text = ""
        TxOrigen_Rec.Text = ""
        txt_Con_Depto.Text = ""
        txt_Con_Provincia.Text = ""
        txt_Con_Distrito.Text = ""
        TxRep_legal.Text = ""
        TxNroResolucion.Text = ""
        TxTipopm.Text = ""

        'Datos de propietario
        txt_Pro_Id.Text = ""
        txt_Pro_Nombre.Text = ""
        txtDniLEP.Text = ""


        'Datos de contrato/permiso
        txt_Contrato_Id.Text = ""
        txt_Con_Contrato.Text = ""

        'Datos de poa
        'txt_Poa_Id.Text = ""
        'txt_Con_Poa.Text = ""

        'Datos de vehiculo
        txt_veh_id.Text = ""
        txt_veh_placa.Text = ""
        txtTipo.Text = ""
        TxTipo_vehic.Text = ""

        'Datos del conductor
        txt_Conductor_Id.Text = ""
        txt_Conductor_Nombre.Text = ""
        txt_Conductor_Dni.Text = ""
        txt_Conductor_Licencia.Text = ""

        'Datos de destino
        txt_Des_Id.Text = ""
        txt_Des_Nombre.Text = ""
        txt_Des_Depto.Text = ""
        txt_Des_Provincia.Text = ""
        txt_Des_Distrito.Text = ""
        txt_Des_Direccion.Text = ""
        txt_Des_Ruc.Text = ""

   

    End Sub

    Private Sub siguientecontrol()
        SendKeys.Send("{TAB}")
    End Sub

    Private Sub validar_campos()

        'Preguntamos si los controles estan vacios, para enviar el mensaje

    End Sub

    Private Sub DataDetalle_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        registro_seleccionado()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Function optener_siguiente_numero_lista()
        Dim ulpos As Integer
        Dim numero, ultimo, numstring, siguiente As String

        ulpos = Dte.Rows.Count - 1

        If ulpos <> -1 Then
            ultimo = Dte.Rows(ulpos).Item("des_nrodoc").ToString()

            numero = Convert.ToInt32(Mid(ultimo, 5, 6) + 1)
        Else
            numero = 1
        End If
        numstring = Microsoft.VisualBasic.Right("000000" + numero, 6)
        siguiente = numstring

        Return siguiente
    End Function

    Private Sub formatear_grid()

        If Dtdm.Rows.Count <> 0 Then
            'Quitando lo necesario
            DataDetalleI.AllowUserToResizeRows = False
            DataDetalleI.RowHeadersVisible = False

            'Modificando el ancho de las columnas
            DataDetalleI.Columns.Item(1).Width = 30 'Item
            DataDetalleI.Columns.Item(2).Width = 30 'Des_Id
            DataDetalleI.Columns.Item(3).Width = 100 'NroGtf
            DataDetalleI.Columns.Item(4).Width = 140 'Especie
            DataDetalleI.Columns.Item(5).Width = 240 'Producto
            DataDetalleI.Columns.Item(6).Width = 80 'Piezas
            DataDetalleI.Columns.Item(7).Width = 80 'Volm3
            DataDetalleI.Columns.Item(8).Width = 60 'Desd_des_id
            DataDetalleI.Columns.Item(9).Width = 60 'Desd_des_id

            'Cambiando el texto de las cabeceras
            DataDetalleI.Columns(1).HeaderText = "Item"
            DataDetalleI.Columns(2).HeaderText = "Id"
            DataDetalleI.Columns(3).HeaderText = "Nro. GTF"
            DataDetalleI.Columns(4).HeaderText = "Especie"
            DataDetalleI.Columns(5).HeaderText = "Producto"
            DataDetalleI.Columns(6).HeaderText = "Piezas"
            DataDetalleI.Columns(7).HeaderText = "Volm3"
            DataDetalleI.Columns(8).HeaderText = "Desd_des_id"
            DataDetalleI.Columns(9).HeaderText = "Desd_lt_id"

            'Coultando algunas columnas
            DataDetalleI.Columns.Item(2).Visible = False 'Des_Id
            DataDetalleI.Columns.Item(8).Visible = False
            DataDetalleI.Columns.Item(9).Visible = False

            DataDetalleI.Columns.Item(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataDetalleI.Columns.Item(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

            'Centrando todas las columnas del DataGridView
            DataDetalleI.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            DataDetalleI.Columns.Item(7).DefaultCellStyle.Format = "##0.#00"

            'Centrando todos los Encabezados de las columnas del DataGridView
            DataDetalleI.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ocultar_columnas()
            sumar_volumenytrozas()
        End If
        ocultar_columnas()
    End Sub

    Private Sub ocultar_columnas()
        DataDetalleI.Columns.Item("Eliminar").Visible = False
    End Sub

    Private Sub btnSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSig.Click
        recno += 1
        If recno <= (nreg - 1) Then
            mostrar_encabezado()
            mostrar_detalle(txtId.Text)
            formatear_grid()
        Else
            recno = nreg - 1
        End If
    End Sub

    Private Sub btnAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnt.Click
        recno -= 1
        If recno >= 0 Then
            mostrar_encabezado()
            mostrar_detalle(txtId.Text)
            formatear_grid()
        Else
            recno = 0
        End If
    End Sub

    Private Sub btnPri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPri.Click
        recno = 0
        mostrar_encabezado()
        mostrar_detalle(txtId.Text)
        formatear_grid()
    End Sub

    Private Sub btnUlt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUlt.Click
        recno = nreg - 1
        mostrar_encabezado()
        mostrar_detalle(txtId.Text)
        formatear_grid()
    End Sub

    Private Sub limpiar_totales()
        'txtDespachadom3.Text = ""
        'txtAutorizadom3.Text = ""
        'txtDespachadopor.Text = ""
        'txtAutorizadopor.Text = ""
        'txtSaldoPor.Text = ""
        'txtSaldoM3.Text = ""
    End Sub

    Private Sub sumar_volumenytrozas()
        'Try

        '    Dim totVolm3 As Decimal
        '    Dim totDespapor, totAutopor, totSaldopor As Integer
        '    Dim totAutoVolm3, totSaldoVolm3 As Decimal

        '    If nregd <> 0 Then
        '        totVolm3 = Dtdm.Compute("Sum(desd_volm3)", Nothing)
        '        totDespapor = (totVolm3 * Convert.ToSByte(txtPorcentaje.Text)) / Convert.ToDecimal(txtVolm3Lista.Text)
        '        txtDespachadopor.Text = String.Format(totDespapor.ToString, "#0.00") + "%"
        '        txtDespachadom3.Text = totVolm3

        '    Else
        '        txtDespachadopor.Text = ""
        '        txtDespachadom3.Text = ""
        '    End If

        '    totAutopor = txtPorcentaje.Text
        '    totAutoVolm3 = txtVolm3Lista.Text
        '    totSaldopor = totAutopor - totDespapor
        '    totSaldoVolm3 = totAutoVolm3 - totVolm3

        '    txtAutorizadopor.Text = String.Format(totAutopor, "#0.00") + "%"
        '    txtSaldoPor.Text = String.Format(totSaldopor, "#0.00") + "%"
        '    txtSaldoM3.Text = totSaldoVolm3

        '    txtAutorizadom3.Text = totAutoVolm3

        '    'txtDespachadom3.Text = ""
        '    'txtAutorizadom3.Text = ""
        '    'txtDespachadopor.Text = ""
        '    'txtAutorizadopor.Text = ""
        '    'txtSaldoPor.Text = ""
        '    'txtSaldoM3.Text = ""

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Sub

    Private Sub mostrar_detalle(ByVal registro As Integer)

        Try
            If String.IsNullOrEmpty(txtId.Text) = False Then
                Dim dt As New DataSet
                Dim cn As New MySqlConnection(New fxSamad().GetCadenaConexionSamad())

                Dim da As New MySqlDataAdapter("SELECT p.desd_id AS ID,p.desd_NroGtf AS NroGtf,p.desd_codigo As LoteAser_Pqt,p.desd_especie AS Especie,p.desd_producto as Producto,p.Desd_ClaseC as Clase_Comercial,Desd_Cantidad as Cantidad,p.Desd_TipoUnid as Tipo_Unidad,p.desd_volm3 as Volm3,p.Desd_VolPt as VolPt FROM despacho_det AS p Where p.desd_des_id=" & txtId.Text, cn)
                da.Fill(dt, "despacho_det")
                CType(New MySqlDataAdapter("SELECT pd.Cat_Espesor As Espesor,pd.Cat_Ancho as Ancho,pd.Cat_Largo as Largo,pd.Cat_Cantidad as Cantidad,pd.Cat_Volm3 as Volm3,pd.Cat_VolPT as VolPt,pd.Cat_Des_Id as ID FROM despacho_catalogo AS pd;", cn), MySqlDataAdapter).Fill(dt, "detalle")
                dt.Relations.Add("1", dt.Tables("despacho_det").Columns("Id"), dt.Tables("detalle").Columns("ID"), False)
                DataDetalle.PrimaryGrid.DataSource = dt
                DataDetalle.PrimaryGrid.ColumnHeader.RowHeight = 24

                If dt.Tables.Count > 0 Then
                    btnEliminar.Enabled = True
                    nregd = dt.Tables.Count
                Else
                    btnEliminar.Enabled = False
                End If

            End If

            'Dim dtl As New vDespacho_det
            'Dim func As New fdespacho_det 'Creacion una variable para hacer referencia a la funcion fconcesiones
            'dtl.gdesddesid = registro
            'Dtdm = func.mostrar(registro) 'Invocamos a la funcion mostrar()
            'DataDetalleI.Columns.Item("Eliminar").Visible = False 'Ocultamos la Columna Eliminar
            'Almacenamos la cantidad de filas o registros recuperados
            If nregd <> 0 Then 'Si las filas al contarlas es diferente de cero
                '    DataDetalleI.DataSource = Dtdm
                '    DataDetalleI.ColumnHeadersVisible = True
                '    formatear_grid()
                registro_seleccionado()
                sumar_volumenytrozas()
                ocultar_columnas()
            Else
                '    DataDetalleI.DataSource = Nothing
                '    DataDetalleI.ColumnHeadersVisible = False
                '    limpiar_campos_detalle()
            End If
            estado_botones_items()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

        frmNroLista.titulo = "Buscar Documentos"
        frmNroLista.t_tabla = "vmostrar_documentos_formato02"
        frmNroLista.t_campos = "f02_id,f02_nrodoc,f02_fecha,count(f02_id) as Trozas,sum(volm3) as Volm3"
        frmNroLista.t_donde = ""
        frmNroLista.t_agruparpor = "f02_id"
        frmNroLista.t_ordenarpor = "f02_fecha desc"

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Nro.Doc.", "Fecha", "Trozas", "Volm3"} 'Arreglo par los titulos
        Dim anchos() As Integer = {30, 80, 70, 50, 50} 'Arreglo para los anchis
        Dim alineacion() As String = {"Center", "Left", "Center", "Center", "Center"} 'Arreglo para las alineaciones

        ReDim frmNroLista.matAnchos(anchos.Length)
        ReDim frmNroLista.matTitulos(titulos.Length)
        ReDim frmNroLista.matColumnas(titulos.Length)
        ReDim frmNroLista.matAlineacion(titulos.Length)

        titulos.CopyTo(frmNroLista.matTitulos, 0)
        anchos.CopyTo(frmNroLista.matAnchos, 0)
        alineacion.CopyTo(frmNroLista.matAlineacion, 0)

        frmNroLista.ShowDialog(Me)

        'Datos del Vehiculo frmbuscardoc
        If frmNroLista.flag = True Then

            recno = frmNroLista.matColumnas(0) '- 1
            If recno <> 0 Then
                Dim valor As Integer = -1
                Dim index As Integer = 0
                Do While valor <> recno
                    valor = Dte.Rows(index).Item("Id")
                    index += 1
                Loop
                recno = index - 1

                mostrar_encabezado()
                Deshabilitar_datos()
                mostrar_detalle(frmNroLista.matColumnas(0))
                formatear_grid()
            End If

        End If
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If String.IsNullOrEmpty(txDespacho.Text) = False Then
            Dim frmDetalle As New frmDespacho_det

            'Formulario para ingreso Troza por troza
            Dim reg As Integer = Dtdm.Rows.Count 'Contamos 
            frmDetalle.txtReg.Text = txtId.Text 'reg + 1
            frmDetalle.txtPeriodo.Text = xtPeriodo
            frmDetalle.xExiste = True
            frmDetalle.xdespachoID = CInt(txtId.Text) 'Aqui envio el valor del despacho_Id
            frmDetalle.xcontratoid = CInt(txt_Con_Id.Text)
            frmDetalle.contratonro = txt_Con_Contrato.Text
            frmDetalle.xcodDespacho = txDespacho.Text
            frmDetalle.ShowDialog(Me) 'Mostramos el Formulario FrmDetalle
            If frmDetalle.sw = True Then
                btnUlt_Click(Me, e)
            End If
        Else
            MessageBox.Show("Debe seleccion un registro para poder editarlo", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        End If




        'nuevoItem = True
        'Dim frmDetalle As New frmFormato02_det

        'Dim reg As Integer = Dtdm.Rows.Count 'Contamos 
        ''Enviando los datos del DataGrid al Formulario
        'frmDetalle.txtReg.Text = DataDetalle.SelectedCells.Item(1).Value 'Numero de registro
        'frmDetalle.txtCodificacion.Text = DataDetalle.SelectedCells.Item(4).Value 'Coigo
        'frmDetalle.txtAutogenerado.Text = DataDetalle.SelectedCells.Item(5).Value 'Autogenerado
        'frmDetalle.txt_Especie_Nombre.Text = DataDetalle.SelectedCells.Item(6).Value 'Especie
        'frmDetalle.txtD1.Text = DataDetalle.SelectedCells.Item(7).Value ' D1
        'frmDetalle.txtD2.Text = DataDetalle.SelectedCells.Item(8).Value 'D2
        'frmDetalle.txtD3.Text = DataDetalle.SelectedCells.Item(9).Value 'D3
        'frmDetalle.txtVolm3.Text = DataDetalle.SelectedCells.Item(10).Value 'Volm3
        'frmDetalle.txtObservacion.Text = DataDetalle.SelectedCells.Item(11).Value 'Observacion
        'frmDetalle.txtObservacion.Enabled = True

        'frmDetalle.ShowDialog(Me) 'Mostramos el Formulario FrmDetalle
        'If frmDetalle.Sw = True Then
        '    Dim result As DialogResult
        '    'validar_campos()
        '    sw_guardard = True
        '    If sw_guardard = True Then 'Guardamos si los controles no estan vacios
        '        result = MessageBox.Show("Esta seguro de GUARDAR el registro ?", "Guardar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        '        If result = DialogResult.OK Then
        '            Try
        '                Dim dtse As New vFormato02_det
        '                Dim funce As New fformato02_det

        '                dtse.gf02d_f02_id = TxtId.Text
        '                dtse.gf02d_id = DataDetalle.SelectedCells.Item(2).Value
        '                dtse.gf02d_especie = frmDetalle.txt_Especie_Nombre.Text
        '                dtse.gf02d_codificacion = frmDetalle.txtCodificacion.Text
        '                dtse.gf02d_d1 = frmDetalle.txtD1.Text
        '                dtse.gf02d_d2 = frmDetalle.txtD2.Text
        '                dtse.gf02d_d3 = frmDetalle.txtD3.Text
        '                dtse.gf02d_volm3 = frmDetalle.txtVolm3.Text
        '                dtse.gf02d_cut = frmDetalle.txtAutogenerado.Text
        '                dtse.gf02d_observacion = frmDetalle.txtObservacion.Text

        '                'Codigo para insertar registros
        '                If funce.editar(dtse) Then
        '                    MessageBox.Show("Datos guardados correctamente...!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '                    mostrar_detalle(TxtId.Text)
        '                    btnNuevo.Enabled = False
        '                    btnModificar.Enabled = False
        '                    btnGuardar.Enabled = True
        '                    btnDeshacer.Enabled = True
        '                    btnSalir.Enabled = True
        '                    sumar_volumenytrozas()
        '                    formatear_grid()
        '                Else
        '                    MessageBox.Show("Datos No fueron registrados, intente de nuevo!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                    mostrar_detalle(recno)
        '                End If
        '            Catch ex As Exception
        '                MsgBox(ex.Message)
        '            End Try
        '        End If
        '    Else
        '        MessageBox.Show(msg, "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End If
        'End If
    End Sub

    Private Sub registro_seleccionado()
        If nregd <> 0 Then
            'TxtObservaDetalle.Text = DataDetalle.SelectedCells.Item(11).Value
        End If
    End Sub

    Private Sub estado_botones_items()
        If nregd <> 0 Then
            btnAgregarItem.Enabled = True
            btnEditar.Enabled = True
            btnEliminar.Enabled = False
            btnEliminarDoc.Enabled = True
            chkEliminar.Enabled = True
        Else
            btnAgregarItem.Enabled = True
            btnEditar.Enabled = False
            btnEliminar.Enabled = False
            btnEliminarDoc.Enabled = True
            chkEliminar.Enabled = False
        End If
    End Sub

    Private Sub limpiar_campos_detalle()
        'TxtObservaDetalle.Text = ""
    End Sub

    Function descontar_trozas_agregadas()

        Dim dtsr As New vShowbrow
        Dim func As New fshowbrow

        dtsr.gt_tabla = "formato02_det"
        dtsr.gt_campos = "f02d_cut as valor_buscado"
        dtsr.gt_donde = ""
        dtsr.gt_agruparpor = ""
        dtsr.gt_ordenarpor = ""

        Dtdta = func.mostrar(dtsr)

        Dim cadena As String = ""
        Dim registros As Integer = Dtdta.Rows.Count

        If registros <> 0 Then
            Dim arrCuts(registros) As String
            Dim i As Integer = 0
            For Each columna As DataRow In Dtdta.Rows
                arrCuts(i) = CStr(columna("valor_buscado"))
                If (i + 1) <> registros Then
                    cadena = cadena + "'" + arrCuts(i) + "'" + ","
                Else
                    cadena = cadena + "'" + arrCuts(i) + "'"
                End If
                i = i + 1
            Next
        End If
        Return cadena
    End Function

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Habilitar_datos()
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnDeshacer.Enabled = True
        btnSalir.Enabled = False
        btnEliminarDoc.Enabled = False
        'Botones del Detalle
        deshabilitar_botones_desplazamiento()
        btnAgregarItem.Enabled = False
        btnEditar.Enabled = False
        chkEliminar.Enabled = False
        limpiar_totales()
        limpiar()
        DataDetalleI.DataSource = Nothing
        'dataResumen.DataSource = Nothing
        nuevo = True
        modificar = False
        txtNroDoc.Text = optener_siguiente_numero_lista()
        'gbConcesion.BackColor = Color.Khaki
    End Sub

    Private Sub btnDeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeshacer.Click
        recno = recno
        mostrar_encabezado()
        Deshabilitar_datos()
        mostrar_detalle(IIf(txtId.Text <> "", txtId.Text, 0))
        If txtId.Text <> "" Then
            formatear_grid()
        Else
            limpiar()
            txtNroDoc.Text = ""
        End If
        habilitar_botones_desplazamiento()
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnGuardar.Enabled = False
        btnDeshacer.Enabled = False
        btnAgregarItem.Enabled = False
        btnSalir.Enabled = True

        habilitar_botones_desplazamiento()
        btnAgregarItem.Enabled = True
        btnEditar.Enabled = True
        chkEliminar.Enabled = True
    End Sub

    Private Sub frmDespacho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'recno = nreg + 1
        recno = nreg
        mostrar_encabezado()
        mostrar_detalle(IIf(txtId.Text <> "", txtId.Text, 0))
        mostrar_resumen()
        formatear_grid()
        Deshabilitar_datos()

        If recargalita = True Then
            btnUlt.PerformClick()
        End If
        'AplicarPerfil()

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
            Dim result As DialogResult

            'validar_campos()
            sw_guardar = True
            If sw_guardar = True Then 'Guardamos si los controles no estan vacios
                result = MessageBox.Show("Esta seguro de GUARDAR el registro ?", "Guardar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If result = DialogResult.OK Then
                    Try

                        'Guardando los datos de Encabezado
                        Dim dts As New vDespacho
                        Dim func As New fdespacho

                        dts.gnrodoc = txtNroDoc.Text
                        dts.gubigeo = TxUbigeo.Text
                        dts.garffs = txDeffs.Text
                        dts.gfecha = txtFecha.Text
                        dts.gfechaven = TxFecha_Ven.Text
                        dts.gperiodo = xtPeriodo
                        dts.tipTrans = cbTipoTransporte.Text
                        dts.gtitularid = txt_Con_Id.Text
                        dts.gpropietarioid = txt_Pro_Id.Text
                        dts.gtipocv = TxTipo_com_CV.Text
                        dts.gnrocv = TxNro_Cv_Serie.Text & "-" & TxNro_Com_Cv.Text
                        dts.gnroguiarem = TxNroSerie.Text & "-" & TxNroGuia.Text
                        dts.gdestinatarioid = txt_Des_Id.Text
                        dts.gtransportistaid = txt_Conductor_Id.Text
                        dts.gvehiculoid = txt_veh_id.Text
                        dts.gcontratoid = txt_Contrato_Id.Text



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
                                btnDeshacer.Enabled = False
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
                            dts.gdesid = txtId.Text
                            If func.editar(dts) Then
                                MessageBox.Show("Datos editados correctamente...!", "Editando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                limpiar()
                                mostrar_encabezado()
                                sumar_volumenytrozas()
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

    Private Sub btnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAgregarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarItem.Click
        nuevoItem = True

        Dim frmDetalle As New frmDespacho_det

        'Formulario para ingreso Troza por troza
        Dim reg As Integer = Dtdm.Rows.Count 'Contamos 
        frmDetalle.txtReg.Text = txtId.Text 'reg + 1
        frmDetalle.txtPeriodo.Text = xtPeriodo
        frmDetalle.xExiste = False
        frmDetalle.xdespachoID = CInt(txtId.Text)
        frmDetalle.contratonro = txt_Con_Contrato.Text
        'frmDetalle.xcodDespacho = txDespacho.Text
        frmDetalle.ShowDialog(Me) 'Mostramos el Formulario FrmDetalle

        If frmDetalle.sw = True Then

            Dim result As DialogResult
            'validar_campos()
            sw_guardard = True
            If sw_guardard = True Then 'Guardamos si los controles no estan vacios
                result = MessageBox.Show("Esta seguro de GUARDAR el registro ?", "Guardar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If result = DialogResult.OK Then
                    Try
                        Dim dtsd As New vDespacho_det
                        Dim funcd As New fdespacho_det

                        dtsd.gdesddesid = txtId.Text
                        dtsd.gnrogtf = frmDetalle.txtNroGtf.Text
                        dtsd.gespecie = "" ' frmDetalle.txt_Especie_Nombre.Text
                        dtsd.gproducto = "" ' frmDetalle.txtProducto.Text
                        dtsd.gpiezas = "" 'frmDetalle.txGTF.Text
                        dtsd.gvolm3 = "" 'frmDetalle.txtVolm3.Text
                        dtsd.gdesdltid = frmDetalle.txtNroGtfId.Text

                        'Codigo para insertar registros
                        If funcd.insertar(dtsd) Then
                            MessageBox.Show("Datos guardados correctamente...!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'mostrar_encabezado()
                            mostrar_detalle(txtId.Text)
                            mostrar_resumen()
                            btnNuevo.Enabled = True
                            btnModificar.Enabled = True
                            btnGuardar.Enabled = False
                            btnDeshacer.Enabled = False
                            estado_botones_items()
                            btnSalir.Enabled = True
                            sumar_volumenytrozas()
                            formatear_grid()

                        Else
                            MessageBox.Show("Datos No fueron registrados, intente de nuevo!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            mostrar_detalle(recno)
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

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Habilitar_datos()

        btnSalir.Enabled = False
        btnAgregarItem.Enabled = True
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnDeshacer.Enabled = True
        btnEliminarDoc.Enabled = False

        deshabilitar_botones_desplazamiento()
        btnAgregarItem.Enabled = False
        btnEditar.Enabled = False

        chkEliminar.Enabled = False
        nuevo = False
        modificar = True
    End Sub

    Private Sub mostrar_resumen()

        Try

            If String.IsNullOrEmpty(txtId.Text) = False Then
                Dim col As Integer
                Dim dtsr As New vShowbrow
                Dim func As New fshowbrow
                dtsr.gt_tabla = "despacho_det"
                dtsr.gt_campos = "desd_nrogtf as 'Nro. GTF',desd_especie as Especie,sum(desd_cantidad) as Piezas,sum(desd_volm3) as Volm3"
                dtsr.gt_donde = "desd_des_id =" + txtId.Text
                dtsr.gt_agruparpor = "desd_nrogtf,desd_especie"
                dtsr.gt_ordenarpor = ""
                Dt = func.mostrar(dtsr) 'Invocamos a la funcion mostrar()
                If Dt.Rows.Count <> -1 Then 'Si las filas al contarlas es diferente de cero
                    col = Dt.Columns.Count
                    dataResumen.AllowUserToResizeRows = False
                    dataResumen.RowHeadersVisible = False
                    dataResumen.DataSource = Dt
                    'Formateando las columnas
                    dataResumen.Columns.Item(0).Width = 100
                    dataResumen.Columns.Item(1).Width = 100
                    dataResumen.Columns.Item(2).Width = 60
                    dataResumen.Columns.Item(3).Width = 50
                    dataResumen.Columns.Item(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    dataResumen.Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    dataResumen.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dataResumen.Columns.Item(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dataResumen.Columns.Item(3).DefaultCellStyle.Format = "###.000"
                    dataResumen.ColumnHeadersVisible = True
                    dataResumen.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Else
                    dataResumen.DataSource = Nothing
                    dataResumen.ColumnHeadersVisible = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtPorcentaje_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

        ' "0123456789.-" Valores o caracteres que solo aceptara el TextBox
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub

    Private Sub txtPorcentaje_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'calcular_porcentaje()
    End Sub

    Private Sub chkEliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEliminar.CheckedChanged
        If chkEliminar.CheckState = CheckState.Checked Then
            'DataDetalleI.Columns.Item("Eliminar").Visible = True
            'DataDetalleI.Columns.Item("Eliminar").Width = 20
            'DataDetalleI.Columns.Item("Eliminar").HeaderText = ""
            btnEliminar.Enabled = True
        Else
            'DataDetalleI.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult
        Dim Actualizado As Boolean
        Dim dz As New samadEntities
        If String.IsNullOrEmpty(txDespacho.Text) = True Then
            MessageBoxEx.Show("Debe seleccionar el Registro que desea borrar", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        result = MessageBox.Show("Esta seguro de ELIMINAR " & txDespacho.Text & " registro(s) seleccionado(s)...?", "Eliminar registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                'If New cdFormato04_rumas().RumaTieneDetalle(CInt(txDespacho.Text)) = True Then
                '    MessageBox.Show("No es posible borrar este registro porque esta Ruma tiene detalle", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    Exit Sub
                'End If
                If MessageBox.Show("¿Realmente desea borrar este Registro de Despacho?", "Despacho", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If

                Dim paqueteruma = dz.despacho_det.Where(Function(x) x.Desd_Id = CInt(txDespacho.Text)).Select(Function(y) y.Desd_RumaPaquete).FirstOrDefault()

                If paqueteruma = 1 Then 'ruma
                    'xrumadespachoId
                    Actualizado = New fxSamad().Actlote("Update formato04_rumas Set estatus=0 Where rumaid=" & xrumapaqueteid & " And estatus = 1")
                    Actualizado = New fxSamad().Actlote("Update formato04_rumas_det Set estatus=0 Where rumaid=" & xrumapaqueteid & " And estatus = 1")
                Else 'paquete 
                    Dim codigoactiva = dz.paquete.Where(Function(x) x.Numpaquete = xrumapaqueteid And x.Estatus = 1).Select(Function(y) y.RowId).FirstOrDefault()
                    Actualizado = New fxSamad().Actlote("Update paquete Set estatus=0 Where rowid=" & codigoactiva & " And estatus = 1")
                    Actualizado = New fxSamad().Actlote("Update paquete_deta Set estatus=0 Where paqueteid=" & codigoactiva & " And estatus = 1")
                End If

                Dim xa = New fxSamad().BORRAR("despacho_det", "desd_id=" & txDespacho.Text)
                Dim de = New fxSamad().BORRAR("despacho_catalogo", "cat_des_id=" & txDespacho.Text)
                MessageBox.Show("Se Elimnado el registro de despacho satisfactoriamente", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)

                mostrar_detalle(txtId.Text)
                mostrar_resumen()
                formatear_grid()
                sumar_volumenytrozas()
                chkEliminar.Checked = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataDetalle_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataDetalleI.CellContentClick
        If e.ColumnIndex = Me.DataDetalleI.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.DataDetalleI.Rows(e.RowIndex).Cells("Eliminar")
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

    Private Sub btnConcesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConcesion.Click
        'Enviamos los datos de la consulta sql
        frm.titulo = "Titular y Contrado"
        'frm.t_tabla = "vmostrar_listatrozasc"
        frm.t_tabla = "vmostrar_titulares_aserrio"
        frm.t_campos = "titularid,titular,contratoID,contrato,departamento,provincia,distrito,OrigenRecurso,Resolucion,TipoPm,Rep_Legal,periodo"
        'frm.t_campos = "lt_titular_id,pro_titular,con_descripcion,departamento,provincia,distrito,pro_sector,con_id,titular_ruc,lt_deffs"
        frm.t_donde = ""
        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array

        'Dim titulos() As String = {"Id", "Titular", "Contrato", "Departamento", "Provincia", "Distrito", "Sector", "contratoid", "Ruc", "Deffs"}
        Dim titulos() As String = {"Id", "Titular", "ContratoID", "Contrato", "Departamento", "Provincia", "Distrito", "Orig. Recurso", "Resolucion", "Tipo PM", "Rep_Legal", "periodo"}
        Dim anchos() As Integer = {30, 280, 120, 0, 0, 0, 0, 0, 0, 0, 0, 0}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)
        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog(Me)

        'Datos del Titular
        If frm.flag = True Then

            txt_Con_Id.Text = frm.matColumnas(0)
            txt_Con_Titular.Text = frm.matColumnas(1)
            txt_Contrato_Id.Text = frm.matColumnas(2)
            txt_Con_Contrato.Text = frm.matColumnas(3)
            txt_Con_Depto.Text = frm.matColumnas(4)
            txt_Con_Provincia.Text = frm.matColumnas(5)
            txt_Con_Distrito.Text = frm.matColumnas(6)
            TxOrigen_Rec.Text = frm.matColumnas(7)
            TxNroResolucion.Text = frm.matColumnas(8)
            TxTipopm.Text = frm.matColumnas(9)
            TxRep_legal.Text = frm.matColumnas(10)
            xtPeriodo = frm.matColumnas(11)
        End If
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
            txt_Pro_Id.Text = frmpp.matColumnas(0)
            txt_Pro_Nombre.Text = frmpp.matColumnas(1)
            txtDniLEP.Text = frmpp.matColumnas(2)
            txtRucRusP.Text = frmpp.matColumnas(3)
            txtDireccion.Text = frmpp.matColumnas(4)
            TxDepto_P.Text = frmpp.matColumnas(5)
            TxProv_p.Text = frmpp.matColumnas(6)
            TxDist_p.Text = frmpp.matColumnas(7)

        End If
    End Sub

    Private Sub btnDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDestino.Click

        frmd.t_tabla = "vmostrar_titulares"
        frmd.t_campos = "pro_id,pro_titular,pro_ruc,departamento,provincia,distrito,pro_direccion,pro_dni"
        frmd.t_donde = ""
        frmd.t_agruparpor = ""
        frmd.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Razón Social", "Ruc", "Dpto", "Provincia", "Distrito", "Dirección", "Dni"}
        Dim anchos() As Integer = {30, 200, 60, 90, 90, 90, 90}

        ReDim frmd.matAnchos(anchos.Length)
        ReDim frmd.matTitulos(titulos.Length)
        ReDim frmd.matColumnas(titulos.Length)
        titulos.CopyTo(frmd.matTitulos, 0)
        anchos.CopyTo(frmd.matAnchos, 0)

        frmd.ShowDialog(Me)

        'Datos de Propietarios
        If frmd.flag = True Then
            txt_Des_Id.Text = frmd.matColumnas(0)
            txt_Des_Nombre.Text = frmd.matColumnas(1)
            txt_Des_Ruc.Text = frmd.matColumnas(2)
            txt_Des_Depto.Text = frmd.matColumnas(3)
            txt_Des_Provincia.Text = frmd.matColumnas(4)
            txt_Des_Distrito.Text = frmd.matColumnas(5)
            txt_Des_Direccion.Text = frmd.matColumnas(6)
            txtDniLED.Text = frmd.matColumnas(7)
        End If
    End Sub

    Private Sub btnConductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConductor.Click
        'Enviamos los datos de la consulta sql
        If txt_veh_id.Text <> "" Then
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
                txt_Conductor_Id.Text = frmco.matColumnas(0)
                txt_Conductor_Nombre.Text = frmco.matColumnas(1)
                txt_Conductor_Licencia.Text = frmco.matColumnas(2)
                txt_Conductor_Dni.Text = frmco.matColumnas(3)
            End If
        Else

            MessageBox.Show("Debe ingresar un Vehículo Primero", "Mensaje")

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
            txt_veh_id.Text = frmpl.matColumnas(0)
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

    Private Sub mostrar_resumen_gtf()

        Try

            Dim col As Integer
            Dim dtsr As New vShowbrow
            Dim func As New fshowbrow

            dtsr.gt_tabla = "despacho_det"
            dtsr.gt_campos = "desd_nrogtf as 'Nro. GTF',sum(desd_cantidad) as Piezas,sum(desd_volm3) as Volm3"
            dtsr.gt_donde = "desd_des_id =" + txtId.Text
            dtsr.gt_agruparpor = "desd_nrogtf,desd_especie"
            dtsr.gt_ordenarpor = ""

            Dt = func.mostrar(dtsr) 'Invocamos a la funcion mostrar()

            If Dt.Rows.Count <> -1 Then 'Si las filas al contarlas es diferente de cero
                col = Dt.Columns.Count
                dataResumen.AllowUserToResizeRows = False
                dataResumen.RowHeadersVisible = False
                dataResumen.DataSource = Dt
                'Formateando las columnas
                dataResumen.Columns.Item(0).Width = 100
                dataResumen.Columns.Item(1).Width = 100
                dataResumen.Columns.Item(2).Width = 60
                dataResumen.Columns.Item(3).Width = 50

                dataResumen.Columns.Item(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                dataResumen.Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                dataResumen.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dataResumen.Columns.Item(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                dataResumen.Columns.Item(3).DefaultCellStyle.Format = "###.000"

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

    Private Sub btnEliminarDoc_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarDoc.Click
        If String.IsNullOrEmpty(txtId.Text) = True Then
            MessageBox.Show("No hay registro disponible para borrar", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If New cdDespacho().DespachoDespachoDet(txtId.Text) = True Then
            MessageBox.Show("Esta registro de despacho dependientes a este nro de documento, no es posible borrar el Registro", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If New fxSamad().BORRAR("despacho", "RowId=" & txtId.Text) = False Then
            MessageBox.Show("Registro borrado con exito", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'Exit Sub
            btnAnt_Click(Me, e)
        End If
    End Sub

    'Private Sub txtFecha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtFecha.ValueChanged
    '    xtPeriodo = Year(txtFecha.Value.ToShortDateString())
    'End Sub

    Private Sub DataDetalle_Click(sender As System.Object, e As System.EventArgs) Handles DataDetalle.Click
        Dim xPanel As GridPanel = DataDetalle.PrimaryGrid
        Dim xRow As GridRow = Nothing
        Dim dm As New samadEntities
        ' Dim xProducto As String
        If xPanel.Rows.Count() > 0 Then
            xRow = xPanel.ActiveRow
            txDespacho.Text = xRow.Cells(0).Value
            xrumapaqueteid = CInt(xRow.Cells(2).Value)
        End If
    End Sub

   

    Private Sub btnImpDespacho_Click(sender As System.Object, e As System.EventArgs) Handles btnImpDespacho.Click
        Dim db As New samadEntities
        Dim dt As New DespachoCab
        Dim dtb As New DespachoCab
        Dim cn As New MySqlConnection(New fxSamad().GetCadenaConexionSamad())

        'Select * from 
        'despacho
        'INNER JOIN despacho_det ON despacho.Des_Id = despacho_det.Desd_Des_Id
        'INNER JOIN despacho_catalogo ON despacho_det.Desd_Id = despacho_catalogo.Cat_Des_Id

        'Dim resul = (From c In db.vw_listadodespachocabecera
        '           From d In db.despacho_det
        '           Where d.Desd_Des_Id = c.des_id And c.des_nrodoc = txtNroDoc.Text And d.Desd_Des_Id = CInt(txtId.Text)
        '           Select New ReporteDespacho With {.Cabecera = c,
        '                                        .Detalle = d}).ToList()


        'Dim r As New ReporteDespachoC
        'r.DataSource = resul '.Where(Function(p) String.IsNullOrEmpty(p.Detalle.Ltd_Autogenerado))
        'Dim rv As New frmReporte
        'rv.Viewer.ReportSource = r
        'rv.Show()
        'rv.Viewer.RefreshReport()

        'implementas el anexo por especies
        'Dim resula = (From c In db.despacho_det
        '              From d In db.despacho_catalogo Where d.Cat_Des_Id = c.Desd_Id And c.Desd_Des_Id = CInt(txtId.Text)
        '              Select New ReporteDespachoDet With {.CabeceraDet = c,
        '                                                  .DetalleCat = d}).ToList()

        'Dim cr As New ReportCatDesp
        'cr.DataSource = resula '.Where(Function(p) String.IsNullOrEmpty(p.Detalle.Ltd_Autogenerado))
        'Dim rw As New frmReporte
        'rw.Viewer.ReportSource = cr
        'rw.Show()
        'rw.Viewer.RefreshReport()

        Try

            'llenar datos para el reporte.




            'fin


            If String.IsNullOrEmpty(txtId.Text) = False Then

                Dim da As New MySqlDataAdapter("SELECT des_id as Id,des_ubigeo,des_Arffs,des_fecha,des_fecha_ven as fecha_ven,des_nrodoc,des_recurso,des_titular_id,des_titular_nombre,pro_ruc,des_rep_legal,des_resolucion,des_tipopm,departamento,provincia,distrito,des_propietario_id,des_propietario_nombre,prop_dni,prop_ruc,des_direccion_p,departamento_p,provincia_p,distrito_p,des_tipo_cv,des_nro_cv,des_destinatario_id,des_destinatario_nombre,des_dpto,des_prov,des_dist,des_direccion,des_ruc,des_dni,des_transportista_id,des_conductor_nombre,con_nrolicencia,con_dni,des_nro_guia_rem,des_vehiculo_id,veh_placa,veh_tipo,Veh_Tipo_vehic,des_contrato_id,Nrocontrato,des_tipotransporte FROM vw_listadodespachocabecera Where des_id=" & txtId.Text, cn)
                da.Fill(dt, "Cabecera")

                CType(New MySqlDataAdapter("SELECT ID,DetID,NroGtf,LoteAser_Pqt,Nom_Cientifico,Especie,Producto,Clase_Comercial,Cantidad,Tipo_Unidad,Volm3,VolPt FROM vw_listadodespachodetalle  Where ID=" & txtId.Text, cn), MySqlDataAdapter).Fill(dt, "Cabeceradet")
                'dt.Relations.Add("1", dt.Tables("Cabecera").Columns("Id"), dt.Tables("Cabeceradet").Columns("ID"), False)

                CType(New MySqlDataAdapter("SELECT despacho_det.Desd_Des_Id as IdD,despacho_catalogo.Cat_Des_Id as ID,despacho_catalogo.Cat_Espesor as Espesor,despacho_catalogo.Cat_Ancho as Ancho,despacho_catalogo.Cat_Largo as Largo,despacho_catalogo.Cat_Volm3 as Volm3,despacho_catalogo.Cat_VolPT as VolPT,despacho_catalogo.Cat_Cantidad as Cantidad,despacho_catalogo.Cat_Numero as Nro_Order FROM   despacho_det INNER JOIN despacho_catalogo ON despacho_det.Desd_Id = despacho_catalogo.Cat_Des_Id where despacho_det.Desd_Des_Id=" & txtId.Text, cn), MySqlDataAdapter).Fill(dt, "DespachoCat")

                CType(New MySqlDataAdapter("SELECT CatId,CatIdEspecie,CatDeDtsId,CatDesId,CatEspecie,CatEspesorA,CatAnchoA,CatLargoA,CatVolm3A,CatVolPtA,CatCamtidadA,CatEspesorB,CatAnchoB,CatLargoB,CatVolm3B,CatVolPtB,CatCamtidadB,CatEspesorC,CatAnchoC,CatLargoC,CatVolm3C,CatVolPtC,CatCamtidadC,CatEspesorD,CatAnchoD,CatLargoD,CatVolm3D,CatVolPtD,CatCamtidadD,CatEstatus FROM catalogodespachoreport WHERE CatDesId=" & txtId.Text, cn), MySqlDataAdapter).Fill(dt, "ReportCatA")

                CType(New MySqlDataAdapter("select id,Var,space(20) as campo from formatHoja", cn), MySqlDataAdapter).Fill(dt, "ReportHoja") 'existe?



                If dt.Tables.Count > 0 Then

                    Dim cr As New ReportDespachoCr
                    cr.SetDataSource(dt)
                    Dim rp As New frmReport
                    rp.CrystalReportViewer1.ReportSource = cr
                    rp.Show()
                    rp.Refresh()

                    'Dim dab As New MySqlDataAdapter("SELECT p.desd_id AS ID,p.desd_NroGtf AS NroGtf,p.desd_codigo As LoteAser_Pqt,p.desd_especie AS Especie,p.desd_producto as Producto,p.Desd_ClaseC as Clase_Comercial,Desd_Cantidad as Cantidad,p.Desd_TipoUnid as Tipo_Unidad,p.desd_volm3 as Volm3,p.Desd_VolPt as VolPt FROM despacho_det AS p  Where p.Desd_Des_Id=" & txtId.Text, cn)
                    'dab.Fill(dtb, "DeapachoDet")
                    'CType(New MySqlDataAdapter("SELECT despacho_det.Desd_Des_Id as IdD,despacho_catalogo.Cat_Des_Id as ID,despacho_catalogo.Cat_Espesor as Espesor,despacho_catalogo.Cat_Ancho as Ancho,despacho_catalogo.Cat_Largo as Largo,despacho_catalogo.Cat_Volm3 as Volm3,despacho_catalogo.Cat_VolPT as VolPT,despacho_catalogo.Cat_Cantidad as Cantidad FROM   despacho_det INNER JOIN despacho_catalogo ON despacho_det.Desd_Id = despacho_catalogo.Cat_Des_Id where despacho_det.Desd_Des_Id=" & txtId.Text, cn), MySqlDataAdapter).Fill(dtb, "DespachoCat")
                    'dt.Relations.Add("1", dt.Tables("Cabecera").Columns("Id"), dt.Tables("Cabeceradet").Columns("ID"), False)

                    'Dim report As New 

                    'Dim rpb As New frmReporteCatalogo
                    'Dim rds As New ReportDataSource()
                    'rpb.ReportViewer1.ProcessingMode = ProcessingMode.Local  'Tipo de procesamiento del visor
                    'rpb.ReportViewer1.Visible = True
                    'rpb.ReportViewer1.SetDisplayMode(DisplayMode.Normal)
                    'rpb.ReportViewer1.LocalReport.ReportEmbeddedResource = "SAMAD.CatlogoRePort.rdlc"
                    'Dim rd As New ReportDataSource("Datos", dt.Tables(0))   'Dataset utilizado para poblar el reporte y la tabla que se utilizara
                    'rpb.ReportViewer1.LocalReport.DataSources.Clear()              'limpio la fuente de datos
                    'rpb.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Cabecera", dt.Tables(0)))           'Agrego el ReportDatasource
                    'rpb.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("CabeceraDetalle", dt.Tables(1)))
                    'rpb.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("CatalogoDetalle", dt.Tables(2)))
                    'rpb.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DetalleCatalogo", dt.Tables(3)))
                    'rpb.ReportViewer1.RefreshReport()
                    'rpb.Show()

                    Dim crc As New CatalogoReporte_01
                    crc.SetDataSource(dt)
                    Dim rpt As New FmrReporte_Catalogo1
                    rpt.CrystalReportViewer1.ReportSource = crc
                    rpt.Show()
                    rpt.Refresh()

                Else

                End If

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDeffs_Click(sender As System.Object, e As System.EventArgs) Handles btnDeffs.Click
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
                btnDestino.Select()
            Case Keys.Tab, Keys.Enter
                e.Handled = True
                If String.IsNullOrEmpty(TxNro_Com_Cv.Text) = True Then
                    MessageBox.Show("Por favor ingrese el Numero de Serie", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    TxNro_Com_Cv.Focus()
                    Exit Sub
                End If
                If IsNumeric(TxNro_Com_Cv.Text) = True Then
                    TxNro_Com_Cv.Text = Microsoft.VisualBasic.Right("000000" + TxNro_Com_Cv.Text, 6)
                End If
                btnDestino.Focus()
                btnDestino.Select()
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
                btnPlaca.Select()
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
                btnPlaca.Select()
        End Select
    End Sub

    Private Sub TxNroGuia_Click(sender As Object, e As System.EventArgs) Handles TxNroGuia.Click
        TxNroGuia.SelectionLength = TxNroGuia.Text.Length
    End Sub

#End Region


    Private Sub LblArffs_Click(sender As System.Object, e As System.EventArgs) Handles LblArffs.Click
        Dim frmDeffs As New FrmDeffs
        frmDeffs.ShowDialog(Me)
    End Sub

    Private Sub lblPropietario_Click(sender As System.Object, e As System.EventArgs) Handles lblPropietario.Click
        Dim frmTitulares As New frmTitulares
        frmTitulares.ShowDialog(Me)
    End Sub

    Private Sub lblDeestino_Click(sender As System.Object, e As System.EventArgs) Handles lblDeestino.Click
        Dim frmTitulares As New frmTitulares
        frmTitulares.ShowDialog(Me)
    End Sub

    Private Sub lblVehiculo_Click(sender As System.Object, e As System.EventArgs) Handles lblVehiculo.Click
        Dim frmVehiculos As New frmVehiculos
        frmVehiculos.ShowDialog(Me)
    End Sub

    Private Sub lblConductor_Click(sender As System.Object, e As System.EventArgs) Handles lblConductor.Click
        Dim frmConductores As New frmConductores
        frmConductores.ShowDialog(Me)
    End Sub

    Private Sub lblResponsable_Click(sender As System.Object, e As System.EventArgs)
        Dim frmPersonal As New frmPersonal
        frmPersonal.ShowDialog(Me)
    End Sub

    Private Sub TxTipo_com_CV_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxTipo_com_CV.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                TxNro_Cv_Serie.Focus()
            Case Keys.Tab, Keys.Enter
 
                    TxNro_Cv_Serie.Focus()
        End Select
    End Sub

 
End Class