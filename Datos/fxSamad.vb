Imports System.Configuration
Imports System.ServiceProcess
Imports MySql.Data.MySqlClient

Public Class fxSamad

    Public Const Titulo = "SAMAD ~ Sistema de Aserrío de Madera"

#Region "Funciones Protegidas"

    ' Esta funcion Genera la Cadena de Conexion a la base de Datos
    Protected Function CadenaConexionSamad() As String
        Dim xConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim xSeccion As ConnectionStringsSection = xConf.GetSection("connectionStrings")
        CadenaConexionSamad = xSeccion.ConnectionStrings("SAMAD.My.MySettings.strMysqlConexion").ConnectionString
    End Function

    ' Esta funcion retorna la cadena de Conexion a Mysql como root --159753
    Protected Function CadenaConexionMysql() As String
        CadenaConexionMysql = "server=localhost;user id=root;password=159753;persistsecurityinfo=True;database=mysql"
    End Function


#End Region


    ''' <summary>
    ''' Funcion que indica si debe Configurarse el AppSetting
    ''' </summary>
    ''' <returns>True or False</returns>
    ''' <remarks></remarks>

    Public Function ConfigurarAppSetting() As Boolean
        ConfigurarAppSetting = My.Settings.Configurar
    End Function

    ' - Funcion para Abrir Conexion a la Base de Datos
    Public Function OpenConecctionSamad() As Boolean
        Try
            Dim xCnn = New MySqlConnection(CadenaConexionSamad())
            xCnn.Open()
            xCnn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Esta funcion verifica si se puede Iniciar sesion como root al Server Mysql
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function OpenConecctionMysql() As Boolean
        Dim strCadena As String = CadenaConexionMysql()
        Dim xCnn As New MySqlConnection(strCadena)
        Try
            xCnn.Open()
            xCnn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    ''' <summary>
    ''' Funcion que retorna la Cadena de Conexion para la base de datos Mysql
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetCadenaConexionSamad() As String
        GetCadenaConexionSamad = CadenaConexionSamad()
    End Function

    ''' <summary>
    ''' Funcion que retorna la Cadena de Cionexion a Mysql como usuario root
    ''' </summary>
    ''' <returns>Cadena de conexion</returns>
    ''' <remarks></remarks>
    Public Function GetCadenaCionexionMysql() As String
        GetCadenaCionexionMysql = CadenaConexionMysql()
    End Function

#Region "Funciones Miscelaneas"

    ' - Funcion para verificar si un Formulario esta abierto
    Public Function FormularioAbierto(ByVal strFormName As String) As Boolean
        For Each frm As Form In My.Application.OpenForms
            If (frm.Name.ToLower() = strFormName.ToLower()) Then Return True
        Next
        Return False
    End Function

    ''' <summary>
    ''' Verifica si el Servicio de Mysql esta Instalado en Windows
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ServicioMysql() As Boolean
        Try
            Dim xService As New ServiceProcess.ServiceController("MySQL")
            If xService.Status = ServiceControllerStatus.Running Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Funcion para Iniciar el Servicio de Mysql como servidor local
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function IniciarServicioMysql() As Boolean
        Dim procStartInfo As New ProcessStartInfo
        Dim iniciaServer As New ProcessStartInfo
        Dim procExecuting As New Process
        Dim serverExecuting As New Process
        'Dim comando As String
        With procStartInfo
            .UseShellExecute = True
            .FileName = Application.StartupPath.ToString() & "\Mysql\bin\mysqld.exe"
            '.FileName = "D:\mysql\bin\mysqld.exe"
            .Arguments = "--install"
            .Verb = "runas"
            '.FileName = "C:\mysql\Mysql\bin\mysqld.exe"
            .WindowStyle = ProcessWindowStyle.Normal
            'If System.Environment.OSVersion.Version.Major >= 6 Then
            '    '-Inicia el servicio como administrador
            '    .Verb = "runas"
            'End If
        End With

        With iniciaServer
            .UseShellExecute = True
            .FileName = "net"
            .Arguments = "start mysql"
            .Verb = "runas"
        End With

        Try
            procExecuting = Process.Start(procStartInfo)
            serverExecuting = Process.Start(iniciaServer)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    ''' <summary>
    ''' Funcion para crear la base de datos samad
    ''' </summary>
    ''' <returns>True or False</returns>
    ''' <remarks></remarks>
    Function CreardBaseSamad() As Boolean
        Dim xCnn As New MySqlConnection(New fxSamad().CadenaConexionMysql())
        Try
            Dim xCmd As New MySqlCommand("create DATABASE If not exists samad", xCnn)
            Dim xUse As New MySqlCommand("use samad", xCnn)
            xCnn.Open()
            xCmd.ExecuteNonQuery()
            xUse.ExecuteNonQuery()
            xCnn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    ''' <summary>
    ''' Funcion para verificar si el Servicio Mysql esta corriendo en localhost(Funcion no Oficial final)
    ''' </summary>
    ''' <returns>True or False</returns>
    ''' <remarks></remarks>
    Function ServicioMysqlIsRunning() As Boolean
        Dim strCadena As String = CadenaConexionMysql()
        Dim xCnn As New MySqlConnection(strCadena)
        Try
            xCnn.Open()
            xCnn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function StrCeros(ByVal xValor As VariantType, xLargo As Integer, xSuma As Boolean) As String
        Dim xCantceros As Integer
        If xSuma = True Then
            xValor = xValor + 1
        End If
        If IsNumeric(xValor) Then
            xCantceros = xLargo - Len(Trim(Str(xValor)))
        Else
            xCantceros = xLargo - Len(CStr(xValor))
        End If
        StrCeros = Strings.StrDup(xCantceros, "0") & Trim(Str(xValor))
    End Function

    ''' <summary>
    ''' Formula para Calcular los metros Cubicos con el Metodo Smalian
    ''' </summary>
    ''' <param name="dMayor">Diametro Mayor de la Troza</param>
    ''' <param name="dMenor">Diametro Menor de la Troza</param>
    ''' <param name="largo">Largo de la Troza</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function FormulaSmalian(ByVal dMayor As Decimal, dMenor As Decimal, largo As Double, xDecimales As Integer) As Decimal
        Dim xVolumen As Decimal = 0
        Dim Dx As Decimal = (((dMayor + dMenor) / 2) / 100) ^ 2
        xVolumen = (3.1415 * Dx * largo) / 4
        FormulaSmalian = Decimal.Round(xVolumen, xDecimales)
    End Function

    ''' <summary>
    ''' Formula para calcular los Pies Tablares Metodo de Doyle
    ''' </summary>
    ''' <param name="dMenor">Diametro menor en pulgadas</param>
    ''' <param name="largo">Largo en Pies</param>
    ''' <param name="xDecimales">Cantidad de decimales amostrar</param>
    ''' <returns>Cantidad en Pies tablar</returns>
    ''' <remarks></remarks>
    Function FormulaDoyle(ByVal dMenor As Decimal, largo As Double, xDecimales As Integer) As Decimal
        Dim xVolumen As Decimal = 0
        Dim Dx As Decimal = (dMenor - 4) ^ 2
        xVolumen = (Dx * largo) / 16
        FormulaDoyle = Decimal.Round(xVolumen, xDecimales)
    End Function

    ''' <summary>
    ''' Formula para obtener Volumen en Pies Tablar
    ''' </summary>
    ''' <param name="xEspesor"></param>
    ''' <param name="xAncho"></param>
    ''' <param name="xLargo"></param>
    ''' <param name="xDecimales"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function FormulaPT(ByVal xEspesor As Decimal, xAncho As Decimal, xLargo As Double, xDecimales As Integer) As Decimal
        Dim xVolumen As Decimal = 0
        xVolumen = (xEspesor * xAncho * xLargo) / 12
        FormulaPT = Decimal.Round(xVolumen, xDecimales)
    End Function

    Function FormulaM3(ByVal xEspesor As Decimal, xAncho As Decimal, xLargo As Double, xDecimales As Integer) As Decimal
        Dim xVolumen As Decimal = 0
        xVolumen = (xEspesor * xAncho * xLargo)
        FormulaM3 = Decimal.Round(xVolumen, xDecimales)
    End Function

    ''' <summary>
    ''' Funcion para obtener el Numero de Lote de una troza
    ''' </summary>
    ''' <param name="strTroza">Codigo de Troza</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetNumeroLote(ByVal strTroza As String) As String
        Using dm As New samadEntities
            Dim nl = (From rs In dm.formato01_det Where rs.F01d_Correlativo = strTroza Select rs.F01d_Lote).First()
            Return nl
        End Using
    End Function

    ''' <summary>
    ''' Formula que devuelve el calculo em Metros Cubicos
    ''' </summary>
    ''' <param name="dM">Diametro Mayor</param>
    ''' <param name="xDm">Diametro Menor</param>
    ''' <param name="xlargo">Largo</param>
    ''' <param name="xFormula"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function VolMet3(ByVal dM As Decimal, xDm As Decimal, xlargo As Double, xFormula As Integer) As Decimal
        If xFormula = 0 Then
            VolMet3 = FormulaSmalian(dM, xDm, xlargo, 3)
        Else
            VolMet3 = FormulaDoyle(xDm, xlargo, 3)
        End If
    End Function




#End Region


    ''' <summary>
    ''' Funcion para Borrar Registros segun los parametros 
    ''' </summary>
    ''' <param name="strTabla">Tabla donde se borraran los registros</param>
    ''' <param name="strCriterio">Criterios para borrar el registro</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function BORRAR(ByVal strTabla As String, strCriterio As String) As Boolean
        Dim cnn = New MySqlConnection(CadenaConexionSamad())
        Dim cmd = New MySqlCommand("spborrar", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection.Open()
        cmd.Parameters.Add("xTabla", MySqlDbType.VarChar, 30).Value = strTabla
        cmd.Parameters.Add("xCriterio", MySqlDbType.VarChar, 50).Value = strCriterio
        If cmd.ExecuteNonQuery = True Then
            Return True
        Else
            Return False
        End If
    End Function

    ' 'If New fxSamad().BORRAR("formato04", "f04_id=" & txId.Text) = False Then
    Function ACTUALIZALOTE(ByVal strTabla As String, ByVal campocriterio As String) As Boolean
        Dim cnn = New MySqlConnection(CadenaConexionSamad())
        Dim cmd = New MySqlCommand("spactualiza", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection.Open()
        cmd.Parameters.Add("Tabla", MySqlDbType.VarChar, 30).Value = strTabla
        cmd.Parameters.Add("Criterio", MySqlDbType.VarChar, 50).Value = campocriterio
        If cmd.ExecuteNonQuery = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Function Actlote(ByVal strCsql As String) As Boolean
        Dim cnn = New MySqlConnection(CadenaConexionSamad())
        Dim cmd = New MySqlCommand(strCsql, cnn)
        cmd.CommandType = CommandType.Text
        cmd.Connection.Open()
        If cmd.ExecuteNonQuery = True Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
