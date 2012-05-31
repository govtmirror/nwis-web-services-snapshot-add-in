'**************************************************************************
'**************************************************************************
'****
'**** This software is in the public domain because it contains materials that
'**** originally came from the United States Geological Survey, an agency of the
'**** United States Department of Interior. For more information, see the official
'**** USGS copyright policy at http://www.usgs.gov/visual-id/credit_usgs.html#copyright
'**** 
'**** This software is provided "AS IS".
'****
'**** The Snapshot add-in utility was based upon original work done by:
'****           David McCulloch, USGS Reston VA [dmccullo@usgs.gov]
'****
'**** Snapshot Team Leader: Sally Holl,    USGS TX-WSC Austin [sholl@usgs.gov]
'****           Programmer: David Maltby,  USGS TX-WSC Austin [drmaltby@usgs.gov]
'****           Programmer: Joseph Vrabel, USGS TX-WSC Austin [jvrabel@usgs.gov]
'****
'**************************************************************************
'**************************************************************************
Public Class frmStartUp
    'this is a simple form that displays a Disclaimer and requires the user to "Accept" or "Decline"
    'a global 'blnAcceptedDisclaimer' variable is set to True only if user "Accepts" (set false otherwise)

    'frmStartUp_Load
    Private Sub frmStartUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'initialize disclaimer text
        rtfStartUpMessage.BackColor = Drawing.Color.White
        rtfStartUpMessage.Text = _
            "This software is in the public domain because it contains materials that " & _
            "originally came from the United States Geological Survey, an agency of the " & _
            "United States Department of Interior. For more information, see the official " & _
            "USGS copyright policy at http://www.usgs.gov/visual-id/credit_usgs.html#copyright" & vbCrLf _
            & vbCrLf _
            & "This Add-In is provided 'AS IS'."

        'uncheck "agree"
        chkAgree.Checked = False

        'disable "Accept"
        btnAccept.Enabled = False

        'make disclaimer visible and proceed
        Me.Visible = True
    End Sub


    'chkAgree_CheckedChanged
    Private Sub chkAgree_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAgree.CheckedChanged
        'enable Accept button if check
        If chkAgree.Checked Then
            btnAccept.Enabled = True
        Else
            btnAccept.Enabled = False
        End If
    End Sub


    'btnAccept_Click
    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        'accepting - set global accept flag and exit
        blnAcceptedDisclaimer = True
        Me.Close()
    End Sub


    'btnDecline_Click
    Private Sub btnDecline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecline.Click
        'declining - set global accept flag and exit
        blnAcceptedDisclaimer = False
        Me.Close()
    End Sub


    'rtfStartUpMessage_LinkClicked
    Private Sub rtfStartUpMessage_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles rtfStartUpMessage.LinkClicked
        'launch the link clicked in the rich text box in system browser.
        Dim strURL As String = e.LinkText 'link URL.
        Try
            System.Diagnostics.Process.Start(strURL)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show( _
                "Sorry, cannot access the web page: " & vbCrLf & strURL, _
                "Snapshot", _
                System.Windows.Forms.MessageBoxButtons.OK, _
                System.Windows.Forms.MessageBoxIcon.Information, _
                System.Windows.Forms.MessageBoxDefaultButton.Button1)
        End Try
    End Sub

End Class


