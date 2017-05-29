Imports System.Net

Module fauditoria

    Public Sub insertar(ByVal tabla As String, ByVal accion As String, ByVal id As Integer, ByVal datos As String)
        Try
            Dim db As New samadEntities
            Dim a As New auditoria
            a.Aud_Fecha = DateTime.Now
            a.Aud_Tabla = tabla
            a.Aud_Accion = accion
            a.Aud_Id_Registro = id
            a.Aud_Datos = datos
            a.Aud_id_Usuario = vInfraestructura.Usuario.gus_id
            Try
                a.Aud_nombre_pc = My.Computer.Name
                a.Aud_ip = getIp()
            Catch ex As Exception

            End Try

            db.auditoria.AddObject(a)
            db.SaveChanges()

        Catch ex As Exception
            MsgBox("Auditoria: " + ex.ToString)
        End Try
    End Sub

    Public Function getIp() As String

        Dim valorIp As String

        valorIp = Dns.GetHostEntry(My.Computer.Name).AddressList.FirstOrDefault(Function(i) i.AddressFamily = Sockets.AddressFamily.InterNetwork).ToString()

        Return valorIp

    End Function

End Module

