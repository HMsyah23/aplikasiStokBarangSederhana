Public Class formAlat

    Sub kosongkan()
        TextBox1.Enabled = False
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        cariTxt.Text = ""
        TextBox6.Text = ""
        loadDataCombobox("select * from data_barang order by id_barang asc", TextBox6, "satuan")
        TextBox2.Focus()
        TampilGrid()
    End Sub

    Sub Ketemu()
        On Error Resume Next
        TextBox1.Text = rd.Item(0)
        TextBox2.Text = rd.Item(1)
        TextBox3.Text = rd.Item(2)
        TextBox4.Text = rd.Item(3)
        TextBox6.Text = rd.Item(4)
        TextBox2.Focus()
    End Sub

    Sub TampilGrid()
        queryDGV("select * from data_barang order by id_barang asc", DGV)
        With DGV
            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "Nama Barang"
            .Columns(2).HeaderText = "Spesifikasi"
            .Columns(3).HeaderText = "Merk"
            .Columns(4).HeaderText = "Satuan"
            .Columns(5).HeaderText = "Stok"
            .Columns(0).Width = 90
            .Columns(1).Width = 300
            .Columns(2).Width = 150
            .Columns(3).Width = 120
            .Columns(4).Width = 70
            .Columns(5).Width = 90
        End With
    End Sub

    Sub KodeOtomatis()
        kosongkan()
        CariKode("select id_barang from data_barang order by id_barang desc")
        If Not rd.HasRows Then
            TextBox1.Text = "ATK001"
        Else
            TextBox1.Text = "ATK" + Format(Microsoft.VisualBasic.Right(rd.Item("id_barang"), 3) + 1, "000")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Try
            CariKode("select * from data_barang where id_barang='" & TextBox1.Text & "'")
            If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Or (TextBox6.Text = "") Then
                MsgBox("Isi Semua Kolom Terlebih Dahulu")
            Else
                If Not rd.HasRows Then
                    queryData("insert into data_barang values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox6.Text & "',0)")
                    MsgBox("Data Berhasil Ditambah")
                Else
                    If MessageBox.Show("Perbarui Data ...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        queryData("update data_barang set nama_barang='" & TextBox2.Text & "',spesifikasi='" & TextBox3.Text & "',merk='" & TextBox4.Text & "',satuan='" & TextBox6.Text & "' where id_barang='" & TextBox1.Text & "'")
                        MsgBox("Data Berhasil Diperbarui")
                    Else
                        MsgBox("Pembaruan Data Ditangguhkan oleh pengguna")
                    End If
                End If
                TampilGrid()
                kosongkan()
                KodeOtomatis()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        TextBox2.Focus()
        CariKode("select * from data_barang where id_barang='" & TextBox1.Text & "'")
        If Not rd.HasRows Then
            MsgBox("Kode tidak terdaftar")
            TextBox2.Focus()
        Else
            If MessageBox.Show("Yakin akan dihapus...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                queryData("DELETE * FROM data_barang WHERE id_barang='" & TextBox1.Text & "'")
                kosongkan()
                TampilGrid()
                KodeOtomatis()
            Else
                kosongkan()
                KodeOtomatis()
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        kosongkan()
        KodeOtomatis()
    End Sub

    Private Sub formAlat_Load(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If (MyBase.Visible = True) Then
            Koneksi()
            KodeOtomatis()
            TampilGrid()
        End If
    End Sub

    Private Sub cariTxt_TextChanged(sender As Object, e As EventArgs) Handles cariTxt.TextChanged
        FilterData("SELECT * FROM data_barang WHERE id_barang & stok & nama_barang & spesifikasi & merk & satuan LIKE '%" & cariTxt.Text & "%' order by id_barang", "data_barang", DGV)
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        cariTxt.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        CariKode("select * from data_barang where id_barang='" & cariTxt.Text & "'")
        If rd.HasRows Then
            Ketemu()
        End If
    End Sub

End Class