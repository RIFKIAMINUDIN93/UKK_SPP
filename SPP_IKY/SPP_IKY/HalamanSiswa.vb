﻿Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class HalamanSiswa
    Dim WithEvents PD As New PrintDocument
    Dim PDD As New PrintPreviewDialog

    Sub aturdgv()
        sql = "SELECT tgl_bayar, bulan_dibayar, jumlah_bayar FROM pembayaran"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        dgv_user.DataSource = ds.Tables("pembayaran")
    End Sub
    Private Sub Siswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sql = "SELECT id_pembayaran, tgl_bayar, jumlah_bayar from pembayaran WHERE tgl_bayar between '" & dtdari.Value.Date.ToString("MM/dd/yyyy") & "'and'" & dtsampai.Value.Date.ToString("MM/dd/yyyy") & "'"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        dgv_user.DataSource = ds.Tables("pembayaran")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
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
        e.Graphics.DrawString("tanggal_bayar", f10, Brushes.Black, 100, 95)
        e.Graphics.DrawString("bulan_dibayar", f10, Brushes.Black, 0, 95)
        e.Graphics.DrawString("harga", f10, Brushes.Black, 250, 95)
        dgv_user.AllowUserToAddRows = False

        Dim tinggi As Integer
        For baris As Integer = 0 To dgv_user.RowCount - 1
            tinggi += 15
            e.Graphics.DrawString(dgv_user.Rows(baris).Cells(0).Value.ToString, f10, Brushes.Black, 100, 100 + tinggi)
            e.Graphics.DrawString(dgv_user.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 0, 100 + tinggi)
            e.Graphics.DrawString(dgv_user.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, 250, 100 + tinggi)

        Next
        tinggi = 110 + tinggi
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 400)
        e.Graphics.DrawString("Hatur Thank You !!!!!", f10, Brushes.Black, centermargin, 450, tengah)
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

End Class