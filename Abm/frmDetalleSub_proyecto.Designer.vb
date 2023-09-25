<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleSub_proyecto
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
        Me.txtnombre_sub_proyecto = New System.Windows.Forms.TextBox()
        Me.etiquetanombre_sub_proyecto = New System.Windows.Forms.Label()
        Me.txtcodigo_sub_proyecto = New System.Windows.Forms.TextBox()
        Me.etiquetacodigo_sub_proyecto = New System.Windows.Forms.Label()
        Me.txthora_prevista = New System.Windows.Forms.TextBox()
        Me.etiquetahora_prevista = New System.Windows.Forms.Label()
        Me.txthora_real = New System.Windows.Forms.TextBox()
        Me.etiquetahora_real = New System.Windows.Forms.Label()
        Me.dtpfecha_prevista = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha_prevista = New System.Windows.Forms.Label()
        Me.dtpfecha_real = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha_real = New System.Windows.Forms.Label()
        Me.lblid_proyecto = New System.Windows.Forms.Label()
        Me.btnBuscaproyecto = New System.Windows.Forms.Button()
        Me.cmbproyecto = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_proyecto = New System.Windows.Forms.Label()
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
        Me.btnSalir.Location = New System.Drawing.Point(499, 431)
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
        Me.btnGuardar.Location = New System.Drawing.Point(392, 431)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 58)
        Me.btnGuardar.TabIndex = 50
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtnombre_sub_proyecto
        '
        Me.txtnombre_sub_proyecto.BackColor = System.Drawing.Color.White
        Me.txtnombre_sub_proyecto.Location = New System.Drawing.Point(161, 70)
        Me.txtnombre_sub_proyecto.MaxLength = 50
        Me.txtnombre_sub_proyecto.Name = "txtnombre_sub_proyecto"
        Me.txtnombre_sub_proyecto.Size = New System.Drawing.Size(385, 20)
        Me.txtnombre_sub_proyecto.TabIndex = 4
        '
        'etiquetanombre_sub_proyecto
        '
        Me.etiquetanombre_sub_proyecto.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetanombre_sub_proyecto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanombre_sub_proyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_sub_proyecto.ForeColor = System.Drawing.Color.White
        Me.etiquetanombre_sub_proyecto.Location = New System.Drawing.Point(22, 70)
        Me.etiquetanombre_sub_proyecto.Name = "etiquetanombre_sub_proyecto"
        Me.etiquetanombre_sub_proyecto.Size = New System.Drawing.Size(133, 21)
        Me.etiquetanombre_sub_proyecto.TabIndex = 500
        Me.etiquetanombre_sub_proyecto.Text = "Nombre sub proyecto"
        Me.etiquetanombre_sub_proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtcodigo_sub_proyecto
        '
        Me.txtcodigo_sub_proyecto.BackColor = System.Drawing.Color.White
        Me.txtcodigo_sub_proyecto.Location = New System.Drawing.Point(161, 113)
        Me.txtcodigo_sub_proyecto.MaxLength = 50
        Me.txtcodigo_sub_proyecto.Name = "txtcodigo_sub_proyecto"
        Me.txtcodigo_sub_proyecto.Size = New System.Drawing.Size(385, 20)
        Me.txtcodigo_sub_proyecto.TabIndex = 5
        '
        'etiquetacodigo_sub_proyecto
        '
        Me.etiquetacodigo_sub_proyecto.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetacodigo_sub_proyecto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacodigo_sub_proyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacodigo_sub_proyecto.ForeColor = System.Drawing.Color.White
        Me.etiquetacodigo_sub_proyecto.Location = New System.Drawing.Point(22, 113)
        Me.etiquetacodigo_sub_proyecto.Name = "etiquetacodigo_sub_proyecto"
        Me.etiquetacodigo_sub_proyecto.Size = New System.Drawing.Size(133, 21)
        Me.etiquetacodigo_sub_proyecto.TabIndex = 501
        Me.etiquetacodigo_sub_proyecto.Text = "C�digo sub proyecto"
        Me.etiquetacodigo_sub_proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txthora_prevista
        '
        Me.txthora_prevista.BackColor = System.Drawing.Color.White
        Me.txthora_prevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthora_prevista.ForeColor = System.Drawing.Color.Blue
        Me.txthora_prevista.Location = New System.Drawing.Point(161, 156)
        Me.txthora_prevista.MaxLength = 50
        Me.txthora_prevista.Name = "txthora_prevista"
        Me.txthora_prevista.Size = New System.Drawing.Size(222, 31)
        Me.txthora_prevista.TabIndex = 6
        Me.txthora_prevista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetahora_prevista
        '
        Me.etiquetahora_prevista.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetahora_prevista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetahora_prevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetahora_prevista.ForeColor = System.Drawing.Color.White
        Me.etiquetahora_prevista.Location = New System.Drawing.Point(22, 156)
        Me.etiquetahora_prevista.Name = "etiquetahora_prevista"
        Me.etiquetahora_prevista.Size = New System.Drawing.Size(133, 21)
        Me.etiquetahora_prevista.TabIndex = 502
        Me.etiquetahora_prevista.Text = "Hora prevista"
        Me.etiquetahora_prevista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txthora_real
        '
        Me.txthora_real.BackColor = System.Drawing.Color.White
        Me.txthora_real.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthora_real.ForeColor = System.Drawing.Color.Blue
        Me.txthora_real.Location = New System.Drawing.Point(161, 209)
        Me.txthora_real.MaxLength = 50
        Me.txthora_real.Name = "txthora_real"
        Me.txthora_real.Size = New System.Drawing.Size(222, 31)
        Me.txthora_real.TabIndex = 7
        Me.txthora_real.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetahora_real
        '
        Me.etiquetahora_real.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetahora_real.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetahora_real.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetahora_real.ForeColor = System.Drawing.Color.White
        Me.etiquetahora_real.Location = New System.Drawing.Point(22, 209)
        Me.etiquetahora_real.Name = "etiquetahora_real"
        Me.etiquetahora_real.Size = New System.Drawing.Size(133, 21)
        Me.etiquetahora_real.TabIndex = 503
        Me.etiquetahora_real.Text = "Hora real"
        Me.etiquetahora_real.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpfecha_prevista
        '
        Me.dtpfecha_prevista.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_prevista.Location = New System.Drawing.Point(161, 262)
        Me.dtpfecha_prevista.Name = "dtpfecha_prevista"
        Me.dtpfecha_prevista.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_prevista.TabIndex = 8
        '
        'etiquetafecha_prevista
        '
        Me.etiquetafecha_prevista.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetafecha_prevista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetafecha_prevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_prevista.ForeColor = System.Drawing.Color.White
        Me.etiquetafecha_prevista.Location = New System.Drawing.Point(22, 262)
        Me.etiquetafecha_prevista.Name = "etiquetafecha_prevista"
        Me.etiquetafecha_prevista.Size = New System.Drawing.Size(133, 21)
        Me.etiquetafecha_prevista.TabIndex = 504
        Me.etiquetafecha_prevista.Text = "Fecha prevista"
        Me.etiquetafecha_prevista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpfecha_real
        '
        Me.dtpfecha_real.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_real.Location = New System.Drawing.Point(161, 305)
        Me.dtpfecha_real.Name = "dtpfecha_real"
        Me.dtpfecha_real.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_real.TabIndex = 9
        '
        'etiquetafecha_real
        '
        Me.etiquetafecha_real.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetafecha_real.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetafecha_real.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_real.ForeColor = System.Drawing.Color.White
        Me.etiquetafecha_real.Location = New System.Drawing.Point(22, 305)
        Me.etiquetafecha_real.Name = "etiquetafecha_real"
        Me.etiquetafecha_real.Size = New System.Drawing.Size(133, 21)
        Me.etiquetafecha_real.TabIndex = 505
        Me.etiquetafecha_real.Text = "Fecha real"
        Me.etiquetafecha_real.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblid_proyecto
        '
        Me.lblid_proyecto.AutoSize = True
        Me.lblid_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_proyecto.Location = New System.Drawing.Point(370, 348)
        Me.lblid_proyecto.Name = "lblid_proyecto"
        Me.lblid_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proyecto.TabIndex = 506
        Me.lblid_proyecto.Text = "0"
        Me.lblid_proyecto.Visible = False
        '
        'btnBuscaproyecto
        '
        Me.btnBuscaproyecto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaproyecto.Image = Global.Gestion_tarea.My.Resources.Resources.buscar_c_25
        Me.btnBuscaproyecto.Location = New System.Drawing.Point(516, 348)
        Me.btnBuscaproyecto.Name = "btnBuscaproyecto"
        Me.btnBuscaproyecto.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaproyecto.TabIndex = 60
        Me.btnBuscaproyecto.UseVisualStyleBackColor = True
        '
        'cmbproyecto
        '
        Me.cmbproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbproyecto.FormattingEnabled = True
        Me.cmbproyecto.Location = New System.Drawing.Point(161, 348)
        Me.cmbproyecto.Name = "cmbproyecto"
        Me.cmbproyecto.Size = New System.Drawing.Size(349, 21)
        Me.cmbproyecto.TabIndex = 10
        '
        'etiquetaid_proyecto
        '
        Me.etiquetaid_proyecto.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetaid_proyecto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_proyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_proyecto.ForeColor = System.Drawing.Color.White
        Me.etiquetaid_proyecto.Location = New System.Drawing.Point(22, 348)
        Me.etiquetaid_proyecto.Name = "etiquetaid_proyecto"
        Me.etiquetaid_proyecto.Size = New System.Drawing.Size(133, 21)
        Me.etiquetaid_proyecto.TabIndex = 507
        Me.etiquetaid_proyecto.Text = "Proyecto"
        Me.etiquetaid_proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDetalleSub_proyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 511)
        Me.Controls.Add(Me.txtnombre_sub_proyecto)
        Me.Controls.Add(Me.etiquetanombre_sub_proyecto)
        Me.Controls.Add(Me.txtcodigo_sub_proyecto)
        Me.Controls.Add(Me.etiquetacodigo_sub_proyecto)
        Me.Controls.Add(Me.txthora_prevista)
        Me.Controls.Add(Me.etiquetahora_prevista)
        Me.Controls.Add(Me.txthora_real)
        Me.Controls.Add(Me.etiquetahora_real)
        Me.Controls.Add(Me.dtpfecha_prevista)
        Me.Controls.Add(Me.etiquetafecha_prevista)
        Me.Controls.Add(Me.dtpfecha_real)
        Me.Controls.Add(Me.etiquetafecha_real)
        Me.Controls.Add(Me.lblid_proyecto)
        Me.Controls.Add(Me.btnBuscaproyecto)
        Me.Controls.Add(Me.cmbproyecto)
        Me.Controls.Add(Me.etiquetaid_proyecto)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "frmDetalleSub_proyecto"
        Me.Text = "Sub_proyecto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Protected WithEvents txtnombre_sub_proyecto As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_sub_proyecto As System.Windows.Forms.Label
   Protected WithEvents txtcodigo_sub_proyecto As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacodigo_sub_proyecto As System.Windows.Forms.Label
   Protected WithEvents txthora_prevista As System.Windows.Forms.TextBox
   Friend WithEvents etiquetahora_prevista As System.Windows.Forms.Label
   Protected WithEvents txthora_real As System.Windows.Forms.TextBox
   Friend WithEvents etiquetahora_real As System.Windows.Forms.Label
   Protected WithEvents dtpfecha_prevista As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha_prevista As System.Windows.Forms.Label
   Protected WithEvents dtpfecha_real As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha_real As System.Windows.Forms.Label
   Friend WithEvents lblid_proyecto As System.Windows.Forms.Label
   Friend WithEvents btnBuscaproyecto As System.Windows.Forms.Button
   Friend WithEvents cmbproyecto As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_proyecto As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

