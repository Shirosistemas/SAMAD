Imports System.Windows.Forms
Imports System.Configuration
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmPrincipal
    Dim xTitulo = fxSamad.Titulo
    Protected frmCount As Integer = 0
    ' - Procedimiento para abrir Formularios
    Private Sub AbrirFormulario(ByVal sFrmName As Object)
        Dim xForm As New System.Windows.Forms.Form
        xForm = sFrmName
        If New fxSamad().FormularioAbierto(xForm.Name.ToString()) = False Then
            xForm.MdiParent = Me
            frmCount += 1
            xForm.Show()
        Else
            xForm.WindowState = FormWindowState.Normal
        End If
        Me.Refresh()
    End Sub

    'Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
    '    ' Create a new instance of the child form.
    '    Dim ChildForm As New System.Windows.Forms.Form
    '    ' Make it a child of this MDI form before showing it.
    '    ChildForm.MdiParent = Me

    '    m_ChildFormNumber += 1
    '    ChildForm.Text = "Window " & m_ChildFormNumber

    '    ChildForm.Show()
    'End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub GuiaDeDespachoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuiaDeDespachoToolStripMenuItem.Click
        frmListatrozas.MdiParent = Me
        frmListatrozas.Show()
    End Sub

    Private Sub ConcesionesProcedenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConcesionesProcedenciaToolStripMenuItem.Click
        frmTitulares.MdiParent = Me
        frmTitulares.Show()
    End Sub

    Private Sub VehículosMaquinariasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmVehiculos.MdiParent = Me
        frmVehiculos.Show()
    End Sub

    Private Sub PersonalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        frmPersonal.MdiParent = Me
        frmPersonal.Show()

    End Sub

    Private Sub CargosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCargos.MdiParent = Me
        frmCargos.Show()
    End Sub

    Private Sub EspeciesMaderablesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmEspecies.MdiParent = Me
        frmEspecies.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub tsbVehiculos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbVehiculos.Click
        frmVehiculos.MdiParent = Me
        frmVehiculos.Show()
    End Sub

    Private Sub tsbPersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPersonal.Click
        frmPersonal.MdiParent = Me
        frmPersonal.Show()
    End Sub

    Private Sub tsbEspecies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEspecies.Click
        frmEspecies.MdiParent = Me
        frmEspecies.Show()
    End Sub

    Private Sub TitularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmTitulares.MdiParent = Me
        frmTitulares.Show()
    End Sub
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmOrigenes.MdiParent = Me
        frmOrigenes.Show()
    End Sub

    Private Sub ContratosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContratosToolStripMenuItem.Click
        frmContratos.MdiParent = Me
        frmContratos.Show()
    End Sub

    Private Sub ZafrasYPoasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZafrasYPoasToolStripMenuItem.Click
        FrmZafrasypoas.MdiParent = Me
        FrmZafrasypoas.Show()
    End Sub
    Private Sub ConductoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConductoresToolStripMenuItem.Click
        frmConductores.MdiParent = Me
        frmConductores.Show()
    End Sub

    Private Sub VehículosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehículosToolStripMenuItem.Click
        frmVehiculos.MdiParent = Me
        frmVehiculos.Show()
    End Sub

    Private Sub RecepciónDeTrozasFormato02ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecepciónDeTrozasFormato02ToolStripMenuItem.Click
        wfIngreso_trozas.MdiParent = Me
        wfIngreso_trozas.Show()
    End Sub

    Private Sub ProducciónDeAserríoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProducciónDeAserríoToolStripMenuItem.Click
        frmFormato04.MdiParent = Me
        frmFormato04.Show()
    End Sub

    Private Sub DeffsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmDeffs.MdiParent = Me
        FrmDeffs.Show()
    End Sub

    Private Sub EmpaquetadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpaquetadoToolStripMenuItem.Click
        wfEmpaquetado.MdiParent = Me
        wfEmpaquetado.Show()
    End Sub

    Private Sub DespachoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DespachoToolStripMenuItem.Click
        frmDespacho.MdiParent = Me
        frmDespacho.Show()
    End Sub

    Private Sub frmPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label4.Text = vInfraestructura.Usuario.gnombre
        Label13.Text = vInfraestructura.Usuario.gtipo
        ToolStripStatusLabel.Text = "Entorno de los datos : " & My.Settings.dbEntorno
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        frmUsuarios.Show()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AyudaToolStripMenuItem.Click
        'Dim rutaEjecutable As String = System.IO.Directory.GetCurrentDirectory().ToString
        'System.Diagnostics.Process.Start(rutaEjecutable & "\Ayuda.chm")
    End Sub

    Private Sub frmPrincipal_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim rutaEjecutable As String = System.IO.Directory.GetCurrentDirectory().ToString
            System.Diagnostics.Process.Start(rutaEjecutable & "\Usuario.chm")
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmTitulares.MdiParent = Me
        frmTitulares.Show()
    End Sub

    Private Sub IngresoDeTrozasAlAserrioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresoDeTrozasAlAserrioToolStripMenuItem.Click
        frmFormato02.MdiParent = Me
        frmFormato02.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click
        frmProductos.MdiParent = Me
        frmProductos.Show()
    End Sub

    Private Sub ProcedenciasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProcedenciasToolStripMenuItem.Click
        frmProcedencia.MdiParent = Me
        frmProcedencia.Show()
    End Sub

    Private Sub CentroTransaccionalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CentroTransaccionalToolStripMenuItem.Click
        frmProcesos.MdiParent = Me
        frmProcesos.Show()
    End Sub

    Private Sub UbicaciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UbicaciónToolStripMenuItem.Click
        frmUbicacion.MdiParent = Me
        frmUbicacion.Show()
    End Sub

    Private Sub RestaurarBaseDeDatosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RestaurarBaseDeDatosToolStripMenuItem.Click
        If My.Settings.dbEntorno = "Remoto" Then
            MessageBox.Show("Los datos unicamente se pueden restaurar en modo Local", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Try
            Dim OpenFileDialog1 As New OpenFileDialog
            OpenFileDialog1.InitialDirectory = "c:\\"
            OpenFileDialog1.Filter = "Archivos sql (*.sql)|*.sql"
            OpenFileDialog1.FilterIndex = 1
            OpenFileDialog1.RestoreDirectory = True
            If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                Dim result = MessageBox.Show("Esta Seguro de Restaurar la Base de Datos", "Restaurar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = Windows.Forms.DialogResult.Yes Then
                    Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
                    Dim server = config.AppSettings.Settings("server").Value
                    Dim uid = config.AppSettings.Settings("uid").Value
                    Dim pass = config.AppSettings.Settings("password").Value
                    Dim constring = "server=" + server + ";uid=" + uid + ";password=" + pass + ";database=samad"
                    Dim file = OpenFileDialog1.FileName
                    Dim conn As New MySqlConnection(constring)
                    Dim cmd As New MySqlCommand
                    Dim mb As New MySqlBackup(cmd)
                    cmd.Connection = conn
                    conn.Open()
                    mb.ImportFromFile(file)
                    conn.Close()
                    MessageBox.Show("Se Restauro la Base de Datos Correctamente", "Restaurar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GuardarCopiaDeSeguridadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GuardarCopiaDeSeguridadToolStripMenuItem.Click
       Try
            Dim saveFileDialog1 As New SaveFileDialog
            saveFileDialog1.Filter = "Archivos sql (*.sql)|*.sql"
            saveFileDialog1.FilterIndex = 1
            saveFileDialog1.RestoreDirectory = True
            If saveFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                Dim file = saveFileDialog1.FileName
                Dim conn As New MySqlConnection(New fxSamad().GetCadenaConexionSamad())
                Dim cmd As New MySqlCommand
                Dim mb As New MySqlBackup(cmd)
                cmd.Connection = conn
                conn.Open()
                mb.ExportInfo.AddCreateDatabase = True
                mb.ExportInfo.ExportTableStructure = True
                mb.ExportInfo.ExportRows = True
                mb.ExportInfo.ExportFunctions = True
                mb.ExportInfo.ExportProcedures = True
                mb.ExportInfo.ExportViews = True
                mb.ExportToFile(file)
                conn.Close()
                MessageBox.Show("Se Guardo la Base de Datos Correctamente", "Guardando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReportesToolStripMenuItem.Click
        Dim reportes As New frmReportes
        reportes.ShowDialog()
    End Sub

    Private Sub ManualDeInstalaciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ManualDeInstalaciónToolStripMenuItem.Click
        Dim rutaEjecutable As String = System.IO.Directory.GetCurrentDirectory().ToString
        System.Diagnostics.Process.Start(rutaEjecutable & "\Ayuda.chm")
    End Sub

    Private Sub ManualDeUsuarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ManualDeUsuarioToolStripMenuItem.Click
        Dim rutaEjecutable As String = System.IO.Directory.GetCurrentDirectory().ToString
        System.Diagnostics.Process.Start(rutaEjecutable & "\Usuario.chm")
    End Sub

    Private Sub LineaDeProducciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frmUnidadMedida.MdiParent = Me
        frmUnidadMedida.Show()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        frmEspecies.MdiParent = Me
        frmListatrozas.Show()
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        wfIngreso_trozas.MdiParent = Me
        wfIngreso_trozas.Show()
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        frmFormato02.MdiParent = Me
        frmFormato02.Show()
    End Sub

    Private Sub tsbConcesiones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConcesiones.Click
        frmContratos.MdiParent = Me
        frmContratos.Show()
    End Sub

    Private Sub tsbEmpresaTransporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEmpresaTransporte.Click
        frmConductores.MdiParent = Me
        frmConductores.Show()
    End Sub

    Private Function cmd1() As Object
        Throw New NotImplementedException
    End Function

    Private Sub PersonalToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles PersonalToolStripMenuItem.Click
        frmPersonal.MdiParent = Me
        frmPersonal.Show()
    End Sub

    Private Sub CargosToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles CargosToolStripMenuItem.Click
        frmCargos.MdiParent = Me
        frmCargos.Show()
    End Sub

    Private Sub EspeciesMaderablesToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles EspeciesMaderablesToolStripMenuItem.Click
        frmEspecies.MdiParent = Me
        frmEspecies.Show()
    End Sub

    Private Sub LineaDeProducciónToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles LineaDeProducciónToolStripMenuItem.Click
        frmLinea.MdiParent = Me
        frmLinea.Show()
    End Sub

    Private Sub DeffsToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles DeffsToolStripMenuItem.Click
        FrmDeffs.MdiParent = Me
        FrmDeffs.Show()
    End Sub

    Private Sub ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem.Click
        frmTitulares.MdiParent = Me
        frmTitulares.Show()
    End Sub

    Private Sub UnidadDeMedidaDelAreaBasalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UnidadDeMedidaDelAreaBasalToolStripMenuItem.Click
        frmUnidadMedida.MdiParent = Me
        frmUnidadMedida.Show()
    End Sub

    Private Sub UnidadDeMedidaDeLaLongitudToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UnidadDeMedidaDeLaLongitudToolStripMenuItem.Click
        frmUnidadMedidaLargo.MdiParent = Me
        frmUnidadMedidaLargo.Show()
    End Sub

    Private Sub ConfiguracionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConfiguracionToolStripMenuItem.Click
        frmTipoCalculoVolumen.MdiParent = Me
        frmTipoCalculoVolumen.Show()
    End Sub
End Class
