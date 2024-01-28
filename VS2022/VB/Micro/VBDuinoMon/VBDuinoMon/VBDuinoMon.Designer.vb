<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VbduinoMon
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
        Me.SP01 = New System.IO.Ports.SerialPort(Me.components)
        Me.SendTB01 = New System.Windows.Forms.TextBox()
        Me.RTBox01 = New System.Windows.Forms.RichTextBox()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SelectPort = New System.Windows.Forms.ComboBox()
        Me.SendButton = New System.Windows.Forms.Button()
        Me.SelectBaudRate = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'SP01
        '
        '
        'SendTB01
        '
        Me.SendTB01.Location = New System.Drawing.Point(0, 12)
        Me.SendTB01.Name = "SendTB01"
        Me.SendTB01.Size = New System.Drawing.Size(700, 26)
        Me.SendTB01.TabIndex = 0
        '
        'RTBox01
        '
        Me.RTBox01.Location = New System.Drawing.Point(0, 74)
        Me.RTBox01.Name = "RTBox01"
        Me.RTBox01.Size = New System.Drawing.Size(800, 303)
        Me.RTBox01.TabIndex = 1
        Me.RTBox01.Text = ""
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(527, 393)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(101, 39)
        Me.ConnectButton.TabIndex = 2
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(653, 393)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(97, 39)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SelectPort
        '
        Me.SelectPort.FormattingEnabled = True
        Me.SelectPort.Location = New System.Drawing.Point(218, 399)
        Me.SelectPort.Name = "SelectPort"
        Me.SelectPort.Size = New System.Drawing.Size(121, 28)
        Me.SelectPort.TabIndex = 4
        '
        'SendButton
        '
        Me.SendButton.Location = New System.Drawing.Point(713, 15)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(75, 30)
        Me.SendButton.TabIndex = 6
        Me.SendButton.Text = "Send"
        Me.SendButton.UseVisualStyleBackColor = True
        '
        'SelectBaudRate
        '
        Me.SelectBaudRate.FormattingEnabled = True
        Me.SelectBaudRate.Items.AddRange(New Object() {"300", "600", "1200", "2400", "4800", "9600", "19200", "38400"})
        Me.SelectBaudRate.Location = New System.Drawing.Point(372, 399)
        Me.SelectBaudRate.Name = "SelectBaudRate"
        Me.SelectBaudRate.Size = New System.Drawing.Size(121, 28)
        Me.SelectBaudRate.TabIndex = 7
        Me.SelectBaudRate.Text = "Select Baud"
        '
        'VbduinoMon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SelectBaudRate)
        Me.Controls.Add(Me.SendButton)
        Me.Controls.Add(Me.SelectPort)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ConnectButton)
        Me.Controls.Add(Me.RTBox01)
        Me.Controls.Add(Me.SendTB01)
        Me.Name = "VbduinoMon"
        Me.Text = "VBDuinoMon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SP01 As IO.Ports.SerialPort
    Friend WithEvents SendTB01 As TextBox
    Friend WithEvents RTBox01 As RichTextBox
    Friend WithEvents ConnectButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SelectPort As ComboBox
    Friend WithEvents SendButton As Button
    Friend WithEvents SelectBaudRate As ComboBox
End Class
