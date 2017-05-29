Imports MySql.Data.MySqlClient
Public Class flibreria
    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando
    Public Function ValidaControles(ByVal ctrlContenedor As Object) As Boolean

        Dim controlcito As Control
        Dim controlChild As Control

        For Each controlcito In ctrlContenedor
            If TypeOf controlcito Is TextBox Or TypeOf controlcito Is ComboBox Then
                If Trim(controlcito.Text) = "" And controlcito.Tag <> "Id" Then
                    MsgBox("Debe Ingresar " + controlcito.Tag, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, Application.ProductName)
                    controlcito.BackColor = Color.Chocolate
                    controlcito.Focus()
                    Return False
                    controlcito.Enabled = True
                Else
                    controlcito.BackColor = System.Drawing.SystemColors.Control
                End If
            ElseIf controlcito.HasChildren Then
                For Each controlChild In controlcito.Controls
                    If TypeOf controlChild Is TextBox Or TypeOf controlChild Is ComboBox Then
                        If Trim(controlcito.Text) = "" And controlcito.Tag <> "Id" Then
                            MsgBox("Debe Ingresar " + controlcito.Tag, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, Application.ProductName)
                            controlcito.BackColor = Color.Chocolate
                            controlcito.Focus()
                            Return False
                            controlcito.Enabled = True
                        Else
                            controlcito.BackColor = System.Drawing.SystemColors.Control
                        End If
                    End If
                Next
            End If
        Next
        Return True
    End Function
    Public Sub siguientecontrol()
        SendKeys.Send("{TAB}")
    End Sub
    Function descontar_elementos_agregados(ByVal nombreTabla As String, ByVal campoAbuscar As String)

        Dim Dtea As New DataTable
        Dim dtsr As New vShowbrow
        Dim func As New fshowbrow

        dtsr.gt_tabla = nombreTabla
        dtsr.gt_campos = String.Format("{0} as valor_buscado", campoAbuscar)
        dtsr.gt_donde = ""
        dtsr.gt_agruparpor = ""
        dtsr.gt_ordenarpor = ""

        Dtea = func.mostrar(dtsr)

        Dim cadena As String = ""
        Dim registros As Integer = Dtea.Rows.Count

        If registros <> 0 Then
            Dim arrCuts(registros) As String
            Dim i As Integer = 0
            For Each columna As DataRow In Dtea.Rows
                arrCuts(i) = CStr(columna("valor_buscado"))
                If (i + 1) <> registros Then
                    cadena = cadena + "'" + arrCuts(i) + "'" + ","
                Else
                    cadena = cadena + "'" + arrCuts(i) + "'"
                End If
                i = i + 1
            Next
        End If
        Return cadena
    End Function
    Function buscar_dato_exitente_entabla(ByVal dato_a_buscar As String, ByVal tabla As String, ByVal campo As String) As Boolean

        Dim tbbusas As DataTable
        Dim dtsr As New vShowbrow
        Dim func As New fshowbrow

        dtsr.gt_tabla = tabla
        dtsr.gt_campos = campo
        If IsNumeric(dato_a_buscar) = False Then
            dtsr.gt_donde = String.Format("{0}='{1}'", campo, dato_a_buscar)
        Else
            dtsr.gt_donde = String.Format("{0}={1}", campo, Convert.ToUInt32(dato_a_buscar))
        End If
        dtsr.gt_agruparpor = ""
        dtsr.gt_ordenarpor = ""

        tbbusas = func.mostrar(dtsr) 'Invocamos a la funcion mostrar()
        If tbbusas.Rows.Count <> 0 Then 'Si las filas al contarlas es diferente de cero
            Return True
        Else
            Return False
        End If

    End Function
End Class
