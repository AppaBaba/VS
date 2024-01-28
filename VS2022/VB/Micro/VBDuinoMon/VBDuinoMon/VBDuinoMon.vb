Imports System
Imports System.IO.Ports

Public Class VbduinoMon
    Dim myCom As String

    Private Sub VbduinoMon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        myCom = ""
        Try
            For Each sp As String In My.Computer.Ports.SerialPortNames
                SelectPort.Items.Add(sp)
            Next
            SelectPort.SelectedIndex = 0
            SelectBaudRate.SelectedItem = "9600"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectPort.SelectedIndexChanged
        If (SelectPort.SelectedItem <> "") Then
            myCom = SelectPort.SelectedItem
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectBaudRate.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        If ConnectButton.Text = "Connect" Then
            SP01.PortName = SelectPort.SelectedItem
            SP01.BaudRate = Val(SelectBaudRate.SelectedItem)
            Try

                SP01.Open()
                ConnectButton.Text = "Disconnect"
                SendTB01.Enabled = True
                SP01.DataBits = 8
                SP01.Parity = Parity.None
                SP01.StopBits = StopBits.One
                SP01.Handshake = Handshake.None
                SP01.Encoding = System.Text.Encoding.Default 'very important!
                SP01.ReadTimeout = 10000
            Catch ex As Exception
            End Try
        Else
            SP01.Close()
            SendTB01.Enabled = False
            ConnectButton.Text = "Connect"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        RTBox01.Text = ""
    End Sub

    Private Sub SendTB01_KeyDown(sender As Object, e As KeyEventArgs) Handles SendTB01.KeyDown
        If e.KeyCode = Keys.Enter Then
            SP01.Write(SendTB01.Text)
            SendTB01.Clear()
        End If
    End Sub

    Private Sub SP01_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SP01.DataReceived
        RTBox01.Text &= SP01.ReadExisting()
    End Sub

    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        SP01.Write(SendTB01.Text)
        SendTB01.Clear()
    End Sub
End Class
