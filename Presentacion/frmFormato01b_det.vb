Public Class frmFormato01b_det
    'Public Sw As Boolean
    'Public row As DataTable
    'Dim titulares As Boolean = True
    'Dim contratos As Boolean = False
    'Dim zafras As Boolean = False
    'Dim poas As Boolean = False
    'Public id, iddet, aserrio As Integer
    'Public periodo As String
    'Dim listadetalle As List(Of listatrozasd)
    'Public Event MiEvento(ByVal sender As Object, ByVal e As ItemEvents)
    'Dim frmgtf, frmTroza, frmTroza2 As New frmShowbrow

    'Dim xTitulo = fxSamad.Titulo

    'Private Sub AplicarPerfil()
    '    If vInfraestructura.Usuario.gtipo = "ADMINISTRADOR" Then

    '    Else
    '        GroupBox2.Enabled = False
    '    End If
    'End Sub

    'Private Sub btnGTF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Enviamos los datos de la consulta sql
    '    frmTroza.titulo = "Títular: " + frmgtf.matColumnas(1)
    '    frmTroza.t_tabla = "vmostrar_listatrozas"
    '    'frmTroza.t_campos = String.Format("lt_nrolista,count(lt_nrolista) as trozas,sum(ltd_vol_m3) as volm3,(Select count(*) from vmostrar_listatrozas Where ltd_autogenerado<>'' AND lt_titular_id = {0}) as usado", txtTitularId.Text)
    '    'frmTroza.t_donde = String.Format("lt_titular_id = {0}", txtTitularId.Text)
    '    frmTroza.t_agruparpor = "lt_nrolista"
    '    frmTroza.t_ordenarpor = ""

    '    'Enviamos los formatosy tiulos de las columnas en un Array
    '    Dim titulos() As String = {"Nro.GTF", "Tot.Trozas", "Vol.m3", "Tot.Recep."}
    '    Dim anchos() As Integer = {100, 80, 80, 80}
    '    Dim alineacion() As String = {"Left", "Center", "Center", "Center"}

    '    ReDim frmTroza.matAnchos(anchos.Length)
    '    ReDim frmTroza.matTitulos(titulos.Length)
    '    ReDim frmTroza.matColumnas(titulos.Length)
    '    ReDim frmTroza.matAlineacion(titulos.Length)
    '    titulos.CopyTo(frmTroza.matTitulos, 0)
    '    anchos.CopyTo(frmTroza.matAnchos, 0)
    '    alineacion.CopyTo(frmTroza.matAlineacion, 0)
    '    frmTroza.ShowDialog(Me)

    '    'Datos a relacionar
    '    If frmTroza.flag = True Then

    '        'txtNroGtf.Text = frmTroza.matColumnas(0)
    '        TxtTrozas.Text = frmTroza.matColumnas(1)
    '        txtVolm3.Text = frmTroza.matColumnas(2)

    '        Dim func As New fshowbrow
    '        Dim dtsr As New vShowbrow

    '        'Enviamos los datos de la consulta sql

    '        dtsr.gt_tabla = "vmostrar_listatrozasconnrolista"
    '        dtsr.gt_campos = "ltd_Id,lt_nrolista,ltd_especie,ltd_codificacion,ltd_d1,ltd_d2,ltd_d3,ltd_vol_m3,lt_titular_id,cut,ltd_especie as ltd_especiec,ltd_d1 as ltd_d1c,ltd_d2 as ltd_d2c,ltd_d3 as ltd_d3c,ltd_vol_m3 as ltd_vol_m3c"
    '        'dtsr.gt_donde = String.Format("lt_nrolista = '{0}' AND ((ltd_autogenerado IS NULL) OR (ltd_autogenerado ='')) AND lt_titular_id = {1}", txtNroGtf.Text, txtTitularId.Text)
    '        dtsr.gt_agruparpor = ""
    '        dtsr.gt_ordenarpor = ""

    '        row = func.mostrar(dtsr) 'Inv

    '        If row.Rows.Count <> 0 Then

    '            dataTransferir.DataSource = row

    '            dataTransferir.Columns(0).HeaderText = "Id"
    '            dataTransferir.Columns(1).HeaderText = "Nro.GTF"
    '            dataTransferir.Columns(2).HeaderText = "Especie"
    '            dataTransferir.Columns(3).HeaderText = "Código"
    '            dataTransferir.Columns(4).HeaderText = "D> (Mayor)"
    '            dataTransferir.Columns(5).HeaderText = "D< (Menor)"
    '            dataTransferir.Columns(6).HeaderText = "Largo"
    '            dataTransferir.Columns(7).HeaderText = "Volm3"
    '            dataTransferir.Columns(8).HeaderText = "Titular Id"
    '            dataTransferir.Columns(9).HeaderText = "Cut"

    '            dataTransferir.Columns(10).Visible = False
    '            dataTransferir.Columns(11).Visible = False
    '            dataTransferir.Columns(12).Visible = False
    '            dataTransferir.Columns(13).Visible = False
    '            dataTransferir.Columns(14).Visible = False

    '            dataTransferir.Columns(0).Width = 30
    '            dataTransferir.Columns(1).Width = 70
    '            dataTransferir.Columns(2).Width = 100
    '            dataTransferir.Columns(3).Width = 80
    '            dataTransferir.Columns(4).Width = 50
    '            dataTransferir.Columns(5).Width = 50
    '            dataTransferir.Columns(6).Width = 50
    '            dataTransferir.Columns(7).Width = 50
    '            dataTransferir.Columns(8).Width = 50
    '            dataTransferir.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    '            'Dim dr as DataRow
    '            'For Each dr In row.Rows
    '            '    MsgBox(dr("ltd_especie"))
    '            'Next
    '        Else
    '            dataTransferir.DataSource = Nothing
    '            MessageBox.Show("Estos registros ya fueron transferidos...!!!", "Mensaje")
    '        End If
    '    End If
    'End Sub

    'Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    '    Dim db As New samadEntities
    '    If btnAceptar.Text = "Agregar" Then
    '        If dataTransferir.Rows.Count <> 0 Then
    '            Sw = True
    '            Dim old = db.formato01_det.FirstOrDefault(Function(p) p.formato01.F01_Pro_id = aserrio And p.formato01.F01_periodo = periodo And p.F01d_CodIndustria = txtCodIndustria.Text)
    '            If Not old Is Nothing Then
    '                MessageBox.Show("El Código de industria ya existe para la empresa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Return
    '            End If
    '            Dim result As DialogResult
    '            result = MessageBox.Show("Esta seguro de GUARDAR el registro ?", "Guardar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
    '            If result = DialogResult.OK Then
    '                Try
    '                    If dataTransferir.SelectedRows.Count > 1 Then
    '                        noMedir.Checked = True
    '                        For Each row As DataGridViewRow In dataTransferir.SelectedRows
    '                            Dim dtse As New vFormato01_det
    '                            Dim funce As New fformato01_det

    '                            dtse.gf01d_f01_id = id
    '                            dtse.gf01d_especie = row.Cells.Item(2).Value
    '                            dtse.gf01d_especiec = row.Cells.Item(2).Value
    '                            dtse.gf01d_correlativo = row.Cells.Item(3).Value
    '                            dtse.gf01d_guiaremision = """"
    '                            dtse.gf01d_gtf = listadetalle.FirstOrDefault(Function(p) p.Ltd_Id = row.Cells.Item(1).Value).listatrozasc.Lt_NroLista
    '                            dtse.gf01d_placa = row.Cells.Item(3).Value
    '                            dtse.gf01d_d1 = row.Cells.Item(4).Value 'D1 GTF

    '                            dtse.gf01d_d2 = row.Cells.Item(5).Value 'D1 GTF

    '                            dtse.gf01d_d3 = row.Cells.Item(6).Value 'D1 GTF

    '                            dtse.gf01d_vol_m3 = row.Cells.Item(7).Value
    '                            dtse.gf01d_d1c = row.Cells.Item(4).Value
    '                            dtse.gf01d_d2c = row.Cells.Item(5).Value
    '                            dtse.gf01d_d3c = row.Cells.Item(6).Value
    '                            dtse.gf01d_vol_m3c = row.Cells.Item(7).Value
    '                            dtse.gf01d_tipo = "TERRESTRE"
    '                            dtse.gf01d_unidad = cbxUnidad.Text
    '                            dtse.fldLote = txLote.Text
    '                            dtse.fldOwner = txOwnerId.Text
    '                            ''autogenerado

    '                            Dim idTrozad As Integer = row.Cells.Item(1).Value
    '                            Dim trozaselecc As listatrozasd = db.listatrozasd.FirstOrDefault(Function(p) p.Ltd_Id = idTrozad)
    '                            Dim autogenerado As String = trozaselecc.listatrozasc.Lt_NroLista.ToString() + "." + trozaselecc.listatrozasc.Lt_Titular_Id.ToString() + "." + idTrozad.ToString()
    '                            dtse.gf01d_autogenerado = autogenerado

    '                            'Codigo para insertar registros
    '                            If funce.insertar(dtse) Then
    '                                Dim idd As Integer = row.Cells.Item(1).Value
    '                                Dim listainsertada As listatrozasd = db.listatrozasd.FirstOrDefault(Function(p) p.Ltd_Id = idd)
    '                                listainsertada.Ltd_Autogenerado = autogenerado
    '                                db.SaveChanges()
    '                                fauditoria.insertar("listatrozasd", "Editar", idd, "")
    '                                Dim listainsertadalocal As listatrozasd = listadetalle.FirstOrDefault(Function(p) p.Ltd_Id = idd)
    '                                listadetalle.Remove(listainsertadalocal)
    '                            Else
    '                                MessageBox.Show("Datos No fueron registrados, intente de nuevo!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                            End If

    '                            RaiseEvent MiEvento(Nothing, Nothing)
    '                        Next
    '                        MessageBox.Show("Datos guardados correctamente " + dataTransferir.SelectedRows.Count.ToString() + " Items...!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                        dataTransferir.DataSource = listadetalle.ToList()
    '                        listadetalle = dataTransferir.DataSource
    '                        TxtTrozas.Text = listadetalle.Count
    '                        txtVolm3.Text = listadetalle.Sum(Function(p) p.Ltd_Vol_M3)
    '                        registro_seleccionado()
    '                    Else
    '                        Dim dtse As New vFormato01_det
    '                        Dim funce As New fformato01_det

    '                        dtse.gf01d_f01_id = id
    '                        dtse.gf01d_especie = dataTransferir.SelectedCells.Item(2).Value
    '                        dtse.gf01d_especiec = txtEspecieCubicacion.Text
    '                        dtse.gf01d_correlativo = dataTransferir.SelectedCells.Item(3).Value
    '                        dtse.gf01d_guiaremision = """"
    '                        dtse.gf01d_gtf = listadetalle.FirstOrDefault(Function(p) p.Ltd_Id = dataTransferir.SelectedCells.Item(1).Value).listatrozasc.Lt_NroLista
    '                        dtse.gf01d_placa = txtCodIndustria.Text
    '                        dtse.gf01d_d1 = dataTransferir.SelectedCells.Item(4).Value 'D1 GTF
    '                        dtse.gf01d_d2 = dataTransferir.SelectedCells.Item(5).Value 'D1 GTF
    '                        dtse.gf01d_d3 = dataTransferir.SelectedCells.Item(6).Value 'D1 GTF
    '                        dtse.gf01d_vol_m3 = txtVolm3.Text
    '                        If Not noMedir.Checked Then
    '                            If String.IsNullOrEmpty(txtD1c.Text) Or String.IsNullOrEmpty(txtD2c.Text) Or String.IsNullOrEmpty(txtD3c.Text) Then
    '                                MessageBox.Show("Complete todos los campos...!", "Verificando", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                                Return
    '                            End If
    '                            dtse.gf01d_d1c = txtD1c.Text
    '                            dtse.gf01d_d2c = txtD2c.Text
    '                            dtse.gf01d_d3c = txtD3c.Text
    '                            dtse.gf01d_vol_m3c = txtVolm3c.Text
    '                        Else
    '                            dtse.gf01d_d1c = dataTransferir.SelectedCells.Item(4).Value 'D1 GTF
    '                            dtse.gf01d_d2c = dataTransferir.SelectedCells.Item(5).Value 'D1 GTF
    '                            dtse.gf01d_d3c = dataTransferir.SelectedCells.Item(6).Value 'D1 GTF
    '                            dtse.gf01d_vol_m3c = txtVol3.Text
    '                        End If


    '                        dtse.gf01d_ubicacion = txtUbicacion.Text
    '                        dtse.gf01d_observacion = txtObservacion.Text
    '                        dtse.gf01d_autogenerado = txtAutogenerado.Text
    '                        dtse.gf01d_veh_placa = txtVeh_Placa.Text
    '                        dtse.gf01d_conductor = txtConductor.Text
    '                        dtse.gf01d_procedencia = txtProcedencia.Text
    '                        dtse.gf01d_tipo = "TERRESTRE"
    '                        dtse.gf01d_unidad = cbxUnidad.Text
    '                        'Codigo para insertar registros
    '                        If funce.insertar(dtse) Then

    '                            MessageBox.Show("Datos guardados correctamente...!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                            Dim idd As Integer = dataTransferir.SelectedCells.Item(1).Value
    '                            Dim listainsertada As listatrozasd = db.listatrozasd.FirstOrDefault(Function(p) p.Ltd_Id = idd)
    '                            listainsertada.Ltd_Autogenerado = txtAutogenerado.Text
    '                            db.SaveChanges()
    '                            fauditoria.insertar("listatrozasd", "Editar", idd, "")
    '                            Dim listainsertadalocal As listatrozasd = listadetalle.FirstOrDefault(Function(p) p.Ltd_Id = idd)
    '                            listadetalle.Remove(listainsertadalocal)
    '                            dataTransferir.DataSource = listadetalle.ToList()

    '                            listadetalle = dataTransferir.DataSource
    '                            TxtTrozas.Text = listadetalle.Count
    '                            txtVolm3.Text = listadetalle.Sum(Function(p) p.Ltd_Vol_M3)
    '                            registro_seleccionado()

    '                        Else
    '                            MessageBox.Show("Datos No fueron registrados, intente de nuevo!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                        End If
    '                        RaiseEvent MiEvento(Nothing, Nothing)
    '                    End If

    '                Catch ex As Exception
    '                    MsgBox(ex.Message)
    '                End Try
    '            End If
    '        Else
    '            MessageBox.Show("No hay registros que transferir...!!", "Mensaje")
    '        End If
    '    Else
    '        ''edicion
    '        Sw = True
    '        Dim detalle = db.formato01_det.FirstOrDefault(Function(p) p.F01d_Id = iddet)
    '        detalle.F01d_CodIndustria = txtCodIndustria.Text
    '        detalle.F01d_Especie = txt_Especie_Nombre.Text
    '        detalle.F01d_D1 = txtD1.Text
    '        detalle.F01d_D2 = txtD2.Text
    '        detalle.F01d_D3 = txtD3.Text
    '        detalle.F01d_Vol_M3 = txtVol3.Text
    '        detalle.F01d_Especiec = txtEspecieCubicacion.Text
    '        detalle.F01d_D1c = txtD1c.Text
    '        detalle.F01d_D2c = txtD2c.Text
    '        detalle.F01d_D3c = txtD3c.Text
    '        detalle.F01d_Vol_M3c = txtVolm3c.Text
    '        detalle.F01d_Ubicacion = txtUbicacion.Text
    '        detalle.F01d_Observacion = txtObservacion.Text
    '        detalle.f01d_Veh_Placa = txtVeh_Placa.Text
    '        detalle.f01d_Conductor = txtConductor.Text
    '        detalle.F01d_Correlativo = txtCodificacion.Text
    '        detalle.F01d_Autogenerado = txtAutogenerado.Text
    '        detalle.F01d_Procedencia = txtProcedencia.Text
    '        detalle.F01d_Tipo = "TERRESTRE"
    '        detalle.F01d_unidad = cbxUnidad.Text
    '        db.SaveChanges()
    '        fauditoria.insertar("formato01_det", "Editar", iddet, "")
    '        MessageBox.Show("Datos guardados correctamente...!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Me.Hide()
    '    End If
    'End Sub

    'Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    '    Me.Hide()
    'End Sub

    'Private Sub btnVehPlaca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVehPlaca.Click
    '    Dim frmV As New frmShowbrow
    '    'Enviamos los datos de la consulta sql

    '    frmV.titulo = "Lista de Vehiculos"
    '    frmV.t_tabla = "vehiculos"
    '    frmV.t_campos = "veh_id,veh_placa,veh_marca"
    '    frmV.t_donde = ""
    '    frmV.t_agruparpor = ""
    '    frmV.t_ordenarpor = ""

    '    'Enviamos los formatosy tiulos de las columnas en un Array
    '    Dim titulos() As String = {"Id", "Placa", "Marca"}
    '    Dim anchos() As Integer = {50, 100, 60}

    '    ReDim frmV.matAnchos(anchos.Length)
    '    ReDim frmV.matTitulos(titulos.Length)
    '    ReDim frmV.matColumnas(titulos.Length)
    '    titulos.CopyTo(frmV.matTitulos, 0)
    '    anchos.CopyTo(frmV.matAnchos, 0)

    '    frmV.ShowDialog(Me)

    '    'Datos
    '    If frmV.flag = True Then
    '        txtVeh_Placa.Text = frmV.matColumnas(1)
    '    End If
    'End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Dim frmV As New frmShowbrow
    '    'Enviamos los datos de la consulta sql

    '    frmV.titulo = "Conductores"
    '    frmV.t_tabla = "conductores"
    '    frmV.t_campos = "con_id,con_nomape,con_nrolicencia,con_dni"
    '    frmV.t_donde = ""
    '    frmV.t_agruparpor = ""
    '    frmV.t_ordenarpor = ""

    '    'Enviamos los formatosy tiulos de las columnas en un Array
    '    Dim titulos() As String = {"Id", "Conductor", "Licencia", "Dni"}
    '    Dim anchos() As Integer = {30, 180, 90, 60}

    '    ReDim frmV.matAnchos(anchos.Length)
    '    ReDim frmV.matTitulos(titulos.Length)
    '    ReDim frmV.matColumnas(titulos.Length)
    '    titulos.CopyTo(frmV.matTitulos, 0)
    '    anchos.CopyTo(frmV.matAnchos, 0)

    '    frmV.ShowDialog(Me)

    '    'Datos
    '    If frmV.flag = True Then
    '        txtConductor.Text = frmV.matColumnas(1)
    '    End If
    'End Sub

    'Private Sub lblTitular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frmTitular As New frmTitulares
    '    frmTitular.ShowDialog(Me)
    'End Sub

    'Private Sub lblVehiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblVehiculo.Click
    '    Dim frmVehiculo As New frmVehiculos
    '    frmVehiculo.ShowDialog(Me)
    'End Sub

    'Private Sub lblConductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblConductor.Click
    '    Dim frmConductor As New frmConductores
    '    frmConductor.ShowDialog(Me)
    'End Sub

    'Private Sub dataTransferir_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataTransferir.CellClick
    '    registro_seleccionado()
    'End Sub

    'Private Sub frmFormato01b_det_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    '    Dim db As New samadEntities
    '    ContratoComboBox.DataSource = (From c In db.contratos From t In db.titulares Where c.Con_Pro_Id = t.Pro_Id
    '                                Select New With {.id = c.Con_id, .titular = t.Pro_Titular + " (" + c.Con_Descripcion + ")"}).ToList()

    '    ContratoComboBox.SelectedItem = Nothing
    '    medirRB.Checked = True

    '    If btnAceptar.Text = "Guardar" Then
    '        Dim detalle = db.formato01_det.FirstOrDefault(Function(p) p.F01d_Id = iddet)
    '        txtCodIndustria.Text = detalle.F01d_Placa
    '        txt_Especie_Nombre.Text = detalle.F01d_Especie
    '        txtD1.Text = detalle.F01d_D1
    '        txtD2.Text = detalle.F01d_D2
    '        txtD3.Text = detalle.F01d_D3
    '        txtVol3.Text = detalle.F01d_Vol_M3
    '        txtEspecieCubicacion.Text = detalle.F01d_Especiec
    '        txtD1c.Text = detalle.F01d_D1c
    '        txtD2c.Text = detalle.F01d_D2c
    '        txtD3c.Text = detalle.F01d_D3c
    '        txtVolm3c.Text = detalle.F01d_Vol_M3c
    '        txtUbicacion.Text = detalle.F01d_Ubicacion 'Ubicación
    '        txtObservacion.Text = detalle.F01d_Observacion
    '        txtVeh_Placa.Text = detalle.f01d_Veh_Placa
    '        txtConductor.Text = detalle.f01d_Conductor
    '        txtCodificacion.Text = detalle.F01d_Correlativo
    '        txtAutogenerado.Text = detalle.F01d_Autogenerado
    '        txtProcedencia.Text = detalle.F01d_Procedencia
    '        txtD1c.Enabled = True
    '        txtD2c.Enabled = True
    '        txtD3c.Enabled = True

    '        cbxUnidad.Enabled = True
    '        cbxUnidad.Text = detalle.F01d_unidad
    '        TxtTrozas.Enabled = False
    '        txtVolm3.Enabled = False
    '    End If
    '    db = Nothing
    '    'AplicarPerfil()
    'End Sub

    'Private Sub registro_seleccionado()
    '    Dim db As New samadEntities
    '    If dataTransferir.Rows.Count <> 0 Then
    '        txt_Especie_Nombre.Text = dataTransferir.SelectedCells.Item(2).Value 'Especie GTF
    '        txtCodificacion.Text = dataTransferir.SelectedCells.Item(3).Value 'Correlativo
    '        txtD1.Text = dataTransferir.SelectedCells.Item(4).Value 'D1 GTF
    '        txtD2.Text = dataTransferir.SelectedCells.Item(5).Value 'D2 GTF
    '        txtD3.Text = dataTransferir.SelectedCells.Item(6).Value 'D3 GTF 
    '        txtVol3.Text = dataTransferir.SelectedCells.Item(7).Value 'Volm3 GTF
    '        Dim ltx = New fformato01_det().DatosTroza(txtCodificacion.Text)
    '        txOwnerId.Text = ltx.PropietarioId
    '        txOwner.Text = ltx.Nombre_propietario
    '        If medirRB.Checked Then

    '            txtD1c.Text = ""
    '            txtD2c.Text = ""
    '            txtD3c.Text = ""
    '            txtVolm3c.Text = ""
    '            txtEspecieCubicacion.Text = dataTransferir.SelectedCells.Item(2).Value 'Especie GTF
    '            txtCodIndustria.Text = ""
    '            txtAutogenerado.Text = ""

    '            ''autogenerado

    '            Dim idTrozad As Integer = dataTransferir.SelectedCells.Item(1).Value
    '            Dim trozaselecc As listatrozasd = db.listatrozasd.FirstOrDefault(Function(p) p.Ltd_Id = idTrozad)
    '            Dim autogenerado As String
    '            autogenerado = trozaselecc.listatrozasc.Lt_NroLista.ToString() + "." + trozaselecc.listatrozasc.Lt_Titular_Id.ToString() + "." + idTrozad.ToString()
    '            txtAutogenerado.Text = autogenerado

    '            ''correlativo

    '            Dim Ultimatroza As formato01_det = db.formato01_det.Where(Function(p) p.F01d_F01_Id = id).OrderByDescending(Function(p) p.F01d_Id).FirstOrDefault()

    '            If Not Ultimatroza Is Nothing Then
    '                If Not String.IsNullOrEmpty(Ultimatroza.F01d_Placa) Then
    '                    Try
    '                        txtCodIndustria.Text = (Integer.Parse(Ultimatroza.F01d_Placa) + 1).ToString().PadLeft(3, "0"c)
    '                    Catch ex As Exception
    '                        txtCodIndustria.Text = ""
    '                    End Try

    '                Else
    '                    txtCodIndustria.Text = ""
    '                End If
    '            Else
    '                txtCodIndustria.Text = ""
    '            End If

    '            cbxUnidad.Enabled = True
    '            txtD1c.Enabled = True
    '            txtD2c.Enabled = True
    '            txtD3c.Enabled = True

    '            txtEspecieCubicacion.Enabled = True
    '            txtCodIndustria.Enabled = True
    '            txtAutogenerado.Enabled = False
    '            If cbxUnidad.Text = "" Then
    '                cbxUnidad.Text = "Smalian"
    '            End If
    '            SeleccionUnidad()
    '            txtCodIndustria.Focus()

    '        End If

    '        If noMedir.Checked Then
    '            txtEspecieCubicacion.Text = dataTransferir.SelectedCells.Item(2).Value 'Especie GTF
    '            txtD1c.Text = dataTransferir.SelectedCells.Item(4).Value 'D1 GTF
    '            txtD2c.Text = dataTransferir.SelectedCells.Item(5).Value 'D2 GTF
    '            txtD3c.Text = dataTransferir.SelectedCells.Item(6).Value 'D3 GTF 
    '            txtVolm3c.Text = dataTransferir.SelectedCells.Item(7).Value 'Volm3 GTF
    '            ''autogenerado

    '            Dim idTrozad As Integer = dataTransferir.SelectedCells.Item(1).Value
    '            Dim trozaselecc As listatrozasd = db.listatrozasd.FirstOrDefault(Function(p) p.Ltd_Id = idTrozad)
    '            Dim autogenerado As String
    '            autogenerado = trozaselecc.listatrozasc.Lt_NroLista.ToString() + "." + trozaselecc.listatrozasc.Lt_Titular_Id.ToString() + "." + idTrozad.ToString()
    '            txtAutogenerado.Text = autogenerado

    '            ''correlativo

    '            Dim Ultimatroza As formato01_det = db.formato01_det.Where(Function(p) p.F01d_F01_Id = id).OrderByDescending(Function(p) p.F01d_Id).FirstOrDefault()

    '            If Not Ultimatroza Is Nothing Then
    '                If Not String.IsNullOrEmpty(Ultimatroza.F01d_CodIndustria) And Not Ultimatroza.F01d_CodIndustria.Contains("-") Then
    '                    txtCodIndustria.Text = (Integer.Parse(Ultimatroza.F01d_CodIndustria) + 1).ToString().PadLeft(3, "0"c)
    '                Else
    '                    txtCodIndustria.Text = ""
    '                End If
    '            Else
    '                txtCodIndustria.Text = ""
    '            End If

    '            txtD1c.Enabled = False
    '            cbxUnidad.Enabled = False
    '            cbxUnidad.Text = "Smalian"
    '            txtD2c.Enabled = False
    '            txtD3c.Enabled = False
    '            txtVolm3c.Enabled = False
    '            txtEspecieCubicacion.Enabled = False
    '            txtCodIndustria.Enabled = True
    '            txtAutogenerado.Enabled = False
    '            'SeleccionUnidad()

    '        End If

    '    Else
    '        txtD1c.Text = ""
    '        txtD2c.Text = ""
    '        txtD3c.Text = ""
    '        txtVolm3c.Text = ""
    '        txtEspecieCubicacion.Text = ""
    '        txtCodIndustria.Text = ""
    '        txtAutogenerado.Text = ""
    '    End If

    'End Sub

    'Private Sub ContratoComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ContratoComboBox.SelectedIndexChanged
    '    contratos = False
    '    Dim db As New samadEntities
    '    Dim id As Integer = ContratoComboBox.SelectedValue
    '    ZafrasComboBox.DataSource = db.zafrasypoas.Where(Function(p) p.Zyp_Permiso_Id = id).Select(Function(p) p.Zyp_Zafra).Distinct().ToList()
    '    ZafrasComboBox.SelectedItem = Nothing
    '    contratos = True
    'End Sub

    'Private Sub ZafrasComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ZafrasComboBox.SelectedIndexChanged
    '    If contratos Then
    '        zafras = False
    '        Dim db As New samadEntities
    '        Dim zafr As Integer = ZafrasComboBox.SelectedItem
    '        Dim id As Integer = ContratoComboBox.SelectedValue
    '        If Not zafr = 0 Then
    '            PoaComboBox.DataSource = db.zafrasypoas.Where(Function(p) p.Zyp_Zafra = zafr And p.Zyp_Permiso_Id = id)
    '            dataTransferir.DataSource = (From t In db.listatrozasd
    '                                        From z In db.zafrasypoas
    '                                        Where
    '                                        t.listatrozasc.Lt_Poa_Id = z.Zyp_id And
    '                                        z.Zyp_Zafra = zafr And
    '                                        z.Zyp_Permiso_Id = id And
    '                                        String.IsNullOrEmpty(t.Ltd_Autogenerado)
    '                                        Select t).ToList()
    '            listadetalle = dataTransferir.DataSource

    '            TxtTrozas.Text = listadetalle.Count
    '            txtVolm3.Text = listadetalle.Sum(Function(p) p.Ltd_Vol_M3)
    '            registro_seleccionado()
    '        End If
    '        PoaComboBox.SelectedItem = Nothing
    '        zafras = True
    '    End If
    'End Sub

    'Private Sub PoaComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles PoaComboBox.SelectedIndexChanged
    '    If zafras Then
    '        poas = False
    '        Dim db As New samadEntities
    '        Dim selecc As zafrasypoas = PoaComboBox.SelectedItem
    '        If Not selecc Is Nothing Then
    '            GTFCombobox.DataSource = db.listatrozasc.Where(Function(p) p.Lt_Poa_Id = selecc.Zyp_id).Distinct().ToList()
    '            dataTransferir.DataSource = db.listatrozasd.Where(Function(p) p.listatrozasc.Lt_Poa_Id = selecc.Zyp_id And String.IsNullOrEmpty(p.Ltd_Autogenerado)).ToList()
    '            listadetalle = dataTransferir.DataSource
    '            TxtTrozas.Text = listadetalle.Count
    '            txtVolm3.Text = listadetalle.Sum(Function(p) p.Ltd_Vol_M3)
    '            registro_seleccionado()
    '        Else

    '            listadetalle.Clear()
    '            dataTransferir.DataSource = listadetalle
    '            registro_seleccionado()
    '        End If
    '        GTFCombobox.SelectedItem = Nothing
    '        poas = True
    '    End If
    'End Sub

    'Private Sub GTFCombobox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles GTFCombobox.SelectedIndexChanged
    '    If poas Then
    '        Dim db As New samadEntities
    '        Dim selecc As listatrozasc = GTFCombobox.SelectedItem
    '        If Not selecc Is Nothing Then
    '            dataTransferir.DataSource = db.listatrozasd.Where(Function(p) p.Ltd_Lt_Id = selecc.Lt_id And String.IsNullOrEmpty(p.Ltd_Autogenerado)).ToList()
    '            listadetalle = dataTransferir.DataSource
    '            TxtTrozas.Text = listadetalle.Count
    '            txtVolm3.Text = listadetalle.Sum(Function(p) p.Ltd_Vol_M3)
    '            registro_seleccionado()
    '        Else

    '            listadetalle.Clear()
    '            dataTransferir.DataSource = listadetalle
    '            registro_seleccionado()
    '        End If
    '    End If

    'End Sub

    'Private Sub medirRB_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles medirRB.CheckedChanged
    '    If medirRB.Checked Then
    '        registro_seleccionado()
    '        cbxUnidad.Enabled = True
    '    End If
    'End Sub

    'Private Sub noMedir_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles noMedir.CheckedChanged
    '    If noMedir.Checked Then
    '        registro_seleccionado()
    '        cbxUnidad.Enabled = False
    '    End If
    'End Sub

    'Private Sub Calcular_Volm3()
    '    If cbxUnidad.Text = "Smalian" Then
    '        If txtD1c.Text <> "" And txtD2c.Text <> "" And txtD3c.Text <> "" Then
    '            txtVolm3c.Text = ((txtD1c.Text ^ 2) + (txtD2c.Text ^ 2))
    '            txtVolm3c.Text = txtVolm3c.Text * txtD3c.Text
    '            txtVolm3c.Text = txtVolm3c.Text * 0.3927
    '            txtVolm3c.Text = Format(txtVolm3c.Text * 1, "#0.000")
    '        End If

    '    End If
    '    If cbxUnidad.Text = "Doyle" Then
    '        If txtD2c.Text <> "" And txtD3c.Text <> "" Then
    '            txtVolm3c.Text = (((txtD2c.Text - 4) ^ 2) * txtD3c.Text) / 16
    '            txtVolm3c.Text = Format(txtVolm3c.Text * 1, "#0.000")
    '        End If
    '    End If
    'End Sub

    'Private Sub txtD1c_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtD1c.LostFocus
    '    If IsNumeric(txtD1c.Text) Then
    '        If txtD1c.Text <> 0 And (txtD1c.Text >= 25 And txtD1c.Text <= 250) Then
    '            txtD1c.Text = Format(txtD1c.Text / 100, "##0.00")
    '        End If
    '    End If
    '    Calcular_Volm3()

    'End Sub

    'Private Sub txtD2c_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtD2c.LostFocus
    '    If cbxUnidad.Text = "Smalian" Then
    '        If IsNumeric(txtD2c.Text) Then
    '            If txtD2c.Text <> 0 And (txtD2c.Text >= 25 And txtD2c.Text <= 250) Then
    '                txtD2c.Text = Format(txtD2c.Text / 100, "##0.00")
    '            End If
    '        End If

    '    End If
    '    Calcular_Volm3()
    'End Sub

    'Private Sub txtD3c_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtD3c.LostFocus
    '    If cbxUnidad.Text = "Smalian" Then
    '        If IsNumeric(txtD3c.Text) Then
    '            If txtD3c.Text <> 0 And (txtD3c.Text >= 25 And txtD3c.Text <= 250) Then
    '                txtD3c.Text = Format(txtD3c.Text / 100, "##0.00")
    '            End If
    '        End If

    '    End If
    '    Calcular_Volm3()
    'End Sub

    'Private Sub SeleccionUnidad()
    '    If medirRB.Checked Then
    '        If cbxUnidad.Text = "Smalian" Then
    '            uD1.Text = "metros"
    '            uD2.Text = "metros"
    '            uD3.Text = "metros"
    '            txtD1c.Text = ""
    '            uVol.Text = "m3"
    '            txtD1c.Enabled = True
    '            Label16.Text = "Vol. M3"
    '        End If
    '        If cbxUnidad.Text = "Doyle" Then
    '            uD2.Text = "pulgadas"
    '            uD3.Text = "pies"
    '            uD1.Text = ""
    '            uVol.Text = "pies tablares"
    '            txtD1c.Enabled = False
    '            Label16.Text = "Vol. PT"
    '            txtD1c.Text = 0
    '            txtD2c.Text = ""
    '            txtD3c.Text = ""
    '            txtVolm3c.Text = ""
    '        End If
    '    End If
    'End Sub

    'Private Sub cbxUnidad_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxUnidad.SelectedIndexChanged
    '    SeleccionUnidad()
    '    txtCodIndustria.Focus()
    'End Sub

    'Private Sub txtCodIndustria_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodIndustria.KeyPress
    '    If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
    '        e.Handled = True
    '        Dim db As New samadEntities
    '        Dim old = db.formato01_det.FirstOrDefault(Function(p) p.formato01.F01_Pro_id = aserrio And p.formato01.F01_periodo = periodo And p.F01d_Placa = txtCodIndustria.Text)
    '        If Not old Is Nothing Then
    '            MessageBox.Show("El Código de industria ya existe para la empresa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            txtCodIndustria.Focus()
    '        Else
    '            If cbxUnidad.Text = "Smalian" Then
    '                txtD1c.Focus()
    '            End If
    '            If cbxUnidad.Text = "Doyle" Then
    '                txtD2c.Focus()
    '            End If
    '        End If
    '    End If

    'End Sub

    'Private Sub txtD1c_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtD1c.KeyPress
    '    If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
    '        e.Handled = True
    '        If txtD1c.Text = CChar("") Then
    '            txtD1c.Text = "0"
    '        Else
    '            txtD1c.Text = Format(txtD1c.Text * 1, "##0.00")
    '            txtD2c.Focus()
    '        End If
    '    End If

    '    ' "0123456789.-" Valores o caracteres que solo aceptara el TextBox

    '    If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
    '        e.Handled = True
    '        e.KeyChar = CChar("")
    '    End If
    'End Sub

    'Private Sub txtD3c_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtD3c.KeyPress

    '    If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
    '        e.Handled = True
    '        If txtD3c.Text = CChar("") Then
    '            txtD3c.Text = "0"
    '        Else
    '            txtD3c.Text = Format(txtD3c.Text * 1, "##0.00")
    '            btnAceptar.Focus()
    '        End If
    '    End If

    '    ' "0123456789.-" Valores o caracteres que solo aceptara el TextBox

    '    If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
    '        e.Handled = True
    '        e.KeyChar = CChar("")
    '    End If

    'End Sub

    'Private Sub txtD2c_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtD2c.KeyPress

    '    If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
    '        e.Handled = True
    '        If txtD2c.Text = CChar("") Then
    '            txtD2c.Text = "0"
    '        Else
    '            txtD2c.Text = Format(txtD2c.Text * 1, "##0.00")
    '            txtD3c.Focus()
    '        End If
    '    End If

    '    ' "0123456789.-" Valores o caracteres que solo aceptara el TextBox

    '    If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
    '        e.Handled = True
    '        e.KeyChar = CChar("")
    '    End If

    'End Sub

    'Private Sub txtProce_Click(sender As System.Object, e As System.EventArgs) Handles txtProce.Click
    '    Dim frmV As New frmShowbrow
    '    'Enviamos los datos de la consulta sql

    '    frmV.titulo = "Lista de Procedencias"
    '    frmV.t_tabla = "procedencia"
    '    frmV.t_campos = "pro_id,pro_nombre"
    '    frmV.t_donde = ""
    '    frmV.t_agruparpor = ""
    '    frmV.t_ordenarpor = ""

    '    'Enviamos los formatosy tiulos de las columnas en un Array
    '    Dim titulos() As String = {"Id", "Nombre"}
    '    Dim anchos() As Integer = {50, 100}

    '    ReDim frmV.matAnchos(anchos.Length)
    '    ReDim frmV.matTitulos(titulos.Length)
    '    ReDim frmV.matColumnas(titulos.Length)
    '    titulos.CopyTo(frmV.matTitulos, 0)
    '    anchos.CopyTo(frmV.matAnchos, 0)

    '    frmV.ShowDialog(Me)

    '    'Datos
    '    If frmV.flag = True Then
    '        txtProcedencia.Text = frmV.matColumnas(1)
    '    End If
    'End Sub

    'Private Sub txtUbi_Click(sender As System.Object, e As System.EventArgs) Handles txtUbi.Click
    '    Dim frmV As New frmShowbrow
    '    'Enviamos los datos de la consulta sql

    '    frmV.titulo = "Lista de Ubicaciones"
    '    frmV.t_tabla = "ubicacion"
    '    frmV.t_campos = "ubi_id,ubi_nombre,ubi_propietario"
    '    frmV.t_donde = ""
    '    frmV.t_agruparpor = ""
    '    frmV.t_ordenarpor = ""

    '    'Enviamos los formatosy tiulos de las columnas en un Array
    '    Dim titulos() As String = {"Id", "Nombre", "Propietario"}
    '    Dim anchos() As Integer = {50, 100, 100}

    '    ReDim frmV.matAnchos(anchos.Length)
    '    ReDim frmV.matTitulos(titulos.Length)
    '    ReDim frmV.matColumnas(titulos.Length)
    '    titulos.CopyTo(frmV.matTitulos, 0)
    '    anchos.CopyTo(frmV.matAnchos, 0)

    '    frmV.ShowDialog(Me)

    '    'Datos
    '    If frmV.flag = True Then
    '        txtUbicacion.Text = frmV.matColumnas(1)
    '    End If
    'End Sub

    'Private Sub btnEspecie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEspecie.Click
    '    Dim frmEs As New frmShowbrow
    '    'Enviamos los datos de la consulta sql

    '    frmEs.titulo = "Especies Maderables"
    '    frmEs.t_tabla = "especies"
    '    frmEs.t_campos = "espe_id,espe_nombrecomun"
    '    frmEs.t_donde = ""
    '    frmEs.t_agruparpor = ""
    '    frmEs.t_ordenarpor = ""

    '    'Enviamos los formatosy tiulos de las columnas en un Array
    '    Dim titulos() As String = {"Id", "Nombre Común"}
    '    Dim anchos() As Integer = {50, 200}

    '    ReDim frmEs.matAnchos(anchos.Length)
    '    ReDim frmEs.matTitulos(titulos.Length)
    '    ReDim frmEs.matColumnas(titulos.Length)
    '    titulos.CopyTo(frmEs.matTitulos, 0)
    '    anchos.CopyTo(frmEs.matAnchos, 0)

    '    frmEs.ShowDialog(Me)

    '    'Datos de Contrato y Poa
    '    If frmEs.flag = True Then
    '        txtEspecieCubicacion.Text = frmEs.matColumnas(1)
    '    End If
    'End Sub

End Class