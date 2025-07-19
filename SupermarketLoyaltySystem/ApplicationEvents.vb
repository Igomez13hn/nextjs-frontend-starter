Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed. This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active.
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    ' ApplyApplicationDefaults: Raised when the application queries default values to be set for the application.

    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Try
                ' Mostrar formulario de login primero
                Dim loginForm As New LoginForm()
                If loginForm.ShowDialog() = DialogResult.OK Then
                    ' Si el login es exitoso, mostrar el formulario principal
                    Dim mainForm As New MainForm()
                    Me.MainForm = mainForm
                Else
                    ' Si el login falla o se cancela, cerrar la aplicación
                    e.Cancel = True
                End If
            Catch ex As Exception
                Logger.Log(ex)
                MessageBox.Show("Error al iniciar la aplicación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Cancel = True
            End Try
        End Sub

        Private Sub MyApplication_ApplyApplicationDefaults(sender As Object, e As ApplyApplicationDefaultsEventArgs) Handles Me.ApplyApplicationDefaults
            ' Configuración de la aplicación
            e.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
            e.HighDpiMode = HighDpiMode.PerMonitorV2
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            ' Manejar excepciones no controladas
            Logger.Log(e.Exception)
            MessageBox.Show("Ha ocurrido un error inesperado. La aplicación se cerrará.", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.ExitApplication = True
        End Sub

    End Class
End Namespace
