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
Option Explicit On
Option Compare Binary 'need this set to binary for string comparisons
Imports System.Windows.Forms

Public Class frmPcodePicker
    'form for looking up USGS parameter codes using search criteria.

    'shared variables:
    Dim intMaxListMatching As Integer = 1000 'limit the number of matches shown to this to enhance performance
    Dim intNmatches As Integer 'stores the total number of matches found
    Const link_NWISWebPcodeList As String = "http://nwis.waterdata.usgs.gov/usa/nwis/pmcodes"

    '--------------------------------------------------
    'frmPcodePicker = ME

    'frmPcodePicker_Load
    Private Sub frmPcodePicker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'NOTE: keep in mind whatever control changes are done here will fire their events

        'hide / show some controls
        btnDebug.Visible = False
        chkSearchAsTyping.Visible = False
        chkSearchMatchCase.Visible = False
        btnSearch.Visible = False

        'set ESC key to btnCancel
        Me.CancelButton = btnCancel

        'set search defaults
        chkSearchMatchCase.Checked = False
        chkSearchAsTyping.Checked = True

        'add pcode counts to group checkbox names
        'disable group checkboxes that have no pcodes
        'check the enabled checkboxes
        Dim strNpcodes As String
        Dim havePcodes As Boolean

        strNpcodes = "0"
        havePcodes = False
        If strAry_BIO_PNAME IsNot Nothing Then
            strNpcodes = strAry_BIO_PNAME.Length.ToString
            havePcodes = True
        End If
        With chkGroupBIO
            .Text = .Text & " (" & strNpcodes & ")"
            .Enabled = havePcodes
            .Checked = havePcodes
        End With

        strNpcodes = "0"
        havePcodes = False
        If strAry_HAB_PNAME IsNot Nothing Then
            strNpcodes = strAry_HAB_PNAME.Length.ToString
            havePcodes = True
        End If
        With chkGroupHAB
            .Text = .Text & " (" & strNpcodes & ")"
            .Enabled = havePcodes
            .Checked = havePcodes
        End With

        strNpcodes = "0"
        havePcodes = False
        If strAry_INF_PNAME IsNot Nothing Then
            strNpcodes = strAry_INF_PNAME.Length.ToString
            havePcodes = True
        End If
        With chkGroupINF
            .Text = .Text & " (" & strNpcodes & ")"
            .Enabled = havePcodes
            .Checked = havePcodes
        End With

        strNpcodes = "0"
        havePcodes = False
        If strAry_IMM_PNAME IsNot Nothing Then
            strNpcodes = strAry_IMM_PNAME.Length.ToString
            havePcodes = True
        End If
        With chkGroupIMM
            .Text = .Text & " (" & strNpcodes & ")"
            .Enabled = havePcodes
            .Checked = havePcodes
        End With

        strNpcodes = "0"
        havePcodes = False
        If strAry_IMN_PNAME IsNot Nothing Then
            strNpcodes = strAry_IMN_PNAME.Length.ToString
            havePcodes = True
        End If
        With chkGroupIMN
            .Text = .Text & " (" & strNpcodes & ")"
            .Enabled = havePcodes
            .Checked = havePcodes
        End With

        strNpcodes = "0"
        havePcodes = False
        If strAry_INM_PNAME IsNot Nothing Then
            strNpcodes = strAry_INM_PNAME.Length.ToString
            havePcodes = True
        End If
        With chkGroupINM
            .Text = .Text & " (" & strNpcodes & ")"
            .Enabled = havePcodes
            .Checked = havePcodes
        End With

        strNpcodes = "0"
        havePcodes = False
        If strAry_INN_PNAME IsNot Nothing Then
            strNpcodes = strAry_INN_PNAME.Length.ToString
            havePcodes = True
        End If
        With chkGroupINN
            .Text = .Text & " (" & strNpcodes & ")"
            .Enabled = havePcodes
            .Checked = havePcodes
        End With

        strNpcodes = "0"
        havePcodes = False
        If strAry_MBI_PNAME IsNot Nothing Then
            strNpcodes = strAry_MBI_PNAME.Length.ToString
            havePcodes = True
        End If
        With chkGroupMBI
            .Text = .Text & " (" & strNpcodes & ")"
            .Enabled = havePcodes
            .Checked = havePcodes
        End With

        strNpcodes = "0"
        havePcodes = False
        If strAry_NUT_PNAME IsNot Nothing Then
            strNpcodes = strAry_NUT_PNAME.Length.ToString
            havePcodes = True
        End If
        With chkGroupNUT
            .Text = .Text & " (" & strNpcodes & ")"
            .Enabled = havePcodes
            .Checked = havePcodes
        End With

        strNpcodes = "0"
        havePcodes = False
        If strAry_OPE_PNAME IsNot Nothing Then
            strNpcodes = strAry_OPE_PNAME.Length.ToString
            havePcodes = True
        End If
        With chkGroupOPE
            .Text = .Text & " (" & strNpcodes & ")"
            .Enabled = havePcodes
            .Checked = havePcodes
        End With

        strNpcodes = "0"
        havePcodes = False
        If strAry_OPC_PNAME IsNot Nothing Then
            strNpcodes = strAry_OPC_PNAME.Length.ToString
            havePcodes = True
        End If
        With chkGroupOPC
            .Text = .Text & " (" & strNpcodes & ")"
            .Enabled = havePcodes
            .Checked = havePcodes
        End With

        strNpcodes = "0"
        havePcodes = False
        If strAry_OOT_PNAME IsNot Nothing Then
            strNpcodes = strAry_OOT_PNAME.Length.ToString
            havePcodes = True
        End If
        With chkGroupOOT
            .Text = .Text & " (" & strNpcodes & ")"
            .Enabled = havePcodes
            .Checked = havePcodes
        End With

        strNpcodes = "0"
        havePcodes = False
        If strAry_PHY_PNAME IsNot Nothing Then
            strNpcodes = strAry_PHY_PNAME.Length.ToString
            havePcodes = True
        End If
        With chkGroupPHY
            .Text = .Text & " (" & strNpcodes & ")"
            .Enabled = havePcodes
            .Checked = havePcodes
        End With

        strNpcodes = "0"
        havePcodes = False
        If strAry_POP_PNAME IsNot Nothing Then
            strNpcodes = strAry_POP_PNAME.Length.ToString
            havePcodes = True
        End If
        With chkGroupPOP
            .Text = .Text & " (" & strNpcodes & ")"
            .Enabled = havePcodes
            .Checked = havePcodes
        End With

        strNpcodes = "0"
        havePcodes = False
        If strAry_RAD_PNAME IsNot Nothing Then
            strNpcodes = strAry_RAD_PNAME.Length.ToString
            havePcodes = True
        End If
        With chkGroupRAD
            .Text = .Text & " (" & strNpcodes & ")"
            .Enabled = havePcodes
            .Checked = havePcodes
        End With

        strNpcodes = "0"
        havePcodes = False
        If strAry_SED_PNAME IsNot Nothing Then
            strNpcodes = strAry_SED_PNAME.Length.ToString
            havePcodes = True
        End If
        With chkGroupSED
            .Text = .Text & " (" & strNpcodes & ")"
            .Enabled = havePcodes
            .Checked = havePcodes
        End With

        strNpcodes = "0"
        havePcodes = False
        If strAry_ISO_PNAME IsNot Nothing Then
            strNpcodes = strAry_ISO_PNAME.Length.ToString
            havePcodes = True
        End If
        With chkGroupISO
            .Text = .Text & " (" & strNpcodes & ")"
            .Enabled = havePcodes
            .Checked = havePcodes
        End With

        strNpcodes = "0"
        havePcodes = False
        If strAry_TOX_PNAME IsNot Nothing Then
            strNpcodes = strAry_TOX_PNAME.Length.ToString
            havePcodes = True
        End If
        With chkGroupTOX
            .Text = .Text & " (" & strNpcodes & ")"
            .Enabled = havePcodes
            .Checked = havePcodes
        End With

        strNpcodes = "0"
        havePcodes = False
        If strAry_OTH_PNAME IsNot Nothing Then
            strNpcodes = strAry_OTH_PNAME.Length.ToString
            havePcodes = True
        End If
        With chkGroupOTH
            .Text = .Text & " (" & strNpcodes & ")"
            .Enabled = havePcodes
            .Checked = havePcodes
        End With

        'set the Search Type combo box to the 1st item
        cboSearchType.SelectedItem = cboSearchType.Items(0)

        'clear the listboxes
        lstMatch.Items.Clear()
        lstFinal.Items.Clear()

        'set link so tab does not set focus 
        lnkNWISWebPcodeList.TabStop = False 'for some reason when set false in designer, goes back to true.

        'update form controls
        UpdateForm()

        'set tooltips on:
        chkToolTipsOnOff.Checked = True

        'tooltip properties and strings:
        ToolTip1.IsBalloon = True
        ToolTip1.BackColor = Drawing.Color.Cornsilk

        'set tooltip strings:

        '...search controls...
        ToolTip1.SetToolTip(btnSearch, "Search parameters using the current search settings")
        ToolTip1.SetToolTip(txtSearch, "Enter the string to search for in the parameter names")
        ToolTip1.SetToolTip(cboSearchType, "Sets the search type:" _
                            & vbCrLf & "    'Contains as complete word': Searches for parameters containing the specified search text as a complete word" _
                            & vbCrLf & "    'Starts with': Searches for parameters starting with the specified search text" _
                            & vbCrLf & "    'Contains anywhere': Searches for parameters containing the specified search text as a substring anywhere in the name" _
                            )
        ToolTip1.SetToolTip(chkSearchMatchCase, "Check to impose a case-sensitive text search." _
                            & vbCrLf & "Uncheck to perform a case-insensitive search." _
                            )
        ToolTip1.SetToolTip(chkSearchAsTyping, "Check to perform search in 'real time' as new characters are added or removed to the search text." _
                            & vbCrLf & "Unchecking required the 'Search' button to be pressed or pressing ENTER while in the Search Text box." _
                            )

        '...paramter group checkboxes...
        ToolTip1.SetToolTip(chkGroupBIO, "Check to include parameters in this group in the seach")
        ToolTip1.SetToolTip(chkGroupHAB, "Check to include parameters in this group in the seach")
        ToolTip1.SetToolTip(chkGroupINF, "Check to include parameters in this group in the seach")
        ToolTip1.SetToolTip(chkGroupIMM, "Check to include parameters in this group in the seach")
        ToolTip1.SetToolTip(chkGroupIMN, "Check to include parameters in this group in the seach")
        ToolTip1.SetToolTip(chkGroupINM, "Check to include parameters in this group in the seach")
        ToolTip1.SetToolTip(chkGroupINN, "Check to include parameters in this group in the seach")
        ToolTip1.SetToolTip(chkGroupMBI, "Check to include parameters in this group in the seach")
        ToolTip1.SetToolTip(chkGroupNUT, "Check to include parameters in this group in the seach")
        ToolTip1.SetToolTip(chkGroupOPE, "Check to include parameters in this group in the seach")
        ToolTip1.SetToolTip(chkGroupOPC, "Check to include parameters in this group in the seach")
        ToolTip1.SetToolTip(chkGroupOOT, "Check to include parameters in this group in the seach")
        ToolTip1.SetToolTip(chkGroupPHY, "Check to include parameters in this group in the seach")
        ToolTip1.SetToolTip(chkGroupPOP, "Check to include parameters in this group in the seach")
        ToolTip1.SetToolTip(chkGroupRAD, "Check to include parameters in this group in the seach")
        ToolTip1.SetToolTip(chkGroupSED, "Check to include parameters in this group in the seach")
        ToolTip1.SetToolTip(chkGroupISO, "Check to include parameters in this group in the seach")
        ToolTip1.SetToolTip(chkGroupTOX, "Check to include parameters in this group in the seach")
        ToolTip1.SetToolTip(chkGroupOTH, "Check to include parameters in this group in the seach")

        ToolTip1.SetToolTip(btnGroupAll, "Include all parameter groups in the search")
        ToolTip1.SetToolTip(btnGroupNone, "Uncheck all parameter group boxes")

        '...matching list...
        ToolTip1.SetToolTip(lstMatch, "Parameters found matching the search criteria")
        ToolTip1.SetToolTip(btnMatchAddAll, "Move all matching parameters listed to the final parameter list")
        ToolTip1.SetToolTip(btnMatchAddSel, "Move selected matching parameters to the final parameter list." _
                            & vbCrLf & "Use the mouse to single- or multi-select matching parameters." _
                            )

        '...final list...
        ToolTip1.SetToolTip(lstFinal, "Final list of selected parameters")
        ToolTip1.SetToolTip(btnFinalRemALL, "Move all parameters listed back")
        ToolTip1.SetToolTip(btnFinalRemSel, "Move selected parameters back." _
                            & vbCrLf & "Use the mouse to single- or multi-select parameters." _
                            )

        '...debug, accept, cancel...
        ToolTip1.SetToolTip(btnDebug, "DEBUG!")
        ToolTip1.SetToolTip(btnAccept, "Accept final selection and exit")
        ToolTip1.SetToolTip(btnCancel, "Disregard final selection and cancel")

        '...misc...
        ToolTip1.SetToolTip(chkToolTipsOnOff, "Check to enable Tool Tips." _
                            & vbCrLf & "Uncheck to turn tool tips off." _
                            )
        ToolTip1.SetToolTip(lnkNWISWebPcodeList, link_NWISWebPcodeList)

    End Sub


    '----------------------------------------
    'set all group checkbox _Click to FilterResults
    'don't want to use _CheckChanged because causes the check all / none button reponse to be slow (loops though each).
    Private Sub chkGroupBIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroupBIO.Click
        FilterResults()
    End Sub
    Private Sub chkGroupHAB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroupHAB.Click
        FilterResults()
    End Sub
    Private Sub chkGroupINF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroupINF.Click
        FilterResults()
    End Sub
    Private Sub chkGroupIMM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroupIMM.Click
        FilterResults()
    End Sub
    Private Sub chkGroupIMN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroupIMN.Click
        FilterResults()
    End Sub
    Private Sub chkGroupINM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroupINM.Click
        FilterResults()
    End Sub
    Private Sub chkGroupINN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroupINN.Click
        FilterResults()
    End Sub
    Private Sub chkGroupMBI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroupMBI.Click
        FilterResults()
    End Sub
    Private Sub chkGroupNUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroupNUT.Click
        FilterResults()
    End Sub
    Private Sub chkGroupOPE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroupOPE.Click
        FilterResults()
    End Sub
    Private Sub chkGroupOPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroupOPC.Click
        FilterResults()
    End Sub
    Private Sub chkGroupOOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroupOOT.Click
        FilterResults()
    End Sub
    Private Sub chkGroupPHY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroupPHY.Click
        FilterResults()
    End Sub
    Private Sub chkGroupPOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroupPOP.Click
        FilterResults()
    End Sub
    Private Sub chkGroupRAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroupRAD.Click
        FilterResults()
    End Sub
    Private Sub chkGroupSED_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroupSED.Click
        FilterResults()
    End Sub
    Private Sub chkGroupISO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroupISO.Click
        FilterResults()
    End Sub
    Private Sub chkGroupTOX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroupTOX.Click
        FilterResults()
    End Sub
    Private Sub chkGroupOTH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroupOTH.Click
        FilterResults()
    End Sub


    '--------------------------------------------------
    'btnGroupAll - CHECK ALL GROUPS BUTTON

    'btnGroupAll_Click
    Private Sub btnGroupAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGroupAll.Click
        'check all Group check boxes that are enabled
        If chkGroupBIO.Enabled Then chkGroupBIO.Checked = True
        If chkGroupHAB.Enabled Then chkGroupHAB.Checked = True
        If chkGroupINF.Enabled Then chkGroupINF.Checked = True
        If chkGroupIMM.Enabled Then chkGroupIMM.Checked = True
        If chkGroupIMN.Enabled Then chkGroupIMN.Checked = True
        If chkGroupINM.Enabled Then chkGroupINM.Checked = True
        If chkGroupINN.Enabled Then chkGroupINN.Checked = True
        If chkGroupMBI.Enabled Then chkGroupMBI.Checked = True
        If chkGroupNUT.Enabled Then chkGroupNUT.Checked = True
        If chkGroupOPE.Enabled Then chkGroupOPE.Checked = True
        If chkGroupOPC.Enabled Then chkGroupOPC.Checked = True
        If chkGroupOOT.Enabled Then chkGroupOOT.Checked = True
        If chkGroupPHY.Enabled Then chkGroupPHY.Checked = True
        If chkGroupPOP.Enabled Then chkGroupPOP.Checked = True
        If chkGroupRAD.Enabled Then chkGroupRAD.Checked = True
        If chkGroupSED.Enabled Then chkGroupSED.Checked = True
        If chkGroupISO.Enabled Then chkGroupISO.Checked = True
        If chkGroupTOX.Enabled Then chkGroupTOX.Checked = True
        If chkGroupOTH.Enabled Then chkGroupOTH.Checked = True

        'filter results with new setting
        FilterResults()

    End Sub


    '--------------------------------------------------
    'btnGroupNone - UNCHECK ALL GROUPS BUTTON

    'btnNoneGroup_Click
    Private Sub btnGroupNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGroupNone.Click
        'uncheck all Group check boxes
        chkGroupBIO.Checked = False
        chkGroupHAB.Checked = False
        chkGroupINF.Checked = False
        chkGroupIMM.Checked = False
        chkGroupIMN.Checked = False
        chkGroupINM.Checked = False
        chkGroupINN.Checked = False
        chkGroupMBI.Checked = False
        chkGroupNUT.Checked = False
        chkGroupOPE.Checked = False
        chkGroupOPC.Checked = False
        chkGroupOOT.Checked = False
        chkGroupPHY.Checked = False
        chkGroupPOP.Checked = False
        chkGroupRAD.Checked = False
        chkGroupSED.Checked = False
        chkGroupISO.Checked = False
        chkGroupTOX.Checked = False
        chkGroupOTH.Checked = False

        'filter results with new setting
        FilterResults()

    End Sub


    '--------------------------------------------------
    'txtSearch - SEARCH TEXTBOX

    'txtSearch_TextChanged
    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        UpdateForm()

    End Sub

    'txtSearch_KeyDown
    Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        'ENTER: do search if not SearchAsType
        If e.KeyCode = Keys.Enter AndAlso Not chkSearchAsTyping.Checked Then
            FilterResults()
            Exit Sub

        End If

    End Sub

    'txtSearch_KeyUp
    Private Sub txtSearch_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        'if SearchAsType checked, do search
        If chkSearchAsTyping.Checked Then
            FilterResults()
            Exit Sub

        End If

    End Sub


    '--------------------------------------------------
    'cboSearchType - SEARCH TYPE COMBO BOX

    'cboSearchType_SelectedIndexChanged
    Private Sub cboSearchType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSearchType.SelectedIndexChanged
        'seacrch again using new settings (the combobox value is queried for when searching)
        FilterResults()

    End Sub


    '--------------------------------------------------
    'chkSearchMatchCase - SEARCH MATCH CASE CHECKBOX

    'chkSearchMatchCase_MouseDown
    Private Sub chkSearchMatchCase_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSearchMatchCase.MouseDown
        'update search
        FilterResults()

    End Sub


    '--------------------------------------------------
    'btnSearch - SEARCH BUTTON

    'btnSearch_Click
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'update search
        FilterResults()

    End Sub


    '--------------------------------------------------
    'lstMatch - MATCHING PARAMTER LISTBOX

    'lstMatch_KeyDown
    Private Sub lstMatch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstMatch.KeyDown
        'handle keystroke events for matching listbox

        'CTRL+A: select all
        If e.KeyCode = Keys.A AndAlso e.Control = True Then
            'THERE DOES NOT SEEM TO BE A WAY TO DO THIS IN SINGLE OPERATION
            'THIS CAN TAKE A LONG TIME FOR LARGE (~20,000) LISTS
            'MAYBE COMMENT OUT THIS FUNCTIONALITY
            lstMatch.SelectionMode = SelectionMode.MultiSimple 'multi-extended conflicts with the CTRL+A keystroke
            EnableForm(False)
            lstMatch.BeginUpdate()
            For idx As Integer = 0 To lstMatch.Items.Count - 1
                If Not lstMatch.GetSelected(idx) Then lstMatch.SetSelected(idx, True)
            Next idx
            lstMatch.EndUpdate()
            EnableForm(True)
            UpdateForm()
            lstMatch.Focus()
            lstMatch.SelectionMode = SelectionMode.MultiExtended 'set back
            Exit Sub

        End If

        'ENTER: add selected
        If e.KeyCode = Keys.Enter Then
            'move selected items from lstMatch to lstFinal
            MoveMatchToFinal("SELECTED")
            Exit Sub
        End If

    End Sub

    'lstMatch_MouseClick
    Private Sub lstMatch_MouseClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstMatch.MouseClick
        UpdateForm()
    End Sub

    'lstMatch_MouseDoubleClick
    Private Sub lstMatch_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstMatch.MouseDoubleClick
        'move selected items from lstMatch to lstFinal
        MoveMatchToFinal("SELECTED")

    End Sub


    '--------------------------------------------------
    'btnMatchAddAll - ADD ALL MATCHING PARAMETER BUTTON

    'btnMatchAddAll_Click
    Private Sub btnMatchAddAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMatchAddAll.Click
        'move all items from lstMatch to lstFinal
        MoveMatchToFinal("ALL")

    End Sub

    '--------------------------------------------------
    'btnMatchAddSel - ADD SELECTED MATCHING PARAMETER BUTTON

    'btnMatchAddSel_Click
    Private Sub btnMatchAddSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMatchAddSel.Click
        'move selected items from lstMatch to lstFinal
        MoveMatchToFinal("SELECTED")

    End Sub


    '--------------------------------------------------
    'lstFinal - SELECTED PARAMETER LISTBOX

    'lstFinal_KeyDown
    Private Sub lstFinal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstFinal.KeyDown
        'handle keystroke events for matching listbox

        'CTRL+A: select all
        If e.KeyCode = Keys.A AndAlso e.Control = True Then
            'THERE DOES NOT SEEM TO BE A WAY TO DO THIS IN SINGLE OPERATION
            'THIS CAN TAKE A LONG TIME FOR LARGE (~20,000) LISTS
            'MAYBE COMMENT OUT THIS FUNCTIONALITY
            lstFinal.SelectionMode = SelectionMode.MultiSimple 'multi-extended conflicts with the CTRL+A keystroke
            EnableForm(False)
            lstFinal.BeginUpdate()
            For idx As Integer = 0 To lstFinal.Items.Count - 1
                If Not lstFinal.GetSelected(idx) Then lstFinal.SetSelected(idx, True)
            Next idx
            lstFinal.EndUpdate()
            EnableForm(True)
            UpdateForm()
            lstFinal.Focus()
            lstFinal.SelectionMode = SelectionMode.MultiExtended 'set back
            Exit Sub

        End If

        'ENTER: add selected
        If e.KeyCode = Keys.Enter Then
            'move selected items from lstFinal to lstMatch
            MoveFinalToMatch("SELECTED")
            Exit Sub
        End If

    End Sub

    'lstFinal_MouseClick
    Private Sub lstFinal_MouseClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFinal.MouseClick
        UpdateForm()
    End Sub

    'lstFinal_MouseDoubleClick
    Private Sub lstFinal_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstFinal.MouseDoubleClick
        'move selected items from lstFinal to lstFinal
        MoveFinalToMatch("SELECTED")

    End Sub


    '--------------------------------------------------
    'btnFinalRemALL - CLEAR SELECTED BUTTON

    'btnFinalRemALL_Click
    Private Sub btnFinalRemALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalRemALL.Click
        'move all items from lstFinal to lstMatch
        MoveFinalToMatch("ALL")

    End Sub


    '--------------------------------------------------
    'btnRemove - REMOVE SELECTED PARAMETER BUTTON

    'btnFinalRemSel_Click
    Private Sub btnFinalRemSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalRemSel.Click
        'move selected items from lstFinal to lstMatch
        MoveFinalToMatch("SELECTED")

    End Sub


    '--------------------------------------------------
    'btnAccept - ACCEPT SELECTION BUTTON

    'btnAccept_Click
    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        'get and set output:
        strQWPcodes = "" 'reset shared variable in module
        Dim strPcode As String
        Dim idx As Integer
        For idx = 0 To lstFinal.Items.Count - 1 'loop through and strip out pcode from list item string
            strPcode = lstFinal.Items(idx).ToString 'full list item: "XXXXXX (PCODE)"
            strPcode = strPcode.Substring(strPcode.Length - 6, 5) 'PCODE only
            strQWPcodes = strQWPcodes & strPcode & vbCrLf 'apend to output string separated by line feeds
        Next idx
        'MsgBox(strQWPcodes) 'test

        'close this form:
        Me.Close()

    End Sub


    '--------------------------------------------------
    'btnCancel - CANCEL

    'btnCancel_Click
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'set output empty:
        strQWPcodes = "" 'shared variable in module

        'close this form:
        Me.Close()

    End Sub


    '--------------------------------------------------
    'chkToolTipsOnOff

    'chkToolTipsOnOff_CheckedChanged
    Private Sub chkToolTipsOnOff_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkToolTipsOnOff.CheckedChanged
        'activate or deactivate tooltips based on chkHelpToolTips box
        If chkToolTipsOnOff.Checked Then 'turn on
            ToolTip1.Active = True
        Else
            ToolTip1.Active = False
        End If

    End Sub

    '--------------------------------------------------
    'lnkNWISWebPcodeList - NWISWEB LINK

    'lnkNWISWebPcodeList_LinkClicked
    Private Sub lnkNWISWebPcodeList_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkNWISWebPcodeList.LinkClicked
        'launch link in browser
        Try
            System.Diagnostics.Process.Start(link_NWISWebPcodeList)
        Catch ex As Exception
            MessageBox.Show( _
                "Sorry, cannot access the web page.", _
                "Web Page Not Accessible", _
                MessageBoxButtons.OK, _
                MessageBoxIcon.Information)
        End Try

    End Sub


    '--------------------------------------------------
    'btnDebug - DEBUG

    'btnDebug_Click
    Private Sub btnDebug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDebug.Click
        'MsgBox("Nothing to do in DEBUG sub...")

    End Sub


    '==================================================
    'HELPER SUBS

    'UpdateForm
    Private Sub UpdateForm()
        'update form and enable / disable controls based on Form state

        'if no items in seletion list...
        If lstMatch.Items.Count <= 0 Then
            'disable things needing list items:
            btnMatchAddAll.Enabled = False
        Else
            'enable things needing list items:
            btnMatchAddAll.Enabled = True
        End If

        'if no items selected in matching list...
        If lstMatch.SelectedItems.Count <= 0 Then
            'disable things needing list items selected:
            btnMatchAddSel.Enabled = False
        Else
            'enable things needing list items selected:
            btnMatchAddSel.Enabled = True
        End If

        'if no items in seletion list...
        If lstFinal.Items.Count <= 0 Then
            'disable things needing list items:
            btnFinalRemALL.Enabled = False
            btnAccept.Enabled = False
        Else
            'enable things needing list items:
            btnFinalRemALL.Enabled = True
            btnAccept.Enabled = True
        End If

        'if no items selected in seletion list...
        If lstFinal.SelectedItems.Count <= 0 Then
            'disable things needing list items selected:
            btnFinalRemSel.Enabled = False
        Else
            'enable things needing list items selected:
            btnFinalRemSel.Enabled = True
        End If

        'enable / disable Search button...
        If (chkGroupBIO.Checked = False AndAlso _
           chkGroupHAB.Checked = False AndAlso _
           chkGroupINF.Checked = False AndAlso _
           chkGroupIMM.Checked = False AndAlso _
           chkGroupIMN.Checked = False AndAlso _
           chkGroupINM.Checked = False AndAlso _
           chkGroupINN.Checked = False AndAlso _
           chkGroupMBI.Checked = False AndAlso _
           chkGroupNUT.Checked = False AndAlso _
           chkGroupOPE.Checked = False AndAlso _
           chkGroupOPC.Checked = False AndAlso _
           chkGroupOOT.Checked = False AndAlso _
           chkGroupPHY.Checked = False AndAlso _
           chkGroupPOP.Checked = False AndAlso _
           chkGroupRAD.Checked = False AndAlso _
           chkGroupSED.Checked = False AndAlso _
           chkGroupISO.Checked = False AndAlso _
           chkGroupTOX.Checked = False AndAlso _
           chkGroupOTH.Checked = False) _
           OrElse txtSearch.Text = "" Then
            'no Groups checked and no search string
            btnSearch.Enabled = False
            lstMatch.Items.Clear()
        Else
            btnSearch.Enabled = True
        End If

        'add counts to labels
        If lstMatch.Items.Count < intMaxListMatching Then 'all matches are shown
            lblMatching.Text = lstMatch.Items.Count.ToString & " Matching Parameters:"

        Else 'only 1st intNmatches (limit) are shown
            lblMatching.Text = intNmatches.ToString & " Matching Parameters (first " & intMaxListMatching.ToString & " shown):"

        End If
        lblSelection.Text = lstFinal.Items.Count.ToString & " Total Selected:"

    End Sub


    'MoveMatchToFinal
    Private Sub MoveMatchToFinal(ByVal strMode As String)
        'move items from lstMatch to lstFinal
        '  if strMode = "ALL", all items are moved
        '  if strMode = "SELECTED", only selected items are moved

        'make sure lstFinal is sorted - duplicate removal technique assumes this
        lstFinal.Sorted = True

        'make sure there are items to add
        If lstMatch.Items.Count <= 0 Then Exit Sub 'nothing to add

        EnableForm(False)
        lstMatch.BeginUpdate()
        lstFinal.BeginUpdate()
        Select Case strMode.ToUpper
            Case "ALL"
                lstFinal.Items.AddRange(lstMatch.Items) 'add all to Final
                lstMatch.Items.Clear() 'remove all from Match

            Case "SELECTED"
                Dim intListX As Integer
                For intListX = lstMatch.Items.Count - 1 To 0 Step -1
                    If lstMatch.GetSelected(intListX) Then
                        'add the selected item from the 1st list to the 2nd list
                        lstFinal.Items.Add(lstMatch.Items(intListX))

                        ''if using optional "ItemData" property array, add the following line to carry it through:
                        'lstFinal.ItemData(lstFinal.NewIndex) = lstMatch.ItemData(intListX)

                        'remove the selected Matching item from the 1st list
                        lstMatch.Items.RemoveAt(intListX)
                    End If
                Next

            Case Else
                MyFatalError("MoveMatchToFinal: 'strMode' is not specified correctly.")

        End Select

        'remove any duplicates in lstFinal
        Dim idx As Integer = 1
        Do While idx <= lstFinal.Items.Count - 1
            If lstFinal.Items(idx) Is lstFinal.Items(idx - 1) Then
                lstFinal.Items.RemoveAt(idx)
            Else
                idx = idx + 1
            End If
        Loop

        'clear highlighted
        lstMatch.ClearSelected()

        'enable and update form controls
        lstMatch.EndUpdate()
        lstFinal.EndUpdate()
        EnableForm(True)
        UpdateForm()

    End Sub


    'MoveFinalToMatch
    Private Sub MoveFinalToMatch(ByVal strMode As String)
        'move items from lstFinal to lstMatch
        '  if strMode = "ALL", all items are moved
        '  if strMode = "SELECTED", only selected items are moved

        'make sure lstFinal is sorted - duplicate removal technique assumes this
        lstMatch.Sorted = True

        'make sure there are items to add
        If lstFinal.Items.Count <= 0 Then Exit Sub 'nothing to add

        EnableForm(False)
        lstFinal.BeginUpdate()
        lstMatch.BeginUpdate()
        Select Case strMode.ToUpper
            Case "ALL"
                'verify action
                Dim intResult As Integer = MessageBox.Show("Move all selected parameters from the final selection?", _
                   "Clear Selected?", _
                   MessageBoxButtons.YesNo, _
                   MessageBoxIcon.Question, _
                   MessageBoxDefaultButton.Button2)
                If intResult = DialogResult.No Then Exit Sub

                lstMatch.Items.AddRange(lstFinal.Items) 'add all to Final
                lstFinal.Items.Clear() 'remove all from Match

            Case "SELECTED"
                Dim intListX As Integer
                For intListX = lstFinal.Items.Count - 1 To 0 Step -1
                    If lstFinal.GetSelected(intListX) Then
                        'add the selected item from the 1st list to the 2nd list
                        lstMatch.Items.Add(lstFinal.Items(intListX))

                        ''if using optional "ItemData" property array, add the following line to carry it through:
                        'lstMatch.ItemData(lstMatch.NewIndex) = lstFinal.ItemData(intListX)

                        'remove the selected items from the 1st list
                        lstFinal.Items.RemoveAt(intListX)
                    End If
                Next

            Case Else
                MyFatalError("MoveFinalToMatch: 'strMode' is not specified correctly.")

        End Select

        'remove any duplicates in lstFinal
        Dim idx As Integer = 1
        Do While idx <= lstMatch.Items.Count - 1
            If lstMatch.Items(idx) Is lstMatch.Items(idx - 1) Then
                lstMatch.Items.RemoveAt(idx)
            Else
                idx = idx + 1
            End If
        Loop

        'clear highlighted
        lstFinal.ClearSelected()

        'enable and update form controls
        lstFinal.EndUpdate()
        lstMatch.EndUpdate()
        EnableForm(True)
        UpdateForm()

    End Sub

    ''RemoveSelectedFromFinal
    'Private Sub RemoveSelectedFromFinal()
    '    'remove currently selected items from lstFinal

    '    'DOESN'T SEEM TO BE A NON-LOOPING WAY TO DO THIS,
    '    'BUT THIS IS NOT TOO BAD (JUST LOOPS THRU WHAT IS SELECTED)
    '    EnableForm(False)
    '    lstFinal.BeginUpdate()
    '    While lstFinal.SelectedItems.Count > 0
    '        lstFinal.Items.Remove(lstFinal.SelectedItems(0))
    '    End While
    '    lstFinal.EndUpdate()
    '    EnableForm(True)
    '    UpdateForm()

    'End Sub


    'FilterResults
    Private Sub FilterResults()
        'filter Pcodes based on Groups and Text options and display to the selected listbox

        'reset number of matches
        intNmatches = 0

        'clear the results listbox
        lstMatch.Items.Clear()

        'make sure have a search string entered
        If txtSearch.Text = "" Then Exit Sub

        'disable form
        EnableForm(False)

        'turn off listbox updating while adding
        lstMatch.BeginUpdate()

        'go through checked Groups, search for text in Group pcodes, and add to results listbox
        If chkGroupBIO.Checked Then SearchGroupAdd(strAry_BIO_PNAME)
        If chkGroupHAB.Checked Then SearchGroupAdd(strAry_HAB_PNAME)
        If chkGroupINF.Checked Then SearchGroupAdd(strAry_INF_PNAME)
        If chkGroupIMM.Checked Then SearchGroupAdd(strAry_IMM_PNAME)
        If chkGroupIMN.Checked Then SearchGroupAdd(strAry_IMN_PNAME)
        If chkGroupINM.Checked Then SearchGroupAdd(strAry_INM_PNAME)
        If chkGroupINN.Checked Then SearchGroupAdd(strAry_INN_PNAME)
        If chkGroupMBI.Checked Then SearchGroupAdd(strAry_MBI_PNAME)
        If chkGroupNUT.Checked Then SearchGroupAdd(strAry_NUT_PNAME)
        If chkGroupOPE.Checked Then SearchGroupAdd(strAry_OPE_PNAME)
        If chkGroupOPC.Checked Then SearchGroupAdd(strAry_OPC_PNAME)
        If chkGroupOOT.Checked Then SearchGroupAdd(strAry_OOT_PNAME)
        If chkGroupPHY.Checked Then SearchGroupAdd(strAry_PHY_PNAME)
        If chkGroupPOP.Checked Then SearchGroupAdd(strAry_POP_PNAME)
        If chkGroupRAD.Checked Then SearchGroupAdd(strAry_RAD_PNAME)
        If chkGroupSED.Checked Then SearchGroupAdd(strAry_SED_PNAME)
        If chkGroupISO.Checked Then SearchGroupAdd(strAry_ISO_PNAME)
        If chkGroupTOX.Checked Then SearchGroupAdd(strAry_TOX_PNAME)
        If chkGroupOTH.Checked Then SearchGroupAdd(strAry_OTH_PNAME)

        'turn updating back on
        lstMatch.EndUpdate()
        EnableForm(True)
        UpdateForm()
    End Sub


    'SearchGroupAdd
    Private Sub SearchGroupAdd(ByRef strAry_PNAME As Array)
        'search a parameters in string array "strAry_PNAME" for the current search string using current options

        'see if any pcodes assigned to strAry_PNAME
        If strAry_PNAME Is Nothing Then Exit Sub

        'get the search string
        Dim substr As String = txtSearch.Text
        If substr = "" Then Exit Sub 'no search string


        'define and compile regular expression based on search options
        Dim SearchType As String = cboSearchType.SelectedItem.ToString
        Dim MatchCase As Boolean = chkSearchMatchCase.Checked
        Dim myRegex As System.Text.RegularExpressions.Regex = Nothing

        'need to put Regex definitions in try-catch becuase can be a syntax error depending on the search string.
        'eg: search string contains special Regex characters that result in a Regex error.
        'in these cases bail with out doing anything.
        'special Regex characters normally shouldn't be searched for, and the seach results have aleady been cleared before this Sub is called.
        If SearchType = "Starts with" AndAlso MatchCase Then
            Try
                myRegex = New System.Text.RegularExpressions.Regex( _
                       "^" & substr, _
                       System.Text.RegularExpressions.RegexOptions.Compiled _
                       )
            Catch
                Exit Sub
            End Try
        ElseIf SearchType = "Starts with" AndAlso Not MatchCase Then
            Try
                myRegex = New System.Text.RegularExpressions.Regex( _
                            "^" & substr, _
                            System.Text.RegularExpressions.RegexOptions.IgnoreCase Or System.Text.RegularExpressions.RegexOptions.Compiled _
                            )
            Catch
                Exit Sub
            End Try
        ElseIf SearchType = "Contains anywhere" AndAlso MatchCase Then
            Try
                myRegex = New System.Text.RegularExpressions.Regex( _
                       substr, _
                       System.Text.RegularExpressions.RegexOptions.Compiled _
                       )
            Catch
                Exit Sub
            End Try
        ElseIf SearchType = "Contains anywhere" AndAlso Not MatchCase Then
            Try
                myRegex = New System.Text.RegularExpressions.Regex( _
                       substr, _
                       System.Text.RegularExpressions.RegexOptions.IgnoreCase Or System.Text.RegularExpressions.RegexOptions.Compiled _
                       )
            Catch
                Exit Sub
            End Try
        ElseIf SearchType = "Contains as complete word" AndAlso MatchCase Then
            Try
                myRegex = New System.Text.RegularExpressions.Regex( _
                        "\b" & substr & "\b", _
                        System.Text.RegularExpressions.RegexOptions.Compiled _
                        )
            Catch
                Exit Sub
            End Try
        ElseIf SearchType = "Contains as complete word" AndAlso Not MatchCase Then
            Try
                myRegex = New System.Text.RegularExpressions.Regex( _
                        "\b" & substr & "\b", _
                        System.Text.RegularExpressions.RegexOptions.IgnoreCase Or System.Text.RegularExpressions.RegexOptions.Compiled _
                        )
            Catch
                Exit Sub
            End Try
        Else
            MyFatalError("SearchGroupAdd: Unrecognized search method.")

        End If

        'loop through and look for matches
        For Each pname As String In strAry_PNAME
            If myRegex.IsMatch(pname) Then 'found a match
                intNmatches = intNmatches + 1
                'add to listbox only if # found less than max listbox setting
                If lstMatch.Items.Count < intMaxListMatching Then lstMatch.Items.Add(pname)

            End If
        Next pname

    End Sub


    'EnableForm
    Private Sub EnableForm(ByVal trueFalse As Boolean)
        'activate this if want to disable form before potentially lengthy procedures [ EnableForm(False) ]
        'then re-enable after done [ EnableForm(True) ]
        Exit Sub '!!! this sub turned off

        'set all control enable settings to trueFalse
        For Each ctrl As Control In Me.Controls
            ctrl.Enabled = trueFalse
        Next

        'if enabling, update the form so controls are disabled as needed
        If trueFalse Then 'enabling
            'give the active control focus
            Me.ActiveControl.Focus()

            'set default mouse cursor
            Me.Cursor = Cursors.Default
        Else 'disabling
            'set wait mouse cursor
            Me.Cursor = Cursors.AppStarting

        End If

    End Sub


    'MyFatalError
    Private Sub MyFatalError(ByVal msgStr As String)
        'throw an error message with the message msgStr and close this form.
        'MAYBE PUT THIS IN A SHARED CLASS FOR CONSISTENT USAGE ACROSS ALL snapshot COMPONENTS
        MessageBox.Show( _
           msgStr & vbCrLf & vbCrLf & "Closing window.", _
           "Unexpected Error", _
           MessageBoxButtons.OK, _
           MessageBoxIcon.Error)
        Me.Close()
    End Sub

End Class
