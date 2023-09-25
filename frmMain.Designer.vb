<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    'Inherits System.Windows.Forms.Form
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
        Me.components = New System.ComponentModel.Container()
        Me.MetroTile3 = New System.Windows.Forms.Label()
        Me.MetroTile2 = New System.Windows.Forms.Label()
        Me.MetroTile1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'MetroTile3
        '
        Me.MetroTile3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroTile3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroTile3.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.MetroTile3.Location = New System.Drawing.Point(230, 259)
        Me.MetroTile3.Name = "MetroTile3"
        Me.MetroTile3.Size = New System.Drawing.Size(345, 153)
        Me.MetroTile3.TabIndex = 2
        Me.MetroTile3.Text = "MetroTile3"
        Me.MetroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroTile2
        '
        Me.MetroTile2.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.MetroTile2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroTile2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MetroTile2.Image = Global.Gestion_tarea.My.Resources.Resources.mejorablanco
        Me.MetroTile2.Location = New System.Drawing.Point(406, 100)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(169, 153)
        Me.MetroTile2.TabIndex = 3
        Me.MetroTile2.Text = "Mejoras"
        Me.MetroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'MetroTile1
        '
        Me.MetroTile1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroTile1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroTile1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MetroTile1.Image = Global.Gestion_tarea.My.Resources.Resources.tareasblanco
        Me.MetroTile1.Location = New System.Drawing.Point(230, 100)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(169, 153)
        Me.MetroTile1.TabIndex = 0
        Me.MetroTile1.Text = "Proyectos"
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Timer1
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 575)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.MetroTile3)
        Me.Controls.Add(Me.MetroTile1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents MetroTile1 As System.Windows.Forms.Label
    Private WithEvents MetroTile3 As System.Windows.Forms.Label
    Private WithEvents MetroTile2 As System.Windows.Forms.Label
End Class
