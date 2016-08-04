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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = Global.UIDEV.My.Resources.Resources.main
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1417, 911)
        Me.Controls.Add(Me.terminalOutput)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents terminalOutput As System.Windows.Forms.TextBox
    Friend WithEvents sentrollerSearchTimer As System.Windows.Forms.Timer

End Class
