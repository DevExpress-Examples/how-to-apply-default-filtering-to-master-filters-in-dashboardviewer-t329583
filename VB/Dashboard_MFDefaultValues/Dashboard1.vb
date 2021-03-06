﻿Imports DevExpress.DashboardCommon
Imports DevExpress.DataAccess.ConnectionParameters

Namespace Dashboard_MFDefaultValues
    Partial Public Class Dashboard1
        Inherits DevExpress.DashboardCommon.Dashboard

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Dashboard1_ConfigureDataConnection(ByVal sender As Object, ByVal e As DashboardConfigureDataConnectionEventArgs) Handles Me.ConfigureDataConnection
            If e.DataSourceName = "SQL Data Source 1" Then

                ' Gets connection parameters used to establish a connection to the database.
                Dim parameters As Access97ConnectionParameters = CType(e.ConnectionParameters, Access97ConnectionParameters)
                Dim databasePath As String = "..\..\Data\nwind.mdb"

                ' Specifies the path to a database file.                    
                parameters.FileName = databasePath
            End If
        End Sub
    End Class
End Namespace
