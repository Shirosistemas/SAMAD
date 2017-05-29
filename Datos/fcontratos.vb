Imports System.Data.EntityClient
Imports MySql.Data.MySqlClient

Public Class fcontratos
    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando


    Public Function mostrar() As DataTable
        Try
            conectado() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_contratos") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            Dim da As New MySqlDataAdapter(cmd)

            Dim dt As New DataTable
            da.Fill(dt) 'Retornamos el contenido al adaptador
            Return dt
            ' Else
            ' Return Nothing 'Retornamos nada
            ' End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return Nothing 'Retornamos nada
        Finally
            desconectado()
        End Try
    End Function

    Public Function insertar(ByVal dts As vContratos) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("insertar_contratos") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vdescripcion", dts.gcondescripcion)
            cmd.Parameters.AddWithValue("vrecurso", dts.gconrecurso)
            cmd.Parameters.AddWithValue("vanno", dts.gconanno)
            cmd.Parameters.AddWithValue("vproid", dts.gconproid)

            Dim id = cmd.ExecuteScalar()
            If id > 0 Then
                fauditoria.insertar("contratos", "Insertar", id, dts.gcondescripcion)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function

    Public Function editar(ByVal dts As vContratos) As Boolean

        Try
            conectado()
            cmd = New MySqlCommand("editar_contratos") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("vid", dts.gconid)
            cmd.Parameters.AddWithValue("vdescripcion", dts.gcondescripcion)
            cmd.Parameters.AddWithValue("vrecurso", dts.gconrecurso)
            cmd.Parameters.AddWithValue("vanno", dts.gconanno)
            cmd.Parameters.AddWithValue("vproid", dts.gconproid)

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("contratos", "Editar", dts.gconid, dts.gcondescripcion)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function

    Public Function eliminar(ByVal dts As vContratos) As Boolean
        Try
            conectado()
            cmd = New MySqlCommand("eliminar_contratos") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("vid", MySqlDbType.VarChar, 50).Value = dts.gconid

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("contratos", "Eliminar", dts.gconid, "")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    ''' <summary>
    ''' Funcion para validar si el Numero de un Contrato existe en el Registro
    ''' </summary>
    ''' <param name="strContrato">Numero de contrato a validar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Function NumeroContratoExiste(ByVal strContrato As String) As Boolean
        Using dm As New samadEntities
            Dim nr = (From c In dm.contratos Where c.Con_Descripcion = strContrato Select c.Con_Descripcion).Count()
            Return IIf(nr > 0, True, False)
        End Using
    End Function

End Class

Public Class cdContratos

#Region "Mantenimiento a la Tabla Contratos(Altas, Bajas y Cambiios)"

    ''' <summary>
    ''' Funcion para agregar un Nuevo registro a la Contratos
    ''' </summary>
    ''' <param name="rs"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ContratoAgregar(ByVal rs As SAMAD.contratos) As Boolean
        Using dm As New samadEntities
            Try
                dm.AddTocontratos(rs)
                dm.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    ''' <summary>
    ''' Funcion para Editar el Los datos de un Contrato
    ''' </summary>
    ''' <param name="rs"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ContratoEditar(ByVal rs As SAMAD.contratos) As Boolean
        Using dm As New samadEntities
            ' obtenemos el Registro antes de modificarlo
            Dim ra As SAMAD.contratos = (From v In dm.contratos Where v.Con_id = rs.Con_id Select v).First()
            dm.contratos.Detach(ra)
            Dim rn As New SAMAD.contratos
            Try
                rn.Con_id = rs.Con_id
                dm.contratos.Attach(rn)
                dm.contratos.ApplyCurrentValues(rs)
                dm.SaveChanges()
                Return True
            Catch ex As Exception
                dm.Refresh(Objects.RefreshMode.ClientWins, ra)
                dm.SaveChanges()
                Return False
            End Try
        End Using
    End Function


#End Region

#Region "Funciones que devuelven Valores Booleanos"

    

    ''' <summary>
    ''' Funcion para Grabar o Editar los datos de un contrato
    ''' </summary>
    ''' <param name="rs"></param>
    ''' <param name="xExiste"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ContratoGrabar(ByVal rs As SAMAD.contratos, xExiste As Boolean) As Boolean
        If xExiste = False Then
            Return ContratoAgregar(rs)
        Else
            Return ContratoEditar(rs)
        End If
    End Function

#End Region

#Region "Funciones que Retornan Objetos Entidad"

    ''' <summary>
    ''' Funcion que devuelve los datos de un contrato seleccionado por el ID
    ''' </summary>
    ''' <param name="intId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetById(ByVal intId As Integer) As SAMAD.contratos
        Using dm As New samadEntities
            Dim dt = (From c In dm.contratos Where c.Con_id = intId Select c).First()
            Return dt
        End Using
    End Function

    ''' <summary>
    ''' Funcion que retorna una Lista de la Vista Mostrar Contratos
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function VistaContratos() As List(Of SAMAD.vmostrar_contratos)
        Using dm As New samadEntities
            Dim dt = (From vc In dm.vmostrar_contratos Select vc).ToList()
            Return dt
        End Using
    End Function

    Function lstContrato(ByVal intId As Integer) As IList
        Using dm As New samadEntities
            lstContrato = (From c In dm.contratos.Include("titulares") Where c.Con_id = intId Select New With {.id = c.Con_id, c.Con_Descripcion, c.Con_Anno, c.Con_Pro_Id, c.titulares.Pro_Titular}).ToList()
            'Return lst
        End Using
    End Function

#End Region

End Class
