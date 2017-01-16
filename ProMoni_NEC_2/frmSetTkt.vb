Public Class frmSetTkt

    Private Sub frmSetTkt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSetTkt1M1.Text = CStr(frmMain.Tkt(0, 0))
        txtSetTkt1M2.Text = CStr(frmMain.Tkt(0, 1))
        txtSetTkt1F1.Text = CStr(frmMain.Tkt(0, 2))
        txtSetTkt1F2.Text = CStr(frmMain.Tkt(0, 3))
        txtSetTkt1R.Text = CStr(frmMain.Tkt(0, 4))
        txtSetTkt2M1.Text = CStr(frmMain.Tkt(1, 0))
        txtSetTkt2M2.Text = CStr(frmMain.Tkt(1, 1))
        txtSetTkt2F1.Text = CStr(frmMain.Tkt(1, 2))
        txtSetTkt2F2.Text = CStr(frmMain.Tkt(1, 3))
        txtSetTkt2R.Text = CStr(frmMain.Tkt(1, 4))
    End Sub

    Private Sub btnTktPlnOk_Click(sender As Object, e As EventArgs) Handles btnTktPlnOk.Click
        Dim ss(9) As String
        ss(0) = Trim(txtSetTkt1M1.Text)
        ss(1) = Trim(txtSetTkt1M2.Text)
        ss(2) = Trim(txtSetTkt1F1.Text)
        ss(3) = Trim(txtSetTkt1F2.Text)
        ss(4) = Trim(txtSetTkt1R.Text)
        ss(5) = Trim(txtSetTkt2M1.Text)
        ss(6) = Trim(txtSetTkt2M2.Text)
        ss(7) = Trim(txtSetTkt2F1.Text)
        ss(8) = Trim(txtSetTkt2F2.Text)
        ss(9) = Trim(txtSetTkt2R.Text)
        If IsNumeric(ss(0)) And IsNumeric(ss(1)) And IsNumeric(ss(2)) And IsNumeric(ss(3)) And IsNumeric(ss(4)) And _
            IsNumeric(ss(5)) And IsNumeric(ss(6)) And IsNumeric(ss(7)) And IsNumeric(ss(8)) And IsNumeric(ss(9)) Then
            Dim aa(9) As Single
            For i As Integer = 0 To 9
                aa(i) = Math.Abs(CSng(Val(ss(i))))
                If aa(i) <= 0 Or aa(i) >= 10 Then
                    MessageBox.Show("０秒以上１０秒未満に設定して下さい")
                    Exit Sub
                End If
            Next i
            frmMain.Tkt(0, 0) = aa(0)
            frmMain.Tkt(0, 1) = aa(1)
            frmMain.Tkt(0, 2) = aa(2)
            frmMain.Tkt(0, 3) = aa(3)
            frmMain.Tkt(0, 4) = aa(4)
            frmMain.Tkt(1, 0) = aa(5)
            frmMain.Tkt(1, 1) = aa(6)
            frmMain.Tkt(1, 2) = aa(7)
            frmMain.Tkt(1, 3) = aa(8)
            frmMain.Tkt(1, 4) = aa(9)
            frmMain.SaveSetting()
        Else
            MessageBox.Show("数値を入力して下さい")
            Exit Sub
        End If
    End Sub

    Private Sub btnSetTktCancel_Click(sender As Object, e As EventArgs) Handles btnSetTktCancel.Click
        Me.Hide()
    End Sub

End Class