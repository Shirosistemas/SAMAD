<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaquete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaquete))
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNuevo = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEspecieId = New System.Windows.Forms.TextBox()
        Me.txtEspecieNombre = New System.Windows.Forms.TextBox()
        Me.txtProductoNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProductoId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHumedad = New System.Windows.Forms.ComboBox()
        Me.txtClasificacion = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNumPaq = New System.Windows.Forms.TextBox()
        Me.txtAcabado = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCubicadorNombre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCubicadorId = New System.Windows.Forms.TextBox()
        Me.btnEspecie = New System.Windows.Forms.Button()
        Me.btnCubicador = New System.Windows.Forms.Button()
        Me.btnProducto = New System.Windows.Forms.Button()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(5, 6)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(87, 34)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Aceptar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtNuevo)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(571, 46)
        Me.Panel1.TabIndex = 24
        '
        'txtNuevo
        '
        Me.txtNuevo.Location = New System.Drawing.Point(463, 9)
        Me.txtNuevo.Name = "txtNuevo"
        Me.txtNuevo.Size = New System.Drawing.Size(100, 20)
        Me.txtNuevo.TabIndex = 11
        Me.txtNuevo.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(53, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(280, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Mantenimiento de Paquetes"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Controls.Add(Me.btnGuardar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 362)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(571, 50)
        Me.Panel2.TabIndex = 25
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(93, 6)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(92, 34)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Id"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(85, 14)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(58, 21)
        Me.txtId.TabIndex = 0
        Me.txtId.Tag = "Id"
        Me.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SeaGreen
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(6, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 19)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Especie"
        '
        'txtEspecieId
        '
        Me.txtEspecieId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEspecieId.Enabled = False
        Me.txtEspecieId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspecieId.Location = New System.Drawing.Point(85, 72)
        Me.txtEspecieId.Name = "txtEspecieId"
        Me.txtEspecieId.Size = New System.Drawing.Size(58, 21)
        Me.txtEspecieId.TabIndex = 2
        '
        'txtEspecieNombre
        '
        Me.txtEspecieNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEspecieNombre.Enabled = False
        Me.txtEspecieNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspecieNombre.Location = New System.Drawing.Point(148, 72)
        Me.txtEspecieNombre.Name = "txtEspecieNombre"
        Me.txtEspecieNombre.Size = New System.Drawing.Size(355, 21)
        Me.txtEspecieNombre.TabIndex = 32
        '
        'txtProductoNombre
        '
        Me.txtProductoNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProductoNombre.Enabled = False
        Me.txtProductoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductoNombre.Location = New System.Drawing.Point(148, 101)
        Me.txtProductoNombre.Name = "txtProductoNombre"
        Me.txtProductoNombre.Size = New System.Drawing.Size(355, 21)
        Me.txtProductoNombre.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SeaGreen
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(6, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 19)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Producto"
        '
        'txtProductoId
        '
        Me.txtProductoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProductoId.Enabled = False
        Me.txtProductoId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductoId.Location = New System.Drawing.Point(85, 101)
        Me.txtProductoId.Name = "txtProductoId"
        Me.txtProductoId.Size = New System.Drawing.Size(58, 21)
        Me.txtProductoId.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SeaGreen
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(199, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 19)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Humedad"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SeaGreen
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(6, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 19)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Clasificación"
        '
        'txtHumedad
        '
        Me.txtHumedad.Enabled = False
        Me.txtHumedad.FormattingEnabled = True
        Me.txtHumedad.Items.AddRange(New Object() {"HUMEDO", "SECO", "S2S", "S4S"})
        Me.txtHumedad.Location = New System.Drawing.Point(278, 129)
        Me.txtHumedad.Name = "txtHumedad"
        Me.txtHumedad.Size = New System.Drawing.Size(106, 21)
        Me.txtHumedad.TabIndex = 7
        '
        'txtClasificacion
        '
        Me.txtClasificacion.Enabled = False
        Me.txtClasificacion.FormattingEnabled = True
        Me.txtClasificacion.Items.AddRange(New Object() {"PRIMERA", "SEGUNDA"})
        Me.txtClasificacion.Location = New System.Drawing.Point(85, 159)
        Me.txtClasificacion.Name = "txtClasificacion"
        Me.txtClasificacion.Size = New System.Drawing.Size(106, 21)
        Me.txtClasificacion.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.SeaGreen
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(6, 218)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 19)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Ubicación"
        '
        'txtUbicacion
        '
        Me.txtUbicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUbicacion.Enabled = False
        Me.txtUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbicacion.Location = New System.Drawing.Point(85, 217)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(187, 21)
        Me.txtUbicacion.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.SeaGreen
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(6, 246)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 19)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Observación"
        '
        'txtObservacion
        '
        Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacion.Enabled = False
        Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(85, 246)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(418, 42)
        Me.txtObservacion.TabIndex = 12
        Me.txtObservacion.Tag = "Id"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.SeaGreen
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(6, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 19)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "N° Paquete"
        '
        'txtNumPaq
        '
        Me.txtNumPaq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumPaq.Enabled = False
        Me.txtNumPaq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumPaq.Location = New System.Drawing.Point(85, 43)
        Me.txtNumPaq.Name = "txtNumPaq"
        Me.txtNumPaq.Size = New System.Drawing.Size(58, 21)
        Me.txtNumPaq.TabIndex = 1
        Me.txtNumPaq.Tag = "El Paquete"
        Me.txtNumPaq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAcabado
        '
        Me.txtAcabado.Enabled = False
        Me.txtAcabado.FormattingEnabled = True
        Me.txtAcabado.Items.AddRange(New Object() {"ASERRADO", "S2S", "S4S"})
        Me.txtAcabado.Location = New System.Drawing.Point(85, 130)
        Me.txtAcabado.Name = "txtAcabado"
        Me.txtAcabado.Size = New System.Drawing.Size(106, 21)
        Me.txtAcabado.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.SeaGreen
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(6, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 19)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Acabado"
        '
        'txtCubicadorNombre
        '
        Me.txtCubicadorNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCubicadorNombre.Enabled = False
        Me.txtCubicadorNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCubicadorNombre.Location = New System.Drawing.Point(148, 188)
        Me.txtCubicadorNombre.Name = "txtCubicadorNombre"
        Me.txtCubicadorNombre.Size = New System.Drawing.Size(355, 21)
        Me.txtCubicadorNombre.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.SeaGreen
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(6, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 19)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Cubicador"
        '
        'txtCubicadorId
        '
        Me.txtCubicadorId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCubicadorId.Enabled = False
        Me.txtCubicadorId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCubicadorId.Location = New System.Drawing.Point(85, 188)
        Me.txtCubicadorId.Name = "txtCubicadorId"
        Me.txtCubicadorId.Size = New System.Drawing.Size(58, 21)
        Me.txtCubicadorId.TabIndex = 9
        '
        'btnEspecie
        '
        Me.btnEspecie.AutoSize = True
        Me.btnEspecie.Enabled = False
        Me.btnEspecie.Image = CType(resources.GetObject("btnEspecie.Image"), System.Drawing.Image)
        Me.btnEspecie.Location = New System.Drawing.Point(509, 71)
        Me.btnEspecie.Name = "btnEspecie"
        Me.btnEspecie.Size = New System.Drawing.Size(24, 22)
        Me.btnEspecie.TabIndex = 4
        Me.btnEspecie.UseVisualStyleBackColor = True
        '
        'btnCubicador
        '
        Me.btnCubicador.AutoSize = True
        Me.btnCubicador.Enabled = False
        Me.btnCubicador.Image = CType(resources.GetObject("btnCubicador.Image"), System.Drawing.Image)
        Me.btnCubicador.Location = New System.Drawing.Point(508, 187)
        Me.btnCubicador.Name = "btnCubicador"
        Me.btnCubicador.Size = New System.Drawing.Size(24, 22)
        Me.btnCubicador.TabIndex = 10
        Me.btnCubicador.UseVisualStyleBackColor = True
        '
        'btnProducto
        '
        Me.btnProducto.AutoSize = True
        Me.btnProducto.Enabled = False
        Me.btnProducto.Image = CType(resources.GetObject("btnProducto.Image"), System.Drawing.Image)
        Me.btnProducto.Location = New System.Drawing.Point(508, 101)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(24, 22)
        Me.btnProducto.TabIndex = 5
        Me.btnProducto.UseVisualStyleBackColor = True
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.btnProducto)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Controls.Add(Me.btnCubicador)
        Me.gbDatos.Controls.Add(Me.btnEspecie)
        Me.gbDatos.Controls.Add(Me.txtCubicadorNombre)
        Me.gbDatos.Controls.Add(Me.txtId)
        Me.gbDatos.Controls.Add(Me.Label8)
        Me.gbDatos.Controls.Add(Me.txtEspecieId)
        Me.gbDatos.Controls.Add(Me.txtCubicadorId)
        Me.gbDatos.Controls.Add(Me.Label3)
        Me.gbDatos.Controls.Add(Me.txtAcabado)
        Me.gbDatos.Controls.Add(Me.txtEspecieNombre)
        Me.gbDatos.Controls.Add(Me.Label9)
        Me.gbDatos.Controls.Add(Me.txtProductoId)
        Me.gbDatos.Controls.Add(Me.Label12)
        Me.gbDatos.Controls.Add(Me.Label4)
        Me.gbDatos.Controls.Add(Me.txtNumPaq)
        Me.gbDatos.Controls.Add(Me.txtProductoNombre)
        Me.gbDatos.Controls.Add(Me.Label11)
        Me.gbDatos.Controls.Add(Me.Label5)
        Me.gbDatos.Controls.Add(Me.txtObservacion)
        Me.gbDatos.Controls.Add(Me.Label7)
        Me.gbDatos.Controls.Add(Me.Label10)
        Me.gbDatos.Controls.Add(Me.txtHumedad)
        Me.gbDatos.Controls.Add(Me.txtUbicacion)
        Me.gbDatos.Controls.Add(Me.txtClasificacion)
        Me.gbDatos.Location = New System.Drawing.Point(3, 44)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(562, 300)
        Me.gbDatos.TabIndex = 61
        Me.gbDatos.TabStop = False
        '
        'frmPaquete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 412)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.gbDatos)
        Me.Name = "frmPaquete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAQUETES"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEspecieId As System.Windows.Forms.TextBox
    Friend WithEvents txtEspecieNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtProductoNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtProductoId As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtHumedad As System.Windows.Forms.ComboBox
    Friend WithEvents txtClasificacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNumPaq As System.Windows.Forms.TextBox
    Friend WithEvents txtAcabado As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCubicadorNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCubicadorId As System.Windows.Forms.TextBox
    Friend WithEvents btnEspecie As System.Windows.Forms.Button
    Friend WithEvents btnCubicador As System.Windows.Forms.Button
    Friend WithEvents btnProducto As System.Windows.Forms.Button
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtNuevo As System.Windows.Forms.TextBox
End Class
