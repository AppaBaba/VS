Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FN, SN, Ans As Double
        FN = tB1.Text
        SN = tB2.Text
        Ans = FN + SN
        tB3.Text = Ans
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FN, SN, Ans As Double
        FN = tB1.Text
        SN = tB2.Text
        Ans = FN - SN
        tB3.Text = Ans
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim FN, SN, Ans As Double
        FN = tB1.Text
        SN = tB2.Text
        Ans = FN * SN
        tB3.Text = Ans
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim FN, SN, Ans As Double
        FN = tB1.Text
        SN = tB2.Text
        Ans = FN / SN
        tB3.Text = Ans
    End Sub

End Class
