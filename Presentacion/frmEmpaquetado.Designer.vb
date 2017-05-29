<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpaquetado
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpaquetado))
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.dgwDataDetalle = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.chkEliminar = New System.Windows.Forms.CheckBox()
        Me.txtAserraderoId = New System.Windows.Forms.TextBox()
        Me.txtAserraderoNombre = New System.Windows.Forms.TextBox()
        Me.lblResponsable = New System.Windows.Forms.Label()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.chkCertificada = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtPaquete = New System.Windows.Forms.TextBox()
        Me.txtTotPiezas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.dgwPaquetesDetalle = New System.Windows.Forms.DataGridView()
        Me.txtTotPaq = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtTotalVolpt = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNroDoc = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDeshacer = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnAgregarPaq = New System.Windows.Forms.Button()
        Me.btnEditarPaq = New System.Windows.Forms.Button()
        Me.btnEliminarPaq = New System.Windows.Forms.Button()
        Me.btnBuscarNros = New System.Windows.Forms.Button()
        Me.btnAnt = New System.Windows.Forms.Button()
        Me.btnSig = New System.Windows.Forms.Button()
        Me.btnUlt = New System.Windows.Forms.Button()
        Me.btnPri = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAserradero = New System.Windows.Forms.Button()
        Me.btnEliminarDetalle = New System.Windows.Forms.Button()
        Me.btnEditarDetalle = New System.Windows.Forms.Button()
        Me.btnNuevoDetalle = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgwDataDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgwPaquetesDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtId
        '
        Me.TxtId.BackColor = System.Drawing.SystemColors.Control
        Me.TxtId.Enabled = False
        Me.TxtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtId.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.TxtId.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtId.Location = New System.Drawing.Point(602, 10)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(61, 26)
        Me.TxtId.TabIndex = 53
        Me.TxtId.Tag = "Id"
        Me.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label28.Location = New System.Drawing.Point(572, 10)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(24, 23)
        Me.Label28.TabIndex = 54
        Me.Label28.Text = "Id"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label29.Location = New System.Drawing.Point(8, 19)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(103, 23)
        Me.Label29.TabIndex = 44
        Me.Label29.Text = "Fecha"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgwDataDetalle
        '
        Me.dgwDataDetalle.AllowUserToAddRows = False
        Me.dgwDataDetalle.AllowUserToDeleteRows = False
        Me.dgwDataDetalle.AllowUserToResizeColumns = False
        Me.dgwDataDetalle.AllowUserToResizeRows = False
        Me.dgwDataDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgwDataDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwDataDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwDataDetalle.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgwDataDetalle.Location = New System.Drawing.Point(7, 12)
        Me.dgwDataDetalle.MultiSelect = False
        Me.dgwDataDetalle.Name = "dgwDataDetalle"
        Me.dgwDataDetalle.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwDataDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgwDataDetalle.RowHeadersVisible = False
        Me.dgwDataDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwDataDetalle.Size = New System.Drawing.Size(960, 132)
        Me.dgwDataDetalle.TabIndex = 22
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtFecha.Location = New System.Drawing.Point(115, 19)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(151, 26)
        Me.txtFecha.TabIndex = 43
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.btnBuscarNros)
        Me.Panel2.Controls.Add(Me.btnAnt)
        Me.Panel2.Controls.Add(Me.btnSig)
        Me.Panel2.Controls.Add(Me.btnUlt)
        Me.Panel2.Controls.Add(Me.btnPri)
        Me.Panel2.Controls.Add(Me.btnSalir)
        Me.Panel2.Location = New System.Drawing.Point(-7, 588)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1248, 47)
        Me.Panel2.TabIndex = 54
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnAgregarPaq)
        Me.Panel4.Controls.Add(Me.btnEditarPaq)
        Me.Panel4.Controls.Add(Me.btnEliminarPaq)
        Me.Panel4.Controls.Add(Me.chkEliminar)
        Me.Panel4.Location = New System.Drawing.Point(474, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(434, 39)
        Me.Panel4.TabIndex = 69
        '
        'chkEliminar
        '
        Me.chkEliminar.AutoSize = True
        Me.chkEliminar.Enabled = False
        Me.chkEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkEliminar.Location = New System.Drawing.Point(356, 10)
        Me.chkEliminar.Name = "chkEliminar"
        Me.chkEliminar.Size = New System.Drawing.Size(75, 20)
        Me.chkEliminar.TabIndex = 56
        Me.chkEliminar.Text = "Eliminar"
        Me.chkEliminar.UseVisualStyleBackColor = True
        '
        'txtAserraderoId
        '
        Me.txtAserraderoId.Enabled = False
        Me.txtAserraderoId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAserraderoId.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtAserraderoId.Location = New System.Drawing.Point(115, 47)
        Me.txtAserraderoId.Name = "txtAserraderoId"
        Me.txtAserraderoId.Size = New System.Drawing.Size(26, 26)
        Me.txtAserraderoId.TabIndex = 1
        Me.txtAserraderoId.Tag = "el Responsable"
        Me.txtAserraderoId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAserraderoNombre
        '
        Me.txtAserraderoNombre.Enabled = False
        Me.txtAserraderoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAserraderoNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtAserraderoNombre.Location = New System.Drawing.Point(144, 47)
        Me.txtAserraderoNombre.Name = "txtAserraderoNombre"
        Me.txtAserraderoNombre.Size = New System.Drawing.Size(492, 26)
        Me.txtAserraderoNombre.TabIndex = 2
        Me.txtAserraderoNombre.Tag = "el Responsable"
        '
        'lblResponsable
        '
        Me.lblResponsable.BackColor = System.Drawing.Color.OliveDrab
        Me.lblResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponsable.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblResponsable.Location = New System.Drawing.Point(8, 47)
        Me.lblResponsable.Name = "lblResponsable"
        Me.lblResponsable.Size = New System.Drawing.Size(103, 25)
        Me.lblResponsable.TabIndex = 6
        Me.lblResponsable.Text = "Aserradero"
        Me.lblResponsable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.SystemColors.Control
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Controls.Add(Me.txtObservacion)
        Me.gbDatos.Controls.Add(Me.chkCertificada)
        Me.gbDatos.Controls.Add(Me.Label28)
        Me.gbDatos.Controls.Add(Me.TxtId)
        Me.gbDatos.Controls.Add(Me.Label29)
        Me.gbDatos.Controls.Add(Me.txtFecha)
        Me.gbDatos.Controls.Add(Me.btnAserradero)
        Me.gbDatos.Controls.Add(Me.txtAserraderoId)
        Me.gbDatos.Controls.Add(Me.txtAserraderoNombre)
        Me.gbDatos.Controls.Add(Me.lblResponsable)
        Me.gbDatos.Location = New System.Drawing.Point(5, 45)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(706, 112)
        Me.gbDatos.TabIndex = 52
        Me.gbDatos.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SeaGreen
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(8, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 25)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Observación"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtObservacion
        '
        Me.txtObservacion.Enabled = False
        Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtObservacion.Location = New System.Drawing.Point(115, 79)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(548, 26)
        Me.txtObservacion.TabIndex = 57
        Me.txtObservacion.Tag = "Id"
        '
        'chkCertificada
        '
        Me.chkCertificada.AutoSize = True
        Me.chkCertificada.Enabled = False
        Me.chkCertificada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCertificada.ForeColor = System.Drawing.Color.DarkGreen
        Me.chkCertificada.Location = New System.Drawing.Point(284, 19)
        Me.chkCertificada.Name = "chkCertificada"
        Me.chkCertificada.Size = New System.Drawing.Size(162, 24)
        Me.chkCertificada.TabIndex = 55
        Me.chkCertificada.Text = "Madera Certificada"
        Me.chkCertificada.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel5)
        Me.GroupBox2.Controls.Add(Me.txtPaquete)
        Me.GroupBox2.Controls.Add(Me.txtTotPiezas)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.dgwPaquetesDetalle)
        Me.GroupBox2.Controls.Add(Me.txtTotPaq)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.txtTotalVolpt)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.dgwDataDetalle)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(973, 419)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnEliminarDetalle)
        Me.Panel5.Controls.Add(Me.btnEditarDetalle)
        Me.Panel5.Controls.Add(Me.btnNuevoDetalle)
        Me.Panel5.Location = New System.Drawing.Point(12, 376)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 38)
        Me.Panel5.TabIndex = 68
        '
        'txtPaquete
        '
        Me.txtPaquete.Enabled = False
        Me.txtPaquete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaquete.Location = New System.Drawing.Point(8, 171)
        Me.txtPaquete.Multiline = True
        Me.txtPaquete.Name = "txtPaquete"
        Me.txtPaquete.Size = New System.Drawing.Size(444, 26)
        Me.txtPaquete.TabIndex = 67
        Me.txtPaquete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotPiezas
        '
        Me.txtTotPiezas.Enabled = False
        Me.txtTotPiezas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotPiezas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTotPiezas.Location = New System.Drawing.Point(273, 392)
        Me.txtTotPiezas.Name = "txtTotPiezas"
        Me.txtTotPiezas.Size = New System.Drawing.Size(86, 22)
        Me.txtTotPiezas.TabIndex = 64
        Me.txtTotPiezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(273, 374)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Total Piezas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label32.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label32.Location = New System.Drawing.Point(9, 149)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(443, 19)
        Me.Label32.TabIndex = 53
        Me.Label32.Text = "DETALLE DE PAQUETES"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgwPaquetesDetalle
        '
        Me.dgwPaquetesDetalle.AllowUserToAddRows = False
        Me.dgwPaquetesDetalle.AllowUserToDeleteRows = False
        Me.dgwPaquetesDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwPaquetesDetalle.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgwPaquetesDetalle.Location = New System.Drawing.Point(9, 200)
        Me.dgwPaquetesDetalle.MultiSelect = False
        Me.dgwPaquetesDetalle.Name = "dgwPaquetesDetalle"
        Me.dgwPaquetesDetalle.ReadOnly = True
        Me.dgwPaquetesDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwPaquetesDetalle.Size = New System.Drawing.Size(443, 169)
        Me.dgwPaquetesDetalle.TabIndex = 52
        '
        'txtTotPaq
        '
        Me.txtTotPaq.Enabled = False
        Me.txtTotPaq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotPaq.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTotPaq.Location = New System.Drawing.Point(885, 150)
        Me.txtTotPaq.Name = "txtTotPaq"
        Me.txtTotPaq.Size = New System.Drawing.Size(81, 22)
        Me.txtTotPaq.TabIndex = 49
        Me.txtTotPaq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label31.Location = New System.Drawing.Point(777, 151)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(102, 21)
        Me.Label31.TabIndex = 48
        Me.Label31.Text = "Total Paquetes"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalVolpt
        '
        Me.txtTotalVolpt.Enabled = False
        Me.txtTotalVolpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalVolpt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTotalVolpt.Location = New System.Drawing.Point(365, 393)
        Me.txtTotalVolpt.Name = "txtTotalVolpt"
        Me.txtTotalVolpt.Size = New System.Drawing.Size(86, 22)
        Me.txtTotalVolpt.TabIndex = 47
        Me.txtTotalVolpt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label30.Location = New System.Drawing.Point(365, 374)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(86, 18)
        Me.Label30.TabIndex = 46
        Me.Label30.Text = "Total Vol. PT "
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(667, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nro.Documento"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtNroDoc)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 49)
        Me.Panel1.TabIndex = 51
        '
        'txtNroDoc
        '
        Me.txtNroDoc.BackColor = System.Drawing.SystemColors.Control
        Me.txtNroDoc.Enabled = False
        Me.txtNroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDoc.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.txtNroDoc.Location = New System.Drawing.Point(810, 8)
        Me.txtNroDoc.Mask = "999999"
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(133, 31)
        Me.txtNroDoc.TabIndex = 12
        Me.txtNroDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label6.Location = New System.Drawing.Point(37, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(252, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Modulo de Empaquetado"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Location = New System.Drawing.Point(712, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 110)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnDeshacer)
        Me.Panel3.Controls.Add(Me.btnNuevo)
        Me.Panel3.Controls.Add(Me.btnModificar)
        Me.Panel3.Controls.Add(Me.btnGuardar)
        Me.Panel3.Location = New System.Drawing.Point(5, 9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(254, 77)
        Me.Panel3.TabIndex = 53
        '
        'btnDeshacer
        '
        Me.btnDeshacer.BackColor = System.Drawing.Color.Khaki
        Me.btnDeshacer.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDeshacer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeshacer.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnDeshacer.Image = CType(resources.GetObject("btnDeshacer.Image"), System.Drawing.Image)
        Me.btnDeshacer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeshacer.Location = New System.Drawing.Point(123, 41)
        Me.btnDeshacer.Name = "btnDeshacer"
        Me.btnDeshacer.Size = New System.Drawing.Size(128, 33)
        Me.btnDeshacer.TabIndex = 46
        Me.btnDeshacer.Text = "Deshacer"
        Me.btnDeshacer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeshacer.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Khaki
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(1, 3)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(115, 32)
        Me.btnNuevo.TabIndex = 48
        Me.btnNuevo.Text = "Nuevo Doc."
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Khaki
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(123, 3)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(128, 32)
        Me.btnModificar.TabIndex = 45
        Me.btnModificar.Text = "Modificar Doc."
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Khaki
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(2, 41)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(115, 33)
        Me.btnGuardar.TabIndex = 47
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnAgregarPaq
        '
        Me.btnAgregarPaq.BackColor = System.Drawing.Color.Khaki
        Me.btnAgregarPaq.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAgregarPaq.Enabled = False
        Me.btnAgregarPaq.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPaq.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnAgregarPaq.Image = CType(resources.GetObject("btnAgregarPaq.Image"), System.Drawing.Image)
        Me.btnAgregarPaq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarPaq.Location = New System.Drawing.Point(6, 1)
        Me.btnAgregarPaq.Name = "btnAgregarPaq"
        Me.btnAgregarPaq.Size = New System.Drawing.Size(117, 36)
        Me.btnAgregarPaq.TabIndex = 55
        Me.btnAgregarPaq.Text = "Agreg. Paqte"
        Me.btnAgregarPaq.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarPaq.UseVisualStyleBackColor = False
        '
        'btnEditarPaq
        '
        Me.btnEditarPaq.BackColor = System.Drawing.Color.Khaki
        Me.btnEditarPaq.Enabled = False
        Me.btnEditarPaq.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarPaq.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnEditarPaq.Image = CType(resources.GetObject("btnEditarPaq.Image"), System.Drawing.Image)
        Me.btnEditarPaq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarPaq.Location = New System.Drawing.Point(126, 1)
        Me.btnEditarPaq.Name = "btnEditarPaq"
        Me.btnEditarPaq.Size = New System.Drawing.Size(106, 36)
        Me.btnEditarPaq.TabIndex = 58
        Me.btnEditarPaq.Text = "Edit Paqte"
        Me.btnEditarPaq.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditarPaq.UseVisualStyleBackColor = False
        '
        'btnEliminarPaq
        '
        Me.btnEliminarPaq.BackColor = System.Drawing.Color.Khaki
        Me.btnEliminarPaq.Enabled = False
        Me.btnEliminarPaq.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPaq.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnEliminarPaq.Image = CType(resources.GetObject("btnEliminarPaq.Image"), System.Drawing.Image)
        Me.btnEliminarPaq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarPaq.Location = New System.Drawing.Point(235, 1)
        Me.btnEliminarPaq.Name = "btnEliminarPaq"
        Me.btnEliminarPaq.Size = New System.Drawing.Size(110, 36)
        Me.btnEliminarPaq.TabIndex = 57
        Me.btnEliminarPaq.Text = "Elim.Paqte"
        Me.btnEliminarPaq.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminarPaq.UseVisualStyleBackColor = False
        '
        'btnBuscarNros
        '
        Me.btnBuscarNros.BackColor = System.Drawing.Color.Khaki
        Me.btnBuscarNros.Enabled = False
        Me.btnBuscarNros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarNros.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnBuscarNros.Image = CType(resources.GetObject("btnBuscarNros.Image"), System.Drawing.Image)
        Me.btnBuscarNros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarNros.Location = New System.Drawing.Point(333, 5)
        Me.btnBuscarNros.Name = "btnBuscarNros"
        Me.btnBuscarNros.Size = New System.Drawing.Size(142, 36)
        Me.btnBuscarNros.TabIndex = 52
        Me.btnBuscarNros.Text = "Buscar Docs"
        Me.btnBuscarNros.UseVisualStyleBackColor = False
        '
        'btnAnt
        '
        Me.btnAnt.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAnt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAnt.Image = CType(resources.GetObject("btnAnt.Image"), System.Drawing.Image)
        Me.btnAnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnt.Location = New System.Drawing.Point(168, 7)
        Me.btnAnt.Name = "btnAnt"
        Me.btnAnt.Size = New System.Drawing.Size(75, 32)
        Me.btnAnt.TabIndex = 49
        Me.btnAnt.Text = "Anterior"
        Me.btnAnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAnt.UseVisualStyleBackColor = False
        '
        'btnSig
        '
        Me.btnSig.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSig.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSig.Image = CType(resources.GetObject("btnSig.Image"), System.Drawing.Image)
        Me.btnSig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSig.Location = New System.Drawing.Point(87, 7)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.Size = New System.Drawing.Size(81, 32)
        Me.btnSig.TabIndex = 48
        Me.btnSig.Text = "Siguiente"
        Me.btnSig.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSig.UseVisualStyleBackColor = False
        '
        'btnUlt
        '
        Me.btnUlt.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUlt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUlt.Image = CType(resources.GetObject("btnUlt.Image"), System.Drawing.Image)
        Me.btnUlt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUlt.Location = New System.Drawing.Point(243, 7)
        Me.btnUlt.Name = "btnUlt"
        Me.btnUlt.Size = New System.Drawing.Size(75, 32)
        Me.btnUlt.TabIndex = 47
        Me.btnUlt.Text = "Ultimo"
        Me.btnUlt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUlt.UseVisualStyleBackColor = False
        '
        'btnPri
        '
        Me.btnPri.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPri.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPri.Image = CType(resources.GetObject("btnPri.Image"), System.Drawing.Image)
        Me.btnPri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPri.Location = New System.Drawing.Point(12, 7)
        Me.btnPri.Name = "btnPri"
        Me.btnPri.Size = New System.Drawing.Size(75, 32)
        Me.btnPri.TabIndex = 46
        Me.btnPri.Text = "Primero"
        Me.btnPri.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPri.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(913, 7)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(72, 33)
        Me.btnSalir.TabIndex = 39
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnAserradero
        '
        Me.btnAserradero.AutoSize = True
        Me.btnAserradero.Enabled = False
        Me.btnAserradero.Image = CType(resources.GetObject("btnAserradero.Image"), System.Drawing.Image)
        Me.btnAserradero.Location = New System.Drawing.Point(641, 47)
        Me.btnAserradero.Name = "btnAserradero"
        Me.btnAserradero.Size = New System.Drawing.Size(24, 22)
        Me.btnAserradero.TabIndex = 25
        Me.btnAserradero.UseVisualStyleBackColor = True
        '
        'btnEliminarDetalle
        '
        Me.btnEliminarDetalle.BackColor = System.Drawing.Color.Khaki
        Me.btnEliminarDetalle.Enabled = False
        Me.btnEliminarDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarDetalle.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnEliminarDetalle.Image = CType(resources.GetObject("btnEliminarDetalle.Image"), System.Drawing.Image)
        Me.btnEliminarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarDetalle.Location = New System.Drawing.Point(79, 2)
        Me.btnEliminarDetalle.Name = "btnEliminarDetalle"
        Me.btnEliminarDetalle.Size = New System.Drawing.Size(31, 32)
        Me.btnEliminarDetalle.TabIndex = 69
        Me.btnEliminarDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminarDetalle.UseVisualStyleBackColor = False
        '
        'btnEditarDetalle
        '
        Me.btnEditarDetalle.BackColor = System.Drawing.Color.Khaki
        Me.btnEditarDetalle.Enabled = False
        Me.btnEditarDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarDetalle.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnEditarDetalle.Image = CType(resources.GetObject("btnEditarDetalle.Image"), System.Drawing.Image)
        Me.btnEditarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarDetalle.Location = New System.Drawing.Point(41, 2)
        Me.btnEditarDetalle.Name = "btnEditarDetalle"
        Me.btnEditarDetalle.Size = New System.Drawing.Size(31, 32)
        Me.btnEditarDetalle.TabIndex = 67
        Me.btnEditarDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditarDetalle.UseVisualStyleBackColor = False
        '
        'btnNuevoDetalle
        '
        Me.btnNuevoDetalle.BackColor = System.Drawing.Color.Khaki
        Me.btnNuevoDetalle.Enabled = False
        Me.btnNuevoDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoDetalle.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnNuevoDetalle.Image = CType(resources.GetObject("btnNuevoDetalle.Image"), System.Drawing.Image)
        Me.btnNuevoDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevoDetalle.Location = New System.Drawing.Point(3, 2)
        Me.btnNuevoDetalle.Name = "btnNuevoDetalle"
        Me.btnNuevoDetalle.Size = New System.Drawing.Size(31, 32)
        Me.btnNuevoDetalle.TabIndex = 68
        Me.btnNuevoDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevoDetalle.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'frmEmpaquetado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 636)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.gbDatos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmEmpaquetado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modulo de Empaquetado"
        CType(Me.dgwDataDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgwPaquetesDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtId As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAnt As System.Windows.Forms.Button
    Friend WithEvents btnSig As System.Windows.Forms.Button
    Friend WithEvents btnUlt As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnPri As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAserradero As System.Windows.Forms.Button
    Friend WithEvents txtAserraderoId As System.Windows.Forms.TextBox
    Friend WithEvents txtAserraderoNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblResponsable As System.Windows.Forms.Label
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents chkCertificada As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents dgwPaquetesDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents txtTotPaq As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtTotalVolpt As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtNroDoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotPiezas As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPaquete As System.Windows.Forms.TextBox
    Public WithEvents dgwDataDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnAgregarPaq As System.Windows.Forms.Button
    Friend WithEvents btnEditarPaq As System.Windows.Forms.Button
    Friend WithEvents btnEliminarPaq As System.Windows.Forms.Button
    Friend WithEvents chkEliminar As System.Windows.Forms.CheckBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnEliminarDetalle As System.Windows.Forms.Button
    Friend WithEvents btnEditarDetalle As System.Windows.Forms.Button
    Friend WithEvents btnNuevoDetalle As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnDeshacer As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnBuscarNros As System.Windows.Forms.Button
End Class
