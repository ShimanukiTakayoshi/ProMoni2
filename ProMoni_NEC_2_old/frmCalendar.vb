﻿Public Class frmCalendar

    Private Sub frmCalendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCal.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvCal.Columns.Add("0", "直")
        For i As Short = 1 To 31
            dgvCal.Columns.Add(Str(i), Trim(Str(i)))
        Next i
        dgvCal.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        For i As Integer = 0 To 31
            dgvCal.Columns(i).Width = 30
        Next
        dgvCal.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvCal.RowHeadersVisible = False
        dgvCal.Rows.Add("日勤")
        dgvCal.Rows.Add("夜勤")
        dgvCal.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvCal.Columns(0).Width = 60
        dgvCal.Columns(0).ReadOnly = True
        dgvCal.Columns(0).Frozen = True
        DrawCal()
    End Sub

    Private Sub btnCalSet_Click(sender As Object, e As EventArgs) Handles btnCalSet.Click
        Dim sx As String
        Dim zx As String
        Dim KinmuTmp(1) As String
        For i As Short = 0 To 1
            For j As Short = 1 To 31
                zx = CStr(dgvCal.Item(j, i).Value)
                Select Case zx
                    Case "A", "a"
                        sx = "1"
                    Case "B", "b"
                        sx = "2"
                    Case "C", "c"
                        sx = "3"
                    Case Else
                        sx = "0"
                End Select
                KinmuTmp(i) = KinmuTmp(i) + sx
            Next
        Next
        frmMain.KinmuData(1) = KinmuTmp(0)
        frmMain.KinmuData(2) = KinmuTmp(1)
        DrawCal()
    End Sub

    Public Sub DrawCal()
        Dim kx As Integer
        Dim sx As String
        For i As Short = 0 To 1
            For j As Short = 1 To 31
                kx = CInt(Val(Strings.Mid(frmMain.KinmuData(i + 1), j, 1)))
                Select Case kx
                    Case 1
                        sx = "A"
                    Case 2
                        sx = "B"
                    Case 3
                        sx = "C"
                    Case Else
                        sx = ""
                End Select
                dgvCal.Item(j, i).Value = sx
            Next
        Next
    End Sub

    Private Sub btnCalClose_Click(sender As Object, e As EventArgs) Handles btnCalClose.Click
        frmMain.SaveKinmu()
        Me.Hide()
    End Sub

End Class