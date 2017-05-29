Imports MySql.Data.MySqlClient
Public Class fEmpaquetado
    Inherits conexion
    Dim cmd As New MySqlCommand

    Public Function mostrar() As DataTable
        Try
            CONECTADO()
            cmd = New MySqlCommand("mostrar_empaquetado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            Dim da As New MySqlDataAdapter(cmd)

            Dim dt As New DataTable

            da.Fill(dt)

            Return dt

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return Nothing
        Finally
            DESCONECTADO()
        End Try
    End Function

    Public Function insertar(ByVal dts As vEmpaquetado) As Boolean

        Try
            CONECTADO()
            cmd = New MySqlCommand("insertar_empaquetado") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vEmp_NroDoc", dts.gEmp_NroDoc)
            cmd.Parameters.AddWithValue("vEmp_Fecha", dts.gEmp_Fecha)
            cmd.Parameters.AddWithValue("vEmp_Certificado", dts.gEmp_Certificado)
            cmd.Parameters.AddWithValue("vEmp_AserraderoId", dts.gEmp_AserraderoId)

            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("empaquetado", "Insertar", id, dts.gEmp_NroDoc)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            DESCONECTADO()
        End Try

    End Function

    Public Function editar(ByVal dts As vEmpaquetado) As Boolean

        Try
            CONECTADO()
            cmd = New MySqlCommand("editar_empaquetado") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos 
            cmd.Parameters.AddWithValue("vEmp_id", dts.gEmp_Id)
            cmd.Parameters.AddWithValue("vEmp_NroDoc", dts.gEmp_NroDoc)
            cmd.Parameters.AddWithValue("vEmp_Fecha", dts.gEmp_Fecha)
            cmd.Parameters.AddWithValue("vEmp_Certificado", dts.gEmp_Certificado)
            cmd.Parameters.AddWithValue("vEmp_AserraderoId", dts.gEmp_AserraderoId)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("empaquetado", "Editar", dts.gEmp_Id, dts.gEmp_NroDoc)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            DESCONECTADO()
        End Try

    End Function

    Public Function eliminar(ByVal dts As vEmpaquetado) As Boolean

        Try
            CONECTADO()
            cmd = New MySqlCommand("eliminar_empaquetado") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos 
            cmd.Parameters.AddWithValue("vEmp_id", dts.gEmp_Id)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("empaquetado", "Eliminar", dts.gEmp_Id, "")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            DESCONECTADO()
        End Try

    End Function

End Class


Public Class cdEmpaquetado

#Region "Mantenimiento a la Tabla de Empaquetado"

    ''' <summary>
    ''' Funcion para agregar un nuevo registro a la Tabla Empaquetado
    ''' </summary>
    ''' <param name="rs"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function PaqueteHeaderAgregar(ByVal rs As SAMAD.empaquetado) As Boolean
        Using dm As New samadEntities
            Try
                dm.AddToempaquetado(rs)
                dm.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    ''' <summary>
    ''' Funcion para Editar un Registro del Encabezado de los paquete
    ''' </summary>
    ''' <param name="rs"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PaqueteHeaderEditar(ByVal rs As SAMAD.empaquetado) As Boolean
        Using dm As New samadEntities
            ' obtenemos el Registro antes de modificarlo
            Dim ra As SAMAD.empaquetado = (From v In dm.empaquetado Where v.RowId = rs.RowId Select v).First()
            dm.empaquetado.Detach(ra)
            Dim rn As New SAMAD.empaquetado
            Try
                rn.RowId = rs.RowId
                dm.empaquetado.Attach(rn)
                dm.empaquetado.ApplyCurrentValues(rs)
                dm.SaveChanges()
                Return True
            Catch ex As Exception
                dm.Refresh(Objects.RefreshMode.ClientWins, ra)
                dm.SaveChanges()
                Return False
            End Try
        End Using
    End Function


    Function PaqueteHeaderGrabar(ByVal rs As SAMAD.empaquetado, xexiste As Boolean) As Boolean
        If xexiste = True Then
            ' Editar
            Return PaqueteHeaderEditar(rs)
        Else
            Return PaqueteHeaderAgregar(rs)
        End If
    End Function

#End Region


#Region "Funciones que retornan objetos Entidad"


    Function HeaderPakeque() As SAMAD.vw_empaquetado
        Using dm As New samadEntities
            Dim dt As SAMAD.vw_empaquetado = (From x In dm.vw_empaquetado Select x)
            Return (dt)
        End Using
    End Function

    Function PakequeHeaderLista() As List(Of SAMAD.vw_empaquetado)
        Using dm As New samadEntities
            Dim ls = (From x In dm.vw_empaquetado Select x).ToList()
            Return ls
        End Using
    End Function

#End Region


#Region "Funciones Miscelaneas"

    ''' <summary>
    ''' Genera el Numero de Documento continuo segun el Periodo
    ''' </summary>
    ''' <param name="strPeriodo">Periodo del Documento - es el año </param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function NumeroEmpaquetado(ByVal strPeriodo As String) As String
        Using dm As New samadEntities
            ' Primer Metodo
            'Dim UltimoNumero = dm.empaquetado.Where(Function(x) Year(x.Emp_Fecha) = strPeriodo).Select(Function(x) x.Emp_NroDoc).Max()
            'Segundo Metodo
            Dim UltimoNumero = (From x In dm.empaquetado Where Year(x.Emp_Fecha) = strPeriodo Select x.Emp_NroDoc).Max()

            NumeroEmpaquetado = New fxSamad().StrCeros(UltimoNumero, 6, True)
        End Using
    End Function

    Function EmpaquetadoPaquetes(ByVal intPapaPaquete As Integer) As Boolean
        Using dm As New samadEntities
            Dim nr = (From x In dm.paquete Where x.EmpaquetadoId = intPapaPaquete Select x.EmpaquetadoId).Count()
            Return IIf(nr > 0, True, False)
        End Using
    End Function
#End Region
End Class