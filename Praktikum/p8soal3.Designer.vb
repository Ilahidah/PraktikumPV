<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p8soal3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(30, 45)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(164, 214)
        Me.ListBox1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Pilih list untuk menghapus"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(218, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(123, 23)
        Me.TextBox1.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(218, 186)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Hapus"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(218, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'p8soal3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 327)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "p8soal3"
        Me.Text = "p8soal3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
