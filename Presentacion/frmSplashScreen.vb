Imports System.Configuration
Imports System.IO
Imports MySql.Data.MySqlClient

Public NotInheritable Class SplashScreen

    Dim xTitulo = fxSamad.Titulo
    Dim strEntorno As String = Nothing

#Region "Comentarios (Borrar despues)"
    'Instalar Servicio de Mysql
    'https://www.youtube.com/watch?v=NYmcrl3urig
    'Mysql Stand alone
    'https://www.youtube.com/watch?v=ZI8g4Q_kEog

#End Region
    
    Private Sub btExit_Click(sender As System.Object, e As System.EventArgs) Handles btExit.Click
        Application.Exit()
    End Sub

    Private Sub pbLocal_Click(sender As System.Object, e As System.EventArgs) Handles pbLocal.Click
        rbLocal.Checked = True
    End Sub

    Private Sub pbRemote_Click(sender As System.Object, e As System.EventArgs) Handles pbRemote.Click
        rbRemote.Checked = True
    End Sub

    Private Sub btNext_Click(sender As System.Object, e As System.EventArgs) Handles btNext.Click        
        'Dim fxConection As New conexion
        If rbLocal.Checked = False And rbRemote.Checked = False Then
            MessageBox.Show("Por favor, seleccione el Entorno de los Datos", "Totulo", MessageBoxButtons.OK)
            Exit Sub
        End If
        If rbLocal.Checked = True Then
            If New fxSamad().ServicioMysqlIsRunning() = False Then
                If New fxSamad().IniciarServicioMysql() = False Then
                    MessageBox.Show("No se pudo Iniciar el Servicio local de Datos", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If            
        End If
        If My.Settings.dbEntorno <> strEntorno Then
            My.Settings.dbEntorno = strEntorno
            frmConfigDataBase.Show()
            Me.Close()
        Else
            If New fxSamad().OpenConecctionSamad() = False Then
                My.Settings.dbEntorno = strEntorno
                frmConfigDataBase.Show()
                Me.Close()
            Else
                frmLogin.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub rbRemote_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbRemote.CheckedChanged
        strEntorno = rbRemote.Text
    End Sub

    Private Sub rbLocal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbLocal.CheckedChanged
        strEntorno = rbLocal.Text
    End Sub

    Private Sub SplashScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If My.Settings.dbEntorno = "Local" Then
            rbLocal.Checked = True
        Else
            rbRemote.Checked = True
        End If
    End Sub
End Class
