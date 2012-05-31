<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStartUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStartUp))
        Me.picBanner = New System.Windows.Forms.PictureBox()
        Me.rtfStartUpMessage = New System.Windows.Forms.RichTextBox()
        Me.chkAgree = New System.Windows.Forms.CheckBox()
        Me.btnDecline = New System.Windows.Forms.Button()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.lblBoxTitle = New System.Windows.Forms.Label()
        Me.picUSGSlogo = New System.Windows.Forms.PictureBox()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUSGSlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBanner
        '
        Me.picBanner.Image = CType(resources.GetObject("picBanner.Image"), System.Drawing.Image)
        Me.picBanner.Location = New System.Drawing.Point(-1, 3)
        Me.picBanner.Name = "picBanner"
        Me.picBanner.Size = New System.Drawing.Size(333, 49)
        Me.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBanner.TabIndex = 1
        Me.picBanner.TabStop = False
        '
        'rtfStartUpMessage
        '
        Me.rtfStartUpMessage.BackColor = System.Drawing.Color.White
        Me.rtfStartUpMessage.Location = New System.Drawing.Point(11, 75)
        Me.rtfStartUpMessage.Name = "rtfStartUpMessage"
        Me.rtfStartUpMessage.ReadOnly = True
        Me.rtfStartUpMessage.Size = New System.Drawing.Size(309, 205)
        Me.rtfStartUpMessage.TabIndex = 2
        Me.rtfStartUpMessage.Text = ""
        '
        'chkAgree
        '
        Me.chkAgree.AutoSize = True
        Me.chkAgree.Location = New System.Drawing.Point(12, 286)
        Me.chkAgree.Name = "chkAgree"
        Me.chkAgree.Size = New System.Drawing.Size(194, 17)
        Me.chkAgree.TabIndex = 3
        Me.chkAgree.Text = "I have read and agree to the above"
        Me.chkAgree.UseVisualStyleBackColor = True
        '
        'btnDecline
        '
        Me.btnDecline.Location = New System.Drawing.Point(93, 315)
        Me.btnDecline.Name = "btnDecline"
        Me.btnDecline.Size = New System.Drawing.Size(75, 23)
        Me.btnDecline.TabIndex = 4
        Me.btnDecline.Text = "Decline"
        Me.btnDecline.UseVisualStyleBackColor = True
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(12, 315)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.TabIndex = 5
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'lblBoxTitle
        '
        Me.lblBoxTitle.AutoSize = True
        Me.lblBoxTitle.Location = New System.Drawing.Point(9, 59)
        Me.lblBoxTitle.Name = "lblBoxTitle"
        Me.lblBoxTitle.Size = New System.Drawing.Size(145, 13)
        Me.lblBoxTitle.TabIndex = 6
        Me.lblBoxTitle.Text = "Disclaimer and Terms of Use:"
        '
        'picUSGSlogo
        '
        Me.picUSGSlogo.Image = CType(resources.GetObject("picUSGSlogo.Image"), System.Drawing.Image)
        Me.picUSGSlogo.Location = New System.Drawing.Point(184, 304)
        Me.picUSGSlogo.Name = "picUSGSlogo"
        Me.picUSGSlogo.Size = New System.Drawing.Size(135, 34)
        Me.picUSGSlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUSGSlogo.TabIndex = 7
        Me.picUSGSlogo.TabStop = False
        '
        'frmStartUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 350)
        Me.Controls.Add(Me.picUSGSlogo)
        Me.Controls.Add(Me.lblBoxTitle)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.btnDecline)
        Me.Controls.Add(Me.chkAgree)
        Me.Controls.Add(Me.rtfStartUpMessage)
        Me.Controls.Add(Me.picBanner)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmStartUp"
        Me.Text = "NWIS Snapshot"
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUSGSlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBanner As System.Windows.Forms.PictureBox
    Friend WithEvents rtfStartUpMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents chkAgree As System.Windows.Forms.CheckBox
    Friend WithEvents btnDecline As System.Windows.Forms.Button
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents lblBoxTitle As System.Windows.Forms.Label
    Friend WithEvents picUSGSlogo As System.Windows.Forms.PictureBox
End Class
