<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleMejora_accion
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
        Me.lblid_mejora = New System.Windows.Forms.Label()
        Me.btnBuscamejora = New System.Windows.Forms.Button()
        Me.cmbmejora = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_mejora = New System.Windows.Forms.Label()
        Me.dtpfecha_accion = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha_accion = New System.Windows.Forms.Label()
        Me.lblid_usuario_accion = New System.Windows.Forms.Label()
        Me.cmbusuario_accion = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_usuario_accion = New System.Windows.Forms.Label()
        Me.txtdescripccion_accion = New System.Windows.Forms.TextBox()
        Me.etiquetadescripccion_accion = New System.Windows.Forms.Label()
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
        Me.btnSalir.Location = New System.Drawing.Point(474, 191)
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
        Me.btnGuardar.Location = New System.Drawing.Point(367, 191)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 58)
        Me.btnGuardar.TabIndex = 50
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblid_mejora
        '
        Me.lblid_mejora.AutoSize = True
        Me.lblid_mejora.BackColor = System.Drawing.Color.Red
        Me.lblid_mejora.Location = New System.Drawing.Point(232, 35)
        Me.lblid_mejora.Name = "lblid_mejora"
        Me.lblid_mejora.Size = New System.Drawing.Size(13, 13)
        Me.lblid_mejora.TabIndex = 500
        Me.lblid_mejora.Text = "0"
        Me.lblid_mejora.Visible = False
        '
        'btnBuscamejora
        '
        Me.btnBuscamejora.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscamejora.Image = Global.Gestion_tarea.My.Resources.Resources.buscar_c_25
        Me.btnBuscamejora.Location = New System.Drawing.Point(536, 255)
        Me.btnBuscamejora.Name = "btnBuscamejora"
        Me.btnBuscamejora.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscamejora.TabIndex = 60
        Me.btnBuscamejora.UseVisualStyleBackColor = True
        Me.btnBuscamejora.Visible = False
        '
        'cmbmejora
        '
        Me.cmbmejora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbmejora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbmejora.FormattingEnabled = True
        Me.cmbmejora.Location = New System.Drawing.Point(181, 255)
        Me.cmbmejora.Name = "cmbmejora"
        Me.cmbmejora.Size = New System.Drawing.Size(349, 21)
        Me.cmbmejora.TabIndex = 4
        Me.cmbmejora.Visible = False
        '
        'etiquetaid_mejora
        '
        Me.etiquetaid_mejora.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetaid_mejora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_mejora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_mejora.ForeColor = System.Drawing.Color.White
        Me.etiquetaid_mejora.Location = New System.Drawing.Point(42, 255)
        Me.etiquetaid_mejora.Name = "etiquetaid_mejora"
        Me.etiquetaid_mejora.Size = New System.Drawing.Size(133, 21)
        Me.etiquetaid_mejora.TabIndex = 501
        Me.etiquetaid_mejora.Text = "Mejora"
        Me.etiquetaid_mejora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.etiquetaid_mejora.Visible = False
        '
        'dtpfecha_accion
        '
        Me.dtpfecha_accion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_accion.Location = New System.Drawing.Point(160, 72)
        Me.dtpfecha_accion.Name = "dtpfecha_accion"
        Me.dtpfecha_accion.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_accion.TabIndex = 5
        '
        'etiquetafecha_accion
        '
        Me.etiquetafecha_accion.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetafecha_accion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetafecha_accion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_accion.ForeColor = System.Drawing.Color.White
        Me.etiquetafecha_accion.Location = New System.Drawing.Point(21, 72)
        Me.etiquetafecha_accion.Name = "etiquetafecha_accion"
        Me.etiquetafecha_accion.Size = New System.Drawing.Size(133, 21)
        Me.etiquetafecha_accion.TabIndex = 502
        Me.etiquetafecha_accion.Text = "Fecha accion"
        Me.etiquetafecha_accion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblid_usuario_accion
        '
        Me.lblid_usuario_accion.AutoSize = True
        Me.lblid_usuario_accion.BackColor = System.Drawing.Color.Red
        Me.lblid_usuario_accion.Location = New System.Drawing.Point(369, 115)
        Me.lblid_usuario_accion.Name = "lblid_usuario_accion"
        Me.lblid_usuario_accion.Size = New System.Drawing.Size(13, 13)
        Me.lblid_usuario_accion.TabIndex = 503
        Me.lblid_usuario_accion.Text = "0"
        Me.lblid_usuario_accion.Visible = False
        '
        'cmbusuario_accion
        '
        Me.cmbusuario_accion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbusuario_accion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbusuario_accion.FormattingEnabled = True
        Me.cmbusuario_accion.Location = New System.Drawing.Point(160, 115)
        Me.cmbusuario_accion.Name = "cmbusuario_accion"
        Me.cmbusuario_accion.Size = New System.Drawing.Size(349, 21)
        Me.cmbusuario_accion.TabIndex = 6
        '
        'etiquetaid_usuario_accion
        '
        Me.etiquetaid_usuario_accion.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetaid_usuario_accion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_usuario_accion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_usuario_accion.ForeColor = System.Drawing.Color.White
        Me.etiquetaid_usuario_accion.Location = New System.Drawing.Point(21, 115)
        Me.etiquetaid_usuario_accion.Name = "etiquetaid_usuario_accion"
        Me.etiquetaid_usuario_accion.Size = New System.Drawing.Size(133, 21)
        Me.etiquetaid_usuario_accion.TabIndex = 504
        Me.etiquetaid_usuario_accion.Text = "Usuario accion"
        Me.etiquetaid_usuario_accion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtdescripccion_accion
        '
        Me.txtdescripccion_accion.BackColor = System.Drawing.Color.White
        Me.txtdescripccion_accion.Location = New System.Drawing.Point(160, 158)
        Me.txtdescripccion_accion.MaxLength = 5000
        Me.txtdescripccion_accion.Name = "txtdescripccion_accion"
        Me.txtdescripccion_accion.Size = New System.Drawing.Size(385, 20)
        Me.txtdescripccion_accion.TabIndex = 7
        '
        'etiquetadescripccion_accion
        '
        Me.etiquetadescripccion_accion.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetadescripccion_accion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetadescripccion_accion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetadescripccion_accion.ForeColor = System.Drawing.Color.White
        Me.etiquetadescripccion_accion.Location = New System.Drawing.Point(21, 158)
        Me.etiquetadescripccion_accion.Name = "etiquetadescripccion_accion"
        Me.etiquetadescripccion_accion.Size = New System.Drawing.Size(133, 21)
        Me.etiquetadescripccion_accion.TabIndex = 505
        Me.etiquetadescripccion_accion.Text = "Descripccion accion"
        Me.etiquetadescripccion_accion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDetalleMejora_accion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 266)
        Me.Controls.Add(Me.lblid_mejora)
        Me.Controls.Add(Me.btnBuscamejora)
        Me.Controls.Add(Me.cmbmejora)
        Me.Controls.Add(Me.etiquetaid_mejora)
        Me.Controls.Add(Me.dtpfecha_accion)
        Me.Controls.Add(Me.etiquetafecha_accion)
        Me.Controls.Add(Me.lblid_usuario_accion)
        Me.Controls.Add(Me.cmbusuario_accion)
        Me.Controls.Add(Me.etiquetaid_usuario_accion)
        Me.Controls.Add(Me.txtdescripccion_accion)
        Me.Controls.Add(Me.etiquetadescripccion_accion)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "frmDetalleMejora_accion"
        Me.Text = "Mejora_accion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents lblid_mejora As System.Windows.Forms.Label
   Friend WithEvents btnBuscamejora As System.Windows.Forms.Button
   Friend WithEvents cmbmejora As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_mejora As System.Windows.Forms.Label
   Protected WithEvents dtpfecha_accion As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha_accion As System.Windows.Forms.Label
   Friend WithEvents lblid_usuario_accion As System.Windows.Forms.Label
    Friend WithEvents cmbusuario_accion As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_usuario_accion As System.Windows.Forms.Label
   Protected WithEvents txtdescripccion_accion As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadescripccion_accion As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

