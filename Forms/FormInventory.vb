Imports MySql.Data.MySqlClient
Imports FontAwesome.Sharp

Public Class FormInventory
    Private Sub FormInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTheme()
        ResetMe()
        LoadData()
        lblProductId.Visible = False
        txtProductId.Visible = False
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
                    If grpctns.[GetType]() = GetType(DateTimePicker) Then
                        Dim grpdtp As DateTimePicker = CType(grpctns, DateTimePicker)
                        grpdtp.CalendarForeColor = ThemeColor.SecondaryColor
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
    Public Function checkInventoryIfPositive(query As String, Optional opr As String = "") As Boolean
        Cmd = New MySqlCommand(query, Con)
        AddParameters(opr)
        Dim dt As DataTable = PerformCRUD(Cmd)
        Return dt.Rows(0)(0)
    End Function

    Private Sub AddParameters(str As String)
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("ProductId", txtProductId.Text)
        Cmd.Parameters.AddWithValue("InventoryDate", dtpInventoryDate.Value)
        Cmd.Parameters.AddWithValue("Quantity", txtQuantity.Text)
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
        txtProductName.Text = ""
        txtProductId.Text = ""
        txtQuantity.Text = ""
        dtpInventoryDate.Value = DateTime.Now
        cbxRecordStatus.SelectedIndex = 0
        cbxRecordStatus.Enabled = False
        btnProductPicker.Enabled = True
        btnProductPicker.Select()
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnSave.Enabled = True
    End Sub

    Private Sub LoadData(Optional keyword As String = "")
        keyword = "%" + keyword + "%"
        SQL = "select a.Id, b.Name as ProductName, a.ProductId, a.InventoryDate, a.Quantity, a.RecordStatus, c.DisplayName as CreatedBy, a.CreatedOn
                    from Inventory a inner join Products b on a.ProductId = b.Id
                    inner join Users c on a.CreatedBy = c.Id
                    where a.Id Like @keyword or b.Name Like @keyword or a.InventoryDate Like @keyword
                    or a.Quantity Like @keyword or a.RecordStatus Like @keyword or a.CreatedOn Like @keyword
                    or c.DisplayName Like @keyword"
        Cmd = New MySqlCommand(SQL, Con)
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("keyword", keyword)

        Dim dt As DataTable = PerformCRUD(Cmd)
        DataGridViewInventory.DataSource = dt

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
            String.IsNullOrEmpty(txtProductId.Text) Or
            Convert.ToDouble(txtQuantity.Text) = 0 Or
            String.IsNullOrEmpty(txtQuantity.Text) Or
            String.IsNullOrEmpty(cbxRecordStatus.Text) Then
            MessageBox.Show("Please input all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        ' check product qty ong hand if inputed quantity is negative
        If Convert.ToDouble(txtQuantity.Text) < 0 Then
            ' check if product qty on hand will be negative if this inventory will be deleted
            Dim isPositiveInventory = checkInventoryIfPositive("select 
                    case when (((select COALESCE(SUM(Quantity), 0) from Inventory where ProductId = @ProductId and RecordStatus = 'Active') + @Quantity) - ((select COALESCE(SUM(Quantity), 0) from OrderDetails where ProductId = @ProductId and RecordStatus = 'Active') + (select QuantityOrdered from Products where Id = @ProductId))) >= 0
                        then 1 
                    ELSE 0 
                    END")
            If isPositiveInventory = False Then
                MessageBox.Show("Cannot add negative Inventory for this Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        ' slq insert command + update Products Qty On Hand
        SQL = "Insert into Inventory(ProductId, InventoryDate, Quantity, CreatedBy, CreatedOn, RecordStatus) Values(@ProductId, @InventoryDate, @Quantity, @CreatedBy, @CreatedOn, @RecordStatus);
                update Products as toUpdate,
	                (select COALESCE(SUM(Quantity), 0) as qty from Inventory where ProductId = @ProductId and RecordStatus = 'Active') as inv,
	                (select COALESCE(SUM(Quantity), 0) as qty from OrderDetails where ProductId = @ProductId and RecordStatus = 'Active') as ord,
	                (select QuantityOrdered as qty from Products where Id = @ProductId) as prd
                set toUpdate.QuantityOnHand = (inv.qty - (ord.qty + prd.qty))
                where toUpdate.Id = @ProductId;"
        Execute(SQL, "Insert")
        MessageBox.Show("Inventory Successfully Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadData()
        ResetMe()
    End Sub

    Private Sub DataGridViewProduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewInventory.CellClick
        Try
            Dim dgv As DataGridView = DataGridViewInventory
            If e.RowIndex <> -1 Then
                txtId.Text = Convert.ToString(dgv.CurrentRow.Cells(0).Value)
                txtProductName.Text = Convert.ToString(dgv.CurrentRow.Cells(1).Value)
                txtProductId.Text = Convert.ToString(dgv.CurrentRow.Cells(2).Value)
                dtpInventoryDate.Value = Convert.ToDateTime(dgv.CurrentRow.Cells(3).Value)
                txtQuantity.Text = Convert.ToString(dgv.CurrentRow.Cells(4).Value)
                cbxRecordStatus.Text = Convert.ToString(dgv.CurrentRow.Cells(5).Value)
                cbxRecordStatus.Enabled = Convert.ToString(dgv.CurrentRow.Cells(5).Value) = "In Active"
                btnProductPicker.Enabled = False
                btnUpdate.Enabled = True
                btnDelete.Enabled = Convert.ToString(dgv.CurrentRow.Cells(5).Value) = "Active"
                txtQuantity.Enabled = Convert.ToString(dgv.CurrentRow.Cells(5).Value) = "Active"
                btnSave.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' fields validation
        If String.IsNullOrEmpty(txtId.Text) Then
            MessageBox.Show("Please select Inventory to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        ' check if product qty on hand will be negative if this inventory will be deleted
        Dim isPositiveInventory = checkInventoryIfPositive("select 
                    case when ((select COALESCE(SUM(Quantity), 0) from Inventory where ProductId = @ProductId and RecordStatus = 'Active' and Id != @Id) - ((select COALESCE(SUM(Quantity), 0) from OrderDetails where ProductId = @ProductId and RecordStatus = 'Active') + (select QuantityOrdered from Products where Id = @ProductId))) >= 0
                        then 1
                    ELSE 0 
                    END", "Delete")
        If isPositiveInventory = False Then
            MessageBox.Show("Cannot delete this Inventory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' continue delete if Product Inventory is not negative
        Dim result As DialogResult = MessageBox.Show("Confirm Delete?", "Inventory Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            'Delete command
            SQL = "Update Inventory set RecordStatus = 'In Active' where Id = @Id;
                    update Products as toUpdate,
	                    (select COALESCE(SUM(Quantity), 0) as qty from Inventory where ProductId = @ProductId and RecordStatus = 'Active') as inv,
	                    (select COALESCE(SUM(Quantity), 0) as qty from OrderDetails where ProductId = @ProductId and RecordStatus = 'Active') as ord,
	                    (select QuantityOrdered as qty from Products where Id = @ProductId) as prd
                    set toUpdate.QuantityOnHand = (inv.qty - (ord.qty + prd.qty))
                    where toUpdate.Id = @ProductId;"
            Execute(SQL, "Delete")
            MessageBox.Show("Inventory Successfully Deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData()
            ResetMe()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' fields validation
        If String.IsNullOrEmpty(txtProductName.Text) Or
            String.IsNullOrEmpty(txtProductId.Text) Or
            Convert.ToDouble(txtQuantity.Text) = 0 Or
            String.IsNullOrEmpty(txtQuantity.Text) Or
            String.IsNullOrEmpty(cbxRecordStatus.Text) Then
            MessageBox.Show("Please input all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        ' check if product qty on hand will be negative if this inventory will be deleted
        Dim isPositiveInventory = checkInventoryIfPositive("select 
                    case when (((select COALESCE(SUM(Quantity), 0) from Inventory where ProductId = @ProductId and RecordStatus = 'Active' and Id != @Id) + @Quantity) - ((select COALESCE(SUM(Quantity), 0) from OrderDetails where ProductId = @ProductId and RecordStatus = 'Active') + (select QuantityOrdered from Products where Id = @ProductId))) >= 0
                        then 1
                    ELSE 0 
                    END", "Update")
        If isPositiveInventory = False Then
            MessageBox.Show("Invalid quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' slq insert command
        SQL = "Update Inventory set InventoryDate = @InventoryDate, Quantity = @Quantity, RecordStatus = @RecordStatus where Id = @Id;
                update Products as toUpdate,
	                (select COALESCE(SUM(Quantity), 0) as qty from Inventory where ProductId = @ProductId and RecordStatus = 'Active') as inv,
	                (select COALESCE(SUM(Quantity), 0) as qty from OrderDetails where ProductId = @ProductId and RecordStatus = 'Active') as ord,
	                (select QuantityOrdered as qty from Products where Id = @ProductId) as prd
                set toUpdate.QuantityOnHand = (inv.qty - (ord.qty + prd.qty))
                where toUpdate.Id = @ProductId;"
        Execute(SQL, "Update")
        MessageBox.Show("Inventory Successfully Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadData()
        ResetMe()
    End Sub

    Private Sub btnProductPicker_Click(sender As Object, e As EventArgs) Handles btnProductPicker.Click
        Dim formPicker As New FormProductPicker()
        ' Did the user click Save?
        If formPicker.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ' Yes, so grab the values you want from the dialog here
            Dim pickProduct = formPicker.DataGridViewProduct.CurrentRow
            txtProductId.Text = pickProduct.Cells(0).Value
            txtProductName.Text = pickProduct.Cells(1).Value
        End If
    End Sub
End Class