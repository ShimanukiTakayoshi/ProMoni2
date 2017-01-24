<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalendar
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
        Me.dgvCal = New System.Windows.Forms.DataGridView()
        Me.btnCalSet = New System.Windows.Forms.Button()
        Me.btnCalClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvCal2 = New System.Windows.Forms.DataGridView()
        CType(Me.dgvCal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCal2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCal
        '
        Me.dgvCal.AllowUserToAddRows = False
        Me.dgvCal.AllowUserToDeleteRows = False
        Me.dgvCal.AllowUserToResizeColumns = False
        Me.dgvCal.AllowUserToResizeRows = False
        Me.dgvCal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCal.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.dgvCal.Location = New System.Drawing.Point(23, 122)
        Me.dgvCal.Name = "dgvCal"
        Me.dgvCal.RowTemplate.Height = 21
        Me.dgvCal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvCal.Size = New System.Drawing.Size(991, 61)
        Me.dgvCal.TabIndex = 0
        '
        'btnCalSet
        '
        Me.btnCalSet.Location = New System.Drawing.Point(298, 16)
        Me.btnCalSet.Name = "btnCalSet"
        Me.btnCalSet.Size = New System.Drawing.Size(136, 49)
        Me.btnCalSet.TabIndex = 1
        Me.btnCalSet.Text = "SET"
        Me.btnCalSet.UseVisualStyleBackColor = True
        '
        'btnCalClose
        '
        Me.btnCalClose.Location = New System.Drawing.Point(461, 16)
        Me.btnCalClose.Name = "btnCalClose"
        Me.btnCalClose.Size = New System.Drawing.Size(121, 47)
        Me.btnCalClose.TabIndex = 2
        Me.btnCalClose.Text = "Close/Cancel"
        Me.btnCalClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "班編制カレンダー"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 27)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ｎｏ.１ライン"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 27)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ｎｏ.２ライン"
        '
        'dgvCal2
        '
        Me.dgvCal2.AllowUserToAddRows = False
        Me.dgvCal2.AllowUserToDeleteRows = False
        Me.dgvCal2.AllowUserToResizeColumns = False
        Me.dgvCal2.AllowUserToResizeRows = False
        Me.dgvCal2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCal2.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.dgvCal2.Location = New System.Drawing.Point(22, 268)
        Me.dgvCal2.Name = "dgvCal2"
        Me.dgvCal2.RowTemplate.Height = 21
        Me.dgvCal2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvCal2.Size = New System.Drawing.Size(991, 61)
        Me.dgvCal2.TabIndex = 5
        '
        'frmCalendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 401)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvCal2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalClose)
        Me.Controls.Add(Me.btnCalSet)
        Me.Controls.Add(Me.dgvCal)
        Me.Name = "frmCalendar"
        Me.Text = "班編制カレンダー"
        CType(Me.dgvCal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCal2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCal As System.Windows.Forms.DataGridView
    Friend WithEvents btnCalSet As System.Windows.Forms.Button
    Friend WithEvents btnCalClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvCal2 As System.Windows.Forms.DataGridView
End Class
