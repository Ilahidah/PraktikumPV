<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p2contoh2
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbtnDefault = New System.Windows.Forms.RadioButton()
        Me.RbtnBiru = New System.Windows.Forms.RadioButton()
        Me.RbtnHijau = New System.Windows.Forms.RadioButton()
        Me.RbtnKuning = New System.Windows.Forms.RadioButton()
        Me.RbtnMerah = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbtnDefault)
        Me.GroupBox1.Controls.Add(Me.RbtnBiru)
        Me.GroupBox1.Controls.Add(Me.RbtnHijau)
        Me.GroupBox1.Controls.Add(Me.RbtnKuning)
        Me.GroupBox1.Controls.Add(Me.RbtnMerah)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(171, 157)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pilih warna"
        '
        'RbtnDefault
        '
        Me.RbtnDefault.AutoSize = True
        Me.RbtnDefault.Location = New System.Drawing.Point(14, 22)
        Me.RbtnDefault.Name = "RbtnDefault"
        Me.RbtnDefault.Size = New System.Drawing.Size(63, 19)
        Me.RbtnDefault.TabIndex = 2
        Me.RbtnDefault.TabStop = True
        Me.RbtnDefault.Text = "Default"
        Me.RbtnDefault.UseVisualStyleBackColor = True
        '
        'RbtnBiru
        '
        Me.RbtnBiru.AutoSize = True
        Me.RbtnBiru.Location = New System.Drawing.Point(14, 122)
        Me.RbtnBiru.Name = "RbtnBiru"
        Me.RbtnBiru.Size = New System.Drawing.Size(46, 19)
        Me.RbtnBiru.TabIndex = 3
        Me.RbtnBiru.TabStop = True
        Me.RbtnBiru.Text = "Biru"
        Me.RbtnBiru.UseVisualStyleBackColor = True
        '
        'RbtnHijau
        '
        Me.RbtnHijau.AutoSize = True
        Me.RbtnHijau.Location = New System.Drawing.Point(14, 97)
        Me.RbtnHijau.Name = "RbtnHijau"
        Me.RbtnHijau.Size = New System.Drawing.Size(53, 19)
        Me.RbtnHijau.TabIndex = 2
        Me.RbtnHijau.TabStop = True
        Me.RbtnHijau.Text = "Hijau"
        Me.RbtnHijau.UseVisualStyleBackColor = True
        '
        'RbtnKuning
        '
        Me.RbtnKuning.AutoSize = True
        Me.RbtnKuning.Location = New System.Drawing.Point(14, 72)
        Me.RbtnKuning.Name = "RbtnKuning"
        Me.RbtnKuning.Size = New System.Drawing.Size(63, 19)
        Me.RbtnKuning.TabIndex = 1
        Me.RbtnKuning.TabStop = True
        Me.RbtnKuning.Text = "Kuning"
        Me.RbtnKuning.UseVisualStyleBackColor = True
        '
        'RbtnMerah
        '
        Me.RbtnMerah.AutoSize = True
        Me.RbtnMerah.Location = New System.Drawing.Point(14, 47)
        Me.RbtnMerah.Name = "RbtnMerah"
        Me.RbtnMerah.Size = New System.Drawing.Size(59, 19)
        Me.RbtnMerah.TabIndex = 0
        Me.RbtnMerah.TabStop = True
        Me.RbtnMerah.Text = "Merah"
        Me.RbtnMerah.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(26, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "UBAH WARNA LAYAR"
        '
        'p2contoh2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 260)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "p2contoh2"
        Me.Text = "p2contoh2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RbtnBiru As RadioButton
    Friend WithEvents RbtnHijau As RadioButton
    Friend WithEvents RbtnKuning As RadioButton
    Friend WithEvents RbtnMerah As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents RbtnDefault As RadioButton
End Class
