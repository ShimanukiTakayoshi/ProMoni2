<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClearTime
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
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.nudCtm = New System.Windows.Forms.NumericUpDown()
        Me.nudCth = New System.Windows.Forms.NumericUpDown()
        Me.btnWorkTimeOk = New System.Windows.Forms.Button()
        CType(Me.nudCtm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("ＭＳ ゴシック", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label46.Location = New System.Drawing.Point(62, 21)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(140, 21)
        Me.Label46.TabIndex = 136
        Me.Label46.Text = "ｶｳﾝﾄｸﾘｱ時間"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("ＭＳ ゴシック", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label29.Location = New System.Drawing.Point(118, 65)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(23, 24)
        Me.Label29.TabIndex = 134
        Me.Label29.Text = ":"
        '
        'nudCtm
        '
        Me.nudCtm.CausesValidation = False
        Me.nudCtm.Font = New System.Drawing.Font("ＭＳ ゴシック", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.nudCtm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.nudCtm.Location = New System.Drawing.Point(144, 64)
        Me.nudCtm.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudCtm.Name = "nudCtm"
        Me.nudCtm.ReadOnly = True
        Me.nudCtm.Size = New System.Drawing.Size(58, 28)
        Me.nudCtm.TabIndex = 133
        Me.nudCtm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudCth
        '
        Me.nudCth.CausesValidation = False
        Me.nudCth.Font = New System.Drawing.Font("ＭＳ ゴシック", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.nudCth.Location = New System.Drawing.Point(57, 64)
        Me.nudCth.Maximum = New Decimal(New Integer() {33, 0, 0, 0})
        Me.nudCth.Name = "nudCth"
        Me.nudCth.ReadOnly = True
        Me.nudCth.Size = New System.Drawing.Size(58, 28)
        Me.nudCth.TabIndex = 132
        Me.nudCth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnWorkTimeOk
        '
        Me.btnWorkTimeOk.Location = New System.Drawing.Point(77, 115)
        Me.btnWorkTimeOk.Name = "btnWorkTimeOk"
        Me.btnWorkTimeOk.Size = New System.Drawing.Size(103, 44)
        Me.btnWorkTimeOk.TabIndex = 137
        Me.btnWorkTimeOk.Text = "OK"
        Me.btnWorkTimeOk.UseVisualStyleBackColor = True
        '
        'frmClearTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 214)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnWorkTimeOk)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.nudCtm)
        Me.Controls.Add(Me.nudCth)
        Me.Name = "frmClearTime"
        Me.Text = "frmClearTime"
        CType(Me.nudCtm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents nudCtm As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudCth As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnWorkTimeOk As System.Windows.Forms.Button
End Class
