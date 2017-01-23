<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemo
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
        Me.txtMemoIn = New System.Windows.Forms.TextBox()
        Me.btnMemo1 = New System.Windows.Forms.Button()
        Me.btnMemo2 = New System.Windows.Forms.Button()
        Me.btnMemo3 = New System.Windows.Forms.Button()
        Me.btnMemo4 = New System.Windows.Forms.Button()
        Me.btnMemo5 = New System.Windows.Forms.Button()
        Me.btnMemoClose = New System.Windows.Forms.Button()
        Me.btnMemoSet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMemoIn
        '
        Me.txtMemoIn.Location = New System.Drawing.Point(125, 21)
        Me.txtMemoIn.Multiline = True
        Me.txtMemoIn.Name = "txtMemoIn"
        Me.txtMemoIn.Size = New System.Drawing.Size(478, 206)
        Me.txtMemoIn.TabIndex = 0
        '
        'btnMemo1
        '
        Me.btnMemo1.Location = New System.Drawing.Point(12, 21)
        Me.btnMemo1.Name = "btnMemo1"
        Me.btnMemo1.Size = New System.Drawing.Size(99, 37)
        Me.btnMemo1.TabIndex = 1
        Me.btnMemo1.Text = "伝言１"
        Me.btnMemo1.UseVisualStyleBackColor = True
        '
        'btnMemo2
        '
        Me.btnMemo2.Location = New System.Drawing.Point(12, 64)
        Me.btnMemo2.Name = "btnMemo2"
        Me.btnMemo2.Size = New System.Drawing.Size(99, 37)
        Me.btnMemo2.TabIndex = 2
        Me.btnMemo2.Text = "伝言２"
        Me.btnMemo2.UseVisualStyleBackColor = True
        '
        'btnMemo3
        '
        Me.btnMemo3.Location = New System.Drawing.Point(12, 107)
        Me.btnMemo3.Name = "btnMemo3"
        Me.btnMemo3.Size = New System.Drawing.Size(99, 37)
        Me.btnMemo3.TabIndex = 3
        Me.btnMemo3.Text = "伝言３"
        Me.btnMemo3.UseVisualStyleBackColor = True
        '
        'btnMemo4
        '
        Me.btnMemo4.Location = New System.Drawing.Point(12, 150)
        Me.btnMemo4.Name = "btnMemo4"
        Me.btnMemo4.Size = New System.Drawing.Size(99, 37)
        Me.btnMemo4.TabIndex = 4
        Me.btnMemo4.Text = "伝言４"
        Me.btnMemo4.UseVisualStyleBackColor = True
        '
        'btnMemo5
        '
        Me.btnMemo5.Location = New System.Drawing.Point(12, 190)
        Me.btnMemo5.Name = "btnMemo5"
        Me.btnMemo5.Size = New System.Drawing.Size(99, 37)
        Me.btnMemo5.TabIndex = 5
        Me.btnMemo5.Text = "伝言５"
        Me.btnMemo5.UseVisualStyleBackColor = True
        '
        'btnMemoClose
        '
        Me.btnMemoClose.Location = New System.Drawing.Point(487, 244)
        Me.btnMemoClose.Name = "btnMemoClose"
        Me.btnMemoClose.Size = New System.Drawing.Size(99, 37)
        Me.btnMemoClose.TabIndex = 6
        Me.btnMemoClose.Text = "Close"
        Me.btnMemoClose.UseVisualStyleBackColor = True
        '
        'btnMemoSet
        '
        Me.btnMemoSet.Location = New System.Drawing.Point(147, 244)
        Me.btnMemoSet.Name = "btnMemoSet"
        Me.btnMemoSet.Size = New System.Drawing.Size(99, 37)
        Me.btnMemoSet.TabIndex = 7
        Me.btnMemoSet.Text = "Set"
        Me.btnMemoSet.UseVisualStyleBackColor = True
        '
        'frmMemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 302)
        Me.Controls.Add(Me.btnMemoSet)
        Me.Controls.Add(Me.btnMemoClose)
        Me.Controls.Add(Me.btnMemo5)
        Me.Controls.Add(Me.btnMemo4)
        Me.Controls.Add(Me.btnMemo3)
        Me.Controls.Add(Me.btnMemo2)
        Me.Controls.Add(Me.btnMemo1)
        Me.Controls.Add(Me.txtMemoIn)
        Me.Name = "frmMemo"
        Me.Text = "frmMemo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMemoIn As System.Windows.Forms.TextBox
    Friend WithEvents btnMemo1 As System.Windows.Forms.Button
    Friend WithEvents btnMemo2 As System.Windows.Forms.Button
    Friend WithEvents btnMemo3 As System.Windows.Forms.Button
    Friend WithEvents btnMemo4 As System.Windows.Forms.Button
    Friend WithEvents btnMemo5 As System.Windows.Forms.Button
    Friend WithEvents btnMemoClose As System.Windows.Forms.Button
    Friend WithEvents btnMemoSet As System.Windows.Forms.Button
End Class
