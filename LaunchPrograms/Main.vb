Public Class Main

    Private _appConfigManager As AppConfig

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Try
            _appConfigManager = New AppConfig(My.Application.Info.DirectoryPath & "\" & My.Application.Info.AssemblyName & ".exe")
            RefrescarListaAplicaciones()

        Catch ex As Exception
            MsgBox("Error de inicialización: " & ex.Message)
        End Try

    End Sub

#Region "Funcionalidad de los botones"
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            Dim fdPath As New OpenFileDialog
            fdPath.Title = "Seleccionar un programa"
            fdPath.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
            fdPath.FilterIndex = 2
            fdPath.RestoreDirectory = True

            If (fdPath.ShowDialog() = DialogResult.OK) Then
                _appConfigManager.AddProperty(fdPath.FileName)
                RefrescarListaAplicaciones()
            End If
        Catch ex As Exception
            MsgBox("Error de ejecución: " & ex.Message)
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            If lbProgramas.SelectedIndex = -1 Then
                MsgBox("No hay ningun elemento seleccionado!")
            Else
                _appConfigManager.RemoveProperty(lbProgramas.SelectedIndex)
                RefrescarListaAplicaciones()
            End If
        Catch ex As Exception
            MsgBox("Error de ejecución: " & ex.Message)
        End Try
    End Sub

    Private Sub btnResetLista_Click(sender As Object, e As EventArgs) Handles btnResetLista.Click
        Try
            _appConfigManager.RemoveAllProperties()
            RefrescarListaAplicaciones()
        Catch ex As Exception
            MsgBox("Error de ejecución: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLanzar_Click(sender As Object, e As EventArgs) Handles btnLanzar.Click
        Try

            For Each element As String In _appConfigManager.GetAllProperties
                Process.Start(element)
            Next
        Catch ex As Exception
            MsgBox("Error de ejecución: " & ex.Message)
        End Try
        Close()
    End Sub
#End Region

#Region "Funciones privadas"
    Private Sub RefrescarListaAplicaciones()
        Try
            lbProgramas.Items.Clear()
            For Each item As String In _appConfigManager.GetAllProperties
                lbProgramas.Items.Add(item)
            Next
        Catch ex As Exception
            MsgBox("Error de ejecución: " & ex.Message)
        End Try
    End Sub
#End Region

End Class
