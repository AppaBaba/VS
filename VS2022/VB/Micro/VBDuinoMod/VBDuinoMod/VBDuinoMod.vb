Imports System
Imports System.IO.Ports

Public Class VBDuinoMod

    Dim myCom As String
    Dim feadback As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        myCom = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            SelectPort.Items.Add(sp)
        Next
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectPort.SelectedIndexChanged
        If (SelectPort.SelectedItem <> "") Then
            myCom = SelectPort.SelectedItem
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click

        SP01.Close()
        SP01.PortName = myCom
        SP01.BaudRate = 9600
        SP01.DataBits = 8
        SP01.Parity = Parity.None
        SP01.StopBits = StopBits.One
        SP01.Handshake = Handshake.None
        SP01.Encoding = System.Text.Encoding.Default 'very important!
        SP01.ReadTimeout = 10000





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles OnButton.Click
        SP01.Open()
        SP01.Write("1")
        feadback = SP01.ReadLine()
        RichTextBox1.AppendText(feadback)
        SP01.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles OffButton.Click
        SP01.Open()
        SP01.Write("0")
        feadback = SP01.ReadLine()
        RichTextBox1.AppendText(feadback)
        SP01.Close()
    End Sub
End Class