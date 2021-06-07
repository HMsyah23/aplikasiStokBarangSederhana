Public Class formPengguna

    Sub kosongkan()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        cariTxt.Text = ""
        TextBox2.Focus()
        TampilGrid()
    End Sub

    Sub Ketemu()
        On Error Resume Next
        TextBox1.Text = rd.Item(0)
        TextBox2.Text = rd.Item(1)
        TextBox4.Text = rd.Item(2)
        TextBox3.Text = rd.Item(5)
        If rd.Item(3) = "L" Then
            ComboBox1.SelectedIndex = 0
        Else
            ComboBox1.SelectedIndex = 1
        End If
        If rd.Item(4) = "ISLAM" Then
            TextBox6.SelectedIndex = 0
        ElseIf rd.Item(4) = "KATOLIK" Then
            TextBox6.SelectedIndex = 1
        ElseIf rd.Item(4) = "PROTESTAN" Then
            TextBox6.SelectedIndex = 2
        ElseIf rd.Item(4) = "HINDU" Then
            TextBox6.SelectedIndex = 3
        ElseIf rd.Item(4) = "BUDDHA" Then
            TextBox6.SelectedIndex = 4
        ElseIf rd.Item(4) = "KONG HU CU" Then
            TextBox6.SelectedIndex = 5
        End If
        TextBox2.Focus()
    End Sub
    Dim jenis_kelamin As String
    Sub gantikode()
        If ComboBox1.Text = "Laki - Laki" Then
            jenis_kelamin = "L"
        Else
            jenis_kelamin = "P"
        End If
    End Sub

    Sub TampilGrid()
        queryDGV("select * from karyawan order by NIK asc", DGV)
        With DGV
            .Columns(0).HeaderText = "NIK"
            .Columns(1).HeaderText = "NIP"
            .Columns(2).HeaderText = "Nama Karyawan"
            .Columns(3).HeaderText = "Jenis Kelamin"
            .Columns(4).HeaderText = "Agama"
            .Columns(5).HeaderText = "Jabatan"
            .Columns(0).Width = 90
            .Columns(1).Width = 230
            .Columns(2).Width = 200
            .Columns(3).Width = 120
            .Columns(4).Width = 120
            .Columns(5).Width = 120
        End With
    End Sub



    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Try
            CariKode("select * from karyawan where NIK='" & TextBox1.Text & "'")
            gantikode()
            If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Or (TextBox6.Text = "") Then
                MsgBox("Isi Semua Kolom Terlebih Dahulu")
            Else
                If Not rd.HasRows Then
                    queryData("insert into karyawan values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox4.Text & "','" & jenis_kelamin & "','" & TextBox6.Text & "','" & TextBox3.Text & "')")
                    MsgBox("Data Berhasil Ditambah")
                Else
                    queryData("update karyawan set NIP='" & TextBox2.Text & "',nama_karyawan='" & TextBox4.Text & "', jenis_kelamin='" & jenis_kelamin & "',agama='" & TextBox6.Text & "',jabatan='" & TextBox3.Text & "' where NIK='" & TextBox1.Text & "'")
                    MsgBox("Data Berhasil Diperbarui")
                End If
                TampilGrid()
                kosongkan()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        TextBox2.Focus()
        CariKode("select * from karyawan where NIK='" & TextBox1.Text & "'")
        If Not rd.HasRows Then
            MsgBox("Kode tidak terdaftar")
            TextBox2.Focus()
        Else
            If MessageBox.Show("Yakin akan dihapus...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                queryData("DELETE * FROM karyawan WHERE NIK='" & TextBox1.Text & "'")
                kosongkan()
                TampilGrid()
            Else
                kosongkan()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kosongkan()
    End Sub

    Private Sub formPengguna_Load(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If (MyBase.Visible = True) Then
            Koneksi()
            TampilGrid()
        End If
    End Sub

    Private Sub cariTxt_TextChanged(sender As Object, e As EventArgs) Handles cariTxt.TextChanged
        FilterData("SELECT * FROM karyawan WHERE NIK & NIP & nama_karyawan & jenis_kelamin & agama & jabatan LIKE '%" & cariTxt.Text & "%' order by NIK", "karyawan", DGV)
    End Sub

    Private Sub DGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        If Not IsDBNull(DGV.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
            If DGV.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "L" Then
                DGV.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "Laki - Laki"
            End If
            If DGV.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "P" Then
                DGV.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "Perempuan"
            End If
        End If
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        cariTxt.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        CariKode("select * from karyawan where NIK='" & cariTxt.Text & "'")
        If rd.HasRows Then
            Ketemu()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.KeyPress
        numberOnly(e)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.KeyPress
        numberOnly(e)
    End Sub
End Class