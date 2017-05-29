Public Class frmListatrozasd
    'Inherits frmListatrozas

    Public Sw As Boolean = False
    'Public promedio As Boolean

    Dim xTitulo = fxSamad.Titulo
    ' para obtener el caracter de punto decimal
    Dim xDecimal As Char = Nothing

    Friend xExiste As Boolean
    Friend NumeroGTF As String
    Friend RowPapa As Integer = 0
    Friend Promedio As Boolean
    Friend Numtroza As String
    Friend xZafra As String
    Friend xTitular As Integer = 0

#Region "Funciones y procedimientos locales del Formulario"

    Private Sub CalculoM3()
        'Dim m3, d1, d2, d3 As Decimal
        'd1 = Convert.ToDecimal(CDbl(txD1.Text) / 100)
        'd2 = Convert.ToDecimal(CDbl(txD2.Text) / 100)
        'd3 = Convert.ToDecimal(CDbl(txLargo.Text) / 100)
        'm3 = ((d1 + d2) / 2) ^ 2
        'm3 = (m3 * d3) * 0.7854
        'txVolm3.Text = Decimal.Round((m3 * 100), 3)
        Try
            txVolm3.Text = New fxSamad().FormulaSmalian(CDec(txD1.Text), CDec(txD2.Text), CDbl(txLargo.Text), 3)
        Catch ex As Exception
            txVolm3.Text = "0.00"
        End Try
    End Sub

    Private Sub LimpiarControles()
        txD1.Text = "0.00"
        txD2.Text = "0.00"
        txLargo.Text = "0.00"
        txVolm3.Text = "0.00"
    End Sub

    Private Sub GrabarRegistroDetalle()
        Dim xfm = frmListatrozas
        Dim dt As New SAMAD.listatrozasd
        dt.EspecieId = txEsPecieId.Text
        dt.Ltd_Especie = txEspecie.Text
        dt.Ltd_Codificacion = txNumtroza.Text
        dt.Ltd_D1 = CDbl(txD1.Text)
        dt.Ltd_D2 = CDbl(txD2.Text)
        dt.Ltd_D3 = CDbl(txLargo.Text)
        dt.Ltd_Vol_M3 = CDbl(txVolm3.Text)
        dt.Ltd_Lt_Id = RowPapa
        dt.Ltd_NroListaTrozas = txSerie.Text & "-" & txNumserie.Text
        dt.Estatus = 0
        If xExiste = False Then
            If IsNumeric(Me.txNumtroza.Text) = True Then
                If New cdListatrozasd().ListaTrozasAgregar(dt) = True Then
                    frmListatrozas.GrabarRegistroDetalle()
                    LimpiarControles()
                    txNumtroza.Text = New fxSamad().StrCeros(txNumtroza.Text, 6, True)
                    txNumtroza.SelectAll()
                    txNumtroza.Focus()
                End If
            Else
                If New cdListatrozasd().ListaTrozasAgregar(dt) = True Then
                    frmListatrozas.GrabarRegistroDetalle()
                    LimpiarControles()
                    'txNumtroza.Text = New fxSamad().StrCeros(txNumtroza.Text, 6, True)
                    txNumtroza.SelectAll()
                    txNumtroza.Focus()
                End If
            End If
        End If
        If xExiste = True Then
            dt.Ltd_Id = txRowId.Text
            Dim sn = New cdListatrozasd().ListaTrozasEditar(dt)
            Me.Close()
        End If
    End Sub

    Private Sub CargaDatosTroza()        
        Dim dt = New cdListatrozasd().GetTrozaByNumero(Numtroza)
        txRowId.Text = dt.Ltd_Id
        txEsPecieId.Text = dt.EspecieId
        txEspecie.Text = dt.Ltd_Especie
        txSerie.Text = Mid(dt.Ltd_NroListaTrozas, 1, 3)
        txNumserie.Text = Mid(dt.Ltd_NroListaTrozas, 5, 6)
        txNumtroza.Text = dt.Ltd_Codificacion
        txD1.Text = dt.Ltd_D1
        txD2.Text = dt.Ltd_D2
        txLargo.Text = dt.Ltd_D3
        txVolm3.Text = dt.Ltd_Vol_M3
        RowPapa = dt.Ltd_Lt_Id
        txNumtroza.SelectAll()
        txNumtroza.Focus()
    End Sub
#End Region

    Private Sub btnPoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEspecie.Click
        Dim frmEs As New frmShowbrow
        'Enviamos los datos de la consulta sql
        frmEs.titulo = "Especies Maderables"
        frmEs.t_tabla = "especies"
        frmEs.t_campos = "espe_id,espe_nombrecomun"
        frmEs.t_donde = ""
        frmEs.t_agruparpor = ""
        frmEs.t_ordenarpor = ""
        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Nombre Común"}
        Dim anchos() As Integer = {50, 200}
        ReDim frmEs.matAnchos(anchos.Length)
        ReDim frmEs.matTitulos(titulos.Length)
        ReDim frmEs.matColumnas(titulos.Length)
        titulos.CopyTo(frmEs.matTitulos, 0)
        anchos.CopyTo(frmEs.matAnchos, 0)
        frmEs.ShowDialog(Me)
        'Datos de Contrato y Poa
        If frmEs.flag = True Then
            txEsPecieId.Text = frmEs.matColumnas(0)
            txEspecie.Text = frmEs.matColumnas(1)
            txSerie.Focus()
        End If
    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim msg As String = ""
        If xExiste = False Then
            If New cdListatrozasd().BuscarCodigoTrozas(txNumtroza.Text, xTitular, xZafra) = True Then
                MessageBox.Show("El numero de Troza ya existe", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txNumtroza.Focus()
                txNumtroza.SelectAll()
                Exit Sub
            End If
        End If
        If String.IsNullOrEmpty(txEspecie.Text) = True Then
            MessageBox.Show("Seleccione la Especie de la Troza", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btEspecie.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(txSerie.Text) = True Then
            MessageBox.Show("Ingrese el Numero de Serie", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txSerie.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(txNumserie.Text) = True Then
            MessageBox.Show("Ingrese la codificacion de la Troza", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txNumserie.Focus()
            Exit Sub
        End If
        If CDbl(txVolm3.Text) <= 0 Then
            MessageBox.Show("No hay un volumen de Metros en este registro", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txD1.SelectAll()
            txD1.Focus()
            Exit Sub
        End If
        'Sw = True
        'Me.Close()
        GrabarRegistroDetalle()
    End Sub

    Private Sub txtD3_GotFocus(sender As Object, e As System.EventArgs) Handles txLargo.GotFocus
        stbInfo.Text = "Largo de la Troza (en Metros)"
    End Sub

    Private Sub txtD3_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txLargo.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                txD2.SelectAll()
                txD2.Focus()
            Case Keys.Enter, Keys.Tab
                If String.IsNullOrEmpty(txLargo.Text) = False Then
                    e.Handled = True
                    If CDbl(txLargo.Text) <= 0 Then
                        MessageBox.Show("Por favor ingrese el Largo de la Troza", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txLargo.Focus()
                        Exit Sub
                    End If
                    CalculoM3()
                    btnAceptar.Focus()
                End If
        End Select
    End Sub

    Private Sub txtD3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txLargo.KeyPress
        '' "0123456789.-" Valores o caracteres que solo aceptara el TextBox
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub

    Private Sub txtD2_GotFocus(sender As Object, e As System.EventArgs) Handles txD2.GotFocus
        stbInfo.Text = "Díametro menor (en Centimetros)"
    End Sub

    Private Sub txtD2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txD2.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                txD1.Text = IIf(xExiste = False, "0.00", txD1.Text)
                txD1.SelectAll()
                txD1.Focus()
            Case Keys.Enter, Keys.Tab
                e.Handled = True
                If String.IsNullOrEmpty(txD2.Text) = True Then
                    MessageBox.Show("Por favor ingrese el Diametro menor de la Troza", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txD2.Focus()
                    Exit Sub
                End If
                CalculoM3()
                txLargo.Text = IIf(xExiste = False, "0.00", txLargo.Text)
                txLargo.SelectAll()
                txLargo.Focus()
        End Select
    End Sub

    Private Sub txtD2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txD2.KeyPress
        '    ' "0123456789.-" Valores o caracteres que solo aceptara el TextBox
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub

    Private Sub txtD1_GotFocus(sender As Object, e As System.EventArgs) Handles txD1.GotFocus
        stbInfo.Text = "Díametro mayor (en Centimetros)"
    End Sub

    Private Sub txtD1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txD1.LostFocus
        validar_D1()
        CalculoM3()
    End Sub

    Private Sub txtD2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txD2.LostFocus
        If CDbl(txD2.Text) > CDbl(txD1.Text) Then
            MessageBox.Show("El diametro menor no puede ser Mayor al Diametro Mayor", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txD2.SelectAll()
            txD2.Focus()
            Exit Sub
        End If
        validar_D2()
        CalculoM3()
    End Sub

    Private Sub txLargo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txLargo.LostFocus
        validar_Largo()

    End Sub

    Private Sub siguientecontrol()
        SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtD3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txLargo.LostFocus
        CalculoM3()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Sw = False
        Me.Close()
    End Sub

    Private Sub txtCodificacion_GotFocus(sender As Object, e As System.EventArgs) Handles txNumtroza.GotFocus
        stbInfo.Text = "Codigo de la troza"
    End Sub

    Private Sub txtCodificacion_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txNumtroza.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                txNumtroza.Text = ""
                txNumserie.SelectAll()
                txNumserie.Focus()
                e.Handled = True
            Case Keys.Enter, Keys.Tab
                If String.IsNullOrEmpty(txNumtroza.Text) = True Then
                    MessageBox.Show("Ingrese el Nsumero de Troza", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txNumtroza.Focus()
                End If
                If IsNumeric(txNumtroza.Text) = True Then
                    txNumtroza.Text = New fxSamad().StrCeros(txNumtroza.Text, 6, False)
                End If
                txD1.Text = IIf(xExiste = False, "0.00", txD1.Text)
                txD1.SelectAll()
                txD1.Focus()
                e.Handled = True
        End Select
        e.Handled = True
    End Sub

    Private Sub txtNrolistaTrozas_GotFocus(sender As Object, e As System.EventArgs) Handles txNumserie.GotFocus
        stbInfo.Text = "Numero de Documento"
    End Sub

    Private Sub txtNrolistaTrozas_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txNumserie.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    txSerie.SelectAll()
                    txSerie.Focus()
                    e.Handled = True
                Case Keys.Enter, Keys.Tab
                    If String.IsNullOrEmpty(txNumserie.Text) = True Then
                        MessageBox.Show("Ingrese el Numero de Lista", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txNumserie.Focus()
                        Exit Sub
                    End If
                    If IsNumeric(txNumserie.Text) = True Then
                        txNumserie.Text = Microsoft.VisualBasic.Right("000000" + txNumserie.Text, 6)
                    End If
                    txNumtroza.Text = IIf(xExiste = False, New fxSamad().StrCeros(1, 6, False), txNumtroza.Text)
                    txNumtroza.SelectAll()
                    txNumtroza.Focus()
                    e.Handled = True
            End Select
            e.Handled = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub frmListatrozasd_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            If xExiste = False Then
                txSerie.Text = Mid(NumeroGTF, 1, 3)
                txNumserie.Text = Mid(NumeroGTF, 5, 6)
                lblRowPapa.Text = RowPapa
            Else
                CargaDatosTroza()
            End If            
        Catch ex As Exception
            txSerie.Text = "xxx"
            txNumserie.Text = "xxxxxx"
        End Try
        xDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
    End Sub

    Private Sub txtD1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txD1.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                txD1.Text = IIf(xExiste = False, "0.00", txD1.Text)
                txNumtroza.SelectAll()
                txNumtroza.Focus()
                e.Handled = True
            Case Keys.Enter, Keys.Tab
                e.Handled = True
                If CDbl(txD1.Text) < 1 Then
                    MessageBox.Show("Ingrese Solo numeros Enteros", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txD1.SelectAll()
                    txD1.Focus()
                    Exit Sub
                End If
                txD2.Text = IIf(xExiste = False, "0.00", txD2.Text)
                txD2.SelectAll()
                txD2.Focus()
        End Select
    End Sub

    Private Sub txtD1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txD1.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
        End If
    End Sub


    Private Sub txtSerie_GotFocus(sender As Object, e As System.EventArgs) Handles txSerie.GotFocus
        stbInfo.Text = "Serie del documento"
    End Sub

    Private Sub txtSerie_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txSerie.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.Handled = True
                btEspecie.Focus()
            Case Keys.Tab, Keys.Enter
                e.Handled = True
                If String.IsNullOrEmpty(txSerie.Text) = True Then
                    MessageBox.Show("Por favor ingrese el Numero de Serie", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txSerie.Focus()
                    Exit Sub
                End If
                If IsNumeric(txSerie.Text) = True Then
                    txSerie.Text = Microsoft.VisualBasic.Right("000" + txSerie.Text, 3)
                End If
                txNumserie.Focus()
        End Select
    End Sub

    Private Sub txtSerie_PreviewKeyDown(sender As Object, e As System.Windows.Forms.PreviewKeyDownEventArgs)
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txtNrolistaTrozas_PreviewKeyDown(sender As Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txNumserie.PreviewKeyDown
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txtCodificacion_PreviewKeyDown(sender As Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txNumtroza.PreviewKeyDown
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txtD1_PreviewKeyDown(sender As Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txD1.PreviewKeyDown
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txtD2_PreviewKeyDown(sender As Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txD2.PreviewKeyDown
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txtD3_PreviewKeyDown(sender As Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txLargo.PreviewKeyDown
        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub btnAceptar_GotFocus(sender As Object, e As System.EventArgs) Handles btnAceptar.GotFocus
        stbInfo.Text = "Precione Enter para Grabar el registro"
    End Sub
    Private Function validar_D1() As Boolean

        If CDbl(txD1.Text) >= 300 Then
            If MessageBox.Show("300 cm. supera el diametro maximo de una troza, ¿Desea conservar esta medida?", xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                txD1.BackColor = Color.LightYellow
                txD1.SelectAll()
                txD1.Focus()
                Return False
            End If
        End If

        Return True
    End Function
    Private Function validar_D2() As Boolean

        If CDbl(txD2.Text) >= 300 Then
            If MessageBox.Show("300 cm. supera el diametro maximo de una troza, ¿Desea conservar esta medida?", xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                txD2.BackColor = Color.LightYellow
                txD2.SelectAll()
                txD2.Focus()
                Return False
            End If
        End If

        Return True
    End Function

    Private Function validar_Largo() As Boolean
        If CDbl(txLargo.Text) >= 50 Then
            If MessageBox.Show("50 m. supera la longitud maxima de una troza, ¿Desea conservar esta medida?", xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                txLargo.BackColor = Color.LightYellow
                txLargo.SelectAll()
                txLargo.Focus()
                Return False
            End If
        End If

        Return True
    End Function
    
   
    Private Sub tipValidation_Popup(sender As System.Object, e As System.Windows.Forms.PopupEventArgs) Handles tipValidation.Popup

    End Sub

    
    Private Sub txNumserie_TextChanged(sender As System.Object, e As System.EventArgs) Handles txNumserie.TextChanged

    End Sub

    Private Sub txNumtroza_Validated(sender As System.Object, e As System.EventArgs) Handles txNumtroza.Validated
        If String.IsNullOrEmpty(txNumtroza.Text) = True Then
            MessageBox.Show("Ingrese el Nsumero de Troza", xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txNumtroza.Focus()
        End If
        If IsNumeric(txNumtroza.Text) = True Then
            txNumtroza.Text = New fxSamad().StrCeros(txNumtroza.Text, 6, False)
        End If
        txD1.Text = IIf(xExiste = False, "0.00", txD1.Text)
        txD1.SelectAll()
        txD1.Focus()
    End Sub
End Class