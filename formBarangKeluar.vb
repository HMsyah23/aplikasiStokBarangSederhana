Public Class formBarangKeluar
    Dim id_barang_masuk, id_barang, stok, NIK As String

    Sub KodeOtomatis()
        kosongkan()
        CariKode("SELECT id_barang_keluar from barang_keluar order by id_barang_keluar desc")
        If Not rd.HasRows = True Then
            id_barang_masuk = "BK" + Format(Today, "yyMMdd") + "01"
            idText.Text = id_barang_masuk
        Else
            If Microsoft.VisualBasic.Mid(rd.Item("id_barang_keluar"), 3, 6) = Format(Today, "yyMMdd") Then
                id_barang_masuk = "BK" + Format(Microsoft.VisualBasic.Right(rd.Item("Id_barang_keluar"), 8) + 1, "00")
                idText.Text = id_barang_masuk
            Else
                id_barang_masuk = "BK" + Format(Today, "yyMMdd") + "01"
                idText.Text = id_barang_masuk
            End If
        End If
        kosongkan()
    End Sub


    Sub kosongkan()
        stokText.Clear()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kosongkan()
        KodeOtomatis()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Try
            CariKode("select * from barang_masuk where id_barang_masuk='" & idText.Text & "'")
            If (tanggalTxt.Text = "") Or (stokText.Text = "") Or (idText.Text = "") Or (stokText.Text = "") Or (satuanTxt.Text = "") Or (stokText.Text = 0) Then
                MsgBox("Isi Semua Kolom Terlebih Dahulu")
            Else
                If CInt(stokLabel.Text) >= CInt(stokText.Text) Then
                    If Not rd.HasRows Then
                        If MessageBox.Show("Simpan Data ...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                            queryData("insert into barang_keluar values('" & id_barang_masuk & "','" & NIK & "','" & id_barang & "','" & tanggalTxt.Text & "','" & stokText.Text & "')")
                            MsgBox("Data Stok ATK Berhasil Tersimpan")
                            Dim stok As Integer = CInt(stokLabel.Text) - CInt(stokText.Text)
                            queryData("update data_barang set stok='" & stok & "' where id_barang='" & id_barang & "'")
                            kosongkan()
                            KodeOtomatis()
                        Else
                            MsgBox("Gagal Menyimpan Data")
                        End If
                    End If
                Else
                    MsgBox("Stok Kurang")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub formBarangKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If (MyBase.Visible = True) Then
            Koneksi()
            KodeOtomatis()
            loadDataCombobox("select * from data_barang order by id_barang asc", ComboBoxNama, "nama_barang")
            loadDataCombobox("select * from karyawan order by NIK asc", ComboBoxKaryawan, "nama_karyawan")
            tanggalTxt.Text = Format(Today, "dd/MM/yyyy")
        End If
    End Sub



    Private Sub ComboBoxNama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNama.SelectedIndexChanged
        loadDataCombobox("select merk from data_barang where nama_barang='" & ComboBoxNama.Text & "' order by id_barang asc", ComboBoxMerk, "merk")
        loadDataCombobox("select spesifikasi from data_barang where nama_barang='" & ComboBoxNama.Text & "' order by id_barang asc", ComboBoxSpesifikasi, "spesifikasi")
        queryData("select satuan from data_barang where nama_barang='" & ComboBoxNama.Text & "' and merk='" & ComboBoxMerk.Text & "' and spesifikasi='" & ComboBoxSpesifikasi.Text & "'")
        satuanTxt.Text = cmd.ExecuteScalar()
        queryData("select id_barang from data_barang where nama_barang='" & ComboBoxNama.Text & "' and merk='" & ComboBoxMerk.Text & "' and spesifikasi='" & ComboBoxSpesifikasi.Text & "'")
        id_barang = cmd.ExecuteScalar()
        queryData("select stok from data_barang where nama_barang='" & ComboBoxNama.Text & "' and merk='" & ComboBoxMerk.Text & "' and spesifikasi='" & ComboBoxSpesifikasi.Text & "'")
        stok = cmd.ExecuteScalar()
    End Sub

    Private Sub ComboBoxMerk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMerk.SelectedIndexChanged
        loadDataCombobox("select spesifikasi from data_barang where nama_barang='" & ComboBoxNama.Text & "' and merk='" & ComboBoxMerk.Text & "' order by id_barang asc", ComboBoxSpesifikasi, "spesifikasi")
        queryData("select satuan from data_barang where nama_barang='" & ComboBoxNama.Text & "' and merk='" & ComboBoxMerk.Text & "' and spesifikasi='" & ComboBoxSpesifikasi.Text & "'")
        satuanTxt.Text = cmd.ExecuteScalar()
        queryData("select id_barang from data_barang where nama_barang='" & ComboBoxNama.Text & "' and merk='" & ComboBoxMerk.Text & "' and spesifikasi='" & ComboBoxSpesifikasi.Text & "'")
        id_barang = cmd.ExecuteScalar()
        queryData("select stok from data_barang where nama_barang='" & ComboBoxNama.Text & "' and merk='" & ComboBoxMerk.Text & "' and spesifikasi='" & ComboBoxSpesifikasi.Text & "'")
        stok = cmd.ExecuteScalar()
    End Sub

    Private Sub ComboBoxSpesifikasi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSpesifikasi.SelectedIndexChanged
        queryData("select satuan from data_barang where nama_barang='" & ComboBoxNama.Text & "' and merk='" & ComboBoxMerk.Text & "' and spesifikasi='" & ComboBoxSpesifikasi.Text & "'")
        satuanTxt.Text = cmd.ExecuteScalar()
        queryData("select id_barang from data_barang where nama_barang='" & ComboBoxNama.Text & "' and merk='" & ComboBoxMerk.Text & "' and spesifikasi='" & ComboBoxSpesifikasi.Text & "'")
        id_barang = cmd.ExecuteScalar()
        queryData("select stok from data_barang where nama_barang='" & ComboBoxNama.Text & "' and merk='" & ComboBoxMerk.Text & "' and spesifikasi='" & ComboBoxSpesifikasi.Text & "'")
        stok = cmd.ExecuteScalar()
        stokLabel.Text = stok
    End Sub


    Private Sub ComboBoxKaryawan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxKaryawan.SelectedIndexChanged
        queryData("select NIK from karyawan where nama_karyawan='" & ComboBoxKaryawan.Text & "'")
        NIK = cmd.ExecuteScalar()
    End Sub

    Private Sub stokText_TextChanged(sender As Object, e As EventArgs) Handles stokText.KeyPress
        numberOnly(e)
    End Sub

    Private Sub stokText_TextChanged_1(sender As Object, e As EventArgs) Handles stokText.KeyUp
        If stokText.Text = "" Then
            stokText.Text = 0
        End If
    End Sub
End Class