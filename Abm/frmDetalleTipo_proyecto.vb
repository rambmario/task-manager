Public Class frmDetalleTipo_proyecto

   Private Sub frmDetalleTipo_proyecto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Tipo_proyecto")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaTipo_proyecto  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Tipo_proyecto" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
   End Sub

   Sub LimpiarControles()
       Me.txtnombre_tipo_proyecto.Text = ""
   End Sub

   Private Sub ObtenerDatos()
       Me.txtnombre_tipo_proyecto.Text = oTipo_proyecto.nombre_tipo_proyecto.Trim
   End Sub

   Private Sub AsignarDatos()
       oTipo_proyecto.nombre_tipo_proyecto = Me.txtnombre_tipo_proyecto.Text
   End Sub

   Public Sub SoloLectura()
       Me.txtnombre_tipo_proyecto.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oTipo_proyecto.Exist() Then
               If BanderaTipo_proyecto = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaTipo_proyecto = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen �Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaTipo_proyecto
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oTipo_proyecto.Guardar()
                    frmAbmTipo_proyecto.RefrescarGrilla()
                    Me.CargarCombos()
                   oTipo_proyecto.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.txtnombre_tipo_proyecto.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oTipo_proyecto.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
       Me.txtnombre_tipo_proyecto.Text = "" Then
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       Dim blnVacios As Boolean


       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaTipo_proyecto  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtnombre_tipo_proyecto.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   'Handles 
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
