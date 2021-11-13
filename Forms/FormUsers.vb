Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient

Public Class FormUsers
    Private Sub FormUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTheme()
        ResetMe()
        LoadData()
    End Sub
    Private Sub LoadTheme()
        For Each ctns As Control In Me.Controls
            If ctns.[GetType]() = GetType(IconButton) Then
                Dim btn As IconButton = CType(ctns, IconButton)
                btn.BackColor = ThemeColor.PrimaryColor
                btn.ForeColor = Color.White
                btn.IconColor = Color.White
                btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor
            End If
            If ctns.[GetType]() = GetType(Label) Then
                Dim lbl As Label = CType(ctns, Label)
                lbl.ForeColor = ThemeColor.PrimaryColor
            End If
            If ctns.[GetType]() = GetType(TextBox) Then
                Dim txt As TextBox = CType(ctns, TextBox)
                txt.ForeColor = ThemeColor.SecondaryColor
            End If
            If ctns.[GetType]() = GetType(ComboBox) Then
                Dim cbx As ComboBox = CType(ctns, ComboBox)
                cbx.ForeColor = ThemeColor.SecondaryColor
            End If
            If ctns.[GetType]() = GetType(GroupBox) Then
                Dim grp As GroupBox = CType(ctns, GroupBox)
                grp.ForeColor = ThemeColor.PrimaryColor
                For Each grpctns As Control In grp.Controls
                    If grpctns.[GetType]() = GetType(Label) Then
                        Dim grplbl As Label = CType(grpctns, Label)
                        grplbl.ForeColor = ThemeColor.PrimaryColor
                    End If
                    If grpctns.[GetType]() = GetType(IconButton) Then
                        Dim grpbtn As IconButton = CType(grpctns, IconButton)
                        grpbtn.BackColor = ThemeColor.PrimaryColor
                        grpbtn.ForeColor = Color.White
                        grpbtn.IconColor = Color.White
                        grpbtn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor
                    End If
                    If grpctns.[GetType]() = GetType(TextBox) Then
                        Dim grptxt As TextBox = CType(grpctns, TextBox)
                        grptxt.ForeColor = ThemeColor.SecondaryColor
                    End If
                    If grpctns.[GetType]() = GetType(ComboBox) Then
                        Dim grpcbx As ComboBox = CType(grpctns, ComboBox)
                        grpcbx.ForeColor = ThemeColor.SecondaryColor
                    End If
                    If grpctns.[GetType]() = GetType(Panel) Then
                        Dim panel As Panel = CType(grpctns, Panel)
                        For Each panelctns As Control In panel.Controls
                            If panelctns.[GetType]() = GetType(TextBox) Then
                                Dim paneltxt As TextBox = CType(panelctns, TextBox)
                                paneltxt.ForeColor = ThemeColor.SecondaryColor
                            End If
                            If panelctns.[GetType]() = GetType(DataGridView) Then
                                Dim panelgrid As DataGridView = CType(panelctns, DataGridView)
                                panelgrid.ForeColor = ThemeColor.SecondaryColor
                            End If
                            If panelctns.[GetType]() = GetType(IconButton) Then
                                Dim panelbtn As IconButton = CType(panelctns, IconButton)
                                panelbtn.BackColor = ThemeColor.PrimaryColor
                                panelbtn.ForeColor = Color.White
                                panelbtn.IconColor = Color.White
                                panelbtn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor
                            End If
                        Next
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub Execute(MySQL As String, Optional Parameter As String = "")
        Cmd = New MySqlCommand(MySQL, Con)
        AddParameters(Parameter)
        PerformCRUD(Cmd)
    End Sub

    Private Sub AddParameters(str As String)
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("DisplayName", txtDisplayName.Text)
        Cmd.Parameters.AddWithValue("Position", txtPosition.Text)
        Cmd.Parameters.AddWithValue("UserAccess", cbxUserAccess.Text)
        Cmd.Parameters.AddWithValue("Username", txtUsername.Text)
        Cmd.Parameters.AddWithValue("Password", txtPassword.Text)
        Cmd.Parameters.AddWithValue("RecordStatus", cbxRecordStatus.Text)

        If str = "Update" Or str = "Delete" And Not String.IsNullOrEmpty(txtId.Text) Then
            Cmd.Parameters.AddWithValue("Id", txtId.Text)
        Else
            If currentUserId > 0 Then
                Cmd.Parameters.AddWithValue("CreatedBy", currentUserId)
            End If
            Cmd.Parameters.AddWithValue("CreatedOn", DateTime.Now)
        End If
    End Sub
    Private Sub ResetMe()
        txtId.Text = ""
        txtDisplayName.Text = ""
        txtPosition.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtRePassword.Text = ""
        cbxUserAccess.SelectedIndex = 0
        cbxRecordStatus.SelectedIndex = 0
        cbxRecordStatus.Enabled = False
        txtDisplayName.Select()
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnSave.Enabled = True
    End Sub

    Private Sub LoadData(Optional keyword As String = "")
        keyword = "%" + keyword + "%"
        SQL = "Select a.Id, a.DisplayName, a.Username, a.Password, a.UserAccess, a.Position, b.DisplayName as CreatedBy, a.CreatedOn, a.RecordStatus 
                    from Users a left join Users b on a.CreatedBy  = b.Id
                    where a.Id Like @keyword or a.DisplayName Like @keyword or a.Username Like @keyword 
                    or a.Position Like @keyword or a.UserAccess Like @keyword or a.RecordStatus Like @keyword
                    or a.CreatedOn Like @keyword or b.DisplayName Like @keyword"
        Cmd = New MySqlCommand(SQL, Con)
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("keyword", keyword)

        Dim dt As DataTable = PerformCRUD(Cmd)
        DataGridViewUser.DataSource = dt

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' fields validation
        If String.IsNullOrEmpty(txtDisplayName.Text) Or
            String.IsNullOrEmpty(txtPosition.Text) Or
            String.IsNullOrEmpty(txtUsername.Text) Or
            String.IsNullOrEmpty(txtPassword.Text) Or
            String.IsNullOrEmpty(txtRePassword.Text) Or
            String.IsNullOrEmpty(cbxUserAccess.Text) Or
            String.IsNullOrEmpty(cbxRecordStatus.Text) Then
            MessageBox.Show("Please input all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If txtPassword.Text <> txtRePassword.Text Then
            MessageBox.Show("Password did not match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRePassword.Select()
            Exit Sub
        End If

        ' slq insert command
        SQL = "Insert into Users(DisplayName, Username, Password, UserAccess, Position, CreatedOn, CreatedBy, RecordStatus) Values(@DisplayName, @Username, @Password, @UserAccess, @Position, @CreatedOn, @CreatedBy, @RecordStatus)"
        Execute(SQL, "Insert")
        MessageBox.Show("User Successfully Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadData()
        ResetMe()
    End Sub

    Private Sub btnSearchClear_Click(sender As Object, e As EventArgs) Handles btnSearchClear.Click
        txtSearchBox.Text = ""
    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        LoadData(txtSearchBox.Text)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ResetMe()
        LoadData()
    End Sub

    Private Sub DataGridViewUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewUser.CellClick
        Try
            Dim dgv As DataGridView = DataGridViewUser
            If e.RowIndex <> -1 Then
                txtId.Text = Convert.ToString(dgv.CurrentRow.Cells(0).Value)
                txtDisplayName.Text = Convert.ToString(dgv.CurrentRow.Cells(1).Value)
                txtUsername.Text = Convert.ToString(dgv.CurrentRow.Cells(2).Value)
                txtPassword.Text = Convert.ToString(dgv.CurrentRow.Cells(3).Value)
                txtRePassword.Text = Convert.ToString(dgv.CurrentRow.Cells(3).Value)
                cbxUserAccess.Text = Convert.ToString(dgv.CurrentRow.Cells(4).Value)
                txtPosition.Text = Convert.ToString(dgv.CurrentRow.Cells(5).Value)
                cbxRecordStatus.Text = Convert.ToString(dgv.CurrentRow.Cells(8).Value)
                cbxRecordStatus.Enabled = Convert.ToString(dgv.CurrentRow.Cells(8).Value) = "In Active"
                btnUpdate.Enabled = True
                cbxUserAccess.Enabled = currentUserId <> Convert.ToInt64(dgv.CurrentRow.Cells(0).Value)
                btnDelete.Enabled = Convert.ToString(dgv.CurrentRow.Cells(8).Value) = "Active" And currentUserId <> Convert.ToInt64(dgv.CurrentRow.Cells(0).Value)
                btnSave.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' fields validation
        If String.IsNullOrEmpty(txtDisplayName.Text) Or
            String.IsNullOrEmpty(txtPosition.Text) Or
            String.IsNullOrEmpty(txtUsername.Text) Or
            String.IsNullOrEmpty(txtPassword.Text) Or
            String.IsNullOrEmpty(txtRePassword.Text) Or
            String.IsNullOrEmpty(cbxUserAccess.Text) Or
            String.IsNullOrEmpty(cbxRecordStatus.Text) Then
            MessageBox.Show("Please input all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If txtPassword.Text <> txtRePassword.Text Then
            MessageBox.Show("Password did not match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        ' slq insert command
        SQL = "Update Users set DisplayName = @DisplayName, Username = @Username, Password = @Password, UserAccess = @UserAccess, Position = @Position, RecordStatus = @RecordStatus where Id = @Id"
        Execute(SQL, "Update")
        MessageBox.Show("User Successfully Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadData()
        ResetMe()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' fields validation
        If String.IsNullOrEmpty(txtId.Text) Then
            MessageBox.Show("Please select user to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim result As DialogResult = MessageBox.Show("Confirm Delete?",
                              "User Delete",
                              MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            'Delete command
            SQL = "Update Users set RecordStatus = 'In Active' where Id = @Id"
            Execute(SQL, "Delete")
            MessageBox.Show("User Successfully Deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData()
            ResetMe()
        End If
    End Sub
End Class