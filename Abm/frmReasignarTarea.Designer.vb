<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReasignarTarea
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReasignarTarea))
        Me.dtpFecha_inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpfecha_fin = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha_prevista = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtpFecha_inicio
        '
        Me.dtpFecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_inicio.Location = New System.Drawing.Point(136, 84)
        Me.dtpFecha_inicio.Name = "dtpFecha_inicio"
        Me.dtpFecha_inicio.Size = New System.Drawing.Size(93, 20)
        Me.dtpFecha_inicio.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(94, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 15)
        Me.Label10.TabIndex = 655
        Me.Label10.Text = "Inicio"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpfecha_fin
        '
        Me.dtpfecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_fin.Location = New System.Drawing.Point(136, 120)
        Me.dtpfecha_fin.Name = "dtpfecha_fin"
        Me.dtpfecha_fin.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_fin.TabIndex = 5
        '
        'etiquetafecha_prevista
        '
        Me.etiquetafecha_prevista.AutoSize = True
        Me.etiquetafecha_prevista.BackColor = System.Drawing.Color.Transparent
        Me.etiquetafecha_prevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_prevista.ForeColor = System.Drawing.Color.Black
        Me.etiquetafecha_prevista.Location = New System.Drawing.Point(61, 122)
        Me.etiquetafecha_prevista.Name = "etiquetafecha_prevista"
        Me.etiquetafecha_prevista.Size = New System.Drawing.Size(69, 15)
        Me.etiquetafecha_prevista.TabIndex = 653
        Me.etiquetafecha_prevista.Text = "Fin previsto"
        Me.etiquetafecha_prevista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(269, 178)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 58)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmReasignarTarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 251)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.dtpFecha_inicio)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpfecha_fin)
        Me.Controls.Add(Me.etiquetafecha_prevista)
        Me.Name = "frmReasignarTarea"
        Me.Text = "Reasignar Datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected WithEvents dtpFecha_inicio As DateTimePicker
    Friend WithEvents Label10 As Label
    Protected WithEvents dtpfecha_fin As DateTimePicker
    Friend WithEvents etiquetafecha_prevista As Label
    Friend WithEvents btnGuardar As Button
End Class
