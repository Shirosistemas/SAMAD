
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports System.Linq
Public Class frmDespacho_det
    Public sw As Boolean = False
    Dim frmLista, frm As New frmShowbrow
    Dim gtfid As Integer
    Dim ContratoId As String
    Dim ListarAserrio As List(Of vmostrar_listaaseriogtf)
    Dim listaCodigoRumas As List(Of formato04_rumas_det)
    Dim listaCodigoPaquete As List(Of paquete_deta)
    Dim listaCodigoRumasPaqueteEdit As List(Of despacho_catalogo)
    Dim xDoIt As Boolean
    Dim xGtf As String
    Dim xEspecieID As Integer
    Dim xPeriodo As String
    Dim xRow As GridRow = Nothing
    Dim xRendimientoFactor As Integer
    Dim xresulVolCome As Decimal
    Dim xresulVolRecu As Decimal
    Dim xVol_m3Recep As Decimal
    Dim xVolumen3 As Decimal
    Dim xacumvalomdes As Decimal
    Dim xacumvoltotal As Decimal
    Dim xidclasecomercial As Integer
    Dim xIdEspecie As Integer
    Dim ClaseComercial As String
    Dim IdDetallePat As Integer
    Dim IdDespachoOri As Integer
    Dim xrumadespachoId As Integer
    Dim lsHeader As List(Of SAMAD.despacho_det)
    ' Dim xTotalAserrCom As Decimal
    'Dim xTotalAserrRec As Decimal
    Dim xcontarreg1 As Decimal
    Friend recno As Integer = 0
    Friend CodigoRumaPaquete As String
    Friend contratonro As String
    Friend xcontratoid As Integer
    Friend xExiste As Boolean
    Friend xdespachoID As Integer 'aqui recibe parametro del despacho. esta variable se mantiene mientras no cierras el formulario
    Friend xDespachoDId As Integer 'Aquí debe recivir el valor del campo Desd_Id 
    Friend xcodDespacho As Integer
    Friend xidespeciecatreport As Integer
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Dim funcl As New flibreria
        Dim todook As Boolean = True '= funcl.ValidaControles(gbDatos.Controls)

        'If todook = True Then
        'If Convert.ToDecimal(txtVolm3.Text) <= Convert.ToDecimal(txtSaldo.Text) Then
        '    sw = True
        '    Me.Hide()
        'Else
        '    MessageBox.Show("El Volumen Ingresado, Supera el Saldo de la GFT", "Mensaje")
        'End If
        'End If
        Dim Actualizado As Boolean
        'Dim desconto As Boolean
        'Dim idpaquete As Integer = 0

        'Dim dm As samadEntities
        'Dim def As samadEntities
        Dim dt As New SAMAD.despacho_det

        'xidespeciecatreport = dm.especies.Where(Function(x) x.Espe_NombreComun = TxNomComercial.Text).Select(Function(b) b.Espe_Id).FirstOrDefault()

        If xExiste = True Then
            dt.Desd_Id = xcodDespacho
        End If
        'If xmodific = 1 Then
        If xExiste = True Then
            If RbCorrelativo.Checked = True Then
                'xrumadespachoId
                Actualizado = New fxSamad().Actlote("Update formato04_rumas Set estatus=0 Where rumaid=" & xrumadespachoId & " And estatus = 1")
                Actualizado = New fxSamad().Actlote("Update formato04_rumas_det Set estatus=0 Where rumaid=" & xrumadespachoId & " And estatus = 1")
                Actualizado = New fxSamad().Actlote("delete from despacho_catalogo Where cat_des_id=" & xcodDespacho & "")
            End If
            If RbNgtf.Checked = True Then
                Dim dz As New samadEntities
                Dim codigoactiva = dz.paquete.Where(Function(x) x.Numpaquete = xrumadespachoId And x.Estatus = 1).Select(Function(y) y.RowId).FirstOrDefault()

                Actualizado = New fxSamad().Actlote("Update paquete Set estatus=0 Where rowid=" & codigoactiva & " And estatus = 1")
                Actualizado = New fxSamad().Actlote("Update paquete_deta Set estatus=0 Where paqueteid=" & codigoactiva & " And estatus = 1")
                Actualizado = New fxSamad().Actlote("delete from despacho_catalogo Where cat_des_id=" & xcodDespacho & "")
            End If
            'Desde Aqui Cabecera
            dt.Desd_Des_Id = xdespachoID
            dt.Desd_NroGtf = txtNroGtf.Text
            dt.Desd_EspecieId = xIdEspecie
            dt.Desd_Especie = TxNomComercial.Text
            dt.Desd_Codigo = TxCodigo.Text
            dt.Desd_Producto = TxNomProducto.Text
            dt.Desd_ClaseId = xidclasecomercial
            dt.Desd_ClaseC = TxClaseComercial.Text
            dt.Desd_Cantidad = TxCantidad.Text
            dt.Desd_TipoUnid = TxTipUnid.Text
            dt.Desd_Volm3 = TxVolm3.Text
            dt.Desd_VolPt = TxVolPt.Text

            If RbCorrelativo.Checked = True Then
                dt.Desd_RumaPaquete = 1
            End If
            If RbNgtf.Checked = True Then
                dt.Desd_RumaPaquete = 2
            End If
            If rbDespachoTotal.Checked = True Then
                dt.Desd_ParcialTotal = 1
            End If
            If RbDespachoParcial.Checked = True Then
                dt.Desd_ParcialTotal = 2
            End If

            dt.Desd_VolM3_GTFRec = txTotalM3.Text

            dt.Desd_Sal_Volm3_80 = txtVolPorcSaldo.Text


            If xidclasecomercial = 1 Then
                dt.Desd_Ac_Volm3_CM = TxVolm3DesCom.Text
            Else
                dt.Desd_Ac_Volm3_CM = 0
            End If

            If xidclasecomercial = 2 Then
                dt.Desd_Ac_Volm3_RC = TxVolm3RecDesp.Text
            Else
                dt.Desd_Ac_Volm3_RC = 0
            End If

            dt.Des_Estatu = 0
            If New cdDespacho_det().DespachoDetGrabar(dt, xExiste) = False Then
                MessageBox.Show("No se pudo completar el proceso de grabar", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            'Desde aqui Detalle en las modalidades total y parcial segun opcion escogida.
            ' Dim idpaquete As Integer = New cdDespacho_det().LastDespachoId()
            If rbDespachoTotal.Checked = True Then 'cuando el despacho es total.
                If dgDetalle.PrimaryGrid.Rows.Count > 0 Then
                    Dim xPanel As GridPanel = dgDetalle.PrimaryGrid
                    Dim xRow As GridRow = Nothing
                    Dim IdDetallePat As Integer

                    For Each r As GridRow In xPanel.Rows ' recorre las filas de la grilla e inserta en la tabla dspacho_catalogo
                        Dim dp As New SAMAD.despacho_catalogo
                        'Dim cat As New SAMAD.catalogodespachoreport
                        Dim ct As New samadEntities
                        Dim idespecie = ct.especies.Where(Function(x) x.Espe_NombreComun = TxNomComercial.Text).Select(Function(b) b.Espe_Id).FirstOrDefault()

                        IdDetallePat = CInt(r.Cells(0).Value)
                        dp.Cat_Des_Id = xcodDespacho
                        dp.Cat_Espesor = CDec(r.Cells(1).Value)
                        dp.Cat_Ancho = CDec(r.Cells(2).Value)
                        dp.Cat_Largo = CDec(r.Cells(3).Value)
                        dp.Cat_Cantidad = CDec(r.Cells(4).Value)
                        dp.Cat_Volm3 = CDec(r.Cells(5).Value)
                        dp.Cat_VolPT = CDec(r.Cells(6).Value)
                        dp.Cat_Estatus = 0

                        'cat.CatDeDtsId = xcodDespacho
                        'cat.CatDesId = xdespachoID
                        'cat.CatIdEspecie = idespecie
                        'cat.CatEspecie = TxNomComercial.Text

                        ''llena columna A
                        'cat.CatEspesorA = CInt(r.Cells(1).Value)
                        'cat.CatAnchoA = CInt(r.Cells(2).Value)
                        'cat.CatLargoA = CInt(r.Cells(3).Value)
                        'cat.CatCamtidadA = CInt(r.Cells(4).Value)
                        'cat.CatVolm3A = CDec(r.Cells(5).Value)
                        'cat.CatVolPtA = CDec(r.Cells(6).Value)

                        'If xPanel.Rows.Count > 34 And xPanel.Rows.Count < 69 Then 'llena columna B
                        '    cat.CatEspesorB = CInt(r.Cells(1).Value)
                        '    cat.CatAnchoB = CInt(r.Cells(2).Value)
                        '    cat.CatLargoB = CInt(r.Cells(3).Value)
                        '    cat.CatCamtidadB = CInt(r.Cells(4).Value)
                        '    cat.CatVolm3B = CDec(r.Cells(5).Value)
                        '    cat.CatVolPtB = CDec(r.Cells(6).Value)
                        'ElseIf xPanel.Rows.Count > 68 And xPanel.Rows.Count < 103 Then 'llena columna c
                        '    cat.CatEspesorC = CInt(r.Cells(1).Value)
                        '    cat.CatAnchoC = CInt(r.Cells(2).Value)
                        '    cat.CatLargoC = CInt(r.Cells(3).Value)
                        '    cat.CatCamtidadC = CInt(r.Cells(4).Value)
                        '    cat.CatVolm3C = CDec(r.Cells(5).Value)
                        '    cat.CatVolPtC = CDec(r.Cells(6).Value)
                        'ElseIf xPanel.Rows.Count > 102 And xPanel.Rows.Count < 137 Then
                        '    cat.CatEspesorD = CInt(r.Cells(1).Value)
                        '    cat.CatAnchoD = CInt(r.Cells(2).Value)
                        '    cat.CatLargoD = CInt(r.Cells(3).Value)
                        '    cat.CatCamtidadD = CInt(r.Cells(4).Value)
                        '    cat.CatVolm3D = CDec(r.Cells(5).Value)
                        '    cat.CatVolPtD = CDec(r.Cells(6).Value)
                        'End If
                        'cat.CatEstatus = 0

                        'If New cdDespacho_det().CatalogoReportAgregar(cat) = True Then

                        'End If


                        If New cdDespacho_det().DetalleDespachoCatalogoAgregar(dp) = True Then
                            ' txProducto.Text = "Reg " & xPanel.Rows(x).ToString() & " Ok"
                            If RbCorrelativo.Checked = True Then
                                Actualizado = New fxSamad().Actlote("Update formato04_rumas_det Set estatus=1 Where rowid=" & IdDetallePat & " And estatus = 0")
                                'Actualizado = New fxSamad().Actlote("Update formato04_rumas Set estatus=1 Where rowid=" & xdespachoID & " And estatus = 0")
                            End If
                            If RbNgtf.Checked = True Then
                                Actualizado = New fxSamad().Actlote("Update paquete_deta Set estatus=1 Where rowid=" & IdDetallePat & " And estatus = 0")
                                'Actualizado = New fxSamad().Actlote("Update paquete Set estatus=1 Where rowid=" & xdespachoID & " And estatus = 0")
                            End If
                        End If
                    Next
                    'LimpiarControles()
                    If RbCorrelativo.Checked = True Then
                        'Actualizado = New fxSamad().Actlote("Update formato04_rumas_det Set estatus=1 Where rowid=" & IdDetallePat & " And estatus = 0")
                        Actualizado = New fxSamad().Actlote("Update formato04_rumas Set estatus=1 Where rumaid=" & CInt(TxCorrelativo.Text) & " And estatus = 0")
                    End If
                    If RbNgtf.Checked = True Then
                        Dim dx As New samadEntities
                        Dim codigoactiva = dx.paquete.Where(Function(x) x.Numpaquete = TxCorrelativo.Text And x.Estatus = 1).Select(Function(y) y.RowId).FirstOrDefault()
                        Actualizado = New fxSamad().Actlote("Update paquete Set estatus=1 Where rowid=" & codigoactiva & " And estatus = 0")
                    End If
                    LimpiarControles()
                    'MostrarDatosRumasPaquetes()
                    'HabilitarControles(False)
                End If
            End If
            If RbDespachoParcial.Checked = True Then
                If dgDetalle.GetSelectedRows.Count > 0 Then
                    Dim xPanel As GridPanel = dgDetalle.PrimaryGrid
                    Dim xRow As GridRow = Nothing

                    ''For Each oRow As GridRow In dgDetalle.PrimaryGrid.Rows

                    For Each r As GridRow In xPanel.Rows
                        'Dim cat As New SAMAD.catalogodespachoreport
                        Dim ct As New samadEntities
                        Dim idespecie = ct.especies.Where(Function(x) x.Espe_NombreComun = TxNomComercial.Text).Select(Function(b) b.Espe_Id).FirstOrDefault()

                        If r.IsSelected = True Then

                            Dim dp As New SAMAD.despacho_catalogo

                            IdDetallePat = CInt(r.Cells(0).Value)
                            dp.Cat_Des_Id = xcodDespacho
                            dp.Cat_Espesor = CDec(r.Cells(1).Value)
                            dp.Cat_Ancho = CDec(r.Cells(2).Value)
                            dp.Cat_Largo = CDec(r.Cells(3).Value)
                            dp.Cat_Cantidad = CDec(r.Cells(4).Value)
                            dp.Cat_Volm3 = CDec(r.Cells(5).Value)
                            dp.Cat_VolPT = CDec(r.Cells(6).Value)
                            dp.Cat_Estatus = 0

                            'cat.CatDeDtsId = xcodDespacho
                            'cat.CatDesId = xdespachoID
                            'cat.CatIdEspecie = idespecie
                            'cat.CatEspecie = TxNomComercial.Text

                            ''llena columna A
                            'cat.CatEspesorA = CInt(r.Cells(1).Value)
                            'cat.CatAnchoA = CInt(r.Cells(2).Value)
                            'cat.CatLargoA = CInt(r.Cells(3).Value)
                            'cat.CatCamtidadA = CInt(r.Cells(4).Value)
                            'cat.CatVolm3A = CDec(r.Cells(5).Value)
                            'cat.CatVolPtA = CDec(r.Cells(6).Value)

                            'If xPanel.Rows.Count > 34 And xPanel.Rows.Count < 69 Then 'llena columna B
                            '    cat.CatEspesorB = CInt(r.Cells(1).Value)
                            '    cat.CatAnchoB = CInt(r.Cells(2).Value)
                            '    cat.CatLargoB = CInt(r.Cells(3).Value)
                            '    cat.CatCamtidadB = CInt(r.Cells(4).Value)
                            '    cat.CatVolm3B = CDec(r.Cells(5).Value)
                            '    cat.CatVolPtB = CDec(r.Cells(6).Value)
                            'ElseIf xPanel.Rows.Count > 68 And xPanel.Rows.Count < 103 Then 'llena columna c
                            '    cat.CatEspesorC = CInt(r.Cells(1).Value)
                            '    cat.CatAnchoC = CInt(r.Cells(2).Value)
                            '    cat.CatLargoC = CInt(r.Cells(3).Value)
                            '    cat.CatCamtidadC = CInt(r.Cells(4).Value)
                            '    cat.CatVolm3C = CDec(r.Cells(5).Value)
                            '    cat.CatVolPtC = CDec(r.Cells(6).Value)
                            'ElseIf xPanel.Rows.Count > 102 And xPanel.Rows.Count < 137 Then
                            '    cat.CatEspesorD = CInt(r.Cells(1).Value)
                            '    cat.CatAnchoD = CInt(r.Cells(2).Value)
                            '    cat.CatLargoD = CInt(r.Cells(3).Value)
                            '    cat.CatCamtidadD = CInt(r.Cells(4).Value)
                            '    cat.CatVolm3D = CDec(r.Cells(5).Value)
                            '    cat.CatVolPtD = CDec(r.Cells(6).Value)
                            'End If
                            'cat.CatEstatus = 0

                            'If New cdDespacho_det().CatalogoReportAgregar(cat) = True Then ' agrega al catalo personalizado

                            'End If

                            If New cdDespacho_det().DetalleDespachoCatalogoAgregar(dp) = True Then
                                ' txProducto.Text = "Reg " & xPanel.Rows(x).ToString() & " Ok"
                                If RbCorrelativo.Checked = True Then
                                    Actualizado = New fxSamad().Actlote("Update formato04_rumas_det Set estatus=1 Where rowid=" & IdDetallePat & " And estatus = 0")
                                End If
                                If RbNgtf.Checked = True Then
                                    Actualizado = New fxSamad().Actlote("Update paquete_deta Set estatus=1 Where rowid=" & IdDetallePat & " And estatus = 0")
                                End If

                            End If

                        End If
                    Next
                    'LimpiarControles(True)
                    MostrarDatosRumasPaquetes()
                    'HabilitarControles(False)
                Else
                    If dgDetalle.PrimaryGrid.Rows.Count = 0 Then 'Verifica que no exista mas filas para despachar y actualiza el estatus de la ruma o paquete
                        If RbCorrelativo.Checked = True Then
                            MessageBox.Show("El Lote de Aserrio se ha despachado en su totalidad", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
                            'Actualizado = New fxSamad().Actlote("Update formato04_rumas Set estatus=1 Where rowid=" & IdDetallePat & " And estatus = 0")
                            Actualizado = New fxSamad().Actlote("Update formato04_rumas Set estatus=1 Where rumaid=" & CInt(TxCorrelativo.Text) & " And estatus = 0")
                        End If
                        If RbNgtf.Checked = True Then
                            MessageBox.Show("El Paquete se ha despachado en su totalidad", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
                            Dim dd As New samadEntities
                            Dim codigoactiva = dd.paquete.Where(Function(x) x.Numpaquete = TxCorrelativo.Text And x.Estatus = 1).Select(Function(y) y.RowId).FirstOrDefault()
                            Actualizado = New fxSamad().Actlote("Update paquete Set estatus=1 Where rowid=" & codigoactiva & " And estatus = 0")
                        End If
                    End If
                End If
            End If
            sw = True
            Me.Hide()
        Else 'Si es nuevo registro
            dt.Desd_Des_Id = xdespachoID
            dt.Desd_NroGtf = txtNroGtf.Text
            dt.Desd_EspecieId = xIdEspecie
            dt.Desd_Especie = TxNomComercial.Text
            dt.Desd_Codigo = TxCodigo.Text
            dt.Desd_Producto = TxNomProducto.Text
            dt.Desd_ClaseId = xidclasecomercial
            dt.Desd_ClaseC = TxClaseComercial.Text
            dt.Desd_Cantidad = TxCantidad.Text
            dt.Desd_TipoUnid = TxTipUnid.Text
            dt.Desd_Volm3 = TxVolm3.Text
            dt.Desd_VolPt = TxVolPt.Text
            If RbCorrelativo.Checked = True Then
                dt.Desd_RumaPaquete = 1
            End If
            If RbNgtf.Checked = True Then
                dt.Desd_RumaPaquete = 2
            End If
            If rbDespachoTotal.Checked = True Then
                dt.Desd_ParcialTotal = 1
            End If
            If RbDespachoParcial.Checked = True Then
                dt.Desd_ParcialTotal = 2
            End If

            ''''''asignar nuevos campos'''''''''''''
            dt.Desd_Sal_Volm3_80 = txtVolPorcSaldo.Text
            If xcontarreg1 = 0 Then
                dt.Desd_VolM3_GTFRec = txTotalM3.Text
            Else
                dt.Desd_VolM3_GTFRec = txTotalM3Saldo.Text
            End If

            dt.Desd_Ac_Volm3_CM = TxVolm3DesCom.Text
            dt.Desd_Ac_Volm3_RC = TxVolm3RecDesp.Text

            dt.Des_Estatu = 0

            If New cdDespacho_det().DespachoDetGrabar(dt, xExiste) = False Then
                MessageBox.Show("No se pudo completar el proceso de grabar", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim idpaquete As Integer = New cdDespacho_det().LastDespachoId()

            If rbDespachoTotal.Checked = True Then 'cuando el despacho es total.
                If dgDetalle.PrimaryGrid.Rows.Count > 0 Then
                    Dim xPanel As GridPanel = dgDetalle.PrimaryGrid
                    Dim xRow As GridRow = Nothing
                    Dim IdDetallePat As Integer

                    For Each r As GridRow In xPanel.Rows ' recorre las filas de la grilla e inserta en la tabla dspacho_catalogo
                        Dim dp As New SAMAD.despacho_catalogo
                        Dim cat As New SAMAD.catalogodespachoreport
                        Dim ct As New samadEntities
                        Dim idespecie = ct.especies.Where(Function(x) x.Espe_NombreComun = TxNomComercial.Text).Select(Function(b) b.Espe_Id).FirstOrDefault()


                        IdDetallePat = CInt(r.Cells(0).Value)
                        dp.Cat_Des_Id = idpaquete
                        dp.Cat_Espesor = CDec(r.Cells(1).Value)
                        dp.Cat_Ancho = CDec(r.Cells(2).Value)
                        dp.Cat_Largo = CDec(r.Cells(3).Value)
                        dp.Cat_Cantidad = CDec(r.Cells(4).Value)
                        dp.Cat_Volm3 = CDec(r.Cells(5).Value)
                        dp.Cat_VolPT = CDec(r.Cells(6).Value)
                        dp.Cat_Estatus = 0

                        'cat.CatDeDtsId = idpaquete
                        'cat.CatDesId = xdespachoID
                        'cat.CatIdEspecie = idespecie
                        'cat.CatEspecie = TxNomComercial.Text

                        ''llena columna A
                        ''Dim operacion As Integer
                        ''operacion = 34 - xPanel.Rows.Count
                        ''Do While xPanel.Rows.Count < 35
                        'cat.CatEspesorA = CInt(r.Cells(1).Value)
                        'cat.CatAnchoA = CInt(r.Cells(2).Value)
                        'cat.CatLargoA = CInt(r.Cells(3).Value)
                        'cat.CatCamtidadA = CInt(r.Cells(4).Value)
                        'cat.CatVolm3A = CDec(r.Cells(5).Value)
                        'cat.CatVolPtA = CDec(r.Cells(6).Value)
                        ''Loop
                        'If xPanel.Rows.Count > 34 And r.Rows.Count < 69 Then 'llena columna B
                        '    cat.CatEspesorB = CInt(r.Cells(1).Value)
                        '    cat.CatAnchoB = CInt(r.Cells(2).Value)
                        '    cat.CatLargoB = CInt(r.Cells(3).Value)
                        '    cat.CatCamtidadB = CInt(r.Cells(4).Value)
                        '    cat.CatVolm3B = CDec(r.Cells(5).Value)
                        '    cat.CatVolPtB = CDec(r.Cells(6).Value)
                        'ElseIf xPanel.Rows.Count > 68 And r.Rows.Count < 103 Then 'llena columna B
                        '    cat.CatEspesorC = CInt(r.Cells(1).Value)
                        '    cat.CatAnchoC = CInt(r.Cells(2).Value)
                        '    cat.CatLargoC = CInt(r.Cells(3).Value)
                        '    cat.CatCamtidadC = CInt(r.Cells(4).Value)
                        '    cat.CatVolm3C = CDec(r.Cells(5).Value)
                        '    cat.CatVolPtC = CDec(r.Cells(6).Value)
                        'ElseIf xPanel.Rows.Count > 102 And xPanel.Rows.Count < 137 Then
                        '    cat.CatEspesorD = CInt(r.Cells(1).Value)
                        '    cat.CatAnchoD = CInt(r.Cells(2).Value)
                        '    cat.CatLargoD = CInt(r.Cells(3).Value)
                        '    cat.CatCamtidadD = CInt(r.Cells(4).Value)
                        '    cat.CatVolm3D = CDec(r.Cells(5).Value)
                        '    cat.CatVolPtD = CDec(r.Cells(6).Value)
                        'End If
                        'cat.CatEstatus = 0

                        'If New cdDespacho_det().CatalogoReportAgregar(cat) = True Then

                        'End If
                        If New cdDespacho_det().DetalleDespachoCatalogoAgregar(dp) = True Then
                            ' txProducto.Text = "Reg " & xPanel.Rows(x).ToString() & " Ok"
                            If RbCorrelativo.Checked = True Then
                                Actualizado = New fxSamad().Actlote("Update formato04_rumas_det Set estatus=1 Where rowid=" & IdDetallePat & " And estatus = 0")
                                'Actualizado = New fxSamad().Actlote("Update formato04_rumas Set estatus=1 Where rowid=" & xdespachoID & " And estatus = 0")
                            End If
                            If RbNgtf.Checked = True Then
                                Actualizado = New fxSamad().Actlote("Update paquete_deta Set estatus=1 Where rowid=" & IdDetallePat & " And estatus = 0")
                                'Actualizado = New fxSamad().Actlote("Update paquete Set estatus=1 Where rowid=" & xdespachoID & " And estatus = 0")
                            End If
                        End If
                    Next
                    'LimpiarControles()
                    If RbCorrelativo.Checked = True Then
                        'Actualizado = New fxSamad().Actlote("Update formato04_rumas_det Set estatus=1 Where rowid=" & IdDetallePat & " And estatus = 0")
                        Actualizado = New fxSamad().Actlote("Update formato04_rumas Set estatus=1 Where rumaid=" & CInt(TxCorrelativo.Text) & " And estatus = 0")
                    End If
                    If RbNgtf.Checked = True Then
                        Dim de As New samadEntities
                        Dim codigoactiva = de.paquete.Where(Function(x) x.Numpaquete = TxCorrelativo.Text And x.Estatus = 1).Select(Function(y) y.RowId).FirstOrDefault()
                        Actualizado = New fxSamad().Actlote("Update paquete Set estatus=1 Where rowid=" & codigoactiva & " And estatus = 0")
                    End If
                    LimpiarControles()
                    llenarVolumenInicial()
                    'MostrarDatosRumasPaquetes()
                    'HabilitarControles(False)
                End If
            End If
            If RbDespachoParcial.Checked = True Then
                If dgDetalle.GetSelectedRows.Count > 0 Then
                    Dim xPanel As GridPanel = dgDetalle.PrimaryGrid
                    Dim xRow As GridRow = Nothing

                    ''For Each oRow As GridRow In dgDetalle.PrimaryGrid.Rows

                    For Each r As GridRow In xPanel.Rows
                        Dim dp As New SAMAD.despacho_catalogo
                        If r.IsSelected = True Then

                            Dim cat As New SAMAD.catalogodespachoreport
                            Dim ct As New samadEntities
                            Dim idespecie = ct.especies.Where(Function(x) x.Espe_NombreComun = TxNomComercial.Text).Select(Function(b) b.Espe_Id).FirstOrDefault()


                            IdDetallePat = CInt(r.Cells(0).Value)
                            dp.Cat_Des_Id = idpaquete
                            dp.Cat_Espesor = CDec(r.Cells(1).Value)
                            dp.Cat_Ancho = CDec(r.Cells(2).Value)
                            dp.Cat_Largo = CDec(r.Cells(3).Value)
                            dp.Cat_Cantidad = CDec(r.Cells(4).Value)
                            dp.Cat_Volm3 = CDec(r.Cells(5).Value)
                            dp.Cat_VolPT = CDec(r.Cells(6).Value)
                            dp.Cat_Estatus = 0

                            'cat.CatDeDtsId = idpaquete
                            'cat.CatDesId = xdespachoID
                            'cat.CatIdEspecie = idespecie
                            'cat.CatEspecie = TxNomComercial.Text

                            ''llena columna A
                            'cat.CatEspesorA = CInt(r.Cells(1).Value)
                            'cat.CatAnchoA = CInt(r.Cells(2).Value)
                            'cat.CatLargoA = CInt(r.Cells(3).Value)
                            'cat.CatCamtidadA = CInt(r.Cells(4).Value)
                            'cat.CatVolm3A = CDec(r.Cells(5).Value)
                            'cat.CatVolPtA = CDec(r.Cells(6).Value)

                            'If xPanel.Rows.Count > 34 And xPanel.Rows.Count < 69 Then 'llena columna B
                            '    cat.CatEspesorB = CInt(r.Cells(1).Value)
                            '    cat.CatAnchoB = CInt(r.Cells(2).Value)
                            '    cat.CatLargoB = CInt(r.Cells(3).Value)
                            '    cat.CatCamtidadB = CInt(r.Cells(4).Value)
                            '    cat.CatVolm3B = CDec(r.Cells(5).Value)
                            '    cat.CatVolPtB = CDec(r.Cells(6).Value)
                            'ElseIf xPanel.Rows.Count > 68 And xPanel.Rows.Count < 103 Then 'llena columna c
                            '    cat.CatEspesorC = CInt(r.Cells(1).Value)
                            '    cat.CatAnchoC = CInt(r.Cells(2).Value)
                            '    cat.CatLargoC = CInt(r.Cells(3).Value)
                            '    cat.CatCamtidadC = CInt(r.Cells(4).Value)
                            '    cat.CatVolm3C = CDec(r.Cells(5).Value)
                            '    cat.CatVolPtC = CDec(r.Cells(6).Value)
                            'ElseIf xPanel.Rows.Count > 102 And xPanel.Rows.Count < 137 Then
                            '    cat.CatEspesorD = CInt(r.Cells(1).Value)
                            '    cat.CatAnchoD = CInt(r.Cells(2).Value)
                            '    cat.CatLargoD = CInt(r.Cells(3).Value)
                            '    cat.CatCamtidadD = CInt(r.Cells(4).Value)
                            '    cat.CatVolm3D = CDec(r.Cells(5).Value)
                            '    cat.CatVolPtD = CDec(r.Cells(6).Value)
                            'End If
                            'cat.CatEstatus = 0

                            'If New cdDespacho_det().CatalogoReportAgregar(cat) = True Then

                            'End If
                            If New cdDespacho_det().DetalleDespachoCatalogoAgregar(dp) = True Then
                                ' txProducto.Text = "Reg " & xPanel.Rows(x).ToString() & " Ok"
                                If RbCorrelativo.Checked = True Then
                                    Actualizado = New fxSamad().Actlote("Update formato04_rumas_det Set estatus=1 Where rowid=" & IdDetallePat & " And estatus = 0")
                                End If
                                If RbNgtf.Checked = True Then
                                    Actualizado = New fxSamad().Actlote("Update paquete_deta Set estatus=1 Where rowid=" & IdDetallePat & " And estatus = 0")
                                End If

                            End If

                        End If
                    Next
                    'LimpiarControles(True)
                    MostrarDatosRumasPaquetes()
                    'HabilitarControles(False)
                Else
                    If dgDetalle.PrimaryGrid.Rows.Count = 0 Then 'Verifica que no exista mas filas para despachar y actualiza el estatus de la ruma o paquete
                        If RbCorrelativo.Checked = True Then
                            MessageBox.Show("El Lote de Aserrio se ha despachado en su totalidad", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
                            'Actualizado = New fxSamad().Actlote("Update formato04_rumas Set estatus=1 Where rowid=" & IdDetallePat & " And estatus = 0")
                            Actualizado = New fxSamad().Actlote("Update formato04_rumas Set estatus=1 Where rumaid=" & CInt(TxCorrelativo.Text) & " And estatus = 0")
                        End If
                        If RbNgtf.Checked = True Then
                            MessageBox.Show("El Paquete se ha despachado en su totalidad", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
                            'Actualizado = New fxSamad().Actlote("Update paquete Set estatus=1 Where rowid=" & IdDetallePat & " And estatus = 0")
                            Dim dj As New samadEntities
                            Dim codigoactiva = dj.paquete.Where(Function(x) x.Numpaquete = TxCorrelativo.Text And x.Estatus = 1).Select(Function(y) y.RowId).FirstOrDefault()
                            Actualizado = New fxSamad().Actlote("Update paquete Set estatus=1 Where rowid=" & codigoactiva & " And estatus = 0")

                        End If
                    End If
                End If
            End If
            llenarVolumenInicial()
            LimpiarControles()
        End If
    End Sub
    Private Sub LimpiarControles()
        TxCodigo.Clear()
        TxNomComercial.Clear()
        TxNomProducto.Clear()
        TxCorrelativo.Clear()
        TxCantidad.Clear()
        TxClaseComercial.Clear()
        TxTipUnid.Clear()
        TxVolm3.Clear()
        TxVolPt.Clear()
        dgDetalle.PrimaryGrid.Rows.Clear()

        'Dim xPanel As GridPanel = dgDetalle.PrimaryGrid
        'Dim xRow As GridRow = Nothing
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        sw = False
        Me.Hide()
    End Sub
    Private Sub btnEspecie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Enviamos los datos de la consulta sql
        If txtNroGtf.Text <> "" Then
            frmLista.titulo = "GTF N° " + txtNroGtf.Text + " (" + frmDespacho.txt_Con_Titular.Text + ")"
            frmLista.t_tabla = "listatrozasd"
            frmLista.t_campos = "ltd_especie,count(ltd_especie) as trozas,sum(ltd_vol_m3) as volm3"
            frmLista.t_donde = String.Format("ltd_lt_id = {0}", txtNroGtfId.Text)
            frmLista.t_agruparpor = "ltd_especie"
            frmLista.t_ordenarpor = ""

            'Enviamos los formatosy tiulos de las columnas en un Array
            Dim titulos() As String = {"Especie", "Trozas", "Volm3"}
            Dim anchos() As Integer = {120, 50, 50}
            Dim alineacion() As String = {"Left", "Center", "Center"} 'Arreglo para las alineaciones

            ReDim frmLista.matAnchos(anchos.Length)
            ReDim frmLista.matTitulos(titulos.Length)
            ReDim frmLista.matColumnas(titulos.Length)
            ReDim frmLista.matAlineacion(titulos.Length)

            titulos.CopyTo(frmLista.matTitulos, 0)
            anchos.CopyTo(frmLista.matAnchos, 0)
            alineacion.CopyTo(frmLista.matAlineacion, 0)

            frmLista.ShowDialog(Me)

            'Datos a relacionar
            If frmLista.flag = True Then
                '  txt_Especie_Nombre.Text = frmLista.matColumnas(0)
            End If
        Else
            MessageBox.Show("Lo siento, debe seleccionar la GFT, antes de seleccionar la especie...", "Mensaje")
        End If
    End Sub

    Private Sub txtVolm3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            'If txtVolm3.Text = CChar("") Then
            '    txtVolm3.Text = "0"
            'Else
            '    txtVolm3.Text = Format(txtVolm3.Text * 1, "#0.000")
            'End If
            SendKeys.Send("{TAB}")
        End If

        ' "0123456789.-" Valores o caracteres que solo aceptara el TextBox
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub

    Private Sub btnGtf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGtf.Click
        'Enviamos los datos de la consulta sql
        frm.titulo = "TITULAR : " + frmDespacho.txt_Con_Titular.Text
        frm.t_tabla = "vmostrar_titulares_aserrio"
        frm.t_campos = "titularid,GTF,titular,contratoID,contrato,departamento,provincia,distrito,ruc"
        'frm.t_campos = "lt_titular_id,pro_titular,con_descripcion,departamento,provincia,distrito,pro_sector,con_id,titular_ruc,lt_deffs"
        frm.t_donde = ""
        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array

        'Dim titulos() As String = {"Id", "Titular", "Contrato", "Departamento", "Provincia", "Distrito", "Sector", "contratoid", "Ruc", "Deffs"}
        Dim titulos() As String = {"Id", "GTF", "Titular", "ContratoID", "Contrato", "Departamento", "Provincia", "Distrito", "Ruc"}
        Dim anchos() As Integer = {30, 280, 120, 0, 0, 0, 0, 0, 0, 0}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)
        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)
        frm.ShowDialog(Me)
        'Datos a relacionar
        If frm.flag = True Then

            txtNroGtf.Text = frm.matColumnas(1)
            txtNroGtfId.Text = frm.matColumnas(0)
            ContratoId = frm.matColumnas(1)

            Dim dm As New samadEntities

            cboEspecieGTF.DataSource = (From f02 In dm.formato02 From f02d In dm.formato02_det
                                        Where f02d.F02d_F02_Id = f02.F02_Id And f02d.F02d_GTF = ContratoId Select f02d.F02d_Especie).Distinct().ToList()
            cboEspecieGTF.SelectedItem = Nothing
            txTotalM3.Text = ""
            txTotalM3Saldo.Text = ""
            Tx_Vol28.Text = ""
            Tx_Vol52.Text = ""
            txSaldoComercial.Text = ""
            txtSaldoRecuperacion.Text = ""
            TxSalGtfReg.Text = ""
            TxVolRecSaldo.Text = ""
            txtVolPorcSaldo.Text = ""
            Tx_Vol52Saldo.Text = ""
            Tx_Vol28Saldo.Text = ""
            TxVolm3DesCom.Text = ""
            TxVolm3RecDesp.Text = ""
            TxVolm3Com.Text = ""
            TxVolm3Rec.Text = ""
            grpDetalleLotePaquete.Enabled = False

        End If
    End Sub

    Public Sub llenarVolumenInicial()
        Dim dm As New samadEntities
        Dim valorclasecomer As String
        Dim com, com1 As Decimal
        Dim de As New samadEntities
        If (String.IsNullOrEmpty(cboEspecieGTF.Text)) = False Then

            Dim ValorCombo As String
            'Dim xVolumen3 As Decimal
            ValorCombo = cboEspecieGTF.Text

            'If xPanel.Rows.Count() > 0 Then

            'End If

         
            xVol_m3Recep = (From f01d In dm.vw_mostrar_formato01_det_recep
                         Where f01d.F01d_Especie = ValorCombo And f01d.nro_contrato = contratonro And f01d.Lt_Nrogtf = txtNroGtf.Text Select f01d.F01d_Vol_M3).Sum()

            xVolumen3 = (From f02d In dm.vw_mostrar_formato02_det_aserrio
                         Where f02d.F02d_Especie = ValorCombo And f02d.Con_Descripcion = contratonro And f02d.F02d_GTF = txtNroGtf.Text Select f02d.suma_volm3).First()
            txTotalM3.Text = xVolumen3.ToString("N3")
            xEspecieID = (From f02 In dm.formato02_det Where f02.F02d_Especie = ValorCombo Select f02.EspecieId).FirstOrDefault()
            grpDetalleLotePaquete.Enabled = True

            Dim dtvolm3 = New cdDespacho_det().TraerVolumenGTF(txtNroGtf.Text, ValorCombo, contratonro)
            ''txtVolm3Reg.Text = dtvolm3.ToString("N3")
            txtVolm3Reg.Text = dtvolm3.ToString()

            '''''''''''''CALCULA VOLUMEN TOTAL RECEPCIONADO EN PATIO DE LA INDUSTRIA'''''''''''''''''

            Dim dtvolrec = New cdDespacho_det().TraerVolRecepcion(txtNroGtf.Text, ValorCombo, contratonro)
            ''txtVolm3Reg.Text = dtvolm3.ToString("N3")
            txtVolrec.Text = dtvolrec.ToString("N3")

            ''''''''''''SALDO EN PATIO DE TROZAS DE LA INDUSTRIA''''
            Dim SaldRec = (dtvolrec - xVolumen3)
            TxVolRecSaldo.Text = SaldRec.ToString("N3")


            ''''''''''VOLUMEN DE TROZAS NO RECEPCIONADAS EN PATIO DE LA IND.''''''''
            Dim salgft = (dtvolm3 - dtvolrec)
            TxSalGtfReg.Text = salgft.ToString("N3")

            ''''''''''''CALCULA PORCETANJES DE RENDIMIENTO DE ACUERDO A LO ESTABLECIDO POR LA AUTORIDAD
            Dim porc = dtvolrec * 0.8
            txtVolPorc.Text = porc.ToString("N3")
            Tx_Vol52.Text = (dtvolrec * 0.52).ToString("N3")
            Tx_Vol28.Text = (dtvolrec * 0.28).ToString("N3")


            '''''''''''''CALCULANDO VOLUMEN TOTAL ASERRADO'''''''''''''''''''b

            Dim xTotalAserrCom = (From TProd In dm.vw_mostrar_aserrio_total_prod Where TProd.Especie = ValorCombo And TProd.Con_Descripcion = contratonro And TProd.F01d_Gtf = txtNroGtf.Text And TProd.Prod_ClasificacionId = 1 Select TProd.VolM3).Sum()
            Dim xTotalAserrRec = (From TProd In dm.vw_mostrar_aserrio_total_prod Where TProd.Especie = ValorCombo And TProd.Con_Descripcion = contratonro And TProd.F01d_Gtf = txtNroGtf.Text And TProd.Prod_ClasificacionId = 2 Select TProd.VolM3).Sum()

            'Dim xTotalAserrRec = dm.vw_mostrar_aserrio_total_prod Where(Function(c) c.especies = ValorCombo And c.Con_Descripcion = contratonro And b. = txtNroGtf.Text And b.Prod_ClasificacionId = 2).Select(Function(c) c.T_Vol_m3).FirstOrDefault()

            'IIf(From TProd In dm.vw_mostrar_produccion Where TProd.Especie = ValorCombo And TProd.Con_Descripcion = contratonro And TProd.F02d_GTF = txtNroGtf.Text And TProd.Prod_ClasificacionId = 2 Select TProd.T_Vol_m3)



            ''''''''''CALCULANDO VOLUMENES TOTALES DESPACHADO'''''''''
            valorclasecomer = TxClaseComercial.Text
            Dim xcontarreg1 = de.despacho_det.Where(Function(f) f.Desd_NroGtf = txtNroGtf.Text And f.Desd_Especie = ValorCombo).Select(Function(f) f.Desd_Des_Id).Count()


            Dim xVolAcumCom = dm.despacho_det.Where(Function(x) x.Desd_NroGtf = txtNroGtf.Text And x.Desd_Especie = ValorCombo And x.Desd_ClaseId = 1).Select(Function(e) e.Desd_Volm3).Sum()
            Dim xVolAcumRec = dm.despacho_det.Where(Function(x) x.Desd_NroGtf = txtNroGtf.Text And x.Desd_Especie = ValorCombo And x.Desd_ClaseId = 2).Select(Function(e) e.Desd_Volm3).Sum()

            ''''''''''''''''CALCULANDO VOLUMENES TOTALES DESPACHADO para modificar

            Dim xVolAcumComM = dm.despacho_det.Where(Function(x) x.Desd_NroGtf = txtNroGtf.Text And x.Desd_Especie = ValorCombo And x.Desd_ClaseId = 1 And x.Desd_Id <= xcodDespacho).Select(Function(e) e.Desd_Volm3).Sum()
            Dim xVolAcumRecM = dm.despacho_det.Where(Function(x) x.Desd_NroGtf = txtNroGtf.Text And x.Desd_Especie = ValorCombo And x.Desd_ClaseId = 2 And x.Desd_Id <= xcodDespacho).Select(Function(e) e.Desd_Volm3).Sum()


            ''''''''''''''''''''''CARGAMOS LOS VOLUMENES TOTAL ASERRADOS A LOS TEXTBOX''''''''''''
            If IsNothing(xTotalAserrCom) = True Then
                TxVolm3Com.Text = 0
            Else
                TxVolm3Com.Text = CDec(xTotalAserrCom).ToString("N3")
            End If

            If IsNothing(xTotalAserrRec) = True Then
                TxVolm3Rec.Text = 0
            Else
                TxVolm3Rec.Text = CDec(xTotalAserrRec).ToString("N3")
            End If

            '''''''''''CARGAMOS LOS VOLUMENES ACUMULADOS DESPACHADOS''''''''''''''''''
            If xExiste = False Then
                If IsNothing(xVolAcumCom) = True Then
                    TxVolm3DesCom.Text = 0
                Else
                    TxVolm3DesCom.Text = CDec(xVolAcumCom).ToString("N3")
                End If

                If IsNothing(xVolAcumRec) = True Then
                    TxVolm3RecDesp.Text = 0
                Else
                    TxVolm3RecDesp.Text = CDec(xVolAcumRec).ToString("N3")
                End If


                ''''''''''''ASIGNA VALORES DE RENDIEMINTO Y CALCULA EL SALDO''''''''''''

                If xcontarreg1 > 0 Then
                    com = CDec(dtvolrec * 0.52).ToString("N3")
                    Tx_Vol52Saldo.Text = CDec(com - xVolAcumCom).ToString("N3")

                    com1 = CDec(dtvolrec * 0.28).ToString("N3")

                    If IsNothing(xVolAcumRec) = True Then
                        Tx_Vol28Saldo.Text = com1
                    Else
                        Tx_Vol28Saldo.Text = CDec(com1 - xVolAcumRec).ToString("N3")
                    End If


                Else

                    Tx_Vol52Saldo.Text = CDec(dtvolrec * 0.52).ToString("N3")
                    Tx_Vol28Saldo.Text = CDec(dtvolrec * 0.28).ToString("N3")

                End If

            Else

                If IsNothing(xVolAcumComM) = True Then
                    TxVolm3DesCom.Text = 0
                Else
                    TxVolm3DesCom.Text = CDec(xVolAcumComM).ToString("N3")
                End If

                If IsNothing(xVolAcumRecM) = True Then
                    TxVolm3RecDesp.Text = 0
                Else
                    TxVolm3RecDesp.Text = CDec(xVolAcumRecM).ToString("N3")
                End If


                ''''''''''''ASIGNA VALORES DE RENDIEMINTO Y CALCULA EL SALDO''''''''''''

                If xcontarreg1 > 0 Then
                    com = CDec(dtvolrec * 0.52).ToString("N3")
                    If IsNothing(xVolAcumComM) = True Then
                        Tx_Vol52Saldo.Text = 0
                    Else
                        Tx_Vol52Saldo.Text = CDec(com - xVolAcumComM).ToString("N3")
                    End If


                    com1 = CDec(dtvolrec * 0.28).ToString("N3")

                    If IsNothing(xVolAcumRecM) = True Then
                        Tx_Vol28Saldo.Text = com1
                    Else
                        Tx_Vol28Saldo.Text = CDec(com1 - xVolAcumRecM).ToString("N3")
                    End If


                Else

                    Tx_Vol52Saldo.Text = CDec(dtvolrec * 0.52).ToString("N3")
                    Tx_Vol28Saldo.Text = CDec(dtvolrec * 0.28).ToString("N3")

                End If

            End If
            '''''''''''CARGAMOS LOS SALDOS DE VOLUMENS POR DESPACHAR (STOCK EN PLANTA DE ASERRIO)'''''

            Dim xSaldoDescom = CDec((TxVolm3Com.Text) - CDec(TxVolm3DesCom.Text)).ToString("N3")
            Dim xSaldoDesrec = CDec((TxVolm3Rec.Text) - CDec(TxVolm3RecDesp.Text)).ToString("N3")

            If IsNothing(xSaldoDescom) = True Then
                txSaldoComercial.Text = 0
            Else
                txSaldoComercial.Text = xSaldoDescom
            End If

            If IsNothing(xSaldoDesrec) = True Then
                txtSaldoRecuperacion.Text = 0
            Else
                txtSaldoRecuperacion.Text = xSaldoDesrec
            End If

 

            ''''''''''''CALCULANDO SALDO DEL 80% ''''''''''''''''''''''
            Dim xSaldoPorc = CDec((TxVolm3DesCom.Text) + CDec(TxVolm3RecDesp.Text)).ToString("N3")
            Dim xTporcentaje = CDec(txtVolPorc.Text).ToString("N3")
            txtVolPorcSaldo.Text = (xTporcentaje - xSaldoPorc)

            ''''''''''''''''''SALDO DE VOLUMEN ASERRADO ROLLIZO MENOS PRODUCTO''''''''''''''''''''
            Dim xSaldoAserr = CDec((TxVolm3Com.Text) + CDec(TxVolm3Rec.Text)).ToString("N3")
            Dim xAserrTrozas = CDec(txTotalM3.Text).ToString("N3")
            txTotalM3Saldo.Text = (xAserrTrozas - xSaldoAserr)
        End If

    End Sub

    '''CARGAR COMBOBOXLIST''''''''''''''''
    Private Sub cargarespeciecontratoedit()
        Dim dm As New samadEntities

        cboEspecieGTF.DataSource = (From f02 In dm.formato02 From f02d In dm.formato02_det
                                    Where f02d.F02d_F02_Id = f02.F02_Id And f02d.F02d_GTF = txtNroGtf.Text Select f02d.F02d_Especie).Distinct().ToList()
        cboEspecieGTF.SelectedItem = Nothing
    End Sub

    Private Sub cboEspecieGTF_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboEspecieGTF.SelectedIndexChanged
        If cboEspecieGTF.Text.Length > 0 Then
            llenarVolumenInicial()
        Else
            txtVolm3Reg.Text = ""
            txtVolrec.Text = ""
            txtVolPorc.Text = ""
        End If
    End Sub

    Private Sub CalcularComerRecuper()
        Dim dm As New samadEntities
        Dim idclase As Integer
        Dim valorcombo, valorclasecomer As String
        'Dim xacumvalomdes As Decimal
        'Dim xacumvoltotal As Decimal

        If String.IsNullOrEmpty(TxClaseComercial.Text) = True Then
            MessageBox.Show("Deben existir datos para despachar")
            Exit Sub
        Else
            valorclasecomer = TxClaseComercial.Text

            If String.IsNullOrEmpty(cboEspecieGTF.Text) = True Then
                MessageBox.Show("No esta Seleccionada Ninguna Especie")
                Exit Sub
            Else
                valorcombo = cboEspecieGTF.Text
            End If

            idclase = dm.linea.Where(Function(x) x.Lin_Nombre = valorclasecomer).Select(Function(e) e.Lin_id).FirstOrDefault

            Dim verifcarexite = dm.despacho_det.Where(Function(x) x.Desd_NroGtf = txtNroGtf.Text And x.Desd_Especie = valorcombo And x.Desd_ClaseId = xidclasecomercial And x.Desd_Des_Id <= txtReg.Text).Select(Function(e) e.Desd_Volm3).Count()

            If verifcarexite > 0 Then

                xacumvalomdes = dm.despacho_det.Where(Function(x) x.Desd_NroGtf = txtNroGtf.Text And x.Desd_Especie = valorcombo And x.Desd_ClaseId = xidclasecomercial And x.Desd_Des_Id <= txtReg.Text).Select(Function(e) e.Desd_Volm3).Sum()
                xacumvoltotal = dm.despacho_det.Where(Function(x) x.Desd_NroGtf = txtNroGtf.Text And x.Desd_Especie = valorcombo And x.Desd_ClaseId = xidclasecomercial).Select(Function(e) e.Desd_Volm3).Sum()


            End If

            'If (idclase = xidclasecomercial) Then
            '    Select Case xRendimientoFactor
            '        Case 52
            '            xresulVolCome = (CDec(txTotalM3.Text) - CDec(TxVolm3.Text))
            '            txSaldoComercial.Text = xresulVolCome.ToString("N3")
            '        Case 28
            '            xresulVolRecu = (CDec(txTotalM3.Text) - CDec(TxVolm3.Text))
            '            txSaldoComercial.Text = xresulVolCome.ToString("N3")
            '    End Select
            'End If
        End If

    End Sub
 
    Private Sub MostrarDatosRumasPaquetes()
        Dim dm As New samadEntities
        If RbCorrelativo.Checked = True Then

            Dim dt = New cdFormato04_rumas().GetNumeroRuma(CodigoRumaPaquete)
            xRendimientoFactor = dt.Prod_Rendimiento
            TxCodigo.Text = dt.Codigo_ruma
            xIdEspecie = dt.EspecieId
            TxNomComercial.Text = dt.Especie
            TxNomProducto.Text = dt.Prod_NomProducto
            TxClaseComercial.Text = dt.Prod_ClasificacionCom
            TxCantidad.Text = dt.Cantidad
            TxTipUnid.Text = dt.TipUnidad
            TxVolm3.Text = dt.VolM3
            TxVolPt.Text = dt.VolPT
            xidclasecomercial = dt.Prod_ClasificacionId
            listaCodigoRumas = (From lc In dm.formato04_rumas_det Where lc.RumaId = CodigoRumaPaquete And lc.Estatus = 0).ToList()
            ListarAserriosRumas()
            CalcularComerRecuper()
        End If
        If RbNgtf.Checked = True Then

            Dim paquetId As Integer
            Dim dt = New cdPaquete_det().GetNumeroPaquete(CodigoRumaPaquete)
            xRendimientoFactor = dt.Prod_Rendimiento
            paquetId = dt.RowId
            TxCodigo.Text = dt.Numpaquete
            xIdEspecie = dt.EspecieId
            TxNomComercial.Text = dt.Espe_NombreComun
            TxNomProducto.Text = dt.Prod_NomProducto
            xidclasecomercial = dt.Prod_ClasificacionId
            TxClaseComercial.Text = dt.Prod_ClasificacionCom
            TxCantidad.Text = dt.Canidad
            TxTipUnid.Text = dt.TipoUnidad
            TxVolm3.Text = dt.VolM3
            TxVolPt.Text = dt.VolPT

            listaCodigoPaquete = (From lc In dm.paquete_deta Where lc.PaqueteId = paquetId And lc.Estatus = 0).ToList()
            ListarPaquetesDet()
            CalcularComerRecuper()

        End If

    End Sub
    Public Sub ListarAserriosRumasPaquetesEdit()
        Dim xPanel As GridPanel = dgDetalle.PrimaryGrid
        Dim x As Long = 0
        Dim xTotalM3 As Decimal = 0
        Dim xRow As GridRow = Nothing
        xPanel.Rows.Clear()
        If listaCodigoRumasPaqueteEdit.Count > 0 Then
            For x = 0 To listaCodigoRumasPaqueteEdit.Count - 1
                xRow = New GridRow(listaCodigoRumasPaqueteEdit(x).Cat_Des_Id, listaCodigoRumasPaqueteEdit(x).Cat_Espesor, listaCodigoRumasPaqueteEdit(x).Cat_Ancho, listaCodigoRumasPaqueteEdit(x).Cat_Largo, listaCodigoRumasPaqueteEdit(x).Cat_Cantidad, listaCodigoRumasPaqueteEdit(x).Cat_Volm3, listaCodigoRumasPaqueteEdit(x).Cat_VolPT)
                xPanel.Rows.Add(xRow)
                'xTotalM3 = xTotalM3 + listaCodigoRumas(x).Vol_m3
            Next
        End If
        ' txCantrozas.Text = ListaTrozas.Count()
        ' txTotalM3.Text = xTotalM3
    End Sub

    Public Sub ListarPaquetesDet()
        Dim xPanel As GridPanel = dgDetalle.PrimaryGrid
        Dim x As Long = 0
        Dim xTotalM3 As Decimal = 0
        Dim xRow As GridRow = Nothing
        xPanel.Rows.Clear()
        If listaCodigoPaquete.Count > 0 Then
            For x = 0 To listaCodigoPaquete.Count - 1
                xRow = New GridRow(listaCodigoPaquete(x).RowId, listaCodigoPaquete(x).Espesor, listaCodigoPaquete(x).Ancho, listaCodigoPaquete(x).Largo, listaCodigoPaquete(x).Cantidad, listaCodigoPaquete(x).VolM3, listaCodigoPaquete(x).VolPT)
                xPanel.Rows.Add(xRow)
                'xTotalM3 = xTotalM3 + listaCodigoRumas(x).Vol_m3
            Next
        End If
        ' txCantrozas.Text = ListaTrozas.Count()
        ' txTotalM3.Text = xTotalM3
    End Sub

    Public Sub ListarAserriosRumas()
        Dim xPanel As GridPanel = dgDetalle.PrimaryGrid
        Dim x As Long = 0
        Dim xTotalM3 As Decimal = 0
        Dim xRow As GridRow = Nothing
        xPanel.Rows.Clear()
        If listaCodigoRumas.Count > 0 Then
            For x = 0 To listaCodigoRumas.Count - 1
                xRow = New GridRow(listaCodigoRumas(x).RowId, listaCodigoRumas(x).Espesor, listaCodigoRumas(x).Ancho, listaCodigoRumas(x).Largo, listaCodigoRumas(x).Cantidad, listaCodigoRumas(x).Vol_m3, listaCodigoRumas(x).Vol_pt)
                xPanel.Rows.Add(xRow)
                'xTotalM3 = xTotalM3 + listaCodigoRumas(x).Vol_m3
            Next
        End If
        ' txCantrozas.Text = ListaTrozas.Count()
        ' txTotalM3.Text = xTotalM3
    End Sub

    Private Sub RbCorrelativo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbCorrelativo.CheckedChanged
        If RbCorrelativo.Checked = True Then
            TxCorrelativo.Enabled = True
            TxCorrelativo.Focus()
        Else
            TxCorrelativo.Enabled = False
            TxCorrelativo.Clear()
            'TxCorrelativo.Focus()
            RbCorrelativo.Checked = False
        End If
    End Sub

    Private Sub RbNgtf_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbNgtf.CheckedChanged
        If RbNgtf.Checked = True Then
            TxCorrelativo.Enabled = True
            TxCorrelativo.Focus()
        Else
            TxCorrelativo.Enabled = False
            TxCorrelativo.Clear()
            RbNgtf.Checked = False
            'TxCorrelativo.Focus()
        End If
    End Sub

    Private Sub TxCorrelativo_CommandKeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxCorrelativo.CommandKeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                'TxCorrelativo()
            Case Keys.Tab, Keys.Enter
                e.Handled = True
                If String.IsNullOrEmpty(TxCorrelativo.Text) = True Then
                    MessageBox.Show("Por favor ingrese el Correlativo de Busqueda", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    TxCorrelativo.Focus()
                    Exit Sub
                End If
                If IsNumeric(TxCorrelativo.Text) = True Then
                    TxCorrelativo.Text = Microsoft.VisualBasic.Right("000000" + TxCorrelativo.Text, 6)
                End If
                If String.IsNullOrEmpty(cboEspecieGTF.Text) = False Then
                    If TxCorrelativo.Text <> "" Then
                        Dim tipocampox As String = ""
                        Dim xcampo As String = ""
                        xPeriodo = txtPeriodo.Text
                        Dim db As New samadEntities
                        If RbCorrelativo.Checked = True Then
                            If New cdFormato04_rumas().VerificaRumaDespachada(TxCorrelativo.Text, xPeriodo, cboEspecieGTF.Text) = False Then
                                'MessageBox.Show("Codigo de Aserrio  no existe", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                TxCorrelativo.Focus()
                                btnAceptar.Enabled = False
                                dgDetalle.PrimaryGrid.Rows.Clear()
                                Exit Sub
                            Else
                                btnAceptar.Enabled = True
                            End If
                            CodigoRumaPaquete = TxCorrelativo.Text
                            ClaseComercial = TxClaseComercial.Text
                            MostrarDatosRumasPaquetes()
                            dgDetalle.Select()
                            CalculaVolUtilizado()
                            'MostrarDatosTroza()
                            'btnAceptar.Enabled = True                        
                        End If
                        If RbNgtf.Checked = True Then
                            If New cdPaquete_det().VerificaPaqueteDespachado(TxCorrelativo.Text, xPeriodo, xEspecieID) = False Then  'cdPaquete_det().CodigoPaquete(TxCorrelativo.Text, xPeriodo, xEspecieID) = False Then
                                'MessageBox.Show("Codigo de Industria  no existe", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                TxCorrelativo.Focus()
                                btnAceptar.Enabled = False
                                dgDetalle.PrimaryGrid.Rows.Clear()
                                Exit Sub
                            Else
                                btnAceptar.Enabled = True
                            End If
                            CodigoRumaPaquete = TxCorrelativo.Text
                            MostrarDatosRumasPaquetes()
                            dgDetalle.Select()
                            'MostrarDatosTroza()
                            'btnAceptar.Enabled = True
                        End If
                    End If
                Else
                    MessageBox.Show("Debe Serleccionar una especie", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    cboEspecieGTF.Focus()
                    ' btnAceptar.Enabled = False
                End If
        End Select
    End Sub

    Private Sub dgDetalle_Click(sender As System.Object, e As System.EventArgs) Handles dgDetalle.Click
        Dim xPanel As GridPanel = dgDetalle.PrimaryGrid
        Dim volm3, volpt As Decimal
        Dim cantidad As Integer

        If dgDetalle.GetSelectedRows.Count > 0 Then
            ' txTrozaId.Text = ""
            xRow = xPanel.ActiveRow()

            If RbDespachoParcial.Checked = True Then
                For Each oRow As GridRow In dgDetalle.PrimaryGrid.Rows

                    If oRow.IsSelected = True Then

                        cantidad += oRow.Cells(4).Value
                        volm3 += oRow.Cells(5).Value
                        volpt += oRow.Cells(6).Value
                        'VerDatosTroza()
                        'SaveRecord()
                        'cantidadTotal += oRow.Cells(4).Value
                        'volm3Total += oRow.Cells(5).Value
                        'volpttotal += oRow.Cells(6).Value
                    End If

                Next
                txtCantGrid.Text = cantidad.ToString
                txtVolm3Grid.Text = volm3.ToString
                txtVolPTGrid.Text = volpt.ToString
                txtTipUniGrid.Text = TxTipUnid.Text
                'Actualiza datos resumen cabecera
                TxCantidad.Text = txtCantGrid.Text
                TxTipUnid.Text = txtTipUniGrid.Text
                TxVolm3.Text = txtVolm3Grid.Text
                TxVolPt.Text = txtVolPTGrid.Text

            End If

        End If
    End Sub

    Private Sub rbDespachoTotal_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles rbDespachoTotal.CheckedChanged
        If rbDespachoTotal.Checked = True Then
            dgDetalle.Enabled = False
            btnAceptar.Enabled = True
        Else
            rbDespachoTotal.Checked = False
            dgDetalle.Enabled = True
        End If
    End Sub

    Private Sub RbDespachoParcial_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbDespachoParcial.CheckedChanged
        If RbDespachoParcial.Checked = True Then
            dgDetalle.Enabled = True
            btnAceptar.Enabled = True
        Else
            RbDespachoParcial.Checked = False
            dgDetalle.Enabled = False
            txtCantGrid.Clear()
            txtVolm3Grid.Clear()
            txtVolPTGrid.Clear()
            txtTipUniGrid.Clear()
        End If
    End Sub

    Private Sub CalculaVolUtilizado()
        Dim valorcombo As String
        Dim valorclasecomer As String
        'Dim com, com1 As Decimal
        Dim de As New samadEntities

        valorcombo = cboEspecieGTF.Text
        valorclasecomer = TxClaseComercial.Text
        Dim xcontarreg = de.despacho_det.Where(Function(f) f.Desd_NroGtf = txtNroGtf.Text And f.Desd_Especie = valorcombo).Select(Function(f) f.Desd_Des_Id).Count()

        If xcontarreg > 0 Then
            If TxClaseComercial.Text = "ASERRIO COMERCIAL" Then
                'com = xVolumen3.ToString("N3")
               
                txSaldoComercial.Text = (Tx_Vol52.Text - xacumvoltotal).ToString("N3")
            Else
                'com = xVolumen3.ToString("N3")
                txtSaldoRecuperacion.Text = (Tx_Vol28.Text - xacumvoltotal).ToString("N3")
            End If
        Else
            If TxClaseComercial.Text = "ASERRIO COMERCIAL" Then
                'com = xVolumen3.ToString("N3")
                txSaldoComercial.Text = Tx_Vol52.Text
                'txtSaldoRecuperacion.Text = 0
            Else
                'com1 = xVolumen3.ToString("N3")
                txtSaldoRecuperacion.Text = Tx_Vol28.Text
                'txSaldoComercial.Text = 0
            End If
        End If

    End Sub
    Private Sub listarEncabecados()
        If lsHeader.Count() > 0 Then
            IdDespachoOri = lsHeader(recno).Desd_Id ' id de cabecera
            txtNroGtfId.Text = xcontratoid
            txtNroGtf.Text = lsHeader(recno).Desd_NroGtf
            cargarespeciecontratoedit()
            xIdEspecie = lsHeader(recno).Desd_EspecieId
            cboEspecieGTF.Text = lsHeader(recno).Desd_Especie
            TxCodigo.Text = lsHeader(recno).Desd_Codigo
            TxNomComercial.Text = lsHeader(recno).Desd_Especie
            TxNomProducto.Text = lsHeader(recno).Desd_Producto
            xidclasecomercial = lsHeader(recno).Desd_ClaseId
            TxClaseComercial.Text = lsHeader(recno).Desd_ClaseC
            TxCantidad.Text = lsHeader(recno).Desd_Cantidad
            TxTipUnid.Text = lsHeader(recno).Desd_TipoUnid
            TxVolm3.Text = lsHeader(recno).Desd_Volm3
            TxVolPt.Text = lsHeader(recno).Desd_VolPt
            If lsHeader(recno).Desd_RumaPaquete = 1 Then
                RbCorrelativo.Checked = True
                TxCorrelativo.Text = lsHeader(recno).Desd_Codigo
                'ListarAserriosRumas()
                xrumadespachoId = lsHeader(recno).Desd_Codigo
            Else
                RbNgtf.Checked = True
                TxCorrelativo.Text = lsHeader(recno).Desd_Codigo
                xrumadespachoId = lsHeader(recno).Desd_Codigo
                'ListarAserriosRumasPaquetesEdit()
            End If
            If lsHeader(recno).Desd_ParcialTotal = 1 Then
                rbDespachoTotal.Checked = True
            Else
                RbDespachoParcial.Checked = True
            End If
            Dim dm As New samadEntities
            listaCodigoRumasPaqueteEdit = (From lc In dm.despacho_catalogo Where lc.Cat_Des_Id = IdDespachoOri And lc.Cat_Estatus = 0).ToList()
            ListarAserriosRumasPaquetesEdit()
            'CbUtilizado.Text = lsHeader(recno).CMUtilizado
            'DatosRuma(lsHeader(recno).RumaId) 'rescata los datos de la ruma elegida para empaquetar
            'txTotalp.Text = lsHeader(recno).UtiCantidad
            'txTotalM3.Text = Format(lsHeader(recno).UtiVolM3, "##0.000")
            'txTotalpt.Text = Format(lsHeader(recno).UtiVolPt, "##0.000")
            ''btAcabado.Text = lsHeader(recno).Acabado
            ''btHumedad.Text = lsHeader(recno).Humedad
            'txtClasificacion.Text = lsHeader(recno).Clasificacion
            'txtVPT.Text = Format(lsHeader(recno).Volpt, "##0.000")
            ''txTotalp.Text = lsHeader(recno).
            'xprofinalId = lsHeader(recno).ProductoFinalId
            'xubicacionId = lsHeader(recno).Ubicacion
            'obtieneUbicacionYProductoFinal()
            'traeDatosProducto(xprofinalId)
            'xpaqueteId = lsHeader(recno).RowId
            'xAprovechable = CDec(txtVPT.Text) * (txProvecho.Value / 100)
            'lbProvecho.Text = xAprovechable
            'xIdPaquete = lsHeader(recno).RowId
            'txRecno.Text = recno + 1 & " de " & lsHeader.Count
            'ContarRumas() 'aqui genera el aprovechable
            'ListarDetallePaquete()
            'resumen_aserrio_lotes()
            'cargarconsumidobanda(lsHeader(recno).RumaId, lsHeader(recno).Numpaquete)
        End If

    End Sub
    Private Sub frmDespacho_det_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If xExiste = True Then
            lsHeader = New cdDespacho_det().VistaDespachoDet(xcodDespacho)
            listarEncabecados()
            btnAceptar.Enabled = True
        Else

        End If
    End Sub
End Class