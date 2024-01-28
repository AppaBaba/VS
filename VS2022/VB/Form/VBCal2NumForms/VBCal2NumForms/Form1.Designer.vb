<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tB1 = New System.Windows.Forms.TextBox()
        Me.tB2 = New System.Windows.Forms.TextBox()
        Me.tB3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tB1
        '
        Me.tB1.Location = New System.Drawing.Point(64, 74)
        Me.tB1.Name = "tB1"
        Me.tB1.Size = New System.Drawing.Size(150, 31)
        Me.tB1.TabIndex = 0
        '
        'tB2
        '
        Me.tB2.Location = New System.Drawing.Point(64, 161)
        Me.tB2.Name = "tB2"
        Me.tB2.Size = New System.Drawing.Size(150, 31)
        Me.tB2.TabIndex = 1
        '
        'tB3
        '
        Me.tB3.Location = New System.Drawing.Point(64, 255)
        Me.tB3.Name = "tB3"
        Me.tB3.Size = New System.Drawing.Size(150, 31)
        Me.tB3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(292, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(292, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Second Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(292, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Answer"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(64, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Addition"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(194, 352)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 34)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Subtraction"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(321, 352)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 34)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Multipication"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(459, 352)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 34)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Divition"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 450)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tB3)
        Me.Controls.Add(Me.tB2)
        Me.Controls.Add(Me.tB1)
        Me.Name = "Form1"
        Me.Text = "VBCal2NumForms"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tB1 As TextBox
    Friend WithEvents tB2 As TextBox
    Friend WithEvents tB3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
