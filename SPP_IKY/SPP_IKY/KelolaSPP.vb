Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class KelolaSPP

    Private Sub KelolaSpp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub
    Sub aturdgv()
        sql = "SELECT * FROM spp"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "spp")
        dgv_user.DataSource = ds.Tables("spp")
    End Sub

    Sub kosong()
        txtid.Text = ""
        txtthn.Text = ""
        txtnomi.Text = ""
        txtcari.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connect()
        If txtid.Text = "" Or txtthn.Text = "" Or txtnomi.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = "Insert into spp(id_spp, tahun, nominal) VALUES ('" & txtid.Text & "', '" & txtthn.Text & "', '" & txtnomi.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Tambah Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        connect()
        If txtid.Text = "" Or txtthn.Text = "" Or txtnomi.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = "UPDATE spp set tahun='" & txtthn.Text & "', nominal='" & txtnomi.Text & "' WHERE id_spp='" & txtid.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Edit Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        connect()
        If txtid.Text = "" Or txtthn.Text = "" Or txtnomi.Text = "" Then
            MsgBox("Pastikan mengisi semua field")

        Else
            sql = " DELETE FROM spp WHERE id_spp='" & txtid.Text & "'"
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
        txtid.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(0).Value
        txtthn.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(1).Value
        txtnomi.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(2).Value
    End Sub

    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        sql = "SELECT * From spp Where (tahun like '%" & txtcari.Text & "%')"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "spp")
        dgv_user.DataSource = ds.Tables("spp")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class