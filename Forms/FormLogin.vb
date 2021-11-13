Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class FormLogin
    'Constructor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CustomizeComponents()
    End Sub

    'Drag Form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    ' Customize Controls
    Private Sub CustomizeComponents()
        txtUsername.AutoSize = False
        txtUsername.Size = New Size(350, 45)
        txtPassword.AutoSize = False
        txtPassword.Size = New Size(350, 45)
        txtPassword.UseSystemPasswordChar = True
    End Sub

    ' Form Behaviours
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub FormLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub CheckBoxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPassword.CheckedChanged
        If CheckBoxShowPassword.CheckState = CheckState.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub ResetMe()
        txtPassword.Text = ""
        txtUsername.Text = ""
        CheckBoxShowPassword.Checked = False
        txtUsername.Select()
    End Sub

    Private Sub Login()
        ' fields validation
        If String.IsNullOrEmpty(txtUsername.Text) Or
            String.IsNullOrEmpty(txtPassword.Text) Then
            MessageBox.Show("Please input all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        SQL = "Select * from Users where Username = _utf8 @Username collate utf8_bin and Password = _utf8 @Password collate utf8_bin"
        Cmd = New MySqlCommand(SQL, Con)
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("Username", txtUsername.Text)
        Cmd.Parameters.AddWithValue("Password", txtPassword.Text)
        Dim dt As DataTable = PerformCRUD(Cmd)
        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).ItemArray(8) <> "Active" Then
                MessageBox.Show("User is not active.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ResetMe()
                Exit Sub
            End If
            currentUserId = dt.Rows.Item(0).ItemArray(0)
            currentUserDisplayName = dt.Rows.Item(0).ItemArray(1)
            currentUserAccess = dt.Rows.Item(0).ItemArray(4)
            ResetMe()
            Me.Hide()
            If dt.Rows.Item(0).ItemArray(4) = "Admin" Then
                AdminForm.txtCurrentUser.Text = currentUserDisplayName
                AdminForm.Show()
            Else
                StandardForm.lblCurrentUser.Text = currentUserDisplayName
                StandardForm.OpenOrderForm()
                StandardForm.Show()
            End If
        Else
            MessageBox.Show("Incorrect User Credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ResetMe()
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetMe()
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Login()
        ElseIf Asc(e.KeyChar) = Keys.Escape Then
            txtPassword.Text = ""
        End If
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtPassword.Text = ""
            txtPassword.Select()
        ElseIf Asc(e.KeyChar) = Keys.Escape Then
            txtUsername.Text = ""
        End If
    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()
    End Sub

    Private Sub btnLogin_Paint(sender As Object, e As PaintEventArgs) Handles btnLogin.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnLogin.ClientRectangle
        myRectangle.Inflate(0, 35)
        buttonPath.AddEllipse(myRectangle)
        btnLogin.Region = New Region(buttonPath)
    End Sub
End Class