<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p4contoh2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnForNext = New System.Windows.Forms.Button()
        Me.btnDoWhile = New System.Windows.Forms.Button()
        Me.btnDoUntil = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnWhile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(52, 57)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(399, 244)
        Me.ListBox1.TabIndex = 0
        '
        'btnForNext
        '
        Me.btnForNext.Location = New System.Drawing.Point(52, 318)
        Me.btnForNext.Name = "btnForNext"
        Me.btnForNext.Size = New System.Drawing.Size(75, 24)
        Me.btnForNext.TabIndex = 1
        Me.btnForNext.Text = "For Next"
        Me.btnForNext.UseVisualStyleBackColor = True
        '
        'btnDoWhile
        '
        Me.btnDoWhile.Location = New System.Drawing.Point(133, 318)
        Me.btnDoWhile.Name = "btnDoWhile"
        Me.btnDoWhile.Size = New System.Drawing.Size(75, 24)
        Me.btnDoWhile.TabIndex = 2
        Me.btnDoWhile.Text = "Do While"
        Me.btnDoWhile.UseVisualStyleBackColor = True
        '
        'btnDoUntil
        '
        Me.btnDoUntil.Location = New System.Drawing.Point(214, 318)
        Me.btnDoUntil.Name = "btnDoUntil"
        Me.btnDoUntil.Size = New System.Drawing.Size(75, 24)
        Me.btnDoUntil.TabIndex = 3
        Me.btnDoUntil.Text = "Do Until"
        Me.btnDoUntil.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(376, 318)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 24)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnWhile
        '
        Me.btnWhile.Location = New System.Drawing.Point(295, 318)
        Me.btnWhile.Name = "btnWhile"
        Me.btnWhile.Size = New System.Drawing.Size(75, 24)
        Me.btnWhile.TabIndex = 5
        Me.btnWhile.Text = "While"
        Me.btnWhile.UseVisualStyleBackColor = True
        '
        'p4contoh2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(519, 418)
        Me.Controls.Add(Me.btnWhile)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDoUntil)
        Me.Controls.Add(Me.btnDoWhile)
        Me.Controls.Add(Me.btnForNext)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "p4contoh2"
        Me.Text = "p4contoh2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnForNext As Button
    Friend WithEvents btnDoWhile As Button
    Friend WithEvents btnDoUntil As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnWhile As Button
End Class
