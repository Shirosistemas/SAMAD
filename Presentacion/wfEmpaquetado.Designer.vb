<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wfEmpaquetado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wfEmpaquetado))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txNumero = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.sgDetalle = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.txLoteAserrio = New System.Windows.Forms.TextBox()
        Me.BtEliminar = New DevComponents.DotNetBar.ButtonX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txPeriodo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txCubicadorId = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txComentario = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txCubicador = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btEditar = New DevComponents.DotNetBar.ButtonX()
        Me.btAtras = New DevComponents.DotNetBar.ButtonX()
        Me.btGrabar = New DevComponents.DotNetBar.ButtonX()
        Me.btNuevo = New DevComponents.DotNetBar.ButtonX()
        Me.txRowId = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txEmpresa = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.chkCertificada = New System.Windows.Forms.CheckBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.txExpresaId = New System.Windows.Forms.TextBox()
        Me.lblResponsable = New System.Windows.Forms.Label()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.btPrimero = New DevComponents.DotNetBar.ButtonItem()
        Me.btAnterior = New DevComponents.DotNetBar.ButtonItem()
        Me.txRecno = New DevComponents.DotNetBar.TextBoxItem()
        Me.btSiguiente = New DevComponents.DotNetBar.ButtonItem()
        Me.btUltimo = New DevComponents.DotNetBar.ButtonItem()
        Me.btAdd = New DevComponents.DotNetBar.ButtonItem()
        Me.btBorrar = New DevComponents.DotNetBar.ButtonItem()
        Me.btSalir = New DevComponents.DotNetBar.ButtonItem()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txNumero)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1249, 59)
        Me.Panel1.TabIndex = 52
        '
        'txNumero
        '
        '
        '
        '
        Me.txNumero.Border.Class = "TextBoxBorder"
        Me.txNumero.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txNumero.Enabled = False
        Me.txNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txNumero.Location = New System.Drawing.Point(1011, 11)
        Me.txNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txNumero.Name = "txNumero"
        Me.txNumero.PreventEnterBeep = True
        Me.txNumero.Size = New System.Drawing.Size(177, 34)
        Me.txNumero.TabIndex = 14
        Me.txNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txNumero.WatermarkText = "000000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(824, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nro.Documento"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label6.Location = New System.Drawing.Point(49, 12)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(314, 31)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Modulo de Empaquetado"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.sgDetalle)
        Me.GroupPanel1.Controls.Add(Me.gbDatos)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(7, 63)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1221, 519)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 53
        '
        'sgDetalle
        '
        Me.sgDetalle.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.sgDetalle.Location = New System.Drawing.Point(7, 186)
        Me.sgDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.sgDetalle.Name = "sgDetalle"
        '
        '
        '
        Me.sgDetalle.PrimaryGrid.AllowEdit = False
        '
        '
        '
        Me.sgDetalle.PrimaryGrid.Header.Text = ""
        '
        '
        '
        Me.sgDetalle.PrimaryGrid.Title.Text = "Detalle de EMPAQUETADO"
        Me.sgDetalle.Size = New System.Drawing.Size(1204, 321)
        Me.sgDetalle.TabIndex = 56
        Me.sgDetalle.Text = "SuperGridControl1"
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbDatos.Controls.Add(Me.txLoteAserrio)
        Me.gbDatos.Controls.Add(Me.BtEliminar)
        Me.gbDatos.Controls.Add(Me.Label3)
        Me.gbDatos.Controls.Add(Me.txPeriodo)
        Me.gbDatos.Controls.Add(Me.Label4)
        Me.gbDatos.Controls.Add(Me.txCubicadorId)
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Controls.Add(Me.txComentario)
        Me.gbDatos.Controls.Add(Me.txCubicador)
        Me.gbDatos.Controls.Add(Me.Button1)
        Me.gbDatos.Controls.Add(Me.btEditar)
        Me.gbDatos.Controls.Add(Me.btAtras)
        Me.gbDatos.Controls.Add(Me.btGrabar)
        Me.gbDatos.Controls.Add(Me.btNuevo)
        Me.gbDatos.Controls.Add(Me.txRowId)
        Me.gbDatos.Controls.Add(Me.txEmpresa)
        Me.gbDatos.Controls.Add(Me.chkCertificada)
        Me.gbDatos.Controls.Add(Me.Label28)
        Me.gbDatos.Controls.Add(Me.Label29)
        Me.gbDatos.Controls.Add(Me.dtFecha)
        Me.gbDatos.Controls.Add(Me.txExpresaId)
        Me.gbDatos.Controls.Add(Me.lblResponsable)
        Me.gbDatos.Location = New System.Drawing.Point(7, 0)
        Me.gbDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Padding = New System.Windows.Forms.Padding(4)
        Me.gbDatos.Size = New System.Drawing.Size(1205, 178)
        Me.gbDatos.TabIndex = 55
        Me.gbDatos.TabStop = False
        '
        'txLoteAserrio
        '
        Me.txLoteAserrio.Location = New System.Drawing.Point(1020, 141)
        Me.txLoteAserrio.Name = "txLoteAserrio"
        Me.txLoteAserrio.ReadOnly = True
        Me.txLoteAserrio.Size = New System.Drawing.Size(100, 22)
        Me.txLoteAserrio.TabIndex = 216
        Me.txLoteAserrio.Visible = False
        '
        'BtEliminar
        '
        Me.BtEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtEliminar.Image = Global.SAMAD.My.Resources.Resources.I24007
        Me.BtEliminar.ImageTextSpacing = 5
        Me.BtEliminar.Location = New System.Drawing.Point(982, 92)
        Me.BtEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtEliminar.Name = "BtEliminar"
        Me.BtEliminar.Size = New System.Drawing.Size(137, 36)
        Me.BtEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtEliminar.TabIndex = 63
        Me.BtEliminar.Text = "Eliminar"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SeaGreen
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(660, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 31)
        Me.Label3.TabIndex = 214
        Me.Label3.Text = "Periodo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txPeriodo
        '
        '
        '
        '
        Me.txPeriodo.Border.Class = "TextBoxBorder"
        Me.txPeriodo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txPeriodo.Location = New System.Drawing.Point(754, 59)
        Me.txPeriodo.Margin = New System.Windows.Forms.Padding(4)
        Me.txPeriodo.Name = "txPeriodo"
        Me.txPeriodo.PreventEnterBeep = True
        Me.txPeriodo.Size = New System.Drawing.Size(127, 29)
        Me.txPeriodo.TabIndex = 215
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SeaGreen
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(11, 102)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 23)
        Me.Label4.TabIndex = 213
        Me.Label4.Text = "Cubicador"
        '
        'txCubicadorId
        '
        '
        '
        '
        Me.txCubicadorId.Border.Class = "TextBoxBorder"
        Me.txCubicadorId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txCubicadorId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txCubicadorId.Location = New System.Drawing.Point(154, 102)
        Me.txCubicadorId.Margin = New System.Windows.Forms.Padding(4)
        Me.txCubicadorId.Name = "txCubicadorId"
        Me.txCubicadorId.PreventEnterBeep = True
        Me.txCubicadorId.ReadOnly = True
        Me.txCubicadorId.Size = New System.Drawing.Size(48, 26)
        Me.txCubicadorId.TabIndex = 212
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SeaGreen
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(8, 138)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 31)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Observación"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txComentario
        '
        '
        '
        '
        Me.txComentario.Border.Class = "TextBoxBorder"
        Me.txComentario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txComentario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txComentario.Location = New System.Drawing.Point(153, 136)
        Me.txComentario.Margin = New System.Windows.Forms.Padding(4)
        Me.txComentario.Name = "txComentario"
        Me.txComentario.PreventEnterBeep = True
        Me.txComentario.Size = New System.Drawing.Size(728, 29)
        Me.txComentario.TabIndex = 61
        '
        'txCubicador
        '
        '
        '
        '
        Me.txCubicador.Border.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txCubicador.Border.Class = "TextBoxBorder"
        Me.txCubicador.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txCubicador.ButtonCustom.Image = Global.SAMAD.My.Resources.Resources.add
        Me.txCubicador.ButtonCustom.Visible = True
        Me.txCubicador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txCubicador.Location = New System.Drawing.Point(207, 102)
        Me.txCubicador.Margin = New System.Windows.Forms.Padding(4)
        Me.txCubicador.Name = "txCubicador"
        Me.txCubicador.PreventEnterBeep = True
        Me.txCubicador.ReadOnly = True
        Me.txCubicador.Size = New System.Drawing.Size(674, 26)
        Me.txCubicador.TabIndex = 211
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(889, 137)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 28)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'btEditar
        '
        Me.btEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEditar.Image = Global.SAMAD.My.Resources.Resources.I24004
        Me.btEditar.ImageTextSpacing = 5
        Me.btEditar.Location = New System.Drawing.Point(1052, 9)
        Me.btEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(137, 36)
        Me.btEditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btEditar.TabIndex = 64
        Me.btEditar.Text = "Editar"
        '
        'btAtras
        '
        Me.btAtras.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAtras.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAtras.Image = Global.SAMAD.My.Resources.Resources.I24001
        Me.btAtras.ImageTextSpacing = 5
        Me.btAtras.Location = New System.Drawing.Point(1052, 49)
        Me.btAtras.Margin = New System.Windows.Forms.Padding(4)
        Me.btAtras.Name = "btAtras"
        Me.btAtras.Size = New System.Drawing.Size(137, 36)
        Me.btAtras.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btAtras.TabIndex = 65
        Me.btAtras.Text = "Deshacer"
        '
        'btGrabar
        '
        Me.btGrabar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btGrabar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGrabar.Image = Global.SAMAD.My.Resources.Resources.I240082
        Me.btGrabar.ImageTextSpacing = 5
        Me.btGrabar.Location = New System.Drawing.Point(904, 49)
        Me.btGrabar.Margin = New System.Windows.Forms.Padding(4)
        Me.btGrabar.Name = "btGrabar"
        Me.btGrabar.Size = New System.Drawing.Size(137, 36)
        Me.btGrabar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btGrabar.TabIndex = 62
        Me.btGrabar.Text = "Guardar"
        '
        'btNuevo
        '
        Me.btNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNuevo.Image = Global.SAMAD.My.Resources.Resources.I24003
        Me.btNuevo.ImageTextSpacing = 5
        Me.btNuevo.Location = New System.Drawing.Point(904, 9)
        Me.btNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(137, 36)
        Me.btNuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btNuevo.TabIndex = 63
        Me.btNuevo.Text = "Nuevo"
        '
        'txRowId
        '
        '
        '
        '
        Me.txRowId.Border.Class = "TextBoxBorder"
        Me.txRowId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txRowId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txRowId.Location = New System.Drawing.Point(800, 12)
        Me.txRowId.Margin = New System.Windows.Forms.Padding(4)
        Me.txRowId.Name = "txRowId"
        Me.txRowId.PreventEnterBeep = True
        Me.txRowId.ReadOnly = True
        Me.txRowId.Size = New System.Drawing.Size(81, 29)
        Me.txRowId.TabIndex = 60
        Me.txRowId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txRowId.Visible = False
        Me.txRowId.WatermarkText = "0"
        '
        'txEmpresa
        '
        '
        '
        '
        Me.txEmpresa.Border.Class = "TextBoxBorder"
        Me.txEmpresa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txEmpresa.ButtonCustom.Image = Global.SAMAD.My.Resources.Resources.add
        Me.txEmpresa.ButtonCustom.Visible = True
        Me.txEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txEmpresa.Location = New System.Drawing.Point(209, 58)
        Me.txEmpresa.Margin = New System.Windows.Forms.Padding(4)
        Me.txEmpresa.Name = "txEmpresa"
        Me.txEmpresa.PreventEnterBeep = True
        Me.txEmpresa.ReadOnly = True
        Me.txEmpresa.Size = New System.Drawing.Size(443, 29)
        Me.txEmpresa.TabIndex = 59
        '
        'chkCertificada
        '
        Me.chkCertificada.AutoSize = True
        Me.chkCertificada.Enabled = False
        Me.chkCertificada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCertificada.ForeColor = System.Drawing.Color.DarkGreen
        Me.chkCertificada.Location = New System.Drawing.Point(374, 23)
        Me.chkCertificada.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCertificada.Name = "chkCertificada"
        Me.chkCertificada.Size = New System.Drawing.Size(188, 28)
        Me.chkCertificada.TabIndex = 55
        Me.chkCertificada.Text = "Madera Certificada"
        Me.chkCertificada.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label28.Location = New System.Drawing.Point(763, 12)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(32, 28)
        Me.Label28.TabIndex = 54
        Me.Label28.Text = "Id"
        Me.Label28.Visible = False
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label29.Location = New System.Drawing.Point(11, 23)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(137, 28)
        Me.Label29.TabIndex = 44
        Me.Label29.Text = "Fecha"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtFecha
        '
        Me.dtFecha.Enabled = False
        Me.dtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtFecha.Location = New System.Drawing.Point(153, 23)
        Me.dtFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(200, 29)
        Me.dtFecha.TabIndex = 43
        '
        'txExpresaId
        '
        Me.txExpresaId.Enabled = False
        Me.txExpresaId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txExpresaId.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txExpresaId.Location = New System.Drawing.Point(153, 58)
        Me.txExpresaId.Margin = New System.Windows.Forms.Padding(4)
        Me.txExpresaId.Name = "txExpresaId"
        Me.txExpresaId.ReadOnly = True
        Me.txExpresaId.Size = New System.Drawing.Size(49, 29)
        Me.txExpresaId.TabIndex = 1
        Me.txExpresaId.Tag = "el Responsable"
        Me.txExpresaId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblResponsable
        '
        Me.lblResponsable.BackColor = System.Drawing.Color.OliveDrab
        Me.lblResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponsable.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblResponsable.Location = New System.Drawing.Point(11, 58)
        Me.lblResponsable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResponsable.Name = "lblResponsable"
        Me.lblResponsable.Size = New System.Drawing.Size(137, 31)
        Me.lblResponsable.TabIndex = 6
        Me.lblResponsable.Text = "Aserradero"
        Me.lblResponsable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Bar1
        '
        Me.Bar1.AntiAlias = True
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btPrimero, Me.btAnterior, Me.txRecno, Me.btSiguiente, Me.btUltimo, Me.btAdd, Me.btBorrar, Me.btSalir})
        Me.Bar1.Location = New System.Drawing.Point(0, 592)
        Me.Bar1.Margin = New System.Windows.Forms.Padding(4)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(1249, 33)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 54
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'btPrimero
        '
        Me.btPrimero.Image = Global.SAMAD.My.Resources.Resources.I16002
        Me.btPrimero.Name = "btPrimero"
        Me.btPrimero.Text = "ButtonItem"
        '
        'btAnterior
        '
        Me.btAnterior.Image = Global.SAMAD.My.Resources.Resources.I16003
        Me.btAnterior.Name = "btAnterior"
        Me.btAnterior.Text = "ButtonItem2"
        '
        'txRecno
        '
        Me.txRecno.Enabled = False
        Me.txRecno.Name = "txRecno"
        Me.txRecno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txRecno.TextBoxWidth = 100
        Me.txRecno.WatermarkColor = System.Drawing.SystemColors.GrayText
        Me.txRecno.WatermarkText = "0 de 0"
        '
        'btSiguiente
        '
        Me.btSiguiente.Image = Global.SAMAD.My.Resources.Resources.I16004
        Me.btSiguiente.Name = "btSiguiente"
        Me.btSiguiente.Text = "ButtonItem3"
        '
        'btUltimo
        '
        Me.btUltimo.Image = Global.SAMAD.My.Resources.Resources.I16005
        Me.btUltimo.Name = "btUltimo"
        Me.btUltimo.Text = "ButtonItem4"
        '
        'btAdd
        '
        Me.btAdd.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btAdd.Image = Global.SAMAD.My.Resources.Resources.I24008
        Me.btAdd.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Text = "Agregar Detalle"
        '
        'btBorrar
        '
        Me.btBorrar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btBorrar.Image = Global.SAMAD.My.Resources.Resources.I24007
        Me.btBorrar.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.btBorrar.Name = "btBorrar"
        Me.btBorrar.Text = "Borrar"
        '
        'btSalir
        '
        Me.btSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btSalir.Image = Global.SAMAD.My.Resources.Resources.I240001
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Text = "Salir"
        '
        'wfEmpaquetado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 625)
        Me.Controls.Add(Me.Bar1)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "wfEmpaquetado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "wfEmpaquetado"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents sgDetalle As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkCertificada As System.Windows.Forms.CheckBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txExpresaId As System.Windows.Forms.TextBox
    Friend WithEvents lblResponsable As System.Windows.Forms.Label
    Friend WithEvents txEmpresa As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btPrimero As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btAnterior As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents txRecno As DevComponents.DotNetBar.TextBoxItem
    Friend WithEvents btSiguiente As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btUltimo As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btBorrar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btSalir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btAdd As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents txRowId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txNumero As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txComentario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btEditar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btAtras As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btGrabar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txPeriodo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txCubicadorId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txCubicador As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BtEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txLoteAserrio As System.Windows.Forms.TextBox
End Class
