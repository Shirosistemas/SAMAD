Imports System.IO
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class fguardardbf
    Inherits conexion 'Jalamos la clase conexion


    Public Sub migrar_guiatf_dbf()
        Dim cmdAccion As New MySqlCommand 'Declaramos una variable comando

        'Dim cad As String = "Database=samad;Data Source=localhost;User Id=root;Password=159753"
        Dim query As String = "truncate table guiatf_dbf"
        Dim sBase As String = "C:\SimaFor\Importa_GTF_aserrio\GUIAS_TFS.dbf"
        Dim sSelect As String = "SELECT * FROM GUIAS_TFS"

        Try
            If File.Exists(sBase) Then
                CONECTADO() 'Nos conectamos a la BD
                cmdAccion.Connection = cnn
                cmdAccion.CommandText = query
                cmdAccion.CommandType = CommandType.Text
                cmdAccion.ExecuteNonQuery()
            Else

                MsgBox("No se puede leer el archivo " & sBase, MsgBoxStyle.Critical, "Error de lectura")
                Exit Sub

            End If
        Catch ex As Exception

            Exit Sub
        End Try

        Try
            Dim sConn As String

            sConn = ("Provider=Microsoft.Jet.OLEDB.4.0;" & _
            "Extended Properties='dBASE 5.0';" & _
            "Data Source=" & System.IO.Path.GetDirectoryName(sBase))

            Using dbconn As New OleDb.OleDbConnection(sConn)
                Try
                    dbconn.Open()
                    Dim cmd As OleDb.OleDbCommand = dbconn.CreateCommand()
                    cmd.CommandText = sSelect
                    Dim da As New OleDb.OleDbDataAdapter(cmd)
                    Dim dt As New DataTable

                    da.Fill(dt)

                    '---------------------------
                    'Insertamos datos MySQL
                    '---------------------------
                    Dim ifila = 0
                    Dim cadena = "insert into guiatf_dbf (CID, IDGUIA, NRO_VIAJE, GUI_UBIGEO, NRO_GTF, NOM_ATFFS, FECHA_ENV, FECHA_VENC, ZAFRA, PCA, TITULAR, CONTRATO, PROPIETARI, TIPO_CV, NRO_CV, DESTINATAR, NRGUIA_REM, TRANSPORTE, CONDUCTOR, CIDV) values "
                    Dim fecha1, fecha2 As String
                    For ifila = 0 To dt.Rows.Count - 1
                        If ifila = dt.Rows.Count - 1 Then
                            fecha1 = Format(dt.Rows(ifila).Item(6), "yyyy-MM-dd")
                            fecha2 = Format(dt.Rows(ifila).Item(7), "yyyy-MM-dd")
                            cadena = cadena & "('" & RTrim(dt.Rows(ifila).Item(0).ToString) & "','" & RTrim(dt.Rows(ifila).Item(1).ToString) & "','" _
                            & RTrim(dt.Rows(ifila).Item(2).ToString) & "','" & RTrim(dt.Rows(ifila).Item(3).ToString) & "','" & RTrim(dt.Rows(ifila).Item(4).ToString) _
                            & "','" & RTrim(dt.Rows(ifila).Item(5).ToString) & "','" & fecha1 & "','" & fecha2 & "','" & RTrim(dt.Rows(ifila).Item(8).ToString) & "','" _
                            & RTrim(dt.Rows(ifila).Item(9).ToString) & "','" & RTrim(dt.Rows(ifila).Item(10).ToString) & "','" & RTrim(dt.Rows(ifila).Item(11).ToString) & "','" _
                            & RTrim(dt.Rows(ifila).Item(12).ToString) & "','" & RTrim(dt.Rows(ifila).Item(13).ToString) & "','" & RTrim(dt.Rows(ifila).Item(14).ToString) _
                            & "','" & RTrim(dt.Rows(ifila).Item(15).ToString) & "','" & RTrim(dt.Rows(ifila).Item(16).ToString) & "','" & RTrim(dt.Rows(ifila).Item(17).ToString) _
                            & "','" & RTrim(dt.Rows(ifila).Item(18).ToString) & "','" & RTrim(dt.Rows(ifila).Item(19).ToString) & "')"
                        Else
                            fecha1 = Format(dt.Rows(ifila).Item(6), "yyyy-MM-dd")
                            fecha2 = Format(dt.Rows(ifila).Item(7), "yyyy-MM-dd")
                            cadena = cadena & "('" & RTrim(dt.Rows(ifila).Item(0).ToString) & "','" & RTrim(dt.Rows(ifila).Item(1).ToString) & "','" & RTrim(dt.Rows(ifila).Item(2).ToString) & "','" & RTrim(dt.Rows(ifila).Item(3).ToString) & "','" & RTrim(dt.Rows(ifila).Item(4).ToString) & "','" & RTrim(dt.Rows(ifila).Item(5).ToString) & "','" & fecha1 & "','" & fecha2 & "','" & RTrim(dt.Rows(ifila).Item(8).ToString) & "','" & RTrim(dt.Rows(ifila).Item(9).ToString) & "','" & RTrim(dt.Rows(ifila).Item(10).ToString) & "','" & RTrim(dt.Rows(ifila).Item(11).ToString) & "','" & RTrim(dt.Rows(ifila).Item(12).ToString) & "','" & RTrim(dt.Rows(ifila).Item(13).ToString) & "','" & RTrim(dt.Rows(ifila).Item(14).ToString) & "','" & RTrim(dt.Rows(ifila).Item(15).ToString) & "','" & RTrim(dt.Rows(ifila).Item(16).ToString) & "','" & RTrim(dt.Rows(ifila).Item(17).ToString) & "','" & RTrim(dt.Rows(ifila).Item(18).ToString) & "','" & RTrim(dt.Rows(ifila).Item(19).ToString) & "'),"
                        End If

                        System.Windows.Forms.Application.DoEvents()
                    Next


                    cmdAccion.CommandText = cadena
                    cmdAccion.CommandType = CommandType.Text
                    cmdAccion.ExecuteNonQuery()
                    DESCONECTADO()

                    'FrmImportarGTF.dgvDiarios.DataSource = dt

                    dbconn.Close()

                Catch ex As InvalidOperationException
                    MessageBox.Show("Error InvalidOperationException MySQL" & vbCrLf & ex.Message)
                Catch ex As Exception
                    MessageBox.Show("Error al abrir la base de datos" & vbCrLf & ex.Message)
                    Exit Sub
                End Try
            End Using

            '----------------------------------



        Catch ex As InvalidOperationException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        MessageBox.Show("Las guias fueron migradas", "Aviso SAMAD", MessageBoxButtons.OK)

    End Sub

    Public Sub migrar_lista_trozas_dbf()
        Dim cmdAccion As New MySqlCommand 'Declaramos una variable comando

        ' Dim cad As String = "Database=samad;Data Source=localhost;User Id=root;Password=159753"
        Dim query As String = "truncate table lista_trozas_dbf"
        Dim sBase As String = "C:\SimaFor\Importa_GTF_aserrio\LISTA_TROZAS.dbf"
        Dim sSelect As String = "SELECT * FROM LISTA_TROZAS"

        Try
            If File.Exists(sBase) Then
                CONECTADO() 'Nos conectamos a la BD
                cmdAccion.Connection = cnn
                cmdAccion.CommandText = query
                cmdAccion.CommandType = CommandType.Text
                cmdAccion.ExecuteNonQuery()
            Else

                MsgBox("No se puede leer el archivo " & sBase, MsgBoxStyle.Critical, "Error de lectura")
                Exit Sub

            End If
        Catch ex As Exception

            Exit Sub
        End Try

        Try
            Dim sConn As String

            sConn = ("Provider=Microsoft.Jet.OLEDB.4.0;" & _
            "Extended Properties='dBASE 5.0';" & _
            "Data Source=" & System.IO.Path.GetDirectoryName(sBase))

            Using dbconn As New OleDb.OleDbConnection(sConn)
                Try
                    dbconn.Open()
                    Dim cmd As OleDb.OleDbCommand = dbconn.CreateCommand()
                    cmd.CommandText = sSelect
                    Dim da As New OleDb.OleDbDataAdapter(cmd)
                    Dim dt As New DataTable

                    da.Fill(dt)
                    Dim db As New SAMAD.guiatf_dbf

                    '---------------------------
                    'Insertamos datos MySQL
                    '---------------------------
                    Dim ifila = 0
                    Dim cadena = "insert into lista_trozas_dbf (CID, TITULA, ZAFRA, PCA, NRO_GTF, CORRELA, ESPECIE, PLACA, D1, D2, D3, VOLM3, NRO_LISTA_) values "
                    Dim NRO As String

                    For ifila = 0 To dt.Rows.Count - 1
                        If ifila = dt.Rows.Count - 1 Then
                            NRO = "0" + RTrim(dt.Rows(ifila).Item(4).ToString)
                            cadena = cadena & "('" & RTrim(dt.Rows(ifila).Item(0).ToString) & "','" & RTrim(dt.Rows(ifila).Item(1).ToString) & "','" & RTrim(dt.Rows(ifila).Item(2).ToString) & "','" & RTrim(dt.Rows(ifila).Item(3).ToString) & "','" & NRO & "','" & RTrim(dt.Rows(ifila).Item(5).ToString) & "','" & RTrim(dt.Rows(ifila).Item(6).ToString) & "','" & RTrim(dt.Rows(ifila).Item(7).ToString) & "','" & RTrim(dt.Rows(ifila).Item(8).ToString) & "','" & RTrim(dt.Rows(ifila).Item(9).ToString) & "','" & RTrim(dt.Rows(ifila).Item(10).ToString) & "','" & RTrim(dt.Rows(ifila).Item(11).ToString) & "','" & RTrim(dt.Rows(ifila).Item(12).ToString) & "')"
                        Else
                            NRO = "0" + RTrim(dt.Rows(ifila).Item(4).ToString)
                            cadena = cadena & "('" & RTrim(dt.Rows(ifila).Item(0).ToString) & "','" & RTrim(dt.Rows(ifila).Item(1).ToString) & "','" & RTrim(dt.Rows(ifila).Item(2).ToString) & "','" & RTrim(dt.Rows(ifila).Item(3).ToString) & "','" & NRO & "','" & RTrim(dt.Rows(ifila).Item(5).ToString) & "','" & RTrim(dt.Rows(ifila).Item(6).ToString) & "','" & RTrim(dt.Rows(ifila).Item(7).ToString) & "','" & RTrim(dt.Rows(ifila).Item(8).ToString) & "','" & RTrim(dt.Rows(ifila).Item(9).ToString) & "','" & RTrim(dt.Rows(ifila).Item(10).ToString) & "','" & RTrim(dt.Rows(ifila).Item(11).ToString) & "','" & RTrim(dt.Rows(ifila).Item(12).ToString) & "'),"
                        End If

                        System.Windows.Forms.Application.DoEvents()
                    Next



                    cmdAccion.CommandText = cadena
                    cmdAccion.CommandType = CommandType.Text
                    cmdAccion.ExecuteNonQuery()
                    DESCONECTADO()

                    FrmImportarGTF.dgvDiarios.DataSource = dt

                    dbconn.Close()

                Catch ex As InvalidOperationException
                    MessageBox.Show("Error InvalidOperationException MySQL" & vbCrLf & ex.Message)
                Catch ex As Exception
                    MessageBox.Show("Error al abrir la base de datos" & vbCrLf & ex.Message)
                    Exit Sub
                End Try
            End Using

            '----------------------------------


        Catch ex As InvalidOperationException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function mostrar_trazas(v As String) As DataTable
        Dim cmd As New MySqlCommand 'Declaramos una variable comando
        Dim cadena As String
        Try

            CONECTADO() 'Nos conectamos a la BD
            cadena = "select * from lista_trozas_dbf where cid in (" & v & ")"
            cmd.Connection = cnn
            cmd.CommandText = cadena
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()

            'If cmd.ExecuteNonQuery Then 'Si la consulta contiene información

            Dim da As New MySqlDataAdapter(cmd)

            Dim dt As New DataTable
            da.Fill(dt) 'Retornamos el contenido al adaptador
            Return dt
            ' Else
            ' Return Nothing 'Retornamos nada
            ' End If
        Catch ex As Exception
            MsgBox("Mensaje2:" + ex.ToString)
            Return Nothing 'Retornamos nada
        Finally
            DESCONECTADO()
        End Try
    End Function

    Public Function mostrar() As DataTable
        Dim cmd As New MySqlCommand 'Declaramos una variable comando
        Try

            CONECTADO() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_consulta_gtf") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'If cmd.ExecuteNonQuery Then 'Si la consulta contiene información

            Dim da As New MySqlDataAdapter(cmd)

            Dim dt As New DataTable
            da.Fill(dt) 'Retornamos el contenido al adaptador
            Return dt
            ' Else
            ' Return Nothing 'Retornamos nada
            ' End If
        Catch ex As Exception
            MsgBox("Mensaje2:" + ex.ToString)
            Return Nothing 'Retornamos nada
        Finally
            DESCONECTADO()
        End Try
    End Function

    Public Function mostrar_cid() As DataTable
        Dim cmd As New MySqlCommand 'Declaramos una variable comando
        Try

            CONECTADO() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_consulta_cid") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'If cmd.ExecuteNonQuery Then 'Si la consulta contiene información

            Dim da As New MySqlDataAdapter(cmd)

            Dim dt As New DataTable
            da.Fill(dt) 'Retornamos el contenido al adaptador
            Return dt
            ' Else
            ' Return Nothing 'Retornamos nada
            ' End If
        Catch ex As Exception
            MsgBox("Mensaje2:" + ex.ToString)
            Return Nothing 'Retornamos nada
        Finally
            DESCONECTADO()
        End Try
    End Function

    Public Sub insertar_listatrozasc(ByVal numero As Integer)
        Dim cmdAccion As New MySqlCommand 'Declaramos una variable comando
        Dim a As Integer
        Dim cadena As String

        'CONECTADO()
        cadena = ""
        a = FrmImportarGTF.dgvDiarios.Rows.Count

        If FrmImportarGTF.dgvDiarios.Rows.Count > 0 Then
            Try
                For i As Integer = 0 To FrmImportarGTF.dgvDiarios.Rows.Count - 1
                    If (FrmImportarGTF.dgvDiarios.Rows(i).Cells(0).Value <> Nothing) Then
                        '---------------------------
                        'Insertamos datos MySQL
                        '--------------------------- FrmImportarGTF.dgvDiarios.Rows(i).Cells(1).Value


                        Dim fecha1, fecha2 As String
                        cadena = ""
                        fecha1 = ""
                        fecha2 = ""
                        cadena = "insert into listatrozasc (Lt_Ubigeo, Lt_Nrogtf, Lt_Fecha, Lt_fecha_ven, Lt_Titular_Id, Lt_Propietario_Id, Lt_Contrato_Id, Lt_Poa_Id, Lt_Zafra, Lt_Transporte_Id, Lt_Conductor_Id, Lt_Destinatario_Id, Lt_Tipo_Cv, Lt_Nro_Cv, Lt_NroGuia_rem,  Lt_TipoDimension, Lt_Deffs, Lt_unidad, Estatus, Lt_CID) values "

                        fecha1 = Format(FrmImportarGTF.dgvDiarios.Rows(i).Cells(4).Value, "yyyy-MM-dd")
                        fecha2 = Format(FrmImportarGTF.dgvDiarios.Rows(i).Cells(5).Value, "yyyy-MM-dd")
                        cadena = cadena & "('" & RTrim(FrmImportarGTF.dgvDiarios.Rows(i).Cells(2).Value) & "','" & RTrim(FrmImportarGTF.dgvDiarios.Rows(i).Cells(1).Value) & "','" _
                        & fecha1 & "','" & fecha2 & "','" & RTrim(FrmImportarGTF.dgvDiarios.Rows(i).Cells(9).Value) & "','" _
                        & RTrim(FrmImportarGTF.dgvDiarios.Rows(i).Cells(13).Value) & "','" & RTrim(FrmImportarGTF.dgvDiarios.Rows(i).Cells(10).Value) & "','" & RTrim(FrmImportarGTF.dgvDiarios.Rows(i).Cells(12).Value) & "','" _
                        & RTrim(FrmImportarGTF.dgvDiarios.Rows(i).Cells(11).Value) & "','" & RTrim(FrmImportarGTF.dgvDiarios.Rows(i).Cells(17).Value) & "','" & RTrim(FrmImportarGTF.dgvDiarios.Rows(i).Cells(18).Value) & "','" _
                        & RTrim(FrmImportarGTF.dgvDiarios.Rows(i).Cells(16).Value) & "','" & RTrim(FrmImportarGTF.dgvDiarios.Rows(i).Cells(14).Value) & "','" & RTrim(FrmImportarGTF.dgvDiarios.Rows(i).Cells(15).Value) & "','" _
                        & RTrim(FrmImportarGTF.dgvDiarios.Rows(i).Cells(19).Value) & "','" & "" & "','" _
                        & RTrim(FrmImportarGTF.dgvDiarios.Rows(i).Cells(3).Value) & "','" & "Smalian" & "','" & "0" & "','" & RTrim(FrmImportarGTF.dgvDiarios.Rows(i).Cells(20).Value) & "')"


                        CONECTADO() 'Nos conectamos a la BD
                        cmdAccion.Connection = cnn
                        cmdAccion.CommandText = cadena
                        cmdAccion.CommandType = CommandType.Text
                        cmdAccion.ExecuteNonQuery()
                        DESCONECTADO()


                        System.Windows.Forms.Application.DoEvents()


                    End If
                Next ' Fin FOR


            Catch ex As InvalidOperationException
                MessageBox.Show("Error InvalidOperationException MySQL" & vbCrLf & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error al abrir la base de datos" & vbCrLf & ex.Message)
                Exit Sub
            End Try

        End If

    End Sub

    Public Sub insertar_listatrozasd(ByVal numero As Integer)
        Dim cmdAccion As New MySqlCommand 'Declaramos una variable comando
        Dim a As Integer
        Dim cadena As String

        'CONECTADO()
        cadena = ""
        a = FrmImportarGTF.dgvTrazas.Rows.Count

        If FrmImportarGTF.dgvTrazas.Rows.Count > 0 Then
            Try
                For i As Integer = 0 To FrmImportarGTF.dgvTrazas.Rows.Count - 1
                    If (FrmImportarGTF.dgvTrazas.Rows(i).Cells(0).Value <> Nothing) Then
                        '---------------------------
                        'Insertamos datos MySQL
                        '--------------------------- FrmImportarGTF.dgvDiarios.Rows(i).Cells(1).Value


                        cadena = ""
                        cadena = "insert into listatrozasd (EspecieId, Ltd_Especie, Ltd_Codificacion, Ltd_D1, Ltd_D2, Ltd_D3, Ltd_Vol_M3, Ltd_Lt_Id, Estatus) values "

                        cadena = cadena & "('" & RTrim(FrmImportarGTF.dgvTrazas.Rows(i).Cells(0).Value) & "','" & RTrim(FrmImportarGTF.dgvTrazas.Rows(i).Cells(1).Value) & "','" _
                        & RTrim(FrmImportarGTF.dgvTrazas.Rows(i).Cells(2).Value) & "','" & RTrim(FrmImportarGTF.dgvTrazas.Rows(i).Cells(3).Value) & "','" & RTrim(FrmImportarGTF.dgvTrazas.Rows(i).Cells(4).Value) & "','" _
                        & RTrim(FrmImportarGTF.dgvTrazas.Rows(i).Cells(5).Value) & "','" & RTrim(FrmImportarGTF.dgvTrazas.Rows(i).Cells(6).Value) & "','" & RTrim(FrmImportarGTF.dgvTrazas.Rows(i).Cells(7).Value) & "','" & "0" & "')"


                        CONECTADO() 'Nos conectamos a la BD
                        cmdAccion.Connection = cnn
                        cmdAccion.CommandText = cadena
                        cmdAccion.CommandType = CommandType.Text
                        cmdAccion.ExecuteNonQuery()
                        DESCONECTADO()


                        System.Windows.Forms.Application.DoEvents()


                    End If
                Next ' Fin FOR


            Catch ex As InvalidOperationException
                MessageBox.Show("Error InvalidOperationException MySQL" & vbCrLf & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error al abrir la base de datos" & vbCrLf & ex.Message)
                Exit Sub
            End Try

        End If

    End Sub

    Public Sub actualiza_lista_troza_dbf()
        Dim cmdAccion As New MySqlCommand 'Declaramos una variable comando
        Dim a As Integer
        Dim cadena As String

        Dim query As String = "truncate table lista_trozas_dbf"
        CONECTADO() 'Nos conectamos a la BD
        cmdAccion.Connection = cnn
        cmdAccion.CommandText = query
        cmdAccion.CommandType = CommandType.Text
        cmdAccion.ExecuteNonQuery()


        'CONECTADO()
        cadena = ""
        a = FrmImportarGTF.dgvTrazas.Rows.Count

        If FrmImportarGTF.dgvTrazas.Rows.Count > 0 Then
            Try
                For i As Integer = 0 To FrmImportarGTF.dgvTrazas.Rows.Count - 1
                    If (FrmImportarGTF.dgvTrazas.Rows(i).Cells(0).Value <> Nothing) Then
                        '---------------------------
                        'Insertamos datos MySQL
                        '--------------------------- 

                        cadena = "insert into lista_trozas_dbf (CID, TITULA, ZAFRA, PCA, NRO_GTF, CORRELA, ESPECIE, PLACA, D1, D2, D3, VOLM3, NRO_LISTA_) values "

                        cadena = cadena & "('" & RTrim(FrmImportarGTF.dgvTrazas.Rows(i).Cells(0).Value) & "','" & RTrim(FrmImportarGTF.dgvTrazas.Rows(i).Cells(1).Value) & "','" & RTrim(FrmImportarGTF.dgvTrazas.Rows(i).Cells(2).Value) & "','" _
                                & RTrim(FrmImportarGTF.dgvTrazas.Rows(i).Cells(3).Value) & "','" & RTrim(FrmImportarGTF.dgvTrazas.Rows(i).Cells(4).Value) & "','" & RTrim(FrmImportarGTF.dgvTrazas.Rows(i).Cells(5).Value) & "','" _
                                & RTrim(FrmImportarGTF.dgvTrazas.Rows(i).Cells(6).Value) & "','" & RTrim(FrmImportarGTF.dgvTrazas.Rows(i).Cells(7).Value) & "','" & RTrim(FrmImportarGTF.dgvTrazas.Rows(i).Cells(8).Value) & "','" _
                                & RTrim(FrmImportarGTF.dgvTrazas.Rows(i).Cells(9).Value) & "','" & RTrim(FrmImportarGTF.dgvTrazas.Rows(i).Cells(10).Value) & "','" & RTrim(FrmImportarGTF.dgvTrazas.Rows(i).Cells(11).Value) & "','" _
                                & RTrim(FrmImportarGTF.dgvTrazas.Rows(i).Cells(12).Value) & "')"

                        'cmdAccion.Connection = cnn
                        cmdAccion.CommandText = cadena
                        cmdAccion.CommandType = CommandType.Text
                        cmdAccion.ExecuteNonQuery()
                        DESCONECTADO()


                        System.Windows.Forms.Application.DoEvents()


                    End If
                Next ' Fin FOR


            Catch ex As InvalidOperationException
                MessageBox.Show("Error InvalidOperationException MySQL" & vbCrLf & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error al abrir la base de datos" & vbCrLf & ex.Message)
                Exit Sub
            End Try

        End If

    End Sub


End Class
