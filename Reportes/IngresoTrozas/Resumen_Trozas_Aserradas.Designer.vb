Partial Class Resumen_Trozas_Aserradas
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.ObjectDataSource1 = New Telerik.Reporting.ObjectDataSource()
        Me.aserraderoGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.aserraderoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.aserraderoDataTextBox = New Telerik.Reporting.TextBox()
        Me.aserraderoGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.t_trozasSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.vol_m3_GtfSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.vol_m3_CASumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.vol_ptSumFunctionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.aserraderoGroup = New Telerik.Reporting.Group()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.labelsGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.especieCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.t_trozasCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.vol_m3_GtfCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.vol_m3_CACaptionTextBox = New Telerik.Reporting.TextBox()
        Me.vol_ptCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.labelsGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroup = New Telerik.Reporting.Group()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.TxContrato = New Telerik.Reporting.TextBox()
        Me.TextBox45 = New Telerik.Reporting.TextBox()
        Me.TxTitular = New Telerik.Reporting.TextBox()
        Me.TextBox44 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TxFechaFin = New Telerik.Reporting.TextBox()
        Me.TxFechaIni = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TxListaAserrad = New Telerik.Reporting.TextBox()
        Me.TextBox43 = New Telerik.Reporting.TextBox()
        Me.TxPca = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TxZafra = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TxLoteTroza = New Telerik.Reporting.TextBox()
        Me.TextBox48 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.especieDataTextBox1 = New Telerik.Reporting.TextBox()
        Me.t_trozasDataTextBox1 = New Telerik.Reporting.TextBox()
        Me.vol_m3_GtfDataTextBox1 = New Telerik.Reporting.TextBox()
        Me.vol_m3_CADataTextBox1 = New Telerik.Reporting.TextBox()
        Me.vol_ptDataTextBox1 = New Telerik.Reporting.TextBox()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'ObjectDataSource1
        '
        Me.ObjectDataSource1.DataSource = GetType(SAMAD.Resumen_Trozas_AserradasReport)
        Me.ObjectDataSource1.Name = "ObjectDataSource1"
        '
        'aserraderoGroupHeader
        '
        Me.aserraderoGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.5846666693687439R)
        Me.aserraderoGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.aserraderoCaptionTextBox, Me.aserraderoDataTextBox})
        Me.aserraderoGroupHeader.Name = "aserraderoGroupHeader"
        '
        'aserraderoCaptionTextBox
        '
        Me.aserraderoCaptionTextBox.CanGrow = True
        Me.aserraderoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.04722222313284874R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.aserraderoCaptionTextBox.Name = "aserraderoCaptionTextBox"
        Me.aserraderoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.6785001754760742R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.aserraderoCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.aserraderoCaptionTextBox.Style.Font.Bold = True
        Me.aserraderoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.aserraderoCaptionTextBox.StyleName = "Caption"
        Me.aserraderoCaptionTextBox.Value = "Nombre del Aserradero:"
        '
        'aserraderoDataTextBox
        '
        Me.aserraderoDataTextBox.CanGrow = True
        Me.aserraderoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.8048882484436035R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.aserraderoDataTextBox.Name = "aserraderoDataTextBox"
        Me.aserraderoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(13.995012283325195R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.aserraderoDataTextBox.StyleName = "Data"
        Me.aserraderoDataTextBox.Value = "=Fields.Aserradero"
        '
        'aserraderoGroupFooter
        '
        Me.aserraderoGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.5846666693687439R)
        Me.aserraderoGroupFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.t_trozasSumFunctionTextBox, Me.vol_m3_GtfSumFunctionTextBox, Me.vol_m3_CASumFunctionTextBox, Me.vol_ptSumFunctionTextBox, Me.TextBox1})
        Me.aserraderoGroupFooter.Name = "aserraderoGroupFooter"
        '
        't_trozasSumFunctionTextBox
        '
        Me.t_trozasSumFunctionTextBox.CanGrow = True
        Me.t_trozasSumFunctionTextBox.Format = "{0:N0}"
        Me.t_trozasSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.1268911361694336R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.t_trozasSumFunctionTextBox.Name = "t_trozasSumFunctionTextBox"
        Me.t_trozasSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6055533885955811R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.t_trozasSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.t_trozasSumFunctionTextBox.StyleName = "Data"
        Me.t_trozasSumFunctionTextBox.Value = "=Sum(Fields.T_trozas)"
        '
        'vol_m3_GtfSumFunctionTextBox
        '
        Me.vol_m3_GtfSumFunctionTextBox.CanGrow = True
        Me.vol_m3_GtfSumFunctionTextBox.Format = "{0:N3}"
        Me.vol_m3_GtfSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.7892227172851562R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.vol_m3_GtfSumFunctionTextBox.Name = "vol_m3_GtfSumFunctionTextBox"
        Me.vol_m3_GtfSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6055533885955811R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.vol_m3_GtfSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.vol_m3_GtfSumFunctionTextBox.StyleName = "Data"
        Me.vol_m3_GtfSumFunctionTextBox.Value = "=Sum(Fields.Vol_m3_Gtf)"
        '
        'vol_m3_CASumFunctionTextBox
        '
        Me.vol_m3_CASumFunctionTextBox.CanGrow = True
        Me.vol_m3_CASumFunctionTextBox.Format = "{0:N3}"
        Me.vol_m3_CASumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.451557159423828R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.vol_m3_CASumFunctionTextBox.Name = "vol_m3_CASumFunctionTextBox"
        Me.vol_m3_CASumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6055533885955811R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.vol_m3_CASumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.vol_m3_CASumFunctionTextBox.StyleName = "Data"
        Me.vol_m3_CASumFunctionTextBox.Value = "=Sum(Fields.Vol_m3_CA)"
        '
        'vol_ptSumFunctionTextBox
        '
        Me.vol_ptSumFunctionTextBox.CanGrow = True
        Me.vol_ptSumFunctionTextBox.Format = "{0:N3}"
        Me.vol_ptSumFunctionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.113886833190918R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.vol_ptSumFunctionTextBox.Name = "vol_ptSumFunctionTextBox"
        Me.vol_ptSumFunctionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6055533885955811R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.vol_ptSumFunctionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.vol_ptSumFunctionTextBox.StyleName = "Data"
        Me.vol_ptSumFunctionTextBox.Value = "=Sum(Fields.Vol_pt)"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.4472222328186035R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1797230243682861R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox1.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "Totales"
        '
        'aserraderoGroup
        '
        Me.aserraderoGroup.GroupFooter = Me.aserraderoGroupFooter
        Me.aserraderoGroup.GroupHeader = Me.aserraderoGroupHeader
        Me.aserraderoGroup.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.Aserradero")})
        Me.aserraderoGroup.Name = "aserraderoGroup"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.5846666693687439R)
        Me.reportFooter.Name = "reportFooter"
        Me.reportFooter.Style.Visible = True
        '
        'labelsGroupHeader
        '
        Me.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.5846666693687439R)
        Me.labelsGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.especieCaptionTextBox, Me.t_trozasCaptionTextBox, Me.vol_m3_GtfCaptionTextBox, Me.vol_m3_CACaptionTextBox, Me.vol_ptCaptionTextBox})
        Me.labelsGroupHeader.Name = "labelsGroupHeader"
        Me.labelsGroupHeader.PrintOnEveryPage = True
        '
        'especieCaptionTextBox
        '
        Me.especieCaptionTextBox.CanGrow = True
        Me.especieCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.4472222328186035R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.especieCaptionTextBox.Name = "especieCaptionTextBox"
        Me.especieCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.622889518737793R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.especieCaptionTextBox.Style.Font.Bold = True
        Me.especieCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.especieCaptionTextBox.StyleName = "Caption"
        Me.especieCaptionTextBox.Value = "Nombre Común"
        '
        't_trozasCaptionTextBox
        '
        Me.t_trozasCaptionTextBox.CanGrow = True
        Me.t_trozasCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.1268911361694336R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.t_trozasCaptionTextBox.Name = "t_trozasCaptionTextBox"
        Me.t_trozasCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6055533885955811R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.t_trozasCaptionTextBox.Style.Font.Bold = True
        Me.t_trozasCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.t_trozasCaptionTextBox.StyleName = "Caption"
        Me.t_trozasCaptionTextBox.Value = "T.Trozas"
        '
        'vol_m3_GtfCaptionTextBox
        '
        Me.vol_m3_GtfCaptionTextBox.CanGrow = True
        Me.vol_m3_GtfCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.7892236709594727R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.vol_m3_GtfCaptionTextBox.Name = "vol_m3_GtfCaptionTextBox"
        Me.vol_m3_GtfCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6055533885955811R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.vol_m3_GtfCaptionTextBox.Style.Font.Bold = True
        Me.vol_m3_GtfCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.vol_m3_GtfCaptionTextBox.StyleName = "Caption"
        Me.vol_m3_GtfCaptionTextBox.Value = "Vol. m3 (GTF)"
        '
        'vol_m3_CACaptionTextBox
        '
        Me.vol_m3_CACaptionTextBox.CanGrow = True
        Me.vol_m3_CACaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.451555252075195R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.vol_m3_CACaptionTextBox.Name = "vol_m3_CACaptionTextBox"
        Me.vol_m3_CACaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6055533885955811R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.vol_m3_CACaptionTextBox.Style.Font.Bold = True
        Me.vol_m3_CACaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.vol_m3_CACaptionTextBox.StyleName = "Caption"
        Me.vol_m3_CACaptionTextBox.Value = "Vol. m3 (C. A.)"
        '
        'vol_ptCaptionTextBox
        '
        Me.vol_ptCaptionTextBox.CanGrow = True
        Me.vol_ptCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.113887786865234R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.vol_ptCaptionTextBox.Name = "vol_ptCaptionTextBox"
        Me.vol_ptCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6055533885955811R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.vol_ptCaptionTextBox.Style.Font.Bold = True
        Me.vol_ptCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.vol_ptCaptionTextBox.StyleName = "Caption"
        Me.vol_ptCaptionTextBox.Value = "Vol. pt"
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
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.5846666693687439R)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.currentTimeTextBox, Me.pageInfoTextBox})
        Me.pageFooter.Name = "pageFooter"
        '
        'currentTimeTextBox
        '
        Me.currentTimeTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.04722222313284874R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.currentTimeTextBox.Name = "currentTimeTextBox"
        Me.currentTimeTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.8541669845581055R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.currentTimeTextBox.StyleName = "PageInfo"
        Me.currentTimeTextBox.Value = "=NOW()"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.9437265396118164R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.7757139205932617R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=PageNumber"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(1.815333366394043R)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox, Me.TxContrato, Me.TextBox45, Me.TxTitular, Me.TextBox44, Me.TextBox12, Me.TxFechaFin, Me.TxFechaIni, Me.TextBox9, Me.TxListaAserrad, Me.TextBox43, Me.TxPca, Me.TextBox13, Me.TxZafra, Me.TextBox10, Me.TxLoteTroza, Me.TextBox48})
        Me.reportHeader.Name = "reportHeader"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0048889252357184887R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(17.795110702514648R), Telerik.Reporting.Drawing.Unit.Cm(0.71533334255218506R))
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "Resumen de Trozas Aserradas"
        '
        'TxContrato
        '
        Me.TxContrato.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.913888931274414R), Telerik.Reporting.Drawing.Unit.Cm(0.81533330678939819R))
        Me.TxContrato.Name = "TxContrato"
        Me.TxContrato.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.8861117362976074R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxContrato.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxContrato.Value = ""
        '
        'TextBox45
        '
        Me.TextBox45.CanGrow = True
        Me.TextBox45.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.59999942779541R), Telerik.Reporting.Drawing.Unit.Cm(0.81533330678939819R))
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.180554986000061R), Telerik.Reporting.Drawing.Unit.Cm(0.33333343267440796R))
        Me.TextBox45.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox45.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox45.Style.Color = System.Drawing.Color.Green
        Me.TextBox45.Style.Font.Bold = True
        Me.TextBox45.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox45.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox45.StyleName = "Caption"
        Me.TextBox45.Value = "N° Contrato:"
        '
        'TxTitular
        '
        Me.TxTitular.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.80926293134689331R))
        Me.TxTitular.Name = "TxTitular"
        Me.TxTitular.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.7000007629394531R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxTitular.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxTitular.Value = ""
        '
        'TextBox44
        '
        Me.TextBox44.CanGrow = True
        Me.TextBox44.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.1062259674072266R), Telerik.Reporting.Drawing.Unit.Cm(0.80926293134689331R))
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5409994125366211R), Telerik.Reporting.Drawing.Unit.Cm(0.33333343267440796R))
        Me.TextBox44.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox44.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox44.Style.Color = System.Drawing.Color.Green
        Me.TextBox44.Style.Font.Bold = True
        Me.TextBox44.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox44.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox44.StyleName = "Caption"
        Me.TextBox44.Value = "Titular del Titulo Habilitante:"
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = True
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.6297214031219482R), Telerik.Reporting.Drawing.Unit.Cm(0.80926293134689331R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.80000007152557373R), Telerik.Reporting.Drawing.Unit.Cm(0.33333343267440796R))
        Me.TextBox12.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox12.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox12.Style.Color = System.Drawing.Color.Green
        Me.TextBox12.Style.Font.Bold = True
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox12.StyleName = "Caption"
        Me.TextBox12.Value = "Hasta:"
        '
        'TxFechaFin
        '
        Me.TxFechaFin.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.5398883819580078R), Telerik.Reporting.Drawing.Unit.Cm(0.80926293134689331R))
        Me.TxFechaFin.Name = "TxFechaFin"
        Me.TxFechaFin.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxFechaFin.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxFechaFin.Value = ""
        '
        'TxFechaIni
        '
        Me.TxFechaIni.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.89999991655349731R), Telerik.Reporting.Drawing.Unit.Cm(0.80926293134689331R))
        Me.TxFechaIni.Name = "TxFechaIni"
        Me.TxFechaIni.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxFechaIni.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxFechaIni.Value = ""
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.04722222313284874R), Telerik.Reporting.Drawing.Unit.Cm(0.80926293134689331R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.80000007152557373R), Telerik.Reporting.Drawing.Unit.Cm(0.33333343267440796R))
        Me.TextBox9.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox9.Style.Color = System.Drawing.Color.Green
        Me.TextBox9.Style.Font.Bold = True
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox9.StyleName = "Caption"
        Me.TextBox9.Value = "Desde:"
        '
        'TxListaAserrad
        '
        Me.TxListaAserrad.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.1999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(1.3092631101608276R))
        Me.TxListaAserrad.Name = "TxListaAserrad"
        Me.TxListaAserrad.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxListaAserrad.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxListaAserrad.Value = ""
        '
        'TextBox43
        '
        Me.TextBox43.CanGrow = True
        Me.TextBox43.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.397223949432373R), Telerik.Reporting.Drawing.Unit.Cm(1.3092631101608276R))
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.702776312828064R), Telerik.Reporting.Drawing.Unit.Cm(0.33333343267440796R))
        Me.TextBox43.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox43.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox43.Style.Color = System.Drawing.Color.Green
        Me.TextBox43.Style.Font.Bold = True
        Me.TextBox43.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox43.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox43.StyleName = "Caption"
        Me.TextBox43.Value = "N° Lista de Aserrío:"
        '
        'TxPca
        '
        Me.TxPca.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.7487812042236328R), Telerik.Reporting.Drawing.Unit.Cm(1.3092631101608276R))
        Me.TxPca.Name = "TxPca"
        Me.TxPca.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxPca.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxPca.Value = ""
        '
        'TextBox13
        '
        Me.TextBox13.CanGrow = True
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.6269452571868896R), Telerik.Reporting.Drawing.Unit.Cm(1.3092631101608276R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0000001192092896R), Telerik.Reporting.Drawing.Unit.Cm(0.33333343267440796R))
        Me.TextBox13.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox13.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox13.Style.Color = System.Drawing.Color.Green
        Me.TextBox13.Style.Font.Bold = True
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox13.StyleName = "Caption"
        Me.TextBox13.Value = "N° PCA:"
        '
        'TxZafra
        '
        Me.TxZafra.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.89722234010696411R), Telerik.Reporting.Drawing.Unit.Cm(1.3153336048126221R))
        Me.TxZafra.Name = "TxZafra"
        Me.TxZafra.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxZafra.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxZafra.Value = ""
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = True
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.044446229934692383R), Telerik.Reporting.Drawing.Unit.Cm(1.3153336048126221R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.80000007152557373R), Telerik.Reporting.Drawing.Unit.Cm(0.33333343267440796R))
        Me.TextBox10.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox10.Style.Color = System.Drawing.Color.Green
        Me.TextBox10.Style.Font.Bold = True
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox10.StyleName = "Caption"
        Me.TextBox10.Value = "Zafra:"
        '
        'TxLoteTroza
        '
        Me.TxLoteTroza.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.499998092651367R), Telerik.Reporting.Drawing.Unit.Cm(1.3153336048126221R))
        Me.TxLoteTroza.Name = "TxLoteTroza"
        Me.TxLoteTroza.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.33333331346511841R))
        Me.TxLoteTroza.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TxLoteTroza.Value = ""
        '
        'TextBox48
        '
        Me.TextBox48.CanGrow = True
        Me.TextBox48.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.7999992370605469R), Telerik.Reporting.Drawing.Unit.Cm(1.3092631101608276R))
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6008548736572266R), Telerik.Reporting.Drawing.Unit.Cm(0.33333343267440796R))
        Me.TextBox48.Style.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox48.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox48.Style.Color = System.Drawing.Color.Green
        Me.TextBox48.Style.Font.Bold = True
        Me.TextBox48.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox48.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox48.StyleName = "Caption"
        Me.TextBox48.Value = "N° Lote de Trozas:"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.5846666693687439R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.especieDataTextBox1, Me.t_trozasDataTextBox1, Me.vol_m3_GtfDataTextBox1, Me.vol_m3_CADataTextBox1, Me.vol_ptDataTextBox1})
        Me.detail.Name = "detail"
        '
        'especieDataTextBox1
        '
        Me.especieDataTextBox1.CanGrow = True
        Me.especieDataTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.4472222328186035R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.especieDataTextBox1.Name = "especieDataTextBox1"
        Me.especieDataTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.622889518737793R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.especieDataTextBox1.StyleName = "Data"
        Me.especieDataTextBox1.Value = "=Fields.Especie"
        '
        't_trozasDataTextBox1
        '
        Me.t_trozasDataTextBox1.CanGrow = True
        Me.t_trozasDataTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.1268916130065918R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.t_trozasDataTextBox1.Name = "t_trozasDataTextBox1"
        Me.t_trozasDataTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6055533885955811R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.t_trozasDataTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.t_trozasDataTextBox1.StyleName = "Data"
        Me.t_trozasDataTextBox1.Value = "=Fields.T_trozas"
        '
        'vol_m3_GtfDataTextBox1
        '
        Me.vol_m3_GtfDataTextBox1.CanGrow = True
        Me.vol_m3_GtfDataTextBox1.Format = "{0:N3}"
        Me.vol_m3_GtfDataTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.7892246246337891R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.vol_m3_GtfDataTextBox1.Name = "vol_m3_GtfDataTextBox1"
        Me.vol_m3_GtfDataTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6055533885955811R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.vol_m3_GtfDataTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.vol_m3_GtfDataTextBox1.StyleName = "Data"
        Me.vol_m3_GtfDataTextBox1.Value = "=Fields.Vol_m3_Gtf"
        '
        'vol_m3_CADataTextBox1
        '
        Me.vol_m3_CADataTextBox1.CanGrow = True
        Me.vol_m3_CADataTextBox1.Format = "{0:N3}"
        Me.vol_m3_CADataTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.451557159423828R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.vol_m3_CADataTextBox1.Name = "vol_m3_CADataTextBox1"
        Me.vol_m3_CADataTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6055533885955811R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.vol_m3_CADataTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.vol_m3_CADataTextBox1.StyleName = "Data"
        Me.vol_m3_CADataTextBox1.Value = "=Fields.Vol_m3_CA"
        '
        'vol_ptDataTextBox1
        '
        Me.vol_ptDataTextBox1.CanGrow = True
        Me.vol_ptDataTextBox1.Format = "{0:N3}"
        Me.vol_ptDataTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.113889694213867R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.vol_ptDataTextBox1.Name = "vol_ptDataTextBox1"
        Me.vol_ptDataTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6055533885955811R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.vol_ptDataTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.vol_ptDataTextBox1.StyleName = "Data"
        Me.vol_ptDataTextBox1.Value = "=Fields.Vol_pt"
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.5846666693687439R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.reportNameTextBox})
        Me.pageHeader.Name = "pageHeader"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.04722222313284874R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(17.752677917480469R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "Resumen de Trozas Aserradas"
        '
        'Resumen_Trozas_Aserradas
        '
        Me.DataSource = Me.ObjectDataSource1
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.aserraderoGroup, Me.labelsGroup})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.aserraderoGroupHeader, Me.aserraderoGroupFooter, Me.labelsGroupHeader, Me.labelsGroupFooter, Me.reportFooter, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.detail})
        Me.Name = "Resumen_Trozas_Aserradas"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Cm(1.5R)
        Me.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Cm(1.5R)
        Me.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Cm(1.5R)
        Me.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Cm(1.5R)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Title")})
        StyleRule1.Style.Color = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(77, Byte), Integer))
        StyleRule1.Style.Font.Name = "Calibri"
        StyleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Caption")})
        StyleRule2.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(227, Byte), Integer))
        StyleRule2.Style.Color = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(77, Byte), Integer))
        StyleRule2.Style.Font.Name = "Calibri"
        StyleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Data")})
        StyleRule3.Style.Color = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(77, Byte), Integer))
        StyleRule3.Style.Font.Name = "Calibri"
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        StyleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("PageInfo")})
        StyleRule4.Style.Color = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(77, Byte), Integer))
        StyleRule4.Style.Font.Name = "Calibri"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        StyleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(17.799999237060547R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ObjectDataSource1 As Telerik.Reporting.ObjectDataSource
    Friend WithEvents aserraderoGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents aserraderoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents aserraderoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents aserraderoGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents t_trozasSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents vol_m3_GtfSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents vol_m3_CASumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents vol_ptSumFunctionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents aserraderoGroup As Telerik.Reporting.Group
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents labelsGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents especieCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents t_trozasCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents vol_m3_GtfCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents vol_m3_CACaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents vol_ptCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents labelsGroup As Telerik.Reporting.Group
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents currentTimeTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents especieDataTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents t_trozasDataTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents vol_m3_GtfDataTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents vol_m3_CADataTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents vol_ptDataTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TxContrato As Telerik.Reporting.TextBox
    Friend WithEvents TextBox45 As Telerik.Reporting.TextBox
    Friend WithEvents TxTitular As Telerik.Reporting.TextBox
    Friend WithEvents TextBox44 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TxFechaFin As Telerik.Reporting.TextBox
    Friend WithEvents TxFechaIni As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TxListaAserrad As Telerik.Reporting.TextBox
    Friend WithEvents TextBox43 As Telerik.Reporting.TextBox
    Friend WithEvents TxPca As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TxZafra As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TxLoteTroza As Telerik.Reporting.TextBox
    Friend WithEvents TextBox48 As Telerik.Reporting.TextBox
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
End Class