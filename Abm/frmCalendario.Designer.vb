<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalendario
    Inherits System.Windows.Forms.Form
    'Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.lblid_sub_proyecto = New System.Windows.Forms.Label()
        Me.lblid_empresa = New System.Windows.Forms.Label()
        Me.lblid_proyecto = New System.Windows.Forms.Label()
        Me.MetroGrid1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFecha_desde = New System.Windows.Forms.DateTimePicker()
        Me.cmbCod_sub_proyecto = New System.Windows.Forms.ComboBox()
        Me.cmbCod_empresa = New System.Windows.Forms.ComboBox()
        Me.cmbCod_Proyecto = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_proyecto = New System.Windows.Forms.Label()
        Me.cmbproyecto = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbEmpresa = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbSub_proyecto = New System.Windows.Forms.ComboBox()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(846, 52)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(123, 23)
        Me.btnConsultar.TabIndex = 0
        Me.btnConsultar.Text = "Consultar Eventos"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnImportar
        '
        Me.btnImportar.Location = New System.Drawing.Point(846, 84)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(123, 23)
        Me.btnImportar.TabIndex = 2
        Me.btnImportar.Text = "Importar Eventos"
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'lblid_sub_proyecto
        '
        Me.lblid_sub_proyecto.AutoSize = True
        Me.lblid_sub_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_sub_proyecto.Location = New System.Drawing.Point(676, 9)
        Me.lblid_sub_proyecto.Name = "lblid_sub_proyecto"
        Me.lblid_sub_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_sub_proyecto.TabIndex = 600
        Me.lblid_sub_proyecto.Text = "0"
        Me.lblid_sub_proyecto.Visible = False
        '
        'lblid_empresa
        '
        Me.lblid_empresa.AutoSize = True
        Me.lblid_empresa.BackColor = System.Drawing.Color.Red
        Me.lblid_empresa.Location = New System.Drawing.Point(638, 9)
        Me.lblid_empresa.Name = "lblid_empresa"
        Me.lblid_empresa.Size = New System.Drawing.Size(13, 13)
        Me.lblid_empresa.TabIndex = 599
        Me.lblid_empresa.Text = "0"
        Me.lblid_empresa.Visible = False
        '
        'lblid_proyecto
        '
        Me.lblid_proyecto.AutoSize = True
        Me.lblid_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_proyecto.Location = New System.Drawing.Point(657, 9)
        Me.lblid_proyecto.Name = "lblid_proyecto"
        Me.lblid_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proyecto.TabIndex = 598
        Me.lblid_proyecto.Text = "0"
        Me.lblid_proyecto.Visible = False
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MetroGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(10, 124)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.ReadOnly = True
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(959, 337)
        Me.MetroGrid1.TabIndex = 601
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(787, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 15)
        Me.Label6.TabIndex = 1071
        Me.Label6.Text = "Fecha Desde"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecha_desde
        '
        Me.dtpFecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_desde.Location = New System.Drawing.Point(873, 26)
        Me.dtpFecha_desde.Name = "dtpFecha_desde"
        Me.dtpFecha_desde.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha_desde.TabIndex = 1070
        '
        'cmbCod_sub_proyecto
        '
        Me.cmbCod_sub_proyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCod_sub_proyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCod_sub_proyecto.FormattingEnabled = True
        Me.cmbCod_sub_proyecto.Location = New System.Drawing.Point(97, 77)
        Me.cmbCod_sub_proyecto.Name = "cmbCod_sub_proyecto"
        Me.cmbCod_sub_proyecto.Size = New System.Drawing.Size(165, 21)
        Me.cmbCod_sub_proyecto.TabIndex = 1083
        '
        'cmbCod_empresa
        '
        Me.cmbCod_empresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCod_empresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCod_empresa.FormattingEnabled = True
        Me.cmbCod_empresa.Location = New System.Drawing.Point(97, 26)
        Me.cmbCod_empresa.Name = "cmbCod_empresa"
        Me.cmbCod_empresa.Size = New System.Drawing.Size(165, 21)
        Me.cmbCod_empresa.TabIndex = 1082
        '
        'cmbCod_Proyecto
        '
        Me.cmbCod_Proyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCod_Proyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCod_Proyecto.FormattingEnabled = True
        Me.cmbCod_Proyecto.Location = New System.Drawing.Point(97, 50)
        Me.cmbCod_Proyecto.Name = "cmbCod_Proyecto"
        Me.cmbCod_Proyecto.Size = New System.Drawing.Size(165, 21)
        Me.cmbCod_Proyecto.TabIndex = 1081
        '
        'etiquetaid_proyecto
        '
        Me.etiquetaid_proyecto.AutoSize = True
        Me.etiquetaid_proyecto.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_proyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_proyecto.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_proyecto.Location = New System.Drawing.Point(37, 56)
        Me.etiquetaid_proyecto.Name = "etiquetaid_proyecto"
        Me.etiquetaid_proyecto.Size = New System.Drawing.Size(54, 15)
        Me.etiquetaid_proyecto.TabIndex = 1076
        Me.etiquetaid_proyecto.Text = "Proyecto"
        Me.etiquetaid_proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbproyecto
        '
        Me.cmbproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbproyecto.FormattingEnabled = True
        Me.cmbproyecto.Location = New System.Drawing.Point(268, 49)
        Me.cmbproyecto.Name = "cmbproyecto"
        Me.cmbproyecto.Size = New System.Drawing.Size(329, 21)
        Me.cmbproyecto.TabIndex = 1073
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(34, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 15)
        Me.Label5.TabIndex = 1078
        Me.Label5.Text = "Empresa"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbEmpresa
        '
        Me.cmbEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEmpresa.FormattingEnabled = True
        Me.cmbEmpresa.Location = New System.Drawing.Point(268, 25)
        Me.cmbEmpresa.Name = "cmbEmpresa"
        Me.cmbEmpresa.Size = New System.Drawing.Size(329, 21)
        Me.cmbEmpresa.TabIndex = 1072
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 15)
        Me.Label7.TabIndex = 1080
        Me.Label7.Text = "Sub Proyecto"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbSub_proyecto
        '
        Me.cmbSub_proyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSub_proyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSub_proyecto.FormattingEnabled = True
        Me.cmbSub_proyecto.Location = New System.Drawing.Point(268, 76)
        Me.cmbSub_proyecto.Name = "cmbSub_proyecto"
        Me.cmbSub_proyecto.Size = New System.Drawing.Size(329, 21)
        Me.cmbSub_proyecto.TabIndex = 1074
        '
        'frmCalendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(992, 473)
        Me.Controls.Add(Me.cmbCod_sub_proyecto)
        Me.Controls.Add(Me.cmbCod_empresa)
        Me.Controls.Add(Me.cmbCod_Proyecto)
        Me.Controls.Add(Me.etiquetaid_proyecto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpFecha_desde)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.lblid_sub_proyecto)
        Me.Controls.Add(Me.lblid_empresa)
        Me.Controls.Add(Me.lblid_proyecto)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.cmbproyecto)
        Me.Controls.Add(Me.cmbEmpresa)
        Me.Controls.Add(Me.cmbSub_proyecto)
        Me.Name = "frmCalendario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eventos Google Calendar"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnImportar As Button
    Friend WithEvents lblid_sub_proyecto As Label
    Friend WithEvents lblid_empresa As Label
    Friend WithEvents lblid_proyecto As Label
    Friend WithEvents MetroGrid1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbCod_sub_proyecto As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCod_empresa As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCod_Proyecto As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_proyecto As System.Windows.Forms.Label
    Friend WithEvents cmbproyecto As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbSub_proyecto As System.Windows.Forms.ComboBox
End Class
