Imports System.Net.Mail

Public Class frmMariling

    Dim odt As New DataTable
    Private Sub frmMariling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.lblid_empresa.Text = CType(Me.Owner, frmAbmTarea).lblid_empresa.Text

        Me.lblid_empresa.Text = frmAbmTarea.lblid_empresa.Text

        odt = oTarea.GetAllMailing(CInt(Me.lblid_empresa.Text))
        Me.DataGridView1.DataSource = odt

        Me.DataGridView1.Columns(0).Visible = False
    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.EnviarMail()
    End Sub




    Private Sub EnviarMail()

        Dim odtEmp As New DataTable
        Dim odtEmpresaDestino As New DataTable
        Dim strMailPropio As String = ""
        Dim strPass As String = ""
        Dim strMailDestino As String = ""

        'datos de origen
        odtEmp = oEmpresa.GetAllTipo(1)

        If odtEmp.Rows.Count > 0 Then
            strMailPropio = CStr(odtEmp.Rows(0).Item("Mail empresa"))
            strPass = CStr(odtEmp.Rows(0).Item("Password empresa"))
        Else
            MessageBox.Show("Debe configurar una empresa como propia y definir el correo electronico")
            Exit Sub
        End If

        'datos de destino
        odtEmpresaDestino = oEmpresa.GetOne(CInt(Me.lblid_empresa.Text))

        If odtEmpresaDestino.Rows.Count > 0 Then
            strMailDestino = CStr(odtEmpresaDestino.Rows(0).Item("Mail empresa"))
        End If

        'Funcion de envio de correo

        Dim SMTP As New System.Net.Mail.SmtpClient 'Variable con la que se envia el correo
        Dim CORREO As New System.Net.Mail.MailMessage
        CORREO.From = New System.Net.Mail.MailAddress(strMailPropio, "Correo Electronico", System.Text.Encoding.UTF8)


        Dim strCuerpo As String = ""

        For Each row As DataRow In odt.Rows
            strCuerpo = strCuerpo & "* " & CStr(row("id tarea")) & ": " & CStr(row("comentario")) & vbCrLf
        Next

        'strCuerpo = "* " & CStr(Me.DataGridView1.Rows(0).Cells(2).Value) & vbCrLf _
        '    & "* " & CStr(Me.DataGridView1.Rows(0).Cells(2).Value) & vbCrLf _
        '     & "* " & CStr(Me.DataGridView1.Rows(0).Cells(2).Value) & vbCrLf _
        '    & "* " & CStr(Me.DataGridView1.Rows(0).Cells(2).Value)

        Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(strCuerpo, Nothing, "text/html")


        'Path de la imagen
        Dim logo As New LinkedResource("H:\VBNet\_Analisis\_Iconos\36.jpg")
        logo.ContentId = "companylogo"
        'Adicionando logo
        htmlView.LinkedResources.Add(logo)


        CORREO.To.Add(strMailDestino)
        'Adicionando copia oculta
        CORREO.Bcc.Add(strMailPropio)

        CORREO.IsBodyHtml = False
        '' CORREO.AlternateViews.Add(htmlView)
        CORREO.Body = strCuerpo

        CORREO.Subject = "Modificaciones"

        SMTP.Host = "box569.bluehost.com"
        SMTP.Port = 587


        Try
            SMTP.Credentials = New System.Net.NetworkCredential(strMailPropio, strPass)
            SMTP.Send(CORREO)

        Catch ex As System.Net.Mail.SmtpException
            MessageBox.Show("Fallo el envio: " & ex.Message)
        End Try
    End Sub


End Class