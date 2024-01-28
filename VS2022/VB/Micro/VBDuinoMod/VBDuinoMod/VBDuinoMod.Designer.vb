<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VBDuinoMod
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
        Me.SelectPort = New System.Windows.Forms.ComboBox()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.OnButton = New System.Windows.Forms.Button()
        Me.OffButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SelectPort
        '
        Me.SelectPort.FormattingEnabled = True
        Me.SelectPort.Location = New System.Drawing.Point(474, 62)
        Me.SelectPort.Name = "SelectPort"
        Me.SelectPort.Size = New System.Drawing.Size(121, 28)
        Me.SelectPort.TabIndex = 0
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(474, 179)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(121, 33)
        Me.ConnectButton.TabIndex = 1
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(44, 115)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(274, 248)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        '
        'OnButton
        '
        Me.OnButton.Location = New System.Drawing.Point(409, 333)
        Me.OnButton.Name = "OnButton"
        Me.OnButton.Size = New System.Drawing.Size(75, 30)
        Me.OnButton.TabIndex = 5
        Me.OnButton.Text = "ON"
        Me.OnButton.UseVisualStyleBackColor = True
        '
        'OffButton
        '
        Me.OffButton.Location = New System.Drawing.Point(549, 333)
        Me.OffButton.Name = "OffButton"
        Me.OffButton.Size = New System.Drawing.Size(75, 30)
        Me.OffButton.TabIndex = 6
        Me.OffButton.Text = "OFF"
        Me.OffButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.OffButton)
        Me.Controls.Add(Me.OnButton)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ConnectButton)
        Me.Controls.Add(Me.SelectPort)
        Me.Name = "Form1"
        Me.Text = "VBDuinoMod"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SP01 As IO.Ports.SerialPort
    Friend WithEvents SelectPort As ComboBox
    Friend WithEvents ConnectButton As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents OnButton As Button
    Friend WithEvents OffButton As Button
End Class
