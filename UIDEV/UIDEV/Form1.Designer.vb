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
        Me.terminalOutput = New System.Windows.Forms.TextBox()
        Me.sentrollerSearchTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonAfeMeter = New System.Windows.Forms.Button()
        Me.ButtonAfeRTD = New System.Windows.Forms.Button()
        Me.ButtonAfeBURD = New System.Windows.Forms.Button()
        Me.ButtonAfeHVBYP = New System.Windows.Forms.Button()
        Me.SelectCh0 = New System.Windows.Forms.RadioButton()
        Me.SelectCh1 = New System.Windows.Forms.RadioButton()
        Me.SelectCh2 = New System.Windows.Forms.RadioButton()
        Me.SelectCh3 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'terminalOutput
        '
        Me.terminalOutput.BackColor = System.Drawing.Color.Black
        Me.terminalOutput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.terminalOutput.Font = New System.Drawing.Font("Monospac821 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.terminalOutput.ForeColor = System.Drawing.Color.Lime
        Me.terminalOutput.Location = New System.Drawing.Point(36, 780)
        Me.terminalOutput.MaximumSize = New System.Drawing.Size(245, 0)
        Me.terminalOutput.Name = "terminalOutput"
        Me.terminalOutput.Size = New System.Drawing.Size(245, 15)
        Me.terminalOutput.TabIndex = 1
        '
        'sentrollerSearchTimer
        '
        Me.sentrollerSearchTimer.Enabled = True
        Me.sentrollerSearchTimer.Interval = 200
        '
        'ButtonAfeMeter
        '
        Me.ButtonAfeMeter.Location = New System.Drawing.Point(689, 233)
        Me.ButtonAfeMeter.Name = "ButtonAfeMeter"
        Me.ButtonAfeMeter.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAfeMeter.TabIndex = 2
        Me.ButtonAfeMeter.Text = "Harvest"
        Me.ButtonAfeMeter.UseVisualStyleBackColor = True
        '
        'ButtonAfeRTD
        '
        Me.ButtonAfeRTD.Location = New System.Drawing.Point(869, 233)
        Me.ButtonAfeRTD.Name = "ButtonAfeRTD"
        Me.ButtonAfeRTD.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAfeRTD.TabIndex = 3
        Me.ButtonAfeRTD.Text = "RTD"
        Me.ButtonAfeRTD.UseVisualStyleBackColor = True
        '
        'ButtonAfeBURD
        '
        Me.ButtonAfeBURD.Location = New System.Drawing.Point(689, 322)
        Me.ButtonAfeBURD.Name = "ButtonAfeBURD"
        Me.ButtonAfeBURD.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAfeBURD.TabIndex = 4
        Me.ButtonAfeBURD.Text = "BURDEN"
        Me.ButtonAfeBURD.UseVisualStyleBackColor = True
        '
        'ButtonAfeHVBYP
        '
        Me.ButtonAfeHVBYP.Location = New System.Drawing.Point(869, 322)
        Me.ButtonAfeHVBYP.Name = "ButtonAfeHVBYP"
        Me.ButtonAfeHVBYP.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAfeHVBYP.TabIndex = 5
        Me.ButtonAfeHVBYP.Text = "HV Bypass"
        Me.ButtonAfeHVBYP.UseVisualStyleBackColor = True
        '
        'SelectCh0
        '
        Me.SelectCh0.AutoSize = True
        Me.SelectCh0.Checked = True
        Me.SelectCh0.Location = New System.Drawing.Point(869, 447)
        Me.SelectCh0.Name = "SelectCh0"
        Me.SelectCh0.Size = New System.Drawing.Size(74, 17)
        Me.SelectCh0.TabIndex = 6
        Me.SelectCh0.TabStop = True
        Me.SelectCh0.Text = "SelectCh0"
        Me.SelectCh0.UseVisualStyleBackColor = True
        '
        'SelectCh1
        '
        Me.SelectCh1.AutoSize = True
        Me.SelectCh1.Location = New System.Drawing.Point(869, 470)
        Me.SelectCh1.Name = "SelectCh1"
        Me.SelectCh1.Size = New System.Drawing.Size(74, 17)
        Me.SelectCh1.TabIndex = 7
        Me.SelectCh1.Text = "SelectCh1"
        Me.SelectCh1.UseVisualStyleBackColor = True
        '
        'SelectCh2
        '
        Me.SelectCh2.AutoSize = True
        Me.SelectCh2.Location = New System.Drawing.Point(869, 493)
        Me.SelectCh2.Name = "SelectCh2"
        Me.SelectCh2.Size = New System.Drawing.Size(74, 17)
        Me.SelectCh2.TabIndex = 8
        Me.SelectCh2.Text = "SelectCh2"
        Me.SelectCh2.UseVisualStyleBackColor = True
        '
        'SelectCh3
        '
        Me.SelectCh3.AutoSize = True
        Me.SelectCh3.Location = New System.Drawing.Point(869, 516)
        Me.SelectCh3.Name = "SelectCh3"
        Me.SelectCh3.Size = New System.Drawing.Size(74, 17)
        Me.SelectCh3.TabIndex = 9
        Me.SelectCh3.Text = "SelectCh3"
        Me.SelectCh3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1417, 911)
        Me.Controls.Add(Me.SelectCh3)
        Me.Controls.Add(Me.SelectCh2)
        Me.Controls.Add(Me.SelectCh1)
        Me.Controls.Add(Me.SelectCh0)
        Me.Controls.Add(Me.ButtonAfeHVBYP)
        Me.Controls.Add(Me.ButtonAfeBURD)
        Me.Controls.Add(Me.ButtonAfeRTD)
        Me.Controls.Add(Me.ButtonAfeMeter)
        Me.Controls.Add(Me.terminalOutput)
        Me.Name = "Form1"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents terminalOutput As System.Windows.Forms.TextBox
    Friend WithEvents sentrollerSearchTimer As System.Windows.Forms.Timer
    Friend WithEvents ButtonAfeMeter As System.Windows.Forms.Button
    Friend WithEvents ButtonAfeRTD As System.Windows.Forms.Button
    Friend WithEvents ButtonAfeBURD As System.Windows.Forms.Button
    Friend WithEvents ButtonAfeHVBYP As System.Windows.Forms.Button
    Friend WithEvents SelectCh0 As System.Windows.Forms.RadioButton
    Friend WithEvents SelectCh1 As System.Windows.Forms.RadioButton
    Friend WithEvents SelectCh2 As System.Windows.Forms.RadioButton
    Friend WithEvents SelectCh3 As System.Windows.Forms.RadioButton

End Class
