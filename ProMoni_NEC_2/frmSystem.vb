Public Class frmSystem

    Private Sub frmSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSetQu1M1.Text = CStr(frmMain.Qu(0, 0))
        txtSetQu1M2.Text = CStr(frmMain.Qu(0, 1))
        txtSetQu1F1.Text = CStr(frmMain.Qu(0, 2))
        txtSetQu1F2.Text = CStr(frmMain.Qu(0, 3))
        txtSetQu1R.Text = CStr(frmMain.Qu(0, 4))
        txtGeta1M1.Text = CStr(frmMain.Geta(0, 0))
        txtGeta1M2.Text = CStr(frmMain.Geta(0, 1))
        txtGeta1F1.Text = CStr(frmMain.Geta(0, 2))
        txtGeta1F2.Text = CStr(frmMain.Geta(0, 3))
        txtGeta1R.Text = CStr(frmMain.Geta(0, 4))
        txtSumHosei1.Text = CStr(frmMain.DekidakaHosei(0))
        txtGp1A.Text = CStr(frmMain.GpGeta(0, 0))
        txtGp1B.Text = CStr(frmMain.GpGeta(0, 1))
        txtGp1C.Text = CStr(frmMain.GpGeta(0, 2))
        lblGpTotal1A.Text = CStr(frmMain.GpTotal(0, 0))
        lblGpTotal1B.Text = CStr(frmMain.GpTotal(0, 1))
        lblGpTotal1C.Text = CStr(frmMain.GpTotal(0, 2))

        txtSetQu2M1.Text = CStr(frmMain.Qu(1, 0))
        txtSetQu2M2.Text = CStr(frmMain.Qu(1, 1))
        txtSetQu2F1.Text = CStr(frmMain.Qu(1, 2))
        txtSetQu2F2.Text = CStr(frmMain.Qu(1, 3))
        txtSetQu2R.Text = CStr(frmMain.Qu(1, 4))
        txtGeta2M1.Text = CStr(frmMain.Geta(1, 0))
        txtGeta2M2.Text = CStr(frmMain.Geta(1, 1))
        txtGeta2F1.Text = CStr(frmMain.Geta(1, 2))
        txtGeta2F2.Text = CStr(frmMain.Geta(1, 3))
        txtGeta2R.Text = CStr(frmMain.Geta(1, 4))
        txtSumHosei2.Text = CStr(frmMain.DekidakaHosei(1))
        txtGp2A.Text = CStr(frmMain.GpGeta(1, 0))
        txtGp2B.Text = CStr(frmMain.GpGeta(1, 1))
        txtGp2C.Text = CStr(frmMain.GpGeta(1, 2))
        lblGpTotal2A.Text = CStr(frmMain.GpTotal(1, 0))
        lblGpTotal2B.Text = CStr(frmMain.GpTotal(1, 1))
        lblGpTotal2C.Text = CStr(frmMain.GpTotal(1, 2))
        nudScreenTime.Value = CDec((frmMain.timScreenChange.Interval) / 1000)
    End Sub

    Private Sub btnSetPlnOk_Click(sender As Object, e As EventArgs) Handles btnSetPlnOk.Click
        Dim ss(9) As String
        '取数設定
        ss(0) = Trim(txtSetQu1M1.Text)
        ss(1) = Trim(txtSetQu1M2.Text)
        ss(2) = Trim(txtSetQu1F1.Text)
        ss(3) = Trim(txtSetQu1F2.Text)
        ss(4) = Trim(txtSetQu1R.Text)
        ss(5) = Trim(txtSetQu2M1.Text)
        ss(6) = Trim(txtSetQu2M2.Text)
        ss(7) = Trim(txtSetQu2F1.Text)
        ss(8) = Trim(txtSetQu2F2.Text)
        ss(9) = Trim(txtSetQu2R.Text)
        If IsNumeric(ss(0)) And IsNumeric(ss(1)) And IsNumeric(ss(2)) And IsNumeric(ss(3)) And IsNumeric(ss(4)) And _
            IsNumeric(ss(5)) And IsNumeric(ss(6)) And IsNumeric(ss(7)) And IsNumeric(ss(8)) And IsNumeric(ss(9)) Then
            Dim aa(9) As Single
            For i As Integer = 0 To 9
                aa(i) = Math.Abs(CSng(Val(ss(i))))
                If aa(i) <= 0 Or aa(i) >= 10 Then
                    MessageBox.Show("０以上１０未満に設定して下さい")
                    Exit Sub
                End If
            Next i
            frmMain.Qu(0, 0) = CInt(aa(0))
            frmMain.Qu(0, 1) = CInt(aa(1))
            frmMain.Qu(0, 2) = CInt(aa(2))
            frmMain.Qu(0, 3) = CInt(aa(3))
            frmMain.Qu(0, 4) = CInt(aa(4))
            frmMain.Qu(1, 0) = CInt(aa(5))
            frmMain.Qu(1, 1) = CInt(aa(6))
            frmMain.Qu(1, 2) = CInt(aa(7))
            frmMain.Qu(1, 3) = CInt(aa(8))
            frmMain.Qu(1, 4) = CInt(aa(9))
            frmMain.SaveSetting()
        Else
            MessageBox.Show("数値を入力して下さい")
            Exit Sub
        End If
        'ゲタ設定
        ss(0) = Trim(txtGeta1M1.Text)
        ss(1) = Trim(txtGeta1M2.Text)
        ss(2) = Trim(txtGeta1F1.Text)
        ss(3) = Trim(txtGeta1F2.Text)
        ss(4) = Trim(txtGeta1R.Text)
        ss(5) = Trim(txtGeta2M1.Text)
        ss(6) = Trim(txtGeta2M2.Text)
        ss(7) = Trim(txtGeta2F1.Text)
        ss(8) = Trim(txtGeta2F2.Text)
        ss(9) = Trim(txtGeta2R.Text)
        If IsNumeric(ss(0)) And IsNumeric(ss(1)) And IsNumeric(ss(2)) And IsNumeric(ss(3)) And IsNumeric(ss(4)) And _
            IsNumeric(ss(5)) And IsNumeric(ss(6)) And IsNumeric(ss(7)) And IsNumeric(ss(8)) And IsNumeric(ss(9)) Then
            Dim aa(9) As Single
            For i As Integer = 0 To 9
                aa(i) = Math.Abs(CSng(Val(ss(i))))
                If aa(i) > 1000000 Then
                    MessageBox.Show("１,０００,０００未満に設定して下さい")
                    Exit Sub
                End If
            Next i
            frmMain.Geta(0, 0) = CInt(ss(0))
            frmMain.Geta(0, 1) = CInt(ss(1))
            frmMain.Geta(0, 2) = CInt(ss(2))
            frmMain.Geta(0, 3) = CInt(ss(3))
            frmMain.Geta(0, 4) = CInt(ss(4))
            frmMain.Geta(1, 0) = CInt(ss(5))
            frmMain.Geta(1, 1) = CInt(ss(6))
            frmMain.Geta(1, 2) = CInt(ss(7))
            frmMain.Geta(1, 3) = CInt(ss(8))
            frmMain.Geta(1, 4) = CInt(ss(9))
        Else
            MessageBox.Show("数値を入力して下さい")
            Exit Sub
        End If
        '累計補正設定
        ss(0) = Trim(txtSumHosei1.Text)
        ss(1) = Trim(txtSumHosei2.Text)
        If IsNumeric(ss(0)) And IsNumeric(ss(1)) Then
            For i As Integer = 0 To 1
                If Math.Abs(CSng(Val(ss(i)))) >= 10000000 Then
                    MessageBox.Show("１０,０００,０００未満に設定して下さい")
                    Exit Sub
                End If
            Next i
            frmMain.DekidakaHosei(0) = CInt(ss(0))
            frmMain.DekidakaHosei(1) = CInt(ss(1))
        Else
            MessageBox.Show("数値を入力して下さい")
            Exit Sub
        End If
        '班別累計
        ss(0) = Trim(txtGp1A.Text)
        ss(1) = Trim(txtGp1B.Text)
        ss(2) = Trim(txtGp1C.Text)
        ss(3) = Trim(txtGp2A.Text)
        ss(4) = Trim(txtGp2B.Text)
        ss(5) = Trim(txtGp2C.Text)
        'frmMain.dsf = False
        If IsNumeric(ss(0)) And IsNumeric(ss(1)) And IsNumeric(ss(2)) And IsNumeric(ss(3)) And IsNumeric(ss(4)) And IsNumeric(ss(5)) Then
            Dim aa(5) As Single
            For i As Integer = 0 To 5
                aa(i) = Math.Abs(CSng(Val(ss(i))))
                If aa(i) > 50000 Then
                    MessageBox.Show("５０,０００未満に設定して下さい")
                    Exit Sub
                End If
            Next i
            frmMain.GpGeta(0, 0) = CInt(ss(0))
            frmMain.GpGeta(0, 1) = CInt(ss(1))
            frmMain.GpGeta(0, 2) = CInt(ss(2))
            frmMain.GpGeta(1, 0) = CInt(ss(3))
            frmMain.GpGeta(1, 1) = CInt(ss(4))
            frmMain.GpGeta(1, 2) = CInt(ss(5))
        Else
            MessageBox.Show("数値を入力して下さい")
            Exit Sub
        End If
        frmMain.timScreenChange.Interval = CInt(nudScreenTime.Value) * 1000
        For i As Short = 0 To 10
            frmMain.ReDrawFlag(i) = True
        Next i
    End Sub

    Private Sub btnSetPlnCancel_Click(sender As Object, e As EventArgs) Handles btnSetPlnCancel.Click
        'Me.Hide()
        Me.Close()
    End Sub

End Class