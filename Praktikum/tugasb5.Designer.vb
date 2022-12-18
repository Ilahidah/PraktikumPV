<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tugasb5
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No. Hp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Lama kerja"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Gaji pokok"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(313, 61)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(501, 302)
        Me.ListView1.TabIndex = 6
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(139, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(135, 23)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(139, 111)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(135, 23)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(139, 290)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(135, 23)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(139, 202)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(135, 23)
        Me.TextBox4.TabIndex = 11
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(139, 155)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(135, 23)
        Me.TextBox5.TabIndex = 10
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1 tahun", "2 tahun", "3 tahun", "4 tahun"})
        Me.ComboBox1.Location = New System.Drawing.Point(139, 249)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(135, 23)
        Me.ComboBox1.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(199, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "simpan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tugasb5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(871, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "tugasb5"
        Me.Text = "tugasb5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
End Class
