Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class FormQuantity
    Public qtyOnHand As Double
    Public Sub New(Optional qty As Double = 0)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        qtyOnHand = qty
    End Sub
    Private Sub FormQuantity_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadTheme()
        txtQuantity.Text = ""
        txtQuantity.Select()
    End Sub
    Private Sub LoadTheme()
        For Each ctns As Control In Me.Controls
            If ctns.[GetType]() = GetType(Panel) Then
                Dim grp As Panel = CType(ctns, Panel)
                If grp.Name = "TitleBar" Then
                    grp.BackColor = ThemeColor.PrimaryColor
                End If
                If grp.Name = "FormPanel" Then
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
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Set the result to pass back to the form that called this dialog
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Private Sub TitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseDown, FormPanel.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        ' accept numbers only
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
        If Asc(e.KeyChar) = Keys.Enter Then
            If String.IsNullOrEmpty(txtQuantity.Text) Then
                MessageBox.Show("Please input quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtQuantity.Select()
            Else
                If Convert.ToDouble(txtQuantity.Text) > 0 Then
                    If Convert.ToDouble(txtQuantity.Text) > qtyOnHand Then
                        MessageBox.Show("Quantity must be less than or equal to Product Qty On Hand.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtQuantity.Text = ""
                        txtQuantity.Select()
                    Else
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                Else
                    MessageBox.Show("Please input valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtQuantity.Text = ""
                    txtQuantity.Select()
                End If
            End If
        ElseIf Asc(e.KeyChar) = Keys.Escape Then
            txtQuantity.Text = ""
        End If
    End Sub
End Class