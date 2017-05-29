Partial Class ReportDespachos
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportDespachos))
        Dim FormattingRule1 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.ObjectDataSource1 = New Telerik.Reporting.ObjectDataSource()
        Me.labelsGroupHeader = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.labelsGroupFooter = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroup = New Telerik.Reporting.Group()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.TextBox69 = New Telerik.Reporting.TextBox()
        Me.TextBox70 = New Telerik.Reporting.TextBox()
        Me.TextBox71 = New Telerik.Reporting.TextBox()
        Me.TextBox74 = New Telerik.Reporting.TextBox()
        Me.TextBox73 = New Telerik.Reporting.TextBox()
        Me.TextBox72 = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.TextBox34 = New Telerik.Reporting.TextBox()
        Me.TextBox36 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox40 = New Telerik.Reporting.TextBox()
        Me.TextBox42 = New Telerik.Reporting.TextBox()
        Me.TextBox44 = New Telerik.Reporting.TextBox()
        Me.TextBox46 = New Telerik.Reporting.TextBox()
        Me.TextBox48 = New Telerik.Reporting.TextBox()
        Me.TextBox50 = New Telerik.Reporting.TextBox()
        Me.TextBox56 = New Telerik.Reporting.TextBox()
        Me.TextBox60 = New Telerik.Reporting.TextBox()
        Me.TextBox62 = New Telerik.Reporting.TextBox()
        Me.TextBox64 = New Telerik.Reporting.TextBox()
        Me.TextBox66 = New Telerik.Reporting.TextBox()
        Me.TextBox68 = New Telerik.Reporting.TextBox()
        Me.TextBox75 = New Telerik.Reporting.TextBox()
        Me.TextBox76 = New Telerik.Reporting.TextBox()
        Me.TextBox77 = New Telerik.Reporting.TextBox()
        Me.TextBox78 = New Telerik.Reporting.TextBox()
        Me.TextBox79 = New Telerik.Reporting.TextBox()
        Me.TextBox80 = New Telerik.Reporting.TextBox()
        Me.TextBox81 = New Telerik.Reporting.TextBox()
        Me.TextBox82 = New Telerik.Reporting.TextBox()
        Me.TextBox83 = New Telerik.Reporting.TextBox()
        Me.TextBox84 = New Telerik.Reporting.TextBox()
        Me.TextBox85 = New Telerik.Reporting.TextBox()
        Me.TextBox86 = New Telerik.Reporting.TextBox()
        Me.TextBox87 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox51 = New Telerik.Reporting.TextBox()
        Me.TextBox53 = New Telerik.Reporting.TextBox()
        Me.TextBox55 = New Telerik.Reporting.TextBox()
        Me.TextBox57 = New Telerik.Reporting.TextBox()
        Me.TextBox59 = New Telerik.Reporting.TextBox()
        Me.TextBox61 = New Telerik.Reporting.TextBox()
        Me.TextBox63 = New Telerik.Reporting.TextBox()
        Me.TextBox67 = New Telerik.Reporting.TextBox()
        Me.TextBox88 = New Telerik.Reporting.TextBox()
        Me.TextBox91 = New Telerik.Reporting.TextBox()
        Me.TextBox92 = New Telerik.Reporting.TextBox()
        Me.TextBox93 = New Telerik.Reporting.TextBox()
        Me.TextBox94 = New Telerik.Reporting.TextBox()
        Me.TextBox95 = New Telerik.Reporting.TextBox()
        Me.TextBox102 = New Telerik.Reporting.TextBox()
        Me.TextBox103 = New Telerik.Reporting.TextBox()
        Me.TextBox106 = New Telerik.Reporting.TextBox()
        Me.TextBox107 = New Telerik.Reporting.TextBox()
        Me.TextBox108 = New Telerik.Reporting.TextBox()
        Me.Command1 = New DevComponents.DotNetBar.Command(Me.components)
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'ObjectDataSource1
        '
        Me.ObjectDataSource1.DataSource = GetType(SAMAD.ReporteDespacho)
        Me.ObjectDataSource1.Name = "ObjectDataSource1"
        '
        'labelsGroupHeader
        '
        Me.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.5999990701675415R)
        Me.labelsGroupHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox6, Me.TextBox4, Me.TextBox5})
        Me.labelsGroupHeader.Name = "labelsGroupHeader"
        Me.labelsGroupHeader.PrintOnEveryPage = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchoring = Telerik.Reporting.AnchoringStyles.Left
        Me.TextBox1.CanGrow = True
        Me.TextBox1.CanShrink = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(-0.000000030279156959522879R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6000000238418579R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox1.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox1.Style.Color = System.Drawing.Color.Black
        Me.TextBox1.Style.Font.Bold = False
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.StyleName = "Caption"
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        '
        'TextBox2
        '
        Me.TextBox2.Anchoring = Telerik.Reporting.AnchoringStyles.Left
        Me.TextBox2.CanGrow = True
        Me.TextBox2.CanShrink = True
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.5999996662139893R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1000000238418579R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox2.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox2.Style.Color = System.Drawing.Color.Black
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.StyleName = "Caption"
        resources.ApplyResources(Me.TextBox2, "TextBox2")
        '
        'TextBox3
        '
        Me.TextBox3.Anchoring = CType((Telerik.Reporting.AnchoringStyles.Left Or Telerik.Reporting.AnchoringStyles.Right), Telerik.Reporting.AnchoringStyles)
        Me.TextBox3.CanGrow = True
        Me.TextBox3.CanShrink = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.5R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.1067700386047363R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox3.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox3.Style.Color = System.Drawing.Color.Black
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.StyleName = "Caption"
        resources.ApplyResources(Me.TextBox3, "TextBox3")
        '
        'TextBox6
        '
        Me.TextBox6.Anchoring = CType((Telerik.Reporting.AnchoringStyles.Left Or Telerik.Reporting.AnchoringStyles.Right), Telerik.Reporting.AnchoringStyles)
        Me.TextBox6.CanGrow = True
        Me.TextBox6.CanShrink = True
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.09999942779541R), Telerik.Reporting.Drawing.Unit.Cm(0.000099477132607717067R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6724611520767212R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox6.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox6.Style.Color = System.Drawing.Color.Black
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox6.StyleName = "Caption"
        resources.ApplyResources(Me.TextBox6, "TextBox6")
        '
        'TextBox4
        '
        Me.TextBox4.Anchoring = CType((Telerik.Reporting.AnchoringStyles.Left Or Telerik.Reporting.AnchoringStyles.Right), Telerik.Reporting.AnchoringStyles)
        Me.TextBox4.CanGrow = True
        Me.TextBox4.CanShrink = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.566196441650391R), Telerik.Reporting.Drawing.Unit.Cm(0.084467709064483643R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3144558668136597R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox4.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox4.Style.Color = System.Drawing.Color.Black
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.StyleName = "Caption"
        resources.ApplyResources(Me.TextBox4, "TextBox4")
        '
        'TextBox5
        '
        Me.TextBox5.Anchoring = CType((Telerik.Reporting.AnchoringStyles.Left Or Telerik.Reporting.AnchoringStyles.Right), Telerik.Reporting.AnchoringStyles)
        Me.TextBox5.CanGrow = True
        Me.TextBox5.CanShrink = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(17.899999618530273R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.2060362100601196R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox5.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox5.Style.Color = System.Drawing.Color.Black
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.StyleName = "Caption"
        resources.ApplyResources(Me.TextBox5, "TextBox5")
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
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(1.3999999761581421R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.reportNameTextBox})
        Me.pageHeader.Name = "pageHeader"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.10000003129243851R))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(20.0R), Telerik.Reporting.Drawing.Unit.Cm(1.2999999523162842R))
        Me.reportNameTextBox.StyleName = "PageInfo"
        resources.ApplyResources(Me.reportNameTextBox, "reportNameTextBox")
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
        Me.currentTimeTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.8541669845581055R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.currentTimeTextBox.StyleName = "PageInfo"
        resources.ApplyResources(Me.currentTimeTextBox, "currentTimeTextBox")
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.9388337135314941R), Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.8541669845581055R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pageInfoTextBox.StyleName = "PageInfo"
        resources.ApplyResources(Me.pageInfoTextBox, "pageInfoTextBox")
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.5675971508026123R)
        Me.reportFooter.Name = "reportFooter"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.61533272266387939R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox69, Me.TextBox70, Me.TextBox71, Me.TextBox74, Me.TextBox73, Me.TextBox72})
        Me.detail.Name = "detail"
        '
        'TextBox69
        '
        Me.TextBox69.CanGrow = True
        Me.TextBox69.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.04233333095908165R), Telerik.Reporting.Drawing.Unit.Cm(0.11533275246620178R))
        Me.TextBox69.Name = "TextBox69"
        Me.TextBox69.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6576665639877319R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox69.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox69.StyleName = "Data"
        resources.ApplyResources(Me.TextBox69, "TextBox69")
        '
        'TextBox70
        '
        Me.TextBox70.CanGrow = True
        Me.TextBox70.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.7000000476837158R), Telerik.Reporting.Drawing.Unit.Cm(0.072999417781829834R))
        Me.TextBox70.Name = "TextBox70"
        Me.TextBox70.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6254991292953491R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox70.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox70.StyleName = "Data"
        resources.ApplyResources(Me.TextBox70, "TextBox70")
        '
        'TextBox71
        '
        Me.TextBox71.CanGrow = True
        Me.TextBox71.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.1999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.072999417781829834R))
        Me.TextBox71.Name = "TextBox71"
        Me.TextBox71.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.4066715240478516R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox71.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox71.StyleName = "Data"
        resources.ApplyResources(Me.TextBox71, "TextBox71")
        '
        'TextBox74
        '
        Me.TextBox74.CanGrow = True
        Me.TextBox74.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.6999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.072999417781829834R))
        Me.TextBox74.Name = "TextBox74"
        Me.TextBox74.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.8527777194976807R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox74.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox74.StyleName = "Data"
        resources.ApplyResources(Me.TextBox74, "TextBox74")
        '
        'TextBox73
        '
        Me.TextBox73.Anchoring = Telerik.Reporting.AnchoringStyles.Right
        Me.TextBox73.CanGrow = True
        Me.TextBox73.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(18.000099182128906R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox73.Name = "TextBox73"
        Me.TextBox73.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.7092773914337158R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox73.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox73.StyleName = "Data"
        resources.ApplyResources(Me.TextBox73, "TextBox73")
        '
        'TextBox72
        '
        Me.TextBox72.CanGrow = True
        Me.TextBox72.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.800000190734863R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox72.Name = "TextBox72"
        Me.TextBox72.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4948641061782837R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox72.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox72.StyleName = "Data"
        resources.ApplyResources(Me.TextBox72, "TextBox72")
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(14.100000381469727R)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox8, Me.TextBox12, Me.TextBox14, Me.TextBox18, Me.TextBox20, Me.TextBox22, Me.TextBox24, Me.TextBox26, Me.TextBox28, Me.TextBox30, Me.TextBox32, Me.TextBox34, Me.TextBox36, Me.TextBox38, Me.TextBox40, Me.TextBox42, Me.TextBox44, Me.TextBox46, Me.TextBox48, Me.TextBox50, Me.TextBox56, Me.TextBox60, Me.TextBox62, Me.TextBox64, Me.TextBox66, Me.TextBox68, Me.TextBox75, Me.TextBox76, Me.TextBox77, Me.TextBox78, Me.TextBox79, Me.TextBox80, Me.TextBox81, Me.TextBox82, Me.TextBox83, Me.TextBox84, Me.TextBox85, Me.TextBox86, Me.TextBox87, Me.TextBox7, Me.TextBox9, Me.TextBox17, Me.TextBox19, Me.TextBox21, Me.TextBox25, Me.TextBox51, Me.TextBox53, Me.TextBox55, Me.TextBox57, Me.TextBox59, Me.TextBox61, Me.TextBox63, Me.TextBox67, Me.TextBox88, Me.TextBox91, Me.TextBox92, Me.TextBox93, Me.TextBox94, Me.TextBox95, Me.TextBox102, Me.TextBox103, Me.TextBox106, Me.TextBox107, Me.TextBox108})
        Me.reportHeader.Name = "reportHeader"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Format = "{0:d}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.6999996900558472R), Telerik.Reporting.Drawing.Unit.Cm(0.347222238779068R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.7407470941543579R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox8.StyleName = "Data"
        resources.ApplyResources(Me.TextBox8, "TextBox8")
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = True
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.3138890266418457R), Telerik.Reporting.Drawing.Unit.Cm(3.2805550098419189R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.0084247589111328R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox12.StyleName = "Data"
        resources.ApplyResources(Me.TextBox12, "TextBox12")
        '
        'TextBox14
        '
        Me.TextBox14.CanGrow = True
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.200201034545898R), Telerik.Reporting.Drawing.Unit.Cm(3.2805554866790771R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.580352783203125R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox14.StyleName = "Data"
        resources.ApplyResources(Me.TextBox14, "TextBox14")
        '
        'TextBox18
        '
        Me.TextBox18.CanGrow = True
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.5805559158325195R), Telerik.Reporting.Drawing.Unit.Cm(4.4805560111999512R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.4194440841674805R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox18.StyleName = "Data"
        resources.ApplyResources(Me.TextBox18, "TextBox18")
        '
        'TextBox20
        '
        Me.TextBox20.CanGrow = True
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.93722915649414R), Telerik.Reporting.Drawing.Unit.Cm(4.48199987411499R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.957740306854248R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox20.StyleName = "Data"
        resources.ApplyResources(Me.TextBox20, "TextBox20")
        '
        'TextBox22
        '
        Me.TextBox22.CanGrow = True
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.980554580688477R), Telerik.Reporting.Drawing.Unit.Cm(4.4820008277893066R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.8999998569488525R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox22.StyleName = "Data"
        resources.ApplyResources(Me.TextBox22, "TextBox22")
        '
        'TextBox24
        '
        Me.TextBox24.CanGrow = True
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.2143328189849854R), Telerik.Reporting.Drawing.Unit.Cm(6.0666670799255371R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.9470629692077637R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox24.StyleName = "Data"
        resources.ApplyResources(Me.TextBox24, "TextBox24")
        '
        'TextBox26
        '
        Me.TextBox26.CanGrow = True
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.9999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(6.6666669845581055R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2999999523162842R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox26.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox26.StyleName = "Data"
        resources.ApplyResources(Me.TextBox26, "TextBox26")
        '
        'TextBox28
        '
        Me.TextBox28.CanGrow = True
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.09999942779541R), Telerik.Reporting.Drawing.Unit.Cm(6.0805554389953613R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.7830390930175781R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox28.StyleName = "Data"
        resources.ApplyResources(Me.TextBox28, "TextBox28")
        '
        'TextBox30
        '
        Me.TextBox30.CanGrow = True
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.2000000476837158R), Telerik.Reporting.Drawing.Unit.Cm(8.01388931274414R))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.0886330604553223R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox30.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox30.StyleName = "Data"
        resources.ApplyResources(Me.TextBox30, "TextBox30")
        '
        'TextBox32
        '
        Me.TextBox32.CanGrow = True
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.0272424221038818R), Telerik.Reporting.Drawing.Unit.Cm(9.1812143325805664R))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.7255001068115234R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox32.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox32.StyleName = "Data"
        resources.ApplyResources(Me.TextBox32, "TextBox32")
        '
        'TextBox34
        '
        Me.TextBox34.CanGrow = True
        Me.TextBox34.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.0472230911254883R), Telerik.Reporting.Drawing.Unit.Cm(9.1812162399292R))
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9304392337799072R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox34.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox34.StyleName = "Data"
        resources.ApplyResources(Me.TextBox34, "TextBox34")
        '
        'TextBox36
        '
        Me.TextBox36.CanGrow = True
        Me.TextBox36.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.513889312744141R), Telerik.Reporting.Drawing.Unit.Cm(9.1812171936035156R))
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0892786979675293R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox36.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox36.StyleName = "Data"
        resources.ApplyResources(Me.TextBox36, "TextBox36")
        '
        'TextBox38
        '
        Me.TextBox38.CanGrow = True
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.51388931274414R), Telerik.Reporting.Drawing.Unit.Cm(6.6666669845581055R))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.003166675567627R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox38.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox38.StyleName = "Data"
        resources.ApplyResources(Me.TextBox38, "TextBox38")
        '
        'TextBox40
        '
        Me.TextBox40.CanGrow = True
        Me.TextBox40.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.0272424221038818R), Telerik.Reporting.Drawing.Unit.Cm(8.5673789978027344R))
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.32550048828125R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox40.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox40.StyleName = "Data"
        resources.ApplyResources(Me.TextBox40, "TextBox40")
        '
        'TextBox42
        '
        Me.TextBox42.CanGrow = True
        Me.TextBox42.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.913888931274414R), Telerik.Reporting.Drawing.Unit.Cm(8.0138883590698242R))
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.6892790794372559R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox42.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox42.StyleName = "Data"
        resources.ApplyResources(Me.TextBox42, "TextBox42")
        '
        'TextBox44
        '
        Me.TextBox44.CanGrow = True
        Me.TextBox44.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.5R), Telerik.Reporting.Drawing.Unit.Cm(10.547221183776855R))
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.1997995376586914R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox44.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox44.StyleName = "Data"
        resources.ApplyResources(Me.TextBox44, "TextBox44")
        '
        'TextBox46
        '
        Me.TextBox46.CanGrow = True
        Me.TextBox46.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(11.106963157653809R))
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4095957279205322R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox46.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox46.StyleName = "Data"
        resources.ApplyResources(Me.TextBox46, "TextBox46")
        '
        'TextBox48
        '
        Me.TextBox48.CanGrow = True
        Me.TextBox48.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.398430824279785R), Telerik.Reporting.Drawing.Unit.Cm(10.522478103637695R))
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.3621354103088379R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox48.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox48.StyleName = "Data"
        resources.ApplyResources(Me.TextBox48, "TextBox48")
        '
        'TextBox50
        '
        Me.TextBox50.CanGrow = True
        Me.TextBox50.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.799999237060547R), Telerik.Reporting.Drawing.Unit.Cm(11.106963157653809R))
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.8031673431396484R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox50.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox50.StyleName = "Data"
        resources.ApplyResources(Me.TextBox50, "TextBox50")
        '
        'TextBox56
        '
        Me.TextBox56.CanGrow = True
        Me.TextBox56.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.2472221851348877R), Telerik.Reporting.Drawing.Unit.Cm(3.8666672706604004R))
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.7527780532836914R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox56.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox56.StyleName = "Data"
        resources.ApplyResources(Me.TextBox56, "TextBox56")
        '
        'TextBox60
        '
        Me.TextBox60.CanGrow = True
        Me.TextBox60.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.511167049407959R), Telerik.Reporting.Drawing.Unit.Cm(11.106963157653809R))
        Me.TextBox60.Name = "TextBox60"
        Me.TextBox60.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.4888334274291992R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox60.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox60.StyleName = "Data"
        resources.ApplyResources(Me.TextBox60, "TextBox60")
        '
        'TextBox62
        '
        Me.TextBox62.CanGrow = True
        Me.TextBox62.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.0R), Telerik.Reporting.Drawing.Unit.Cm(12.480555534362793R))
        Me.TextBox62.Name = "TextBox62"
        Me.TextBox62.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9571943283081055R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox62.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox62.StyleName = "Data"
        resources.ApplyResources(Me.TextBox62, "TextBox62")
        '
        'TextBox64
        '
        Me.TextBox64.CanGrow = True
        Me.TextBox64.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.0R), Telerik.Reporting.Drawing.Unit.Cm(13.024317741394043R))
        Me.TextBox64.Name = "TextBox64"
        Me.TextBox64.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9571943283081055R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox64.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox64.StyleName = "Data"
        resources.ApplyResources(Me.TextBox64, "TextBox64")
        '
        'TextBox66
        '
        Me.TextBox66.CanGrow = True
        Me.TextBox66.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.720832824707031R), Telerik.Reporting.Drawing.Unit.Cm(12.484569549560547R))
        Me.TextBox66.Name = "TextBox66"
        Me.TextBox66.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.6999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox66.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox66.StyleName = "Data"
        resources.ApplyResources(Me.TextBox66, "TextBox66")
        '
        'TextBox68
        '
        Me.TextBox68.CanGrow = True
        Me.TextBox68.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.720832824707031R), Telerik.Reporting.Drawing.Unit.Cm(13.140735626220703R))
        Me.TextBox68.Name = "TextBox68"
        Me.TextBox68.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.6999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox68.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox68.StyleName = "Data"
        resources.ApplyResources(Me.TextBox68, "TextBox68")
        '
        'TextBox75
        '
        Me.TextBox75.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.10000003129243851R), Telerik.Reporting.Drawing.Unit.Cm(0.34722200036048889R))
        Me.TextBox75.Name = "TextBox75"
        Me.TextBox75.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6000000238418579R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox75.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox75.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox75, "TextBox75")
        '
        'TextBox76
        '
        Me.TextBox76.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.18055534362793R), Telerik.Reporting.Drawing.Unit.Cm(3.882000207901001R))
        Me.TextBox76.Name = "TextBox76"
        Me.TextBox76.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0044534206390381R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox76.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox76.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox76, "TextBox76")
        '
        'TextBox77
        '
        Me.TextBox77.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.10000003129243851R), Telerik.Reporting.Drawing.Unit.Cm(3.882000207901001R))
        Me.TextBox77.Name = "TextBox77"
        Me.TextBox77.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox77.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox77.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox77, "TextBox77")
        '
        'TextBox78
        '
        Me.TextBox78.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.10000003129243851R), Telerik.Reporting.Drawing.Unit.Cm(3.2820003032684326R))
        Me.TextBox78.Name = "TextBox78"
        Me.TextBox78.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.1643338203430176R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox78.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox78.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox78, "TextBox78")
        '
        'TextBox79
        '
        Me.TextBox79.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.975821495056152R), Telerik.Reporting.Drawing.Unit.Cm(1.3999999761581421R))
        Me.TextBox79.Name = "TextBox79"
        Me.TextBox79.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5800116062164307R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox79.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox79.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox79, "TextBox79")
        '
        'TextBox80
        '
        Me.TextBox80.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.10000003129243851R), Telerik.Reporting.Drawing.Unit.Cm(2.7625548839569092R))
        Me.TextBox80.Name = "TextBox80"
        Me.TextBox80.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.90000057220459R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox80.Style.Font.Bold = True
        Me.TextBox80.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox80.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox80, "TextBox80")
        '
        'TextBox81
        '
        Me.TextBox81.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.10000003129243851R), Telerik.Reporting.Drawing.Unit.Cm(4.48199987411499R))
        Me.TextBox81.Name = "TextBox81"
        Me.TextBox81.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4472579956054687R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox81.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox81.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox81, "TextBox81")
        '
        'TextBox82
        '
        Me.TextBox82.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.38065242767334R), Telerik.Reporting.Drawing.Unit.Cm(2.1999998092651367R))
        Me.TextBox82.Name = "TextBox82"
        Me.TextBox82.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.276846170425415R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox82.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox82.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox82, "TextBox82")
        '
        'TextBox83
        '
        Me.TextBox83.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.099998474121094R), Telerik.Reporting.Drawing.Unit.Cm(0.76275533437728882R))
        Me.TextBox83.Name = "TextBox83"
        Me.TextBox83.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5800116062164307R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox83.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox83.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox83, "TextBox83")
        '
        'TextBox84
        '
        FormattingRule1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox84.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule1})
        Me.TextBox84.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.899999618530273R), Telerik.Reporting.Drawing.Unit.Cm(0.262555330991745R))
        Me.TextBox84.Name = "TextBox84"
        Me.TextBox84.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.7800116539001465R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox84.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox84.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox84, "TextBox84")
        '
        'TextBox85
        '
        Me.TextBox85.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.18055534362793R), Telerik.Reporting.Drawing.Unit.Cm(4.48199987411499R))
        Me.TextBox85.Name = "TextBox85"
        Me.TextBox85.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.7000001668930054R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox85.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox85.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox85, "TextBox85")
        '
        'TextBox86
        '
        Me.TextBox86.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.895168304443359R), Telerik.Reporting.Drawing.Unit.Cm(4.48199987411499R))
        Me.TextBox86.Name = "TextBox86"
        Me.TextBox86.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0853888988494873R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox86.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox86.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox86, "TextBox86")
        '
        'TextBox87
        '
        Me.TextBox87.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.380556106567383R), Telerik.Reporting.Drawing.Unit.Cm(3.9067425727844238R))
        Me.TextBox87.Name = "TextBox87"
        Me.TextBox87.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.8194451332092285R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox87.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox87.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox87, "TextBox87")
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.322513580322266R), Telerik.Reporting.Drawing.Unit.Cm(3.2805554866790771R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8774865865707397R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox7, "TextBox7")
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.161594390869141R), Telerik.Reporting.Drawing.Unit.Cm(6.0666666030883789R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9384044408798218R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox9, "TextBox9")
        '
        'TextBox17
        '
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(6.6666660308837891R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox17.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox17, "TextBox17")
        '
        'TextBox19
        '
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(5.5009994506835938R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.7220442295074463R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox19.Style.Font.Bold = True
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox19.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox19, "TextBox19")
        '
        'TextBox21
        '
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(6.0666666030883789R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.2000000476837158R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox21.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox21.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox21, "TextBox21")
        '
        'TextBox25
        '
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.5R), Telerik.Reporting.Drawing.Unit.Cm(6.6666660308837891R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0044534206390381R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox25.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox25.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox25, "TextBox25")
        '
        'TextBox51
        '
        Me.TextBox51.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.6945219039917R), Telerik.Reporting.Drawing.Unit.Cm(8.5673789978027344R))
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0044534206390381R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox51.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox51.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox51, "TextBox51")
        '
        'TextBox53
        '
        Me.TextBox53.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.014833396300673485R), Telerik.Reporting.Drawing.Unit.Cm(8.5673789978027344R))
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9851666688919067R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox53.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox53.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox53, "TextBox53")
        '
        'TextBox55
        '
        Me.TextBox55.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.014833396300673485R), Telerik.Reporting.Drawing.Unit.Cm(8.0253791809082031R))
        Me.TextBox55.Name = "TextBox55"
        Me.TextBox55.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.185166597366333R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox55.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox55.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox55, "TextBox55")
        '
        'TextBox57
        '
        Me.TextBox57.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.014833396300673485R), Telerik.Reporting.Drawing.Unit.Cm(7.487879753112793R))
        Me.TextBox57.Name = "TextBox57"
        Me.TextBox57.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.9851672649383545R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox57.Style.Font.Bold = True
        Me.TextBox57.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox57.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox57, "TextBox57")
        '
        'TextBox59
        '
        Me.TextBox59.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.014833396300673485R), Telerik.Reporting.Drawing.Unit.Cm(9.18121337890625R))
        Me.TextBox59.Name = "TextBox59"
        Me.TextBox59.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9851666688919067R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox59.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox59.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox59, "TextBox59")
        '
        'TextBox61
        '
        Me.TextBox61.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.7805562019348145R), Telerik.Reporting.Drawing.Unit.Cm(9.18121337890625R))
        Me.TextBox61.Name = "TextBox61"
        Me.TextBox61.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.2194454669952393R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox61.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox61.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox61, "TextBox61")
        '
        'TextBox63
        '
        Me.TextBox63.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.980555534362793R), Telerik.Reporting.Drawing.Unit.Cm(9.18121337890625R))
        Me.TextBox63.Name = "TextBox63"
        Me.TextBox63.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5194461345672607R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox63.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox63.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox63, "TextBox63")
        '
        'TextBox67
        '
        Me.TextBox67.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.980555534362793R), Telerik.Reporting.Drawing.Unit.Cm(8.0138883590698242R))
        Me.TextBox67.Name = "TextBox67"
        Me.TextBox67.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9144124984741211R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox67.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox67.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox67, "TextBox67")
        '
        'TextBox88
        '
        Me.TextBox88.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.1984319686889648R), Telerik.Reporting.Drawing.Unit.Cm(10.547221183776855R))
        Me.TextBox88.Name = "TextBox88"
        Me.TextBox88.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2000010013580322R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox88.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox88.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox88, "TextBox88")
        '
        'TextBox91
        '
        Me.TextBox91.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.347258567810059R), Telerik.Reporting.Drawing.Unit.Cm(11.082221031188965R))
        Me.TextBox91.Name = "TextBox91"
        Me.TextBox91.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4104828834533691R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox91.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox91.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox91, "TextBox91")
        '
        'TextBox92
        '
        Me.TextBox92.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(11.106963157653809R))
        Me.TextBox92.Name = "TextBox92"
        Me.TextBox92.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4407472610473633R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox92.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox92.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox92, "TextBox92")
        '
        'TextBox93
        '
        Me.TextBox93.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0036664428189396858R), Telerik.Reporting.Drawing.Unit.Cm(10.027463912963867R))
        Me.TextBox93.Name = "TextBox93"
        Me.TextBox93.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.196333646774292R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox93.Style.Font.Bold = True
        Me.TextBox93.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox93.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox93, "TextBox93")
        '
        'TextBox94
        '
        Me.TextBox94.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(10.571964263916016R))
        Me.TextBox94.Name = "TextBox94"
        Me.TextBox94.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4407472610473633R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox94.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox94.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox94, "TextBox94")
        '
        'TextBox95
        '
        Me.TextBox95.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.0R), Telerik.Reporting.Drawing.Unit.Cm(11.106963157653809R))
        Me.TextBox95.Name = "TextBox95"
        Me.TextBox95.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6997989416122437R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox95.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox95.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        resources.ApplyResources(Me.TextBox95, "TextBox95")
        '
        'TextBox102
        '
        Me.TextBox102.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.0R), Telerik.Reporting.Drawing.Unit.Cm(12.484569549560547R))
        Me.TextBox102.Name = "TextBox102"
        Me.TextBox102.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6905486583709717R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox102.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        resources.ApplyResources(Me.TextBox102, "TextBox102")
        '
        'TextBox103
        '
        Me.TextBox103.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.0R), Telerik.Reporting.Drawing.Unit.Cm(13.140735626220703R))
        Me.TextBox103.Name = "TextBox103"
        Me.TextBox103.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6905486583709717R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox103.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        resources.ApplyResources(Me.TextBox103, "TextBox103")
        '
        'TextBox106
        '
        Me.TextBox106.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(13.140735626220703R))
        Me.TextBox106.Name = "TextBox106"
        Me.TextBox106.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.0R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox106.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        resources.ApplyResources(Me.TextBox106, "TextBox106")
        '
        'TextBox107
        '
        Me.TextBox107.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0036664428189396858R), Telerik.Reporting.Drawing.Unit.Cm(12.040069580078125R))
        Me.TextBox107.Name = "TextBox107"
        Me.TextBox107.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.9963335990905762R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox107.Style.Font.Bold = True
        Me.TextBox107.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        resources.ApplyResources(Me.TextBox107, "TextBox107")
        '
        'TextBox108
        '
        Me.TextBox108.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0036664428189396858R), Telerik.Reporting.Drawing.Unit.Cm(12.584054946899414R))
        Me.TextBox108.Name = "TextBox108"
        Me.TextBox108.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.9963335990905762R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox108.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        resources.ApplyResources(Me.TextBox108, "TextBox108")
        '
        'Command1
        '
        Me.Command1.Name = "Command1"
        '
        'ReportDespachos
        '
        Me.DataSource = Me.ObjectDataSource1
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Me.labelsGroup})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeader, Me.labelsGroupFooter, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.Name = "ReportDespachos"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.5R)
        Me.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Cm(0.5R)
        Me.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Cm(0.5R)
        Me.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Cm(0.5R)
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
        Me.UnitOfMeasure = Telerik.Reporting.Drawing.UnitType.Cm
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(20.0R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ObjectDataSource1 As Telerik.Reporting.ObjectDataSource
    Friend WithEvents labelsGroupHeader As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooter As Telerik.Reporting.GroupFooterSection
    Friend WithEvents labelsGroup As Telerik.Reporting.Group
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents currentTimeTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents TextBox69 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox70 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox71 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox72 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox73 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox74 As Telerik.Reporting.TextBox
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox32 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox34 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox36 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox40 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox42 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox44 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox46 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox48 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox50 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox56 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox60 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox62 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox64 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox66 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox68 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox75 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox76 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox77 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox78 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox79 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox80 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox81 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox82 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox83 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox84 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox85 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox86 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox87 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox51 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox53 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox55 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox57 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox59 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox61 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox63 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox67 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox88 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox91 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox92 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox93 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox94 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox95 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox102 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox103 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox106 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox107 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox108 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents Command1 As DevComponents.DotNetBar.Command
    Private components As System.ComponentModel.IContainer
End Class