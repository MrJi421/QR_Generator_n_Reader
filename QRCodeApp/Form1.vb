Imports QRCoder
Imports System.IO
Imports System.Windows.Forms

Public Class Form1

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        ' Create a QR code generator
        Dim qrGenerator As New QRCodeGenerator()
        Dim qrCodeData As QRCodeData = qrGenerator.CreateQrCode(Textinput.Text, QRCodeGenerator.ECCLevel.Q)
        Dim qrCode As New QRCode(qrCodeData)

        ' Get the QR code as a bitmap
        Dim qrCodeImage As Bitmap = qrCode.GetGraphic(5)

        ' Display the QR code in the PictureBox
        pic.Image = qrCodeImage
        If pic.Image IsNot Nothing Then
            downloadbtn.Enabled = True
        Else
            downloadbtn.Enabled = False
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
        'terminate the app
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'reset the generated image and text
        pic.Image = My.Resources.img1
        Textinput.Text = String.Empty
        downloadbtn.Enabled = False
    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        'change the window to scan mode and reset it to reset mode
        Me.Hide()
        pic.Image = My.Resources.img1
        Textinput.Text = String.Empty
        downloadbtn.Enabled = False
        Form2.Show()
        'Me.Refresh()

    End Sub

    Private Sub downloadbtn_Click(sender As Object, e As EventArgs) Handles downloadbtn.Click
        'download the image file
        If pic.Image IsNot Nothing Then
            ' Use SaveFileDialog to specify the file name and location for saving the QR code image
            Using saveFileDialog As New SaveFileDialog
                saveFileDialog.Filter = "PNG Image|*.png"
                saveFileDialog.Title = "Save QR Code Image"
                saveFileDialog.FileName = "qrcode.png" ' Default file name

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    ' Get the user-selected file path and save the QR code image there
                    Dim targetPath As String = saveFileDialog.FileName

                    If Not String.IsNullOrEmpty(targetPath) Then
                        ' Save the QR code image to the specified location
                        pic.Image.Save(targetPath)
                        downloadbtn.Text = "Downloaded"
                        Timer1.start()
                    End If
                End If
            End Using
        Else
            MessageBox.Show("No QR code image to download. Generate a QR code first.")
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'after 5 sec timer need to stop and btn need to be come its previous text state
        downloadbtn.Text = "Download"
        Timer1.Stop()
    End Sub
End Class