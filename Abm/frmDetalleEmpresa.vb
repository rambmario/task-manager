Public Class frmDetalleEmpresa

   Private Sub frmDetalleEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaTipo_empresa, "Buscar Nuevo Tipo_empresa")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Empresa")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbTipo_empresa.Text = oTipo_empresa.GetOne(CInt(Me.lblid_Tipo_empresa.Text)).Rows(0).Item("nombre Tipo empresa").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaEmpresa  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Empresa" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarTipo_empresa
   End Sub

   Sub CargarTipo_empresa()
       Dim odt As New DataTable

       odt = oTipo_empresa.GetCmb
       With Me.cmbTipo_empresa
           .DataSource = odt
           .DisplayMember = "nombre_tipo_empresa"
           .ValueMember = "id_tipo_empresa"
       End With
       If Me.cmbTipo_empresa.SelectedIndex >= 0 Then
           cmbTipo_empresa.SelectedIndex = 0
           Me.lblid_Tipo_empresa.Text = cmbTipo_empresa.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.txtnombre_empresa.Text = ""
       Me.txtcodigo_empresa.Text = ""
       Me.lblid_tipo_empresa.Text = "0"
       Me.cmbTipo_empresa.Text =  ""
       Me.txtmail_empresa.Text = ""
       Me.txtpassword_mail.Text = ""
       Me.txtlogo.Text = ""
   End Sub

   Private Sub ObtenerDatos()
       Me.txtnombre_empresa.Text = oEmpresa.nombre_empresa.Trim
       Me.txtcodigo_empresa.Text = oEmpresa.codigo_empresa.Trim
       Me.lblid_tipo_empresa.Text = oEmpresa.id_tipo_empresa.ToString
       Me.txtmail_empresa.Text = oEmpresa.mail_empresa.Trim
       Me.txtpassword_mail.Text = oEmpresa.password_mail.Trim
       Me.txtlogo.Text = oEmpresa.logo.Trim
   End Sub

   Private Sub AsignarDatos()
       oEmpresa.nombre_empresa = Me.txtnombre_empresa.Text
       oEmpresa.codigo_empresa = Me.txtcodigo_empresa.Text
       oEmpresa.id_tipo_empresa = CInt(Me.lblid_tipo_empresa.Text)
       oEmpresa.mail_empresa = Me.txtmail_empresa.Text
       oEmpresa.password_mail = Me.txtpassword_mail.Text
       oEmpresa.logo = Me.txtlogo.Text
   End Sub

   Public Sub SoloLectura()
       Me.txtnombre_empresa.Enabled = False
       Me.txtcodigo_empresa.Enabled = False
       Me.cmbTipo_empresa.Enabled = False
       Me.btnBuscaTipo_empresa.Enabled = False
       Me.txtmail_empresa.Enabled = False
       Me.txtpassword_mail.Enabled = False
       Me.txtlogo.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oEmpresa.Exist() Then
               If BanderaEmpresa = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaEmpresa = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaEmpresa
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oEmpresa.Guardar()
                   frmAbmEmpresa.RefrescarGrilla()
                   Me.CargarCombos()
                   oEmpresa.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.txtnombre_empresa.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oEmpresa.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
        If _
        Me.txtnombre_empresa.Text = "" Or _
        Me.txtcodigo_empresa.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
       Return bandera
   End Function

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       Dim blnVacios As Boolean

       If CDbl(Me.lblid_tipo_empresa.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de tipo_empresa")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaEmpresa  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

   Private Sub cmbTipo_empresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipo_empresa.SelectedIndexChanged
       If Me.cmbTipo_empresa.SelectedIndex >= 0 Then
           Me.lblid_tipo_empresa.Text = cmbTipo_empresa.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaTipo_empresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaTipo_empresa.Click
       Dim frmTemporal As New FrmAbmTipo_empresa
       frmTemporal.ShowDialog()
       Me.CargarTipo_empresa()
       Me.cmbTipo_empresa.Focus()
       Me.cmbTipo_empresa.Text = ""
       Me.lblid_Tipo_empresa.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtnombre_empresa.KeyPress, txtcodigo_empresa.KeyPress, txtmail_empresa.KeyPress, txtpassword_mail.KeyPress, txtlogo.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbTipo_empresa.KeyDown
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
