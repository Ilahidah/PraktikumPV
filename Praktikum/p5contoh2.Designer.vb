<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p5contoh2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(359, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NIM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Prodi"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(142, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(183, 23)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(142, 83)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(183, 23)
        Me.TextBox2.TabIndex = 10
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(30, 237)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(717, 179)
        Me.ListView1.TabIndex = 13
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(142, 125)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(183, 23)
        Me.ComboBox1.TabIndex = 14
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(142, 164)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(183, 23)
        Me.ComboBox2.TabIndex = 15
        '
        'p5contoh2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "p5contoh2"
        Me.Text = "p5contoh2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
End Class
