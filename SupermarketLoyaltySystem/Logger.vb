Imports System.IO

Public Module Logger
    Private ReadOnly LogFilePath As String = "error_log.txt"

    Public Sub Log(ex As Exception)
        Try
            Dim logMessage As String = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}: {ex.Message}{Environment.NewLine}{ex.StackTrace}{Environment.NewLine}{Environment.NewLine}"
            File.AppendAllText(LogFilePath, logMessage)
        Catch
            ' No lanzar excepciones adicionales desde el logging
        End Try
    End Sub

    Public Sub LogInfo(message As String)
        Try
            Dim logMessage As String = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}: INFO - {message}{Environment.NewLine}"
            File.AppendAllText(LogFilePath, logMessage)
        Catch
            ' No lanzar excepciones adicionales desde el logging
        End Try
    End Sub
End Module
