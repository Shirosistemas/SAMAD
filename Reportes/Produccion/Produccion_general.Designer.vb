Partial Class Produccion_general

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.ObjectDataSource1 = New Telerik.Reporting.ObjectDataSource()
        Me.GroupHeaderSection1 = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.GroupFooterSection1 = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox35 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.Group1 = New Telerik.Reporting.Group()
        Me.labelsGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.labelsGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroup = New Telerik.Reporting.Group()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.TxPeriodoPro = New Telerik.Reporting.TextBox()
        Me.TextBox37 = New Telerik.Reporting.TextBox()
        Me.TextBox36 = New Telerik.Reporting.TextBox()
        Me.TxTurnoPro = New Telerik.Reporting.TextBox()
        Me.TxAserraderoPro = New Telerik.Reporting.TextBox()
        Me.TextBox33 = New Telerik.Reporting.TextBox()
        Me.TextBox34 = New Telerik.Reporting.TextBox()
        Me.TxTipoMaterialPro = New Telerik.Reporting.TextBox()
        Me.TxObjProductoPro = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.TxProductoPro = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TxtEspeciePro = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TxFechaIni = New Telerik.Reporting.TextBox()
        Me.TxFechaFin = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TxZafra = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TxPca = New Telerik.Reporting.TextBox()
        Me.TextBox43 = New Telerik.Reporting.TextBox()
        Me.TxListaAserrad = New Telerik.Reporting.TextBox()
        Me.TextBox44 = New Telerik.Reporting.TextBox()
        Me.TxTitular = New Telerik.Reporting.TextBox()
        Me.TextBox45 = New Telerik.Reporting.TextBox()
        Me.TxContrato = New Telerik.Reporting.TextBox()
        Me.TextBox48 = New Telerik.Reporting.TextBox()
        Me.TxLoteTroza = New Telerik.Reporting.TextBox()
        Me.TextBox47 = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.TextBox42 = New Telerik.Reporting.TextBox()
        Me.TextBox41 = New Telerik.Reporting.TextBox()
        Me.TextBox40 = New Telerik.Reporting.TextBox()
        Me.TextBox46 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'ObjectDataSource1
        '
        Me.ObjectDataSource1.DataSource = GetType(SAMAD.Reporte04)
        Me.ObjectDataSource1.Name = "ObjectDataSource1"
        '
        'GroupHeaderSection1
        '
        Me.GroupHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(0.5846666693687439R)
        Me.GroupHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox2, Me.TextBox3})
        Me.GroupHeaderSection1.Name = "GroupHeaderSection1"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.6000001430511475R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(18.315332412719727R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox2.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.TextBox2.StyleName = "Data"
        Me.TextBox2.Value = "=Fields.Detalle.Titular"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox3.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextBox3.Style.BorderColor.Default = System.Drawing.Color.White
        Me.TextBox3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox3.Style.Color = System.Drawing.Color.Blue
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.StyleName = "Caption"
        Me.TextBox3.Value = "Nombre del Titular de T. H. :"
        '
        'GroupFooterSection1
        '
        Me.GroupFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(0.67450082302093506R)
        Me.GroupFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox24, Me.TextBox35, Me.TextBox38, Me.TextBox39})
        Me.GroupFooterSection1.Name = "GroupFooterSection1"
        '
        'TextBox24
        '
        Me.TextBox24.CanGrow = True
        Me.TextBox24.Format = "{0:N3}"
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(23.700002670288086R), Telerik.Reporting.Drawing.Unit.Cm(0.0846666619181633R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5516296625137329R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox24.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox24.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox24.Style.Font.Bold = True
        Me.TextBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox24.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.15000000596046448R)
        Me.TextBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox24.StyleName = "Data"
        Me.TextBox24.Value = "=sum(Fields.Detalle.VolPT)"
        '
        'TextBox35
        '
        Me.TextBox35.CanGrow = True
        Me.TextBox35.Format = "{0:N3}"
        Me.TextBox35.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(22.399999618530273R), Telerik.Reporting.Drawing.Unit.Cm(0.0846666619181633R))
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3000015020370483R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox35.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox35.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox35.Style.Font.Bold = True
        Me.TextBox35.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox35.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.15000000596046448R)
        Me.TextBox35.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox35.StyleName = "Data"
        Me.TextBox35.Value = "=sum(Fields.Detalle.VolM3)"
        '
        'TextBox38
        '
        Me.TextBox38.CanGrow = True
        Me.TextBox38.Format = "{0:N0}"
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(20.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0846666619181633R))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3000006675720215R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox38.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox38.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox38.Style.Font.Bold = True
        Me.TextBox38.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox38.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox38.StyleName = "Data"
        Me.TextBox38.Value = "=sum(Fields.Detalle.Cantidad)"
        '
        'TextBox39
        '
        Me.TextBox39.CanGrow = True
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.88899999856948853R), Telerik.Reporting.Drawing.Unit.Cm(0.14816665649414063R))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6472220420837402R), Telerik.Reporting.Drawing.Unit.Cm(0.38751056790351868R))
        Me.TextBox39.Style.BackgroundColor = System.Drawing.Color.Tan
        Me.TextBox39.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox39.Style.Color = System.Drawing.Color.Crimson
        Me.TextBox39.Style.Font.Bold = True
        Me.TextBox39.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox39.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox39.StyleName = "Caption"
        Me.TextBox39.Value = "Sub totales"
        '
        'Group1
        '
        Me.Group1.GroupFooter = Me.GroupFooterSection1
        Me.Group1.GroupHeader = Me.GroupHeaderSection1
        Me.Group1.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.Detalle.Titular")})
        Me.Group1.Name = "Group1"
        '
        'labelsGroupHeader
        '
        Me.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.5846666693687439R)
        Me.labelsGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox4, Me.TextBox11, Me.TextBox10, Me.TextBox9, Me.TextBox8, Me.TextBox7, Me.TextBox6, Me.TextBox5, Me.TextBox12, Me.TextBox13, Me.TextBox31})
        Me.labelsGroupHeader.Name = "labelsGroupHeader"
        Me.labelsGroupHeader.PrintOnEveryPage = True
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.10000003129243851R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.3971788883209229R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox4.Style.BorderColor.Default = System.Drawing.Color.White
        Me.TextBox4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Name = "Arial"
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.StyleName = "Caption"
        Me.TextBox4.Value = "N° Lote Aserrio"
        '
        'TextBox11
        '
        Me.TextBox11.CanGrow = True
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(25.251832962036133R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4000006914138794R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox11.Style.BorderColor.Default = System.Drawing.Color.White
        Me.TextBox11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox11.Style.Font.Bold = True
        Me.TextBox11.Style.Font.Name = "Arial"
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.StyleName = "Caption"
        Me.TextBox11.Value = "Nro. GTF"
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = True
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(23.700002670288086R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5516296625137329R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox10.Style.BorderColor.Default = System.Drawing.Color.White
        Me.TextBox10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox10.Style.Font.Bold = True
        Me.TextBox10.Style.Font.Name = "Arial"
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.StyleName = "Caption"
        Me.TextBox10.Value = "Vol Pt"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(22.399999618530273R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3000015020370483R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox9.Style.BorderColor.Default = System.Drawing.Color.White
        Me.TextBox9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox9.Style.Font.Bold = True
        Me.TextBox9.Style.Font.Name = "Arial"
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.StyleName = "Caption"
        Me.TextBox9.Value = "Vol M3"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(21.30000114440918R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0999987125396729R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox8.Style.BorderColor.Default = System.Drawing.Color.White
        Me.TextBox8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox8.Style.Font.Bold = True
        Me.TextBox8.Style.Font.Name = "Arial"
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.StyleName = "Caption"
        Me.TextBox8.Value = "Unidad"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = True
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(20.0R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3000006675720215R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox7.Style.BorderColor.Default = System.Drawing.Color.White
        Me.TextBox7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox7.Style.Font.Bold = True
        Me.TextBox7.Style.Font.Name = "Arial"
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox7.StyleName = "Caption"
        Me.TextBox7.Value = "Cantidad"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(17.100000381469727R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.8999984264373779R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox6.Style.BorderColor.Default = System.Drawing.Color.White
        Me.TextBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox6.Style.Font.Bold = True
        Me.TextBox6.Style.Font.Name = "Arial"
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox6.StyleName = "Caption"
        Me.TextBox6.Value = "Clasifica del Producto"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.700000762939453R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.3971788883209229R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox5.Style.BorderColor.Default = System.Drawing.Color.White
        Me.TextBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.Style.Font.Name = "Arial"
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.StyleName = "Caption"
        Me.TextBox5.Value = "Objetivo del producto"
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = True
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.300000190734863R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.3971788883209229R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox12.Style.BorderColor.Default = System.Drawing.Color.White
        Me.TextBox12.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox12.Style.Font.Bold = True
        Me.TextBox12.Style.Font.Name = "Arial"
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox12.StyleName = "Caption"
        Me.TextBox12.Value = "Clasificacion Com."
        '
        'TextBox13
        '
        Me.TextBox13.CanGrow = True
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.8999996185302734R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.3971788883209229R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox13.Style.BorderColor.Default = System.Drawing.Color.White
        Me.TextBox13.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox13.Style.Font.Bold = True
        Me.TextBox13.Style.Font.Name = "Arial"
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.StyleName = "Caption"
        Me.TextBox13.Value = "Nom. del Producto"
        '
        'TextBox31
        '
        Me.TextBox31.CanGrow = True
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.5R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.3971788883209229R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox31.Style.BorderColor.Default = System.Drawing.Color.White
        Me.TextBox31.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox31.Style.Font.Bold = True
        Me.TextBox31.Style.Font.Name = "Arial"
        Me.TextBox31.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox31.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox31.StyleName = "Caption"
        Me.TextBox31.Value = "Especie"
        '
        'labelsGroupFooter
        '
        Me.labelsGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.57150000333786011R)
        Me.labelsGroupFooter.Name = "labelsGroupFooter"
        Me.labelsGroupFooter.Style.Visible = False
        '
        'labelsGroup
        '
        Me.labelsGroup.GroupFooter = Me.labelsGroupFooter
        Me.labelsGroup.GroupHeader = Me.labelsGroupHeader
        Me.labelsGroup.Name = "labelsGroup"
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.5846666693687439R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.reportNameTextBox})
        Me.pageHeader.Name = "pageHeader"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(26.530666351318359R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "Producción general"
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.5846666693687439R)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.currentTimeTextBox, Me.pageInfoTextBox})
        Me.pageFooter.Name = "pageFooter"
        '
        'currentTimeTextBox
        '
        Me.currentTimeTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.currentTimeTextBox.Name = "currentTimeTextBox"
        Me.currentTimeTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(13.244166374206543R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.currentTimeTextBox.StyleName = "PageInfo"
        Me.currentTimeTextBox.Value = "=NOW()"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.32883358001709R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(13.244166374206543R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=PageNumber"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(2.5153334140777588R)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TxPeriodoPro, Me.TextBox37, Me.TextBox36, Me.TxTurnoPro, Me.TxAserraderoPro, Me.TextBox33, Me.TextBox34, Me.TxTipoMaterialPro, Me.TxObjProductoPro, Me.TextBox32, Me.TxProductoPro, Me.TextBox30, Me.TxtEspeciePro, Me.TextBox29, Me.TextBox28, Me.TxFechaIni, Me.TxFechaFin, Me.TextBox27, Me.TextBox26, Me.TxZafra, Me.TextBox25, Me.TxPca, Me.TextBox43, Me.TxListaAserrad, Me.TextBox44, Me.TxTitular, Me.TextBox45, Me.TxContrato, Me.TextBox48, Me.TxLoteTroza, Me.TextBox47})
        Me.reportHeader.Name = "reportHeader"
        '
        'TxPeriodoPro
        '
        Me.TxPeriodoPro.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.899999618530273R), Telerik.Reporting.Drawing.Unit.Cm(1.8153336048126221R))
        Me.TxPeriodoPro.Name = "TxPeriodoPro"
        Me.TxPeriodoPro.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxPeriodoPro.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TxPeriodoPro.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TxPeriodoPro.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxPeriodoPro.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TxPeriodoPro.Value = "TxPeriodoPro"
        '
        'TextBox37
        '
        Me.TextBox37.CanGrow = True
        Me.TextBox37.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.899999618530273R), Telerik.Reporting.Drawing.Unit.Cm(1.5190002918243408R))
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.2199999988079071R))
        Me.TextBox37.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox37.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox37.Style.Color = System.Drawing.Color.Green
        Me.TextBox37.Style.Font.Bold = True
        Me.TextBox37.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox37.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox37.StyleName = "Caption"
        Me.TextBox37.Value = "Periodo:"
        '
        'TextBox36
        '
        Me.TextBox36.CanGrow = True
        Me.TextBox36.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.5086669921875R), Telerik.Reporting.Drawing.Unit.Cm(1.5190002918243408R))
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.15000057220459R), Telerik.Reporting.Drawing.Unit.Cm(0.2199999988079071R))
        Me.TextBox36.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox36.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox36.Style.Color = System.Drawing.Color.Green
        Me.TextBox36.Style.Font.Bold = True
        Me.TextBox36.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox36.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox36.StyleName = "Caption"
        Me.TextBox36.Value = "Turno:"
        '
        'TxTurnoPro
        '
        Me.TxTurnoPro.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.5086669921875R), Telerik.Reporting.Drawing.Unit.Cm(1.8153336048126221R))
        Me.TxTurnoPro.Name = "TxTurnoPro"
        Me.TxTurnoPro.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.15000057220459R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxTurnoPro.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TxTurnoPro.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TxTurnoPro.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxTurnoPro.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TxTurnoPro.Value = "TxTurnoPro"
        '
        'TxAserraderoPro
        '
        Me.TxAserraderoPro.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.6929998397827148R), Telerik.Reporting.Drawing.Unit.Cm(1.8153336048126221R))
        Me.TxAserraderoPro.Name = "TxAserraderoPro"
        Me.TxAserraderoPro.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.0999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxAserraderoPro.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TxAserraderoPro.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TxAserraderoPro.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxAserraderoPro.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TxAserraderoPro.Value = "TxAserraderoPro"
        '
        'TextBox33
        '
        Me.TextBox33.CanGrow = True
        Me.TextBox33.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.6929998397827148R), Telerik.Reporting.Drawing.Unit.Cm(1.5190002918243408R))
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.0999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.2199999988079071R))
        Me.TextBox33.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox33.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox33.Style.Color = System.Drawing.Color.Green
        Me.TextBox33.Style.Font.Bold = True
        Me.TextBox33.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox33.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox33.StyleName = "Caption"
        Me.TextBox33.Value = "Nombre del Aserradero:"
        '
        'TextBox34
        '
        Me.TextBox34.CanGrow = True
        Me.TextBox34.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.99916672706604R), Telerik.Reporting.Drawing.Unit.Cm(1.5190002918243408R))
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.599998950958252R), Telerik.Reporting.Drawing.Unit.Cm(0.2199999988079071R))
        Me.TextBox34.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox34.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox34.Style.Color = System.Drawing.Color.Green
        Me.TextBox34.Style.Font.Bold = True
        Me.TextBox34.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox34.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox34.StyleName = "Caption"
        Me.TextBox34.Value = "Tipo de Material:"
        '
        'TxTipoMaterialPro
        '
        Me.TxTipoMaterialPro.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.99916672706604R), Telerik.Reporting.Drawing.Unit.Cm(1.8153336048126221R))
        Me.TxTipoMaterialPro.Name = "TxTipoMaterialPro"
        Me.TxTipoMaterialPro.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.599998950958252R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxTipoMaterialPro.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TxTipoMaterialPro.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TxTipoMaterialPro.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxTipoMaterialPro.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TxTipoMaterialPro.Value = "TxTipoMaterialPro"
        '
        'TxObjProductoPro
        '
        Me.TxObjProductoPro.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.80300003290176392R), Telerik.Reporting.Drawing.Unit.Cm(1.8153336048126221R))
        Me.TxObjProductoPro.Name = "TxObjProductoPro"
        Me.TxObjProductoPro.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxObjProductoPro.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TxObjProductoPro.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TxObjProductoPro.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxObjProductoPro.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TxObjProductoPro.Value = "TxObjProductoPro"
        '
        'TextBox32
        '
        Me.TextBox32.CanGrow = True
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.80300003290176392R), Telerik.Reporting.Drawing.Unit.Cm(1.5190002918243408R))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.2199999988079071R))
        Me.TextBox32.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox32.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox32.Style.Color = System.Drawing.Color.Green
        Me.TextBox32.Style.Font.Bold = True
        Me.TextBox32.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox32.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox32.StyleName = "Caption"
        Me.TextBox32.Value = "Objetibo del Producto:"
        '
        'TxProductoPro
        '
        Me.TxProductoPro.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(18.794666290283203R), Telerik.Reporting.Drawing.Unit.Cm(1.8153336048126221R))
        Me.TxProductoPro.Name = "TxProductoPro"
        Me.TxProductoPro.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.6736111640930176R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxProductoPro.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TxProductoPro.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TxProductoPro.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxProductoPro.Value = "TxProductoPro"
        '
        'TextBox30
        '
        Me.TextBox30.CanGrow = True
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(18.794666290283203R), Telerik.Reporting.Drawing.Unit.Cm(1.5190002918243408R))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.6736111640930176R), Telerik.Reporting.Drawing.Unit.Cm(0.2199999988079071R))
        Me.TextBox30.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox30.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox30.Style.Color = System.Drawing.Color.Green
        Me.TextBox30.Style.Font.Bold = True
        Me.TextBox30.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox30.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox30.StyleName = "Caption"
        Me.TextBox30.Value = "Nombre del producto:"
        '
        'TxtEspeciePro
        '
        Me.TxtEspeciePro.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.5086669921875R), Telerik.Reporting.Drawing.Unit.Cm(1.1168335676193237R))
        Me.TxtEspeciePro.Name = "TxtEspeciePro"
        Me.TxtEspeciePro.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.15000057220459R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxtEspeciePro.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TxtEspeciePro.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TxtEspeciePro.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxtEspeciePro.Value = "TextBox10"
        '
        'TextBox29
        '
        Me.TextBox29.CanGrow = True
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.5086669921875R), Telerik.Reporting.Drawing.Unit.Cm(0.82050025463104248R))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.15000057220459R), Telerik.Reporting.Drawing.Unit.Cm(0.2199999988079071R))
        Me.TextBox29.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox29.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox29.Style.Color = System.Drawing.Color.Green
        Me.TextBox29.Style.Font.Bold = True
        Me.TextBox29.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox29.StyleName = "Caption"
        Me.TextBox29.Value = "Especie:"
        '
        'TextBox28
        '
        Me.TextBox28.CanGrow = True
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.80300003290176392R), Telerik.Reporting.Drawing.Unit.Cm(0.82050025463104248R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.2199999988079071R))
        Me.TextBox28.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox28.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox28.Style.Color = System.Drawing.Color.Green
        Me.TextBox28.Style.Font.Bold = True
        Me.TextBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox28.StyleName = "Caption"
        Me.TextBox28.Value = "Desde:"
        '
        'TxFechaIni
        '
        Me.TxFechaIni.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.80300003290176392R), Telerik.Reporting.Drawing.Unit.Cm(1.1168335676193237R))
        Me.TxFechaIni.Name = "TxFechaIni"
        Me.TxFechaIni.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxFechaIni.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TxFechaIni.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TxFechaIni.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxFechaIni.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.TxFechaIni.Value = "TextBox10"
        '
        'TxFechaFin
        '
        Me.TxFechaFin.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.4116666316986084R), Telerik.Reporting.Drawing.Unit.Cm(1.1168335676193237R))
        Me.TxFechaFin.Name = "TxFechaFin"
        Me.TxFechaFin.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxFechaFin.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TxFechaFin.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TxFechaFin.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxFechaFin.Value = "TextBox10"
        '
        'TextBox27
        '
        Me.TextBox27.CanGrow = True
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.4116666316986084R), Telerik.Reporting.Drawing.Unit.Cm(0.82050025463104248R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.2199999988079071R))
        Me.TextBox27.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox27.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox27.Style.Color = System.Drawing.Color.Green
        Me.TextBox27.Style.Font.Bold = True
        Me.TextBox27.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox27.StyleName = "Caption"
        Me.TextBox27.Value = "Hasta:"
        '
        'TextBox26
        '
        Me.TextBox26.CanGrow = True
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.3125R), Telerik.Reporting.Drawing.Unit.Cm(0.82050025463104248R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.2199999988079071R))
        Me.TextBox26.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox26.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox26.Style.Color = System.Drawing.Color.Green
        Me.TextBox26.Style.Font.Bold = True
        Me.TextBox26.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox26.StyleName = "Caption"
        Me.TextBox26.Value = "Zafra:"
        '
        'TxZafra
        '
        Me.TxZafra.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.3125R), Telerik.Reporting.Drawing.Unit.Cm(1.1168335676193237R))
        Me.TxZafra.Name = "TxZafra"
        Me.TxZafra.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxZafra.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TxZafra.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TxZafra.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxZafra.Value = "TextBox10"
        '
        'TextBox25
        '
        Me.TextBox25.CanGrow = True
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.899999618530273R), Telerik.Reporting.Drawing.Unit.Cm(0.82050025463104248R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.2199999988079071R))
        Me.TextBox25.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox25.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox25.Style.Color = System.Drawing.Color.Green
        Me.TextBox25.Style.Font.Bold = True
        Me.TextBox25.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox25.StyleName = "Caption"
        Me.TextBox25.Value = "N° PCA:"
        '
        'TxPca
        '
        Me.TxPca.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.899999618530273R), Telerik.Reporting.Drawing.Unit.Cm(1.1168335676193237R))
        Me.TxPca.Name = "TxPca"
        Me.TxPca.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxPca.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TxPca.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TxPca.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxPca.Value = "TextBox10"
        '
        'TextBox43
        '
        Me.TextBox43.CanGrow = True
        Me.TextBox43.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(18.794666290283203R), Telerik.Reporting.Drawing.Unit.Cm(0.82050025463104248R))
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.15000057220459R), Telerik.Reporting.Drawing.Unit.Cm(0.2199999988079071R))
        Me.TextBox43.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox43.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox43.Style.Color = System.Drawing.Color.Green
        Me.TextBox43.Style.Font.Bold = True
        Me.TextBox43.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox43.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox43.StyleName = "Caption"
        Me.TextBox43.Value = "N° Lista de Aserrío:"
        '
        'TxListaAserrad
        '
        Me.TxListaAserrad.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(18.794666290283203R), Telerik.Reporting.Drawing.Unit.Cm(1.1168335676193237R))
        Me.TxListaAserrad.Name = "TxListaAserrad"
        Me.TxListaAserrad.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.15000057220459R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxListaAserrad.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TxListaAserrad.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TxListaAserrad.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxListaAserrad.Value = "TextBox10"
        '
        'TextBox44
        '
        Me.TextBox44.CanGrow = True
        Me.TextBox44.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.99916672706604R), Telerik.Reporting.Drawing.Unit.Cm(0.82050025463104248R))
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.599998950958252R), Telerik.Reporting.Drawing.Unit.Cm(0.2199999988079071R))
        Me.TextBox44.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox44.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox44.Style.Color = System.Drawing.Color.Green
        Me.TextBox44.Style.Font.Bold = True
        Me.TextBox44.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox44.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox44.StyleName = "Caption"
        Me.TextBox44.Value = "Titular del Titulo Habilitante:"
        '
        'TxTitular
        '
        Me.TxTitular.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.99916672706604R), Telerik.Reporting.Drawing.Unit.Cm(1.1168335676193237R))
        Me.TxTitular.Name = "TxTitular"
        Me.TxTitular.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.599998950958252R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxTitular.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TxTitular.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TxTitular.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxTitular.Value = "TextBox10"
        '
        'TextBox45
        '
        Me.TextBox45.CanGrow = True
        Me.TextBox45.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.6929998397827148R), Telerik.Reporting.Drawing.Unit.Cm(0.82050025463104248R))
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.4999990463256836R), Telerik.Reporting.Drawing.Unit.Cm(0.2199999988079071R))
        Me.TextBox45.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox45.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox45.Style.Color = System.Drawing.Color.Green
        Me.TextBox45.Style.Font.Bold = True
        Me.TextBox45.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox45.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox45.StyleName = "Caption"
        Me.TextBox45.Value = "N° Contrato:"
        '
        'TxContrato
        '
        Me.TxContrato.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.6929998397827148R), Telerik.Reporting.Drawing.Unit.Cm(1.1168335676193237R))
        Me.TxContrato.Name = "TxContrato"
        Me.TxContrato.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.4999990463256836R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxContrato.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TxContrato.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TxContrato.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxContrato.Value = "TextBox10"
        '
        'TextBox48
        '
        Me.TextBox48.CanGrow = True
        Me.TextBox48.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(21.101833343505859R), Telerik.Reporting.Drawing.Unit.Cm(0.82050025463104248R))
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3736107349395752R), Telerik.Reporting.Drawing.Unit.Cm(0.2199999988079071R))
        Me.TextBox48.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox48.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox48.Style.Color = System.Drawing.Color.Green
        Me.TextBox48.Style.Font.Bold = True
        Me.TextBox48.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox48.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox48.StyleName = "Caption"
        Me.TextBox48.Value = "N° Lote de Trozas:"
        '
        'TxLoteTroza
        '
        Me.TxLoteTroza.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(21.101833343505859R), Telerik.Reporting.Drawing.Unit.Cm(1.1168335676193237R))
        Me.TxLoteTroza.Name = "TxLoteTroza"
        Me.TxLoteTroza.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3736107349395752R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxLoteTroza.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TxLoteTroza.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TxLoteTroza.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxLoteTroza.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TxLoteTroza.Value = "TextBox10"
        '
        'TextBox47
        '
        Me.TextBox47.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.1000003814697266R), Telerik.Reporting.Drawing.Unit.Cm(0.11533339321613312R))
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.09999942779541R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox47.Style.Font.Bold = True
        Me.TextBox47.Style.Font.Italic = True
        Me.TextBox47.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox47.Style.Font.Strikeout = False
        Me.TextBox47.Style.Font.Underline = True
        Me.TextBox47.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox47.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox47.Value = "PARAMETROS DE FILTRADO"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.57150000333786011R)
        Me.reportFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox42, Me.TextBox41, Me.TextBox40, Me.TextBox46})
        Me.reportFooter.Name = "reportFooter"
        '
        'TextBox42
        '
        Me.TextBox42.CanGrow = True
        Me.TextBox42.Format = "{0:N0}"
        Me.TextBox42.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(20.0R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3000006675720215R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox42.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox42.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox42.Style.Font.Bold = True
        Me.TextBox42.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox42.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox42.StyleName = "Data"
        Me.TextBox42.Value = "=sum(Fields.Detalle.Cantidad)"
        '
        'TextBox41
        '
        Me.TextBox41.CanGrow = True
        Me.TextBox41.Format = "{0:N3}"
        Me.TextBox41.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(22.399999618530273R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3000015020370483R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox41.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox41.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox41.Style.Font.Bold = True
        Me.TextBox41.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox41.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.15000000596046448R)
        Me.TextBox41.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox41.StyleName = "Data"
        Me.TextBox41.Value = "=sum(Fields.Detalle.VolM3)"
        '
        'TextBox40
        '
        Me.TextBox40.CanGrow = True
        Me.TextBox40.Format = "{0:N3}"
        Me.TextBox40.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(23.700002670288086R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5516296625137329R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox40.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox40.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox40.Style.Font.Bold = True
        Me.TextBox40.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox40.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.15000000596046448R)
        Me.TextBox40.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox40.StyleName = "Data"
        Me.TextBox40.Value = "=sum(Fields.Detalle.VolPT)"
        '
        'TextBox46
        '
        Me.TextBox46.CanGrow = True
        Me.TextBox46.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.88899999856948853R), Telerik.Reporting.Drawing.Unit.Cm(0.0846666619181633R))
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6472220420837402R), Telerik.Reporting.Drawing.Unit.Cm(0.38751056790351868R))
        Me.TextBox46.Style.BackgroundColor = System.Drawing.Color.Tan
        Me.TextBox46.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox46.Style.Color = System.Drawing.Color.Crimson
        Me.TextBox46.Style.Font.Bold = True
        Me.TextBox46.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox46.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox46.StyleName = "Caption"
        Me.TextBox46.Value = "TOTALES"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.5846666693687439R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox23, Me.TextBox22, Me.TextBox21, Me.TextBox20, Me.TextBox19, Me.TextBox18, Me.TextBox17, Me.TextBox16, Me.TextBox15, Me.TextBox14, Me.TextBox1})
        Me.detail.Name = "detail"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.10000003129243851R), Telerik.Reporting.Drawing.Unit.Cm(0.021166747435927391R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.3971788883209229R), Telerik.Reporting.Drawing.Unit.Cm(0.49999982118606567R))
        Me.TextBox23.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox23.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox23.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox23.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0.23000000417232513R)
        Me.TextBox23.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.0R)
        Me.TextBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox23.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox23.Value = "=Fields.Detalle.Nro_Lot_As"
        '
        'TextBox22
        '
        Me.TextBox22.CanGrow = True
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(25.251832962036133R), Telerik.Reporting.Drawing.Unit.Cm(0.021166665479540825R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4000006914138794R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox22.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox22.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox22.StyleName = "Data"
        Me.TextBox22.Value = "=Fields.Detalle.F01d_Gtf"
        '
        'TextBox21
        '
        Me.TextBox21.CanGrow = True
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(23.700002670288086R), Telerik.Reporting.Drawing.Unit.Cm(0.021166665479540825R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5516296625137329R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox21.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox21.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox21.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox21.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.23000000417232513R)
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox21.StyleName = "Data"
        Me.TextBox21.Value = "=Fields.Detalle.VolPT"
        '
        'TextBox20
        '
        Me.TextBox20.CanGrow = True
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(22.399999618530273R), Telerik.Reporting.Drawing.Unit.Cm(0.021166665479540825R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3000015020370483R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox20.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox20.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox20.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.23000000417232513R)
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox20.StyleName = "Data"
        Me.TextBox20.Value = "=Fields.Detalle.VolM3"
        '
        'TextBox19
        '
        Me.TextBox19.CanGrow = True
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(21.30000114440918R), Telerik.Reporting.Drawing.Unit.Cm(0.021166665479540825R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0999987125396729R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox19.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox19.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox19.StyleName = "Data"
        Me.TextBox19.Value = "=Fields.Detalle.TipUnidad"
        '
        'TextBox18
        '
        Me.TextBox18.CanGrow = True
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(20.0R), Telerik.Reporting.Drawing.Unit.Cm(0.021166665479540825R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3000006675720215R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox18.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox18.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox18.StyleName = "Data"
        Me.TextBox18.Value = "=Fields.Detalle.Cantidad"
        '
        'TextBox17
        '
        Me.TextBox17.CanGrow = True
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(17.100000381469727R), Telerik.Reporting.Drawing.Unit.Cm(0.021166665479540825R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.8999984264373779R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox17.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox17.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox17.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0.23000000417232513R)
        Me.TextBox17.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.0R)
        Me.TextBox17.StyleName = "Data"
        Me.TextBox17.Value = "=Fields.Detalle.ClasificaProducto"
        '
        'TextBox16
        '
        Me.TextBox16.CanGrow = True
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.700000762939453R), Telerik.Reporting.Drawing.Unit.Cm(0.021166665479540825R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.3971788883209229R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox16.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox16.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox16.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0.23000000417232513R)
        Me.TextBox16.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.0R)
        Me.TextBox16.StyleName = "Data"
        Me.TextBox16.Value = "=Fields.Detalle.Objetivo_producto"
        '
        'TextBox15
        '
        Me.TextBox15.CanGrow = True
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.300000190734863R), Telerik.Reporting.Drawing.Unit.Cm(0.021166665479540825R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.3971788883209229R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox15.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox15.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox15.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0.23000000417232513R)
        Me.TextBox15.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.0R)
        Me.TextBox15.StyleName = "Data"
        Me.TextBox15.Value = "=Fields.Detalle.Prod_ClasificacionCom"
        '
        'TextBox14
        '
        Me.TextBox14.CanGrow = True
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.8999996185302734R), Telerik.Reporting.Drawing.Unit.Cm(0.021166665479540825R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.3971788883209229R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox14.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox14.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox14.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0.23000000417232513R)
        Me.TextBox14.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.0R)
        Me.TextBox14.StyleName = "Data"
        Me.TextBox14.Value = "=Fields.Detalle.Nom_Producto"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.5R), Telerik.Reporting.Drawing.Unit.Cm(0.021166665479540825R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.3971788883209229R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0.23000000417232513R)
        Me.TextBox1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.0R)
        Me.TextBox1.StyleName = "Data"
        Me.TextBox1.Value = "=Fields.Detalle.Especie"
        '
        'Produccion_general
        '
        Me.DataSource = Me.ObjectDataSource1
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.Group1, Me.labelsGroup})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.GroupHeaderSection1, Me.GroupFooterSection1, Me.labelsGroupHeader, Me.labelsGroupFooter, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.Name = "Produccion_general_1"
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Cm(1.5R)
        Me.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Cm(1.5R)
        Me.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Cm(1.5R)
        Me.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Cm(1.5R)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Title")})
        StyleRule1.Style.Color = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        StyleRule1.Style.Font.Name = "Tahoma"
        StyleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Caption")})
        StyleRule2.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        StyleRule2.Style.Color = System.Drawing.Color.White
        StyleRule2.Style.Font.Name = "Tahoma"
        StyleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Data")})
        StyleRule3.Style.Color = System.Drawing.Color.Black
        StyleRule3.Style.Font.Name = "Tahoma"
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        StyleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("PageInfo")})
        StyleRule4.Style.Color = System.Drawing.Color.Black
        StyleRule4.Style.Font.Name = "Tahoma"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        StyleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(26.651832580566406R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ObjectDataSource1 As Telerik.Reporting.ObjectDataSource
    Friend WithEvents GroupHeaderSection1 As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents GroupFooterSection1 As Telerik.Reporting.GroupFooterSection
    Friend WithEvents Group1 As Telerik.Reporting.Group
    Friend WithEvents labelsGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents labelsGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents labelsGroup As Telerik.Reporting.Group
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents currentTimeTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents TxPeriodoPro As Telerik.Reporting.TextBox
    Friend WithEvents TextBox37 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox36 As Telerik.Reporting.TextBox
    Friend WithEvents TxTurnoPro As Telerik.Reporting.TextBox
    Friend WithEvents TxAserraderoPro As Telerik.Reporting.TextBox
    Friend WithEvents TextBox33 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox34 As Telerik.Reporting.TextBox
    Friend WithEvents TxTipoMaterialPro As Telerik.Reporting.TextBox
    Friend WithEvents TxObjProductoPro As Telerik.Reporting.TextBox
    Friend WithEvents TextBox32 As Telerik.Reporting.TextBox
    Friend WithEvents TxProductoPro As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TxtEspeciePro As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TxFechaIni As Telerik.Reporting.TextBox
    Friend WithEvents TxFechaFin As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TxZafra As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TxPca As Telerik.Reporting.TextBox
    Friend WithEvents TextBox43 As Telerik.Reporting.TextBox
    Friend WithEvents TxListaAserrad As Telerik.Reporting.TextBox
    Friend WithEvents TextBox44 As Telerik.Reporting.TextBox
    Friend WithEvents TxTitular As Telerik.Reporting.TextBox
    Friend WithEvents TextBox45 As Telerik.Reporting.TextBox
    Friend WithEvents TxContrato As Telerik.Reporting.TextBox
    Friend WithEvents TextBox48 As Telerik.Reporting.TextBox
    Friend WithEvents TxLoteTroza As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox31 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox42 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox41 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox40 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox46 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox35 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox47 As Telerik.Reporting.TextBox
End Class