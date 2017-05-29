
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Public Class frmFormato04_det

    Friend xFecha As Date
    Friend xExiste As Boolean
    Friend xIdPapa As Integer
    Friend xF02pro As Integer = 0
    Friend xF02pro2 As Integer = 0
    Friend xPeriodo As String
    Friend xTproduccion As Integer = Nothing
    Friend xRumaId As Integer
    Friend xEmpresaId As Integer
    Friend xMaxlargo As Double
    Dim xId As Integer
    Dim modifica As Boolean

    Dim xCantrozas As Integer = 0
    Dim xFe As Double = 0.0
    Dim xVolm3Trozas As Decimal = 0
    Dim xvolacumtotal As Decimal = 0

    Dim xVolm3Aserrad As Decimal = 0
    Dim xVolptAserrad As Decimal = 0
    Dim xcantidad As Integer = 0

    Dim xTitulo = fxSamad.Titulo

    Dim recno As Integer = 0
    Dim lsHeader As List(Of SAMAD.vw_rumas)
    Dim dbpro As New productos
    Dim xAprovechable As Double
    Dim xtransaccional As String
    Dim xDoIt As Boolean
    Dim xmodificar As Boolean = False
    Dim flagnavegar As Boolean = False
    Dim datoVolo As Decimal = 0

#Region "Funciones y procedimientos Locales del Sistema"

    Private Sub CargaCubicacion()
        'cbPoa.DataSource = dm.zafrasypoas.Where(Function(p) p.Zyp_Zafra = xzafra And p.Zyp_Permiso_Id = ContratoId)
        'cbCubicacion.DataSource = dm.cubicacion.Select(Function(x) x.Cub_Descrip)

        'cbCubicacion.DataSource = dm.productos.Select(Function(x) x.Prod_NomProducto).Distinct()
        'cbCubicacion.SelectedIndex = Nothing
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
        Label23.Text = xunidadAb
        Label20.Text = xunidadAb
        Label19.Text = xunidadL

        If xsimbolcal = "P" Or xsimbolcal = "NP" Or xsimbolcal = "NCH" Then
            LblUnid.Text = "Pz"
            Label18.Text = "Pz"
        Else
            If xsimbolcal = "PQ" Or xsimbolcal = "NPQ" Or xsimbolcal = "CHQ" Or xsimbolcal = "NCHQ" Then
                LblUnid.Text = "Pqt"
                Label18.Text = "Pqt"
            End If
        End If

        llenacombosdeRelacionProduc()
        llenacomboUbicacion()

    End Sub

    Private Sub ContarTrozas()
        Dim xvalorexiste As Integer
        Dim xvolacum As Double


        Dim dm As New samadEntities

        If String.IsNullOrEmpty(txEspecieId.Text) = True Then
            xCantrozas = 0            
            xVolm3Trozas = 0
            xvalorexiste = 0
            xvolacum = 0
            xvolacumtotal = 0
        Else
            'xCantrozas = dm.formato02a.Where(Function(x) x.F02d_F02_Id = xF02pro And x.EspecieId = CInt(txEspecieId.Text)).Count()
            xCantrozas = dm.vw_formato02a.Where(Function(x) x.F02_NroDoc = xF02pro And x.EspecieID = txEspecieId.Text).Count()
            'Dim xVolm3Troza = dm.formato02_det.Where(Function(x) x.F02d_F02_Id = xF02pro And x.EspecieId = CInt(txEspecieId.Text) And x.F02d_Lote = txLote.Text).Sum(Function(x) x.F02d_Volm3)
            'Dim xVolm3Troz = dm.vw_formato02a.Where(Function(x) x.F02d_F02_Id = xF02pro And x.EspecieID = txEspecieId.Text).Sum(Function(x) x.F02d_Volm3)
            Dim consultaTrozas = dm.vw_formato02a.Where(Function(x) x.F02_NroDoc = xF02pro And x.EspecieID = txEspecieId.Text).Sum(Function(x) x.F02d_Volm3)

            If consultaTrozas Is Nothing Then
                xVolm3Trozas = 0.0
            Else
                xVolm3Trozas = consultaTrozas
            End If

            xvalorexiste = dm.formato04_rumas.Where(Function(x) x.Lote_troza = txLote.Text And x.EspecieId = txEspecieId.Text).Select(Function(x) x.Lote_troza).FirstOrDefault()
            If xvalorexiste > 0 Then
                xvolacum = dm.formato04_rumas.Where(Function(x) x.Lote_troza = txLote.Text And x.EspecieId = CInt(txEspecieId.Text) And x.RumaId <= CInt(lbRumaID.Text)).Select(Function(x) x.VolM3).Sum() ' trae total volumen trozas aserradas
                xvalorexiste = dm.formato04_rumas.Where(Function(x) x.Lote_troza = txLote.Text And x.EspecieId = txEspecieId.Text).Select(Function(x) x.Lote_troza).Count() 'si existe 
                xvolacumtotal = dm.formato04_rumas.Where(Function(x) x.Lote_troza = txLote.Text And x.EspecieId = txEspecieId.Text).Select(Function(x) x.VolM3).Sum() ' trae total volumen 
            Else
                xvalorexiste = 0
                xvolacum = 0
                xvolacumtotal = 0
            End If

        End If

        'xVolm3Trozas = dm.formato02_det.Where(Function(x) x.F02d_F02_Id = xF02pro And x.EspecieId = CInt(txEspecieId.Text) And Function(x) x.F02d_Lote = txLote.Text).Sum(Function(x) x.F02d_Volm3)
        'lblVm3.Text = "Vol. M3:  " & xVolm3Trozas
        'lblCantrozas.Text = "Trozas:  " & xCantrozas

        'Dim xsaldoacum = dm.formato04_rumas.Where(Function(x) x.Lote_troza = txLote.Text And x.EspecieId = txEspecieId.Text And x.RumaId <= lbRumaID.Text).Select(Function(x) x.Sald_Vol_Trozas).Sum() '



        txTrozas.Text = xCantrozas
        txM3.Text = Format(xVolm3Trozas, "##0.000")

        If xvalorexiste > 0 Then
            'lbProvecho.Text = xsaldoacum.ToString
            If flagnavegar = True Then
                lbVol_Aprov.Text = (xVolm3Trozas * (txProvecho.Value / 100)).ToString '(txProvecho.Value / 100)
                lbAcumVolm3.Text = xvolacum.ToString
                lbProvecho.Text = (lbVol_Aprov.Text - lbAcumVolm3.Text)
            Else
                flagnavegar = False
                lbAcumVolm3.Text = xvolacum.ToString
                lbProvecho.Text = (lbVol_Aprov.Text - lbAcumVolm3.Text)
            End If
        Else
            'xAprovechable = CDec(xVolm3Trozas) * (txProvecho.Value / 100) '90 %
            'lbProvecho.Text = xAprovechable
            lbAcumVolm3.Text = 0
            lbProvecho.Text = 0
        End If



    End Sub
    Private Function CalcularConsumo() As Double
        Dim dm As New samadEntities
        xcantidad = dm.formato04_rumas.Where(Function(x) x.Lote_troza = txLote.Text And x.EspecieId = txEspecieId.Text).Count()
        Dim vm3 = dm.formato04_rumas.Where(Function(x) x.Lote_troza = txLote.Text And x.EspecieId = txEspecieId.Text).Select(Function(x) x.Sald_Vol_Trozas).Min()

        If vm3.HasValue Then
            Return vm3
        Else
            Return 0
        End If

    End Function
    'Genera  automaticamente el Numero de Ruma(Segun el Periodo)
    Private Sub CodigoRuma()
        Dim dm As New samadEntities
        Dim xNumero As Integer = 0
        xNumero = (From fr In dm.formato04_rumas From z In dm.formato04 Where fr.F04_Id = z.F04_Id And z.F04_Periodo = xPeriodo Select fr.RowId).Count()
        'xNumero = dm.formato04_rumas.Where(Function(x) x.Periodo = xPeriodo).Max(Function(x) x.RumaId)
        'xNumero = dm.formato04_rumas.Where(Function(x) x.Periodo = xPeriodo).Select(Function(x) x.RowId).Count()
        txRumaId.Text = New fxSamad().StrCeros(xNumero, 6, True)
    End Sub

    Private Sub LimpiarValoresMedicion()
        txAncho.Clear()
        txLargo.Clear()
        txCantidad.Clear()
        txEspesor.Clear()
        txVolPT.Clear()
        txVolM3.Clear()
    End Sub

    Private Sub HabilitarControles(ByVal xEstado As Boolean)
        btSave.Enabled = xEstado
        btUnDo.Enabled = xEstado
        btNew.Enabled = Not xEstado
        btDelete.Enabled = Not xEstado
        btEdit.Enabled = Not xEstado
        cbObjetivo.Enabled = xEstado
        cbCent.Enabled = xEstado
        CbUbiPro.Enabled = xEstado
        txRumaId.Enabled = xEstado
        txEspecieId.Enabled = xEstado
        txEspecie.Enabled = xEstado
        txProvecho.Enabled = xEstado
        CbclaseProducto.Enabled = xEstado
        chkCertificada.Enabled = xEstado
        txEspesor.Enabled = xEstado
        txAncho.Enabled = xEstado
        txLargo.Enabled = xEstado
        If TxSimboloCubi.Text = "P" Or TxSimboloCubi.Text = "Pq" Then
            txCantidad.Enabled = Not xEstado
            txCantidad.Text = 1
        Else
            txCantidad.Enabled = xEstado
        End If
        txVolPT.Enabled = xEstado
        txVolM3.Enabled = xEstado
        btAddDetalle.Enabled = xEstado
        sgDetalle.Enabled = xEstado
        grResumenMedicion.Enabled = xEstado
    End Sub

    Private Sub LimpiarControles()
        txRumaId.Text = ""
        txProductoId.Text = ""
        txEspecieId.Text = ""
        txEspecie.Text = ""
        txLote.Text = ""
        txOrdenProd.Text = ""
        txProductoId.Text = ""
        txProducto.Text = ""
        TxFunCal.Text = ""
        TxSisCubicacion.Text = ""
        TxSimboloCubi.Text = ""
        'lblCantrozas.Text = "Trozas : 0.00"
        'lblVm3.Text = "Vol. M3:0.00"
        txTrozas.Text = ""
        txM3.Text = ""
        lbAprovechar.Text = "0%"
        Label23.Text = ""
        Label20.Text = ""
        Label19.Text = ""
        LblUnid.Text = ""
        lbAcumVolm3.Text = ""
        lbVol_Aprov.Text = ""
        lbProvecho.Text = ""
        'cbCubicacion.SelectedIndex = Nothing        
        cbObjetivo.SelectedIndex = Nothing
        CbUbiPro.DataSource = Nothing
        cbCent.DataSource = Nothing

    End Sub

    Private Sub ListarEncabezado()
        If lsHeader.Count() > 0 Then
            lbRumaID.Text = lsHeader(recno).RowId
            lbRowPapa.Text = lsHeader(recno).F04_Id
            'lbNumero.Text =lsHeader(recno).Periodo 
            txEspecieId.Text = lsHeader(recno).EspecieId
            txEspecie.Text = lsHeader(recno).Nombre_especie
            txLote.Text = lsHeader(recno).Lote_troza
            txOrdenProd.Text = lsHeader(recno).Orden_produccion
            txRumaId.Text = lsHeader(recno).Codigo_ruma
            txProductoId.Text = lsHeader(recno).ProductoId
            txProducto.Text = lsHeader(recno).Descripcion_ruma
            'TxFunCal.Text = lsHeader(recno).Prod_FuncionCalculo
            'TxSisCubicacion.Text = lsHeader(recno).Prod_SistemaCalculo
            'TxSimboloCubi.Text = lsHeader(recno).Prod_Simbolo
            'lbAprovechar.
            'lblCantrozas.Text = "Trozas :" & lsHeader(recno).Cantidad_trozas
            'lblVm3.Text = "Vol. M3 :" & lsHeader(recno).Volumen_m3_trozas
            txTrozas.Text = xCantrozas
            'txM3.Text=Format((volpt * CDec(txCantidad.Text)), "#,##0.00")
            txM3.Text = Format(xVolm3Trozas, "##0.000")
            'lbVol_Aprov.Text = lsHeader(recno).VoLoTrozas
            'cbCubicacion.SelectedIndex = lsHeader(recno).Tipo_medida
            chkCertificada.Checked = lsHeader(recno).MaderaCertificada
            cbObjetivo.Text = lsHeader(recno).Objetivo_producto
            CbclaseProducto.Text = lsHeader(recno).ClasificaProducto
            txRecNo.Text = recno + 1 & " de " & lsHeader.Count
            'xAprovechable = CDec(txM3.Text) * (txProvecho.Value / 100)
            'lbProvecho.Text = lsHeader(recno).Sald_Vol_Trozas  'xAprovechable
            If recno > 0 Then
                datoVolo = lsHeader(recno - 1).VoLoTrozas
            End If

            traeDatosProducto(txProductoId.Text)
            ListarDetalleRuma()
            flagnavegar = True

        Else
            LimpiarControles()
            Dim xRow As GridRow = Nothing
            Dim xPanel As GridPanel = sgDetalle.PrimaryGrid
            xPanel.Rows.Clear()
        End If
        'Agregar el Detalle al Grid
    End Sub

    Private Sub CalculoPT()
        Dim volpt As Decimal = 0, volm3 As Decimal = 0, espcal As Decimal = 0, anchcal As Decimal = 0, larcal As Decimal = 0

        Try
            If CDec(txEspesor.Text) > 0 And CDec(txAncho.Text) > 0 And CDbl(txLargo.Text) > 0 Then

                volpt = New fxSamad().FormulaPT(CDec(txEspesor.Text), CDec(txAncho.Text), CDbl(txLargo.Text), 3)
                txVolPT.Text = Format(CDec(volpt), "#,##0.00")

                If Label23.Text = "m" Then
                    espcal = (CDec(txEspesor.Text) * 1)
                ElseIf Label23.Text = "cm" Then
                    espcal = (CDec(txEspesor.Text) * 100)
                Else
                    espcal = (CDec(txEspesor.Text) * 1000)
                End If

                If Label20.Text = "m" Then
                    anchcal = (CDec(txAncho.Text) * 1)
                ElseIf Label20.Text = "cm" Then
                    anchcal = (CDec(txAncho.Text) * 100)
                Else
                    anchcal = (CDec(txAncho.Text) * 1000)
                End If

                If Label19.Text = "m" Then
                    larcal = (CDec(txLargo.Text) * 1)
                ElseIf Label19.Text = "cm" Then
                    larcal = (CDec(txLargo.Text) * 100)
                Else
                    larcal = (CDec(txLargo.Text) * 1000)
                End If

                volm3 = New fxSamad().FormulaM3(CDec(espcal), CDec(anchcal), CDbl(larcal), 3)



                If TxSisCubicacion.Text = "Pt" Then
                    If IsNumeric(txCantidad.Text) Then
                        txVolPT.Text = Format((volpt * CDec(txCantidad.Text)) * xFe, "#,##0.00")

                        txVolM3.Text = Format((((volpt * CDec(txCantidad.Text) * xFe) / 424)), "#,##0.000")
                    End If
                Else
                    If IsNumeric(txCantidad.Text) Then
                        txVolM3.Text = Format((volm3 * CDec(txCantidad.Text)) * xFe, "#,##0.000")

                        txVolPT.Text = Format((((volm3 * CDec(txCantidad.Text) * xFe) * 424)), "#,##0.00")
                    End If
                End If




            End If
        Catch ex As Exception
            txVolPT.Text = "0.00"
            txVolM3.Text = "0.00"
        End Try
    End Sub

    Private Function BuscarMedidas() As Integer
        Dim dm As New samadEntities
        Dim xProductoId As Integer
        Try
            xProductoId = dm.productos.Where(Function(e) txEspesor.Text >= e.Prod_Espesor And txAncho.Text >= e.Prod_Ancho And txLargo.Text >= e.Prod_Largo).Select(Function(x) x.Prod_Id).FirstOrDefault()
            lbId.Text = xProductoId
            Return xProductoId
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub LimpiarDetalleRuma()
        txEspesor.Text = ""
        txAncho.Text = ""
        txLargo.Text = ""
        txCantidad.Text = ""
        txVolPT.Text = ""
        txVolM3.Text = ""
    End Sub

    Private Sub ListarDetalleRuma()
        Dim x As Long = 0
        Dim xRow As GridRow = Nothing
        Dim xPanel As GridPanel = sgDetalle.PrimaryGrid

        If lbRowPapa.Text > 0 Then
            Dim ls = New cdFormato04_rumas().RumaDetalle(CInt(lbRumaID.Text))
            If ls.Count > 0 Then
                xPanel.Rows.Clear()
                For x = 0 To ls.Count - 1
                    xRow = New GridRow(ls(x).Orden, ls(x).Tipo_corte, ls(x).Espesor, ls(x).Ancho, ls(x).Largo, ls(x).Cantidad, ls(x).Vol_pt, ls(x).Vol_m3)
                    xPanel.Rows.Add(xRow)

                Next
            Else
                xPanel.Rows.Clear()
            End If
        Else
            xPanel.Rows.Clear()
        End If
    End Sub

    ' - Funcion local para obtener la suma del volumen de trozas

    'dataTransferir.DataSource = (From t In db.listatrozasd From z In db.zafrasypoas
    '                                            Where t.listatrozasc.Lt_Poa_Id = z.Zyp_id And z.Zyp_Zafra = zafr And z.Zyp_Permiso_Id = id And
    '                                            String.IsNullOrEmpty(t.Ltd_Autogenerado) Select t).ToList()



#End Region
    Private Sub txEspecie_ButtonCustomClick(sender As System.Object, e As System.EventArgs) Handles txEspecie.ButtonCustomClick
        Dim wfBuscar As New frmShowbrow
        wfBuscar.titulo = "Especies en Producción Nro " & lbNumero.Text
        wfBuscar.t_tabla = "vw_formato02a"
        wfBuscar.t_campos = "f02_id,f02_fecha,f02d_lote,especieid,especie, f02_nroope,SUM(f02d_volm3) AS f02d_volm3"
        wfBuscar.t_donde = String.Format("f02_nrodoc={0}", lbNumero.Text)
        wfBuscar.t_agruparpor = "especie"
        wfBuscar.t_ordenarpor = "especie"
        Dim titulos() As String = {"Id", "Fecha", "Lote", "Especie ID", "Especie", "Nro Op", "Vol_m3"}
        Dim anchos() As Integer = {50, 80, 60, 60, 160, 60, 60}
        ReDim wfBuscar.matAnchos(anchos.Length)
        ReDim wfBuscar.matTitulos(titulos.Length)
        ReDim wfBuscar.matColumnas(titulos.Length)
        titulos.CopyTo(wfBuscar.matTitulos, 0)
        anchos.CopyTo(wfBuscar.matAnchos, 0)
        wfBuscar.ShowDialog(Me)
        If wfBuscar.flag = True Then
            txLote.Text = wfBuscar.matColumnas(2)
            txEspecieId.Text = wfBuscar.matColumnas(3)
            txEspecie.Text = wfBuscar.matColumnas(4)
            txOrdenProd.Text = wfBuscar.matColumnas(5)
            lbVol_Aprov.Text = (wfBuscar.matColumnas(6) * (txProvecho.Value / 100))
            xF02pro = lbNumero.Text
            ContarTrozas()
        End If
        CodigoRuma()
        txRumaId.SelectAll()
        txRumaId.Focus()
        wfBuscar = Nothing
    End Sub

    Private Sub txRuma_Leave(sender As System.Object, e As System.EventArgs) Handles txRumaId.Leave
        If IsNumeric(txRumaId.Text) = True Then
            txRumaId.Text = Microsoft.VisualBasic.Right("000000" + txRumaId.Text, 6)
        End If
        'Validar si esta ruma existe en el periodo(Pendiente)
    End Sub
    Private Sub bloquearNavegacion()
        btFisrt.Enabled = False
        btBack.Enabled = False
        txRecNo.Enabled = False
        btNext.Enabled = False
        btLast.Enabled = False
        btUnDo.Enabled = True
    End Sub
    Private Sub DesbloquearNavegacion()
        btFisrt.Enabled = True
        btBack.Enabled = True
        txRecNo.Enabled = True
        btNext.Enabled = True
        btLast.Enabled = True
        btUnDo.Enabled = False
    End Sub

    Private Sub ultimaRumaIngresada()
        Dim xLast As Integer = 0
        Dim dm As New samadEntities
        xLast = dm.formato04_rumas.Where(Function(x) x.F04_Id = lbRowPapa.Text).Select(Function(x) x.RumaId).FirstOrDefault()
        If xLast > 0 Then
            xLast = dm.formato04_rumas.Where(Function(x) x.F04_Id = lbRowPapa.Text).Select(Function(x) x.RumaId).Max()
        End If

        lbRumaID.Text = xLast + 1 'New fxSamad().StrCeros(xLast, 6, True)
        'Dim xNext = dm.formato04.Where(Function(x) x.F04_Periodo = txPeriodo.Text).Select(Function(x) x.F04_Nro).Max()
        'txtNro.Text = New fxSamad().StrCeros(xNext, 6, True)
        'recno = xLast
    End Sub

    Private Function validacambioEspecie() As Boolean

        Dim dm As New samadEntities
        'Dim existe As Integer
        Dim existe = dm.formato04_rumas_det.Where(Function(x) x.RumaId = lbRumaID.Text).Select(Function(x) x.RowId).Count()
        'Dim exist = dm.formato04_rumas_det.Where(Function(x) x.RumaId = lbRumaID.Text).ToList().Count()
        If existe > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub txProducto_ButtonCustomClick(sender As System.Object, e As System.EventArgs) Handles txProducto.ButtonCustomClick
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
            txProductoId.Text = wfBuscar.matColumnas(0)
            txProducto.Text = wfBuscar.matColumnas(1)
            traeDatosProducto(txProductoId.Text)
        End If
        wfBuscar = Nothing
    End Sub

    Private Sub frmFormato04_det_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'lbAprovechar.Text = IIf(xTproduccion = 0, "52%", "28%")
        lsHeader = New cdFormato04_rumas().VistaRumas()
        HabilitarControles(False)
        recno = lsHeader.Count - 1
        ListarEncabezado()
        ContarTrozas()
        'CbclaseProducto.Enabled = False
        resumen_aserrio_lotes()


    End Sub
    Private Sub llenacombosdeRelacionProduc()
        Dim dm As New samadEntities
        cbCent.DataSource = dm.procesos.Where(Function(p) p.Pro_id = xEmpresaId).Select(Function(x) x.Proc_descripcion).Distinct().ToList()
        'CbUbiPro.DataSource = dm.ubicacion.Where(Function(p) p.Ubi_ProId = xEmpresaId).Select(Function(x) x.Ubi_Nombre).Distinct().ToList()
    End Sub
    Private Sub llenacomboUbicacion()
        Dim dm As New samadEntities
        'cbCent.DataSource = dm.procesos.Where(Function(p) p.Pro_id = xEmpresaId).Select(Function(x) x.Proc_descripcion).Distinct().ToList()
        CbUbiPro.DataSource = dm.ubicacion.Where(Function(p) p.Ubi_ProId = xEmpresaId).Select(Function(x) x.Ubi_Nombre).Distinct().ToList()
    End Sub

    Private Sub btSave_Click(sender As System.Object, e As System.EventArgs) Handles btSave.Click

        If String.IsNullOrEmpty(txRumaId.Text) = True Then
            MessageBox.Show("No se ha ingresado el Codigo de Ruma", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If TxVolumenPt.Text = "" Then
            If New cdFormato04_rumas().RumaExiste(txRumaId.Text, xPeriodo) = True Then
                MessageBox.Show("El Codigo de ruma que ha ingresado ya existe en el Periodo", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txRumaId.SelectAll()
                txRumaId.Focus()
                Return
            End If
        End If
        If String.IsNullOrEmpty(txEspecieId.Text) = True Then
            MessageBox.Show("Seleccione la Especie del Producto", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txEspecie.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(txProductoId.Text) = True Then
            MessageBox.Show("Debe seleccionar el producto de la Ruma", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txProducto.Focus()
            Exit Sub
        End If
        Dim dt As New SAMAD.formato04_rumas
        Dim dm As New samadEntities

        Dim valorexiste = dm.formato04_rumas.Where(Function(x) x.Lote_troza = txLote.Text And x.EspecieId = txEspecieId.Text).Select(Function(x) x.RumaId).Count()
        If xmodificar = True Then
            xExiste = True
        Else
            xExiste = False

        End If

        If xExiste = True Then
            dt.RowId = lbRumaID.Text 'xRumaId
        End If
        dt.RumaId = lbRumaID.Text
        dt.Codigo_ruma = txRumaId.Text
        dt.ProductoId = txProductoId.Text
        dt.Descripcion_ruma = txProducto.Text
        dt.EspecieId = txEspecieId.Text
        dt.Especie = txEspecie.Text
        dt.Lote_troza = txLote.Text

        dt.Orden_produccion = txOrdenProd.Text
        If String.IsNullOrEmpty(TxCantida.Text) = True Then
            dt.Cantidad = 0
        Else
            dt.Cantidad = CInt(TxCantida.Text) 'xcantidad
        End If
        If String.IsNullOrEmpty(TxVolumenM3.Text) = True Then
            dt.VolM3 = 0
        Else
            dt.VolM3 = CDbl(TxVolumenM3.Text)  'xVolm3Troza
        End If
        If String.IsNullOrEmpty(TxVolumenPt.Text) = True Then
            dt.VolPT = 0
        Else
            dt.VolPT = CDbl(TxVolumenPt.Text)
        End If

        'dt.Cantidad = IIf(String.IsNullOrEmpty(txCantidad.Text) = True, 0, txCantidad.Text)
        'dt.VolM3 = 0

        dt.Estatus = 0
        dt.F04_Id = xIdPapa
        dt.FuncionCalculo = TxFunCal.Text
        dt.SisCubicacion = TxSisCubicacion.Text
        dt.Simbolo = TxSimboloCubi.Text
        dt.TipUnidad = LblUnid.Text
        'dt.Periodo = xPeriodo
        'dt.Tipo_medida = cbCubicacion.SelectedIndex
        dt.MaderaCertificada = chkCertificada.CheckState
        dt.Objetivo_producto = cbObjetivo.Text
        dt.CentroTransac = cbCent.Text
        dt.UbicaProducto = CbUbiPro.Text
        dt.ClasificaProducto = CbclaseProducto.Text

        If valorexiste > 0 Then
            If valorexiste = 1 Then
                dt.VoLoTrozas = lbVol_Aprov.Text
            Else
                If TxVolumenM3.Text = "" Then
                    dt.VoLoTrozas = CDbl(lbProvecho.Text)
                Else
                    'dt.VoLoTrozas = saldoTrozas(xIdPapa, txEspecieId.Text)
                    dt.VoLoTrozas = CDbl(TxVolumenM3.Text) + CDbl(lbProvecho.Text)
                End If

            End If
        Else
            dt.VoLoTrozas = xVolm3Trozas
        End If

        dt.Sald_Vol_Trozas = lbProvecho.Text



        If New cdFormato04_rumas().GrabarRumas(dt, xExiste) = False Then
            MessageBox.Show("No se pudo completar el proceso de Grabar el registro", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        txEspecie.ButtonCustom.Visible = False
        txProducto.ButtonCustom.Visible = False
        HabilitarControles(False)
        lsHeader = New cdFormato04_rumas().VistaRumas()
        recno = lsHeader.Count - 1
        ListarEncabezado()
        DesbloquearNavegacion()
        resumen_aserrio_lotes()
        frmFormato04.recargagrilla = True
    End Sub

    Private Sub btNew_Click(sender As System.Object, e As System.EventArgs) Handles btNew.Click
        Dim xPanel As GridPanel = sgDetalle.PrimaryGrid
        xPanel.Rows.Clear()
        LimpiarControles()
        txEspecie.ButtonCustom.Visible = True
        txProducto.ButtonCustom.Visible = True
        HabilitarControles(True)
        ultimaRumaIngresada()
        CodigoRuma()
        bloquearNavegacion()
        txRumaId.SelectAll()
        txRumaId.Focus()
        flagnavegar = False
        TxCantida.Text = ""
        TxVolumenPt.Text = ""
        TxVolumenM3.Text = ""
        xF02pro = 0
    End Sub

    Private Sub btUnDo_Click(sender As System.Object, e As System.EventArgs) Handles btUnDo.Click
        HabilitarControles(False)
        DesbloquearNavegacion()
        ListarEncabezado()
        ContarTrozas()
        resumen_aserrio_lotes()
        LimpiarValoresMedicion()
    End Sub

    Private Sub btNext_Click(sender As System.Object, e As System.EventArgs) Handles btNext.Click
        recno = recno + 1
        If recno > lsHeader.Count - 1 Then
            recno = lsHeader.Count - 1
        End If
        ListarEncabezado()
        ContarTrozas()
        resumen_aserrio_lotes()
    End Sub

    Private Sub btLast_Click(sender As System.Object, e As System.EventArgs) Handles btLast.Click, txLargo.Leave
        recno = lsHeader.Count - 1
        ListarEncabezado()
        ContarTrozas()
        resumen_aserrio_lotes()
    End Sub

    Private Sub btBack_Click(sender As System.Object, e As System.EventArgs) Handles btBack.Click
        recno = recno - 1
        If recno < 0 Then
            recno = 0
        End If
        ListarEncabezado()
        ContarTrozas()
        resumen_aserrio_lotes()
    End Sub

    Private Sub btFisrt_Click(sender As System.Object, e As System.EventArgs) Handles btFisrt.Click
        recno = 0
        ListarEncabezado()
        ContarTrozas()
        resumen_aserrio_lotes()
    End Sub
    Private Sub siguientecontrol()
        SendKeys.Send("{TAB}")
    End Sub
    Private Sub txEspesor_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txEspesor.KeyPress
        'Colo numeros
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
            'siguientecontrol()
        End If
    End Sub

    Private Sub txAncho_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txAncho.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
            'siguientecontrol()
        End If
    End Sub

    Private Sub txLargo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txLargo.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
            'siguientecontrol()
        End If
    End Sub

    Private Sub txCantidad_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txCantidad.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
            'siguientecontrol()
        End If
    End Sub

    Private Sub txVolPT_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txVolPT.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
            'siguientecontrol()
        End If
    End Sub

    Private Sub txVolPT_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txVolPT.PreviewKeyDown
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txCantidad_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txCantidad.PreviewKeyDown
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txLargo_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txLargo.PreviewKeyDown
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txAncho_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txAncho.PreviewKeyDown
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If

    End Sub

    Private Sub txEspesor_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txEspesor.PreviewKeyDown
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If

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
            cbTipoCorte.Focus()
            cbTipoCorte.SelectAll()
        Else
            If xsimbolcal = "NP" Or xsimbolcal = "NPQ" Or xsimbolcal = "NCHQ" Then
                If CDbl(txCantidad.Text) < 1 Then
                    MessageBox.Show("para la funcion de Cubicacion seleccionada para este producto solo puede ingresar cantidades de uno a mas")
                    txCantidad.Focus()
                    txCantidad.SelectAll()
                    Exit Sub
                End If
                cbTipoCorte.Focus()
                cbTipoCorte.SelectAll()
            End If
        End If
    End Sub
    Private Sub validaLargo(ByVal texboxer As String)
        Dim variable1, variable2, operaL, PPPT As String
        Dim ValorL As Double
        Dim largoval As Double
        Dim dm As New samadEntities 'dm.procesos.Where(Function(p) p.Pro_id = xEmpresaId).Select(Function(x) x.Proc_descripcion).Distinct().ToList()
        variable1 = dm.tipo_calculo_volumen.Where(Function(x) x.TipCal_Simbolo = TxSimboloCubi.Text).Select(Function(p) p.TipCal_Simbolo).FirstOrDefault()
        variable2 = dm.tipo_calculo_volumen.Where(Function(x) x.TipCal_Cod = TxFunCal.Text).Select(Function(p) p.TipCal_Cod).FirstOrDefault()

        ValorL = dm.productos.Where(Function(x) x.Prod_Id = txProductoId.Text).Select(Function(d) d.Prod_Largo).FirstOrDefault()
        operaL = dm.productos.Where(Function(x) x.Prod_Id = txProductoId.Text).Select(Function(d) d.Prod_OperadorL).FirstOrDefault()

        PPPT = dm.productos.Where(Function(x) x.Prod_Id = txProductoId.Text).Select(Function(d) d.Prod_TipoProducto).FirstOrDefault()

        xMaxlargo = dm.vw_formato02a.Where(Function(x) x.EspecieID = txEspecieId.Text And x.F02_NroDoc = xF02pro).Select(Function(d) d.F02d_D3).Max

        If Label19.Text = "PLin." Then
            largoval = (CDec(txLargo.Text) * 0.3048)

        ElseIf Label19.Text = "m." Then
            largoval = (CDec(txLargo.Text) * 1)
        ElseIf Label19.Text = "mm." Then
            largoval = (CDec(txLargo.Text) / 1000)
        ElseIf Label19.Text = "In." Then
            largoval = (CDec(txLargo.Text) * 0.0254)
        Else
            largoval = (CDec(txLargo.Text) / 100)
        End If

        If variable1 = TxSimboloCubi.Text And variable2 = TxFunCal.Text Then ',ExAxL(P)

            '  If PPPT = "PT" Then 'Cubicado Pieza por Pieza= Pt
            If largoval < xMaxlargo Then

                If (operaL.Equals(">") Or operaL.Equals(">=")) = True Then

                    If (CDbl(texboxer) > CDbl(ValorL) Or CDbl(texboxer) >= CDbl(ValorL)) = True Then
                        If TxSimboloCubi.Text = "P" Or TxSimboloCubi.Text = "Pq" Then
                            cbTipoCorte.Focus()
                            cbTipoCorte.SelectAll()
                        Else
                            txCantidad.Focus()
                            txCantidad.SelectAll()
                        End If
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
            Else
                MessageBox.Show("el valor ingresado en el Largo para el producto selecionado Supera el largo de la troza aserrada")
                txLargo.Focus()
                txLargo.SelectAll()
                Return
            End If
        End If
        txCantidad.Focus()
        txCantidad.SelectAll()
        ' End If
    End Sub

    Private Sub validaAncho(ByVal texboxer As String)
        Dim variable1, variable2, operaA, PPPT As String
        Dim valorA As Double
        Dim dm As New samadEntities

        variable1 = dm.tipo_calculo_volumen.Where(Function(x) x.TipCal_Simbolo = TxSimboloCubi.Text).Select(Function(p) p.TipCal_Simbolo).FirstOrDefault()
        variable2 = dm.tipo_calculo_volumen.Where(Function(x) x.TipCal_Cod = TxFunCal.Text).Select(Function(p) p.TipCal_Cod).FirstOrDefault()

        valorA = dm.productos.Where(Function(x) x.Prod_Id = txProductoId.Text).Select(Function(d) d.Prod_Ancho).FirstOrDefault()
        operaA = dm.productos.Where(Function(x) x.Prod_Id = txProductoId.Text).Select(Function(d) d.Prod_OperadorA).FirstOrDefault()


        PPPT = dm.productos.Where(Function(x) x.Prod_Id = txProductoId.Text).Select(Function(d) d.Prod_TipoProducto).FirstOrDefault()

        If variable1 = TxSimboloCubi.Text And variable2 = TxFunCal.Text Then ',ExAxL(P)

            'If PPPT = "PT" Then 'Cubicado Pieza por Pieza= Pt
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

        txLargo.Focus()
        txLargo.SelectAll()

        'End If


    End Sub

    Private Sub validaEspesor(ByVal texboxer As String)
        Dim variable1, variable2, operaEs, PPPT As String
        Dim esp As Single
        Dim valorEs As Double
        Dim dm As New samadEntities 'dm.procesos.Where(Function(p) p.Pro_id = xEmpresaId).Select(Function(x) x.Proc_descripcion).Distinct().ToList()
        variable1 = dm.tipo_calculo_volumen.Where(Function(x) x.TipCal_Simbolo = TxSimboloCubi.Text).Select(Function(p) p.TipCal_Simbolo).FirstOrDefault()
        variable2 = dm.tipo_calculo_volumen.Where(Function(x) x.TipCal_Cod = TxFunCal.Text).Select(Function(p) p.TipCal_Cod).FirstOrDefault()

        esp = Val(txProductoId.Text)
        valorEs = dm.productos.Where(Function(x) x.Prod_Id = esp).Select(Function(d) d.Prod_Espesor).FirstOrDefault()
        operaEs = dm.productos.Where(Function(x) x.Prod_Id = txProductoId.Text).Select(Function(d) d.Prod_OperadorE).FirstOrDefault()

        PPPT = dm.productos.Where(Function(x) x.Prod_Id = txProductoId.Text).Select(Function(d) d.Prod_TipoProducto).FirstOrDefault()

        If variable1 = TxSimboloCubi.Text And variable2 = TxFunCal.Text Then ',ExAxL(P)

            ' If PPPT = "PT" Then 'Cubicado Pieza por Pieza= Pt
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
            txAncho.Focus()
            txAncho.SelectAll()
  
        End If
        'End If
    End Sub

    Private Sub txEspesor_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txEspesor.KeyDown
        Select Case e.KeyCode
            Case Keys.Tab
                e.Handled = True
                If String.IsNullOrEmpty(txEspesor.Text) = True Then
                    MessageBox.Show("Ingrese el Espesor del Producto", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txEspesor.Focus()
                    Exit Sub
                End If
                validaEspesor(txEspesor.Text)
                txAncho.Focus()
            Case Keys.Enter, Keys.Tab
                e.Handled = True
                If String.IsNullOrEmpty(txEspesor.Text) = True Then
                    MessageBox.Show("Ingrese el Espesor del Producto", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txEspesor.Focus()
                    Exit Sub
                End If
                validaEspesor(txEspesor.Text)
                txAncho.Focus()
        End Select
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
                    MessageBox.Show("Ingrese el Ancho del Producto", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txAncho.Focus()
                    Exit Sub
                End If
                validaAncho(txAncho.Text)
                'txLargo.Focus()
        End Select
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
                    MessageBox.Show("Ingrese el largo del Producto", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txLargo.Focus()
                    Exit Sub
                End If
                validaLargo(txLargo.Text)
                'txCantidad.Focus()
        End Select
    End Sub

    Private Sub txLargo_Leave(sender As Object, e As System.EventArgs)
        CalculoPT()
    End Sub

    Private Sub txCantidad_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txCantidad.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                txLargo.SelectAll()
                txLargo.Focus()
            Case Keys.Enter, Keys.Tab
                e.Handled = True
                If String.IsNullOrEmpty(txCantidad.Text) = True Then
                    MessageBox.Show("Ingrese el Numero de piezas", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txCantidad.Focus()
                    Exit Sub
                End If
                validaCantidad()
                CalculoPT()
                ' cbTipoCorte.Focus()
        End Select
    End Sub

    Private Sub txAncho_Leave(sender As System.Object, e As System.EventArgs) Handles txAncho.Leave
        CalculoPT()
    End Sub

    Private Sub txEspesor_Leave(sender As System.Object, e As System.EventArgs) Handles txEspesor.Leave
        CalculoPT()
    End Sub

    Private Sub btAddDetalle_Click(sender As System.Object, e As System.EventArgs) Handles btAddDetalle.Click
        Dim sd As New samadEntities

        If New cdFormato04_rumas().BuscarRumaxId(CInt(lbRumaID.Text)) = False Then
            MessageBox.Show("Primero necesita grabar los datos de la ruma y luego debe editar el registro para agregar datos en el detalle", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btSave.Focus()
            Exit Sub
        End If
        If New cdFormato04_rumas().EstadoEspecieEnProduccion(txEspecieId.Text, xF02pro) = True Then
            MessageBox.Show("Esta Ruma no permite agregar mas productos, la Operación ya fue cerrada", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If String.IsNullOrEmpty(txVolPT.Text) = True Then
            MessageBox.Show("Los datos no estan completos para agregarse a la RUMA", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If CDec(txVolPT.Text) <= 0 Then
            MessageBox.Show("No se han ingresado los datos del producto para agregarse a la RUMA", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If cbTipoCorte.Text = "" Then
            MessageBox.Show("No se han seleccionado el tipo de corte", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbTipoCorte.SelectAll()
            cbTipoCorte.Focus()
            Exit Sub
        End If
        'Dim xIdMedida As Integer = BuscarMedidas()
        'If xIdMedida = 0 Then
        '    MessageBox.Show("Las medidas ingresadas no corresponden al Producto Seleccionado", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txEspesor.Focus()
        '    Exit Sub
        'Else
        '    If xIdMedida <> txProductoId.Text Then
        '        MessageBox.Show("Las medidas proporcionadas estan fuera del rango aceptable en el Producto", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        txEspesor.SelectAll()
        '        txEspesor.Focus()
        '        Exit Sub
        '    End If
        'End If



        Dim xAcum = ((xVolm3Trozas * txProvecho.Value / 100) - (xvolacumtotal)) ' CalcularConsumo()

        If xAcum <= CDec(txVolM3.Text) Then
            MessageBox.Show("El volumen en Metros Cubicos supera el valor aprovechable de las trozas", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txCantidad.SelectAll()
            txCantidad.Focus()
            Exit Sub
        End If
        'inicio agregar detalle de producto
        Dim dt As New SAMAD.formato04_rumas_det
        Dim xContRegistro As Integer
        'If xExiste = True Then
        '    dt.RowId = 0
        'End If

        If xId > 0 Then
            xExiste = True
            dt.RowId = xId
            dt.RumaId = lbRumaID.Text
            dt.Espesor = txEspesor.Text
            dt.Ancho = txAncho.Text
            dt.Largo = txLargo.Text
            dt.Cantidad = txCantidad.Text
            dt.Tipo_corte = cbTipoCorte.Text
            dt.Vol_pt = txVolPT.Text
            dt.Vol_m3 = txVolM3.Text
            'dt. = txEspecieId.Text
            'dt.Codigo_producto = txProductoId.Text
            dt.F04TipoUnidad = Label18.Text
            'dt.Tipo_corte = cbTipoCorte.SelectedIndex
            dt.Estatus = 0
            'dt.Orden = 1
            If New cdFormato04_rumas().GrabarDetalleRuma(dt, xExiste) = True Then
                'Agregar al Grid
                'Actualizar la tabla formato04_rumas
                Dim sn = New cdFormato04_rumas().ActualizaM3Rumas(CInt(lbRumaID.Text), CDec(txVolM3.Text), CDec(txVolPT.Text), CInt(txCantidad.Text), chkCierra.CheckState)
                If chkCierra.CheckState = CheckState.Checked Then
                    'Marcar formato02_det como utilizado
                    'Dim sn = New fxSamad().ACTUALIZALOTE("formato02_det", "set estatus=1 Where f02d_f02_id=" & xF02pro & " And Especieid=" & txEspecieId.Text)
                    If New fxSamad().Actlote("Update formato02_det Set estatus=1 Where f02d_f02_id=" & xF02pro & " And especieid=" & txEspecieId.Text) = True Then
                        chkCierra.Checked = False
                    End If
                End If
                ListarDetalleRuma()
                LimpiarDetalleRuma()
                txEspesor.Focus()
                resumen_aserrio_lotes()
                ContarTrozas()
                ' lbProvecho.Text = CalcularConsumo().ToString
            End If
        Else

            xContRegistro = sd.formato04_rumas_det.Where(Function(x) x.RumaId = lbRumaID.Text).Count() + 1

            xExiste = False
            'dt.Orden =
            dt.RumaId = lbRumaID.Text
            dt.Espesor = txEspesor.Text
            dt.Ancho = txAncho.Text
            dt.Largo = txLargo.Text
            dt.Cantidad = txCantidad.Text
            dt.Vol_pt = txVolPT.Text
            dt.Vol_m3 = txVolM3.Text
            'dt. = txEspecieId.Text
            'dt.Codigo_producto = txProductoId.Text
            dt.F04TipoUnidad = Label18.Text
            dt.Tipo_corte = cbTipoCorte.Text
            dt.Orden = xContRegistro
            dt.Estatus = 0
            If New cdFormato04_rumas().GrabarDetalleRuma(dt, xExiste) = True Then
                'Agregar al Grid
                'Actualizar la tabla formato04_rumas
                Dim sn = New cdFormato04_rumas().ActualizaM3Rumas(CInt(lbRumaID.Text), CDec(txVolM3.Text), CDec(txVolPT.Text), CInt(txCantidad.Text), chkCierra.CheckState)
                If chkCierra.CheckState = CheckState.Checked Then
                    'Marcar formato02_det como utilizado
                    'Dim sn = New fxSamad().ACTUALIZALOTE("formato02_det", "set estatus=1 Where f02d_f02_id=" & xF02pro & " And Especieid=" & txEspecieId.Text)
                    If New fxSamad().Actlote("Update formato02_det Set estatus=1 Where f02d_f02_id=" & xF02pro & " And especieid=" & txEspecieId.Text) = True Then
                        chkCierra.Checked = False
                    End If
                End If
                ListarDetalleRuma()
                LimpiarDetalleRuma()
                txEspesor.Focus()
                resumen_aserrio_lotes()
                ContarTrozas()
            End If
        End If

        'Grabar el detalle de Rumas
        'frmFormato04.btUpdate.PerformClick()
        frmFormato04.Button1.PerformClick()
        'Actualizar el Formulario Padre
        If TxSimboloCubi.Text = "P" Or TxSimboloCubi.Text = "Pq" Then
            txCantidad.Text = 1
        Else
            txCantidad.Text = 0
        End If
    End Sub

    Private Sub btExit_Click(sender As System.Object, e As System.EventArgs) Handles btExit.Click
        Me.Close()
        frmFormato04.actualizar()
    End Sub

    Private Sub btDelete_Click(sender As System.Object, e As System.EventArgs) Handles btDelete.Click
        Dim ruma As New samadEntities
        Dim estado = ruma.formato04_rumas.Where(Function(x) x.RumaId = lbRumaID.Text).FirstOrDefault()
        If estado.Estatus = True Then
            MessageBoxEx.Show("No es posible borrar esta Ruma, porque ya fue utilizada", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Dim estado2 = ruma.formato04_rumas_det.Where(Function(p) p.RumaId = lbRumaID.Text).FirstOrDefault()
        If estado2.Estatus = True Then
            MessageBoxEx.Show("No es posible borrar esta Ruma, porque ya fue utilizada", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If New cdFormato04_rumas().RumaTieneDetalle(CInt(lbRumaID.Text)) = True Then
            MessageBoxEx.Show("No es posible borrar esta Ruma, porque tiene registros dependientes", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If MessageBoxEx.Show("Realmente desea borrar el registro de esta RUMA?", xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        If New cdFormato04_rumas().BorrarRuma(lbRumaID.Text) = False Then
            MessageBox.Show("No se pudo borrar el registro", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        recno = 0
        lsHeader = New cdFormato04_rumas().VistaRumas()
        ListarEncabezado()
        frmFormato04.btUpdate.PerformClick()
    End Sub

    Private Sub sgDetalle_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles sgDetalle.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right = True Then
            smPop.Show()
        End If
    End Sub

    Private Sub smDel_Click(sender As System.Object, e As System.EventArgs) Handles smDel.Click
        Dim xPanel As GridPanel = sgDetalle.PrimaryGrid
        Dim xRow As GridRow = xPanel.ActiveRow()
        Dim ruma As New samadEntities
        Dim estado = ruma.formato04_rumas.Where(Function(x) x.RumaId = lbRumaID.Text).FirstOrDefault()
        If estado.Estatus = True Then
            MessageBoxEx.Show("No es posible borrar esta Ruma, porque ya fue utilizada", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Dim estado2 = ruma.formato04_rumas_det.Where(Function(p) p.RumaId = lbRumaID.Text).FirstOrDefault()
        If estado2.Estatus = True Then
            MessageBoxEx.Show("No es posible borrar esta Ruma, porque ya fue utilizada", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Dim xId As Integer = xRow.Cells(0).Value
        If MessageBox.Show("Realmente desea borrar el Registro seleccionado?" & xId, xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        If New cdFormato04_rumas().DetalleRumaBorrar(xId) = False Then
            MessageBox.Show("No se pudo completar la operaciond e borrado", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        ListarDetalleRuma()
        frmFormato04.btUpdate.PerformClick()
    End Sub


    Private Sub btEdit_Click(sender As System.Object, e As System.EventArgs) Handles btEdit.Click
        If validacambioEspecie() = True Then
            txEspecieId.Enabled = False
            txEspecie.Enabled = False
            txEspecie.ButtonCustom.Visible = False
            'txProducto.ButtonCustom.Visible = False
            txProducto.ButtonCustom.Visible = True
            HabilitarControles(True)
            'ultimaRumaIngresada()
            ListarEncabezado()
            'CodigoRuma()
            bloquearNavegacion()
            txRumaId.SelectAll()
            txRumaId.Focus()
            xExiste = True
            CbclaseProducto.Enabled = True
        Else

            txEspecie.ButtonCustom.Visible = True
            txProducto.ButtonCustom.Visible = True
            HabilitarControles(True)
            'ultimaRumaIngresada()
            ListarEncabezado()
            'CodigoRuma()
            bloquearNavegacion()
            txRumaId.SelectAll()
            txRumaId.Focus()
            xExiste = True
            CbclaseProducto.Enabled = True
        End If
        xmodificar = True
    End Sub

    Private Sub txRumaId_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txRumaId.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                txEspecie.SelectAll()
                txEspecie.Focus()
            Case Keys.Enter, Keys.Tab
                e.Handled = True
                If String.IsNullOrEmpty(txRumaId.Text) = True Then
                    MessageBox.Show("Ingrese el Ancho del Producto", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txAncho.Focus()
                    Exit Sub
                End If

                txEspecie.Focus()
        End Select
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

            cantidad = dm.formato04_rumas_det.Where(Function(x) x.RumaId = lbRumaID.Text).Select(Function(d) d.Cantidad).Sum() 'txRumaId
            sumaVolpt = dm.formato04_rumas_det.Where(Function(x) x.RumaId = lbRumaID.Text).Select(Function(d) d.Vol_pt).Sum()
            sumaVolM3 = dm.formato04_rumas_det.Where(Function(x) x.RumaId = lbRumaID.Text).Select(Function(d) d.Vol_m3).Sum()
        Else
            cantidad = 0
            sumaVolpt = 0
            sumaVolM3 = 0
 
        End If
        TxCantida.Text = cantidad
        TxVolumenPt.Text = sumaVolpt
        TxVolumenM3.Text = sumaVolM3

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

        'xIdPaquete = xRow.Cells(1).Value
        txEspesor.Text = xRow.Cells(2).Value
        txAncho.Text = xRow.Cells(3).Value
        txLargo.Text = xRow.Cells(4).Value
        txCantidad.Text = xRow.Cells(5).Value
        txVolPT.Text = xRow.Cells(6).Value
        txVolM3.Text = xRow.Cells(7).Value

    End Sub


    
    Private Sub Label17_Click(sender As System.Object, e As System.EventArgs) Handles Label17.Click
        Dim frmProcesos As New frmProcesos
        frmProcesos.ShowDialog(Me)
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click
        Dim frmUbicacion As New frmUbicacion
        frmUbicacion.ShowDialog(Me)
    End Sub

    Private Sub CbUbiPro_Click(sender As Object, e As System.EventArgs) Handles CbUbiPro.Click
        llenacomboUbicacion()
    End Sub

    Private Sub CbUbiPro_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbUbiPro.SelectedIndexChanged

    End Sub

    Private Sub cbCent_Click(sender As Object, e As System.EventArgs) Handles cbCent.Click
        llenacombosdeRelacionProduc()
    End Sub

    Private Sub cbTipoCorte_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbTipoCorte.KeyPress
        siguientecontrol()
    End Sub

    Private Function saldoTrozas(ByVal idDoc As Integer, ByVal idEspecie As String)
        Dim dm As New samadEntities
        Dim ultimo = dm.formato04_rumas.Where(Function(x) x.F04_Id = idDoc And x.EspecieId = idEspecie).ToList().LastOrDefault()
        Return ultimo.Sald_Vol_Trozas
    End Function
End Class
