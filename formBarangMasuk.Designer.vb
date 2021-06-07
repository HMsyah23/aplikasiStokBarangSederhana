<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formBarangMasuk
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
        Me.volTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.idTxt = New System.Windows.Forms.TextBox()
        Me.ComboBoxMerk = New System.Windows.Forms.ComboBox()
        Me.Merk = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.satuanTxt = New System.Windows.Forms.TextBox()
        Me.ComboBoxSpesifikasi = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBoxNama = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.totalTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.hargaTxt = New System.Windows.Forms.TextBox()
        Me.tanggalTxt = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.simpan = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(14, 217)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 20)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "Vol"
        '
        'volTxt
        '
        Me.volTxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.volTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.volTxt.Location = New System.Drawing.Point(166, 217)
        Me.volTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.volTxt.MaxLength = 3
        Me.volTxt.Name = "volTxt"
        Me.volTxt.Size = New System.Drawing.Size(75, 26)
        Me.volTxt.TabIndex = 129
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.idTxt)
        Me.GroupBox1.Controls.Add(Me.ComboBoxMerk)
        Me.GroupBox1.Controls.Add(Me.Merk)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.satuanTxt)
        Me.GroupBox1.Controls.Add(Me.ComboBoxSpesifikasi)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.ComboBoxNama)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.totalTxt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.hargaTxt)
        Me.GroupBox1.Controls.Add(Me.tanggalTxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.volTxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 81)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(499, 311)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input ATK Masuk"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label17.Location = New System.Drawing.Point(14, 28)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(130, 20)
        Me.Label17.TabIndex = 146
        Me.Label17.Text = "Id Barang Masuk"
        '
        'idTxt
        '
        Me.idTxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.idTxt.Enabled = False
        Me.idTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.idTxt.Location = New System.Drawing.Point(166, 25)
        Me.idTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.idTxt.MaxLength = 7
        Me.idTxt.Name = "idTxt"
        Me.idTxt.Size = New System.Drawing.Size(142, 26)
        Me.idTxt.TabIndex = 145
        '
        'ComboBoxMerk
        '
        Me.ComboBoxMerk.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBoxMerk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMerk.FormattingEnabled = True
        Me.ComboBoxMerk.Location = New System.Drawing.Point(166, 120)
        Me.ComboBoxMerk.MaxLength = 2
        Me.ComboBoxMerk.Name = "ComboBoxMerk"
        Me.ComboBoxMerk.Size = New System.Drawing.Size(188, 28)
        Me.ComboBoxMerk.TabIndex = 144
        '
        'Merk
        '
        Me.Merk.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Merk.AutoSize = True
        Me.Merk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Merk.Location = New System.Drawing.Point(14, 120)
        Me.Merk.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Merk.Name = "Merk"
        Me.Merk.Size = New System.Drawing.Size(44, 20)
        Me.Merk.TabIndex = 143
        Me.Merk.Text = "Merk"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(14, 187)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 20)
        Me.Label15.TabIndex = 142
        Me.Label15.Text = "Satuan"
        '
        'satuanTxt
        '
        Me.satuanTxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.satuanTxt.Enabled = False
        Me.satuanTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.satuanTxt.Location = New System.Drawing.Point(166, 187)
        Me.satuanTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.satuanTxt.MaxLength = 7
        Me.satuanTxt.Name = "satuanTxt"
        Me.satuanTxt.Size = New System.Drawing.Size(102, 26)
        Me.satuanTxt.TabIndex = 141
        '
        'ComboBoxSpesifikasi
        '
        Me.ComboBoxSpesifikasi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBoxSpesifikasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSpesifikasi.FormattingEnabled = True
        Me.ComboBoxSpesifikasi.Location = New System.Drawing.Point(166, 154)
        Me.ComboBoxSpesifikasi.MaxLength = 2
        Me.ComboBoxSpesifikasi.Name = "ComboBoxSpesifikasi"
        Me.ComboBoxSpesifikasi.Size = New System.Drawing.Size(188, 28)
        Me.ComboBoxSpesifikasi.TabIndex = 140
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(14, 154)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 20)
        Me.Label14.TabIndex = 139
        Me.Label14.Text = "Spesifikasi"
        '
        'ComboBoxNama
        '
        Me.ComboBoxNama.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBoxNama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxNama.FormattingEnabled = True
        Me.ComboBoxNama.Items.AddRange(New Object() {"Laki - Laki", "Perempuan"})
        Me.ComboBoxNama.Location = New System.Drawing.Point(166, 86)
        Me.ComboBoxNama.MaxLength = 2
        Me.ComboBoxNama.Name = "ComboBoxNama"
        Me.ComboBoxNama.Size = New System.Drawing.Size(200, 28)
        Me.ComboBoxNama.TabIndex = 138
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(14, 86)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 20)
        Me.Label9.TabIndex = 137
        Me.Label9.Text = "Nama Barang"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(14, 277)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Total"
        '
        'totalTxt
        '
        Me.totalTxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.totalTxt.Enabled = False
        Me.totalTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.totalTxt.Location = New System.Drawing.Point(166, 277)
        Me.totalTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.totalTxt.MaxLength = 20
        Me.totalTxt.Name = "totalTxt"
        Me.totalTxt.Size = New System.Drawing.Size(130, 26)
        Me.totalTxt.TabIndex = 135
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(14, 247)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 20)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "Harga"
        '
        'hargaTxt
        '
        Me.hargaTxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.hargaTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.hargaTxt.Location = New System.Drawing.Point(166, 247)
        Me.hargaTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.hargaTxt.MaxLength = 8
        Me.hargaTxt.Name = "hargaTxt"
        Me.hargaTxt.Size = New System.Drawing.Size(130, 26)
        Me.hargaTxt.TabIndex = 133
        '
        'tanggalTxt
        '
        Me.tanggalTxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tanggalTxt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tanggalTxt.Location = New System.Drawing.Point(166, 55)
        Me.tanggalTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.tanggalTxt.Name = "tanggalTxt"
        Me.tanggalTxt.Size = New System.Drawing.Size(102, 26)
        Me.tanggalTxt.TabIndex = 131
        Me.tanggalTxt.Value = New Date(2021, 4, 4, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(14, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Tanggal Masuk"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(420, 396)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 39)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Batal"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'simpan
        '
        Me.simpan.BackColor = System.Drawing.Color.LimeGreen
        Me.simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.simpan.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Bold)
        Me.simpan.ForeColor = System.Drawing.Color.Transparent
        Me.simpan.Location = New System.Drawing.Point(326, 396)
        Me.simpan.Margin = New System.Windows.Forms.Padding(2)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(90, 39)
        Me.simpan.TabIndex = 28
        Me.simpan.Text = "Simpan"
        Me.simpan.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkViolet
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1064, 76)
        Me.Panel1.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 35.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(8, 10)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(390, 55)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Data ATK Masuk"
        '
        'formBarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1064, 457)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "formBarangMasuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formBarangMasuk"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents volTxt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents simpan As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tanggalTxt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents totalTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents hargaTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents satuanTxt As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxSpesifikasi As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxNama As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxMerk As System.Windows.Forms.ComboBox
    Friend WithEvents Merk As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents idTxt As System.Windows.Forms.TextBox
End Class
