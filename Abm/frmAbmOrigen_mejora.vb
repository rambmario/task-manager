Public Class frmAbmOrigen_mejora

   Dim odt As DataTable
   Dim BanderaConsultaOrigen_mejora As Integer

   Private Sub frmAbmOrigen_mejora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnAgregar, "Incorporar Nuevo Origen_mejora")
       Me.ttGeneral.SetToolTip(Me.btnBorrar, "Borrar un  Origen_mejora Existente")
       Me.ttGeneral.SetToolTip(Me.btnModificar, "Modificar  un Origen_mejora Existente")
       'Me.ttGeneral.SetToolTip(Me.btnConsultar, "Consultar Datos del  Origen_mejora Existente")

       Dim odt As DataTable
       odt = oOrigen_mejora.Cargar()

       RefrescarGrilla()
       Me.txtBuscar.Focus()
       Me.Text = "Origen_mejora"
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
       
       'control de acceso y de permisos
        'Dim odtUser As New DataTable
        'odtUser = oUsuario.GetPermiso(vgNombreUsuario, Me.Name)
        'If odtUser.Rows.Count = 0 OrElse CDbl(odtUser.Rows(0).Item("habilitado")) = 0 Then
        '    Me.btnAgregar.Enabled = False
        '    Me.btnBorrar.Enabled = False
        '    Me.btnModificar.Enabled = False
        'End If
       
   End Sub

   Public Sub RefrescarGrilla()
       Dim odt As DataTable

       odt = oOrigen_mejora.ConsultarTodo()
       Me.dgv1.DataSource = odt
       Me.dgv1.Columns(0).Visible = False
   End Sub

   Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.btnModificar.Focus()
       End If
   End Sub

   Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
       If Me.txtBuscar.Text = "" Then
           Me.txtBuscar.Text = " "
       End If
       odt = oOrigen_mejora.Buscar(Me.txtBuscar.Text)
       Me.dgv1.DataSource = odt
   End Sub

   Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
       Try
           Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
       Catch ex As Exception
       End Try
   End Sub

   Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click, btnBorrar.Click, btnModificar.Click, btnSalir.Click
       Dim btnTemp As New Button
       Dim frmDetalle As New frmDetalleOrigen_mejora
       btnTemp = CType(sender, Button)
       Try
           Select Case btnTemp.Name
               Case "btnAgregar"
                   BanderaOrigen_mejora = 1
                   Me.AddOwnedForm(frmDetalle)
                   oOrigen_mejora.Insertar()
                   frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrilla()
               Case "btnModificar"
                   Dim i As Integer = Me.dgv1.CurrentRow.Index
                   If Not IsNumeric(Me.lblid_pk.Text) Then
                       Exit Sub
                   End If
                   BanderaOrigen_mejora = 2
                   Me.AddOwnedForm(frmDetalle)
                   oOrigen_mejora.Modificar(CInt(Me.lblid_pk.Text))
                   frmDetalle.CargarCombos()
                   frmDetalle.ShowDialog()
                   RefrescarGrilla()
                   Me.dgv1.CurrentCell = Me.dgv1.Rows(i).Cells(1)
               Case "btnBorrar"
                   If Not IsNumeric(Me.lblid_pk.Text) Then
                       Exit Sub
                   End If

                   If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                   = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If

                   oOrigen_mejora.Borrar(CInt(Me.lblid_pk.Text))
                   RefrescarGrilla()
               Case "btnAyuda"
                   'Process.Start(PathAyuda + "frmAbmOrigen_mejora.avi")
               Case "btnSalir"
                   Me.Close()
           End Select
           Me.txtBuscar.Text = ""
           Me.txtBuscar.Focus()
       Catch ex As Exception
       MessageBox.Show(ex.Message)
       End Try
   End Sub

   End Class
