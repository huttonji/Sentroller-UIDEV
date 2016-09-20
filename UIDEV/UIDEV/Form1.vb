Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel








Public Class Form1

    Dim isConnected As Boolean = False
    Dim connectAttempt_PortNumber As Integer = 0
    Dim availablePorts As Array

    Dim decVal As Integer
    Dim hexVal As String
    Dim hexCode As String

    Delegate Sub setTextCallBack(ByVal [text] As String)  'a delegate points to a function (unknown before runtime)

    Dim terminalFeed As New TextBox With
      {.BorderStyle = 0, .Left = 666, .Top = 450, .Width = 509, .Height = 417, .ForeColor = Color.Lime,
       .BackColor = Color.Black, .Font = New Font("Microsoft Sans Serif", 9), .Cursor = Cursors.Arrow, .Multiline = True}
    'add the box



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'load initial background
        Me.BackgroundImage = My.Resources.main


        'initiate the terminal feed display box
        Controls.Add(terminalFeed)

        'load serial ports                                                                                                                  
        availablePorts = IO.Ports.SerialPort.GetPortNames()




    End Sub


    'Incoming Serial handling///////////////////////////////////////////////////
    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            Do While 1 = 1
                ReceivedText(SerialPort1.ReadLine)
            Loop
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ReceivedText(ByVal [text] As String)




        If Me.terminalFeed.InvokeRequired Then
            Dim x As New setTextCallBack(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            If [text].IndexOf("*") Then isConnected = True : buttonSendConfig.BackgroundImage = My.Resources.b_blue



            If [text].IndexOf("pa55word") < 0 Then Me.terminalFeed.Text = [text] + vbNewLine + Me.terminalFeed.Text

        End If


    End Sub








    Private Sub terminalOutput_KeyDown(sender As Object, ByVal e As KeyEventArgs) Handles terminalOutput.KeyDown

        'Send output through serial, add it to the feed, and clear the output box
        If e.KeyCode = Keys.Return Then
            SerialPort1.WriteLine(terminalOutput.Text)
            terminalFeed.Text = terminalOutput.Text & vbNewLine & terminalFeed.Text
            terminalOutput.Text = ""
        End If

    End Sub

    Private Sub sentrollerSearchTimer_Tick(sender As Object, e As EventArgs) Handles sentrollerSearchTimer.Tick

        If isConnected Then

            sentrollerSearchTimer.Enabled = False

            'SerialPort1.ReadLine()    'get rid of echo

            terminalFeed.Text = terminalFeed.Text + SerialPort1.ReadExisting
            Return

        else
            SerialPort1.Close()
        End If
        Try
            SerialPort1.PortName = availablePorts(connectAttempt_PortNumber)

            SerialPort1.Open()
            SerialPort1.WriteLine("pa55word")
        Catch ex As Exception
        End Try

        'handle next COM port try
        availablePorts = IO.Ports.SerialPort.GetPortNames()                 'refresh avail ports list
        connectAttempt_PortNumber = connectAttempt_PortNumber + 1
        If connectAttempt_PortNumber = availablePorts.Length Then
            connectAttempt_PortNumber = 0

        End If




    End Sub


    Private Sub buttonSendConfig_Click(sender As Object, e As EventArgs)


        If hexCode = Nothing Then radioSelect(Me, e)

        Dim afeSetCommand As String = "appdev afe " + ComboBox1.Text(3) + " set " + Label1.Text

        If isConnected Then
            SerialPort1.WriteLine("pa55word")
            SerialPort1.Write(afeSetCommand)
        End If

    End Sub

    Private Sub radioSelect(sender As Object, e As EventArgs)

        Dim decCode(4) As Boolean
        decCode(0) = If(selectMeter.Checked = True, True, False)
        decCode(1) = If(selectRTDon.Checked = True, True, False)
        decCode(2) = If(selectBURDon.Checked = True, True, False)
        decCode(3) = If(selectBYP.Checked = True, True, False)

        Dim decVal As Integer
        decVal = decVal + If(decCode(0), 8, 0)
        decVal = decVal + If(decCode(1), 4, 0)
        decVal = decVal + If(decCode(2), 2, 0)
        decVal = decVal + If(decCode(3), 1, 0)

        Dim hexCode As String = "0x02" + Hex(decVal)
        Label1.Text = "0x02" + Hex(decVal)

    End Sub

    Private Sub buttonSendConfig_MouseEnter(sender As Object, e As EventArgs)
        buttonSendConfig.BackgroundImage = My.Resources.b_blue_fuzz

    End Sub

    Private Sub buttonSendConfig_MouseLeave(sender As Object, e As EventArgs)
        buttonSendConfig.BackgroundImage = My.Resources.b_blue
    End Sub
End Class
