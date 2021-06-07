Imports System.Data.OleDb
Module DBkoneksi
    Public str As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\DCS\aplikasiATKKornelius\stokBarangDB.mdb"
    Public Conn As New OleDbConnection(str)
    Public da As OleDbDataAdapter
    Public ds As New DataSet
    Public dt As DataTable
    Public cmd As OleDbCommand
    Public rd As OleDbDataReader
    Public s As String

    Public Sub Koneksi()
        Try
            Conn.Close()
            Conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub CariKode(kode As String)
        cmd = New OleDbCommand(kode, Conn)
        rd = cmd.ExecuteReader
        rd.Read()
    End Sub

    Sub queryData(query As String)
        Dim simpan As String = query
        cmd = New OleDbCommand(simpan, Conn)
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub queryDGV(query As String, DGV As DataGridView)
        da = New OleDbDataAdapter(query, Conn)
        ds = New DataSet
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
    End Sub

    Public Sub numberOnly(e)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Sub FilterData(valueToSearch As String, namaTabel As String, dgv As DataGridView)
        Call Koneksi()
        da = New OleDbDataAdapter(valueToSearch, Conn)
        Dim ss As New DataSet
        da.Fill(ss, namaTabel)
        dgv.DataSource = ss.Tables(namaTabel)
    End Sub

    Sub cariIdAnggota(valueToSearch As String, namaTabel As String, dgv As DataGridView)
        Call Koneksi()
        da = New OleDbDataAdapter(valueToSearch, Conn)
    End Sub

    Sub getDataComboBox(txt As ComboBox, tabel As String, kolom As String)
        Koneksi()
        Try
            da = New OleDbDataAdapter("SELECT DISTINCT " & kolom & " FROM " & tabel & "", Conn)
            dt = New DataTable
            da.Fill(dt)
            txt.DataSource = dt
            txt.DisplayMember = tabel
            txt.ValueMember = kolom
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub getData(ByVal dataCollection As AutoCompleteStringCollection, tabel As String, kolom As String)
        Koneksi()
        Dim ds As New DataSet()
        Try
            cmd = New OleDbCommand("SELECT DISTINCT " & kolom & " FROM " & tabel & "", Conn)
            da.SelectCommand = cmd
            da.Fill(ds)
            da.Dispose()
            cmd.Dispose()
            For Each row As DataRow In ds.Tables(0).Rows
                dataCollection.Add(row(kolom).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub

    Public Sub getAutoCompleteData(textb As TextBox, tabel As String, kolom As String)
        textb.AutoCompleteMode = AutoCompleteMode.Suggest
        textb.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim DataCollection As New AutoCompleteStringCollection()
        getData(DataCollection, tabel, kolom)
        textb.AutoCompleteCustomSource = DataCollection
    End Sub

    Public Sub loadDataCombobox(query As String, cmb As ComboBox, kolom As String)
        Call koneksi()
        Try
            cmd = New OleDbCommand(query, Conn)
            Rd = cmd.ExecuteReader
            If Rd.HasRows = True Then
                cmb.Items.Clear()
                While Rd.Read()
                    cmb.Items.Add(Rd(kolom))
                End While
            End If
            Rd.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Module
