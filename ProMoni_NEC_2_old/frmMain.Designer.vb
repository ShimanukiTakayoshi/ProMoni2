﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblClock = New System.Windows.Forms.Label()
        Me.timScan = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.設定SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetPln = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetTkt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWorkTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClearTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEnd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCalendar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuScreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuScreen1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuScreen2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuScreenT = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuScreenV = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuScreenH = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.timSaveTime = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timScreenChange = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblClock
        '
        Me.lblClock.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblClock.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblClock.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblClock.Location = New System.Drawing.Point(993, 25)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(315, 34)
        Me.lblClock.TabIndex = 0
        Me.lblClock.Text = "0000/00/00 00:00:00"
        Me.lblClock.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'timScan
        '
        Me.timScan.Enabled = True
        Me.timScan.Interval = 1000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.設定SToolStripMenuItem, Me.mnuClear, Me.mnuCalendar, Me.mnuScreen})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 26)
        Me.MenuStrip1.TabIndex = 75
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '設定SToolStripMenuItem
        '
        Me.設定SToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSetPln, Me.mnuSetTkt, Me.mnuWorkTime, Me.mnuSystem, Me.mnuClearTime, Me.mnuEnd})
        Me.設定SToolStripMenuItem.Name = "設定SToolStripMenuItem"
        Me.設定SToolStripMenuItem.Size = New System.Drawing.Size(62, 22)
        Me.設定SToolStripMenuItem.Text = "設定(&S)"
        '
        'mnuSetPln
        '
        Me.mnuSetPln.Name = "mnuSetPln"
        Me.mnuSetPln.Size = New System.Drawing.Size(184, 22)
        Me.mnuSetPln.Text = "日産数設定(&N)"
        '
        'mnuSetTkt
        '
        Me.mnuSetTkt.Name = "mnuSetTkt"
        Me.mnuSetTkt.Size = New System.Drawing.Size(184, 22)
        Me.mnuSetTkt.Text = "タクト設定(&T)"
        '
        'mnuWorkTime
        '
        Me.mnuWorkTime.Name = "mnuWorkTime"
        Me.mnuWorkTime.Size = New System.Drawing.Size(184, 22)
        Me.mnuWorkTime.Text = "稼動時間設定(&W)"
        '
        'mnuSystem
        '
        Me.mnuSystem.Name = "mnuSystem"
        Me.mnuSystem.Size = New System.Drawing.Size(184, 22)
        Me.mnuSystem.Text = "システム設定(&S)"
        '
        'mnuClearTime
        '
        Me.mnuClearTime.Name = "mnuClearTime"
        Me.mnuClearTime.Size = New System.Drawing.Size(184, 22)
        Me.mnuClearTime.Text = "ｶｳﾝﾄｸﾘｱ時間設定(&C)"
        '
        'mnuEnd
        '
        Me.mnuEnd.Name = "mnuEnd"
        Me.mnuEnd.Size = New System.Drawing.Size(184, 22)
        Me.mnuEnd.Text = "終了(&E)"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(82, 22)
        Me.mnuClear.Text = "ｶｳﾝﾄｸﾘｱ(&M)"
        '
        'mnuCalendar
        '
        Me.mnuCalendar.Name = "mnuCalendar"
        Me.mnuCalendar.Size = New System.Drawing.Size(110, 22)
        Me.mnuCalendar.Text = "班編制ｶﾚﾝﾀﾞｰ(&K)"
        '
        'mnuScreen
        '
        Me.mnuScreen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuScreen1, Me.mnuScreen2, Me.mnuScreenT, Me.mnuScreenV, Me.mnuScreenH})
        Me.mnuScreen.Name = "mnuScreen"
        Me.mnuScreen.Size = New System.Drawing.Size(111, 22)
        Me.mnuScreen.Text = "画面表示切替(&G)"
        '
        'mnuScreen1
        '
        Me.mnuScreen1.Name = "mnuScreen1"
        Me.mnuScreen1.Size = New System.Drawing.Size(198, 22)
        Me.mnuScreen1.Text = "ライン１(&1)"
        '
        'mnuScreen2
        '
        Me.mnuScreen2.Name = "mnuScreen2"
        Me.mnuScreen2.Size = New System.Drawing.Size(198, 22)
        Me.mnuScreen2.Text = "ライン２(&2)"
        '
        'mnuScreenT
        '
        Me.mnuScreenT.Name = "mnuScreenT"
        Me.mnuScreenT.Size = New System.Drawing.Size(198, 22)
        Me.mnuScreenT.Text = "ライン1･2時間切換(&T)"
        '
        'mnuScreenV
        '
        Me.mnuScreenV.Name = "mnuScreenV"
        Me.mnuScreenV.Size = New System.Drawing.Size(198, 22)
        Me.mnuScreenV.Text = "ライン1･2縦表示(&V)"
        '
        'mnuScreenH
        '
        Me.mnuScreenH.Name = "mnuScreenH"
        Me.mnuScreenH.Size = New System.Drawing.Size(198, 22)
        Me.mnuScreenH.Text = "ライン1･2横表示(&H)"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("MS UI Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(9, 610)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1359, 124)
        Me.TextBox1.TabIndex = 77
        Me.TextBox1.Visible = False
        '
        'timSaveTime
        '
        Me.timSaveTime.Enabled = True
        Me.timSaveTime.Interval = 100000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1151, 454)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 41)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1267, 454)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 40)
        Me.Button2.TabIndex = 79
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1160, 425)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 12)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1270, 425)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 12)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'timScreenChange
        '
        Me.timScreenChange.Interval = 1000
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(489, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 82
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1370, 750)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " リレーライン進捗モニター"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClock As System.Windows.Forms.Label
    Friend WithEvents timScan As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 設定SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSetPln As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSetTkt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWorkTime As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents mnuEnd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents timSaveTime As System.Windows.Forms.Timer
    Friend WithEvents mnuClearTime As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCalendar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents timScreenChange As System.Windows.Forms.Timer
    Friend WithEvents mnuScreen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuScreen1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuScreen2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuScreenT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuScreenV As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuScreenH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
