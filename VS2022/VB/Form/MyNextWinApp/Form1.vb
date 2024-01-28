Public Class Form1

    'A program is not very interesting unless you can intereact with it
    'and get something back. So here we dragged a button from the toolbox
    'over to the design form and double click it to open the code view.
    'Below is the Button Sub, that we put the MessageBox.Show line in to
    'print something out. This replaces the console.writeline() in the 
    'console application program. 

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("My name is AppaBaba")
    End Sub

End Class
