<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.tsbConcesiones = New System.Windows.Forms.ToolStripButton()
        Me.tsbEmpresaTransporte = New System.Windows.Forms.ToolStripButton()
        Me.tsbVehiculos = New System.Windows.Forms.ToolStripButton()
        Me.tsbPersonal = New System.Windows.Forms.ToolStripButton()
        Me.tsbEspecies = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConcesionesProcedenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZafrasYPoasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresasDeTransporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConductoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehículosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspeciesMaderablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcedenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LineaDeProducciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CentroTransaccionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeffsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnidadDeMedidaDelAreaBasalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnidadDeMedidaDeLaLongitudToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuiaDeDespachoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecepciónDeTrozasFormato02ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoDeTrozasAlAserrioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProducciónDeAserríoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpaquetadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DespachoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilitariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualDeInstalaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiaDeSeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestaurarBaseDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarCopiaDeSeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(939, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStrip
        '
        Me.ToolStrip.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbConcesiones, Me.tsbEmpresaTransporte, Me.tsbVehiculos, Me.tsbPersonal, Me.tsbEspecies, Me.ToolStripSeparator2, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripButton8})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(202, 25)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'tsbConcesiones
        '
        Me.tsbConcesiones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbConcesiones.Image = CType(resources.GetObject("tsbConcesiones.Image"), System.Drawing.Image)
        Me.tsbConcesiones.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConcesiones.Name = "tsbConcesiones"
        Me.tsbConcesiones.Size = New System.Drawing.Size(23, 22)
        Me.tsbConcesiones.Text = "Concesiones"
        '
        'tsbEmpresaTransporte
        '
        Me.tsbEmpresaTransporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEmpresaTransporte.Image = CType(resources.GetObject("tsbEmpresaTransporte.Image"), System.Drawing.Image)
        Me.tsbEmpresaTransporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEmpresaTransporte.Name = "tsbEmpresaTransporte"
        Me.tsbEmpresaTransporte.Size = New System.Drawing.Size(23, 22)
        Me.tsbEmpresaTransporte.Text = "Empresas de Transporte"
        '
        'tsbVehiculos
        '
        Me.tsbVehiculos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbVehiculos.Image = CType(resources.GetObject("tsbVehiculos.Image"), System.Drawing.Image)
        Me.tsbVehiculos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbVehiculos.Name = "tsbVehiculos"
        Me.tsbVehiculos.Size = New System.Drawing.Size(23, 22)
        Me.tsbVehiculos.Text = "Vehículos"
        '
        'tsbPersonal
        '
        Me.tsbPersonal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPersonal.Image = CType(resources.GetObject("tsbPersonal.Image"), System.Drawing.Image)
        Me.tsbPersonal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPersonal.Name = "tsbPersonal"
        Me.tsbPersonal.Size = New System.Drawing.Size(23, 22)
        Me.tsbPersonal.Text = "Personal"
        '
        'tsbEspecies
        '
        Me.tsbEspecies.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEspecies.Image = CType(resources.GetObject("tsbEspecies.Image"), System.Drawing.Image)
        Me.tsbEspecies.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEspecies.Name = "tsbEspecies"
        Me.tsbEspecies.Size = New System.Drawing.Size(23, 22)
        Me.tsbEspecies.Text = "Especies"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Guia de Despacho de Trozas"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "Recepcion de Trozas"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "Aserrío de Trozas"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivosToolStripMenuItem, Me.MovimientosToolStripMenuItem, Me.UtilitariosToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(939, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ArchivosToolStripMenuItem
        '
        Me.ArchivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConcesionesProcedenciaToolStripMenuItem, Me.EmpresasDeTransporteToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem1, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.ArchivosToolStripMenuItem.Name = "ArchivosToolStripMenuItem"
        Me.ArchivosToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ArchivosToolStripMenuItem.Text = "Archivos"
        '
        'ConcesionesProcedenciaToolStripMenuItem
        '
        Me.ConcesionesProcedenciaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContratosToolStripMenuItem, Me.ZafrasYPoasToolStripMenuItem})
        Me.ConcesionesProcedenciaToolStripMenuItem.Image = CType(resources.GetObject("ConcesionesProcedenciaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConcesionesProcedenciaToolStripMenuItem.Name = "ConcesionesProcedenciaToolStripMenuItem"
        Me.ConcesionesProcedenciaToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ConcesionesProcedenciaToolStripMenuItem.Text = "Titulos Habilitantes"
        '
        'ContratosToolStripMenuItem
        '
        Me.ContratosToolStripMenuItem.Image = CType(resources.GetObject("ContratosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ContratosToolStripMenuItem.Name = "ContratosToolStripMenuItem"
        Me.ContratosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ContratosToolStripMenuItem.Text = "Contratos"
        '
        'ZafrasYPoasToolStripMenuItem
        '
        Me.ZafrasYPoasToolStripMenuItem.Image = CType(resources.GetObject("ZafrasYPoasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ZafrasYPoasToolStripMenuItem.Name = "ZafrasYPoasToolStripMenuItem"
        Me.ZafrasYPoasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ZafrasYPoasToolStripMenuItem.Text = "Zafras y Poas"
        '
        'EmpresasDeTransporteToolStripMenuItem
        '
        Me.EmpresasDeTransporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConductoresToolStripMenuItem, Me.VehículosToolStripMenuItem})
        Me.EmpresasDeTransporteToolStripMenuItem.Image = CType(resources.GetObject("EmpresasDeTransporteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmpresasDeTransporteToolStripMenuItem.Name = "EmpresasDeTransporteToolStripMenuItem"
        Me.EmpresasDeTransporteToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.EmpresasDeTransporteToolStripMenuItem.Text = "Transporte"
        '
        'ConductoresToolStripMenuItem
        '
        Me.ConductoresToolStripMenuItem.Image = CType(resources.GetObject("ConductoresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConductoresToolStripMenuItem.Name = "ConductoresToolStripMenuItem"
        Me.ConductoresToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ConductoresToolStripMenuItem.Text = "Conductores"
        '
        'VehículosToolStripMenuItem
        '
        Me.VehículosToolStripMenuItem.Image = CType(resources.GetObject("VehículosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VehículosToolStripMenuItem.Name = "VehículosToolStripMenuItem"
        Me.VehículosToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.VehículosToolStripMenuItem.Text = "Vehículos"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonalToolStripMenuItem, Me.CargosToolStripMenuItem, Me.EspeciesMaderablesToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.UbicaciónToolStripMenuItem, Me.ProcedenciasToolStripMenuItem, Me.LineaDeProducciónToolStripMenuItem, Me.CentroTransaccionalToolStripMenuItem, Me.DeffsToolStripMenuItem, Me.ToolStripMenuItem})
        Me.ToolStripMenuItem2.Image = Global.SAMAD.My.Resources.Resources.I32001
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(203, 22)
        Me.ToolStripMenuItem2.Text = "Catalogos generales"
        '
        'PersonalToolStripMenuItem
        '
        Me.PersonalToolStripMenuItem.Image = Global.SAMAD.My.Resources.Resources.I32022
        Me.PersonalToolStripMenuItem.Name = "PersonalToolStripMenuItem"
        Me.PersonalToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.PersonalToolStripMenuItem.Text = "Personal"
        '
        'CargosToolStripMenuItem
        '
        Me.CargosToolStripMenuItem.Image = Global.SAMAD.My.Resources.Resources.I24003
        Me.CargosToolStripMenuItem.Name = "CargosToolStripMenuItem"
        Me.CargosToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.CargosToolStripMenuItem.Text = "Cargos"
        '
        'EspeciesMaderablesToolStripMenuItem
        '
        Me.EspeciesMaderablesToolStripMenuItem.Image = CType(resources.GetObject("EspeciesMaderablesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EspeciesMaderablesToolStripMenuItem.Name = "EspeciesMaderablesToolStripMenuItem"
        Me.EspeciesMaderablesToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.EspeciesMaderablesToolStripMenuItem.Text = "Especies Maderables"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Image = CType(resources.GetObject("ProductosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'UbicaciónToolStripMenuItem
        '
        Me.UbicaciónToolStripMenuItem.Image = Global.SAMAD.My.Resources.Resources.UBICACION
        Me.UbicaciónToolStripMenuItem.Name = "UbicaciónToolStripMenuItem"
        Me.UbicaciónToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.UbicaciónToolStripMenuItem.Text = "Ubicación"
        '
        'ProcedenciasToolStripMenuItem
        '
        Me.ProcedenciasToolStripMenuItem.Image = Global.SAMAD.My.Resources.Resources.ingreso
        Me.ProcedenciasToolStripMenuItem.Name = "ProcedenciasToolStripMenuItem"
        Me.ProcedenciasToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ProcedenciasToolStripMenuItem.Text = "Procedencias"
        '
        'LineaDeProducciónToolStripMenuItem
        '
        Me.LineaDeProducciónToolStripMenuItem.Image = Global.SAMAD.My.Resources.Resources.produccion_1
        Me.LineaDeProducciónToolStripMenuItem.Name = "LineaDeProducciónToolStripMenuItem"
        Me.LineaDeProducciónToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.LineaDeProducciónToolStripMenuItem.Text = "Clasificación de productos"
        '
        'CentroTransaccionalToolStripMenuItem
        '
        Me.CentroTransaccionalToolStripMenuItem.Image = Global.SAMAD.My.Resources.Resources.Transacciones
        Me.CentroTransaccionalToolStripMenuItem.Name = "CentroTransaccionalToolStripMenuItem"
        Me.CentroTransaccionalToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.CentroTransaccionalToolStripMenuItem.Text = "Centro Transaccional"
        '
        'DeffsToolStripMenuItem
        '
        Me.DeffsToolStripMenuItem.Image = CType(resources.GetObject("DeffsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeffsToolStripMenuItem.Name = "DeffsToolStripMenuItem"
        Me.DeffsToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.DeffsToolStripMenuItem.Text = "Deffs"
        '
        'ToolStripMenuItem
        '
        Me.ToolStripMenuItem.Image = CType(resources.GetObject("ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem.Name = "ToolStripMenuItem"
        Me.ToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ToolStripMenuItem.Text = "Empresas"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnidadDeMedidaDelAreaBasalToolStripMenuItem, Me.UnidadDeMedidaDeLaLongitudToolStripMenuItem, Me.ConfiguracionToolStripMenuItem})
        Me.ToolStripMenuItem1.Image = Global.SAMAD.My.Resources.Resources.largo2
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.ToolStripMenuItem1.Text = "Parametros de medición"
        '
        'UnidadDeMedidaDelAreaBasalToolStripMenuItem
        '
        Me.UnidadDeMedidaDelAreaBasalToolStripMenuItem.Image = Global.SAMAD.My.Resources.Resources.AreaBasal1
        Me.UnidadDeMedidaDelAreaBasalToolStripMenuItem.Name = "UnidadDeMedidaDelAreaBasalToolStripMenuItem"
        Me.UnidadDeMedidaDelAreaBasalToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.UnidadDeMedidaDelAreaBasalToolStripMenuItem.Text = "Unidad de medida del Area basal"
        '
        'UnidadDeMedidaDeLaLongitudToolStripMenuItem
        '
        Me.UnidadDeMedidaDeLaLongitudToolStripMenuItem.Image = Global.SAMAD.My.Resources.Resources.Longitud_01
        Me.UnidadDeMedidaDeLaLongitudToolStripMenuItem.Name = "UnidadDeMedidaDeLaLongitudToolStripMenuItem"
        Me.UnidadDeMedidaDeLaLongitudToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.UnidadDeMedidaDeLaLongitudToolStripMenuItem.Text = "Unidad de medida de la longitud"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.Image = Global.SAMAD.My.Resources.Resources.cal_volumen1
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuración de calculo de volúmen"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(200, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuiaDeDespachoToolStripMenuItem, Me.RecepciónDeTrozasFormato02ToolStripMenuItem, Me.IngresoDeTrozasAlAserrioToolStripMenuItem, Me.ProducciónDeAserríoToolStripMenuItem, Me.EmpaquetadoToolStripMenuItem, Me.DespachoToolStripMenuItem})
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'GuiaDeDespachoToolStripMenuItem
        '
        Me.GuiaDeDespachoToolStripMenuItem.Image = CType(resources.GetObject("GuiaDeDespachoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GuiaDeDespachoToolStripMenuItem.Name = "GuiaDeDespachoToolStripMenuItem"
        Me.GuiaDeDespachoToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.GuiaDeDespachoToolStripMenuItem.Text = "Guia de Transporte Forestal"
        '
        'RecepciónDeTrozasFormato02ToolStripMenuItem
        '
        Me.RecepciónDeTrozasFormato02ToolStripMenuItem.Image = CType(resources.GetObject("RecepciónDeTrozasFormato02ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RecepciónDeTrozasFormato02ToolStripMenuItem.Name = "RecepciónDeTrozasFormato02ToolStripMenuItem"
        Me.RecepciónDeTrozasFormato02ToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.RecepciónDeTrozasFormato02ToolStripMenuItem.Text = "Recepción de Trozas (Formato 02)"
        '
        'IngresoDeTrozasAlAserrioToolStripMenuItem
        '
        Me.IngresoDeTrozasAlAserrioToolStripMenuItem.Image = CType(resources.GetObject("IngresoDeTrozasAlAserrioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IngresoDeTrozasAlAserrioToolStripMenuItem.Name = "IngresoDeTrozasAlAserrioToolStripMenuItem"
        Me.IngresoDeTrozasAlAserrioToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.IngresoDeTrozasAlAserrioToolStripMenuItem.Text = "Ingreso de Trozas al Aserrio"
        '
        'ProducciónDeAserríoToolStripMenuItem
        '
        Me.ProducciónDeAserríoToolStripMenuItem.Image = CType(resources.GetObject("ProducciónDeAserríoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProducciónDeAserríoToolStripMenuItem.Name = "ProducciónDeAserríoToolStripMenuItem"
        Me.ProducciónDeAserríoToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.ProducciónDeAserríoToolStripMenuItem.Text = "Producción de Aserrío"
        '
        'EmpaquetadoToolStripMenuItem
        '
        Me.EmpaquetadoToolStripMenuItem.Image = Global.SAMAD.My.Resources.Resources.empaquetado
        Me.EmpaquetadoToolStripMenuItem.Name = "EmpaquetadoToolStripMenuItem"
        Me.EmpaquetadoToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.EmpaquetadoToolStripMenuItem.Text = "Empaquetado"
        '
        'DespachoToolStripMenuItem
        '
        Me.DespachoToolStripMenuItem.Image = Global.SAMAD.My.Resources.Resources.despacho
        Me.DespachoToolStripMenuItem.Name = "DespachoToolStripMenuItem"
        Me.DespachoToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.DespachoToolStripMenuItem.Text = "Despacho"
        '
        'UtilitariosToolStripMenuItem
        '
        Me.UtilitariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.CopiaDeSeguridadToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.UtilitariosToolStripMenuItem.Name = "UtilitariosToolStripMenuItem"
        Me.UtilitariosToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.UtilitariosToolStripMenuItem.Text = "Utilitarios"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Image = CType(resources.GetObject("UsuariosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualDeInstalaciónToolStripMenuItem, Me.ManualDeUsuarioToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AyudaToolStripMenuItem.Text = "Ayuda..."
        '
        'ManualDeInstalaciónToolStripMenuItem
        '
        Me.ManualDeInstalaciónToolStripMenuItem.Name = "ManualDeInstalaciónToolStripMenuItem"
        Me.ManualDeInstalaciónToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ManualDeInstalaciónToolStripMenuItem.Text = "Manual de Instalación"
        '
        'ManualDeUsuarioToolStripMenuItem
        '
        Me.ManualDeUsuarioToolStripMenuItem.Name = "ManualDeUsuarioToolStripMenuItem"
        Me.ManualDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ManualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario"
        '
        'CopiaDeSeguridadToolStripMenuItem
        '
        Me.CopiaDeSeguridadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestaurarBaseDeDatosToolStripMenuItem, Me.GuardarCopiaDeSeguridadToolStripMenuItem})
        Me.CopiaDeSeguridadToolStripMenuItem.Name = "CopiaDeSeguridadToolStripMenuItem"
        Me.CopiaDeSeguridadToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CopiaDeSeguridadToolStripMenuItem.Text = "Copia de Seguridad"
        '
        'RestaurarBaseDeDatosToolStripMenuItem
        '
        Me.RestaurarBaseDeDatosToolStripMenuItem.Name = "RestaurarBaseDeDatosToolStripMenuItem"
        Me.RestaurarBaseDeDatosToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.RestaurarBaseDeDatosToolStripMenuItem.Text = "Restaurar Base de Datos"
        '
        'GuardarCopiaDeSeguridadToolStripMenuItem
        '
        Me.GuardarCopiaDeSeguridadToolStripMenuItem.Name = "GuardarCopiaDeSeguridadToolStripMenuItem"
        Me.GuardarCopiaDeSeguridadToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.GuardarCopiaDeSeguridadToolStripMenuItem.Text = "Guardar Copia de Seguridad"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(609, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(330, 21)
        Me.Panel1.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Usuario:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(208, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Label13"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(166, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Perfil:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Label4"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.SAMAD.My.Resources.Resources.fondo_giz
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(939, 453)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmPrincipal"
        Me.Text = "Sistema de Aserrio de Maderam - (CoC-V01)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConcesionesProcedenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpresasDeTransporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuiaDeDespachoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilitariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecepciónDeTrozasFormato02ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbConcesiones As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEmpresaTransporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbVehiculos As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbPersonal As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEspecies As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ConductoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehículosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContratosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZafrasYPoasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProducciónDeAserríoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpaquetadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DespachoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresoDeTrozasAlAserrioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiaDeSeguridadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestaurarBaseDeDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarCopiaDeSeguridadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManualDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EspeciesMaderablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UbicaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcedenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LineaDeProducciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CentroTransaccionalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeffsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnidadDeMedidaDelAreaBasalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnidadDeMedidaDeLaLongitudToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManualDeInstalaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
