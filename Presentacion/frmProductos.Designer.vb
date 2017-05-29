<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescrip = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEspesorDesde = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxFacEsp = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbOperadorL = New System.Windows.Forms.ComboBox()
        Me.cbOperadorA = New System.Windows.Forms.ComboBox()
        Me.cbOperadorE = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLargoDesde = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAnchoDesde = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtSimboloCubi = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtSisCubicacion = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbUnidMedL = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbUnidMedAb = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtRendimiento = New System.Windows.Forms.TextBox()
        Me.lineaprodCB = New System.Windows.Forms.ComboBox()
        Me.cmbClaseComercial = New System.Windows.Forms.ComboBox()
        Me.lblTipoCubicacion = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbTipoProducto = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkEliminar = New System.Windows.Forms.CheckBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblinexistente = New System.Windows.Forms.Label()
        Me.dataListado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaseComercial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rendimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UniMedidaAb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UniMedLargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Espesor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OperadorE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ancho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OperadorA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Largo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OperadorL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FuncionCalculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SistemaCalculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Simbolo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tcDatos = New System.Windows.Forms.TabControl()
        Me.tpLista = New System.Windows.Forms.TabPage()
        Me.tpDatos = New System.Windows.Forms.TabPage()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcDatos.SuspendLayout()
        Me.tpLista.SuspendLayout()
        Me.tpDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnNuevo)
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.btnSalir)
        Me.Panel2.Controls.Add(Me.btnModificar)
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Controls.Add(Me.btnGuardar)
        Me.Panel2.Location = New System.Drawing.Point(0, 480)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1253, 77)
        Me.Panel2.TabIndex = 17
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(1, 15)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(116, 42)
        Me.btnNuevo.TabIndex = 20
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(511, 15)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(125, 42)
        Me.btnEliminar.TabIndex = 16
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(1086, 15)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(116, 42)
        Me.btnSalir.TabIndex = 19
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.Control
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(120, 15)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(131, 42)
        Me.btnModificar.TabIndex = 15
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(379, 15)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(129, 42)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(253, 15)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(123, 42)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(1, -4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1256, 56)
        Me.Panel1.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Info
        Me.Label6.Location = New System.Drawing.Point(57, 14)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(269, 31)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Modulo de Productos"
        '
        'txtDescrip
        '
        Me.txtDescrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescrip.Enabled = False
        Me.txtDescrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrip.Location = New System.Drawing.Point(167, 81)
        Me.txtDescrip.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescrip.MaxLength = 50
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.Size = New System.Drawing.Size(384, 23)
        Me.txtDescrip.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SeaGreen
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(7, 59)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Desde"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEspesorDesde
        '
        Me.txtEspesorDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEspesorDesde.Enabled = False
        Me.txtEspesorDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspesorDesde.Location = New System.Drawing.Point(7, 86)
        Me.txtEspesorDesde.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEspesorDesde.Name = "txtEspesorDesde"
        Me.txtEspesorDesde.Size = New System.Drawing.Size(108, 24)
        Me.txtEspesorDesde.TabIndex = 3
        Me.txtEspesorDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(140, 6)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(69, 23)
        Me.txtId.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SeaGreen
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(7, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre del Producto"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.TxFacEsp)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.txtSimboloCubi)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.txtSisCubicacion)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.cbUnidMedL)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.cbUnidMedAb)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.txtRendimiento)
        Me.Panel3.Controls.Add(Me.lineaprodCB)
        Me.Panel3.Controls.Add(Me.cmbClaseComercial)
        Me.Panel3.Controls.Add(Me.lblTipoCubicacion)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.cbTipoProducto)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txtId)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtDescrip)
        Me.Panel3.Location = New System.Drawing.Point(3, 30)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1189, 334)
        Me.Panel3.TabIndex = 18
        '
        'TxFacEsp
        '
        Me.TxFacEsp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxFacEsp.Enabled = False
        Me.TxFacEsp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxFacEsp.Location = New System.Drawing.Point(167, 156)
        Me.TxFacEsp.Margin = New System.Windows.Forms.Padding(4)
        Me.TxFacEsp.Name = "TxFacEsp"
        Me.TxFacEsp.Size = New System.Drawing.Size(77, 24)
        Me.TxFacEsp.TabIndex = 44
        Me.TxFacEsp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.SeaGreen
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(1052, 123)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 23)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Simbolo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbOperadorL)
        Me.GroupBox1.Controls.Add(Me.cbOperadorA)
        Me.GroupBox1.Controls.Add(Me.cbOperadorE)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtLargoDesde)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtAnchoDesde)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtEspesorDesde)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 203)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(734, 115)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Caracteristicas del Producto"
        '
        'cbOperadorL
        '
        Me.cbOperadorL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOperadorL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOperadorL.FormattingEnabled = True
        Me.cbOperadorL.Items.AddRange(New Object() {">", "<", ">=", "<="})
        Me.cbOperadorL.Location = New System.Drawing.Point(612, 86)
        Me.cbOperadorL.Margin = New System.Windows.Forms.Padding(4)
        Me.cbOperadorL.Name = "cbOperadorL"
        Me.cbOperadorL.Size = New System.Drawing.Size(115, 26)
        Me.cbOperadorL.TabIndex = 45
        '
        'cbOperadorA
        '
        Me.cbOperadorA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOperadorA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOperadorA.FormattingEnabled = True
        Me.cbOperadorA.Items.AddRange(New Object() {">", "<", ">=", "<="})
        Me.cbOperadorA.Location = New System.Drawing.Point(362, 86)
        Me.cbOperadorA.Margin = New System.Windows.Forms.Padding(4)
        Me.cbOperadorA.Name = "cbOperadorA"
        Me.cbOperadorA.Size = New System.Drawing.Size(115, 26)
        Me.cbOperadorA.TabIndex = 44
        '
        'cbOperadorE
        '
        Me.cbOperadorE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOperadorE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOperadorE.FormattingEnabled = True
        Me.cbOperadorE.Items.AddRange(New Object() {">", "<", ">=", "<="})
        Me.cbOperadorE.Location = New System.Drawing.Point(122, 86)
        Me.cbOperadorE.Margin = New System.Windows.Forms.Padding(4)
        Me.cbOperadorE.Name = "cbOperadorE"
        Me.cbOperadorE.Size = New System.Drawing.Size(112, 26)
        Me.cbOperadorE.TabIndex = 43
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label11.Location = New System.Drawing.Point(494, 31)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(234, 26)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Largo"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLargoDesde
        '
        Me.txtLargoDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLargoDesde.Enabled = False
        Me.txtLargoDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLargoDesde.Location = New System.Drawing.Point(494, 86)
        Me.txtLargoDesde.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLargoDesde.Name = "txtLargoDesde"
        Me.txtLargoDesde.Size = New System.Drawing.Size(107, 24)
        Me.txtLargoDesde.TabIndex = 7
        Me.txtLargoDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.SeaGreen
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(494, 59)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 23)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Desde"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.SeaGreen
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label16.Location = New System.Drawing.Point(612, 59)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(116, 23)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Operador"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(245, 31)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(231, 26)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Ancho"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAnchoDesde
        '
        Me.txtAnchoDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAnchoDesde.Enabled = False
        Me.txtAnchoDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnchoDesde.Location = New System.Drawing.Point(245, 86)
        Me.txtAnchoDesde.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAnchoDesde.Name = "txtAnchoDesde"
        Me.txtAnchoDesde.Size = New System.Drawing.Size(107, 24)
        Me.txtAnchoDesde.TabIndex = 5
        Me.txtAnchoDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.SeaGreen
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(245, 59)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 23)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Desde"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.SeaGreen
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(361, 59)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 23)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Operador"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(7, 31)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(230, 26)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Espesor"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SeaGreen
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(125, 59)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Operador"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.SeaGreen
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label22.Location = New System.Drawing.Point(8, 157)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(151, 23)
        Me.Label22.TabIndex = 41
        Me.Label22.Text = "F. Espaciamiento"
        '
        'txtSimboloCubi
        '
        Me.txtSimboloCubi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSimboloCubi.Enabled = False
        Me.txtSimboloCubi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSimboloCubi.Location = New System.Drawing.Point(1127, 122)
        Me.txtSimboloCubi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSimboloCubi.Name = "txtSimboloCubi"
        Me.txtSimboloCubi.Size = New System.Drawing.Size(48, 24)
        Me.txtSimboloCubi.TabIndex = 40
        Me.txtSimboloCubi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.SeaGreen
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label21.Location = New System.Drawing.Point(849, 123)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(132, 23)
        Me.Label21.TabIndex = 39
        Me.Label21.Text = "Sist. de Cubicación"
        '
        'txtSisCubicacion
        '
        Me.txtSisCubicacion.Enabled = False
        Me.txtSisCubicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSisCubicacion.Location = New System.Drawing.Point(989, 122)
        Me.txtSisCubicacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSisCubicacion.Name = "txtSisCubicacion"
        Me.txtSisCubicacion.Size = New System.Drawing.Size(55, 24)
        Me.txtSisCubicacion.TabIndex = 38
        Me.txtSisCubicacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.SeaGreen
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(252, 123)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(151, 23)
        Me.Label20.TabIndex = 37
        Me.Label20.Text = "Unidad de Med. Long."
        '
        'cbUnidMedL
        '
        Me.cbUnidMedL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnidMedL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUnidMedL.FormattingEnabled = True
        Me.cbUnidMedL.Location = New System.Drawing.Point(411, 120)
        Me.cbUnidMedL.Margin = New System.Windows.Forms.Padding(4)
        Me.cbUnidMedL.Name = "cbUnidMedL"
        Me.cbUnidMedL.Size = New System.Drawing.Size(108, 26)
        Me.cbUnidMedL.TabIndex = 36
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.SeaGreen
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label19.Location = New System.Drawing.Point(8, 123)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(151, 23)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "Unidad de Med. Ab"
        '
        'cbUnidMedAb
        '
        Me.cbUnidMedAb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnidMedAb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUnidMedAb.FormattingEnabled = True
        Me.cbUnidMedAb.Location = New System.Drawing.Point(167, 120)
        Me.cbUnidMedAb.Margin = New System.Windows.Forms.Padding(4)
        Me.cbUnidMedAb.Name = "cbUnidMedAb"
        Me.cbUnidMedAb.Size = New System.Drawing.Size(77, 26)
        Me.cbUnidMedAb.TabIndex = 34
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.SeaGreen
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label18.Location = New System.Drawing.Point(8, 48)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(151, 23)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "Tipo de Producto"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SeaGreen
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label17.Location = New System.Drawing.Point(974, 81)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(112, 23)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Rendimeinto %"
        '
        'txtRendimiento
        '
        Me.txtRendimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRendimiento.Enabled = False
        Me.txtRendimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRendimiento.Location = New System.Drawing.Point(1095, 80)
        Me.txtRendimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRendimiento.Name = "txtRendimiento"
        Me.txtRendimiento.Size = New System.Drawing.Size(79, 24)
        Me.txtRendimiento.TabIndex = 31
        Me.txtRendimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lineaprodCB
        '
        Me.lineaprodCB.DisplayMember = "Lin_Nombre"
        Me.lineaprodCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lineaprodCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lineaprodCB.FormattingEnabled = True
        Me.lineaprodCB.Location = New System.Drawing.Point(696, 122)
        Me.lineaprodCB.Margin = New System.Windows.Forms.Padding(4)
        Me.lineaprodCB.Name = "lineaprodCB"
        Me.lineaprodCB.Size = New System.Drawing.Size(145, 25)
        Me.lineaprodCB.TabIndex = 30
        Me.lineaprodCB.ValueMember = "Lin_Nombre"
        '
        'cmbClaseComercial
        '
        Me.cmbClaseComercial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClaseComercial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClaseComercial.FormattingEnabled = True
        Me.cmbClaseComercial.Location = New System.Drawing.Point(688, 79)
        Me.cmbClaseComercial.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbClaseComercial.Name = "cmbClaseComercial"
        Me.cmbClaseComercial.Size = New System.Drawing.Size(271, 26)
        Me.cmbClaseComercial.TabIndex = 28
        '
        'lblTipoCubicacion
        '
        Me.lblTipoCubicacion.Location = New System.Drawing.Point(321, 49)
        Me.lblTipoCubicacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoCubicacion.Name = "lblTipoCubicacion"
        Me.lblTipoCubicacion.Size = New System.Drawing.Size(197, 22)
        Me.lblTipoCubicacion.TabIndex = 27
        Me.lblTipoCubicacion.Text = "EAL1 = Tabla por tabla"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.SeaGreen
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(559, 81)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 23)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Clase Comercial"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.SeaGreen
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(527, 124)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(161, 23)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Función de Cubicación"
        '
        'cbTipoProducto
        '
        Me.cbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoProducto.FormattingEnabled = True
        Me.cbTipoProducto.Items.AddRange(New Object() {"PT", "PP"})
        Me.cbTipoProducto.Location = New System.Drawing.Point(167, 48)
        Me.cbTipoProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.cbTipoProducto.MaxLength = 45
        Me.cbTipoProducto.Name = "cbTipoProducto"
        Me.cbTipoProducto.Size = New System.Drawing.Size(123, 25)
        Me.cbTipoProducto.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkEliminar)
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblinexistente)
        Me.GroupBox2.Controls.Add(Me.dataListado)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox2.Location = New System.Drawing.Point(11, 6)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1188, 372)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'chkEliminar
        '
        Me.chkEliminar.AutoSize = True
        Me.chkEliminar.ForeColor = System.Drawing.Color.DarkGreen
        Me.chkEliminar.Location = New System.Drawing.Point(421, 343)
        Me.chkEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.chkEliminar.Name = "chkEliminar"
        Me.chkEliminar.Size = New System.Drawing.Size(83, 22)
        Me.chkEliminar.TabIndex = 10
        Me.chkEliminar.Text = "Eliminar"
        Me.chkEliminar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Enabled = False
        Me.txtBuscar.Location = New System.Drawing.Point(103, 341)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(256, 24)
        Me.txtBuscar.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(12, 341)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 26)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Buscar"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblinexistente
        '
        Me.lblinexistente.AutoSize = True
        Me.lblinexistente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblinexistente.ForeColor = System.Drawing.Color.White
        Me.lblinexistente.Location = New System.Drawing.Point(469, 159)
        Me.lblinexistente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblinexistente.Name = "lblinexistente"
        Me.lblinexistente.Size = New System.Drawing.Size(201, 18)
        Me.lblinexistente.TabIndex = 1
        Me.lblinexistente.Text = "No hay registros que mostrar"
        '
        'dataListado
        '
        Me.dataListado.AllowUserToAddRows = False
        Me.dataListado.AllowUserToDeleteRows = False
        Me.dataListado.AllowUserToResizeRows = False
        Me.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.ID, Me.TipoProducto, Me.NombreProducto, Me.ClaseComercial, Me.Rendimiento, Me.UniMedidaAb, Me.UniMedLargo, Me.Espesor, Me.OperadorE, Me.Ancho, Me.OperadorA, Me.Largo, Me.OperadorL, Me.FuncionCalculo, Me.SistemaCalculo, Me.Simbolo})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataListado.DefaultCellStyle = DataGridViewCellStyle1
        Me.dataListado.Location = New System.Drawing.Point(10, 16)
        Me.dataListado.Margin = New System.Windows.Forms.Padding(4)
        Me.dataListado.MultiSelect = False
        Me.dataListado.Name = "dataListado"
        Me.dataListado.ReadOnly = True
        Me.dataListado.RowHeadersVisible = False
        Me.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListado.Size = New System.Drawing.Size(1171, 319)
        Me.dataListado.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 337
        '
        'ID
        '
        Me.ID.DataPropertyName = "Prod_Id"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'TipoProducto
        '
        Me.TipoProducto.DataPropertyName = "Prod_TipoProducto"
        Me.TipoProducto.HeaderText = "Tipo Producto"
        Me.TipoProducto.Name = "TipoProducto"
        Me.TipoProducto.ReadOnly = True
        '
        'NombreProducto
        '
        Me.NombreProducto.DataPropertyName = "Prod_NomProducto"
        Me.NombreProducto.HeaderText = "Nombre Producto"
        Me.NombreProducto.Name = "NombreProducto"
        Me.NombreProducto.ReadOnly = True
        '
        'ClaseComercial
        '
        Me.ClaseComercial.DataPropertyName = "Prod_ClasificacionCom"
        Me.ClaseComercial.HeaderText = "Clase Comercial"
        Me.ClaseComercial.Name = "ClaseComercial"
        Me.ClaseComercial.ReadOnly = True
        '
        'Rendimiento
        '
        Me.Rendimiento.DataPropertyName = "Prod_Rendimiento"
        Me.Rendimiento.HeaderText = "Rendimiento"
        Me.Rendimiento.Name = "Rendimiento"
        Me.Rendimiento.ReadOnly = True
        '
        'UniMedidaAb
        '
        Me.UniMedidaAb.DataPropertyName = "Prod_UnidadMedidaAb"
        Me.UniMedidaAb.HeaderText = "Unid. Medida Ab"
        Me.UniMedidaAb.Name = "UniMedidaAb"
        Me.UniMedidaAb.ReadOnly = True
        '
        'UniMedLargo
        '
        Me.UniMedLargo.DataPropertyName = "Prod_UnidadMedidaL"
        Me.UniMedLargo.HeaderText = "Unid. Medida Largo"
        Me.UniMedLargo.Name = "UniMedLargo"
        Me.UniMedLargo.ReadOnly = True
        '
        'Espesor
        '
        Me.Espesor.DataPropertyName = "Prod_Espesor"
        Me.Espesor.HeaderText = "Espesor"
        Me.Espesor.Name = "Espesor"
        Me.Espesor.ReadOnly = True
        '
        'OperadorE
        '
        Me.OperadorE.DataPropertyName = "Prod_OperadorE"
        Me.OperadorE.HeaderText = "OperadorE"
        Me.OperadorE.Name = "OperadorE"
        Me.OperadorE.ReadOnly = True
        '
        'Ancho
        '
        Me.Ancho.DataPropertyName = "Prod_Ancho"
        Me.Ancho.HeaderText = "Ancho"
        Me.Ancho.Name = "Ancho"
        Me.Ancho.ReadOnly = True
        '
        'OperadorA
        '
        Me.OperadorA.DataPropertyName = "Prod_OperadorA"
        Me.OperadorA.HeaderText = "OperadorA"
        Me.OperadorA.Name = "OperadorA"
        Me.OperadorA.ReadOnly = True
        '
        'Largo
        '
        Me.Largo.DataPropertyName = "Prod_Largo"
        Me.Largo.HeaderText = "Largo"
        Me.Largo.Name = "Largo"
        Me.Largo.ReadOnly = True
        '
        'OperadorL
        '
        Me.OperadorL.DataPropertyName = "Prod_OperadorL"
        Me.OperadorL.HeaderText = "OperadorL"
        Me.OperadorL.Name = "OperadorL"
        Me.OperadorL.ReadOnly = True
        '
        'FuncionCalculo
        '
        Me.FuncionCalculo.DataPropertyName = "Prod_FuncionCalculo"
        Me.FuncionCalculo.HeaderText = "Funcion de Calculo"
        Me.FuncionCalculo.Name = "FuncionCalculo"
        Me.FuncionCalculo.ReadOnly = True
        '
        'SistemaCalculo
        '
        Me.SistemaCalculo.DataPropertyName = "Prod_SistemaCalculo"
        Me.SistemaCalculo.HeaderText = "Sistema de Calculo"
        Me.SistemaCalculo.Name = "SistemaCalculo"
        Me.SistemaCalculo.ReadOnly = True
        '
        'Simbolo
        '
        Me.Simbolo.DataPropertyName = "Prod_Simbolo"
        Me.Simbolo.HeaderText = "Simbolo"
        Me.Simbolo.Name = "Simbolo"
        Me.Simbolo.ReadOnly = True
        '
        'tcDatos
        '
        Me.tcDatos.Controls.Add(Me.tpLista)
        Me.tcDatos.Controls.Add(Me.tpDatos)
        Me.tcDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcDatos.Location = New System.Drawing.Point(0, 53)
        Me.tcDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.tcDatos.Name = "tcDatos"
        Me.tcDatos.SelectedIndex = 0
        Me.tcDatos.Size = New System.Drawing.Size(1208, 420)
        Me.tcDatos.TabIndex = 20
        '
        'tpLista
        '
        Me.tpLista.Controls.Add(Me.GroupBox2)
        Me.tpLista.Location = New System.Drawing.Point(4, 29)
        Me.tpLista.Margin = New System.Windows.Forms.Padding(4)
        Me.tpLista.Name = "tpLista"
        Me.tpLista.Padding = New System.Windows.Forms.Padding(4)
        Me.tpLista.Size = New System.Drawing.Size(1200, 387)
        Me.tpLista.TabIndex = 0
        Me.tpLista.Text = "Listado de Productos"
        Me.tpLista.UseVisualStyleBackColor = True
        '
        'tpDatos
        '
        Me.tpDatos.Controls.Add(Me.Panel3)
        Me.tpDatos.Location = New System.Drawing.Point(4, 29)
        Me.tpDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.tpDatos.Name = "tpDatos"
        Me.tpDatos.Padding = New System.Windows.Forms.Padding(4)
        Me.tpDatos.Size = New System.Drawing.Size(1200, 387)
        Me.tpDatos.TabIndex = 1
        Me.tpDatos.Text = "Datos"
        Me.tpDatos.UseVisualStyleBackColor = True
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 559)
        Me.Controls.Add(Me.tcDatos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modulo de Productos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcDatos.ResumeLayout(False)
        Me.tpLista.ResumeLayout(False)
        Me.tpDatos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDescrip As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEspesorDesde As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAnchoDesde As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkEliminar As System.Windows.Forms.CheckBox
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblinexistente As System.Windows.Forms.Label
    Friend WithEvents dataListado As System.Windows.Forms.DataGridView
    Friend WithEvents tcDatos As System.Windows.Forms.TabControl
    Friend WithEvents tpLista As System.Windows.Forms.TabPage
    Friend WithEvents tpDatos As System.Windows.Forms.TabPage
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtLargoDesde As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbTipoProducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblTipoCubicacion As System.Windows.Forms.Label
    Friend WithEvents cmbClaseComercial As System.Windows.Forms.ComboBox
    Friend WithEvents lineaprodCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtRendimiento As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbOperadorL As System.Windows.Forms.ComboBox
    Friend WithEvents cbOperadorA As System.Windows.Forms.ComboBox
    Friend WithEvents cbOperadorE As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtSimboloCubi As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtSisCubicacion As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbUnidMedL As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cbUnidMedAb As System.Windows.Forms.ComboBox
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClaseComercial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rendimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UniMedidaAb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UniMedLargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Espesor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OperadorE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ancho As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OperadorA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Largo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OperadorL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FuncionCalculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SistemaCalculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Simbolo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxFacEsp As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
