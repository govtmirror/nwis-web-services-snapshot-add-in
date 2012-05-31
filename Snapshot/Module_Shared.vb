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
Module Module_Shared
    'This module is used to define variables shared between different Snapshot components.

    'version and last update:
    Public strThisVersion As String = "Snapshot 1.0 for ArcMap 10.0" '"[major number].[minor number] [string specifying target ArcMap version]"
    Public strThisLastUpdate As String = "September 1, 2011"

    '-----------------------------------------------
    'help URLs:

    'Snapshot web homepage:
    Public strSnapshotWebHomepage = "http://txpub.usgs.gov/snapshot/"

    'help links for "?" icons:
    '  Sites tab:
    Public strSitesHelpWebPage As String = "http://txpub.usgs.gov/snapshot/10.0/Help/Tester_Instructions_Arc10.htm#Tester_Instructions_Arc10_1.htm#Request_data_from_the"
    '  QW tab:
    Public strQWHelpWebPage As String = "http://txpub.usgs.gov/snapshot/10.0/Help/Tester_Instructions_Arc10.htm#Tester_Instructions_Arc10_1.htm#Request_and_explore_databc-14"
    '  DV tab:
    Public strDVHelpWebPage As String = "http://txpub.usgs.gov/snapshot/10.0/Help/Tester_Instructions_Arc10.htm#Tester_Instructions_Arc10_1.htm#Request_data_from_the2bc-18"
    '  UV tab:
    Public strUVHelpWebPage As String = "http://txpub.usgs.gov/snapshot/10.0/Help/Tester_Instructions_Arc10.htm#Tester_Instructions_Arc10_1.htm#Request_data_from_the1bc-17"

    '-----------------------------------------------
    'webservice base URLs:

    '  Sites:
    Public strSitesBaseURL As String = "http://waterservices.usgs.gov/nwis/site?format=mapper,1.0"
    '  QW:
    Public strQWBaseURL As String = "http://qwwebservices.usgs.gov/Result/search"
    '  DV:
    Public strDVBaseURL As String = "http://waterservices.usgs.gov/nwis/dv"
    '  UV:
    Public strUVBaseURL As String = "http://waterservices.usgs.gov/nwis/iv"

    '-----------------------------------------------
    'pcodes output by the PCodePicker and loaded into the Snapshot main window.
    Public strQWPcodes As String = Nothing

    'whether the disclaimer has already been shown and accepted
    Public blnAcceptedDisclaimer As Boolean = False

    'Site Tab: maximum spatial area limit (square degrees) allowed by web service.
    Public dblSiteService_MaxAreaSqDeg As Double = 24.0 'note: as of 10-14-2011, the limit is 25 square degrees - set a little lower for safety margin

    'Site Tab: maximum spatial area limit (square degrees) allowed by Snaphot.
    'Snapshot uses tiling to partition the map extent, with a separate web service query for each tile.
    Public dblSnapshot_MaxAreaSqDeg As Double = 9999999999.0 'do not restrict


    '===================================================================
    'SHARED SUBS / FUNCTIONS

    Public Sub CheckSystemTime()
        'Do a quick NWISWeb query to get the current date-time.
        'Ignore time-zones, and compare to computer's system date-time.
        'If difference is more than +/- 12 hours (worst case scenario for any possible timezone),
        'a warning dialog will popup notifying user.
        '
        'If any errors occur, Sub is exited without doing anything.
        '
        'method: scrape a NWISWeb rdb query result to get the current date-time
        'note:   using site_no 12345678 in the query to get a response
        '        this is a dummy site that exists in NWISWeb, but may want to change this
        '        need to use something that will register a hit (has results) or query will fail
        '
        'URL: http://waterdata.usgs.gov/nwis/inventory?search_site_no=12345678&search_site_no_match_type=exact&format=sitefile_output&sitefile_output_format=rdb&column_name=site_no
        'RETURNS (rdb format):
        '#
        '#
        '# US Geological Survey
        '# retrieved: 2011-08-15 16:31:24 EDT
        '...more stuff...

        Try
            'setup connection to service
            Dim client As System.Net.WebClient = New System.Net.WebClient()
            Dim content As String = client.DownloadString("http://waterdata.usgs.gov/nwis/inventory?search_site_no=12345678&search_site_no_match_type=exact&format=sitefile_output&sitefile_output_format=rdb&column_name=site_no")
            Dim sr As New System.IO.StringReader(content)

            'read through each string looking for 1st occurance of 'retrieved:'
            Dim strDateTime As String = ""
            While sr.Peek <> -1
                Dim s As String = sr.ReadLine
                If s.StartsWith("# retrieved: ") Then
                    strDateTime = s.Substring(13, 19) '2011-08-15 16:31:24  <== IGNORING timezone
                    Exit While
                End If
            End While
            client.Dispose()

            'see if found the dateTime
            If strDateTime = "" Then Exit Sub 'didn't ifnd it - do nothing.

            'compute difference of web result and computer system time
            Dim nHourDiff As Double = CDbl(Now.Subtract(CDate(strDateTime)).TotalHours)
            'MsgBox(nHourDiff.ToString)

            'give warning if abs(difference) > 12 hours
            If System.Math.Abs(nHourDiff) > 12.0 Then
                System.Windows.Forms.MessageBox.Show( _
                "WARNING:" & vbCrLf _
                & vbCrLf _
                & "A descrepancy larger than 12 hours between your computer system Date-Time " & vbCrLf _
                & "and the current NWISWeb Date-Time has been detected." & vbCrLf _
                & vbCrLf _
                & "The Snapshot tool requires requires an accurate computer system Date-Time " & vbCrLf _
                & "for some of its features. " & vbCrLf _
                & vbCrLf _
                & "Please verify your computer Date-Time and adjust if needed.", _
                "Snapshot", _
                System.Windows.Forms.MessageBoxButtons.OK, _
                System.Windows.Forms.MessageBoxIcon.Exclamation, _
                System.Windows.Forms.MessageBoxDefaultButton.Button1)
            End If

        Catch
            'do nothing.

        End Try

    End Sub

End Module



