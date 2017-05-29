<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportarGTF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImportarGTF))
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.txtFic = New System.Windows.Forms.TextBox()
        Me.txtSelect = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.dgvDiarios = New System.Windows.Forms.DataGridView()
        Me.btnMigrar = New System.Windows.Forms.Button()
        Me.cbMostrar = New System.Windows.Forms.CheckBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dgvTrazas = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDiarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTrazas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExaminar
        '
        Me.btnExaminar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnExaminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExaminar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnExaminar.Image = Global.SAMAD.My.Resources.Resources.I32017
        Me.btnExaminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExaminar.Location = New System.Drawing.Point(979, 389)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(145, 49)
        Me.btnExaminar.TabIndex = 61
        Me.btnExaminar.Text = "Examinar GTF"
        Me.btnExaminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExaminar.UseVisualStyleBackColor = False
        '
        'txtFic
        '
        Me.txtFic.Enabled = False
        Me.txtFic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFic.Location = New System.Drawing.Point(12, 12)
        Me.txtFic.Name = "txtFic"
        Me.txtFic.Size = New System.Drawing.Size(376, 21)
        Me.txtFic.TabIndex = 69
        Me.txtFic.Tag = "el Origen del recurso"
        '
        'txtSelect
        '
        Me.txtSelect.Enabled = False
        Me.txtSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelect.Location = New System.Drawing.Point(12, 39)
        Me.txtSelect.Name = "txtSelect"
        Me.txtSelect.Size = New System.Drawing.Size(376, 21)
        Me.txtSelect.TabIndex = 70
        Me.txtSelect.Tag = "el Origen del recurso"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnActualizar.Image = Global.SAMAD.My.Resources.Resources.I32017
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(221, 387)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(145, 49)
        Me.btnActualizar.TabIndex = 71
        Me.btnActualizar.Text = "Actualizar GTF"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'dgvDiarios
        '
        Me.dgvDiarios.AllowUserToAddRows = False
        Me.dgvDiarios.AllowUserToDeleteRows = False
        Me.dgvDiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDiarios.Location = New System.Drawing.Point(12, 4)
        Me.dgvDiarios.Name = "dgvDiarios"
        Me.dgvDiarios.Size = New System.Drawing.Size(894, 356)
        Me.dgvDiarios.TabIndex = 72
        '
        'btnMigrar
        '
        Me.btnMigrar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMigrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMigrar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnMigrar.Image = CType(resources.GetObject("btnMigrar.Image"), System.Drawing.Image)
        Me.btnMigrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMigrar.Location = New System.Drawing.Point(12, 387)
        Me.btnMigrar.Name = "btnMigrar"
        Me.btnMigrar.Size = New System.Drawing.Size(189, 49)
        Me.btnMigrar.TabIndex = 73
        Me.btnMigrar.Text = "Migrar GTF DBF"
        Me.btnMigrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMigrar.UseVisualStyleBackColor = False
        '
        'cbMostrar
        '
        Me.cbMostrar.AutoSize = True
        Me.cbMostrar.Location = New System.Drawing.Point(14, 364)
        Me.cbMostrar.Name = "cbMostrar"
        Me.cbMostrar.Size = New System.Drawing.Size(100, 17)
        Me.cbMostrar.TabIndex = 74
        Me.cbMostrar.Text = "Marcar TODOS"
        Me.cbMostrar.UseVisualStyleBackColor = True
        Me.cbMostrar.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(804, 387)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(102, 45)
        Me.btnSalir.TabIndex = 75
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'dgvTrazas
        '
        Me.dgvTrazas.AllowUserToAddRows = False
        Me.dgvTrazas.AllowUserToDeleteRows = False
        Me.dgvTrazas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTrazas.Location = New System.Drawing.Point(936, 4)
        Me.dgvTrazas.Name = "dgvTrazas"
        Me.dgvTrazas.Size = New System.Drawing.Size(188, 356)
        Me.dgvTrazas.TabIndex = 76
        '
        'FrmImportarGTF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 444)
        Me.Controls.Add(Me.dgvTrazas)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.cbMostrar)
        Me.Controls.Add(Me.btnMigrar)
        Me.Controls.Add(Me.dgvDiarios)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.txtSelect)
        Me.Controls.Add(Me.txtFic)
        Me.Controls.Add(Me.btnExaminar)
        Me.Name = "FrmImportarGTF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmImportarGTF"
        CType(Me.dgvDiarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTrazas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExaminar As System.Windows.Forms.Button
    Friend WithEvents txtFic As System.Windows.Forms.TextBox
    Friend WithEvents txtSelect As System.Windows.Forms.TextBox
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents dgvDiarios As System.Windows.Forms.DataGridView
    Friend WithEvents btnMigrar As System.Windows.Forms.Button
    Friend WithEvents cbMostrar As System.Windows.Forms.CheckBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents dgvTrazas As System.Windows.Forms.DataGridView
End Class
