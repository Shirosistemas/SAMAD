Public Class frmPaqueteDeta
    Dim Dt, Dtd, Dtdm, Dte, Dtep, Dtb As New DataTable
    Dim nreg, nregpd, nregd, xreg, recno As Integer
    Dim sw_guardar As Boolean = False
    Dim sw_guardard As Boolean = False
    Dim nuevo As Boolean = False
    Public nuevoDeta As Boolean = False
    Dim nuevoItem As Boolean = False
    Dim modificar As Boolean = False
    Public modificarDeta As Boolean = False
    Dim modificarItem As Boolean = False
    Dim msg As String = ""
    Public sw2 As Boolean = False
    Dim frm, frmbuscardoc As New frmShowbrow
    Private _left As String
    Private Sub AplicarPerfil()
        If vInfraestructura.Usuario.gtipo = "ADMINISTRADOR" Then

        Else

            Panel2.Enabled = False
        End If
    End Sub
    Private Sub habilitar()
        txtId.Enabled = False
        txtAncho.Enabled = True
        txtEspesor.Enabled = True
        txtLargo.Enabled = True
        txtVolPt.Enabled = True
        txtNumPiezas.Enabled = True

        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
    End Sub
    Private Sub deshabilitar()
        txtId.Enabled = False
        txtAncho.Enabled = False
        txtEspesor.Enabled = False
        txtLargo.Enabled = False
        txtVolPt.Enabled = False
        txtNumPiezas.Enabled = False
    End Sub
    Private Sub limpiar()
        txtId.Text = ""
        txtAncho.Text = ""
        txtEspesor.Text = ""
        txtLargo.Text = ""
        txtVolPt.Text = ""
        txtNumPiezas.Text = ""
    End Sub
    Private Sub frmPaqueteDeta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        habilitar()
        AplicarPerfil()
        Panel2.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim funcl As New flibreria
        Dim todook As Boolean = funcl.ValidaControles(gbDatos.Controls)
        If todook = True Then
            sw2 = True
            Me.Hide()
        End If
    End Sub
    Private Sub txtNumPiezas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumPiezas.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            e.Handled = True
            If txtNumPiezas.Text = CChar("") Then
                txtNumPiezas.Text = "0"
            Else
                txtNumPiezas.Text = Format(txtNumPiezas.Text * 1, "#####0")
                txtVolPt.Focus()
            End If
        End If

        ' "0123456789.-" Valores o caracteres que solo aceptara el TextBox

        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub
    Private Sub txtNumPiezas_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumPiezas.LostFocus
        If IsNumeric(txtNumPiezas.Text) Then
            If txtNumPiezas.Text <> 0 Then
                txtNumPiezas.Text = Format(txtNumPiezas.Text * 1, "####0")
            End If
        End If
        Calcular_Volm3()
    End Sub
    Private Sub Calcular_Volm3()
        Dim espesor = txtEspesor.Text
        Dim ancho = txtAncho.Text
        Dim largo = txtLargo.Text
        Dim Pzas = txtNumPiezas.Text
        If txtEspesor.Text <> "" And txtAncho.Text <> "" And txtLargo.Text <> "" And txtNumPiezas.Text <> "" Then
            txtVolPt.Text = Format(((espesor * ancho * largo) / 12) * Pzas, "##,##0.00")
        End If
    End Sub
    Private Sub txtEspesor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEspesor.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            e.Handled = True
            If txtEspesor.Text = "" Then
                txtEspesor.Text = "0"
            Else
                txtEspesor.Text = Format(txtEspesor.Text * 1, "##0.00")
                txtAncho.Focus()
            End If
        End If

        ' "0123456789.-" Valores o caracteres que solo aceptara el TextBox

        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub
    Private Sub txtEspesor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEspesor.LostFocus
        If IsNumeric(txtEspesor.Text) Then
            If txtEspesor.Text <> 0 Then
                txtEspesor.Text = Format(txtEspesor.Text * 1, "##0.00")
            End If
        End If
        Calcular_Volm3()
    End Sub
    Private Sub txtLargo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLargo.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            e.Handled = True
            If txtLargo.Text = "" Then
                txtLargo.Text = "0"
            Else
                txtLargo.Text = Format(txtLargo.Text * 1, "##0.00")
                txtNumPiezas.Focus()
            End If
        End If

        ' "0123456789.-" Valores o caracteres que solo aceptara el TextBox

        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub
    Private Sub txtLargo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLargo.LostFocus
        If IsNumeric(txtLargo.Text) Then
            If txtLargo.Text <> 0 Then
                txtLargo.Text = Format(txtLargo.Text * 1, "##0.00")
            End If
        End If
        Calcular_Volm3()
    End Sub
    Private Sub txtAncho_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAncho.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            e.Handled = True
            If txtAncho.Text = "" Then
                txtAncho.Text = "0"
            Else
                txtAncho.Text = Format(txtAncho.Text * 1, "##0.00")
                txtLargo.Focus()
            End If
        End If

        ' "0123456789.-" Valores o caracteres que solo aceptara el TextBox

        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub

    Private Sub txtAncho_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAncho.LostFocus
        If IsNumeric(txtAncho.Text) Then
            If txtAncho.Text <> 0 Then
                txtAncho.Text = Format(txtAncho.Text * 1, "##0.00")
            End If
        End If
        Calcular_Volm3()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Enviamos los datos de la consulta sql
        frm.titulo = "Seleccionar Medidas"
        frm.t_tabla = "vmostrar_formato04_det"
        frm.t_campos = "f04d_especie,prod_descrip,f04d_espesor,f04d_ancho,f04d_largo,sum(f04d_nropiezasp+f04d_nropiezass)as Piezas, sum(f04d_volptp+f04d_volpts) as volpt"
        frm.t_donde = ""
        frm.t_agruparpor = "f04d_espesor,f04d_ancho,f04d_largo"
        frm.t_ordenarpor = "f04d_especie,prod_descrip"

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Especie", "Producto", "Espesor", "Ancho", "Largo", "Piezas", "Volpt"}
        Dim anchos() As Integer = {100, 100, 50, 50, 50, 50, 50}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)
        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog(Me)

        'Datos del Titular
        If frm.flag = True Then
            'txtEspecieId.Text = frm.matColumnas(0)
            'txtEspecieNombre.Text = frm.matColumnas(1)
        End If
    End Sub
    
   
    Private Sub txtVolPt_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtVolPt.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            e.Handled = True
            If txtAncho.Text = "" Then

            Else
                btnGuardar.Focus()
            End If
        End If
    End Sub
End Class