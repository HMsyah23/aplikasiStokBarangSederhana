<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formBarangKeluar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tanggalTxt = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.simpan = New System.Windows.Forms.Button()
        Me.stokLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.idText = New System.Windows.Forms.TextBox()
        Me.ComboBoxKaryawan = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxMerk = New System.Windows.Forms.ComboBox()
        Me.Merk = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.satuanTxt = New System.Windows.Forms.TextBox()
        Me.ComboBoxSpesifikasi = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ComboBoxNama = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.stokText = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tanggalTxt
        '
        Me.tanggalTxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tanggalTxt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tanggalTxt.Location = New System.Drawing.Point(164, 62)
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
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Tanggal Keluar"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(428, 396)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 39)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Batal"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'simpan
        '
        Me.simpan.BackColor = System.Drawing.Color.LimeGreen
        Me.simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.simpan.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Bold)
        Me.simpan.ForeColor = System.Drawing.Color.Transparent
        Me.simpan.Location = New System.Drawing.Point(335, 396)
        Me.simpan.Margin = New System.Windows.Forms.Padding(2)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(89, 39)
        Me.simpan.TabIndex = 35
        Me.simpan.Text = "Simpan"
        Me.simpan.UseVisualStyleBackColor = False
        '
        'stokLabel
        '
        Me.stokLabel.AutoSize = True
        Me.stokLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stokLabel.Location = New System.Drawing.Point(437, 266)
        Me.stokLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.stokLabel.Name = "stokLabel"
        Me.stokLabel.Size = New System.Drawing.Size(58, 19)
        Me.stokLabel.TabIndex = 7
        Me.stokLabel.Text = "@stok"
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
        Me.Panel1.TabIndex = 40
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
        Me.Label8.Text = "Data ATK Keluar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(326, 266)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 19)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Stok Saat Ini"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.idText)
        Me.GroupBox1.Controls.Add(Me.ComboBoxKaryawan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBoxMerk)
        Me.GroupBox1.Controls.Add(Me.Merk)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.satuanTxt)
        Me.GroupBox1.Controls.Add(Me.ComboBoxSpesifikasi)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.stokLabel)
        Me.GroupBox1.Controls.Add(Me.ComboBoxNama)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.tanggalTxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.stokText)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 91)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(499, 301)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input ATK Keluar"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label19.Location = New System.Drawing.Point(12, 35)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 20)
        Me.Label19.TabIndex = 157
        Me.Label19.Text = "Id Barang Keluar"
        '
        'idText
        '
        Me.idText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.idText.Enabled = False
        Me.idText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.idText.Location = New System.Drawing.Point(164, 32)
        Me.idText.Margin = New System.Windows.Forms.Padding(2)
        Me.idText.MaxLength = 7
        Me.idText.Name = "idText"
        Me.idText.Size = New System.Drawing.Size(135, 26)
        Me.idText.TabIndex = 156
        '
        'ComboBoxKaryawan
        '
        Me.ComboBoxKaryawan.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBoxKaryawan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxKaryawan.FormattingEnabled = True
        Me.ComboBoxKaryawan.Items.AddRange(New Object() {"Laki - Laki", "Perempuan"})
        Me.ComboBoxKaryawan.Location = New System.Drawing.Point(164, 94)
        Me.ComboBoxKaryawan.MaxLength = 2
        Me.ComboBoxKaryawan.Name = "ComboBoxKaryawan"
        Me.ComboBoxKaryawan.Size = New System.Drawing.Size(200, 28)
        Me.ComboBoxKaryawan.TabIndex = 155
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 97)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 20)
        Me.Label4.TabIndex = 154
        Me.Label4.Text = "Nama Karyawan"
        '
        'ComboBoxMerk
        '
        Me.ComboBoxMerk.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBoxMerk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMerk.FormattingEnabled = True
        Me.ComboBoxMerk.Location = New System.Drawing.Point(164, 162)
        Me.ComboBoxMerk.MaxLength = 2
        Me.ComboBoxMerk.Name = "ComboBoxMerk"
        Me.ComboBoxMerk.Size = New System.Drawing.Size(188, 28)
        Me.ComboBoxMerk.TabIndex = 152
        '
        'Merk
        '
        Me.Merk.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Merk.AutoSize = True
        Me.Merk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Merk.Location = New System.Drawing.Point(12, 162)
        Me.Merk.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Merk.Name = "Merk"
        Me.Merk.Size = New System.Drawing.Size(44, 20)
        Me.Merk.TabIndex = 151
        Me.Merk.Text = "Merk"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label16.Location = New System.Drawing.Point(12, 229)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 20)
        Me.Label16.TabIndex = 150
        Me.Label16.Text = "Satuan"
        '
        'satuanTxt
        '
        Me.satuanTxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.satuanTxt.Enabled = False
        Me.satuanTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.satuanTxt.Location = New System.Drawing.Point(164, 229)
        Me.satuanTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.satuanTxt.MaxLength = 7
        Me.satuanTxt.Name = "satuanTxt"
        Me.satuanTxt.Size = New System.Drawing.Size(102, 26)
        Me.satuanTxt.TabIndex = 149
        '
        'ComboBoxSpesifikasi
        '
        Me.ComboBoxSpesifikasi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBoxSpesifikasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSpesifikasi.FormattingEnabled = True
        Me.ComboBoxSpesifikasi.Location = New System.Drawing.Point(164, 196)
        Me.ComboBoxSpesifikasi.MaxLength = 2
        Me.ComboBoxSpesifikasi.Name = "ComboBoxSpesifikasi"
        Me.ComboBoxSpesifikasi.Size = New System.Drawing.Size(188, 28)
        Me.ComboBoxSpesifikasi.TabIndex = 148
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label17.Location = New System.Drawing.Point(12, 196)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 20)
        Me.Label17.TabIndex = 147
        Me.Label17.Text = "Spesifikasi"
        '
        'ComboBoxNama
        '
        Me.ComboBoxNama.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBoxNama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxNama.FormattingEnabled = True
        Me.ComboBoxNama.Items.AddRange(New Object() {"Laki - Laki", "Perempuan"})
        Me.ComboBoxNama.Location = New System.Drawing.Point(164, 128)
        Me.ComboBoxNama.MaxLength = 2
        Me.ComboBoxNama.Name = "ComboBoxNama"
        Me.ComboBoxNama.Size = New System.Drawing.Size(200, 28)
        Me.ComboBoxNama.TabIndex = 146
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label18.Location = New System.Drawing.Point(12, 128)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(107, 20)
        Me.Label18.TabIndex = 145
        Me.Label18.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 259)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 20)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "Vol"
        '
        'stokText
        '
        Me.stokText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.stokText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.stokText.Location = New System.Drawing.Point(164, 259)
        Me.stokText.Margin = New System.Windows.Forms.Padding(2)
        Me.stokText.MaxLength = 7
        Me.stokText.Name = "stokText"
        Me.stokText.Size = New System.Drawing.Size(75, 26)
        Me.stokText.TabIndex = 129
        '
        'formBarangKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1064, 457)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "formBarangKeluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formBarangKeluar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tanggalTxt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents simpan As System.Windows.Forms.Button
    Friend WithEvents stokLabel As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents stokText As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxKaryawan As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxMerk As System.Windows.Forms.ComboBox
    Friend WithEvents Merk As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents satuanTxt As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxSpesifikasi As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxNama As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents idText As System.Windows.Forms.TextBox
End Class
