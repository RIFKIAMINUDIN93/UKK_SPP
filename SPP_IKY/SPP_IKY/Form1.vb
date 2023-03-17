Imports System.Data.SqlClient
Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connect()
        If txtusnm.Text = "" And txtpass.Text = "" Then
            MsgBox("Pastikan Mengisi Semua Field")
        Else
            Sql = "SELECT id_petugas, username, password, level FROM petugas WHERE username='" & Trim(txtusnm.Text) & "' and password='" & Trim(txtpass.Text) & "'"
            cmd = New SqlCommand(Sql, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If rd.Item("level").Equals("Admin") Then
                    Admin.Show()
                    Me.Hide()
                ElseIf rd.Item("level").Equals("Petugas") Then
                    HistoriPembayaran.Show()
                    Me.Hide()
                ElseIf rd.Item("level").Equals("Siswa") Then
                    HalamanSiswa.Show()
                    Me.Hide()
                Else
                    MsgBox("Username atau password yang anda masukan tidak sesuai")
                    rd.Close()
                End If
            Else
                MsgBox("Username atau password yang anda masukan tidak sesuai")
                rd.Close()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtusnm.Text = ""
        txtpass.Text = ""
        MsgBox("Username dan password anda belum terisi")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()

    End Sub
End Class
