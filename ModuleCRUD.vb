Option Explicit On
Option Strict On

Imports MySql.Data.MySqlClient
Imports System.Configuration

Module ModuleCRUD
    ' current user
    Public currentUserId As Long
    Public currentUserDisplayName As String
    Public currentUserAccess As String
    ' connection string from app.config
    Public Constring As String = ConfigurationManager.ConnectionStrings("InventoryManagementApp.My.MySettings.DBConnectionString").ConnectionString
    Public Con As New MySqlConnection(Constring)
    Public Cmd As MySqlCommand
    Public SQL As String = String.Empty

    Public Function PerformCRUD(Com As MySqlCommand) As DataTable

        Dim da As MySqlDataAdapter
        Dim dt As New DataTable()
        da = New MySqlDataAdapter
        da.SelectCommand = Com
        da.Fill(dt)

        Return dt
    End Function
End Module
