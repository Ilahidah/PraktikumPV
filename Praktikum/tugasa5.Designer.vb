<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tugasa5
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "nama"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(73, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(164, 23)
        Me.TextBox1.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(311, 87)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(199, 250)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(73, 63)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(164, 23)
        Me.TextBox2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "nilai"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(162, 211)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Show max min value"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(25, 258)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(260, 79)
        Me.ListBox1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(26, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 30)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "DATA NILAI SISWA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 115)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masukkan inputan"
        '
        'tugasa5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(532, 364)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "tugasa5"
        Me.Text = "tugasa5"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
