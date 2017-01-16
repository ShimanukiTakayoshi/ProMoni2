Public Class frmSetPln

    Private Sub frmSetPln_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSetPln1M1.Text = CStr(frmMain.Pln(0, 0))
        txtSetPln1M2.Text = CStr(frmMain.Pln(0, 1))
        txtSetPln1F1.Text = CStr(frmMain.Pln(0, 2))
        txtSetPln1F2.Text = CStr(frmMain.Pln(0, 3))
        txtSetPln1R.Text = CStr(frmMain.Pln(0, 4))
        txtSetPln2M1.Text = CStr(frmMain.Pln(1, 0))
        txtSetPln2M2.Text = CStr(frmMain.Pln(1, 1))
        txtSetPln2F1.Text = CStr(frmMain.Pln(1, 2))
        txtSetPln2F2.Text = CStr(frmMain.Pln(1, 3))
        txtSetPln2R.Text = CStr(frmMain.Pln(1, 4))
    End Sub

    Private Sub btnSetPlnOk_Click(sender As Object, e As EventArgs) Handles btnSetPlnOk.Click
        Dim ss(9) As String
        ss(0) = Trim(txtSetPln1M1.Text)
        ss(1) = Trim(txtSetPln1M2.Text)
        ss(2) = Trim(txtSetPln1F1.Text)
        ss(3) = Trim(txtSetPln1F2.Text)
        ss(4) = Trim(txtSetPln1R.Text)
        ss(5) = Trim(txtSetPln2M1.Text)
        ss(6) = Trim(txtSetPln2M2.Text)
        ss(7) = Trim(txtSetPln2F1.Text)
        ss(8) = Trim(txtSetPln2F2.Text)
        ss(9) = Trim(txtSetPln2R.Text)
        If IsNumeric(ss(0)) And IsNumeric(ss(1)) And IsNumeric(ss(2)) And IsNumeric(ss(3)) And IsNumeric(ss(4)) And _
            IsNumeric(ss(5)) And IsNumeric(ss(6)) And IsNumeric(ss(7)) And IsNumeric(ss(8)) And IsNumeric(ss(9)) Then
            Dim aa(9) As Integer
            For i As Integer = 0 To 9
                aa(i) = Math.Abs(CInt(Val(ss(i))))
                If aa(i) > 99999 Then
                    MessageBox.Show("１０万個以下に設定して下さい")
                    Exit Sub
                End If
            Next i
            frmMain.Pln(0, 0) = aa(0)
            frmMain.Pln(0, 1) = aa(1)
            frmMain.Pln(0, 2) = aa(2)
            frmMain.Pln(0, 3) = aa(3)
            frmMain.Pln(0, 4) = aa(4)
            frmMain.Pln(1, 0) = aa(5)
            frmMain.Pln(1, 1) = aa(6)
            frmMain.Pln(1, 2) = aa(7)
            frmMain.Pln(1, 3) = aa(8)
            frmMain.Pln(1, 4) = aa(9)
            frmMain.SaveSetting()
        Else
            MessageBox.Show("数値を入力して下さい")
            Exit Sub
        End If
    End Sub

    Private Sub btnSetPlnCancel_Click(sender As Object, e As EventArgs) Handles btnSetPlnCancel.Click
        Me.Hide()
    End Sub
End Class