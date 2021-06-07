Imports System.Data.OleDb
Imports Microsoft.Reporting
Imports Microsoft.Reporting.WinForms

Public Class formUtama
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Public Sub tombolMati(tombol As Boolean)
        Button1.Enabled = tombol
        Button2.Enabled = tombol
        Button3.Enabled = tombol
        Button4.Enabled = tombol
        Button6.Enabled = tombol
        Button13.Enabled = tombol
    End Sub

    Public Sub hideAllForm()
        formLaporan.Hide()
        formAlat.Hide()
        formPengguna.Hide()
        formBarangMasuk.Hide()
        formBarangKeluar.Hide()
        Panel3.Hide()
    End Sub

    Public Sub closeAllForm(bukaForm As Form)
        hideAllForm()
        bukaForm.MdiParent = Me
        bukaForm.Dock = DockStyle.Fill
        bukaForm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ((txt_password.Text = "admin123") And (txt_username.Text = "admin")) Then
            tombolMati(True)
            Panel4.Hide()
            Label7.Show()
            Panel5.Show()
            MessageBox.Show("Akun Valid, Selamat Datang", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            id_Admin.Text = "Admin"
        Else
            MessageBox.Show("Login gagal, username atau Password salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_password.Text = ""
            txt_username.Text = ""
            txt_username.Focus()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        closeAllForm(formLaporan)
    End Sub

    Private Sub formUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsMdiContainer = True
        tombolMati(False)
        ComboBox1.Text = "Januari"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        closeAllForm(formAlat)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        tombolMati(False)
        hideAllForm()
        Panel3.Show()
        Panel4.Show()
        Label7.Hide()
        Panel5.Hide()
        txt_username.Text = ""
        txt_password.Text = ""
        id_Admin.Text = "@user"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            txt_password.UseSystemPasswordChar = False
        Else
            txt_password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        closeAllForm(formPengguna)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        closeAllForm(formBarangMasuk)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        closeAllForm(formBarangKeluar)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        closeAllForm(formLaporan)
        Try
            formLaporan.ReportViewer1.Clear()
            Dim dt As New DataTable
            Koneksi()
            Dim x As String = ComboBox1.Text

            If x = "Januari" Then
                s = 1
            ElseIf x = "Februari" Then
                s = 2
            ElseIf x = "Maret" Then
                s = 3
            ElseIf x = "April" Then
                s = 4
            ElseIf x = "Mei" Then
                s = 5
            ElseIf x = "Juni" Then
                s = 6
            ElseIf x = "Juli" Then
                s = 7
            ElseIf x = "Agustus" Then
                s = 8
            ElseIf x = "September" Then
                s = 9
            ElseIf x = "Oktober" Then
                s = 10
            ElseIf x = "November" Then
                s = 11
            ElseIf x = "Desember" Then
                s = 12
            End If
            Dim cmd As New OleDb.OleDbCommand("SELECT barang_keluar.NIK, karyawan.nama_karyawan, data_barang.nama_barang, data_barang.spesifikasi, data_barang.Merk, barang_keluar.tanggal_keluar, barang_keluar.vol, barang_keluar.id_barang_keluar FROM ((barang_keluar INNER JOIN data_barang ON barang_keluar.id_barang = data_barang.id_barang) INNER JOIN karyawan ON barang_keluar.NIK = karyawan.NIK)  where month(barang_keluar.tanggal_keluar) = " & s & " ", Conn)
            Dim Param1 As New ReportParameter
            Param1.Name = "masukParam"
            Param1.Values.Add("Laporan per Bulan : " & ComboBox1.Text & "")
            cmd.CommandTimeout = 4096
            Dim ta As New OleDb.OleDbDataAdapter(cmd)
            ta.Fill(dt)
            With formLaporan.ReportViewer1.LocalReport
                .DataSources.Clear()
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("ATKKornelius", dt))
                .ReportEmbeddedResource = "stokBarang.reportBarangKeluar.rdlc"
                .SetParameters(New ReportParameter() {Param1})
            End With
            formLaporan.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        closeAllForm(formLaporan)
        Try
            formLaporan.ReportViewer1.Clear()
            Dim dt As New DataTable
            Koneksi()
            Dim x As String = ComboBox1.Text

            If x = "Januari" Then
                s = 1
            ElseIf x = "Februari" Then
                s = 2
            ElseIf x = "Maret" Then
                s = 3
            ElseIf x = "April" Then
                s = 4
            ElseIf x = "Mei" Then
                s = 5
            ElseIf x = "Juni" Then
                s = 6
            ElseIf x = "Juli" Then
                s = 7
            ElseIf x = "Agustus" Then
                s = 8
            ElseIf x = "September" Then
                s = 9
            ElseIf x = "Oktober" Then
                s = 10
            ElseIf x = "November" Then
                s = 11
            ElseIf x = "Desember" Then
                s = 12
            End If
            Dim cmd As New OleDb.OleDbCommand("SELECT barang_masuk.id_barang_masuk, barang_masuk.id_barang, data_barang.nama_barang, data_barang.spesifikasi, data_barang.merk, barang_masuk.tanggal_masuk, barang_masuk.vol, barang_masuk.harga_satuan, barang_masuk.jumlah FROM data_barang INNER JOIN barang_masuk ON data_barang.id_barang = barang_masuk.id_barang Where Month(barang_masuk.tanggal_masuk) = " & s & " ", Conn)
            Dim Param1 As New ReportParameter
            Param1.Name = "masukParam"
            Param1.Values.Add("Laporan Per Bulan : " & ComboBox1.Text & "")
            cmd.CommandTimeout = 4096
            Dim ta As New OleDb.OleDbDataAdapter(cmd)
            ta.Fill(dt)
            With formLaporan.ReportViewer1.LocalReport
                .DataSources.Clear()
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("barangMasuk", dt))
                .ReportEmbeddedResource = "stokBarang.LaporanBarangMasuk.rdlc"
                .SetParameters(New ReportParameter() {Param1})
            End With
            formLaporan.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class