<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtjudul = New System.Windows.Forms.TextBox()
        Me.txtiterasi = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnjalankan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "JUDUL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ITERASI"
        '
        'txtjudul
        '
        Me.txtjudul.Location = New System.Drawing.Point(227, 113)
        Me.txtjudul.Name = "txtjudul"
        Me.txtjudul.Size = New System.Drawing.Size(131, 20)
        Me.txtjudul.TabIndex = 2
        '
        'txtiterasi
        '
        Me.txtiterasi.Location = New System.Drawing.Point(227, 152)
        Me.txtiterasi.Name = "txtiterasi"
        Me.txtiterasi.Size = New System.Drawing.Size(131, 20)
        Me.txtiterasi.TabIndex = 3
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(499, 87)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 199)
        Me.ListBox1.TabIndex = 4
        '
        'btnjalankan
        '
        Me.btnjalankan.Location = New System.Drawing.Point(227, 211)
        Me.btnjalankan.Name = "btnjalankan"
        Me.btnjalankan.Size = New System.Drawing.Size(100, 23)
        Me.btnjalankan.TabIndex = 5
        Me.btnjalankan.Text = "JALANKAN"
        Me.btnjalankan.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnjalankan)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtiterasi)
        Me.Controls.Add(Me.txtjudul)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtjudul As TextBox
    Friend WithEvents txtiterasi As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnjalankan As Button
End Class
