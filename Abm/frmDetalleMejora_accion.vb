Public Class frmDetalleMejora_accion

   Private Sub frmDetalleMejora_accion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaMejora, "Buscar Nuevo Mejora")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Mejora_accion")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

            Me.cmbusuario_accion.Text = oUsuario.GetOne(CInt(Me.lblid_usuario_accion.Text)).Rows(0).Item("nombre Usuario").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaMejora_accion  = 1 Then
           Me.LimpiarControles()
        End If
        Me.lblid_mejora.Text = CType(Owner, frmDetalleMejora).lblid_mejora.Text
       Me.Text = "Mejora_accion" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarMejora
       Me.CargarUsuario_accion
   End Sub

   Sub CargarMejora()
       Dim odt As New DataTable

       odt = oMejora.GetCmb
       With Me.cmbMejora
           .DataSource = odt
           .DisplayMember = "nombre_mejora"
           .ValueMember = "id_mejora"
       End With
       If Me.cmbMejora.SelectedIndex >= 0 Then
           cmbMejora.SelectedIndex = 0
           Me.lblid_Mejora.Text = cmbMejora.SelectedValue.ToString
       End If
   End Sub

   Sub CargarUsuario_accion()
       Dim odt As New DataTable

        odt = oUsuario.GetCmb
       With Me.cmbUsuario_accion
           .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
       End With
       If Me.cmbUsuario_accion.SelectedIndex >= 0 Then
           cmbUsuario_accion.SelectedIndex = 0
           Me.lblid_Usuario_accion.Text = cmbUsuario_accion.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
        'Me.lblid_mejora.Text = "0"
        'Me.cmbMejora.Text =  ""
       Me.dtpfecha_accion.Value = DateTime.Now
       Me.lblid_usuario_accion.Text = "0"
       Me.cmbUsuario_accion.Text =  ""
       Me.txtdescripccion_accion.Text = ""
   End Sub

   Private Sub ObtenerDatos()
       Me.lblid_mejora.Text = oMejora_accion.id_mejora.ToString
       Me.dtpfecha_accion.Value = oMejora_accion.fecha_accion
       Me.lblid_usuario_accion.Text = oMejora_accion.id_usuario_accion.ToString
       Me.txtdescripccion_accion.Text = oMejora_accion.descripccion_accion.Trim
   End Sub

   Private Sub AsignarDatos()
       oMejora_accion.id_mejora = CInt(Me.lblid_mejora.Text)
       oMejora_accion.fecha_accion = Me.dtpfecha_accion.Value.Date
       oMejora_accion.id_usuario_accion = CInt(Me.lblid_usuario_accion.Text)
       oMejora_accion.descripccion_accion = Me.txtdescripccion_accion.Text
   End Sub

   Public Sub SoloLectura()
       Me.cmbMejora.Enabled = False
       Me.btnBuscaMejora.Enabled = False
       Me.dtpfecha_accion.Enabled = False
       Me.cmbUsuario_accion.Enabled = False
       Me.txtdescripccion_accion.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oMejora_accion.Exist() Then
               If BanderaMejora_accion = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaMejora_accion = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaMejora_accion
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oMejora_accion.Guardar()
                   frmAbmMejora_accion.RefrescarGrilla()
                   Me.CargarCombos()
                   oMejora_accion.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.cmbMejora.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oMejora_accion.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
       Me.txtdescripccion_accion.Text = "" Then
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       Dim blnVacios As Boolean

        'If CDbl(Me.lblid_mejora.Text) = 0 Then
        '    MessageBox.Show("Debe Seleccionar un Dato del Combo de mejora")
        '    Exit Sub
        'End If
       If CDbl(Me.lblid_usuario_accion.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de usuario_accion")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaMejora_accion  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

   Private Sub cmbMejora_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMejora.SelectedIndexChanged
        'If Me.cmbMejora.SelectedIndex >= 0 Then
        '    Me.lblid_mejora.Text = cmbMejora.SelectedValue.ToString
        'End If
   End Sub

   Private Sub btnBuscaMejora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaMejora.Click
        'Dim frmTemporal As New FrmAbmMejora
        'frmTemporal.ShowDialog()
        'Me.CargarMejora()
        'Me.cmbMejora.Focus()
        'Me.cmbMejora.Text = ""
        'Me.lblid_Mejora.Text = "0"
   End Sub

   Private Sub cmbUsuario_accion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUsuario_accion.SelectedIndexChanged
       If Me.cmbUsuario_accion.SelectedIndex >= 0 Then
           Me.lblid_usuario_accion.Text = cmbUsuario_accion.SelectedValue.ToString
       End If
   End Sub

  

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtdescripccion_accion.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbMejora.KeyDown, dtpfecha_accion.KeyDown, cmbUsuario_accion.KeyDown
       If CDbl(e.KeyValue.ToString) = 13 Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   'Handles 
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
