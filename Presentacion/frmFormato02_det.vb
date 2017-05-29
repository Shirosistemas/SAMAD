Public Class frmFormato02_det

    Friend xExiste As Boolean
    Friend TrozaId, aserrio As String
    Friend xRowpapa As Integer
    Friend xPeriodo, xLote, xcontinuo As String

    Dim xTitulo = fxSamad.Titulo


#Region "Funciones y Procedimientos del Sistema(Esta Opcion)"

    'Validamos si existen Trozas en Existencias
    Private Function TrozasExistentes() As Boolean
        Using dm As New samadEntities
            Dim nr = (From rs In dm.formato01_det Where rs.Estatus = 0 Select rs.F01d_Id).Count()
            Return IIf(nr > 0, True, False)
        End Using
    End Function

    Private Sub MostrarDatosTroza()
        If rbCodigo.Checked = True Then
            Dim dt = New cdFormato01Det().GetNumeroTrozaIndustria(TrozaId)
            ' If Not xLastTRoza Is Nothing Then
            If Not dt Is Nothing Then
                txCodigoTroza.Text = dt.F01d_Correlativo
                txCodigoEmpresa.Text = dt.F01d_CodIndustria
                txPeriodoIngreso.Text = dt.Periodo
                txGtf.Text = dt.F01d_Gtf
                txLoteIngreso.Text = dt.F01d_Lote
                txEspecieID.Text = dt.EspecieId
                txEspecie.Text = dt.F01d_Especiec
                txDmayor.Text = dt.F01d_D1
                txDmenor.Text = dt.F01d_D2
                txLargo.Text = dt.F01d_D3
                txVolM3.Text = dt.F01d_Vol_M3
                txtDM1c.Text = dt.F01d_D1c
                txtDM2c.Text = dt.F01d_D2c
                txtLargoc.Text = dt.F01d_D3c
                txtVolm3c.Text = dt.F01d_Vol_M3c
                txtDmIn.Text = dt.F01d_Dm_pulgada
                txtLargoFt.Text = dt.F01d_Long_pie
                txtVolPt.Text = dt.F01d_Vol_pt
                txUnidad.Text = dt.F01d_unidad
                txAutogen.Text = dt.F01d_Autogenerado
            End If
        End If
        If rxTroza.Checked = True Then
            Dim dt = New cdFormato01Det().GetNumeroTroza(TrozaId)
            If Not dt Is Nothing Then
                txCodigoTroza.Text = dt.F01d_Correlativo
                txCodigoEmpresa.Text = dt.F01d_CodIndustria
                txPeriodoIngreso.Text = dt.Periodo
                txGtf.Text = dt.F01d_Gtf
                txLoteIngreso.Text = dt.F01d_Lote
                txEspecieID.Text = dt.EspecieId
                txEspecie.Text = dt.F01d_Especiec
                txDmayor.Text = dt.F01d_D1
                txDmenor.Text = dt.F01d_D2
                txLargo.Text = dt.F01d_D3
                txVolM3.Text = dt.F01d_Vol_M3
                txtDM1c.Text = dt.F01d_D1c
                txtDM2c.Text = dt.F01d_D2c
                txtLargoc.Text = dt.F01d_D3c
                txtVolm3c.Text = dt.F01d_Vol_M3c
                txtDmIn.Text = dt.F01d_Dm_pulgada
                txtLargoFt.Text = dt.F01d_Long_pie
                txtVolPt.Text = dt.F01d_Vol_pt
                txUnidad.Text = dt.F01d_unidad
                txAutogen.Text = dt.F01d_Autogenerado
            End If
        End If
    End Sub

    Private Sub MarcarTrozaConsumida()
        Dim dm As New samadEntities
        Dim xListat As formato01_det = dm.formato01_det.First(Function(x) x.F01d_Correlativo = txCodigoTroza.Text)
        xListat.Estatus = 1
        dm.SaveChanges()
    End Sub

    Private Sub LimpiarControles()
        txCodigoTroza.Text = ""
        txCodigoEmpresa.Text = ""
        txPeriodoIngreso.Text = ""
        txLoteIngreso.Text = ""
        txGtf.Text = ""
        txAutogen.Text = ""
        txEspecie.Text = ""
        txDmayor.Text = ""
        txDmenor.Text = ""
        txLargo.Text = ""
        txVolM3.Text = ""
        txtDM1c.Text = ""
        txtDM2c.Text = ""
        txtLargoc.Text = ""
        txtVolm3c.Text = ""
        txtDmIn.Text = ""
        txtLargoFt.Text = ""
        txtVolPt.Text = ""
        txEspecieID.Text = ""
        txUnidad.Text = ""
    End Sub
#End Region

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txNumtroza_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F8 Then
            'Buscar el Codigo segun el Parametro

        End If
    End Sub

   

    Function TrozaExiste(ByVal strTroza As String) As Boolean
        Using dm As New samadEntities
            Dim nr = (From x In dm.formato01_det Where x.F01d_Correlativo = strTroza Select x.F01d_Correlativo).Count()
            Return IIf(nr > 0, True, False)
        End Using
    End Function

    Private Sub TxCorrelativo_CommandKeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxCorrelativo.CommandKeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                'TxCorrelativo()

            Case Keys.Tab, Keys.Enter
                e.Handled = True
                If String.IsNullOrEmpty(TxCorrelativo.Text) = True Then
                    MessageBox.Show("Por favor ingrese el Correlativo de Busqueda", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    TxCorrelativo.Focus()
                    Exit Sub
                End If
                If IsNumeric(TxCorrelativo.Text) = True Then
                    TxCorrelativo.Text = Microsoft.VisualBasic.Right("000000" + TxCorrelativo.Text, 6)
                Else

                End If
      
                If TxCorrelativo.Text <> "" Then
                    Dim tipocampox As String = ""
                    Dim xcampo As String = ""
                    Dim db As New samadEntities
                    If rxTroza.Checked = True Then
                        If New cdFormato01Det().VerificaSiExisteRegistroBosque(TxCorrelativo.Text, xPeriodo, aserrio) = False Then '.CodigoBosqueExiste(TxCorrelativo.Text, xPeriodo, aserrio) = False Then
                            ' MessageBox.Show("Codigo de Bosque  no existe", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            TxCorrelativo.Focus()
                            btnAceptar.Enabled = False
                            Exit Sub
                            'If New cdFormato02det().CodigoBosqueRepite(TxCorrelativo.Text, xPeriodo, aserrio) = True Then
                            '    MessageBox.Show("Código de Bosque es repetido", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            '    btnAceptar.Enabled = False
                            '    TxCorrelativo.Focus()
                            '    Exit Sub
                        Else
                            btnAceptar.Enabled = True
                            'End If

                        End If

                        TrozaId = TxCorrelativo.Text
                        MostrarDatosTroza()
                        btnAceptar.Enabled = True
                        btnAceptar.Select()

                    End If
                    If rbCodigo.Checked = True Then

                        If New cdFormato01Det().VerificaSiExisteRegistroIndustria(TxCorrelativo.Text, xPeriodo, aserrio) = False Then '.CodigoIndustriaExisteA(TxCorrelativo.Text, xPeriodo, aserrio) = False Then
                            'MessageBox.Show("Codigo de Industria  no existe", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            TxCorrelativo.Focus()
                            btnAceptar.Enabled = False
                            Exit Sub
                            'If New cdFormato02det().CodigoIndustriaRepite(TxCorrelativo.Text, xPeriodo, aserrio) = True Then
                            '    MessageBox.Show("Código de Indutria es repetido", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            '    btnAceptar.Enabled = False
                            '    TxCorrelativo.Focus()
                            '    Exit Sub

                        Else
                            btnAceptar.Enabled = True
                            'End If
                        End If
                        TrozaId = TxCorrelativo.Text
                        MostrarDatosTroza()
                        btnAceptar.Enabled = True
                        btnAceptar.Select()
                    End If
                End If

        End Select
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If String.IsNullOrEmpty(txComentario.Text) Then
            If MessageBox.Show("No hay ningun comentario, ¿Desea guardar el registro de todas maneras?", xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                txComentario.Focus()
                Exit Sub
            End If
        End If
        Dim FRM = frmFormato02
        Dim dt As New SAMAD.formato02_det
        Try
            If xExiste = True Then
                dt.F02d_Id = txId.Text
            End If
            dt.F02d_Cut = txAutogen.Text
            dt.F02d_Codificacion = txCodigoTroza.Text
            dt.F02d_D1 = CDbl(IIf(txDmayor.Text = "", 0, txDmayor.Text))
            dt.F02d_D2 = CDbl(IIf(txDmenor.Text = "", 0, txDmenor.Text))
            dt.F02d_D3 = CDbl(IIf(txLargo.Text = "", 0, txLargo.Text))
            dt.F02d_Volm3 = CDbl(IIf(txVolM3.Text = "", 0, txVolM3.Text))

            dt.f02d_d1c = CDbl(IIf(txtDM1c.Text = "", 0, txtDM1c.Text))
            dt.f02d_d2c = CDbl(IIf(txtDM2c.Text = "", 0, txtDM2c.Text))
            dt.f02d_d3c = CDbl(IIf(txtLargoc.Text = "", 0, txtLargoc.Text))
            dt.f02d_volm3c = CDbl(IIf(txtVolm3c.Text = "", 0, txtVolm3c.Text))

            dt.f02d_d_pulgada = CDbl(IIf(txtDmIn.Text = "", 0, txtDmIn.Text))
            dt.f02d_dpies = CDbl(IIf(txtLargoFt.Text = "", 0, txtLargoFt.Text))
            dt.f02d_vol_pt = CDbl(IIf(txtVolPt.Text = "", 0, txtVolPt.Text))
            dt.F02d_Observacion = txComentario.Text
            dt.F02d_F02_Id = xRowpapa
            dt.EspecieID = txEspecieID.Text
            dt.F02d_Especie = txEspecie.Text
            dt.F02d_CodIndustria = txCodigoEmpresa.Text
            dt.F02d_unidad = txUnidad.Text
            dt.F02d_Lote = txLoteIngreso.Text
            dt.F02d_Periodo = xPeriodo
            dt.F02d_GTF = txGtf.Text
            dt.Estatus = 0
            If New cdFormato02det().GrabarEnFormato02Det(dt, xExiste) = True Then
                MarcarTrozaConsumida()
                frmFormato02.btUpdate.PerformClick()
                frmFormato02.ListarInfo()
                LimpiarControles()
                txComentario.Focus()
                ' txNumtroza.Focus()

            Else
                MessageBox.Show("No se pudo registrar este producto", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(e.ToString, xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        TxCorrelativo.Focus()
        TxCorrelativo.SelectAll()

    End Sub


    Private Sub frmFormato02_det_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TxCorrelativo.Focus()
        TxCorrelativo.Select()


    End Sub

    Private Sub rbCodigo_Click(sender As Object, e As System.EventArgs) Handles rbCodigo.Click
        TxCorrelativo.Focus()
        TxCorrelativo.Select()
    End Sub

    Private Sub rxTroza_Click(sender As Object, e As System.EventArgs) Handles rxTroza.Click
        TxCorrelativo.Focus()
        TxCorrelativo.Select()
    End Sub


End Class