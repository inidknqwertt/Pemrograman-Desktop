Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Untuk Menambahkan item ke dalam ComboBox Fakultas
        cmbFakultas.Items.Add("FMIPA")
        cmbFakultas.Items.Add("FKIP")
        cmbFakultas.Items.Add("FEB")

        ' Untuk Menambahkan item ke dalam ComboBox Jurusan
        cmbJurusan.Items.Add("Matematika")
        cmbJurusan.Items.Add("Kimia")
        cmbJurusan.Items.Add("Biologi")
        cmbJurusan.Items.Add("Fisika")
        cmbJurusan.Items.Add("Ilmu Komputer")
    End Sub

    Private Sub txtNIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIP.KeyPress
        ' Hanya memperbolehkan input angka di NIP
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click

        ' Pilih jenis kelamin dari RadioButton
        Dim jenisKelamin As String = ""
        If radioLaki.Checked Then
            jenisKelamin = "Laki-laki"
        ElseIf radioPerempuan.Checked Then
            jenisKelamin = "Perempuan"
        Else
            MessageBox.Show("Pilih jenis kelamin!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'TAMPILAN MassageBox
        Dim message As String = "Hai : " & txtNIP.Text & vbCrLf &
                                "Nip : " & txtNama.Text & vbCrLf &
                                "Fakultas : " & cmbFakultas.SelectedItem.ToString() & vbCrLf &
                                "Jurusan : " & cmbJurusan.SelectedItem.ToString() & vbCrLf &
                                "Jenis Kelamin : " & jenisKelamin
        MessageBox.Show(message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
