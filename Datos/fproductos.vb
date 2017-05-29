Imports MySql.Data.MySqlClient
Public Class fproductos
    Inherits conexion 'Jalamos la clase conexion
    Dim cmd As New MySqlCommand 'Declaramos una variable comando

    Public Function mostrar() As DataTable
        Try
            conectado() 'Nos conectamos a la BD
            cmd = New MySqlCommand("mostrar_productos") 'Llamamos al procedimiento almacenado
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
            desconectado()
        End Try
    End Function

    Public Function insertar(ByVal dts As vProductos) As Boolean

        Try
            'conectado()
            'cmd = New MySqlCommand("insertar_productos") 'Llamamos al procedimiento almacenado
            'cmd.CommandType = CommandType.StoredProcedure
            'cmd.Connection = cnn

            ''Agregamos los parametros de PA a los metodos
            'cmd.Parameters.AddWithValue("vdescrip", dts.gdescrip)
            'cmd.Parameters.AddWithValue("vespesordesde", dts.gespesordesde)
            'cmd.Parameters.AddWithValue("vespesorhasta", dts.gespesorhasta)
            'cmd.Parameters.AddWithValue("vanchodesde", dts.ganchodesde)
            'cmd.Parameters.AddWithValue("vanchohasta", dts.ganchohasta)
            'cmd.Parameters.AddWithValue("vlargodesde", dts.glargodesde)
            'cmd.Parameters.AddWithValue("vlargohasta", dts.glargohasta)
            'cmd.Parameters.AddWithValue("vtipomaterial", dts.gtipoconteo)
            'cmd.Parameters.AddWithValue("vtipocorte", dts.gtipocorte)

            Dim db As New samadEntities
            Dim producto As New productos

            'producto.Prod_Descrip = dts.gdescrip
            'producto.Prod_EspesorDesde = dts.gespesordesde
            'producto.Prod_EspesorHasta = dts.gespesorhasta
            'producto.Prod_AnchoDesde = dts.ganchodesde
            'producto.Prod_AnchoHasta = dts.ganchohasta
            'producto.Prod_LargoDesde = dts.glargodesde
            'producto.Prod_LargoHasta = dts.glargohasta
            'producto.Prod_TipoMaterial = dts.gtipoconteo
            'producto.Prod_TipoCorte = dts.gtipocorte
            'producto.Prod_LineaProd = dts.glineaprod

            db.productos.AddObject(producto)
            db.SaveChanges()

            'Dim id = cmd.ExecuteScalar()
            Dim id = producto.Prod_Id
            If id > 0 Then
                fauditoria.insertar("productos", "Insertar", id, dts.gdescrip)
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

    Public Function editar(ByVal dts As vProductos) As Boolean

        Try
            'conectado()
            'cmd = New MySqlCommand("editar_productos") 'Llamamos al procedimiento almacenado
            'cmd.CommandType = CommandType.StoredProcedure
            'cmd.Connection = cnn

            ''Agregamos los parametros de PA a los metodos
            'cmd.Parameters.AddWithValue("vid", dts.gprod_id)
            'cmd.Parameters.AddWithValue("vdescrip", dts.gdescrip)
            'cmd.Parameters.AddWithValue("vespesordesde", dts.gespesordesde)
            'cmd.Parameters.AddWithValue("vespesorhasta", dts.gespesorhasta)
            'cmd.Parameters.AddWithValue("vanchodesde", dts.ganchodesde)
            'cmd.Parameters.AddWithValue("vanchohasta", dts.ganchohasta)
            'cmd.Parameters.AddWithValue("vlargodesde", dts.glargodesde)
            'cmd.Parameters.AddWithValue("vlargohasta", dts.glargohasta)
            'cmd.Parameters.AddWithValue("vtipomaterial", dts.gtipoconteo)
            'cmd.Parameters.AddWithValue("vtipocorte", dts.gtipocorte)

            Dim db As New samadEntities
            Dim idd As Integer = dts.gprod_id
            Dim producto = db.productos.FirstOrDefault(Function(p) p.Prod_Id = idd)
            'producto.Prod_Descrip = dts.gdescrip
            'producto.Prod_EspesorDesde = dts.gespesordesde
            'producto.Prod_EspesorHasta = dts.gespesorhasta
            'producto.Prod_AnchoDesde = dts.ganchodesde
            'producto.Prod_AnchoHasta = dts.ganchohasta
            'producto.Prod_LargoDesde = dts.glargodesde
            'producto.Prod_LargoHasta = dts.glargohasta
            'producto.Prod_TipoMaterial = dts.gtipoconteo
            'producto.Prod_TipoCorte = dts.gtipocorte
            'producto.Prod_LineaProd = dts.glineaprod
            db.SaveChanges()

            fauditoria.insertar("productos", "Editar", dts.gprod_id, dts.gdescrip)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function

    Public Function eliminar(ByVal dts As vProductos) As Boolean
        Try
            conectado()
            cmd = New MySqlCommand("eliminar_productos") 'Llamamos al procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Agregamos los parametros de PA a los metodos
            cmd.Parameters.Add("vid", MySqlDbType.VarChar, 50).Value = dts.gprod_id

            If cmd.ExecuteNonQuery Then
                fauditoria.insertar("productos", "Eliminar", dts.gprod_id, "")
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

End Class

Public Class cdProductos

#Region "Mantenimiento a la tabla de productos(Altas bajas y cambios)"


#End Region


#Region "Consults que retornan valores booleanos"


#End Region


#Region "Funciones que retornan Listas y entidades"

    ''' <summary>
    ''' Funcion que retorna todos los datos de un producto
    ''' </summary>
    ''' <param name="ProductoId">codigo de producto a filtrar</param>
    ''' <returns>entidad.Productos</returns>
    ''' <remarks></remarks>
    Function DatosdelProducto(ByVal ProductoId As Integer) As SAMAD.productos
        Using dm As New samadEntities
            Try
                Dim dt As SAMAD.productos = (From rs In dm.productos Where rs.Prod_Id = ProductoId Select rs)
                Return dt
            Catch ex As Exception
                Return New SAMAD.productos
            End Try
        End Using
    End Function

#End Region
End Class