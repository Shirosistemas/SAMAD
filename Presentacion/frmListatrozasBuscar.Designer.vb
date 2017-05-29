<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListatrozasBuscar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListatrozasBuscar))
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.pnlArriba = New System.Windows.Forms.Panel()
        Me.Lbltitulo = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.pnlGrid = New System.Windows.Forms.Panel()
        Me.codigo = New System.Windows.Forms.RadioButton()
        Me.gtf = New System.Windows.Forms.RadioButton()
        Me.datashowbrow = New System.Windows.Forms.DataGridView()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlArriba.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.datashowbrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnAceptar.Location = New System.Drawing.Point(317, 41)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(63, 23)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'pnlArriba
        '
        Me.pnlArriba.BackColor = System.Drawing.Color.SeaGreen
        Me.pnlArriba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlArriba.Controls.Add(Me.Lbltitulo)
        Me.pnlArriba.Location = New System.Drawing.Point(-2, 0)
        Me.pnlArriba.Name = "pnlArriba"
        Me.pnlArriba.Size = New System.Drawing.Size(559, 33)
        Me.pnlArriba.TabIndex = 16
        '
        'Lbltitulo
        '
        Me.Lbltitulo.AutoSize = True
        Me.Lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitulo.ForeColor = System.Drawing.SystemColors.Info
        Me.Lbltitulo.Location = New System.Drawing.Point(7, 6)
        Me.Lbltitulo.Name = "Lbltitulo"
        Me.Lbltitulo.Size = New System.Drawing.Size(98, 16)
        Me.Lbltitulo.TabIndex = 9
        Me.Lbltitulo.Text = "Buscar registro"
        '
        'btnCancelar
        '
        Me.btnCancelar.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnCancelar.Location = New System.Drawing.Point(387, 41)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(65, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'pnlGrid
        '
        Me.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGrid.Controls.Add(Me.codigo)
        Me.pnlGrid.Controls.Add(Me.gtf)
        Me.pnlGrid.Controls.Add(Me.btnAceptar)
        Me.pnlGrid.Controls.Add(Me.datashowbrow)
        Me.pnlGrid.Controls.Add(Me.PictureBox1)
        Me.pnlGrid.Controls.Add(Me.btnCancelar)
        Me.pnlGrid.Controls.Add(Me.txtbuscar)
        Me.pnlGrid.Controls.Add(Me.Label1)
        Me.pnlGrid.Location = New System.Drawing.Point(5, 39)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(537, 344)
        Me.pnlGrid.TabIndex = 15
        '
        'codigo
        '
        Me.codigo.AutoSize = True
        Me.codigo.Location = New System.Drawing.Point(150, 10)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(113, 17)
        Me.codigo.TabIndex = 13
        Me.codigo.TabStop = True
        Me.codigo.Text = "Buscar Por Código"
        Me.codigo.UseVisualStyleBackColor = True
        '
        'gtf
        '
        Me.gtf.AutoSize = True
        Me.gtf.Location = New System.Drawing.Point(24, 10)
        Me.gtf.Name = "gtf"
        Me.gtf.Size = New System.Drawing.Size(107, 17)
        Me.gtf.TabIndex = 12
        Me.gtf.TabStop = True
        Me.gtf.Text = "Buscar por GTF's"
        Me.gtf.UseVisualStyleBackColor = True
        '
        'datashowbrow
        '
        Me.datashowbrow.AllowUserToAddRows = False
        Me.datashowbrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datashowbrow.DefaultCellStyle = DataGridViewCellStyle1
        Me.datashowbrow.Location = New System.Drawing.Point(5, 71)
        Me.datashowbrow.MultiSelect = False
        Me.datashowbrow.Name = "datashowbrow"
        Me.datashowbrow.ReadOnly = True
        Me.datashowbrow.RowHeadersVisible = False
        Me.datashowbrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datashowbrow.Size = New System.Drawing.Size(527, 264)
        Me.datashowbrow.TabIndex = 2
        '
        'txtbuscar
        '
        Me.txtbuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar.Location = New System.Drawing.Point(56, 42)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(168, 21)
        Me.txtbuscar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(227, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'frmListatrozasBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 382)
        Me.Controls.Add(Me.pnlArriba)
        Me.Controls.Add(Me.pnlGrid)
        Me.Name = "frmListatrozasBuscar"
        Me.Text = "Busquedas"
        Me.pnlArriba.ResumeLayout(False)
        Me.pnlArriba.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlGrid.PerformLayout()
        CType(Me.datashowbrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents pnlArriba As System.Windows.Forms.Panel
    Friend WithEvents Lbltitulo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents datashowbrow As System.Windows.Forms.DataGridView
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gtf As System.Windows.Forms.RadioButton
    Friend WithEvents codigo As System.Windows.Forms.RadioButton
End Class
