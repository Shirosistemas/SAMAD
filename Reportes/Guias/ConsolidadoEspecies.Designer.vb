Partial Class ConsolidadoEspecies
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.ObjectDataSource1 = New Telerik.Reporting.ObjectDataSource()
        Me.titularGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.titularCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.titularDataTextBox = New Telerik.Reporting.TextBox()
        Me.titularGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.titularGroup = New Telerik.Reporting.Group()
        Me.labelsGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.especieCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.volumenCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.trozasCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.labelsGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.labelsGroup = New Telerik.Reporting.Group()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TitularTB = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.especieDataTextBox = New Telerik.Reporting.TextBox()
        Me.trozasDataTextBox = New Telerik.Reporting.TextBox()
        Me.volumenDataTextBox = New Telerik.Reporting.TextBox()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'ObjectDataSource1
        '
        Me.ObjectDataSource1.DataSource = GetType(SAMAD.ConsolidadoEspeciesReport)
        Me.ObjectDataSource1.Name = "ObjectDataSource1"
        '
        'titularGroupHeader
        '
        Me.titularGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.5846666693687439R)
        Me.titularGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titularCaptionTextBox, Me.titularDataTextBox})
        Me.titularGroupHeader.Name = "titularGroupHeader"
        '
        'titularCaptionTextBox
        '
        Me.titularCaptionTextBox.CanGrow = True
        Me.titularCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.titularCaptionTextBox.Name = "titularCaptionTextBox"
        Me.titularCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1465654373168945R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.titularCaptionTextBox.Style.Font.Bold = True
        Me.titularCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.titularCaptionTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.titularCaptionTextBox.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.titularCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.titularCaptionTextBox.StyleName = "Caption"
        Me.titularCaptionTextBox.Value = "Titular:"
        '
        'titularDataTextBox
        '
        Me.titularDataTextBox.CanGrow = True
        Me.titularDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.3918335437774658R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.titularDataTextBox.Name = "titularDataTextBox"
        Me.titularDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(17.438835144042969R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.titularDataTextBox.Style.Font.Bold = True
        Me.titularDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.titularDataTextBox.StyleName = "Data"
        Me.titularDataTextBox.Value = "=Fields.Titular"
        '
        'titularGroupFooter
        '
        Me.titularGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.57150000333786011R)
        Me.titularGroupFooter.Name = "titularGroupFooter"
        '
        'titularGroup
        '
        Me.titularGroup.GroupFooter = Me.titularGroupFooter
        Me.titularGroup.GroupHeader = Me.titularGroupHeader
        Me.titularGroup.Groupings.AddRange(New Telerik.Reporting.Grouping() {New Telerik.Reporting.Grouping("=Fields.Titular")})
        Me.titularGroup.Name = "titularGroup"
        '
        'labelsGroupHeader
        '
        Me.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.61533337831497192R)
        Me.labelsGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.especieCaptionTextBox, Me.volumenCaptionTextBox, Me.trozasCaptionTextBox})
        Me.labelsGroupHeader.Name = "labelsGroupHeader"
        Me.labelsGroupHeader.PrintOnEveryPage = True
        '
        'especieCaptionTextBox
        '
        Me.especieCaptionTextBox.CanGrow = True
        Me.especieCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.especieCaptionTextBox.Name = "especieCaptionTextBox"
        Me.especieCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.5820002555847168R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.especieCaptionTextBox.Style.Font.Bold = True
        Me.especieCaptionTextBox.StyleName = "Caption"
        Me.especieCaptionTextBox.Value = "Especie"
        '
        'volumenCaptionTextBox
        '
        Me.volumenCaptionTextBox.CanGrow = True
        Me.volumenCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.291001319885254R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.volumenCaptionTextBox.Name = "volumenCaptionTextBox"
        Me.volumenCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.5820002555847168R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.volumenCaptionTextBox.Style.Font.Bold = True
        Me.volumenCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.volumenCaptionTextBox.StyleName = "Caption"
        Me.volumenCaptionTextBox.Value = "Volumen"
        '
        'trozasCaptionTextBox
        '
        Me.trozasCaptionTextBox.CanGrow = True
        Me.trozasCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.6245341300964355R), Telerik.Reporting.Drawing.Unit.Cm(0.0153336888179183R))
        Me.trozasCaptionTextBox.Name = "trozasCaptionTextBox"
        Me.trozasCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.5820002555847168R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.trozasCaptionTextBox.Style.Font.Bold = True
        Me.trozasCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.trozasCaptionTextBox.StyleName = "Caption"
        Me.trozasCaptionTextBox.Value = "Trozas"
        '
        'labelsGroupFooter
        '
        Me.labelsGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.84600067138671875R)
        Me.labelsGroupFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox11, Me.TextBox12, Me.TextBox13})
        Me.labelsGroupFooter.Name = "labelsGroupFooter"
        Me.labelsGroupFooter.Style.Visible = True
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.24600048363208771R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5999997854232788R), Telerik.Reporting.Drawing.Unit.Cm(0.5000004768371582R))
        Me.TextBox11.Style.Font.Bold = True
        Me.TextBox11.Value = "Totales"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.5000004768371582R), Telerik.Reporting.Drawing.Unit.Cm(0.24600048363208771R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.64866828918457R), Telerik.Reporting.Drawing.Unit.Cm(0.5000004768371582R))
        Me.TextBox12.Style.Font.Bold = True
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox12.Value = "= Sum(Fields.Trozas)"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.96400260925293R), Telerik.Reporting.Drawing.Unit.Cm(0.24600048363208771R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.7730011940002441R), Telerik.Reporting.Drawing.Unit.Cm(0.5000004768371582R))
        Me.TextBox13.Style.Font.Bold = True
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.Value = "= Sum(Fields.Volumen)"
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
        Me.currentTimeTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.currentTimeTextBox.Name = "currentTimeTextBox"
        Me.currentTimeTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.8941669464111328R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.currentTimeTextBox.StyleName = "PageInfo"
        Me.currentTimeTextBox.Value = "=NOW()"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.97883415222168R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.8941669464111328R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=PageNumber"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(4.0153336524963379R)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.TitularTB, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox2, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10})
        Me.reportHeader.Name = "reportHeader"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.63499999046325684R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.915334701538086R), Telerik.Reporting.Drawing.Unit.Cm(0.81533330678939819R))
        Me.TextBox1.StyleName = "Title"
        Me.TextBox1.Value = "Consolidado por Especies"
        '
        'TitularTB
        '
        Me.TitularTB.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.0954999923706055R), Telerik.Reporting.Drawing.Unit.Cm(2.1166665554046631R))
        Me.TitularTB.Name = "TitularTB"
        Me.TitularTB.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(11.600001335144043R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TitularTB.Style.Font.Bold = True
        Me.TitularTB.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TitularTB.Value = ""
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(2.1166665554046631R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox3.StyleName = "Caption"
        Me.TextBox3.Value = "Titular :"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.021166665479540825R), Telerik.Reporting.Drawing.Unit.Cm(2.8363332748413086R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1677320003509521R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox4.StyleName = "Caption"
        Me.TextBox4.Value = "Nro_Zafra :"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.3918333053588867R), Telerik.Reporting.Drawing.Unit.Cm(2.8363332748413086R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9322669506073R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox5.StyleName = "Data"
        Me.TextBox5.Value = ""
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.021166665479540825R), Telerik.Reporting.Drawing.Unit.Cm(1.5153335332870483R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.457666277885437R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox2.StyleName = "Caption"
        Me.TextBox2.Value = "Desde :"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.8838332891464233R), Telerik.Reporting.Drawing.Unit.Cm(1.5153335332870483R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6833336353302R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox6.Style.Font.Bold = False
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox6.Value = ""
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.5R), Telerik.Reporting.Drawing.Unit.Cm(1.5153335332870483R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6833336353302R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox7.Style.Font.Bold = False
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox7.Value = ""
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.4609999656677246R), Telerik.Reporting.Drawing.Unit.Cm(1.5153335332870483R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.457666277885437R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox8.Style.Font.Bold = True
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox8.StyleName = "Caption"
        Me.TextBox8.Value = "Hasta :"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.0170001983642578R), Telerik.Reporting.Drawing.Unit.Cm(2.8574998378753662R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.55049991607666R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox9.StyleName = "Data"
        Me.TextBox9.Value = ""
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = True
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.6675000190734863R), Telerik.Reporting.Drawing.Unit.Cm(2.8363332748413086R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1677320003509521R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox10.Style.Font.Bold = True
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox10.StyleName = "Caption"
        Me.TextBox10.Value = "Nro_PCA :"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.57150000333786011R)
        Me.reportFooter.Name = "reportFooter"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.5846666693687439R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.especieDataTextBox, Me.trozasDataTextBox, Me.volumenDataTextBox})
        Me.detail.Name = "detail"
        '
        'especieDataTextBox
        '
        Me.especieDataTextBox.CanGrow = True
        Me.especieDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.especieDataTextBox.Name = "especieDataTextBox"
        Me.especieDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.5820002555847168R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.especieDataTextBox.StyleName = "Data"
        Me.especieDataTextBox.Value = "=Fields.Especie"
        '
        'trozasDataTextBox
        '
        Me.trozasDataTextBox.CanGrow = True
        Me.trozasDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.5R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.trozasDataTextBox.Name = "trozasDataTextBox"
        Me.trozasDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.6486687660217285R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.trozasDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.trozasDataTextBox.StyleName = "Data"
        Me.trozasDataTextBox.Value = "=Fields.Trozas"
        '
        'volumenDataTextBox
        '
        Me.volumenDataTextBox.CanGrow = True
        Me.volumenDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.96400260925293R), Telerik.Reporting.Drawing.Unit.Cm(0.084566541016101837R))
        Me.volumenDataTextBox.Name = "volumenDataTextBox"
        Me.volumenDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.7730011940002441R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.volumenDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.volumenDataTextBox.StyleName = "Data"
        Me.volumenDataTextBox.Value = "=Fields.Volumen"
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
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.830667495727539R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "ConsolidadoEspecies"
        '
        'ConsolidadoEspecies
        '
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.titularGroup, Me.labelsGroup})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titularGroupHeader, Me.titularGroupFooter, Me.labelsGroupHeader, Me.labelsGroupFooter, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.Name = "ConsolidadoEspecies"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.5R)
        Me.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Cm(0.5R)
        Me.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Cm(0.5R)
        Me.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Cm(0.5R)
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Title")})
        StyleRule1.Style.Color = System.Drawing.Color.Black
        StyleRule1.Style.Font.Bold = True
        StyleRule1.Style.Font.Italic = False
        StyleRule1.Style.Font.Name = "Tahoma"
        StyleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18.0R)
        StyleRule1.Style.Font.Strikeout = False
        StyleRule1.Style.Font.Underline = False
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Caption")})
        StyleRule2.Style.Color = System.Drawing.Color.Black
        StyleRule2.Style.Font.Name = "Tahoma"
        StyleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Data")})
        StyleRule3.Style.Font.Name = "Tahoma"
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        StyleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("PageInfo")})
        StyleRule4.Style.Font.Name = "Tahoma"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        StyleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(19.915334701538086R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ObjectDataSource1 As Telerik.Reporting.ObjectDataSource
    Friend WithEvents titularGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents titularCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents titularDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents titularGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents titularGroup As Telerik.Reporting.Group
    Friend WithEvents labelsGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents especieCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents trozasCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents volumenCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents labelsGroup As Telerik.Reporting.Group
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents currentTimeTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents especieDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents trozasDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents volumenDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TitularTB As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
End Class