<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p7soal1
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(23, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 32)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "List Mahasiswa"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(93, 203)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(230, 23)
        Me.TextBox3.TabIndex = 33
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(93, 166)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(230, 23)
        Me.TextBox2.TabIndex = 32
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(93, 130)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(230, 23)
        Me.TextBox1.TabIndex = 31
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(255, 356)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(84, 23)
        Me.btnDel.TabIndex = 30
        Me.btnDel.Text = "Del"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(139, 356)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(84, 23)
        Me.btnAdd.TabIndex = 29
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(23, 356)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(84, 23)
        Me.btnInsert.TabIndex = 28
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Prodi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "NIM"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(23, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 139)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Mahasiswa"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Location = New System.Drawing.Point(375, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(536, 246)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tabel Mahasiswa"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 249)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(316, 101)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Index List"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 15)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "(i) del"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 15)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "(i) insert" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(70, 63)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(230, 23)
        Me.TextBox5.TabIndex = 39
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(70, 25)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(230, 23)
        Me.TextBox4.TabIndex = 38
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(19, 26)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(500, 205)
        Me.ListView1.TabIndex = 38
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'p7soal1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 438)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "p7soal1"
        Me.Text = "p7soal1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnDel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ListView1 As ListView
End Class
