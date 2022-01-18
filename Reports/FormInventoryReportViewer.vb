Imports FontAwesome.Sharp
Imports InventoryManagementApp.InventoryManagementApp
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class FormInventoryReportViewer
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        LoadReport()
    End Sub
    Private Sub LoadTheme()
        For Each ctns As Control In Me.Controls
            If ctns.[GetType]() = GetType(Panel) Then
                Dim grp As Panel = CType(ctns, Panel)
                For Each grpctns As Control In grp.Controls
                    If grpctns.[GetType]() = GetType(Label) Then
                        Dim panlbl As Label = CType(grpctns, Label)
                        panlbl.ForeColor = ThemeColor.PrimaryColor
                    End If
                    If grpctns.[GetType]() = GetType(IconButton) Then
                        Dim panbtn As IconButton = CType(grpctns, IconButton)
                        panbtn.BackColor = ThemeColor.PrimaryColor
                        panbtn.ForeColor = Color.White
                        panbtn.IconColor = Color.White
                        panbtn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor
                    End If
                    If grpctns.[GetType]() = GetType(TextBox) Then
                        Dim pantxt As TextBox = CType(grpctns, TextBox)
                        pantxt.ForeColor = ThemeColor.SecondaryColor
                    End If
                    If grpctns.[GetType]() = GetType(DateTimePicker) Then
                        Dim grpdtp As DateTimePicker = CType(grpctns, DateTimePicker)
                        grpdtp.CalendarForeColor = ThemeColor.SecondaryColor
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub FormInventoryReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTheme()
    End Sub
    Sub LoadReport()
        Dim rptDS As ReportDataSource
        Me.ReportViewer.RefreshReport()
        Try
            Dim myparams As New List(Of ReportParameter)
            Dim myparam1 = New ReportParameter("FromDate", dtpFromDate.Value)
            Dim myparam2 = New ReportParameter("ToDate", dtpToDate.Value)
            myparams.Add(myparam1)
            myparams.Add(myparam2)

            With ReportViewer.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\InventoryReport.rdlc"
                .SetParameters(myparams)
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter
            Con.Open()
            da.SelectCommand = New MySqlCommand("SELECT b.Name as Description, a.InventoryDate, a.Quantity, b.Price, c.DisplayName as CreatedBy
	                                                FROM inventory a inner join products b on a.ProductId = b.Id
	                                                inner join users c on a.CreatedBy = c.Id
                                                    where a.RecordStatus = 'Active' and date(InventoryDate) between '" & dtpFromDate.Value.ToString("yyyy-MM-dd") & "' and '" & dtpToDate.Value.ToString("yyyy-MM-dd") & "'", Con)
            da.Fill(ds.Tables("DTInventory"))
            Con.Close()

            rptDS = New ReportDataSource("DataSet1", ds.Tables("DTInventory"))
            ReportViewer.LocalReport.DataSources.Add(rptDS)
            ReportViewer.SetDisplayMode(DisplayMode.PrintLayout)
            ReportViewer.ZoomMode = ZoomMode.Percent
            ReportViewer.ZoomPercent = 100

        Catch ex As Exception
            Con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class