<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleTipo_empresa
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleTipo_empresa))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.txtnombre_tipo_empresa = New System.Windows.Forms.TextBox
       Me.etiquetanombre_tipo_empresa = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'txtnombre_tipo_empresa
       '
       Me.txtnombre_tipo_empresa.BackColor = System.Drawing.Color.White
       Me.txtnombre_tipo_empresa.Location = New System.Drawing.Point(161, 70)
       Me.txtnombre_tipo_empresa.Size = New System.Drawing.Size(385, 20)
       Me.txtnombre_tipo_empresa.MaxLength = 50
       Me.txtnombre_tipo_empresa.Name = "txtnombre_tipo_empresa"
       Me.txtnombre_tipo_empresa.TabIndex = 4
       '
       'etiquietanombre_tipo_empresa
       '
        Me.etiquetanombre_tipo_empresa.BackColor = System.Drawing.Color.SteelBlue
        Me.etiquetanombre_tipo_empresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanombre_tipo_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_tipo_empresa.ForeColor = System.Drawing.Color.White
        Me.etiquetanombre_tipo_empresa.Location = New System.Drawing.Point(22, 70)
        Me.etiquetanombre_tipo_empresa.Name = "etiquetanombre_tipo_empresa"
        Me.etiquetanombre_tipo_empresa.Size = New System.Drawing.Size(133, 21)
        Me.etiquetanombre_tipo_empresa.TabIndex = 500
        Me.etiquetanombre_tipo_empresa.Text = "Nombre tipo empresa"
        Me.etiquetanombre_tipo_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnSalir.Location = New System.Drawing.Point(499, 153)
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
        Me.btnGuardar.Location = New System.Drawing.Point(392, 153)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 58)
        Me.btnGuardar.TabIndex = 50
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        '
        'frmDetalleTipo_empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 233)
        Me.Controls.Add(Me.txtnombre_tipo_empresa)
        Me.Controls.Add(Me.etiquetanombre_tipo_empresa)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "frmDetalleTipo_empresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo_empresa"
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Protected WithEvents txtnombre_tipo_empresa As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_tipo_empresa As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

