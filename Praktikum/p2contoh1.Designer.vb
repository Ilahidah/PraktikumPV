<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p2contoh1
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
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.BtnEnter = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(143, 166)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(204, 23)
        Me.txtString.TabIndex = 1
        '
        'BtnEnter
        '
        Me.BtnEnter.Location = New System.Drawing.Point(272, 205)
        Me.BtnEnter.Name = "BtnEnter"
        Me.BtnEnter.Size = New System.Drawing.Size(75, 23)
        Me.BtnEnter.TabIndex = 2
        Me.BtnEnter.Text = "Enter"
        Me.BtnEnter.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(87, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "MENGHITUNG PANJANG STRING"
        '
        'p2contoh1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 323)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnEnter)
        Me.Controls.Add(Me.txtString)
        Me.Controls.Add(Me.Label1)
        Me.Name = "p2contoh1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "p2contoh1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtString As TextBox
    Friend WithEvents BtnEnter As Button
    Friend WithEvents Label2 As Label
End Class
