<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p3contoh1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nilai"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(217, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "ulang"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(324, 136)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(63, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "cek"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Predikat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(148, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ket"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(217, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(170, 23)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(217, 104)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(170, 23)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(217, 226)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(170, 23)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(217, 188)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(170, 23)
        Me.TextBox4.TabIndex = 9
        '
        'p3contoh1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 318)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "p3contoh1"
        Me.Text = "p3contoh1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
