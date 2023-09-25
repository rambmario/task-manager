Public Class frmDetalleSub_proyecto

   Private Sub frmDetalleSub_proyecto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaProyecto, "Buscar Nuevo Proyecto")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Sub_proyecto")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbProyecto.Text = oProyecto.GetOne(CInt(Me.lblid_Proyecto.Text)).Rows(0).Item("nombre Proyecto").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaSub_proyecto  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Sub_proyecto" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarProyecto
   End Sub

   Sub CargarProyecto()
       Dim odt As New DataTable

       odt = oProyecto.GetCmb
       With Me.cmbProyecto
           .DataSource = odt
           .DisplayMember = "nombre_proyecto"
           .ValueMember = "id_proyecto"
       End With
       If Me.cmbProyecto.SelectedIndex >= 0 Then
           cmbProyecto.SelectedIndex = 0
           Me.lblid_Proyecto.Text = cmbProyecto.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.txtnombre_sub_proyecto.Text = ""
       Me.txtcodigo_sub_proyecto.Text = ""
       Me.txthora_prevista.Text = "0"
       Me.txthora_real.Text = "0"
       Me.dtpfecha_prevista.Value = DateTime.Now
       Me.dtpfecha_real.Value = DateTime.Now
       Me.lblid_proyecto.Text = "0"
       Me.cmbProyecto.Text =  ""
   End Sub

   Private Sub ObtenerDatos()
       Me.txtnombre_sub_proyecto.Text = oSub_proyecto.nombre_sub_proyecto.Trim
       Me.txtcodigo_sub_proyecto.Text = oSub_proyecto.codigo_sub_proyecto.Trim
       Me.txthora_prevista.Text = oSub_proyecto.hora_prevista.ToString.Trim
       Me.txthora_real.Text = oSub_proyecto.hora_real.ToString.Trim
       Me.dtpfecha_prevista.Value = oSub_proyecto.fecha_prevista
       Me.dtpfecha_real.Value = oSub_proyecto.fecha_real
       Me.lblid_proyecto.Text = oSub_proyecto.id_proyecto.ToString
   End Sub

   Private Sub AsignarDatos()
       oSub_proyecto.nombre_sub_proyecto = Me.txtnombre_sub_proyecto.Text
       oSub_proyecto.codigo_sub_proyecto = Me.txtcodigo_sub_proyecto.Text
       oSub_proyecto.hora_prevista = CDec(Me.txthora_prevista.Text)
       oSub_proyecto.hora_real = CDec(Me.txthora_real.Text)
       oSub_proyecto.fecha_prevista = Me.dtpfecha_prevista.Value.Date
       oSub_proyecto.fecha_real = Me.dtpfecha_real.Value.Date
       oSub_proyecto.id_proyecto = CInt(Me.lblid_proyecto.Text)
   End Sub

   Public Sub SoloLectura()
       Me.txtnombre_sub_proyecto.Enabled = False
       Me.txtcodigo_sub_proyecto.Enabled = False
       Me.txthora_prevista.Enabled = False
       Me.txthora_real.Enabled = False
       Me.dtpfecha_prevista.Enabled = False
       Me.dtpfecha_real.Enabled = False
       Me.cmbProyecto.Enabled = False
       Me.btnBuscaProyecto.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oSub_proyecto.Exist() Then
               If BanderaSub_proyecto = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaSub_proyecto = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaSub_proyecto
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oSub_proyecto.Guardar()
                    frmAbmSub_proyecto.RefrescarGrilla()
                    Me.CargarCombos()
                    oSub_proyecto.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.txtnombre_sub_proyecto.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oSub_proyecto.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If _
        Me.txtnombre_sub_proyecto.Text = "" Or _
        Me.txtcodigo_sub_proyecto.Text = "" Or _
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

        If CDbl(Me.lblid_proyecto.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de proyecto")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaSub_proyecto = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbProyecto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbproyecto.SelectedIndexChanged
        If Me.cmbProyecto.SelectedIndex >= 0 Then
            Me.lblid_proyecto.Text = cmbProyecto.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaproyecto.Click
        Dim frmTemporal As New FrmAbmProyecto
        frmTemporal.ShowDialog()
        Me.CargarProyecto()
       Me.cmbProyecto.Focus()
       Me.cmbProyecto.Text = ""
       Me.lblid_Proyecto.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtnombre_sub_proyecto.KeyPress, txtcodigo_sub_proyecto.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles dtpfecha_prevista.KeyDown, dtpfecha_real.KeyDown, cmbProyecto.KeyDown
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
