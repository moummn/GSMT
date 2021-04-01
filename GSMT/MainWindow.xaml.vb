Class MainWindow
    Private Sub Button1_Click(sender As Object, e As RoutedEventArgs) Handles Button1.Click
        Dim pg As Page = New Page1
        Content1.Content = pg.Content
    End Sub

    Private Sub Button2_Click(sender As Object, e As RoutedEventArgs) Handles Button2.Click
        Dim pg As Page = New Page2
        Content1.Content = pg.Content
    End Sub
End Class
