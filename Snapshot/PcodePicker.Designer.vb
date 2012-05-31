<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPcodePicker
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
        Me.components = New System.ComponentModel.Container()
        Me.lblGroup = New System.Windows.Forms.Label()
        Me.btnDebug = New System.Windows.Forms.Button()
        Me.btnGroupAll = New System.Windows.Forms.Button()
        Me.btnGroupNone = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lstMatch = New System.Windows.Forms.ListBox()
        Me.lnkNWISWebPcodeList = New System.Windows.Forms.LinkLabel()
        Me.lblNWISWebPcodeList = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblMatching = New System.Windows.Forms.Label()
        Me.lstFinal = New System.Windows.Forms.ListBox()
        Me.lblSelection = New System.Windows.Forms.Label()
        Me.btnMatchAddSel = New System.Windows.Forms.Button()
        Me.btnFinalRemSel = New System.Windows.Forms.Button()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnFinalRemALL = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnMatchAddAll = New System.Windows.Forms.Button()
        Me.cboSearchType = New System.Windows.Forms.ComboBox()
        Me.chkSearchAsTyping = New System.Windows.Forms.CheckBox()
        Me.lblSearchType = New System.Windows.Forms.Label()
        Me.chkSearchMatchCase = New System.Windows.Forms.CheckBox()
        Me.chkToolTipsOnOff = New System.Windows.Forms.CheckBox()
        Me.chkGroupBIO = New System.Windows.Forms.CheckBox()
        Me.chkGroupHAB = New System.Windows.Forms.CheckBox()
        Me.chkGroupINF = New System.Windows.Forms.CheckBox()
        Me.chkGroupIMM = New System.Windows.Forms.CheckBox()
        Me.chkGroupIMN = New System.Windows.Forms.CheckBox()
        Me.chkGroupMBI = New System.Windows.Forms.CheckBox()
        Me.chkGroupNUT = New System.Windows.Forms.CheckBox()
        Me.chkGroupOPE = New System.Windows.Forms.CheckBox()
        Me.chkGroupOPC = New System.Windows.Forms.CheckBox()
        Me.chkGroupOOT = New System.Windows.Forms.CheckBox()
        Me.chkGroupPHY = New System.Windows.Forms.CheckBox()
        Me.chkGroupPOP = New System.Windows.Forms.CheckBox()
        Me.chkGroupRAD = New System.Windows.Forms.CheckBox()
        Me.chkGroupSED = New System.Windows.Forms.CheckBox()
        Me.chkGroupISO = New System.Windows.Forms.CheckBox()
        Me.chkGroupTOX = New System.Windows.Forms.CheckBox()
        Me.chkGroupOTH = New System.Windows.Forms.CheckBox()
        Me.chkGroupINM = New System.Windows.Forms.CheckBox()
        Me.chkGroupINN = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Location = New System.Drawing.Point(12, 62)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(134, 13)
        Me.lblGroup.TabIndex = 1
        Me.lblGroup.Text = "Choose Parameter Groups:"
        '
        'btnDebug
        '
        Me.btnDebug.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebug.ForeColor = System.Drawing.Color.Red
        Me.btnDebug.Location = New System.Drawing.Point(687, 29)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(88, 23)
        Me.btnDebug.TabIndex = 16
        Me.btnDebug.TabStop = False
        Me.btnDebug.Text = "DEBUG"
        Me.btnDebug.UseVisualStyleBackColor = True
        '
        'btnGroupAll
        '
        Me.btnGroupAll.Location = New System.Drawing.Point(12, 422)
        Me.btnGroupAll.Name = "btnGroupAll"
        Me.btnGroupAll.Size = New System.Drawing.Size(88, 23)
        Me.btnGroupAll.TabIndex = 2
        Me.btnGroupAll.TabStop = False
        Me.btnGroupAll.Text = "All"
        Me.btnGroupAll.UseVisualStyleBackColor = True
        '
        'btnGroupNone
        '
        Me.btnGroupNone.Location = New System.Drawing.Point(106, 422)
        Me.btnGroupNone.Name = "btnGroupNone"
        Me.btnGroupNone.Size = New System.Drawing.Size(88, 23)
        Me.btnGroupNone.TabIndex = 3
        Me.btnGroupNone.TabStop = False
        Me.btnGroupNone.Text = "Clear"
        Me.btnGroupNone.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(230, 32)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(354, 20)
        Me.txtSearch.TabIndex = 4
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(227, 11)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(96, 13)
        Me.lblSearch.TabIndex = 6
        Me.lblSearch.Text = "Enter Search Text:"
        '
        'lstMatch
        '
        Me.lstMatch.FormattingEnabled = True
        Me.lstMatch.HorizontalScrollbar = True
        Me.lstMatch.Items.AddRange(New Object() {"listMatching"})
        Me.lstMatch.Location = New System.Drawing.Point(230, 80)
        Me.lstMatch.Name = "lstMatch"
        Me.lstMatch.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstMatch.Size = New System.Drawing.Size(354, 342)
        Me.lstMatch.Sorted = True
        Me.lstMatch.TabIndex = 7
        Me.lstMatch.TabStop = False
        '
        'lnkNWISWebPcodeList
        '
        Me.lnkNWISWebPcodeList.AutoSize = True
        Me.lnkNWISWebPcodeList.Location = New System.Drawing.Point(734, 429)
        Me.lnkNWISWebPcodeList.Name = "lnkNWISWebPcodeList"
        Me.lnkNWISWebPcodeList.Size = New System.Drawing.Size(251, 13)
        Me.lnkNWISWebPcodeList.TabIndex = 15
        Me.lnkNWISWebPcodeList.TabStop = True
        Me.lnkNWISWebPcodeList.Text = "http://nwis.waterdata.usgs.gov/usa/nwis/pmcodes"
        Me.lnkNWISWebPcodeList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNWISWebPcodeList
        '
        Me.lblNWISWebPcodeList.AutoSize = True
        Me.lblNWISWebPcodeList.Location = New System.Drawing.Point(493, 429)
        Me.lblNWISWebPcodeList.Name = "lblNWISWebPcodeList"
        Me.lblNWISWebPcodeList.Size = New System.Drawing.Size(227, 13)
        Me.lblNWISWebPcodeList.TabIndex = 9
        Me.lblNWISWebPcodeList.Text = "Visit NWISWeb Parameter Code Definitions at:"
        Me.lblNWISWebPcodeList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMatching
        '
        Me.lblMatching.AutoSize = True
        Me.lblMatching.Location = New System.Drawing.Point(227, 62)
        Me.lblMatching.Name = "lblMatching"
        Me.lblMatching.Size = New System.Drawing.Size(110, 13)
        Me.lblMatching.TabIndex = 10
        Me.lblMatching.Text = "Matching Parameters:"
        '
        'lstFinal
        '
        Me.lstFinal.ForeColor = System.Drawing.Color.Teal
        Me.lstFinal.FormattingEnabled = True
        Me.lstFinal.HorizontalScrollbar = True
        Me.lstFinal.Location = New System.Drawing.Point(631, 80)
        Me.lstFinal.Name = "lstFinal"
        Me.lstFinal.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstFinal.Size = New System.Drawing.Size(354, 342)
        Me.lstFinal.Sorted = True
        Me.lstFinal.TabIndex = 10
        Me.lstFinal.TabStop = False
        '
        'lblSelection
        '
        Me.lblSelection.AutoSize = True
        Me.lblSelection.Location = New System.Drawing.Point(628, 62)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.Size = New System.Drawing.Size(79, 13)
        Me.lblSelection.TabIndex = 12
        Me.lblSelection.Text = "Total Selected:"
        '
        'btnMatchAddSel
        '
        Me.btnMatchAddSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMatchAddSel.Location = New System.Drawing.Point(590, 126)
        Me.btnMatchAddSel.Name = "btnMatchAddSel"
        Me.btnMatchAddSel.Size = New System.Drawing.Size(35, 38)
        Me.btnMatchAddSel.TabIndex = 9
        Me.btnMatchAddSel.TabStop = False
        Me.btnMatchAddSel.Text = ">"
        Me.btnMatchAddSel.UseVisualStyleBackColor = True
        '
        'btnFinalRemSel
        '
        Me.btnFinalRemSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalRemSel.Location = New System.Drawing.Point(590, 289)
        Me.btnFinalRemSel.Name = "btnFinalRemSel"
        Me.btnFinalRemSel.Size = New System.Drawing.Size(35, 38)
        Me.btnFinalRemSel.TabIndex = 12
        Me.btnFinalRemSel.TabStop = False
        Me.btnFinalRemSel.Text = "<"
        Me.btnFinalRemSel.UseVisualStyleBackColor = True
        '
        'btnAccept
        '
        Me.btnAccept.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccept.ForeColor = System.Drawing.Color.Teal
        Me.btnAccept.Location = New System.Drawing.Point(803, 29)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(88, 23)
        Me.btnAccept.TabIndex = 13
        Me.btnAccept.Text = "OK"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnFinalRemALL
        '
        Me.btnFinalRemALL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalRemALL.ForeColor = System.Drawing.Color.Black
        Me.btnFinalRemALL.Location = New System.Drawing.Point(590, 333)
        Me.btnFinalRemALL.Name = "btnFinalRemALL"
        Me.btnFinalRemALL.Size = New System.Drawing.Size(35, 38)
        Me.btnFinalRemALL.TabIndex = 11
        Me.btnFinalRemALL.TabStop = False
        Me.btnFinalRemALL.Text = "<<"
        Me.btnFinalRemALL.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(593, 29)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(88, 23)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(897, 29)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 23)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnMatchAddAll
        '
        Me.btnMatchAddAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMatchAddAll.ForeColor = System.Drawing.Color.Black
        Me.btnMatchAddAll.Location = New System.Drawing.Point(590, 170)
        Me.btnMatchAddAll.Name = "btnMatchAddAll"
        Me.btnMatchAddAll.Size = New System.Drawing.Size(35, 38)
        Me.btnMatchAddAll.TabIndex = 8
        Me.btnMatchAddAll.TabStop = False
        Me.btnMatchAddAll.Text = ">>"
        Me.btnMatchAddAll.UseVisualStyleBackColor = True
        '
        'cboSearchType
        '
        Me.cboSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearchType.FormattingEnabled = True
        Me.cboSearchType.Items.AddRange(New Object() {"Contains as complete word", "Starts with", "Contains anywhere"})
        Me.cboSearchType.Location = New System.Drawing.Point(12, 31)
        Me.cboSearchType.Name = "cboSearchType"
        Me.cboSearchType.Size = New System.Drawing.Size(182, 21)
        Me.cboSearchType.TabIndex = 5
        '
        'chkSearchAsTyping
        '
        Me.chkSearchAsTyping.AutoSize = True
        Me.chkSearchAsTyping.Checked = True
        Me.chkSearchAsTyping.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSearchAsTyping.Location = New System.Drawing.Point(441, 11)
        Me.chkSearchAsTyping.Name = "chkSearchAsTyping"
        Me.chkSearchAsTyping.Size = New System.Drawing.Size(158, 17)
        Me.chkSearchAsTyping.TabIndex = 26
        Me.chkSearchAsTyping.Text = "Search with each keystroke"
        Me.chkSearchAsTyping.UseVisualStyleBackColor = True
        '
        'lblSearchType
        '
        Me.lblSearchType.AutoSize = True
        Me.lblSearchType.Location = New System.Drawing.Point(12, 11)
        Me.lblSearchType.Name = "lblSearchType"
        Me.lblSearchType.Size = New System.Drawing.Size(71, 13)
        Me.lblSearchType.TabIndex = 27
        Me.lblSearchType.Text = "Search Type:"
        '
        'chkSearchMatchCase
        '
        Me.chkSearchMatchCase.AutoSize = True
        Me.chkSearchMatchCase.Location = New System.Drawing.Point(341, 11)
        Me.chkSearchMatchCase.Name = "chkSearchMatchCase"
        Me.chkSearchMatchCase.Size = New System.Drawing.Size(94, 17)
        Me.chkSearchMatchCase.TabIndex = 29
        Me.chkSearchMatchCase.Text = "Case sensitive"
        Me.chkSearchMatchCase.UseVisualStyleBackColor = True
        '
        'chkToolTipsOnOff
        '
        Me.chkToolTipsOnOff.AutoSize = True
        Me.chkToolTipsOnOff.Location = New System.Drawing.Point(230, 428)
        Me.chkToolTipsOnOff.Name = "chkToolTipsOnOff"
        Me.chkToolTipsOnOff.Size = New System.Drawing.Size(100, 17)
        Me.chkToolTipsOnOff.TabIndex = 30
        Me.chkToolTipsOnOff.Text = "Show Tool Tips"
        Me.chkToolTipsOnOff.UseVisualStyleBackColor = True
        '
        'chkGroupBIO
        '
        Me.chkGroupBIO.AutoSize = True
        Me.chkGroupBIO.Location = New System.Drawing.Point(12, 80)
        Me.chkGroupBIO.Name = "chkGroupBIO"
        Me.chkGroupBIO.Size = New System.Drawing.Size(71, 17)
        Me.chkGroupBIO.TabIndex = 31
        Me.chkGroupBIO.Text = "Biological"
        Me.chkGroupBIO.UseVisualStyleBackColor = True
        '
        'chkGroupHAB
        '
        Me.chkGroupHAB.AutoSize = True
        Me.chkGroupHAB.Location = New System.Drawing.Point(12, 97)
        Me.chkGroupHAB.Name = "chkGroupHAB"
        Me.chkGroupHAB.Size = New System.Drawing.Size(60, 17)
        Me.chkGroupHAB.TabIndex = 32
        Me.chkGroupHAB.Text = "Habitat"
        Me.chkGroupHAB.UseVisualStyleBackColor = True
        '
        'chkGroupINF
        '
        Me.chkGroupINF.AutoSize = True
        Me.chkGroupINF.Location = New System.Drawing.Point(12, 114)
        Me.chkGroupINF.Name = "chkGroupINF"
        Me.chkGroupINF.Size = New System.Drawing.Size(78, 17)
        Me.chkGroupINF.TabIndex = 33
        Me.chkGroupINF.Text = "Information"
        Me.chkGroupINF.UseVisualStyleBackColor = True
        '
        'chkGroupIMM
        '
        Me.chkGroupIMM.AutoSize = True
        Me.chkGroupIMM.Location = New System.Drawing.Point(12, 131)
        Me.chkGroupIMM.Name = "chkGroupIMM"
        Me.chkGroupIMM.Size = New System.Drawing.Size(141, 17)
        Me.chkGroupIMM.TabIndex = 34
        Me.chkGroupIMM.Text = "Inorganics, Major Metals"
        Me.chkGroupIMM.UseVisualStyleBackColor = True
        '
        'chkGroupIMN
        '
        Me.chkGroupIMN.AutoSize = True
        Me.chkGroupIMN.Location = New System.Drawing.Point(12, 148)
        Me.chkGroupIMN.Name = "chkGroupIMN"
        Me.chkGroupIMN.Size = New System.Drawing.Size(164, 17)
        Me.chkGroupIMN.TabIndex = 35
        Me.chkGroupIMN.Text = "Inorganics, Major Non-Metals"
        Me.chkGroupIMN.UseVisualStyleBackColor = True
        '
        'chkGroupMBI
        '
        Me.chkGroupMBI.AutoSize = True
        Me.chkGroupMBI.Location = New System.Drawing.Point(12, 199)
        Me.chkGroupMBI.Name = "chkGroupMBI"
        Me.chkGroupMBI.Size = New System.Drawing.Size(96, 17)
        Me.chkGroupMBI.TabIndex = 36
        Me.chkGroupMBI.Text = "Microbiological"
        Me.chkGroupMBI.UseVisualStyleBackColor = True
        '
        'chkGroupNUT
        '
        Me.chkGroupNUT.AutoSize = True
        Me.chkGroupNUT.Location = New System.Drawing.Point(12, 216)
        Me.chkGroupNUT.Name = "chkGroupNUT"
        Me.chkGroupNUT.Size = New System.Drawing.Size(63, 17)
        Me.chkGroupNUT.TabIndex = 37
        Me.chkGroupNUT.Text = "Nutrient"
        Me.chkGroupNUT.UseVisualStyleBackColor = True
        '
        'chkGroupOPE
        '
        Me.chkGroupOPE.AutoSize = True
        Me.chkGroupOPE.Location = New System.Drawing.Point(12, 233)
        Me.chkGroupOPE.Name = "chkGroupOPE"
        Me.chkGroupOPE.Size = New System.Drawing.Size(117, 17)
        Me.chkGroupOPE.TabIndex = 38
        Me.chkGroupOPE.Text = "Organics, Pesticide"
        Me.chkGroupOPE.UseVisualStyleBackColor = True
        '
        'chkGroupOPC
        '
        Me.chkGroupOPC.AutoSize = True
        Me.chkGroupOPC.Location = New System.Drawing.Point(12, 250)
        Me.chkGroupOPC.Name = "chkGroupOPC"
        Me.chkGroupOPC.Size = New System.Drawing.Size(100, 17)
        Me.chkGroupOPC.TabIndex = 39
        Me.chkGroupOPC.Text = "Organics, PCBs"
        Me.chkGroupOPC.UseVisualStyleBackColor = True
        '
        'chkGroupOOT
        '
        Me.chkGroupOOT.AutoSize = True
        Me.chkGroupOOT.Location = New System.Drawing.Point(12, 267)
        Me.chkGroupOOT.Name = "chkGroupOOT"
        Me.chkGroupOOT.Size = New System.Drawing.Size(100, 17)
        Me.chkGroupOOT.TabIndex = 40
        Me.chkGroupOOT.Text = "Organics, Other"
        Me.chkGroupOOT.UseVisualStyleBackColor = True
        '
        'chkGroupPHY
        '
        Me.chkGroupPHY.AutoSize = True
        Me.chkGroupPHY.Location = New System.Drawing.Point(12, 284)
        Me.chkGroupPHY.Name = "chkGroupPHY"
        Me.chkGroupPHY.Size = New System.Drawing.Size(65, 17)
        Me.chkGroupPHY.TabIndex = 41
        Me.chkGroupPHY.Text = "Physical"
        Me.chkGroupPHY.UseVisualStyleBackColor = True
        '
        'chkGroupPOP
        '
        Me.chkGroupPOP.AutoSize = True
        Me.chkGroupPOP.Location = New System.Drawing.Point(12, 301)
        Me.chkGroupPOP.Name = "chkGroupPOP"
        Me.chkGroupPOP.Size = New System.Drawing.Size(138, 17)
        Me.chkGroupPOP.TabIndex = 42
        Me.chkGroupPOP.Text = "Population / Community"
        Me.chkGroupPOP.UseVisualStyleBackColor = True
        '
        'chkGroupRAD
        '
        Me.chkGroupRAD.AutoSize = True
        Me.chkGroupRAD.Location = New System.Drawing.Point(12, 318)
        Me.chkGroupRAD.Name = "chkGroupRAD"
        Me.chkGroupRAD.Size = New System.Drawing.Size(96, 17)
        Me.chkGroupRAD.TabIndex = 43
        Me.chkGroupRAD.Text = "Radiochemical"
        Me.chkGroupRAD.UseVisualStyleBackColor = True
        '
        'chkGroupSED
        '
        Me.chkGroupSED.AutoSize = True
        Me.chkGroupSED.Location = New System.Drawing.Point(12, 335)
        Me.chkGroupSED.Name = "chkGroupSED"
        Me.chkGroupSED.Size = New System.Drawing.Size(70, 17)
        Me.chkGroupSED.TabIndex = 44
        Me.chkGroupSED.Text = "Sediment"
        Me.chkGroupSED.UseVisualStyleBackColor = True
        '
        'chkGroupISO
        '
        Me.chkGroupISO.AutoSize = True
        Me.chkGroupISO.Location = New System.Drawing.Point(12, 352)
        Me.chkGroupISO.Name = "chkGroupISO"
        Me.chkGroupISO.Size = New System.Drawing.Size(99, 17)
        Me.chkGroupISO.TabIndex = 45
        Me.chkGroupISO.Text = "Stable Isotopes"
        Me.chkGroupISO.UseVisualStyleBackColor = True
        '
        'chkGroupTOX
        '
        Me.chkGroupTOX.AutoSize = True
        Me.chkGroupTOX.Location = New System.Drawing.Point(12, 369)
        Me.chkGroupTOX.Name = "chkGroupTOX"
        Me.chkGroupTOX.Size = New System.Drawing.Size(62, 17)
        Me.chkGroupTOX.TabIndex = 46
        Me.chkGroupTOX.Text = "Toxicity"
        Me.chkGroupTOX.UseVisualStyleBackColor = True
        '
        'chkGroupOTH
        '
        Me.chkGroupOTH.AutoSize = True
        Me.chkGroupOTH.Location = New System.Drawing.Point(12, 386)
        Me.chkGroupOTH.Name = "chkGroupOTH"
        Me.chkGroupOTH.Size = New System.Drawing.Size(52, 17)
        Me.chkGroupOTH.TabIndex = 47
        Me.chkGroupOTH.Text = "Other"
        Me.chkGroupOTH.UseVisualStyleBackColor = True
        '
        'chkGroupINM
        '
        Me.chkGroupINM.AutoSize = True
        Me.chkGroupINM.Location = New System.Drawing.Point(12, 165)
        Me.chkGroupINM.Name = "chkGroupINM"
        Me.chkGroupINM.Size = New System.Drawing.Size(141, 17)
        Me.chkGroupINM.TabIndex = 48
        Me.chkGroupINM.Text = "Inorganics, Minor Metals"
        Me.chkGroupINM.UseVisualStyleBackColor = True
        '
        'chkGroupINN
        '
        Me.chkGroupINN.AutoSize = True
        Me.chkGroupINN.Location = New System.Drawing.Point(12, 182)
        Me.chkGroupINN.Name = "chkGroupINN"
        Me.chkGroupINN.Size = New System.Drawing.Size(164, 17)
        Me.chkGroupINN.TabIndex = 49
        Me.chkGroupINN.Text = "Inorganics, Minor Non-Metals"
        Me.chkGroupINN.UseVisualStyleBackColor = True
        '
        'frmPcodePicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 453)
        Me.Controls.Add(Me.chkGroupINN)
        Me.Controls.Add(Me.chkGroupINM)
        Me.Controls.Add(Me.chkGroupOTH)
        Me.Controls.Add(Me.chkGroupTOX)
        Me.Controls.Add(Me.chkGroupISO)
        Me.Controls.Add(Me.chkGroupSED)
        Me.Controls.Add(Me.chkGroupRAD)
        Me.Controls.Add(Me.chkGroupPOP)
        Me.Controls.Add(Me.chkGroupPHY)
        Me.Controls.Add(Me.chkGroupOOT)
        Me.Controls.Add(Me.chkGroupOPC)
        Me.Controls.Add(Me.chkGroupOPE)
        Me.Controls.Add(Me.chkGroupNUT)
        Me.Controls.Add(Me.chkGroupMBI)
        Me.Controls.Add(Me.chkGroupIMN)
        Me.Controls.Add(Me.chkGroupIMM)
        Me.Controls.Add(Me.chkGroupINF)
        Me.Controls.Add(Me.chkGroupHAB)
        Me.Controls.Add(Me.chkGroupBIO)
        Me.Controls.Add(Me.chkToolTipsOnOff)
        Me.Controls.Add(Me.chkSearchMatchCase)
        Me.Controls.Add(Me.lblSearchType)
        Me.Controls.Add(Me.chkSearchAsTyping)
        Me.Controls.Add(Me.cboSearchType)
        Me.Controls.Add(Me.btnMatchAddAll)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnFinalRemALL)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.btnFinalRemSel)
        Me.Controls.Add(Me.btnMatchAddSel)
        Me.Controls.Add(Me.lblSelection)
        Me.Controls.Add(Me.lstFinal)
        Me.Controls.Add(Me.lblMatching)
        Me.Controls.Add(Me.lblNWISWebPcodeList)
        Me.Controls.Add(Me.lnkNWISWebPcodeList)
        Me.Controls.Add(Me.lstMatch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnGroupNone)
        Me.Controls.Add(Me.btnGroupAll)
        Me.Controls.Add(Me.btnDebug)
        Me.Controls.Add(Me.lblGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmPcodePicker"
        Me.Text = "Parameter Code Picker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGroup As System.Windows.Forms.Label
    Friend WithEvents btnDebug As System.Windows.Forms.Button
    Friend WithEvents btnGroupAll As System.Windows.Forms.Button
    Friend WithEvents btnGroupNone As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents lstMatch As System.Windows.Forms.ListBox
    Friend WithEvents lnkNWISWebPcodeList As System.Windows.Forms.LinkLabel
    Friend WithEvents lblNWISWebPcodeList As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblMatching As System.Windows.Forms.Label
    Friend WithEvents lstFinal As System.Windows.Forms.ListBox
    Friend WithEvents lblSelection As System.Windows.Forms.Label
    Friend WithEvents btnMatchAddSel As System.Windows.Forms.Button
    Friend WithEvents btnFinalRemSel As System.Windows.Forms.Button
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents btnFinalRemALL As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnMatchAddAll As System.Windows.Forms.Button
    Friend WithEvents cboSearchType As System.Windows.Forms.ComboBox
    Friend WithEvents chkSearchAsTyping As System.Windows.Forms.CheckBox
    Friend WithEvents lblSearchType As System.Windows.Forms.Label
    Friend WithEvents chkSearchMatchCase As System.Windows.Forms.CheckBox
    Friend WithEvents chkToolTipsOnOff As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroupBIO As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroupHAB As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroupINF As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroupIMM As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroupIMN As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroupMBI As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroupNUT As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroupOPE As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroupOPC As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroupOOT As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroupPHY As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroupPOP As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroupRAD As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroupSED As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroupISO As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroupTOX As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroupOTH As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroupINM As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroupINN As System.Windows.Forms.CheckBox

End Class
