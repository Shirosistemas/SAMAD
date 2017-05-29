<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormato01Busqueda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormato01Busqueda))
        Me.pnlArriba = New System.Windows.Forms.Panel()
        Me.Lbltitulo = New System.Windows.Forms.Label()
        Me.pnlGrid = New System.Windows.Forms.Panel()
        Me.cbCodIndustria = New System.Windows.Forms.RadioButton()
        Me.cbGTF = New System.Windows.Forms.RadioButton()
        Me.cbPCA = New System.Windows.Forms.RadioButton()
        Me.cbZafra = New System.Windows.Forms.RadioButton()
        Me.cbTitular = New System.Windows.Forms.RadioButton()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.datashowbrow = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlArriba.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.datashowbrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlArriba
        '
        Me.pnlArriba.BackColor = System.Drawing.Color.SeaGreen
        Me.pnlArriba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlArriba.Controls.Add(Me.Lbltitulo)
        Me.pnlArriba.Location = New System.Drawing.Point(-1, 0)
        Me.pnlArriba.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlArriba.Name = "pnlArriba"
        Me.pnlArriba.Size = New System.Drawing.Size(1035, 40)
        Me.pnlArriba.TabIndex = 18
        '
        'Lbltitulo
        '
        Me.Lbltitulo.AutoSize = True
        Me.Lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitulo.ForeColor = System.Drawing.SystemColors.Info
        Me.Lbltitulo.Location = New System.Drawing.Point(9, 7)
        Me.Lbltitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbltitulo.Name = "Lbltitulo"
        Me.Lbltitulo.Size = New System.Drawing.Size(125, 20)
        Me.Lbltitulo.TabIndex = 9
        Me.Lbltitulo.Text = "Buscar registro"
        '
        'pnlGrid
        '
        Me.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGrid.Controls.Add(Me.cbCodIndustria)
        Me.pnlGrid.Controls.Add(Me.cbGTF)
        Me.pnlGrid.Controls.Add(Me.cbPCA)
        Me.pnlGrid.Controls.Add(Me.cbZafra)
        Me.pnlGrid.Controls.Add(Me.cbTitular)
        Me.pnlGrid.Controls.Add(Me.btnAceptar)
        Me.pnlGrid.Controls.Add(Me.datashowbrow)
        Me.pnlGrid.Controls.Add(Me.PictureBox1)
        Me.pnlGrid.Controls.Add(Me.btnCancelar)
        Me.pnlGrid.Controls.Add(Me.txtbuscar)
        Me.pnlGrid.Controls.Add(Me.Label1)
        Me.pnlGrid.Location = New System.Drawing.Point(8, 46)
        Me.pnlGrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(1007, 422)
        Me.pnlGrid.TabIndex = 17
        '
        'cbCodIndustria
        '
        Me.cbCodIndustria.AutoSize = True
        Me.cbCodIndustria.Location = New System.Drawing.Point(760, 12)
        Me.cbCodIndustria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbCodIndustria.Name = "cbCodIndustria"
        Me.cbCodIndustria.Size = New System.Drawing.Size(209, 21)
        Me.cbCodIndustria.TabIndex = 16
        Me.cbCodIndustria.TabStop = True
        Me.cbCodIndustria.Text = "Busqueda por Cod. Industria"
        Me.cbCodIndustria.UseVisualStyleBackColor = True
        '
        'cbGTF
        '
        Me.cbGTF.AutoSize = True
        Me.cbGTF.Location = New System.Drawing.Point(572, 12)
        Me.cbGTF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbGTF.Name = "cbGTF"
        Me.cbGTF.Size = New System.Drawing.Size(177, 21)
        Me.cbGTF.TabIndex = 15
        Me.cbGTF.TabStop = True
        Me.cbGTF.Text = "Busqueda por Nro GTF"
        Me.cbGTF.UseVisualStyleBackColor = True
        '
        'cbPCA
        '
        Me.cbPCA.AutoSize = True
        Me.cbPCA.Location = New System.Drawing.Point(399, 12)
        Me.cbPCA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbPCA.Name = "cbPCA"
        Me.cbPCA.Size = New System.Drawing.Size(149, 21)
        Me.cbPCA.TabIndex = 14
        Me.cbPCA.TabStop = True
        Me.cbPCA.Text = "Busqueda por PCA"
        Me.cbPCA.UseVisualStyleBackColor = True
        '
        'cbZafra
        '
        Me.cbZafra.AutoSize = True
        Me.cbZafra.Location = New System.Drawing.Point(220, 12)
        Me.cbZafra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbZafra.Name = "cbZafra"
        Me.cbZafra.Size = New System.Drawing.Size(156, 21)
        Me.cbZafra.TabIndex = 13
        Me.cbZafra.TabStop = True
        Me.cbZafra.Text = "Busqueda por Zafra"
        Me.cbZafra.UseVisualStyleBackColor = True
        '
        'cbTitular
        '
        Me.cbTitular.AutoSize = True
        Me.cbTitular.Location = New System.Drawing.Point(32, 12)
        Me.cbTitular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbTitular.Name = "cbTitular"
        Me.cbTitular.Size = New System.Drawing.Size(162, 21)
        Me.cbTitular.TabIndex = 12
        Me.cbTitular.TabStop = True
        Me.cbTitular.Text = "Busqueda por Titular"
        Me.cbTitular.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnAceptar.Location = New System.Drawing.Point(423, 50)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(84, 28)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
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
        Me.datashowbrow.Location = New System.Drawing.Point(7, 87)
        Me.datashowbrow.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.datashowbrow.MultiSelect = False
        Me.datashowbrow.Name = "datashowbrow"
        Me.datashowbrow.ReadOnly = True
        Me.datashowbrow.RowHeadersVisible = False
        Me.datashowbrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datashowbrow.Size = New System.Drawing.Size(984, 325)
        Me.datashowbrow.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(303, 50)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnCancelar.Location = New System.Drawing.Point(516, 50)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(87, 28)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtbuscar
        '
        Me.txtbuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar.Location = New System.Drawing.Point(75, 52)
        Me.txtbuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(223, 24)
        Me.txtbuscar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar"
        '
        'frmFormato01Busqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 479)
        Me.Controls.Add(Me.pnlArriba)
        Me.Controls.Add(Me.pnlGrid)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmFormato01Busqueda"
        Me.Text = "frmFormato01Busqueda"
        Me.pnlArriba.ResumeLayout(False)
        Me.pnlArriba.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlGrid.PerformLayout()
        CType(Me.datashowbrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlArriba As System.Windows.Forms.Panel
    Friend WithEvents Lbltitulo As System.Windows.Forms.Label
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents cbGTF As System.Windows.Forms.RadioButton
    Friend WithEvents cbPCA As System.Windows.Forms.RadioButton
    Friend WithEvents cbZafra As System.Windows.Forms.RadioButton
    Friend WithEvents cbTitular As System.Windows.Forms.RadioButton
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents datashowbrow As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbCodIndustria As System.Windows.Forms.RadioButton
End Class
