Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class KelolaTransaksiPetugas
    Dim WithEvents PD As New PrintDocument
    Dim PDD As New PrintPreviewDialog

    Sub aturdgv()
        sql = "SELECT * FROM pembayaran"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        dgv_user.DataSource = ds.Tables("pembayaran")
    End Sub

    Sub kosong()
        txtidpem.Text = ""
        txtidpet.Text = ""
        txtnisn.Text = ""
        txtbln.Text = ""
        txtthn.Text = ""
        cmbidspp.Text = ""
        txtjml.Text = ""
    End Sub
    Private Sub KelolaTransaksiPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connect()
        If txtidpem.Text = "" Or txtidpet.Text = "" Or txtnisn.Text = "" Or txtbln.Text = "" Or txtthn.Text = "" Or cmbidspp.Text = "" Or txtjml.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = "Insert into pembayaran(id_pembayaran, id_petugas, nisn, tgl_bayar, bulan_dibayar, tahun_dibayar, id_spp, jumlah_bayar) VALUES ('" & txtidpem.Text & "', '" & txtidpet.Text & "', '" & txtnisn.Text & "', '" & Format(Dttglbayar.Value, "yyyy-MM-dd") & "', '" & txtbln.Text & "' , '" & txtthn.Text & "', '" & cmbidspp.Text & "' , '" & txtjml.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Tambah Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        connect()
        If txtidpem.Text = "" Or txtidpet.Text = "" Or txtnisn.Text = "" Or txtbln.Text = "" Or txtthn.Text = "" Or cmbidspp.Text = "" Or txtjml.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = "UPDATE pembayaran set id_petugas='" & txtidpet.Text & "', nisn='" & txtnisn.Text & "', tgl_bayar='" & Format(Dttglbayar.Value, "yyyy-MM-dd") & "', bulan_dibayar='" & txtbln.Text & "' , tahun_dibayar='" & txtthn.Text & "', id_spp='" & cmbidspp.Text & "' , jumlah_bayar='" & cmbidspp.Text & "' WHERE id_pembayaran='" & txtidpem.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Edit Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        connect()
        If txtidpem.Text = "" Or txtidpet.Text = "" Or txtnisn.Text = "" Or txtbln.Text = "" Or txtthn.Text = "" Or cmbidspp.Text = "" Or txtjml.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = " DELETE FROM pembayaran WHERE id_pembayaran='" & txtidpem.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Hapus Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HistoriPembayaran.Show()
        Me.Hide()
    End Sub

    Private Sub dgv_user_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_user.MouseClick
        txtidpem.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(0).Value
        txtidpet.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(1).Value
        txtnisn.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(2).Value
        Dttglbayar.Value = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(3).Value
        txtbln.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(4).Value
        txtthn.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(5).Value
        cmbidspp.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(6).Value
        txtjml.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(7).Value
    End Sub
    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        sql = "SELECT * From pembayaran Where (id_pembayaran like '%" & txtcari.Text & "%')"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "kelas")
        dgv_user.DataSource = ds.Tables("kelas")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'printPD()
        PDD.Document = PD
        PDD.ShowDialog()
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "--------------------------------------------------------------------------------------"

        e.Graphics.DrawString("SPP SMK Negeri 2 Kuningan", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("Jl.Sukamulya No.77", f10, Brushes.Black, centermargin, 25, tengah)
        e.Graphics.DrawString("No Tlp: 0812", f10, Brushes.Black, centermargin, 40, tengah)

        e.Graphics.DrawString("Petugas", f10, Brushes.Black, 0, 65)
        e.Graphics.DrawString(":", f10, Brushes.Black, 60, 65)
        e.Graphics.DrawString("Rifki", f10, Brushes.Black, 80, 65)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 80)
        e.Graphics.DrawString("id bayar", f10, Brushes.Black, 0, 95)
        e.Graphics.DrawString("id petugas", f10, Brushes.Black, 60, 95)
        e.Graphics.DrawString("nisn", f10, Brushes.Black, 125, 95)
        e.Graphics.DrawString("harga", f10, Brushes.Black, 160, 95)
        e.Graphics.DrawString("tanggal bayar", f10, Brushes.Black, 220, 95)
        dgv_user.AllowUserToAddRows = False

        Dim tinggi As Integer
        For baris As Integer = 0 To dgv_user.RowCount - 1
            tinggi += 15
            e.Graphics.DrawString(dgv_user.Rows(baris).Cells(0).Value.ToString, f10, Brushes.Black, 0, 100 + tinggi)
            e.Graphics.DrawString(dgv_user.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 60, 100 + tinggi)
            e.Graphics.DrawString(dgv_user.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, 125, 100 + tinggi)
            e.Graphics.DrawString(dgv_user.Rows(baris).Cells(7).Value.ToString, f10, Brushes.Black, 160, 100 + tinggi)
            e.Graphics.DrawString(dgv_user.Rows(baris).Cells(3).Value.ToString, f10, Brushes.Black, 220, 100 + tinggi)


        Next
        tinggi = 110 + tinggi
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 400)
        e.Graphics.DrawString("Terimakasih !!!!!", f10, Brushes.Black, centermargin, 450, tengah)
    End Sub

    Sub printPD()
        PrintDocument1.PrinterSettings.PrinterName = "Microsoft Print to PDF"
        PrintDocument1.Print()
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 350, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form1.Show()
        Me.Hide()
    End Sub

End Class