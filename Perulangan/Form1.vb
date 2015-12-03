Public Class Form1

    Private Sub ProblemBintangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProblemBintangToolStripMenuItem.Click
        Form2.Show()
    End Sub


    Private Sub MatriksKalkulatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatriksKalkulatorToolStripMenuItem.Click
        Matriks.Show()
    End Sub


    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim pilih = MessageBox.Show("Apakah anda yakin ingin keluar ?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If pilih = Windows.Forms.DialogResult.OK Then
            Environment.Exit(0)
        Else

        End If
    End Sub

End Class
