<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.terminalOutput = New System.Windows.Forms.TextBox()
        Me.sentrollerSearchTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.selectMeter = New System.Windows.Forms.RadioButton()
        Me.selectHarvest = New System.Windows.Forms.RadioButton()
        Me.selectRTDon = New System.Windows.Forms.RadioButton()
        Me.selectRTDoff = New System.Windows.Forms.RadioButton()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.selectBURDon = New System.Windows.Forms.RadioButton()
        Me.selectBURDoff = New System.Windows.Forms.RadioButton()
        Me.selectBYP = New System.Windows.Forms.RadioButton()
        Me.selectHV = New System.Windows.Forms.RadioButton()
        Me.buttonSendConfig = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(664, 787)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 80)
        Me.VScrollBar1.TabIndex = 0
        '
        'terminalOutput
        '
        Me.terminalOutput.BackColor = System.Drawing.Color.Black
        Me.terminalOutput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.terminalOutput.Font = New System.Drawing.Font("Monospac821 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.terminalOutput.ForeColor = System.Drawing.Color.Lime
        Me.terminalOutput.Location = New System.Drawing.Point(677, 417)
        Me.terminalOutput.MaximumSize = New System.Drawing.Size(430, 0)
        Me.terminalOutput.Name = "terminalOutput"
        Me.terminalOutput.Size = New System.Drawing.Size(430, 15)
        Me.terminalOutput.TabIndex = 1
        '
        'sentrollerSearchTimer
        '
        Me.sentrollerSearchTimer.Enabled = True
        Me.sentrollerSearchTimer.Interval = 200
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SplitContainer1.Location = New System.Drawing.Point(850, 118)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.selectMeter)
        Me.SplitContainer1.Panel1.Controls.Add(Me.selectHarvest)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.selectRTDon)
        Me.SplitContainer1.Panel2.Controls.Add(Me.selectRTDoff)
        Me.SplitContainer1.Size = New System.Drawing.Size(303, 100)
        Me.SplitContainer1.TabIndex = 2
        '
        'selectMeter
        '
        Me.selectMeter.AutoSize = True
        Me.selectMeter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.selectMeter.Location = New System.Drawing.Point(197, 19)
        Me.selectMeter.Name = "selectMeter"
        Me.selectMeter.Size = New System.Drawing.Size(52, 17)
        Me.selectMeter.TabIndex = 1
        Me.selectMeter.Text = "Meter"
        Me.selectMeter.UseVisualStyleBackColor = True
        '
        'selectHarvest
        '
        Me.selectHarvest.AutoSize = True
        Me.selectHarvest.Checked = True
        Me.selectHarvest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.selectHarvest.Location = New System.Drawing.Point(44, 19)
        Me.selectHarvest.Name = "selectHarvest"
        Me.selectHarvest.Size = New System.Drawing.Size(62, 17)
        Me.selectHarvest.TabIndex = 0
        Me.selectHarvest.TabStop = True
        Me.selectHarvest.Text = "Harvest"
        Me.selectHarvest.UseVisualStyleBackColor = True
        '
        'selectRTDon
        '
        Me.selectRTDon.AutoSize = True
        Me.selectRTDon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.selectRTDon.Location = New System.Drawing.Point(197, 17)
        Me.selectRTDon.Name = "selectRTDon"
        Me.selectRTDon.Size = New System.Drawing.Size(63, 17)
        Me.selectRTDon.TabIndex = 1
        Me.selectRTDon.Text = "RTD on"
        Me.selectRTDon.UseVisualStyleBackColor = True
        '
        'selectRTDoff
        '
        Me.selectRTDoff.AutoSize = True
        Me.selectRTDoff.Checked = True
        Me.selectRTDoff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.selectRTDoff.Location = New System.Drawing.Point(44, 17)
        Me.selectRTDoff.Name = "selectRTDoff"
        Me.selectRTDoff.Size = New System.Drawing.Size(63, 17)
        Me.selectRTDoff.TabIndex = 0
        Me.selectRTDoff.TabStop = True
        Me.selectRTDoff.Text = "RTD off"
        Me.selectRTDoff.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BackColor = System.Drawing.Color.Black
        Me.SplitContainer2.Location = New System.Drawing.Point(851, 224)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.selectBURDon)
        Me.SplitContainer2.Panel1.Controls.Add(Me.selectBURDoff)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.selectBYP)
        Me.SplitContainer2.Panel2.Controls.Add(Me.selectHV)
        Me.SplitContainer2.Size = New System.Drawing.Size(302, 100)
        Me.SplitContainer2.TabIndex = 3
        '
        'selectBURDon
        '
        Me.selectBURDon.AutoSize = True
        Me.selectBURDon.Checked = True
        Me.selectBURDon.ForeColor = System.Drawing.Color.Magenta
        Me.selectBURDon.Location = New System.Drawing.Point(196, 19)
        Me.selectBURDon.Name = "selectBURDon"
        Me.selectBURDon.Size = New System.Drawing.Size(71, 17)
        Me.selectBURDon.TabIndex = 1
        Me.selectBURDon.TabStop = True
        Me.selectBURDon.Text = "BURD on"
        Me.selectBURDon.UseVisualStyleBackColor = True
        '
        'selectBURDoff
        '
        Me.selectBURDoff.AutoSize = True
        Me.selectBURDoff.ForeColor = System.Drawing.Color.Magenta
        Me.selectBURDoff.Location = New System.Drawing.Point(43, 19)
        Me.selectBURDoff.Name = "selectBURDoff"
        Me.selectBURDoff.Size = New System.Drawing.Size(71, 17)
        Me.selectBURDoff.TabIndex = 0
        Me.selectBURDoff.Text = "BURD off"
        Me.selectBURDoff.UseVisualStyleBackColor = True
        '
        'selectBYP
        '
        Me.selectBYP.AutoSize = True
        Me.selectBYP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.selectBYP.Location = New System.Drawing.Point(196, 15)
        Me.selectBYP.Name = "selectBYP"
        Me.selectBYP.Size = New System.Drawing.Size(58, 17)
        Me.selectBYP.TabIndex = 1
        Me.selectBYP.Text = "bypass"
        Me.selectBYP.UseVisualStyleBackColor = True
        '
        'selectHV
        '
        Me.selectHV.AutoSize = True
        Me.selectHV.Checked = True
        Me.selectHV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.selectHV.Location = New System.Drawing.Point(43, 15)
        Me.selectHV.Name = "selectHV"
        Me.selectHV.Size = New System.Drawing.Size(40, 17)
        Me.selectHV.TabIndex = 0
        Me.selectHV.TabStop = True
        Me.selectHV.Text = "HV"
        Me.selectHV.UseVisualStyleBackColor = True
        '
        'buttonSendConfig
        '
        Me.buttonSendConfig.BackgroundImage = Global.UIDEV.My.Resources.Resources.b_orange
        Me.buttonSendConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buttonSendConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonSendConfig.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.buttonSendConfig.FlatAppearance.BorderSize = 0
        Me.buttonSendConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonSendConfig.ForeColor = System.Drawing.Color.Cyan
        Me.buttonSendConfig.Location = New System.Drawing.Point(1136, 281)
        Me.buttonSendConfig.Name = "buttonSendConfig"
        Me.buttonSendConfig.Size = New System.Drawing.Size(136, 62)
        Me.buttonSendConfig.TabIndex = 4
        Me.buttonSendConfig.Text = "Send Configuration"
        Me.buttonSendConfig.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.SandyBrown
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"AFE0", "AFE1", "AFE2", "AFE3"})
        Me.ComboBox1.Location = New System.Drawing.Point(1181, 160)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(52, 21)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.Text = "AFE0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(1177, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "0x002"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = Global.UIDEV.My.Resources.Resources.main
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1417, 911)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.buttonSendConfig)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.terminalOutput)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Name = "Form1"
        Me.Text = "UIDEV"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents terminalOutput As System.Windows.Forms.TextBox
    Friend WithEvents sentrollerSearchTimer As System.Windows.Forms.Timer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents selectMeter As System.Windows.Forms.RadioButton
    Friend WithEvents selectHarvest As System.Windows.Forms.RadioButton
    Friend WithEvents selectRTDon As System.Windows.Forms.RadioButton
    Friend WithEvents selectRTDoff As System.Windows.Forms.RadioButton
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents selectBURDon As System.Windows.Forms.RadioButton
    Friend WithEvents selectBURDoff As System.Windows.Forms.RadioButton
    Friend WithEvents selectBYP As System.Windows.Forms.RadioButton
    Friend WithEvents selectHV As System.Windows.Forms.RadioButton
    Friend WithEvents buttonSendConfig As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
