Imports System.Configuration

Public Class AppConfig

    Private _config As Configuration
    Private _settings As AppSettingsSection

    Public Sub New(ByVal sPath_ As String)
        _config = ConfigurationManager.OpenExeConfiguration(sPath_)
        _settings = _config.AppSettings
    End Sub

#Region "Funciones públicas"
    Public Function GetProperty(ByVal sPropertyName_ As String) As String
        Return _settings.Settings.Item(sPropertyName_).Value
    End Function

    Public Function GetAllProperties() As List(Of String)
        Dim sListaApps As New List(Of String)
        For Each key As String In _settings.Settings.AllKeys
            sListaApps.Add(_settings.Settings.Item(key).Value)
        Next
        Return sListaApps
    End Function

    Public Sub RemoveProperty(ByVal iNumber_ As Integer)
        _settings.Settings.Remove("path" & iNumber_)
        ResetConfigKeys()
        Me.Finalize()
    End Sub

    Public Sub RemoveAllProperties()
        For Each key As String In _settings.Settings.AllKeys
            _settings.Settings.Remove(key)
        Next
        Me.Finalize()
    End Sub

    Public Sub SetProperty(ByVal sPropertyName_ As String, ByVal propertyValue As String)
        _settings.Settings.Item(sPropertyName_).Value = propertyValue
        Me.Finalize()
    End Sub

    Public Sub AddProperty(ByVal sPropertyValue_ As String)
        _settings.Settings.Add("path" & _settings.Settings.Count, sPropertyValue_)
        Me.Finalize()
    End Sub
#End Region

#Region "Funciones privadas"
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        _config.Save(ConfigurationSaveMode.Modified)
    End Sub

    Private Sub ResetConfigKeys()
        Dim sListaApps As New List(Of String)

        sListaApps = GetAllProperties()
        RemoveAllProperties()

        For Each element As String In sListaApps
            AddProperty(element)
        Next
    End Sub
#End Region
End Class
