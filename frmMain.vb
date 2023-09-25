Public Class frmMain

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        'Dim frmTemp As New frmAbmTarea
        'frmTemp.ShowDialog()

        vgTareaMejora = 1
        frmAbmTarea.ShowDialog()
        frmAbmTarea.Dispose()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '  Me.MetroTile2.Text = "Hora: " & vbCrLf & Date.Now.TimeOfDay.ToString

        '  Me.MetroTile1.BackColor = color01
        'Me.MetroTile1.TileImage = My.Resources.tareasblanco

        '  Me.MetroTile2.BackColor = color02
        'Me.MetroTile2.TileImage = My.Resources.mejorablanco

        ' Me.MetroTile3.BackColor = color03
        Me.MetroTile3.Text = Date.Now.ToLongDateString


        'Me.Timer1.Interval = 1000 '
        'Me.Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick

        '  Me.MetroTile2.Text = "Hora: " & String.Format("{0:HH:mm:ss}", DateTime.Now)

    End Sub

    Dim color01R As Color = Color.FromArgb(100, 144, 227)
    Dim color01 As Color = Color.FromArgb(4, 75, 204)
    Dim color02R As Color = Color.FromArgb(232, 88, 127)
    Dim color02 As Color = Color.FromArgb(188, 28, 71)
    Dim color03R As Color = Color.FromArgb(91, 189, 235)
    Dim color03 As Color = Color.FromArgb(17, 145, 204)
    Dim color04R As Color = Color.FromArgb(162, 130, 237)
    Dim color04 As Color = Color.FromArgb(99, 60, 189)
    Dim color05R As Color = Color.FromArgb(207, 79, 219)
    Dim color05 As Color = Color.FromArgb(153, 0, 168)

    Private Sub MetroTile1_MouseHover(sender As Object, e As EventArgs) Handles MetroTile1.MouseHover
        Me.MetroTile1.BackColor = color01R
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub MetroTile1_MouseLeave(sender As Object, e As EventArgs) Handles MetroTile1.MouseLeave
        Me.MetroTile1.BackColor = color01
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        vgTareaMejora = 2

        frmAbmTarea.ShowDialog()
        frmAbmTarea.Dispose()
    End Sub

    Private Sub MetroTile2_MouseHover(sender As Object, e As EventArgs) Handles MetroTile2.MouseHover
        Me.MetroTile2.BackColor = color02R
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub MetroTile2_MouseLeave(sender As Object, e As EventArgs) Handles MetroTile2.MouseLeave
        Me.MetroTile2.BackColor = color02
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MetroTile3_MouseHover(sender As Object, e As EventArgs) Handles MetroTile3.MouseHover
        Me.MetroTile3.BackColor = color03R
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub MetroTile3_MouseLeave(sender As Object, e As EventArgs) Handles MetroTile3.MouseLeave
        Me.MetroTile3.BackColor = color03
        Me.Cursor = Cursors.Default
    End Sub





End Class