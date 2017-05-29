<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wfContratos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RibbonBar1 = New DevComponents.DotNetBar.RibbonBar()
        Me.btNuevo = New DevComponents.DotNetBar.ButtonItem()
        Me.btEditar = New DevComponents.DotNetBar.ButtonItem()
        Me.btBorrar = New DevComponents.DotNetBar.ButtonItem()
        Me.btUpdate = New DevComponents.DotNetBar.ButtonItem()
        Me.btImprimir = New DevComponents.DotNetBar.ButtonItem()
        Me.btSalir = New DevComponents.DotNetBar.ButtonItem()
        Me.txId = New DevComponents.DotNetBar.TextBoxItem()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.txIdc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.txNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txTID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txYear = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txNumero = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btAtras = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.dgContratos = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.GridColumn1 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GridColumn2 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GridColumn3 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.sPlitter = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.GridColumn4 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar1.ContainerControlProcessDialogKey = True
        Me.RibbonBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonBar1.DragDropSupport = True
        Me.RibbonBar1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btNuevo, Me.btEditar, Me.btBorrar, Me.btUpdate, Me.btImprimir, Me.btSalir, Me.txId})
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Size = New System.Drawing.Size(613, 69)
        Me.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar1.TabIndex = 0
        Me.RibbonBar1.Text = "RibbonBar1"
        '
        '
        '
        Me.RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar1.TitleVisible = False
        '
        'btNuevo
        '
        Me.btNuevo.Image = Global.SAMAD.My.Resources.Resources.Nvo
        Me.btNuevo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.SubItemsExpandWidth = 14
        Me.btNuevo.Text = "Agregar"
        Me.btNuevo.Tooltip = "Agregar nuevo Contrato"
        '
        'btEditar
        '
        Me.btEditar.Image = Global.SAMAD.My.Resources.Resources.Edit
        Me.btEditar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btEditar.Name = "btEditar"
        Me.btEditar.SubItemsExpandWidth = 14
        Me.btEditar.Text = "Editar"
        Me.btEditar.Tooltip = "Editar contrato existente"
        '
        'btBorrar
        '
        Me.btBorrar.Image = Global.SAMAD.My.Resources.Resources.Del
        Me.btBorrar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btBorrar.Name = "btBorrar"
        Me.btBorrar.SubItemsExpandWidth = 14
        Me.btBorrar.Text = "Borrar"
        Me.btBorrar.Tooltip = "borrar un contrato existente"
        '
        'btUpdate
        '
        Me.btUpdate.Image = Global.SAMAD.My.Resources.Resources.Update
        Me.btUpdate.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.SubItemsExpandWidth = 14
        Me.btUpdate.Text = "Actualiza"
        Me.btUpdate.Tooltip = "Actualizar lista de contratos"
        '
        'btImprimir
        '
        Me.btImprimir.Image = Global.SAMAD.My.Resources.Resources.Print
        Me.btImprimir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.SubItemsExpandWidth = 14
        Me.btImprimir.Text = "Imprimir"
        Me.btImprimir.Tooltip = "Imprime lista de Contratos"
        '
        'btSalir
        '
        Me.btSalir.Image = Global.SAMAD.My.Resources.Resources._Exit
        Me.btSalir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btSalir.Name = "btSalir"
        Me.btSalir.SubItemsExpandWidth = 14
        Me.btSalir.Text = "Salir"
        Me.btSalir.Tooltip = "Salir al menu principal"
        '
        'txId
        '
        Me.txId.Name = "txId"
        Me.txId.WatermarkColor = System.Drawing.SystemColors.GrayText
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.txIdc)
        Me.PanelEx1.Controls.Add(Me.ButtonX1)
        Me.PanelEx1.Controls.Add(Me.txNombre)
        Me.PanelEx1.Controls.Add(Me.txTID)
        Me.PanelEx1.Controls.Add(Me.txYear)
        Me.PanelEx1.Controls.Add(Me.txNumero)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.btAtras)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 69)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(613, 94)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        Me.PanelEx1.Text = "PanelEx1"
        '
        'txIdc
        '
        '
        '
        '
        Me.txIdc.Border.Class = "TextBoxBorder"
        Me.txIdc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txIdc.Location = New System.Drawing.Point(447, 12)
        Me.txIdc.Name = "txIdc"
        Me.txIdc.PreventEnterBeep = True
        Me.txIdc.Size = New System.Drawing.Size(89, 20)
        Me.txIdc.TabIndex = 10
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(436, 45)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(100, 39)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 9
        Me.ButtonX1.Text = "Grabar"
        '
        'txNombre
        '
        '
        '
        '
        Me.txNombre.Border.Class = "TextBoxBorder"
        Me.txNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txNombre.Location = New System.Drawing.Point(182, 64)
        Me.txNombre.Name = "txNombre"
        Me.txNombre.PreventEnterBeep = True
        Me.txNombre.Size = New System.Drawing.Size(248, 20)
        Me.txNombre.TabIndex = 8
        Me.txNombre.WatermarkText = "Nombre del Titular"
        '
        'txTID
        '
        '
        '
        '
        Me.txTID.Border.Class = "TextBoxBorder"
        Me.txTID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txTID.Location = New System.Drawing.Point(139, 64)
        Me.txTID.Name = "txTID"
        Me.txTID.PreventEnterBeep = True
        Me.txTID.Size = New System.Drawing.Size(41, 20)
        Me.txTID.TabIndex = 7
        Me.txTID.WatermarkText = "ID"
        '
        'txYear
        '
        '
        '
        '
        Me.txYear.Border.Class = "TextBoxBorder"
        Me.txYear.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txYear.Location = New System.Drawing.Point(139, 37)
        Me.txYear.MaxLength = 4
        Me.txYear.Name = "txYear"
        Me.txYear.PreventEnterBeep = True
        Me.txYear.Size = New System.Drawing.Size(51, 20)
        Me.txYear.TabIndex = 6
        Me.txYear.WatermarkText = "2015"
        '
        'txNumero
        '
        '
        '
        '
        Me.txNumero.Border.Class = "TextBoxBorder"
        Me.txNumero.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txNumero.Location = New System.Drawing.Point(139, 10)
        Me.txNumero.MaxLength = 99
        Me.txNumero.Name = "txNumero"
        Me.txNumero.PreventEnterBeep = True
        Me.txNumero.Size = New System.Drawing.Size(257, 20)
        Me.txNumero.TabIndex = 5
        Me.txNumero.WatermarkText = "12345678901"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Titular del Contrato"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Año del Contrato"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "No Contrato forestal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(423, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id"
        '
        'btAtras
        '
        Me.btAtras.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAtras.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAtras.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAtras.Image = Global.SAMAD.My.Resources.Resources.I320198
        Me.btAtras.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btAtras.Location = New System.Drawing.Point(540, 14)
        Me.btAtras.Name = "btAtras"
        Me.btAtras.Size = New System.Drawing.Size(66, 70)
        Me.btAtras.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btAtras.TabIndex = 0
        Me.btAtras.Text = "Regresar"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.dgContratos)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx2.Location = New System.Drawing.Point(0, 163)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(613, 191)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 2
        Me.PanelEx2.Text = "PanelEx2"
        '
        'dgContratos
        '
        Me.dgContratos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgContratos.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.dgContratos.Location = New System.Drawing.Point(0, 0)
        Me.dgContratos.Name = "dgContratos"
        '
        '
        '
        Me.dgContratos.PrimaryGrid.Columns.Add(Me.GridColumn1)
        Me.dgContratos.PrimaryGrid.Columns.Add(Me.GridColumn2)
        Me.dgContratos.PrimaryGrid.Columns.Add(Me.GridColumn3)
        Me.dgContratos.PrimaryGrid.Columns.Add(Me.GridColumn4)
        Me.dgContratos.Size = New System.Drawing.Size(613, 191)
        Me.dgContratos.TabIndex = 0
        Me.dgContratos.Text = "SuperGridControl1"
        '
        'GridColumn1
        '
        Me.GridColumn1.HeaderText = "Id"
        Me.GridColumn1.Name = "Column1"
        Me.GridColumn1.Width = 60
        '
        'GridColumn2
        '
        Me.GridColumn2.HeaderText = "No Contrato"
        Me.GridColumn2.Name = "Column2"
        Me.GridColumn2.Width = 120
        '
        'GridColumn3
        '
        Me.GridColumn3.HeaderText = "Nombre Titular"
        Me.GridColumn3.Name = "Column3"
        Me.GridColumn3.Width = 300
        '
        'sPlitter
        '
        Me.sPlitter.BackColor = System.Drawing.SystemColors.ControlLight
        Me.sPlitter.BackColor2 = System.Drawing.Color.Empty
        Me.sPlitter.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.sPlitter.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.sPlitter.Dock = System.Windows.Forms.DockStyle.Top
        Me.sPlitter.ExpandableControl = Me.PanelEx1
        Me.sPlitter.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.sPlitter.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.sPlitter.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.sPlitter.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder
        Me.sPlitter.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.sPlitter.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder
        Me.sPlitter.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.sPlitter.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.sPlitter.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.sPlitter.HotBackColor2 = System.Drawing.Color.Empty
        Me.sPlitter.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.sPlitter.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemCheckedBackground
        Me.sPlitter.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.sPlitter.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.sPlitter.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.sPlitter.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder
        Me.sPlitter.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.sPlitter.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder
        Me.sPlitter.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.sPlitter.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.sPlitter.Location = New System.Drawing.Point(0, 163)
        Me.sPlitter.Name = "sPlitter"
        Me.sPlitter.Size = New System.Drawing.Size(613, 6)
        Me.sPlitter.Style = DevComponents.DotNetBar.eSplitterStyle.Mozilla
        Me.sPlitter.TabIndex = 3
        Me.sPlitter.TabStop = False
        '
        'GridColumn4
        '
        Me.GridColumn4.HeaderText = "Año"
        Me.GridColumn4.Name = "Column4"
        Me.GridColumn4.Width = 80
        '
        'wfContratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 354)
        Me.Controls.Add(Me.sPlitter)
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "wfContratos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "wfContratos"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.PanelEx2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents btNuevo As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btEditar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btBorrar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btUpdate As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btImprimir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btSalir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents sPlitter As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents dgContratos As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents txId As DevComponents.DotNetBar.TextBoxItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btAtras As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txYear As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txNumero As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txIdc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txTID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GridColumn1 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents GridColumn2 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents GridColumn3 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents GridColumn4 As DevComponents.DotNetBar.SuperGrid.GridColumn
End Class
