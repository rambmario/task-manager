<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleTareaExpress
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleTareaExpress))
        Me.lblid_proyecto = New System.Windows.Forms.Label()
        Me.lblid_empresa = New System.Windows.Forms.Label()
        Me.lblid_sub_proyecto = New System.Windows.Forms.Label()
        Me.dtpFecha_pedido = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.etiquetanombre_tarea = New System.Windows.Forms.Label()
        Me.txtnombre_tarea = New System.Windows.Forms.TextBox()
        Me.lblid_usuario_asignado = New System.Windows.Forms.Label()
        Me.txthora_prevista = New System.Windows.Forms.TextBox()
        Me.etiquetahora_prevista = New System.Windows.Forms.Label()
        Me.lblid_tarea = New System.Windows.Forms.Label()
        Me.chkEs_feriado = New System.Windows.Forms.CheckBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProyecto = New System.Windows.Forms.Button()
        Me.txtUnidad = New System.Windows.Forms.Button()
        Me.txtAsignado = New System.Windows.Forms.Button()
        Me.txtSubproyecto = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbtipo_tarea = New System.Windows.Forms.ComboBox()
        Me.lblid_tipo_tarea = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblid_proyecto
        '
        Me.lblid_proyecto.AutoSize = True
        Me.lblid_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_proyecto.Location = New System.Drawing.Point(12, 37)
        Me.lblid_proyecto.Name = "lblid_proyecto"
        Me.lblid_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proyecto.TabIndex = 610
        Me.lblid_proyecto.Text = "0"
        Me.lblid_proyecto.Visible = False
        '
        'lblid_empresa
        '
        Me.lblid_empresa.AutoSize = True
        Me.lblid_empresa.BackColor = System.Drawing.Color.Red
        Me.lblid_empresa.Location = New System.Drawing.Point(12, 9)
        Me.lblid_empresa.Name = "lblid_empresa"
        Me.lblid_empresa.Size = New System.Drawing.Size(13, 13)
        Me.lblid_empresa.TabIndex = 611
        Me.lblid_empresa.Text = "0"
        Me.lblid_empresa.Visible = False
        '
        'lblid_sub_proyecto
        '
        Me.lblid_sub_proyecto.AutoSize = True
        Me.lblid_sub_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_sub_proyecto.Location = New System.Drawing.Point(12, 64)
        Me.lblid_sub_proyecto.Name = "lblid_sub_proyecto"
        Me.lblid_sub_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_sub_proyecto.TabIndex = 612
        Me.lblid_sub_proyecto.Text = "0"
        Me.lblid_sub_proyecto.Visible = False
        '
        'dtpFecha_pedido
        '
        Me.dtpFecha_pedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_pedido.Location = New System.Drawing.Point(121, 135)
        Me.dtpFecha_pedido.Name = "dtpFecha_pedido"
        Me.dtpFecha_pedido.Size = New System.Drawing.Size(93, 20)
        Me.dtpFecha_pedido.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(75, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 15)
        Me.Label9.TabIndex = 653
        Me.Label9.Text = "Fecha"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'etiquetanombre_tarea
        '
        Me.etiquetanombre_tarea.AutoSize = True
        Me.etiquetanombre_tarea.BackColor = System.Drawing.Color.Transparent
        Me.etiquetanombre_tarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_tarea.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_tarea.Location = New System.Drawing.Point(43, 161)
        Me.etiquetanombre_tarea.Name = "etiquetanombre_tarea"
        Me.etiquetanombre_tarea.Size = New System.Drawing.Size(72, 15)
        Me.etiquetanombre_tarea.TabIndex = 652
        Me.etiquetanombre_tarea.Text = "Descripción"
        Me.etiquetanombre_tarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnombre_tarea
        '
        Me.txtnombre_tarea.BackColor = System.Drawing.Color.White
        Me.txtnombre_tarea.Location = New System.Drawing.Point(121, 161)
        Me.txtnombre_tarea.MaxLength = 5000
        Me.txtnombre_tarea.Multiline = True
        Me.txtnombre_tarea.Name = "txtnombre_tarea"
        Me.txtnombre_tarea.Size = New System.Drawing.Size(542, 58)
        Me.txtnombre_tarea.TabIndex = 4
        '
        'lblid_usuario_asignado
        '
        Me.lblid_usuario_asignado.AutoSize = True
        Me.lblid_usuario_asignado.BackColor = System.Drawing.Color.Red
        Me.lblid_usuario_asignado.Location = New System.Drawing.Point(12, 89)
        Me.lblid_usuario_asignado.Name = "lblid_usuario_asignado"
        Me.lblid_usuario_asignado.Size = New System.Drawing.Size(13, 13)
        Me.lblid_usuario_asignado.TabIndex = 654
        Me.lblid_usuario_asignado.Text = "0"
        Me.lblid_usuario_asignado.Visible = False
        '
        'txthora_prevista
        '
        Me.txthora_prevista.BackColor = System.Drawing.Color.White
        Me.txthora_prevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthora_prevista.ForeColor = System.Drawing.Color.Blue
        Me.txthora_prevista.Location = New System.Drawing.Point(121, 252)
        Me.txthora_prevista.MaxLength = 50
        Me.txthora_prevista.Name = "txthora_prevista"
        Me.txthora_prevista.Size = New System.Drawing.Size(113, 26)
        Me.txthora_prevista.TabIndex = 6
        Me.txthora_prevista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetahora_prevista
        '
        Me.etiquetahora_prevista.AutoSize = True
        Me.etiquetahora_prevista.BackColor = System.Drawing.Color.Transparent
        Me.etiquetahora_prevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetahora_prevista.ForeColor = System.Drawing.Color.Black
        Me.etiquetahora_prevista.Location = New System.Drawing.Point(75, 252)
        Me.etiquetahora_prevista.Name = "etiquetahora_prevista"
        Me.etiquetahora_prevista.Size = New System.Drawing.Size(40, 15)
        Me.etiquetahora_prevista.TabIndex = 658
        Me.etiquetahora_prevista.Text = "Horas"
        Me.etiquetahora_prevista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_tarea
        '
        Me.lblid_tarea.AutoSize = True
        Me.lblid_tarea.BackColor = System.Drawing.Color.Red
        Me.lblid_tarea.Location = New System.Drawing.Point(12, 116)
        Me.lblid_tarea.Name = "lblid_tarea"
        Me.lblid_tarea.Size = New System.Drawing.Size(13, 13)
        Me.lblid_tarea.TabIndex = 659
        Me.lblid_tarea.Text = "0"
        Me.lblid_tarea.Visible = False
        '
        'chkEs_feriado
        '
        Me.chkEs_feriado.AutoSize = True
        Me.chkEs_feriado.Enabled = False
        Me.chkEs_feriado.Location = New System.Drawing.Point(121, 303)
        Me.chkEs_feriado.Name = "chkEs_feriado"
        Me.chkEs_feriado.Size = New System.Drawing.Size(15, 14)
        Me.chkEs_feriado.TabIndex = 661
        Me.chkEs_feriado.UseVisualStyleBackColor = True
        Me.chkEs_feriado.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(257, 276)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 58)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(344, 276)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(71, 58)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 662
        Me.Label1.Text = "Unidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 663
        Me.Label2.Text = "Proyecto/Cuenta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 664
        Me.Label3.Text = "Sub Proyecto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 665
        Me.Label4.Text = "Asignado"
        '
        'txtProyecto
        '
        Me.txtProyecto.BackColor = System.Drawing.Color.SteelBlue
        Me.txtProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtProyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProyecto.ForeColor = System.Drawing.Color.White
        Me.txtProyecto.Location = New System.Drawing.Point(121, 40)
        Me.txtProyecto.Name = "txtProyecto"
        Me.txtProyecto.Size = New System.Drawing.Size(411, 23)
        Me.txtProyecto.TabIndex = 666
        Me.txtProyecto.Text = "0"
        Me.txtProyecto.UseVisualStyleBackColor = False
        '
        'txtUnidad
        '
        Me.txtUnidad.BackColor = System.Drawing.Color.SteelBlue
        Me.txtUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidad.ForeColor = System.Drawing.Color.White
        Me.txtUnidad.Location = New System.Drawing.Point(121, 12)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(411, 23)
        Me.txtUnidad.TabIndex = 667
        Me.txtUnidad.Text = "0"
        Me.txtUnidad.UseVisualStyleBackColor = False
        '
        'txtAsignado
        '
        Me.txtAsignado.BackColor = System.Drawing.Color.SteelBlue
        Me.txtAsignado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtAsignado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsignado.ForeColor = System.Drawing.Color.White
        Me.txtAsignado.Location = New System.Drawing.Point(121, 96)
        Me.txtAsignado.Name = "txtAsignado"
        Me.txtAsignado.Size = New System.Drawing.Size(411, 23)
        Me.txtAsignado.TabIndex = 668
        Me.txtAsignado.Text = "0"
        Me.txtAsignado.UseVisualStyleBackColor = False
        '
        'txtSubproyecto
        '
        Me.txtSubproyecto.BackColor = System.Drawing.Color.SteelBlue
        Me.txtSubproyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtSubproyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubproyecto.ForeColor = System.Drawing.Color.White
        Me.txtSubproyecto.Location = New System.Drawing.Point(121, 68)
        Me.txtSubproyecto.Name = "txtSubproyecto"
        Me.txtSubproyecto.Size = New System.Drawing.Size(411, 23)
        Me.txtSubproyecto.TabIndex = 669
        Me.txtSubproyecto.Text = "0"
        Me.txtSubproyecto.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(84, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 671
        Me.Label5.Text = "Tipo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbtipo_tarea
        '
        Me.cmbtipo_tarea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbtipo_tarea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtipo_tarea.FormattingEnabled = True
        Me.cmbtipo_tarea.Location = New System.Drawing.Point(121, 225)
        Me.cmbtipo_tarea.Name = "cmbtipo_tarea"
        Me.cmbtipo_tarea.Size = New System.Drawing.Size(294, 21)
        Me.cmbtipo_tarea.TabIndex = 5
        '
        'lblid_tipo_tarea
        '
        Me.lblid_tipo_tarea.AutoSize = True
        Me.lblid_tipo_tarea.BackColor = System.Drawing.Color.Red
        Me.lblid_tipo_tarea.Location = New System.Drawing.Point(136, 228)
        Me.lblid_tipo_tarea.Name = "lblid_tipo_tarea"
        Me.lblid_tipo_tarea.Size = New System.Drawing.Size(13, 13)
        Me.lblid_tipo_tarea.TabIndex = 672
        Me.lblid_tipo_tarea.Text = "0"
        Me.lblid_tipo_tarea.Visible = False
        '
        'frmDetalleTareaExpress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(675, 346)
        Me.Controls.Add(Me.lblid_tipo_tarea)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbtipo_tarea)
        Me.Controls.Add(Me.txtSubproyecto)
        Me.Controls.Add(Me.txtAsignado)
        Me.Controls.Add(Me.txtUnidad)
        Me.Controls.Add(Me.txtProyecto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkEs_feriado)
        Me.Controls.Add(Me.lblid_tarea)
        Me.Controls.Add(Me.txthora_prevista)
        Me.Controls.Add(Me.etiquetahora_prevista)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblid_usuario_asignado)
        Me.Controls.Add(Me.dtpFecha_pedido)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.etiquetanombre_tarea)
        Me.Controls.Add(Me.txtnombre_tarea)
        Me.Controls.Add(Me.lblid_proyecto)
        Me.Controls.Add(Me.lblid_empresa)
        Me.Controls.Add(Me.lblid_sub_proyecto)
        Me.Name = "frmDetalleTareaExpress"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de Tareas Express"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblid_proyecto As System.Windows.Forms.Label
    Friend WithEvents lblid_empresa As System.Windows.Forms.Label
    Friend WithEvents lblid_sub_proyecto As System.Windows.Forms.Label
    Protected WithEvents dtpFecha_pedido As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents etiquetanombre_tarea As System.Windows.Forms.Label
    Protected WithEvents txtnombre_tarea As System.Windows.Forms.TextBox
    Friend WithEvents lblid_usuario_asignado As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents txthora_prevista As System.Windows.Forms.TextBox
    Friend WithEvents etiquetahora_prevista As System.Windows.Forms.Label
    Friend WithEvents lblid_tarea As System.Windows.Forms.Label
    Friend WithEvents chkEs_feriado As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProyecto As Button
    Friend WithEvents txtUnidad As Button
    Friend WithEvents txtAsignado As Button
    Friend WithEvents txtSubproyecto As Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbtipo_tarea As System.Windows.Forms.ComboBox
    Friend WithEvents lblid_tipo_tarea As System.Windows.Forms.Label
End Class
