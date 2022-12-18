<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tugasb4
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnWhile = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDoUntil = New System.Windows.Forms.Button()
        Me.btnDoWhile = New System.Windows.Forms.Button()
        Me.btnForNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(26, 36)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(158, 199)
        Me.ListBox1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(198, 257)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(75, 23)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Masukan jumlah perulangan"
        '
        'btnWhile
        '
        Me.btnWhile.Location = New System.Drawing.Point(198, 165)
        Me.btnWhile.Name = "btnWhile"
        Me.btnWhile.Size = New System.Drawing.Size(75, 24)
        Me.btnWhile.TabIndex = 12
        Me.btnWhile.Text = "While"
        Me.btnWhile.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(198, 211)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 24)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDoUntil
        '
        Me.btnDoUntil.Location = New System.Drawing.Point(198, 122)
        Me.btnDoUntil.Name = "btnDoUntil"
        Me.btnDoUntil.Size = New System.Drawing.Size(75, 24)
        Me.btnDoUntil.TabIndex = 10
        Me.btnDoUntil.Text = "Do Until"
        Me.btnDoUntil.UseVisualStyleBackColor = True
        '
        'btnDoWhile
        '
        Me.btnDoWhile.Location = New System.Drawing.Point(198, 80)
        Me.btnDoWhile.Name = "btnDoWhile"
        Me.btnDoWhile.Size = New System.Drawing.Size(75, 24)
        Me.btnDoWhile.TabIndex = 9
        Me.btnDoWhile.Text = "Do While"
        Me.btnDoWhile.UseVisualStyleBackColor = True
        '
        'btnForNext
        '
        Me.btnForNext.Location = New System.Drawing.Point(198, 36)
        Me.btnForNext.Name = "btnForNext"
        Me.btnForNext.Size = New System.Drawing.Size(75, 24)
        Me.btnForNext.TabIndex = 8
        Me.btnForNext.Text = "For Next"
        Me.btnForNext.UseVisualStyleBackColor = True
        '
        'tugasb4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(324, 342)
        Me.Controls.Add(Me.btnWhile)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDoUntil)
        Me.Controls.Add(Me.btnDoWhile)
        Me.Controls.Add(Me.btnForNext)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "tugasb4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tugasb4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnWhile As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDoUntil As Button
    Friend WithEvents btnDoWhile As Button
    Friend WithEvents btnForNext As Button
End Class
