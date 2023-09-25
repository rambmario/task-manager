<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtemp
    ' Inherits System.Windows.Forms.Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtemp))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblid_tarea = New System.Windows.Forms.Label()
        Me.chkActivo_mejora = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(139, 70)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(101, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese una Fecha:"
        '
        'btnBorrar
        '
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.Location = New System.Drawing.Point(252, -219)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(39, 39)
        Me.btnBorrar.TabIndex = 627
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = Global.Gestion_tarea.My.Resources.Resources.salir_c_1_35
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(213, 129)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(71, 58)
        Me.btnSalir.TabIndex = 626
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
        Me.btnGuardar.Location = New System.Drawing.Point(126, 129)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 58)
        Me.btnGuardar.TabIndex = 625
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblid_tarea
        '
        Me.lblid_tarea.AutoSize = True
        Me.lblid_tarea.BackColor = System.Drawing.Color.Red
        Me.lblid_tarea.Location = New System.Drawing.Point(23, 109)
        Me.lblid_tarea.Name = "lblid_tarea"
        Me.lblid_tarea.Size = New System.Drawing.Size(13, 13)
        Me.lblid_tarea.TabIndex = 644
        Me.lblid_tarea.Text = "0"
        Me.lblid_tarea.Visible = False
        '
        'chkActivo_mejora
        '
        Me.chkActivo_mejora.AutoSize = True
        Me.chkActivo_mejora.Location = New System.Drawing.Point(63, 96)
        Me.chkActivo_mejora.Name = "chkActivo_mejora"
        Me.chkActivo_mejora.Size = New System.Drawing.Size(118, 17)
        Me.chkActivo_mejora.TabIndex = 645
        Me.chkActivo_mejora.Text = "Esta activo mejoras"
        Me.chkActivo_mejora.UseVisualStyleBackColor = True
        Me.chkActivo_mejora.Visible = False
        '
        'frmtemp
        '
        Me.AcceptButton = Me.btnGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(300, 200)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkActivo_mejora)
        Me.Controls.Add(Me.lblid_tarea)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.MaximumSize = New System.Drawing.Size(300, 200)
        Me.MinimumSize = New System.Drawing.Size(300, 180)
        Me.Name = "frmtemp"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Cambio de Fecha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Protected WithEvents btnBorrar As System.Windows.Forms.Button
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblid_tarea As System.Windows.Forms.Label
    Friend WithEvents chkActivo_mejora As System.Windows.Forms.CheckBox

End Class
