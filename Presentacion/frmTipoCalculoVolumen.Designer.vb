<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoCalculoVolumen
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTipoCalculoVolumen))
        Me.tcDatos = New System.Windows.Forms.TabControl()
        Me.tpLista = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkEliminar = New System.Windows.Forms.CheckBox()
        Me.lblinexistente = New System.Windows.Forms.Label()
        Me.dataListado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Elementos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Funcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalVolumen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FcVm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Simbolo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpDatos = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbPtM3 = New System.Windows.Forms.ComboBox()
        Me.cbSimbolo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btIrAFuncion = New System.Windows.Forms.Button()
        Me.btLimpiarElementos = New System.Windows.Forms.Button()
        Me.btNPq = New System.Windows.Forms.Button()
        Me.btNP = New System.Windows.Forms.Button()
        Me.btPq = New System.Windows.Forms.Button()
        Me.btP = New System.Windows.Forms.Button()
        Me.btParenAbre = New System.Windows.Forms.Button()
        Me.btParenCerrar = New System.Windows.Forms.Button()
        Me.btPor = New System.Windows.Forms.Button()
        Me.btL = New System.Windows.Forms.Button()
        Me.btA = New System.Windows.Forms.Button()
        Me.btE = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFe = New System.Windows.Forms.TextBox()
        Me.txtFcVm = New System.Windows.Forms.TextBox()
        Me.txtFuncion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtElementos = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtProced = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.tcDatos.SuspendLayout()
        Me.tpLista.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpDatos.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcDatos
        '
        Me.tcDatos.Controls.Add(Me.tpLista)
        Me.tcDatos.Controls.Add(Me.tpDatos)
        Me.tcDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcDatos.Location = New System.Drawing.Point(12, 59)
        Me.tcDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.tcDatos.Name = "tcDatos"
        Me.tcDatos.SelectedIndex = 0
        Me.tcDatos.Size = New System.Drawing.Size(735, 343)
        Me.tcDatos.TabIndex = 29
        '
        'tpLista
        '
        Me.tpLista.Controls.Add(Me.GroupBox2)
        Me.tpLista.Location = New System.Drawing.Point(4, 29)
        Me.tpLista.Margin = New System.Windows.Forms.Padding(4)
        Me.tpLista.Name = "tpLista"
        Me.tpLista.Padding = New System.Windows.Forms.Padding(4)
        Me.tpLista.Size = New System.Drawing.Size(727, 310)
        Me.tpLista.TabIndex = 0
        Me.tpLista.Text = "Listado de Ubicaciones"
        Me.tpLista.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.chkEliminar)
        Me.GroupBox2.Controls.Add(Me.lblinexistente)
        Me.GroupBox2.Controls.Add(Me.dataListado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox2.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(711, 272)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Enabled = False
        Me.txtBuscar.Location = New System.Drawing.Point(107, 242)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(199, 23)
        Me.txtBuscar.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(15, 242)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Buscar"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkEliminar
        '
        Me.chkEliminar.AutoSize = True
        Me.chkEliminar.ForeColor = System.Drawing.Color.DarkGreen
        Me.chkEliminar.Location = New System.Drawing.Point(357, 246)
        Me.chkEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.chkEliminar.Name = "chkEliminar"
        Me.chkEliminar.Size = New System.Drawing.Size(80, 21)
        Me.chkEliminar.TabIndex = 18
        Me.chkEliminar.Text = "Eliminar"
        Me.chkEliminar.UseVisualStyleBackColor = True
        '
        'lblinexistente
        '
        Me.lblinexistente.AutoSize = True
        Me.lblinexistente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblinexistente.ForeColor = System.Drawing.Color.Red
        Me.lblinexistente.Location = New System.Drawing.Point(187, 123)
        Me.lblinexistente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblinexistente.Name = "lblinexistente"
        Me.lblinexistente.Size = New System.Drawing.Size(192, 17)
        Me.lblinexistente.TabIndex = 1
        Me.lblinexistente.Text = "No hay registros que mostrar"
        '
        'dataListado
        '
        Me.dataListado.AllowUserToAddRows = False
        Me.dataListado.AllowUserToDeleteRows = False
        Me.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.ID, Me.Elementos, Me.Funcion, Me.CalVolumen, Me.FcVm, Me.Fe, Me.Simbolo})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataListado.DefaultCellStyle = DataGridViewCellStyle1
        Me.dataListado.Location = New System.Drawing.Point(13, 21)
        Me.dataListado.Margin = New System.Windows.Forms.Padding(4)
        Me.dataListado.MultiSelect = False
        Me.dataListado.Name = "dataListado"
        Me.dataListado.ReadOnly = True
        Me.dataListado.RowHeadersVisible = False
        Me.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListado.Size = New System.Drawing.Size(685, 218)
        Me.dataListado.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 334
        '
        'ID
        '
        Me.ID.DataPropertyName = "TipCal_id"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Elementos
        '
        Me.Elementos.DataPropertyName = "TipCal_Elementos"
        Me.Elementos.HeaderText = "Elementos"
        Me.Elementos.Name = "Elementos"
        Me.Elementos.ReadOnly = True
        '
        'Funcion
        '
        Me.Funcion.DataPropertyName = "TipCal_DescripcionFunc"
        Me.Funcion.HeaderText = "Funcion"
        Me.Funcion.Name = "Funcion"
        Me.Funcion.ReadOnly = True
        '
        'CalVolumen
        '
        Me.CalVolumen.DataPropertyName = "TipCal_Volumen"
        Me.CalVolumen.HeaderText = "Cal Volumen"
        Me.CalVolumen.Name = "CalVolumen"
        Me.CalVolumen.ReadOnly = True
        '
        'FcVm
        '
        Me.FcVm.DataPropertyName = "TipCal_FcVm"
        Me.FcVm.HeaderText = "FcVm"
        Me.FcVm.Name = "FcVm"
        Me.FcVm.ReadOnly = True
        '
        'Fe
        '
        Me.Fe.DataPropertyName = "TipCal_Fe"
        Me.Fe.HeaderText = "Fe"
        Me.Fe.Name = "Fe"
        Me.Fe.ReadOnly = True
        '
        'Simbolo
        '
        Me.Simbolo.DataPropertyName = "TipCal_Simbolo"
        Me.Simbolo.HeaderText = "Simbolo"
        Me.Simbolo.Name = "Simbolo"
        Me.Simbolo.ReadOnly = True
        '
        'tpDatos
        '
        Me.tpDatos.Controls.Add(Me.Panel3)
        Me.tpDatos.Location = New System.Drawing.Point(4, 29)
        Me.tpDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.tpDatos.Name = "tpDatos"
        Me.tpDatos.Padding = New System.Windows.Forms.Padding(4)
        Me.tpDatos.Size = New System.Drawing.Size(727, 310)
        Me.tpDatos.TabIndex = 1
        Me.tpDatos.Text = "Datos"
        Me.tpDatos.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.cbPtM3)
        Me.Panel3.Controls.Add(Me.cbSimbolo)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtFe)
        Me.Panel3.Controls.Add(Me.txtFcVm)
        Me.Panel3.Controls.Add(Me.txtFuncion)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txtId)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtElementos)
        Me.Panel3.Location = New System.Drawing.Point(11, 31)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(708, 271)
        Me.Panel3.TabIndex = 21
        '
        'cbPtM3
        '
        Me.cbPtM3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPtM3.FormattingEnabled = True
        Me.cbPtM3.Items.AddRange(New Object() {"Pt", "m3"})
        Me.cbPtM3.Location = New System.Drawing.Point(127, 169)
        Me.cbPtM3.Name = "cbPtM3"
        Me.cbPtM3.Size = New System.Drawing.Size(186, 28)
        Me.cbPtM3.TabIndex = 45
        '
        'cbSimbolo
        '
        Me.cbSimbolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSimbolo.FormattingEnabled = True
        Me.cbSimbolo.Items.AddRange(New Object() {"P", "NP", "Pq", "NPq"})
        Me.cbSimbolo.Location = New System.Drawing.Point(127, 106)
        Me.cbSimbolo.Name = "cbSimbolo"
        Me.cbSimbolo.Size = New System.Drawing.Size(186, 28)
        Me.cbSimbolo.TabIndex = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btIrAFuncion)
        Me.GroupBox1.Controls.Add(Me.btLimpiarElementos)
        Me.GroupBox1.Controls.Add(Me.btNPq)
        Me.GroupBox1.Controls.Add(Me.btNP)
        Me.GroupBox1.Controls.Add(Me.btPq)
        Me.GroupBox1.Controls.Add(Me.btP)
        Me.GroupBox1.Controls.Add(Me.btParenAbre)
        Me.GroupBox1.Controls.Add(Me.btParenCerrar)
        Me.GroupBox1.Controls.Add(Me.btPor)
        Me.GroupBox1.Controls.Add(Me.btL)
        Me.GroupBox1.Controls.Add(Me.btA)
        Me.GroupBox1.Controls.Add(Me.btE)
        Me.GroupBox1.Location = New System.Drawing.Point(319, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 96)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contendor de elementos"
        '
        'btIrAFuncion
        '
        Me.btIrAFuncion.Location = New System.Drawing.Point(203, 29)
        Me.btIrAFuncion.Name = "btIrAFuncion"
        Me.btIrAFuncion.Size = New System.Drawing.Size(98, 26)
        Me.btIrAFuncion.TabIndex = 52
        Me.btIrAFuncion.Text = "Siguiente"
        Me.btIrAFuncion.UseVisualStyleBackColor = True
        '
        'btLimpiarElementos
        '
        Me.btLimpiarElementos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLimpiarElementos.Location = New System.Drawing.Point(202, 58)
        Me.btLimpiarElementos.Name = "btLimpiarElementos"
        Me.btLimpiarElementos.Size = New System.Drawing.Size(100, 27)
        Me.btLimpiarElementos.TabIndex = 51
        Me.btLimpiarElementos.Text = "Limpiar"
        Me.btLimpiarElementos.UseVisualStyleBackColor = True
        '
        'btNPq
        '
        Me.btNPq.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNPq.Location = New System.Drawing.Point(147, 58)
        Me.btNPq.Name = "btNPq"
        Me.btNPq.Size = New System.Drawing.Size(53, 27)
        Me.btNPq.TabIndex = 51
        Me.btNPq.Text = "NPq"
        Me.btNPq.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btNPq.UseVisualStyleBackColor = True
        '
        'btNP
        '
        Me.btNP.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNP.Location = New System.Drawing.Point(147, 29)
        Me.btNP.Name = "btNP"
        Me.btNP.Size = New System.Drawing.Size(53, 27)
        Me.btNP.TabIndex = 51
        Me.btNP.Text = "NP"
        Me.btNP.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btNP.UseVisualStyleBackColor = True
        '
        'btPq
        '
        Me.btPq.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPq.Location = New System.Drawing.Point(99, 58)
        Me.btPq.Name = "btPq"
        Me.btPq.Size = New System.Drawing.Size(47, 27)
        Me.btPq.TabIndex = 49
        Me.btPq.Text = "Pq"
        Me.btPq.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btPq.UseVisualStyleBackColor = True
        '
        'btP
        '
        Me.btP.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btP.Location = New System.Drawing.Point(99, 29)
        Me.btP.Name = "btP"
        Me.btP.Size = New System.Drawing.Size(47, 27)
        Me.btP.TabIndex = 46
        Me.btP.Text = "P"
        Me.btP.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btP.UseVisualStyleBackColor = True
        '
        'btParenAbre
        '
        Me.btParenAbre.Location = New System.Drawing.Point(38, 29)
        Me.btParenAbre.Name = "btParenAbre"
        Me.btParenAbre.Size = New System.Drawing.Size(27, 27)
        Me.btParenAbre.TabIndex = 45
        Me.btParenAbre.Text = "("
        Me.btParenAbre.UseVisualStyleBackColor = True
        '
        'btParenCerrar
        '
        Me.btParenCerrar.Location = New System.Drawing.Point(38, 58)
        Me.btParenCerrar.Name = "btParenCerrar"
        Me.btParenCerrar.Size = New System.Drawing.Size(27, 27)
        Me.btParenCerrar.TabIndex = 45
        Me.btParenCerrar.Text = ")"
        Me.btParenCerrar.UseVisualStyleBackColor = True
        '
        'btPor
        '
        Me.btPor.Location = New System.Drawing.Point(68, 58)
        Me.btPor.Name = "btPor"
        Me.btPor.Size = New System.Drawing.Size(27, 27)
        Me.btPor.TabIndex = 45
        Me.btPor.Text = "x"
        Me.btPor.UseVisualStyleBackColor = True
        '
        'btL
        '
        Me.btL.Location = New System.Drawing.Point(68, 29)
        Me.btL.Name = "btL"
        Me.btL.Size = New System.Drawing.Size(27, 27)
        Me.btL.TabIndex = 45
        Me.btL.Text = "L"
        Me.btL.UseVisualStyleBackColor = True
        '
        'btA
        '
        Me.btA.Location = New System.Drawing.Point(7, 29)
        Me.btA.Name = "btA"
        Me.btA.Size = New System.Drawing.Size(27, 27)
        Me.btA.TabIndex = 48
        Me.btA.Text = "A"
        Me.btA.UseVisualStyleBackColor = True
        '
        'btE
        '
        Me.btE.Location = New System.Drawing.Point(7, 58)
        Me.btE.Name = "btE"
        Me.btE.Size = New System.Drawing.Size(27, 27)
        Me.btE.TabIndex = 47
        Me.btE.Text = "E"
        Me.btE.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.SeaGreen
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(7, 110)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 23)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Simbolo"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SeaGreen
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(7, 238)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 23)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Fe"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SeaGreen
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(7, 207)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 23)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "FcVm"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SeaGreen
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(7, 175)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 23)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Cal. Volumen"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SeaGreen
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(7, 143)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 23)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Desc. Funcion"
        '
        'txtFe
        '
        Me.txtFe.Enabled = False
        Me.txtFe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFe.Location = New System.Drawing.Point(127, 235)
        Me.txtFe.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFe.Name = "txtFe"
        Me.txtFe.Size = New System.Drawing.Size(557, 24)
        Me.txtFe.TabIndex = 43
        '
        'txtFcVm
        '
        Me.txtFcVm.Enabled = False
        Me.txtFcVm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFcVm.Location = New System.Drawing.Point(127, 204)
        Me.txtFcVm.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFcVm.Name = "txtFcVm"
        Me.txtFcVm.Size = New System.Drawing.Size(557, 24)
        Me.txtFcVm.TabIndex = 43
        '
        'txtFuncion
        '
        Me.txtFuncion.Enabled = False
        Me.txtFuncion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuncion.Location = New System.Drawing.Point(127, 140)
        Me.txtFuncion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFuncion.Name = "txtFuncion"
        Me.txtFuncion.Size = New System.Drawing.Size(557, 24)
        Me.txtFuncion.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(7, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(127, 42)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(69, 24)
        Me.txtId.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SeaGreen
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(7, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Elementos"
        '
        'txtElementos
        '
        Me.txtElementos.Enabled = False
        Me.txtElementos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtElementos.Location = New System.Drawing.Point(127, 75)
        Me.txtElementos.Margin = New System.Windows.Forms.Padding(4)
        Me.txtElementos.Name = "txtElementos"
        Me.txtElementos.Size = New System.Drawing.Size(185, 24)
        Me.txtElementos.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.txtProced)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(751, 56)
        Me.Panel1.TabIndex = 27
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'txtProced
        '
        Me.txtProced.AutoSize = True
        Me.txtProced.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProced.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtProced.Location = New System.Drawing.Point(59, 12)
        Me.txtProced.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtProced.Name = "txtProced"
        Me.txtProced.Size = New System.Drawing.Size(577, 31)
        Me.txtProced.TabIndex = 9
        Me.txtProced.Text = "Modulo de Parametros de Calculo del Volumen"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnNuevo)
        Me.Panel2.Controls.Add(Me.btnModificar)
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.btnSalir)
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Controls.Add(Me.btnGuardar)
        Me.Panel2.Location = New System.Drawing.Point(-4, 410)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(755, 72)
        Me.Panel2.TabIndex = 28
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(5, 7)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(123, 42)
        Me.btnNuevo.TabIndex = 20
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.Control
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(129, 7)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(123, 42)
        Me.btnModificar.TabIndex = 15
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(501, 7)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(123, 42)
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
        Me.btnSalir.Location = New System.Drawing.Point(625, 7)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(123, 42)
        Me.btnSalir.TabIndex = 19
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(377, 7)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(123, 42)
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
        Me.btnGuardar.Location = New System.Drawing.Point(253, 7)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(123, 42)
        Me.btnGuardar.TabIndex = 17
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'frmTipoCalculoVolumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 488)
        Me.Controls.Add(Me.tcDatos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTipoCalculoVolumen"
        Me.Text = "Parametros de Calculo del Volumen"
        Me.tcDatos.ResumeLayout(False)
        Me.tpLista.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpDatos.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcDatos As System.Windows.Forms.TabControl
    Friend WithEvents tpLista As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkEliminar As System.Windows.Forms.CheckBox
    Friend WithEvents lblinexistente As System.Windows.Forms.Label
    Friend WithEvents dataListado As System.Windows.Forms.DataGridView
    Friend WithEvents tpDatos As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtElementos As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtProced As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFuncion As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFe As System.Windows.Forms.TextBox
    Friend WithEvents txtFcVm As System.Windows.Forms.TextBox
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Elementos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Funcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalVolumen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FcVm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Simbolo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btNPq As System.Windows.Forms.Button
    Friend WithEvents btNP As System.Windows.Forms.Button
    Friend WithEvents btPq As System.Windows.Forms.Button
    Friend WithEvents btP As System.Windows.Forms.Button
    Friend WithEvents btParenAbre As System.Windows.Forms.Button
    Friend WithEvents btParenCerrar As System.Windows.Forms.Button
    Friend WithEvents btPor As System.Windows.Forms.Button
    Friend WithEvents btL As System.Windows.Forms.Button
    Friend WithEvents btA As System.Windows.Forms.Button
    Friend WithEvents btE As System.Windows.Forms.Button
    Friend WithEvents cbSimbolo As System.Windows.Forms.ComboBox
    Friend WithEvents btLimpiarElementos As System.Windows.Forms.Button
    Friend WithEvents btIrAFuncion As System.Windows.Forms.Button
    Friend WithEvents cbPtM3 As System.Windows.Forms.ComboBox
End Class
