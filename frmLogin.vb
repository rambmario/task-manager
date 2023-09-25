Public Class frmLogin

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        '   User = odt.Rows.Find(Me.lblid_campana.Text).Item("nombre_usuario").ToString.Trim
        Dim odtTemp As New DataTable

        odtTemp = oUsuario.GetUser(Me.UsernameTextBox.Text.Trim, Me.PasswordTextBox.Text.Trim)
        If odtTemp.Rows.Count <= 0 Then
            MessageBox.Show("Los datos ingresados son incorrectos", "PERMISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            vgNombreUsuario = Me.UsernameTextBox.Text
            vgCodigoUsuario = CInt(odtTemp.Rows(0).Item("id usuario"))
            vgCodigoTipoUsuario = CInt(odtTemp.Rows(0).Item("id tipo usuario"))
            vgUsuarioCalendarUser = CType(odtTemp.Rows(0).Item("Usuario calendar"), String)
            vgUsuarioCalendarPass = CType(odtTemp.Rows(0).Item("Password calendar"), String)
            vgUsuarioCorreo = CType(odtTemp.Rows(0).Item("Mail"), String)

            PathReporte = Environment.CurrentDirectory
            LargoPath = PathReporte.IndexOf("\bin")
            PathReporte = String.Concat(PathReporte.Substring(0, LargoPath), "\Reportes\")

            Dim frmTemp As New frmMain
            frmTemp.ShowDialog()

            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Dim odt As New DataTable
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oUsuario.Cargar()

        'Dim odt1 As New DataTable
        'odt1 = oClienteMaestro.GetOne(1)
        'If odt1.Rows.Count <> 0 Then
        '    'If "virikyna_rio" = odt.Rows(0).Item("Nombre permiso").ToString() Then
        '    vgNombreCliente = odt1.Rows(0).Item("nombre cliente maestro").ToString()
        '    vgNombrePermiso = odt1.Rows(0).Item("nombre permiso").ToString()
        '    vgNombreReporte = odt1.Rows(0).Item("nombre reporte").ToString()

        '    vgCuentaClienteSuma = odt1.Rows(0).Item("Cuenta cliente suma").ToString()
        '    vgCuentaClienteResta = odt1.Rows(0).Item("Cuenta cliente resta").ToString()
        '    vgCuentaClienteResta_N = odt1.Rows(0).Item("Cuenta cliente resta n").ToString()
        '    vgCuentaProveedorSuma = odt1.Rows(0).Item("Cuenta proveedor suma").ToString()
        '    vgCuentaProveedorResta = odt1.Rows(0).Item("Cuenta proveedor resta").ToString()
        '    vgPdv = odt1.Rows(0).Item("PDV").ToString()
        'End If
    End Sub

End Class
