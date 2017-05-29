Public Class frmFormato01c_det
    Dim Sw As Boolean = False
    Public multi As Boolean = False
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If dataTransferir.Rows.Count <> 0 Then
            multi = True
            Me.Hide()
            wfIngreso_trozas_det.Hide()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub
    Private Sub AplicarPerfil()
        If vInfraestructura.Usuario.gtipo = "ADMINISTRADOR" Then

        Else
            GroupBox2.Enabled = False
        End If
    End Sub

    Private Sub formatear_grid()
        dataTransferir.Columns(0).HeaderText = "Id"
        dataTransferir.Columns(1).HeaderText = "Nro.GTF"
        dataTransferir.Columns(2).HeaderText = "Especie"
        dataTransferir.Columns(3).HeaderText = "Código"
        dataTransferir.Columns(4).HeaderText = "D> (Mayor)"
        dataTransferir.Columns(5).HeaderText = "D< (Menor)"
        dataTransferir.Columns(6).HeaderText = "Largo"
        dataTransferir.Columns(7).HeaderText = "Volm3"
        dataTransferir.Columns(8).HeaderText = "Titular Id"
        dataTransferir.Columns(9).HeaderText = "Cut"

        dataTransferir.Columns(0).Width = 30
        dataTransferir.Columns(1).Width = 70
        dataTransferir.Columns(2).Width = 100
        dataTransferir.Columns(3).Width = 60
        dataTransferir.Columns(4).Width = 50
        dataTransferir.Columns(5).Width = 50
        dataTransferir.Columns(6).Width = 50
        dataTransferir.Columns(7).Width = 50
        dataTransferir.Columns(8).Width = 40
        dataTransferir.Columns(9).Width = 120
        dataTransferir.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub frmFormato01c_det_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formatear_grid()
        calcular_trozas_y_volumen()
        AplicarPerfil()

    End Sub

    Private Sub calcular_trozas_y_volumen()
        ''Dim tot_trozas As Integer = wfIngreso_trozas_det.Dtmul.Rows.Count
        ''Dim tot_volm3 As Decimal = wfIngreso_trozas_det.Dtmul.Compute("Sum(ltd_vol_m3)", Nothing)
        ''TxtTrozas.Text = tot_trozas
        ''txtVolm3.Text = tot_volm3
    End Sub
End Class