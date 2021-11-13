Imports MySql.Data.MySqlClient
Imports FontAwesome.Sharp

Public Class FormOrders
    Private loadQuery As String = ""
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If currentUserAccess = "Admin" Then
            loadQuery = "select a.Id, a.OrderNo, a.OrderDate, a.TotalAmount, a.RecordStatus, b.DisplayName as CreatedBy, a.CreatedOn
                    from Orders a inner join Users b on a.CreatedBy = b.Id
                    where a.Id Like @keyword or a.OrderNo Like @keyword or a.OrderDate Like @keyword
                    or a.TotalAmount Like @keyword or a.RecordStatus Like @keyword or a.CreatedOn Like @keyword
                    or b.DisplayName Like @keyword"
        Else
            loadQuery = "select a.Id, a.OrderNo, a.OrderDate, a.TotalAmount, a.RecordStatus, b.DisplayName as CreatedBy, a.CreatedOn
                    from Orders a inner join Users b on a.CreatedBy = b.Id
                    where a.CreatedBy = @CurrentUser and (a.Id Like @keyword or a.OrderNo Like @keyword or a.OrderDate Like @keyword
                    or a.TotalAmount Like @keyword or a.RecordStatus Like @keyword or a.CreatedOn Like @keyword
                    or b.DisplayName Like @keyword)"
        End If
    End Sub
    Private Sub FormOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTheme()
        ResetMe()
        LoadData()
    End Sub
    Public Sub LoadTheme()
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
                    If grpctns.[GetType]() = GetType(GroupBox) Then
                        Dim grpbx As GroupBox = CType(grpctns, GroupBox)
                        grpbx.ForeColor = ThemeColor.PrimaryColor
                        For Each grpbxctns As Control In grpbx.Controls
                            If grpbxctns.[GetType]() = GetType(Label) Then
                                Dim grplbl As Label = CType(grpbxctns, Label)
                                grplbl.ForeColor = ThemeColor.PrimaryColor
                            End If
                            If grpbxctns.[GetType]() = GetType(IconButton) Then
                                Dim grpbtn As IconButton = CType(grpbxctns, IconButton)
                                grpbtn.BackColor = ThemeColor.PrimaryColor
                                grpbtn.ForeColor = Color.White
                                grpbtn.IconColor = Color.White
                                grpbtn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor
                            End If
                            If grpbxctns.[GetType]() = GetType(TextBox) Then
                                Dim grptxt As TextBox = CType(grpbxctns, TextBox)
                                grptxt.ForeColor = ThemeColor.SecondaryColor
                            End If
                            If grpbxctns.[GetType]() = GetType(ComboBox) Then
                                Dim grpcbx As ComboBox = CType(grpbxctns, ComboBox)
                                grpcbx.ForeColor = ThemeColor.SecondaryColor
                            End If
                            If grpbxctns.[GetType]() = GetType(DateTimePicker) Then
                                Dim grpdtp As DateTimePicker = CType(grpbxctns, DateTimePicker)
                                grpdtp.CalendarForeColor = ThemeColor.SecondaryColor
                            End If
                            If grpbxctns.[GetType]() = GetType(Panel) Then
                                Dim panel As Panel = CType(grpbxctns, Panel)
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
    Private Function GetQuantityOnHand(ProductId As String) As Double
        SQL = "select ((select COALESCE(SUM(Quantity), 0) from Inventory where ProductId = @ProductId and RecordStatus = 'Active') - ((select COALESCE(SUM(Quantity), 0) from OrderDetails where ProductId = @ProductId and RecordStatus = 'Active') + QuantityOrdered)) as QuantityOnHand
		            from Products where Id = @ProductId"
        Cmd = New MySqlCommand(SQL, Con)
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("ProductId", ProductId)
        Dim dt As DataTable = PerformCRUD(Cmd)
        Return Convert.ToDouble(dt.Rows(0)(0))
    End Function
    Public Function GetRandomNumber() As Integer
        ' by making Generator static, we preserve the same instance '
        Static Generator As Random = New Random()
        Return Generator.Next(1, 100000)
    End Function

    Private Sub AddParameters(str As String)
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("OrderNo", txtOrderNo.Text)
        Cmd.Parameters.AddWithValue("OrderDate", dtpOrderDate.Value)
        Cmd.Parameters.AddWithValue("TotalAmount", lblTotalAmount.Text)
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
        txtOrderNo.Text = GetRandomNumber()
        lblTotalAmount.Text = "0.00"
        dtpOrderDate.Value = DateTime.Now
        cbxRecordStatus.SelectedIndex = 0
        DataGridViewOrderDetails.Rows.Clear()
        cbxRecordStatus.Enabled = False
        btnProductPicker.Enabled = True
        btnProductPicker.Select()
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnSave.Enabled = True
    End Sub
    Public Sub VoidOrderDetailItems()
        For x As Integer = 0 To DataGridViewOrderDetails.Rows.Count - 1
            ' void product if quantityordered > 0
            If Convert.ToDouble(DataGridViewOrderDetails.Rows(x).Cells(5).Value) > 0 Then
                ' Update Product QuantityOrdered + quantity and Qty On Hand
                SQL = "update Products 
	                    set QuantityOrdered = QuantityOrdered - @QuantityOrdered
                        where Id = @ProductId;
                        update Products as toUpdate,
	                        (select COALESCE(SUM(Quantity), 0) as qty from Inventory where ProductId = @ProductId and RecordStatus = 'Active') as inv,
	                        (select COALESCE(SUM(Quantity), 0) as qty from OrderDetails where ProductId = @ProductId and RecordStatus = 'Active') as ord,
	                        (select QuantityOrdered as qty from Products where Id = @ProductId) as prd
                        set toUpdate.QuantityOnHand = (inv.qty - (ord.qty + prd.qty))
                        where toUpdate.Id = @ProductId;"
                Cmd = New MySqlCommand(SQL, Con)
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("ProductId", DataGridViewOrderDetails.Rows(x).Cells(0).Value)
                Cmd.Parameters.AddWithValue("QuantityOrdered", DataGridViewOrderDetails.Rows(x).Cells(5).Value)
                PerformCRUD(Cmd)
            End If
        Next
        DataGridViewOrderDetails.Rows.Clear()
    End Sub

    Private Sub ComputeTotalAmount()
        Dim totAmount As Double = 0
        For x As Integer = 0 To DataGridViewOrderDetails.Rows.Count - 1
            totAmount += Convert.ToDouble(DataGridViewOrderDetails.Item("Total", x).Value)
        Next
        lblTotalAmount.Text = String.Format("{0:0.00#}", totAmount)
    End Sub

    Private Sub LoadData(Optional keyword As String = "")
        keyword = "%" + keyword + "%"
        SQL = loadQuery
        Cmd = New MySqlCommand(SQL, Con)
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("keyword", keyword)
        Cmd.Parameters.AddWithValue("CurrentUser", currentUserId)

        Dim dt As DataTable = PerformCRUD(Cmd)
        DataGridViewOrders.DataSource = dt

    End Sub

    Private Sub LoadOrderDetails(OrderId As String)
        SQL = "select a.ProductId, b.Name as ProductName, a.Quantity, a.Price, (a.Quantity * a.Price) as Total, 0 as QuantityOrdered
	                from OrderDetails a inner join Products b on a.ProductId = b.Id
                    where a.OrderId = @OrderId"
        Cmd = New MySqlCommand(SQL, Con)
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("OrderId", OrderId)

        Dim dt As DataTable = PerformCRUD(Cmd)
        DataGridViewOrderDetails.Rows.Clear()
        For x As Integer = 0 To dt.Rows.Count - 1
            Dim row As String() = New String() {dt.Rows(x)(0).ToString(), dt.Rows(x)(1).ToString(), dt.Rows(x)(2).ToString(), dt.Rows(x)(3).ToString(), dt.Rows(x)(4).ToString(), dt.Rows(x)(5).ToString()}
            DataGridViewOrderDetails.Rows.Add(row)
        Next

    End Sub
    Private Sub btnSearchClear_Click(sender As Object, e As EventArgs) Handles btnSearchClear.Click
        txtSearchBox.Text = ""
    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        LoadData(txtSearchBox.Text)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If DataGridViewOrderDetails.RowCount > 0 Then
            VoidOrderDetailItems()
        End If
        ResetMe()
        LoadData()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'fields validation
        If String.IsNullOrEmpty(txtOrderNo.Text) Or
            Convert.ToDouble(lblTotalAmount.Text) = 0 Or
            DataGridViewOrderDetails.RowCount = 0 Then
            MessageBox.Show("Please input all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'sql insert order header
        SQL = "Insert into orders(OrderNo, OrderDate, TotalAmount, CreatedBy, CreatedOn, RecordStatus) Values(@OrderNo, @OrderDate, @TotalAmount, @CreatedBy, @CreatedOn, @RecordStatus);
                SELECT LAST_INSERT_ID();"
        Cmd = New MySqlCommand(SQL, Con)
        AddParameters("Insert")
        Dim dt As DataTable = PerformCRUD(Cmd)
        Dim orderId = Convert.ToInt64(dt.Rows(0)(0))

        ' slq insert order details command + update Products Qty On Hand and Qty Sold and Qty Ordered
        If orderId > 0 Then
            For x As Integer = 0 To DataGridViewOrderDetails.Rows.Count - 1
                SQL = "Insert into orderdetails(OrderId, ProductId, Quantity, Price, Total, CreatedBy, CreatedOn, RecordStatus) Values(@OrderId, @ProductId, @Quantity, @Price, @Total, @CreatedBy, @CreatedOn, @RecordStatus);
                        update Products as toUpdate,
	                        (select COALESCE(SUM(Quantity), 0) as qty from OrderDetails where ProductId = @ProductId and RecordStatus = 'Active') as ord
                        set toUpdate.QuantitySold = ord.qty,
                            toUpdate.QuantityOrdered = toUpdate.QuantityOrdered - @QuantityOrdered
                        where toUpdate.Id = @ProductId;
                        update Products as toUpdate,
	                        (select COALESCE(SUM(Quantity), 0) as qty from Inventory where ProductId = @ProductId and RecordStatus = 'Active') as inv,
	                        (select COALESCE(SUM(Quantity), 0) as qty from OrderDetails where ProductId = @ProductId and RecordStatus = 'Active') as ord,
	                        (select QuantityOrdered as qty from Products where Id = @ProductId) as prd
                        set toUpdate.QuantityOnHand = (inv.qty - (ord.qty + prd.qty))
                        where toUpdate.Id = @ProductId;"
                Cmd = New MySqlCommand(SQL, Con)
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("OrderId", orderId)
                Cmd.Parameters.AddWithValue("ProductId", DataGridViewOrderDetails.Rows(x).Cells(0).Value)
                Cmd.Parameters.AddWithValue("Quantity", DataGridViewOrderDetails.Rows(x).Cells(2).Value)
                Cmd.Parameters.AddWithValue("Price", DataGridViewOrderDetails.Rows(x).Cells(3).Value)
                Cmd.Parameters.AddWithValue("Total", DataGridViewOrderDetails.Rows(x).Cells(4).Value)
                Cmd.Parameters.AddWithValue("QuantityOrdered", DataGridViewOrderDetails.Rows(x).Cells(5).Value)
                Cmd.Parameters.AddWithValue("CreatedBy", currentUserId)
                Cmd.Parameters.AddWithValue("CreatedOn", DateTime.Now)
                Cmd.Parameters.AddWithValue("RecordStatus", "Active")
                PerformCRUD(Cmd)
            Next
        End If
        MessageBox.Show("Order Successfully Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadData()
        ResetMe()
    End Sub

    Private Sub DataGridViewOrders_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewOrders.CellClick
        Try
            Dim dgv As DataGridView = DataGridViewOrders
            If e.RowIndex <> -1 Then
                If DataGridViewOrderDetails.Rows.Count > 0 Then
                    VoidOrderDetailItems()
                End If
                txtId.Text = Convert.ToString(dgv.CurrentRow.Cells(0).Value)
                txtOrderNo.Text = Convert.ToString(dgv.CurrentRow.Cells(1).Value)
                dtpOrderDate.Value = Convert.ToDateTime(dgv.CurrentRow.Cells(2).Value)
                lblTotalAmount.Text = String.Format("{0:0.00#}", dgv.CurrentRow.Cells(3).Value)
                cbxRecordStatus.Text = Convert.ToString(dgv.CurrentRow.Cells(4).Value)
                cbxRecordStatus.Enabled = Convert.ToString(dgv.CurrentRow.Cells(4).Value) = "In Active"
                btnProductPicker.Enabled = False
                btnUpdate.Enabled = True
                btnDelete.Enabled = Convert.ToString(dgv.CurrentRow.Cells(4).Value) = "Active"
                btnSave.Enabled = False
                btnProductPicker.Enabled = Convert.ToString(dgv.CurrentRow.Cells(4).Value) = "Active"
                btnAddQuantity.Enabled = Convert.ToString(dgv.CurrentRow.Cells(4).Value) = "Active"
                btnRemoveDetail.Enabled = Convert.ToString(dgv.CurrentRow.Cells(4).Value) = "Active"
                LoadOrderDetails(Convert.ToString(dgv.CurrentRow.Cells(0).Value))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' fields validation
        If String.IsNullOrEmpty(txtId.Text) Then
            MessageBox.Show("Please select Order to Cancel.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        ' confirm cancel
        Dim result As DialogResult = MessageBox.Show("Confirm Cancel?", "Order Cancel", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            'Cancel command
            SQL = "Update Orders set RecordStatus = 'In Active' where Id = @Id;
                    Update OrderDetails set RecordStatus = 'In Active' where OrderId = @Id"
            Execute(SQL, "Delete")
            For x As Integer = 0 To DataGridViewOrderDetails.Rows.Count - 1
                ' Update Product QuantityOrdered , QuantitySold, QuantityOnHand
                SQL = "update Products as toUpdate,
	                            (select COALESCE(SUM(Quantity), 0) as qty from OrderDetails where ProductId = @ProductId and RecordStatus = 'Active') as ord
                            set toUpdate.QuantitySold = ord.qty,
                                toUpdate.QuantityOrdered = toUpdate.QuantityOrdered - @QuantityOrdered
                            where toUpdate.Id = @ProductId;
                            update Products as toUpdate,
	                            (select COALESCE(SUM(Quantity), 0) as qty from Inventory where ProductId = @ProductId and RecordStatus = 'Active') as inv,
	                            (select COALESCE(SUM(Quantity), 0) as qty from OrderDetails where ProductId = @ProductId and RecordStatus = 'Active') as ord,
	                            (select QuantityOrdered as qty from Products where Id = @ProductId) as prd
                            set toUpdate.QuantityOnHand = (inv.qty - (ord.qty + prd.qty))
                            where toUpdate.Id = @ProductId;"
                Cmd = New MySqlCommand(SQL, Con)
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("ProductId", DataGridViewOrderDetails.Rows(x).Cells(0).Value)
                Cmd.Parameters.AddWithValue("QuantityOrdered", DataGridViewOrderDetails.Rows(x).Cells(5).Value)
                PerformCRUD(Cmd)
            Next
            MessageBox.Show("Order Successfully Cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData()
            ResetMe()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'fields validation
        If String.IsNullOrEmpty(txtOrderNo.Text) Or
            Convert.ToDouble(lblTotalAmount.Text) = 0 Or
            DataGridViewOrderDetails.RowCount = 0 Then
            MessageBox.Show("Please input all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'sql insert order header
        SQL = "Update Orders set OrderDate = @OrderDate, TotalAmount = @TotalAmount, RecordStatus = @RecordStatus where Id = @Id;
                delete from OrderDetails where OrderId = @Id;"
        Execute(SQL, "Update")

        ' slq insert order details command + update Products Qty On Hand and Qty Sold and Qty Ordered
        For x As Integer = 0 To DataGridViewOrderDetails.Rows.Count - 1
            SQL = "Insert into orderdetails(OrderId, ProductId, Quantity, Price, Total, CreatedBy, CreatedOn, RecordStatus) Values(@OrderId, @ProductId, @Quantity, @Price, @Total, @CreatedBy, @CreatedOn, @RecordStatus);
                        update Products as toUpdate,
	                        (select COALESCE(SUM(Quantity), 0) as qty from OrderDetails where ProductId = @ProductId and RecordStatus = 'Active') as ord
                        set toUpdate.QuantitySold = ord.qty,
                            toUpdate.QuantityOrdered = toUpdate.QuantityOrdered - @QuantityOrdered
                        where toUpdate.Id = @ProductId;
                        update Products as toUpdate,
	                        (select COALESCE(SUM(Quantity), 0) as qty from Inventory where ProductId = @ProductId and RecordStatus = 'Active') as inv,
	                        (select COALESCE(SUM(Quantity), 0) as qty from OrderDetails where ProductId = @ProductId and RecordStatus = 'Active') as ord,
	                        (select QuantityOrdered as qty from Products where Id = @ProductId) as prd
                        set toUpdate.QuantityOnHand = (inv.qty - (ord.qty + prd.qty))
                        where toUpdate.Id = @ProductId;"
            Cmd = New MySqlCommand(SQL, Con)
            Cmd.Parameters.Clear()
            Cmd.Parameters.AddWithValue("OrderId", txtId.Text)
            Cmd.Parameters.AddWithValue("ProductId", DataGridViewOrderDetails.Rows(x).Cells(0).Value)
            Cmd.Parameters.AddWithValue("Quantity", DataGridViewOrderDetails.Rows(x).Cells(2).Value)
            Cmd.Parameters.AddWithValue("Price", DataGridViewOrderDetails.Rows(x).Cells(3).Value)
            Cmd.Parameters.AddWithValue("Total", DataGridViewOrderDetails.Rows(x).Cells(4).Value)
            Cmd.Parameters.AddWithValue("QuantityOrdered", DataGridViewOrderDetails.Rows(x).Cells(5).Value)
            Cmd.Parameters.AddWithValue("CreatedBy", currentUserId)
            Cmd.Parameters.AddWithValue("CreatedOn", DateTime.Now)
            Cmd.Parameters.AddWithValue("RecordStatus", cbxRecordStatus.Text)
            PerformCRUD(Cmd)
        Next
        MessageBox.Show("Order Successfully Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadData()
        ResetMe()
    End Sub

    Private Sub btnProductPicker_Click(sender As Object, e As EventArgs) Handles btnProductPicker.Click
        Dim prodPickSql As String = "select a.Id, a.Name as ProductName, ((select COALESCE(SUM(Quantity), 0) from Inventory where ProductId = a.Id and RecordStatus = 'Active') - ((select COALESCE(SUM(Quantity), 0) from OrderDetails where ProductId = a.Id and RecordStatus = 'Active') + a.QuantityOrdered)) as QuantityOnHand, a.Price
                                            from Products a 
                                            where a.RecordStatus = 'Active' and ((select COALESCE(SUM(Quantity), 0) from Inventory where ProductId = a.Id and RecordStatus = 'Active') - ((select COALESCE(SUM(Quantity), 0) from OrderDetails where ProductId = a.Id and RecordStatus = 'Active') + a.QuantityOrdered)) > 0 
                                            and (a.Id Like @keyword or a.Name Like @keyword or a.Price Like @keyword 
                                            or ((select COALESCE(SUM(Quantity), 0) from Inventory where ProductId = a.Id and RecordStatus = 'Active') - ((select COALESCE(SUM(Quantity), 0) from OrderDetails where ProductId = a.Id and RecordStatus = 'Active') + a.QuantityOrdered)) Like @keyword)"
        Dim formPicker As New FormProductPicker(prodPickSql)
        ' Did the user click Save?
        If formPicker.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ' Yes, so grab the values you want from the dialog here
            Dim pickProduct As DataRow = DirectCast(formPicker.DataGridViewProduct.CurrentRow.DataBoundItem, DataRowView).Row
            Dim formQuantity As New FormQuantity(Convert.ToDouble(pickProduct("QuantityOnHand")))
            If formQuantity.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim quantityordered = Convert.ToDouble(formQuantity.txtQuantity.Text)
                txtProductName.Text = pickProduct("ProductName").ToString()
                Dim temp As Integer = 0
                ' update quantity and total if pick product already exist
                For i As Integer = 0 To DataGridViewOrderDetails.RowCount - 1
                    If DataGridViewOrderDetails.Rows(i).Cells(0).Value.ToString = pickProduct("Id").ToString() Then
                        DataGridViewOrderDetails.Rows(i).Cells(2).Value = Convert.ToDouble(DataGridViewOrderDetails.Rows(i).Cells(2).Value) + quantityordered
                        DataGridViewOrderDetails.Rows(i).Cells(5).Value = Convert.ToDouble(DataGridViewOrderDetails.Rows(i).Cells(5).Value) + quantityordered
                        DataGridViewOrderDetails.Rows(i).Cells(4).Value = Convert.ToDouble(DataGridViewOrderDetails.Rows(i).Cells(2).Value) * Convert.ToDouble(DataGridViewOrderDetails.Rows(i).Cells(3).Value)
                        temp = 1
                    End If
                Next
                ' add new row if product did not exist
                If temp = 0 Then
                    Dim row As String() = New String() {pickProduct("Id").ToString(), pickProduct("ProductName").ToString(), quantityordered.ToString(), pickProduct("Price").ToString(), (quantityordered * Convert.ToDouble(pickProduct("Price"))).ToString(), quantityordered.ToString()}
                    DataGridViewOrderDetails.Rows.Add(row)
                End If
                ' compute total amount
                ComputeTotalAmount()
                ' Update Product QuantityOrdered + quantity and Qty On Hand
                SQL = "update Products 
	                    set QuantityOrdered = QuantityOrdered + @QuantityOrdered
                        where Id = @ProductId;
                        update Products as toUpdate,
	                        (select COALESCE(SUM(Quantity), 0) as qty from Inventory where ProductId = @ProductId and RecordStatus = 'Active') as inv,
	                        (select COALESCE(SUM(Quantity), 0) as qty from OrderDetails where ProductId = @ProductId and RecordStatus = 'Active') as ord,
	                        (select QuantityOrdered as qty from Products where Id = @ProductId) as prd
                        set toUpdate.QuantityOnHand = (inv.qty - (ord.qty + prd.qty))
                        where toUpdate.Id = @ProductId;"
                Cmd = New MySqlCommand(SQL, Con)
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("ProductId", pickProduct("Id"))
                Cmd.Parameters.AddWithValue("QuantityOrdered", quantityordered)
                PerformCRUD(Cmd)
            End If
        End If
    End Sub

    Private Sub DataGridViewOrderDetails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewOrderDetails.CellClick
        Try
            Dim dgv As DataGridView = DataGridViewOrderDetails
            If e.RowIndex <> -1 Then
                txtProductName.Text = Convert.ToString(dgv.CurrentRow.Cells(1).Value)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddQuantity_Click(sender As Object, e As EventArgs) Handles btnAddQuantity.Click
        If DataGridViewOrderDetails.Rows.Count > 0 And DataGridViewOrderDetails.CurrentRow IsNot Nothing Then
            ' get qty on hand of the product
            Dim qtyOnHand As Double = GetQuantityOnHand(DataGridViewOrderDetails.CurrentRow.Cells(0).Value.ToString())

            Dim formQuantity As New FormQuantity(qtyOnHand)
            If formQuantity.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim quantityordered = Convert.ToDouble(formQuantity.txtQuantity.Text)
                ' update quantity and total
                DataGridViewOrderDetails.CurrentRow.Cells(2).Value = Convert.ToDouble(DataGridViewOrderDetails.CurrentRow.Cells(2).Value) + quantityordered
                DataGridViewOrderDetails.CurrentRow.Cells(5).Value = Convert.ToDouble(DataGridViewOrderDetails.CurrentRow.Cells(5).Value) + quantityordered
                DataGridViewOrderDetails.CurrentRow.Cells(4).Value = Convert.ToDouble(DataGridViewOrderDetails.CurrentRow.Cells(2).Value) * Convert.ToDouble(DataGridViewOrderDetails.CurrentRow.Cells(3).Value)
                ' compute total amount
                ComputeTotalAmount()
                ' Update Product QuantityOrdered + quantity and Qty On Hand
                SQL = "update Products 
	                    set QuantityOrdered = QuantityOrdered + @QuantityOrdered
                        where Id = @ProductId;
                        update Products as toUpdate,
	                        (select COALESCE(SUM(Quantity), 0) as qty from Inventory where ProductId = @ProductId and RecordStatus = 'Active') as inv,
	                        (select COALESCE(SUM(Quantity), 0) as qty from OrderDetails where ProductId = @ProductId and RecordStatus = 'Active') as ord,
	                        (select QuantityOrdered as qty from Products where Id = @ProductId) as prd
                        set toUpdate.QuantityOnHand = (inv.qty - (ord.qty + prd.qty))
                        where toUpdate.Id = @ProductId;"
                Cmd = New MySqlCommand(SQL, Con)
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("ProductId", DataGridViewOrderDetails.CurrentRow.Cells(0).Value)
                Cmd.Parameters.AddWithValue("QuantityOrdered", quantityordered)
                PerformCRUD(Cmd)
            End If
        End If
    End Sub

    Private Sub btnRemoveDetail_Click(sender As Object, e As EventArgs) Handles btnRemoveDetail.Click
        If DataGridViewOrderDetails.Rows.Count > 0 And DataGridViewOrderDetails.CurrentRow IsNot Nothing Then
            Dim quantityordered = Convert.ToDouble(DataGridViewOrderDetails.CurrentRow.Cells(5).Value)
            Dim productId = DataGridViewOrderDetails.CurrentRow.Cells(0).Value
            ' remove current row
            DataGridViewOrderDetails.Rows.RemoveAt(DataGridViewOrderDetails.CurrentRow.Index)
            ' compute total amount
            ComputeTotalAmount()
            If quantityordered > 0 Then
                ' Update Product QuantityOrdered - quantity and Qty On Hand
                SQL = "update Products 
	                    set QuantityOrdered = QuantityOrdered - @QuantityOrdered
                        where Id = @ProductId;
                        update Products as toUpdate,
	                        (select COALESCE(SUM(Quantity), 0) as qty from Inventory where ProductId = @ProductId and RecordStatus = 'Active') as inv,
	                        (select COALESCE(SUM(Quantity), 0) as qty from OrderDetails where ProductId = @ProductId and RecordStatus = 'Active') as ord,
	                        (select QuantityOrdered as qty from Products where Id = @ProductId) as prd
                        set toUpdate.QuantityOnHand = (inv.qty - (ord.qty + prd.qty))
                        where toUpdate.Id = @ProductId;"
                Cmd = New MySqlCommand(SQL, Con)
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("ProductId", productId)
                Cmd.Parameters.AddWithValue("QuantityOrdered", quantityordered)
                PerformCRUD(Cmd)
            End If
        End If
    End Sub
End Class