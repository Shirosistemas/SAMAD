Public Class wfProduccion_detalle

   
    Private Sub txEspecie_ButtonCustomClick(sender As System.Object, e As System.EventArgs) Handles txEspecie.ButtonCustomClick
        Dim wfBuscar As New frmShowbrow
        wfBuscar.titulo = "Numeros de Lotes"
        wfBuscar.t_tabla = "formato02_det"
        wfBuscar.t_campos = "f02d_especie,f02d_lote"
        wfBuscar.t_donde = ""
        wfBuscar.t_agruparpor = "f02d_especie"
        wfBuscar.t_ordenarpor = "f02d_especie"
        Dim titulos() As String = {"Especie", "No lote"}
        Dim anchos() As Integer = {120, 70}

        ReDim wfBuscar.matAnchos(anchos.Length)
        ReDim wfBuscar.matTitulos(titulos.Length)
        ReDim wfBuscar.matColumnas(titulos.Length)
        titulos.CopyTo(wfBuscar.matTitulos, 0)
        anchos.CopyTo(wfBuscar.matAnchos, 0)

        wfBuscar.ShowDialog(Me)
        If wfBuscar.flag = True Then
            txEspecie.Text = wfBuscar.matColumnas(0)
            txLote.Text = wfBuscar.matColumnas(1)
            Dim dm As New samadEntities
            'ZafrasComboBox.DataSource = db.zafrasypoas.Where(Function(p) p.Zyp_Permiso_Id = id).Select(Function(p) p.Zyp_Zafra).Distinct().ToList()
            txEspecieId.Text = dm.especies.Where(Function(x) x.Espe_NombreComun = txEspecie.Text).Select(Function(p) p.Espe_Id).First()
        End If
    End Sub

    Private Sub txEspecie_TextChanged(sender As System.Object, e As System.EventArgs) Handles txEspecie.TextChanged

    End Sub
End Class