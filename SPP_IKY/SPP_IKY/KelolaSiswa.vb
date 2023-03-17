Imports System.Data.SqlClient

Public Class KelolaSiswa
    Private Sub KelolaSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub
    Sub aturdgv()
        sql = "SELECT * FROM siswa"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "siswa")
        dgv_user.DataSource = ds.Tables("siswa")
    End Sub

    Sub kosong()
        txtnisn.Text = ""
        txtnis.Text = ""
        txtnamsis.Text = ""
        cmbidkel.Text = ""
        txtalam.Text = ""
        txtnotlp.Text = ""
        cmbidspp.Text = ""
        txtcari.Text = ""
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connect()
        If txtnisn.Text = "" Or txtnis.Text = "" Or txtnamsis.Text = "" Or cmbidkel.Text = "" Or txtalam.Text = "" Or txtnotlp.Text = "" Or cmbidspp.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = "Insert into siswa(nisn, nis, nama, id_kelas, alamat, no_telp, id_spp) VALUES ('" & txtnisn.Text & "', '" & txtnis.Text & "', '" & txtnamsis.Text & "', '" & cmbidkel.Text & "', '" & txtalam.Text & "' , '" & txtnotlp.Text & "', '" & cmbidspp.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Tambah Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        connect()
        If txtnisn.Text = "" Or txtnis.Text = "" Or txtnamsis.Text = "" Or cmbidkel.Text = "" Or txtalam.Text = "" Or txtnotlp.Text = "" Or cmbidspp.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = "UPDATE siswa set nis='" & txtnis.Text & "', nama='" & txtnamsis.Text & "', id_kelas='" & cmbidkel.Text & "', alamat='" & txtalam.Text & "' , no_telp='" & txtnotlp.Text & "', id_spp='" & cmbidspp.Text & "' WHERE nisn='" & txtnisn.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Edit Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        connect()
        If txtnisn.Text = "" Or txtnis.Text = "" Or txtnamsis.Text = "" Or cmbidkel.Text = "" Or txtalam.Text = "" Or txtnotlp.Text = "" Or cmbidspp.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = " DELETE FROM siswa WHERE nisn='" & txtnisn.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Hapus Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub dgv_user_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_user.MouseClick
        txtnisn.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(0).Value
        txtnis.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(1).Value
        txtnamsis.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(2).Value
        cmbidkel.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(3).Value
        txtalam.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(4).Value
        txtnotlp.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(5).Value
        cmbidspp.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(6).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin.Show()
        Me.Hide()
    End Sub
    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        sql = "SELECT * From siswa Where (nama like '%" & txtcari.Text & "%')"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "siswa")
        dgv_user.DataSource = ds.Tables("siswa")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class