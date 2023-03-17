<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KelolaTransaksiPetugas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtjml = New System.Windows.Forms.TextBox()
        Me.txtidpet = New System.Windows.Forms.ComboBox()
        Me.txtnisn = New System.Windows.Forms.ComboBox()
        Me.Dttglbayar = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.dgv_user = New System.Windows.Forms.DataGridView()
        Me.txtthn = New System.Windows.Forms.TextBox()
        Me.txtidpem = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbln = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.cmbidspp = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.dgv_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(531, 240)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(59, 20)
        Me.Button2.TabIndex = 182
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(367, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 180
        Me.Label10.Text = "Jumlah Bayar"
        '
        'txtjml
        '
        Me.txtjml.Location = New System.Drawing.Point(353, 204)
        Me.txtjml.Name = "txtjml"
        Me.txtjml.Size = New System.Drawing.Size(100, 20)
        Me.txtjml.TabIndex = 181
        '
        'txtidpet
        '
        Me.txtidpet.FormattingEnabled = True
        Me.txtidpet.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.txtidpet.Location = New System.Drawing.Point(353, 104)
        Me.txtidpet.Name = "txtidpet"
        Me.txtidpet.Size = New System.Drawing.Size(100, 21)
        Me.txtidpet.TabIndex = 179
        '
        'txtnisn
        '
        Me.txtnisn.FormattingEnabled = True
        Me.txtnisn.Items.AddRange(New Object() {"123", "234", "345", "456", "567", "678"})
        Me.txtnisn.Location = New System.Drawing.Point(626, 103)
        Me.txtnisn.Name = "txtnisn"
        Me.txtnisn.Size = New System.Drawing.Size(100, 21)
        Me.txtnisn.TabIndex = 178
        '
        'Dttglbayar
        '
        Me.Dttglbayar.Location = New System.Drawing.Point(79, 156)
        Me.Dttglbayar.Name = "Dttglbayar"
        Me.Dttglbayar.Size = New System.Drawing.Size(100, 20)
        Me.Dttglbayar.TabIndex = 177
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(458, 424)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 176
        Me.Button5.Text = "Hapus"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(302, 424)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 175
        Me.Button4.Text = "Edit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(149, 425)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 174
        Me.Button3.Text = "Tambah"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(596, 240)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(130, 20)
        Me.txtcari.TabIndex = 173
        '
        'dgv_user
        '
        Me.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_user.Location = New System.Drawing.Point(79, 268)
        Me.dgv_user.Name = "dgv_user"
        Me.dgv_user.Size = New System.Drawing.Size(647, 150)
        Me.dgv_user.TabIndex = 172
        '
        'txtthn
        '
        Me.txtthn.Location = New System.Drawing.Point(626, 155)
        Me.txtthn.Name = "txtthn"
        Me.txtthn.Size = New System.Drawing.Size(100, 20)
        Me.txtthn.TabIndex = 170
        '
        'txtidpem
        '
        Me.txtidpem.Location = New System.Drawing.Point(79, 104)
        Me.txtidpem.Name = "txtidpem"
        Me.txtidpem.Size = New System.Drawing.Size(100, 20)
        Me.txtidpem.TabIndex = 168
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(106, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 167
        Me.Label8.Text = "ID SPP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(640, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 166
        Me.Label7.Text = "Tahun Dibayar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(367, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "Belum Dibayar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 164
        Me.Label5.Text = "Tanggal Bayar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(658, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 163
        Me.Label4.Text = "NISN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(372, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "ID Petugas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "ID Pembayaran"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(713, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(322, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kelola Transaksi"
        '
        'txtbln
        '
        Me.txtbln.Location = New System.Drawing.Point(353, 155)
        Me.txtbln.Name = "txtbln"
        Me.txtbln.Size = New System.Drawing.Size(100, 20)
        Me.txtbln.TabIndex = 169
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 78)
        Me.Panel1.TabIndex = 160
        '
        'cmbidspp
        '
        Me.cmbidspp.FormattingEnabled = True
        Me.cmbidspp.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cmbidspp.Location = New System.Drawing.Point(79, 203)
        Me.cmbidspp.Name = "cmbidspp"
        Me.cmbidspp.Size = New System.Drawing.Size(100, 21)
        Me.cmbidspp.TabIndex = 183
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(596, 425)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 184
        Me.Button6.Text = "LogOut"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'KelolaTransaksiPetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.ClientSize = New System.Drawing.Size(800, 456)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.cmbidspp)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtjml)
        Me.Controls.Add(Me.txtidpet)
        Me.Controls.Add(Me.txtnisn)
        Me.Controls.Add(Me.Dttglbayar)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.dgv_user)
        Me.Controls.Add(Me.txtthn)
        Me.Controls.Add(Me.txtidpem)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbln)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "KelolaTransaksiPetugas"
        Me.Text = "KelolaTransaksiPetugas"
        CType(Me.dgv_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtjml As TextBox
    Friend WithEvents txtidpet As ComboBox
    Friend WithEvents txtnisn As ComboBox
    Friend WithEvents Dttglbayar As DateTimePicker
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtcari As TextBox
    Friend WithEvents dgv_user As DataGridView
    Friend WithEvents txtthn As TextBox
    Friend WithEvents txtidpem As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbln As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents cmbidspp As ComboBox
    Friend WithEvents Button6 As Button
End Class
