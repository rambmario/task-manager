Public Class frmAbmMejora

   Dim odt As DataTable
   Dim BanderaConsultaMejora As Integer

   Private Sub frmAbmMejora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnAgregar, "Incorporar Nuevo Mejora")
       Me.ttGeneral.SetToolTip(Me.btnBorrar, "Borrar un  Mejora Existente")
       Me.ttGeneral.SetToolTip(Me.btnModificar, "Modificar  un Mejora Existente")
       'Me.ttGeneral.SetToolTip(Me.btnConsultar, "Consultar Datos del  Mejora Existente")

       Dim odt As DataTable
       odt = oMejora.Cargar()

       RefrescarGrilla()
       Me.txtBuscar.Focus()
       Me.Text = "Mejora"
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
       
        ''control de acceso y de permisos
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

       odt = oMejora.ConsultarTodo()
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
       odt = oMejora.Buscar(Me.txtBuscar.Text)
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
       Dim frmDetalle As New frmDetalleMejora
       btnTemp = CType(sender, Button)
       Try
           Select Case btnTemp.Name
               Case "btnAgregar"
                   BanderaMejora = 1
                   Me.AddOwnedForm(frmDetalle)
                   oMejora.Insertar()
                   frmDetalle.CargarCombos()
                   frmDetalle.ShowDialog()
               Case "btnModificar"
                   Dim i As Integer = Me.dgv1.CurrentRow.Index
                   If Not IsNumeric(Me.lblid_pk.Text) Then
                       Exit Sub
                   End If
                   BanderaMejora = 2
                   Me.AddOwnedForm(frmDetalle)
                   oMejora.Modificar(CInt(Me.lblid_pk.Text))
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

                   oMejora.Borrar(CInt(Me.lblid_pk.Text))
                   RefrescarGrilla()
               Case "btnAyuda"
                   'Process.Start(PathAyuda + "frmAbmMejora.avi")
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
