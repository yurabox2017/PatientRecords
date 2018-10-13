Imports System.IO
Class Application


    ' События приложения, например, Startup, Exit и DispatcherUnhandledException,
    ' можно обрабатывать в данном файле.
    Private Sub Application_DispatcherUnhandledException(sender As Object, e As System.Windows.Threading.DispatcherUnhandledExceptionEventArgs) Handles Me.DispatcherUnhandledException
        MessageBox.Show(e.Exception.Message, "Ошибка в программе", MessageBoxButton.OK, MessageBoxImage.Error)
        e.Handled = True
    End Sub
End Class
