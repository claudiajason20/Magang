<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JenisPendapatanMobilvb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JenisPendapatanMobilvb))
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Cari = New System.Windows.Forms.Button()
        Me.Hapus = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Tambah = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(23, 34)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(184, 20)
        Me.TextBox4.TabIndex = 24
        '
        'Cari
        '
        Me.Cari.Location = New System.Drawing.Point(222, 32)
        Me.Cari.Name = "Cari"
        Me.Cari.Size = New System.Drawing.Size(59, 23)
        Me.Cari.TabIndex = 23
        Me.Cari.Text = "Cari"
        Me.Cari.UseVisualStyleBackColor = True
        '
        'Hapus
        '
        Me.Hapus.Location = New System.Drawing.Point(306, 111)
        Me.Hapus.Name = "Hapus"
        Me.Hapus.Size = New System.Drawing.Size(78, 23)
        Me.Hapus.TabIndex = 22
        Me.Hapus.Text = "Hapus"
        Me.Hapus.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(306, 170)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(78, 23)
        Me.Cancel.TabIndex = 21
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Tambah
        '
        Me.Tambah.Location = New System.Drawing.Point(306, 140)
        Me.Tambah.Name = "Tambah"
        Me.Tambah.Size = New System.Drawing.Size(78, 23)
        Me.Tambah.TabIndex = 20
        Me.Tambah.Text = "Tambah"
        Me.Tambah.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(258, 288)
        Me.DataGridView1.TabIndex = 19
        '
        'JenisPendapatanMobilvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 379)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Cari)
        Me.Controls.Add(Me.Hapus)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Tambah)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "JenisPendapatanMobilvb"
        Me.Text = "Master Pendapatan Mobilvb"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Cari As Button
    Friend WithEvents Hapus As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents Tambah As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
