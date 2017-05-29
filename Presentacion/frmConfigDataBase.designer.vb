<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigDataBase
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigDataBase))
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.lbProgreso = New System.Windows.Forms.Label()
        Me.txdBase = New System.Windows.Forms.TextBox()
        Me.chkInstallDB = New System.Windows.Forms.CheckBox()
        Me.txClave = New System.Windows.Forms.TextBox()
        Me.txUsuario = New System.Windows.Forms.TextBox()
        Me.txServer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btNext = New System.Windows.Forms.Button()
        Me.pbRemote = New System.Windows.Forms.PictureBox()
        Me.btExit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.pbRemote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.GroupPanel1.Controls.Add(Me.lbProgreso)
        Me.GroupPanel1.Controls.Add(Me.txdBase)
        Me.GroupPanel1.Controls.Add(Me.chkInstallDB)
        Me.GroupPanel1.Controls.Add(Me.txClave)
        Me.GroupPanel1.Controls.Add(Me.txUsuario)
        Me.GroupPanel1.Controls.Add(Me.txServer)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.Label7)
        Me.GroupPanel1.Controls.Add(Me.btNext)
        Me.GroupPanel1.Controls.Add(Me.pbRemote)
        Me.GroupPanel1.Controls.Add(Me.btExit)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(7, 7)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(480, 231)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 3
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
        Me.GroupPanel1.TabIndex = 8
        Me.GroupPanel1.Text = "Configurar Acceso a Datos"
        '
        'lbProgreso
        '
        Me.lbProgreso.BackColor = System.Drawing.Color.Transparent
        Me.lbProgreso.Location = New System.Drawing.Point(129, 120)
        Me.lbProgreso.Name = "lbProgreso"
        Me.lbProgreso.Size = New System.Drawing.Size(284, 28)
        Me.lbProgreso.TabIndex = 20
        Me.lbProgreso.Text = "Restaurando la base de datos"
        Me.lbProgreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbProgreso.Visible = False
        '
        'txdBase
        '
        Me.txdBase.Location = New System.Drawing.Point(30, 164)
        Me.txdBase.Name = "txdBase"
        Me.txdBase.Size = New System.Drawing.Size(140, 26)
        Me.txdBase.TabIndex = 19
        Me.txdBase.Visible = False
        '
        'chkInstallDB
        '
        Me.chkInstallDB.AutoSize = True
        Me.chkInstallDB.BackColor = System.Drawing.Color.Transparent
        Me.chkInstallDB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInstallDB.Location = New System.Drawing.Point(132, 127)
        Me.chkInstallDB.Name = "chkInstallDB"
        Me.chkInstallDB.Size = New System.Drawing.Size(235, 20)
        Me.chkInstallDB.TabIndex = 18
        Me.chkInstallDB.Text = "Restaurar base de datos si no existe"
        Me.chkInstallDB.UseVisualStyleBackColor = False
        '
        'txClave
        '
        Me.txClave.Enabled = False
        Me.txClave.Location = New System.Drawing.Point(224, 87)
        Me.txClave.Name = "txClave"
        Me.txClave.Size = New System.Drawing.Size(203, 26)
        Me.txClave.TabIndex = 17
        Me.txClave.UseSystemPasswordChar = True
        '
        'txUsuario
        '
        Me.txUsuario.Location = New System.Drawing.Point(224, 55)
        Me.txUsuario.Name = "txUsuario"
        Me.txUsuario.ReadOnly = True
        Me.txUsuario.Size = New System.Drawing.Size(203, 26)
        Me.txUsuario.TabIndex = 15
        '
        'txServer
        '
        Me.txServer.Location = New System.Drawing.Point(224, 22)
        Me.txServer.Name = "txServer"
        Me.txServer.ReadOnly = True
        Me.txServer.Size = New System.Drawing.Size(203, 26)
        Me.txServer.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(145, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 18)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(139, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Username:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(129, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Server Host:"
        '
        'btNext
        '
        Me.btNext.Image = Global.SAMAD.My.Resources.Resources.I240002
        Me.btNext.Location = New System.Drawing.Point(358, 165)
        Me.btNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btNext.Name = "btNext"
        Me.btNext.Size = New System.Drawing.Size(103, 31)
        Me.btNext.TabIndex = 11
        Me.btNext.Text = "Siguiente"
        Me.btNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btNext.UseVisualStyleBackColor = True
        '
        'pbRemote
        '
        Me.pbRemote.BackColor = System.Drawing.Color.Transparent
        Me.pbRemote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRemote.Image = CType(resources.GetObject("pbRemote.Image"), System.Drawing.Image)
        Me.pbRemote.Location = New System.Drawing.Point(6, 12)
        Me.pbRemote.Name = "pbRemote"
        Me.pbRemote.Size = New System.Drawing.Size(110, 134)
        Me.pbRemote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRemote.TabIndex = 8
        Me.pbRemote.TabStop = False
        '
        'btExit
        '
        Me.btExit.Image = Global.SAMAD.My.Resources.Resources.I320002
        Me.btExit.Location = New System.Drawing.Point(188, 157)
        Me.btExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(87, 39)
        Me.btExit.TabIndex = 7
        Me.btExit.Text = "Salir"
        Me.btExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btExit.UseVisualStyleBackColor = True
        '
        'frmConfigDataBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(493, 247)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfigDataBase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración de Base de Datos"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.pbRemote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btNext As System.Windows.Forms.Button
    Friend WithEvents pbRemote As System.Windows.Forms.PictureBox
    Friend WithEvents btExit As System.Windows.Forms.Button
    Friend WithEvents txClave As System.Windows.Forms.TextBox
    Friend WithEvents txUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txServer As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkInstallDB As System.Windows.Forms.CheckBox
    Friend WithEvents txdBase As System.Windows.Forms.TextBox
    Friend WithEvents lbProgreso As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
