<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleUsuario
   Inherits System.Windows.Forms.Form

   'Form reemplaza a Dispose para limpiar la lista de componentes.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
       If disposing AndAlso components IsNot Nothing Then
           components.Dispose()
       End If
       MyBase.Dispose(disposing)
   End Sub

   'Requerido por el Dise�ador de Windows Forms
   Private components As System.ComponentModel.IContainer

   'NOTA: el Dise�ador de Windows Forms necesita el siguiente procedimiento
   'Se puede modificar usando el Dise�ador de Windows Forms.
   'No lo modifique con el editor de c�digo.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
       Me.components = New System.ComponentModel.Container
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleUsuario))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.txtnombre_usuario = New System.Windows.Forms.TextBox
       Me.etiquetanombre_usuario = New System.Windows.Forms.Label
       Me.txtapellido_usuario = New System.Windows.Forms.TextBox
       Me.etiquetaapellido_usuario = New System.Windows.Forms.Label
       Me.txtidentificador = New System.Windows.Forms.TextBox
       Me.etiquetaidentificador = New System.Windows.Forms.Label
       Me.txtclave = New System.Windows.Forms.TextBox
       Me.etiquetaclave = New System.Windows.Forms.Label
       Me.lblid_tipo_usuario = New System.Windows.Forms.Label
       Me.btnBuscatipo_usuario = New System.Windows.Forms.Button
       Me.cmbtipo_usuario = New System.Windows.Forms.ComboBox
       Me.etiquetaid_tipo_usuario = New System.Windows.Forms.Label
       Me.lblid_empresa = New System.Windows.Forms.Label
       Me.btnBuscaempresa = New System.Windows.Forms.Button
       Me.cmbempresa = New System.Windows.Forms.ComboBox
       Me.etiquetaid_empresa = New System.Windows.Forms.Label
       Me.txtcosto = New System.Windows.Forms.TextBox
       Me.etiquetacosto = New System.Windows.Forms.Label
       Me.txtcapacidad_trabajo = New System.Windows.Forms.TextBox
       Me.etiquetacapacidad_trabajo = New System.Windows.Forms.Label
       Me.txtusuario_calendar = New System.Windows.Forms.TextBox
       Me.etiquetausuario_calendar = New System.Windows.Forms.Label
       Me.txtpassword_calendar = New System.Windows.Forms.TextBox
       Me.etiquetapassword_calendar = New System.Windows.Forms.Label
       Me.txtmail = New System.Windows.Forms.TextBox
       Me.etiquetamail = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'txtnombre_usuario
       '
       Me.txtnombre_usuario.BackColor = System.Drawing.Color.White
       Me.txtnombre_usuario.Location = New System.Drawing.Point(161, 70)
       Me.txtnombre_usuario.Size = New System.Drawing.Size(385, 20)
       Me.txtnombre_usuario.MaxLength = 50
       Me.txtnombre_usuario.Name = "txtnombre_usuario"
       Me.txtnombre_usuario.TabIndex = 4
       '
       'etiquietanombre_usuario
       '
       Me.etiquetanombre_usuario.BackColor = System.Drawing.Color.SteelBlue
       Me.etiquetanombre_usuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetanombre_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanombre_usuario.ForeColor = System.Drawing.Color.White
       Me.etiquetanombre_usuario.Location = New System.Drawing.Point(22, 70)
       Me.etiquetanombre_usuario.Name = "etiquetanombre_usuario"
       Me.etiquetanombre_usuario.Size = New System.Drawing.Size(133, 21)
       Me.etiquetanombre_usuario.TabIndex = 500
       Me.etiquetanombre_usuario.Text = "Nombre usuario"
       Me.etiquetanombre_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
       '
       '
       'txtapellido_usuario
       '
       Me.txtapellido_usuario.BackColor = System.Drawing.Color.White
       Me.txtapellido_usuario.Location = New System.Drawing.Point(161, 113)
       Me.txtapellido_usuario.Size = New System.Drawing.Size(385, 20)
       Me.txtapellido_usuario.MaxLength = 50
       Me.txtapellido_usuario.Name = "txtapellido_usuario"
       Me.txtapellido_usuario.TabIndex = 5
       '
       'etiquietaapellido_usuario
       '
       Me.etiquetaapellido_usuario.BackColor = System.Drawing.Color.SteelBlue
       Me.etiquetaapellido_usuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetaapellido_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaapellido_usuario.ForeColor = System.Drawing.Color.White
       Me.etiquetaapellido_usuario.Location = New System.Drawing.Point(22, 113)
       Me.etiquetaapellido_usuario.Name = "etiquetaapellido_usuario"
       Me.etiquetaapellido_usuario.Size = New System.Drawing.Size(133, 21)
       Me.etiquetaapellido_usuario.TabIndex = 501
       Me.etiquetaapellido_usuario.Text = "Apellido usuario"
       Me.etiquetaapellido_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
       '
       '
       'txtidentificador
       '
       Me.txtidentificador.BackColor = System.Drawing.Color.White
       Me.txtidentificador.Location = New System.Drawing.Point(161, 156)
       Me.txtidentificador.Size = New System.Drawing.Size(385, 20)
       Me.txtidentificador.MaxLength = 50
       Me.txtidentificador.Name = "txtidentificador"
       Me.txtidentificador.TabIndex = 6
       '
       'etiquietaidentificador
       '
       Me.etiquetaidentificador.BackColor = System.Drawing.Color.SteelBlue
       Me.etiquetaidentificador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetaidentificador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaidentificador.ForeColor = System.Drawing.Color.White
       Me.etiquetaidentificador.Location = New System.Drawing.Point(22, 156)
       Me.etiquetaidentificador.Name = "etiquetaidentificador"
       Me.etiquetaidentificador.Size = New System.Drawing.Size(133, 21)
       Me.etiquetaidentificador.TabIndex = 502
       Me.etiquetaidentificador.Text = "Identificador"
       Me.etiquetaidentificador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
       '
       '
       'txtclave
       '
       Me.txtclave.BackColor = System.Drawing.Color.White
       Me.txtclave.Location = New System.Drawing.Point(161, 199)
       Me.txtclave.Size = New System.Drawing.Size(385, 20)
       Me.txtclave.MaxLength = 50
       Me.txtclave.Name = "txtclave"
       Me.txtclave.TabIndex = 7
       '
       'etiquietaclave
       '
       Me.etiquetaclave.BackColor = System.Drawing.Color.SteelBlue
       Me.etiquetaclave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetaclave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaclave.ForeColor = System.Drawing.Color.White
       Me.etiquetaclave.Location = New System.Drawing.Point(22, 199)
       Me.etiquetaclave.Name = "etiquetaclave"
       Me.etiquetaclave.Size = New System.Drawing.Size(133, 21)
       Me.etiquetaclave.TabIndex = 503
       Me.etiquetaclave.Text = "Clave"
       Me.etiquetaclave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
       '
       '
       'lblid_tipo_usuario
       '
       Me.lblid_tipo_usuario.AutoSize = True
       Me.lblid_tipo_usuario.BackColor = System.Drawing.Color.Red
       Me.lblid_tipo_usuario.Location = New System.Drawing.Point(370, 242)
       Me.lblid_tipo_usuario.Name = "lblid_tipo_usuario"
       Me.lblid_tipo_usuario.Size = New System.Drawing.Size(13, 13)
       Me.lblid_tipo_usuario.TabIndex = 504
       Me.lblid_tipo_usuario.Text = "0"
       Me.lblid_tipo_usuario.Visible = False
       '
       'btnBuscatipo_usuario
       '
       Me.btnBuscatipo_usuario.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscatipo_usuario.Image = Global.Gestion_tarea.My.Resources.Resources.buscar_c_25
       Me.btnBuscatipo_usuario.Location = New System.Drawing.Point(516, 242)
       Me.btnBuscatipo_usuario.Name = "btnBuscatipo_usuario"
       Me.btnBuscatipo_usuario.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscatipo_usuario.TabIndex = 60
       Me.btnBuscatipo_usuario.UseVisualStyleBackColor = True
       '
       'cmbtipo_usuario
       '
       Me.cmbtipo_usuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbtipo_usuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbtipo_usuario.FormattingEnabled = True
       Me.cmbtipo_usuario.Location = New System.Drawing.Point(161, 242)
       Me.cmbtipo_usuario.Size = New System.Drawing.Size(349, 21)
       Me.cmbtipo_usuario.Name = "cmbtipo_usuario"
       Me.cmbtipo_usuario.TabIndex = 8
       '
       'etiquietaid_tipo_usuario
       '
       Me.etiquetaid_tipo_usuario.BackColor = System.Drawing.Color.SteelBlue
       Me.etiquetaid_tipo_usuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetaid_tipo_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_tipo_usuario.ForeColor = System.Drawing.Color.White
       Me.etiquetaid_tipo_usuario.Location = New System.Drawing.Point(22, 242)
       Me.etiquetaid_tipo_usuario.Name = "etiquetaid_tipo_usuario"
       Me.etiquetaid_tipo_usuario.Size = New System.Drawing.Size(133, 21)
       Me.etiquetaid_tipo_usuario.TabIndex = 505
       Me.etiquetaid_tipo_usuario.Text = "Tipo usuario"
       Me.etiquetaid_tipo_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
       '
       '
       'lblid_empresa
       '
       Me.lblid_empresa.AutoSize = True
       Me.lblid_empresa.BackColor = System.Drawing.Color.Red
       Me.lblid_empresa.Location = New System.Drawing.Point(370, 285)
       Me.lblid_empresa.Name = "lblid_empresa"
       Me.lblid_empresa.Size = New System.Drawing.Size(13, 13)
       Me.lblid_empresa.TabIndex = 506
       Me.lblid_empresa.Text = "0"
       Me.lblid_empresa.Visible = False
       '
       'btnBuscaempresa
       '
       Me.btnBuscaempresa.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaempresa.Image = Global.Gestion_tarea.My.Resources.Resources.buscar_c_25
       Me.btnBuscaempresa.Location = New System.Drawing.Point(516, 285)
       Me.btnBuscaempresa.Name = "btnBuscaempresa"
       Me.btnBuscaempresa.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaempresa.TabIndex = 61
       Me.btnBuscaempresa.UseVisualStyleBackColor = True
       '
       'cmbempresa
       '
       Me.cmbempresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbempresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbempresa.FormattingEnabled = True
       Me.cmbempresa.Location = New System.Drawing.Point(161, 285)
       Me.cmbempresa.Size = New System.Drawing.Size(349, 21)
       Me.cmbempresa.Name = "cmbempresa"
       Me.cmbempresa.TabIndex = 9
       '
       'etiquietaid_empresa
       '
       Me.etiquetaid_empresa.BackColor = System.Drawing.Color.SteelBlue
       Me.etiquetaid_empresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetaid_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_empresa.ForeColor = System.Drawing.Color.White
       Me.etiquetaid_empresa.Location = New System.Drawing.Point(22, 285)
       Me.etiquetaid_empresa.Name = "etiquetaid_empresa"
       Me.etiquetaid_empresa.Size = New System.Drawing.Size(133, 21)
       Me.etiquetaid_empresa.TabIndex = 507
       Me.etiquetaid_empresa.Text = "Empresa"
       Me.etiquetaid_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
       '
       '
       'txtcosto
       '
       Me.txtcosto.BackColor = System.Drawing.Color.White
       Me.txtcosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtcosto.ForeColor = System.Drawing.Color.Blue
       Me.txtcosto.Location = New System.Drawing.Point(161, 328)
       Me.txtcosto.MaxLength = 50
       Me.txtcosto.Name = "txtcosto"
       Me.txtcosto.Size = New System.Drawing.Size(222, 31)
       Me.txtcosto.TabIndex = 10
       Me.txtcosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietacosto
       '
       Me.etiquetacosto.BackColor = System.Drawing.Color.SteelBlue
       Me.etiquetacosto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetacosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacosto.ForeColor = System.Drawing.Color.White
       Me.etiquetacosto.Location = New System.Drawing.Point(22, 328)
       Me.etiquetacosto.Name = "etiquetacosto"
       Me.etiquetacosto.Size = New System.Drawing.Size(133, 21)
       Me.etiquetacosto.TabIndex = 508
       Me.etiquetacosto.Text = "Costo"
       Me.etiquetacosto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
       '
       '
       'txtcapacidad_trabajo
       '
       Me.txtcapacidad_trabajo.BackColor = System.Drawing.Color.White
       Me.txtcapacidad_trabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtcapacidad_trabajo.ForeColor = System.Drawing.Color.Blue
       Me.txtcapacidad_trabajo.Location = New System.Drawing.Point(161, 381)
       Me.txtcapacidad_trabajo.MaxLength = 50
       Me.txtcapacidad_trabajo.Name = "txtcapacidad_trabajo"
       Me.txtcapacidad_trabajo.Size = New System.Drawing.Size(222, 31)
       Me.txtcapacidad_trabajo.TabIndex = 11
       Me.txtcapacidad_trabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietacapacidad_trabajo
       '
       Me.etiquetacapacidad_trabajo.BackColor = System.Drawing.Color.SteelBlue
       Me.etiquetacapacidad_trabajo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetacapacidad_trabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacapacidad_trabajo.ForeColor = System.Drawing.Color.White
       Me.etiquetacapacidad_trabajo.Location = New System.Drawing.Point(22, 381)
       Me.etiquetacapacidad_trabajo.Name = "etiquetacapacidad_trabajo"
       Me.etiquetacapacidad_trabajo.Size = New System.Drawing.Size(133, 21)
       Me.etiquetacapacidad_trabajo.TabIndex = 509
       Me.etiquetacapacidad_trabajo.Text = "Capacidad trabajo"
       Me.etiquetacapacidad_trabajo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
       '
       '
       'txtusuario_calendar
       '
       Me.txtusuario_calendar.BackColor = System.Drawing.Color.White
       Me.txtusuario_calendar.Location = New System.Drawing.Point(161, 434)
       Me.txtusuario_calendar.Size = New System.Drawing.Size(385, 20)
       Me.txtusuario_calendar.MaxLength = 500
       Me.txtusuario_calendar.Name = "txtusuario_calendar"
       Me.txtusuario_calendar.TabIndex = 12
       '
       'etiquietausuario_calendar
       '
       Me.etiquetausuario_calendar.BackColor = System.Drawing.Color.SteelBlue
       Me.etiquetausuario_calendar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetausuario_calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetausuario_calendar.ForeColor = System.Drawing.Color.White
       Me.etiquetausuario_calendar.Location = New System.Drawing.Point(22, 434)
       Me.etiquetausuario_calendar.Name = "etiquetausuario_calendar"
       Me.etiquetausuario_calendar.Size = New System.Drawing.Size(133, 21)
       Me.etiquetausuario_calendar.TabIndex = 510
       Me.etiquetausuario_calendar.Text = "Usuario calendar"
       Me.etiquetausuario_calendar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
       '
       '
       'txtpassword_calendar
       '
       Me.txtpassword_calendar.BackColor = System.Drawing.Color.White
       Me.txtpassword_calendar.Location = New System.Drawing.Point(161, 477)
       Me.txtpassword_calendar.Size = New System.Drawing.Size(385, 20)
       Me.txtpassword_calendar.MaxLength = 500
       Me.txtpassword_calendar.Name = "txtpassword_calendar"
       Me.txtpassword_calendar.TabIndex = 13
       '
       'etiquietapassword_calendar
       '
       Me.etiquetapassword_calendar.BackColor = System.Drawing.Color.SteelBlue
       Me.etiquetapassword_calendar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetapassword_calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetapassword_calendar.ForeColor = System.Drawing.Color.White
       Me.etiquetapassword_calendar.Location = New System.Drawing.Point(22, 477)
       Me.etiquetapassword_calendar.Name = "etiquetapassword_calendar"
       Me.etiquetapassword_calendar.Size = New System.Drawing.Size(133, 21)
       Me.etiquetapassword_calendar.TabIndex = 511
       Me.etiquetapassword_calendar.Text = "Password calendar"
       Me.etiquetapassword_calendar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
       '
       '
       'txtmail
       '
       Me.txtmail.BackColor = System.Drawing.Color.White
       Me.txtmail.Location = New System.Drawing.Point(161, 520)
       Me.txtmail.Size = New System.Drawing.Size(385, 20)
       Me.txtmail.MaxLength = 500
       Me.txtmail.Name = "txtmail"
       Me.txtmail.TabIndex = 14
       '
       'etiquietamail
       '
       Me.etiquetamail.BackColor = System.Drawing.Color.SteelBlue
       Me.etiquetamail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetamail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetamail.ForeColor = System.Drawing.Color.White
       Me.etiquetamail.Location = New System.Drawing.Point(22, 520)
       Me.etiquetamail.Name = "etiquetamail"
       Me.etiquetamail.Size = New System.Drawing.Size(133, 21)
       Me.etiquetamail.TabIndex = 512
       Me.etiquetamail.Text = "Mail"
       Me.etiquetamail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
       '
       '
       'btnSalir
       '
       Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
       Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.btnSalir.ForeColor = System.Drawing.Color.Black
       Me.btnSalir.Image = Global.Gestion_tarea.My.Resources.Resources.salir_c_1_35
       Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnSalir.Location = New System.Drawing.Point(499, 603)
       Me.btnSalir.Name = "btnSalir"
       Me.btnSalir.Size = New System.Drawing.Size(71, 58)
       Me.btnSalir.TabIndex = 51
       Me.btnSalir.Text = "&Salir"
       Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
       Me.btnSalir.UseVisualStyleBackColor = True
       '
       'btnGuardar
       '
       Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.btnGuardar.ForeColor = System.Drawing.Color.Black
       Me.btnGuardar.Image = Global.Gestion_tarea.My.Resources.Resources.guardar_3_1_35
       Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnGuardar.Location = New System.Drawing.Point(392,603)
       Me.btnGuardar.Name = "btnGuardar"
       Me.btnGuardar.Size = New System.Drawing.Size(71, 58)
       Me.btnGuardar.TabIndex = 50
       Me.btnGuardar.Text = "&Guardar"
       Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
       Me.btnGuardar.UseVisualStyleBackColor = True
       '
       '
       'frmDetalleUsuario
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(600, 683)
       Me.Controls.Add(Me.txtnombre_usuario)
       Me.Controls.Add(Me.etiquetanombre_usuario)
       Me.Controls.Add(Me.txtapellido_usuario)
       Me.Controls.Add(Me.etiquetaapellido_usuario)
       Me.Controls.Add(Me.txtidentificador)
       Me.Controls.Add(Me.etiquetaidentificador)
       Me.Controls.Add(Me.txtclave)
       Me.Controls.Add(Me.etiquetaclave)
       Me.Controls.Add(Me.lblid_tipo_usuario)
       Me.Controls.Add(Me.btnBuscatipo_usuario)
       Me.Controls.Add(Me.cmbtipo_usuario)
       Me.Controls.Add(Me.etiquetaid_tipo_usuario)
       Me.Controls.Add(Me.lblid_empresa)
       Me.Controls.Add(Me.btnBuscaempresa)
       Me.Controls.Add(Me.cmbempresa)
       Me.Controls.Add(Me.etiquetaid_empresa)
       Me.Controls.Add(Me.txtcosto)
       Me.Controls.Add(Me.etiquetacosto)
       Me.Controls.Add(Me.txtcapacidad_trabajo)
       Me.Controls.Add(Me.etiquetacapacidad_trabajo)
       Me.Controls.Add(Me.txtusuario_calendar)
       Me.Controls.Add(Me.etiquetausuario_calendar)
       Me.Controls.Add(Me.txtpassword_calendar)
       Me.Controls.Add(Me.etiquetapassword_calendar)
       Me.Controls.Add(Me.txtmail)
       Me.Controls.Add(Me.etiquetamail)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Name = "frmDetalleUsuario"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "Usuario"
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Protected WithEvents txtnombre_usuario As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_usuario As System.Windows.Forms.Label
   Protected WithEvents txtapellido_usuario As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaapellido_usuario As System.Windows.Forms.Label
   Protected WithEvents txtidentificador As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaidentificador As System.Windows.Forms.Label
   Protected WithEvents txtclave As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaclave As System.Windows.Forms.Label
   Friend WithEvents lblid_tipo_usuario As System.Windows.Forms.Label
   Friend WithEvents btnBuscatipo_usuario As System.Windows.Forms.Button
   Friend WithEvents cmbtipo_usuario As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_tipo_usuario As System.Windows.Forms.Label
   Friend WithEvents lblid_empresa As System.Windows.Forms.Label
   Friend WithEvents btnBuscaempresa As System.Windows.Forms.Button
   Friend WithEvents cmbempresa As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_empresa As System.Windows.Forms.Label
   Protected WithEvents txtcosto As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacosto As System.Windows.Forms.Label
   Protected WithEvents txtcapacidad_trabajo As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacapacidad_trabajo As System.Windows.Forms.Label
   Protected WithEvents txtusuario_calendar As System.Windows.Forms.TextBox
   Friend WithEvents etiquetausuario_calendar As System.Windows.Forms.Label
   Protected WithEvents txtpassword_calendar As System.Windows.Forms.TextBox
   Friend WithEvents etiquetapassword_calendar As System.Windows.Forms.Label
   Protected WithEvents txtmail As System.Windows.Forms.TextBox
   Friend WithEvents etiquetamail As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

