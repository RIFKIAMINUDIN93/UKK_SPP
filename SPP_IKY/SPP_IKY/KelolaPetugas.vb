Imports System.Data.SqlClient

Public Class KelolaPetugas
    Sub aturdgv()
        sql = "SELECT * FROM petugas"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "petugas")
        dgv_user.DataSource = ds.Tables("petugas")
    End Sub

    Sub kosong()
        txtidpeg.Text = ""
        txtus.Text = ""
        txtpass.Text = ""
        txtnampeg.Text = ""
        txtcari.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        connect()
        If txtidpeg.Text = "" Or txtus.Text = "" Or txtpass.Text = "" Or txtnampeg.Text = "" Or cblevel.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = "Insert into petugas(id_petugas, username, password, nama_petugas, level) VALUES ('" & txtidpeg.Text & "', '" & txtus.Text & "', '" & txtpass.Text & "', '" & txtnampeg.Text & "', '" & cblevel.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Tambah Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connect()
        If txtidpeg.Text = "" Or txtus.Text = "" Or txtpass.Text = "" Or txtnampeg.Text = "" Or cblevel.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = "UPDATE petugas set username='" & txtus.Text & "', password='" & txtpass.Text & "', nama_petugas='" & txtnampeg.Text & "', level='" & cblevel.Text & "' WHERE id_petugas='" & txtidpeg.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Edit Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        connect()
        If txtidpeg.Text = "" Or txtus.Text = "" Or txtpass.Text = "" Or txtnampeg.Text = "" Or cblevel.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = " DELETE FROM petugas WHERE id_petugas='" & txtidpeg.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Hapus Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub dgv_user_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_user.MouseClick
        txtidpeg.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(0).Value
        txtus.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(1).Value
        txtpass.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(2).Value
        txtnampeg.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(3).Value
        cblevel.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(4).Value
    End Sub

    Private Sub KelolaPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub


    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        sql = "SELECT * From petugas Where (nama_petugas like '%" & txtcari.Text & "%')"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "petugas")
        dgv_user.DataSource = ds.Tables("petugas")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class