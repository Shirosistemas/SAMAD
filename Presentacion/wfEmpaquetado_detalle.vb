
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Public Class wfEmpaquetado_detalle
    Friend calcula As Boolean
    Friend xEmpquetadoId As Integer
    Friend xIdaserradero As Integer
    Friend xPeriodo As Integer 'String = Nothing
    Friend xExiste As Boolean
    Friend recno As Integer = 0
    Friend xmodific As Integer = 0
    Dim xcantidad As Integer = 0
    Dim xCantrozas As Integer = 0
    Dim xIdPaquete As Integer = 0
    Dim xId As Integer
    Dim xvolptRumas As Decimal = 0
    Dim xFe As Integer = 0
    Dim npiezas As Integer = 0
    Dim nvolpt As Decimal
    Dim nvolm3 As Decimal
    Dim xUticantidad As Integer = 0
    Dim xUtiVolM3 As Decimal
    Dim xUtiVolPT As Decimal
    Dim xUticantidad1 As Integer = 0
    Dim xUtiVolM31 As Decimal
    Dim xUtiVolPT1 As Decimal
    Dim xAprovechable As Double
    Friend xpaqueteId, xprofinalId, xubicacionId As Integer
    Friend xtipocubicacion As String
    Dim xTitulo = fxSamad.Titulo
    'Dim lsHeader As List(Of SAMAD.vw_rumas)
    Dim lsHeader As List(Of SAMAD.paquete)
    Dim xId_aserrio02 As String = 0


#Region "Funciones y Procedimientos del Sistema"

    Private Sub listarEncabecados()
        If lsHeader.Count() > 0 Then
            lblIDPapa.Text = lsHeader(recno).EmpaquetadoId
            lbPaquetID.Text = lsHeader(recno).RowId
            txRumaId.Text = lsHeader(recno).RumaId
            txPaquete.Text = lsHeader(recno).Numpaquete
            btAcabado.Text = lsHeader(recno).Acabado
            btHumedad.Text = lsHeader(recno).Humedad

            CbUtilizado.Text = lsHeader(recno).CMUtilizado
            DatosRuma(lsHeader(recno).RumaId) 'rescata los datos de la ruma elegida para empaquetar
            txTotalp.Text = lsHeader(recno).UtiCantidad
            txTotalM3.Text = Format(lsHeader(recno).UtiVolM3, "##0.000")
            txTotalpt.Text = Format(lsHeader(recno).UtiVolPt, "##0.000")
            'btAcabado.Text = lsHeader(recno).Acabado
            'btHumedad.Text = lsHeader(recno).Humedad
            txtClasificacion.Text = lsHeader(recno).Clasificacion
            txtVPT.Text = Format(lsHeader(recno).Volpt, "##0.000")
            'txTotalp.Text = lsHeader(recno).
            xprofinalId = lsHeader(recno).ProductoFinalId
            xubicacionId = lsHeader(recno).Ubicacion
            obtieneUbicacionYProductoFinal()
            traeDatosProducto(xprofinalId)
            xpaqueteId = lsHeader(recno).RowId
            xAprovechable = CDec(txtVPT.Text) * (txProvecho.Value / 100)
            lbProvecho.Text = xAprovechable
            xIdPaquete = lsHeader(recno).RowId
            txRecno.Text = recno + 1 & " de " & lsHeader.Count
            ContarRumas() 'aqui genera el aprovechable
            ListarDetallePaquete()
            resumen_aserrio_lotes()
            cargarconsumidobanda(lsHeader(recno).RumaId, lsHeader(recno).Numpaquete)
        End If

    End Sub

    Private Function CalcularConsumo() As Double
        Dim dm As New samadEntities
        xcantidad = dm.paquete.Where(Function(x) x.RumaId = txRumaId.Text And x.EspecieId = txEspecieId.Text).Count()
        Dim vPt = dm.paquete.Where(Function(x) x.RumaId = txRumaId.Text And x.EspecieId = txEspecieId.Text).Select(Function(x) x.Volpt).Sum()
        If vPt.HasValue Then
            Return vPt
        Else
            Return 0
        End If

    End Function

    Private Sub ContarRumas()
        Dim dm As New samadEntities
        'xCantrozas = dm.formato04_rumas.Where(Function(x) x.RumaId = txRumaId.Text).Count()
        xvolptRumas = dm.formato04_rumas.Where(Function(x) x.RumaId = txRumaId.Text).Select(Function(x) x.VolPT).First()

        xAprovechable = CDec(xvolptRumas) * (txProvecho.Value / 100)
        lbProvecho.Text = xAprovechable

    End Sub

    Private Sub obtieneUbicacionYProductoFinal()
        Dim dm As New samadEntities
        'Dim xProductoId As Integer
        Try
            'xProductoId = dm.productos.Where(Function(e) e.Prod_Id = txProductoFinalId.Text).Select(Function(x) x.Prod_Id).FirstOrDefault()
            txProductoFinalId.Text = xprofinalId
            TxProdFinal.Text = dm.productos.Where(Function(x) x.Prod_Id = txProductoFinalId.Text).Select(Function(x) x.Prod_NomProducto).First()

            txUbicacionId.Text = xubicacionId
            txUbicacion.Text = dm.ubicacion.Where(Function(x) x.Ubi_id = txUbicacionId.Text).Select(Function(x) x.Ubi_Nombre).First()
        Catch ex As Exception
            'Return 0
        End Try

    End Sub

    Private Sub cargarconsumidobanda(ByVal idrumaconsumo As Integer, ByVal nropaquete As String)
        Dim dm As New samadEntities

        'Dim nx As String
        Dim dt As SAMAD.paquete = (From x In dm.paquete Where x.RumaId = idrumaconsumo And x.Numpaquete = nropaquete Select x).FirstOrDefault()
        If Not dt Is Nothing Then
            txVm3.Text = IIf(IsDBNull(dt.Volm3Inicial), 0, dt.Volm3Inicial)
            txVpt.Text = IIf(IsDBNull(dt.VolptInicial), 0, dt.VolptInicial)
            txPiezas.Text = IIf(IsDBNull(dt.CantidadInicial), 0, dt.CantidadInicial)
        End If

    End Sub



    Private Sub DatosRuma(ByVal iRumaId As Integer)
        Dim dm As New samadEntities

        'Dim nx As String
        Dim dt As SAMAD.formato04_rumas = (From x In dm.formato04_rumas Where x.RumaId = iRumaId Select x).First()

        'nx = IIf(IsDBNull(dm.paquete.Where(Function(x) x.RumaId = iRumaId).Select(Function(x) x.CMUtilizado).First()), "TOTAL", (dm.paquete.Where(Function(x) x.RumaId = iRumaId).Select(Function(x) x.CMUtilizado).First()))

        If Not dt Is Nothing Then
            txRuma.Text = dt.Codigo_ruma
            txEspecieId.Text = dt.EspecieId
            txEspecie.Text = dt.Especie
            txProOrigenId.Text = dt.ProductoId
            TxProdOrigen.Text = dm.productos.Where(Function(x) x.Prod_Id = dt.ProductoId).Select(Function(x) x.Prod_NomProducto).First()
            txPiezas.Text = dt.Cantidad
            txVm3.Text = Format(CDec((dt.VolM3)), "#,##0.000")
            txVpt.Text = Format(CDec((dt.VolPT)), "#,##0.000")
            'End If
            lblUniLote.Text = dt.TipUnidad
            xtipocubicacion = dt.SisCubicacion
        End If

    End Sub

    Private Sub calcularcomsumo(ByVal iRumaId As Integer)
        Dim dm As New samadEntities
        Dim cuenta As Integer
        Dim NX As Integer = 1, RESUL As Integer

        Dim dt As SAMAD.formato04_rumas = (From x In dm.formato04_rumas Where x.RumaId = iRumaId Select x).First()


        cuenta = dm.paquete.Where(Function(x) x.RumaId = iRumaId).Select(Function(x) x.RumaId).Count()
        cuenta = cuenta + 1
        Dim rumaId As Integer = IIf(IsDBNull(dm.paquete.Where(Function(X) X.RumaId = iRumaId).Select(Function(x) x.RumaId).FirstOrDefault()), 0, dm.paquete.Where(Function(X) X.RumaId = iRumaId).Select(Function(x) x.RumaId).FirstOrDefault())

        If Int32.Parse(txRumaId.Text) = rumaId Then
            RESUL = cuenta + NX

        End If

        If RESUL > 1 And cuenta > 1 Then
            npiezas = dt.Cantidad
            nvolm3 = dt.VolM3
            nvolpt = dt.VolPT
            xUticantidad = dm.paquete.Where(Function(x) x.RumaId = txRumaId.Text And x.EspecieId = txEspecieId.Text).Select(Function(x) x.UtiCantidad).Sum()
            xUtiVolM3 = dm.paquete.Where(Function(x) x.RumaId = txRumaId.Text And x.EspecieId = txEspecieId.Text).Select(Function(x) x.UtiVolM3).Sum()
            xUtiVolPT = dm.paquete.Where(Function(x) x.RumaId = txRumaId.Text And x.EspecieId = txEspecieId.Text).Select(Function(x) x.UtiVolPt).Sum()

            txPiezas.Text = (npiezas - xUticantidad)
            txVm3.Text = Format(CDec((nvolm3 - xUtiVolM3)), "#,##0.00")
            txVpt.Text = Format(CDec((nvolpt - xUtiVolPT)), "#,##0.00")
        Else
            txPiezas.Text = dt.Cantidad
            txVm3.Text = Format(CDec((dt.VolM3)), "#,##0.000")
            txVpt.Text = Format(CDec((dt.VolPT)), "#,##0.000")
            'End If
            lblUniLote.Text = dt.TipUnidad
            xtipocubicacion = dt.SisCubicacion

            ' txVolM3.Text = Format((CDec(txVolPT.Text) / 424), "#,##0.00")
        End If
    End Sub

    'Genera  automaticamente el Numero de Ruma(Segun el Periodo)
    Private Sub CodigoRuma()
        Dim dm As New samadEntities
        Dim xNumero As Integer = 0
        xNumero = (From fr In dm.paquete From z In dm.empaquetado Where fr.EmpaquetadoId = z.RowId And z.Emp_Periodo = xPeriodo Select fr.RowId).Count()
        'xNumero = dm.formato04_rumas.Where(Function(x) x.Periodo = xPeriodo).Max(Function(x) x.RumaId)
        'xNumero = dm.formato04_rumas.Where(Function(x) x.Periodo = xPeriodo).Select(Function(x) x.RowId).Count()
        'If xNumero > 0 Then
        '    xNumero += 1
        'Else
        '    xNumero = 1
        'End If
        txPaquete.Text = New fxSamad().StrCeros(xNumero, 6, True)
    End Sub

    Private Sub ultimaRumaIngresada()
        Dim dm As New samadEntities
        Dim xLast = dm.paquete.Where(Function(x) x.RumaId = txRumaId.Text).Select(Function(x) x.RowId).Max()
        txPaquete.Text = xLast + 1 'New fxSamad().StrCeros(xLast, 6, True)
        'Dim xNext = dm.formato04.Where(Function(x) x.F04_Periodo = txPeriodo.Text).Select(Function(x) x.F04_Nro).Max()
        'txtNro.Text = New fxSamad().StrCeros(xNext, 6, True)
        'recno = xLast
    End Sub

    Private Sub ProductoInfo()
        'If String.IsNullOrEmpty(txProductod.Text) = False Then
        '    Dim dm As New samadEntities
        '    Dim dt As SAMAD.vw_rumas_detalle = (From x In dm.vw_rumas_detalle Where x.RumaId = txRumaId.Text Select x).First()
        '    ' txProname.Text = dt.Descripcion_ruma
        '    txEspesor.Text = dt.Espesor
        '    txAncho.Text = dt.Ancho
        '    txLargo.Text = dt.Largo
        '    txCantidad.Text = dt.Cantidad
        'End If
    End Sub

    Private Sub HabilitarControles(ByVal xEstatus As Boolean)

        txRuma.ButtonCustom.Visible = xEstatus
        TxProdFinal.ButtonCustom.Visible = xEstatus
        txProOrigenId.Enabled = xEstatus
        TxProdOrigen.Enabled = xEstatus
        txProductoFinalId.Enabled = xEstatus
        TxProdFinal.Enabled = xEstatus
        CbUtilizado.Enabled = xEstatus
        btAcabado.Enabled = xEstatus
        btHumedad.Enabled = xEstatus
        txtClasificacion.Enabled = xEstatus
        txUbicacionId.Enabled = xEstatus
        txUbicacion.Enabled = xEstatus
        'txTotalp.Enabled = xEstatus

        txAncho.Enabled = xEstatus
        txEspesor.Enabled = xEstatus
        txLargo.Enabled = xEstatus
        txCantidad.Enabled = xEstatus
        txVolm3.Enabled = xEstatus
        txVolpt.Enabled = xEstatus
        btAdd.Enabled = xEstatus

        'txCubicador.ButtonCustom.Visible = xEstatus
        'txUbicacion.ButtonCustom.Visible = xEstatus
        'txProductod.ButtonCustom.Visible = xEstatus
        txPaquete.ReadOnly = Not xEstatus
        'txCantidad.ReadOnly = Not xEstatus
        btNew.Enabled = Not xEstatus
        btAtras.Enabled = xEstatus
        btEdit.Enabled = Not xEstatus
        btBorra.Enabled = Not xEstatus
        btSave.Enabled = xEstatus
        'txEspesor.ReadOnly = Not xEstatus
        'txAncho.ReadOnly = Not xEstatus
        'txLargo.ReadOnly = Not xEstatus
    End Sub
    Private Sub LimpiarDetalleRuma()
        txEspesor.Text = ""
        txAncho.Text = ""
        txLargo.Text = ""
        txCantidad.Text = ""
        txVolpt.Text = ""
        txVolm3.Text = ""
    End Sub
    Private Sub LimpiarControles(ByVal todos As Boolean)
        If todos = True Then
            txRumaId.Text = ""
            txRuma.Text = ""
            txEspecieId.Text = ""
            txEspecie.Text = ""
            txProOrigenId.Text = ""
            txProductoFinalId.Text = ""
            TxProdOrigen.Text = ""
            TxProdFinal.Text = ""
            'txProductod.Text = ""
            txPaquete.Text = ""
            txPiezas.Text = ""
            txVm3.Text = ""
            txVpt.Text = ""
            txTotalp.Text = ""
            txTotalM3.Text = ""
            txTotalpt.Text = ""
            'txDispo.Text = ""
            'txCubicadorId.Text = ""
            'txCubicador.Text = ""
            txUbicacionId.Text = ""
            txUbicacion.Text = ""
            'txProductod.Text = ""
            'txProname.Text = ""
            txEspesor.Text = ""
            txAncho.Text = ""
            txLargo.Text = ""
            txCantidad.Text = ""
            txVolm3.Text = ""
            txVolpt.Text = ""
            txTotalp.Text = 0
            txTotalM3.Text = 0
            txTotalpt.Text = 0
            btAcabado.Text = ""
            btHumedad.Text = ""
            txtClasificacion.Text = ""
            TxFunCal.Text = ""
            TxSisCubicacion.Text = ""
            TxSimboloCubi.Text = ""
            TxCantR.Text = ""
            TxVolM3r.Text = ""
            TxVolPtr.Text = ""
        Else
            'txProductod.Text = ""
            'txProname.Text = ""
            txEspesor.Text = ""
            txAncho.Text = ""
            txLargo.Text = ""
            txCantidad.Text = ""
            txVolm3.Text = ""
            txVolpt.Text = ""
        End If

    End Sub

    Private Sub CalculoM3PT()
        Dim vm3 As Decimal = 0
        Try
            If CDec(txCantidad.Text) > 0 Then
                vm3 = New fxSamad().FormulaPT(CDec(txEspesor.Text), CDec(txAncho.Text), CDbl(txLargo.Text), 3)
                txVolpt.Text = Format((vm3 * CDec(txCantidad.Text)), "#,##0.000")
                txVolm3.Text = Format((CDec(txVolpt.Text) / 424), "#,##0.000")
            End If
        Catch ex As Exception
            txVolm3.Text = ""
            txVolpt.Text = ""
        End Try
    End Sub

    Private Sub BuscarMedidas()
        Dim dm As New samadEntities
        Dim xProductoId As Integer
        Try

            xProductoId = dm.productos.Where(Function(e) txEspesor.Text >= e.Prod_Espesor And txEspesor.Text <= e.Prod_Espesor And txAncho.Text >= e.Prod_Ancho And txAncho.Text <= e.Prod_Ancho And txLargo.Text >= e.Prod_Largo And txLargo.Text <= e.Prod_Largo).Select(Function(x) x.Prod_Id).FirstOrDefault()
            'txProductod.Text = xProductoId
            'txProname.Text = dm.productos.Where(Function(x) x.Prod_Id = txProductoId.Text).Select(Function(x) x.Prod_NomProducto).First()
            txCantidad.Focus()
        Catch ex As Exception
            'Return 0
        End Try
    End Sub

#End Region

    Private Sub btSalir_Click(sender As System.Object, e As System.EventArgs) Handles btSalir.Click
        wfEmpaquetado.Refresh()
        wfEmpaquetado.refresca(True)
        wfEmpaquetado.actualiza_grid()
        Me.Close()

    End Sub

    Private Sub txCubicador_ButtonCustomClick(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub txRuma_ButtonCustomClick(sender As System.Object, e As System.EventArgs) Handles txRuma.ButtonCustomClick
        Dim wfBuscar As New frmShowbrow
        wfBuscar.titulo = "Rumas Disponibles"
        wfBuscar.t_tabla = "vw_rumas"
        wfBuscar.t_campos = "rowid,codigo_ruma,nombre_especie,f04_fecha"
        wfBuscar.t_donde = String.Format("Prod_tipoproducto='PP' and Estatus=0 and f04_pro_id=" & xIdaserradero & " and f04_periodo=" & CInt(xPeriodo))
        wfBuscar.t_agruparpor = ""
        wfBuscar.t_ordenarpor = ""
        Dim titulos() As String = {"Id", "Ruma", "Especie ruma", "Fecha"}
        Dim anchos() As Integer = {50, 80, 160, 75}
        ReDim wfBuscar.matAnchos(anchos.Length)
        ReDim wfBuscar.matTitulos(titulos.Length)
        ReDim wfBuscar.matColumnas(titulos.Length)
        titulos.CopyTo(wfBuscar.matTitulos, 0)
        anchos.CopyTo(wfBuscar.matAnchos, 0)
        wfBuscar.ShowDialog(Me)
        If wfBuscar.flag = True Then
            txRumaId.Text = wfBuscar.matColumnas(0)
            txRuma.Text = wfBuscar.matColumnas(1)
            DatosRuma(wfBuscar.matColumnas(0))
            CodigoRuma()
            CmUtilizado()
            ContarRumas()
            calcularcomsumo(wfBuscar.matColumnas(0))
            txPaquete.Focus()
        End If
        wfBuscar = Nothing
    End Sub

    Private Sub txUbicacion_ButtonCustomClick(sender As System.Object, e As System.EventArgs) Handles txUbicacion.ButtonCustomClick
        Dim wfBuscar As New frmShowbrow
        xId_aserrio02 = My.Forms.wfEmpaquetado.xId_Aserradero01
        wfBuscar.titulo = "Ubicaciones"
        wfBuscar.t_tabla = "ubicacion"
        wfBuscar.t_campos = "ubi_id,ubi_nombre,Ubi_Proid"
        wfBuscar.t_donde = String.Format("Ubi_Proid = {0}", xId_aserrio02)
        wfBuscar.t_agruparpor = ""
        wfBuscar.t_ordenarpor = ""
        Dim titulos() As String = {"Id", "Ubicación", "Ubi_Proid"}
        Dim anchos() As Integer = {50, 120, 120}
        ReDim wfBuscar.matAnchos(anchos.Length)
        ReDim wfBuscar.matTitulos(titulos.Length)
        ReDim wfBuscar.matColumnas(titulos.Length)
        titulos.CopyTo(wfBuscar.matTitulos, 0)
        anchos.CopyTo(wfBuscar.matAnchos, 0)
        wfBuscar.ShowDialog(Me)
        If wfBuscar.flag = True Then
            txUbicacionId.Text = wfBuscar.matColumnas(0)
            txUbicacion.Text = wfBuscar.matColumnas(1)
        End If
        wfBuscar = Nothing
    End Sub

    Private Sub validaCantidad()
        Dim xsimbolcal As String
        Dim dm As New samadEntities
        xsimbolcal = TxSimboloCubi.Text

        If xsimbolcal = "P" Or xsimbolcal = "PQ" Or xsimbolcal = "CHQ" Then
            If CDbl(txCantidad.Text) <> 1 Then
                MessageBox.Show("para la funcion de Cubicacion seleccionada para este producto solo puede ingresar cantidades una por una")
                txCantidad.Focus()
                txCantidad.SelectAll()
                Exit Sub
            End If
            CalculoPT()
            btAdd.Focus()
            btAdd.Select()
        ElseIf xsimbolcal = "NP" Or xsimbolcal = "NPQ" Or xsimbolcal = "NCHQ" Then
            If CDbl(txCantidad.Text) < 1 Then
                MessageBox.Show("para la funcion de Cubicacion seleccionada para este producto solo puede ingresar cantidades de uno a mas")
                txCantidad.Focus()
                txCantidad.SelectAll()
                Exit Sub
            End If
            CalculoPT()
            btAdd.Focus()
            btAdd.Select()
        End If

    End Sub

    Private Sub CalculoPT()
        Dim volpt As Decimal = 0, volm3 As Decimal = 0, espcal As Decimal = 0, anchcal As Decimal = 0, larcal As Decimal = 0

        Try
            If CDec(txEspesor.Text) > 0 And CDec(txAncho.Text) > 0 And CDbl(txLargo.Text) > 0 Then

                volpt = New fxSamad().FormulaPT(CDec(txEspesor.Text), CDec(txAncho.Text), CDbl(txLargo.Text), 3)
                txVolpt.Text = Format(CDec(volpt), "#,##0.00")

                If Label8.Text = "m" Then
                    espcal = (CDec(txEspesor.Text) / 1)
                ElseIf Label8.Text = "cm" Then
                    espcal = (CDec(txEspesor.Text) / 100)
                Else
                    espcal = (CDec(txEspesor.Text) / 1000)
                End If

                If Label14.Text = "m" Then
                    anchcal = (CDec(txAncho.Text) / 1)
                ElseIf Label14.Text = "cm" Then
                    anchcal = (CDec(txAncho.Text) / 100)
                Else
                    anchcal = (CDec(txAncho.Text) / 1000)
                End If

                If Label18.Text = "m" Then
                    larcal = (CDec(txLargo.Text) / 1)
                ElseIf Label18.Text = "cm" Then
                    larcal = (CDec(txLargo.Text) / 100)
                Else
                    larcal = (CDec(txLargo.Text) / 1000)
                End If

                volm3 = New fxSamad().FormulaM3(CDec(espcal), CDec(anchcal), CDbl(larcal), 3)

                If TxSisCubicacion.Text = "Pt" Then
                    If IsNumeric(txCantidad.Text) Then
                        txVolpt.Text = Format((volpt * CDec(txCantidad.Text)) * xFe, "#,##0.00")

                        txVolm3.Text = Format((((volpt * CDec(txCantidad.Text) * xFe) / 424)), "#,##0.000")
                    End If
                Else
                    If IsNumeric(txCantidad.Text) Then

                        txVolm3.Text = Format((volm3 * CDec(txCantidad.Text)) * xFe, "#,##0.000")

                        txVolpt.Text = Format((((volm3 * CDec(txCantidad.Text) * xFe) * 424)), "#,##0.00")
                    End If
                End If

            End If
        Catch ex As Exception
            txVolpt.Text = "0.00"
            txVolm3.Text = "0.00"
        End Try
    End Sub

    Private Sub txPaquete_Leave(sender As System.Object, e As System.EventArgs) Handles txPaquete.Leave
        If String.IsNullOrEmpty(txPaquete.Text) = False Then
            txPaquete.Text = (Integer.Parse(txPaquete.Text).ToString().PadLeft(6, "0"))
        End If
    End Sub


    Private Sub txProductod_ButtonCustomClick(sender As System.Object, e As System.EventArgs)
        Dim wfBuscar As New frmShowbrow
        wfBuscar.titulo = "Productos en RUMA Nro: " & txRuma.Text
        wfBuscar.t_tabla = "vw_rumas_detalle"
        wfBuscar.t_campos = "codigo_producto,prod_descrip,cantidad"
        wfBuscar.t_donde = "rumaid=" & txRumaId.Text
        wfBuscar.t_agruparpor = ""
        wfBuscar.t_ordenarpor = ""
        Dim titulos() As String = {"Id", "Producto", "Existencia"}
        Dim anchos() As Integer = {50, 200, 800}
        ReDim wfBuscar.matAnchos(anchos.Length)
        ReDim wfBuscar.matTitulos(titulos.Length)
        ReDim wfBuscar.matColumnas(titulos.Length)
        titulos.CopyTo(wfBuscar.matTitulos, 0)
        anchos.CopyTo(wfBuscar.matAnchos, 0)
        wfBuscar.ShowDialog(Me)
        If wfBuscar.flag = True Then
            ' txProductod.Text = wfBuscar.matColumnas(0)
            ProductoInfo()
            txCantidad.SelectAll()
            txCantidad.Focus()
        End If
        wfBuscar = Nothing
    End Sub

    Private Sub wfEmpaquetado_detalle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'LimpiarControles(True)

        lsHeader = New cdPaquete_det().VistaPaquetes()
        HabilitarControles(False)
        recno = lsHeader.Count - 1
        listarEncabecados()
        txTotalp.Enabled = False
        txTotalp.ReadOnly = True
        'ContarRumas()

        'HabilitarControles(False)

    End Sub

    Private Sub ListarDetallePaquete()
        Dim x As Long = 0
        Dim xRow As GridRow = Nothing
        Dim xPanel As GridPanel = sgDetalle.PrimaryGrid
        If txRumaId.Text > 0 Then
            Dim ls = New cdPaquete_det().PaqueteDetalle(xpaqueteId)
            If ls.Count > 0 Then
                xPanel.Rows.Clear()
                For x = 0 To ls.Count - 1
                    xRow = New GridRow(ls(x).RowId, ls(x).PaqueteId, ls(x).Espesor, ls(x).Ancho, ls(x).Largo, ls(x).Cantidad, ls(x).VolM3, ls(x).VolPT)
                    xPanel.Rows.Add(xRow)
                Next
                'resumen_aserrio_lotes()
            Else
                xPanel.Rows.Clear()
            End If
        Else
            xPanel.Rows.Clear()
        End If
    End Sub
    Private Sub bloquearNavegacion()
        btFisr.Enabled = False
        btBack.Enabled = False
        txRecno.Enabled = False
        btNext.Enabled = False
        btLast.Enabled = False
        'btUn.Enabled = True
    End Sub
    Private Sub DesbloquearNavegacion()
        btFisr.Enabled = True
        btBack.Enabled = True
        txRecno.Enabled = True
        btNext.Enabled = True
        btLast.Enabled = True
        'btUnDo.Enabled = False
    End Sub
    Private Sub btNew_Click(sender As System.Object, e As System.EventArgs) Handles btNew.Click
        calcula = True
        LimpiarControles(True)
        HabilitarControles(True)
        sgDetalle.PrimaryGrid.Rows.Clear()
        txRuma.Focus()
        CodigoRuma()
    End Sub

    Private Sub btAtras_Click(sender As System.Object, e As System.EventArgs) Handles btAtras.Click
        HabilitarControles(False)
        listarEncabecados()
        LimpiarControles(False)
        DesbloquearNavegacion()
    End Sub

    Private Sub btEdit_Click(sender As System.Object, e As System.EventArgs) Handles btEdit.Click
        If String.IsNullOrEmpty(txRumaId.Text) = True Then
            MessageBox.Show("Ho hay registro spara Editar", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        calcula = True
        xmodific = 1
        HabilitarControles(True)
        bloquearNavegacion()
    End Sub

    Private Sub btSave_Click(sender As System.Object, e As System.EventArgs) Handles btSave.Click
        Dim Actualizado As Boolean
        ' Dim desconto As Boolean
        'Dim idpaquete As Integer = 0

        'Dim dm As samadEntities
        If xmodific = 0 Then
            If New cdPaquete_det().PaqueteExiste(txPaquete.Text, xPeriodo) = True Then
                MessageBox.Show("El Codigo de Paquete ya existe en el Periodo", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txPaquete.SelectAll()
                txPaquete.Focus()
                Exit Sub
            End If
        End If
        If String.IsNullOrEmpty(txUbicacionId.Text) = True Then
            MessageBox.Show("debe ingresar la ubicacion del Paquete", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txUbicacion.Focus()
            Exit Sub
        End If
        Dim dt As New SAMAD.paquete

        If xExiste = True Then
            dt.RowId = 0
        End If

        If xmodific = 1 Then
            xExiste = True
            dt.RowId = lbPaquetID.Text
            dt.EmpaquetadoId = xEmpquetadoId
            dt.RumaId = txRumaId.Text
            dt.Numpaquete = txPaquete.Text
            dt.EspecieId = txEspecieId.Text
            dt.ProductoOrigenId = txProOrigenId.Text
            dt.ProductoFinalId = txProductoFinalId.Text
            dt.CMUtilizado = CbUtilizado.Text
            dt.Cantidad = IIf(String.IsNullOrEmpty(TxCantR.Text) = True, 0, Int32.Parse(TxCantR.Text))
            dt.Volm3 = IIf(String.IsNullOrEmpty(TxVolM3r.Text) = True, 0, CDec(TxVolM3r.Text))
            dt.Volpt = IIf(String.IsNullOrEmpty(TxVolPtr.Text) = True, 0, CDec(TxVolPtr.Text))
            dt.Acabado = btAcabado.Text
            dt.Humedad = btHumedad.Text
            dt.Clasificacion = txtClasificacion.Text
            dt.Ubicacion = txUbicacionId.Text
            dt.TipoUnidad = Label26.Text
            dt.Periodo = xPeriodo
            dt.CantidadInicial = txPiezas.Text
            dt.Volm3Inicial = txVm3.Text
            dt.VolptInicial = txVpt.Text
            dt.UtiCantidad = IIf(String.IsNullOrEmpty(txTotalp.Text) = True, 0, Int32.Parse(txTotalp.Text))
            dt.UtiVolM3 = IIf(String.IsNullOrEmpty(txTotalM3.Text) = True, 0, CDec(txTotalM3.Text))
            dt.UtiVolPt = IIf(String.IsNullOrEmpty(txTotalpt.Text) = True, 0, CDec(txTotalpt.Text))

            If New cdPaquete_det().PaqueteGrabar(dt, xExiste) = False Then
                MessageBox.Show("No se pudo completar el proceso de grabar", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim idpaquete As Integer = New cdPaquete_det().LastPaqueteId()

            If CbUtilizado.Text = "TOTAL" Then
                chkCierra.CheckState = CheckState.Checked
                'Marcar rumas como utilizado
                Actualizado = New fxSamad().Actlote("Update formato04_rumas Set estatus=1 Where rumaid=" & txRumaId.Text & " And especieid=" & txEspecieId.Text)
            Else
                If txTotalpt.Text = txVpt.Text Then
                    chkCierra.CheckState = CheckState.Checked
                    Actualizado = New fxSamad().Actlote("Update formato04_rumas Set estatus=0 Where rumaid=" & txRumaId.Text & " And especieid=" & txEspecieId.Text)
                    chkCierra.Checked = True
                End If
                chkCierra.CheckState = CheckState.Unchecked
                'Marcar rumas como utilizado
                Actualizado = New fxSamad().Actlote("Update formato04_rumas Set estatus=0 Where rumaid=" & txRumaId.Text & " And especieid=" & txEspecieId.Text)
                chkCierra.Checked = False
                ' desconto = New cdPaquete_det().DescuentaRumas(idpaquete)
            End If
            lsHeader = New cdPaquete_det().VistaPaquetes()
            HabilitarControles(False)
            recno = lsHeader.Count - 1
            listarEncabecados()
            resumen_aserrio_lotes()
            DesbloquearNavegacion()
        Else
            dt.EmpaquetadoId = xEmpquetadoId
            dt.Numpaquete = txPaquete.Text
            dt.EspecieId = txEspecieId.Text
            dt.ProductoOrigenId = txProOrigenId.Text
            dt.ProductoFinalId = txProductoFinalId.Text
            dt.CMUtilizado = CbUtilizado.Text
            dt.Cantidad = CDbl(IIf(TxCantR.Text = "", 0, TxCantR.Text))
            dt.Volm3 = CDbl(IIf(TxVolM3r.Text = "", 0, TxVolM3r.Text))
            dt.Volpt = CDbl(IIf(TxVolPtr.Text = "", 0, TxVolPtr.Text))
            'dt.Cantidad = IIf(String.IsNullOrEmpty(TxCantR.Text) = True, 0, Val(TxCantR.Text))
            'dt.Volm3 = IIf(String.IsNullOrEmpty(TxVolM3r.Text) = True, 0, CDec(TxVolM3r.Text))
            'dt.Volpt = IIf(String.IsNullOrEmpty(TxVolPtr.Text) = True, 0, CDec(TxVolPtr.Text))
            'dt.Tipo_producto = txProductoId.Text
            dt.Acabado = btAcabado.Text
            dt.Humedad = btHumedad.Text
            dt.Clasificacion = txtClasificacion.Text
            dt.Ubicacion = txUbicacionId.Text
            dt.TipoUnidad = Label26.Text
            dt.RumaId = txRumaId.Text
            dt.Periodo = xPeriodo
            dt.CantidadInicial = txPiezas.Text
            dt.Volm3Inicial = txVm3.Text
            dt.VolptInicial = txVpt.Text
            dt.UtiCantidad = IIf(String.IsNullOrEmpty(txTotalp.Text) = True, 0, Int32.Parse(txTotalp.Text))
            dt.UtiVolM3 = IIf(String.IsNullOrEmpty(txTotalM3.Text) = True, 0, CDec(txTotalM3.Text))
            dt.UtiVolPt = IIf(String.IsNullOrEmpty(txTotalpt.Text) = True, 0, CDec(txTotalpt.Text))
            If New cdPaquete_det().PaqueteGrabar(dt, xExiste) = False Then
                MessageBox.Show("No se pudo completar el proceso de grabar", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim idpaquete As Integer = New cdPaquete_det().LastPaqueteId()

            If CbUtilizado.Text = "TOTAL" Then
                chkCierra.CheckState = CheckState.Checked
                'Marcar rumas como utilizado
                Actualizado = New fxSamad().Actlote("Update formato04_rumas Set estatus=1 Where rumaid=" & txRumaId.Text)

            Else
                If txTotalpt.Text = txVpt.Text Then
                    chkCierra.CheckState = CheckState.Checked
                    Actualizado = New fxSamad().Actlote("Update formato04_rumas Set estatus=0 Where rumaid=" & txRumaId.Text & " And especieid=" & txEspecieId.Text)
                    chkCierra.Checked = True
                End If
                chkCierra.CheckState = CheckState.Unchecked
                'Marcar rumas como utilizado
                Actualizado = New fxSamad().Actlote("Update formato04_rumas Set estatus=0 Where rumaid=" & txRumaId.Text)
                chkCierra.Checked = False
                ' desconto = New cdPaquete_det().DescuentaRumas(idpaquete)
            End If
            lsHeader = New cdPaquete_det().VistaPaquetes()
            HabilitarControles(False)
            recno = lsHeader.Count - 1
            listarEncabecados()
            resumen_aserrio_lotes()
            DesbloquearNavegacion()
        End If
        'Dim xIdPaquete As Integer = New cdPaquete_det().LastPaqueteId()
        'Dim x As Long
        'Dim xPanel As GridPanel = sgDetalle.PrimaryGrid
        'Dim xRow As GridRow = Nothing
        ''For Each oRow As GridRow In dgDetalle.PrimaryGrid.Rows
        'For Each r As GridRow In xPanel.Rows
        '    Dim dp As New SAMAD.paquete_deta
        '    dp.PaqueteId = xIdPaquete
        '    dp.ProductoId = CDec(r.Cells(0).Value)
        '    dp.Espesor = CDec(r.Cells(2).Value)
        '    dp.Ancho = CDec(r.Cells(3).Value)
        '    dp.Largo = CDec(r.Cells(4).Value)
        '    dp.Cantidad = CDec(r.Cells(5).Value)
        '    dp.VolM3 = CDec(r.Cells(6).Value)
        '    dp.VolPT = CDec(r.Cells(7).Value)
        '    If New cdPaquete_det().DetallePaqueteAgregar(dp) = True Then
        '        ' txProducto.Text = "Reg " & xPanel.Rows(x).ToString() & " Ok"
        '    End If
        'Next
        'LimpiarControles(True)
        'listarEncabecados()
        'HabilitarControles(False)
        'wfEmpaquetado.btPrimero.


    End Sub

    Private Sub btAdd_Click(sender As System.Object, e As System.EventArgs) Handles btAdd.Click
        'Agregar al grid si cumple con los criterios establecidos
        If IsNumeric(txCantidad.Text) = False Then
            Exit Sub
        End If
        If CDec(txCantidad.Text) <= 0 Then
            MessageBox.Show("Debe ingresar una cantidad de Priezas valida", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txCantidad.SelectAll()
            txCantidad.Focus()
            Exit Sub
        End If
        'If CDec(txCantidad.Text) > CDec(txPiezas.Text) Then
        '    MessageBox.Show("No es posible agregar mas piezas que las disponible en la Ruma", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txCantidad.SelectAll()
        '    txCantidad.Focus()
        '    Exit Sub
        'End If
        Dim xAcum = CalcularConsumo()
        If xAcum + CDec(txVolpt.Text) > xAprovechable Then
            MessageBox.Show("El volumen en Metros Cubicos supera el valor aprovechable de las trozas", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txCantidad.SelectAll()
            txCantidad.Focus()
            Exit Sub
        End If

        Dim dt As New SAMAD.paquete_deta
        xIdPaquete = xpaqueteId  'New cdPaquete_det().LastPaqueteId()
        If xExiste = True Then
            dt.RowId = 0
        End If

        If xId > 0 Then
            xExiste = True
            dt.RowId = xId
            dt.PaqueteId = xIdPaquete
            dt.Espesor = CDec(txEspesor.Text)
            dt.Ancho = CDec(txAncho.Text)
            dt.Largo = CDec(txLargo.Text)
            dt.VolM3 = CDec(txVolm3.Text)
            dt.VolPT = CDec(txVolpt.Text)
            dt.Cantidad = CDec(txCantidad.Text)
            dt.ProductoId = CDec(txProductoFinalId.Text)
            If New cdPaquete_det().GrabarDetallePaquete(dt, xExiste) = True Then
                'Agregar al Grid
                'Actualizar la tabla formato04_rumas
                Dim sn = New cdPaquete_det().ActualizaM3Rumas(CInt(xIdPaquete), CDec(txVolm3.Text), CDec(txVolpt.Text), CInt(txCantidad.Text), chkCierra.CheckState)
                If chkCierra.CheckState = CheckState.Checked Then
                    'Marcar formato02_det como utilizado
                    'Dim sn = New fxSamad().ACTUALIZALOTE("formato02_det", "set estatus=1 Where f02d_f02_id=" & xF02pro & " And Especieid=" & txEspecieId.Text)
                    If New fxSamad().Actlote("Update formato04_rumas Set estatus=1 Where rumaid=" & txRumaId.Text & " And especieid=" & txEspecieId.Text) = True Then
                        chkCierra.Checked = False
                    End If
                End If
                ListarDetallePaquete()
                LimpiarDetalleRuma()
                txEspesor.Focus()
                resumen_aserrio_lotes()
            End If

        Else
            dt.PaqueteId = xIdPaquete
            dt.Espesor = CDec(txEspesor.Text)
            dt.Ancho = CDec(txAncho.Text)
            dt.Largo = CDec(txLargo.Text)
            dt.VolM3 = CDec(txVolm3.Text)
            dt.VolPT = CDec(txVolpt.Text)
            dt.Cantidad = CDec(txCantidad.Text)
            dt.ProductoId = CDec(txProductoFinalId.Text)
            If New cdPaquete_det().GrabarDetallePaquete(dt, xExiste) = True Then
                'Agregar al Grid
                'Actualizar la tabla formato04_rumas
                Dim sn = New cdPaquete_det().ActualizaM3Rumas(CInt(xIdPaquete), CDec(txVolm3.Text), CDec(txVolpt.Text), CInt(txCantidad.Text), chkCierra.CheckState)
                If chkCierra.CheckState = CheckState.Checked Then
                    'Marcar formato02_det como utilizado
                    'Dim sn = New fxSamad().ACTUALIZALOTE("formato02_det", "set estatus=1 Where f02d_f02_id=" & xF02pro & " And Especieid=" & txEspecieId.Text)
                    If New fxSamad().Actlote("Update formato04_rumas Set estatus=1 Where rumaid=" & txRumaId.Text & " And especieid=" & txEspecieId.Text) = True Then
                        chkCierra.Checked = False
                    End If
                End If
                ListarDetallePaquete()
                LimpiarDetalleRuma()
                txEspesor.Focus()
                resumen_aserrio_lotes()
            End If
        End If
        'dt. = lbRumaID.Text

        'Dim xPanel As GridPanel = sgDetalle.PrimaryGrid
        'Dim xRow As GridRow = Nothing
        ''If CDec(txTotalp.Text) + CDec(txCantidad.Text) > CDec(txPiezas.Text) Then
        ''    MessageBox.Show("La Cantidad de piezas en el paquete supera las piezas disponibles en la Ruma", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ''    txCantidad.SelectAll()
        ''    txCantidad.Focus()
        ''    Exit Sub
        ''End If
        'xRow = New GridRow(txEspesor.Text, txAncho.Text, txLargo.Text, txCantidad.Text, txVolm3.Text, txVolpt.Text)
        ''txTotalp.Text = CDec(txTotalp.Text) + CDec(txCantidad.Text)
        ''txTotalM3.Text = CDec(txTotalM3.Text) + CDec(txVolm3.Text)
        ''txTotalpt.Text = CDec(txTotalpt.Text) + CDec(txVolpt.Text)
        'xPanel.Rows.Add(xRow)
        LimpiarControles(False)
        txEspesor.Focus()
    End Sub
    Private Sub resumen_aserrio_lotes()
        Dim xPanel As GridPanel = sgDetalle.PrimaryGrid
        Dim xRow As GridRow = Nothing
        Dim dm As New samadEntities
        Dim cantidad As Integer

        Dim sumaVolpt, sumaVolM3 As Double

        If xPanel.Rows.Count() > 0 Then
            '    xRow = xPanel.ActiveRow

            'cantidad = xPanel.Rows.Count()
            'xPanel.SelectAll()

            cantidad = dm.paquete_deta.Where(Function(x) x.PaqueteId = xIdPaquete).Select(Function(d) d.Cantidad).Sum()
            sumaVolpt = dm.paquete_deta.Where(Function(x) x.PaqueteId = xIdPaquete).Select(Function(d) d.VolPT).Sum()
            sumaVolM3 = dm.paquete_deta.Where(Function(x) x.PaqueteId = xIdPaquete).Select(Function(d) d.VolM3).Sum()
        Else
            cantidad = 0
            sumaVolpt = 0
            sumaVolM3 = 0

        End If
        TxCantR.Text = cantidad
        TxVolPtr.Text = sumaVolpt
        TxVolM3r.Text = sumaVolM3

    End Sub

    Private Sub smDel_Click(sender As System.Object, e As System.EventArgs) Handles smDel.Click
        Dim xPanel As GridPanel = sgDetalle.PrimaryGrid
        Dim xRow As GridRow = xPanel.ActiveRow()
        Dim elimina As Boolean
        xId = xRow.Cells(0).Value
        If MessageBox.Show("Realmente desea borrar el Registro seleccionado?" & xId, xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        elimina = New cdPaquete_det().DetallePaqueteBorrar(xId)
        If (elimina = True) Then
            MessageBox.Show("El registro seleccionado se ha eliminado correctamente", "Empaquetado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
            ListarDetallePaquete()
            resumen_aserrio_lotes()
        Else
            MessageBox.Show("No se ha podido Eliminar el Registro", "Empaquetado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
            Exit Sub
        End If
        'txTotalp.Text = CDec(txTotalp.Text) - xId
        'txTotalM3.Text = CDec(txTotalM3.Text) - CDec(xRow.Cells(6).Value)
        'txTotalpt.Text = CDec(txTotalpt.Text) - CDec(xRow.Cells(7).Value)
        'xPanel.Rows.Remove(xRow)

    End Sub

    Private Sub sgDetalle_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles sgDetalle.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right = True Then
            smPop.Show()
        End If
    End Sub

    Private Sub smEdit_Click(sender As System.Object, e As System.EventArgs) Handles smEdit.Click
        Dim xPanel As GridPanel = sgDetalle.PrimaryGrid
        Dim xRow As GridRow = xPanel.ActiveRow()
        xId = xRow.Cells(0).Value
        If MessageBox.Show("Realmente desea Editar el Registro seleccionado?" & xId, xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        'txProductod.Text = xRow.Cells(0).Value
        'txProname.Text = xRow.Cells(1).Value

        xIdPaquete = xRow.Cells(1).Value
        txEspesor.Text = xRow.Cells(2).Value
        txAncho.Text = xRow.Cells(3).Value
        txLargo.Text = xRow.Cells(4).Value
        txCantidad.Text = xRow.Cells(5).Value
        txVolm3.Text = xRow.Cells(6).Value
        txVolpt.Text = xRow.Cells(7).Value


    End Sub

    Private Sub btFisr_Click(sender As System.Object, e As System.EventArgs) Handles btFisr.Click
        recno = 0
        listarEncabecados()

    End Sub

    Private Sub btBack_Click(sender As System.Object, e As System.EventArgs) Handles btBack.Click
        recno = recno - 1
        If recno < 0 Then
            recno = 0
        End If
        listarEncabecados()
    End Sub

    Private Sub btNext_Click(sender As System.Object, e As System.EventArgs) Handles btNext.Click
        recno = recno + 1
        If recno > lsHeader.Count - 1 Then
            recno = lsHeader.Count - 1
        End If
        listarEncabecados()
    End Sub

    Private Sub btLast_Click(sender As System.Object, e As System.EventArgs) Handles btLast.Click
        recno = lsHeader.Count - 1
        listarEncabecados()
    End Sub
    Private Sub CmUtilizado()
        If String.IsNullOrEmpty(CbUtilizado.Text) = False Then
            If CbUtilizado.Text = "PARCIAL" Then
                txTotalp.Enabled = True
                txTotalp.ReadOnly = False
                'txTotalp.Text = "0"
                'txTotalpt.Text = "0"
                'txTotalM3.Text = "0"
                txTotalp.Focus()
                txTotalp.SelectAll()
                'chkCierra.CheckState = CheckState.Unchecked
            Else
                txTotalp.Text = txPiezas.Text
                txTotalM3.Text = txVm3.Text
                txTotalpt.Text = txVpt.Text
                txTotalp.Enabled = False
                txTotalp.ReadOnly = True
                txTotalM3.ReadOnly = True
                txTotalM3.Enabled = False
                txTotalpt.ReadOnly = True
                txTotalpt.Enabled = False
                'chkCierra.CheckState = CheckState.Checked
                btAcabado.Focus()
            End If
        End If
    End Sub


    Private Sub CbUtilizado_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbUtilizado.SelectedIndexChanged
        CmUtilizado()

    End Sub

    Private Sub traeDatosProducto(ByVal producId As String)
        Dim xfuncalculo, xsiscal, xsimbolcal, xunidadAb, xunidadL As String
        Dim xrendimieto, calfe As Integer
        Dim dm As New samadEntities

        xfuncalculo = dm.productos.Where(Function(e) e.Prod_Id = producId).Select(Function(x) x.Prod_FuncionCalculo).FirstOrDefault()
        xsiscal = dm.productos.Where(Function(e) e.Prod_Id = producId).Select(Function(x) x.Prod_SistemaCalculo).FirstOrDefault()
        xsimbolcal = dm.productos.Where(Function(e) e.Prod_Id = producId).Select(Function(x) x.Prod_Simbolo).FirstOrDefault()
        xrendimieto = dm.productos.Where(Function(e) e.Prod_Id = producId).Select(Function(x) x.Prod_Rendimiento).FirstOrDefault()
        xunidadAb = dm.productos.Where(Function(e) e.Prod_Id = producId).Select(Function(x) x.Prod_UnidadMedidaAb).FirstOrDefault()
        xunidadL = dm.productos.Where(Function(e) e.Prod_Id = producId).Select(Function(x) x.Prod_UnidadMedidaL).FirstOrDefault()
        calfe = dm.productos.Where(Function(e) e.Prod_Id = producId).Select(Function(x) x.Prod_Fe).FirstOrDefault()

        xFe = ((100 - calfe) / 100)

        TxFunCal.Text = xfuncalculo
        TxSisCubicacion.Text = xsiscal
        TxSimboloCubi.Text = xsimbolcal
        lbAprovechar.Text = xrendimieto
        Label8.Text = xunidadAb
        Label14.Text = xunidadAb
        Label18.Text = xunidadL

        If xsimbolcal = "P" Or xsimbolcal = "NP" Or xsimbolcal = "NCH" Or xsimbolcal = "CH" Then
            Label26.Text = "Pz"
            Label19.Text = "Pz"
        Else
            If (xsimbolcal = "PQ" Or xsimbolcal = "NPQ") Or (xsimbolcal = "CHQ" Or xsimbolcal = "NCHQ") Then
                Label26.Text = "Pqt"
                Label19.Text = "Pqt"
            End If
        End If

        'llenacombosdeRelacionProduc()

    End Sub

    Private Sub TxProdFinal_ButtonCustomClick(sender As Object, e As System.EventArgs) Handles TxProdFinal.ButtonCustomClick
        Dim wfBuscar As New frmShowbrow
        wfBuscar.titulo = "Catálogo de Productos"
        wfBuscar.t_tabla = "productos"
        wfBuscar.t_campos = "prod_id,prod_nomproducto"
        'wfBuscar.t_donde = String.Format("prod_descrip={0}", lblPapaId.Text)
        wfBuscar.t_donde = ""   '"Pro_Transporteck =  true"
        wfBuscar.t_agruparpor = ""  '"prod_tipomaterial"
        wfBuscar.t_ordenarpor = "prod_id"
        Dim titulos() As String = {"Código", "Descripcion", "Corte"}
        Dim anchos() As Integer = {50, 200, 60}
        ReDim wfBuscar.matAnchos(anchos.Length)
        ReDim wfBuscar.matTitulos(titulos.Length)
        ReDim wfBuscar.matColumnas(titulos.Length)
        titulos.CopyTo(wfBuscar.matTitulos, 0)
        anchos.CopyTo(wfBuscar.matAnchos, 0)
        wfBuscar.ShowDialog(Me)
        If wfBuscar.flag = True Then
            txProductoFinalId.Text = wfBuscar.matColumnas(0)
            TxProdFinal.Text = wfBuscar.matColumnas(1)
            traeDatosProducto(txProductoFinalId.Text)
        End If
        wfBuscar = Nothing
    End Sub

    Private Sub validaLargo(ByVal texboxer As String)
        Dim variable1, variable2, operaL, PPPT As String
        Dim ValorL As Double
        Dim dm As New samadEntities 'dm.procesos.Where(Function(p) p.Pro_id = xEmpresaId).Select(Function(x) x.Proc_descripcion).Distinct().ToList()
        variable1 = dm.tipo_calculo_volumen.Where(Function(x) x.TipCal_Simbolo = TxSimboloCubi.Text).Select(Function(p) p.TipCal_Simbolo).FirstOrDefault()
        variable2 = dm.tipo_calculo_volumen.Where(Function(x) x.TipCal_Cod = TxFunCal.Text).Select(Function(p) p.TipCal_Cod).FirstOrDefault()

        ValorL = dm.productos.Where(Function(x) x.Prod_Id = txProductoFinalId.Text).Select(Function(d) d.Prod_Largo).FirstOrDefault()
        operaL = dm.productos.Where(Function(x) x.Prod_Id = txProductoFinalId.Text).Select(Function(d) d.Prod_OperadorL).FirstOrDefault()

        PPPT = dm.productos.Where(Function(x) x.Prod_Id = txProductoFinalId.Text).Select(Function(d) d.Prod_TipoProducto).FirstOrDefault()

        If variable1 = TxSimboloCubi.Text And variable2 = TxFunCal.Text Then ',ExAxL(P)

            If PPPT = "PT" Then 'Cubicado Pieza por Pieza= Pt
                If (operaL.Equals(">") Or operaL.Equals(">=")) = True Then

                    If (CDbl(texboxer) > CDbl(ValorL) Or CDbl(texboxer) >= CDbl(ValorL)) = True Then
                        txCantidad.Focus()
                        txCantidad.SelectAll()
                        Exit Sub
                    Else
                        MessageBox.Show("el valor ingresado en el Largo para el producto selecionado no coincide con los parametros establecidos en la configuracion de producto")

                        txLargo.Focus()
                        txLargo.SelectAll()
                        Exit Sub
                    End If

                ElseIf (operaL.Equals("<") Or operaL.Equals("<=")) = True Then
                    If (CDbl(texboxer) < CDbl(ValorL) Or CDbl(texboxer) <= CDbl(ValorL)) = True Then
                        txCantidad.Focus()
                        txCantidad.SelectAll()
                        Exit Sub
                    Else
                        MessageBox.Show("el valor ingresado en el Largo para el producto selecionado no coincide con los parametros establecidos en la configuracion de producto")

                        txLargo.Focus()
                        txLargo.SelectAll()
                        Exit Sub
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub validaAncho(ByVal texboxer As String)
        Dim variable1, variable2, operaA, PPPT As String
        Dim valorA As Double
        Dim dm As New samadEntities

        variable1 = dm.tipo_calculo_volumen.Where(Function(x) x.TipCal_Simbolo = TxSimboloCubi.Text).Select(Function(p) p.TipCal_Simbolo).FirstOrDefault()
        variable2 = dm.tipo_calculo_volumen.Where(Function(x) x.TipCal_Cod = TxFunCal.Text).Select(Function(p) p.TipCal_Cod).FirstOrDefault()

        valorA = dm.productos.Where(Function(x) x.Prod_Id = txProductoFinalId.Text).Select(Function(d) d.Prod_Ancho).FirstOrDefault()
        operaA = dm.productos.Where(Function(x) x.Prod_Id = txProductoFinalId.Text).Select(Function(d) d.Prod_OperadorA).FirstOrDefault()


        PPPT = dm.productos.Where(Function(x) x.Prod_Id = txProductoFinalId.Text).Select(Function(d) d.Prod_TipoProducto).FirstOrDefault()

        If variable1 = TxSimboloCubi.Text And variable2 = TxFunCal.Text Then ',ExAxL(P)

            If PPPT = "PT" Then 'Cubicado Pieza por Pieza= Pt
                '>=1>=6>=6
                If (operaA.Equals(">") Or operaA.Equals(">=")) = True Then

                    If (CDbl(texboxer) > CDbl(valorA) Or CDbl(texboxer) >= CDbl(valorA)) = True Then
                        txLargo.Focus()
                        txLargo.SelectAll()
                        Exit Sub
                    Else
                        MessageBox.Show("el valor ingresado en el Ancho para el producto selecionado no coincide con los parametros establecidos en la configuracion de producto")

                        txAncho.Focus()
                        txAncho.SelectAll()
                        Exit Sub
                    End If

                ElseIf (operaA.Equals("<") Or operaA.Equals("<=")) = True Then

                    If (CDbl(texboxer) < CDbl(valorA) Or CDbl(texboxer) <= CDbl(valorA)) = True Then
                        txLargo.Focus()
                        txLargo.SelectAll()
                        Exit Sub
                    Else
                        MessageBox.Show("el valor ingresado en el Ancho para el producto selecionado no coincide con los parametros establecidos en la configuracion de producto")

                        txAncho.Focus()
                        txAncho.SelectAll()
                        Exit Sub
                    End If
                End If

            End If

        End If


    End Sub

    Private Sub validaEspesor(ByVal texboxer As String)
        Dim variable1, variable2, operaEs, PPPT As String
        Dim valorEs As Double
        Dim dm As New samadEntities 'dm.procesos.Where(Function(p) p.Pro_id = xEmpresaId).Select(Function(x) x.Proc_descripcion).Distinct().ToList()
        variable1 = dm.tipo_calculo_volumen.Where(Function(x) x.TipCal_Simbolo = TxSimboloCubi.Text).Select(Function(p) p.TipCal_Simbolo).FirstOrDefault()
        variable2 = dm.tipo_calculo_volumen.Where(Function(x) x.TipCal_Cod = TxFunCal.Text).Select(Function(p) p.TipCal_Cod).FirstOrDefault()

        valorEs = dm.productos.Where(Function(x) x.Prod_Id = txProductoFinalId.Text).Select(Function(d) d.Prod_Espesor).FirstOrDefault()
        operaEs = dm.productos.Where(Function(x) x.Prod_Id = txProductoFinalId.Text).Select(Function(d) d.Prod_OperadorE).FirstOrDefault()

        PPPT = dm.productos.Where(Function(x) x.Prod_Id = txProductoFinalId.Text).Select(Function(d) d.Prod_TipoProducto).FirstOrDefault()

        If variable1 = TxSimboloCubi.Text And variable2 = TxFunCal.Text Then ',ExAxL(P)

            If PPPT = "PT" Then 'Cubicado Pieza por Pieza= Pt
                '>=1>=6>=6
                If (operaEs.Equals(">") Or operaEs.Equals(">=")) = True Then

                    If (CDbl(texboxer) > CDbl(valorEs) Or CDbl(texboxer) >= CDbl(valorEs)) = True Then
                        txAncho.Focus()
                        txAncho.SelectAll()
                        Exit Sub
                    Else
                        MessageBox.Show("el valor ingresado en el Espesor para el producto selecionado no coincide con los parametros establecidos en la configuracion de producto")
                        txEspesor.Focus()
                        txEspesor.SelectAll()
                        Exit Sub
                    End If

                ElseIf (operaEs.Equals("<") Or operaEs.Equals("<=")) = True Then
                    If (CDbl(texboxer) < CDbl(valorEs) Or CDbl(texboxer) <= CDbl(valorEs)) = True Then
                        txAncho.Focus()
                        txAncho.SelectAll()
                        Exit Sub
                    Else
                        MessageBox.Show("el valor ingresado en el Espesor para el producto selecionado no coincide con los parametros establecidos en la configuracion de producto")

                        txEspesor.Focus()
                        txEspesor.SelectAll()
                        'Int32.Parse(txAncho.Text)
                        Exit Sub
                    End If
                End If

            End If
        End If
    End Sub

    Private Sub txTotalp_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txTotalp.PreviewKeyDown
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txTotalp_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txTotalp.KeyPress
        ' Solo numeros
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub

    Private Sub txTotalpt_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txTotalpt.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                CbUtilizado.SelectAll()
                CbUtilizado.Focus()
            Case Keys.Enter, Keys.Tab
                e.Handled = True
                If xtipocubicacion = "Pt" Then

                    If CDec(txTotalpt.Text) = CDec(txVpt.Text) Then
                        'txTotalp.Text = txPiezas.Text
                        txTotalpt.Text = txVpt.Text
                        txTotalM3.Text = txVm3.Text
                    Else
                        While (CDbl(txTotalpt.Text) > CDbl(txVpt.Text) Or CDbl(txTotalpt.Text) < 1)
                            MessageBox.Show("El valor Ingresado debe estas comprendido por el rango de > 1 y < " + txVpt.Text, "Empaquetado")
                            txTotalpt.Focus()
                            txTotalpt.SelectAll()
                            Exit Sub
                        End While
                        txTotalM3.Text = (CDec(txTotalpt.Text) / 424).ToString("N3")
                        btAcabado.Enabled = True
                        btAcabado.Focus()
                    End If

                Else

                    If CDec(txTotalM3.Text) = CDec(txVm3.Text) Then
                        'txTotalp.Text = txPiezas.Text
                        txTotalpt.Text = txVpt.Text
                        txTotalM3.Text = txVm3.Text
                    Else
                        While (CDbl(txTotalM3.Text) > CDbl(txVm3.Text) Or CDbl(txTotalM3.Text) < 1)
                            MessageBox.Show("El valor Ingresado debe estas comprendido por el rango de > 1 y < " + txVm3.Text, "Empaquetado")
                            txTotalM3.Focus()
                            txTotalM3.SelectAll()
                            Exit Sub
                        End While
                        txTotalpt.Text = (CDec(txTotalM3.Text) * 424).ToString("N2")
                        btAcabado.Enabled = True
                        btAcabado.Focus()
                    End If

                End If
        End Select
    End Sub
    Private Sub txTotalpt_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txTotalpt.PreviewKeyDown
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txTotalpt_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txTotalpt.KeyPress
        ' Solo numeros
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub

    Private Sub txTotalM3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txTotalM3.KeyPress
        ' Solo numeros
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub

    Private Sub txTotalM3_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txTotalM3.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                CbUtilizado.SelectAll()
                CbUtilizado.Focus()
            Case Keys.Enter, Keys.Tab
                e.Handled = True
                If xtipocubicacion = "Pt" Then

                    If txTotalpt.Text = txVpt.Text Then
                        txTotalpt.Text = txVpt.Text
                        txTotalM3.Text = txVm3.Text
                    Else

                        While (CDbl(txTotalpt.Text) >= CDbl(txVpt.Text) Or CDbl(txTotalpt.Text) < 1)
                            MessageBox.Show("El valor Ingresado debe estas comprendido por el rango de > 1 y < " + txVpt.Text, "Empaquetado")
                            txTotalpt.Focus()
                            txTotalpt.SelectAll()
                            Exit Sub
                        End While
                        txTotalM3.Text = (CDec(txTotalpt.Text) / 424).ToString("N3")
                        btAcabado.Enabled = True
                        btAcabado.Focus()
                    End If
                Else
                    If txTotalpt.Text = txVpt.Text Then
                        txTotalpt.Text = txVpt.Text
                        txTotalM3.Text = txVm3.Text
                    Else
                        While (CDbl(txTotalM3.Text) >= CDbl(txVm3.Text) Or CDbl(txTotalM3.Text) < 1)
                            MessageBox.Show("El valor Ingresado debe estas comprendido por el rango de > 1 y < " + txVm3.Text, "Empaquetado")
                            txTotalM3.Focus()
                            txTotalM3.SelectAll()
                            Exit Sub
                        End While
                        txTotalpt.Text = (CDec(txTotalM3.Text) * 424).ToString("N2")
                        btAcabado.Enabled = True
                        btAcabado.Focus()
                    End If
                End If
        End Select
    End Sub

    Private Sub txTotalM3_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txTotalM3.PreviewKeyDown
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txTotalp_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txTotalp.KeyDown
        Dim porcentaje As Double
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                CbUtilizado.SelectAll()
                CbUtilizado.Focus()
            Case Keys.Enter, Keys.Tab
                e.Handled = True
                If xtipocubicacion = "Pt" Then

                    If txTotalp.Text = txPiezas.Text Then
                        txTotalM3.Text = txVm3.Text
                        txTotalpt.Text = txVpt.Text
                        txTotalM3.ReadOnly = True
                        txTotalpt.ReadOnly = True
                    Else
                        While (txTotalp.Text > txPiezas.Text Or txTotalp.Text < 1)
                            MessageBox.Show("El valor Ingresado debe estas comprendido por el rango de > 1 y < " + txPiezas.Text, "Empaquetado")
                            txTotalp.Focus()
                            txTotalp.SelectAll()
                            Exit Sub
                        End While
                        porcentaje = CDbl(txTotalp.Text) / CDbl(txPiezas.Text)
                        txTotalpt.Text = Format(porcentaje * CDbl(txVpt.Text), "##0.000")
                        txTotalM3.Text = Format(CDbl(txTotalpt.Text) / 424, "##0.000")

                        'txTotalpt.Enabled = True
                        'txTotalpt.Focus()
                        'txTotalpt.SelectAll()
                        'txTotalM3.Text = 0
                    End If

                Else
                    If txTotalp.Text = txPiezas.Text Then
                        txTotalM3.Text = txVm3.Text
                        txTotalpt.Text = txVpt.Text
                        txTotalM3.ReadOnly = True
                        txTotalpt.ReadOnly = True
                    Else
                        While (txTotalp.Text > txPiezas.Text Or txTotalp.Text < 1)
                            MessageBox.Show("El valor Ingresado debe estas comprendido por el rango de > 1 y < " + txPiezas.Text, "Empaquetado")
                            txTotalp.Focus()
                            txTotalp.SelectAll()
                            Exit Sub
                        End While
                        porcentaje = CDbl(txTotalp.Text) / CDbl(txPiezas.Text)
                        txTotalpt.Text = Format(porcentaje * CDbl(txVpt.Text), "##0.000")
                        txTotalM3.Text = Format(CDbl(txTotalpt.Text) / 424, "##0.000")

                        'txTotalM3.Enabled = True
                        'txTotalM3.Focus()
                        'txTotalM3.SelectAll()
                        'txTotalpt.Text = 0
                    End If
                End If
        End Select
    End Sub

    Private Sub txEspesor_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txEspesor.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                txPaquete.SelectAll()
                txPaquete.Focus()
            Case Keys.Enter, Keys.Tab
                If String.IsNullOrEmpty(txEspesor.Text) = True Then
                    MessageBox.Show("Ingrese in espsor válido", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                validaEspesor(txEspesor.Text)
                'txAncho.Focus()
        End Select
    End Sub

    Private Sub txEspesor_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txEspesor.KeyPress
        ' Solo numeros
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub

    Private Sub txEspesor_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txEspesor.PreviewKeyDown
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txAncho_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txAncho.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                txEspesor.SelectAll()
                txEspesor.Focus()
            Case Keys.Enter, Keys.Tab
                e.Handled = True
                If String.IsNullOrEmpty(txAncho.Text) = True Then
                    MessageBox.Show("Ingrese un ancho vàlido", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                validaAncho(txAncho.Text)
                'txLargo.Focus()
        End Select
    End Sub

    Private Sub txAncho_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txAncho.KeyPress
        ' Solo numeros
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub

    Private Sub txAncho_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txAncho.PreviewKeyDown
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txLargo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txLargo.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                txAncho.SelectAll()
                txAncho.Focus()
            Case Keys.Enter, Keys.Tab
                e.Handled = True
                If String.IsNullOrEmpty(txLargo.Text) = True Then
                    MessageBox.Show("Debe ingresar el largo", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                validaLargo(txLargo.Text)
                'BuscarMedidas()
        End Select
    End Sub

    Private Sub txLargo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txLargo.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub

    Private Sub txLargo_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txLargo.PreviewKeyDown
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txCantidad_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txCantidad.PreviewKeyDown
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txCantidad_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txCantidad.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                e.Handled = True


                If String.IsNullOrEmpty(txCantidad.Text) = True Then
                    MessageBox.Show("Ingrese un ancho vàlido", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                validaCantidad()
            Case Keys.Tab
                e.Handled = True
                If String.IsNullOrEmpty(txCantidad.Text) = True Then
                    MessageBox.Show("Ingrese un ancho vàlido", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                validaCantidad()

        End Select
    End Sub

    Private Sub txCantidad_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txCantidad.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub

    Private Sub btBorra_Click(sender As System.Object, e As System.EventArgs) Handles btBorra.Click
        If New cdPaquete_det().PaqueteTieneDetalle(CInt(lbPaquetID.Text)) = True Then
            MessageBoxEx.Show("No es posible borrar esta Ruma, porque tiene registros dependientes", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If MessageBoxEx.Show("Realmente desea borrar el registro de este Paquete " & lbPaquetID.Text & "?", xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        If New cdPaquete_det().BorrarPaquete(lbPaquetID.Text) = False Then
            MessageBox.Show("No se pudo borrar el registro", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        LimpiarControles(True)
        HabilitarControles(False)
        sgDetalle.PrimaryGrid.Rows.Clear()
        txRuma.Focus()
        recno = 0
        lsHeader = New cdPaquete_det().VistaPaquetes()
        listarEncabecados()
        ' frmFormato04.btUpdate.PerformClick()

    End Sub

   
End Class