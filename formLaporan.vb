Imports Microsoft.Reporting
Imports Microsoft.Reporting.WinForms

Public Class formLaporan

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Try
            Me.ReportViewer1.Clear()
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
            With Me.ReportViewer1.LocalReport
                .DataSources.Clear()
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("barangMasuk", dt))
                .ReportEmbeddedResource = "stokBarang.LaporanBarangMasuk.rdlc"
                .SetParameters(New ReportParameter() {Param1})
            End With
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.ReportViewer1.Clear()
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
            Dim cmd As New OleDb.OleDbCommand("SELECT * FROM data_barang order by id_barang", Conn)
            Dim Param1 As New ReportParameter
            Param1.Name = "masukParam"
            Param1.Values.Add("")
            cmd.CommandTimeout = 4096
            Dim ta As New OleDb.OleDbDataAdapter(cmd)
            ta.Fill(dt)
            With Me.ReportViewer1.LocalReport
                .DataSources.Clear()
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("ATKornelius", dt))
                .ReportEmbeddedResource = "stokBarang.LaporanAlat.rdlc"
                .SetParameters(New ReportParameter() {Param1})
            End With
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.ReportViewer1.Clear()
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
            With Me.ReportViewer1.LocalReport
                .DataSources.Clear()
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("ATKKornelius", dt))
                .ReportEmbeddedResource = "stokBarang.reportBarangKeluar.rdlc"
                .SetParameters(New ReportParameter() {Param1})
            End With
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub formLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Januari"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportEmbeddedResource = "stokBarang.reportBarangKeluar.rdlc"
        End With
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class