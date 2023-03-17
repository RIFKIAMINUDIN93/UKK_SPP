Imports System.Data.SqlClient

Public Class HistoriPembayaran
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        KelolaTransaksiPetugas.Show()
        Me.Hide()
    End Sub

    Private Sub HistoriPembayaran(sender As Object, e As EventArgs) Handles Button5.Click
        sql = "SELECT * from pembayaran WHERE tgl_bayar='" & dtdari.Value.Date.ToString("MM/dd/yyyy") & "'"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        dgvadmin.DataSource = ds.Tables("pembayaran")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Sub aturdgv()
        sql = "SELECT * FROM pembayaran"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        dgvadmin.DataSource = ds.Tables("pembayaran")
    End Sub
    Private Sub Petugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sql = "SELECT * from pembayaran WHERE tgl_bayar='" & dtdari.Value.Date.ToString("MM/dd/yyyy") & "'"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        dgvadmin.DataSource = ds.Tables("pembayaran")
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class