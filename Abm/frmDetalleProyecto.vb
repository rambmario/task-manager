Public Class frmDetalleProyecto

   Private Sub frmDetalleProyecto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaTipo_proyecto, "Buscar Nuevo Tipo_proyecto")
       Me.ttGeneral.SetToolTip(Me.btnBuscaEmpresa, "Buscar Nuevo Empresa")
        Me.ttGeneral.SetToolTip(Me.btnBuscaEstado_proyecto, "Buscar Nuevo Estado_proyecto")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Proyecto")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbTipo_proyecto.Text = oTipo_proyecto.GetOne(CInt(Me.lblid_Tipo_proyecto.Text)).Rows(0).Item("nombre Tipo proyecto").ToString.Trim
            Me.cmbEmpresa.Text = oEmpresa.GetOne(CInt(Me.lblid_Empresa.Text)).Rows(0).Item("nombre Empresa").ToString.Trim
            Me.cmbEstado_proyecto.Text = oEstado_proyecto.GetOne(CInt(Me.lblid_Estado_proyecto.Text)).Rows(0).Item("nombre Estado proyecto").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaProyecto = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Proyecto" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Sub CargarCombos()
        Me.CargarTipo_proyecto()
        Me.CargarEmpresa()
        Me.CargarEstado_proyecto()
    End Sub

    Sub CargarTipo_proyecto()
        Dim odt As New DataTable

        odt = oTipo_proyecto.GetCmb
        With Me.cmbTipo_proyecto
            .DataSource = odt
            .DisplayMember = "nombre_tipo_proyecto"
            .ValueMember = "id_tipo_proyecto"
        End With
        If Me.cmbTipo_proyecto.SelectedIndex >= 0 Then
            cmbTipo_proyecto.SelectedIndex = 0
            Me.lblid_Tipo_proyecto.Text = cmbTipo_proyecto.SelectedValue.ToString
        End If
    End Sub

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
            Me.lblid_Empresa.Text = cmbEmpresa.SelectedValue.ToString
        End If
    End Sub

    Sub CargarEstado_proyecto()
        Dim odt As New DataTable

        odt = oEstado_proyecto.GetCmb
        With Me.cmbEstado_proyecto
            .DataSource = odt
            .DisplayMember = "nombre_estado_proyecto"
            .ValueMember = "id_estado_proyecto"
        End With
        If Me.cmbEstado_proyecto.SelectedIndex >= 0 Then
            cmbEstado_proyecto.SelectedIndex = 0
            Me.lblid_Estado_proyecto.Text = cmbEstado_proyecto.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Me.txtnombre_proyecto.Text = ""
        Me.txtcodigo_proyecto.Text = ""
        Me.lblid_tipo_proyecto.Text = "0"
        Me.cmbTipo_proyecto.Text = ""
        Me.lblid_empresa.Text = "0"
        Me.cmbEmpresa.Text = ""
        Me.txthora_prevista.Text = "0"
        Me.txthora_real.Text = "0"
        Me.dtpfecha_prevista_fin.Value = DateTime.Now
        Me.dtpfecha_real_fin.Value = DateTime.Now
        Me.lblid_estado_proyecto.Text = "0"
        Me.cmbEstado_proyecto.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        Me.txtnombre_proyecto.Text = oProyecto.nombre_proyecto.Trim
        Me.txtcodigo_proyecto.Text = oProyecto.codigo_proyecto.Trim
        Me.lblid_tipo_proyecto.Text = oProyecto.id_tipo_proyecto.ToString
        Me.lblid_empresa.Text = oProyecto.id_empresa.ToString
        Me.txthora_prevista.Text = oProyecto.hora_prevista.ToString.Trim
        Me.txthora_real.Text = oProyecto.hora_real.ToString.Trim
        Me.dtpfecha_prevista_fin.Value = oProyecto.fecha_prevista_fin
        Me.dtpfecha_real_fin.Value = oProyecto.fecha_real_fin
        Me.lblid_estado_proyecto.Text = oProyecto.id_estado_proyecto.ToString
    End Sub

    Private Sub AsignarDatos()
        oProyecto.nombre_proyecto = Me.txtnombre_proyecto.Text
        oProyecto.codigo_proyecto = Me.txtcodigo_proyecto.Text
        oProyecto.id_tipo_proyecto = CInt(Me.lblid_tipo_proyecto.Text)
        oProyecto.id_empresa = CInt(Me.lblid_empresa.Text)
        oProyecto.hora_prevista = CDec(Me.txthora_prevista.Text)
        oProyecto.hora_real = CDec(Me.txthora_real.Text)
        oProyecto.fecha_prevista_fin = Me.dtpfecha_prevista_fin.Value.Date
        oProyecto.fecha_real_fin = Me.dtpfecha_real_fin.Value.Date
        oProyecto.id_estado_proyecto = CInt(Me.lblid_estado_proyecto.Text)
    End Sub

    Public Sub SoloLectura()
        Me.txtnombre_proyecto.Enabled = False
        Me.txtcodigo_proyecto.Enabled = False
        Me.cmbTipo_proyecto.Enabled = False
        Me.btnBuscaTipo_proyecto.Enabled = False
        Me.cmbEmpresa.Enabled = False
        Me.btnBuscaEmpresa.Enabled = False
        Me.txthora_prevista.Enabled = False
        Me.txthora_real.Enabled = False
        Me.dtpfecha_prevista_fin.Enabled = False
        Me.dtpfecha_real_fin.Enabled = False
        Me.cmbEstado_proyecto.Enabled = False
        Me.btnBuscaEstado_proyecto.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oProyecto.Exist() Then
                If BanderaProyecto = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaProyecto = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaProyecto
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oProyecto.Guardar()
                    frmAbmProyecto.RefrescarGrilla()
                    Me.CargarCombos()
                    oProyecto.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.txtnombre_proyecto.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oProyecto.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If _
        Me.txtnombre_proyecto.Text = "" Or _
        Me.txtcodigo_proyecto.Text = "" Or _
        Me.txthora_prevista.Text = "" Or _
        Me.txthora_real.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_tipo_proyecto.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de tipo_proyecto")
            Exit Sub
        End If
        If CDbl(Me.lblid_empresa.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de empresa")
            Exit Sub
        End If
        If CDbl(Me.lblid_estado_proyecto.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de estado_proyecto")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaProyecto = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbTipo_proyecto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtipo_proyecto.SelectedIndexChanged
        If Me.cmbTipo_proyecto.SelectedIndex >= 0 Then
            Me.lblid_tipo_proyecto.Text = cmbTipo_proyecto.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaTipo_proyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscatipo_proyecto.Click
        Dim frmTemporal As New FrmAbmTipo_proyecto
        frmTemporal.ShowDialog()
        Me.CargarTipo_proyecto()
        Me.cmbTipo_proyecto.Focus()
        Me.cmbTipo_proyecto.Text = ""
        Me.lblid_Tipo_proyecto.Text = "0"
    End Sub

    Private Sub cmbEmpresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbempresa.SelectedIndexChanged
        If Me.cmbEmpresa.SelectedIndex >= 0 Then
            Me.lblid_empresa.Text = cmbEmpresa.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaempresa.Click
        Dim frmTemporal As New FrmAbmEmpresa
        frmTemporal.ShowDialog()
        Me.CargarEmpresa()
        Me.cmbEmpresa.Focus()
        Me.cmbEmpresa.Text = ""
        Me.lblid_Empresa.Text = "0"
    End Sub

    Private Sub cmbEstado_proyecto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstado_proyecto.SelectedIndexChanged
        If Me.cmbEstado_proyecto.SelectedIndex >= 0 Then
            Me.lblid_estado_proyecto.Text = cmbEstado_proyecto.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaEstado_proyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaEstado_proyecto.Click
        'Dim frmTemporal As New FrmAbmEstado_proyecto
        'frmTemporal.ShowDialog()
        'Me.CargarEstado_proyecto()
        'Me.cmbEstado_proyecto.Focus()
        'Me.cmbEstado_proyecto.Text = ""
        'Me.lblid_Estado_proyecto.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtnombre_proyecto.KeyPress, txtcodigo_proyecto.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbtipo_proyecto.KeyDown, cmbempresa.KeyDown, dtpfecha_prevista_fin.KeyDown, dtpfecha_real_fin.KeyDown, cmbEstado_proyecto.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

   Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txthora_prevista.KeyPress, txthora_real.KeyPress
       Dim txtTemp As TextBox
       txtTemp = CType(sender, TextBox)

       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
       If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Then
           If InStr(txtTemp.Text, ",") <> 0 Then
               e.Handled = True
           Else
               e.KeyChar = CChar(",")
           End If
       End If

       Dim Largo As Integer = InStr(txtTemp.Text, ",")

       If txtTemp.Text.Length > Largo + 2 And Largo <> 0 And e.KeyChar.ToString <> vbBack Then
           e.Handled = True
       End If

       If (e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9") Or e.KeyChar.ToString = "," Or e.KeyChar = vbBack Then
           '  e.Handled = False
       Else
           e.Handled = True
       End If
   End Sub

End Class
