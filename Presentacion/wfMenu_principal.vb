Imports System.IO
Imports System.Configuration
Imports System.Windows.Forms
Imports DevComponents.DotNetBar
Imports MySql.Data.MySqlClient
Public Class wfMenu_principal

    Dim xTitulo = fxSamad.Titulo
    Protected frmCount As Integer = 0

#Region "Funciones y Prtocedimientos locales del Sistema"
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

#End Region


    Private Sub btSalir_Click(sender As System.Object, e As System.EventArgs) Handles btSalir.Click
        Dim sn = New conexion().dbClose()
        Application.Exit()
    End Sub

    Private Sub btContratos_Click(sender As System.Object, e As System.EventArgs) Handles btContratos.Click
        AbrirFormulario(frmContratos)
        'AbrirFormulario(wfContratos)
    End Sub

    Private Sub btExit_Click(sender As System.Object, e As System.EventArgs) Handles btExit.Click
        Dim sn = New conexion().dbClose()
        Application.Exit()
    End Sub

    Private Sub btConductor_Click(sender As System.Object, e As System.EventArgs) Handles btConductor.Click
        AbrirFormulario(frmConductores)
    End Sub

    Private Sub btSafrapoa_Click(sender As System.Object, e As System.EventArgs) Handles btSafrapoa.Click
        AbrirFormulario(FrmZafrasypoas)
    End Sub

    Private Sub btVehiculo_Click(sender As System.Object, e As System.EventArgs) Handles btVehiculo.Click
        AbrirFormulario(frmVehiculos)
    End Sub

    Private Sub btPersonal_Click(sender As System.Object, e As System.EventArgs) Handles btPersonal.Click
        AbrirFormulario(frmPersonal)
    End Sub

    Private Sub btCargos_Click(sender As System.Object, e As System.EventArgs) Handles btCargos.Click
        AbrirFormulario(frmCargos)
    End Sub

    Private Sub btEspecies_Click(sender As System.Object, e As System.EventArgs) Handles btEspecies.Click
        AbrirFormulario(frmEspecies)
    End Sub

    Private Sub btProductos_Click(sender As System.Object, e As System.EventArgs) Handles btProductos.Click
        AbrirFormulario(frmProductos)
    End Sub

    Private Sub btUbicacion_Click(sender As System.Object, e As System.EventArgs) Handles btUbicacion.Click
        AbrirFormulario(frmUbicacion)
    End Sub

    Private Sub btProcedencias_Click(sender As System.Object, e As System.EventArgs) Handles btProcedencias.Click
        AbrirFormulario(frmProcedencia)
    End Sub

    Private Sub btLinprod_Click(sender As System.Object, e As System.EventArgs) Handles btLinprod.Click
        AbrirFormulario(frmLinea)
    End Sub

    Private Sub btTransac_Click(sender As System.Object, e As System.EventArgs) Handles btTransac.Click
        AbrirFormulario(frmProcesos)
    End Sub

    Private Sub btDefs_Click(sender As System.Object, e As System.EventArgs) Handles btDefs.Click
        AbrirFormulario(FrmDeffs)
    End Sub

    Private Sub btEmpresas_Click(sender As System.Object, e As System.EventArgs) Handles btEmpresas.Click
        AbrirFormulario(frmTitulares)
    End Sub

    Private Sub btGuias_Click(sender As System.Object, e As System.EventArgs) Handles btGuias.Click
        If RibbonControl1.Expanded = True Then
            RibbonControl1.Expanded = False
        End If
        AbrirFormulario(frmListatrozas)
    End Sub

    Private Sub btReceptrozas_Click(sender As System.Object, e As System.EventArgs) Handles btReceptrozas.Click
        If RibbonControl1.Expanded = True Then
            RibbonControl1.Expanded = False
        End If
        AbrirFormulario(wfIngreso_trozas)
    End Sub

    Private Sub btIngtrozas_Click(sender As System.Object, e As System.EventArgs) Handles btIngtrozas.Click
        If RibbonControl1.Expanded = True Then
            RibbonControl1.Expanded = False
        End If
        AbrirFormulario(frmFormato02)
    End Sub

    Private Sub btProduccion_Click(sender As System.Object, e As System.EventArgs) Handles btProduccion.Click
        If RibbonControl1.Expanded = True Then
            RibbonControl1.Expanded = False
        End If
        AbrirFormulario(frmFormato04)
    End Sub

    Private Sub btEmpaquetado_Click(sender As System.Object, e As System.EventArgs) Handles btEmpaquetado.Click
        If RibbonControl1.Expanded = True Then
            RibbonControl1.Expanded = False
        End If
        AbrirFormulario(wfEmpaquetado)
    End Sub

    Private Sub btDespacho_Click(sender As System.Object, e As System.EventArgs) Handles btDespacho.Click
        AbrirFormulario(frmDespacho)
    End Sub

    Private Sub btUsuarios_Click(sender As System.Object, e As System.EventArgs) Handles btUsuarios.Click
        AbrirFormulario(frmUsuarios)
    End Sub

    Private Sub btGTF_Click(sender As System.Object, e As System.EventArgs) Handles btGTF.Click
        AbrirFormulario(frmReportes)
    End Sub

    Private Sub btRestaura_Click(sender As System.Object, e As System.EventArgs) Handles btRestaura.Click
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

    Private Sub cmdMinMax_Executed(sender As System.Object, e As System.EventArgs) Handles cmdMinMax.Executed
        RibbonControl1.Expanded = cmdMinMax.Checked
        cmdMinMax.Checked = Not cmdMinMax.Checked
    End Sub

    Private Sub btBackup_Click(sender As System.Object, e As System.EventArgs) Handles btBackup.Click        
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

    
    Private Sub wfMenu_principal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbEntorno.Text = "Entorno de los datos : " & My.Settings.dbEntorno
    End Sub

    Private Sub btMinMax_ValueChanged(sender As System.Object, e As System.EventArgs) Handles btMinMax.ValueChanged

    End Sub

  
    Private Sub btUnidMedAB_Click(sender As System.Object, e As System.EventArgs) Handles btUnidMedAB.Click
        AbrirFormulario(frmUnidadMedida)
    End Sub

    Private Sub btUnidMedL_Click(sender As System.Object, e As System.EventArgs) Handles btUnidMedL.Click
        AbrirFormulario(frmUnidadMedidaLargo)
    End Sub

    Private Sub btTipCalVol_Click(sender As System.Object, e As System.EventArgs) Handles btTipCalVol.Click
        AbrirFormulario(frmTipoCalculoVolumen)
    End Sub

    Private Sub RibbonBar6_ItemClick(sender As System.Object, e As System.EventArgs) Handles RibbonBar6.ItemClick

    End Sub
End Class