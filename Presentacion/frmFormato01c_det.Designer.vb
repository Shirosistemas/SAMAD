<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormato01c_det
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormato01c_det))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVolm3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTrozas = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dataTransferir = New System.Windows.Forms.DataGridView()
        Me.ltd_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lt_nrolista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ltd_especie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ltd_codificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ltd_d1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ltd_d2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ltd_d3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ltd_vol_m3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lt_ltd_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataTransferir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(419, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 25)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "Total Volumen"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVolm3
        '
        Me.txtVolm3.Enabled = False
        Me.txtVolm3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolm3.Location = New System.Drawing.Point(535, 264)
        Me.txtVolm3.Name = "txtVolm3"
        Me.txtVolm3.Size = New System.Drawing.Size(151, 26)
        Me.txtVolm3.TabIndex = 131
        Me.txtVolm3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(86, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 25)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "Total Trozas Seleccionadas"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtTrozas
        '
        Me.TxtTrozas.Enabled = False
        Me.TxtTrozas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTrozas.Location = New System.Drawing.Point(295, 264)
        Me.TxtTrozas.Name = "TxtTrozas"
        Me.TxtTrozas.Size = New System.Drawing.Size(121, 26)
        Me.TxtTrozas.TabIndex = 129
        Me.TxtTrozas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.btnAceptar)
        Me.GroupBox2.Location = New System.Drawing.Point(-2, 293)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(688, 52)
        Me.GroupBox2.TabIndex = 127
        Me.GroupBox2.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(115, 14)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(104, 33)
        Me.btnCancelar.TabIndex = 47
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(8, 14)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(104, 33)
        Me.btnAceptar.TabIndex = 90
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(767, 42)
        Me.Panel1.TabIndex = 133
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(37, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ingreso de Trozas Seleccionadas"
        '
        'dataTransferir
        '
        Me.dataTransferir.AllowUserToAddRows = False
        Me.dataTransferir.AllowUserToDeleteRows = False
        Me.dataTransferir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataTransferir.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ltd_id, Me.lt_nrolista, Me.ltd_especie, Me.ltd_codificacion, Me.ltd_d1, Me.ltd_d2, Me.ltd_d3, Me.ltd_vol_m3, Me.lt_ltd_id, Me.cut})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataTransferir.DefaultCellStyle = DataGridViewCellStyle1
        Me.dataTransferir.Location = New System.Drawing.Point(9, 66)
        Me.dataTransferir.MultiSelect = False
        Me.dataTransferir.Name = "dataTransferir"
        Me.dataTransferir.ReadOnly = True
        Me.dataTransferir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataTransferir.Size = New System.Drawing.Size(683, 187)
        Me.dataTransferir.TabIndex = 134
        '
        'ltd_id
        '
        Me.ltd_id.HeaderText = "Id"
        Me.ltd_id.Name = "ltd_id"
        Me.ltd_id.ReadOnly = True
        '
        'lt_nrolista
        '
        Me.lt_nrolista.HeaderText = "Nro.Lista"
        Me.lt_nrolista.Name = "lt_nrolista"
        Me.lt_nrolista.ReadOnly = True
        '
        'ltd_especie
        '
        Me.ltd_especie.HeaderText = "Especie"
        Me.ltd_especie.Name = "ltd_especie"
        Me.ltd_especie.ReadOnly = True
        '
        'ltd_codificacion
        '
        Me.ltd_codificacion.HeaderText = "Cod. Bosque"
        Me.ltd_codificacion.Name = "ltd_codificacion"
        Me.ltd_codificacion.ReadOnly = True
        '
        'ltd_d1
        '
        Me.ltd_d1.HeaderText = "D1 (Diam >)"
        Me.ltd_d1.Name = "ltd_d1"
        Me.ltd_d1.ReadOnly = True
        '
        'ltd_d2
        '
        Me.ltd_d2.HeaderText = "D2 (Diam <)"
        Me.ltd_d2.Name = "ltd_d2"
        Me.ltd_d2.ReadOnly = True
        '
        'ltd_d3
        '
        Me.ltd_d3.HeaderText = "Largo"
        Me.ltd_d3.Name = "ltd_d3"
        Me.ltd_d3.ReadOnly = True
        '
        'ltd_vol_m3
        '
        Me.ltd_vol_m3.HeaderText = "Volm3"
        Me.ltd_vol_m3.Name = "ltd_vol_m3"
        Me.ltd_vol_m3.ReadOnly = True
        '
        'lt_ltd_id
        '
        Me.lt_ltd_id.HeaderText = "Titular Id"
        Me.lt_ltd_id.Name = "lt_ltd_id"
        Me.lt_ltd_id.ReadOnly = True
        '
        'cut
        '
        Me.cut.HeaderText = "cut"
        Me.cut.Name = "cut"
        Me.cut.ReadOnly = True
        '
        'frmFormato01c_det
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 369)
        Me.Controls.Add(Me.dataTransferir)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtVolm3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTrozas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmFormato01c_det"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Trozas Seleccionadas"
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataTransferir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVolm3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTrozas As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dataTransferir As System.Windows.Forms.DataGridView
    Friend WithEvents ltd_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lt_nrolista As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ltd_especie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ltd_codificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ltd_d1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ltd_d2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ltd_d3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ltd_vol_m3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lt_ltd_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cut As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
