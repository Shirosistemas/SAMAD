Partial Class GTFOp1
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.labelsGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.ltd_IdCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.ltd_D2CaptionTextBox = New Telerik.Reporting.TextBox()
        Me.ltd_D3CaptionTextBox = New Telerik.Reporting.TextBox()
        Me.ltd_Vol_M3CaptionTextBox = New Telerik.Reporting.TextBox()
        Me.ltd_D1CaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.ltd_CodificacionCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.labelsGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroup = New Telerik.Reporting.Group()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.ltd_IdDataTextBox = New Telerik.Reporting.TextBox()
        Me.ltd_D1DataTextBox = New Telerik.Reporting.TextBox()
        Me.ltd_D2DataTextBox = New Telerik.Reporting.TextBox()
        Me.ltd_D3DataTextBox = New Telerik.Reporting.TextBox()
        Me.ltd_Vol_M3DataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.ltd_CodificacionDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.ObjectDataSource1 = New Telerik.Reporting.ObjectDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'labelsGroupHeader
        '
        Me.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R)
        Me.labelsGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.ltd_IdCaptionTextBox, Me.ltd_D2CaptionTextBox, Me.ltd_D3CaptionTextBox, Me.ltd_Vol_M3CaptionTextBox, Me.ltd_D1CaptionTextBox, Me.TextBox7, Me.TextBox9, Me.ltd_CodificacionCaptionTextBox, Me.TextBox1})
        Me.labelsGroupHeader.Name = "labelsGroupHeader"
        Me.labelsGroupHeader.PrintOnEveryPage = True
        '
        'ltd_IdCaptionTextBox
        '
        Me.ltd_IdCaptionTextBox.CanGrow = True
        Me.ltd_IdCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.1002002954483032R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.ltd_IdCaptionTextBox.Name = "ltd_IdCaptionTextBox"
        Me.ltd_IdCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.5989954471588135R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.ltd_IdCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.ltd_IdCaptionTextBox.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.ltd_IdCaptionTextBox.Style.Font.Bold = True
        Me.ltd_IdCaptionTextBox.Style.Font.Name = "Arial"
        Me.ltd_IdCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.ltd_IdCaptionTextBox.StyleName = "Caption"
        Me.ltd_IdCaptionTextBox.Value = "Especie"
        '
        'ltd_D2CaptionTextBox
        '
        Me.ltd_D2CaptionTextBox.Angle = 0.0R
        Me.ltd_D2CaptionTextBox.CanGrow = True
        Me.ltd_D2CaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.999598503112793R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.ltd_D2CaptionTextBox.Name = "ltd_D2CaptionTextBox"
        Me.ltd_D2CaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.ltd_D2CaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.ltd_D2CaptionTextBox.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.ltd_D2CaptionTextBox.Style.Font.Bold = True
        Me.ltd_D2CaptionTextBox.Style.Font.Name = "Arial"
        Me.ltd_D2CaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.ltd_D2CaptionTextBox.StyleName = "Caption"
        Me.ltd_D2CaptionTextBox.Value = "Diam.Men"
        '
        'ltd_D3CaptionTextBox
        '
        Me.ltd_D3CaptionTextBox.CanGrow = True
        Me.ltd_D3CaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.999798774719238R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.ltd_D3CaptionTextBox.Name = "ltd_D3CaptionTextBox"
        Me.ltd_D3CaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.ltd_D3CaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.ltd_D3CaptionTextBox.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.ltd_D3CaptionTextBox.Style.Font.Bold = True
        Me.ltd_D3CaptionTextBox.Style.Font.Name = "Arial"
        Me.ltd_D3CaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.ltd_D3CaptionTextBox.StyleName = "Caption"
        Me.ltd_D3CaptionTextBox.Value = "Largo"
        '
        'ltd_Vol_M3CaptionTextBox
        '
        Me.ltd_Vol_M3CaptionTextBox.CanGrow = True
        Me.ltd_Vol_M3CaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.ltd_Vol_M3CaptionTextBox.Name = "ltd_Vol_M3CaptionTextBox"
        Me.ltd_Vol_M3CaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1998028755187988R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.ltd_Vol_M3CaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.ltd_Vol_M3CaptionTextBox.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.ltd_Vol_M3CaptionTextBox.Style.Font.Bold = True
        Me.ltd_Vol_M3CaptionTextBox.Style.Font.Name = "Arial"
        Me.ltd_Vol_M3CaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.ltd_Vol_M3CaptionTextBox.StyleName = "Caption"
        Me.ltd_Vol_M3CaptionTextBox.Value = "Vol (m3)"
        '
        'ltd_D1CaptionTextBox
        '
        Me.ltd_D1CaptionTextBox.CanGrow = True
        Me.ltd_D1CaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.9993982315063477R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.ltd_D1CaptionTextBox.Name = "ltd_D1CaptionTextBox"
        Me.ltd_D1CaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.ltd_D1CaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.ltd_D1CaptionTextBox.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.ltd_D1CaptionTextBox.Style.Font.Bold = True
        Me.ltd_D1CaptionTextBox.Style.Font.Name = "Arial"
        Me.ltd_D1CaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.ltd_D1CaptionTextBox.StyleName = "Caption"
        Me.ltd_D1CaptionTextBox.Value = "Diam.May"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = True
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1000000238418579R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox7.Style.Font.Bold = True
        Me.TextBox7.Style.Font.Name = "Arial"
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox7.StyleName = "Caption"
        Me.TextBox7.Value = "Nro"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(17.200000762939453R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4826951026916504R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox9.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox9.Style.Font.Bold = True
        Me.TextBox9.Style.Font.Name = "Arial"
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.StyleName = "Caption"
        Me.TextBox9.Value = "Nro Lista"
        '
        'ltd_CodificacionCaptionTextBox
        '
        Me.ltd_CodificacionCaptionTextBox.CanGrow = True
        Me.ltd_CodificacionCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.6993956565856934R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.ltd_CodificacionCaptionTextBox.Name = "ltd_CodificacionCaptionTextBox"
        Me.ltd_CodificacionCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2996022701263428R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.ltd_CodificacionCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.ltd_CodificacionCaptionTextBox.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.ltd_CodificacionCaptionTextBox.Style.Font.Bold = True
        Me.ltd_CodificacionCaptionTextBox.Style.Font.Name = "Arial"
        Me.ltd_CodificacionCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.ltd_CodificacionCaptionTextBox.StyleName = "Caption"
        Me.ltd_CodificacionCaptionTextBox.Value = "Codificaciòn"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9008018970489502R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "Arial"
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "Nro_GTF"
        '
        'labelsGroupFooter
        '
        Me.labelsGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.0R)
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
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.reportNameTextBox})
        Me.pageHeader.Name = "pageHeader"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.788331985473633R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "Lista de Trozas"
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155R)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.currentTimeTextBox, Me.pageInfoTextBox})
        Me.pageFooter.Name = "pageFooter"
        '
        'currentTimeTextBox
        '
        Me.currentTimeTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.currentTimeTextBox.Name = "currentTimeTextBox"
        Me.currentTimeTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.8677082061767578R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.currentTimeTextBox.Style.Font.Name = "Arial"
        Me.currentTimeTextBox.StyleName = "PageInfo"
        Me.currentTimeTextBox.Value = "=NOW()"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.973541259765625R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.8677082061767578R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.pageInfoTextBox.Style.Font.Name = "Arial"
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=PageNumber"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1856250762939453R)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox})
        Me.reportHeader.Name = "reportHeader"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.894166946411133R), Telerik.Reporting.Drawing.Unit.Cm(1.1856250762939453R))
        Me.titleTextBox.Style.Font.Bold = True
        Me.titleTextBox.Style.Font.Name = "Arial"
        Me.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "Lista de Trozas"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.7999998927116394R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.ltd_IdDataTextBox, Me.ltd_D1DataTextBox, Me.ltd_D2DataTextBox, Me.ltd_D3DataTextBox, Me.ltd_Vol_M3DataTextBox, Me.TextBox8, Me.TextBox10, Me.ltd_CodificacionDataTextBox, Me.TextBox2})
        Me.detail.Name = "detail"
        '
        'ltd_IdDataTextBox
        '
        Me.ltd_IdDataTextBox.CanGrow = True
        Me.ltd_IdDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.1002002954483032R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.ltd_IdDataTextBox.Name = "ltd_IdDataTextBox"
        Me.ltd_IdDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.5989954471588135R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.ltd_IdDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.ltd_IdDataTextBox.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.ltd_IdDataTextBox.Style.Font.Name = "Arial"
        Me.ltd_IdDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.ltd_IdDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.ltd_IdDataTextBox.StyleName = "Data"
        Me.ltd_IdDataTextBox.Value = "= Fields.Detalle.Ltd_Especie"
        '
        'ltd_D1DataTextBox
        '
        Me.ltd_D1DataTextBox.CanGrow = True
        Me.ltd_D1DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.9993982315063477R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.ltd_D1DataTextBox.Name = "ltd_D1DataTextBox"
        Me.ltd_D1DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.ltd_D1DataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.ltd_D1DataTextBox.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.ltd_D1DataTextBox.Style.Font.Name = "Arial"
        Me.ltd_D1DataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.ltd_D1DataTextBox.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.ltd_D1DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.ltd_D1DataTextBox.StyleName = "Data"
        Me.ltd_D1DataTextBox.Value = "= Fields.Detalle.Ltd_D1"
        '
        'ltd_D2DataTextBox
        '
        Me.ltd_D2DataTextBox.CanGrow = True
        Me.ltd_D2DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.999597549438477R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.ltd_D2DataTextBox.Name = "ltd_D2DataTextBox"
        Me.ltd_D2DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.ltd_D2DataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.ltd_D2DataTextBox.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.ltd_D2DataTextBox.Style.Font.Name = "Arial"
        Me.ltd_D2DataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.ltd_D2DataTextBox.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.ltd_D2DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.ltd_D2DataTextBox.StyleName = "Data"
        Me.ltd_D2DataTextBox.Value = "= Fields.Detalle.Ltd_D2"
        '
        'ltd_D3DataTextBox
        '
        Me.ltd_D3DataTextBox.CanGrow = True
        Me.ltd_D3DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.999798774719238R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.ltd_D3DataTextBox.Name = "ltd_D3DataTextBox"
        Me.ltd_D3DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.ltd_D3DataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.ltd_D3DataTextBox.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.ltd_D3DataTextBox.Style.Font.Name = "Arial"
        Me.ltd_D3DataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.ltd_D3DataTextBox.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.ltd_D3DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.ltd_D3DataTextBox.StyleName = "Data"
        Me.ltd_D3DataTextBox.Value = "= Fields.Detalle.Ltd_D3"
        '
        'ltd_Vol_M3DataTextBox
        '
        Me.ltd_Vol_M3DataTextBox.CanGrow = True
        Me.ltd_Vol_M3DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.ltd_Vol_M3DataTextBox.Name = "ltd_Vol_M3DataTextBox"
        Me.ltd_Vol_M3DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1998028755187988R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.ltd_Vol_M3DataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.ltd_Vol_M3DataTextBox.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.ltd_Vol_M3DataTextBox.Style.Font.Name = "Arial"
        Me.ltd_Vol_M3DataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.ltd_Vol_M3DataTextBox.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.ltd_Vol_M3DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.ltd_Vol_M3DataTextBox.StyleName = "Data"
        Me.ltd_Vol_M3DataTextBox.Value = "= Fields.Detalle.Ltd_Vol_M3"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1000001430511475R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox8.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox8.Style.Font.Name = "Arial"
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.StyleName = "Data"
        Me.TextBox8.Value = "= RowNumber()"
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = True
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(17.200000762939453R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4826951026916504R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox10.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox10.Style.Font.Name = "Arial"
        Me.TextBox10.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.StyleName = "Data"
        Me.TextBox10.Value = "= Fields.Detalle.Ltd_NroListaTrozas"
        '
        'ltd_CodificacionDataTextBox
        '
        Me.ltd_CodificacionDataTextBox.CanGrow = True
        Me.ltd_CodificacionDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.6993956565856934R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.ltd_CodificacionDataTextBox.Name = "ltd_CodificacionDataTextBox"
        Me.ltd_CodificacionDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2996022701263428R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.ltd_CodificacionDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.ltd_CodificacionDataTextBox.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.ltd_CodificacionDataTextBox.Style.Font.Name = "Arial"
        Me.ltd_CodificacionDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.ltd_CodificacionDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.ltd_CodificacionDataTextBox.StyleName = "Data"
        Me.ltd_CodificacionDataTextBox.Value = "= Fields.Detalle.Ltd_Codificacion"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8999996185302734R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox2.Style.Color = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "=Fields.Detalle.listatrozasc.Lt_Nrogtf"
        '
        'ObjectDataSource1
        '
        Me.ObjectDataSource1.DataSource = GetType(SAMAD.reporte01)
        Me.ObjectDataSource1.Name = "ObjectDataSource1"
        '
        'GTFOp1
        '
        Me.DataSource = Me.ObjectDataSource1
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.labelsGroup})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeader, Me.labelsGroupFooter, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.detail})
        Me.Name = "GTFOp1"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.5R)
        Me.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Cm(0.5R)
        Me.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Cm(0.5R)
        Me.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Cm(0.5R)
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(19.894166946411133R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents labelsGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents ltd_IdCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents ltd_D1CaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents ltd_D2CaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents ltd_D3CaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents ltd_Vol_M3CaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents ltd_CodificacionCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents labelsGroup As Telerik.Reporting.Group
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents currentTimeTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents ltd_IdDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents ltd_D1DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents ltd_D2DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents ltd_D3DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents ltd_Vol_M3DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents ltd_CodificacionDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents ObjectDataSource1 As Telerik.Reporting.ObjectDataSource
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
End Class