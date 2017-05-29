<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btNext = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbLocal = New System.Windows.Forms.PictureBox()
        Me.pbRemote = New System.Windows.Forms.PictureBox()
        Me.btExit = New System.Windows.Forms.Button()
        Me.rbLocal = New System.Windows.Forms.RadioButton()
        Me.rbRemote = New System.Windows.Forms.RadioButton()
        Me.sTyleManager = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.GroupPanel1.SuspendLayout()
        CType(Me.pbLocal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRemote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(84, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(475, 43)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sistema de Aserrio de Madera"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.GroupPanel1.Controls.Add(Me.btNext)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.pbLocal)
        Me.GroupPanel1.Controls.Add(Me.pbRemote)
        Me.GroupPanel1.Controls.Add(Me.btExit)
        Me.GroupPanel1.Controls.Add(Me.rbLocal)
        Me.GroupPanel1.Controls.Add(Me.rbRemote)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(11, 50)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(640, 274)
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
        Me.GroupPanel1.TabIndex = 7
        Me.GroupPanel1.Text = "Entorno de Datos"
        '
        'btNext
        '
        Me.btNext.Image = Global.SAMAD.My.Resources.Resources.I240002
        Me.btNext.Location = New System.Drawing.Point(323, 195)
        Me.btNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btNext.Name = "btNext"
        Me.btNext.Size = New System.Drawing.Size(132, 38)
        Me.btNext.TabIndex = 11
        Me.btNext.Text = "Siguiente"
        Me.btNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btNext.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(180, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 135)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Seleccione el entorno de datos a Usar; Tenga en cuenta que si trabaja en modo loc" & _
    "al, los datos estaran disponibles unicamente para este Usuario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbLocal
        '
        Me.pbLocal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLocal.Image = CType(resources.GetObject("pbLocal.Image"), System.Drawing.Image)
        Me.pbLocal.Location = New System.Drawing.Point(29, 15)
        Me.pbLocal.Margin = New System.Windows.Forms.Padding(4)
        Me.pbLocal.Name = "pbLocal"
        Me.pbLocal.Size = New System.Drawing.Size(133, 145)
        Me.pbLocal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLocal.TabIndex = 9
        Me.pbLocal.TabStop = False
        '
        'pbRemote
        '
        Me.pbRemote.BackColor = System.Drawing.Color.Transparent
        Me.pbRemote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRemote.Image = CType(resources.GetObject("pbRemote.Image"), System.Drawing.Image)
        Me.pbRemote.Location = New System.Drawing.Point(460, 15)
        Me.pbRemote.Margin = New System.Windows.Forms.Padding(4)
        Me.pbRemote.Name = "pbRemote"
        Me.pbRemote.Size = New System.Drawing.Size(133, 145)
        Me.pbRemote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRemote.TabIndex = 8
        Me.pbRemote.TabStop = False
        '
        'btExit
        '
        Me.btExit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExit.Image = Global.SAMAD.My.Resources.Resources.I320002
        Me.btExit.Location = New System.Drawing.Point(148, 189)
        Me.btExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(120, 50)
        Me.btExit.TabIndex = 7
        Me.btExit.Text = "Salir"
        Me.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btExit.UseVisualStyleBackColor = True
        '
        'rbLocal
        '
        Me.rbLocal.AutoSize = True
        Me.rbLocal.Location = New System.Drawing.Point(29, 167)
        Me.rbLocal.Margin = New System.Windows.Forms.Padding(4)
        Me.rbLocal.Name = "rbLocal"
        Me.rbLocal.Size = New System.Drawing.Size(73, 27)
        Me.rbLocal.TabIndex = 1
        Me.rbLocal.TabStop = True
        Me.rbLocal.Text = "Local"
        Me.rbLocal.UseVisualStyleBackColor = True
        '
        'rbRemote
        '
        Me.rbRemote.AutoSize = True
        Me.rbRemote.Location = New System.Drawing.Point(491, 167)
        Me.rbRemote.Margin = New System.Windows.Forms.Padding(4)
        Me.rbRemote.Name = "rbRemote"
        Me.rbRemote.Size = New System.Drawing.Size(95, 27)
        Me.rbRemote.TabIndex = 0
        Me.rbRemote.TabStop = True
        Me.rbRemote.Text = "Remoto"
        Me.rbRemote.UseVisualStyleBackColor = True
        '
        'sTyleManager
        '
        Me.sTyleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue
        Me.sTyleManager.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(661, 334)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.pbLocal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRemote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbLocal As System.Windows.Forms.PictureBox
    Friend WithEvents pbRemote As System.Windows.Forms.PictureBox
    Friend WithEvents btExit As System.Windows.Forms.Button
    Friend WithEvents rbLocal As System.Windows.Forms.RadioButton
    Friend WithEvents rbRemote As System.Windows.Forms.RadioButton
    Friend WithEvents sTyleManager As DevComponents.DotNetBar.StyleManager
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btNext As System.Windows.Forms.Button
    Private WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel

End Class
