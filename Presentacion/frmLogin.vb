
Public Class frmLogin

    'Private dt As New DataTable
    Dim xTitulo = fxSamad.Titulo

#Region "Nuevo Codigo"

    ' Proc local para llenar el Combobox Usuario con los usuarios existentes en la tabla Usuarios
    Private Sub ListarUsuarios()
        Dim dt = New fusuarios().lstUsuarios()
        UsernameCB.DataSource = dt
        UsernameCB.ValueMember = "usu_nombre"
        UsernameCB.DisplayMember = "usu_nombre"
    End Sub

#End Region

    Private Sub btn_Login_Click(sender As System.Object, e As System.EventArgs) Handles btn_Login.Click
        Login()
    End Sub

    Private Sub Login()
        If New fusuarios().UsuarioExiste(UsernameCB.Text.Trim()) = False Then
            MessageBox.Show("Nombre de Usuario no existe", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            UsernameCB.Focus()
            Exit Sub
        End If
        Dim dt = New fusuarios().dtUsuario(UsernameCB.Text.Trim())
        If dt.usu_password <> Password.Text Then
            MessageBox.Show("Clave de acceso no es correcta", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Password.Focus()
            Exit Sub
        End If
        Dim user As New vUsuario(dt.usu_id, dt.usu_nombre, dt.usu_password, dt.uso_tipo)
        vInfraestructura.Usuario = user
        'wfMenu_principal.Show()
        frmPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        'If Password.Text.Length = 0 Then
        '    Me.Close()
        'Else
        '    Password.Clear()
        'End If

        Application.Exit()

    End Sub

    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Try
        '    Dim func As New fusuarios 'Creacion una variable para hacer referencia a la funcion fusuarios
        '    dt = func.mostrar 'Invocamos a la funcion mostrar()
        '    UsernameCB.DataSource = dt
        '    UsernameCB.ValueMember = "usu_nombre"
        '    UsernameCB.DisplayMember = "usu_nombre"
        'Catch ex As Exception
        '    MsgBox("Mensaje : Procedimiento Mostrar()" + ex.Message)
        'End Try
        ListarUsuarios()
    End Sub

    Private Sub UsernameCB_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles UsernameCB.SelectedIndexChanged
        Password.Focus()
    End Sub


    Private Sub Password_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrEmpty(Password.Text) = True Then
                MessageBox.Show("Por favor ingrese su clave de acceso", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Password.Focus()
            End If
            Login()
        End If
    End Sub
End Class