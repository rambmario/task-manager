Public Class frmAbmTipo_tarea

   Dim odt As DataTable
   Dim BanderaConsultaTipo_tarea As Integer

   Private Sub frmAbmTipo_tarea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnAgregar, "Incorporar Nuevo Tipo_tarea")
       Me.ttGeneral.SetToolTip(Me.btnBorrar, "Borrar un  Tipo_tarea Existente")
       Me.ttGeneral.SetToolTip(Me.btnModificar, "Modificar  un Tipo_tarea Existente")
       'Me.ttGeneral.SetToolTip(Me.btnConsultar, "Consultar Datos del  Tipo_tarea Existente")

       Dim odt As DataTable
       odt = oTipo_tarea.Cargar()

       RefrescarGrilla()
       Me.txtBuscar.Focus()
        Me.Text = "Tipo de Tarea"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

    End Sub

    Public Sub RefrescarGrilla()
        Dim odt As DataTable

        odt = oTipo_tarea.ConsultarTodo()
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
        odt = oTipo_tarea.Buscar(Me.txtBuscar.Text)
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
        Dim frmDetalle As New frmDetalleTipo_tarea
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    BanderaTipo_tarea = 1
                    Me.AddOwnedForm(frmDetalle)
                    oTipo_tarea.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    BanderaTipo_tarea = 2
                    Me.AddOwnedForm(frmDetalle)
                    oTipo_tarea.Modificar(CInt(Me.lblid_pk.Text))
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrilla()
                Case "btnBorrar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    oTipo_tarea.Borrar(CInt(Me.lblid_pk.Text))
                    RefrescarGrilla()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmTipo_tarea.avi")
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
