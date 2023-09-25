Public Class frmDetalleUsuario

   Private Sub frmDetalleUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaTipo_usuario, "Buscar Nuevo Tipo_usuario")
       Me.ttGeneral.SetToolTip(Me.btnBuscaEmpresa, "Buscar Nuevo Empresa")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Usuario")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbTipo_usuario.Text = oTipo_usuario.GetOne(CInt(Me.lblid_Tipo_usuario.Text)).Rows(0).Item("nombre Tipo usuario").ToString.Trim
           Me.cmbEmpresa.Text = oEmpresa.GetOne(CInt(Me.lblid_Empresa.Text)).Rows(0).Item("nombre Empresa").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaUsuario  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Usuario" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarTipo_usuario
       Me.CargarEmpresa
   End Sub

   Sub CargarTipo_usuario()
       Dim odt As New DataTable

       odt = oTipo_usuario.GetCmb
       With Me.cmbTipo_usuario
           .DataSource = odt
           .DisplayMember = "nombre_tipo_usuario"
           .ValueMember = "id_tipo_usuario"
       End With
       If Me.cmbTipo_usuario.SelectedIndex >= 0 Then
           cmbTipo_usuario.SelectedIndex = 0
           Me.lblid_Tipo_usuario.Text = cmbTipo_usuario.SelectedValue.ToString
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

   Sub LimpiarControles()
       Me.txtnombre_usuario.Text = ""
       Me.txtapellido_usuario.Text = ""
       Me.txtidentificador.Text = ""
       Me.txtclave.Text = ""
       Me.lblid_tipo_usuario.Text = "0"
       Me.cmbTipo_usuario.Text =  ""
       Me.lblid_empresa.Text = "0"
       Me.cmbEmpresa.Text =  ""
       Me.txtcosto.Text = "0"
       Me.txtcapacidad_trabajo.Text = "0"
       Me.txtusuario_calendar.Text = ""
       Me.txtpassword_calendar.Text = ""
       Me.txtmail.Text = ""
   End Sub

   Private Sub ObtenerDatos()
       Me.txtnombre_usuario.Text = oUsuario.nombre_usuario.Trim
       Me.txtapellido_usuario.Text = oUsuario.apellido_usuario.Trim
       Me.txtidentificador.Text = oUsuario.identificador.Trim
       Me.txtclave.Text = oUsuario.clave.Trim
       Me.lblid_tipo_usuario.Text = oUsuario.id_tipo_usuario.ToString
       Me.lblid_empresa.Text = oUsuario.id_empresa.ToString
       Me.txtcosto.Text = oUsuario.costo.ToString.Trim
       Me.txtcapacidad_trabajo.Text = oUsuario.capacidad_trabajo.ToString.Trim
       Me.txtusuario_calendar.Text = oUsuario.usuario_calendar.Trim
       Me.txtpassword_calendar.Text = oUsuario.password_calendar.Trim
       Me.txtmail.Text = oUsuario.mail.Trim
   End Sub

   Private Sub AsignarDatos()
       oUsuario.nombre_usuario = Me.txtnombre_usuario.Text
       oUsuario.apellido_usuario = Me.txtapellido_usuario.Text
       oUsuario.identificador = Me.txtidentificador.Text
       oUsuario.clave = Me.txtclave.Text
       oUsuario.id_tipo_usuario = CInt(Me.lblid_tipo_usuario.Text)
       oUsuario.id_empresa = CInt(Me.lblid_empresa.Text)
       oUsuario.costo = CDec(Me.txtcosto.Text)
       oUsuario.capacidad_trabajo = CDec(Me.txtcapacidad_trabajo.Text)
       oUsuario.usuario_calendar = Me.txtusuario_calendar.Text
       oUsuario.password_calendar = Me.txtpassword_calendar.Text
       oUsuario.mail = Me.txtmail.Text
   End Sub

   Public Sub SoloLectura()
       Me.txtnombre_usuario.Enabled = False
       Me.txtapellido_usuario.Enabled = False
       Me.txtidentificador.Enabled = False
       Me.txtclave.Enabled = False
       Me.cmbTipo_usuario.Enabled = False
       Me.btnBuscaTipo_usuario.Enabled = False
       Me.cmbEmpresa.Enabled = False
       Me.btnBuscaEmpresa.Enabled = False
       Me.txtcosto.Enabled = False
       Me.txtcapacidad_trabajo.Enabled = False
       Me.txtusuario_calendar.Enabled = False
       Me.txtpassword_calendar.Enabled = False
       Me.txtmail.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oUsuario.Exist() Then
               If BanderaUsuario = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaUsuario = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaUsuario
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oUsuario.Guardar()
                   frmAbmUsuario.RefrescarGrilla()
                   Me.CargarCombos()
                   oUsuario.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.txtnombre_usuario.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oUsuario.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
       Me.txtnombre_usuario.Text = "" or _
       Me.txtapellido_usuario.Text = "" or _
       Me.txtidentificador.Text = "" or _
       Me.txtclave.Text = "" or _
       Me.txtcosto.Text = "" or _
       Me.txtcapacidad_trabajo.Text = "" or _
       Me.txtusuario_calendar.Text = "" or _
       Me.txtpassword_calendar.Text = "" or _
       Me.txtmail.Text = "" Then
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       Dim blnVacios As Boolean

       If CDbl(Me.lblid_tipo_usuario.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de tipo_usuario")
           Exit Sub
       End If
       If CDbl(Me.lblid_empresa.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de empresa")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaUsuario  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

   Private Sub cmbTipo_usuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipo_usuario.SelectedIndexChanged
       If Me.cmbTipo_usuario.SelectedIndex >= 0 Then
           Me.lblid_tipo_usuario.Text = cmbTipo_usuario.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaTipo_usuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaTipo_usuario.Click
       FrmAbmTipo_usuario.ShowDialog()
       FrmAbmTipo_usuario.Dispose()
       Me.CargarTipo_usuario()
       Me.cmbTipo_usuario.Focus()
       Me.cmbTipo_usuario.Text = ""
       Me.lblid_Tipo_usuario.Text = "0"
   End Sub

   Private Sub cmbEmpresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpresa.SelectedIndexChanged
       If Me.cmbEmpresa.SelectedIndex >= 0 Then
           Me.lblid_empresa.Text = cmbEmpresa.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaEmpresa.Click
       FrmAbmEmpresa.ShowDialog()
       FrmAbmEmpresa.Dispose()
       Me.CargarEmpresa()
       Me.cmbEmpresa.Focus()
       Me.cmbEmpresa.Text = ""
       Me.lblid_Empresa.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtnombre_usuario.KeyPress, txtapellido_usuario.KeyPress, txtidentificador.KeyPress, txtclave.KeyPress, txtusuario_calendar.KeyPress, txtpassword_calendar.KeyPress, txtmail.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbTipo_usuario.KeyDown, cmbEmpresa.KeyDown
       If CDbl(e.KeyValue.ToString) = 13 Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtcosto.KeyPress, txtcapacidad_trabajo.KeyPress
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
