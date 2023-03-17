Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class KelolaKelas

    Private Sub KelolaKelas(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub
    Sub aturdgv()
        sql = "SELECT * FROM kelas"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "kelas")
        dgv_user.DataSource = ds.Tables("kelas")
    End Sub

    Sub kosong()
        txtidkel.Text = ""
        txtnamkel.Text = ""
        txtkompetensi.Text = ""
        txtcari.Text = ""
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connect()
        If txtidkel.Text = "" Or txtnamkel.Text = "" Or txtkompetensi.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = "Insert into kelas(id_kelas, nama_kelas, kompetensi_keahlian) VALUES ('" & txtidkel.Text & "', '" & txtnamkel.Text & "', '" & txtkompetensi.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Tambah Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        connect()
        If txtidkel.Text = "" Or txtnamkel.Text = "" Or txtkompetensi.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = "UPDATE kelas set nama_kelas='" & txtnamkel.Text & "', kompetensi_keahlian='" & txtkompetensi.Text & "' WHERE id_kelas='" & txtidkel.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Edit Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        connect()
        If txtidkel.Text = "" Or txtnamkel.Text = "" Or txtkompetensi.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = " DELETE FROM kelas WHERE id_kelas='" & txtidkel.Text & "'"
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
        txtidkel.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(0).Value
        txtnamkel.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(1).Value
        txtkompetensi.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(2).Value
    End Sub

    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        sql = "SELECT * From kelas Where (nama_kelas like '%" & txtcari.Text & "%')"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "kelas")
        dgv_user.DataSource = ds.Tables("kelas")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub KelolaKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class