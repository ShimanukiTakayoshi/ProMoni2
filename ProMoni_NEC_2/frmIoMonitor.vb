Public Class frmIoMonitor

    Private Sub frmIoMonitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub timIoScan_Tick(sender As Object, e As EventArgs) Handles timIoScan.Tick
        lblI0.Text = Str(frmMain.IO(0))
        lblI1.Text = Str(frmMain.IO(1))
        lblI2.Text = Str(frmMain.IO(2))
        lblI3.Text = Str(frmMain.IO(3))
        lblI4.Text = Str(frmMain.IO(4))
        lblI5.Text = Str(frmMain.IO(5))
        lblI6.Text = Str(frmMain.IO(6))
        lblI7.Text = Str(frmMain.IO(7))
    End Sub
End Class