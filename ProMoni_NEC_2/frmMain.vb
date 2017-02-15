Public Class frmMain

    Public AppFolder As String = "c:\ProMoni_EM_2"      'アプリケーションフォルダ
    Public SystemFolder As String = "\0System"          'システムファイルフォルダ
    Public TmpFolder As String = "\0Tmp"                'システムファイルフォルダ
    Public DataFolder As String = "\Data"               'データフォルダ
    Public DekidakaFolder As String = "\Dekidaka"       '出来高フォルダ
    Public CaptureFolder As String = "\Capture"         'キャプチャーフォルダ
    Public ShinchokuFolder As String = "\Shinchoku"     '進捗フォルダ

    Public ScreenSelect As Short = 1                    '表示スクリーン選択
    Public Ln As Short = 0                              '製造ライン番号
    Public DualMode As Boolean = False                  '２画面モード縦
    Public HoriMode As Boolean = False                  '２画面モード横
    Public EmExMode As Boolean = False                  'EM:False / EX:True
    Public ModelName As String = ""                     '表示機種名


    Public Pln(1, 4) As Integer            '目標生産数
    Public Trg(1, 4) As Integer            '現在計画数
    Public NowC(1, 6) As Integer           '現在生産数
    'Public NonAdj(2) As String          '直行率
    Public Tkt(1, 4) As Single             '設定ﾀｸﾄﾀｲﾑ
    Public Trr(1, 4) As Integer            '稼働率100%時生産数
    Public Qu(1, 4) As Integer             '取り数（出力信号1ﾊﾟﾙｽ当りの生産数）
    Public Geta(1, 4) As Integer           '現在生産数補正値
    Public GpData(1, 2) As Integer           '班別データ（実績保存用）
    Public GpData2(1, 2) As Integer          '班別データ（実績保存用）

    Public WtSh(7) As Integer           'ﾗｲﾝ停止開始時間(H)
    Public WtSm(7) As Integer           'ﾗｲﾝ停止開始時間(M)
    Public WtEh(7) As Integer           'ﾗｲﾝ停止時間(H)
    Public WtEm(7) As Integer           'ﾗｲﾝ停止時間(M)
    Public WtLosR(7) As Integer         'ﾗｲﾝ停止ﾛｽ率
    Public WtLosTime(7) As Integer      'ﾗｲﾝ停止実質時間(M)
    Public WtS(7) As Integer            'ﾜｰｸﾀｲﾑ計算用1
    Public WtE(7) As Integer            'ﾜｰｸﾀｲﾑ計算用2
    Public WtPi(14) As Integer          'ﾜｰｸﾀｲﾑ計算用3
    Public WtBt(14) As Integer          'ﾜｰｸﾀｲﾑ計算用4

    Public WtSh2(7) As Integer           'ﾗｲﾝ停止開始時間(H)
    Public WtSm2(7) As Integer           'ﾗｲﾝ停止開始時間(M)
    Public WtEh2(7) As Integer           'ﾗｲﾝ停止時間(H)
    Public WtEm2(7) As Integer           'ﾗｲﾝ停止時間(M)
    Public WtLosR2(7) As Integer         'ﾗｲﾝ停止ﾛｽ率
    Public WtLosTime2(7) As Integer      'ﾗｲﾝ停止実質時間(M)
    Public WtS2(7) As Integer            'ﾜｰｸﾀｲﾑ計算用1
    Public WtE2(7) As Integer            'ﾜｰｸﾀｲﾑ計算用2
    Public WtPi2(14) As Integer          'ﾜｰｸﾀｲﾑ計算用3
    Public WtBt2(14) As Integer          'ﾜｰｸﾀｲﾑ計算用4

    Public Wt1Choku As Integer = 44100     '1直稼動時間(秒)7:45-20:00
    Public Wt2Choku As Integer = 42300     '2直稼動時間(秒)20:00-7:45
    Public Wt1Jisshitu As Integer = 0      '1実質稼働時間(秒) 休憩等の時間を差し引いた時間
    Public Wt2jisshitu As Integer = 0      '2実質稼働時間(秒) 休憩等の時間を差し引いた時間
    Public Wt1Choku2 As Integer = 44100     '1直稼動時間(秒)7:45-20:00
    Public Wt2Choku2 As Integer = 42300     '2直稼動時間(秒)20:00-7:45
    Public Wt1Jisshitu2 As Integer = 0      '1実質稼働時間(秒) 休憩等の時間を差し引いた時間
    Public Wt2jisshitu2 As Integer = 0      '2実質稼働時間(秒) 休憩等の時間を差し引いた時間

    Public Cth As Integer                  '自動ｶｳﾝﾀｸﾘｱ時間(h)
    Public Ctm As Integer                  '自動ｶｳﾝﾀｸﾘｱ時間(m)
    Public Cth2 As Integer                  '自動ｶｳﾝﾀｸﾘｱ時間(h)
    Public Ctm2 As Integer                  '自動ｶｳﾝﾀｸﾘｱ時間(m)
    Public Rth As Integer                  '最描写時間(h)
    Public Rtm As Integer                  '最描写時間(m)
    Public Rth2 As Integer                  '最描写時間(h)
    Public Rtm2 As Integer                  '最描写時間(m)

    Public SvFileName As String = ""       '実績ﾃﾞｰﾀ保存ﾌｧｲﾙ名
    Public SvBkFileName As String = ""     '実績ﾃﾞｰﾀ保存ﾌｧｲﾙ名(ﾊﾞｯｸｱｯﾌﾟ)

    Public ChokuChangeFlag As Boolean = False       '直切換ﾌﾗｸﾞ

    Public ChokuFlag As Boolean = False     '直ﾌﾗｸﾞ
    Public ChokuData1(1, 4) As Integer         '1直実績数
    Public ChokuData2(1, 4) As Integer         '2直実績数
    Public ChokuDataTrg1(1, 4) As Integer      '1直計画数
    Public ChokuDataTrg2(1, 4) As Integer      '2直計画数
    Public DekidakaDay(1) As Integer           '1直出来高
    Public DekidakaAll(1) As Integer           '合計出来高
    Public DekidakaDataDay(1, 31) As Integer   '1直各日出来高
    Public DekidakaDataDay2(1, 31) As Integer   '1直各日出来高
    Public DekidakaDataNight(1, 31) As Integer '2直各日出来高
    Public DekidakaDataNight2(1, 31) As Integer   '1直各日出来高
    Public DekidakaTotal(1) As Integer         '月度出来高
    Public DekidakaHosei(1) As Integer         '月度出来高補正値

    Public MemNowCh1(1, 4) As String           '一時保存用実績ﾃﾞｰﾀ
    Public DebugMode As Boolean = True      'ﾃﾞﾊﾞｯｸﾞﾓｰﾄﾞ切換ﾌﾗｸﾞ

    Public Gp(2) As Integer                 '班別実績数
    Public Gp2(2) As Integer                 '班別実績数
    Public GpTotal(1, 2) As Integer            '班別累計数
    Public GpTotal2(1, 2) As Integer            '班別累計数
    Public GpGeta(1, 2) As Integer             '班別累計数補正値
    Public GpGeta2(1, 2) As Integer             '班別累計数補正値
    Public GpChoku(2) As Integer            '班別可動日数ｶｳﾝﾄ
    Public GpChoku2(2) As Integer            '班別可動日数ｶｳﾝﾄ
    Public KinmuData(4) As String           '勤務ｶﾚﾝﾀﾞｰ
    Public Han As Integer = 2               '班編成数
    Public Han2 As Integer = 2               '班編成数
    Public L2choku1Nomi As Integer
    Public ProPause As Boolean = False      '2直終了後動作一時停止ﾌﾗｸﾞ
    Public Start1H As Integer               '1直開始(時間)
    Public Start1M As Integer               '1直開始(分)
    Public Start2H As Integer               '2直開始(時間)
    Public Start2M As Integer               '2直開始(分)
    Public End2H As Integer                 '2直終了(時間)
    Public End2M As Integer                 '2直終了(分)
    Public Start1H2 As Integer               '1直開始(時間)
    Public Start1M2 As Integer               '1直開始(分)
    Public Start2H2 As Integer               '2直開始(時間)
    Public Start2M2 As Integer               '2直開始(分)
    Public End2H2 As Integer                 '2直終了(時間)
    Public End2M2 As Integer                 '2直終了(分)

    Dim WrPlnA(1, 4) As Integer                '表示用_目標生産数(合計)
    Dim WrPlnB(1, 4) As Integer                '表示用_目標生産数(直)
    Dim WrTrgA(1, 4) As Integer                '表示用_計画数(合計)
    Dim WrTrgB(1, 4) As Integer                '表示用_計画数(1直)
    Dim WrTrgC(1, 4) As Integer                '表示用_計画数(2直)
    Dim WrCntA(1, 4) As Integer                '表示用_実績数(合計)
    Dim WrCntB(1, 4) As Integer                '表示用_実績数(1直)
    Dim WrCntC(1, 4) As Integer                '表示用_実績数(2直)
    Dim WrDelA(1, 4) As Integer                '表示用_差(合計)
    Dim WrDelB(1, 4) As Integer                '表示用_差(1直)
    Dim WrDelC(1, 4) As Integer                '表示用_差(2直)
    Dim WrRat(1, 2) As Integer                 '表示用_稼働率
    Dim WrCho(1, 2) As Single                  '表示用_直行率

    Public IO(99) As Byte

    '---グラフィック用---
    Public gf12 As New Font("ＭＳゴシック", 12, FontStyle.Bold)
    Public gf18 As New Font("ＭＳゴシック", 18, FontStyle.Bold)
    Public gf20 As New Font("ＭＳゴシック", 20, FontStyle.Bold)
    Public gf24 As New Font("ＭＳゴシック", 24, FontStyle.Bold)
    Public gf26 As New Font("ＭＳゴシック", 26, FontStyle.Bold)
    Public gf28 As New Font("ＭＳゴシック", 28, FontStyle.Bold)
    Public gf30 As New Font("ＭＳゴシック", 30, FontStyle.Bold)
    Public gf32 As New Font("ＭＳゴシック", 32, FontStyle.Bold)
    Public gf40 As New Font("ＭＳゴシック", 40, FontStyle.Bold)
    Public gf48 As New Font("ＭＳゴシック", 48, FontStyle.Bold)
    Public gf72 As New Font("ＭＳゴシック", 72, FontStyle.Bold)
    Public gcBlack As New SolidBrush(Color.Black)
    Public gcBlue As New SolidBrush(Color.Blue)
    Public gcWhite As New SolidBrush(Color.White)
    Public gcRed As New SolidBrush(Color.Red)
    Public gcDarkGreen As New SolidBrush(Color.DarkGreen)
    Public gcYellow As New SolidBrush(Color.Yellow)
    Public gcDeepPink As New SolidBrush(Color.DeepPink)
    Public Pen1 As Pen = New Pen(Color.Black, 1)
    Public Pen3 As Pen = New Pen(Color.Black, 3)
    Public Pen3r As Pen = New Pen(Color.Red, 3)

    Public SaveDataFirstFlag As Boolean = True
    Public SaveSubFolder As String
    Public SaveFileName As String
    Public SaveTimeH As String = "8"       'データ保存ファイル切替時間(H)
    Public SaveTimeM As String = "0"      'データ保存ファイル切替時間(M)
    Public SaveHour As String = ""

    '------いらないかもしれない変数
    Public dtrg(1, 4) As String                '達成率計算用1
    Public dtrg1(4) As String               '達成率計算用2
    Public dnow(1, 4) As String                '達成率計算用4
    Public ReDrawFlag(10) As Boolean        '最描写ﾌﾗｸﾞ

    'ﾒｲﾝ

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadModel()
        LoadSetting()
        WorkTimeCalc()
        initialize()
        LoadTmpCount()
        LoadDekidaka()
        LoadKinmu()
    End Sub

    Private Sub timScan_Tick(sender As Object, e As EventArgs) Handles timScan.Tick
        '時刻表示
        If Ln = 1 Then
            lblClock.BackColor = Color.YellowGreen
        Else
            lblClock.BackColor = Color.LemonChiffon
        End If
        lblClock.Text = CStr(Now)
        Me.lblClock.Location = New Point(690, 28)
        If ProPause = True Then
            TargetCount()
            DrawScreen()
            Exit Sub
        End If
        If DebugMode = True Then
            For i As Short = 0 To 1
                NowC(i, 0) += 1
                NowC(i, 1) += 1
                NowC(i, 2) += 1
                NowC(i, 3) += 1
                NowC(i, 4) += 1
            Next
        End If
        Trigger.Hide()
        PlanCount()
        TargetCount()
        NowCount()
        DeltaCount()
        RatioCount()
        NonAdjustRatioCount()
        DekidakaSum()
        DrawScreen()
        SaveData()
    End Sub

    Private Sub timSaveTime_Tick(sender As Object, e As EventArgs) Handles timSaveTime.Tick
        SaveTmpCount()
    End Sub

    Private Sub timScreenChange_Tick(sender As Object, e As EventArgs) Handles timScreenChange.Tick
        Dim a As Integer = timScreenChange.Interval
        If Ln = 0 Then
            Ln = 1
        Else
            Ln = 0
        End If
    End Sub

    Public Sub PlanCount()
        Dim sx(4) As String
        Dim sy(4) As String
        For j As Short = 0 To 1
            For i As Short = 0 To 4
                sx(i) = CurCh(ClmInt(CInt(Str(Pln(j, i)))))
                If j = 1 And L2choku1Nomi = 1 Then
                    sy(i) = CurCh(ClmInt(CInt(Str(Pln(j, i)))))
                Else
                    sy(i) = CurCh(ClmInt(CInt(Str(Pln(j, i) / 2))))
                End If
                WrPlnA(j, i) = CInt(sx(i))
                WrPlnB(j, i) = CInt(sy(i))
            Next i
        Next j
    End Sub

    Public Sub TargetCount()
        Dim NowTime As String = Strings.Right(CStr(Now), 8)
        Dim NowHour As Integer = CInt(Val(Strings.Mid(NowTime, 1, 2)))
        Dim NowMinute As Integer = CInt(Val(Strings.Mid(NowTime, 4, 2)))
        Dim NowSecond As Integer = CInt(Val(Strings.Mid(NowTime, 7, 2)))
        Dim sx(4) As String
        Dim j As Short = 0
        'ライン１
        j = 0
        'AM0時～7時45分->24時～31時45分に変換
        'If NowHour < 7 Or (NowHour = 7 And NowMinute < 45) Then NowHour = NowHour + 24     Ver1.0
        'Ver2.0
        If Han = 2 Then
            If NowHour < Start1H Or (NowHour = Start1H And NowMinute < Start1M) Then NowHour = NowHour + 24
        Else
            If NowHour < Cth Or (NowHour = Cth And NowMinute < Ctm) Then NowHour = NowHour + 24
        End If
        Dim Nt As Integer = NowHour * 3600 + NowMinute * 60 + NowSecond
        '1直開始ｶｳﾝﾄｸﾘｱ
        If ChokuChangeFlag = False And NowHour = Cth And NowMinute = Ctm And ProPause = False Then
            '２直部目標値を計画値と同じにする
            For i As Short = 0 To 4
                If ChokuFlag = True Then
                    sx(i) = CurCh(Str(Pln(j, i) / 2))
                Else
                    'g.FillRectangle(Brushes.Blue, rx1(i))
                End If
            Next i
            timScan.Enabled = False     'Ver2.0 追加
            ProPause = True             'Ver2.0 追加
            DekidakaHozon()
            Capturex()
            SaveJisseki()
            'CountClear()               'Ver2.0 削除
            ChokuChangeFlag = True
            DekidakaSum()
            timScan.Enabled = True      'Ver2.0 追加
            Exit Sub
        End If
        'Ver2.0 追加
        If ProPause = True And NowHour = Start1H And NowMinute = Start1M Then
            CountClear()
            ProPause = False
            Exit Sub
        ElseIf ProPause = True Then
            For i As Integer = 0 To 4
                WrTrgA(j, i) = CInt(Pln(j, i))
                WrTrgB(j, i) = CInt(Pln(j, i) / 2)
                WrTrgC(j, i) = CInt(Pln(j, i) / 2)
            Next i
            Exit Sub
        End If
        'Dim St As Decimal = 7 * 3600 + 45 * 60         'Ver1.0
        'Ver2.0
        Dim St As Integer
        If Han = 2 Then
            St = Start1H * 3600 + Start1M * 60
        Else
            St = Cth * 3600 + Ctm * 60
        End If
        Dim Wp As Integer = 0
        Dim DeltaTime As Integer = 0
        'ワークポジション設定
        If Nt < WtPi(1) Then
            Wp = 0
        ElseIf Nt >= WtPi(1) And Nt < WtPi(2) Then
            Wp = 1
        ElseIf Nt >= WtPi(2) And Nt < WtPi(3) Then
            Wp = 2
        ElseIf Nt >= WtPi(3) And Nt < WtPi(4) Then
            Wp = 3
        ElseIf Nt >= WtPi(4) And Nt < WtPi(5) Then
            Wp = 4
        ElseIf Nt >= WtPi(5) And Nt < WtPi(6) Then
            Wp = 5
        ElseIf Nt >= WtPi(6) And Nt < WtPi(7) Then
            Wp = 6
        ElseIf Nt >= WtPi(7) And Nt < WtPi(8) Then
            Wp = 7
        ElseIf Nt >= WtPi(8) And Nt < WtPi(9) Then
            Wp = 8
        ElseIf Nt >= WtPi(9) And Nt < WtPi(10) Then
            Wp = 9
        ElseIf Nt >= WtPi(10) And Nt < WtPi(11) Then
            Wp = 10
        ElseIf Nt >= WtPi(11) And Nt < WtPi(12) Then
            Wp = 11
        ElseIf Nt >= WtPi(12) And Nt < WtPi(13) Then
            Wp = 12
        ElseIf Nt >= WtPi(13) And Nt < WtPi(14) Then
            Wp = 13
        Else
            Wp = 0
        End If
        '実稼動時間算出
        ' WtBt(0) = WtBt(0) + 2700
        Select Case Wp
            Case 0
                DeltaTime = Nt - St
            Case 1
                DeltaTime = CInt(WtBt(0) + (Nt - WtPi(1)) * (1 - (WtLosR(1) / 100)))
            Case 2
                DeltaTime = WtBt(0) + WtBt(1) + (Nt - WtPi(2))
            Case 3
                DeltaTime = CInt(WtBt(0) + WtBt(1) + WtBt(2) + (Nt - WtPi(3)) * (1 - (WtLosR(2) / 100)))
            Case 4
                DeltaTime = WtBt(0) + WtBt(1) + WtBt(2) + WtBt(3) + (Nt - WtPi(4))
            Case 5
                DeltaTime = CInt(WtBt(0) + WtBt(1) + WtBt(2) + WtBt(3) + WtBt(4) + (Nt - WtPi(5)) * (1 - WtLosR(3) / 100))
            Case 6
                DeltaTime = WtBt(0) + WtBt(1) + WtBt(2) + WtBt(3) + WtBt(4) + WtBt(5) + (Nt - WtPi(6))
            Case 7
                DeltaTime = CInt(WtBt(0) + WtBt(1) + WtBt(2) + WtBt(3) + WtBt(4) + WtBt(5) + WtBt(6) + (Nt - WtPi(7)) * (1 - WtLosR(4) / 100))
            Case 8
                DeltaTime = WtBt(0) + WtBt(1) + WtBt(2) + WtBt(3) + WtBt(4) + WtBt(5) + WtBt(6) + WtBt(7) + (Nt - WtPi(8))
            Case 9
                DeltaTime = CInt(WtBt(0) + WtBt(1) + WtBt(2) + WtBt(3) + WtBt(4) + WtBt(5) + WtBt(6) + WtBt(7) + WtBt(8) + (Nt - WtPi(9)) * (1 - WtLosR(5) / 100))
            Case 10
                DeltaTime = WtBt(0) + WtBt(1) + WtBt(2) + WtBt(3) + WtBt(4) + WtBt(5) + WtBt(6) + WtBt(7) + WtBt(8) + WtBt(9) + (Nt - WtPi(10))
            Case 11
                DeltaTime = CInt(WtBt(0) + WtBt(1) + WtBt(2) + WtBt(3) + WtBt(4) + WtBt(5) + WtBt(6) + WtBt(7) + WtBt(8) + WtBt(9) + WtBt(10) + (Nt - WtPi(11)) * (1 - WtLosR(6) / 100))
            Case 12
                DeltaTime = WtBt(0) + WtBt(1) + WtBt(2) + WtBt(3) + WtBt(4) + WtBt(5) + WtBt(6) + WtBt(7) + WtBt(8) + WtBt(9) + WtBt(10) + WtBt(11) + (Nt - WtPi(12))
            Case 13
                DeltaTime = CInt(WtBt(0) + WtBt(1) + WtBt(2) + WtBt(3) + WtBt(4) + WtBt(5) + WtBt(6) + WtBt(7) + WtBt(8) + WtBt(9) + WtBt(10) + WtBt(11) + WtBt(12) + (Nt - WtPi(13)) * (1 - WtLosR(7) / 100))
            Case Else
                DeltaTime = Nt - St
        End Select
        '目標数量算出＆表示
        Dim azh As Integer
        Dim azm As Integer
        Select Case Han
            Case 2
                azh = CInt(Start2H)
                azm = CInt(Start2M)
            Case Else
                azh = CInt(Cth)
                azm = CInt(Ctm)
        End Select
        Dim Takto(4) As Double
        If NowHour < azh Or (NowHour = azh And NowMinute < azm) Then            'Ver2.0
            ChokuFlag = False
            For i As Short = 0 To 4
                Takto(i) = (Wt1Jisshitu / (Pln(j, i) / 2))
                Trg(j, i) = CInt(DeltaTime / Takto(i))
                Trr(j, i) = CInt(DeltaTime / Tkt(j, i))
            Next i
        Else
            ChokuChangeFlag = False
            ChokuFlag = True
            For i As Short = 0 To 4
                Takto(i) = (Wt2jisshitu / (Pln(j, i) / 2))
                Trg(j, i) = CInt(Pln(j, i) / 2 + (DeltaTime - Wt1Jisshitu) / Takto(i))
                Trr(j, i) = CInt(Wt1Jisshitu / Tkt(j, i) + (DeltaTime - Wt1Jisshitu) / Tkt(j, i))
            Next i
            If NowHour = Rth And NowMinute = Rtm And NowSecond < 5 Then ReDrawFlag(1) = True 'Ver2.0 変更
        End If
        'End If
        '合計部
        Dim ax(4) As Integer
        Dim bx(4) As Integer
        For i As Short = 0 To 4
            ax(i) = CInt(Trg(j, i))
            bx(i) = CInt(Pln(j, i))
        Next i
        For i As Short = 0 To 4
            sx(i) = CurCh(ClmInt(CInt(Str(ax(i)))))
            If dtrg(j, i) <> sx(i) Or ReDrawFlag(1) Then
                dtrg(j, i) = sx(i)
                If ChokuFlag = False Then
                    ChokuDataTrg1(j, i) = ax(i)
                Else
                    ChokuDataTrg2(j, i) = CInt(ax(i) - (Wt1Jisshitu / (Wt1Jisshitu / (bx(i) / 2))))
                End If
                WrTrgA(j, i) = CInt(sx(i))
            End If
        Next i
        '１直部
        For i As Short = 0 To 4
            sx(i) = CurCh(ClmInt(CInt(Str(ChokuDataTrg1(j, i)))))
            If dtrg1(i) <> sx(i) Or ReDrawFlag(1) Then
                If ChokuFlag = True Then
                    If ReDrawFlag(1) = False Then Exit For
                    sx(i) = CurCh(Str(Pln(j, i) / 2))
                End If
                dtrg1(i) = sx(i)
                WrTrgB(j, i) = CInt(sx(i))
            End If
        Next i
        '２直部
        For i As Short = 0 To 4
            If ChokuFlag = True Then
                sx(i) = CurCh(ClmInt(CInt(Str(ChokuDataTrg2(j, i)))))
                WrTrgB(j, i) = CInt(Pln(j, i) / 2)
            End If
            WrTrgC(j, i) = CInt(sx(i))
        Next i
        'ライン２
        j = 1
        'AM0時～7時45分->24時～31時45分に変換
        'If NowHour < 7 Or (NowHour = 7 And NowMinute < 45) Then NowHour = NowHour + 24     Ver1.0
        'Ver2.0
        If Han2 = 2 Then
            If NowHour < Start1H Or (NowHour = Start1H And NowMinute < Start1M) Then NowHour = NowHour + 24
        Else
            If NowHour < Cth Or (NowHour = Cth And NowMinute < Ctm) Then NowHour = NowHour + 24
        End If
        Dim Nt2 As Integer = NowHour * 3600 + NowMinute * 60 + NowSecond
        '1直開始ｶｳﾝﾄｸﾘｱ
        If ChokuChangeFlag = False And NowHour = Cth And NowMinute = Ctm And ProPause = False Then
            '２直部目標値を計画値と同じにする
            For i As Short = 0 To 4
                If ChokuFlag = True Then
                    sx(i) = CurCh(Str(Pln(j, i) / 2))
                Else
                    'g.FillRectangle(Brushes.Blue, rx1(i))
                End If
            Next i
            timScan.Enabled = False     'Ver2.0 追加
            ProPause = True             'Ver2.0 追加
            DekidakaHozon()
            Capturex()
            SaveJisseki()
            'CountClear()               'Ver2.0 削除
            ChokuChangeFlag = True
            DekidakaSum()
            timScan.Enabled = True      'Ver2.0 追加
            Exit Sub
        End If
        'Ver2.0 追加
        If ProPause = True And NowHour = Start1H And NowMinute = Start1M Then
            CountClear()
            ProPause = False
            Exit Sub
        ElseIf ProPause = True Then
            For i As Integer = 0 To 4
                WrTrgA(j, i) = CInt(Pln(j, i))
                WrTrgB(j, i) = CInt(Pln(j, i) / 2)
                WrTrgC(j, i) = CInt(Pln(j, i) / 2)
            Next i
            Exit Sub
        End If
        'Dim St As Decimal = 7 * 3600 + 45 * 60         'Ver1.0
        'Ver2.0
        Dim St2 As Integer
        If Han2 = 2 Then
            St2 = Start1H * 3600 + Start1M * 60
        Else
            St2 = Cth * 3600 + Ctm * 60
        End If
        Dim Wp2 As Integer = 0
        Dim DeltaTime2 As Integer = 0
        'ワークポジション設定
        If Nt2 < WtPi2(1) Then
            Wp2 = 0
        ElseIf Nt2 >= WtPi2(1) And Nt2 < WtPi2(2) Then
            Wp2 = 1
        ElseIf Nt2 >= WtPi2(2) And Nt2 < WtPi2(3) Then
            Wp2 = 2
        ElseIf Nt2 >= WtPi2(3) And Nt2 < WtPi2(4) Then
            Wp2 = 3
        ElseIf Nt2 >= WtPi2(4) And Nt2 < WtPi2(5) Then
            Wp2 = 4
        ElseIf Nt2 >= WtPi2(5) And Nt2 < WtPi2(6) Then
            Wp2 = 5
        ElseIf Nt2 >= WtPi2(6) And Nt2 < WtPi2(7) Then
            Wp2 = 6
        ElseIf Nt2 >= WtPi2(7) And Nt2 < WtPi2(8) Then
            Wp2 = 7
        ElseIf Nt2 >= WtPi2(8) And Nt2 < WtPi2(9) Then
            Wp2 = 8
        ElseIf Nt2 >= WtPi2(9) And Nt2 < WtPi2(10) Then
            Wp2 = 9
        ElseIf Nt2 >= WtPi2(10) And Nt2 < WtPi2(11) Then
            Wp2 = 10
        ElseIf Nt2 >= WtPi2(11) And Nt2 < WtPi2(12) Then
            Wp2 = 11
        ElseIf Nt2 >= WtPi2(12) And Nt2 < WtPi2(13) Then
            Wp2 = 12
        ElseIf Nt2 >= WtPi2(13) And Nt2 < WtPi2(14) Then
            Wp2 = 13
        Else
            Wp2 = 0
        End If
        '実稼動時間算出
        ' WtBt(0) = WtBt(0) + 2700
        Select Case Wp2
            Case 0
                DeltaTime2 = Nt2 - St2
            Case 1
                DeltaTime2 = CInt(WtBt2(0) + (Nt2 - WtPi2(1)) * (1 - (WtLosR2(1) / 100)))
            Case 2
                DeltaTime2 = WtBt2(0) + WtBt2(1) + (Nt2 - WtPi2(2))
            Case 3
                DeltaTime2 = CInt(WtBt2(0) + WtBt2(1) + WtBt2(2) + (Nt2 - WtPi2(3)) * (1 - (WtLosR2(2) / 100)))
            Case 4
                DeltaTime2 = WtBt2(0) + WtBt2(1) + WtBt2(2) + WtBt2(3) + (Nt2 - WtPi2(4))
            Case 5
                DeltaTime2 = CInt(WtBt2(0) + WtBt2(1) + WtBt2(2) + WtBt2(3) + WtBt2(4) + (Nt2 - WtPi2(5)) * (1 - WtLosR2(3) / 100))
            Case 6
                DeltaTime2 = WtBt2(0) + WtBt2(1) + WtBt2(2) + WtBt2(3) + WtBt2(4) + WtBt2(5) + (Nt2 - WtPi2(6))
            Case 7
                DeltaTime2 = CInt(WtBt2(0) + WtBt2(1) + WtBt2(2) + WtBt2(3) + WtBt2(4) + WtBt2(5) + WtBt2(6) + (Nt2 - WtPi2(7)) * (1 - WtLosR2(4) / 100))
            Case 8
                DeltaTime2 = WtBt2(0) + WtBt2(1) + WtBt2(2) + WtBt2(3) + WtBt2(4) + WtBt2(5) + WtBt2(6) + WtBt2(7) + (Nt2 - WtPi2(8))
            Case 9
                DeltaTime2 = CInt(WtBt2(0) + WtBt2(1) + WtBt2(2) + WtBt2(3) + WtBt2(4) + WtBt2(5) + WtBt2(6) + WtBt2(7) + WtBt2(8) + (Nt2 - WtPi2(9)) * (1 - WtLosR2(5) / 100))
            Case 10
                DeltaTime2 = WtBt2(0) + WtBt2(1) + WtBt2(2) + WtBt2(3) + WtBt2(4) + WtBt2(5) + WtBt2(6) + WtBt2(7) + WtBt2(8) + WtBt2(9) + (Nt2 - WtPi2(10))
            Case 11
                DeltaTime2 = CInt(WtBt2(0) + WtBt2(1) + WtBt2(2) + WtBt2(3) + WtBt2(4) + WtBt2(5) + WtBt2(6) + WtBt2(7) + WtBt2(8) + WtBt2(9) + WtBt2(10) + (Nt2 - WtPi2(11)) * (1 - WtLosR2(6) / 100))
            Case 12
                DeltaTime2 = WtBt2(0) + WtBt2(1) + WtBt2(2) + WtBt2(3) + WtBt2(4) + WtBt2(5) + WtBt2(6) + WtBt2(7) + WtBt2(8) + WtBt2(9) + WtBt2(10) + WtBt2(11) + (Nt2 - WtPi2(12))
            Case 13
                DeltaTime2 = CInt(WtBt2(0) + WtBt2(1) + WtBt2(2) + WtBt2(3) + WtBt2(4) + WtBt2(5) + WtBt2(6) + WtBt2(7) + WtBt2(8) + WtBt2(9) + WtBt2(10) + WtBt2(11) + WtBt2(12) + (Nt2 - WtPi2(13)) * (1 - WtLosR2(7) / 100))
            Case Else
                DeltaTime2 = Nt2 - St2
        End Select
        '目標数量算出＆表示
        Dim azh2 As Integer
        Dim azm2 As Integer
        Select Case Han2
            Case 2
                azh2 = CInt(Start2H)
                azm2 = CInt(Start2M)
            Case Else
                azh2 = CInt(Cth)
                azm2 = CInt(Ctm)
        End Select
        Dim Takto2(4) As Double
        If NowHour < azh2 Or (NowHour = azh2 And NowMinute < azm2) Then            'Ver2.0
            ChokuFlag = False
            For i As Short = 0 To 4
                If L2choku1Nomi = 0 Then
                    Takto2(i) = (Wt1Jisshitu2 / (Pln(j, i) / 2))
                Else
                    Takto2(i) = (Wt1Jisshitu2 / (Pln(j, i)))
                End If
                Trg(j, i) = CInt(DeltaTime2 / Takto2(i))
                Trr(j, i) = CInt(DeltaTime2 / Tkt(j, i))
            Next i
        Else
            ChokuChangeFlag = False
            ChokuFlag = True
            For i As Short = 0 To 4
                If L2choku1Nomi = 0 Then
                    Takto2(i) = (Wt2jisshitu2 / (Pln(j, i) / 2))
                Else
                    Takto2(i) = (Wt2jisshitu2 / (Pln(j, i)))
                End If
                Trg(j, i) = CInt(Pln(j, i) / 2 + (DeltaTime2 - Wt1Jisshitu2) / Takto2(i))
                Trr(j, i) = CInt(Wt1Jisshitu2 / Tkt(j, i) + (DeltaTime2 - Wt1Jisshitu2) / Tkt(j, i))
            Next i
            If NowHour = Rth And NowMinute = Rtm And NowSecond < 5 Then ReDrawFlag(1) = True 'Ver2.0 変更
        End If
        'End If
        '合計部
        For i As Short = 0 To 4
            ax(i) = CInt(Trg(j, i))
            bx(i) = CInt(Pln(j, i))
        Next i
        For i As Short = 0 To 4
            sx(i) = CurCh(ClmInt(CInt(Str(ax(i)))))
            If dtrg(j, i) <> sx(i) Or ReDrawFlag(1) Then
                dtrg(j, i) = sx(i)
                If ChokuFlag = False Then
                    ChokuDataTrg1(j, i) = ax(i)
                Else
                    If L2choku1Nomi = 0 Then
                        ChokuDataTrg2(j, i) = CInt(ax(i) - (Wt1Jisshitu2 / (Wt1Jisshitu2 / (bx(i) / 2))))
                    Else
                        ChokuDataTrg2(j, i) = CInt(ax(i) - (Wt1Jisshitu2 / (Wt1Jisshitu2 / (bx(i)))))
                    End If
                End If
                WrTrgA(j, i) = CInt(sx(i))
            End If
        Next i
        '１直部
        For i As Short = 0 To 4
            sx(i) = CurCh(ClmInt(CInt(Str(ChokuDataTrg1(j, i)))))
            If dtrg1(i) <> sx(i) Or ReDrawFlag(1) Then
                If ChokuFlag = True Then
                    If ReDrawFlag(1) = False Then Exit For
                    If L2choku1Nomi = 0 Then
                        sx(i) = CurCh(Str(Pln(j, i) / 2))
                    Else
                        sx(i) = CurCh(Str(Pln(j, i)))
                    End If
                End If
                    dtrg1(i) = sx(i)
                    WrTrgB(j, i) = CInt(sx(i))
                End If
        Next i
        '２直部
        For i As Short = 0 To 4
            If ChokuFlag = True Then
                sx(i) = CurCh(ClmInt(CInt(Str(ChokuDataTrg2(j, i)))))
                If L2choku1Nomi = 0 Then
                    WrTrgB(j, i) = CInt(Pln(j, i) / 2)
                Else
                    WrTrgB(j, i) = CInt(Pln(j, i))
                End If
            End If
                WrTrgC(j, i) = CInt(sx(i))
        Next i
        ReDrawFlag(1) = False
    End Sub

    Public Sub NowCount()
        Dim ax(4) As Single
        Dim sx(4) As String
        For j As Short = 0 To 1
            For i As Short = 0 To 4
                ax(i) = NowC(j, i) * Qu(j, i) + Geta(j, i)
            Next i
            If ChokuFlag = False Then
                DekidakaDay(j) = CInt(ax(4))
            Else
                DekidakaAll(j) = CInt(ax(4))
            End If
            '合計部
            For i As Short = 0 To 4
                sx(i) = Trim(CurCh(ClmInt(CInt(Str(ax(i))))))
                dnow(j, i) = sx(i)
                If ChokuFlag = False Then
                    ChokuData1(j, i) = CInt(ax(i))
                Else
                    ChokuData2(j, i) = CInt(ax(i) - ChokuData1(j, i))
                End If
                WrCntA(j, i) = CInt(ax(i))
            Next
            '１直部
            For i As Integer = 0 To 4
                If ChokuFlag = True And ReDrawFlag(2) = False Then Exit For
                sx(i) = Trim(CurCh(ClmInt(CInt(Str(ChokuData1(j, i))))))
                If ChokuFlag = True Then
                    For k As Integer = 0 To 4
                        sx(k) = Trim(CurCh(ClmInt(CInt(Str(Replace(MemNowCh1(j, i), ",", ""))))))
                    Next
                End If
                MemNowCh1(j, i) = sx(i)
                WrCntB(j, i) = CInt(sx(i))
            Next i
            ReDrawFlag(2) = False
            '２直部
            For i As Short = 0 To 4
                If ChokuFlag = True Then
                    sx(i) = Trim(CurCh(ClmInt(CInt(Str(ChokuData2(j, i))))))
                End If
                WrCntC(j, i) = CInt(sx(i))
            Next i
        Next j
    End Sub

    Public Sub DeltaCount()
        Dim tmp(4) As Integer
        For j As Short = 0 To 1
            For i As Short = 0 To 4
                tmp(i) = NowC(j, i) * Qu(j, i) + Geta(j, i) - Trg(j, i)
            Next i
            Dim sx(4) As String
            Dim px(4) As Integer
            '合計部
            For i As Short = 0 To 4
                sx(i) = Trim(CurCh((Str(tmp(i)))))
                WrDelA(j, i) = CInt(sx(i))
            Next
            '１直部
            For i As Short = 0 To 4
                px(i) = CInt(Pln(j, i) / 2)
            Next i
            For i As Short = 0 To 4
                If ChokuFlag = False Then
                    sx(i) = Trim(CurCh((Str(ChokuData1(j, i) - ChokuDataTrg1(j, i)))))
                Else
                    sx(i) = Trim(CurCh(Str(Val(CDbl(Replace(MemNowCh1(j, i), ",", "")) - px(i)))))
                End If
                WrDelB(j, i) = CInt(sx(i))
            Next
            '２直部
            For i As Short = 0 To 4
                If ChokuFlag = True Then
                    tmp(i) = CInt(Val(((Str(ChokuData2(j, i) - ChokuDataTrg2(j, i))))))
                    sx(i) = Trim(CurCh((Str(ChokuData2(j, i) - ChokuDataTrg2(j, i)))))
                End If
                WrDelC(j, i) = CInt(sx(i))
            Next
        Next j
        ReDrawFlag(3) = False
    End Sub

    Public Sub RatioCount()
        Dim tmp(4) As Single
        Dim tmpS(4) As String
        For j As Short = 0 To 1
            For i As Short = 0 To 4
                If Trr(j, i) > 0 Then
                    tmp(i) = CSng(100 * (NowC(j, i) * Qu(j, i) + Geta(j, i)) / Trr(j, i))
                Else
                    tmp(i) = 0
                End If
            Next i
            For i As Short = 0 To 4
                If tmp(i) >= 100 Then
                    tmpS(i) = "100"
                Else
                    tmpS(i) = ClmInt(CInt(tmp(i)))
                    If Trim(tmpS(i)) = "100" Then
                        tmpS(i) = "100"
                    End If
                End If
            Next
            Dim sx(4) As String
            sx(0) = tmpS(2)
            sx(1) = tmpS(3)
            sx(2) = tmpS(4)
            For i As Short = 0 To 2
                WrRat(j, i) = CInt(sx(i))
            Next
        Next j
        ReDrawFlag(4) = False
    End Sub

    Public Sub NonAdjustRatioCount()
        Dim Ret As Integer
        Dim PortNo(9) As Short
        Dim Data(9) As Byte
        Dim x(9) As Single
        '無調率データ コンテックDIO-32より取得
        For i As Short = 0 To 9
            PortNo(i) = i
        Next i
        If DebugMode = False Then
            Ret = DioInpMultiByte(0, PortNo, 10, Data)
            '百分率計算（100%以上の場合は100%にする）
            If EmExMode Then
                x(0) = CSng((Data(3) * 256 + Data(2)) / 100)
                x(1) = CSng((Data(5) * 256 + Data(4)) / 100)
                x(2) = CSng((Data(7) * 256 + Data(6)) / 100)
                If x(0) > 100 Then x(0) = 100
                If x(1) > 100 Then x(1) = 100
                If x(2) > 100 Then x(2) = 100
            Else
                x(0) = CSng((Data(1) * 256 + Data(0)) / 100)
                x(1) = CSng((Data(3) * 256 + Data(2)) / 100)
                x(3) = CSng((Data(5) * 256 + Data(4)) / 100)
                x(4) = CSng((Data(7) * 256 + Data(6)) / 100)
                x(5) = CSng((Data(9) * 256 + Data(8)) / 100)
                If NowC(Ln, 5) > 0 Then
                    x(2) = CSng(NowC(Ln, 6) / NowC(Ln, 5) * 100)
                Else
                    x(2) = 0
                End If
                If x(0) > 100 Then x(0) = 100
                If x(1) > 100 Then x(1) = 100
                If x(2) > 99.9 Then x(2) = 99.9
                If x(3) > 100 Then x(3) = 100
                If x(4) > 100 Then x(4) = 100
                If x(5) > 100 Then x(5) = 100
            End If
            WrCho(0, 0) = x(0)
            WrCho(0, 1) = x(1)
            WrCho(0, 2) = x(2)
            WrCho(1, 0) = x(3)
            WrCho(1, 1) = x(4)
            WrCho(1, 2) = x(5)
            IO = Data
        End If
    End Sub

    '画面描写

    Public Sub DrawScreen()
        If DualMode Then
            If HoriMode Then
                DrawScreen3()
            Else
                DrawScreen2()
            End If
        Else
            DrawScreen1()
        End If
    End Sub

    Public Sub DrawScreen1()
        'ダブルバッファー設定
        Dim currentContext As BufferedGraphicsContext
        Dim myBuffer As BufferedGraphics
        currentContext = BufferedGraphicsManager.Current
        myBuffer = currentContext.Allocate(Me.CreateGraphics(), New Rectangle(0, 0, 1500, 800))
        'Public gcBlack As New SolidBrush(Color.Black)
        Dim g As Graphics = myBuffer.Graphics
        Dim Lc(1) As SolidBrush
        Dim Lp(1) As SolidBrush
        Lc(0) = New SolidBrush(Color.Orange)
        Lc(1) = New SolidBrush(Color.DarkGreen)
        Lp(0) = New SolidBrush(Color.Black)
        Lp(1) = New SolidBrush(Color.Yellow)
        'Dim Lc As Object
        '画面ｸﾘｱ
        Dim rect0x As New RectangleF(0, 0, 1500, 800)
        If Ln = 0 Then
            g.FillRectangle(Brushes.LemonChiffon, rect0x)
        Else
            g.FillRectangle(Brushes.YellowGreen, rect0x)
        End If
        '---
        Dim rect0 As New RectangleF(60, 65, 960, 50)
        g.FillRectangle(Lc(Ln), rect0)
        Dim rect1 As New RectangleF(60, 115, 960, 50)
        Dim rect2 As New RectangleF(60, 315, 960, 50)
        Dim rect3 As New RectangleF(60, 515, 960, 50)
        g.FillRectangle(Brushes.White, rect1)
        g.FillRectangle(Brushes.White, rect2)
        g.FillRectangle(Brushes.White, rect3)
        Dim rect4 As New RectangleF(60, 165, 960, 50)
        Dim rect5 As New RectangleF(60, 365, 960, 50)
        Dim rect6 As New RectangleF(60, 565, 960, 50)
        g.FillRectangle(Brushes.Blue, rect4)
        g.FillRectangle(Brushes.Blue, rect5)
        g.FillRectangle(Brushes.Blue, rect6)
        Dim rect7 As New RectangleF(60, 215, 960, 50)
        Dim rect8 As New RectangleF(60, 415, 960, 50)
        Dim rect9 As New RectangleF(60, 615, 960, 50)
        g.FillRectangle(Brushes.LightBlue, rect7)
        g.FillRectangle(Brushes.LightBlue, rect8)
        g.FillRectangle(Brushes.LightBlue, rect9)
        Dim rect10 As New RectangleF(60, 265, 960, 50)
        Dim rect11 As New RectangleF(60, 465, 960, 50)
        Dim rect12 As New RectangleF(60, 665, 960, 50)
        g.FillRectangle(Brushes.Yellow, rect10)
        g.FillRectangle(Brushes.Yellow, rect11)
        g.FillRectangle(Brushes.Yellow, rect12)
        Dim rect13 As New RectangleF(5, 115, 55, 600)
        g.FillRectangle(Brushes.LightGreen, rect13)
        'タイトル
        g.DrawString("リレー生産進捗集中モニター   Ver3.0", gf20, gcBlue, 130, 30)
        'ライン名
        Dim LineNumber As String
        If Ln = 0 Then
            LineNumber = "１"
        Else
            LineNumber = "２"
        End If
        g.DrawString(LineNumber, gf72, gcBlack, 1022, 42)
        g.DrawString(ModelName + "-" + "No.", gf18, gcBlack, 1015, 28)
        g.DrawString("   ライン名", gf18, Lp(Ln), 65, 75)
        g.DrawString("巻線１号ﾗｲﾝ", gf18, Lp(Ln), 220, 75)
        g.DrawString("巻線２号ﾗｲﾝ", gf18, Lp(Ln), 220 + 160, 75)
        g.DrawString("前組１号ﾗｲﾝ", gf18, Lp(Ln), 220 + 160 * 2, 75)
        g.DrawString("前組２号ﾗｲﾝ", gf18, Lp(Ln), 220 + 160 * 3, 75)
        g.DrawString("    後組ﾗｲﾝ", gf18, Lp(Ln), 220 + 160 * 4, 75)
        For i As Long = 0 To 2
            g.DrawString("目標生産数", gf18, gcBlack, 65, 125 + 200 * i)
            g.DrawString("現在計画数", gf18, gcWhite, 65, 175 + 200 * i)
            g.DrawString("現在実績数", gf18, gcBlack, 65, 225 + 200 * i)
            g.DrawString("        差", gf18, gcBlack, 65, 275 + 200 * i)
        Next i
        g.DrawString("１", gf18, gcBlack, 20, 190)
        g.DrawString("直", gf18, gcBlack, 16, 220)
        g.DrawString("２", gf18, gcBlack, 20, 390)
        g.DrawString("直", gf18, gcBlack, 16, 420)
        g.DrawString("合", gf18, gcBlack, 16, 590)
        g.DrawString("計", gf18, gcBlack, 16, 620)
        For i As Long = 0 To 6
            g.DrawLine(Pen1, 60 + 160 * i, 65, 60 + 160 * i, 715)
        Next
        For i As Long = 0 To 13
            g.DrawLine(Pen1, 60, 65 + 50 * i, 60 + 960, 65 + 50 * i)
        Next
        g.DrawLine(Pen3, 5, 65, 5, 715)
        g.DrawLine(Pen3, 60, 65, 60, 715)
        g.DrawLine(Pen3, 220, 65, 220, 715)
        g.DrawLine(Pen3, 1020, 65, 1020, 715)
        g.DrawLine(Pen3, 5, 65, 1020, 65)
        g.DrawLine(Pen3, 5, 115, 1020, 115)
        g.DrawLine(Pen3, 5, 315, 1020, 315)
        g.DrawLine(Pen3, 5, 515, 1020, 515)
        g.DrawLine(Pen3, 5, 715, 1020, 715)
        '累計
        Dim rect20 As New RectangleF(1030 + 100, 65 - 35, 335 - 100, 50)
        g.FillRectangle(Lc(Ln), rect20)
        Dim rect21 As New RectangleF(1030 + 100, 115 - 35, 335 - 100, 50)
        g.FillRectangle(Brushes.White, rect21)
        g.DrawLine(Pen3, 1030 + 100, 65 - 35, 1365, 65 - 35)
        g.DrawLine(Pen3, 1030 + 100, 115 - 35, 1365, 115 - 35)
        g.DrawLine(Pen3, 1030 + 100, 165 - 35, 1365, 165 - 35)
        g.DrawLine(Pen3, 1030 + 100, 65 - 35, 1030 + 100, 165 - 35)
        g.DrawLine(Pen3, 1365, 65 - 35, 1365, 165 - 35)
        g.DrawString("月度 累計出来高", gf18, Lp(Ln), 1073 + 90, 75 - 35)
        '班別
        Dim rect30 As New RectangleF(1030, 215 - 75, 335, 35)
        g.FillRectangle(Lc(Ln), rect30)
        Dim rect31 As New RectangleF(1030, 250 - 75, 100, 120)
        g.FillRectangle(Brushes.LightSkyBlue, rect31)
        Dim rect32 As New RectangleF(1130, 250 - 75, 235, 120)
        g.FillRectangle(Brushes.White, rect32)
        g.DrawLine(Pen3, 1030, 215 - 75, 1365, 215 - 75)
        g.DrawLine(Pen3, 1030, 250 - 75, 1365, 250 - 75)
        g.DrawLine(Pen1, 1030, 290 - 75, 1365, 290 - 75)
        g.DrawLine(Pen1, 1030, 330 - 75, 1365, 330 - 75)
        g.DrawLine(Pen3, 1030, 370 - 75, 1365, 370 - 75)
        g.DrawLine(Pen3, 1030, 215 - 75, 1030, 370 - 75)
        g.DrawLine(Pen3, 1130, 250 - 75, 1130, 370 - 75)
        g.DrawLine(Pen3, 1365, 215 - 75, 1365, 370 - 75)
        g.DrawString("月度 班別実績数", gf18, Lp(Ln), 1073, 225 - 80)
        g.DrawString("(日産平均)", gf12, Lp(Ln), 1273, 228 - 80)
        g.DrawString("Ａ班", gf18, gcBlack, 1050, 260 - 76)
        g.DrawString("Ｂ班", gf18, gcBlack, 1050, 300 - 78)
        g.DrawString("Ｃ班", gf18, gcBlack, 1050, 340 - 80)
        If Han = 2 Then
            g.DrawLine(Pen3, 1030, 256, 1365, 256)
            Dim rect60 As New RectangleF(1028, 257, 340, 40)
            If Ln = 0 Then
                g.FillRectangle(Brushes.LemonChiffon, rect60)
            Else
                g.FillRectangle(Brushes.YellowGreen, rect60)
            End If
        End If
        '稼働率・直行率
        Dim rect40 As New RectangleF(1030, 515 + 15, 100 - 20, 200 - 15)
        g.FillRectangle(Lc(Ln), rect40)
        Dim rect41 As New RectangleF(1130 - 20, 515 + 15, 117 - 10, 200 - 15)
        g.FillRectangle(Brushes.LightPink, rect41)
        Dim rect42 As New RectangleF(1247 - 30, 515 + 15, 117 + 30, 200 - 15)
        g.FillRectangle(Brushes.LightGreen, rect42)
        g.DrawLine(Pen3, 1030, 515 + 15, 1365, 515 + 15)
        g.DrawLine(Pen3, 1030, 565, 1365, 565)
        g.DrawLine(Pen1, 1030, 615, 1365, 615)
        g.DrawLine(Pen1, 1030, 665, 1365, 665)
        g.DrawLine(Pen3, 1030, 715, 1365, 715)
        g.DrawLine(Pen3, 1030, 515 + 15, 1030, 715)
        g.DrawLine(Pen3, 1130 - 20, 515 + 15, 1130 - 20, 715)
        g.DrawLine(Pen3, 1247 - 30, 515 + 15, 1247 - 30, 715)
        g.DrawLine(Pen3, 1365, 515 + 15, 1365, 715)
        g.DrawString("稼働率", gf18, gcBlack, 1143 - 25, 525 + 10)
        g.DrawString("直行率", gf18, gcBlack, 1262 - 15, 525 + 10)
        g.DrawString("前組１", gf18, Lp(Ln), 1040 - 10, 575)
        g.DrawString("前組２", gf18, Lp(Ln), 1040 - 10, 625)
        g.DrawString("後組", gf18, Lp(Ln), 1050 - 10, 675)
        Dim Mx As Long = GetMonth()
        'Dim Dx As Long = GetDay()
        Dim sx As String = ""
        If Mx < 10 Then
            sx = " " + Trim(Str(Mx))
        Else
            sx = Trim(Str(Mx))
        End If
        g.DrawString(sx, gf20, Lp(Ln), 1040 + 90, 72 - 35)
        g.DrawString(sx, gf20, Lp(Ln), 1040, 222 - 80)
        ''達成率
        Dim rect50 As New RectangleF(1030, 305, 335, 35)
        g.FillRectangle(Lc(Ln), rect50)
        Dim rect51 As New RectangleF(1030, 340, 100, 180)
        g.FillRectangle(Brushes.LightSkyBlue, rect51)
        Dim rect52 As New RectangleF(1130, 340, 235, 180)
        g.FillRectangle(Brushes.White, rect52)
        g.DrawLine(Pen3, 1030, 305, 1365, 305)
        g.DrawLine(Pen3, 1030, 340, 1365, 340)
        g.DrawLine(Pen1, 1030, 400, 1365, 400)
        g.DrawLine(Pen1, 1030, 460, 1365, 460)
        g.DrawLine(Pen3, 1030, 520, 1365, 520)
        g.DrawLine(Pen3, 1030, 305, 1030, 520)
        g.DrawLine(Pen3, 1130, 340, 1130, 520)
        g.DrawLine(Pen3, 1365, 305, 1365, 520)
        g.DrawString("現在達成率", gf18, Lp(Ln), 1120, 310)
        g.DrawString("巻線", gf18, gcBlack, 1045, 358)
        g.DrawString("前組", gf18, gcBlack, 1045, 418)
        g.DrawString("後組", gf18, gcBlack, 1045, 478)
        ''--- 
        '合計表示
        For i As Integer = 0 To 4
            If L2choku1Nomi = 1 Then
                Pr(g, WrPlnB(Ln, i), 360 + (160 * i), 520, gcBlue, 26)
                Pr(g, WrTrgB(Ln, i), 360 + (160 * i), 570, gcWhite, 26)
                Pr(g, WrCntB(Ln, i), 360 + (160 * i), 620, gcBlack, 26)
                Pr(g, WrDelB(Ln, i), 360 + (160 * i), 670, gcBlack, 26)
            Else
                Pr(g, WrPlnA(Ln, i), 360 + (160 * i), 520, gcBlue, 26)
                Pr(g, WrTrgA(Ln, i), 360 + (160 * i), 570, gcWhite, 26)
                Pr(g, WrCntA(Ln, i), 360 + (160 * i), 620, gcBlack, 26)
                Pr(g, WrDelA(Ln, i), 360 + (160 * i), 670, gcBlack, 26)
            End If
        Next
        '1直表示
        For i As Integer = 0 To 4
            Pr(g, WrPlnB(Ln, i), 360 + (160 * i), 120, gcBlue, 26)
            Pr(g, WrTrgB(Ln, i), 360 + (160 * i), 170, gcWhite, 26)
            Pr(g, WrCntB(Ln, i), 360 + (160 * i), 220, gcBlack, 26)
            Pr(g, WrDelB(Ln, i), 360 + (160 * i), 270, gcBlack, 26)
        Next
        '2直表示
        If Ln = 0 Or L2choku1Nomi = 0 Then
            If ChokuFlag = True Then
                For i As Short = 0 To 4
                    Pr(g, WrPlnB(Ln, i), 360 + (160 * i), 320, gcBlue, 26)
                    Pr(g, WrTrgC(Ln, i), 360 + (160 * i), 370, gcWhite, 26)
                    Pr(g, WrCntC(Ln, i), 360 + (160 * i), 420, gcBlack, 26)
                    Pr(g, WrDelC(Ln, i), 360 + (160 * i), 470, gcBlack, 26)
                Next
            End If
        End If
        '稼働率表示
        Dim gof As Integer = 0
        Dim gColor As System.Drawing.Brush
        For i As Integer = 0 To 2
            If WrRat(Ln, i) = 100 Then
                gof = 30
            ElseIf WrRat(Ln, i) < 100 And WrRat(Ln, i) >= 10 Then
                gof = 42
            Else
                gof = 53
            End If
            If WrRat(Ln, i) > 80 Then
                gColor = gcBlue
            ElseIf WrRat(Ln, i) > 70 Then
                gColor = gcDarkGreen
            Else
                gColor = gcRed
            End If
            g.DrawString(PutValue(WrRat(Ln, i)) + "%", gf26, gColor, 1021 + gof, 572 + i * 50)
        Next
        '直行率表示
        For i As Short = 0 To 2
            'Dim cc As Long = Int(Val(wrCho(i)))
            If WrCho(Ln, i) >= 100 Then
                gof = 60
            ElseIf WrCho(Ln, i) < 100 And WrCho(Ln, i) >= 10 Then
                gof = 50
            Else
                gof = 70
            End If
            If WrCho(Ln, i) > 98 Then
                gColor = gcBlue
            ElseIf WrCho(Ln, i) > 95 Then
                gColor = gcDeepPink
            Else
                gColor = gcRed
            End If
            g.DrawString(CnvPercentageString(WrCho(Ln, i)) + "%", gf26, gColor, 1200 + gof, 572 + i * 50)
        Next i
        '出来高表示
        Dim zx As Integer = DekidakaTotal(Ln) + DekidakaHosei(Ln) + NowC(Ln, 4) * Qu(Ln, 4) + Geta(Ln, 4)
        Pr(g, zx, 1330, 80, gcBlack, 32)
        'End Select
        '達成率表示
        Dim ax(2) As Integer
        Dim bx(2) As Integer
        Dim cx(2) As Integer
        bx(0) = CInt(Val(Replace(dtrg(Ln, 0), ",", "")) + Val(Replace(dtrg(Ln, 1), ",", "")))
        bx(1) = CInt(Val(Replace(dtrg(Ln, 2), ",", "")) + Val(Replace(dtrg(Ln, 3), ",", "")))
        bx(2) = CInt(Val(Replace(dtrg(Ln, 4), ",", "")))
        cx(0) = CInt(Val(Replace(dnow(Ln, 0), ",", "")) + Val(Replace(dnow(Ln, 1), ",", "")))
        cx(1) = CInt(Val(Replace(dnow(Ln, 2), ",", "")) + Val(Replace(dnow(Ln, 3), ",", "")))
        cx(2) = CInt(Val(Replace(dnow(Ln, 4), ",", "")))
        For i As Short = 0 To 2
            If bx(i) <> 0 Then
                ax(i) = CInt(cx(i) / bx(i) * 100)
                If ax(i) = 100 And bx(i) > cx(i) Then ax(i) = 99
            Else
                ax(i) = 0
            End If
        Next i
        For i As Short = 0 To 2
            If ax(i) > 999 Then ax(i) = 999
            Select Case ax(i)
                Case 0 To 9
                    g.DrawString(Str(ax(i)) + "%", gf48, gcBlack, 1220, 335 + i * 60)
                Case 10 To 99
                    g.DrawString(Str(ax(i)) + "%", gf48, gcBlack, 1220 - 37, 335 + i * 60)
                Case Else
                    g.DrawString(Str(ax(i)) + "%", gf48, gcBlack, 1220 - 37 * 2, 335 + i * 60)
            End Select
        Next i
        ''班別実績表示
        GrupJisseki()
        For i As Integer = 0 To Han - 1
            Pr(g, GpData(Ln, i), 1300, 178 + i * 40, gcBlack, 26)
        Next i
        'バッファー内容表示()
        myBuffer.Render()
        'バッファー内容クリア
        myBuffer.Dispose()
    End Sub

    Public Sub DrawScreen2()
        'ダブルバッファー設定
        Dim currentContext As BufferedGraphicsContext
        Dim myBuffer As BufferedGraphics
        currentContext = BufferedGraphicsManager.Current
        myBuffer = currentContext.Allocate(Me.CreateGraphics(), New Rectangle(0, 0, 1500, 800))
        Dim g As Graphics = myBuffer.Graphics
        '---
        Dim Lc(1) As SolidBrush
        Dim Lp(1) As SolidBrush
        Lc(0) = New SolidBrush(Color.Orange)
        Lc(1) = New SolidBrush(Color.DarkGreen)
        Lp(0) = New SolidBrush(Color.Black)
        Lp(1) = New SolidBrush(Color.Yellow)
        'Dim Lc As Object
        '画面ｸﾘｱ
        Dim rect0x As New RectangleF(0, 0, 1500, 800)
        g.FillRectangle(Brushes.LemonChiffon, rect0x)
        '---
        Dim Ht As Short = 65        '表の上端
        Dim Hl As Short = 100      '表の左端
        Dim Hx As Short = 26        '表の桁の高さ
        Dim Hy As Short = 150         '表の桁の幅
        Dim Hw As Integer = Hy * 6         '表の幅
        Dim rec(25) As RectangleF
        '---
        'ﾊﾞｯｸｶﾗｰ
        For i As Short = 0 To 25
            rec(i) = New RectangleF(Hl, Ht + Hx * i, Hw, Hx)
        Next i
        g.FillRectangle(Brushes.LightPink, rec(0))
        For i As Short = 0 To 5
            g.FillRectangle(Brushes.White, rec(i * 4 + 1))
            g.FillRectangle(Brushes.Blue, rec(i * 4 + 2))
            g.FillRectangle(Brushes.LightBlue, rec(i * 4 + 3))
            g.FillRectangle(Brushes.Yellow, rec(i * 4 + 4))
        Next
        Dim rect0 As New RectangleF(Hl - 45, Ht + Hx * 1, 45, Hx * 12)
        g.FillRectangle(Brushes.Gold, rect0)
        Dim rect3 As New RectangleF(Hl - 45, Ht + Hx * 13, 45, Hx * 12)
        g.FillRectangle(Brushes.LightGreen, rect3)
        Dim rect1 As New RectangleF(Hl - 90, Ht + Hx, 45, Hx * 12)
        g.FillRectangle(Brushes.Orange, rect1)
        Dim rect2 As New RectangleF(Hl - 90, Ht + Hx * 13, 45, Hx * 12)
        g.FillRectangle(Brushes.DarkGreen, rect2)
        '枠
        '罫線・縦細
        For i As Short = 0 To 6
            g.DrawLine(Pen1, Hl + Hy * i, Ht, Hl + Hy * i, Ht + Hx * 25)
        Next
        '罫線・横細
        For i As Short = 0 To 25
            g.DrawLine(Pen1, Hl, Ht + Hx * i, Hl + Hw, Ht + Hx * i)
        Next
        '罫線・縦太
        g.DrawLine(Pen3, Hl - 90, Ht, Hl - 90, Ht + Hx * 25)
        g.DrawLine(Pen3, Hl - 45, Ht + Hx, Hl - 45, Ht + Hx * 25)
        g.DrawLine(Pen3, Hl, Ht, Hl, Ht + Hx * 25)
        g.DrawLine(Pen3, Hl + Hy, Ht, Hl + Hy, Ht + Hx * 25)
        g.DrawLine(Pen3, Hl + Hw, Ht, Hl + Hw, Ht + Hx * 25)
        '罫線・横太
        g.DrawLine(Pen3, Hl - 90, Ht, Hl + Hw, Ht)
        g.DrawLine(Pen3, Hl - 90, Ht + Hx, Hl + Hw, Ht + Hx)
        g.DrawLine(Pen3, Hl - 90, Ht + Hx * 13, Hl + Hw, Ht + Hx * 13)
        g.DrawLine(Pen3, Hl - 90, Ht + Hx * 25, Hl + Hw, Ht + Hx * 25)
        For i As Short = 0 To 5
            g.DrawLine(Pen3, Hl - 45, Ht + Hx + Hx * 4 * i, Hl + Hw, Ht + Hx + Hx * 4 * i)
        Next
        'タイトル
        g.DrawString(ModelName + "リレー生産進捗集中モニター   Ver3.0", gf20, gcBlue, 130, 26)
        g.DrawString("   ライン名", gf12, gcBlack, 125, 70)
        g.DrawString("巻線１号ﾗｲﾝ", gf12, gcBlack, 125 + Hy, 70)
        g.DrawString("巻線２号ﾗｲﾝ", gf12, gcBlack, 125 + Hy * 2, 70)
        g.DrawString("前組１号ﾗｲﾝ", gf12, gcBlack, 125 + Hy * 3, 70)
        g.DrawString("前組２号ﾗｲﾝ", gf12, gcBlack, 125 + Hy * 4, 70)
        g.DrawString("   後組ﾗｲﾝ", gf12, gcBlack, 125 + Hy * 5, 70)
        For i As Long = 0 To 5
            g.DrawString("目標生産数", gf12, gcBlack, 115, 95 + 104 * i)
            g.DrawString("現在計画数", gf12, gcWhite, 115, 121 + 104 * i)
            g.DrawString("現在実績数", gf12, gcBlack, 115, 147 + 104 * i)
            g.DrawString("        差", gf12, gcBlack, 115, 173 + 104 * i)
        Next i
        g.DrawString("１", gf12, gcBlack, 47 + 20, 120)
        g.DrawString("直", gf12, gcBlack, 47 + 16, 145)
        g.DrawString("２", gf12, gcBlack, 47 + 20, 220)
        g.DrawString("直", gf12, gcBlack, 47 + 16, 245)
        g.DrawString("合", gf12, gcBlack, 47 + 16, 320)
        g.DrawString("計", gf12, gcBlack, 47 + 16, 345)
        g.DrawString("１", gf12, gcBlack, 47 + 20, 120 + Hx * 12)
        g.DrawString("直", gf12, gcBlack, 47 + 16, 145 + Hx * 12)
        g.DrawString("２", gf12, gcBlack, 47 + 20, 220 + Hx * 12)
        g.DrawString("直", gf12, gcBlack, 47 + 16, 245 + Hx * 12)
        g.DrawString("合", gf12, gcBlack, 47 + 16, 320 + Hx * 12)
        g.DrawString("計", gf12, gcBlack, 47 + 16, 345 + Hx * 12)

        g.DrawString("１", gf24, gcBlack, 15, 140)
        g.DrawString("号", gf24, gcBlack, 10, 180)
        g.DrawString("ラ", gf24, gcBlack, 15, 220)
        g.DrawString("イ", gf24, gcBlack, 15, 260)
        g.DrawString("ン", gf24, gcBlack, 15, 300)
        g.DrawString("２", gf24, gcYellow, 15, 140 + Hx * 12)
        g.DrawString("号", gf24, gcYellow, 10, 180 + Hx * 12)
        g.DrawString("ラ", gf24, gcYellow, 15, 220 + Hx * 12)
        g.DrawString("イ", gf24, gcYellow, 15, 260 + Hx * 12)
        g.DrawString("ン", gf24, gcYellow, 15, 300 + Hx * 12)
        '累計
        Dim rect20 As New RectangleF(1010, 30, 355, Hx + 15)
        g.FillRectangle(Brushes.LightPink, rect20)
        Dim rect21 As New RectangleF(1140, 70, 355, Hx * 2 + 30)
        g.FillRectangle(Brushes.White, rect21)
        Dim rect22 As New RectangleF(1010, 70, 130, Hx + 15)
        g.FillRectangle(Brushes.Orange, rect22)
        Dim rect23 As New RectangleF(1010, 85 + Hx, 130, Hx + 15)
        g.FillRectangle(Brushes.DarkGreen, rect23)
        g.DrawLine(Pen3, 1010, 30, 1365, 30)
        g.DrawLine(Pen3, 1010, 30 + 15 + Hx, 1365, 30 + 15 + Hx)
        g.DrawLine(Pen1, 1010, 30 + 30 + Hx * 2, 1365, 30 + 30 + Hx * 2)
        g.DrawLine(Pen3, 1010, 30 + 45 + Hx * 3, 1365, 30 + 45 + Hx * 3)
        g.DrawLine(Pen3, 1010, 30, 1010, 30 + 45 + Hx * 3)
        g.DrawLine(Pen3, 1365, 30, 1365, 30 + 45 + Hx * 3)
        g.DrawLine(Pen3, 1140, 30 + 15 + Hx, 1140, 30 + 45 + Hx * 3)
        g.DrawString("月度 累計出来高", gf20, gcBlack, 1110, 38)
        g.DrawString("１号ﾗｲﾝ", gf20, gcBlack, 1020, 30 + 20 + Hx * 1)
        g.DrawString("２号ﾗｲﾝ", gf20, gcYellow, 1020, 30 + 35 + Hx * 2)
        '班別
        Dim rect30 As New RectangleF(1010, 3 + Hx * 6, 355, Hx)
        g.FillRectangle(Brushes.LightPink, rect30)
        Dim rect31 As New RectangleF(1010, 3 + Hx * 7, 60, Hx * 3)
        g.FillRectangle(Brushes.Orange, rect31)
        Dim rect32 As New RectangleF(1010, 3 + Hx * 10, 60, Hx * 3)
        g.FillRectangle(Brushes.DarkGreen, rect32)
        Dim rect33 As New RectangleF(1070, 3 + Hx * 7, 70, Hx * 3)
        g.FillRectangle(Brushes.Gold, rect33)
        Dim rect34 As New RectangleF(1070, 3 + Hx * 10, 70, Hx * 3)
        g.FillRectangle(Brushes.LightGreen, rect34)
        Dim rect35 As New RectangleF(1140, 3 + Hx * 7, 225, Hx * 6)
        g.FillRectangle(Brushes.White, rect35)
        g.DrawLine(Pen3, 1010, 3 + Hx * 6, 1365, 3 + Hx * 6)
        g.DrawLine(Pen3, 1010, 3 + Hx * 7, 1365, 3 + Hx * 7)
        g.DrawLine(Pen3, 1010, 3 + Hx * 10, 1365, 3 + Hx * 10)
        g.DrawLine(Pen3, 1010, 3 + Hx * 13, 1365, 3 + Hx * 13)
        g.DrawLine(Pen3, 1010, 3 + Hx * 6, 1010, 3 + Hx * 13)
        g.DrawLine(Pen3, 1070, 3 + Hx * 7, 1070, 3 + Hx * 13)
        g.DrawLine(Pen3, 1140, 3 + Hx * 7, 1140, 3 + Hx * 13)
        g.DrawLine(Pen3, 1365, 3 + Hx * 6, 1365, 3 + Hx * 13)
        g.DrawLine(Pen1, 1070, 3 + Hx * 8, 1365, 3 + Hx * 8)
        g.DrawLine(Pen1, 1070, 3 + Hx * 9, 1365, 3 + Hx * 9)
        g.DrawLine(Pen1, 1070, 3 + Hx * 11, 1365, 3 + Hx * 11)
        g.DrawLine(Pen1, 1070, 3 + Hx * 12, 1365, 3 + Hx * 12)
        g.DrawString("月度 班別実績数", gf18, gcBlack, 1060, 3 + Hx * 6)
        g.DrawString("(日産平均)", gf12, gcBlack, 1270, 6 + Hx * 6)
        g.DrawString("Ａ班", gf18, gcBlack, 1078, 3 + Hx * 7)
        g.DrawString("Ｂ班", gf18, gcBlack, 1078, 3 + Hx * 8)
        g.DrawString("Ａ班", gf18, gcBlack, 1078, 3 + Hx * 10)
        g.DrawString("Ｂ班", gf18, gcBlack, 1078, 3 + Hx * 11)
        g.DrawString("１", gf20, gcBlack, 1024, 13 + Hx * 7)
        g.DrawString("号", gf20, gcBlack, 1020, 13 + Hx * 8)
        g.DrawString("２", gf20, gcYellow, 1024, 13 + Hx * 10)
        g.DrawString("号", gf20, gcYellow, 1020, 13 + Hx * 11)
        If Han = 3 Then
            g.DrawString("Ｃ班", gf18, gcBlack, 1078, 3 + Hx * 9)
            g.DrawString("Ｃ班", gf18, gcBlack, 1078, 3 + Hx * 12)
        End If
        ''達成率
        Dim rect50 As New RectangleF(1010, 8 + Hx * 13, 355, Hx)
        g.FillRectangle(Brushes.LightPink, rect50)
        Dim rect51 As New RectangleF(1010, 8 + Hx * 14, 60, Hx * 3)
        g.FillRectangle(Brushes.Orange, rect51)
        Dim rect52 As New RectangleF(1010, 8 + Hx * 17, 60, Hx * 3)
        g.FillRectangle(Brushes.DarkGreen, rect52)
        Dim rect53 As New RectangleF(1070, 8 + Hx * 14, 70, Hx * 3)
        g.FillRectangle(Brushes.Gold, rect53)
        Dim rect54 As New RectangleF(1070, 8 + Hx * 17, 70, Hx * 3)
        g.FillRectangle(Brushes.LightGreen, rect54)
        Dim rect55 As New RectangleF(1140, 8 + Hx * 14, 225, Hx * 6)
        g.FillRectangle(Brushes.White, rect55)
        g.DrawLine(Pen3, 1010, 8 + Hx * 13, 1365, 8 + Hx * 13)
        g.DrawLine(Pen3, 1010, 8 + Hx * 14, 1365, 8 + Hx * 14)
        g.DrawLine(Pen3, 1010, 8 + Hx * 17, 1365, 8 + Hx * 17)
        g.DrawLine(Pen3, 1010, 8 + Hx * 20, 1365, 8 + Hx * 20)
        g.DrawLine(Pen3, 1010, 8 + Hx * 13, 1010, 8 + Hx * 20)
        g.DrawLine(Pen3, 1070, 8 + Hx * 14, 1070, 8 + Hx * 20)
        g.DrawLine(Pen3, 1140, 8 + Hx * 14, 1140, 8 + Hx * 20)
        g.DrawLine(Pen3, 1365, 8 + Hx * 13, 1365, 8 + Hx * 20)
        g.DrawLine(Pen1, 1070, 8 + Hx * 15, 1365, 8 + Hx * 15)
        g.DrawLine(Pen1, 1070, 8 + Hx * 16, 1365, 8 + Hx * 16)
        g.DrawLine(Pen1, 1070, 8 + Hx * 18, 1365, 8 + Hx * 18)
        g.DrawLine(Pen1, 1070, 8 + Hx * 19, 1365, 8 + Hx * 19)
        g.DrawString("現在達成率", gf18, gcBlack, 1100, 8 + Hx * 13)
        g.DrawString("巻線", gf18, gcBlack, 1075, 8 + Hx * 14)
        g.DrawString("前組", gf18, gcBlack, 1075, 8 + Hx * 15)
        g.DrawString("後組", gf18, gcBlack, 1075, 8 + Hx * 16)
        g.DrawString("巻線", gf18, gcBlack, 1075, 8 + Hx * 17)
        g.DrawString("前組", gf18, gcBlack, 1075, 8 + Hx * 18)
        g.DrawString("後組", gf18, gcBlack, 1075, 8 + Hx * 19)
        g.DrawString("１", gf20, gcBlack, 1024, 13 + Hx * 14)
        g.DrawString("号", gf20, gcBlack, 1020, 13 + Hx * 15)
        g.DrawString("２", gf20, gcYellow, 1024, 13 + Hx * 17)
        g.DrawString("号", gf20, gcYellow, 1020, 13 + Hx * 18)
        '稼働率・直行率
        Dim rect40 As New RectangleF(1010, 13 + Hx * 20, 355, Hx)
        g.FillRectangle(Brushes.LightPink, rect40)
        Dim rect41 As New RectangleF(1010, 13 + Hx * 21, 60, Hx * 3)
        g.FillRectangle(Brushes.Orange, rect41)
        Dim rect42 As New RectangleF(1010, 13 + Hx * 24, 60, Hx * 3)
        g.FillRectangle(Brushes.DarkGreen, rect42)
        Dim rect43 As New RectangleF(1070, 13 + Hx * 21, 70, Hx * 3)
        g.FillRectangle(Brushes.Gold, rect43)
        Dim rect44 As New RectangleF(1070, 13 + Hx * 24, 70, Hx * 3)
        g.FillRectangle(Brushes.LightGreen, rect44)
        Dim rect45 As New RectangleF(1140, 13 + Hx * 21, 225, Hx * 6)
        g.FillRectangle(Brushes.White, rect45)
        g.DrawLine(Pen3, 1010, 13 + Hx * 20, 1365, 13 + Hx * 20)
        g.DrawLine(Pen3, 1010, 13 + Hx * 21, 1365, 13 + Hx * 21)
        g.DrawLine(Pen3, 1010, 13 + Hx * 24, 1365, 13 + Hx * 24)
        g.DrawLine(Pen3, 1010, 13 + Hx * 27, 1365, 13 + Hx * 27)
        g.DrawLine(Pen3, 1010, 13 + Hx * 20, 1010, 13 + Hx * 27)
        g.DrawLine(Pen3, 1070, 13 + Hx * 21, 1070, 13 + Hx * 27)
        g.DrawLine(Pen3, 1140, 13 + Hx * 20, 1140, 13 + Hx * 27)
        g.DrawLine(Pen3, 1250, 13 + Hx * 20, 1250, 13 + Hx * 27)
        g.DrawLine(Pen3, 1365, 13 + Hx * 20, 1365, 13 + Hx * 27)
        g.DrawLine(Pen1, 1070, 13 + Hx * 22, 1365, 13 + Hx * 22)
        g.DrawLine(Pen1, 1070, 13 + Hx * 23, 1365, 13 + Hx * 23)
        g.DrawLine(Pen1, 1070, 13 + Hx * 25, 1365, 13 + Hx * 25)
        g.DrawLine(Pen1, 1070, 13 + Hx * 26, 1365, 13 + Hx * 26)
        g.DrawString("稼働率", gf18, gcBlack, 1150, 13 + Hx * 20)
        g.DrawString("直行率", gf18, gcBlack, 1260, 13 + Hx * 20)
        g.DrawString("前１", gf18, gcBlack, 1078, 13 + Hx * 21)
        g.DrawString("前２", gf18, gcBlack, 1078, 13 + Hx * 22)
        g.DrawString("後組", gf18, gcBlack, 1075, 13 + Hx * 23)
        g.DrawString("前１", gf18, gcBlack, 1078, 13 + Hx * 24)
        g.DrawString("前２", gf18, gcBlack, 1078, 13 + Hx * 25)
        g.DrawString("後組", gf18, gcBlack, 1075, 13 + Hx * 26)
        g.DrawString("１", gf20, gcBlack, 1024, 18 + Hx * 21)
        g.DrawString("号", gf20, gcBlack, 1020, 18 + Hx * 22)
        g.DrawString("２", gf20, gcYellow, 1024, 18 + Hx * 24)
        g.DrawString("号", gf20, gcYellow, 1020, 18 + Hx * 25)
        Dim Mx As Long = GetMonth()
        'Dim Dx As Long = GetDay()
        Dim sx As String = ""
        If Mx < 10 Then
            sx = " " + Trim(Str(Mx))
        Else
            sx = Trim(Str(Mx))
        End If
        g.DrawString(sx, gf24, gcBlack, 1060, 35)
        g.DrawString(sx, gf20, gcBlack, 1030, Hx * 6)
        ''--- 
        For j As Integer = 0 To 1
            Dim px As Integer = 0
            Dim pf As Short = 18
            For i As Integer = 0 To 4
                px = 70 + Hl + Hy * (i + 1) + 60
                '合計表示
                If j = 1 And L2choku1Nomi = 1 Then
                    Pr(g, WrPlnB(j, i), px, Ht + Hx * (9 + 12 * j), gcBlue, pf)
                    Pr(g, WrTrgB(j, i), px, Ht + Hx * (10 + 12 * j), gcWhite, pf)
                    Pr(g, WrCntB(j, i), px, Ht + Hx * (11 + 12 * j), gcBlack, pf)
                    Pr(g, WrDelB(j, i), px, Ht + Hx * (12 + 12 * j), gcBlack, pf)
                Else
                    Pr(g, WrPlnA(j, i), px, Ht + Hx * (9 + 12 * j), gcBlue, pf)
                    Pr(g, WrTrgA(j, i), px, Ht + Hx * (10 + 12 * j), gcWhite, pf)
                    Pr(g, WrCntA(j, i), px, Ht + Hx * (11 + 12 * j), gcBlack, pf)
                    Pr(g, WrDelA(j, i), px, Ht + Hx * (12 + 12 * j), gcBlack, pf)
                End If
                '1直表示
                Pr(g, WrPlnB(j, i), px, Ht + Hx * (1 + 12 * j), gcBlue, pf)
                Pr(g, WrTrgB(j, i), px, Ht + Hx * (2 + 12 * j), gcWhite, pf)
                Pr(g, WrCntB(j, i), px, Ht + Hx * (3 + 12 * j), gcBlack, pf)
                Pr(g, WrDelB(j, i), px, Ht + Hx * (4 + 12 * j), gcBlack, pf)
                '2直表示
                If j = 0 Or L2choku1Nomi = 0 Then
                    If ChokuFlag = True Then
                        Pr(g, WrPlnB(j, i), px, Ht + Hx * (5 + 12 * j), gcBlue, pf)
                        Pr(g, WrTrgC(j, i), px, Ht + Hx * (6 + 12 * j), gcWhite, pf)
                        Pr(g, WrCntC(j, i), px, Ht + Hx * (7 + 12 * j), gcBlack, pf)
                        Pr(g, WrDelC(j, i), px, Ht + Hx * (8 + 12 * j), gcBlack, pf)
                    End If
                End If
            Next
            '稼働率表示
            Dim gof As Integer = 0
            Dim gColor As System.Drawing.Brush
            For i As Integer = 0 To 2
                If WrRat(j, i) = 100 Then
                    gof = 40
                ElseIf WrRat(j, i) < 100 And WrRat(j, i) >= 10 Then
                    gof = 48
                Else
                    gof = 53
                End If
                If WrRat(j, i) > 80 Then
                    gColor = gcBlue
                ElseIf WrRat(j, i) > 70 Then
                    gColor = gcDarkGreen
                Else
                    gColor = gcRed
                End If
                g.DrawString(PutValue(WrRat(j, i)) + "%", gf18, gColor, 1080 + gof, 560 + (i + j * 3) * Hx)
            Next
            '直行率表示
            For i As Short = 0 To 2
                If WrCho(j, i) >= 100 Then
                    gof = 65
                ElseIf WrCho(j, i) < 100 And WrCho(j, i) >= 10 Then
                    gof = 58
                Else
                    gof = 72
                End If
                If WrCho(j, i) > 98 Then
                    gColor = gcBlue
                ElseIf WrCho(j, i) > 95 Then
                    gColor = gcDeepPink
                Else
                    gColor = gcRed
                End If
                g.DrawString(CnvPercentageString(WrCho(j, i)) + "%", gf18, gColor, 1210 + gof, 560 + (i + j * 3) * Hx)
            Next i
            '出来高表示
            Dim zx As Integer = DekidakaTotal(j) + DekidakaHosei(j) + NowC(j, 4) * Qu(j, 4) + Geta(j, 4)
            Pr(g, zx, 1330, 71 + 41 * j, gcBlack, 28)
            '達成率表示
            Dim ax(1, 2) As Integer
            Dim bx(1, 2) As Integer
            Dim cx(1, 2) As Integer
            bx(j, 0) = CInt(Val(Replace(dtrg(j, 0), ",", "")) + Val(Replace(dtrg(j, 1), ",", "")))
            bx(j, 1) = CInt(Val(Replace(dtrg(j, 2), ",", "")) + Val(Replace(dtrg(j, 3), ",", "")))
            bx(j, 2) = CInt(Val(Replace(dtrg(j, 4), ",", "")))
            cx(j, 0) = CInt(Val(Replace(dnow(j, 0), ",", "")) + Val(Replace(dnow(j, 1), ",", "")))
            cx(j, 1) = CInt(Val(Replace(dnow(j, 2), ",", "")) + Val(Replace(dnow(j, 3), ",", "")))
            cx(j, 2) = CInt(Val(Replace(dnow(j, 4), ",", "")))
            For i As Short = 0 To 2
                If bx(j, i) <> 0 Then
                    ax(j, i) = CInt(cx(j, i) / bx(j, i) * 100)
                    If ax(j, i) = 100 And bx(j, i) > cx(j, i) Then ax(j, i) = 99
                Else
                    ax(j, i) = 0
                End If
            Next i
            For i As Short = 0 To 2
                If ax(j, i) > 999 Then ax(j, i) = 999
                Select Case ax(j, i)
                    Case 0 To 9
                        g.DrawString(Str(ax(j, i)) + "%", gf18, gcBlack, 1220, 373 + (i + j * 3) * Hx)
                    Case 10 To 99
                        g.DrawString(Str(ax(j, i)) + "%", gf18, gcBlack, 1220 - 14, 373 + (i + j * 3) * Hx)
                    Case Else
                        g.DrawString(Str(ax(j, i)) + "%", gf18, gcBlack, 1220 - 14 * 2, 373 + (i + j * 3) * Hx)
                End Select
            Next i
            '班別実績表示
            GrupJisseki()
            For i As Short = 0 To 2
                Pr(g, GpData(j, i), 1300, 182 + (i + j * 3) * Hx, gcBlack, 20)
            Next i
        Next j
        'バッファー内容表示()
        myBuffer.Render()
        'バッファー内容クリア
        myBuffer.Dispose()
    End Sub

    Public Sub DrawScreen3()
        'ダブルバッファー設定
        Dim currentContext As BufferedGraphicsContext
        Dim myBuffer As BufferedGraphics
        currentContext = BufferedGraphicsManager.Current
        myBuffer = currentContext.Allocate(Me.CreateGraphics(), New Rectangle(0, 0, 1500, 800))
        Dim g As Graphics = myBuffer.Graphics
        '---
        Dim Lc(1) As SolidBrush
        Dim Lp(1) As SolidBrush
        Lc(0) = New SolidBrush(Color.Orange)
        Lc(1) = New SolidBrush(Color.DarkGreen)
        Lp(0) = New SolidBrush(Color.Black)
        Lp(1) = New SolidBrush(Color.Yellow)
        'Dim Lc As Object
        '画面ｸﾘｱ
        Dim rect0x As New RectangleF(0, 0, 1500, 800)
        g.FillRectangle(Brushes.LemonChiffon, rect0x)
        '---
        Dim Ht As Short = 65        '表の上端
        Dim Hl As Short = 70      '表の左端
        Dim Hx As Short = 30        '表の桁の高さ
        Dim Hy As Short = 118         '表の桁の幅
        Dim Hw As Integer = Hy * 5         '表の幅
        Dim rec(25) As RectangleF
        '---
        'ﾊﾞｯｸｶﾗｰ
        For i As Short = 0 To 25
            rec(i) = New RectangleF(Hl, Ht + Hx * i, Hw * 2 + 110, Hx)
        Next i
        g.FillRectangle(Brushes.LightPink, rec(0))
        For i As Short = 0 To 2
            g.FillRectangle(Brushes.White, rec(i * 4 + 1))
            g.FillRectangle(Brushes.Blue, rec(i * 4 + 2))
            g.FillRectangle(Brushes.LightBlue, rec(i * 4 + 3))
            g.FillRectangle(Brushes.Yellow, rec(i * 4 + 4))
        Next
        '枠
        '罫線・縦細
        For i As Short = 0 To 4
            g.DrawLine(Pen1, 70 + Hl + Hy * i, Ht, 70 + Hl + Hy * i, Ht + Hx * 13)
        Next
        For i As Short = 0 To 4
            g.DrawLine(Pen1, Hw + 110 + Hl + Hy * i, Ht, Hw + 110 + Hl + Hy * i, Ht + Hx * 13)
        Next
        '罫線・横細
        For i As Short = 0 To 12
            g.DrawLine(Pen1, Hl, Ht + Hx * i, Hl + 110 + Hw * 2, Ht + Hx * i)
        Next
        '
        Dim rect0 As New RectangleF(Hl - 30, Ht + Hx * 1, 30, Hx * 12)
        g.FillRectangle(Brushes.Gold, rect0)
        'Dim rect3 As New RectangleF(Hl - 45, Ht + Hx * 13, 45, Hx * 12)
        'g.FillRectangle(Brushes.LightGreen, rect3)
        Dim rect1 As New RectangleF(Hl - 65, Ht + Hx, 35, Hx * 12)
        g.FillRectangle(Brushes.Orange, rect1)
        '罫線・縦太
        g.DrawLine(Pen3, Hl - 65, Ht, Hl - 65, Ht + Hx * 13)
        g.DrawLine(Pen3, Hl - 30, Ht + Hx, Hl - 30, Ht + Hx * 13)
        g.DrawLine(Pen3, Hl, Ht, Hl, Ht + Hx * 13)
        g.DrawLine(Pen3, Hl + 70, Ht, Hl + 70, Ht + Hx * 13)
        g.DrawLine(Pen3, Hl + Hw + 70, Ht, Hl + Hw + 70, Ht + Hx * 13)
        g.DrawLine(Pen3, Hl + Hw + 75, Ht, Hl + Hw + 75, Ht + Hx * 13)
        g.DrawLine(Pen3, Hl + Hw + 110, Ht, Hl + Hw + 110, Ht + Hx * 13)
        g.DrawLine(Pen3, Hl + Hw * 2 + 110, Ht, Hl + Hw * 2 + 110, Ht + Hx * 13)
        '罫線・横太
        g.DrawLine(Pen3, Hl - 65, Ht, Hl + 110 + Hw * 2, Ht)
        g.DrawLine(Pen3, Hl - 65, Ht + Hx, Hl + 110 + Hw * 2, Ht + Hx)
        g.DrawLine(Pen3, Hl - 65, Ht + Hx * 13, Hl + 110 + Hw * 2, Ht + Hx * 13)
        g.DrawLine(Pen3, Hl - 30, Ht + Hx + Hx * 4, Hl + 110 + Hw * 2, Ht + Hx + Hx * 4)
        g.DrawLine(Pen3, Hl - 30, Ht + Hx + Hx * 8, Hl + 110 + Hw * 2, Ht + Hx + Hx * 8)
        Dim rect2 As New RectangleF(Hl + Hw + 77, Ht + Hx + 2, 32, Hx * 12 - 3)
        g.FillRectangle(Brushes.DarkGreen, rect2)
        Dim rect3 As New RectangleF(Hl + Hw + 70 + 2, Ht - 3, 2, Hx * 13 + 5)
        g.FillRectangle(Brushes.LemonChiffon, rect3)
        Dim rect4 As New RectangleF(Hl + Hw + 70 + 7, Ht + 2, 31, 27)
        g.FillRectangle(Brushes.LemonChiffon, rect4)
        'タイトル
        g.DrawString(ModelName + "リレー生産進捗集中モニター   Ver3.0", gf20, gcBlue, 130, 26)
        g.DrawString("ライン名", gf12, gcBlack, 75, 70)
        g.DrawString("巻線１号ﾗｲﾝ", gf12, gcBlack, 25 + Hy, 70)
        g.DrawString("巻線２号ﾗｲﾝ", gf12, gcBlack, 25 + Hy * 2, 70)
        g.DrawString("前組１号ﾗｲﾝ", gf12, gcBlack, 25 + Hy * 3, 70)
        g.DrawString("前組２号ﾗｲﾝ", gf12, gcBlack, 25 + Hy * 4, 70)
        g.DrawString("   後組ﾗｲﾝ", gf12, gcBlack, 25 + Hy * 5, 70)
        g.DrawString("巻線１号ﾗｲﾝ", gf12, gcBlack, 65 + Hw + Hy, 70)
        g.DrawString("巻線２号ﾗｲﾝ", gf12, gcBlack, 65 + Hw + Hy * 2, 70)
        g.DrawString("前組１号ﾗｲﾝ", gf12, gcBlack, 65 + Hw + Hy * 3, 70)
        g.DrawString("前組２号ﾗｲﾝ", gf12, gcBlack, 65 + Hw + Hy * 4, 70)
        g.DrawString("   後組ﾗｲﾝ", gf12, gcBlack, 65 + Hw + Hy * 5, 70)
        For i As Long = 0 To 2
            g.DrawString("目標", gf18, gcBlack, 76, 97 + 120 * i)
            g.DrawString("計画", gf18, gcWhite, 76, 127 + 120 * i)
            g.DrawString("実績", gf18, gcBlack, 76, 157 + 120 * i)
            g.DrawString("  差", gf18, gcBlack, 76, 187 + 120 * i)
        Next i
        g.DrawString("１", gf12, gcBlack, 47 + 0, 130)
        g.DrawString("直", gf12, gcBlack, 47 - 4, 160)
        g.DrawString("２", gf12, gcBlack, 47 + 0, 250)
        g.DrawString("直", gf12, gcBlack, 47 - 4, 280)
        g.DrawString("合", gf12, gcBlack, 47 - 4, 360)
        g.DrawString("計", gf12, gcBlack, 47 - 4, 390)

        g.DrawString("１", gf24, gcBlack, 5, 160)
        g.DrawString("号", gf24, gcBlack, 0, 200)
        g.DrawString("ラ", gf24, gcBlack, 5, 240)
        g.DrawString("イ", gf24, gcBlack, 5, 280)
        g.DrawString("ン", gf24, gcBlack, 5, 320)
        g.DrawString("２", gf24, gcYellow, 75 + Hl + Hw, 160)
        g.DrawString("号", gf24, gcYellow, 70 + Hl + Hw, 200)
        g.DrawString("ラ", gf24, gcYellow, 75 + Hl + Hw, 240)
        g.DrawString("イ", gf24, gcYellow, 75 + Hl + Hw, 280)
        g.DrawString("ン", gf24, gcYellow, 75 + Hl + Hw, 320)
        '累計()
        Dim hxx As Integer = 38
        Dim rect20 As New RectangleF(5, 460, 1355, hxx)
        g.FillRectangle(Brushes.LightPink, rect20)
        Dim rect21 As New RectangleF(5, 460 + hxx, 1355, hxx * 6)
        g.FillRectangle(Brushes.White, rect21)
        Dim rect22 As New RectangleF(5, 498, 100, hxx * 3)
        g.FillRectangle(Brushes.Orange, rect22)
        Dim rect23 As New RectangleF(5, 498 + hxx * 3, 100, hxx * 3)
        g.FillRectangle(Brushes.DarkGreen, rect23)
        Dim rect24 As New RectangleF(258 + Hy + 10, 498, 100, hxx * 6)
        g.FillRectangle(Brushes.LightBlue, rect24)
        Dim rect25 As New RectangleF(258 + Hy * 3 + 80, 498, 105, hxx * 6)
        g.FillRectangle(Brushes.LightBlue, rect25)
        Dim rect26 As New RectangleF(258 + Hy * 5 + 105, 498, 100, hxx * 6)
        g.FillRectangle(Brushes.LightBlue, rect26)
        g.DrawLine(Pen3, 5, 460, 1360, 460)
        g.DrawLine(Pen3, 5, 460 + hxx, 1360, 460 + hxx)
        g.DrawLine(Pen3, 5, 460 + hxx * 4, 1360, 460 + hxx * 4)
        g.DrawLine(Pen3, 5, 460 + hxx * 7, 1360, 460 + hxx * 7)
        For i As Short = 0 To 7
            g.DrawLine(Pen1, 105 + Hy * 2 + 45, 460 + hxx * i, 1360, 460 + hxx * i)
        Next
        g.DrawLine(Pen3, 5, 460, 5, 726)
        g.DrawLine(Pen3, 70 + 35, 498, 70 + 35, 726)
        g.DrawLine(Pen3, 258 + Hy + 10, 460, 258 + Hy + 10, 726)
        g.DrawLine(Pen3, 258 + Hy + 110, 498, 258 + Hy + 110, 726)
        g.DrawLine(Pen3, 140 + Hy * 4 + 70 + 10, 460, 140 + Hy * 4 + 70 + 10, 726)
        g.DrawLine(Pen3, 140 + Hy * 4 + 70 + 116, 498, 140 + Hy * 4 + 70 + 116, 726)
        g.DrawLine(Pen3, 140 + Hy * 6 + 106, 460, 140 + Hy * 6 + 106, 726)
        g.DrawLine(Pen3, 140 + Hy * 6 + 70 + 136, 498, 140 + Hy * 6 + 70 + 136, 726)
        g.DrawLine(Pen3, 140 + Hy * 7 + 70 + 50 + 121, 460, 140 + Hy * 7 + 70 + 50 + 121, 726)
        g.DrawLine(Pen3, 140 + Hy * 8 + 70 + 100 + 106, 460, 140 + Hy * 8 + 70 + 100 + 106, 726)
        g.DrawString("月度 累計出来高", gf20, gcBlack, 150, 465)
        g.DrawString("１", gf28, gcBlack, 35, 510)
        g.DrawString("号", gf28, gcBlack, 30, 560)
        g.DrawString("２", gf28, gcYellow, 35, 620)
        g.DrawString("号", gf28, gcYellow, 30, 670)
        ''班別
        g.DrawString("月度班別実績", gf20, gcBlack, 420, 465)
        g.DrawString("(日産平均)", gf12, gcBlack, 602, 475)
        g.DrawString("Ａ班", gf18, gcBlack, 405, 505)
        g.DrawString("Ｂ班", gf18, gcBlack, 405, 505 + hxx * 1)
        g.DrawString("Ａ班", gf18, gcBlack, 405, 505 + hxx * 3)
        g.DrawString("Ｂ班", gf18, gcBlack, 405, 505 + hxx * 4)
        If Han = 3 Then
            g.DrawString("Ｃ班", gf18, gcBlack, 405, 505 + hxx * 2)
            g.DrawString("Ｃ班", gf18, gcBlack, 405, 505 + hxx * 5)
        End If
        '達成率
        g.DrawString("現在達成率", gf20, gcBlack, 780, 465)
        g.DrawString("巻線", gf18, gcBlack, 715, 467 + hxx)
        g.DrawString("前組", gf18, gcBlack, 715, 467 + hxx * 2)
        g.DrawString("後組", gf18, gcBlack, 715, 467 + hxx * 3)
        g.DrawString("巻線", gf18, gcBlack, 715, 467 + hxx * 4)
        g.DrawString("前組", gf18, gcBlack, 715, 467 + hxx * 5)
        g.DrawString("後組", gf18, gcBlack, 715, 467 + hxx * 6)
        '稼働率・直行率
        g.DrawString("稼働率", gf20, gcBlack, 1080, 465)
        g.DrawString("直行率", gf20, gcBlack, 1240, 465)
        g.DrawString("前組１", gf18, gcBlack, 965, 465 + hxx)
        g.DrawString("前組２", gf18, gcBlack, 965, 465 + hxx * 2)
        g.DrawString("後組", gf18, gcBlack, 970, 465 + hxx * 3)
        g.DrawString("前組１", gf18, gcBlack, 965, 465 + hxx * 4)
        g.DrawString("前組２", gf18, gcBlack, 965, 465 + hxx * 5)
        g.DrawString("後組", gf18, gcBlack, 970, 465 + hxx * 6)
        Dim Mx As Long = GetMonth()
        Dim sx As String = ""
        If Mx < 10 Then
            sx = " " + Trim(Str(Mx))
        Else
            sx = Trim(Str(Mx))
        End If
        g.DrawString(sx, gf24, gcBlack, 110, 462)
        g.DrawString(sx, gf24, gcBlack, 385, 462)
        ''--- 
        For j As Integer = 0 To 1
            Dim px As Integer = 0
            Dim pf As Short = 20
            For i As Integer = 0 To 4
                px = 55 + Hl + Hy * (i + 1) + (Hw + 40) * j
                '合計表示
                If j = 1 And L2choku1Nomi = 1 Then
                    Pr(g, WrPlnB(j, i), px, Ht + Hx * 9, gcBlue, pf)
                    Pr(g, WrTrgB(j, i), px, Ht + Hx * 10, gcWhite, pf)
                    Pr(g, WrCntB(j, i), px, Ht + Hx * 11, gcBlack, pf)
                    Pr(g, WrDelB(j, i), px, Ht + Hx * 12, gcBlack, pf)
                Else
                    Pr(g, WrPlnA(j, i), px, Ht + Hx * 9, gcBlue, pf)
                    Pr(g, WrTrgA(j, i), px, Ht + Hx * 10, gcWhite, pf)
                    Pr(g, WrCntA(j, i), px, Ht + Hx * 11, gcBlack, pf)
                    Pr(g, WrDelA(j, i), px, Ht + Hx * 12, gcBlack, pf)
                End If
                '1直表示
                Pr(g, WrPlnB(j, i), px, Ht + Hx * 1, gcBlue, pf)
                Pr(g, WrTrgB(j, i), px, Ht + Hx * 2, gcWhite, pf)
                Pr(g, WrCntB(j, i), px, Ht + Hx * 3, gcBlack, pf)
                Pr(g, WrDelB(j, i), px, Ht + Hx * 4, gcBlack, pf)
                '2直表示
                If j = 0 Or L2choku1Nomi = 0 Then
                    If ChokuFlag = True Then
                        Pr(g, WrPlnB(j, i), px, Ht + Hx * 5, gcBlue, pf)
                        Pr(g, WrTrgC(j, i), px, Ht + Hx * 6, gcWhite, pf)
                        Pr(g, WrCntC(j, i), px, Ht + Hx * 7, gcBlack, pf)
                        Pr(g, WrDelC(j, i), px, Ht + Hx * 8, gcBlack, pf)
                    End If
                End If
            Next
            '稼働率表示
            Dim gof As Integer = 0
            Dim gColor As System.Drawing.Brush
            For i As Integer = 0 To 2
                If WrRat(j, i) = 100 Then
                    gof = 40
                ElseIf WrRat(j, i) < 100 And WrRat(j, i) >= 10 Then
                    gof = 48
                Else
                    gof = 56
                End If
                If WrRat(j, i) > 80 Then
                    gColor = gcBlue
                ElseIf WrRat(j, i) > 70 Then
                    gColor = gcDarkGreen
                Else
                    gColor = gcRed
                End If
                g.DrawString(PutValue(WrRat(j, i)) + "%", gf24, gColor, 990 + gof, 500 + (i + j * 3) * hxx)
            Next
            '直行率表示
            For i As Short = 0 To 2
                If WrCho(j, i) >= 100 Then
                    gof = 65
                ElseIf WrCho(j, i) < 100 And WrCho(j, i) >= 10 Then
                    gof = 58
                Else
                    gof = 75
                End If
                If WrCho(j, i) > 98 Then
                    gColor = gcBlue
                ElseIf WrCho(j, i) > 95 Then
                    gColor = gcDeepPink
                Else
                    gColor = gcRed
                End If
                g.DrawString(CnvPercentageString(WrCho(j, i)) + "%", gf24, gColor, 1185 + gof, 500 + (i + j * 3) * hxx)
            Next i
            '出来高表示
            Dim zx As Integer = DekidakaTotal(j) + DekidakaHosei(j) + NowC(j, 4) * Qu(j, 4) + Geta(j, 4)
            Pr(g, zx, 350, 520 + 110 * j, gcBlack, 40)
            ''達成率表示
            Dim ax(1, 2) As Integer
            Dim bx(1, 2) As Integer
            Dim cx(1, 2) As Integer
            bx(j, 0) = CInt(Val(Replace(dtrg(j, 0), ",", "")) + Val(Replace(dtrg(j, 1), ",", "")))
            bx(j, 1) = CInt(Val(Replace(dtrg(j, 2), ",", "")) + Val(Replace(dtrg(j, 3), ",", "")))
            bx(j, 2) = CInt(Val(Replace(dtrg(j, 4), ",", "")))
            cx(j, 0) = CInt(Val(Replace(dnow(j, 0), ",", "")) + Val(Replace(dnow(j, 1), ",", "")))
            cx(j, 1) = CInt(Val(Replace(dnow(j, 2), ",", "")) + Val(Replace(dnow(j, 3), ",", "")))
            cx(j, 2) = CInt(Val(Replace(dnow(j, 4), ",", "")))
            For i As Short = 0 To 2
                If bx(j, i) <> 0 Then
                    ax(j, i) = CInt(cx(j, i) / bx(j, i) * 100)
                    If ax(j, i) = 100 And bx(j, i) > cx(j, i) Then ax(j, i) = 99
                Else
                    ax(j, i) = 0
                End If
            Next i
            For i As Short = 0 To 2
                If ax(j, i) > 999 Then ax(j, i) = 999
                Select Case ax(j, i)
                    Case 0 To 9
                        g.DrawString(Str(ax(j, i)) + "%", gf24, gcBlack, 870, 500 + (i + j * 3) * hxx)
                    Case 10 To 99
                        g.DrawString(Str(ax(j, i)) + "%", gf24, gcBlack, 870 - 20, 500 + (i + j * 3) * hxx)
                    Case Else
                        g.DrawString(Str(ax(j, i)) + "%", gf24, gcBlack, 870 - 20 * 2, 500 + (i + j * 3) * hxx)
                End Select
            Next i
            ''班別実績表示
            GrupJisseki()
            For i As Short = 0 To 2
                Pr(g, GpData(j, i), 660, 496 + (i + j * 3) * hxx, gcBlack, 28)
            Next i
        Next j
        'バッファー内容表示()
        myBuffer.Render()
        'バッファー内容クリア
        myBuffer.Dispose()
    End Sub

    'サブルーチン

    Public Sub GrupJisseki()
        Dim axx As Integer
        Dim DayX As Integer = GetDay()
        Dim hanx As Integer = 0
        For j As Short = 0 To 1
            For i As Short = 0 To 2
                Gp(i) = 0
                GpTotal(j, i) = 0
                GpChoku(i) = 0
                Gp2(i) = 0
                GpTotal2(j, i) = 0
                GpChoku2(i) = 0
            Next i
            For i As Integer = 1 To DayX
                axx = CInt(Val(Strings.Mid(KinmuData(1), i, 1)))
                If axx > 0 Then GpTotal(j, axx - 1) = GpTotal(j, axx - 1) + DekidakaDataDay(j, i) : GpChoku(axx - 1) += 1
                axx = CInt(Val(Strings.Mid(KinmuData(2), i, 1)))
                If axx > 0 Then GpTotal(j, axx - 1) = GpTotal(j, axx - 1) + DekidakaDataNight(j, i) : GpChoku(axx - 1) += 1
                axx = CInt(Val(Strings.Mid(KinmuData(3), i, 1)))
                If axx > 0 Then GpTotal(j, axx - 1) = GpTotal(j, axx - 1) + DekidakaDataDay2(j, i) : GpChoku2(axx - 1) += 1
                axx = CInt(Val(Strings.Mid(KinmuData(4), i, 1)))
                If axx > 0 Then GpTotal(j, axx - 1) = GpTotal(j, axx - 1) + DekidakaDataNight2(j, i) : GpChoku2(axx - 1) += 1
            Next
            If j = 0 Then hanx = Han - 1 Else hanx = Han2 - 1
            For i As Integer = 0 To hanx
                If GpChoku(i) > 0 Then
                    Gp(i) = CInt((GpTotal(j, i) + GpGeta(j, i)) / GpChoku(i))
                Else
                    Gp(i) = 0
                End If
                GpData(j, i) = Gp(i)
                If GpChoku2(i) > 0 Then
                    Gp2(i) = CInt((GpTotal2(j, i) + GpGeta2(j, i)) / GpChoku2(i))
                Else
                    Gp2(i) = 0
                End If
                GpData2(j, i) = Gp2(i)
            Next
        Next j
    End Sub

    Public Sub Pr(g As Graphics, n As Integer, x As Integer, y As Integer, c As System.Drawing.Brush, f As Short)
        'n = -1 * n
        Dim font As System.Drawing.Font
        Dim color As System.Drawing.Brush
        Dim fof1 As Single = 0          'ﾌｫﾝﾄ1文字毎ｵﾌｾｯﾄ
        Dim fof2 As Integer = 0         'ﾌｫﾝﾄ全体ｵﾌｾｯﾄ
        Dim cc As Integer = 0           'ｶﾝﾏ数
        Dim hc As Integer = 0           'ﾏｲﾅｽ符号有無
        Dim hof As Integer = 0          'ﾏｲﾅｽ符号ｵﾌｾｯﾄ
        Dim s As String = Trim(Str(Math.Abs(n)))
        Dim l As Integer = Len(s)
        color = c
        'カンマを付ける
        Select Case l
            Case 4 To 6
                s = Strings.Left(s, l - 3) & "," & Strings.Right(s, 3)
                cc = 1
            Case 7 To 9
                s = Strings.Left(s, l - 3) & "," & Strings.Right(s, 3)
                s = Strings.Left(s, l - 6) & "," & Strings.Right(s, 7)
                cc = 2
            Case Else
                s = s
                cc = 0
        End Select
        '符号確認
        If n < 0 Then hc = 1 : s = "-" & s : color = gcRed
        '補正値設定
        Select Case f
            Case 12
                font = gf12
                fof1 = 10 * (l - 1)
                fof2 = 0 + cc * 5
                hof = 6 * hc
            Case 18
                font = gf18
                fof1 = 14 * (l - 1)
                fof2 = 6 + cc * 8
                hof = 9 * hc
            Case 20
                font = gf20
                fof1 = 16 * (l - 1)
                fof2 = 8 + cc * 9
                hof = 10 * hc
            Case 24
                font = gf24
                fof1 = 19 * (l - 1)
                fof2 = 11 + cc * 10
                hof = 12 * hc
            Case 26
                font = gf26
                fof1 = 21 * (l - 1)
                fof2 = 11 + cc * 10
                hof = 13 * hc
            Case 28
                font = gf28
                fof1 = 22 * (l - 1)
                fof2 = 13 + cc * 11
                hof = 14 * hc
            Case 32
                font = gf32
                fof1 = 25 * (l - 1)
                fof2 = 15 + cc * 13
                hof = 20 * hc
            Case 40
                font = gf40
                fof1 = 31 * (l - 1)
                fof2 = 27 + cc * 12
                hof = 14 * hc
            Case Else
                font = gf12
                fof1 = 10 * (l - 1)
                fof2 = 0 + cc * 5
                hof = 6 * hc
        End Select
        g.DrawString(s, font, color, x - fof1 - fof2 - hof, y)
    End Sub

    Public Sub DekidakaSum()
        For j As Short = 0 To 1
            DekidakaTotal(j) = 0
            For i As Short = 1 To 31
                DekidakaTotal(j) += DekidakaDataDay(j, i) + DekidakaDataNight(j, i)
            Next
        Next
    End Sub

    Public Sub DekidakaHozon()
        Dim ToYear As Integer = CInt(Val(Strings.Left(CStr(Now), 4)))
        Dim ToMonth As Integer = CInt(Val(Strings.Mid(CStr(Now), 6, 2)))
        Dim Today As Integer = CInt(Val(Strings.Mid(CStr(Now), 9, 2)))
        Dim ToHour As Integer = CInt(Val(Strings.Mid(CStr(Now), 12, 2)))
        Dim NewFileFlag As Boolean = False
        '月末夜勤設定
        If Today = 1 And ToHour < 8 Then
            NewFileFlag = True
            Select Case ToMonth
                Case 1
                    Today = 31
                    ToMonth = 12
                    ToYear -= 1
                Case 3
                    Today = 29
                    ToMonth = 2
                Case 5, 7, 8, 10, 12
                    Today = 30
                    ToMonth -= 1
                Case 2, 4, 6, 9, 11
                    Today = 31
                    ToMonth -= 1
                Case Else
                    Today = 31
                    ToMonth -= 1
            End Select
        Else
            Today -= 1
        End If
        '出来高変数へ代入
        For i As Short = 0 To 1
            DekidakaDataDay(i, Today) = DekidakaDay(i)
            If DekidakaAll(i) > DekidakaDay(i) Then
                DekidakaDataNight(i, Today) = DekidakaAll(i) - DekidakaDay(i)
            Else
                DekidakaDataNight(i, Today) = 0
            End If
        Next i
        '出来高ファイル名生成
        Dim SvF1 As String = Trim(Str(ToYear))
        If ToMonth < 10 Then
            SvF1 = SvF1 + "0" + Trim(Str(ToMonth))
        Else
            SvF1 = SvF1 + Trim(Str(ToMonth))
        End If
        '出来高ファイルへ出力
        SvF1 = AppFolder & DataFolder & DekidakaFolder & "\Q" + SvF1 + ".txt"
        'SvF1 = AppFolder + "\DekidakaData\Q" + SvF1 + ".txt"
        Try
            System.IO.File.Delete(SvF1)
            Dim sw As System.IO.StreamWriter
            sw = New System.IO.StreamWriter(SvF1, True, System.Text.Encoding.GetEncoding(932))
            'sw.WriteLine("日付,日勤出来高,夜勤出来高")
            For i As Short = 1 To 31
                sw.WriteLine(Trim(Str(i)) + "," + Trim(Str(DekidakaDataDay(0, i))) + "," + Trim(Str(DekidakaDataNight(0, i))) + "," + Trim(Str(DekidakaDataDay(1, i))) + "," + Trim(Str(DekidakaDataNight(1, i))))
            Next
            sw.Close()
            'SvFirstFlag = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Application.Exit()
        End Try
        '新月出来高ファイル生成
        If NewFileFlag Then
            SvF1 = Strings.Left(CStr(Now), 4) + Strings.Mid(CStr(Now), 6, 2)
            SvF1 = AppFolder & DataFolder & DekidakaFolder & "\Q" + SvF1 + ".txt"
            Try
                System.IO.File.Delete(SvF1)
                Dim sw As System.IO.StreamWriter
                sw = New System.IO.StreamWriter(SvF1, True, System.Text.Encoding.GetEncoding(932))
                'sw.WriteLine("日付,日勤出来高,夜勤出来高")
                For i As Long = 1 To 31
                    sw.WriteLine(Trim(Str(i)) + ",0,0,0,0")
                Next
                sw.Close()
                'SvFirstFlag = False
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Application.Exit()
            End Try
            For i As Short = 1 To 31
                DekidakaDataDay(Ln, i) = 0
                DekidakaDataNight(Ln, i) = 0
            Next
            For i As Short = 0 To 2
                GpTotal(Ln, i) = 0
                GpGeta(Ln, i) = 0
            Next
        End If
    End Sub

    Public Sub WorkTimeCalc()
        'ライン１
        Select Case Han
            Case 2
                'Wt1Choku = 32400     '1直稼動時間(秒)8:00-17:00
                'Wt2Choku = 32400     '2直稼動時間(秒)17:00-26:00
                Wt1Choku = (Start2H * 3600 + Start2M * 60) - (Start1H * 3600 + Start1M * 60)
                Wt2Choku = (End2H * 3600 + End2M * 60) - (Start2H * 3600 + Start2M * 60)
            Case Else
                Wt1Choku = 44100     '1直稼動時間(秒)7:45-20:00
                Wt2Choku = 42300     '2直稼動時間(秒)20:00-7:45
        End Select
        For i As Short = 1 To 7
            WtS(i) = WtSh(i) * 3600 + WtSm(i) * 60
            WtE(i) = WtEm(i) * 60
            WtPi(1 + (i - 1) * 2) = WtS(i)
            WtPi(2 + (i - 1) * 2) = WtS(i) + WtE(i)
        Next
        For i As Short = 1 To 7
            WtLosTime(i) = CInt(WtEm(i) * (WtLosR(i) / 100))
        Next
        'Dim st As Long = 7 * 3600 + 45 * 60
        'WtBt(0) = WtPi(1) - st - 900
        'Dim st As Long = Cth * 3600 + Ctm * 60
        If Han = 2 Then
            WtBt(0) = WtPi(1) - (Start1H * 3600 + Start1M * 60)
        Else
            WtBt(0) = WtPi(1) - Cth * 3600 + Ctm * 60 - 900
        End If
        For i As Short = 1 To 13
            WtBt(i) = WtPi(i + 1) - WtPi(i)
        Next
        WtBt(1) = CInt(WtBt(1) * (1 - (WtLosR(1) / 100)))
        WtBt(3) = CInt(WtBt(3) * (1 - (WtLosR(2) / 100)))
        WtBt(5) = CInt(WtBt(5) * (1 - (WtLosR(3) / 100)))
        WtBt(7) = CInt(WtBt(7) * (1 - (WtLosR(4) / 100)))
        WtBt(9) = CInt(WtBt(9) * (1 - (WtLosR(5) / 100)))
        WtBt(11) = CInt(WtBt(11) * (1 - (WtLosR(6) / 100)))
        WtBt(13) = CInt(WtBt(13) * (1 - (WtLosR(7) / 100)))
        If Han = 2 Then
            WtLosTime(7) = 0
        End If
        Wt1Jisshitu = Wt1Choku - (WtLosTime(1) + WtLosTime(2) + WtLosTime(3) + WtLosTime(7)) * 60
        Wt2jisshitu = Wt2Choku - (WtLosTime(4) + WtLosTime(5) + WtLosTime(6)) * 60
        'ライン２
        Select Case Han2
            Case 2
                'Wt1Choku = 32400     '1直稼動時間(秒)8:00-17:00
                'Wt2Choku = 32400     '2直稼動時間(秒)17:00-26:00
                Wt1Choku2 = (Start2H2 * 3600 + Start2M2 * 60) - (Start1H2 * 3600 + Start1M2 * 60)
                Wt2Choku2 = (End2H2 * 3600 + End2M2 * 60) - (Start2H2 * 3600 + Start2M2 * 60)
            Case Else
                Wt1Choku2 = 44100     '1直稼動時間(秒)7:45-20:00
                Wt2Choku2 = 42300     '2直稼動時間(秒)20:00-7:45
        End Select
        For i As Short = 1 To 7
            WtS2(i) = WtSh2(i) * 3600 + WtSm2(i) * 60
            WtE2(i) = WtEm2(i) * 60
            WtPi2(1 + (i - 1) * 2) = WtS2(i)
            WtPi2(2 + (i - 1) * 2) = WtS2(i) + WtE2(i)
        Next
        For i As Short = 1 To 7
            WtLosTime2(i) = CInt(WtEm2(i) * (WtLosR2(i) / 100))
        Next
        If Han2 = 2 Then
            WtBt2(0) = WtPi2(1) - (Start1H2 * 3600 + Start1M2 * 60)
        Else
            WtBt2(0) = WtPi2(1) - Cth2 * 3600 + Ctm2 * 60 - 900
        End If
        For i As Short = 1 To 13
            WtBt2(i) = WtPi2(i + 1) - WtPi2(i)
        Next
        WtBt2(1) = CInt(WtBt2(1) * (1 - (WtLosR2(1) / 100)))
        WtBt2(3) = CInt(WtBt2(3) * (1 - (WtLosR2(2) / 100)))
        WtBt2(5) = CInt(WtBt2(5) * (1 - (WtLosR2(3) / 100)))
        WtBt2(7) = CInt(WtBt2(7) * (1 - (WtLosR2(4) / 100)))
        WtBt2(9) = CInt(WtBt2(9) * (1 - (WtLosR2(5) / 100)))
        WtBt2(11) = CInt(WtBt2(11) * (1 - (WtLosR2(6) / 100)))
        WtBt2(13) = CInt(WtBt2(13) * (1 - (WtLosR2(7) / 100)))
        If Han2 = 2 Then
            WtLosTime2(7) = 0
        End If
        Wt1Jisshitu2 = Wt1Choku2 - (WtLosTime2(1) + WtLosTime2(2) + WtLosTime2(3) + WtLosTime2(7)) * 60
        Wt2jisshitu2 = Wt2Choku2 - (WtLosTime2(4) + WtLosTime2(5) + WtLosTime2(6)) * 60
    End Sub

    Public Sub CountClear()
        'dsf = False
        Trg(0, 0) = 0
        Trg(0, 1) = 0
        Trg(0, 2) = 0
        Trg(0, 3) = 0
        Trg(0, 4) = 0
        Trg(1, 0) = 0
        Trg(1, 1) = 0
        Trg(1, 2) = 0
        Trg(1, 3) = 0
        Trg(1, 4) = 0
        NowC(0, 0) = 0
        NowC(0, 1) = 0
        NowC(0, 2) = 0
        NowC(0, 3) = 0
        NowC(0, 5) = 0
        NowC(0, 6) = 0
        NowC(0, 4) = 0
        NowC(1, 0) = 0
        NowC(1, 1) = 0
        NowC(1, 2) = 0
        NowC(1, 3) = 0
        NowC(1, 5) = 0
        NowC(1, 6) = 0
        NowC(1, 4) = 0
        Geta(0, 0) = 0
        Geta(0, 1) = 0
        Geta(0, 2) = 0
        Geta(0, 3) = 0
        Geta(0, 4) = 0
        Geta(1, 0) = 0
        Geta(1, 1) = 0
        Geta(1, 2) = 0
        Geta(1, 3) = 0
        Geta(1, 4) = 0
        For i As Short = 0 To 4
            ChokuData1(0, i) = 0
            ChokuData1(1, i) = 0
            ChokuData2(0, i) = 0
            ChokuData2(1, i) = 0
        Next i
        For j As Short = 0 To 1
            For i As Short = 0 To 4
                'dpln(i) = ""
                dtrg(j, i) = ""
                dtrg1(i) = ""
                'dck1(i) = ""
                'dck2(i) = ""
                'dna(i) = ""
                ChokuDataTrg2(0, i) = 0
                ChokuDataTrg2(1, i) = 0
            Next
        Next j
        SaveTmpCount()
        DrawScreen()
    End Sub

    Private Sub Capturex()
        '画面をキャプチャーする
        DrawScreen3()
        'Bitmapの作成
        Dim bmp As New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        'Graphicsの作成
        Dim g As Graphics = Graphics.FromImage(bmp)
        '画面全体をコピーする
        g.CopyFromScreen(New Point(0, 0), New Point(0, 0), bmp.Size)
        '解放
        g.Dispose()
        '保存
        bmp.Save(AppFolder & DataFolder & "\Capture\S" + Replace(Replace(CStr(Now), "/", ""), ":", "") + ".bmp")
    End Sub

    '初期設定

    Public Sub initialize()
        Me.Width = 1388
        Me.Height = 778
        'MidNightFlag = False
        ChokuChangeFlag = False
        For i As Short = 0 To 4
            ChokuData1(0, i) = 0
            ChokuData1(1, i) = 0
            ChokuData2(0, i) = 0
            ChokuData2(1, i) = 0
        Next i
        For i As Short = 0 To 10
            ReDrawFlag(i) = True
        Next
        timScreenChange.Interval = 5000
    End Sub

    '関数

    Public Function PutValue(n As Integer) As String
        PutValue = String.Format("{0,9:#,##0}", n)
    End Function

    Public Function ClmInt(a As Integer) As String
        '整数を６桁の文字列に変換
        '６桁未満はスペースを入れる
        '６桁以上は下６桁を有効にする
        Dim l1 As Integer = Len(Trim(Str(a)))
        If l1 >= 6 Then
            ClmInt = Strings.Right(Str(a), 6)
        Else
            ClmInt = Strings.Space(6 - l1) + Trim(Str(a))
        End If
    End Function

    Public Function CurCh(x As String) As String
        Dim x0 As Integer = 0
        If Val(x) >= 0 Then
            x0 = Len(x)
            If Val(x) >= 1000 Then
                If x0 > 3 Then
                    CurCh = Strings.Left(x, x0 - 3) + "," + Strings.Right(x, 3)
                Else
                    CurCh = " " + x
                End If
            Else
                CurCh = " " + x
            End If
        Else
            x0 = Len(x) - 0
            If Math.Abs(Val(x)) >= 1000 Then
                If x0 > 3 Then
                    CurCh = Strings.Left(x, x0 - 3) + "," + Strings.Right(x, 3)
                Else
                    CurCh = " " + x
                End If
            Else
                CurCh = " " + x
            End If
        End If
    End Function

    Public Function CnvPercentageString(a As Single) As String
        '---------------------------------------------------------------
        '実数［ａ］を少数点以下１桁が付いたパーセントの文字列に変換する
        '例）100＝"100"　（１００％は小数点を付けない）
        '例） 50＝"50.0"
        '例）  1＝"1.0"
        '例）0.1＝"0.1"
        '---------------------------------------------------------------
        Dim s0 As String = Trim(Str(a)) '文字列に変換
        '100%事処理
        If a >= 100 Then
            CnvPercentageString = "100"
            Exit Function
        End If
        '1%以下の場合,表示が".1"となってしまうので頭に"0"を付ける
        If Strings.Left(s0, 1) = "." Then s0 = "0" + s0
        '少数点以下1桁にする
        Dim y1 As Integer = InStr(s0, ".")
        Dim z1 As Integer = Len(s0)
        If y1 = 0 Then
            CnvPercentageString = s0 + ".0"
        Else
            CnvPercentageString = Strings.Left(s0, y1 + 1)
        End If
    End Function

    Public Function GetDay() As Integer
        Dim sx As String = CStr(Now)
        Dim ToYear As Integer = CInt(Val(Strings.Left(sx, 4)))
        Dim ToMonth As Integer = CInt(Val(Strings.Mid(sx, 6, 2)))
        Dim Today As Integer = CInt(Val(Strings.Mid(sx, 9, 2)))
        Dim ToHour As Integer = 0
        Dim ToMini As Integer = 0
        Dim ToSec As Integer = CInt(Val(Strings.Right(sx, 2)))
        Dim a1 As Integer = InStr(sx, ":")
        If a1 = 14 Then
            ToHour = CInt(Val(Strings.Mid(sx, 12, 2)))
            ToMini = CInt(Val(Strings.Mid(sx, 15, 2)))
        Else
            ToHour = CInt(Val(Strings.Mid(sx, 11, 2)))
            ToMini = CInt(Val(Strings.Mid(sx, 14, 2)))
        End If
        '月末夜勤時設定
        If Today = 1 And (ToHour < 7 Or (ToHour = 7 And ToMini < 45) Or (ToHour = 7 And ToMini = 45 And ToSec < 10)) Then
            Select Case ToMonth
                Case 1
                    Today = 31
                Case 3
                    Today = 29
                Case 5, 7, 8, 10, 12
                    Today = 30
                Case 2, 4, 6, 9, 11
                    Today = 31
                Case Else
                    Today = 31
            End Select
        Else
            Today -= 1
        End If
        GetDay = Today
    End Function

    Public Function GetMonth() As Integer
        Dim sx As String = CStr(Now)
        Dim ToYear As Integer = CInt(Val(Strings.Left(sx, 4)))
        Dim ToMonth As Integer = CInt(Val(Strings.Mid(sx, 6, 2)))
        Dim Today As Integer = CInt(Val(Strings.Mid(sx, 9, 2)))
        Dim ToHour As Integer = 0
        Dim ToMini As Integer = 0
        Dim ToSec As Integer = CInt(Val(Strings.Right(sx, 2)))
        Dim a1 As Integer = InStr(sx, ":")
        If a1 = 14 Then
            ToHour = CInt(Val(Strings.Mid(sx, 12, 2)))
            ToMini = CInt(Val(Strings.Mid(sx, 15, 2)))
        Else
            ToHour = CInt(Val(Strings.Mid(sx, 11, 2)))
            ToMini = CInt(Val(Strings.Mid(sx, 14, 2)))
        End If
        '月末夜勤時設定
        If Today = 1 And (ToHour < 7 Or (ToHour = 7 And ToMini < 45) Or (ToHour = 7 And ToMini = 45 And ToSec < 10)) Then
            Select Case ToMonth
                Case 1
                    ToMonth = 12
                Case Else
                    ToMonth -= 1
            End Select
        End If
        GetMonth = ToMonth
    End Function

    'メニュー

    Private Sub mnuSetPln_Click(sender As Object, e As EventArgs) Handles mnuSetPln.Click
        frmSetPln.Show()
    End Sub

    Private Sub mnuSetTkt_Click(sender As Object, e As EventArgs) Handles mnuSetTkt.Click
        frmSetTkt.Show()
    End Sub

    Private Sub mnuWorkTime_Click(sender As Object, e As EventArgs) Handles mnuWorkTime.Click
        frmWorkTime.Show()
    End Sub

    Private Sub mnuSystem_Click(sender As Object, e As EventArgs) Handles mnuSystem.Click
        frmSystem.Show()
    End Sub

    Private Sub mnuClearTime_Click(sender As Object, e As EventArgs) Handles mnuClearTime.Click
        frmClearTime.Show()
    End Sub

    Private Sub mnuEnd_Click(sender As Object, e As EventArgs) Handles mnuEnd.Click
        If MsgBox("終了してよいですか？", CType(vbOKCancel + vbExclamation, MsgBoxStyle)) = vbOK Then
            SaveTmpCount()
            Trigger.DioEnd()
        End If
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        If MsgBox("カウントをクリアしてよいですか？", CType(vbOKCancel + vbExclamation, MsgBoxStyle)) = vbOK Then
            CountClear()
        End If
    End Sub

    Private Sub mnuMemo_Click(sender As Object, e As EventArgs)
        frmMemo.Show()
    End Sub

    Private Sub mnuCalendar_Click(sender As Object, e As EventArgs) Handles mnuCalendar.Click
        frmCalendar.Show()
    End Sub

    Private Sub mnuScreen1_Click(sender As Object, e As EventArgs) Handles mnuScreen1.Click
        Ln = 0
        DualMode = False
        timScreenChange.Enabled = False
    End Sub

    Private Sub mnuScreen2_Click(sender As Object, e As EventArgs) Handles mnuScreen2.Click
        Ln = 1
        DualMode = False
        timScreenChange.Enabled = False
    End Sub

    Private Sub mnuScreenT_Click(sender As Object, e As EventArgs) Handles mnuScreenT.Click
        timScreenChange.Enabled = True
        DualMode = False
        Ln = 0
    End Sub

    Private Sub mnuScreenV_Click(sender As Object, e As EventArgs) Handles mnuScreenV.Click
        DualMode = True
        HoriMode = False
        Ln = 0
        timScreenChange.Enabled = False
    End Sub

    Private Sub mnuScreenH_Click(sender As Object, e As EventArgs) Handles mnuScreenH.Click
        DualMode = True
        HoriMode = True
        Ln = 0
        timScreenChange.Enabled = False
    End Sub

    '各ファイル操作

    Public Sub LoadModel()
        Dim x(20) As Integer
        Dim sr As System.IO.StreamReader
        Dim ofile As String = AppFolder & SystemFolder & "\Model.txt"
        sr = New System.IO.StreamReader(ofile, System.Text.Encoding.GetEncoding(932))
        Try
            ModelName = Trim(sr.ReadLine())
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Application.Exit()
        End Try
        If ModelName = "EX" Then
            EmExMode = True
        Else
            EmExMode = False
        End If
    End Sub

    Public Sub LoadSetting()
        Dim x(20) As Integer
        Dim sr As System.IO.StreamReader
        Dim ofile As String = AppFolder & SystemFolder & "\Init.txt"
        sr = New System.IO.StreamReader(ofile, System.Text.Encoding.GetEncoding(932))
        Try
            Pln(0, 0) = CInt(sr.ReadLine())
            Pln(0, 1) = CInt(sr.ReadLine())
            Pln(0, 2) = CInt(sr.ReadLine())
            Pln(0, 3) = CInt(sr.ReadLine())
            Pln(0, 4) = CInt(sr.ReadLine())
            Pln(1, 0) = CInt(sr.ReadLine())
            Pln(1, 1) = CInt(sr.ReadLine())
            Pln(1, 2) = CInt(sr.ReadLine())
            Pln(1, 3) = CInt(sr.ReadLine())
            Pln(1, 4) = CInt(sr.ReadLine())
            Tkt(0, 0) = CSng(sr.ReadLine())
            Tkt(0, 1) = CSng(sr.ReadLine())
            Tkt(0, 2) = CSng(sr.ReadLine())
            Tkt(0, 3) = CSng(sr.ReadLine())
            Tkt(0, 4) = CSng(sr.ReadLine())
            Tkt(1, 0) = CSng(sr.ReadLine())
            Tkt(1, 1) = CSng(sr.ReadLine())
            Tkt(1, 2) = CSng(sr.ReadLine())
            Tkt(1, 3) = CSng(sr.ReadLine())
            Tkt(1, 4) = CSng(sr.ReadLine())
            x(0) = CInt(CSng(sr.ReadLine()))
            x(1) = CInt(CSng(sr.ReadLine()))
            x(2) = CInt(CSng(sr.ReadLine()))
            x(3) = CInt(CSng(sr.ReadLine()))
            x(4) = CInt(CSng(sr.ReadLine()))
            x(5) = CInt(CSng(sr.ReadLine()))
            x(6) = CInt(CSng(sr.ReadLine()))
            x(7) = CInt(CSng(sr.ReadLine()))
            x(8) = CInt(CSng(sr.ReadLine()))
            x(9) = CInt(CSng(sr.ReadLine()))
            x(10) = CInt(CSng(sr.ReadLine()))
            x(11) = CInt(CSng(sr.ReadLine()))
            x(12) = CInt(CSng(sr.ReadLine()))
            x(13) = CInt(CSng(sr.ReadLine()))
            x(14) = CInt(CSng(sr.ReadLine()))
            x(15) = CInt(CSng(sr.ReadLine()))
            Qu(0, 0) = CInt(CSng(sr.ReadLine()))
            Qu(0, 1) = CInt(CSng(sr.ReadLine()))
            Qu(0, 2) = CInt(CSng(sr.ReadLine()))
            Qu(0, 3) = CInt(CSng(sr.ReadLine()))
            Qu(0, 4) = CInt(CSng(sr.ReadLine()))
            Qu(1, 0) = CInt(CSng(sr.ReadLine()))
            Qu(1, 1) = CInt(CSng(sr.ReadLine()))
            Qu(1, 2) = CInt(CSng(sr.ReadLine()))
            Qu(1, 3) = CInt(CSng(sr.ReadLine()))
            Qu(1, 4) = CInt(CSng(sr.ReadLine()))
            'ライン１
            For i As Short = 1 To 7
                WtSh(i) = CInt(CSng(sr.ReadLine()))
                WtSm(i) = CInt(CSng(sr.ReadLine()))
                WtEm(i) = CInt(CSng(sr.ReadLine()))
                WtLosR(i) = CInt(CSng(sr.ReadLine()))
            Next i
            Cth = CInt(CSng(sr.ReadLine()))
            Ctm = CInt(CSng(sr.ReadLine()))
            Start1H = CInt(CSng(sr.ReadLine()))
            Start1M = CInt(CSng(sr.ReadLine()))
            Start2H = CInt(CSng(sr.ReadLine()))
            Start2M = CInt(CSng(sr.ReadLine()))
            End2H = CInt(CSng(sr.ReadLine()))
            End2M = CInt(CSng(sr.ReadLine()))
            Han = CInt(sr.ReadLine())
            If Han = 2 Then
                Cth = End2H : Ctm = End2M
                Rth = Start2H : Rtm = Start2M
            Else
                Cth = 7 : Ctm = 45
                Rth = 20 : Rtm = 0
            End If
            'ライン２
            For i As Short = 1 To 7
                WtSh2(i) = CInt(CSng(sr.ReadLine()))
                WtSm2(i) = CInt(CSng(sr.ReadLine()))
                WtEm2(i) = CInt(CSng(sr.ReadLine()))
                WtLosR2(i) = CInt(CSng(sr.ReadLine()))
            Next i
            Cth2 = CInt(CSng(sr.ReadLine()))
            Ctm2 = CInt(CSng(sr.ReadLine()))
            Start1H2 = CInt(CSng(sr.ReadLine()))
            Start1M2 = CInt(CSng(sr.ReadLine()))
            Start2H2 = CInt(CSng(sr.ReadLine()))
            Start2M2 = CInt(CSng(sr.ReadLine()))
            End2H2 = CInt(CSng(sr.ReadLine()))
            End2M2 = CInt(CSng(sr.ReadLine()))
            Han2 = CInt(sr.ReadLine())
            L2choku1Nomi = CInt(sr.ReadLine())
            sr.Close()
            If Han2 = 2 Then
                Cth2 = End2H2 : Ctm2 = End2M2
                Rth2 = Start2H2 : Rtm = Start2M2
            Else
                Cth2 = 7 : Ctm2 = 45
                Rth2 = 20 : Rtm2 = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Application.Exit()
        End Try
    End Sub

    Public Sub SaveSetting()
        Dim ss(120) As String
        For i As Short = 0 To 120
            ss(i) = "z"
        Next
        ss(0) = Str(Pln(0, 0))
        ss(1) = Str(Pln(0, 1))
        ss(2) = Str(Pln(0, 2))
        ss(3) = Str(Pln(0, 3))
        ss(4) = Str(Pln(0, 4))
        ss(5) = Str(Pln(1, 0))
        ss(6) = Str(Pln(1, 1))
        ss(7) = Str(Pln(1, 2))
        ss(8) = Str(Pln(1, 3))
        ss(9) = Str(Pln(1, 4))
        ss(10) = Str(Tkt(0, 0))
        ss(11) = Str(Tkt(0, 1))
        ss(12) = Str(Tkt(0, 2))
        ss(13) = Str(Tkt(0, 3))
        ss(14) = Str(Tkt(0, 4))
        ss(15) = Str(Tkt(1, 0))
        ss(16) = Str(Tkt(1, 1))
        ss(17) = Str(Tkt(1, 2))
        ss(18) = Str(Tkt(1, 3))
        ss(19) = Str(Tkt(1, 4))
        ss(20) = "0" 'CStr(Wt1ProStartH)
        ss(21) = "1" 'CStr(Wt1ProStartM)
        ss(22) = "2" 'CStr(Wt1BrkStartH)
        ss(23) = "3" 'CStr(Wt1BrkStartM)
        ss(24) = "4" 'CStr(Wt1BrkEndH)
        ss(25) = "5" 'CStr(Wt1BrkEndM)
        ss(26) = "6" 'CStr(Wt1ProEndH)
        ss(27) = "7" 'CStr(Wt1ProEndM)
        ss(28) = "8" 'CStr(Wt2ProStartH)
        ss(29) = "9" 'CStr(Wt2ProStartM)
        ss(30) = "10" 'CStr(Wt2BrkStartH)
        ss(31) = "11" 'CStr(Wt2BrkStartM)
        ss(32) = "12" 'CStr(Wt2BrkEndH)
        ss(33) = "13" 'CStr(Wt2BrkEndM)
        ss(34) = "14" 'CStr(Wt2ProEndH)
        ss(35) = "15" 'CStr(Wt2ProEndM)
        ss(36) = CStr(Qu(0, 0))
        ss(37) = CStr(Qu(0, 1))
        ss(38) = CStr(Qu(0, 2))
        ss(39) = CStr(Qu(0, 3))
        ss(40) = CStr(Qu(0, 4))
        ss(41) = CStr(Qu(1, 0))
        ss(42) = CStr(Qu(1, 1))
        ss(43) = CStr(Qu(1, 2))
        ss(44) = CStr(Qu(1, 3))
        ss(45) = CStr(Qu(1, 4))
        'ライン１
        For i As Short = 1 To 7
            ss(46 + 4 * (i - 1)) = CStr(WtSh(i))
            ss(47 + 4 * (i - 1)) = CStr(WtSm(i))
            ss(48 + 4 * (i - 1)) = CStr(WtEm(i))
            ss(49 + 4 * (i - 1)) = CStr(WtLosR(i))
        Next i
        ss(74) = CStr(7)
        ss(75) = CStr(45)
        ss(76) = CStr(Start1H)
        ss(77) = CStr(Start1M)
        ss(78) = CStr(Start2H)
        ss(79) = CStr(Start2M)
        ss(80) = CStr(End2H)
        ss(81) = CStr(End2M)
        ss(82) = CStr(Han)
        'ライン２
        For i As Short = 1 To 7
            ss(83 + 4 * (i - 1)) = CStr(WtSh2(i))
            ss(84 + 4 * (i - 1)) = CStr(WtSm2(i))
            ss(85 + 4 * (i - 1)) = CStr(WtEm2(i))
            ss(86 + 4 * (i - 1)) = CStr(WtLosR2(i))
        Next i
        ss(111) = CStr(7)
        ss(112) = CStr(45)
        ss(113) = CStr(Start1H2)
        ss(114) = CStr(Start1M2)
        ss(115) = CStr(Start2H2)
        ss(116) = CStr(Start2M2)
        ss(117) = CStr(End2H2)
        ss(118) = CStr(End2M2)
        ss(119) = CStr(Han2)
        ss(120) = CStr(L2choku1Nomi)
        Try
            Dim ofile As String = AppFolder & SystemFolder & "\Init.txt"
            System.IO.File.Delete(ofile)
            Dim sw As System.IO.StreamWriter
            sw = New System.IO.StreamWriter(ofile, True, System.Text.Encoding.GetEncoding(932))
            For i As Short = 0 To 120
                sw.WriteLine(Trim(ss(i)))
            Next i
            sw.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Application.Exit()
        End Try
    End Sub

    Public Sub LoadTmpCount()
        Dim sr As System.IO.StreamReader
        Dim ofile As String = AppFolder & TmpFolder & "\TmpCount1.txt"
        sr = New System.IO.StreamReader(ofile, System.Text.Encoding.GetEncoding(932))
        Try
            NowC(0, 0) = CInt(sr.ReadLine())
            NowC(0, 1) = CInt(sr.ReadLine())
            NowC(0, 2) = CInt(sr.ReadLine())
            NowC(0, 3) = CInt(sr.ReadLine())
            NowC(0, 4) = CInt(sr.ReadLine())
            NowC(1, 0) = CInt(sr.ReadLine())
            NowC(1, 1) = CInt(sr.ReadLine())
            NowC(1, 2) = CInt(sr.ReadLine())
            NowC(1, 3) = CInt(sr.ReadLine())
            NowC(1, 4) = CInt(sr.ReadLine())
            Geta(0, 0) = CInt(CSng(sr.ReadLine()))
            Geta(0, 1) = CInt(CSng(sr.ReadLine()))
            Geta(0, 2) = CInt(CSng(sr.ReadLine()))
            Geta(0, 3) = CInt(CSng(sr.ReadLine()))
            Geta(0, 4) = CInt(CSng(sr.ReadLine()))
            Geta(1, 0) = CInt(CSng(sr.ReadLine()))
            Geta(1, 1) = CInt(CSng(sr.ReadLine()))
            Geta(1, 2) = CInt(CSng(sr.ReadLine()))
            Geta(1, 3) = CInt(CSng(sr.ReadLine()))
            Geta(1, 4) = CInt(CSng(sr.ReadLine()))
            MemNowCh1(0, 0) = CStr(CSng(sr.ReadLine()))
            MemNowCh1(0, 1) = CStr(CSng(sr.ReadLine()))
            MemNowCh1(0, 2) = CStr(CSng(sr.ReadLine()))
            MemNowCh1(0, 3) = CStr(CSng(sr.ReadLine()))
            MemNowCh1(0, 4) = CStr(CSng(sr.ReadLine()))
            MemNowCh1(1, 0) = CStr(CSng(sr.ReadLine()))
            MemNowCh1(1, 1) = CStr(CSng(sr.ReadLine()))
            MemNowCh1(1, 2) = CStr(CSng(sr.ReadLine()))
            MemNowCh1(1, 3) = CStr(CSng(sr.ReadLine()))
            MemNowCh1(1, 4) = CStr(CSng(sr.ReadLine()))
            NowC(0, 5) = CInt(sr.ReadLine())
            NowC(0, 6) = CInt(sr.ReadLine())
            NowC(1, 5) = CInt(sr.ReadLine())
            NowC(1, 6) = CInt(sr.ReadLine())
            GpGeta(0, 0) = CInt(CSng(sr.ReadLine()))
            GpGeta(0, 1) = CInt(CSng(sr.ReadLine()))
            GpGeta(0, 2) = CInt(sr.ReadLine())
            GpGeta(1, 0) = CInt(CSng(sr.ReadLine()))
            GpGeta(1, 1) = CInt(CSng(sr.ReadLine()))
            GpGeta(1, 2) = CInt(sr.ReadLine())
            DekidakaHosei(0) = CInt(sr.ReadLine())
            DekidakaHosei(1) = CInt(sr.ReadLine())
            sr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Application.Exit()
        End Try
        For i As Short = 0 To 4
            ChokuData1(0, i) = CInt(Val(MemNowCh1(0, i)))
            ChokuData1(1, i) = CInt(Val(MemNowCh1(1, i)))
        Next i
        DekidakaDay(0) = ChokuData1(0, 4)
        DekidakaDay(1) = ChokuData1(1, 4)
    End Sub

    Public Sub SaveTmpCount()
        Dim ss(41) As String
        ss(0) = CStr(NowC(0, 0))
        ss(1) = CStr(NowC(0, 1))
        ss(2) = CStr(NowC(0, 2))
        ss(3) = CStr(NowC(0, 3))
        ss(4) = CStr(NowC(0, 4))
        ss(5) = CStr(NowC(1, 0))
        ss(6) = CStr(NowC(1, 1))
        ss(7) = CStr(NowC(1, 2))
        ss(8) = CStr(NowC(1, 3))
        ss(9) = CStr(NowC(1, 4))
        ss(10) = CStr(Geta(0, 0))
        ss(11) = CStr(Geta(0, 1))
        ss(12) = CStr(Geta(0, 2))
        ss(13) = CStr(Geta(0, 3))
        ss(14) = CStr(Geta(0, 4))
        ss(15) = CStr(Geta(1, 0))
        ss(16) = CStr(Geta(1, 1))
        ss(17) = CStr(Geta(1, 2))
        ss(18) = CStr(Geta(1, 3))
        ss(19) = CStr(Geta(1, 4))
        ss(20) = MemNowCh1(0, 0)
        ss(21) = MemNowCh1(0, 1)
        ss(22) = MemNowCh1(0, 2)
        ss(23) = MemNowCh1(0, 3)
        ss(24) = MemNowCh1(0, 4)
        ss(25) = MemNowCh1(1, 0)
        ss(26) = MemNowCh1(1, 1)
        ss(27) = MemNowCh1(1, 2)
        ss(28) = MemNowCh1(1, 3)
        ss(29) = MemNowCh1(1, 4)
        ss(30) = CStr(NowC(0, 5))
        ss(31) = CStr(NowC(0, 6))
        ss(32) = CStr(NowC(1, 5))
        ss(33) = CStr(NowC(1, 6))
        ss(34) = CStr(GpGeta(0, 0))
        ss(35) = CStr(GpGeta(0, 1))
        ss(36) = CStr(GpGeta(0, 2))
        ss(37) = CStr(GpGeta(1, 0))
        ss(38) = CStr(GpGeta(1, 1))
        ss(39) = CStr(GpGeta(1, 2))
        ss(40) = CStr(DekidakaHosei(0))
        ss(41) = CStr(DekidakaHosei(1))
        Try
            Dim ofile As String = AppFolder & TmpFolder & "\TmpCount1.txt"
            System.IO.File.Delete(ofile)
            Dim sw As System.IO.StreamWriter
            sw = New System.IO.StreamWriter(ofile, True, System.Text.Encoding.GetEncoding(932))
            For i As Short = 0 To 41
                sw.WriteLine(Trim(ss(i)))
            Next i
            sw.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Application.Exit()
        End Try
    End Sub

    Public Sub LoadDekidaka()
        '今月の出来高ファイルを読み込む
        'Dim sr As System.IO.StreamReader
        Dim zx As String = CStr(Now)
        Dim YearX As Integer = CInt(Val(Strings.Mid(CStr(Now), 1, 4)))
        Dim MonthX As Integer = CInt(Val(Strings.Mid(CStr(Now), 6, 2)))
        Dim DayX As Integer = CInt(Val(Strings.Mid(CStr(Now), 9, 2)))
        Dim HourX As Integer = CInt(Val(Strings.Mid(CStr(Now), 12, 2)))
        Dim YearXN As Integer = 0
        Dim MonthXN As Integer = 0
        Dim YearXL As Integer = 0
        Dim MonthXL As Integer = 0
        Dim LdF1 As String = ""
        Dim sx As String = ""
        Dim p1 As Integer = 0
        Dim p2 As Integer = 0
        '今月のファイル名生成（各月１日の０：００～７：５９は前月に設定する）
        If DayX = 1 And HourX < 8 Then
            If MonthX = 1 Then
                MonthX = 12
                YearX -= 1
            Else
                MonthX -= 1
            End If
        End If
        If MonthX < 10 Then
            LdF1 = Trim(Str(YearX)) + "0" + Trim(Str(MonthX))
        Else
            LdF1 = Trim(Str(YearX)) + Trim(Str(MonthX))
        End If
        LdF1 = AppFolder & DataFolder & DekidakaFolder & "\Q" + LdF1 + ".txt"
        Dim i As Integer = 0
        Dim n As Integer = FreeFile()
        Dim day(31) As Integer
        Try
            FileOpen(n, LdF1, OpenMode.Input)
        Catch ex As Exception
            DekidakaHozon()
            FileOpen(n, LdF1, OpenMode.Input)
        End Try
        Do While Not EOF(n)
            Input(n, day(i + 1))
            Input(n, DekidakaDataDay(0, i + 1))
            Input(n, DekidakaDataNight(0, i + 1))
            Input(n, DekidakaDataDay(1, i + 1))
            Input(n, DekidakaDataNight(1, i + 1))
            i += 1
        Loop
        FileClose(n)
    End Sub

    Public Sub LoadKinmu()
        Dim sr As System.IO.StreamReader
        sr = New System.IO.StreamReader(AppFolder & SystemFolder & "\Kinmu.txt", System.Text.Encoding.GetEncoding(932))
        Try
            KinmuData(0) = sr.ReadLine()
            KinmuData(1) = sr.ReadLine()
            KinmuData(2) = sr.ReadLine()
            KinmuData(3) = sr.ReadLine()
            KinmuData(4) = sr.ReadLine()
            sr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Application.Exit()
        End Try
    End Sub

    Public Sub SaveJisseki()
        Dim Title As String = "日付,1直巻線1,1直巻線2,1直前組1,1直前組2,1直後組,2直巻線1,2直巻線2,2直前組1,2直前組2,2直後組,合計巻線1,合計巻線2,合計前組1,合計前組2,合計後組,月度累計,班A,班B,班C" + vbCr + vbLf
        Dim zx As String = Strings.Left(CStr(Now), 10)
        For j As Integer = 0 To 1
            SvFileName = AppFolder + DataFolder + "\JissekiData" + Trim(Str(j)) + ".CSV"
            SvBkFileName = AppFolder + DataFolder + "\JissekiDataBackUp" + Trim(Str(j)) + ".CSV"
            Dim sx As String = ""
            Dim finfo As New System.IO.FileInfo(SvFileName)
            If finfo.Exists = False Then
                sx = Title
            End If
            sx = sx + zx
            For i As Short = 0 To 4
                sx = sx + "," + Trim(Str(ChokuData1(j, i)))
            Next
            For i As Short = 0 To 4
                sx = sx + "," + Trim(Str(ChokuData2(j, i)))
            Next
            For i As Short = 0 To 4
                sx = sx + "," + Trim(Str(ChokuData1(j, i) + ChokuData2(j, i)))
            Next
            sx = sx + "," + Trim(Str(DekidakaTotal(j) + DekidakaHosei(j) + NowC(j, 4) * Qu(j, 4) + Geta(j, 4)))
            For i As Short = 0 To 2
                sx = sx + "," + Trim(Str(GpData(j, i)))
            Next
            Try
                Dim sw As System.IO.StreamWriter
                sw = New System.IO.StreamWriter(SvFileName, True, System.Text.Encoding.GetEncoding(932))
                sw.WriteLine(sx)
                sw.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Application.Exit()
            End Try
            sx = ""
            Dim finfoBk As New System.IO.FileInfo(SvBkFileName)
            If finfoBk.Exists = False Then
                sx = Title
            End If
            sx = sx + zx
            For i As Short = 0 To 4
                sx = sx + "," + Trim(Str(ChokuData1(j, i)))
            Next
            For i As Short = 0 To 4
                sx = sx + "," + Trim(Str(ChokuData2(j, i)))
            Next
            For i As Short = 0 To 4
                sx = sx + "," + Trim(Str(ChokuData1(j, i) + ChokuData2(j, i)))
            Next
            sx = sx + "," + Trim(Str(DekidakaTotal(j) + DekidakaHosei(j) + NowC(j, 4) * Qu(j, 4) + Geta(j, 4)))
            For i As Short = 0 To 2
                sx = sx + "," + Trim(Str(GpData(j, i)))
            Next
            Try
                Dim sw As System.IO.StreamWriter
                sw = New System.IO.StreamWriter(SvBkFileName, True, System.Text.Encoding.GetEncoding(932))
                sw.WriteLine(sx)
                sw.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Application.Exit()
            End Try
        Next j
    End Sub

    Public Sub SaveKinmu()
        Try
            System.IO.File.Delete(AppFolder & SystemFolder & "\Kinmu.txt")
            Dim sw As System.IO.StreamWriter
            sw = New System.IO.StreamWriter(AppFolder & SystemFolder & "\Kinmu.txt", True, System.Text.Encoding.GetEncoding(932))
            For i As Short = 0 To 4
                sw.WriteLine(KinmuData(i))
            Next i
            sw.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Application.Exit()
        End Try
        'DekidakaGroup()
    End Sub

    Public Sub CreateSaveFolder()
        '保存先フォルダ生成
        Dim dt As DateTime = DateTime.Now
        Dim b As String = dt.ToString
        SaveSubFolder = Strings.Left(Trim(b), 4) + Strings.Mid(Trim(b), 6, 2)
        Dim di As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(AppFolder + "\" + DataFolder + "\" + ShinchokuFolder + "\" + SaveSubFolder)
        di.Create()
    End Sub

    Public Sub CreateSaveFileName()
        '保存ファイル生成
        Dim dt As DateTime = DateTime.Now
        Dim b As String = dt.ToString
        SaveFileName = Strings.Left(Trim(b), 4) + Strings.Mid(Trim(b), 6, 2) + Strings.Mid(Trim(b), 9, 2)
        Dim Title As String = ""
        Title = "機種,日付,時間,1巻1,1巻2,1前1,1前2,1後,2巻1,2巻2,2前1,2前2,2後" + vbCrLf
        My.Computer.FileSystem.WriteAllText(AppFolder + "\" + DataFolder + "\" + ShinchokuFolder + "\" + SaveSubFolder + "\" + SaveFileName + ".CSV", Title, True)
        My.Computer.FileSystem.WriteAllText(AppFolder + "\" + DataFolder + "\" + ShinchokuFolder + "\" + SaveSubFolder + "\" + SaveFileName + ".BKF", Title, True)
    End Sub

    Public Sub SaveData()
        '起動初回確認
        If SaveDataFirstFlag Then
            CreateSaveFolder()
            CreateSaveFileName()
            SaveDataFirstFlag = False
        End If
        '現在時刻確認
        Dim NowYearMonth As String = Replace(Strings.Left(CStr(Now), 7), "/", "")
        Dim NowDate As String = Replace(Strings.Left(CStr(Now), 10), "/", "")
        Dim NowTime As String = Replace(Strings.Mid(CStr(Now), 12, 5), ":", "")
        'Dim NowHour As String = Strings.Left(NowTime, 2)
        Dim S0 As String = CStr(Now)
        Dim a0 As Integer = InStr(S0, " ")
        Dim a1 As Integer = InStr(S0, ":")
        Dim NowHour As String = Strings.Mid(S0, a0 + 1, (a1 - a0) - 1)
        If NowDate <> SaveFileName And Val(NowTime) >= Val(SaveTimeH + SaveTimeM) Then
            If NowYearMonth <> SaveSubFolder Then CreateSaveFolder()
            CreateSaveFileName()
        End If
        Dim NowDateX As String = Strings.Left(CStr(Now), 10)
        Dim NowTimeX As String = Strings.Mid(CStr(Now), 12, 8)
        If SaveHour <> NowHour Then
            'データ保存
            Dim InputString As String = ModelName + "," + NowDateX + "," + NowTimeX + ","
            For i As Integer = 0 To 1
                For j As Integer = 0 To 4
                    InputString = InputString + Trim(Str(WrCntA(i, j))) + ","
                Next
            Next
            InputString = InputString + vbCrLf
            My.Computer.FileSystem.WriteAllText(AppFolder + "\" + DataFolder + "\" + ShinchokuFolder + "\" + SaveSubFolder + "\" + SaveFileName + ".CSV", InputString, True)
            My.Computer.FileSystem.WriteAllText(AppFolder + "\" + DataFolder + "\" + ShinchokuFolder + "\" + SaveSubFolder + "\" + SaveFileName + ".BKF", InputString, True)
            SaveHour = NowHour
        End If
    End Sub

End Class