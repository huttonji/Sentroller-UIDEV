Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel



Public Class Form1

    Dim availablePorts As Array


    'Dim portButton As New System.Windows.Forms.Button()  'adds a new instance of the class "button" (like a prefix)


    Delegate Sub setTextCallBack(ByVal [text] As String)  'a delegate points to a function (unknown before runtime)






    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.choose_port

        'load serial ports (make this on a timer?)
        availablePorts = IO.Ports.SerialPort.GetPortNames()
        Dim portButton(availablePorts.Length) As System.Windows.Forms.Button
        'generate COM port buttons
        For i As Integer = 0 To availablePorts.Length - 1
            portButton(i) = New System.Windows.Forms.Button
            portButton(i).Text = availablePorts(i)
            portButton(i).BackgroundImage = UIDEV.My.Resources.Resources.b_blue
            portButton(i).BackgroundImageLayout = ImageLayout.Stretch
            portButton(i).BackColor = Color.Transparent
            portButton(i).ForeColor = Color.DeepSkyBlue
            portButton(i).FlatAppearance.BorderColor = Color.Black
            portButton(i).FlatStyle = FlatStyle.Flat
            portButton(i).Cursor = Cursors.Hand
            portButton(i).Font = New Font("Century Gothic", 11, FontStyle.Bold)

            portButton(i).Width = 85
            portButton(i).Height = 46

            'grid placement:
            'shift every odd button 100px right, and shift each new set of 2 down 60px
            portButton(i).Location = New Point((1000 + ((i Mod 2) * 100)), (460 + Int(i / 2) * 60))

            AddHandler portButton(i).MouseEnter, AddressOf portButton_MouseEnter
            AddHandler portButton(i).MouseLeave, AddressOf portButton_MouseLeave

            Controls.Add(portButton(i))
        Next i


       




    End Sub


    Private Sub portButton_MouseEnter(Sender As Object, e As EventArgs)
        Sender.backgroundImage = UIDEV.My.Resources.Resources.b_blue_fuzz
    End Sub

    Private Sub portButton_MouseLeave(Sender As Object, e As EventArgs)
        Sender.backgroundImage = UIDEV.My.Resources.Resources.b_blue
    End Sub


    'Incoming Serial handling///////////////////////////////////////////////////
    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadExisting)
    End Sub

    Private Sub ReceivedText(ByVal [text] As String)
        '  If Me.tb_output.InvokeRequired Then
        Dim x As New setTextCallBack(AddressOf ReceivedText)
        Me.Invoke(x, New Object() {(text)})
        ' Else
        'Me.tb_output.Text &= [text]
        ' End If
    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub
End Class
