Imports System.Data.OleDb
Public Class Form19

    Private Sub Form19_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("Jenis Surat", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Perihal", 150, HorizontalAlignment.Center)
        ListView1.Columns.Add("Keterangan", 200, HorizontalAlignment.Center)
        ListView1.Columns.Add("Penerima Surat", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Tanggal Surat", 90, HorizontalAlignment.Center)
        ListView1.Columns.Add("No Surat", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("Tanggal Acara", 90, HorizontalAlignment.Center)

    End Sub

    Private Sub Btnsubmit_Click(sender As System.Object, e As System.EventArgs) Handles Btnsubmit.Click
        Dim newitem As New ListViewItem(Cbjenis.Text)
        newitem.SubItems.Add(Txtperihal.Text)
        newitem.SubItems.Add(Txtketerangan.Text)
        newitem.SubItems.Add(Txtpenerima.Text)
        newitem.SubItems.Add(Txttanggalsurat.Text)
        newitem.SubItems.Add(Txtno.Text)
        newitem.SubItems.Add(Txtacara.Text)

        ListView1.Items.Add(newitem)

        For Each item As ListViewItem In ListView1.Items

            Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_reglogin.accdb")
            Dim cmd As New OleDbCommand("Insert into tbl_catatan values(@JenisSurat, @Perihal, @Keterangan, @Penerima, @TanggalSurat, @NoSurat, @TanggalAcara)", conn)
            cmd.Parameters.AddWithValue("@JenisSurat", item.SubItems(0).Text)
            cmd.Parameters.AddWithValue("@Perihal", item.SubItems(1).Text)
            cmd.Parameters.AddWithValue("@Keterangan", item.SubItems(2).Text)
            cmd.Parameters.AddWithValue("@Penerima", item.SubItems(3).Text)
            cmd.Parameters.AddWithValue("@TanggalSurat", item.SubItems(4).Text)
            cmd.Parameters.AddWithValue("@NoSurat", item.SubItems(5).Text)
            cmd.Parameters.AddWithValue("@TanggalAcara", item.SubItems(6).Text)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

        Next
        MessageBox.Show("All items inserted successfully")
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Cbjenis.Text = ListView1.SelectedItems(0).SubItems(0).Text
            Txtperihal.Text = ListView1.SelectedItems(0).SubItems(1).Text
            Txtketerangan.Text = ListView1.SelectedItems(0).SubItems(2).Text
            Txtpenerima.Text = ListView1.SelectedItems(0).SubItems(3).Text
            Txttanggalsurat.Text = ListView1.SelectedItems(0).SubItems(4).Text
            Txtno.Text = ListView1.SelectedItems(0).SubItems(5).Text
            Txtacara.Text = ListView1.SelectedItems(0).SubItems(6).Text
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Cbjenis.Text = " "
        Txtperihal.Text = " "
        Txtketerangan.Text = " "
        Txtpenerima.Text = " "
        Txttanggalsurat.Text = " "
        Txtno.Text = " "
        Txtacara.Text = " "

        Cbjenis.Focus()
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        For Each item As ListViewItem In ListView1.Items

            Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_reglogin.accdb")
            Dim cmd As New OleDbCommand("Insert into tbl_catatan values(@JenisSurat, @Perihal, @Keterangan, @Penerima, @TanggalSurat, @NoSurat, @TanggalAcara)", conn)
            cmd.Parameters.AddWithValue("@JenisSurat", item.SubItems(0).Text)
            cmd.Parameters.AddWithValue("@Perihal", item.SubItems(1).Text)
            cmd.Parameters.AddWithValue("@Keterangan", item.SubItems(2).Text)
            cmd.Parameters.AddWithValue("@Penerima", item.SubItems(3).Text)
            cmd.Parameters.AddWithValue("@TanggalSurat", item.SubItems(4).Text)
            cmd.Parameters.AddWithValue("@NoSurat", item.SubItems(5).Text)
            cmd.Parameters.AddWithValue("@TanggalAcara", item.SubItems(6).Text)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

        Next
        MessageBox.Show("All items inserted successfully")
    End Sub

    Private Sub BtnKeluar_Click(sender As System.Object, e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Btnmenu_Click(sender As System.Object, e As System.EventArgs) Handles Btnmenu.Click
        Me.Close()
        Form3.Show()
    End Sub
End Class