Public Class frmPaquete
    Dim Dt, Dtd, Dtdm, Dte, Dtb As New DataTable
    Dim func As New fformato01 'Creacion una variable para hacer referencia a la funcion fconcesiones
    Dim nreg, nregd, nregp, xreg, recno As Integer
    Dim sw_guardar As Boolean = False
    Dim sw_guardard As Boolean = False
    Dim nuevo As Boolean
    Dim nuevoItem As Boolean = False
    Dim modificar As Boolean
    Dim modificarItem As Boolean = False
    Dim msg As String = ""
    Dim frm, frmbuscardoc As New frmShowbrow
    Private _left As String

    Private Sub AplicarPerfil()
        If vInfraestructura.Usuario.gtipo = "ADMINISTRADOR" Then

        Else

            Panel2.Enabled = False
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmPaquete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        habilitar()
        AplicarPerfil()
        Panel2.Enabled = True
    End Sub

    Private Sub limpiar()
        txtId.Text = ""
        txtNumPaq.Text = ""
        txtEspecieId.Text = ""
        txtEspecieNombre.Text = ""
        txtProductoId.Text = ""
        txtProductoNombre.Text = ""
        txtCubicadorId.Text = ""
        txtCubicadorNombre.Text = ""
        txtUbicacion.Text = ""
        txtObservacion.Text = ""
    End Sub

    Private Sub habilitar()
        txtId.Enabled = False
        txtNumPaq.Enabled = True
        txtEspecieId.Enabled = False
        txtEspecieNombre.Enabled = False
        txtProductoId.Enabled = False
        txtProductoNombre.Enabled = False
        txtAcabado.Enabled = True
        txtHumedad.Enabled = True
        txtClasificacion.Enabled = True
        txtCubicadorId.Enabled = False
        txtCubicadorNombre.Enabled = False
        txtUbicacion.Enabled = True
        txtObservacion.Enabled = True

        btnProducto.Enabled = True
        btnEspecie.Enabled = True
        btnCubicador.Enabled = True
    End Sub

    Private Sub deshabilitar()
        txtId.Enabled = False
        txtNumPaq.Enabled = False
        txtEspecieId.Enabled = False
        txtEspecieNombre.Enabled = False
        txtProductoId.Enabled = False
        txtProductoNombre.Enabled = False
        txtAcabado.Enabled = False
        txtHumedad.Enabled = False
        txtClasificacion.Enabled = False
        txtCubicadorId.Enabled = False
        txtCubicadorNombre.Enabled = False
        txtUbicacion.Enabled = False
        txtObservacion.Enabled = False

        btnProducto.Enabled = False
        btnEspecie.Enabled = False
        btnCubicador.Enabled = False

    End Sub

    Function buscarPaquete(ByVal registro As String) As Boolean
        Try
            Dim dtl As New vPaquete
            Dim func As New fPaquete 'Creacion una variable para hacer referencia a la funcion flistatrozasd

            dtl.gPaq_Numero = registro
            Dte = func.buscarPaquete(dtl) 'Invocamos a la funcion mostrar()

            nregp = Dte.Rows.Count 'Almacenamos la cantidad de filas o registros recuperados

            If nregp <> 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub btnEspecie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEspecie.Click
        'Enviamos los datos de la consulta sql
        frm.titulo = "Lista del Especies"
        frm.t_tabla = "especies"
        frm.t_campos = "Espe_Id,Espe_NombreComun"
        frm.t_donde = ""
        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Especie - Nombre Común"}
        Dim anchos() As Integer = {30, 200}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)
        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog(Me)

        'Datos del Titular
        If frm.flag = True Then
            txtEspecieId.Text = frm.matColumnas(0)
            txtEspecieNombre.Text = frm.matColumnas(1)
        End If
    End Sub

    Private Sub btnProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProducto.Click
        'Enviamos los datos de la consulta sql
        frm.titulo = "Lista del Productos"
        frm.t_tabla = "productos"
        frm.t_campos = "Prod_Id,Prod_Descrip"
        frm.t_donde = ""
        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Descripcion producto"}
        Dim anchos() As Integer = {30, 200}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)
        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog(Me)

        'Datos del Titular
        If frm.flag = True Then
            txtProductoId.Text = frm.matColumnas(0)
            txtProductoNombre.Text = frm.matColumnas(1)
        End If
    End Sub

    Private Sub btnCubicador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCubicador.Click
        'Enviamos los datos de la consulta sql
        frm.titulo = "Lista del Empleados"
        frm.t_tabla = "personal"
        frm.t_campos = "Per_Id,Per_NomApe"
        frm.t_donde = ""
        frm.t_agruparpor = ""
        frm.t_ordenarpor = ""

        'Enviamos los formatosy tiulos de las columnas en un Array
        Dim titulos() As String = {"Id", "Nombres y Apellidos"}
        Dim anchos() As Integer = {30, 200}

        ReDim frm.matAnchos(anchos.Length)
        ReDim frm.matTitulos(titulos.Length)
        ReDim frm.matColumnas(titulos.Length)
        titulos.CopyTo(frm.matTitulos, 0)
        anchos.CopyTo(frm.matAnchos, 0)

        frm.ShowDialog(Me)

        'Datos del Titular
        If frm.flag = True Then
            txtCubicadorId.Text = frm.matColumnas(0)
            txtCubicadorNombre.Text = frm.matColumnas(1)
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim funcl As New flibreria
        Dim todook As Boolean = funcl.ValidaControles(gbDatos.Controls)

        If todook = True Then
            Dim result As DialogResult
            'validar_campos()
            sw_guardar = True
            If sw_guardar = True Then 'Guardamos si los controles no estan vacios
                result = MessageBox.Show("Esta seguro de GUARDAR el registro ?", "Guardar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If result = DialogResult.OK Then
                    Try
                        'Guardando los datos de Encabezado
                        Dim dts As New vPaquete
                        Dim func As New fPaquete

                        dts.gPaq_Emp_id = frmEmpaquetado.TxtId.Text
                        dts.gPaq_Numero = txtNumPaq.Text
                        dts.gPaq_Especie = txtEspecieId.Text
                        dts.gPaq_TipoProducto = txtProductoId.Text
                        dts.gPaq_Acabado = txtAcabado.Text
                        dts.gPaq_Humedad = txtHumedad.Text
                        dts.gPaq_Clasificacion = txtClasificacion.Text
                        dts.gPaq_CubicadorId = txtCubicadorId.Text
                        dts.gPaq_Ubicacion = txtUbicacion.Text
                        dts.gPaq_Observacion = txtObservacion.Text

                        If frmEmpaquetado.nuevoDeta = True Then
                            'If buscarPaquete(txtNumPaq.Text) = False Then
                            If func.insertar(dts) Then
                                MessageBox.Show("Datos guardados correctamente...!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                limpiar()
                                deshabilitar()
                                btnGuardar.Enabled = False
                                Me.Close()
                            Else
                                MessageBox.Show("Datos No fueron registrados, intente de nuevo!!!", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                            'Else
                            '    MessageBox.Show("Paquete ya ingresado, intente con otro", "SAMAD", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            '    txtNumPaq.Focus()
                            'End If
                        Else

                        If frmEmpaquetado.modificarDeta = True Then
                            dts.gPaq_id = txtId.Text
                            If func.editar(dts) = False Then
                                MessageBox.Show("Datos editados correctamente...!", "Editando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                limpiar()
                                deshabilitar()
                                btnGuardar.Enabled = False
                                Me.Close()
                            Else
                                MessageBox.Show("Datos No fueron editados, intente de nuevo!", "Editando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Else
                MessageBox.Show(msg, "Validar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

End Class