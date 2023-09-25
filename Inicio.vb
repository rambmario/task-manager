Imports System.Globalization
Imports System.Threading
Imports System.Net.Mail
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Module Inicio


    Public oUsuario_asignado As New Usuario

    Public oCliente As New Cliente
    Public BanderaCliente As Integer = 0

    Public oFeriado As New Feriado
    Public BanderaFeriado As Integer = 0

    Public oGantt As New Gantt
    Public BanderaGantt As Integer = 0

    Public oLog_error As New log_error

    Public oProyecto As New Proyecto
    Public BanderaProyecto As Integer = 0

    Public oTarea As New Tarea
    Public BanderaTarea As Integer = 0

    Public oUsuario As New Usuario
    Public BanderaUsuario As Integer = 0

    Public oTipo_usuario As New Tipo_usuario
    Public BanderaTipo_usuario As Integer = 0

    Public oHora_real As New Hora_real
    Public BanderaHora_real As Integer = 0

    Public oTipo_empresa As New Tipo_empresa
    Public BanderaTipo_empresa As Integer = 0

    Public oEmpresa As New Empresa
    Public BanderaEmpresa As Integer = 0

    Public oTipo_proyecto As New Tipo_proyecto
    Public BanderaTipo_proyecto As Integer = 0

    Public oSub_proyecto As New Sub_proyecto
    Public BanderaSub_proyecto As Integer = 0

    Public oTipo_tarea As New Tipo_tarea
    Public BanderaTipo_tarea As Integer = 0

    Public oEstado_tarea As New Estado_tarea
    Public BanderaEstado_tarea As Integer = 0

    Public oMejora As New Mejora
    Public BanderaMejora As Integer = 0

    Public oTipo_mejora As New Tipo_mejora
    Public BanderaTipo_mejora As Integer = 0

    Public oMetodo_causa As New Metodo_causa
    Public BanderaMetodo_causa As Integer = 0

    Public oOrigen_mejora As New Origen_mejora
    Public BanderaOrigen_mejora As Integer = 0

    Public oMejora_accion As New Mejora_accion
    Public BanderaMejora_accion As Integer = 0

    Public oEstado_mejora As New Estado_mejora
    Public BanderaEstad_mejora As Integer = 0

    Public oEstado_proyecto As New Estado_proyecto
    Public BanderaEstado_proyecto As Integer = 0




    'variable comanda
    Public BanderaCierre As Integer = 0
    Public BanderaTramitePedido As Integer = 0
    Public NombreFromPadre As String = ""

    'variable de usuario
    Public NombreUsuario As String = ""
    Public vgCodigoUsuario As Integer = 0
    Public vgCodigoTipoUsuario As Integer = 0
    Public vgNombreFormulario As String = ""
    Public vgNombreFormularioPadre As String = ""
    Public vgNombreUsuario As String = ""
    Public vgUsuarioCalendarUser As String = ""
    Public vgUsuarioCalendarPass As String = ""
    Public vgUsuarioCorreo As String = ""

    Public vgPermiso As Boolean = True

    'agregado para detalle producto
    Public vgNombreCliente As String = ""
    Public vgNombreReporte As String = ""
    Public vgNombrePermiso As String = ""
    Public vgPuertoFiscal As String = ""
    Public vgNombreImpresoraFiscal As String = ""
    Public vgPdv As String = ""
    Public vgPdvLibroIva As String = ""
    Public vgId_almacen As String = ""
    Public vgNombre_libro_iva As String = ""

    Public vgTotalAPagar As Decimal = 0
    Public vgIdTareaGantt As Integer = 0

    'variable de consultas
    Public BanderaConsulta As String
    Public odtConsultaGeneral As New DataTable
    Public BanderaConsulta_2 As String
    Public odtConsultaGeneral_2 As New DataTable
    Public strTituloConsultaGeneral As String = ""
    Public strDetalleConsultaGeneral As String = ""
    Public strHoraFormateada As String = ""
    Public odtConsultaBancos As New DataTable
    Public bandera_imprime As Integer = 0
    Public Bandera_consulta_empleado As String = ""
    Public bandera_contado As Boolean = False
    Public BanderaConsultaProducto As Integer = 0

    'variables de reportes
    Public parametro_empleado_prn As String = ""
    Public Banderaprint As String = ""
    Public parametro_id_empresa As Integer = 0
    Public parametro_id_empleado As Integer = 0
    Public parametro_id_alnmacen As Integer = 0
    Public parametro_fecha As DateTime
    Public parametro_fecha_inicio As DateTime
    Public parametro_fecha_fin As DateTime
    Public parametro_fecha_old As DateTime
    Public parametro_empleado As String = ""
    Public parametro_empleado_pago As String = ""
    Public parametro_empleado_sueldo As String = ""
    Public parametro_empleado_total As String = ""
    Public parametro_empleado_hora As String = ""
    Public parametro_empleado_hora_formateada As String = ""
    Public parametro_id_pago_recibo As Integer = 0
    Public bandera_imprime_cliente As Integer = 0
    Public parametro_periodo As DateTime 'As String = ""
    Public parametro_cliente_prn As String = ""
    Public parametro_nom_cliente As String = ""
    Public parametro_saldo_anterior As Decimal = 0 ' As String = ""
    Public parametro_proveedor_prn As Integer = 0
    Public bandera_imprime_prov As Integer = 0
    Public parametro_nom_prov As String = ""
    Public parametro_sdo_ant As String = ""
    Public parametro_pdv As String = ""
    Public parametro_total As String = ""
    Public parametro_subtotal As Decimal = 0
    Public parametro_grupo_producto As String = ""
    Public parametro_tipo_producto As String = ""
    Public parametro_fecha_libro_iva_venta As DateTime
    Public Banderaprintpantalla As String = ""
    Public parametro_fecha_stock As DateTime
    Public parametro_fecha_transferencia As DateTime
    Public parametro_fecha_egreso_insumo As DateTime
    Public parametro_id_campana As Integer = 0
    Public parametro_id_grupocampana As Integer = 0
    Public parametro_banco As Integer = 0
    Public parametro_empresa As Integer = 0
    Public parametro_cuenta As Integer = 0
    Public parametro_id_banco As Integer = 0
    Public parametro_id_cuenta As Integer = 0
    Public parametro_id_caja As Integer = 0
    Public parametro_nombre_cuenta As String = ""
    Public parametro_nombre_empresa As String = ""
    Public parametro_nombre_banco As String = ""
    Public parametro_sumainsumo As Integer = 0
    Public parametro_nro_sumalabor As Integer = 0
    Public parametro_fac As Integer = 0
    Public parametro_id_cliente As Integer = 0
    Public parametro_fecha_librado_desde As DateTime
    Public parametro_fecha_librado_hasta As DateTime
    Public parametro_fecha_pago_desde As DateTime
    Public parametro_fecha_pago_hasta As DateTime
    Public parametro_fecha_recibido_desde As DateTime
    Public parametro_fecha_recibido_hasta As DateTime
    Public parametro_fecha_acreditacion_desde As DateTime
    Public parametro_fecha_acreditacion_hasta As DateTime
    Public parametro_Proveedor As Integer = 0
    Public parametro_nro_cheque As String = ""
    Public parametro_nro_transferencia As String = ""
    Public parametro_total_total As Decimal = 0
    Public parametro_total_iva As Decimal = 0
    Public parametro_total_neto As Decimal = 0
    Public parametro_A_total As Decimal = 0
    Public parametro_A_iva As Decimal = 0
    Public parametro_A_neto As Decimal = 0
    Public parametro_B_total As Decimal = 0
    Public parametro_B_iva As Decimal = 0
    Public parametro_B_neto As Decimal = 0
    Public parametro_inicio_print As Decimal = 0
    Public parametro_nom_empleado As String = ""
    Public parametro_id_empleado_old As Integer = 0
    Public parametro_id_almacen As Integer = 0
    Public parametro_patente As String = ""
    Public parametro_retiro_caja As Integer = 0
    Public parametro_id_usuario As Integer = 0
    Public parametro_id_grupo_producto As Integer = 0
    Public parametro_tarea_general As Integer = 0
    Public parametro_tarea_estado As Boolean = False
    Public parametro_reporte As String = ""

    Public parametro_id_pago_cliente As Integer = 0
    Public parametro_pago_venta As Decimal = 0
    Public parametro_saldo_actual As Decimal = 0
    'Public parametro_nom_cliente As Integer = 0
    Public parametro_pago_letra As String = ""
    Public parametro_numero_recibo As Decimal = 0

    Public parametro_descuento As String = ""
    Public parametro_path_logo As String = ""

    'variables globales
    Public vgCodigo_producto As String = ""
    Public vgIDProducto As Integer = 0
    Public id_factura_global As Integer = 0
    Public numero_factura_global As String = ""
    Public BanderaConsultaGeneral As String = ""
    Public Banderabtn As Integer = 0
    Public odtConsultaGeneralSuma As New DataTable
    Public numero_factura_factura_global As String = ""
    Public parametro_id_pago_venta_cheque As Integer = 0
    Public parametro_id_venta As Integer = 0
    Public parametro_id_proveedor As Integer = 0
    Public parametro_id_cuerpo_factura_proveedor As Integer = 0
    Public bandera_cantidad As Integer = 0
    Public bandera_bonificacion As Integer = 0
    Public parametro_id_proyecto As Integer = 0
    Public parametro_id_subproyecto As Integer = 0


    Public flagpresupuesto As Integer

    Public PathAyuda As String
    Public PathFoto As String
    Public PathReporte As String
    Public PathReporte_2 As String
    Public LargoPath As Integer


    '09/03
    Public vgBanderaprint As String = ""
    Public vgFormularioPadre As String = ""
    Public vgTareaMejora As Integer = 0

    '14/03
    Public banderanuevoprod As Boolean = False

    '12/04   sirve para cuerpo factura
    Public totalrent As Decimal = 0
    '16/04
    Public banderaEnviarMail As Boolean = False
    Public banderamail As Boolean = False



    Function CompletarCeros(ByVal strCadena As String, ByVal intLargo As Integer) As String
        If intLargo = 4 Then
            Select Case Len(strCadena)
                Case 0 : strCadena = "0000" + strCadena
                Case 1 : strCadena = "000" + strCadena
                Case 2 : strCadena = "00" + strCadena
                Case 3 : strCadena = "0" + strCadena
            End Select
        End If
        If intLargo = 8 Then
            Select Case Len(strCadena)
                Case 0 : strCadena = "00000000" + strCadena
                Case 1 : strCadena = "0000000" + strCadena
                Case 2 : strCadena = "000000" + strCadena
                Case 3 : strCadena = "00000" + strCadena
                Case 4 : strCadena = "0000" + strCadena
                Case 5 : strCadena = "000" + strCadena
                Case 6 : strCadena = "00" + strCadena
                Case 7 : strCadena = "0" + strCadena
            End Select
        End If
        Return strCadena
    End Function

    Function CompletarCeros2(ByVal strCadena As String) As String

        Select Case Len(strCadena)
            Case 0 : strCadena = "000000000000" + strCadena
            Case 1 : strCadena = "00000000000" + strCadena
            Case 2 : strCadena = "0000000000" + strCadena
            Case 3 : strCadena = "000000000" + strCadena
            Case 4 : strCadena = "00000000" + strCadena
            Case 5 : strCadena = "0000000" + strCadena
            Case 6 : strCadena = "000000" + strCadena
            Case 7 : strCadena = "00000" + strCadena
            Case 8 : strCadena = "0000" + strCadena
            Case 9 : strCadena = "000" + strCadena
            Case 10 : strCadena = "00" + strCadena
            Case 11 : strCadena = "0" + strCadena
            Case 12 : strCadena = strCadena
        End Select

        Return strCadena
    End Function

    Function CompletarCerosCodigo(ByVal strCadena As String) As String
        Select Case Len(strCadena)
            Case 1 : strCadena = "0000" + strCadena
            Case 2 : strCadena = "000" + strCadena
            Case 3 : strCadena = "00" + strCadena
            Case 4 : strCadena = "0" + strCadena
            Case 5 : strCadena = strCadena
        End Select

        Return strCadena
    End Function

    Public Function ControlarCampo(ByVal nombre_campo As String, ByVal dt As DataTable) As Boolean
        Dim Resultado As Boolean = False
        For Each column As DataColumn In dt.Columns
            If column.ColumnName = nombre_campo Then
                Resultado = True
                Exit For
            End If
        Next

        Return Resultado
    End Function

    Public Function RetornarCheck(ByVal valor_check As String) As Boolean
        If valor_check = "X" Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function RetornarValor(ByVal valor_check As Boolean) As String
        If valor_check = True Then
            Return "X"
        Else
            Return ""
        End If
    End Function

    Public Function RetornarColor(ByVal valor_check As Boolean) As Color
        If valor_check = True Then
            Return Color.Red
        Else
            Return Color.White
        End If
    End Function


    Public Sub Errores(ByVal ex2 As Exception)
        Try
            With oLog_Error
                .Cargar()
                .Insertar()
                .numero = CStr(Err.Number)
                .mensaje = ex2.Message
                .origen = ex2.Source
                .descripcion = ex2.StackTrace
                .fecha = DateTime.Now
                .Guardar()
            End With
        Catch ex As Exception
        End Try
    End Sub


    Public Sub enviar_mail(ByVal i_de As String, ByVal i_para As String, ByVal asunto As String, ByVal mensaje As String)

        Dim insMail As New MailMessage(New MailAddress(i_de), New MailAddress(i_para))
        With insMail

            .Subject = asunto
            .IsBodyHtml = True 'envia el mensaje como html
            .Body = mensaje
            .From = New MailAddress(i_de)
            .ReplyTo = New MailAddress(i_de)

        End With
        Dim smtp As New System.Net.Mail.SmtpClient
        smtp.Host = "smtp.gmail.com"
        smtp.Port = 587
        smtp.EnableSsl = True
        smtp.UseDefaultCredentials = False
        smtp.Credentials = New System.Net.NetworkCredential("byctuc@gmail.com", "tucumancordoba")

        smtp.Send(insMail)



    End Sub

    Public Sub EnviarMailAdjunto(ByVal StrPara() As String, ByVal StrAsunto As String, ByVal sAdjunto() As String, ByVal StrMensaje As String)

        Dim SMPT As New SmtpClient
        'variable tipo mensaje con parametros De: Para:
        Dim Msg As New MailMessage(New MailAddress("byctuc@gmail.com"), New MailAddress(StrPara(0)))
        'Copia ocultas a las areas
        If StrPara.Length >= 1 Then
            For i As Integer = 0 To StrPara.Length - 1
                Msg.Bcc.Add(StrPara(i))
            Next
        End If
        'Asunto
        Msg.Subject = StrAsunto
        'Mensaje
        Msg.Body = StrMensaje
        'ADJUNTOS
        For Each FAdjunto As String In sAdjunto
            If Not FAdjunto = "" Then
                'Objeto tipo attachment
                Dim Adjunto As New Attachment(FAdjunto) 'ruta de archivo creo. je
                'agregar adjunto al objeto mensaje
                Msg.Attachments.Add(Adjunto)
            End If
        Next
        'DATOS SMTP
        'Credenciales
        SMPT.Credentials = New System.Net.NetworkCredential("byctuc@gmail.com", "tucumancordoba")
        'Host, Puerto, autenticacion
        SMPT.Host = "smtp.gmail.com"
        SMPT.Port = 587
        SMPT.EnableSsl = True
        SMPT.Timeout = 10
        'Enviar
        SMPT.Send(Msg)

    End Sub

    Private cnn As New Conexion
    Private _inicio As Integer = 0
    Private _tope As Integer = 0
    Private _numeroPagina As Integer = 1
    Private _ultimaPagina As Integer = 0
    Private _cantidadRegistros As Integer = 0
    Private _datamember As String
    Private _adapter As New SqlDataAdapter
    Private _datos As DataSet

    Public Sub Paginar(ByVal s_datamember As String, ByVal i_cantidadxpagina As Integer, ByVal s_adapter As SqlDataAdapter)
        _inicio = 0
        _tope = i_cantidadxpagina
        _datamember = s_datamember

        Dim odt As DataTable

        cnn.Coneccion()
        _adapter = s_adapter
        _datos = New DataSet
        odt = New DataTable
        cnn.Abrir()
        _adapter.Fill(_datos, _inicio, _tope, _datamember)
        _adapter.Fill(odt)
        cnn.Cerrar()
        _cantidadRegistros = odt.Rows.Count

        AsignarTope()

    End Sub

    Public Sub AsignarTope()
        _ultimaPagina = _cantidadRegistros \ _tope

        Dim aux As Integer = _cantidadRegistros Mod _tope

        If _ultimaPagina = 0 Then
            _ultimaPagina = 1

        ElseIf _ultimaPagina >= 1 And (aux > 0) Then
            _ultimaPagina = _ultimaPagina + 1

        End If

        _numeroPagina = 1
    End Sub

    Public Function Cargar() As DataSet

        Return _datos

    End Function

    Public Function PrimeraPagina() As DataSet

        _numeroPagina = 1
        _inicio = 0
        _datos.Clear()
        _adapter.Fill(_datos, _inicio, _tope, _datamember)

        Return _datos

    End Function
    Public Function UltimaPagina() As DataSet

        _numeroPagina = _ultimaPagina
        _inicio = (_ultimaPagina - 1) * _tope
        _datos.Clear()
        _adapter.Fill(_datos, _inicio, _tope, _datamember)

        Return _datos

    End Function
    Public Function Atras() As DataSet

        If _numeroPagina = 1 Then
            Return _datos
        End If

        _numeroPagina = _numeroPagina - 1
        _inicio = _inicio - _tope
        _datos.Clear()
        _adapter.Fill(_datos, _inicio, _tope, _datamember)

        Return _datos

    End Function

    Public Function Adelante() As DataSet

        If _ultimaPagina = _numeroPagina Then
            Return _datos
        End If

        _numeroPagina = _numeroPagina + 1
        _inicio = _inicio + _tope
        _datos.Clear()
        _adapter.Fill(_datos, _inicio, _tope, _datamember)

        Return _datos

    End Function

    Public Function ActualizarTope(ByVal i_tope As Integer) As DataSet
        _tope = i_tope
        _inicio = 0
        AsignarTope()

        _datos.Clear()
        _adapter.Fill(_datos, _inicio, _tope, _datamember)
        Return _datos

    End Function

    Public Function countRow() As Integer
        Return _cantidadRegistros
    End Function

    Public Function countPag() As Integer
        Return _ultimaPagina
    End Function

    Public Function NumPag() As Integer
        Return _numeroPagina
    End Function

    Public Function LimiteRow() As Integer
        Return _tope
    End Function

End Module
