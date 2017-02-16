Public Class frmWorkTime
    Dim WtFirstFlag As Boolean = True
    Dim WtSetNGFlag As Boolean = False

    Private Sub frmWorkTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer = frmMain.WtSh2(1)

        x = x
        WtFirstFlag = True
        WtSetNGFlag = False
        'ライン１
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

        nudTh1.Value = frmMain.Start1H
        nudTh2.Value = frmMain.Start2H
        nudTh3.Value = frmMain.End2H
        nudTm1.Value = frmMain.Start1M
        nudTm2.Value = frmMain.Start2M
        nudTm3.Value = frmMain.End2M

        'ライン２
        nudSh12.Value = frmMain.WtSh2(1)
        nudSh22.Value = frmMain.WtSh2(2)
        nudSh32.Value = frmMain.WtSh2(3)
        nudSh42.Value = frmMain.WtSh2(4)
        nudSh52.Value = frmMain.WtSh2(5)
        nudSh62.Value = frmMain.WtSh2(6)
        nudsh72.Value = frmMain.WtSh2(7)

        nudSm12.Value = frmMain.WtSm2(1)
        nudSm22.Value = frmMain.WtSm2(2)
        nudSm32.Value = frmMain.WtSm2(3)
        nudSm42.Value = frmMain.WtSm2(4)
        nudSm52.Value = frmMain.WtSm2(5)
        nudSm62.Value = frmMain.WtSm2(6)
        nudSm72.Value = frmMain.WtSm2(7)

        nudEm12.Value = frmMain.WtEm2(1)
        nudEm22.Value = frmMain.WtEm2(2)
        nudEm32.Value = frmMain.WtEm2(3)
        nudEm42.Value = frmMain.WtEm2(4)
        nudEm52.Value = frmMain.WtEm2(5)
        nudEm62.Value = frmMain.WtEm2(6)
        nudEm72.Value = frmMain.WtEm2(7)

        nudLoss12.Value = frmMain.WtLosR2(1)
        nudLoss22.Value = frmMain.WtLosR2(2)
        nudLoss32.Value = frmMain.WtLosR2(3)
        nudLoss42.Value = frmMain.WtLosR2(4)
        nudLoss52.Value = frmMain.WtLosR2(5)
        nudLoss62.Value = frmMain.WtLosR2(6)
        nudLoss72.Value = frmMain.WtLosR2(7)

        lblStopTimeJ12.Text = Str(frmMain.WtLosTime2(1))
        lblStopTimeJ22.Text = Str(frmMain.WtLosTime2(2))
        lblStopTimeJ32.Text = Str(frmMain.WtLosTime2(3))
        lblStopTimeJ42.Text = Str(frmMain.WtLosTime2(4))
        lblStopTimeJ52.Text = Str(frmMain.WtLosTime2(5))
        lblStopTimeJ62.Text = Str(frmMain.WtLosTime2(6))
        lblStopTimeJ72.Text = Str(frmMain.WtLosTime2(7))

        nudTh12.Value = frmMain.Start1H2
        nudTh22.Value = frmMain.Start2H2
        nudTh32.Value = frmMain.End2H2
        nudTm12.Value = frmMain.Start1M2
        nudTm22.Value = frmMain.Start2M2
        nudTm32.Value = frmMain.End2M2

        'ライン１
        Select Case frmMain.Han
            Case 2
                rbtn2han.Checked = True
            Case Else
                rbtn3han.Checked = True
        End Select
        'ライン２
        Select Case frmMain.Han2
            Case 2
                rbtn2han2.Checked = True
            Case Else
                rbtn3han2.Checked = True
        End Select
        Select Case frmMain.L2choku1Nomi
            Case 0
                cbxChoku1Nomi.Checked = False
            Case Else
                cbxChoku1Nomi.Checked = True
        End Select
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
            'ライン１
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
                If StSecE(i) > StSecE(i + 1) Then
                    If MsgBox("｢停止時間｣の設定値が前後しています。", CType(vbOKCancel + vbExclamation, MsgBoxStyle)) = vbOK Then
                        WtSetNGFlag = True
                        Exit Sub
                    End If
                End If
            Next
            'ライン２
            Dim StSecS2(7) As Long
            Dim StSecE2(7) As Long
            WtSetNGFlag = False
            '設定時間を「秒」に換算
            StSecS2(1) = CLng(nudSh12.Value * 3600 + nudSm12.Value * 60)
            StSecS2(2) = CLng(nudSh22.Value * 3600 + nudSm22.Value * 60)
            StSecS2(3) = CLng(nudSh32.Value * 3600 + nudSm32.Value * 60)
            StSecS2(4) = CLng(nudSh42.Value * 3600 + nudSm42.Value * 60)
            StSecS2(5) = CLng(nudSh52.Value * 3600 + nudSm52.Value * 60)
            StSecS2(6) = CLng(nudSh62.Value * 3600 + nudSm62.Value * 60)
            StSecS2(7) = CLng(nudsh72.Value * 3600 + nudSm72.Value * 60)
            StSecE2(1) = CLng(StSecS(1) + nudEm12.Value * 60)
            StSecE2(2) = CLng(StSecS(2) + nudEm22.Value * 60)
            StSecE2(3) = CLng(StSecS(3) + nudEm32.Value * 60)
            StSecE2(4) = CLng(StSecS(4) + nudEm42.Value * 60)
            StSecE2(5) = CLng(StSecS(5) + nudEm52.Value * 60)
            StSecE2(6) = CLng(StSecS(6) + nudEm62.Value * 60)
            StSecE2(7) = CLng(StSecS(7) + nudEm72.Value * 60)
            For i As Short = 1 To 6
                If StSecS2(i) > StSecS2(i + 1) Then
                    If MsgBox("｢ライン停止時間｣の設定値が前後しています。", CType(vbOKCancel + vbExclamation, MsgBoxStyle)) = vbOK Then
                        WtSetNGFlag = True
                        Exit Sub
                    End If
                End If
            Next
            For i As Short = 1 To 6
                If StSecE2(i) > StSecE2(i + 1) Then
                    If MsgBox("｢停止時間｣の設定値が前後しています。", CType(vbOKCancel + vbExclamation, MsgBoxStyle)) = vbOK Then
                        WtSetNGFlag = True
                        Exit Sub
                    End If
                End If
            Next
            ReDraw()
        End If
    End Sub

    Public Sub ReDraw()
        'ライン１
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

        'ライン２
        frmMain.WtSh2(1) = CInt(nudSh12.Value)
        frmMain.WtSh2(2) = CInt(nudSh22.Value)
        frmMain.WtSh2(3) = CInt(nudSh32.Value)
        frmMain.WtSh2(4) = CInt(nudSh42.Value)
        frmMain.WtSh2(5) = CInt(nudSh52.Value)
        frmMain.WtSh2(6) = CInt(nudSh62.Value)
        frmMain.WtSh2(7) = CInt(nudsh72.Value)
        frmMain.WtSm2(1) = CInt(nudSm12.Value)
        frmMain.WtSm2(2) = CInt(nudSm22.Value)
        frmMain.WtSm2(3) = CInt(nudSm32.Value)
        frmMain.WtSm2(4) = CInt(nudSm42.Value)
        frmMain.WtSm2(5) = CInt(nudSm52.Value)
        frmMain.WtSm2(6) = CInt(nudSm62.Value)
        frmMain.WtSm2(7) = CInt(nudSm72.Value)
        frmMain.WtEm2(1) = CInt(nudEm12.Value)
        frmMain.WtEm2(2) = CInt(nudEm22.Value)
        frmMain.WtEm2(3) = CInt(nudEm32.Value)
        frmMain.WtEm2(4) = CInt(nudEm42.Value)
        frmMain.WtEm2(5) = CInt(nudEm52.Value)
        frmMain.WtEm2(6) = CInt(nudEm62.Value)
        frmMain.WtEm2(7) = CInt(nudEm72.Value)
        frmMain.WtLosR2(1) = CInt(nudLoss12.Value)
        frmMain.WtLosR2(2) = CInt(nudLoss22.Value)
        frmMain.WtLosR2(3) = CInt(nudLoss32.Value)
        frmMain.WtLosR2(4) = CInt(nudLoss42.Value)
        frmMain.WtLosR2(5) = CInt(nudLoss52.Value)
        frmMain.WtLosR2(6) = CInt(nudLoss62.Value)
        frmMain.WtLosR2(7) = CInt(nudLoss72.Value)

        frmMain.Start1H2 = CInt(nudTh12.Value)
        frmMain.Start2H2 = CInt(nudTh22.Value)
        frmMain.End2H2 = CInt(nudTh32.Value)
        frmMain.Start1M2 = CInt(nudTm12.Value)
        frmMain.Start2M2 = CInt(nudTm22.Value)
        frmMain.End2M2 = CInt(nudTm32.Value)

        For i As Short = 1 To 7
            frmMain.WtLosTime2(i) = CInt(frmMain.WtEm2(i) * (frmMain.WtLosR2(i) / 100))
        Next
        lblStopTimeJ12.Text = Str(frmMain.WtLosTime2(1))
        lblStopTimeJ22.Text = Str(frmMain.WtLosTime2(2))
        lblStopTimeJ32.Text = Str(frmMain.WtLosTime2(3))
        lblStopTimeJ42.Text = Str(frmMain.WtLosTime2(4))
        lblStopTimeJ52.Text = Str(frmMain.WtLosTime2(5))
        lblStopTimeJ62.Text = Str(frmMain.WtLosTime2(6))
        lblStopTimeJ72.Text = Str(frmMain.WtLosTime2(7))

        Select Case frmMain.Han2
            Case 2
                Label60.Visible = True
                Label62.Visible = True
                Label63.Visible = True
                Label64.Visible = True
                Label65.Visible = True
                Label66.Visible = True
                Label67.Visible = True
                Label68.Visible = True
                nudTh12.Visible = True
                nudTh22.Visible = True
                nudTh32.Visible = True
                nudTm12.Visible = True
                nudTm22.Visible = True
                nudTm32.Visible = True
                Label99.Visible = False
                Label92.Visible = False
                Label85.Visible = False
                lblStopTimeJ72.Visible = False
                nudsh72.Visible = False
                nudSm72.Visible = False
                nudEm72.Visible = False
                nudLoss72.Visible = False
                Label97.Text = "1直休憩"
                frmMain.Cth2 = CInt(CLng(frmMain.End2H2))
                frmMain.Ctm2 = CInt(CLng(frmMain.End2M2))
                frmMain.Rth2 = CInt(CLng(frmMain.Start2H2))
                frmMain.Rtm2 = CInt(CLng(frmMain.Start2M2))
            Case Else
                Label60.Visible = False
                Label62.Visible = False
                Label63.Visible = False
                Label64.Visible = False
                Label65.Visible = False
                Label66.Visible = False
                Label67.Visible = False
                Label68.Visible = False
                nudTh12.Visible = False
                nudTh22.Visible = False
                nudTh32.Visible = False
                nudTm12.Visible = False
                nudTm22.Visible = False
                nudTm32.Visible = False
                Label99.Visible = True
                Label92.Visible = True
                Label85.Visible = True
                lblStopTimeJ72.Visible = True
                nudsh72.Visible = True
                nudSm72.Visible = True
                nudEm72.Visible = True
                nudLoss72.Visible = True
                Label97.Text = "1直夕礼･休憩"
                frmMain.Cth2 = 7
                frmMain.Ctm2 = 45
                frmMain.Rth2 = 20
                frmMain.Rtm2 = 0
        End Select
    End Sub

    Private Sub btnWorkTimeOk_Click(sender As Object, e As EventArgs) Handles btnWorkTimeOk.Click
        nudPropertySetting()
        If WtSetNGFlag = False Then
            ReDraw()
            frmMain.SaveSetting()
            frmMain.WorkTimeCalc()
        End If
    End Sub

    Private Sub btnWorkTimeCancel_Click(sender As Object, e As EventArgs) Handles btnWorkTimeCancel.Click
        nudPropertySetting()
        If WtSetNGFlag = False Then
            Me.Hide()
        End If
    End Sub

    Private Sub nudSh12_ValueChanged(sender As Object, e As EventArgs) Handles nudSh12.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSm12_ValueChanged(sender As Object, e As EventArgs) Handles nudSm12.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudEm12_ValueChanged(sender As Object, e As EventArgs) Handles nudEm12.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudLoss12_ValueChanged(sender As Object, e As EventArgs) Handles nudLoss12.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSh22_ValueChanged(sender As Object, e As EventArgs) Handles nudSh22.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSm22_ValueChanged(sender As Object, e As EventArgs) Handles nudSm22.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudEm22_ValueChanged(sender As Object, e As EventArgs) Handles nudEm22.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudLoss22_ValueChanged(sender As Object, e As EventArgs) Handles nudLoss22.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSh32_ValueChanged(sender As Object, e As EventArgs) Handles nudSh32.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSm32_ValueChanged(sender As Object, e As EventArgs) Handles nudSm32.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudEm32_ValueChanged(sender As Object, e As EventArgs) Handles nudEm32.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudLoss32_ValueChanged(sender As Object, e As EventArgs) Handles nudLoss32.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSh42_ValueChanged(sender As Object, e As EventArgs) Handles nudSh42.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSm42_ValueChanged(sender As Object, e As EventArgs) Handles nudSm42.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudEm42_ValueChanged(sender As Object, e As EventArgs) Handles nudEm42.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudLoss42_ValueChanged(sender As Object, e As EventArgs) Handles nudLoss42.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSh52_ValueChanged(sender As Object, e As EventArgs) Handles nudSh52.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSm52_ValueChanged(sender As Object, e As EventArgs) Handles nudSm52.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudEm52_ValueChanged(sender As Object, e As EventArgs) Handles nudEm52.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudLoss52_ValueChanged(sender As Object, e As EventArgs) Handles nudLoss52.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSh62_ValueChanged(sender As Object, e As EventArgs) Handles nudSh62.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSm62_ValueChanged(sender As Object, e As EventArgs) Handles nudSm62.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudEm62_ValueChanged(sender As Object, e As EventArgs) Handles nudEm62.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudLoss62_ValueChanged(sender As Object, e As EventArgs) Handles nudLoss62.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSh72_ValueChanged(sender As Object, e As EventArgs) Handles nudsh72.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudSm72_ValueChanged(sender As Object, e As EventArgs) Handles nudSm72.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudEm72_ValueChanged(sender As Object, e As EventArgs) Handles nudEm72.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub nudLoss72_ValueChanged(sender As Object, e As EventArgs) Handles nudLoss72.ValueChanged
        nudPropertySetting()
    End Sub

    Private Sub rbtn2han2_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn2han2.CheckedChanged
        frmMain.Han2 = 2
        ReDraw()
    End Sub

    Private Sub rbtn3han2_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn3han2.CheckedChanged
        frmMain.Han2 = 3
        ReDraw()
    End Sub

    Private Sub cbxChoku1Nomi_CheckedChanged(sender As Object, e As EventArgs) Handles cbxChoku1Nomi.CheckedChanged
        If cbxChoku1Nomi.Checked = False Then
            frmMain.L2choku1Nomi = 0
        Else
            frmMain.L2choku1Nomi = 1
        End If
    End Sub
End Class