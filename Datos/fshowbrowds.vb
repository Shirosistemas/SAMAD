Imports MySql.Data.MySqlClient
Public Class fshowbrowds
    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando
    Public Function mostrar(ByVal dts As vShowbrow) As DataSet
        Try
            conectado() 'Nos conectamos a la BD
            cmd = New MySqlCommand("showbrow") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.AddWithValue("tabla", dts.gt_tabla)
            cmd.Parameters.AddWithValue("campos", dts.gt_campos)
            cmd.Parameters.AddWithValue("donde", dts.gt_donde)
            cmd.Parameters.AddWithValue("agruparpor", dts.gt_agruparpor)
            cmd.Parameters.AddWithValue("ordenarpor", dts.gt_ordenarpor)

            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet

            da.Fill(ds) 'Retornamos el contenido al adaptador
            Return ds
            'End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return Nothing 'Retornamos nada
        Finally
            desconectado()
        End Try
    End Function
End Class
