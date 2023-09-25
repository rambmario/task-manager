<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleEmpresa
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
        Me.components = New System.ComponentModel.Container()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtnombre_empresa = New System.Windows.Forms.TextBox()
        Me.etiquetanombre_empresa = New System.Windows.Forms.Label()
        Me.txtcodigo_empresa = New System.Windows.Forms.TextBox()
        Me.etiquetacodigo_empresa = New System.Windows.Forms.Label()
        Me.lblid_tipo_empresa = New System.Windows.Forms.Label()
        Me.btnBuscatipo_empresa = New System.Windows.Forms.Button()
        Me.cmbtipo_empresa = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_tipo_empresa = New System.Windows.Forms.Label()
        Me.txtmail_empresa = New System.Windows.Forms.TextBox()
        Me.etiquetamail_empresa = New System.Windows.Forms.Label()
        Me.txtpassword_mail = New System.Windows.Forms.TextBox()
        Me.etiquetapassword_mail = New System.Windows.Forms.Label()
        Me.txtlogo = New System.Windows.Forms.TextBox()
        Me.etiquetalogo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = Global.Gestion_tarea.My.Resources.Resources.salir_c_1_35
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(499, 368)
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
        Me.btnGuardar.Location = New System.Drawing.Point(392, 368)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 58)
        Me.btnGuardar.TabIndex = 50
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtnombre_empresa
        '
        Me.txtnombre_empresa.BackColor = System.Drawing.Color.White
        Me.txtnombre_empresa.Location = New System.Drawing.Point(161, 70)
        Me.txtnombre_empresa.MaxLength = 50
        Me.txtnombre_empresa.Name = "txtnombre_empresa"
        Me.txtnombre_empresa.Size = New System.Drawing.Size(385, 20)
        Me.txtnombre_empresa.TabIndex = 4
        '
        'etiquetanombre_empresa
        '
        Me.etiquetanombre_empresa.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetanombre_empresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanombre_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_empresa.ForeColor = System.Drawing.Color.White
        Me.etiquetanombre_empresa.Location = New System.Drawing.Point(22, 70)
        Me.etiquetanombre_empresa.Name = "etiquetanombre_empresa"
        Me.etiquetanombre_empresa.Size = New System.Drawing.Size(133, 21)
        Me.etiquetanombre_empresa.TabIndex = 500
        Me.etiquetanombre_empresa.Text = "Nombre empresa"
        Me.etiquetanombre_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtcodigo_empresa
        '
        Me.txtcodigo_empresa.BackColor = System.Drawing.Color.White
        Me.txtcodigo_empresa.Location = New System.Drawing.Point(161, 113)
        Me.txtcodigo_empresa.MaxLength = 50
        Me.txtcodigo_empresa.Name = "txtcodigo_empresa"
        Me.txtcodigo_empresa.Size = New System.Drawing.Size(385, 20)
        Me.txtcodigo_empresa.TabIndex = 5
        '
        'etiquetacodigo_empresa
        '
        Me.etiquetacodigo_empresa.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetacodigo_empresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacodigo_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacodigo_empresa.ForeColor = System.Drawing.Color.White
        Me.etiquetacodigo_empresa.Location = New System.Drawing.Point(22, 113)
        Me.etiquetacodigo_empresa.Name = "etiquetacodigo_empresa"
        Me.etiquetacodigo_empresa.Size = New System.Drawing.Size(133, 21)
        Me.etiquetacodigo_empresa.TabIndex = 501
        Me.etiquetacodigo_empresa.Text = "C�digo empresa"
        Me.etiquetacodigo_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblid_tipo_empresa
        '
        Me.lblid_tipo_empresa.AutoSize = True
        Me.lblid_tipo_empresa.BackColor = System.Drawing.Color.Red
        Me.lblid_tipo_empresa.Location = New System.Drawing.Point(370, 156)
        Me.lblid_tipo_empresa.Name = "lblid_tipo_empresa"
        Me.lblid_tipo_empresa.Size = New System.Drawing.Size(13, 13)
        Me.lblid_tipo_empresa.TabIndex = 502
        Me.lblid_tipo_empresa.Text = "0"
        Me.lblid_tipo_empresa.Visible = False
        '
        'btnBuscatipo_empresa
        '
        Me.btnBuscatipo_empresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscatipo_empresa.Image = Global.Gestion_tarea.My.Resources.Resources.buscar_c_25
        Me.btnBuscatipo_empresa.Location = New System.Drawing.Point(516, 156)
        Me.btnBuscatipo_empresa.Name = "btnBuscatipo_empresa"
        Me.btnBuscatipo_empresa.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscatipo_empresa.TabIndex = 60
        Me.btnBuscatipo_empresa.UseVisualStyleBackColor = True
        '
        'cmbtipo_empresa
        '
        Me.cmbtipo_empresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbtipo_empresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtipo_empresa.FormattingEnabled = True
        Me.cmbtipo_empresa.Location = New System.Drawing.Point(161, 156)
        Me.cmbtipo_empresa.Name = "cmbtipo_empresa"
        Me.cmbtipo_empresa.Size = New System.Drawing.Size(349, 21)
        Me.cmbtipo_empresa.TabIndex = 6
        '
        'etiquetaid_tipo_empresa
        '
        Me.etiquetaid_tipo_empresa.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetaid_tipo_empresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_tipo_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_tipo_empresa.ForeColor = System.Drawing.Color.White
        Me.etiquetaid_tipo_empresa.Location = New System.Drawing.Point(22, 156)
        Me.etiquetaid_tipo_empresa.Name = "etiquetaid_tipo_empresa"
        Me.etiquetaid_tipo_empresa.Size = New System.Drawing.Size(133, 21)
        Me.etiquetaid_tipo_empresa.TabIndex = 503
        Me.etiquetaid_tipo_empresa.Text = "Tipo empresa"
        Me.etiquetaid_tipo_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtmail_empresa
        '
        Me.txtmail_empresa.BackColor = System.Drawing.Color.White
        Me.txtmail_empresa.Location = New System.Drawing.Point(161, 199)
        Me.txtmail_empresa.MaxLength = 50
        Me.txtmail_empresa.Name = "txtmail_empresa"
        Me.txtmail_empresa.Size = New System.Drawing.Size(385, 20)
        Me.txtmail_empresa.TabIndex = 7
        '
        'etiquetamail_empresa
        '
        Me.etiquetamail_empresa.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetamail_empresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetamail_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetamail_empresa.ForeColor = System.Drawing.Color.White
        Me.etiquetamail_empresa.Location = New System.Drawing.Point(22, 199)
        Me.etiquetamail_empresa.Name = "etiquetamail_empresa"
        Me.etiquetamail_empresa.Size = New System.Drawing.Size(133, 21)
        Me.etiquetamail_empresa.TabIndex = 504
        Me.etiquetamail_empresa.Text = "Mail empresa"
        Me.etiquetamail_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtpassword_mail
        '
        Me.txtpassword_mail.BackColor = System.Drawing.Color.White
        Me.txtpassword_mail.Location = New System.Drawing.Point(161, 242)
        Me.txtpassword_mail.MaxLength = 50
        Me.txtpassword_mail.Name = "txtpassword_mail"
        Me.txtpassword_mail.Size = New System.Drawing.Size(385, 20)
        Me.txtpassword_mail.TabIndex = 8
        '
        'etiquetapassword_mail
        '
        Me.etiquetapassword_mail.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetapassword_mail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetapassword_mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetapassword_mail.ForeColor = System.Drawing.Color.White
        Me.etiquetapassword_mail.Location = New System.Drawing.Point(22, 242)
        Me.etiquetapassword_mail.Name = "etiquetapassword_mail"
        Me.etiquetapassword_mail.Size = New System.Drawing.Size(133, 21)
        Me.etiquetapassword_mail.TabIndex = 505
        Me.etiquetapassword_mail.Text = "Password mail"
        Me.etiquetapassword_mail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtlogo
        '
        Me.txtlogo.BackColor = System.Drawing.Color.White
        Me.txtlogo.Location = New System.Drawing.Point(161, 285)
        Me.txtlogo.MaxLength = 5000
        Me.txtlogo.Name = "txtlogo"
        Me.txtlogo.Size = New System.Drawing.Size(385, 20)
        Me.txtlogo.TabIndex = 9
        '
        'etiquetalogo
        '
        Me.etiquetalogo.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetalogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetalogo.ForeColor = System.Drawing.Color.White
        Me.etiquetalogo.Location = New System.Drawing.Point(22, 285)
        Me.etiquetalogo.Name = "etiquetalogo"
        Me.etiquetalogo.Size = New System.Drawing.Size(133, 21)
        Me.etiquetalogo.TabIndex = 506
        Me.etiquetalogo.Text = "Logo"
        Me.etiquetalogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDetalleEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 448)
        Me.Controls.Add(Me.txtnombre_empresa)
        Me.Controls.Add(Me.etiquetanombre_empresa)
        Me.Controls.Add(Me.txtcodigo_empresa)
        Me.Controls.Add(Me.etiquetacodigo_empresa)
        Me.Controls.Add(Me.lblid_tipo_empresa)
        Me.Controls.Add(Me.btnBuscatipo_empresa)
        Me.Controls.Add(Me.cmbtipo_empresa)
        Me.Controls.Add(Me.etiquetaid_tipo_empresa)
        Me.Controls.Add(Me.txtmail_empresa)
        Me.Controls.Add(Me.etiquetamail_empresa)
        Me.Controls.Add(Me.txtpassword_mail)
        Me.Controls.Add(Me.etiquetapassword_mail)
        Me.Controls.Add(Me.txtlogo)
        Me.Controls.Add(Me.etiquetalogo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "frmDetalleEmpresa"
        Me.Text = "Empresa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Protected WithEvents txtnombre_empresa As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_empresa As System.Windows.Forms.Label
   Protected WithEvents txtcodigo_empresa As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacodigo_empresa As System.Windows.Forms.Label
   Friend WithEvents lblid_tipo_empresa As System.Windows.Forms.Label
   Friend WithEvents btnBuscatipo_empresa As System.Windows.Forms.Button
   Friend WithEvents cmbtipo_empresa As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_tipo_empresa As System.Windows.Forms.Label
   Protected WithEvents txtmail_empresa As System.Windows.Forms.TextBox
   Friend WithEvents etiquetamail_empresa As System.Windows.Forms.Label
   Protected WithEvents txtpassword_mail As System.Windows.Forms.TextBox
   Friend WithEvents etiquetapassword_mail As System.Windows.Forms.Label
   Protected WithEvents txtlogo As System.Windows.Forms.TextBox
   Friend WithEvents etiquetalogo As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

