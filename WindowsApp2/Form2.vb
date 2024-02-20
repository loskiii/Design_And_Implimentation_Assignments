Public Class Form2
    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.chbBold.Text = Font.
    End Sub

    Private Sub chbItalic_CheckedChanged(sender As Object, e As EventArgs) Handles chbItalic.CheckedChanged
        txtSampleBox.Font = New Font(txtSampleBox.Font, txtSampleBox.Font.Style _
                                                               Xor FontStyle.Italic)
    End Sub

    Private Sub chbBold_CheckedChanged(sender As Object, e As EventArgs) Handles chbBold.CheckedChanged
        txtSampleBox.Font = New Font(txtSampleBox.Font, txtSampleBox.Font.Style _
                                                               Xor FontStyle.Bold)
    End Sub

    Private Sub chbBoldItalic_CheckedChanged(sender As Object, e As EventArgs) Handles chbBoldItalic.CheckedChanged
        txtSampleBox.Font = New Font(txtSampleBox.Font, txtSampleBox.Font.Style _
                                                               Xor FontStyle.Bold)
        txtSampleBox.Font = New Font(txtSampleBox.Font, txtSampleBox.Font.Style _
                                                               Xor FontStyle.Italic)
    End Sub

    Private Sub rdbGreen_CheckedChanged(sender As Object, e As EventArgs) Handles rdbGreen.CheckedChanged
        txtSampleBox.ForeColor = Color.Green
    End Sub

    Private Sub rdbBlue_CheckedChanged(sender As Object, e As EventArgs) Handles rdbBlue.CheckedChanged
        txtSampleBox.ForeColor = Color.Blue
    End Sub

    Private Sub rdbRed_CheckedChanged(sender As Object, e As EventArgs) Handles rdbRed.CheckedChanged
        txtSampleBox.ForeColor = Color.Red
    End Sub

    Private Sub rdbMagneto_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMagneto.CheckedChanged
        txtSampleBox.Font = New Font("Magneto", txtSampleBox.Font.Size, txtSampleBox.Font.Style)
    End Sub

    Private Sub rdbGaramond_CheckedChanged(sender As Object, e As EventArgs) Handles rdbGaramond.CheckedChanged
        txtSampleBox.Font = New Font("Garamond", txtSampleBox.Font.Size, txtSampleBox.Font.Style)
    End Sub

    Private Sub rdbTahoma_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTahoma.CheckedChanged
        txtSampleBox.Font = New Font("Tahoma", txtSampleBox.Font.Size, txtSampleBox.Font.Style)
    End Sub

    Private Sub btnLoadPicture_Click(sender As Object, e As EventArgs) Handles btnLoadPicture.Click
        pctLoadPicture.ImageLocation = "C:\Users\Admin\Desktop\Coding\HTML&JS\Images\amg.png"
    End Sub
End Class