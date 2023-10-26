Imports ZXing
Imports ZXing.QrCode


Public Class Form2

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        'hide this window and open the scan app
        pic.Image = My.Resources.img2
        TextExtracted.Text = String.Empty
        TextExtracted.Enabled = True
        copybtn.Enabled = False
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'terminate the app
        Application.Exit()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'on click the reset btn img and text need to be cleared
        pic.Image = My.Resources.img2
        TextExtracted.Text = String.Empty
        TextExtracted.Enabled = True
        copybtn.Enabled = False

    End Sub

    Private Sub imgUploadbtn_Click(sender As Object, e As EventArgs) Handles imgUploadbtn.Click
        Dim openFileDialog As New OpenFileDialog()
        'filter the image files
        openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*"

        'if file explorer opens, select the 
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim imageFilePath As String = openFileDialog.FileName
            Dim barcodeReader As New BarcodeReader()
            Dim bitmap As New Bitmap(imageFilePath)
            Dim result As Result = barcodeReader.Decode(bitmap)
            pic.Image = Image.FromFile(imageFilePath)

            If result IsNot Nothing Then
                'if image is a qr code and some text is found in qr code it will be stored
                'in the given variable and will be shown in textBox
                Dim decodedText As String = result.Text
                TextExtracted.Text = decodedText
                TextExtracted.Enabled = False
                copybtn.Enabled = True
            Else
                'if image is not a qr code it will be show a message that qr code is not found
                MsgBox("QR code not found in the selected image.")
            End If

        End If
    End Sub

    Private Sub copybtn_Click(sender As Object, e As EventArgs) Handles copybtn.Click
        Dim copiedtext As String = TextExtracted.Text

        If Not String.IsNullOrEmpty(copiedtext) Then

            'if text box consists the text then copy it
            Clipboard.SetText(copiedtext)
            copybtn.Text = "Copied"
            Timer1.Start()

        Else
            copybtn.Enabled = False
            'if image is not a qr code it will be desabled
            MsgBox("Text or links not found in the selected QR code.")

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        copybtn.Text = "Copy"
        Timer1.Stop()
    End Sub

End Class
