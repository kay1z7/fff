<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReciept
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblPayID = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblEventId = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblEventDays = New System.Windows.Forms.Label
        Me.lblDiscount = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.lblPaymentDate = New System.Windows.Forms.Label
        Me.lblTotalCharge = New System.Windows.Forms.Label
        Me.lblEventType = New System.Windows.Forms.Label
        Me.lblFulname = New System.Windows.Forms.Label
        Me.lblServiceType = New System.Windows.Forms.Label
        Me.lblBalance = New System.Windows.Forms.Label
        Me.lblIntialPayment = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnPrint = New System.Windows.Forms.ToolStripButton
        Me.btnPayment = New System.Windows.Forms.ToolStripButton
        Me.btnSheldule = New System.Windows.Forms.ToolStripButton
        Me.btnReport = New System.Windows.Forms.ToolStripButton
        Me.btnClose = New System.Windows.Forms.ToolStripButton
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lblPrint_Date = New System.Windows.Forms.Label
        Me.txtCustomer_code = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpEvent = New System.Windows.Forms.DateTimePicker
        Me.btnGenerate = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPayID)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblEventId)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblEventDays)
        Me.GroupBox1.Controls.Add(Me.lblDiscount)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.lblPaymentDate)
        Me.GroupBox1.Controls.Add(Me.lblTotalCharge)
        Me.GroupBox1.Controls.Add(Me.lblEventType)
        Me.GroupBox1.Controls.Add(Me.lblFulname)
        Me.GroupBox1.Controls.Add(Me.lblServiceType)
        Me.GroupBox1.Controls.Add(Me.lblBalance)
        Me.GroupBox1.Controls.Add(Me.lblIntialPayment)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 275)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reciept Details..."
        '
        'lblPayID
        '
        Me.lblPayID.AutoSize = True
        Me.lblPayID.Location = New System.Drawing.Point(324, 152)
        Me.lblPayID.Name = "lblPayID"
        Me.lblPayID.Size = New System.Drawing.Size(0, 13)
        Me.lblPayID.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(248, 151)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Payment ID:"
        '
        'lblEventId
        '
        Me.lblEventId.AutoSize = True
        Me.lblEventId.Location = New System.Drawing.Point(312, 55)
        Me.lblEventId.Name = "lblEventId"
        Me.lblEventId.Size = New System.Drawing.Size(0, 13)
        Me.lblEventId.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(245, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Event ID:"
        '
        'lblEventDays
        '
        Me.lblEventDays.AutoSize = True
        Me.lblEventDays.Location = New System.Drawing.Point(317, 205)
        Me.lblEventDays.Name = "lblEventDays"
        Me.lblEventDays.Size = New System.Drawing.Size(0, 13)
        Me.lblEventDays.TabIndex = 22
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(313, 117)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(0, 13)
        Me.lblDiscount.TabIndex = 20
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(245, 205)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 13)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "No of  Days:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(247, 117)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 13)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Discount:"
        '
        'lblPaymentDate
        '
        Me.lblPaymentDate.AutoSize = True
        Me.lblPaymentDate.Location = New System.Drawing.Point(98, 241)
        Me.lblPaymentDate.Name = "lblPaymentDate"
        Me.lblPaymentDate.Size = New System.Drawing.Size(0, 13)
        Me.lblPaymentDate.TabIndex = 17
        '
        'lblTotalCharge
        '
        Me.lblTotalCharge.AutoSize = True
        Me.lblTotalCharge.Location = New System.Drawing.Point(98, 117)
        Me.lblTotalCharge.Name = "lblTotalCharge"
        Me.lblTotalCharge.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalCharge.TabIndex = 15
        '
        'lblEventType
        '
        Me.lblEventType.AutoSize = True
        Me.lblEventType.Location = New System.Drawing.Point(98, 55)
        Me.lblEventType.Name = "lblEventType"
        Me.lblEventType.Size = New System.Drawing.Size(0, 13)
        Me.lblEventType.TabIndex = 14
        '
        'lblFulname
        '
        Me.lblFulname.AutoSize = True
        Me.lblFulname.Location = New System.Drawing.Point(98, 24)
        Me.lblFulname.Name = "lblFulname"
        Me.lblFulname.Size = New System.Drawing.Size(0, 13)
        Me.lblFulname.TabIndex = 13
        '
        'lblServiceType
        '
        Me.lblServiceType.AutoSize = True
        Me.lblServiceType.Location = New System.Drawing.Point(98, 86)
        Me.lblServiceType.Name = "lblServiceType"
        Me.lblServiceType.Size = New System.Drawing.Size(0, 13)
        Me.lblServiceType.TabIndex = 12
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(98, 179)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(0, 13)
        Me.lblBalance.TabIndex = 11
        '
        'lblIntialPayment
        '
        Me.lblIntialPayment.AutoSize = True
        Me.lblIntialPayment.Location = New System.Drawing.Point(98, 148)
        Me.lblIntialPayment.Name = "lblIntialPayment"
        Me.lblIntialPayment.Size = New System.Drawing.Size(0, 13)
        Me.lblIntialPayment.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Payment Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Initial Payment:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Balance Amount:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total Charge:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Service Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Event Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FulName:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(341, 411)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Prined Date:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnPayment, Me.btnSheldule, Me.btnReport, Me.btnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(521, 51)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnPrint
        '
        Me.btnPrint.Image = Global.Event_Planning_and_Management__System.My.Resources.Resources.Printdoc
        Me.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(39, 48)
        Me.btnPrint.Text = "Print "
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnPayment
        '
        Me.btnPayment.Image = Global.Event_Planning_and_Management__System.My.Resources.Resources.payment
        Me.btnPayment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(58, 48)
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnSheldule
        '
        Me.btnSheldule.Image = Global.Event_Planning_and_Management__System.My.Resources.Resources.Agenda1
        Me.btnSheldule.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSheldule.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSheldule.Name = "btnSheldule"
        Me.btnSheldule.Size = New System.Drawing.Size(88, 48)
        Me.btnSheldule.Text = "Sheldule Event"
        Me.btnSheldule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnReport
        '
        Me.btnReport.Image = Global.Event_Planning_and_Management__System.My.Resources.Resources.Invoiceprint
        Me.btnReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(46, 48)
        Me.btnReport.Text = "Report"
        Me.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnClose
        '
        Me.btnClose.Image = Global.Event_Planning_and_Management__System.My.Resources.Resources.logmeout
        Me.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 48)
        Me.btnClose.Text = "Close"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 434)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(521, 22)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblPrint_Date
        '
        Me.lblPrint_Date.AutoSize = True
        Me.lblPrint_Date.Location = New System.Drawing.Point(414, 410)
        Me.lblPrint_Date.Name = "lblPrint_Date"
        Me.lblPrint_Date.Size = New System.Drawing.Size(0, 13)
        Me.lblPrint_Date.TabIndex = 13
        '
        'txtCustomer_code
        '
        Me.txtCustomer_code.Location = New System.Drawing.Point(96, 94)
        Me.txtCustomer_code.Name = "txtCustomer_code"
        Me.txtCustomer_code.Size = New System.Drawing.Size(130, 20)
        Me.txtCustomer_code.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Customer Code:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(248, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Event Date:"
        '
        'dtpEvent
        '
        Me.dtpEvent.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEvent.Location = New System.Drawing.Point(314, 94)
        Me.dtpEvent.Name = "dtpEvent"
        Me.dtpEvent.Size = New System.Drawing.Size(120, 20)
        Me.dtpEvent.TabIndex = 25
        '
        'btnGenerate
        '
        Me.btnGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(434, 88)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 30)
        Me.btnGenerate.TabIndex = 26
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'frmReciept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleVioletRed
        Me.ClientSize = New System.Drawing.Size(521, 456)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.dtpEvent)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCustomer_code)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPrint_Date)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmReciept"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReciept"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents lblIntialPayment As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblPaymentDate As System.Windows.Forms.Label
    Friend WithEvents lblTotalCharge As System.Windows.Forms.Label
    Friend WithEvents lblEventType As System.Windows.Forms.Label
    Friend WithEvents lblFulname As System.Windows.Forms.Label
    Friend WithEvents lblServiceType As System.Windows.Forms.Label
    Friend WithEvents lblEventDays As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSheldule As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblPrint_Date As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblEventId As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblPayID As System.Windows.Forms.Label
    Friend WithEvents txtCustomer_code As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpEvent As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
End Class
