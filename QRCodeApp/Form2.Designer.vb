<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.TextExtracted = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.imgUploadbtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.copybtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(175, 587)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 3
        Me.btnGenerate.Text = "Generate mode"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'TextExtracted
        '
        Me.TextExtracted.Location = New System.Drawing.Point(94, 515)
        Me.TextExtracted.Multiline = True
        Me.TextExtracted.Name = "TextExtracted"
        Me.TextExtracted.Size = New System.Drawing.Size(528, 66)
        Me.TextExtracted.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 496)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Extracted Text :"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(94, 587)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(385, 587)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(580, 659)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Developed by @Mr. Ji"
        '
        'imgUploadbtn
        '
        Me.imgUploadbtn.Location = New System.Drawing.Point(547, 587)
        Me.imgUploadbtn.Name = "imgUploadbtn"
        Me.imgUploadbtn.Size = New System.Drawing.Size(75, 23)
        Me.imgUploadbtn.TabIndex = 0
        Me.imgUploadbtn.Text = "Upload"
        Me.imgUploadbtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Square721 BT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(296, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "QR Scanner"
        '
        'pic
        '
        Me.pic.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pic.ErrorImage = Nothing
        Me.pic.Image = Global.QRCodeApp.My.Resources.Resources.img2
        Me.pic.InitialImage = Nothing
        Me.pic.Location = New System.Drawing.Point(94, 33)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(528, 451)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic.TabIndex = 12
        Me.pic.TabStop = False
        '
        'copybtn
        '
        Me.copybtn.Enabled = False
        Me.copybtn.Location = New System.Drawing.Point(466, 587)
        Me.copybtn.Name = "copybtn"
        Me.copybtn.Size = New System.Drawing.Size(75, 23)
        Me.copybtn.TabIndex = 1
        Me.copybtn.Text = "Copy"
        Me.copybtn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 681)
        Me.Controls.Add(Me.pic)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.imgUploadbtn)
        Me.Controls.Add(Me.copybtn)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextExtracted)
        Me.Controls.Add(Me.btnGenerate)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QR Code Generator"
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerate As Button
    Friend WithEvents TextExtracted As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents imgUploadbtn As Button
    Friend WithEvents pic As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents copybtn As Button
    Friend WithEvents Timer1 As Timer
End Class
