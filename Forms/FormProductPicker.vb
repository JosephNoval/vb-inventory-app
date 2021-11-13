Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class FormProductPicker
    Public Sub New(Optional query = "select a.Id, a.Name as ProductName, ((select COALESCE(SUM(Quantity), 0) from Inventory where ProductId = a.Id and RecordStatus = 'Active') - ((select COALESCE(SUM(Quantity), 0) from OrderDetails where ProductId = a.Id and RecordStatus = 'Active') + a.QuantityOrdered)) as QuantityOnHand, a.Price
                from Products a 
                where a.RecordStatus = 'Active' and (a.Id Like @keyword or a.Name Like @keyword or a.Price Like @keyword 
                or ((select COALESCE(SUM(Quantity), 0) from Inventory where ProductId = a.Id and RecordStatus = 'Active') - ((select COALESCE(SUM(Quantity), 0) from OrderDetails where ProductId = a.Id and RecordStatus = 'Active') + a.QuantityOrdered)) Like @keyword)")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SQL = query
    End Sub
    Private Sub FormProductPicker_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadTheme()
        LoadData()
    End Sub
    Private Sub LoadTheme()
        For Each ctns As Control In Me.Controls
            If ctns.[GetType]() = GetType(Panel) Then
                Dim grp As Panel = CType(ctns, Panel)
                If grp.Name = "TitleBar" Then
                    grp.BackColor = ThemeColor.PrimaryColor
                End If
                If grp.Name = "FooterBar" Then
                    grp.BackColor = ThemeColor.SecondaryColor
                End If
                For Each grpctns As Control In grp.Controls
                    If grpctns.[GetType]() = GetType(Panel) Then
                        Dim panctns As Panel = CType(grpctns, Panel)
                        For Each grpPans As Control In panctns.Controls
                            If grpPans.[GetType]() = GetType(Label) Then
                                Dim panlbl As Label = CType(grpPans, Label)
                                panlbl.ForeColor = ThemeColor.PrimaryColor
                            End If
                            If grpPans.[GetType]() = GetType(IconButton) Then
                                Dim panbtn As IconButton = CType(grpPans, IconButton)
                                panbtn.BackColor = ThemeColor.PrimaryColor
                                panbtn.ForeColor = Color.White
                                panbtn.IconColor = Color.White
                                panbtn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor
                            End If
                            If grpPans.[GetType]() = GetType(TextBox) Then
                                Dim pantxt As TextBox = CType(grpPans, TextBox)
                                pantxt.ForeColor = ThemeColor.SecondaryColor
                            End If
                            If grpPans.[GetType]() = GetType(DataGridView) Then
                                Dim pangrid As DataGridView = CType(grpPans, DataGridView)
                                pangrid.ForeColor = ThemeColor.SecondaryColor
                            End If
                        Next
                    End If
                Next
            End If
        Next
    End Sub
    'Drag Form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    ' Load Data
    Private Sub LoadData(Optional keyword As String = "")
        keyword = "%" + keyword + "%"
        Cmd = New MySqlCommand(SQL, Con)
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("keyword", keyword)

        Dim dt As DataTable = PerformCRUD(Cmd)
        DataGridViewProduct.DataSource = dt

    End Sub
    ' Form Behaviours
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Set the result to pass back to the form that called this dialog
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub TitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnSearchClear_Click(sender As Object, e As EventArgs) Handles btnSearchClear.Click
        txtSearchBox.Text = ""
    End Sub
    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        LoadData(txtSearchBox.Text)
    End Sub

    Private Sub DataGridViewProduct_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProduct.CellDoubleClick
        ' Set the result to pass back to the form that called this dialog
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class