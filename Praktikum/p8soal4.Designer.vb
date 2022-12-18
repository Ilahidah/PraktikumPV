<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p8soal4
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(210, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Nama Produk"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Kode Produk" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(141, 90)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(218, 23)
        Me.TextBox2.TabIndex = 17
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(293, 129)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "tampilkan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nama Produk"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(141, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(218, 23)
        Me.TextBox1.TabIndex = 14
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 15
        Me.ListBox2.Location = New System.Drawing.Point(210, 204)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(149, 169)
        Me.ListBox2.TabIndex = 13
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(40, 204)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(127, 169)
        Me.ListBox1.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(141, 129)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Kode Produk" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(213, 129)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "set array"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'p8soal4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "p8soal4"
        Me.Text = "p8soal4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
End Class
