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
Imports ESRI.ArcGIS.Framework
Imports ESRI.ArcGIS.esriSystem
Imports ESRI.ArcGIS.Desktop.AddIns
Imports System.Windows.Forms

'btnMenuLaunch
Public Class btnMenuLaunch
    'button on the Snapshot add-in toolbar
    Inherits ESRI.ArcGIS.Desktop.AddIns.Button

    '----------------------------------------------------------
    'New
    Public Sub New()

    End Sub


    '----------------------------------------------------------
    'OnUpdate
    Protected Overrides Sub OnUpdate()
        Enabled = My.ArcMap.Application IsNot Nothing
    End Sub


    '----------------------------------------------------------
    'OnClick
    Protected Overrides Sub OnClick()
        'toggle the shown / hidden state of the Snapshot DockableWindow
        'will popup a disclaimer if making DockableWindow visible and it hasn't been shown yet

        'get ID of dockable window
        Dim docWinID As UID = New UID
        docWinID.Value = My.IDs.docSnapshot

        'get ref of dockable window
        Dim docWinREF As IDockableWindow
        docWinREF = My.ArcMap.DockableWindowManager.GetDockableWindow(docWinID)

        'toggle the shown state
        If docWinREF.IsVisible Then 'currently shown
            docWinREF.Show(False) 'hide.
            blnAcceptedDisclaimer = True 'if it is shown, discalaimer has been accepted already
        Else 'currently hidden
            If blnAcceptedDisclaimer = False Then 'dislaimer not accepted yet
                'show the StartUp disclaimer as a modal dialog
                Dim frmStartUp As New frmStartUp
                frmStartUp.StartPosition = FormStartPosition.CenterParent
                frmStartUp.ShowDialog() 'will set global accept variable if accept hit
            End If
            If blnAcceptedDisclaimer = True Then
                'compare the computer system time to NWISWeb time
                'a warning is given if the time difference > +/- 12 hours, but doesn't do anything
                CheckSystemTime()

                'disclaimer was accepted - show
                docWinREF.Show(True)
            End If
        End If

    End Sub

End Class
