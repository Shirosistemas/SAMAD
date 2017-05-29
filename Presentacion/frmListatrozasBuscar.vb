Public Class frmListatrozasBuscar
    Public dt As New DataTable
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

                dv.RowFilter = String.Format(campoabuscar & " Like '%{0}%'", txtbuscar.Text) 'Filtramos la busqueda
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

        Private Sub frmShowbrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub gtf_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles gtf.CheckedChanged
        If gtf.Checked Then
            Me.t_tabla = "vmostrar_listatrozasportitular"
            Me.t_campos = "lt_id,Lt_Nrogtf,pro_titular,Trozas"
            Me.t_donde = ""
            Me.t_agruparpor = ""
            Me.t_ordenarpor = ""

            'Enviamos los formatosy tiulos de las columnas en un Array
            Dim titulos() As String = {"Id", "Nro.GTF", "Títular", "Trozas"}
            Dim anchos() As Integer = {30, 70, 200, 60}

            ReDim Me.matAnchos(anchos.Length)
            ReDim Me.matTitulos(titulos.Length)
            ReDim Me.matColumnas(titulos.Length)
            titulos.CopyTo(Me.matTitulos, 0)
            anchos.CopyTo(Me.matAnchos, 0)

            mostrar()

        End If

    End Sub

    Private Sub codigo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles codigo.CheckedChanged
        If codigo.Checked Then
            Me.t_tabla = "vmostrar_listatrozasdetalle"
            Me.t_campos = "Ltd_Lt_Id,ltd_Codificacion,Ltd_NroListaTrozas, Lt_Nrogtf"
            Me.t_donde = ""
            Me.t_agruparpor = ""
            Me.t_ordenarpor = ""

            'Enviamos los formatosy tiulos de las columnas en un Array
            Dim titulos() As String = {"Id", "Código", "Nro Lista Trozas", "GTF"}
            Dim anchos() As Integer = {40, 70, 100, 100}

            ReDim Me.matAnchos(anchos.Length)
            ReDim Me.matTitulos(titulos.Length)
            ReDim Me.matColumnas(titulos.Length)
            titulos.CopyTo(Me.matTitulos, 0)
            anchos.CopyTo(Me.matAnchos, 0)

            mostrar()

        End If
    End Sub
End Class
