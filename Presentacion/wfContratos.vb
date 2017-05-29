
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Public Class wfContratos

    Dim xExiste As Boolean
    Dim xTitulo = fxSamad.Titulo

#Region "Funciones y Procedimientos locales del Sistema(Para esta Opción)"

    Private Sub ListarContratos()
        Dim xPanel As GridPanel = dgContratos.PrimaryGrid
        Dim dl = New cdContratos().VistaContratos()
        Dim x As Long = 0
        Dim xRow As GridRow = Nothing
        xPanel.Rows.Clear()
        If dl.Count() > 0 Then
            For x = 0 To dl.Count - 1
                xRow = New GridRow(dl(x).con_id, dl(x).Con_Descripcion, dl(x).pro_titular, dl(x).Con_Anno)
                xPanel.Rows.Add(xRow)
            Next
        End If
    End Sub


#End Region

    Private Sub btSalir_Click(sender As System.Object, e As System.EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub btAtras_Click(sender As System.Object, e As System.EventArgs) Handles btAtras.Click
        sPlitter.Expanded = False
    End Sub

    Private Sub wfContratos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        sPlitter.Expanded = False
        ListarContratos()
    End Sub

    Private Sub dgContratos_Click(sender As System.Object, e As System.EventArgs) Handles dgContratos.Click
        Dim xPanel As GridPanel = dgContratos.PrimaryGrid
        Dim xRow As GridRow = Nothing
        xRow = xPanel.ActiveRow()
        txId.Text = xRow.Cells(0).Value
    End Sub

    Private Sub btEditar_Click(sender As System.Object, e As System.EventArgs) Handles btEditar.Click
        If String.IsNullOrEmpty(txId.Text) = True Then
            MessageBox.Show("Debe seleccione el Registro a Editar ", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim lst = New cdContratos().lstContrato(CInt(txId.Text))
        If lst.Count > 0 Then
            'txId.Text = lst(0).
            txNombre.Text = lst(0).id
        End If
        'Console.WriteLine(prod5.Equals(prod6))
        'txTID.Text = lst(1)

        sPlitter.Expanded = True

    End Sub
End Class