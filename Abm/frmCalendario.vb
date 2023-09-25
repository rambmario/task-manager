Imports System.Collections.Generic
Imports System.IO
Imports System.Threading

Imports Google.Apis.Calendar.v3
Imports Google.Apis.Calendar.v3.Data
Imports Google.Apis.Calendar.v3.EventsResource
Imports Google.Apis.Services
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Util.Store


Public Class frmCalendario

    Dim odt As New DataTable

    Private Sub frmCalendario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        odt.Columns.Add("ID", Type.GetType("System.String"))
        odt.Columns.Add("Fecha", Type.GetType("System.DateTime"))
        odt.Columns.Add("Detalle", Type.GetType("System.String"))
        odt.Columns.Add("Ingresada", Type.GetType("System.Boolean"))
        odt.Columns.Add("Seleccionar", Type.GetType("System.Boolean"))

        CargarEmpresa()
        CargarCod_Empresa()
        CargarProyecto()
        CargarCod_Proyecto()
        CargarSub_Proyecto()
        CargarCod_Sub_Proyecto()

        Me.lblid_empresa.Text = frmAbmTarea.lblid_empresa.Text
        Me.lblid_proyecto.Text = frmAbmTarea.lblid_proyecto.Text
        Me.lblid_sub_proyecto.Text = frmAbmTarea.lblid_sub_proyecto.Text
        Me.dtpFecha_desde.Value = DateTime.Now.Date


    End Sub


    Dim scopes As IList(Of String) = New List(Of String)
    Dim service As CalendarService
    Dim initializer As BaseClientService.Initializer = New BaseClientService.Initializer
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim service As CalendarService
        Try
            ' scopes.Clear()
            scopes.Add(CalendarService.Scope.Calendar)
            Dim Secrets = New ClientSecrets()
            'Secrets.ClientId = "74048514324-qnum6je9726hqmob3tbiljopbefcusuc.apps.googleusercontent.com"
            'Secrets.ClientSecret = "1rBvzQCcMYuzL50_vpUsvLg0"
            Secrets.ClientId = vgUsuarioCalendarUser
            Secrets.ClientSecret = vgUsuarioCalendarPass
            Dim scope = New List(Of String)
            scope.Add(CalendarService.Scope.Calendar)
            Dim credential = GoogleWebAuthorizationBroker.AuthorizeAsync(Secrets, scopes, vgUsuarioCorreo, CancellationToken.None).Result()
            Dim initializer = New BaseClientService.Initializer
            initializer.HttpClientInitializer = credential
            initializer.ApplicationName = "Calendar"
            service = New CalendarService(initializer)
            Dim list As IList(Of CalendarListEntry) = service.CalendarList.List().Execute().Items
            Dim requeust As ListRequest = service.Events.List(vgUsuarioCorreo)
            ' requeust.MaxResults = 2500
            requeust.TimeMin = Me.dtpFecha_desde.Value.Date

            Dim odtIngresa As New DataTable
            Dim odr As DataRow
            Dim blIngresada As Boolean = False

            'limpio el datatable
            odt.Clear()
            For Each calendarEvent As Data.Event In requeust.Execute().Items
                odtIngresa = oTarea.GetOneCalendarID(calendarEvent.Id)
                If odtIngresa.Rows.Count > 0 Then
                    blIngresada = True
                Else
                    blIngresada = False
                End If

                odr = odt.NewRow()
                odr("ID") = calendarEvent.Id
                odr("Detalle") = calendarEvent.Summary
                odr("Ingresada") = blIngresada
                odr("Seleccionar") = False

                If calendarEvent.Start.Date Is Nothing Then
                    odr("Fecha") = Date.Now
                Else
                    odr("Fecha") = calendarEvent.Start.Date
                End If

                odt.Rows.Add(odr)
            Next

            Dim view As DataView = New DataView(odt)
            view.Sort = "Fecha"

            Me.MetroGrid1.DataSource = view
            Me.MetroGrid1.Columns(0).Visible = False

            ' Me.DataGridView1.DataSource = requeust.Execute.Items
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    '' Calendar scopes which is initialized on the main method.
    '  Dim scopes As IList(Of String) = New List(Of String)()

    '' Calendar service.
    ' Dim service As CalendarService

    Sub Main()
        ' Add the calendar specific scope to the scopes list.
        scopes.Add(CalendarService.Scope.Calendar)

        ' Display the header and initialize the sample.
        Console.WriteLine("Google.Apis.Calendar.v3 Sample")
        Console.WriteLine("==============================")

        Dim credential As UserCredential
        Using stream As New FileStream("My Project 01-dbcb6b2115d2.json", FileMode.Open, FileAccess.Read)
            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets, scopes, "74048514324-qnum6je9726hqmob3tbiljopbefcusuc.apps.googleusercontent.com", CancellationToken.None,
                    New FileDataStore("Calendar.VB.Sample")).Result
        End Using
        '''1rBvzQCcMYuzL50_vpUsvLg0

        ' Create the calendar service using an initializer instance
        Dim initializer As New BaseClientService.Initializer()
        initializer.HttpClientInitializer = credential
        initializer.ApplicationName = "VB.NET Calendar Sample"
        service = New CalendarService(initializer)

        ' Fetch the list of calendar list
        Dim list As IList(Of CalendarListEntry) = service.CalendarList.List().Execute().Items()

        ' Display all calendars
        DisplayList(list)
        For Each calendar As Data.CalendarListEntry In list
            ' Display calendar's events
            DisplayFirstCalendarEvents(calendar)
        Next

        Console.WriteLine("Press any key to continue...")
        Console.ReadKey()
    End Sub

    ''' <summary>Displays all calendars.</summary>
    Private Sub DisplayList(list As IList(Of CalendarListEntry))
        Console.WriteLine("Lists of calendars:")
        For Each item As CalendarListEntry In list
            Console.WriteLine(item.Summary & ". Location: " & item.Location & ", TimeZone: " & item.TimeZone)
        Next
    End Sub

    ''' <summary>Displays the calendar's events.</summary>
    Private Sub DisplayFirstCalendarEvents(list As CalendarListEntry)
        Console.WriteLine(Environment.NewLine & "Maximum 5 first events from {0}:", list.Summary)
        Dim requeust As ListRequest = service.Events.List(list.Id)
        ' Set MaxResults and TimeMin with sample values
        requeust.MaxResults = 5
        requeust.TimeMin = New DateTime(2013, 10, 1, 20, 0, 0)
        ' Fetch the list of events
        For Each calendarEvent As Data.Event In requeust.Execute().Items
            Dim startDate As String = "Unspecified"
            If (Not calendarEvent.Start Is Nothing) Then
                If (Not calendarEvent.Start.Date Is Nothing) Then
                    startDate = calendarEvent.Start.Date.ToString()
                End If
            End If

            Console.WriteLine(calendarEvent.Summary & ". Start at: " & startDate)
        Next
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click

        Dim rowSel() As DataRow
        rowSel = odt.Select("Seleccionar = true")

        For Each row As DataRow In rowSel
            'row As DataRow In odt.Rows
            If CBool(row("Ingresada")) = False Then
                oTarea.Cargar()
                oTarea.Insertar()
                oTarea.archivo_relacionado = ""
                oTarea.complejidad = "B"
                oTarea.enviada = False
                oTarea.es_feriado = False
                oTarea.fecha_fin = CDate(row("Fecha"))
                oTarea.fecha_inicio = CDate(row("Fecha"))
                oTarea.fecha_pedido = CDate(row("Fecha"))
                oTarea.fecha_real = CDate(row("Fecha"))
                oTarea.hora_prevista = 1
                oTarea.hora_real = 1
                oTarea.IDCalendar = CType(row("ID"), String)
                oTarea.id_empresa = CInt(Me.lblid_empresa.Text)
                oTarea.id_estado_tarea = 1
                oTarea.id_proyecto = CInt(Me.lblid_proyecto.Text)
                oTarea.id_sub_proyecto = CInt(Me.lblid_sub_proyecto.Text)
                oTarea.id_tipo_tarea = 1
                oTarea.id_usuario = vgCodigoUsuario
                oTarea.id_usuario_asignado = vgCodigoUsuario
                oTarea.nombre_tarea = CType(row("Detalle"), String)
                oTarea.prioridad = 1
                oTarea.ubicacion_documento = ""
                oTarea.Guardar()
            End If
        Next

        btnConsultar.PerformClick()
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Try
    '        Me.Main()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub


    '    Private Function ObtenerCalendario(ByVal NombreCalendario As String, ByVal Cuenta As String, ByVal Password As String) As String
    '        Try
    '            Dim Propietario As Boolean = False

    '            'Alta del servicio de Google y autenticación en Google
    '            Dim servicioGoogle As New CalendarService("SysInsertarCita")
    '            servicioGoogle.setUserCredentials(Cuenta, Password)
    '            Dim consultaCalendar As CalendarQuery = New CalendarQuery()
    '            consultaCalendar.Uri = New Uri("https://www.google.com/calendar/feeds/default/allcalendars/full")

    '            Dim resultadoFeed As CalendarFeed = servicioGoogle.Query(consultaCalendar)

    '            Dim Existe As Boolean = False
    '            For Each entradaActual As CalendarEntry In resultadoFeed.Entries
    '                Dim calendarios As New calendariosGoogleCalendar

    '                If entradaActual.Title.Text = NombreCalendario Then
    '                    Existe = True
    '                    Dim P1 As Integer = -1
    '                    P1 = InStrRev(entradaActual.Id.AbsoluteUri, "/")
    '                    ObtenerCalendario = Strings.Right(entradaActual.Id.AbsoluteUri, Strings.Len(entradaActual.Id.AbsoluteUri) - P1)
    '                End If
    '            Next

    '            If Existe = False Then
    '                ObtenerCalendario = "-1"
    '            End If

    '        Catch ex As Exception
    '            TXServidor.Text = TXServidor.Text & "GMail Error al recuperar calendarios..." & vbCrLf
    '            TXServidor.Text = TXServidor.Text & "https://www.google.com/calendar/feeds/default/allcalendars/full" & vbCrLf
    '            ErrorGMAIL = True
    '            ObtenerCalendario = "Error"
    '        End Try
    '    End Function

    '    Private Function InsertarCita(ByVal IdCalendario As String, ByVal Cuenta As String, ByVal Password As String, ByVal TituloEvento As String, ByVal DescripcionEvento As String, ByVal LugarEvento As String, ByVal FItx As String, ByVal FFtx As String) As String

    '        Dim fechaInicio As Date = Date.Parse(FItx, System.Globalization.CultureInfo.CurrentCulture)
    '        Dim fechaFin As Date = Date.Parse(FFtx, System.Globalization.CultureInfo.CurrentCulture)

    '        Dim Invitados As String = "" 'si quieres que incluya otros ej "sysred7@gmail.com, alfa@gmail.com"

    '        Dim Recordatorio As New Reminder
    '        Dim RecordatorioUnidad As String = "minutos" 'minutos horas dias
    '        Dim RecordatorioUnidades As Integer = 0
    '        Dim RecordatorioTipo As String = "SMS" 'SMS Correo electrónico Ventana emergente

    '        Try
    '            'Alta del servicio de Google y autenticación en Google
    '            Dim servicioGoogle As New CalendarService("Mi Calendario")
    '            servicioGoogle.setUserCredentials(Cuenta, Password)

    '            Dim entradaCalendario As New EventEntry

    '            'Asunto (título) del evento Google Calendar
    '            entradaCalendario.Title.Text = TituloEvento

    '            'Descripción del evento Google Calendar
    '            entradaCalendario.Content.Content = DescripcionEvento

    '            'Lugar del evento Google Calendar
    '            Dim ubicacionEvento = New Where()
    '            ubicacionEvento.ValueString = LugarEvento
    '            entradaCalendario.Locations.Add(ubicacionEvento)

    '            Dim desdeHastaCalendar As New [When](fechaInicio, fechaFin)
    '            entradaCalendario.Times.Add(desdeHastaCalendar)

    '            '** INICIO Activar tipo de Recordatorio

    '            GoTo melosalto
    '            'Unidad de tiempo (horas, minutos, días)
    '            If RecordatorioUnidad = "minutos" Then
    '                Recordatorio.Minutes = CInt(RecordatorioUnidades)
    '            End If
    '            If RecordatorioUnidad = "horas" Then
    '                Recordatorio.Hours = CInt(RecordatorioUnidades)
    '            End If
    '            If RecordatorioUnidad = "días" Then
    '                Recordatorio.Days = CInt(RecordatorioUnidades)
    '            End If

    '            'tipo de recordatorio (SMS, correo electrónico, ventana emergente)
    '            If RecordatorioTipo = "SMS" Then
    '                Recordatorio.Method = Reminder.ReminderMethod.sms
    '            End If
    '            If RecordatorioTipo = "Correo electrónico" Then
    '                Recordatorio.Method = Reminder.ReminderMethod.email
    '            End If
    '            If RecordatorioTipo = "Ventana emergente" Then
    '                Recordatorio.Method = Reminder.ReminderMethod.alert
    '            End If

    '            entradaCalendario.Reminders.Add(Recordatorio)
    '            '** FIN Activar tipo de Recordatorio

    '            'Inserta los invitados de la cita de Google Calendar
    '            If Invitados <> "" Then
    '                Dim invitadosSeparados() As String
    '                Dim i As Integer
    '                invitadosSeparados = Split(Invitados, ",")
    '                Dim invitado As Who
    '                For i = 0 To UBound(invitadosSeparados)
    '                    invitado = New Who()
    '                    invitado.Rel = Who.RelType.MESSAGE_TO
    '                    invitado.Email = invitadosSeparados(i)
    '                    entradaCalendario.Participants.Add(invitado)
    '                Next i
    '            End If
    'melosalto:

    '            'Insertamos el evento creado en Google Calendar
    '            Dim uriDireccionGoogle As New Uri("https://www.google.com/calendar/feeds/" & IdCalendario & "/private/full")
    '            Dim entradaEventoInsertar As AtomEntry = servicioGoogle.Insert(uriDireccionGoogle, entradaCalendario)
    '            InsertarCita = DirectCast(entradaEventoInsertar, Google.GData.Calendar.EventEntry).EventId

    '            ' MsgBox("Evento enviado correctamente a Google Calendar.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)


    '        Catch ex As Exception
    '            ErrorGMAIL = True
    '            TXServidor.Text = TXServidor.Text & "GMail ERROR inserción cita..." & vbCrLf
    '            InsertarCita = "Error"
    '        End Try

    '    End Function
    '    Private Sub ObtenerCitas()
    '        Dim lugarCita As String
    '        Dim participantesCita As String
    '        Dim Calendario As String = "Mi calendario"
    '        Dim NumeroMaximoCitas As Integer = 1000
    '        Dim FI As Date = "01/01/2010"
    '        Dim FF As Date = "01/01/2050"

    '        Dim i As Integer

    '        Try
    '            Dim servicioGoogle As Google.GData.Calendar.CalendarService = New Google.GData.Calendar.CalendarService("SysInsertar Cita")
    '            servicioGoogle.setUserCredentials("sysred55@gmail. com", "158984654")
    '            Dim consultaCalendar As Google.GData.Calendar.EventQuery = New Google.GData.Calendar.EventQuery()
    '            consultaCalendar.Uri = New Uri("https://www.google.com/calendar/feeds/default/private/full?max-results=" & CStr(NumeroMaximoCitas))
    '            consultaCalendar.StartTime = FI
    '            consultaCalendar.EndTime = FF

    '            Dim entradaFeed As Google.GData.Calendar.EventEntry
    '            Dim calendarioFeed As Google.GData.Calendar.EventFeed = servicioGoogle.Query(consultaCalendar)

    '            For Each entradaFeed In calendarioFeed.Entries
    '                Dim fechaEvento As New [When](entradaFeed.Times(0).StartTime, entradaFeed.Times(0).EndTime)
    '                Dim citasGoogle As New citasGoogleCalendar

    '                citasGoogle.contenido = entradaFeed.Content.Content
    '                citasGoogle.titulo = entradaFeed.Title.Text
    '                citasGoogle.fechaInicio = fechaEvento.StartTime
    '                citasGoogle.fechaFin = fechaEvento.EndTime
    '                citasGoogle.id = entradaFeed.EventId
    '                Dim url As New Uri("http://www.google.com/calendar/feeds/" & "sysred5@gmail.com" & "/private/full/" & citasGoogle.id)
    '                Try
    '                    servicioGoogle.Delete(url)
    '                Catch ex As Exception
    '                End Try

    '                lugarCita = ""
    '                For i = 0 To entradaFeed.Locations.Count - 1
    '                    If lugarCita <> "" Then
    '                        lugarCita = lugarCita & ", " & entradaFeed.Locations.Item(i).ValueString
    '                    Else
    '                        lugarCita = entradaFeed.Locations.Item(i).ValueString
    '                    End If
    '                Next
    '                citasGoogle.lugar = lugarCita

    '                participantesCita = ""
    '                For i = 0 To entradaFeed.Participants.Count - 1
    '                    If participantesCita <> "" Then
    '                        participantesCita = participantesCita & ", " & entradaFeed.Participants.Item(i).ValueString
    '                    Else
    '                        participantesCita = entradaFeed.Participants.Item(i).ValueString
    '                    End If
    '                Next
    '                citasGoogle.participantes = participantesCita
    '                MsgBox(citasGoogle.titulo)
    '            Next
    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
    '        End Try

    '    End Sub

    Private Sub MetroGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick

    End Sub

    Private Sub MetroGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellDoubleClick
        If MetroGrid1.Columns(e.ColumnIndex).Name = "Seleccionar" Then
            Dim i As String = ""
            i = CStr(Me.MetroGrid1.CurrentRow.Cells("ID").Value)

            Dim expresion As String = ""
            expresion = "ID = '" + i + "'"

            Dim dr As DataRow
            dr = odt.Select(expresion)(0)

            If CDbl(Me.MetroGrid1.Item("Seleccionar", Me.MetroGrid1.CurrentRow.Index).Value) = 0 Then
                dr("Seleccionar") = 1
            Else
                dr("Seleccionar") = 0
            End If

            '  MessageBox.Show(odt.Rows(i).Item("detalle").ToString)

            Dim view As DataView = New DataView(odt)
            view.Sort = "Fecha"

            Me.MetroGrid1.DataSource = view
            Me.MetroGrid1.Columns(0).Visible = False
        End If
    End Sub


    'combos relacionados a la parte inferior
    Sub CargarEmpresa()
        Dim odt As New DataTable

        odt = oEmpresa.GetCmb
        With Me.cmbEmpresa
            .DataSource = odt
            .DisplayMember = "nombre_empresa"
            .ValueMember = "id_empresa"
        End With
        If Me.cmbEmpresa.SelectedIndex >= 0 Then
            cmbEmpresa.SelectedIndex = 0
            Me.lblid_empresa.Text = cmbEmpresa.SelectedValue.ToString
        End If
    End Sub
    Sub CargarProyecto()
        Dim odt As New DataTable

        odt = oProyecto.GetCmbEmpresa(CInt(Me.lblid_empresa.Text))
        With Me.cmbproyecto
            .DataSource = odt
            .DisplayMember = "nombre_proyecto"
            .ValueMember = "id_proyecto"
        End With
        If Me.cmbproyecto.SelectedIndex >= 0 Then
            cmbproyecto.SelectedIndex = 0
            Me.lblid_proyecto.Text = cmbproyecto.SelectedValue.ToString
        End If
    End Sub

    Sub CargarSub_Proyecto()
        Dim odt As New DataTable

        odt = oSub_proyecto.GetCmbProyecto(CInt(Me.lblid_proyecto.Text))
        With Me.cmbSub_proyecto
            .DataSource = odt
            .DisplayMember = "nombre_sub_proyecto"
            .ValueMember = "id_sub_proyecto"
        End With
        If Me.cmbSub_proyecto.SelectedIndex >= 0 Then
            cmbSub_proyecto.SelectedIndex = 0
            Me.lblid_sub_proyecto.Text = cmbSub_proyecto.SelectedValue.ToString
        End If
    End Sub
    '***
    Sub CargarCod_Empresa()
        Dim odt As New DataTable

        odt = oEmpresa.GetCmb
        With Me.cmbCod_empresa
            .DataSource = odt
            .DisplayMember = "codigo_empresa"
            .ValueMember = "id_empresa"
        End With
        If Me.cmbCod_empresa.SelectedIndex >= 0 Then
            cmbCod_empresa.SelectedIndex = 0
            Me.lblid_empresa.Text = cmbCod_empresa.SelectedValue.ToString
        End If
    End Sub
    Sub CargarCod_Proyecto()
        Dim odt As New DataTable

        odt = oProyecto.GetCmbEmpresa(CInt(Me.lblid_empresa.Text))
        With Me.cmbCod_Proyecto
            .DataSource = odt
            .DisplayMember = "codigo_proyecto"
            .ValueMember = "id_proyecto"
        End With
        If Me.cmbCod_Proyecto.SelectedIndex >= 0 Then
            cmbCod_Proyecto.SelectedIndex = 0
            Me.lblid_proyecto.Text = cmbCod_Proyecto.SelectedValue.ToString
        End If
    End Sub

    Sub CargarCod_Sub_Proyecto()
        Dim odt As New DataTable

        odt = oSub_proyecto.GetCmbProyecto(CInt(Me.lblid_proyecto.Text))
        With Me.cmbCod_sub_proyecto
            .DataSource = odt
            .DisplayMember = "codigo_sub_proyecto"
            .ValueMember = "id_sub_proyecto"
        End With
        If Me.cmbCod_sub_proyecto.SelectedIndex >= 0 Then
            cmbCod_sub_proyecto.SelectedIndex = 0
            Me.lblid_sub_proyecto.Text = cmbCod_sub_proyecto.SelectedValue.ToString
        End If
    End Sub
#Region "-> SELECTEDINDEXCHANGED - DIVERSOS COMBOS"

    Private Sub cmbCod_empresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCod_empresa.SelectedIndexChanged
        If Me.cmbCod_empresa.SelectedIndex >= 0 And IsNumeric(cmbCod_empresa.SelectedValue) Then
            Me.lblid_empresa.Text = cmbCod_empresa.SelectedValue.ToString
            Me.cmbproyecto.Text = ""
            Me.cmbCod_Proyecto.Text = ""
            Me.lblid_proyecto.Text = "0"
            Me.cmbSub_proyecto.Text = ""
            Me.cmbCod_sub_proyecto.Text = ""
            Me.lblid_sub_proyecto.Text = "0"
            Me.cmbEmpresa.SelectedValue = cmbCod_empresa.SelectedValue
            CargarProyecto()
            CargarCod_Proyecto()
            CargarSub_Proyecto()
            CargarCod_Sub_Proyecto()
        End If
    End Sub

    Private Sub cmbCod_Proyecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCod_Proyecto.SelectedIndexChanged
        If Me.cmbCod_Proyecto.SelectedIndex >= 0 And IsNumeric(cmbCod_Proyecto.SelectedValue) Then
            Me.lblid_proyecto.Text = cmbCod_Proyecto.SelectedValue.ToString
            Me.cmbSub_proyecto.Text = ""
            Me.cmbCod_sub_proyecto.Text = ""
            Me.lblid_sub_proyecto.Text = "0"
            Me.cmbproyecto.SelectedValue = Me.cmbCod_Proyecto.SelectedValue
            CargarSub_Proyecto()
            CargarCod_Sub_Proyecto()
        End If
    End Sub

    Private Sub cmbCod_sub_proyecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCod_sub_proyecto.SelectedIndexChanged
        If Me.cmbCod_sub_proyecto.SelectedIndex >= 0 And IsNumeric(cmbCod_sub_proyecto.SelectedValue) Then
            Me.lblid_sub_proyecto.Text = cmbCod_sub_proyecto.SelectedValue.ToString
            Me.cmbSub_proyecto.SelectedValue = Me.cmbCod_sub_proyecto.SelectedValue
        End If
    End Sub

    Private Sub cmbEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpresa.SelectedIndexChanged
        If Me.cmbEmpresa.SelectedIndex >= 0 And IsNumeric(cmbEmpresa.SelectedValue) Then
            Me.lblid_empresa.Text = cmbEmpresa.SelectedValue.ToString
            Me.cmbproyecto.Text = ""
            Me.cmbCod_Proyecto.Text = ""
            Me.lblid_proyecto.Text = "0"
            Me.cmbSub_proyecto.Text = ""
            Me.cmbCod_sub_proyecto.Text = ""
            Me.lblid_sub_proyecto.Text = "0"
            Me.cmbCod_empresa.SelectedValue = Me.cmbEmpresa.SelectedValue
            CargarProyecto()
            CargarCod_Proyecto()
            CargarSub_Proyecto()
            CargarCod_Sub_Proyecto()
        End If
    End Sub

    Private Sub cmbproyecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbproyecto.SelectedIndexChanged
        If Me.cmbproyecto.SelectedIndex >= 0 And IsNumeric(cmbproyecto.SelectedValue) Then
            Me.lblid_proyecto.Text = cmbproyecto.SelectedValue.ToString
            Me.cmbSub_proyecto.Text = ""
            Me.cmbCod_sub_proyecto.Text = ""
            Me.lblid_sub_proyecto.Text = "0"
            Me.cmbCod_Proyecto.SelectedValue = Me.cmbproyecto.SelectedValue
            CargarSub_Proyecto()
            CargarCod_Sub_Proyecto()
        End If
    End Sub

    Private Sub cmbSub_proyecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSub_proyecto.SelectedIndexChanged
        If Me.cmbSub_proyecto.SelectedIndex >= 0 And IsNumeric(cmbSub_proyecto.SelectedValue) Then
            Me.lblid_sub_proyecto.Text = cmbSub_proyecto.SelectedValue.ToString
            Me.cmbCod_sub_proyecto.SelectedValue = Me.cmbSub_proyecto.SelectedValue
        End If
    End Sub
#End Region


End Class