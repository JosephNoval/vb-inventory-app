Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class AdminForm
    'Fields
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    Private random As Random
    Private tempIndex As Integer

    'Constructor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        SidePanel.Controls.Add(leftBorderBtn)
        random = New Random()
        currentBtn = New IconButton()
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
    Private Sub ActivateButton(senderBtn As Object)
        If senderBtn IsNot Nothing Then
            If currentBtn.Name <> CType(senderBtn, IconButton).Name Then
                DisableButton()
                'Button
                Dim color As Color = SelectThemeColor()
                currentBtn = CType(senderBtn, IconButton)
                currentBtn.BackColor = Color.FromArgb(37, 36, 81)
                currentBtn.ForeColor = color
                currentBtn.IconColor = color
                currentBtn.TextAlign = ContentAlignment.MiddleCenter
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

                PanelTitleBar.BackColor = color
                PanelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3)
                ThemeColor.PrimaryColor = color
                ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3)

                'Left Border
                leftBorderBtn.BackColor = color
                leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
                leftBorderBtn.Visible = True
                leftBorderBtn.BringToFront()

                'Current Form Icon
                IconCurrentForm.IconChar = currentBtn.IconChar
                IconCurrentForm.IconColor = Color.Gainsboro

                txtCurrentUser.BackColor = color
            End If
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(39, 39, 58)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub
    Private Sub OpenChildForm(childForm As Form, btnSender As Object)
        'Open only form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        ActivateButton(btnSender)
        currentChildForm = childForm
        'end
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text

    End Sub
    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        If lblFormTitle.Text = "Orders" Then
            If DirectCast(currentChildForm, FormOrders).DataGridViewOrderDetails.RowCount > 0 Then
                DirectCast(currentChildForm, FormOrders).VoidOrderDetailItems()
            End If
        End If
        OpenChildForm(New FormUsers(), sender)
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        If lblFormTitle.Text = "Orders" Then
            If DirectCast(currentChildForm, FormOrders).DataGridViewOrderDetails.RowCount > 0 Then
                DirectCast(currentChildForm, FormOrders).VoidOrderDetailItems()
            End If
        End If
        OpenChildForm(New FormProducts(), sender)
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        If lblFormTitle.Text = "Orders" Then
            If DirectCast(currentChildForm, FormOrders).DataGridViewOrderDetails.RowCount > 0 Then
                DirectCast(currentChildForm, FormOrders).VoidOrderDetailItems()
            End If
        End If
        OpenChildForm(New FormInventory(), sender)
    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        If lblFormTitle.Text = "Orders" Then
            If DirectCast(currentChildForm, FormOrders).DataGridViewOrderDetails.RowCount > 0 Then
                Exit Sub
            End If
        End If
        OpenChildForm(New FormOrders(), sender)
    End Sub

    Private Sub ImageHome_Click(sender As Object, e As EventArgs) Handles ImageHome.Click
        If lblFormTitle.Text = "Orders" Then
            If DirectCast(currentChildForm, FormOrders).DataGridViewOrderDetails.RowCount > 0 Then
                DirectCast(currentChildForm, FormOrders).VoidOrderDetailItems()
            End If
        End If
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub
    Public Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.Gainsboro
        lblFormTitle.Text = "Home"
        PanelTitleBar.BackColor = Color.FromArgb(0, 150, 136)
        PanelLogo.BackColor = Color.FromArgb(39, 39, 58)
        txtCurrentUser.BackColor = Color.FromArgb(0, 150, 136)
        currentBtn = New IconButton()
        txtCurrentUser.Text = currentUserDisplayName
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

    Private Sub PanelDesktop_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelDesktop.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub SidePanel_MouseDown(sender As Object, e As MouseEventArgs) Handles SidePanel.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub IconPictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles IconPictureBox1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub AdminForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub
    'Close-Maximize-Minimize
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If lblFormTitle.Text = "Orders" Then
            If DirectCast(currentChildForm, FormOrders).DataGridViewOrderDetails.RowCount > 0 Then
                DirectCast(currentChildForm, FormOrders).VoidOrderDetailItems()
            End If
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
        If lblFormTitle.Text = "Orders" Then
            If DirectCast(currentChildForm, FormOrders).DataGridViewOrderDetails.RowCount > 0 Then
                DirectCast(currentChildForm, FormOrders).VoidOrderDetailItems()
            End If
        End If
        currentUserId = 0
        currentUserAccess = ""
        currentUserDisplayName = ""
        txtCurrentUser.Text = ""
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
        Me.Hide()
        FormLogin.Show()
    End Sub

    Private Sub AdminForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If lblFormTitle.Text = "Orders" Then
            If DirectCast(currentChildForm, FormOrders).DataGridViewOrderDetails.RowCount > 0 Then
                DirectCast(currentChildForm, FormOrders).VoidOrderDetailItems()
            End If
        End If
    End Sub
End Class
