Public Class formBarangMasuk
    Dim id_barang_masuk, stok, id_barang As String
    Sub KodeOtomatis()
        kosongkan()
        CariKode("select id_barang_masuk from barang_masuk order by id_barang_masuk desc")
        If Not rd.HasRows = True Then
            id_barang_masuk = "BM" + Format(Today, "yyMMdd") + "01"
            idTxt.Text = id_barang_masuk
        Else
            If Microsoft.VisualBasic.Mid(rd.Item("id_barang_masuk"), 3, 6) = Format(Today, "yyMMdd") Then
                id_barang_masuk = "BM" + Format(Microsoft.VisualBasic.Right(rd.Item("Id_barang_masuk"), 8) + 1, "00")
                idTxt.Text = id_barang_masuk
            Else
                id_barang_masuk = "BM" + Format(Today, "yyMMdd") + "01"
                idTxt.Text = id_barang_masuk
            End If
        End If
        kosongkan()
    End Sub


    Sub kosongkan()
        hargaTxt.Text = 0
        volTxt.Text = 0
        totalTxt.Text = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kosongkan()
        KodeOtomatis()
    End Sub

    Private Sub formBarangMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If (MyBase.Visible = True) Then
            Koneksi()
            KodeOtomatis()
            loadDataCombobox("select * from data_barang order by id_barang asc", ComboBoxNama, "nama_barang")
            tanggalTxt.Text = Format(Today, "dd/MM/yyyy")
        End If
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Try
            CariKode("select * from barang_masuk where id_barang_masuk='" & idTxt.Text & "'")
            If (tanggalTxt.Text = "") Or (volTxt.Text = "") Or (idTxt.Text = "") Or (hargaTxt.Text = "") Or (ComboBoxMerk.Text = "") Or (ComboBoxNama.Text = "") Or (ComboBoxSpesifikasi.Text = "") Or (satuanTxt.Text = "") Then
                MsgBox("Isi Semua Kolom Terlebih Dahulu")
            Else
                If Not rd.HasRows Then
                    If MessageBox.Show("Simpan Data ...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        queryData("insert into barang_masuk values('" & id_barang_masuk & "','" & id_barang & "','" & tanggalTxt.Text & "','" & CInt(volTxt.Text) & "','" & CInt(hargaTxt.Text) & "','" & CInt(totalTxt.Text) & "')")
                        MsgBox("Data Stok ATK Berhasil Tersimpan")
                        Dim stok As Integer = CInt(stok) + CInt(volTxt.Text)
                        queryData("update data_barang set stok='" & stok & "' where id_barang='" & id_barang & "'")
                        kosongkan()
                        KodeOtomatis()
                    Else
                        MsgBox("Gagal Menyimpan Data")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
    End Sub

    Private Sub volTxt_TextChanged(sender As Object, e As EventArgs) Handles volTxt.KeyUp
        If volTxt.Text = "" Then
            volTxt.Text = 0
        End If
        totalTxt.Text = CInt(volTxt.Text) * CInt(hargaTxt.Text)
    End Sub

    Private Sub hargaTxt_TextChanged(sender As Object, e As EventArgs) Handles hargaTxt.KeyUp
        If hargaTxt.Text = "" Then
            hargaTxt.Text = 0
        End If
        totalTxt.Text = CInt(volTxt.Text) * CInt(hargaTxt.Text)
    End Sub

    Private Sub volTxt_TextChanged_1(sender As Object, e As EventArgs) Handles volTxt.KeyPress
        numberOnly(e)
    End Sub

    Private Sub hargaTxt_TextChanged_1(sender As Object, e As EventArgs) Handles hargaTxt.KeyPress
        numberOnly(e)
    End Sub


End Class