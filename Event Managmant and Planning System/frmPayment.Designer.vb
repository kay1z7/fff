<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Me.tsslStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tsslPayid = New System.Windows.Forms.ToolStripStatusLabel
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblReciever = New System.Windows.Forms.Label
        Me.txtRecieverName = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpPaid = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.txtInitialPay = New System.Windows.Forms.TextBox
        Me.txtTotalCharge = New System.Windows.Forms.TextBox
        Me.txtOther_Charge = New System.Windows.Forms.TextBox
        Me.txtOther_Service = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtServiceChrg = New System.Windows.Forms.TextBox
        Me.txtServiceTy = New System.Windows.Forms.TextBox
        Me.txtEventTy = New System.Windows.Forms.TextBox
        Me.txtCustomer_Code = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ManageTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SheduleNewEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GenerateRecieptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblEventID = New System.Windows.Forms.Label
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslStatus, Me.ToolStripStatusLabel1, Me.tsslPayid})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 462)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(567, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslStatus
        '
        Me.tsslStatus.Name = "tsslStatus"
        Me.tsslStatus.Size = New System.Drawing.Size(39, 17)
        Me.tsslStatus.Text = "Ready"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Margin = New System.Windows.Forms.Padding(20, 3, 0, 2)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(71, 17)
        Me.ToolStripStatusLabel1.Text = "Payment ID:"
        '
        'tsslPayid
        '
        Me.tsslPayid.Name = "tsslPayid"
        Me.tsslPayid.Size = New System.Drawing.Size(0, 17)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 434)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Recieved By:"
        '
        'lblReciever
        '
        Me.lblReciever.AutoSize = True
        Me.lblReciever.Location = New System.Drawing.Point(205, 433)
        Me.lblReciever.Name = "lblReciever"
        Me.lblReciever.Size = New System.Drawing.Size(0, 13)
        Me.lblReciever.TabIndex = 13
        '
        'txtRecieverName
        '
        Me.txtRecieverName.Location = New System.Drawing.Point(85, 431)
        Me.txtRecieverName.Name = "txtRecieverName"
        Me.txtRecieverName.Size = New System.Drawing.Size(100, 20)
        Me.txtRecieverName.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Snow
        Me.Label12.Location = New System.Drawing.Point(140, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(238, 25)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Event Fees Payment "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnClose)
        Me.GroupBox3.Controls.Add(Me.btnPrint)
        Me.GroupBox3.Controls.Add(Me.btnUpdate)
        Me.GroupBox3.Controls.Add(Me.btnDelete)
        Me.GroupBox3.Controls.Add(Me.btnSave)
        Me.GroupBox3.Controls.Add(Me.btnAdd)
        Me.GroupBox3.Font = New System.Drawing.Font("Georgia", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(465, 91)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(93, 332)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(9, 279)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 38)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(12, 228)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 38)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "&Print Reciept"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(12, 177)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 38)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(12, 126)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 38)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 75)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 38)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 24)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 38)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add &New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Location = New System.Drawing.Point(3, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(451, 334)
        Me.Panel1.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpPaid)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtBalance)
        Me.GroupBox1.Controls.Add(Me.txtInitialPay)
        Me.GroupBox1.Controls.Add(Me.txtTotalCharge)
        Me.GroupBox1.Controls.Add(Me.txtOther_Charge)
        Me.GroupBox1.Controls.Add(Me.txtOther_Service)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 170)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 158)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Details..."
        '
        'dtpPaid
        '
        Me.dtpPaid.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPaid.Location = New System.Drawing.Point(96, 116)
        Me.dtpPaid.Name = "dtpPaid"
        Me.dtpPaid.Size = New System.Drawing.Size(105, 20)
        Me.dtpPaid.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Payment Date:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(211, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Balance:"
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(293, 84)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtBalance.TabIndex = 8
        '
        'txtInitialPay
        '
        Me.txtInitialPay.Location = New System.Drawing.Point(98, 84)
        Me.txtInitialPay.Name = "txtInitialPay"
        Me.txtInitialPay.Size = New System.Drawing.Size(100, 20)
        Me.txtInitialPay.TabIndex = 7
        '
        'txtTotalCharge
        '
        Me.txtTotalCharge.Location = New System.Drawing.Point(291, 52)
        Me.txtTotalCharge.Name = "txtTotalCharge"
        Me.txtTotalCharge.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalCharge.TabIndex = 6
        '
        'txtOther_Charge
        '
        Me.txtOther_Charge.Location = New System.Drawing.Point(98, 54)
        Me.txtOther_Charge.Name = "txtOther_Charge"
        Me.txtOther_Charge.Size = New System.Drawing.Size(100, 20)
        Me.txtOther_Charge.TabIndex = 5
        '
        'txtOther_Service
        '
        Me.txtOther_Service.Location = New System.Drawing.Point(98, 21)
        Me.txtOther_Service.Multiline = True
        Me.txtOther_Service.Name = "txtOther_Service"
        Me.txtOther_Service.Size = New System.Drawing.Size(295, 20)
        Me.txtOther_Service.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Intial Payment:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(207, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Total Charge:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Other Charge:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Other Services:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtServiceChrg)
        Me.GroupBox2.Controls.Add(Me.txtServiceTy)
        Me.GroupBox2.Controls.Add(Me.txtEventTy)
        Me.GroupBox2.Controls.Add(Me.txtCustomer_Code)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(295, 157)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer/Event Info...."
        '
        'txtServiceChrg
        '
        Me.txtServiceChrg.Location = New System.Drawing.Point(98, 124)
        Me.txtServiceChrg.Name = "txtServiceChrg"
        Me.txtServiceChrg.ReadOnly = True
        Me.txtServiceChrg.Size = New System.Drawing.Size(163, 20)
        Me.txtServiceChrg.TabIndex = 8
        '
        'txtServiceTy
        '
        Me.txtServiceTy.Location = New System.Drawing.Point(98, 93)
        Me.txtServiceTy.Name = "txtServiceTy"
        Me.txtServiceTy.ReadOnly = True
        Me.txtServiceTy.Size = New System.Drawing.Size(163, 20)
        Me.txtServiceTy.TabIndex = 7
        '
        'txtEventTy
        '
        Me.txtEventTy.Location = New System.Drawing.Point(98, 60)
        Me.txtEventTy.Name = "txtEventTy"
        Me.txtEventTy.ReadOnly = True
        Me.txtEventTy.Size = New System.Drawing.Size(163, 20)
        Me.txtEventTy.TabIndex = 6
        '
        'txtCustomer_Code
        '
        Me.txtCustomer_Code.Location = New System.Drawing.Point(98, 28)
        Me.txtCustomer_Code.Name = "txtCustomer_Code"
        Me.txtCustomer_Code.Size = New System.Drawing.Size(163, 20)
        Me.txtCustomer_Code.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Service Charge:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Service Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Event Type:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Code:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ManageTaskToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(567, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.PrintToolStripMenuItem, Me.NewToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.NewToolStripMenuItem.Text = "New Payment"
        '
        'ManageTaskToolStripMenuItem
        '
        Me.ManageTaskToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SheduleNewEventToolStripMenuItem, Me.GenerateRecieptToolStripMenuItem})
        Me.ManageTaskToolStripMenuItem.Name = "ManageTaskToolStripMenuItem"
        Me.ManageTaskToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ManageTaskToolStripMenuItem.Text = "Manage Task"
        '
        'SheduleNewEventToolStripMenuItem
        '
        Me.SheduleNewEventToolStripMenuItem.Name = "SheduleNewEventToolStripMenuItem"
        Me.SheduleNewEventToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.SheduleNewEventToolStripMenuItem.Text = "Shedule New Event"
        '
        'GenerateRecieptToolStripMenuItem
        '
        Me.GenerateRecieptToolStripMenuItem.Name = "GenerateRecieptToolStripMenuItem"
        Me.GenerateRecieptToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.GenerateRecieptToolStripMenuItem.Text = "Generate Reciept"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Event Id:"
        '
        'lblEventID
        '
        Me.lblEventID.AutoSize = True
        Me.lblEventID.Location = New System.Drawing.Point(83, 71)
        Me.lblEventID.Name = "lblEventID"
        Me.lblEventID.Size = New System.Drawing.Size(0, 13)
        Me.lblEventID.TabIndex = 21
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleVioletRed
        Me.ClientSize = New System.Drawing.Size(567, 484)
        Me.Controls.Add(Me.lblEventID)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtRecieverName)
        Me.Controls.Add(Me.lblReciever)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPayment"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblReciever As System.Windows.Forms.Label
    Friend WithEvents txtRecieverName As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpPaid As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtInitialPay As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCharge As System.Windows.Forms.TextBox
    Friend WithEvents txtOther_Charge As System.Windows.Forms.TextBox
    Friend WithEvents txtOther_Service As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtServiceChrg As System.Windows.Forms.TextBox
    Friend WithEvents txtServiceTy As System.Windows.Forms.TextBox
    Friend WithEvents txtEventTy As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomer_Code As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents tsslStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageTaskToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SheduleNewEventToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerateRecieptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblEventID As System.Windows.Forms.Label
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslPayid As System.Windows.Forms.ToolStripStatusLabel
End Class
