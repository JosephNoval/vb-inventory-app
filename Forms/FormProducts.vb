Imports MySql.Data.MySqlClient
Imports FontAwesome.Sharp

Public Class FormProducts
    Private Sub FormProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTheme()
        ResetMe()
        LoadData()
        LoadCategory()
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
        Cmd.Parameters.AddWithValue("Name", txtProductName.Text)
        Cmd.Parameters.AddWithValue("Description", txtDescription.Text)
        Cmd.Parameters.AddWithValue("CategoryId", cbxCategory.SelectedValue)
        Cmd.Parameters.AddWithValue("Price", txtPrice.Text)
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

    Private Function GetQuantityOnHand(ProductId As String) As Double
        SQL = "select ((select COALESCE(SUM(Quantity), 0) from Inventory where ProductId = @ProductId and RecordStatus = 'Active') - ((select COALESCE(SUM(Quantity), 0) from OrderDetails where ProductId = @ProductId and RecordStatus = 'Active') + QuantityOrdered)) as QuantityOnHand
		            from Products where Id = @ProductId"
        Cmd = New MySqlCommand(SQL, Con)
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("ProductId", ProductId)
        Dim dt As DataTable = PerformCRUD(Cmd)
        Return Convert.ToDouble(dt.Rows(0)(0))
    End Function
    Private Sub ResetMe()
        txtId.Text = ""
        txtProductName.Text = ""
        txtDescription.Text = ""
        txtPrice.Text = ""
        txtQtyOnHand.Text = ""
        txtQtySold.Text = ""
        cbxCategory.SelectedIndex = 0
        cbxRecordStatus.SelectedIndex = 0
        cbxRecordStatus.Enabled = False
        txtProductName.Select()
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnSave.Enabled = True
    End Sub

    Private Sub LoadData(Optional keyword As String = "")
        keyword = "%" + keyword + "%"
        SQL = "select a.Id, a.Name as ProductName, b.CategoryName as Category, a.Price, a.CreatedOn, c.DisplayName as CreatedBy, a.RecordStatus, 
                       a.Description, ((select COALESCE(SUM(Quantity), 0) from Inventory where ProductId = a.Id and RecordStatus = 'Active') - ((select COALESCE(SUM(Quantity), 0) from OrderDetails where ProductId = a.Id and RecordStatus = 'Active') + a.QuantityOrdered)) as QuantityOnHand, 
                    (select COALESCE(SUM(Quantity), 0) from OrderDetails where ProductId = a.Id and RecordStatus = 'Active') as QuantitySold, a.CategoryId from Products a 
                    inner join Category b on a.CategoryId = b.Id 
                    inner join  Users c on a.CreatedBy = c.Id
                    where a.Id Like @keyword or a.Name Like @keyword or b.CategoryName Like @keyword
                     or a.Price Like @keyword or a.CreatedOn Like @keyword or c.DisplayName Like @keyword
                           or a.RecordStatus Like @keyword"
        Cmd = New MySqlCommand(SQL, Con)
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("keyword", keyword)

        Dim dt As DataTable = PerformCRUD(Cmd)
        DataGridViewProduct.DataSource = dt

    End Sub
    Private Sub LoadCategory()
        SQL = "Select Id, CategoryName from Category where RecordStatus = 'Active'"
        Cmd = New MySqlCommand(SQL, Con)

        Dim dt As DataTable = PerformCRUD(Cmd)

        'Insert the Default Item to DataTable.
        Dim row As DataRow = dt.NewRow()
        row(0) = 0
        row(1) = "-- Select Category --"
        dt.Rows.InsertAt(row, 0)

        'Assign DataTable as DataSource.
        cbxCategory.DataSource = dt
        cbxCategory.DisplayMember = "CategoryName"
        cbxCategory.ValueMember = "Id"
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' fields validation
        If String.IsNullOrEmpty(txtProductName.Text) Or
            String.IsNullOrEmpty(txtDescription.Text) Or
            String.IsNullOrEmpty(txtPrice.Text) Or
            cbxCategory.SelectedValue = 0 Or
            String.IsNullOrEmpty(cbxRecordStatus.Text) Then
            MessageBox.Show("Please input all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        ' slq insert command
        SQL = "Insert into Products(Name, Description, QuantityOnHand, QuantitySold, Price, CreatedOn, CreatedBy, RecordStatus, CategoryId, QuantityOrdered) Values(@Name, @Description, 0, 0, @Price, @CreatedOn, @CreatedBy, @RecordStatus, @CategoryId, 0)"
        Execute(SQL, "Insert")
        MessageBox.Show("Product Successfully Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadData()
        ResetMe()
    End Sub

    Private Sub DataGridViewProduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProduct.CellClick
        Try
            Dim dgv As DataGridView = DataGridViewProduct
            If e.RowIndex <> -1 Then
                txtId.Text = Convert.ToString(dgv.CurrentRow.Cells(0).Value)
                txtProductName.Text = Convert.ToString(dgv.CurrentRow.Cells(1).Value)
                txtDescription.Text = Convert.ToString(dgv.CurrentRow.Cells(7).Value)
                cbxCategory.SelectedValue = dgv.CurrentRow.Cells(10).Value
                cbxRecordStatus.Text = Convert.ToString(dgv.CurrentRow.Cells(6).Value)
                txtPrice.Text = Convert.ToString(dgv.CurrentRow.Cells(3).Value)
                txtQtyOnHand.Text = If(String.IsNullOrEmpty(Convert.ToString(dgv.CurrentRow.Cells(8).Value)), 0, Convert.ToString(dgv.CurrentRow.Cells(8).Value))
                txtQtySold.Text = If(String.IsNullOrEmpty(Convert.ToString(dgv.CurrentRow.Cells(9).Value)), 0, Convert.ToString(dgv.CurrentRow.Cells(9).Value))
                cbxRecordStatus.Enabled = Convert.ToString(dgv.CurrentRow.Cells(6).Value) = "In Active"
                btnUpdate.Enabled = True
                btnDelete.Enabled = Convert.ToString(dgv.CurrentRow.Cells(6).Value) = "Active"
                btnSave.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' fields validation
        If String.IsNullOrEmpty(txtId.Text) Then
            MessageBox.Show("Please select Product to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        ' cannot delete if there are remaining stocks
        If GetQuantityOnHand(txtId.Text) > 0 Then
            MessageBox.Show("Cannot delete Product with Available Quantity on Hand.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim result As DialogResult = MessageBox.Show("Confirm Delete?", "Product Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            'Delete command
            SQL = "Update Products set RecordStatus = 'In Active' where Id = @Id"
            Execute(SQL, "Delete")
            MessageBox.Show("Product Successfully Deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData()
            ResetMe()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' fields validation
        If String.IsNullOrEmpty(txtProductName.Text) Or
            String.IsNullOrEmpty(txtDescription.Text) Or
            String.IsNullOrEmpty(txtPrice.Text) Or
            cbxCategory.SelectedValue = 0 Or
            String.IsNullOrEmpty(cbxRecordStatus.Text) Then
            MessageBox.Show("Please input all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        ' slq insert command
        SQL = "Update Products set Name = @Name, Description = @Description, Price = @Price, CategoryId = @CategoryId, RecordStatus = @RecordStatus where Id = @Id"
        Execute(SQL, "Update")
        MessageBox.Show("Product Successfully Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadData()
        ResetMe()
    End Sub
End Class