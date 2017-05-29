<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wfUsuarios
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
        Me.btPrint = New DevComponents.DotNetBar.ButtonItem()
        Me.btSalir = New DevComponents.DotNetBar.ButtonItem()
        Me.txId = New DevComponents.DotNetBar.TextBoxItem()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.txCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.txClave = New System.Windows.Forms.TextBox()
        Me.txNombre = New System.Windows.Forms.TextBox()
        Me.btSave = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Splitter = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.SuperGridControl1 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
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
        Me.RibbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btNuevo, Me.btEditar, Me.btBorrar, Me.btUpdate, Me.btPrint, Me.btSalir, Me.txId})
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Size = New System.Drawing.Size(560, 69)
        Me.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar1.TabIndex = 27
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
        '
        'btEditar
        '
        Me.btEditar.Image = Global.SAMAD.My.Resources.Resources.Edit
        Me.btEditar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btEditar.Name = "btEditar"
        Me.btEditar.SubItemsExpandWidth = 14
        Me.btEditar.Text = "Editar"
        '
        'btBorrar
        '
        Me.btBorrar.Image = Global.SAMAD.My.Resources.Resources.Del
        Me.btBorrar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btBorrar.Name = "btBorrar"
        Me.btBorrar.SubItemsExpandWidth = 14
        Me.btBorrar.Text = "Borrar"
        '
        'btUpdate
        '
        Me.btUpdate.Image = Global.SAMAD.My.Resources.Resources.Update
        Me.btUpdate.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.SubItemsExpandWidth = 14
        Me.btUpdate.Text = "Actualiza"
        '
        'btPrint
        '
        Me.btPrint.Image = Global.SAMAD.My.Resources.Resources.Print
        Me.btPrint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btPrint.Name = "btPrint"
        Me.btPrint.SubItemsExpandWidth = 14
        Me.btPrint.Text = "Imprimir"
        '
        'btSalir
        '
        Me.btSalir.Image = Global.SAMAD.My.Resources.Resources._Exit
        Me.btSalir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btSalir.Name = "btSalir"
        Me.btSalir.SubItemsExpandWidth = 14
        Me.btSalir.Text = "Salir"
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
        Me.PanelEx1.Controls.Add(Me.txCodigo)
        Me.PanelEx1.Controls.Add(Me.cbTipo)
        Me.PanelEx1.Controls.Add(Me.txClave)
        Me.PanelEx1.Controls.Add(Me.txNombre)
        Me.PanelEx1.Controls.Add(Me.btSave)
        Me.PanelEx1.Controls.Add(Me.ButtonX1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 69)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(560, 112)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 28
        Me.PanelEx1.Text = "PanelEx1"
        '
        'txCodigo
        '
        '
        '
        '
        Me.txCodigo.Border.Class = "TextBoxBorder"
        Me.txCodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txCodigo.Location = New System.Drawing.Point(409, 17)
        Me.txCodigo.Name = "txCodigo"
        Me.txCodigo.PreventEnterBeep = True
        Me.txCodigo.Size = New System.Drawing.Size(71, 20)
        Me.txCodigo.TabIndex = 12
        Me.txCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txCodigo.WatermarkColor = System.Drawing.Color.Gray
        Me.txCodigo.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.txCodigo.WatermarkText = "Id"
        '
        'cbTipo
        '
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"ADMINISTRADOR", "VISITANTE"})
        Me.cbTipo.Location = New System.Drawing.Point(70, 84)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(234, 21)
        Me.cbTipo.TabIndex = 11
        '
        'txClave
        '
        Me.txClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txClave.Enabled = False
        Me.txClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txClave.Location = New System.Drawing.Point(3, 57)
        Me.txClave.Name = "txClave"
        Me.txClave.Size = New System.Drawing.Size(234, 21)
        Me.txClave.TabIndex = 10
        '
        'txNombre
        '
        Me.txNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txNombre.Enabled = False
        Me.txNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txNombre.Location = New System.Drawing.Point(7, 17)
        Me.txNombre.Name = "txNombre"
        Me.txNombre.Size = New System.Drawing.Size(234, 21)
        Me.txNombre.TabIndex = 9
        '
        'btSave
        '
        Me.btSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSave.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSave.Image = Global.SAMAD.My.Resources.Resources.I240082
        Me.btSave.Location = New System.Drawing.Point(399, 77)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(85, 28)
        Me.btSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btSave.TabIndex = 1
        Me.btSave.Text = "Grabar"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.SAMAD.My.Resources.Resources.I320198
        Me.ButtonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX1.Location = New System.Drawing.Point(492, 8)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(63, 98)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 0
        Me.ButtonX1.Text = "Atras"
        '
        'Splitter
        '
        Me.Splitter.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Splitter.BackColor2 = System.Drawing.Color.Empty
        Me.Splitter.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.Splitter.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.Splitter.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Splitter.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.Splitter.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Splitter.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder
        Me.Splitter.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Splitter.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder
        Me.Splitter.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Splitter.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.Splitter.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Splitter.HotBackColor2 = System.Drawing.Color.Empty
        Me.Splitter.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.Splitter.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemCheckedBackground
        Me.Splitter.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Splitter.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.Splitter.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Splitter.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder
        Me.Splitter.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Splitter.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder
        Me.Splitter.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Splitter.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.Splitter.Location = New System.Drawing.Point(0, 181)
        Me.Splitter.Name = "Splitter"
        Me.Splitter.Size = New System.Drawing.Size(560, 6)
        Me.Splitter.Style = DevComponents.DotNetBar.eSplitterStyle.Mozilla
        Me.Splitter.TabIndex = 29
        Me.Splitter.TabStop = False
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.SuperGridControl1)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx2.Location = New System.Drawing.Point(0, 187)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(560, 234)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 30
        Me.PanelEx2.Text = "PanelEx2"
        '
        'SuperGridControl1
        '
        Me.SuperGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.SuperGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.SuperGridControl1.Name = "SuperGridControl1"
        Me.SuperGridControl1.Size = New System.Drawing.Size(560, 234)
        Me.SuperGridControl1.TabIndex = 0
        Me.SuperGridControl1.Text = "SuperGridControl1"
        '
        'wfUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 421)
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.Splitter)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "wfUsuarios"
        Me.Text = "wfUsuarios"
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
    Friend WithEvents btPrint As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btSalir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents txId As DevComponents.DotNetBar.TextBoxItem
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txClave As System.Windows.Forms.TextBox
    Friend WithEvents txNombre As System.Windows.Forms.TextBox
    Friend WithEvents btSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Splitter As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
End Class
