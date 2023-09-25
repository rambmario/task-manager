Public Class frmGantt

    Private Sub frmGantt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarUsuario()
    End Sub

    Sub CargarUsuario()
        Dim odt As New DataTable

        odt = oUsuario.GetCmb
        With Me.cmbUsuario
            .DataSource = odt
            .DisplayMember = "identificador"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbUsuario.SelectedIndex >= 0 Then
            cmbUsuario.SelectedIndex = 0
            Me.lblid_usuario.Text = cmbUsuario.SelectedValue.ToString
        End If
    End Sub

    Public Sub RefrescarGrillaTarea()
        Dim odt As New DataTable

        odt = oTarea.GetAll_GanttDetalle(CDate(Me.lblFecha_inicio.Text), CInt(Me.lblid_usuario.Text))

        Me.DataGridView2.DataSource = odt
        Me.DataGridView2.Columns(0).Visible = False

        If odt.Rows.Count <= 0 Then
            Me.lblid_tarea.Text = "0"
            Me.RefrescarGrillaHoras()
        End If
    End Sub

   Public  Sub RefrescarGrillaHoras()
        Dim odt As New DataTable

        odt = oHora_real.GetTarea(CInt(Me.lblid_tarea.Text))

        Me.DataGridView3.DataSource = odt
        Me.DataGridView3.Columns(0).Visible = False
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim odt As New DataTable
        Dim dtFecha As DateTime
        Dim dtfecha_fin As DateTime
        Dim strUsuario As String = ""
        Dim decHoras As Decimal = 0
        Dim strProyectoCuenta As String = """"
        Dim strDescripcion As String = ""
        Dim odtFecha As New DataTable
        Dim bitEsFeriado As Boolean = False
        Dim odtFeriado As New DataTable
        Dim odtTareaFinal As New DataTable

        'oGantt.Truncate()
        'oGantt.Cargar()

        odtFecha = oTarea.GetOne_Fechas(CInt(Me.lblid_usuario.Text))

        dtFecha = CDate(odtFecha.Rows(0).Item("fecha inicio"))
        If dtFecha > Date.Now.Date Then
            dtFecha = Date.Now.Date
        End If
        dtfecha_fin = CDate(odtFecha.Rows(0).Item("fecha fin")).AddDays(1)

        Me.ProgressBar1.Maximum = CInt(DateDiff(DateInterval.Day, dtFecha, dtfecha_fin))
        Dim contador As Integer = 1

        'consulta sobre las tareas del usuario
        odtTareaFinal = oTarea.GetAll_Gantt_Grilla(CInt(Me.lblid_usuario.Text))

        While dtFecha < dtfecha_fin
            odt = oTarea.GetAll_Gantt_2(dtFecha.Date, CInt(Me.lblid_usuario.Text))



            If odt.Rows.Count > 0 Then
                'strUsuario = CStr(odt.Rows(0).Item("nombre usuario"))
                'decHoras = CDec(odt.Rows(0).Item("horas"))
                'strProyectoCuenta = ""
                'strDescripcion = ""
            Else

                odtFeriado = oFeriado.GetOne_Fecha(dtFecha.Date)
                If odtFeriado.Rows.Count > 0 Then
                    bitEsFeriado = True
                Else
                    bitEsFeriado = False
                End If

                Dim newCustomersRow As DataRow = odtTareaFinal.NewRow()
                Dim oldWeekDayName As String
                oldWeekDayName = WeekdayName(Weekday(dtFecha))

                newCustomersRow("Día") = oldWeekDayName
                newCustomersRow("Fecha") = dtFecha
                newCustomersRow("Nombre usuario") = ""
                newCustomersRow("Horas") = 0
                newCustomersRow("Es Feriado") = bitEsFeriado

                odtTareaFinal.Rows.Add(newCustomersRow)
            End If

            '    Dim oldWeekDayName As String
            '    oldWeekDayName = WeekdayName(Weekday(dtFecha))

            '    If oldWeekDayName = "sábado" Or oldWeekDayName = "domingo" Then
            '        'no agrego
            '        oGantt.Insertar()
            '        oGantt.dia = oldWeekDayName
            '        oGantt.fecha = dtFecha.Date
            '        oGantt.horas = decHoras
            '        oGantt.nombre_usuario = strUsuario
            '        oGantt.es_feriado = bitEsFeriado
            '        oGantt.Guardar()
            '    Else
            '        oGantt.Insertar()
            '        oGantt.dia = oldWeekDayName
            '        oGantt.fecha = dtFecha.Date
            '        oGantt.horas = decHoras
            '        oGantt.nombre_usuario = strUsuario
            '        oGantt.es_feriado = bitEsFeriado
            '        oGantt.Guardar()
            '    End If

            dtFecha = DateAdd(DateInterval.Day, 1, dtFecha)

            Me.ProgressBar1.Value = contador
            contador = contador + 1
        End While

        '   odt = oTarea.GetAll_Gantt_Grilla(CInt(Me.lblid_usuario.Text))

        Dim view As New DataView(odtTareaFinal)
        view.Sort = "Fecha"

        Me.DataGridView1.DataSource = view
        Me.DataGridView1.Columns("Es feriado").Visible = False
        'Me.DataGridView1.Columns(0).Visible = False
        'Me.DataGridView1.Columns("Es feriado").Name = "Fdo."

    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting

        For Each row_grilla As DataGridViewRow In DataGridView1.Rows
            If CDate(row_grilla.Cells.Item("fecha").Value) = Date.Now.Date Then
                row_grilla.DefaultCellStyle.BackColor = Color.Green
            ElseIf CBool(row_grilla.Cells.Item("Es feriado").Value) = True Then
                'row_grilla.Cells.Item("Día").Style.BackColor = Color.Red
                row_grilla.DefaultCellStyle.BackColor = Color.Red
            ElseIf CStr(row_grilla.Cells.Item("Día").Value) = "sábado" Or CStr(row_grilla.Cells.Item("Día").Value) = "domingo" Then
                'row_grilla.Cells.Item("Día").Style.BackColor = Color.Gray
                row_grilla.DefaultCellStyle.BackColor = Color.LightGray
            End If
        Next


        'If Me.DataGridView1.Columns(e.ColumnIndex).Name = "Fdo." Then
        '    Dim Valor_Feriado As Boolean = CBool(Me.DataGridView1.Rows(e.RowIndex).Cells("Fdo.").Value)
        '    Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

        '    If Valor_Feriado = True Then
        '        e.CellStyle.ForeColor = Color.Red
        '    Else

        '    End If
        'End If

        'If Me.DataGridView1.Columns(e.ColumnIndex).Name = "Día" Then
        '    Dim Valor_Estado As String = CStr(Me.DataGridView1.Rows(e.RowIndex).Cells("Día").Value)
        '    Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

        '    If Valor_Estado = "sábado" Or Valor_Estado = "domingo" Then
        '        row.DefaultCellStyle.ForeColor = Color.Gray
        '    End If

        'End If



        'If Me.dgv_OrdenCompra.Columns(e.ColumnIndex).Name = "Fecha de Cierre" Then
        '    Dim cerrada As Boolean = CBool(Me.dgv_OrdenCompra.Rows(e.RowIndex).Cells("Esta cerrada").Value)

        '    If cerrada = False Then
        '        e.CellStyle.ForeColor = Color.LightBlue
        '        e.CellStyle.SelectionForeColor = Color.LightGoldenrodYellow
        '    Else
        '        e.CellStyle.ForeColor = Color.Black
        '        e.CellStyle.SelectionForeColor = Color.Brown
        '    End If
        'End If
    End Sub

    Private Sub DataGridView1_CurrentCellChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellChanged
        Try
            Me.lblFecha_inicio.Text = CStr(Me.DataGridView1.Item("Fecha", Me.DataGridView1.CurrentRow.Index).Value)
        Catch ex As Exception

        End Try
        If Not IsDate(Me.lblFecha_inicio.Text) Then
            Exit Sub
        End If

        Me.RefrescarGrillaTarea()
    End Sub


    Private Sub DataGridView2_CurrentCellChanged(sender As Object, e As EventArgs) Handles DataGridView2.CurrentCellChanged
        Try
            Me.lblid_tarea.Text = CStr(Me.DataGridView2.Item(0, Me.DataGridView2.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
        If Not IsNumeric(Me.lblid_tarea.Text) Then
            Exit Sub
        End If
        Me.RefrescarGrillaHoras()
    End Sub


    Private Sub btnBuscaFeriado_Click(sender As Object, e As EventArgs) Handles btnBuscaFeriado.Click
        frmAbmFeriado.ShowDialog()
        frmAbmFeriado.Dispose()
    End Sub

    Private Sub tsmReasignarFecha_Click(sender As Object, e As EventArgs) Handles tsmReasignarFecha.Click
        vgIdTareaGantt = CInt(Me.lblid_tarea.Text)

        frmReasignarTarea.ShowDialog()
        frmReasignarTarea.Dispose()

        Dim i As Integer = Me.DataGridView1.CurrentRow.Index
        Me.btnConsultar.PerformClick()

        Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(i).Cells("fecha")
    End Sub


    Private Sub cmbUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsuario.SelectedIndexChanged
        If Me.cmbUsuario.SelectedIndex >= 0 And IsNumeric(cmbUsuario.SelectedValue) Then
            Me.lblid_usuario.Text = cmbUsuario.SelectedValue.ToString
        End If
    End Sub

    Private Sub DataGridView3_CurrentCellChanged(sender As Object, e As EventArgs) Handles DataGridView3.CurrentCellChanged
        Try
            Me.lblid_hora_real.Text = CStr(Me.DataGridView3.Item(0, Me.DataGridView3.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        BanderaHora_real = 1
        '   Me.AddOwnedForm(frmDetalleHora_realGantt)
        oHora_real.Cargar()
        oHora_real.Insertar()

        frmDetalleHora_realGantt.CargarCombos()
        frmDetalleHora_realGantt.ShowDialog()
        frmDetalleHora_realGantt.Dispose()

        'Dim frmTemp As New frmDetalleHora_realGantt
        'BanderaHora_real = 1
        'Me.AddOwnedForm(frmTemp)
        'oHora_real.Cargar()
        'oHora_real.Insertar()

        'frmTemp.CargarCombos()
        'frmTemp.ShowDialog()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If Not IsNumeric(Me.lblid_hora_real.Text) Then
            Exit Sub
        End If

        If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        oHora_real.Borrar(CInt(Me.lblid_hora_real.Text))
        RefrescarGrillaHoras()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If Not IsNumeric(Me.lblid_hora_real.Text) Then
            Exit Sub
        End If
        BanderaHora_real = 2
        ' Me.AddOwnedForm(frmDetalleHora_realGantt)

        oHora_real.Cargar()
        oHora_real.Modificar(CInt(Me.lblid_hora_real.Text))

        frmDetalleHora_realGantt.CargarCombos()
        frmDetalleHora_realGantt.ShowDialog()
        frmDetalleHora_realGantt.Dispose()
        RefrescarGrillaHoras()
    End Sub


    Private Sub CanceladaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CanceladaToolStripMenuItem.Click
        oTarea.Modificar(CInt(Me.lblid_tarea.Text))
        oTarea.id_estado_tarea = 3
        oTarea.Guardar()

        Dim i As Integer = Me.DataGridView1.CurrentRow.Index
        Me.btnConsultar.PerformClick()

        Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(i).Cells("fecha")
    End Sub

    Private Sub SuspendidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuspendidaToolStripMenuItem.Click
        oTarea.Modificar(CInt(Me.lblid_tarea.Text))
        oTarea.id_estado_tarea = 2
        oTarea.Guardar()

        Dim i As Integer = Me.DataGridView1.CurrentRow.Index
        Me.btnConsultar.PerformClick()

        Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(i).Cells("fecha")
    End Sub

    Private Sub FinalizadaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FinalizadaToolStripMenuItem.Click

    End Sub

    Private Sub ProgramadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramadaToolStripMenuItem.Click
        oTarea.Modificar(CInt(Me.lblid_tarea.Text))
        oTarea.id_estado_tarea = 1
        oTarea.Guardar()

        Dim i As Integer = Me.DataGridView1.CurrentRow.Index
        Me.btnConsultar.PerformClick()

        Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(i).Cells("fecha")
    End Sub

    Private Sub FechaDeHoyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FechaDeHoyToolStripMenuItem.Click
        oTarea.Modificar(CInt(Me.lblid_tarea.Text))
        oTarea.id_estado_tarea = 4
        oTarea.fecha_inicio = DateTime.Now.Date
        oTarea.fecha_fin = DateTime.Now.Date
        oTarea.fecha_real = DateTime.Now.Date
        oTarea.Guardar()

        Dim i As Integer = Me.DataGridView1.CurrentRow.Index
        Me.btnConsultar.PerformClick()

        Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(i).Cells("fecha")
    End Sub

    Private Sub FechaViejaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FechaViejaToolStripMenuItem.Click
        oTarea.Modificar(CInt(Me.lblid_tarea.Text))
        oTarea.id_estado_tarea = 4
        oTarea.Guardar()

        Dim i As Integer = Me.DataGridView1.CurrentRow.Index
        Me.btnConsultar.PerformClick()

        Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(i).Cells("fecha")
    End Sub

    Private Sub FechaPersonalizadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FechaPersonalizadaToolStripMenuItem.Click
        Dim frmTemp As New frmFechaTarea

        frmTemp.ShowDialog()

        oTarea.Modificar(CInt(Me.lblid_tarea.Text))
        oTarea.id_estado_tarea = 4
        oTarea.fecha_inicio = parametro_fecha
        oTarea.fecha_fin = parametro_fecha
        oTarea.fecha_real = parametro_fecha
        oTarea.Guardar()

        Dim i As Integer = Me.DataGridView1.CurrentRow.Index
        Me.btnConsultar.PerformClick()

        Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(i).Cells("fecha")
    End Sub

    Private Sub btnFinalizarRapido_Click(sender As Object, e As EventArgs) Handles btnFinalizarRapido.Click
        oTarea.Modificar(CInt(Me.lblid_tarea.Text))
        oTarea.id_estado_tarea = 4
        oTarea.Guardar()

        Dim i As Integer = Me.DataGridView1.CurrentRow.Index
        Me.btnConsultar.PerformClick()

        Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(i).Cells("fecha")
    End Sub
End Class