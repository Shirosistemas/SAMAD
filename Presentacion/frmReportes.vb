Imports MySql.Data.MySqlClient
Public Class frmReportes
    Dim titulares As Boolean = True
    Dim contratos As Boolean = False
    Dim zafras As Boolean = False
    Dim poas As Boolean = False



    'Private Sub ResulAgrupado()
    '    Dim db As New samadEntities
    '    Dim fechaf = dtFin.Value.AddDays(-1)
    '    Dim xResultado As=(From d In db.listatrozasd.Include("listatrozosc")
    '                       From dest In db.titulares
    '                       From tit In db.titulares 
    '                       From prop In db.titulares 
    '                       From Poa In db.zafrasypoas 


    'End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        Dim db As New samadEntities

        Dim fechafin = dtFin.Value.AddDays(-1)

        Dim resul = (From d In db.listatrozasd.Include("listatrozasc")
                   From destinatario In db.titulares
                   From titular In db.titulares
                   From propietario In db.titulares
                   From poa In db.zafrasypoas
                   Where
                   d.listatrozasc.Lt_Titular_Id = titular.Pro_Id And
                   d.listatrozasc.Lt_Destinatario_Id = destinatario.Pro_Id And
                   d.listatrozasc.Lt_Propietario_Id = propietario.Pro_Id And
                   d.listatrozasc.Lt_Poa_Id = poa.Zyp_id And
                   d.listatrozasc.Lt_Fecha >= dtInicio.Value And
                   d.listatrozasc.Lt_Fecha <= dtFin.Value And
                   d.Ltd_Especie.Contains(txtEspecie.Text) And
                   d.listatrozasc.Lt_Nrogtf.Contains(txtGTF.Text) And
                   poa.Zyp_Poa.Contains(txtPOA.Text) And
                   destinatario.Pro_Titular.Contains(txtDestinatario.Text) And
                   titular.Pro_Titular.Contains(txtTitular.Text) And
                   propietario.Pro_Titular.Contains(txtPropietario.Text)
                   Select New reporte01 With {.Titular = titular.Pro_Titular,
                                                .Cabecera = d.listatrozasc,
                                                .Destinatario = destinatario.Pro_Titular,
                                                .Detalle = d,
                                                .Poa = poa.Zyp_Poa,
                                                .Propietario = propietario.Pro_Titular}).ToList()

        If rbPantalla.Checked Then
            If trozasStock.Checked Then ''GTF
                Dim r As New GTFOp1
                r.DataSource = resul '.Where(Function(p) String.IsNullOrEmpty(p.Detalle.Ltd_Autogenerado))
                Dim rv As New frmReporte
                rv.Viewer.ReportSource = r
                rv.Show()
                rv.Viewer.RefreshReport()
            End If
            If trozasConsumidas.Checked Then ''GTF
                Dim r As New GTFOp1
                r.DataSource = resul.Where(Function(p) String.IsNullOrEmpty(p.Detalle.Ltd_Autogenerado))
                Dim rv As New frmReporte
                rv.Viewer.ReportSource = r
                rv.Show()
                rv.Viewer.RefreshReport()
            End If
            If trozasEspecie.Checked Then ''Especies
                Dim r As New ConsolidadoEspecies
                Dim lista As New List(Of ConsolidadoEspeciesReport)
                Dim res = resul.GroupBy(Function(p) p.Titular).ToList()
                For Each ti In res
                    Dim especies = resul.Where(Function(p) p.Titular = ti.Key).GroupBy(Function(g) g.Detalle.Ltd_Especie).Select(Function(f) New ConsolidadoEspeciesReport With {.Titular = ti.Key, .Especie = f.Key, .Trozas = f.Count(Function(s) s.Detalle.Ltd_Vol_M3), .Volumen = f.Sum(Function(s) s.Detalle.Ltd_Vol_M3)}).ToList()
                    For Each v In especies
                        lista.Add(v)
                    Next
                Next

                r.DataSource = lista

                Dim rv As New frmReporte
                ''pone el nombre del titular del titulo habilitante
                If Not String.IsNullOrEmpty(txtTitular.Text) Then
                    r.TitularTB.Value = txtTitular.Text
                Else
                    r.TitularTB.Value = "TODOS LOS TITULARES"
                End If
                ''pone la fecha de filtrado
                If Not String.IsNullOrEmpty(dtInicio.Text) Then
                    r.TextBox6.Value = dtInicio.Text
                    r.TextBox7.Value = dtFin.Text
                Else
                    r.TextBox6.Value = "Todo"
                    r.TextBox7.Value = "Todo"
                End If
                ''pone nombre a la zafra
                If Not String.IsNullOrEmpty(TxtZafra.Text) Then
                    r.TextBox5.Value = TxtZafra.Text
                Else
                    r.TextBox5.Value = "Todo"
                End If
                ''pone nombre a la pca
                If Not String.IsNullOrEmpty(txtPOA.Text) Then
                    r.TextBox9.Value = txtPOA.Text
                Else
                    r.TextBox9.Value = "Todo"
                End If
                ''pone nombre al propietario del producto
                rv.Viewer.ReportSource = r
                rv.Show()
                rv.Viewer.RefreshReport()
            End If

        End If

        If rbImpresora.Checked Then
            If trozasStock.Checked Then ''GTF
                Dim r As New GTFOp1
                r.DataSource = resul.Where(Function(p) String.IsNullOrEmpty(p.Detalle.Ltd_Autogenerado))
                Imprimir(r.Name)
            End If
            If trozasConsumidas.Checked Then ''GTF
                Dim r As New GTFOp1
                r.DataSource = resul.Where(Function(p) Not String.IsNullOrEmpty(p.Detalle.Ltd_Autogenerado))
                Imprimir(r.Name)
            End If
        End If



    End Sub

    Private Sub Imprimir(val As String)
        Dim reportName = val

        ' Obtain the settings of the default printer
        Dim printerSettings As New System.Drawing.Printing.PrinterSettings

        ' The standard print controller comes with no UI
        Dim standardPrintController As New System.Drawing.Printing.StandardPrintController

        ' Create a report source to pass the report to the report processor
        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()

        ' reportName is the Assembly Qualified Name of the report
        typeReportSource.TypeName = reportName

        ' Print the report using the custom print controller
        Dim reportProcessor As New Telerik.Reporting.Processing.ReportProcessor
        reportProcessor.PrintController = standardPrintController
        reportProcessor.PrintReport(typeReportSource, printerSettings)
    End Sub

    Private Sub btnGFT_Click(sender As System.Object, e As System.EventArgs) Handles btnGFT.Click
        Dim inicio = dtInicio.Value.AddDays(-1).Date
        Dim fin = dtFin.Value.Date

        Dim frm As New frmShowbrow
        frm.titulo = "Seleccione GTF"
        frm.t_tabla = "listatrozasc c, titulares t, zafrasypoas z"
        frm.t_campos = " distinct Lt_Nrogtf,Lt_fecha"
        frm.t_donde = "c.Lt_Poa_Id = z.Zyp_id and c.Lt_Titular_id = t.Pro_id and t.Pro_Titular = '" + txtTitular.Text + "' and z.Zyp_Zafra like '%" + TxtZafra.Text + "%'" + IIf(String.IsNullOrWhiteSpace(txtPOA.Text), "", "and z.Zyp_Poa = '" + txtPOA.Text + "'") + " and " +
                    "Lt_Fecha > '" + inicio.Year.ToString() + "-" + inicio.Month.ToString() + "-" + inicio.Day.ToString() + "' and " + " Lt_Fecha < '" + fin.Year.ToString() + "-" + fin.Month.ToString() + "-" + fin.Day.ToString() + "'"
        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Nro. GTF", "Fecha"}
        Dim anchos() As Integer = {100, 200}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)
        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog(Me)

        'Datos de Propietarios
        If frm.flag = True Then
            txtGTF.Text = frm.matColumnas(0)
        End If
    End Sub

    Private Sub btnPOA_Click(sender As System.Object, e As System.EventArgs) Handles btnPOA.Click
        Dim inicio = dtInicio.Value.AddDays(-1).Date
        Dim fin = dtFin.Value.Date

        Dim frm As New frmShowbrow
        frm.titulo = "Seleccione POA"
        frm.t_tabla = "listatrozasc c, zafrasypoas z"
        frm.t_campos = "distinct  z.Zyp_Poa, z.Zyp_id"
        frm.t_donde = "c.Lt_Poa_Id = z.Zyp_id and z.zyp_Zafra = '" + TxtZafra.Text + "' and " +
                      "c.Lt_Fecha > '" + inicio.Year.ToString() + "-" + inicio.Month.ToString() + "-" + inicio.Day.ToString() + "' and " + " c.Lt_Fecha < '" + fin.Year.ToString() + "-" + fin.Month.ToString() + "-" + fin.Day.ToString() + "'"

        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"PCA", "ID"}
        Dim anchos() As Integer = {100, 0}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)
        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog(Me)

        'Datos de Propietarios
        If frm.flag = True Then
            txtPOA.Text = frm.matColumnas(0)
        End If
    End Sub

    Private Sub btnDestinatario_Click(sender As System.Object, e As System.EventArgs) Handles btnDestinatario.Click
        Dim inicio = dtInicio.Value.AddDays(-1).Date
        Dim fin = dtFin.Value.Date

        Dim frm As New frmShowbrow
        frm.titulo = "Seleccione Destinatario"
        frm.t_tabla = "listatrozasc c, titulares d"
        frm.t_campos = "distinct d.Pro_id, d.Pro_Titular"
        frm.t_donde = "c.Lt_Destinatario_id = d.Pro_id and " +
                      "c.Lt_Fecha > '" + inicio.Year.ToString() + "-" + inicio.Month.ToString() + "-" + inicio.Day.ToString() + "' and " + " c.Lt_Fecha < '" + fin.Year.ToString() + "-" + fin.Month.ToString() + "-" + fin.Day.ToString() + "'"

        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"ID", "Destinatario"}
        Dim anchos() As Integer = {40, 200}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)
        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog(Me)

        'Datos de Propietarios
        If frm.flag = True Then
            txtDestinatario.Text = frm.matColumnas(1) 'Numero de Columna Se Empieza en 0
        End If
    End Sub

    Private Sub btnTitular_Click(sender As System.Object, e As System.EventArgs) Handles btnTitular.Click
        Dim inicio = dtInicio.Value.AddDays(-1).Date
        Dim fin = dtFin.Value.Date

        Dim frm As New frmShowbrow
        frm.titulo = "Seleccione Titular"
        frm.t_tabla = "listatrozasc c, titulares t"
        frm.t_campos = "distinct t.Pro_id, t.Pro_Titular"
        frm.t_donde = "c.Lt_Titular_id = t.Pro_id and " +
                      "c.Lt_Fecha > '" + inicio.Year.ToString() + "-" + inicio.Month.ToString() + "-" + inicio.Day.ToString() + "' and " + " c.Lt_Fecha < '" + fin.Year.ToString() + "-" + fin.Month.ToString() + "-" + fin.Day.ToString() + "'"

        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"ID", "Titular"}
        Dim anchos() As Integer = {40, 200}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)
        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog(Me)

        'Datos de Propietarios
        If frm.flag = True Then
            txtTitular.Text = frm.matColumnas(1)
        End If
    End Sub

    Private Sub btnPropietario_Click(sender As System.Object, e As System.EventArgs) Handles btnPropietario.Click
        Dim inicio = dtInicio.Value.AddDays(-1).Date
        Dim fin = dtFin.Value.Date

        Dim frm As New frmShowbrow
        frm.titulo = "Seleccione Propietario"
        frm.t_tabla = "listatrozasc c, titulares t"
        frm.t_campos = "distinct t.Pro_id, t.Pro_Titular"
        frm.t_donde = "c.Lt_Propietario_id = t.Pro_id and " +
                      "c.Lt_Fecha > '" + inicio.Year.ToString() + "-" + inicio.Month.ToString() + "-" + inicio.Day.ToString() + "' and " + " c.Lt_Fecha < '" + fin.Year.ToString() + "-" + fin.Month.ToString() + "-" + fin.Day.ToString() + "'"

        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"ID", "Propietario"}
        Dim anchos() As Integer = {40, 200}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)
        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog(Me)

        'Datos de Propietarios
        If frm.flag = True Then
            txtPropietario.Text = frm.matColumnas(1)
        End If
    End Sub

    Private Sub btnEspecie_Click(sender As System.Object, e As System.EventArgs) Handles btnEspecie.Click
        Dim inicio = dtInicio.Value.AddDays(-1).Date
        Dim fin = dtFin.Value.Date

        Dim frm As New frmShowbrow
        frm.titulo = "Seleccione Especie"
        frm.t_tabla = "listatrozasd d , listatrozasc c, especies e"
        frm.t_campos = "distinct e.Espe_id, ltd_especie"
        frm.t_donde = "e.Espe_NombreComun = d.ltd_especie and " +
                        "c.Lt_id = d.ltd_lt_id and " +
                        "c.Lt_Fecha > '" + inicio.Year.ToString() + "-" + inicio.Month.ToString() + "-" + inicio.Day.ToString() + "' and " + " c.Lt_Fecha < '" + fin.Year.ToString() + "-" + fin.Month.ToString() + "-" + fin.Day.ToString() + "'"

        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"ID", "Especie"}
        Dim anchos() As Integer = {40, 200}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)
        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog(Me)

        'Datos de Propietarios
        If frm.flag = True Then
            txtEspecie.Text = frm.matColumnas(1)
        End If
    End Sub

#Region """""""""""CODIGO PARA IMPRESION DE TROZAS RECEPCIONADAS EN PATIO DEL ASERRADERO"""""""""""""""""

    Private Sub btnImprimirRecepcion_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimirRecepcion.Click

        Dim db As New samadEntities
        Dim dt As New RecepcionTrozas
        Dim dini, dfin As String
        Dim Sql As String = ""
        Dim cn As New MySqlConnection(New fxSamad().GetCadenaConexionSamad())

        Dim fechafin = DateFin.Value.AddDays(-1)

        Try
            'convertir fecha 
            If RbLista_General.Checked Then
                dini = Convert.ToDateTime(dtpDesde.Value.Date).ToString("yyyy-MM-dd")
                dfin = Convert.ToDateTime(dtpHasta.Value.Date).ToString("yyyy-MM-dd")

                Sql = "SELECT F01_id,F01d_Id,F01d_F01_Id,F01d_Lote,Con_Descripcion,F01d_Titular,Zyp_Zafra,Zyp_Poa,F01d_Gtf,F01d_Correlativo,F01d_CodIndustria,F01d_Especie,F01d_D1,F01d_D2,F01d_D3,F01d_Vol_M3,F01d_D1c,F01d_D2c,F01d_D3c,F01d_Vol_M3c,F01d_Dm_pulgada,F01d_Long_pie,F01d_Vol_pt,F01d_Procedencia,F01d_Autogenerado,Estatus,F01d_Propietario,F01d_Abastecimiento,Periodo,F01_Fecha FROM vw_mostrar_trozas_recepcionadas where F01_Fecha >='" & dini & "' AND F01_Fecha <='" & dfin & "'"


                If TxNroContrato.Text <> "" Then
                    Sql = Sql + " AND Con_Descripcion ='" + TxNroContrato.Text + "'"
                End If
                If CboZafrasRec.Text <> "" Then
                    Sql = Sql + " AND Zyp_Zafra ='" + CboZafrasRec.Text + "'"
                End If
                If CboPoaRec.Text <> "" Then
                    Sql = Sql + " AND Zyp_Poa ='" + CboPoaRec.Text + "'"
                End If
                If CboLtoTrozas.Text <> "" Then
                    Sql = Sql + " AND F01d_Lote ='" + CboLtoTrozas.Text + "'"
                End If
                If CboEspecieRec.Text <> "" Then
                    Sql = Sql + " AND F01d_Especie ='" + CboEspecieRec.Text + "'"
                End If
                If CboGtfRec.Text <> "" Then
                    Sql = Sql + " AND F01d_Gtf ='" + CboGtfRec.Text + "'"
                End If


                Dim da As New MySqlDataAdapter(Sql, cn)
                da.Fill(dt, "RecepcionTrozas")

                If dt.Tables.Count > 0 Then

                    Dim cr As New CrMostrarTrozasRecepcionadas
                    cr.SetDataSource(dt)
                    Dim rp As New ReporteTrozasRecepcionadas
                    rp.CrystalReportViewer1.ReportSource = cr
                    rp.Show()
                    rp.Refresh()

                End If

            End If

            If RbResumen_List_G.Checked Then

                dini = Convert.ToDateTime(dtpDesde.Value.Date).ToString("yyyy-MM-dd")
                dfin = Convert.ToDateTime(dtpHasta.Value.Date).ToString("yyyy-MM-dd")


                Sql = "SELECT F01d_Lote,F01d_Titular,Con_Descripcion,F01d_Gtf,Zyp_Zafra,Zyp_Poa,estatus,F01d_Especie,COUNT(*) as cantidad_especie,SUM(F01d_Vol_M3) as F01d_Vol_M3,SUM(F01d_Vol_M3c) AS VOLM3C,SUM(F01d_Vol_pt) AS VOLPT,F01_Fecha FROM vw_mostrar_trozas_recepcionadas where F01_Fecha >='" & dini & "' AND F01_Fecha <='" & dfin & "'"

                If TxNroContrato.Text <> "" Then
                    Sql = Sql + " AND Con_Descripcion ='" + TxNroContrato.Text + "'"
                End If
                If CboZafrasRec.Text <> "" Then
                    Sql = Sql + " AND Zyp_Zafra ='" + CboZafrasRec.Text + "'"
                End If
                If CboPoaRec.Text <> "" Then
                    Sql = Sql + " AND Zyp_Poa ='" + CboPoaRec.Text + "'"
                End If
                If CboLtoTrozas.Text <> "" Then
                    Sql = Sql + " AND F01d_Lote ='" + CboLtoTrozas.Text + "'"
                End If
                If CboEspecieRec.Text <> "" Then
                    Sql = Sql + " AND F01d_Especie ='" + CboEspecieRec.Text + "'"
                End If
                If CboGtfRec.Text <> "" Then
                    Sql = Sql + " AND F01d_Gtf ='" + CboGtfRec.Text + "'"
                End If

                Sql = Sql + "GROUP BY F01d_Titular,Con_Descripcion,F01d_Especie"

                Dim da As New MySqlDataAdapter(Sql, cn)
                da.Fill(dt, "Resumen")

                If dt.Tables.Count > 0 Then

                    Dim cr As New CrResumen
                    cr.SetDataSource(dt)
                    Dim rp As New ReporteTrozasRecepcionadas
                    rp.CrystalReportViewer1.ReportSource = cr
                    rp.Show()
                    rp.Refresh()

                End If

            End If

            If RbListaGeneralStock.Checked Then

                dini = Convert.ToDateTime(dtpDesde.Value.Date).ToString("yyyy-MM-dd")
                dfin = Convert.ToDateTime(dtpHasta.Value.Date).ToString("yyyy-MM-dd")

                Sql = "SELECT F01_id,F01d_Id,F01d_F01_Id,F01d_Lote,Con_Descripcion,F01d_Titular,Zyp_Zafra,Zyp_Poa,F01d_Gtf,F01d_Correlativo,F01d_CodIndustria,F01d_Especie,F01d_D1,F01d_D2,F01d_D3,F01d_Vol_M3,F01d_D1c,F01d_D2c,F01d_D3c,F01d_Vol_M3c,F01d_Dm_pulgada,F01d_Long_pie,F01d_Vol_pt,F01d_Procedencia,F01d_Autogenerado,Estatus,F01d_Propietario,F01d_Abastecimiento,Periodo,F01_Fecha FROM vw_mostrar_trozas_recepcionadas where estatus=0 and F01_Fecha >='" & dini & "' AND F01_Fecha <='" & dfin & "'"


                If TxNroContrato.Text <> "" Then
                    Sql = Sql + " AND Con_Descripcion ='" + TxNroContrato.Text + "'"
                End If
                If CboZafrasRec.Text <> "" Then
                    Sql = Sql + " AND Zyp_Zafra ='" + CboZafrasRec.Text + "'"
                End If
                If CboPoaRec.Text <> "" Then
                    Sql = Sql + " AND Zyp_Poa ='" + CboPoaRec.Text + "'"
                End If
                If CboLtoTrozas.Text <> "" Then
                    Sql = Sql + " AND F01d_Lote ='" + CboLtoTrozas.Text + "'"
                End If
                If CboEspecieRec.Text <> "" Then
                    Sql = Sql + " AND F01d_Especie ='" + CboEspecieRec.Text + "'"
                End If
                If CboGtfRec.Text <> "" Then
                    Sql = Sql + " AND F01d_Gtf ='" + CboGtfRec.Text + "'"
                End If

                'Sql = Sql + "GROUP BY F01d_Titular,Con_Descripcion,F01d_Especie"

                Dim da As New MySqlDataAdapter(Sql, cn)
                da.Fill(dt, "RecepcionTrozas")

                If dt.Tables.Count > 0 Then

                    Dim cr As New CrMostrarTrozasRecepcionadas
                    cr.SetDataSource(dt)
                    Dim rp As New ReporteTrozasRecepcionadas
                    rp.CrystalReportViewer1.ReportSource = cr
                    rp.Show()
                    rp.Refresh()

                End If
            End If

            If RbListaGenStockRes.Checked Then
                dini = Convert.ToDateTime(dtpDesde.Value.Date).ToString("yyyy-MM-dd")
                dfin = Convert.ToDateTime(dtpHasta.Value.Date).ToString("yyyy-MM-dd")


                Sql = "SELECT F01d_Lote,F01d_Titular,Con_Descripcion,F01d_Gtf,Zyp_Zafra,Zyp_Poa,estatus,F01d_Especie,COUNT(*) as cantidad_especie,SUM(F01d_Vol_M3) as F01d_Vol_M3,SUM(F01d_Vol_M3c) AS VOLM3C,SUM(F01d_Vol_pt) AS VOLPT,F01_Fecha FROM vw_mostrar_trozas_recepcionadas where Estatus=0 and F01_Fecha >='" & dini & "' AND F01_Fecha <='" & dfin & "'"

                If TxNroContrato.Text <> "" Then
                    Sql = Sql + " AND Con_Descripcion ='" + TxNroContrato.Text + "'"
                End If
                If CboZafrasRec.Text <> "" Then
                    Sql = Sql + " AND Zyp_Zafra ='" + CboZafrasRec.Text + "'"
                End If
                If CboPoaRec.Text <> "" Then
                    Sql = Sql + " AND Zyp_Poa ='" + CboPoaRec.Text + "'"
                End If
                If CboLtoTrozas.Text <> "" Then
                    Sql = Sql + " AND F01d_Lote ='" + CboLtoTrozas.Text + "'"
                End If
                If CboEspecieRec.Text <> "" Then
                    Sql = Sql + " AND F01d_Especie ='" + CboEspecieRec.Text + "'"
                End If
                If CboGtfRec.Text <> "" Then
                    Sql = Sql + " AND F01d_Gtf ='" + CboGtfRec.Text + "'"
                End If

                Sql = Sql + "GROUP BY F01d_Titular,Con_Descripcion,F01d_Especie"

                Dim da As New MySqlDataAdapter(Sql, cn)
                da.Fill(dt, "Resumen")

                If dt.Tables.Count > 0 Then

                    Dim cr As New CrResumen
                    cr.SetDataSource(dt)
                    Dim rp As New ReporteTrozasRecepcionadas
                    rp.CrystalReportViewer1.ReportSource = cr
                    rp.Show()
                    rp.Refresh()

                End If

            End If

        Catch ex As Exception

        End Try



    End Sub

#Region """""LENAMOS LOS COMBOBOX PARA LOS PARAMETROS DE FILTRADO EN RECEPCION DE TROZAS"""""""""

    Private Sub LlenarComboTitular()
        Dim db As New samadEntities
        CboTitular.DataSource = (From pe In db.vw_mostrar_trozas_recepcionadas Group pe By pe.F01d_Titular Into grupo = Group Select F01d_Titular)
        CboTitular.SelectedItem = Nothing
    End Sub

    Private Sub LlenarTxContrato(ByVal ValorCombo As String)
        Dim db As New samadEntities

        If String.IsNullOrEmpty(ValorCombo) = False Then

            'Dim Contrato = db.vw_mostrar_trozas_recepcionadas.Where(Function(x) x.F01d_Titular = ValorCombo).Select(Function(y) y.Con_Descripcion).FirstOrDefault()
            Dim Contrato = (From pes In db.vw_mostrar_trozas_recepcionadas Where pes.F01d_Titular = ValorCombo Group pes By pes.Con_Descripcion Into grupo = Group Select Con_Descripcion).First()
            TxNroContrato.Text = Contrato

        Else
            TxNroContrato.Clear()

        End If
    End Sub

    Private Sub LlenarZafra()
        Dim db As New samadEntities
        CboZafrasRec.DataSource = (From pex In db.vw_mostrar_trozas_recepcionadas Group pex By pex.Zyp_Zafra Into grupo = Group Select Zyp_Zafra)
        CboZafrasRec.SelectedItem = Nothing
    End Sub
    Private Sub LlenarPoa()
        Dim db As New samadEntities
        CboPoaRec.DataSource = (From pel In db.vw_mostrar_trozas_recepcionadas Group pel By pel.Zyp_Poa Into grupo = Group Select Zyp_Poa)
        CboPoaRec.SelectedItem = Nothing
    End Sub

    Private Sub LlenarLtoTrozas()
        Dim db As New samadEntities
        CboLoteTroza.DataSource = (From pe In db.vw_mostrar_trozas_recepcionadas Group pe By pe.F01d_Lote Into grupo = Group Select F01d_Lote)
        CboLoteTroza.SelectedItem = Nothing
    End Sub

    Private Sub LlenarNroGtf()
        Dim db As New samadEntities
        CboGtfRec.DataSource = (From pe In db.vw_mostrar_trozas_recepcionadas Group pe By pe.F01d_Gtf Into grupo = Group Select F01d_Gtf)
        CboGtfRec.SelectedItem = Nothing
    End Sub
    Private Sub LlenarEspecieRec()
        Dim db As New samadEntities
        CboEspecieRec.DataSource = (From pe In db.vw_mostrar_trozas_recepcionadas Group pe By pe.F01d_Especie Into grupo = Group Select F01d_Especie)
        CboEspecieRec.SelectedItem = Nothing
    End Sub
   
    '''PROGRAMAR EL EVENTO CLIC PARA LOS COMBOBOX 

    Private Sub CboTitular_Click(sender As System.Object, e As System.EventArgs) Handles CboTitular.Click
        llenartitulares()
    End Sub

    Private Sub CboZafrasRec_Click(sender As System.Object, e As System.EventArgs) Handles CboZafrasRec.Click
        LlenarZafra()
    End Sub

    Private Sub CboPoaRec_Click(sender As System.Object, e As System.EventArgs) Handles CboPoaRec.Click
        LlenarPoa()
    End Sub

    Private Sub CboltoTrozas_Click(sender As System.Object, e As System.EventArgs) Handles CboLtoTrozas.Click
        LlenarLtoTrozas()
    End Sub

    Private Sub CboGtfRec_Click(sender As System.Object, e As System.EventArgs) Handles CboGtfRec.Click
        LlenarNroGtf()
    End Sub

    Private Sub CboEspecieRec_Click(sender As System.Object, e As System.EventArgs) Handles CboEspecieRec.Click
        LlenarEspecieRec()
    End Sub

    Private Sub CboTitular_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CboTitular.SelectedIndexChanged
        If CboTitular.Text.Length > 0 Then
            LlenarTxContrato(CboTitular.Text)
        Else
            TxNroContrato.Text = ""
        End If
    End Sub

#End Region
#End Region

#Region """""""""CODIGO PARA IMPRESION DE MODULO DE TROZAS ASERRADAS"""""""""""""""""""""""""""""

    Private Sub intImprimir_Click(sender As System.Object, e As System.EventArgs) Handles intImprimir.Click

        Dim db As New samadEntities

        Dim resul = (From d In db.vw_mostrar_trozas_aserradas
                    Where
                    d.F02_Fecha >= intDesde.Value And
                    d.F02_Fecha <= intHasta.Value And
                    d.Pro_Titular.Contains(CboTitularAs.Text) And
                    d.Zyp_Zafra.Contains(CboZafraAs.Text) And
                    d.Zyp_Poa.Contains(CboPCAas.Text) And
                    d.Aserradero.Contains(CboIndAserrio.Text) And
                    d.F02d_Especie.Contains(CboEspecieAs.Text) And
                    d.F02_NroDoc.Contains(CboListaAserrad.Text) And
                    d.F02d_Lote.Contains(CboLoteTroza.Text)
                    Select New Reporte03 With {.Detalle = d,
                                               .Aserrio = d.Aserradero,
                                               .Periodo = d.f02_periodo,
                                               .Proceso = d.Proc_descripcion
                                              }).Distinct().ToList()
        Dim consumidas = (From d In db.vw_mostrar_trozas_aserradas
                        Where
                        d.F02_Fecha >= intDesde.Value And
                        d.F02_Fecha <= intHasta.Value And
                        d.Pro_Titular.Contains(CboTitularAs.Text) And
                        d.Con_Descripcion.Contains(TxContartoAs.Text) And
                        d.Zyp_Zafra.Contains(CboZafraAs.Text) And
                        d.Zyp_Poa.Contains(CboPCAas.Text) And
                        d.Aserradero.Contains(CboIndAserrio.Text) And
                        d.F02d_Especie.Contains(CboEspecieAs.Text) And
                        d.F02_NroDoc.Contains(CboListaAserrad.Text) And
                        d.F02d_Lote.Contains(CboLoteTroza.Text)
                        Select New Reporte03 With {.Detalle = d,
                                                    .Aserrio = d.Aserradero,
                                                    .Periodo = d.f02_periodo,
                                                    .Proceso = d.Proc_descripcion
                                                    }).Distinct().ToList()


        'For Each a In consumidas
        '    Dim r = resul.FirstOrDefault(Function(p) p.Detalle.F02d_Id = a.Detalle.F02d_Id)
        '    resul.Remove(r)
        'Next

        If rbPantalla.Checked Then
            If intStock.Checked Then ''Documento
                Dim r As New ReporteGeneralTrozasAserradas
                r.DataSource = resul
                Dim rv As New frmReporte

                ''pone el nombre del titular del titulo habilitante
                If Not String.IsNullOrEmpty(CboTitularAs.Text) Then
                    r.TxTitular.Value = CboTitularAs.Text
                Else
                    r.TxTitular.Value = "TODOS LOS TITULARES DE T. HABILITANTES"
                End If
                ''pone la fecha de filtrado
                If Not String.IsNullOrEmpty(intDesde.Text) Then
                    r.TxFechaIni.Value = intDesde.Text
                    r.TxFechaFin.Value = intHasta.Text
                Else
                    r.TxFechaFin.Value = "Todo"
                    r.TxFechaFin.Value = "Todo"
                End If
                ''pone el nombre del nro. de contrato
                If Not String.IsNullOrEmpty(TxContartoAs.Text) Then
                    r.TxContrato.Value = TxContartoAs.Text
                Else
                    r.TxContrato.Value = "Todo los Nro. de Contratos"
                End If
                ''pone nombre a la zafra
                If Not String.IsNullOrEmpty(CboZafraAs.Text) Then
                    r.TxZafra.Value = CboZafraAs.Text
                Else
                    r.TxZafra.Value = "Todo"
                End If
                ''pone nombre a la pca
                If Not String.IsNullOrEmpty(CboPCAas.Text) Then
                    r.TxPca.Value = CboPCAas.Text
                Else
                    r.TxPca.Value = "Todo"
                End If
                ''pone número de lista de aserrío
                If Not String.IsNullOrEmpty(CboListaAserrad.Text) Then
                    r.TxListaAserrad.Value = CboListaAserrad.Text
                Else
                    r.TxListaAserrad.Value = "Todo"
                End If
                ''pone número de lote de trozas
                If Not String.IsNullOrEmpty(CboLoteTroza.Text) Then
                    r.TxLoteTroza.Value = CboLoteTroza.Text
                Else
                    r.TxLoteTroza.Value = "Todo"
                End If

                rv.Viewer.ReportSource = r
                rv.Show()
                rv.Viewer.RefreshReport()

            End If

            If intConsumidas.Checked Then ''Aserrio
                Dim r As New Resumen_Trozas_Aserradas
                Dim lista As New List(Of Resumen_Trozas_AserradasReport)
                Dim rest = consumidas.GroupBy(Function(p) p.Aserrio).ToList()

                For Each te In rest
                    Dim Resumen = consumidas.Where(Function(p) p.Aserrio = te.Key).GroupBy(Function(g) g.Detalle.F02d_Especie).Select(Function(f) New Resumen_Trozas_AserradasReport With {.Aserradero = te.Key, .Especie = f.Key, .T_trozas = f.Count(Function(s) s.Detalle.F02d_Volm3), .Vol_m3_Gtf = f.Sum(Function(s) s.Detalle.F02d_Volm3), .Vol_m3_CA = f.Sum(Function(s) s.Detalle.f02d_volm3c), .Vol_pt = f.Sum(Function(s) s.Detalle.f02d_vol_pt)})
                    For Each v In Resumen
                        lista.Add(v)
                    Next
                Next


                r.DataSource = lista
                Dim rv As New frmReporte

                ''pone el nombre del titular del titulo habilitante
                If Not String.IsNullOrEmpty(CboTitularAs.Text) Then
                    r.TxTitular.Value = CboTitularAs.Text
                Else
                    r.TxTitular.Value = "TODOS LOS TITULARES DE T. HABILITANTES"
                End If
                ''pone la fecha de filtrado
                If Not String.IsNullOrEmpty(intDesde.Text) Then
                    r.TxFechaIni.Value = intDesde.Text
                    r.TxFechaFin.Value = intHasta.Text
                Else
                    r.TxFechaFin.Value = "Todo"
                    r.TxFechaFin.Value = "Todo"
                End If
                ''pone el nombre del nro. de contrato
                If Not String.IsNullOrEmpty(TxContartoAs.Text) Then
                    r.TxContrato.Value = TxContartoAs.Text
                Else
                    r.TxContrato.Value = "Todo los Nro. de Contratos"
                End If
                ''pone nombre a la zafra
                If Not String.IsNullOrEmpty(CboZafraAs.Text) Then
                    r.TxZafra.Value = CboZafraAs.Text
                Else
                    r.TxZafra.Value = "Todo"
                End If
                ''pone nombre a la pca
                If Not String.IsNullOrEmpty(CboPCAas.Text) Then
                    r.TxPca.Value = CboPCAas.Text
                Else
                    r.TxPca.Value = "Todo"
                End If
                ''pone número de lista de aserrío
                If Not String.IsNullOrEmpty(CboListaAserrad.Text) Then
                    r.TxListaAserrad.Value = CboListaAserrad.Text
                Else
                    r.TxListaAserrad.Value = "Todo"
                End If
                ''pone número de lote de trozas
                If Not String.IsNullOrEmpty(CboLoteTroza.Text) Then
                    r.TxLoteTroza.Value = CboLoteTroza.Text
                Else
                    r.TxLoteTroza.Value = "Todo"
                End If

                rv.Viewer.ReportSource = r
                rv.Show()
                rv.Viewer.RefreshReport()
            End If
        End If

        If rbImpresora.Checked Then
            If intStock.Checked Then ''Documento
                Dim r As New ReporteGeneralTrozasAserradas
                r.DataSource = resul
                Imprimir(r.Name)
            End If
            If intConsumidas.Checked Then ''Aserrio
                Dim r As New Resumen_Trozas_Aserradas
                Dim lista As New List(Of Resumen_Trozas_AserradasReport)
                Dim rest = consumidas.GroupBy(Function(p) p.Aserrio).ToList()

                For Each te In rest
                    Dim Resumen = consumidas.Where(Function(p) p.Aserrio = te.Key).GroupBy(Function(g) g.Detalle.F02d_Especie).Select(Function(f) New Resumen_Trozas_AserradasReport With {.Aserradero = te.Key, .Especie = f.Key, .T_trozas = f.Count(Function(s) s.Detalle.F02d_Volm3), .Vol_m3_Gtf = f.Sum(Function(s) s.Detalle.F02d_Volm3), .Vol_m3_CA = f.Sum(Function(s) s.Detalle.f02d_volm3c), .Vol_pt = f.Sum(Function(s) s.Detalle.f02d_vol_pt)})
                    For Each v In Resumen
                        lista.Add(v)
                    Next
                Next
                r.DataSource = lista
                Imprimir(r.Name)
            End If
        End If
    End Sub


#Region """""""""""""""LLENAR PARAMETROS DE FILTRADO PARA IMPRESION DE TROZAS ASERRAADAS"""""""""""

    Private Sub intHasta_ValueChanged(sender As System.Object, e As System.EventArgs) Handles intHasta.ValueChanged
        llenartitularAs()
        'llenaIndAserrio()
    End Sub

    Private Sub intDesde_ValueChanged(sender As System.Object, e As System.EventArgs) Handles IntDesde.ValueChanged
        llenartitularAs()
        'llenaIndAserrio()
    End Sub
    Private Sub llenartitularAs()
        Dim db As New samadEntities
        CboTitularAs.DataSource = (From t In db.titulares
                                       From f In db.formato02_det
                                       From g In db.listatrozasc
                                       From d In db.formato02
                                       From l In db.contratos
                                       Where
                                       f.F02d_GTF = g.Lt_Nrogtf And
                                       g.Lt_Titular_Id = t.Pro_Id And
                                       d.F02_Fecha >= IntDesde.Value And
                                       d.F02_Fecha <= intHasta.Value
                                       Select New With {.id = t.Pro_Id, .titular = t.Pro_Titular}).Distinct().ToList()

        CboTitularAs.SelectedItem = Nothing

    End Sub
    Private Sub llenarzafraAs()
        Dim db As New samadEntities
        CboZafraAs.DataSource = (From pex In db.vw_mostrar_trozas_aserradas Where pex.Aserradero.Contains(CboIndAserrio.Text) And pex.Pro_Titular.Contains(CboTitularAs.Text) And pex.F02_Fecha >= intDesde.Value And pex.F02_Fecha <= intHasta.Value Group pex By pex.Zyp_Zafra Into grupo = Group Select Zyp_Zafra)
        CboZafraAs.SelectedItem = Nothing
    End Sub
    Private Sub llenarpcaAs()
        Dim db As New samadEntities
        CboPCAas.DataSource = (From pel In db.vw_mostrar_trozas_aserradas Where pel.Aserradero.Contains(CboIndAserrio.Text) And pel.Pro_Titular.Contains(CboTitularAs.Text) And pel.F02_Fecha >= intDesde.Value And pel.F02_Fecha <= intHasta.Value Group pel By pel.Zyp_Poa Into grupo = Group Select Zyp_Poa)
        CboPCAas.SelectedItem = Nothing
    End Sub
    Private Sub llenaIndAserrio()
        Dim db As New samadEntities
        CboIndAserrio.DataSource = (From t In db.titulares
                                      From f In db.formato02
                                      From p In db.procesos
                                      Where
                                      f.F02_Proc_id = p.Proc_id And
                                      p.Pro_id = t.Pro_Id And
                                      f.F02_Fecha >= intDesde.Value And
                                      f.F02_Fecha <= intHasta.Value
                                      Select New With {.id = t.Pro_Id, .aserradero = t.Pro_Titular}).Distinct().ToList
        CboIndAserrio.SelectedItem = Nothing
    End Sub
    Private Sub llenarespecieAs()
        Dim db As New samadEntities
        CboEspecieAs.DataSource = (From pe In db.vw_mostrar_trozas_aserradas Where pe.Aserradero.Contains(CboIndAserrio.Text) And pe.Pro_Titular.Contains(CboTitularAs.Text) And pe.F02_Fecha >= intDesde.Value And pe.F02_Fecha <= intHasta.Value Group pe By pe.F02d_Especie Into grupo = Group Select F02d_Especie)
        CboEspecieAs.SelectedItem = Nothing
    End Sub
    Private Sub nroDocumetoAserrio()
        Dim db As New samadEntities
        CboListaAserrad.DataSource = (From pel In db.vw_mostrar_trozas_aserradas Where pel.Aserradero.Contains(CboIndAserrio.Text) And pel.Pro_Titular.Contains(CboTitularAs.Text) And pel.F02_Fecha >= intDesde.Value And pel.F02_Fecha <= intHasta.Value Group pel By pel.F02_NroDoc, pel.f02_periodo Into group = Group Select F02_NroDoc)
        CboListaAserrad.SelectedItem = Nothing
    End Sub
    Private Sub llenarlotetrozasAs()
        Dim db As New samadEntities
        CboLtoTrozas.DataSource = (From pe In db.vw_mostrar_trozas_aserradas Where pe.Aserradero.Contains(CboIndAserrio.Text) And pe.Pro_Titular.Contains(CboTitularAs.Text) And pe.F02_Fecha >= intDesde.Value And pe.F02_Fecha <= intHasta.Value Group pe By pe.F02d_Lote Into grupo = Group Select F02d_Lote)
        CboLtoTrozas.SelectedItem = Nothing
    End Sub
    '''*************************Llenar los Combobox*************************************
    Private Sub LlenarTxContratoAs(ByVal ValorCombo As String)
        Dim db As New samadEntities

        If String.IsNullOrEmpty(ValorCombo) = False Then

            'Dim ContratoAs = db.vw_mostrar_trozas_aserradas.Where(Function(x) x.Pro_Titular = ValorCombo).Select(Function(y) y.Con_Descripcion).FirstOrDefault()
            Dim ContratoAs = (From pes In db.vw_mostrar_trozas_aserradas Where pes.Pro_Titular = ValorCombo Group pes By pes.Con_Descripcion Into grupo = Group Select Con_Descripcion).First()
            TxContartoAs.Text = ContratoAs
        Else
            TxContartoAs.Clear()
        End If
    End Sub
    Private Sub CboTitularAs_Click(sender As System.Object, e As System.EventArgs) Handles CboTitularAs.Click
        llenartitularAs()
    End Sub

    Private Sub CboPCAas_Click(sender As System.Object, e As System.EventArgs) Handles CboPCAas.Click
        llenarpcaAs()
    End Sub

    Private Sub CboEspecieAs_Click(sender As System.Object, e As System.EventArgs) Handles CboEspecieAs.Click
        llenarespecieAs()
    End Sub

    Private Sub CboListaAserrad_Click(sender As System.Object, e As System.EventArgs) Handles CboListaAserrad.Click
        nroDocumetoAserrio()
    End Sub

    Private Sub CboLoteTroza_Click(sender As System.Object, e As System.EventArgs) Handles CboLoteTroza.Click
        LlenarLtoTrozas()
    End Sub

    Private Sub CboIndAserrio_Click(sender As System.Object, e As System.EventArgs) Handles CboIndAserrio.Click
        llenaIndAserrio()
    End Sub

    Private Sub CboTitularAs_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CboTitularAs.SelectedIndexChanged
        If CboTitularAs.Text.Length > 0 Then
            LlenarTxContratoAs(CboTitularAs.Text)
        Else
            TxContartoAs.Text = ""
        End If
        'llenarzafraAs()
        'llenarpcaAs()
        'llenarespecieAs()
        'llenarlotetrozasAs()
        'llenarlotetrozasAs()
    End Sub

#End Region

#End Region


#Region """""""CODIGO PA IMPRESION DE MODULO PRODUCCIÓN"""""""""""""""""""""""""""""""""""

    Private Sub proPrintBt_Click(sender As System.Object, e As System.EventArgs) Handles proPrintBt.Click
        Dim db As New samadEntities

        Dim general = (From f In db.vw_mostrar_aserrio_total_prod
                                Where
                                f.F04_Fecha >= proDesdeDP.Value And
                                f.F04_Fecha <= proHastaDP.Value And
                                f.Titular.Contains(CbTitularPro.Text) And
                                f.Zafra.Contains(CbZafraPro.Text) And
                                f.Pca.Contains(CbPcaPro.Text) And
                                f.Especie.Contains(CbEspeciePro.Text) And
                                f.Nro_Lot_As.Contains(CbListaAserrioPro.Text) And
                                f.Lote_troza.Contains(CbLoteTrozasPro.Text) And
                                f.Nom_Producto.Contains(CbProductoPro.Text) And
                                f.Objetivo_producto.Contains(CbObjProducPro.Text) And
                                f.F04_TipoConteo.Contains(CbMaterialPro.Text) And
                                f.Nom_Aserradero.Contains(CbNombreAserradPro.Text) And
                                f.periodo.Contains(CbPeriodoPro.Text) And
                                f.Tur_Descrip.Contains(CbTurnoPro.Text)
                                Select New Reporte04 With {.Detalle = f}).Distinct().ToList()

        If proPantallaRB.Checked Then
            If proDocumentoRB.Checked Then ''Documento
                Dim r As New Produccion_general
                r.DataSource = general
                Dim rv As New frmReporte

                ''pone el nombre del titular del titulo habilitante
                If Not String.IsNullOrEmpty(CboTitularAs.Text) Then
                    r.TxTitular.Value = CbTitularPro.Text
                Else
                    r.TxTitular.Value = "TODOS LOS TITULARES DE T. HABILITANTES"
                End If
                ''pone la fecha de filtrado
                If Not String.IsNullOrEmpty(proDesdeDP.Text) Then
                    r.TxFechaIni.Value = proDesdeDP.Text
                    r.TxFechaFin.Value = proHastaDP.Text
                Else
                    r.TxFechaIni.Value = "Todo"
                    r.TxFechaFin.Value = "Todo"
                End If
                ''pone el nombre del nro. de contrato
                If Not String.IsNullOrEmpty(TxContratoPro.Text) Then
                    r.TxContrato.Value = TxContratoPro.Text
                Else
                    r.TxContrato.Value = "Todo los Nro. de Contratos"
                End If
                ''pone nombre a la zafra
                If Not String.IsNullOrEmpty(CbZafraPro.Text) Then
                    r.TxZafra.Value = CbZafraPro.Text
                Else
                    r.TxZafra.Value = "Todo"
                End If
                ''pone nombre a la pca
                If Not String.IsNullOrEmpty(CbPcaPro.Text) Then
                    r.TxPca.Value = CbPcaPro.Text
                Else
                    r.TxPca.Value = "Todo"
                End If
                ''pone nombre de la especie
                If Not String.IsNullOrEmpty(CbEspeciePro.Text) Then
                    r.TxtEspeciePro.Value = CbEspeciePro.Text
                Else
                    r.TxtEspeciePro.Value = "Todas las especies"
                End If
                ''pone número de lista de aserrío
                If Not String.IsNullOrEmpty(CbListaAserrioPro.Text) Then
                    r.TxListaAserrad.Value = CbListaAserrioPro.Text
                Else
                    r.TxListaAserrad.Value = "Todo"
                End If
                ''pone número de lote de trozas
                If Not String.IsNullOrEmpty(CbLoteTrozasPro.Text) Then
                    r.TxLoteTroza.Value = CbLoteTrozasPro.Text
                Else
                    r.TxLoteTroza.Value = "Todo"
                End If
                ''pone nombre del producto
                If Not String.IsNullOrEmpty(CbProductoPro.Text) Then
                    r.TxProductoPro.Value = CbProductoPro.Text
                Else
                    r.TxProductoPro.Value = "Todo"
                End If
                ''pone Objetivo del Producto
                If Not String.IsNullOrEmpty(CbObjProducPro.Text) Then
                    r.TxObjProductoPro.Value = CbObjProducPro.Text
                Else
                    r.TxObjProductoPro.Value = "Todo"
                End If
                ''pone tipo de material
                If Not String.IsNullOrEmpty(CbMaterialPro.Text) Then
                    r.TxTipoMaterialPro.Value = CbMaterialPro.Text
                Else
                    r.TxTipoMaterialPro.Value = "Todo"
                End If
                ''pone nombre del aserradero
                If Not String.IsNullOrEmpty(CbNombreAserradPro.Text) Then
                    r.TxAserraderoPro.Value = CbNombreAserradPro.Text
                Else
                    r.TxAserraderoPro.Value = "Todo"
                End If
                ''pone periodo de operación
                If Not String.IsNullOrEmpty(CbPeriodoPro.Text) Then
                    r.TxPeriodoPro.Value = CbPeriodoPro.Text
                Else
                    r.TxPeriodoPro.Value = "Todo"
                End If
                ''pone turno de la producción
                If Not String.IsNullOrEmpty(CbTurnoPro.Text) Then
                    r.TxTurnoPro.Value = CbTurnoPro.Text
                Else
                    r.TxTurnoPro.Value = "Todo"
                End If

                rv.Viewer.ReportSource = r
                rv.Show()
                rv.Viewer.RefreshReport()

            End If
        End If


    End Sub

#Region """""RELLENAR PARAMETROS DE FILTRADO"""""""""""""""""""

    Private Sub proDesdeDP_ValueChanged(sender As System.Object, e As System.EventArgs) Handles proDesdeDP.ValueChanged
        LlenarTitularPro()
        llenarZafraPro()
        LlenarPcaPro()
        LlenarEspeciePro()
    End Sub

    Private Sub proHastaDP_ValueChanged(sender As System.Object, e As System.EventArgs) Handles proHastaDP.ValueChanged
        LlenarTitularPro()
        llenarZafraPro()
        LlenarPcaPro()
        LlenarEspeciePro()
    End Sub
    '''Llenar Cbo de Ttiulo Habilitante''''''''''''''''''''''''''''''''''''''
    Private Sub LlenarTitularPro()
        Dim db As New samadEntities
        ''''''''''Llenar combobox de titular y Contrato'''''''''''''''''''''''''''''''''''

        CbTitularPro.DataSource = (From f In db.vw_mostrar_aserrio_total_prod
                                            Where
                                            f.F04_Fecha >= proDesdeDP.Value And
                                            f.F04_Fecha <= proHastaDP.Value
                                            Group f By f.Titular, f.Con_Descripcion Into Group = Group Select Titular).Distinct().ToList()
        CbTitularPro.SelectedItem = Nothing
    End Sub

    '''Consulta para de nro de contrato de produccion'''''''''''''''''''''''''
    Private Sub LlenarTxContratoPro(ByVal ValorCombo As String)
        Dim db As New samadEntities

        If String.IsNullOrEmpty(ValorCombo) = False Then

            'Dim Contrato = db.vw_mostrar_trozas_recepcionadas.Where(Function(x) x.F01d_Titular = ValorCombo).Select(Function(y) y.Con_Descripcion).FirstOrDefault()
            Dim ContratoPro = (From pes In db.vw_mostrar_aserrio_total_prod Where pes.Titular = ValorCombo Group pes By pes.Con_Descripcion Into grupo = Group Select Con_Descripcion).First()
            TxContratoPro.Text = ContratoPro
        Else
            TxContratoPro.Clear()
        End If
    End Sub

    Private Sub CbTitularPro_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbTitularPro.SelectedIndexChanged
        If CbTitularPro.Text.Length > 0 Then
            LlenarTxContratoPro(CbTitularPro.Text)
        Else
            TxContratoPro.Text = ""
        End If
        llenarZafraPro()
        LlenarPcaPro()
        LlenarEspeciePro()
    End Sub
    Private Sub llenarZafraPro()
        Dim db As New samadEntities

        '''''''''''''Llenar Combobox de Zafra''''''''''''''''''''

        Dim Zaf = (From f In db.vw_mostrar_aserrio_total_prod
                                        Where
                                        f.F04_Fecha >= proDesdeDP.Value And
                                        f.F04_Fecha <= proHastaDP.Value And
                                        f.Titular.Contains(CbObjProducPro.Text)
                                        Group f By f.Zafra Into Group = Group Select Zafra).Distinct().ToList()
        CbZafraPro.DataSource = Zaf
        CbZafraPro.SelectedItem = Nothing
    End Sub
    Private Sub LlenarPcaPro()
        Dim db As New samadEntities
        ''''''''''''''Llenar Combobox de nro de pca'''''''''''''''''''''''''''''

        CbPcaPro.DataSource = (From f In db.vw_mostrar_aserrio_total_prod
                                        Where
                                        f.F04_Fecha >= proDesdeDP.Value And
                                        f.F04_Fecha <= proHastaDP.Value And
                                        f.Titular.Contains(CbTitularPro.Text)
                                        Group f By f.Pca Into Group = Group Select Pca).Distinct().ToList()
        CbPcaPro.SelectedItem = Nothing
    End Sub
    Private Sub LlenarEspeciePro()
        Dim db As New samadEntities
        ''''''''''''''''Llenar Combobox de nombre de Especie''''''''''''''''''''

        CbEspeciePro.DataSource = (From f In db.vw_mostrar_aserrio_total_prod
                                Where
                                f.F04_Fecha >= proDesdeDP.Value And
                                f.F04_Fecha <= proHastaDP.Value And
                                f.Titular.Contains(CbTitularPro.Text)
                                Group f By f.Especie Into Group = Group Select Especie).Distinct().ToList()
        CbEspeciePro.SelectedItem = Nothing
    End Sub
    Private Sub LlenarNroLoteAserrioPro()
        Dim db As New samadEntities
        CbListaAserrioPro.DataSource = (From f In db.vw_mostrar_aserrio_total_prod
                                                Where
                                                f.F04_Fecha >= proDesdeDP.Value And
                                                f.F04_Fecha <= proHastaDP.Value And
                                                f.Titular.Contains(CbTitularPro.Text)
                                                Group f By f.Nro_Lot_As Into Group = Group Select Nro_Lot_As).Distinct().ToList()
        CbListaAserrioPro.SelectedItem = Nothing
    End Sub
    Private Sub LlenarNroLoteTrozasPro()
        Dim db As New samadEntities
        CbLoteTrozasPro.DataSource = (From f In db.vw_mostrar_aserrio_total_prod
                                                Where
                                                f.F04_Fecha >= proDesdeDP.Value And
                                                f.F04_Fecha <= proHastaDP.Value And
                                                f.Titular.Contains(CbTitularPro.Text)
                                                Group f By f.Lote_troza Into Group = Group Select Lote_troza).Distinct().ToList()
        CbLoteTrozasPro.SelectedItem = Nothing
    End Sub
    Private Sub LlenarNombreProductoPro()
        Dim db As New samadEntities
        CbProductoPro.DataSource = (From f In db.vw_mostrar_aserrio_total_prod
                                                Where
                                                f.F04_Fecha >= proDesdeDP.Value And
                                                f.F04_Fecha <= proHastaDP.Value And
                                                f.Titular.Contains(CbTitularPro.Text)
                                                Group f By f.Nom_Producto Into Group = Group Select Nom_Producto).Distinct().ToList()
        CbProductoPro.SelectedItem = Nothing
    End Sub
    Private Sub LlenarObjetPro()
        Dim db As New samadEntities

        '''''''''''''Llenar Combobox de Nombre de Objetivo del Producto'''''''''''''''''''''''

        CbObjProducPro.DataSource = (From f In db.vw_mostrar_aserrio_total_prod
                            Where
                            f.F04_Fecha >= proDesdeDP.Value And
                            f.F04_Fecha <= proHastaDP.Value
                            Group f By f.Objetivo_producto Into Group = Group Select Objetivo_producto).Distinct().ToList()
        CbObjProducPro.SelectedItem = Nothing
    End Sub
    Private Sub LlenarTipoMaterialPro()
        Dim db As New samadEntities
        '''''''''''''Llenar Combobox de Tipo de material utilizado en creacion de producto''''''''''''''''''''''''''''''''

        Dim mat = db.formato04.Where(Function(p) p.F04_Fecha >= proDesdeDP.Value And p.F04_Fecha <= proHastaDP.Value).Select(Function(p) p.F04_TipoConteo).Distinct().ToList()
        CbMaterialPro.DataSource = mat
        CbMaterialPro.SelectedItem = Nothing
    End Sub
    Private Sub LlenarNomAseradPro()
        Dim db As New samadEntities
        '''''''''''''Llenar Combobox de Nombre de Aserrio'''''''''''''''''''''''

        CbNombreAserradPro.DataSource = (From f In db.vw_mostrar_aserrio_total_prod
                            Where
                            f.F04_Fecha >= proDesdeDP.Value And
                            f.F04_Fecha <= proHastaDP.Value
                            Group f By f.Nom_Aserradero Into Group = Group Select Nom_Aserradero).Distinct().ToList()
        CbNombreAserradPro.SelectedItem = Nothing
    End Sub
    Private Sub LlenarPeriodoPro()
        Dim db As New samadEntities

        '''''''''''''Llenar Combobox de Nombre de Objetivo del Producto'''''''''''''''''''''''

        Dim res = (From f In db.vw_mostrar_aserrio_total_prod
                            Where
                            f.F04_Fecha >= proDesdeDP.Value And
                            f.F04_Fecha <= proHastaDP.Value
                            Group f By f.periodo Into Group = Group Select periodo).Distinct().ToList()
        CbPeriodoPro.DataSource = res
        CbPeriodoPro.SelectedItem = Nothing
    End Sub
    Private Sub LlenarTurno_pro()
        Dim db As New samadEntities

        ''''''''''''''Llenar Combobox de Turno de la Producción'''''''''''''''''''''''

        Dim turn = db.turnos.Select(Function(p) p.Tur_Descrip).Distinct().ToList()
        CbTurnoPro.DataSource = turn
        'CbTurnoPro.Text = ""
        CbTurnoPro.SelectedItem = Nothing
    End Sub
    '''LLENAR COMBOBOX PARA EJECUCION DEL EVENTO CLIC

    Private Sub CbTitularPro_Click(sender As System.Object, e As System.EventArgs) Handles CbTitularPro.Click
        LlenarTitularPro()
    End Sub
    Private Sub CbZafraPro_Click(sender As System.Object, e As System.EventArgs) Handles CbZafraPro.Click
        llenarZafraPro()
    End Sub
    Private Sub CbPcaPro_Click(sender As System.Object, e As System.EventArgs) Handles CbPcaPro.Click
        LlenarPcaPro()
    End Sub
    Private Sub CbEspeciePro_Click(sender As System.Object, e As System.EventArgs) Handles CbEspeciePro.Click
        LlenarEspeciePro()
    End Sub
    Private Sub CbListaAserrioPro_Click(sender As System.Object, e As System.EventArgs) Handles CbListaAserrioPro.Click
        LlenarNroLoteAserrioPro()
    End Sub
    Private Sub CbLoteTrozasPro_Click(sender As System.Object, e As System.EventArgs) Handles CbLoteTrozasPro.Click
        LlenarNroLoteTrozasPro()
    End Sub
    Private Sub CbProductoPro_Click(sender As System.Object, e As System.EventArgs) Handles CbProductoPro.Click
        LlenarNombreProductoPro()
    End Sub
    Private Sub CbTipoProducPro_Click(sender As System.Object, e As System.EventArgs) Handles CbObjProducPro.Click
        LlenarObjetPro()
    End Sub
    Private Sub CbMaterialPro_Click(sender As System.Object, e As System.EventArgs) Handles CbMaterialPro.Click
        LlenarTipoMaterialPro()
    End Sub
    Private Sub CbNombreAserradPro_Click(sender As System.Object, e As System.EventArgs) Handles CbNombreAserradPro.Click
        LlenarNomAseradPro()
    End Sub
    Private Sub CbPeriodoPro_Click(sender As System.Object, e As System.EventArgs) Handles CbPeriodoPro.Click
        LlenarPeriodoPro()
    End Sub
    Private Sub CbTurnoPro_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbTurnoPro.SelectedIndexChanged
        LlenarTurno_pro()
    End Sub
    Private Sub CbTurnoPro_Click(sender As System.Object, e As System.EventArgs) Handles CbTurnoPro.Click
        LlenarTurno_pro()
    End Sub
#End Region

#End Region

    Private Sub dtpDesde_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpDesde.ValueChanged
        llenartitulares()
    End Sub

    Private Sub dtpHasta_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpHasta.ValueChanged
        llenartitulares()
    End Sub

    Private Sub llenartitulares()
        Dim db As New samadEntities
        CboTitular.DataSource = (From t In db.titulares
                                       From f In db.formato01_det
                                       From g In db.listatrozasc
                                       Where
                                       f.F01d_Gtf = g.Lt_Nrogtf And
                                       g.Lt_Titular_Id = t.Pro_Id And
                                       f.formato01.F01_Fecha >= dtpDesde.Value And
                                        f.formato01.F01_Fecha <= dtpHasta.Value
                                    Select New With {.id = t.Pro_Id, .titular = t.Pro_Titular}).Distinct().ToList()

        CboTitular.SelectedItem = Nothing
    End Sub
    
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnZafra.Click
        Dim inicio = dtInicio.Value.AddDays(-1).Date
        Dim fin = dtFin.Value.Date

        Dim frm As New frmShowbrow
        frm.titulo = "Seleccione ZAFRA"
        frm.t_tabla = "listatrozasc c, zafrasypoas z, titulares t"
        frm.t_campos = "distinct  z.Zyp_Zafra, Zyp_id"
        frm.t_donde = "c.Lt_Titular_id = t.Pro_id and c.Lt_Poa_Id = z.Zyp_id and t.Pro_Titular = '" + txtTitular.Text + "' and " +
                      "c.Lt_Fecha > '" + inicio.Year.ToString() + "-" + inicio.Month.ToString() + "-" + inicio.Day.ToString() + "' and " + " c.Lt_Fecha < '" + fin.Year.ToString() + "-" + fin.Month.ToString() + "-" + fin.Day.ToString() + "'"
        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""


        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Zafra", "Id"}
        Dim anchos() As Integer = {100, 0}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)
        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog(Me)

        'Datos de Propietarios
        If frm.flag = True Then
            TxtZafra.Text = frm.matColumnas(0)
        End If
    End Sub

#Region "CODIGO PARA IMPRESION DEL LIBRO DE OPERACIONES"

    Private Sub Imprimir_LibOpera_Click(sender As System.Object, e As System.EventArgs) Handles Imprimir_LibOpera.Click
        Dim db As New samadEntities
        Dim dt As New LibroOperaciones
        Dim dini, dfin As String
        Dim Sql As String = ""
        Dim cn As New MySqlConnection(New fxSamad().GetCadenaConexionSamad())

        Dim fechafin = DateFin.Value.AddDays(-1)

        Try
            'convertir fecha 

            dini = Convert.ToDateTime(DateInicio.Value.Date).ToString("yyyy-MM-dd")
            dfin = Convert.ToDateTime(DateFin.Value.Date).ToString("yyyy-MM-dd")

            Sql = "SELECT Desd_Id,Des_Id,fecha_Ing,Receptor,tipo,Nombre,Nombre_comun,Nombre_Cientifico,T_Trozas,uind_med,T_Volm3,Nro_Gtf,fechaGtf,localidad,Nro_contrato,Des_Fecha,Desd_Producto,Desd_Cantidad,VolM3Com,VolM3Rec,Desd_Ac_Volm3_CM,Desd_Ac_Volm3_RC,Vol_Total,Saldo_80,Pro_Titular,Des_Periodo FROM vw_mostrar_libro_operaciones WHERE Des_Fecha >='" & dini & "' AND Des_Fecha <='" & dfin & "'"

            If CboPerio.Text <> "" Then
                Sql = Sql + " AND Des_Periodo ='" + CboPerio.Text + "'"
            End If
            If CboNroContrato.Text <> "" Then
                Sql = Sql + " AND Nro_contrato ='" + CboNroContrato.Text + "'"
            End If
            If CboNroGtf.Text <> "" Then
                Sql = Sql + " AND Nro_Gtf ='" + CboNroGtf.Text + "'"
            End If
            If CboEspecie.Text <> "" Then
                Sql = Sql + " AND Nombre_comun ='" + CboEspecie.Text + "'"
            End If



            Dim da As New MySqlDataAdapter(Sql, cn)
            da.Fill(dt, "LibroOper")

            If dt.Tables.Count > 0 Then

                Dim cr As New CrystalReport2
                cr.SetDataSource(dt)
                Dim rp As New ReporteLibOpe
                rp.CrystalReportViewer1.ReportSource = cr
                rp.Show()
                rp.Refresh()

            End If


        Catch ex As Exception

        End Try




    End Sub

#Region "Llenar combos"

    Private Sub llenarComboPeriodo()
        Dim db As New samadEntities
        CboPerio.DataSource = (From pe In db.vw_mostrar_libro_operaciones Group pe By pe.Des_Periodo Into grupo = Group Select Des_Periodo)
        CboPerio.SelectedItem = Nothing
    End Sub

    Private Sub LlenarComboContarto()
        Dim db As New samadEntities
        CboNroContrato.DataSource = (From pe In db.vw_mostrar_libro_operaciones Group pe By pe.Nro_contrato Into grupo = Group Select Nro_contrato)
        CboNroContrato.SelectedItem = Nothing
    End Sub
    Private Sub CboZafraAs_Click(sender As System.Object, e As System.EventArgs) Handles CboZafraAs.Click
        llenarzafraAs()
    End Sub
    Private Sub LlenarComboNroGTF()
        Dim db As New samadEntities
        CboNroGtf.DataSource = (From pe In db.vw_mostrar_libro_operaciones Group pe By pe.Nro_Gtf Into grupo = Group Select Nro_Gtf)
        CboNroGtf.SelectedItem = Nothing
    End Sub

    Private Sub LlenarComboEspecie()
        Dim db As New samadEntities
        CboEspecie.DataSource = (From pe In db.vw_mostrar_libro_operaciones Group pe By pe.Nombre_comun Into grupo = Group Select Nombre_comun)
        CboEspecie.SelectedItem = Nothing
    End Sub

    Private Sub CboPerio_Click(sender As System.Object, e As System.EventArgs) Handles CboPerio.Click
        llenarComboPeriodo()
    End Sub

    Private Sub CboNroContrato_Click(sender As System.Object, e As System.EventArgs) Handles CboNroContrato.Click
        LlenarComboContarto()
    End Sub
   
    Private Sub CboNroGtf_Click(sender As System.Object, e As System.EventArgs) Handles CboNroGtf.Click
        LlenarComboNroGTF()
    End Sub

    Private Sub CboEspecie_Click(sender As System.Object, e As System.EventArgs) Handles CboEspecie.Click
        LlenarComboEspecie()
    End Sub

#End Region

#End Region

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub intSalir_Click(sender As System.Object, e As System.EventArgs) Handles intSalir.Click
        Me.Close()
    End Sub

    Private Function f() As Object
        Throw New NotImplementedException
    End Function

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

   
End Class