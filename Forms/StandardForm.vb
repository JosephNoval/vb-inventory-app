Imports System.ComponentModel
Imports System.Runtime.InteropServices

Public Class StandardForm
    ' fields
    Private currentOrderForm As FormOrders
    Private random As Random
    Private tempIndex As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        random = New Random()
        'Form
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub
    'METHODS'
    Private Function SelectThemeColor() As Color
        Dim index As Integer = random.[Next](ThemeColor.ColorList.Count)
        While tempIndex = index
            index = random.[Next](ThemeColor.ColorList.Count)
        End While
        tempIndex = index
        Dim color As String = ThemeColor.ColorList(index)
        Return ColorTranslator.FromHtml(color)
    End Function

    Public Sub LoadTheme()
        Dim color As Color = SelectThemeColor()
        PanelTitleBar.BackColor = color
        ThemeColor.PrimaryColor = color
        ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3)
    End Sub

    Public Sub OpenOrderForm()
        'Open only form
        If currentOrderForm IsNot Nothing Then
            currentOrderForm.Close()
        End If
        LoadTheme()
        currentOrderForm = New FormOrders()
        'end
        currentOrderForm.TopLevel = False
        currentOrderForm.FormBorderStyle = FormBorderStyle.None
        currentOrderForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(currentOrderForm)
        PanelDesktop.Tag = currentOrderForm
        currentOrderForm.BringToFront()
        currentOrderForm.Show()

    End Sub

    Private Sub StandardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenOrderForm()
    End Sub
    'Drag Form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub StandardForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub
    'Close-Maximize-Minimize
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If currentOrderForm.DataGridViewOrderDetails.RowCount > 0 Then
            currentOrderForm.VoidOrderDetailItems()
        End If
        Application.Exit()
    End Sub

    Private Sub btnMaximized_Click(sender As Object, e As EventArgs) Handles btnMaximized.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If currentOrderForm.DataGridViewOrderDetails.RowCount > 0 Then
            currentOrderForm.VoidOrderDetailItems()
        End If
        currentUserId = 0
        currentUserAccess = ""
        currentUserDisplayName = ""
        lblCurrentUser.Text = ""
        Me.Hide()
        FormLogin.Show()
    End Sub

    Private Sub IconCurrentForm_Click(sender As Object, e As EventArgs) Handles IconCurrentForm.Click
        LoadTheme()
        currentOrderForm.LoadTheme()
    End Sub

    Private Sub StandardForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If currentOrderForm.DataGridViewOrderDetails.RowCount > 0 Then
            currentOrderForm.VoidOrderDetailItems()
        End If
    End Sub
End Class