Public Class Form1
    Private Sub btnheroe_Click(sender As Object, e As EventArgs) Handles btnheroe.Click
        Dim alien As Int16
        alien = Int(txtalien.Text)
        If alien = 1 Then
            MessageBox.Show("Sayayin")
        End If
        If alien = 2 Then
            MessageBox.Show("Kriptoniano")
        End If
        If alien = 4 Then
            MessageBox.Show("Alien X")
        End If
        If alien = 5 Then
            MessageBox.Show("Cuatro Brazon")
        End If
        If alien = 6 Then
            MessageBox.Show("Alien")
        End If
        If alien = 7 Then
            MessageBox.Show("Diamante")
        End If
        If alien = 8 Then
            MessageBox.Show("Fuego")
        End If
        If alien = 9 Then
            MessageBox.Show("")
        End If
    End Sub
End Class
