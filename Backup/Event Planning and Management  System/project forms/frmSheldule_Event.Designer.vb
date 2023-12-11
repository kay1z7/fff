<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSheldule_Event
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnPayment = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnAddNew = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtFulname = New System.Windows.Forms.TextBox
        Me.cboCustomer_code = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCostFees = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboServiceType = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtpDeparturee = New System.Windows.Forms.DateTimePicker
        Me.dtpArrival = New System.Windows.Forms.DateTimePicker
        Me.cboEventType = New System.Windows.Forms.ComboBox
        Me.dtpEventTime = New System.Windows.Forms.DateTimePicker
        Me.txtVenue = New System.Windows.Forms.TextBox
        Me.dtpEventEnd = New System.Windows.Forms.DateTimePicker
        Me.dtpEventStart = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EventTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddNewEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddNewServTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GenerateReceiptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EventFeesPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblSheduledid = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblEventid = New System.Windows.Forms.Label
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 475)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(649, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel1.Text = "Ready"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnPayment)
        Me.GroupBox3.Controls.Add(Me.btnUpdate)
        Me.GroupBox3.Controls.Add(Me.btnDelete)
        Me.GroupBox3.Controls.Add(Me.btnSave)
        Me.GroupBox3.Controls.Add(Me.btnAddNew)
        Me.GroupBox3.Location = New System.Drawing.Point(536, 83)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(101, 314)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'btnPayment
        '
        Me.btnPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.Location = New System.Drawing.Point(13, 257)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(73, 31)
        Me.btnPayment.TabIndex = 4
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(13, 202)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(73, 31)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(13, 147)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(73, 31)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(13, 92)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(73, 31)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.Location = New System.Drawing.Point(13, 37)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(73, 31)
        Me.btnAddNew.TabIndex = 0
        Me.btnAddNew.Text = "Add &New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(530, 382)
        Me.Panel1.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtFulname)
        Me.GroupBox2.Controls.Add(Me.cboCustomer_code)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(405, 105)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer/Client info..."
        '
        'txtFulname
        '
        Me.txtFulname.Location = New System.Drawing.Point(112, 65)
        Me.txtFulname.Name = "txtFulname"
        Me.txtFulname.Size = New System.Drawing.Size(223, 20)
        Me.txtFulname.TabIndex = 3
        '
        'cboCustomer_code
        '
        Me.cboCustomer_code.FormattingEnabled = True
        Me.cboCustomer_code.Location = New System.Drawing.Point(112, 27)
        Me.cboCustomer_code.Name = "cboCustomer_code"
        Me.cboCustomer_code.Size = New System.Drawing.Size(121, 21)
        Me.cboCustomer_code.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer FulName:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Code:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCostFees)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cboServiceType)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.dtpDeparturee)
        Me.GroupBox1.Controls.Add(Me.dtpArrival)
        Me.GroupBox1.Controls.Add(Me.cboEventType)
        Me.GroupBox1.Controls.Add(Me.dtpEventTime)
        Me.GroupBox1.Controls.Add(Me.txtVenue)
        Me.GroupBox1.Controls.Add(Me.dtpEventEnd)
        Me.GroupBox1.Controls.Add(Me.dtpEventStart)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 232)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sheldule Event......"
        '
        'txtCostFees
        '
        Me.txtCostFees.Location = New System.Drawing.Point(298, 137)
        Me.txtCostFees.Name = "txtCostFees"
        Me.txtCostFees.Size = New System.Drawing.Size(107, 20)
        Me.txtCostFees.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(223, 142)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Cost/Fees:"
        '
        'cboServiceType
        '
        Me.cboServiceType.FormattingEnabled = True
        Me.cboServiceType.Location = New System.Drawing.Point(324, 32)
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(121, 21)
        Me.cboServiceType.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(245, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Service Type:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Arrival Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(207, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Departure Date:"
        '
        'dtpDeparturee
        '
        Me.dtpDeparturee.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDeparturee.Location = New System.Drawing.Point(297, 173)
        Me.dtpDeparturee.Name = "dtpDeparturee"
        Me.dtpDeparturee.Size = New System.Drawing.Size(108, 20)
        Me.dtpDeparturee.TabIndex = 11
        '
        'dtpArrival
        '
        Me.dtpArrival.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpArrival.Location = New System.Drawing.Point(83, 173)
        Me.dtpArrival.Name = "dtpArrival"
        Me.dtpArrival.Size = New System.Drawing.Size(108, 20)
        Me.dtpArrival.TabIndex = 10
        '
        'cboEventType
        '
        Me.cboEventType.FormattingEnabled = True
        Me.cboEventType.Location = New System.Drawing.Point(88, 31)
        Me.cboEventType.Name = "cboEventType"
        Me.cboEventType.Size = New System.Drawing.Size(131, 21)
        Me.cboEventType.TabIndex = 9
        '
        'dtpEventTime
        '
        Me.dtpEventTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEventTime.Location = New System.Drawing.Point(83, 138)
        Me.dtpEventTime.Name = "dtpEventTime"
        Me.dtpEventTime.Size = New System.Drawing.Size(108, 20)
        Me.dtpEventTime.TabIndex = 8
        '
        'txtVenue
        '
        Me.txtVenue.Location = New System.Drawing.Point(77, 106)
        Me.txtVenue.Name = "txtVenue"
        Me.txtVenue.Size = New System.Drawing.Size(368, 20)
        Me.txtVenue.TabIndex = 7
        '
        'dtpEventEnd
        '
        Me.dtpEventEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEventEnd.Location = New System.Drawing.Point(324, 73)
        Me.dtpEventEnd.Name = "dtpEventEnd"
        Me.dtpEventEnd.Size = New System.Drawing.Size(121, 20)
        Me.dtpEventEnd.TabIndex = 6
        '
        'dtpEventStart
        '
        Me.dtpEventStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEventStart.Location = New System.Drawing.Point(88, 70)
        Me.dtpEventStart.Name = "dtpEventStart"
        Me.dtpEventStart.Size = New System.Drawing.Size(131, 20)
        Me.dtpEventStart.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Event Time:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Venue:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(264, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "End Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Start Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Event Type:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EventTaskToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(649, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.NewCustomerToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'NewCustomerToolStripMenuItem
        '
        Me.NewCustomerToolStripMenuItem.Name = "NewCustomerToolStripMenuItem"
        Me.NewCustomerToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.NewCustomerToolStripMenuItem.Text = "New Customer"
        '
        'EventTaskToolStripMenuItem
        '
        Me.EventTaskToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewEventToolStripMenuItem, Me.AddNewServTypeToolStripMenuItem, Me.GenerateReceiptToolStripMenuItem, Me.EventFeesPaymentToolStripMenuItem})
        Me.EventTaskToolStripMenuItem.Name = "EventTaskToolStripMenuItem"
        Me.EventTaskToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.EventTaskToolStripMenuItem.Text = "Event Task"
        '
        'AddNewEventToolStripMenuItem
        '
        Me.AddNewEventToolStripMenuItem.Name = "AddNewEventToolStripMenuItem"
        Me.AddNewEventToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddNewEventToolStripMenuItem.Text = "Add New Event"
        '
        'AddNewServTypeToolStripMenuItem
        '
        Me.AddNewServTypeToolStripMenuItem.Name = "AddNewServTypeToolStripMenuItem"
        Me.AddNewServTypeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddNewServTypeToolStripMenuItem.Text = "Add New Serv. Type"
        '
        'GenerateReceiptToolStripMenuItem
        '
        Me.GenerateReceiptToolStripMenuItem.Name = "GenerateReceiptToolStripMenuItem"
        Me.GenerateReceiptToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GenerateReceiptToolStripMenuItem.Text = "Generate Receipt"
        '
        'EventFeesPaymentToolStripMenuItem
        '
        Me.EventFeesPaymentToolStripMenuItem.Name = "EventFeesPaymentToolStripMenuItem"
        Me.EventFeesPaymentToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EventFeesPaymentToolStripMenuItem.Text = "Event Fees Payment"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "ID"
        '
        'lblSheduledid
        '
        Me.lblSheduledid.AutoSize = True
        Me.lblSheduledid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSheduledid.Location = New System.Drawing.Point(54, 43)
        Me.lblSheduledid.Name = "lblSheduledid"
        Me.lblSheduledid.Size = New System.Drawing.Size(0, 15)
        Me.lblSheduledid.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(126, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "EventID"
        '
        'lblEventid
        '
        Me.lblEventid.AutoSize = True
        Me.lblEventid.Location = New System.Drawing.Point(177, 41)
        Me.lblEventid.Name = "lblEventid"
        Me.lblEventid.Size = New System.Drawing.Size(0, 13)
        Me.lblEventid.TabIndex = 9
        '
        'frmSheldule_Event
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleVioletRed
        Me.ClientSize = New System.Drawing.Size(649, 497)
        Me.Controls.Add(Me.lblEventid)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblSheduledid)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmSheldule_Event"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sheldule Event"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFulname As System.Windows.Forms.TextBox
    Friend WithEvents cboCustomer_code As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpDeparturee As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpArrival As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboEventType As System.Windows.Forms.ComboBox
    Friend WithEvents dtpEventTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtVenue As System.Windows.Forms.TextBox
    Friend WithEvents dtpEventEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEventStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnPayment As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCostFees As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblSheduledid As System.Windows.Forms.Label
    Friend WithEvents NewCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventTaskToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewEventToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewServTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerateReceiptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventFeesPaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblEventid As System.Windows.Forms.Label
End Class
