Public Class Form2

    Dim kolom, spasiBawah, spasiAtas, banyakKolom, banyakBaris As Integer
    Dim hasil As String
    Dim spasi As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hasil = ""
        banyakBaris = Convert.ToInt64(barisString.Text)
        banyakKolom = (banyakBaris * 2) - 1
        If Pola.Text = "Piramyd" Then
            spasiAtas = banyakBaris + 1
            spasiBawah = banyakBaris - 1
            For spasi As Integer = 1 To banyakBaris
                kolom = 1
                For kolom As Integer = 1 To banyakKolom
                    If kolom > spasiBawah And kolom < spasiAtas Then
                        hasil &= "*"
                    Else
                        hasil &= " "
                    End If
                Next
                spasiBawah -= 1
                spasiAtas += 1
                hasil &= vbCrLf

            Next

        ElseIf Pola.Text = "Hollow Piramyd" Then
            spasiAtas = banyakBaris
            spasiBawah = banyakBaris
            For baris As Integer = 1 To banyakBaris
                kolom = 1
                If baris = banyakBaris Then
                    For kolom As Integer = 1 To banyakKolom
                        hasil &= "*"
                    Next
                Else
                    For kolom As Integer = 1 To banyakKolom
                        If kolom = spasiBawah Or kolom = spasiAtas Then
                            hasil &= "*"
                        Else
                            hasil &= " "
                        End If
                    Next
                End If
                spasiBawah -= 1
                spasiAtas += 1
                hasil &= vbCrLf
            Next

        ElseIf Pola.Text = "Inverted Piramyd" Then
            spasiAtas = banyakKolom
            spasiBawah = 1
            For baris As Integer = 1 To banyakBaris
                kolom = 1
                For kolom As Integer = 1 To banyakKolom
                    If kolom >= spasiBawah And kolom <= spasiAtas Then
                        hasil &= "*"
                    Else
                        hasil &= " "
                    End If
                Next
                spasiBawah += 1
                spasiAtas -= 1
                hasil &= vbCrLf

            Next
        ElseIf Pola.Text = "Hollow Inverted Piramyd" Then
            spasiAtas = banyakKolom
            spasiBawah = 1
            For baris As Integer = 1 To banyakBaris
                kolom = 1
                If baris = 1 Then
                    For kolom As Integer = 1 To banyakKolom
                        hasil &= "*"
                    Next
                Else
                    For kolom As Integer = 1 To banyakKolom
                        If kolom = spasiBawah Or kolom = spasiAtas Then
                            hasil &= "*"
                        Else
                            hasil &= " "
                        End If
                    Next
                End If
                spasiBawah += 1
                spasiAtas -= 1
                hasil &= vbCrLf

            Next
        End If
        hasilBox.Text = hasil
    End Sub

End Class