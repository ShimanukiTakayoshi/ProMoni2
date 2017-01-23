Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports System.Text


Friend Class Trigger
    Inherits System.Windows.Forms.Form
#Region "Windows フォーム デザイナによって生成されたコード"
    Public Sub New()
        MyBase.New()
        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_vb6FormDefInstance = Me
            Else
                Try
                    'スタートアップ フォームについては、最初に作成されたインスタンスが既定インスタンスになります。
                    If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                        m_vb6FormDefInstance = Me
                    End If
                Catch
                End Try
            End If
        End If
        'この呼び出しは、Windows フォーム デザイナで必要です。
        InitializeComponent()
    End Sub
    'Form は、コンポーネント一覧に後処理を実行するために dispose をオーバーライドします。
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Edit_ReturnCode As System.Windows.Forms.TextBox
    Public WithEvents Button_DioExit As System.Windows.Forms.Button
    Public WithEvents Button_Exit As System.Windows.Forms.Button
    Public WithEvents Button_Trigger As System.Windows.Forms.Button
    'Public WithEvents _Check_8 As System.Windows.Forms.CheckBox
    Public WithEvents _Check_7 As System.Windows.Forms.CheckBox
    Public WithEvents _Check_6 As System.Windows.Forms.CheckBox
    Public WithEvents _Check_5 As System.Windows.Forms.CheckBox
    Public WithEvents _Check_4 As System.Windows.Forms.CheckBox
    Public WithEvents _Check_3 As System.Windows.Forms.CheckBox
    Public WithEvents _Check_2 As System.Windows.Forms.CheckBox
    Public WithEvents _Check_1 As System.Windows.Forms.CheckBox
    Public WithEvents _Check_0 As System.Windows.Forms.CheckBox
    'Public WithEvents _Edit_Down_8 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Down_7 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Down_6 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Down_5 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Down_4 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Down_3 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Down_2 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Down_1 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Down_0 As System.Windows.Forms.TextBox
    'Public WithEvents _Edit_Up_8 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Up_7 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Up_6 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Up_5 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Up_4 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Up_3 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Up_2 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Up_1 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Up_0 As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Button_DioIint As System.Windows.Forms.Button
    Public WithEvents Edit_DeviceName As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents _Check_8 As System.Windows.Forms.CheckBox
    Public WithEvents _Edit_Down_8 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Up_8 As System.Windows.Forms.TextBox
    Public WithEvents _Check_15 As System.Windows.Forms.CheckBox
    Public WithEvents _Check_14 As System.Windows.Forms.CheckBox
    Public WithEvents _Check_13 As System.Windows.Forms.CheckBox
    Public WithEvents _Check_12 As System.Windows.Forms.CheckBox
    Public WithEvents _Check_11 As System.Windows.Forms.CheckBox
    Public WithEvents _Check_10 As System.Windows.Forms.CheckBox
    Public WithEvents _Check_9 As System.Windows.Forms.CheckBox
    Public WithEvents _Edit_Down_15 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Down_14 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Down_13 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Down_12 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Down_11 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Down_10 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Down_9 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Up_15 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Up_14 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Up_13 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Up_12 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Up_11 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Up_10 As System.Windows.Forms.TextBox
    Public WithEvents _Edit_Up_9 As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    'メモ : 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使って変更できます。
    'コードエディタを使って修正しないでください。


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Edit_ReturnCode = New System.Windows.Forms.TextBox()
        Me.Button_DioExit = New System.Windows.Forms.Button()
        Me.Button_Exit = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me._Check_15 = New System.Windows.Forms.CheckBox()
        Me._Check_14 = New System.Windows.Forms.CheckBox()
        Me._Check_13 = New System.Windows.Forms.CheckBox()
        Me._Check_12 = New System.Windows.Forms.CheckBox()
        Me._Check_11 = New System.Windows.Forms.CheckBox()
        Me._Check_10 = New System.Windows.Forms.CheckBox()
        Me._Check_9 = New System.Windows.Forms.CheckBox()
        Me._Edit_Down_15 = New System.Windows.Forms.TextBox()
        Me._Edit_Down_14 = New System.Windows.Forms.TextBox()
        Me._Edit_Down_13 = New System.Windows.Forms.TextBox()
        Me._Edit_Down_12 = New System.Windows.Forms.TextBox()
        Me._Edit_Down_11 = New System.Windows.Forms.TextBox()
        Me._Edit_Down_10 = New System.Windows.Forms.TextBox()
        Me._Edit_Down_9 = New System.Windows.Forms.TextBox()
        Me._Edit_Up_15 = New System.Windows.Forms.TextBox()
        Me._Edit_Up_14 = New System.Windows.Forms.TextBox()
        Me._Edit_Up_13 = New System.Windows.Forms.TextBox()
        Me._Edit_Up_12 = New System.Windows.Forms.TextBox()
        Me._Edit_Up_11 = New System.Windows.Forms.TextBox()
        Me._Edit_Up_10 = New System.Windows.Forms.TextBox()
        Me._Edit_Up_9 = New System.Windows.Forms.TextBox()
        Me._Check_8 = New System.Windows.Forms.CheckBox()
        Me._Edit_Down_8 = New System.Windows.Forms.TextBox()
        Me._Edit_Up_8 = New System.Windows.Forms.TextBox()
        Me._Check_7 = New System.Windows.Forms.CheckBox()
        Me._Check_6 = New System.Windows.Forms.CheckBox()
        Me._Check_5 = New System.Windows.Forms.CheckBox()
        Me._Check_4 = New System.Windows.Forms.CheckBox()
        Me._Check_3 = New System.Windows.Forms.CheckBox()
        Me._Check_2 = New System.Windows.Forms.CheckBox()
        Me._Check_1 = New System.Windows.Forms.CheckBox()
        Me.Button_Trigger = New System.Windows.Forms.Button()
        Me._Check_0 = New System.Windows.Forms.CheckBox()
        Me._Edit_Down_7 = New System.Windows.Forms.TextBox()
        Me._Edit_Down_6 = New System.Windows.Forms.TextBox()
        Me._Edit_Down_5 = New System.Windows.Forms.TextBox()
        Me._Edit_Down_4 = New System.Windows.Forms.TextBox()
        Me._Edit_Down_3 = New System.Windows.Forms.TextBox()
        Me._Edit_Down_2 = New System.Windows.Forms.TextBox()
        Me._Edit_Down_1 = New System.Windows.Forms.TextBox()
        Me._Edit_Down_0 = New System.Windows.Forms.TextBox()
        Me._Edit_Up_7 = New System.Windows.Forms.TextBox()
        Me._Edit_Up_6 = New System.Windows.Forms.TextBox()
        Me._Edit_Up_5 = New System.Windows.Forms.TextBox()
        Me._Edit_Up_4 = New System.Windows.Forms.TextBox()
        Me._Edit_Up_3 = New System.Windows.Forms.TextBox()
        Me._Edit_Up_2 = New System.Windows.Forms.TextBox()
        Me._Edit_Up_1 = New System.Windows.Forms.TextBox()
        Me._Edit_Up_0 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button_DioIint = New System.Windows.Forms.Button()
        Me.Edit_DeviceName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Edit_ReturnCode
        '
        Me.Edit_ReturnCode.AcceptsReturn = True
        Me.Edit_ReturnCode.BackColor = System.Drawing.SystemColors.Window
        Me.Edit_ReturnCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Edit_ReturnCode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Edit_ReturnCode.Location = New System.Drawing.Point(80, 224)
        Me.Edit_ReturnCode.MaxLength = 0
        Me.Edit_ReturnCode.Name = "Edit_ReturnCode"
        Me.Edit_ReturnCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Edit_ReturnCode.Size = New System.Drawing.Size(249, 19)
        Me.Edit_ReturnCode.TabIndex = 34
        Me.Edit_ReturnCode.Text = "Text1"
        '
        'Button_DioExit
        '
        Me.Button_DioExit.BackColor = System.Drawing.SystemColors.Control
        Me.Button_DioExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button_DioExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_DioExit.Location = New System.Drawing.Point(352, 224)
        Me.Button_DioExit.Name = "Button_DioExit"
        Me.Button_DioExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button_DioExit.Size = New System.Drawing.Size(113, 20)
        Me.Button_DioExit.TabIndex = 33
        Me.Button_DioExit.Text = "DioExit"
        Me.Button_DioExit.UseVisualStyleBackColor = False
        '
        'Button_Exit
        '
        Me.Button_Exit.BackColor = System.Drawing.SystemColors.Control
        Me.Button_Exit.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button_Exit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_Exit.Location = New System.Drawing.Point(352, 264)
        Me.Button_Exit.Name = "Button_Exit"
        Me.Button_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button_Exit.Size = New System.Drawing.Size(113, 20)
        Me.Button_Exit.TabIndex = 32
        Me.Button_Exit.Text = "Exit"
        Me.Button_Exit.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me._Check_15)
        Me.Frame1.Controls.Add(Me._Check_14)
        Me.Frame1.Controls.Add(Me._Check_13)
        Me.Frame1.Controls.Add(Me._Check_12)
        Me.Frame1.Controls.Add(Me._Check_11)
        Me.Frame1.Controls.Add(Me._Check_10)
        Me.Frame1.Controls.Add(Me._Check_9)
        Me.Frame1.Controls.Add(Me._Edit_Down_15)
        Me.Frame1.Controls.Add(Me._Edit_Down_14)
        Me.Frame1.Controls.Add(Me._Edit_Down_13)
        Me.Frame1.Controls.Add(Me._Edit_Down_12)
        Me.Frame1.Controls.Add(Me._Edit_Down_11)
        Me.Frame1.Controls.Add(Me._Edit_Down_10)
        Me.Frame1.Controls.Add(Me._Edit_Down_9)
        Me.Frame1.Controls.Add(Me._Edit_Up_15)
        Me.Frame1.Controls.Add(Me._Edit_Up_14)
        Me.Frame1.Controls.Add(Me._Edit_Up_13)
        Me.Frame1.Controls.Add(Me._Edit_Up_12)
        Me.Frame1.Controls.Add(Me._Edit_Up_11)
        Me.Frame1.Controls.Add(Me._Edit_Up_10)
        Me.Frame1.Controls.Add(Me._Edit_Up_9)
        Me.Frame1.Controls.Add(Me._Check_8)
        Me.Frame1.Controls.Add(Me._Edit_Down_8)
        Me.Frame1.Controls.Add(Me._Edit_Up_8)
        Me.Frame1.Controls.Add(Me._Check_7)
        Me.Frame1.Controls.Add(Me._Check_6)
        Me.Frame1.Controls.Add(Me._Check_5)
        Me.Frame1.Controls.Add(Me._Check_4)
        Me.Frame1.Controls.Add(Me._Check_3)
        Me.Frame1.Controls.Add(Me._Check_2)
        Me.Frame1.Controls.Add(Me._Check_1)
        Me.Frame1.Controls.Add(Me.Button_Trigger)
        Me.Frame1.Controls.Add(Me._Check_0)
        Me.Frame1.Controls.Add(Me._Edit_Down_7)
        Me.Frame1.Controls.Add(Me._Edit_Down_6)
        Me.Frame1.Controls.Add(Me._Edit_Down_5)
        Me.Frame1.Controls.Add(Me._Edit_Down_4)
        Me.Frame1.Controls.Add(Me._Edit_Down_3)
        Me.Frame1.Controls.Add(Me._Edit_Down_2)
        Me.Frame1.Controls.Add(Me._Edit_Down_1)
        Me.Frame1.Controls.Add(Me._Edit_Down_0)
        Me.Frame1.Controls.Add(Me._Edit_Up_7)
        Me.Frame1.Controls.Add(Me._Edit_Up_6)
        Me.Frame1.Controls.Add(Me._Edit_Up_5)
        Me.Frame1.Controls.Add(Me._Edit_Up_4)
        Me.Frame1.Controls.Add(Me._Edit_Up_3)
        Me.Frame1.Controls.Add(Me._Edit_Up_2)
        Me.Frame1.Controls.Add(Me._Edit_Up_1)
        Me.Frame1.Controls.Add(Me._Edit_Up_0)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 56)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(829, 153)
        Me.Frame1.TabIndex = 3
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "トリガ監視"
        '
        '_Check_15
        '
        Me._Check_15.BackColor = System.Drawing.SystemColors.Control
        Me._Check_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_15.Location = New System.Drawing.Point(784, 88)
        Me._Check_15.Name = "_Check_15"
        Me._Check_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Check_15.Size = New System.Drawing.Size(17, 17)
        Me._Check_15.TabIndex = 55
        Me._Check_15.Text = "Check1"
        Me._Check_15.UseVisualStyleBackColor = False
        '
        '_Check_14
        '
        Me._Check_14.BackColor = System.Drawing.SystemColors.Control
        Me._Check_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_14.Location = New System.Drawing.Point(742, 88)
        Me._Check_14.Name = "_Check_14"
        Me._Check_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Check_14.Size = New System.Drawing.Size(17, 17)
        Me._Check_14.TabIndex = 54
        Me._Check_14.Text = "Check1"
        Me._Check_14.UseVisualStyleBackColor = False
        '
        '_Check_13
        '
        Me._Check_13.BackColor = System.Drawing.SystemColors.Control
        Me._Check_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_13.Location = New System.Drawing.Point(696, 88)
        Me._Check_13.Name = "_Check_13"
        Me._Check_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Check_13.Size = New System.Drawing.Size(17, 17)
        Me._Check_13.TabIndex = 53
        Me._Check_13.Text = "Check1"
        Me._Check_13.UseVisualStyleBackColor = False
        '
        '_Check_12
        '
        Me._Check_12.BackColor = System.Drawing.SystemColors.Control
        Me._Check_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_12.Location = New System.Drawing.Point(655, 88)
        Me._Check_12.Name = "_Check_12"
        Me._Check_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Check_12.Size = New System.Drawing.Size(17, 17)
        Me._Check_12.TabIndex = 52
        Me._Check_12.Text = "Check1"
        Me._Check_12.UseVisualStyleBackColor = False
        '
        '_Check_11
        '
        Me._Check_11.BackColor = System.Drawing.SystemColors.Control
        Me._Check_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_11.Location = New System.Drawing.Point(612, 88)
        Me._Check_11.Name = "_Check_11"
        Me._Check_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Check_11.Size = New System.Drawing.Size(17, 17)
        Me._Check_11.TabIndex = 51
        Me._Check_11.Text = "Check1"
        Me._Check_11.UseVisualStyleBackColor = False
        '
        '_Check_10
        '
        Me._Check_10.BackColor = System.Drawing.SystemColors.Control
        Me._Check_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_10.Location = New System.Drawing.Point(568, 88)
        Me._Check_10.Name = "_Check_10"
        Me._Check_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Check_10.Size = New System.Drawing.Size(17, 17)
        Me._Check_10.TabIndex = 50
        Me._Check_10.Text = "Check1"
        Me._Check_10.UseVisualStyleBackColor = False
        '
        '_Check_9
        '
        Me._Check_9.BackColor = System.Drawing.SystemColors.Control
        Me._Check_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_9.Location = New System.Drawing.Point(524, 88)
        Me._Check_9.Name = "_Check_9"
        Me._Check_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Check_9.Size = New System.Drawing.Size(17, 17)
        Me._Check_9.TabIndex = 49
        Me._Check_9.Text = "Check1"
        Me._Check_9.UseVisualStyleBackColor = False
        '
        '_Edit_Down_15
        '
        Me._Edit_Down_15.AcceptsReturn = True
        Me._Edit_Down_15.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Down_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Down_15.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Down_15.Location = New System.Drawing.Point(772, 64)
        Me._Edit_Down_15.MaxLength = 0
        Me._Edit_Down_15.Name = "_Edit_Down_15"
        Me._Edit_Down_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Down_15.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Down_15.TabIndex = 48
        '
        '_Edit_Down_14
        '
        Me._Edit_Down_14.AcceptsReturn = True
        Me._Edit_Down_14.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Down_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Down_14.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Down_14.Location = New System.Drawing.Point(730, 64)
        Me._Edit_Down_14.MaxLength = 0
        Me._Edit_Down_14.Name = "_Edit_Down_14"
        Me._Edit_Down_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Down_14.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Down_14.TabIndex = 47
        '
        '_Edit_Down_13
        '
        Me._Edit_Down_13.AcceptsReturn = True
        Me._Edit_Down_13.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Down_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Down_13.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Down_13.Location = New System.Drawing.Point(687, 64)
        Me._Edit_Down_13.MaxLength = 0
        Me._Edit_Down_13.Name = "_Edit_Down_13"
        Me._Edit_Down_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Down_13.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Down_13.TabIndex = 46
        '
        '_Edit_Down_12
        '
        Me._Edit_Down_12.AcceptsReturn = True
        Me._Edit_Down_12.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Down_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Down_12.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Down_12.Location = New System.Drawing.Point(644, 64)
        Me._Edit_Down_12.MaxLength = 0
        Me._Edit_Down_12.Name = "_Edit_Down_12"
        Me._Edit_Down_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Down_12.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Down_12.TabIndex = 45
        '
        '_Edit_Down_11
        '
        Me._Edit_Down_11.AcceptsReturn = True
        Me._Edit_Down_11.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Down_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Down_11.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Down_11.Location = New System.Drawing.Point(600, 64)
        Me._Edit_Down_11.MaxLength = 0
        Me._Edit_Down_11.Name = "_Edit_Down_11"
        Me._Edit_Down_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Down_11.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Down_11.TabIndex = 44
        '
        '_Edit_Down_10
        '
        Me._Edit_Down_10.AcceptsReturn = True
        Me._Edit_Down_10.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Down_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Down_10.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Down_10.Location = New System.Drawing.Point(556, 64)
        Me._Edit_Down_10.MaxLength = 0
        Me._Edit_Down_10.Name = "_Edit_Down_10"
        Me._Edit_Down_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Down_10.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Down_10.TabIndex = 43
        '
        '_Edit_Down_9
        '
        Me._Edit_Down_9.AcceptsReturn = True
        Me._Edit_Down_9.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Down_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Down_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Down_9.Location = New System.Drawing.Point(512, 64)
        Me._Edit_Down_9.MaxLength = 0
        Me._Edit_Down_9.Name = "_Edit_Down_9"
        Me._Edit_Down_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Down_9.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Down_9.TabIndex = 42
        '
        '_Edit_Up_15
        '
        Me._Edit_Up_15.AcceptsReturn = True
        Me._Edit_Up_15.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Up_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Up_15.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Up_15.Location = New System.Drawing.Point(772, 32)
        Me._Edit_Up_15.MaxLength = 0
        Me._Edit_Up_15.Name = "_Edit_Up_15"
        Me._Edit_Up_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Up_15.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Up_15.TabIndex = 41
        '
        '_Edit_Up_14
        '
        Me._Edit_Up_14.AcceptsReturn = True
        Me._Edit_Up_14.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Up_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Up_14.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Up_14.Location = New System.Drawing.Point(730, 32)
        Me._Edit_Up_14.MaxLength = 0
        Me._Edit_Up_14.Name = "_Edit_Up_14"
        Me._Edit_Up_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Up_14.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Up_14.TabIndex = 40
        '
        '_Edit_Up_13
        '
        Me._Edit_Up_13.AcceptsReturn = True
        Me._Edit_Up_13.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Up_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Up_13.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Up_13.Location = New System.Drawing.Point(687, 32)
        Me._Edit_Up_13.MaxLength = 0
        Me._Edit_Up_13.Name = "_Edit_Up_13"
        Me._Edit_Up_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Up_13.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Up_13.TabIndex = 39
        '
        '_Edit_Up_12
        '
        Me._Edit_Up_12.AcceptsReturn = True
        Me._Edit_Up_12.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Up_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Up_12.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Up_12.Location = New System.Drawing.Point(644, 32)
        Me._Edit_Up_12.MaxLength = 0
        Me._Edit_Up_12.Name = "_Edit_Up_12"
        Me._Edit_Up_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Up_12.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Up_12.TabIndex = 38
        '
        '_Edit_Up_11
        '
        Me._Edit_Up_11.AcceptsReturn = True
        Me._Edit_Up_11.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Up_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Up_11.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Up_11.Location = New System.Drawing.Point(600, 32)
        Me._Edit_Up_11.MaxLength = 0
        Me._Edit_Up_11.Name = "_Edit_Up_11"
        Me._Edit_Up_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Up_11.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Up_11.TabIndex = 37
        '
        '_Edit_Up_10
        '
        Me._Edit_Up_10.AcceptsReturn = True
        Me._Edit_Up_10.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Up_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Up_10.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Up_10.Location = New System.Drawing.Point(556, 32)
        Me._Edit_Up_10.MaxLength = 0
        Me._Edit_Up_10.Name = "_Edit_Up_10"
        Me._Edit_Up_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Up_10.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Up_10.TabIndex = 36
        '
        '_Edit_Up_9
        '
        Me._Edit_Up_9.AcceptsReturn = True
        Me._Edit_Up_9.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Up_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Up_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Up_9.Location = New System.Drawing.Point(512, 32)
        Me._Edit_Up_9.MaxLength = 0
        Me._Edit_Up_9.Name = "_Edit_Up_9"
        Me._Edit_Up_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Up_9.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Up_9.TabIndex = 35
        '
        '_Check_8
        '
        Me._Check_8.BackColor = System.Drawing.SystemColors.Control
        Me._Check_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_8.Location = New System.Drawing.Point(479, 88)
        Me._Check_8.Name = "_Check_8"
        Me._Check_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Check_8.Size = New System.Drawing.Size(17, 17)
        Me._Check_8.TabIndex = 34
        Me._Check_8.Text = "Check1"
        Me._Check_8.UseVisualStyleBackColor = False
        '
        '_Edit_Down_8
        '
        Me._Edit_Down_8.AcceptsReturn = True
        Me._Edit_Down_8.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Down_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Down_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Down_8.Location = New System.Drawing.Point(467, 64)
        Me._Edit_Down_8.MaxLength = 0
        Me._Edit_Down_8.Name = "_Edit_Down_8"
        Me._Edit_Down_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Down_8.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Down_8.TabIndex = 33
        '
        '_Edit_Up_8
        '
        Me._Edit_Up_8.AcceptsReturn = True
        Me._Edit_Up_8.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Up_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Up_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Up_8.Location = New System.Drawing.Point(467, 32)
        Me._Edit_Up_8.MaxLength = 0
        Me._Edit_Up_8.Name = "_Edit_Up_8"
        Me._Edit_Up_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Up_8.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Up_8.TabIndex = 32
        '
        '_Check_7
        '
        Me._Check_7.BackColor = System.Drawing.SystemColors.Control
        Me._Check_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_7.Location = New System.Drawing.Point(436, 88)
        Me._Check_7.Name = "_Check_7"
        Me._Check_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Check_7.Size = New System.Drawing.Size(17, 17)
        Me._Check_7.TabIndex = 28
        Me._Check_7.Text = "Check1"
        Me._Check_7.UseVisualStyleBackColor = False
        '
        '_Check_6
        '
        Me._Check_6.BackColor = System.Drawing.SystemColors.Control
        Me._Check_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_6.Location = New System.Drawing.Point(394, 88)
        Me._Check_6.Name = "_Check_6"
        Me._Check_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Check_6.Size = New System.Drawing.Size(17, 17)
        Me._Check_6.TabIndex = 27
        Me._Check_6.Text = "Check1"
        Me._Check_6.UseVisualStyleBackColor = False
        '
        '_Check_5
        '
        Me._Check_5.BackColor = System.Drawing.SystemColors.Control
        Me._Check_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_5.Location = New System.Drawing.Point(348, 88)
        Me._Check_5.Name = "_Check_5"
        Me._Check_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Check_5.Size = New System.Drawing.Size(17, 17)
        Me._Check_5.TabIndex = 26
        Me._Check_5.Text = "Check1"
        Me._Check_5.UseVisualStyleBackColor = False
        '
        '_Check_4
        '
        Me._Check_4.BackColor = System.Drawing.SystemColors.Control
        Me._Check_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_4.Location = New System.Drawing.Point(307, 88)
        Me._Check_4.Name = "_Check_4"
        Me._Check_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Check_4.Size = New System.Drawing.Size(17, 17)
        Me._Check_4.TabIndex = 25
        Me._Check_4.Text = "Check1"
        Me._Check_4.UseVisualStyleBackColor = False
        '
        '_Check_3
        '
        Me._Check_3.BackColor = System.Drawing.SystemColors.Control
        Me._Check_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_3.Location = New System.Drawing.Point(264, 88)
        Me._Check_3.Name = "_Check_3"
        Me._Check_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Check_3.Size = New System.Drawing.Size(17, 17)
        Me._Check_3.TabIndex = 24
        Me._Check_3.Text = "Check1"
        Me._Check_3.UseVisualStyleBackColor = False
        '
        '_Check_2
        '
        Me._Check_2.BackColor = System.Drawing.SystemColors.Control
        Me._Check_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_2.Location = New System.Drawing.Point(220, 88)
        Me._Check_2.Name = "_Check_2"
        Me._Check_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Check_2.Size = New System.Drawing.Size(17, 17)
        Me._Check_2.TabIndex = 23
        Me._Check_2.Text = "Check1"
        Me._Check_2.UseVisualStyleBackColor = False
        '
        '_Check_1
        '
        Me._Check_1.BackColor = System.Drawing.SystemColors.Control
        Me._Check_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_1.Location = New System.Drawing.Point(176, 88)
        Me._Check_1.Name = "_Check_1"
        Me._Check_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Check_1.Size = New System.Drawing.Size(17, 17)
        Me._Check_1.TabIndex = 22
        Me._Check_1.Text = "Check1"
        Me._Check_1.UseVisualStyleBackColor = False
        '
        'Button_Trigger
        '
        Me.Button_Trigger.BackColor = System.Drawing.SystemColors.Control
        Me.Button_Trigger.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button_Trigger.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_Trigger.Location = New System.Drawing.Point(344, 120)
        Me.Button_Trigger.Name = "Button_Trigger"
        Me.Button_Trigger.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button_Trigger.Size = New System.Drawing.Size(113, 20)
        Me.Button_Trigger.TabIndex = 21
        Me.Button_Trigger.Text = "Trigger Start"
        Me.Button_Trigger.UseVisualStyleBackColor = False
        '
        '_Check_0
        '
        Me._Check_0.BackColor = System.Drawing.SystemColors.Control
        Me._Check_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Check_0.Location = New System.Drawing.Point(128, 88)
        Me._Check_0.Name = "_Check_0"
        Me._Check_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Check_0.Size = New System.Drawing.Size(17, 17)
        Me._Check_0.TabIndex = 20
        Me._Check_0.Text = "Check1"
        Me._Check_0.UseVisualStyleBackColor = False
        '
        '_Edit_Down_7
        '
        Me._Edit_Down_7.AcceptsReturn = True
        Me._Edit_Down_7.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Down_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Down_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Down_7.Location = New System.Drawing.Point(424, 64)
        Me._Edit_Down_7.MaxLength = 0
        Me._Edit_Down_7.Name = "_Edit_Down_7"
        Me._Edit_Down_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Down_7.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Down_7.TabIndex = 19
        '
        '_Edit_Down_6
        '
        Me._Edit_Down_6.AcceptsReturn = True
        Me._Edit_Down_6.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Down_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Down_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Down_6.Location = New System.Drawing.Point(382, 64)
        Me._Edit_Down_6.MaxLength = 0
        Me._Edit_Down_6.Name = "_Edit_Down_6"
        Me._Edit_Down_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Down_6.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Down_6.TabIndex = 18
        '
        '_Edit_Down_5
        '
        Me._Edit_Down_5.AcceptsReturn = True
        Me._Edit_Down_5.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Down_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Down_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Down_5.Location = New System.Drawing.Point(339, 64)
        Me._Edit_Down_5.MaxLength = 0
        Me._Edit_Down_5.Name = "_Edit_Down_5"
        Me._Edit_Down_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Down_5.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Down_5.TabIndex = 17
        '
        '_Edit_Down_4
        '
        Me._Edit_Down_4.AcceptsReturn = True
        Me._Edit_Down_4.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Down_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Down_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Down_4.Location = New System.Drawing.Point(296, 64)
        Me._Edit_Down_4.MaxLength = 0
        Me._Edit_Down_4.Name = "_Edit_Down_4"
        Me._Edit_Down_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Down_4.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Down_4.TabIndex = 16
        '
        '_Edit_Down_3
        '
        Me._Edit_Down_3.AcceptsReturn = True
        Me._Edit_Down_3.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Down_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Down_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Down_3.Location = New System.Drawing.Point(252, 64)
        Me._Edit_Down_3.MaxLength = 0
        Me._Edit_Down_3.Name = "_Edit_Down_3"
        Me._Edit_Down_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Down_3.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Down_3.TabIndex = 15
        '
        '_Edit_Down_2
        '
        Me._Edit_Down_2.AcceptsReturn = True
        Me._Edit_Down_2.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Down_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Down_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Down_2.Location = New System.Drawing.Point(208, 64)
        Me._Edit_Down_2.MaxLength = 0
        Me._Edit_Down_2.Name = "_Edit_Down_2"
        Me._Edit_Down_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Down_2.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Down_2.TabIndex = 14
        '
        '_Edit_Down_1
        '
        Me._Edit_Down_1.AcceptsReturn = True
        Me._Edit_Down_1.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Down_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Down_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Down_1.Location = New System.Drawing.Point(164, 64)
        Me._Edit_Down_1.MaxLength = 0
        Me._Edit_Down_1.Name = "_Edit_Down_1"
        Me._Edit_Down_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Down_1.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Down_1.TabIndex = 13
        '
        '_Edit_Down_0
        '
        Me._Edit_Down_0.AcceptsReturn = True
        Me._Edit_Down_0.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Down_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Down_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Down_0.Location = New System.Drawing.Point(120, 64)
        Me._Edit_Down_0.MaxLength = 0
        Me._Edit_Down_0.Name = "_Edit_Down_0"
        Me._Edit_Down_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Down_0.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Down_0.TabIndex = 12
        '
        '_Edit_Up_7
        '
        Me._Edit_Up_7.AcceptsReturn = True
        Me._Edit_Up_7.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Up_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Up_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Up_7.Location = New System.Drawing.Point(424, 32)
        Me._Edit_Up_7.MaxLength = 0
        Me._Edit_Up_7.Name = "_Edit_Up_7"
        Me._Edit_Up_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Up_7.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Up_7.TabIndex = 11
        '
        '_Edit_Up_6
        '
        Me._Edit_Up_6.AcceptsReturn = True
        Me._Edit_Up_6.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Up_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Up_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Up_6.Location = New System.Drawing.Point(382, 32)
        Me._Edit_Up_6.MaxLength = 0
        Me._Edit_Up_6.Name = "_Edit_Up_6"
        Me._Edit_Up_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Up_6.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Up_6.TabIndex = 10
        '
        '_Edit_Up_5
        '
        Me._Edit_Up_5.AcceptsReturn = True
        Me._Edit_Up_5.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Up_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Up_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Up_5.Location = New System.Drawing.Point(339, 32)
        Me._Edit_Up_5.MaxLength = 0
        Me._Edit_Up_5.Name = "_Edit_Up_5"
        Me._Edit_Up_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Up_5.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Up_5.TabIndex = 9
        '
        '_Edit_Up_4
        '
        Me._Edit_Up_4.AcceptsReturn = True
        Me._Edit_Up_4.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Up_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Up_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Up_4.Location = New System.Drawing.Point(296, 32)
        Me._Edit_Up_4.MaxLength = 0
        Me._Edit_Up_4.Name = "_Edit_Up_4"
        Me._Edit_Up_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Up_4.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Up_4.TabIndex = 8
        '
        '_Edit_Up_3
        '
        Me._Edit_Up_3.AcceptsReturn = True
        Me._Edit_Up_3.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Up_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Up_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Up_3.Location = New System.Drawing.Point(252, 32)
        Me._Edit_Up_3.MaxLength = 0
        Me._Edit_Up_3.Name = "_Edit_Up_3"
        Me._Edit_Up_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Up_3.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Up_3.TabIndex = 7
        '
        '_Edit_Up_2
        '
        Me._Edit_Up_2.AcceptsReturn = True
        Me._Edit_Up_2.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Up_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Up_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Up_2.Location = New System.Drawing.Point(208, 32)
        Me._Edit_Up_2.MaxLength = 0
        Me._Edit_Up_2.Name = "_Edit_Up_2"
        Me._Edit_Up_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Up_2.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Up_2.TabIndex = 6
        '
        '_Edit_Up_1
        '
        Me._Edit_Up_1.AcceptsReturn = True
        Me._Edit_Up_1.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Up_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Up_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Up_1.Location = New System.Drawing.Point(164, 32)
        Me._Edit_Up_1.MaxLength = 0
        Me._Edit_Up_1.Name = "_Edit_Up_1"
        Me._Edit_Up_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Up_1.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Up_1.TabIndex = 5
        '
        '_Edit_Up_0
        '
        Me._Edit_Up_0.AcceptsReturn = True
        Me._Edit_Up_0.BackColor = System.Drawing.SystemColors.Window
        Me._Edit_Up_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Edit_Up_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Edit_Up_0.Location = New System.Drawing.Point(120, 32)
        Me._Edit_Up_0.MaxLength = 0
        Me._Edit_Up_0.Name = "_Edit_Up_0"
        Me._Edit_Up_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Edit_Up_0.Size = New System.Drawing.Size(39, 19)
        Me._Edit_Up_0.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(24, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "有効／無効："
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(24, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "ダウンカウント："
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(24, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "アップカウント："
        '
        'Button_DioIint
        '
        Me.Button_DioIint.BackColor = System.Drawing.SystemColors.Control
        Me.Button_DioIint.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button_DioIint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_DioIint.Location = New System.Drawing.Point(352, 24)
        Me.Button_DioIint.Name = "Button_DioIint"
        Me.Button_DioIint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button_DioIint.Size = New System.Drawing.Size(113, 20)
        Me.Button_DioIint.TabIndex = 2
        Me.Button_DioIint.Text = "DioInit"
        Me.Button_DioIint.UseVisualStyleBackColor = False
        '
        'Edit_DeviceName
        '
        Me.Edit_DeviceName.AcceptsReturn = True
        Me.Edit_DeviceName.BackColor = System.Drawing.SystemColors.Window
        Me.Edit_DeviceName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Edit_DeviceName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Edit_DeviceName.Location = New System.Drawing.Point(104, 24)
        Me.Edit_DeviceName.MaxLength = 0
        Me.Edit_DeviceName.Name = "Edit_DeviceName"
        Me.Edit_DeviceName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Edit_DeviceName.Size = New System.Drawing.Size(97, 19)
        Me.Edit_DeviceName.TabIndex = 0
        Me.Edit_DeviceName.Text = "Text1"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(24, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "戻り値："
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(32, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "デバイス名："
        '
        'Trigger
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(848, 297)
        Me.Controls.Add(Me.Edit_ReturnCode)
        Me.Controls.Add(Me.Button_DioExit)
        Me.Controls.Add(Me.Button_Exit)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Button_DioIint)
        Me.Controls.Add(Me.Edit_DeviceName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Trigger"
        Me.Text = "トリガ監視"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "アップグレード ウィザードのサポート コード"
    Private Shared m_vb6FormDefInstance As Trigger
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Trigger
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Trigger()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(value As Trigger)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

    Dim Id As Short                         ' デバイスID1
    Dim Id0 As Short
    Dim Ret As Integer                      ' 戻り値
    Dim szError As New StringBuilder("", 256)      ' エラー文字列
    Dim szText As New String("", 100)
    Dim UpCount(16) As Short                 ' アップカウンタ
    Dim DownCount(16) As Short               ' ダウンカウンタ
    Dim Check(15) As CheckBox
    Dim Edit_Down(15) As TextBox
    Dim Edit_Up(15) As TextBox

    '---------------------------------------------------------
    ' ダイアログ初期化
    '---------------------------------------------------------
    Private Sub Trigger_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Dim i As Short

        Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2

        Check(0) = _Check_0
        Check(1) = _Check_1
        Check(2) = _Check_2
        Check(3) = _Check_3
        Check(4) = _Check_4
        Check(5) = _Check_5
        Check(6) = _Check_6
        Check(7) = _Check_7
        Check(8) = _Check_8
        Check(9) = _Check_9
        Check(10) = _Check_10
        Check(11) = _Check_11
        Check(12) = _Check_12
        Check(13) = _Check_13
        Check(14) = _Check_14
        Check(15) = _Check_15

        Edit_Down(0) = _Edit_Down_0
        Edit_Down(1) = _Edit_Down_1
        Edit_Down(2) = _Edit_Down_2
        Edit_Down(3) = _Edit_Down_3
        Edit_Down(4) = _Edit_Down_4
        Edit_Down(5) = _Edit_Down_5
        Edit_Down(6) = _Edit_Down_6
        Edit_Down(7) = _Edit_Down_7
        Edit_Down(8) = _Edit_Down_8
        Edit_Down(9) = _Edit_Down_9
        Edit_Down(10) = _Edit_Down_10
        Edit_Down(11) = _Edit_Down_11
        Edit_Down(12) = _Edit_Down_12
        Edit_Down(13) = _Edit_Down_13
        Edit_Down(14) = _Edit_Down_14
        Edit_Down(15) = _Edit_Down_15

        Edit_Up(0) = _Edit_Up_0
        Edit_Up(1) = _Edit_Up_1
        Edit_Up(2) = _Edit_Up_2
        Edit_Up(3) = _Edit_Up_3
        Edit_Up(4) = _Edit_Up_4
        Edit_Up(5) = _Edit_Up_5
        Edit_Up(6) = _Edit_Up_6
        Edit_Up(7) = _Edit_Up_7
        Edit_Up(8) = _Edit_Up_8
        Edit_Up(9) = _Edit_Up_9
        Edit_Up(10) = _Edit_Up_10
        Edit_Up(11) = _Edit_Up_11
        Edit_Up(12) = _Edit_Up_12
        Edit_Up(13) = _Edit_Up_13
        Edit_Up(14) = _Edit_Up_14
        Edit_Up(15) = _Edit_Up_15

        ' 画面アイテムの初期化
        Edit_DeviceName.Text = "DIO000"

        For i = 0 To 15
            Check(i).Checked = True
        Next
        ' アップカウンタ
        For i = 0 To 15
            Edit_Up(i).Text = ""
        Next i

        ' ダウンカウンタ
        For i = 0 To 15
            Edit_Down(i).Text = ""
        Next i

        Edit_ReturnCode.Text = ""

        'DIO初期化
        DioInitialize()
        'DIOトリガ監視開始
        DioTriggerScanStart()

        frmMain.Show()

    End Sub

    Public Sub DioInitialize()
        Ret = DioInit("DIO000", Id0)
        Ret = DioInit("DIO000", Id)
        'If frmMain.EmExMode Then
        '    Ret = DioInit("DIO001", Id)
        'Else
        '    Ret = DioInit("DIO000", Id)
        'End If
        DioGetErrorString(Ret, szError)
        Edit_ReturnCode.Text = "Ret = " & Ret & ":" & szError.ToString()
    End Sub

    Public Sub DioTriggerScanStart()
        Dim i As Short
        Dim BitNo As Short
        Dim Kind As Short
        Dim Tim As Integer
        ' 変数を初期化する
        For i = 0 To 15
            UpCount(i) = 0                      ' アップカウンタ
            DownCount(i) = 0                    ' ダウンカウンタ
        Next i
        ' チェックを見て
        Tim = 100                               ' 100ms周期で監視
        Kind = DIO_TRG_RISE Or DIO_TRG_FALL     ' アップダウン両方を監視
        For BitNo = 0 To 15
            ' トリガ開始
            If Check(BitNo).CheckState = 1 Then
                Ret = DioNotifyTrg(Id, BitNo, Kind, Tim, Me.Handle.ToInt32)
                If (Ret <> DIO_ERR_SUCCESS) Then
                    Exit For
                End If
                ' またはトリガ停止
            Else
                Ret = DioStopNotifyTrg(Id, BitNo)
                If (Ret <> DIO_ERR_SUCCESS) Then
                    Exit For
                End If
            End If
        Next BitNo
        ' エラー処理
        Call DioGetErrorString(Ret, szError)
        Edit_ReturnCode.Text = "Ret = " & Ret & ":" & szError.ToString()
    End Sub

    Public Sub DioEnd()
        Ret = DioExit(Id0)
        Ret = DioExit(Id)
        DioGetErrorString(Ret, szError)
        Edit_ReturnCode.Text = "Ret = " & Ret & ":" & szError.ToString()
        Ret = DioExit(Id0)
        Ret = DioExit(Id)
        End
    End Sub

    '---------------------------------------------------------
    ' 初期化処理
    '---------------------------------------------------------
    Private Sub Button_DioIint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Button_DioIint.Click

        Dim szDeviceName As String

        ' 画面からデバイス名を取得する
        szDeviceName = Edit_DeviceName.Text

        ' 初期化処理を行ない、IDを取得する
        Ret = DioInit(szDeviceName, Id)

        ' エラー処理
        Call DioGetErrorString(Ret, szError)
        Edit_ReturnCode.Text = "Ret = " & Ret & ":" & szError.ToString()

    End Sub

    '---------------------------------------------------------
    ' 終了処理
    '---------------------------------------------------------
    Private Sub Button_DioExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Button_DioExit.Click

        ' 終了処理を行う
        Ret = DioExit(Id)

        ' エラー処理
        Call DioGetErrorString(Ret, szError)
        Edit_ReturnCode.Text = "Ret = " & Ret & ":" & szError.ToString()

    End Sub

    '---------------------------------------------------------
    ' ダイアログ終了
    '---------------------------------------------------------
    Private Sub Button_Exit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Button_Exit.Click

        ' 終了処理を行う
        Ret = DioExit(Id)

        ' ダイアログを終了する
        End

    End Sub

    '---------------------------------------------------------
    ' トリガ監視開始
    '---------------------------------------------------------
    Private Sub Button_Trigger_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Button_Trigger.Click

        Dim i As Short
        Dim BitNo As Short
        Dim Kind As Short
        Dim Tim As Integer

        ' 変数を初期化する
        For i = 0 To 15
            UpCount(i) = 0                      ' アップカウンタ
            DownCount(i) = 0                    ' ダウンカウンタ
        Next i

        ' チェックを見て
        Tim = 100                               ' 100ms周期で監視
        Kind = DIO_TRG_RISE Or DIO_TRG_FALL     ' アップダウン両方を監視
        For BitNo = 0 To 15

            ' トリガ開始
            If Check(BitNo).CheckState = 1 Then
                Ret = DioNotifyTrg(Id, BitNo, Kind, Tim, Me.Handle.ToInt32)
                If (Ret <> DIO_ERR_SUCCESS) Then
                    Exit For
                End If

                ' またはトリガ停止
            Else
                Ret = DioStopNotifyTrg(Id, BitNo)
                If (Ret <> DIO_ERR_SUCCESS) Then
                    Exit For
                End If
            End If
        Next BitNo

        ' エラー処理
        Call DioGetErrorString(Ret, szError)
        Edit_ReturnCode.Text = "Ret = " & Ret & ":" & szError.ToString()

    End Sub

    '---------------------------------------------------------
    ' サブルーチン：チェック処理
    '---------------------------------------------------------
    Function CheckProcess(ByRef BitNo As Short) As Object

        Dim Tim As Integer              ' 100ms周期で監視
        Dim Kind As Short               ' アップダウン両方を監視

        Tim = 100
        Kind = DIO_TRG_RISE Or DIO_TRG_FALL

        ' トリガ開始
        If Check(BitNo).CheckState = 1 Then
            Ret = DioNotifyTrg(Id, BitNo, Kind, Tim, Me.Handle.ToInt32)

            ' またはトリガ停止
        Else
            Ret = DioStopNotifyTrg(Id, BitNo)
        End If

        ' エラー処理
        Call DioGetErrorString(Ret, szError)
        Edit_ReturnCode.Text = "Ret = " & Ret & ":" & szError.ToString()
        Return 0
    End Function

    '---------------------------------------------------------
    ' チェック処理
    '---------------------------------------------------------
    Private Sub _Check_0_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Check_0.CheckedChanged
        Call CheckProcess(0)
    End Sub

    Private Sub _Check_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Check_1.CheckedChanged
        Call CheckProcess(1)
    End Sub

    Private Sub _Check_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Check_2.CheckedChanged
        Call CheckProcess(2)
    End Sub

    Private Sub _Check_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Check_3.CheckedChanged
        Call CheckProcess(3)
    End Sub

    Private Sub _Check_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Check_4.CheckedChanged
        Call CheckProcess(4)
    End Sub

    Private Sub _Check_5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Check_5.CheckedChanged
        Call CheckProcess(5)
    End Sub

    Private Sub _Check_6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Check_6.CheckedChanged
        Call CheckProcess(6)
    End Sub

    Private Sub _Check_7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Check_7.CheckedChanged
        Call CheckProcess(7)
    End Sub

    Private Sub _Check_8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Check_8.CheckedChanged
        Call CheckProcess(8)
    End Sub

    Private Sub _Check_9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Check_9.CheckedChanged
        Call CheckProcess(9)
    End Sub

    Private Sub _Check_10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Check_10.CheckedChanged
        Call CheckProcess(10)
    End Sub

    Private Sub _Check_11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Check_11.CheckedChanged
        Call CheckProcess(11)
    End Sub

    Private Sub _Check_12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Check_12.CheckedChanged
        Call CheckProcess(12)
    End Sub

    Private Sub _Check_13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Check_13.CheckedChanged
        Call CheckProcess(13)
    End Sub

    Private Sub _Check_14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Check_14.CheckedChanged
        Call CheckProcess(14)
    End Sub

    Private Sub _Check_15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Check_15.CheckedChanged
        Call CheckProcess(15)
    End Sub
    '---------------------------------------------------------
    ' サブルーチン：HIWORD,LOWORDを取得する
    '---------------------------------------------------------
    Function HiLoWord(ByRef Number As Integer, ByRef HiLo As Short) As Integer

        Dim Hi As Integer
        Dim Lo As Integer
        Dim StrData As String
        Dim i As Short

        StrData = Hex(Number)
        If Len(StrData) < 8 Then
            For i = 1 To 8 - Len(StrData)
                StrData = "0" & StrData
            Next i
        End If

        Lo = Val("&h" & VB.Right(StrData, 4))
        Hi = Val("&h" & VB.Left(StrData, 4))
        If HiLo = 0 Then
            HiLoWord = Lo
        ElseIf HiLo = 1 Then
            HiLoWord = Hi
        End If

    End Function

    '---------------------------------------------------------
    ' メッセージハンドラ
    '---------------------------------------------------------
    Protected Overrides Sub WndProc(ByRef m As Message)
        Dim BitNo As Short
        Dim Id As Short
        Dim Kind As Short

        '--------------------------------------
        ' トリガイベントであれば
        '--------------------------------------
        If m.Msg = DIOM_TRIGGER Then

            Id = HiLoWord(m.WParam.ToInt32(), 0)             'DioInit関数で取得したID
            BitNo = HiLoWord(m.LParam.ToInt32(), 0)          'トリガビット番号
            Kind = HiLoWord(m.LParam.ToInt32(), 1)           '立ち上がり：1、もしくは立ち下がり：2、両方：3

            If (Kind And DIO_INT_RISE) Then
                'UpCount(BitNo) = UpCount(BitNo) + 1          'アップカウント
                Select Case BitNo
                    Case 0
                        frmMain.NowC(0, 0) += 1
                    Case 1
                        frmMain.NowC(0, 1) += 1
                    Case 2
                        frmMain.NowC(0, 2) += 1
                    Case 3
                        frmMain.NowC(0, 3) += 1
                    Case 4
                        frmMain.NowC(0, 4) += 1
                    Case 5
                        frmMain.NowC(0, 5) += 1
                    Case 6
                        frmMain.NowC(0, 6) += 1
                    Case 7
                        frmMain.NowC(1, 0) += 1
                    Case 8
                        frmMain.NowC(1, 1) += 1
                    Case 9
                        frmMain.NowC(1, 2) += 1
                    Case 10
                        frmMain.NowC(1, 3) += 1
                    Case 11
                        frmMain.NowC(1, 4) += 1
                    Case Else
                        'frmMain.NowX += 1
                End Select
            End If
            If (Kind And DIO_INT_FALL) Then
                'DownCount(BitNo) = DownCount(BitNo) + 1      'ダウンカウント
            End If
            '--------------------------------------
            ' カウント値表示
            '--------------------------------------
            'Edit_Up(BitNo).Text = CStr(UpCount(BitNo))
            'Edit_Down(BitNo).Text = CStr(DownCount(BitNo))
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub Frame1_Enter(sender As Object, e As EventArgs) Handles Frame1.Enter

    End Sub
End Class