Public Class frmClearTime

    Private Sub frmClearTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudCth.Value = frmMain.Cth
        nudCtm.Value = frmMain.Ctm
    End Sub

    Private Sub btnWorkTimeOk_Click(sender As Object, e As EventArgs) Handles btnWorkTimeOk.Click
        frmMain.Cth = CInt(nudCth.Value)
        frmMain.Ctm = CInt(nudCtm.Value)
        frmMain.SaveSetting()
        Me.Hide()
    End Sub

End Class