Public Class frmFormato02Busqueda
    Private dt As New DataTable
    Dim dts As New vShowbrow
    Dim func As New fshowbrow 'Creacion una variable para hacer referencia a la funcion fconcesiones
    Dim col, buscampo As Integer
    Public t_tabla, t_campos, t_donde, t_agruparpor, t_ordenarpor, campoabuscar, titulo As String
    Public matAnchos() As Integer
    Public matTitulos(), matColumnas() As String
    Public matAlineacion() As String = {}
    Public flag As Boolean = False
    Private Sub mostrar()
        Try
            Dim dts As New vShowbrow
            Dim func As New fshowbrow

            dts.gt_tabla = t_tabla
            dts.gt_campos = t_campos
            dts.gt_donde = t_donde
            dts.gt_agruparpor = t_agruparpor
            dts.gt_ordenarpor = t_ordenarpor

            dt = func.mostrar(dts) 'Invocamos a la funcion mostrar()

            If dt.Rows.Count <> 0 Then 'Si las filas al contarlas es diferente de cero
                col = dt.Columns.Count

                datashowbrow.DataSource = dt
                datashowbrow.ColumnHeadersVisible = True
                datashowbrow.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                formatear_grid()

                If buscampo = 0 Then
                    buscampo = 1
                End If

                If titulo <> "" Then
                    Me.Text = titulo
                    Lbltitulo.Text = titulo
                End If

                campoabuscar = dt.Columns.Item(buscampo).ColumnName 'Variable que almacen el campo donde se realizara la busqueda

            Else
                datashowbrow.DataSource = Nothing
                datashowbrow.ColumnHeadersVisible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'buscar()
    End Sub
    Private Sub formatear_grid()

        datashowbrow.AllowUserToResizeRows = False
        datashowbrow.RowHeadersVisible = False

        'Formateamos el DataGridView con los valores del Array

        For i = 0 To col - 1
            If UBound(matAlineacion) <> -1 Then
                Me.Text = UBound(matAlineacion)
                Dim AlineacionColumnas As String = matAlineacion(i).ToUpper
                If AlineacionColumnas = "LEFT" Then
                    datashowbrow.Columns.Item(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                End If
                If AlineacionColumnas = "CENTER" Then
                    datashowbrow.Columns.Item(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                End If
                If AlineacionColumnas = "RIGTH" Then
                    datashowbrow.Columns.Item(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                End If
            End If
            datashowbrow.Columns.Item(i).Width = matAnchos(i)
            datashowbrow.Columns.Item(i).HeaderText = matTitulos(i)

        Next

    End Sub
    Private Sub buscar()
        Try

            Dim ds As New DataSet 'Declaramos variable para tener una copiar del DataTable
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = String.Format(campoabuscar & " Like '%{0}%'", txtbuscar.Text.ToString()) 'Filtramos la busqueda
            If dv.Count <> 0 Then
                datashowbrow.DataSource = dv
                formatear_grid()
                txtbuscar.Enabled = True

            Else
                datashowbrow.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmShowbrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'mostrar()
    End Sub

    Private Sub txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub datashowbrow_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datashowbrow.CellDoubleClick
        seleccionRegistro()
    End Sub
    Private Sub seleccionRegistro()
        'Almacenamos en el array el registro seleccionado
        For j = 0 To col - 1

            Try
                matColumnas(j) = datashowbrow.SelectedCells.Item(j).Value
            Catch ex As Exception

            End Try
        Next
        flag = True
        Me.Hide()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        seleccionRegistro()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        flag = False
        Me.Hide()
    End Sub

    Private Sub cbDoc_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbDoc.CheckedChanged
        If cbDoc.Checked Then
            Me.t_tabla = "vmostrar_documentos_formato02"
            Me.t_campos = "f02_id,f02_nrodoc,f02d_codindustria,f02_fecha,volm3"
            Me.t_donde = ""
            Me.t_agruparpor = ""
            Me.t_ordenarpor = ""
            Me.buscampo = 1
            'Enviamos los formatosy tiulos de las columnas en un Array
            Dim titulos() As String = {"ID Doc", "Nro Doc", "Cod.Ind", "Fecha", "volm3"}
            Dim anchos() As Integer = {60, 60, 50, 80, 80}

            ReDim Me.matAnchos(anchos.Length)
            ReDim Me.matTitulos(titulos.Length)
            ReDim Me.matColumnas(titulos.Length)
            titulos.CopyTo(Me.matTitulos, 0)
            anchos.CopyTo(Me.matAnchos, 0)

            mostrar()
        End If
    End Sub

    Private Sub cbCodInd_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbCodInd.CheckedChanged
        If cbCodInd.Checked Then
            Me.t_tabla = "vmostrar_documentos_formato02"
            Me.t_campos = "f02_id,f02_nrodoc,f02d_codindustria,f02_fecha,volm3"
            Me.t_donde = ""
            Me.t_agruparpor = ""
            Me.t_ordenarpor = ""
            Me.buscampo = 2
            'Enviamos los formatosy tiulos de las columnas en un Array
            Dim titulos() As String = {"ID Doc", "Nro Doc", "Cod.Ind", "Fecha", "volm3"}
            Dim anchos() As Integer = {60, 60, 50, 80, 80}

            ReDim Me.matAnchos(anchos.Length)
            ReDim Me.matTitulos(titulos.Length)
            ReDim Me.matColumnas(titulos.Length)
            titulos.CopyTo(Me.matTitulos, 0)
            anchos.CopyTo(Me.matAnchos, 0)

            mostrar()
        End If
    End Sub

End Class