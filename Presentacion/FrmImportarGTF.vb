Imports System
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class FrmImportarGTF
    Dim conex As New conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando
    Public ruta As String
   

    Private Sub FrmImportarGTF_DragDrop(ByVal sender As Object, _
                              ByVal e As DragEventArgs) _
                              Handles Me.DragDrop, txtFic.DragDrop
        ' Drag & Drop, aceptar el primer fichero
        If e.Data.GetDataPresent("FileDrop") Then
            txtFic.Text = CType(e.Data.GetData("FileDrop", True), String())(0)
            txtSelect.Text = System.IO.Path.GetFileNameWithoutExtension(txtFic.Text)
        End If
    End Sub

    Private Sub FrmImportarGTF_DragEnter(ByVal sender As Object, _
                                ByVal e As DragEventArgs) _
                                Handles Me.DragEnter, txtFic.DragEnter
        ' Drag & Drop, comprobar con DataFormats
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    
    Private Sub btnMigrar_Click(sender As System.Object, e As System.EventArgs) Handles btnMigrar.Click
        Dim guiadbf As fguardardbf

        guiadbf = New fguardardbf

        guiadbf.migrar_guiatf_dbf()
        guiadbf.migrar_lista_trozas_dbf()


        dgvDiarios.Columns.Clear()
        dgvDiarios.DataSource = Nothing
        btnExaminar.PerformClick()



    End Sub

    Private Sub btnExaminar_Click(sender As System.Object, e As System.EventArgs) Handles btnExaminar.Click
        Dim guiadbf As fguardardbf

        guiadbf = New fguardardbf
        Dim col1 = New DataGridViewCheckBoxColumn
        dgvDiarios.Columns.Add(col1)
        dgvDiarios.Columns(0).Name = "Seleccion"
        dgvDiarios.DataSource = guiadbf.mostrar()

        If dgvDiarios.Rows.Count <= 0 Then
            MsgBox("No hay guias pendientes.", MsgBoxStyle.Information)
            cbMostrar.Visible = False
        Else
            cbMostrar.Visible = True
        End If

    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        Dim cuenta As Integer
        Dim guiadbf As fguardardbf

        guiadbf = New fguardardbf

        Dim filtro As String

        cuenta = 0
        filtro = ""
        If dgvDiarios.Rows.Count > 0 Then
            For i As Integer = 0 To dgvDiarios.Rows.Count - 1
                If (dgvDiarios.Rows(i).Cells(0).Value <> Nothing) Then
                    cuenta += 1
                    filtro = filtro & "'" & dgvDiarios.Rows(i).Cells(20).Value & "',"
                End If
            Next
            filtro = filtro.TrimEnd(",")
            dgvTrazas.DataSource = guiadbf.mostrar_trazas(filtro)
            ' guiadbf.actualiza_lista_troza_dbf()

        End If

        
        'Exit Sub

        If cuenta > 0 Then
            If MsgBox("¿Desea pasar " & cuenta & " guia(s)?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'MsgBox("SI")

                guiadbf.insertar_listatrozasc(cuenta)
                dgvTrazas.DataSource = guiadbf.mostrar_cid()
                guiadbf.insertar_listatrozasd(cuenta)

                MsgBox("Proceso Finalizado.")


                dgvDiarios.Columns.Clear()
                dgvDiarios.DataSource = Nothing


                dgvTrazas.Columns.Clear()
                dgvTrazas.DataSource = Nothing

                btnExaminar.PerformClick()
            End If
        Else
            MsgBox("No hay guias seleccionadas para procesar", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub dgvDiarios_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDiarios.CellContentClick

        ' Detecta si se ha seleccionado el header de la grilla

        If (e.RowIndex = -1) Then
            Return
        End If
        If (dgvDiarios.Columns(e.ColumnIndex).Name = "Seleccion") Then

            ' Se toma la fila seleccionada
            Dim row As DataGridViewRow = dgvDiarios.Rows(e.RowIndex)


            ' Se selecciona la celda del checkbox
            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("Seleccion"), DataGridViewCheckBoxCell)

            If Convert.ToBoolean(cellSelecion.Value) Then
                row.DefaultCellStyle.BackColor = Color.Green
            Else
                row.DefaultCellStyle.BackColor = Color.White
            End If
        End If
    End Sub

    Private Sub dgvDiarios_CurrentCellDirtyStateChanged(sender As Object, e As System.EventArgs) Handles dgvDiarios.CurrentCellDirtyStateChanged
        If (dgvDiarios.IsCurrentCellDirty) Then
            dgvDiarios.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

   
    Private Sub cbMostrar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbMostrar.CheckedChanged
        If Not cbMostrar.ThreeState Then
            cbMostrar.ThreeState = True
            cbMostrar.CheckAlign = ContentAlignment.MiddleRight
            For Each fila As DataGridViewRow In dgvDiarios.Rows
                fila.Cells(0).Value = True
            Next
        Else
            cbMostrar.ThreeState = False
            cbMostrar.CheckAlign = ContentAlignment.MiddleLeft
            For Each fila As DataGridViewRow In dgvDiarios.Rows
                fila.Cells(0).Value = False
            Next
        End If

   
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class