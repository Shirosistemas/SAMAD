Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class conexion

    Protected cnn As New MySqlConnection
    Public idusuario As Integer

    ' - Funcion para Cerrar la Conexion a la Base de Datos
    Function dbClose() As Boolean
        Return DESCONECTADO()
    End Function



    Protected Function CONECTADO()
        Try
            cnn = New MySqlConnection(New fxSamad().GetCadenaConexionSamad())
            cnn.Open() 'Abriendo la conexion
            Dim db As New samadEntities
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Protected Function DESCONECTADO()
        Try
            If cnn.State = ConnectionState.Open Then 'Si el estado de la conexion esta abierta, la cerramos
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function


End Class
