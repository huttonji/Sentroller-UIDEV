Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel








Public Class Form1



    'Serial Communication Variables
    Dim isConnected As Boolean = False
    Dim connectAttempt_PortNumber As Integer = 0
    Dim availablePorts As Array

    'Sentroller variables
    Dim ch0_Meter, ch1_Meter, ch2_Meter, ch3_Meter As Boolean
    Dim ch0_RTD, ch1_RTD, ch2_RTD, ch3_RTD As Boolean
    Dim ch0_Burden, ch1_Burden, ch2_Burden, ch3_Burden As Boolean
    Dim ch0_HVbypass, ch1_HVbypass, ch2_HVbypass, ch3_HVbypass As Boolean



    Dim terminalFeed As New TextBox With
      {.BorderStyle = 0, .Left = 36, .Top = 808, .Width = 320, .Height = 82, .ForeColor = Color.Lime,
       .BackColor = Color.Black, .Font = New Font("Microsoft Sans Serif", 9), .Cursor = Cursors.Arrow, .Multiline = True}

    'MAIN
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'load initial background
        Me.BackgroundImage = My.Resources.main                                                                                   'GREY OUT SENTROLLER MORE WHEN NOT CONNECTED...REAL PICTURE OF SENTROLLER?


        'initiate the terminal feed display box
        Controls.Add(terminalFeed)

        'load serial ports                                                                                                                  'REFRESH PORT OPTIONS AUTOMATICALLY
        availablePorts = IO.Ports.SerialPort.GetPortNames()                                                                                 'INTERRUPT WHEN CONNECTION LOST

    End Sub


    Private Sub SerialPort1_DataReceived(sender As Object, ByVal e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        If isConnected = False Then
            isConnected = True
            sentrollerSearchTimer.Enabled = False
        End If

    End Sub


    Private Sub detectVersion(sender As Object)

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

        If SerialPort1.IsOpen Then
            If SerialPort1.BytesToRead > 0 Then
                isConnected = True
                sentrollerSearchTimer.Enabled = False
                SerialPort1.ReadLine()    'get rid of echo
                terminalFeed.Text = SerialPort1.ReadLine
                Return
            End If
            SerialPort1.Close()
        End If
        Try
            SerialPort1.PortName = availablePorts(connectAttempt_PortNumber)
            SerialPort1.Open()
            SerialPort1.WriteLine("pa55word")
            While SerialPort1.BytesToWrite > 0
            End While
            SerialPort1.DiscardOutBuffer()
            SerialPort1.DiscardInBuffer()
        Catch ex As Exception
        End Try

        'handle next COM port try
        availablePorts = IO.Ports.SerialPort.GetPortNames()                 'refresh avail ports list
        connectAttempt_PortNumber = connectAttempt_PortNumber + 1
        If connectAttempt_PortNumber = availablePorts.Length Then
            connectAttempt_PortNumber = 0

        End If




    End Sub

    Private Sub ButtonAfeMeter_Click(sender As Object, e As EventArgs) Handles ButtonAfeMeter.Click

        SerialPort1.WriteLine("pa55word")

        Dim toggle As Integer
        If ButtonAfeMeter.Text = "Harvest" Then : ButtonAfeMeter.Text = "Meter" : toggle = 1
        Else : ButtonAfeMeter.Text = "Harvest" : toggle = 0
        End If

        If SelectCh0.Checked Then
            If toggle = True Then : ch0_Meter = True : SerialPort1.WriteLine("appdev afe 0 set ")
            Else
            End If



        ElseIf SelectCh1.Checked Then
            If toggle Then ch1_Meter = True Else ch1_Meter = False
        ElseIf SelectCh2.Checked Then
            If toggle Then ch2_Meter = True Else ch2_Meter = False
        ElseIf SelectCh3.Checked Then
            If toggle Then ch3_Meter = True Else ch3_Meter = False
        End If




    End Sub

    Private Sub generateChannelHexCode(ByVal channel As Integer)
        Dim binary As String 'here...................
    End Sub
End Class
