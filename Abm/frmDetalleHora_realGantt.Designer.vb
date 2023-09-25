<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDetalleHora_realGantt
    'Inherits System.Windows.Forms.Form
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleHora_real))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.etiquetanombre_tarea = New System.Windows.Forms.Label()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.txthora_real = New System.Windows.Forms.TextBox()
        Me.etiquetahora_real = New System.Windows.Forms.Label()
        Me.lblid_tarea = New System.Windows.Forms.Label()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBuscatarea = New System.Windows.Forms.Button()
        Me.cmbtarea = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_tarea = New System.Windows.Forms.Label()
        Me.lblid_usuario_asignado = New System.Windows.Forms.Label()
        Me.btnBuscausuario = New System.Windows.Forms.Button()
        Me.cmbusuario_asignado = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_usuario = New System.Windows.Forms.Label()
        Me.dtpfecha_carga = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha_carga = New System.Windows.Forms.Label()
        Me.etiquetaid_tipo_tarea = New System.Windows.Forms.Label()
        Me.txtidentificador = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(499, 373)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 61)
        Me.btnSalir.TabIndex = 51
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(392, 373)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(81, 61)
        Me.btnGuardar.TabIndex = 50
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCosto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnBuscausuario)
        Me.GroupBox1.Controls.Add(Me.etiquetanombre_tarea)
        Me.GroupBox1.Controls.Add(Me.txtComentario)
        Me.GroupBox1.Controls.Add(Me.txthora_real)
        Me.GroupBox1.Controls.Add(Me.etiquetahora_real)
        Me.GroupBox1.Controls.Add(Me.dtpfecha_carga)
        Me.GroupBox1.Controls.Add(Me.lblid_usuario_asignado)
        Me.GroupBox1.Controls.Add(Me.etiquetafecha_carga)
        Me.GroupBox1.Controls.Add(Me.cmbusuario_asignado)
        Me.GroupBox1.Controls.Add(Me.etiquetaid_usuario)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(557, 282)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'txtCosto
        '
        Me.txtCosto.BackColor = System.Drawing.Color.White
        Me.txtCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosto.ForeColor = System.Drawing.Color.Blue
        Me.txtCosto.Location = New System.Drawing.Point(159, 147)
        Me.txtCosto.MaxLength = 50
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(222, 31)
        Me.txtCosto.TabIndex = 8
        Me.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(26, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 15)
        Me.Label1.TabIndex = 516
        Me.Label1.Text = "Costo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'etiquetanombre_tarea
        '
        Me.etiquetanombre_tarea.AutoSize = True
        Me.etiquetanombre_tarea.BackColor = System.Drawing.Color.Transparent
        Me.etiquetanombre_tarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_tarea.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_tarea.Location = New System.Drawing.Point(26, 195)
        Me.etiquetanombre_tarea.Name = "etiquetanombre_tarea"
        Me.etiquetanombre_tarea.Size = New System.Drawing.Size(71, 15)
        Me.etiquetanombre_tarea.TabIndex = 514
        Me.etiquetanombre_tarea.Text = "Comentario"
        Me.etiquetanombre_tarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtComentario
        '
        Me.txtComentario.BackColor = System.Drawing.Color.White
        Me.txtComentario.Location = New System.Drawing.Point(159, 194)
        Me.txtComentario.MaxLength = 5000
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(384, 65)
        Me.txtComentario.TabIndex = 9
        '
        'txthora_real
        '
        Me.txthora_real.BackColor = System.Drawing.Color.White
        Me.txthora_real.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthora_real.ForeColor = System.Drawing.Color.Blue
        Me.txthora_real.Location = New System.Drawing.Point(159, 101)
        Me.txthora_real.MaxLength = 50
        Me.txthora_real.Name = "txthora_real"
        Me.txthora_real.Size = New System.Drawing.Size(222, 31)
        Me.txthora_real.TabIndex = 7
        Me.txthora_real.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetahora_real
        '
        Me.etiquetahora_real.AutoSize = True
        Me.etiquetahora_real.BackColor = System.Drawing.Color.Transparent
        Me.etiquetahora_real.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetahora_real.ForeColor = System.Drawing.Color.Black
        Me.etiquetahora_real.Location = New System.Drawing.Point(26, 101)
        Me.etiquetahora_real.Name = "etiquetahora_real"
        Me.etiquetahora_real.Size = New System.Drawing.Size(58, 15)
        Me.etiquetahora_real.TabIndex = 505
        Me.etiquetahora_real.Text = "Hora real"
        Me.etiquetahora_real.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_tarea
        '
        Me.lblid_tarea.AutoSize = True
        Me.lblid_tarea.BackColor = System.Drawing.Color.Red
        Me.lblid_tarea.Location = New System.Drawing.Point(9, 403)
        Me.lblid_tarea.Name = "lblid_tarea"
        Me.lblid_tarea.Size = New System.Drawing.Size(13, 13)
        Me.lblid_tarea.TabIndex = 500
        Me.lblid_tarea.Text = "0"
        Me.lblid_tarea.Visible = False
        '
        'btnBuscatarea
        '
        Me.btnBuscatarea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscatarea.Image = CType(resources.GetObject("btnBuscatarea.Image"), System.Drawing.Image)
        Me.btnBuscatarea.Location = New System.Drawing.Point(319, 395)
        Me.btnBuscatarea.Name = "btnBuscatarea"
        Me.btnBuscatarea.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscatarea.TabIndex = 60
        Me.btnBuscatarea.UseVisualStyleBackColor = True
        Me.btnBuscatarea.Visible = False
        '
        'cmbtarea
        '
        Me.cmbtarea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbtarea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtarea.FormattingEnabled = True
        Me.cmbtarea.Location = New System.Drawing.Point(20, 395)
        Me.cmbtarea.Name = "cmbtarea"
        Me.cmbtarea.Size = New System.Drawing.Size(329, 21)
        Me.cmbtarea.TabIndex = 1010
        Me.cmbtarea.Visible = False
        '
        'etiquetaid_tarea
        '
        Me.etiquetaid_tarea.AutoSize = True
        Me.etiquetaid_tarea.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_tarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_tarea.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_tarea.Location = New System.Drawing.Point(41, 395)
        Me.etiquetaid_tarea.Name = "etiquetaid_tarea"
        Me.etiquetaid_tarea.Size = New System.Drawing.Size(39, 15)
        Me.etiquetaid_tarea.TabIndex = 501
        Me.etiquetaid_tarea.Text = "Tarea"
        Me.etiquetaid_tarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetaid_tarea.Visible = False
        '
        'lblid_usuario_asignado
        '
        Me.lblid_usuario_asignado.AutoSize = True
        Me.lblid_usuario_asignado.BackColor = System.Drawing.Color.Red
        Me.lblid_usuario_asignado.Location = New System.Drawing.Point(368, 22)
        Me.lblid_usuario_asignado.Name = "lblid_usuario_asignado"
        Me.lblid_usuario_asignado.Size = New System.Drawing.Size(13, 13)
        Me.lblid_usuario_asignado.TabIndex = 502
        Me.lblid_usuario_asignado.Text = "0"
        Me.lblid_usuario_asignado.Visible = False
        '
        'btnBuscausuario
        '
        Me.btnBuscausuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscausuario.Enabled = False
        Me.btnBuscausuario.Image = CType(resources.GetObject("btnBuscausuario.Image"), System.Drawing.Image)
        Me.btnBuscausuario.Location = New System.Drawing.Point(513, 22)
        Me.btnBuscausuario.Name = "btnBuscausuario"
        Me.btnBuscausuario.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscausuario.TabIndex = 61
        Me.btnBuscausuario.UseVisualStyleBackColor = True
        '
        'cmbusuario_asignado
        '
        Me.cmbusuario_asignado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbusuario_asignado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbusuario_asignado.FormattingEnabled = True
        Me.cmbusuario_asignado.Location = New System.Drawing.Point(159, 22)
        Me.cmbusuario_asignado.Name = "cmbusuario_asignado"
        Me.cmbusuario_asignado.Size = New System.Drawing.Size(337, 21)
        Me.cmbusuario_asignado.TabIndex = 5
        '
        'etiquetaid_usuario
        '
        Me.etiquetaid_usuario.AutoSize = True
        Me.etiquetaid_usuario.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_usuario.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_usuario.Location = New System.Drawing.Point(26, 22)
        Me.etiquetaid_usuario.Name = "etiquetaid_usuario"
        Me.etiquetaid_usuario.Size = New System.Drawing.Size(104, 15)
        Me.etiquetaid_usuario.TabIndex = 503
        Me.etiquetaid_usuario.Text = "Usuario Asignado"
        Me.etiquetaid_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpfecha_carga
        '
        Me.dtpfecha_carga.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_carga.Location = New System.Drawing.Point(159, 66)
        Me.dtpfecha_carga.Name = "dtpfecha_carga"
        Me.dtpfecha_carga.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_carga.TabIndex = 6
        '
        'etiquetafecha_carga
        '
        Me.etiquetafecha_carga.AutoSize = True
        Me.etiquetafecha_carga.BackColor = System.Drawing.Color.Transparent
        Me.etiquetafecha_carga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_carga.ForeColor = System.Drawing.Color.Black
        Me.etiquetafecha_carga.Location = New System.Drawing.Point(26, 66)
        Me.etiquetafecha_carga.Name = "etiquetafecha_carga"
        Me.etiquetafecha_carga.Size = New System.Drawing.Size(75, 15)
        Me.etiquetafecha_carga.TabIndex = 504
        Me.etiquetafecha_carga.Text = "Fecha carga"
        Me.etiquetafecha_carga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'etiquetaid_tipo_tarea
        '
        Me.etiquetaid_tipo_tarea.AutoSize = True
        Me.etiquetaid_tipo_tarea.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_tipo_tarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_tipo_tarea.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_tipo_tarea.Location = New System.Drawing.Point(316, 27)
        Me.etiquetaid_tipo_tarea.Name = "etiquetaid_tipo_tarea"
        Me.etiquetaid_tipo_tarea.Size = New System.Drawing.Size(50, 15)
        Me.etiquetaid_tipo_tarea.TabIndex = 507
        Me.etiquetaid_tipo_tarea.Text = "Usuario"
        Me.etiquetaid_tipo_tarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtidentificador
        '
        Me.txtidentificador.BackColor = System.Drawing.Color.SteelBlue
        Me.txtidentificador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidentificador.ForeColor = System.Drawing.Color.White
        Me.txtidentificador.Location = New System.Drawing.Point(372, 26)
        Me.txtidentificador.MaxLength = 5000
        Me.txtidentificador.Name = "txtidentificador"
        Me.txtidentificador.Size = New System.Drawing.Size(208, 20)
        Me.txtidentificador.TabIndex = 506
        Me.txtidentificador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmDetalleHora_real
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 464)
        Me.Controls.Add(Me.lblid_tarea)
        Me.Controls.Add(Me.etiquetaid_tipo_tarea)
        Me.Controls.Add(Me.btnBuscatarea)
        Me.Controls.Add(Me.cmbtarea)
        Me.Controls.Add(Me.etiquetaid_tarea)
        Me.Controls.Add(Me.txtidentificador)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleHora_real"
        Me.Text = "frmDetalleHora_real"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblid_tarea As System.Windows.Forms.Label
    Friend WithEvents btnBuscatarea As System.Windows.Forms.Button
    Friend WithEvents cmbtarea As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_tarea As System.Windows.Forms.Label
    Friend WithEvents lblid_usuario_asignado As System.Windows.Forms.Label
    Friend WithEvents btnBuscausuario As System.Windows.Forms.Button
    Friend WithEvents cmbusuario_asignado As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_usuario As System.Windows.Forms.Label
    Protected WithEvents dtpfecha_carga As System.Windows.Forms.DateTimePicker
    Friend WithEvents etiquetafecha_carga As System.Windows.Forms.Label
    Protected WithEvents txthora_real As System.Windows.Forms.TextBox
    Friend WithEvents etiquetahora_real As System.Windows.Forms.Label
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents btnGuardar As System.Windows.Forms.Button
    Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Friend WithEvents etiquetaid_tipo_tarea As System.Windows.Forms.Label
    Protected WithEvents txtidentificador As System.Windows.Forms.TextBox
    Friend WithEvents etiquetanombre_tarea As System.Windows.Forms.Label
    Protected WithEvents txtComentario As System.Windows.Forms.TextBox
    Protected WithEvents txtCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

