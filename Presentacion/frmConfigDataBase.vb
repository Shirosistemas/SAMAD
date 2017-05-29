Imports System.Configuration
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmConfigDataBase

    Dim xTitulo = fxSamad.Titulo

#Region "Nuevo Codigo Elifa Mojica"

    ' - Procedimiento para Grabar los parametros de COnexion 
    Private Sub SaveAppSetting()
        Dim xConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim xSeccion As ConnectionStringsSection = xConf.GetSection("connectionStrings")
        xSeccion.ConnectionStrings("SAMAD.My.MySettings.strMysqlConexion").ConnectionString = "server=" & txServer.Text & ";user id=" & txUsuario.Text & ";password=" & txClave.Text & ";persistsecurityinfo=True;database=samad"
        xSeccion.ConnectionStrings("samadEntities").ConnectionString = "metadata=res://*/model.csdl|res://*/model.ssdl|res://*/model.msl;provider=MySql.Data.MySqlClient;provider connection string=""server=" + txServer.Text + ";user id=" + txUsuario.Text + ";password=" + txClave.Text + ";database=samad"""
        xConf.Save()
        ConfigurationManager.RefreshSection("connectionStrings")
    End Sub

    ' - Instalar la base de Datos
    Private Function RestaurarBaseDatos() As Boolean
        Dim strCadena As String = "server=192.168.0.4;user id=root;password=159753;persistsecurityinfo=True;database=samad"
        'Dim strCadena As String = New fxSamad().GetCadenaCionexionMysql()
        Try
            Dim xCnn As New MySqlConnection(strCadena)
            'Dim xConfig As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            Dim xCmd As New MySqlCommand
            xCmd.Connection = xCnn
            xCnn.Open()
            Dim xDB As New MySql.Data.MySqlClient.MySqlBackup(xCmd)
            lbProgreso.Visible = True
            Refresh()
            xDB.ImportFromFile(Application.StartupPath.ToString() & "\Mysql\backup\samadx.sql")
            'xDB.ImportFromFile("D:\MySql\Backup\samadx.sql")
            'xDB.ImportFromFile("C:\Mysql\Mysql\Backup\samadx.sql")
            lbProgreso.Text = "Operacion Exitosa"
            xCnn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

#End Region


    Private Sub btExit_Click(sender As System.Object, e As System.EventArgs) Handles btExit.Click
        Application.Exit()
    End Sub

    Private Sub btNext_Click(sender As System.Object, e As System.EventArgs) Handles btNext.Click
        If String.IsNullOrEmpty(txServer.Text) = True Then
            MessageBox.Show("Debe Ingresar el Nombre del Servidor al cual se va a conectar", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txServer.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(txUsuario.Text) = True Then
            MessageBox.Show("Ingrese el Nombre de Usuario con el que se Conecta a la base de datos", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txUsuario.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(txClave.Text) = True Then
            MessageBox.Show("Por favor ingrese la Clave de acceso", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txClave.Focus()
            Exit Sub
        End If
        SaveAppSetting()
        If My.Settings.dbEntorno = "Local" Then
            If New fxSamad().ServicioMysqlIsRunning() = False Then
                MessageBox.Show("No se ha iniciado el Servicio MySql", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If            
            If New fxSamad().OpenConecctionSamad() = False Then
                'La base de datos no existe( hay que crearla
                If New fxSamad().CreardBaseSamad() = False Then
                    MessageBox.Show("No se pudo crear la base de datos", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                If RestaurarBaseDatos() = False Then
                    MessageBox.Show("No se pudo restaurar la base de datos", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        End If
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub frmConfigDataBase_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If My.Settings.dbEntorno = "Local" Then
            txServer.Text = "localhost"
            txUsuario.Text = "peru"
            txClave.Text = "damas"
            txdBase.Text = "samad"
            chkInstallDB.Checked = True
            chkInstallDB.Enabled = False
            'txServer.Enabled = False
        Else
            txServer.Text = ""
            txUsuario.Text = "peru"
            txClave.Text = "damas"
            chkInstallDB.Enabled = False
            txdBase.Text = "samad"
            txServer.ReadOnly = False
        End If
    End Sub

    
End Class