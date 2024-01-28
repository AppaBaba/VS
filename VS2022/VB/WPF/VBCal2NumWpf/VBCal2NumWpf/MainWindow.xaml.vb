Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim FN, SN, Ans As Double
        FN = tB1.Text
        SN = tB2.Text
        Ans = FN + SN
        tB3.Text = Ans
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim FN, SN, Ans As Double
        FN = tB1.Text
        SN = tB2.Text
        Ans = FN - SN
        tB3.Text = Ans
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Dim FN, SN, Ans As Double
        FN = tB1.Text
        SN = tB2.Text
        Ans = FN * SN
        tB3.Text = Ans
    End Sub

    Private Sub Button_Click_3(sender As Object, e As RoutedEventArgs)
        Dim FN, SN, Ans As Double
        FN = tB1.Text
        SN = tB2.Text
        Ans = FN / SN
        tB3.Text = Ans
    End Sub
End Class
