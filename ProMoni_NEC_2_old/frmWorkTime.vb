Public Class frmWorkTime
    Dim WtFirstFlag As Boolean = True
    Dim WtSetNGFlag As Boolean = False

    Private Sub frmWorkTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WtFirstFlag = True
        WtSetNGFlag = False
        nudSh1.Value = frmMain.WtSh(1)
        nudSh2.Value = frmMain.WtSh(2)
        nudSh3.Value = frmMain.WtSh(3)
        nudSh4.Value = frmMain.WtSh(4)
        nudSh5.Value = frmMain.WtSh(5)
        nudSh6.Value = frmMain.WtSh(6)
        nudSh7.Value = frmMain.WtSh(7)

        nudSm1.Value = frmMain.WtSm(1)
        nudSm2.Value = frmMain.WtSm(2)
        nudSm3.Value = frmMain.WtSm(3)
        nudSm4.Value = frmMain.WtSm(4)
        nudSm5.Value = frmMain.WtSm(5)
        nudSm6.Value = frmMain.WtSm(6)
        nudSm7.Value = frmMain.WtSm(7)

        nudEm1.Value = frmMain.WtEm(1)
        nudEm2.Value = frmMain.WtEm(2)
        nudEm3.Value = frmMain.WtEm(3)
        nudEm4.Value = frmMain.WtEm(4)
        nudEm5.Value = frmMain.WtEm(5)
        nudEm6.Value = frmMain.WtEm(6)
        nudEm7.Value = frmMain.WtEm(7)

        nudLoss1.Value = frmMain.WtLosR(1)
        nudLoss2.Value = frmMain.WtLosR(2)
        nudLoss3.Value = frmMain.WtLosR(3)
        nudLoss4.Value = frmMain.WtLosR(4)
        nudLoss5.Value = frmMain.WtLosR(5)
        nudLoss6.Value = frmMain.WtLosR(6)
        nudLoss7.Value = frmMain.WtLosR(7)

        lblStopTimeJ1.Text = Str(frmMain.WtLosTime(1))
        lblStopTimeJ2.Text = Str(frmMain.WtLosTime(2))
        lblStopTimeJ3.Text = Str(frmMain.WtLosTime(3))
        lblStopTimeJ4.Text = Str(frmMain.WtLosTime(4))
        lblStopTimeJ5.Text = Str(frmMain.WtLosTime(5))
        lblStopTimeJ6.Text = Str(frmMain.WtLosTime(6))
        lblStopTimeJ7.Text = Str(frmMain.WtLosTime(7))

        'txt1ProStartH.Text = "" 'Str(frmMain.Wt1ProStartH)
        'txt1ProStartM.Text = "" 'Str(frmMain.Wt1ProStartM)
        'txt1BrkStartH.Text = "" 'Str(frmMain.Wt1BrkStartH)
        'txt1BrkStartM.Text = "" 'Str(frmMain.Wt1BrkStartM)
        'txt1BrkEndH.Text = "" 'Str(frmMain.Wt1BrkEndH)
        'txt1BrkEndM.Text = "" 'Str(frmMain.Wt1BrkEndM)
        'txt1ProEndH.Text = "" 'Str(frmMain.Wt1ProEndH)
        'txt1ProEndM.Text = "" 'Str(frmMain.Wt1ProEndM)
        'txt2ProStartH.Text = "" 'Str(frmMain.Wt2ProStartH)
        'txt2ProStartM.Text = "" 'Str(frmMain.Wt2ProStartM)
        'txt2BrkStartH.Text = "" 'Str(frmMain.Wt2BrkStartH)
        'txt2BrkStartM.Text = "" 'Str(frmMain.Wt2BrkStartM)
        'txt2BrkEndH.Text = "" 'Str(frmMain.Wt2BrkEndH)
        'txt2BrkEndM.Text = "" 'Str(frmMain.Wt2BrkEndM)
        'txt2ProEndH.Text = "" 'Str(frmMain.Wt2ProEndH)
        'txt2ProEndM.Text = "" 'Str(frmMain.Wt2ProEndM)
        '
        nudTh1.Value = frmMain.Start1H
        nudTh2.Value = frmMain.Start2H
        nudTh3.Value = frmMain.End2H
        nudTm1.Value = frmMain.Start1M
        nudTm2.Value = frmMain.Start2M
        nudTm3.Value = frmMain.End2M
        Select Case frmMain.Han
            Case 2
                rbtn2han.Checked = True
            Case Else
                rbtn3han.Checked = True
        End Select

        'nudWt1psh.Value = frmMain.Wt1ProStartH
        'nudWt1psm.Value = frmMain.Wt1ProStartM
        'nudWt1bsh.Value = frmMain.Wt1BrkStartH
        'nudWt1bsm.Value = frmMain.Wt1BrkStartM
        'nudWt1beh.Value = frmMain.Wt1BrkEndH
        'nudWt1bem.Value = frmMain.Wt1BrkEndM
        'nudWt1peh.Value = frmMain.Wt1ProEndH
        'nudWt1pem.Value = frmMain.Wt1ProEndM
        'nudWt2psh.Value = frmMain.Wt2ProStartH
        'nudWt2psm.Value = frmMain.Wt2ProStartM
        'nudWt2bsh.Value = frmMain.Wt2BrkStartH
        'nudWt2bsm.Value = frmMain.Wt2BrkStartM
        'nudWt2beh.Value = frmMain.Wt2BrkEndH
        'nudWt2bem.Value = frmMain.Wt2BrkEndM
        'nudWt2peh.Value = frmMain.Wt2ProEndH
        'nudWt2pem.Value = frmMain.Wt2ProEndM

        ReDraw()

        nudPropertySetting()
        WtFirstFlag = False
    End Sub

    'Private Sub txt1ProStartH_TextChanged(sender As Object, e As EventArgs) Handles txt1ProStartH.TextChanged
    '    If IsNumeric(txt1ProStartH.Text) = False Then
    '        MessageBox.Show("数値を入力して下さい")
    '    End If
    'End Sub

    Public Sub nudPropertySetting()
        If WtFirstFlag = False Then
            Dim StSecS(7) As Long
            Dim StSecE(7) As Long
            WtSetNGFlag = False
            '設定時間を「秒」に換算
            StSecS(1) = CLng(nudSh1.Value * 3600 + nudSm1.Value * 60)
            StSecS(2) = CLng(nudSh2.Value * 3600 + nudSm2.Value * 60)
            StSecS(3) = CLng(nudSh3.Value * 3600 + nudSm3.Value * 60)
            StSecS(4) = CLng(nudSh4.Value * 3600 + nudSm4.Value * 60)
            StSecS(5) = CLng(nudSh5.Value * 3600 + nudSm5.Value * 60)
            StSecS(6) = CLng(nudSh6.Value * 3600 + nudSm6.Value * 60)
            StSecS(7) = CLng(nudSh7.Value * 3600 + nudSm7.Value * 60)
            StSecE(1) = CLng(StSecS(1) + nudEm1.Value * 60)
            StSecE(2) = CLng(StSecS(2) + nudEm2.Value * 60)
            StSecE(3) = CLng(StSecS(3) + nudEm3.Value * 60)
            StSecE(4) = CLng(StSecS(4) + nudEm4.Value * 60)
            StSecE(5) = CLng(StSecS(5) + nudEm5.Value * 60)
            StSecE(6) = CLng(StSecS(6) + nudEm6.Value * 60)
            StSecE(7) = CLng(StSecS(7) + nudEm7.Value * 60)

            For i As Short = 1 To 6
                If StSecS(i) > StSecS(i + 1) Then
                    If MsgBox("｢ライン停止時間｣の設定値が前後しています。", CType(vbOKCancel + vbExclamation, MsgBoxStyle)) = vbOK Then
                        WtSetNGFlag = True
                        Exit Sub
                    End If
                End If
            Next
            For i As Short = 1 To 6
                If StSecE(i) > StSecS(i + 1) Then
                    If MsgBox("｢停止時間｣の設定値が前後しています。", CType(vbOKCancel + vbExclamation, MsgBoxStyle)) = vbOK Then
                        WtSetNGFlag = True
                        Exit Sub
                    End If
                End If
            Next
            ReDraw()
        End If
    End Sub


    Private Sub nudsh1x_ValueChanged(sender As Object, e As EventArgs) Handles nudWt1psh.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudWt1bsh_ValueChanged(sender As Object, e As EventArgs) Handles nudWt1bsh.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudWt1beh_ValueChanged(sender As Object, e As EventArgs) Handles nudWt1beh.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudWt1peh_ValueChanged(sender As Object, e As EventArgs) Handles nudWt1peh.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudWt2psh_ValueChanged(sender As Object, e As EventArgs) Handles nudWt2psh.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudWt2bsh_ValueChanged(sender As Object, e As EventArgs) Handles nudWt2bsh.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudWt2beh_ValueChanged(sender As Object, e As EventArgs) Handles nudWt2beh.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudWt2peh_ValueChanged(sender As Object, e As EventArgs) Handles nudWt2peh.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudWt1psm_ValueChanged(sender As Object, e As EventArgs) Handles nudWt1psm.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudWt1bsm_ValueChanged(sender As Object, e As EventArgs) Handles nudWt1bsm.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudWt1bem_ValueChanged(sender As Object, e As EventArgs) Handles nudWt1bem.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudWt1pem_ValueChanged(sender As Object, e As EventArgs) Handles nudWt1pem.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudWt2psm_ValueChanged(sender As Object, e As EventArgs) Handles nudWt2psm.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudWt2bsm_ValueChanged(sender As Object, e As EventArgs) Handles nudWt2bsm.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudWt2bem_ValueChanged(sender As Object, e As EventArgs) Handles nudWt2bem.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudWt2pem_ValueChanged(sender As Object, e As EventArgs) Handles nudWt2pem.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub btnWorkTimeOk_Click(sender As Object, e As EventArgs) Handles btnWorkTimeOk.Click
        nudPropertySetting()
        If WtSetNGFlag = False Then
            ReDraw()
            frmMain.SaveSetting()
            frmMain.WorkTimeCalc()
        End If
    End Sub

    Public Sub ReDraw()
        frmMain.WtSh(1) = CInt(nudSh1.Value)
        frmMain.WtSh(2) = CInt(nudSh2.Value)
        frmMain.WtSh(3) = CInt(nudSh3.Value)
        frmMain.WtSh(4) = CInt(nudSh4.Value)
        frmMain.WtSh(5) = CInt(nudSh5.Value)
        frmMain.WtSh(6) = CInt(nudSh6.Value)
        frmMain.WtSh(7) = CInt(nudSh7.Value)
        frmMain.WtSm(1) = CInt(nudSm1.Value)
        frmMain.WtSm(2) = CInt(nudSm2.Value)
        frmMain.WtSm(3) = CInt(nudSm3.Value)
        frmMain.WtSm(4) = CInt(nudSm4.Value)
        frmMain.WtSm(5) = CInt(nudSm5.Value)
        frmMain.WtSm(6) = CInt(nudSm6.Value)
        frmMain.WtSm(7) = CInt(nudSm7.Value)
        frmMain.WtEm(1) = CInt(nudEm1.Value)
        frmMain.WtEm(2) = CInt(nudEm2.Value)
        frmMain.WtEm(3) = CInt(nudEm3.Value)
        frmMain.WtEm(4) = CInt(nudEm4.Value)
        frmMain.WtEm(5) = CInt(nudEm5.Value)
        frmMain.WtEm(6) = CInt(nudEm6.Value)
        frmMain.WtEm(7) = CInt(nudEm7.Value)
        frmMain.WtLosR(1) = CInt(nudLoss1.Value)
        frmMain.WtLosR(2) = CInt(nudLoss2.Value)
        frmMain.WtLosR(3) = CInt(nudLoss3.Value)
        frmMain.WtLosR(4) = CInt(nudLoss4.Value)
        frmMain.WtLosR(5) = CInt(nudLoss5.Value)
        frmMain.WtLosR(6) = CInt(nudLoss6.Value)
        frmMain.WtLosR(7) = CInt(nudLoss7.Value)

        frmMain.Start1H = CInt(nudTh1.Value)
        frmMain.Start2H = CInt(nudTh2.Value)
        frmMain.End2H = CInt(nudTh3.Value)
        frmMain.Start1M = CInt(nudTm1.Value)
        frmMain.Start2M = CInt(nudTm2.Value)
        frmMain.End2M = CInt(nudTm3.Value)

        For i As Short = 1 To 7
            frmMain.WtLosTime(i) = CInt(frmMain.WtEm(i) * (frmMain.WtLosR(i) / 100))
        Next
        lblStopTimeJ1.Text = Str(frmMain.WtLosTime(1))
        lblStopTimeJ2.Text = Str(frmMain.WtLosTime(2))
        lblStopTimeJ3.Text = Str(frmMain.WtLosTime(3))
        lblStopTimeJ4.Text = Str(frmMain.WtLosTime(4))
        lblStopTimeJ5.Text = Str(frmMain.WtLosTime(5))
        lblStopTimeJ6.Text = Str(frmMain.WtLosTime(6))
        lblStopTimeJ7.Text = Str(frmMain.WtLosTime(7))

        Select Case frmMain.Han
            Case 2
                Label50.Visible = True
                Label51.Visible = True
                Label52.Visible = True
                Label53.Visible = True
                Label54.Visible = True
                Label55.Visible = True
                Label56.Visible = True
                Label57.Visible = True
                nudTh1.Visible = True
                nudTh2.Visible = True
                nudTh3.Visible = True
                nudTm1.Visible = True
                nudTm2.Visible = True
                nudTm3.Visible = True
                Label23.Visible = False
                Label30.Visible = False
                Label32.Visible = False
                lblStopTimeJ7.Visible = False
                nudSh7.Visible = False
                nudSm7.Visible = False
                nudEm7.Visible = False
                nudLoss7.Visible = False
                Label21.Text = "1直休憩"
                frmMain.Cth = CInt(CLng(frmMain.End2H))
                frmMain.Ctm = CInt(CLng(frmMain.End2M))
                frmMain.Rth = CInt(CLng(frmMain.Start2H))
                frmMain.Rtm = CInt(CLng(frmMain.Start2M))
            Case Else
                Label50.Visible = False
                Label51.Visible = False
                Label52.Visible = False
                Label53.Visible = False
                Label54.Visible = False
                Label55.Visible = False
                Label56.Visible = False
                Label57.Visible = False
                nudTh1.Visible = False
                nudTh2.Visible = False
                nudTh3.Visible = False
                nudTm1.Visible = False
                nudTm2.Visible = False
                nudTm3.Visible = False
                Label23.Visible = True
                Label30.Visible = True
                Label32.Visible = True
                lblStopTimeJ7.Visible = True
                nudSh7.Visible = True
                nudSm7.Visible = True
                nudEm7.Visible = True
                nudLoss7.Visible = True
                Label21.Text = "1直夕礼･休憩"
                frmMain.Cth = 7
                frmMain.Ctm = 45
                frmMain.Rth = 20
                frmMain.Rtm = 0
        End Select
    End Sub


    Private Sub btnWorkTimeCancel_Click(sender As Object, e As EventArgs) Handles btnWorkTimeCancel.Click
        nudPropertySetting()
        If WtSetNGFlag = False Then
            Me.Hide()
        End If
    End Sub

    Private Sub nudSh1_ValueChanged(sender As Object, e As EventArgs) Handles nudSh1.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSm1_ValueChanged(sender As Object, e As EventArgs) Handles nudSm1.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudEm1_ValueChanged(sender As Object, e As EventArgs) Handles nudEm1.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudLoss1_ValueChanged(sender As Object, e As EventArgs) Handles nudLoss1.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSh2_ValueChanged(sender As Object, e As EventArgs) Handles nudSh2.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSm2_ValueChanged(sender As Object, e As EventArgs) Handles nudSm2.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudEm2_ValueChanged(sender As Object, e As EventArgs) Handles nudEm2.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudLoss2_ValueChanged(sender As Object, e As EventArgs) Handles nudLoss2.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSh3_ValueChanged(sender As Object, e As EventArgs) Handles nudSh3.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSm3_ValueChanged(sender As Object, e As EventArgs) Handles nudSm3.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudEm3_ValueChanged(sender As Object, e As EventArgs) Handles nudEm3.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudLoss3_ValueChanged(sender As Object, e As EventArgs) Handles nudLoss3.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSh4_ValueChanged(sender As Object, e As EventArgs) Handles nudSh4.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSm4_ValueChanged(sender As Object, e As EventArgs) Handles nudSm4.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudEm4_ValueChanged(sender As Object, e As EventArgs) Handles nudEm4.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudLoss4_ValueChanged(sender As Object, e As EventArgs) Handles nudLoss4.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSh5_ValueChanged(sender As Object, e As EventArgs) Handles nudSh5.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSm5_ValueChanged(sender As Object, e As EventArgs) Handles nudSm5.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudEm5_ValueChanged(sender As Object, e As EventArgs) Handles nudEm5.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudLoss5_ValueChanged(sender As Object, e As EventArgs) Handles nudLoss5.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSh6_ValueChanged(sender As Object, e As EventArgs) Handles nudSh6.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSm6_ValueChanged(sender As Object, e As EventArgs) Handles nudSm6.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudEm6_ValueChanged(sender As Object, e As EventArgs) Handles nudEm6.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudLoss6_ValueChanged(sender As Object, e As EventArgs) Handles nudLoss6.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSh7_ValueChanged(sender As Object, e As EventArgs) Handles nudSh7.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSm7_ValueChanged(sender As Object, e As EventArgs) Handles nudSm7.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudEm7_ValueChanged(sender As Object, e As EventArgs) Handles nudEm7.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudLoss7_ValueChanged(sender As Object, e As EventArgs) Handles nudLoss7.ValueChanged
        nudPropertySetting()
    End Sub


    Private Sub rbtn2han_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn2han.CheckedChanged
        frmMain.Han = 2
        ReDraw()
    End Sub

    Private Sub rbtn3han_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn3han.CheckedChanged
        frmMain.Han = 3
        ReDraw()
    End Sub

End Class