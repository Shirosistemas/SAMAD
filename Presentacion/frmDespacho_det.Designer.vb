<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDespacho_det
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDespacho_det))
        Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Background2 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Background3 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Background4 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Background5 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Background6 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Background7 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtReg = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPeriodo = New System.Windows.Forms.TextBox()
        Me.txtNroGtfId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNroGtf = New System.Windows.Forms.TextBox()
        Me.GroupPanel7 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Tx_Vol28Saldo = New System.Windows.Forms.TextBox()
        Me.Tx_Vol52Saldo = New System.Windows.Forms.TextBox()
        Me.txTotalM3Saldo = New System.Windows.Forms.TextBox()
        Me.TxSalGtfReg = New System.Windows.Forms.TextBox()
        Me.txtVolPorcSaldo = New System.Windows.Forms.TextBox()
        Me.TxVolRecSaldo = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Tx_Vol28 = New System.Windows.Forms.TextBox()
        Me.txTotalM3 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Tx_Vol52 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtVolm3Reg = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtVolPorc = New System.Windows.Forms.TextBox()
        Me.txtVolrec = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboEspecieGTF = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TxVolm3Rec = New System.Windows.Forms.TextBox()
        Me.TxVolm3Com = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TxVolm3RecDesp = New System.Windows.Forms.TextBox()
        Me.TxVolm3DesCom = New System.Windows.Forms.TextBox()
        Me.txtSaldoRecuperacion = New System.Windows.Forms.TextBox()
        Me.txSaldoComercial = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnGtf = New System.Windows.Forms.Button()
        Me.grpDetalleLotePaquete = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TxVolPt = New System.Windows.Forms.TextBox()
        Me.TxVolm3 = New System.Windows.Forms.TextBox()
        Me.TxTipUnid = New System.Windows.Forms.TextBox()
        Me.TxCantidad = New System.Windows.Forms.TextBox()
        Me.TxClaseComercial = New System.Windows.Forms.TextBox()
        Me.TxNomProducto = New System.Windows.Forms.TextBox()
        Me.TxNomComercial = New System.Windows.Forms.TextBox()
        Me.TxCodigo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupPanel6 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.RbDespachoParcial = New System.Windows.Forms.RadioButton()
        Me.rbDespachoTotal = New System.Windows.Forms.RadioButton()
        Me.RbNgtf = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RbCorrelativo = New System.Windows.Forms.RadioButton()
        Me.TxCorrelativo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dgDetalle = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.GridColumn8 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GridColumn9 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GridColumn10 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GridColumn11 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GridColumn12 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GridColumn14 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GridColumn4 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtVolPTGrid = New System.Windows.Forms.TextBox()
        Me.txtVolm3Grid = New System.Windows.Forms.TextBox()
        Me.txtTipUniGrid = New System.Windows.Forms.TextBox()
        Me.txtCantGrid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDetalleLotePaquete.SuspendLayout()
        Me.GroupPanel6.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.SeaGreen
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(607, 9)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(171, 31)
        Me.Label11.TabIndex = 113
        Me.Label11.Text = "N° Documento"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtReg
        '
        Me.txtReg.BackColor = System.Drawing.SystemColors.Control
        Me.txtReg.Enabled = False
        Me.txtReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReg.Location = New System.Drawing.Point(792, 10)
        Me.txtReg.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReg.Name = "txtReg"
        Me.txtReg.Size = New System.Drawing.Size(195, 30)
        Me.txtReg.TabIndex = 114
        Me.txtReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtPeriodo)
        Me.Panel1.Controls.Add(Me.txtReg)
        Me.Panel1.Location = New System.Drawing.Point(-4, -4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1004, 51)
        Me.Panel1.TabIndex = 110
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 6)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label6.Location = New System.Drawing.Point(49, 12)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(197, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Detalle del Despacho"
        '
        'txtPeriodo
        '
        Me.txtPeriodo.BackColor = System.Drawing.SystemColors.Control
        Me.txtPeriodo.Enabled = False
        Me.txtPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeriodo.Location = New System.Drawing.Point(476, 9)
        Me.txtPeriodo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.Size = New System.Drawing.Size(83, 30)
        Me.txtPeriodo.TabIndex = 114
        Me.txtPeriodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPeriodo.Visible = False
        '
        'txtNroGtfId
        '
        Me.txtNroGtfId.BackColor = System.Drawing.SystemColors.Control
        Me.txtNroGtfId.Enabled = False
        Me.txtNroGtfId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroGtfId.Location = New System.Drawing.Point(7, 31)
        Me.txtNroGtfId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroGtfId.Name = "txtNroGtfId"
        Me.txtNroGtfId.Size = New System.Drawing.Size(40, 24)
        Me.txtNroGtfId.TabIndex = 126
        Me.txtNroGtfId.Tag = "la Especie"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SeaGreen
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(6, 1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 24)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "N° GTF"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNroGtf
        '
        Me.txtNroGtf.BackColor = System.Drawing.SystemColors.Control
        Me.txtNroGtf.Enabled = False
        Me.txtNroGtf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroGtf.Location = New System.Drawing.Point(54, 31)
        Me.txtNroGtf.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroGtf.Name = "txtNroGtf"
        Me.txtNroGtf.Size = New System.Drawing.Size(131, 24)
        Me.txtNroGtf.TabIndex = 121
        Me.txtNroGtf.Tag = "la Especie"
        '
        'GroupPanel7
        '
        Me.GroupPanel7.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel7.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Yellow
        Me.GroupPanel7.Controls.Add(Me.GroupBox2)
        Me.GroupPanel7.Controls.Add(Me.Label21)
        Me.GroupPanel7.Controls.Add(Me.cboEspecieGTF)
        Me.GroupPanel7.Controls.Add(Me.GroupBox1)
        Me.GroupPanel7.Controls.Add(Me.txtNroGtfId)
        Me.GroupPanel7.Controls.Add(Me.Label1)
        Me.GroupPanel7.Controls.Add(Me.txtNroGtf)
        Me.GroupPanel7.Controls.Add(Me.btnGtf)
        Me.GroupPanel7.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel7.Location = New System.Drawing.Point(13, 55)
        Me.GroupPanel7.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanel7.Name = "GroupPanel7"
        Me.GroupPanel7.Size = New System.Drawing.Size(987, 225)
        '
        '
        '
        Me.GroupPanel7.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.GroupPanel7.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.GroupPanel7.Style.BackColorGradientAngle = 90
        Me.GroupPanel7.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderBottomWidth = 1
        Me.GroupPanel7.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.GroupPanel7.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderLeftWidth = 1
        Me.GroupPanel7.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderRightWidth = 1
        Me.GroupPanel7.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderTopWidth = 1
        Me.GroupPanel7.Style.CornerDiameter = 4
        Me.GroupPanel7.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel7.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel7.Style.TextColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupPanel7.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel7.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel7.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel7.TabIndex = 283
        Me.GroupPanel7.Text = "Datos del GTF a usar para el Despacho"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LavenderBlush
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.Tx_Vol28Saldo)
        Me.GroupBox2.Controls.Add(Me.Tx_Vol52Saldo)
        Me.GroupBox2.Controls.Add(Me.txTotalM3Saldo)
        Me.GroupBox2.Controls.Add(Me.TxSalGtfReg)
        Me.GroupBox2.Controls.Add(Me.txtVolPorcSaldo)
        Me.GroupBox2.Controls.Add(Me.TxVolRecSaldo)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Tx_Vol28)
        Me.GroupBox2.Controls.Add(Me.txTotalM3)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Tx_Vol52)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.txtVolm3Reg)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.txtVolPorc)
        Me.GroupBox2.Controls.Add(Me.txtVolrec)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 61)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(645, 137)
        Me.GroupBox2.TabIndex = 306
        Me.GroupBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SAMAD.My.Resources.Resources.Trozas_Icono
        Me.PictureBox3.Location = New System.Drawing.Point(7, 11)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(58, 52)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 312
        Me.PictureBox3.TabStop = False
        '
        'Tx_Vol28Saldo
        '
        Me.Tx_Vol28Saldo.BackColor = System.Drawing.SystemColors.Window
        Me.Tx_Vol28Saldo.Enabled = False
        Me.Tx_Vol28Saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tx_Vol28Saldo.Location = New System.Drawing.Point(530, 102)
        Me.Tx_Vol28Saldo.Margin = New System.Windows.Forms.Padding(4)
        Me.Tx_Vol28Saldo.Name = "Tx_Vol28Saldo"
        Me.Tx_Vol28Saldo.Size = New System.Drawing.Size(99, 30)
        Me.Tx_Vol28Saldo.TabIndex = 317
        Me.Tx_Vol28Saldo.Tag = "Total Saldo del Volumen a despachar al 28% Recuperación"
        Me.Tx_Vol28Saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tx_Vol52Saldo
        '
        Me.Tx_Vol52Saldo.BackColor = System.Drawing.SystemColors.Window
        Me.Tx_Vol52Saldo.Enabled = False
        Me.Tx_Vol52Saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tx_Vol52Saldo.Location = New System.Drawing.Point(417, 102)
        Me.Tx_Vol52Saldo.Margin = New System.Windows.Forms.Padding(4)
        Me.Tx_Vol52Saldo.Name = "Tx_Vol52Saldo"
        Me.Tx_Vol52Saldo.Size = New System.Drawing.Size(99, 30)
        Me.Tx_Vol52Saldo.TabIndex = 316
        Me.Tx_Vol52Saldo.Tag = "Saldo de Volumen al 52%"
        Me.Tx_Vol52Saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txTotalM3Saldo
        '
        Me.txTotalM3Saldo.BackColor = System.Drawing.SystemColors.Window
        Me.txTotalM3Saldo.Enabled = False
        Me.txTotalM3Saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txTotalM3Saldo.Location = New System.Drawing.Point(246, 101)
        Me.txTotalM3Saldo.Margin = New System.Windows.Forms.Padding(4)
        Me.txTotalM3Saldo.Name = "txTotalM3Saldo"
        Me.txTotalM3Saldo.Size = New System.Drawing.Size(80, 30)
        Me.txTotalM3Saldo.TabIndex = 313
        Me.txTotalM3Saldo.Tag = "Saldo del  Volumen de Trozas Aserradas"
        Me.txTotalM3Saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxSalGtfReg
        '
        Me.TxSalGtfReg.BackColor = System.Drawing.SystemColors.Window
        Me.TxSalGtfReg.Enabled = False
        Me.TxSalGtfReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxSalGtfReg.Location = New System.Drawing.Point(70, 101)
        Me.TxSalGtfReg.Margin = New System.Windows.Forms.Padding(4)
        Me.TxSalGtfReg.Name = "TxSalGtfReg"
        Me.TxSalGtfReg.Size = New System.Drawing.Size(80, 30)
        Me.TxSalGtfReg.TabIndex = 315
        Me.TxSalGtfReg.Tag = "Saldo de Vol_m3 Registrados en GTF"
        Me.TxSalGtfReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVolPorcSaldo
        '
        Me.txtVolPorcSaldo.BackColor = System.Drawing.SystemColors.Window
        Me.txtVolPorcSaldo.Enabled = False
        Me.txtVolPorcSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolPorcSaldo.Location = New System.Drawing.Point(334, 102)
        Me.txtVolPorcSaldo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVolPorcSaldo.Name = "txtVolPorcSaldo"
        Me.txtVolPorcSaldo.Size = New System.Drawing.Size(75, 30)
        Me.txtVolPorcSaldo.TabIndex = 314
        Me.txtVolPorcSaldo.Tag = "Saldo Total al 80%"
        Me.txtVolPorcSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxVolRecSaldo
        '
        Me.TxVolRecSaldo.BackColor = System.Drawing.SystemColors.Window
        Me.TxVolRecSaldo.Enabled = False
        Me.TxVolRecSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxVolRecSaldo.Location = New System.Drawing.Point(157, 101)
        Me.TxVolRecSaldo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxVolRecSaldo.Name = "TxVolRecSaldo"
        Me.TxVolRecSaldo.Size = New System.Drawing.Size(80, 30)
        Me.TxVolRecSaldo.TabIndex = 312
        Me.TxVolRecSaldo.Tag = "Saldo del Volumen Recepcionado en Patio"
        Me.TxVolRecSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.YellowGreen
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Red
        Me.Label28.Location = New System.Drawing.Point(8, 102)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(57, 28)
        Me.Label28.TabIndex = 311
        Me.Label28.Text = "T. Sal."
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.YellowGreen
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Red
        Me.Label27.Location = New System.Drawing.Point(8, 66)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(57, 28)
        Me.Label27.TabIndex = 310
        Me.Label27.Text = "T. Ing."
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.YellowGreen
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label17.Location = New System.Drawing.Point(246, 10)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 51)
        Me.Label17.TabIndex = 297
        Me.Label17.Text = "VolM3 Aserr. Rollizo"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tx_Vol28
        '
        Me.Tx_Vol28.BackColor = System.Drawing.SystemColors.Window
        Me.Tx_Vol28.Enabled = False
        Me.Tx_Vol28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tx_Vol28.Location = New System.Drawing.Point(530, 67)
        Me.Tx_Vol28.Margin = New System.Windows.Forms.Padding(4)
        Me.Tx_Vol28.Name = "Tx_Vol28"
        Me.Tx_Vol28.Size = New System.Drawing.Size(99, 30)
        Me.Tx_Vol28.TabIndex = 309
        Me.Tx_Vol28.Tag = "Total Volumen a Despachar al 28% Recuperación"
        Me.Tx_Vol28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txTotalM3
        '
        Me.txTotalM3.BackColor = System.Drawing.SystemColors.Window
        Me.txTotalM3.Enabled = False
        Me.txTotalM3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txTotalM3.Location = New System.Drawing.Point(246, 66)
        Me.txTotalM3.Margin = New System.Windows.Forms.Padding(4)
        Me.txTotalM3.Name = "txTotalM3"
        Me.txTotalM3.Size = New System.Drawing.Size(80, 30)
        Me.txTotalM3.TabIndex = 301
        Me.txTotalM3.Tag = "Total Volumen de Trozas Aserradas"
        Me.txTotalM3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.YellowGreen
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Red
        Me.Label26.Location = New System.Drawing.Point(530, 10)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(99, 51)
        Me.Label26.TabIndex = 308
        Me.Label26.Text = "Vol. m3 al 28% Recuperacion"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tx_Vol52
        '
        Me.Tx_Vol52.BackColor = System.Drawing.SystemColors.Window
        Me.Tx_Vol52.Enabled = False
        Me.Tx_Vol52.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tx_Vol52.Location = New System.Drawing.Point(417, 67)
        Me.Tx_Vol52.Margin = New System.Windows.Forms.Padding(4)
        Me.Tx_Vol52.Name = "Tx_Vol52"
        Me.Tx_Vol52.Size = New System.Drawing.Size(99, 30)
        Me.Tx_Vol52.TabIndex = 307
        Me.Tx_Vol52.Tag = "Total Volumen a Despachar al 52% Comercial"
        Me.Tx_Vol52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.YellowGreen
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(417, 9)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(99, 52)
        Me.Label22.TabIndex = 306
        Me.Label22.Text = "Vol. m3 al 52% Comercial"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.YellowGreen
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(70, 9)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 53)
        Me.Label23.TabIndex = 304
        Me.Label23.Text = "VolM3 Reg. GTF/List. Troz."
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVolm3Reg
        '
        Me.txtVolm3Reg.BackColor = System.Drawing.SystemColors.Window
        Me.txtVolm3Reg.Enabled = False
        Me.txtVolm3Reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolm3Reg.Location = New System.Drawing.Point(70, 66)
        Me.txtVolm3Reg.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVolm3Reg.Name = "txtVolm3Reg"
        Me.txtVolm3Reg.Size = New System.Drawing.Size(80, 30)
        Me.txtVolm3Reg.TabIndex = 305
        Me.txtVolm3Reg.Tag = "Volumen Registrado del Formato de GTF"
        Me.txtVolm3Reg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.YellowGreen
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(157, 10)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 53)
        Me.Label24.TabIndex = 297
        Me.Label24.Text = "VolM3 Recep. Patio"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVolPorc
        '
        Me.txtVolPorc.BackColor = System.Drawing.SystemColors.Window
        Me.txtVolPorc.Enabled = False
        Me.txtVolPorc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolPorc.Location = New System.Drawing.Point(334, 67)
        Me.txtVolPorc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVolPorc.Name = "txtVolPorc"
        Me.txtVolPorc.Size = New System.Drawing.Size(75, 30)
        Me.txtVolPorc.TabIndex = 303
        Me.txtVolPorc.Tag = "Total Vol. Disponible a Despachar al 80%"
        Me.txtVolPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVolrec
        '
        Me.txtVolrec.BackColor = System.Drawing.SystemColors.Window
        Me.txtVolrec.Enabled = False
        Me.txtVolrec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolrec.Location = New System.Drawing.Point(157, 66)
        Me.txtVolrec.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVolrec.Name = "txtVolrec"
        Me.txtVolrec.Size = New System.Drawing.Size(80, 30)
        Me.txtVolrec.TabIndex = 301
        Me.txtVolrec.Tag = "Total Volumen Recepcionado en Patio Aserrio"
        Me.txtVolrec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.YellowGreen
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.Location = New System.Drawing.Point(334, 11)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(75, 51)
        Me.Label25.TabIndex = 299
        Me.Label25.Text = "Vol. m3 al 80%"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.SeaGreen
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label21.Location = New System.Drawing.Point(239, 4)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(413, 24)
        Me.Label21.TabIndex = 128
        Me.Label21.Text = "NOMBRE DE ESPECIE"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboEspecieGTF
        '
        Me.cboEspecieGTF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEspecieGTF.FormattingEnabled = True
        Me.cboEspecieGTF.Location = New System.Drawing.Point(238, 31)
        Me.cboEspecieGTF.Name = "cboEspecieGTF"
        Me.cboEspecieGTF.Size = New System.Drawing.Size(414, 24)
        Me.cboEspecieGTF.TabIndex = 127
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.TxVolm3Rec)
        Me.GroupBox1.Controls.Add(Me.TxVolm3Com)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.TxVolm3RecDesp)
        Me.GroupBox1.Controls.Add(Me.TxVolm3DesCom)
        Me.GroupBox1.Controls.Add(Me.txtSaldoRecuperacion)
        Me.GroupBox1.Controls.Add(Me.txSaldoComercial)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(665, 1)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(312, 197)
        Me.GroupBox1.TabIndex = 113
        Me.GroupBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SAMAD.My.Resources.Resources.Madera_Aserr
        Me.PictureBox2.Location = New System.Drawing.Point(7, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(88, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 311
        Me.PictureBox2.TabStop = False
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label31.Location = New System.Drawing.Point(8, 161)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(90, 27)
        Me.Label31.TabIndex = 310
        Me.Label31.Text = "T. x Desp."
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxVolm3Rec
        '
        Me.TxVolm3Rec.BackColor = System.Drawing.SystemColors.Window
        Me.TxVolm3Rec.Enabled = False
        Me.TxVolm3Rec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxVolm3Rec.Location = New System.Drawing.Point(196, 80)
        Me.TxVolm3Rec.Margin = New System.Windows.Forms.Padding(4)
        Me.TxVolm3Rec.Name = "TxVolm3Rec"
        Me.TxVolm3Rec.Size = New System.Drawing.Size(105, 30)
        Me.TxVolm3Rec.TabIndex = 309
        Me.TxVolm3Rec.Tag = "Total Vol. m3 Aserrio Recuperacion"
        Me.TxVolm3Rec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxVolm3Com
        '
        Me.TxVolm3Com.BackColor = System.Drawing.SystemColors.Window
        Me.TxVolm3Com.Enabled = False
        Me.TxVolm3Com.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxVolm3Com.Location = New System.Drawing.Point(102, 80)
        Me.TxVolm3Com.Margin = New System.Windows.Forms.Padding(4)
        Me.TxVolm3Com.Name = "TxVolm3Com"
        Me.TxVolm3Com.Size = New System.Drawing.Size(86, 30)
        Me.TxVolm3Com.TabIndex = 308
        Me.TxVolm3Com.Tag = "Total Vol. m3 Aserrio Comercial"
        Me.TxVolm3Com.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label30.Location = New System.Drawing.Point(8, 121)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(90, 27)
        Me.Label30.TabIndex = 307
        Me.Label30.Text = "T. Desp."
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label29.Location = New System.Drawing.Point(8, 82)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(90, 27)
        Me.Label29.TabIndex = 306
        Me.Label29.Text = "T. Aserrado"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxVolm3RecDesp
        '
        Me.TxVolm3RecDesp.BackColor = System.Drawing.SystemColors.Window
        Me.TxVolm3RecDesp.Enabled = False
        Me.TxVolm3RecDesp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxVolm3RecDesp.Location = New System.Drawing.Point(196, 118)
        Me.TxVolm3RecDesp.Margin = New System.Windows.Forms.Padding(4)
        Me.TxVolm3RecDesp.Name = "TxVolm3RecDesp"
        Me.TxVolm3RecDesp.Size = New System.Drawing.Size(105, 30)
        Me.TxVolm3RecDesp.TabIndex = 305
        Me.TxVolm3RecDesp.Tag = "Total Vol. m3 Despachados en Aserrío Recuperación"
        Me.TxVolm3RecDesp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxVolm3DesCom
        '
        Me.TxVolm3DesCom.BackColor = System.Drawing.SystemColors.Window
        Me.TxVolm3DesCom.Enabled = False
        Me.TxVolm3DesCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxVolm3DesCom.Location = New System.Drawing.Point(102, 118)
        Me.TxVolm3DesCom.Margin = New System.Windows.Forms.Padding(4)
        Me.TxVolm3DesCom.Name = "TxVolm3DesCom"
        Me.TxVolm3DesCom.Size = New System.Drawing.Size(86, 30)
        Me.TxVolm3DesCom.TabIndex = 304
        Me.TxVolm3DesCom.Tag = "Total Vol. m3 Despachados en Aserrio Comercial"
        Me.TxVolm3DesCom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSaldoRecuperacion
        '
        Me.txtSaldoRecuperacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtSaldoRecuperacion.Enabled = False
        Me.txtSaldoRecuperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoRecuperacion.Location = New System.Drawing.Point(196, 158)
        Me.txtSaldoRecuperacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSaldoRecuperacion.Name = "txtSaldoRecuperacion"
        Me.txtSaldoRecuperacion.Size = New System.Drawing.Size(105, 30)
        Me.txtSaldoRecuperacion.TabIndex = 303
        Me.txtSaldoRecuperacion.Tag = "el Volumen a Despachar"
        Me.txtSaldoRecuperacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txSaldoComercial
        '
        Me.txSaldoComercial.BackColor = System.Drawing.SystemColors.Window
        Me.txSaldoComercial.Enabled = False
        Me.txSaldoComercial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txSaldoComercial.Location = New System.Drawing.Point(102, 158)
        Me.txSaldoComercial.Margin = New System.Windows.Forms.Padding(4)
        Me.txSaldoComercial.Name = "txSaldoComercial"
        Me.txSaldoComercial.Size = New System.Drawing.Size(86, 30)
        Me.txSaldoComercial.TabIndex = 302
        Me.txSaldoComercial.Tag = "el Volumen a Despachar"
        Me.txSaldoComercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.YellowGreen
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label5.Location = New System.Drawing.Point(196, 44)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 27)
        Me.Label5.TabIndex = 299
        Me.Label5.Text = "Recuperacion"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Chartreuse
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(102, 17)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 22)
        Me.Label4.TabIndex = 300
        Me.Label4.Text = "Resumen Aserrio Produc."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.YellowGreen
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label7.Location = New System.Drawing.Point(102, 44)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 27)
        Me.Label7.TabIndex = 298
        Me.Label7.Text = "Comercial"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGtf
        '
        Me.btnGtf.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGtf.Image = CType(resources.GetObject("btnGtf.Image"), System.Drawing.Image)
        Me.btnGtf.Location = New System.Drawing.Point(196, 29)
        Me.btnGtf.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGtf.Name = "btnGtf"
        Me.btnGtf.Size = New System.Drawing.Size(35, 28)
        Me.btnGtf.TabIndex = 0
        Me.btnGtf.UseVisualStyleBackColor = True
        '
        'grpDetalleLotePaquete
        '
        Me.grpDetalleLotePaquete.CanvasColor = System.Drawing.SystemColors.Control
        Me.grpDetalleLotePaquete.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.grpDetalleLotePaquete.Controls.Add(Me.TxVolPt)
        Me.grpDetalleLotePaquete.Controls.Add(Me.TxVolm3)
        Me.grpDetalleLotePaquete.Controls.Add(Me.TxTipUnid)
        Me.grpDetalleLotePaquete.Controls.Add(Me.TxCantidad)
        Me.grpDetalleLotePaquete.Controls.Add(Me.TxClaseComercial)
        Me.grpDetalleLotePaquete.Controls.Add(Me.TxNomProducto)
        Me.grpDetalleLotePaquete.Controls.Add(Me.TxNomComercial)
        Me.grpDetalleLotePaquete.Controls.Add(Me.TxCodigo)
        Me.grpDetalleLotePaquete.Controls.Add(Me.Label16)
        Me.grpDetalleLotePaquete.Controls.Add(Me.Label14)
        Me.grpDetalleLotePaquete.Controls.Add(Me.Label13)
        Me.grpDetalleLotePaquete.Controls.Add(Me.Label12)
        Me.grpDetalleLotePaquete.Controls.Add(Me.Label10)
        Me.grpDetalleLotePaquete.Controls.Add(Me.Label9)
        Me.grpDetalleLotePaquete.Controls.Add(Me.Label8)
        Me.grpDetalleLotePaquete.Controls.Add(Me.GroupPanel6)
        Me.grpDetalleLotePaquete.Controls.Add(Me.dgDetalle)
        Me.grpDetalleLotePaquete.Controls.Add(Me.Label15)
        Me.grpDetalleLotePaquete.DisabledBackColor = System.Drawing.Color.Empty
        Me.grpDetalleLotePaquete.Enabled = False
        Me.grpDetalleLotePaquete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDetalleLotePaquete.Location = New System.Drawing.Point(13, 288)
        Me.grpDetalleLotePaquete.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDetalleLotePaquete.Name = "grpDetalleLotePaquete"
        Me.grpDetalleLotePaquete.Size = New System.Drawing.Size(987, 344)
        '
        '
        '
        Me.grpDetalleLotePaquete.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.grpDetalleLotePaquete.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.grpDetalleLotePaquete.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.grpDetalleLotePaquete.TabIndex = 282
        Me.grpDetalleLotePaquete.Text = "Detalles del  Lote de Aserrío o Paquete"
        '
        'TxVolPt
        '
        Me.TxVolPt.BackColor = System.Drawing.SystemColors.Window
        Me.TxVolPt.Enabled = False
        Me.TxVolPt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxVolPt.Location = New System.Drawing.Point(908, 135)
        Me.TxVolPt.Margin = New System.Windows.Forms.Padding(4)
        Me.TxVolPt.Name = "TxVolPt"
        Me.TxVolPt.Size = New System.Drawing.Size(68, 24)
        Me.TxVolPt.TabIndex = 296
        Me.TxVolPt.Tag = "el Volumen a Despachar"
        Me.TxVolPt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxVolm3
        '
        Me.TxVolm3.BackColor = System.Drawing.SystemColors.Window
        Me.TxVolm3.Enabled = False
        Me.TxVolm3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxVolm3.Location = New System.Drawing.Point(832, 135)
        Me.TxVolm3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxVolm3.Name = "TxVolm3"
        Me.TxVolm3.Size = New System.Drawing.Size(68, 24)
        Me.TxVolm3.TabIndex = 295
        Me.TxVolm3.Tag = "el Volumen a Despachar"
        Me.TxVolm3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxTipUnid
        '
        Me.TxTipUnid.BackColor = System.Drawing.SystemColors.Window
        Me.TxTipUnid.Enabled = False
        Me.TxTipUnid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTipUnid.Location = New System.Drawing.Point(756, 135)
        Me.TxTipUnid.Margin = New System.Windows.Forms.Padding(4)
        Me.TxTipUnid.Name = "TxTipUnid"
        Me.TxTipUnid.Size = New System.Drawing.Size(68, 24)
        Me.TxTipUnid.TabIndex = 294
        Me.TxTipUnid.Tag = "el Volumen a Despachar"
        Me.TxTipUnid.Text = " "
        Me.TxTipUnid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxCantidad
        '
        Me.TxCantidad.BackColor = System.Drawing.SystemColors.Window
        Me.TxCantidad.Enabled = False
        Me.TxCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCantidad.Location = New System.Drawing.Point(676, 135)
        Me.TxCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.TxCantidad.Name = "TxCantidad"
        Me.TxCantidad.Size = New System.Drawing.Size(72, 24)
        Me.TxCantidad.TabIndex = 293
        Me.TxCantidad.Tag = "el Volumen a Despachar"
        Me.TxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxClaseComercial
        '
        Me.TxClaseComercial.BackColor = System.Drawing.SystemColors.Window
        Me.TxClaseComercial.Enabled = False
        Me.TxClaseComercial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxClaseComercial.Location = New System.Drawing.Point(498, 135)
        Me.TxClaseComercial.Margin = New System.Windows.Forms.Padding(4)
        Me.TxClaseComercial.Name = "TxClaseComercial"
        Me.TxClaseComercial.Size = New System.Drawing.Size(170, 24)
        Me.TxClaseComercial.TabIndex = 292
        Me.TxClaseComercial.Tag = "el Volumen a Despachar"
        Me.TxClaseComercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxNomProducto
        '
        Me.TxNomProducto.BackColor = System.Drawing.SystemColors.Window
        Me.TxNomProducto.Enabled = False
        Me.TxNomProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNomProducto.Location = New System.Drawing.Point(298, 135)
        Me.TxNomProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxNomProducto.Name = "TxNomProducto"
        Me.TxNomProducto.Size = New System.Drawing.Size(192, 24)
        Me.TxNomProducto.TabIndex = 291
        Me.TxNomProducto.Tag = "el Volumen a Despachar"
        Me.TxNomProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxNomComercial
        '
        Me.TxNomComercial.BackColor = System.Drawing.SystemColors.Window
        Me.TxNomComercial.Enabled = False
        Me.TxNomComercial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNomComercial.Location = New System.Drawing.Point(95, 135)
        Me.TxNomComercial.Margin = New System.Windows.Forms.Padding(4)
        Me.TxNomComercial.Name = "TxNomComercial"
        Me.TxNomComercial.Size = New System.Drawing.Size(195, 24)
        Me.TxNomComercial.TabIndex = 290
        Me.TxNomComercial.Tag = "el Volumen a Despachar"
        Me.TxNomComercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxCodigo
        '
        Me.TxCodigo.BackColor = System.Drawing.SystemColors.Window
        Me.TxCodigo.Enabled = False
        Me.TxCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCodigo.Location = New System.Drawing.Point(12, 135)
        Me.TxCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxCodigo.Name = "TxCodigo"
        Me.TxCodigo.Size = New System.Drawing.Size(77, 24)
        Me.TxCodigo.TabIndex = 289
        Me.TxCodigo.Tag = "el Volumen a Despachar"
        Me.TxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(908, 104)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 27)
        Me.Label16.TabIndex = 288
        Me.Label16.Text = "Vol. Pt"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(832, 104)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 27)
        Me.Label14.TabIndex = 287
        Me.Label14.Text = "Vol. m3"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(756, 104)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 27)
        Me.Label13.TabIndex = 286
        Me.Label13.Text = "Tip. Unid"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(676, 104)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 27)
        Me.Label12.TabIndex = 285
        Me.Label12.Text = "Cantidad"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(498, 104)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(170, 27)
        Me.Label10.TabIndex = 284
        Me.Label10.Text = "Clase Comercial"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(298, 104)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 27)
        Me.Label9.TabIndex = 283
        Me.Label9.Text = "Nombre Producto"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(96, 104)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(194, 27)
        Me.Label8.TabIndex = 282
        Me.Label8.Text = "Nombre Comercial"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupPanel6
        '
        Me.GroupPanel6.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel6.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Orange
        Me.GroupPanel6.Controls.Add(Me.GroupPanel1)
        Me.GroupPanel6.Controls.Add(Me.RbNgtf)
        Me.GroupPanel6.Controls.Add(Me.Label3)
        Me.GroupPanel6.Controls.Add(Me.RbCorrelativo)
        Me.GroupPanel6.Controls.Add(Me.TxCorrelativo)
        Me.GroupPanel6.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel6.Location = New System.Drawing.Point(11, 11)
        Me.GroupPanel6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanel6.Name = "GroupPanel6"
        Me.GroupPanel6.Size = New System.Drawing.Size(965, 87)
        '
        '
        '
        Me.GroupPanel6.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.GroupPanel6.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GroupPanel6.Style.BackColorGradientAngle = 90
        Me.GroupPanel6.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderBottomWidth = 1
        Me.GroupPanel6.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.GroupPanel6.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderLeftWidth = 1
        Me.GroupPanel6.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderRightWidth = 1
        Me.GroupPanel6.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderTopWidth = 1
        Me.GroupPanel6.Style.CornerDiameter = 4
        Me.GroupPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel6.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel6.Style.TextColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.GroupPanel6.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel6.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel6.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel6.TabIndex = 281
        Me.GroupPanel6.Text = "Seleccionar Lotes de Aserrío o Pqts."
        Me.GroupPanel6.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Center
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Orange
        Me.GroupPanel1.Controls.Add(Me.RbDespachoParcial)
        Me.GroupPanel1.Controls.Add(Me.rbDespachoTotal)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(644, -10)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(318, 77)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.GroupPanel1.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 284
        '
        'RbDespachoParcial
        '
        Me.RbDespachoParcial.AutoSize = True
        Me.RbDespachoParcial.Location = New System.Drawing.Point(6, 43)
        Me.RbDespachoParcial.Name = "RbDespachoParcial"
        Me.RbDespachoParcial.Size = New System.Drawing.Size(273, 21)
        Me.RbDespachoParcial.TabIndex = 290
        Me.RbDespachoParcial.Text = "Despacho Parcial del Lote Aserrio /Pqt"
        Me.RbDespachoParcial.UseVisualStyleBackColor = True
        '
        'rbDespachoTotal
        '
        Me.rbDespachoTotal.AutoSize = True
        Me.rbDespachoTotal.Checked = True
        Me.rbDespachoTotal.Location = New System.Drawing.Point(6, 14)
        Me.rbDespachoTotal.Name = "rbDespachoTotal"
        Me.rbDespachoTotal.Size = New System.Drawing.Size(262, 21)
        Me.rbDespachoTotal.TabIndex = 289
        Me.rbDespachoTotal.TabStop = True
        Me.rbDespachoTotal.Text = "Despacho Total del Lote Aserrio /Pqt"
        Me.rbDespachoTotal.UseVisualStyleBackColor = True
        '
        'RbNgtf
        '
        Me.RbNgtf.AutoSize = True
        Me.RbNgtf.BackColor = System.Drawing.Color.Transparent
        Me.RbNgtf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNgtf.Location = New System.Drawing.Point(7, 33)
        Me.RbNgtf.Margin = New System.Windows.Forms.Padding(4)
        Me.RbNgtf.Name = "RbNgtf"
        Me.RbNgtf.Size = New System.Drawing.Size(183, 22)
        Me.RbNgtf.TabIndex = 225
        Me.RbNgtf.Text = "Despacho Por Paquete"
        Me.RbNgtf.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightGreen
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(294, 5)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 20)
        Me.Label3.TabIndex = 283
        Me.Label3.Text = "N° Lote Aserrio / Pqt."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RbCorrelativo
        '
        Me.RbCorrelativo.AutoSize = True
        Me.RbCorrelativo.BackColor = System.Drawing.Color.Transparent
        Me.RbCorrelativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbCorrelativo.Location = New System.Drawing.Point(7, 3)
        Me.RbCorrelativo.Margin = New System.Windows.Forms.Padding(4)
        Me.RbCorrelativo.Name = "RbCorrelativo"
        Me.RbCorrelativo.Size = New System.Drawing.Size(227, 22)
        Me.RbCorrelativo.TabIndex = 226
        Me.RbCorrelativo.Text = "Despacho por Lote de Aserrio"
        Me.RbCorrelativo.UseVisualStyleBackColor = False
        '
        'TxCorrelativo
        '
        '
        '
        '
        Me.TxCorrelativo.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxCorrelativo.Border.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.TxCorrelativo.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxCorrelativo.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxCorrelativo.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxCorrelativo.Border.Class = "TextBoxBorder"
        Me.TxCorrelativo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxCorrelativo.Enabled = False
        Me.TxCorrelativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCorrelativo.Location = New System.Drawing.Point(294, 28)
        Me.TxCorrelativo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxCorrelativo.Name = "TxCorrelativo"
        Me.TxCorrelativo.PreventEnterBeep = True
        Me.TxCorrelativo.Size = New System.Drawing.Size(156, 30)
        Me.TxCorrelativo.TabIndex = 227
        Me.TxCorrelativo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxCorrelativo.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.TxCorrelativo.WatermarkText = "000000"
        '
        'dgDetalle
        '
        Me.dgDetalle.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.dgDetalle.Location = New System.Drawing.Point(8, 166)
        Me.dgDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.dgDetalle.Name = "dgDetalle"
        '
        '
        '
        Me.dgDetalle.PrimaryGrid.AllowEdit = False
        Me.dgDetalle.PrimaryGrid.AutoHideDeletedRows = False
        Me.dgDetalle.PrimaryGrid.AutoSelectDeleteBoundRows = False
        '
        '
        '
        Me.dgDetalle.PrimaryGrid.ColumnHeader.RowHeight = 25
        Me.dgDetalle.PrimaryGrid.Columns.Add(Me.GridColumn8)
        Me.dgDetalle.PrimaryGrid.Columns.Add(Me.GridColumn9)
        Me.dgDetalle.PrimaryGrid.Columns.Add(Me.GridColumn10)
        Me.dgDetalle.PrimaryGrid.Columns.Add(Me.GridColumn11)
        Me.dgDetalle.PrimaryGrid.Columns.Add(Me.GridColumn12)
        Me.dgDetalle.PrimaryGrid.Columns.Add(Me.GridColumn14)
        Me.dgDetalle.PrimaryGrid.Columns.Add(Me.GridColumn4)
        Me.dgDetalle.PrimaryGrid.DefaultVisualStyles.ColumnHeaderRowStyles.Default.RowHeader.TextAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        '
        '
        '
        Me.dgDetalle.PrimaryGrid.Filter.FilterImage = Global.SAMAD.My.Resources.Resources.filtro
        Me.dgDetalle.PrimaryGrid.Filter.ShowPanelFilterExpr = True
        Me.dgDetalle.PrimaryGrid.GroupHeaderHeight = 20
        Me.dgDetalle.PrimaryGrid.ReadOnly = True
        Me.dgDetalle.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.dgDetalle.PrimaryGrid.ShowCellInfo = False
        Me.dgDetalle.PrimaryGrid.ShowRowDirtyMarker = False
        Me.dgDetalle.PrimaryGrid.ShowRowGridIndex = True
        Me.dgDetalle.PrimaryGrid.ShowRowHeaders = False
        Me.dgDetalle.PrimaryGrid.UseAlternateRowStyle = True
        Me.dgDetalle.PrimaryGrid.VirtualRowHeight = 25
        Me.dgDetalle.Size = New System.Drawing.Size(968, 145)
        Me.dgDetalle.TabIndex = 180
        Me.dgDetalle.Text = "SuperGridControl1"
        '
        'GridColumn8
        '
        Me.GridColumn8.AllowEdit = False
        Me.GridColumn8.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        Background1.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Background1.Color2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn8.CellStyles.Default.Background = Background1
        Background2.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Background2.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn8.CellStyles.Empty.Background = Background2
        Me.GridColumn8.HeaderText = "Id"
        Me.GridColumn8.Name = "Id"
        Me.GridColumn8.ReadOnly = True
        Me.GridColumn8.Width = 80
        '
        'GridColumn9
        '
        Me.GridColumn9.AllowEdit = False
        Background3.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn9.CellStyles.Default.Background = Background3
        Me.GridColumn9.HeaderText = "Espesor"
        Me.GridColumn9.Name = "Espesor"
        Me.GridColumn9.ReadOnly = True
        Me.GridColumn9.Width = 70
        '
        'GridColumn10
        '
        Me.GridColumn10.AllowEdit = False
        Me.GridColumn10.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        Background4.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn10.CellStyles.Default.Background = Background4
        Me.GridColumn10.HeaderText = "Ancho"
        Me.GridColumn10.Name = "Ancho"
        Me.GridColumn10.ReadOnly = True
        Me.GridColumn10.Width = 70
        '
        'GridColumn11
        '
        Me.GridColumn11.AllowEdit = False
        Me.GridColumn11.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight
        Background5.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn11.CellStyles.Default.Background = Background5
        Me.GridColumn11.HeaderText = "Largo"
        Me.GridColumn11.Name = "Largo"
        Me.GridColumn11.ReadOnly = True
        Me.GridColumn11.Width = 70
        '
        'GridColumn12
        '
        Me.GridColumn12.AllowEdit = False
        Me.GridColumn12.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight
        Background6.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn12.CellStyles.Default.Background = Background6
        Me.GridColumn12.HeaderText = "Cantidad"
        Me.GridColumn12.Name = "Cantidad"
        Me.GridColumn12.ReadOnly = True
        Me.GridColumn12.Width = 75
        '
        'GridColumn14
        '
        Me.GridColumn14.AllowEdit = False
        Me.GridColumn14.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight
        Background7.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn14.CellStyles.Default.Background = Background7
        Me.GridColumn14.HeaderText = "Vol M3"
        Me.GridColumn14.Name = "Volm3"
        Me.GridColumn14.ReadOnly = True
        Me.GridColumn14.Width = 75
        '
        'GridColumn4
        '
        Me.GridColumn4.Name = "VolPt"
        Me.GridColumn4.Width = 75
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(12, 104)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 27)
        Me.Label15.TabIndex = 217
        Me.Label15.Text = "Codigo"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVolPTGrid
        '
        Me.txtVolPTGrid.BackColor = System.Drawing.SystemColors.Window
        Me.txtVolPTGrid.Enabled = False
        Me.txtVolPTGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolPTGrid.Location = New System.Drawing.Point(622, 677)
        Me.txtVolPTGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVolPTGrid.Name = "txtVolPTGrid"
        Me.txtVolPTGrid.Size = New System.Drawing.Size(68, 24)
        Me.txtVolPTGrid.TabIndex = 304
        Me.txtVolPTGrid.Tag = "el Volumen a Despachar"
        Me.txtVolPTGrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVolm3Grid
        '
        Me.txtVolm3Grid.BackColor = System.Drawing.SystemColors.Window
        Me.txtVolm3Grid.Enabled = False
        Me.txtVolm3Grid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolm3Grid.Location = New System.Drawing.Point(546, 677)
        Me.txtVolm3Grid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVolm3Grid.Name = "txtVolm3Grid"
        Me.txtVolm3Grid.Size = New System.Drawing.Size(68, 24)
        Me.txtVolm3Grid.TabIndex = 303
        Me.txtVolm3Grid.Tag = "el Volumen a Despachar"
        Me.txtVolm3Grid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTipUniGrid
        '
        Me.txtTipUniGrid.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipUniGrid.Enabled = False
        Me.txtTipUniGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipUniGrid.Location = New System.Drawing.Point(471, 677)
        Me.txtTipUniGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTipUniGrid.Name = "txtTipUniGrid"
        Me.txtTipUniGrid.Size = New System.Drawing.Size(68, 24)
        Me.txtTipUniGrid.TabIndex = 302
        Me.txtTipUniGrid.Tag = "el Volumen a Despachar"
        Me.txtTipUniGrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCantGrid
        '
        Me.txtCantGrid.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantGrid.Enabled = False
        Me.txtCantGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantGrid.Location = New System.Drawing.Point(390, 677)
        Me.txtCantGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantGrid.Name = "txtCantGrid"
        Me.txtCantGrid.Size = New System.Drawing.Size(72, 24)
        Me.txtCantGrid.TabIndex = 301
        Me.txtCantGrid.Tag = "el Volumen a Despachar"
        Me.txtCantGrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(622, 646)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 27)
        Me.Label2.TabIndex = 300
        Me.Label2.Text = "Vol. Pt"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label18.Location = New System.Drawing.Point(546, 646)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 27)
        Me.Label18.TabIndex = 299
        Me.Label18.Text = "Vol. m3"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label19.Location = New System.Drawing.Point(471, 646)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 27)
        Me.Label19.TabIndex = 298
        Me.Label19.Text = "Tip. Unid"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label20.Location = New System.Drawing.Point(390, 646)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 27)
        Me.Label20.TabIndex = 297
        Me.Label20.Text = "Cantidad"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(859, 646)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(139, 55)
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
        Me.btnAceptar.Location = New System.Drawing.Point(738, 646)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(113, 55)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Agregar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'frmDespacho_det
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 711)
        Me.Controls.Add(Me.txtVolPTGrid)
        Me.Controls.Add(Me.txtVolm3Grid)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtTipUniGrid)
        Me.Controls.Add(Me.txtCantGrid)
        Me.Controls.Add(Me.GroupPanel7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.grpDetalleLotePaquete)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label20)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDespacho_det"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDespacho_det"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel7.ResumeLayout(False)
        Me.GroupPanel7.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDetalleLotePaquete.ResumeLayout(False)
        Me.grpDetalleLotePaquete.PerformLayout()
        Me.GroupPanel6.ResumeLayout(False)
        Me.GroupPanel6.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtReg As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnGtf As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNroGtf As System.Windows.Forms.TextBox
    Friend WithEvents txtNroGtfId As System.Windows.Forms.TextBox
    Friend WithEvents GroupPanel7 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents grpDetalleLotePaquete As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents RbNgtf As System.Windows.Forms.RadioButton
    Friend WithEvents RbCorrelativo As System.Windows.Forms.RadioButton
    Friend WithEvents GroupPanel6 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxCorrelativo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dgDetalle As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents GridColumn8 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents GridColumn9 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents GridColumn10 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents GridColumn11 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents GridColumn12 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents GridColumn14 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxVolPt As System.Windows.Forms.TextBox
    Friend WithEvents TxVolm3 As System.Windows.Forms.TextBox
    Friend WithEvents TxTipUnid As System.Windows.Forms.TextBox
    Friend WithEvents TxCantidad As System.Windows.Forms.TextBox
    Friend WithEvents TxClaseComercial As System.Windows.Forms.TextBox
    Friend WithEvents TxNomProducto As System.Windows.Forms.TextBox
    Friend WithEvents TxNomComercial As System.Windows.Forms.TextBox
    Friend WithEvents TxCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoRecuperacion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txTotalM3 As System.Windows.Forms.TextBox
    Friend WithEvents txSaldoComercial As System.Windows.Forms.TextBox
    Friend WithEvents GridColumn4 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents txtVolPTGrid As System.Windows.Forms.TextBox
    Friend WithEvents txtVolm3Grid As System.Windows.Forms.TextBox
    Friend WithEvents txtTipUniGrid As System.Windows.Forms.TextBox
    Friend WithEvents txtCantGrid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cboEspecieGTF As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtPeriodo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtVolm3Reg As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtVolPorc As System.Windows.Forms.TextBox
    Friend WithEvents txtVolrec As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents RbDespachoParcial As System.Windows.Forms.RadioButton
    Friend WithEvents rbDespachoTotal As System.Windows.Forms.RadioButton
    Friend WithEvents Tx_Vol28 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Tx_Vol52 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txTotalM3Saldo As System.Windows.Forms.TextBox
    Friend WithEvents TxSalGtfReg As System.Windows.Forms.TextBox
    Friend WithEvents txtVolPorcSaldo As System.Windows.Forms.TextBox
    Friend WithEvents TxVolRecSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TxVolm3RecDesp As System.Windows.Forms.TextBox
    Friend WithEvents TxVolm3DesCom As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Tx_Vol28Saldo As System.Windows.Forms.TextBox
    Friend WithEvents Tx_Vol52Saldo As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents TxVolm3Rec As System.Windows.Forms.TextBox
    Friend WithEvents TxVolm3Com As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
End Class
