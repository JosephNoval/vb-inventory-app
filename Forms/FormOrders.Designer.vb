<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOrders
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grbForm = New System.Windows.Forms.GroupBox()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.grpOrderDetails = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridViewOrderDetails = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.btnAddQuantity = New FontAwesome.Sharp.IconButton()
        Me.btnRemoveDetail = New FontAwesome.Sharp.IconButton()
        Me.btnProductPicker = New FontAwesome.Sharp.IconButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOrderNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxRecordStatus = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnClear = New FontAwesome.Sharp.IconButton()
        Me.btnUpdate = New FontAwesome.Sharp.IconButton()
        Me.btnDelete = New FontAwesome.Sharp.IconButton()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxList = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridViewOrders = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedOn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecordStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSearchClear = New FontAwesome.Sharp.IconButton()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityOrdered = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grbForm.SuspendLayout()
        Me.grpOrderDetails.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridViewOrderDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBoxList.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbForm
        '
        Me.grbForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbForm.Controls.Add(Me.lblTotalAmount)
        Me.grbForm.Controls.Add(Me.grpOrderDetails)
        Me.grbForm.Controls.Add(Me.txtOrderNo)
        Me.grbForm.Controls.Add(Me.Label4)
        Me.grbForm.Controls.Add(Me.dtpOrderDate)
        Me.grbForm.Controls.Add(Me.Label8)
        Me.grbForm.Controls.Add(Me.cbxRecordStatus)
        Me.grbForm.Controls.Add(Me.Label6)
        Me.grbForm.Controls.Add(Me.btnClear)
        Me.grbForm.Controls.Add(Me.btnUpdate)
        Me.grbForm.Controls.Add(Me.btnDelete)
        Me.grbForm.Controls.Add(Me.btnSave)
        Me.grbForm.Controls.Add(Me.Label2)
        Me.grbForm.Controls.Add(Me.txtId)
        Me.grbForm.Controls.Add(Me.Label1)
        Me.grbForm.Location = New System.Drawing.Point(12, 12)
        Me.grbForm.Name = "grbForm"
        Me.grbForm.Size = New System.Drawing.Size(1340, 382)
        Me.grbForm.TabIndex = 9
        Me.grbForm.TabStop = False
        Me.grbForm.Text = "Form"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalAmount.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblTotalAmount.Location = New System.Drawing.Point(718, 333)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(49, 28)
        Me.lblTotalAmount.TabIndex = 25
        Me.lblTotalAmount.Text = "0.00"
        '
        'grpOrderDetails
        '
        Me.grpOrderDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpOrderDetails.Controls.Add(Me.Panel4)
        Me.grpOrderDetails.Controls.Add(Me.Panel3)
        Me.grpOrderDetails.Location = New System.Drawing.Point(577, 12)
        Me.grpOrderDetails.Name = "grpOrderDetails"
        Me.grpOrderDetails.Size = New System.Drawing.Size(753, 304)
        Me.grpOrderDetails.TabIndex = 24
        Me.grpOrderDetails.TabStop = False
        Me.grpOrderDetails.Text = "Order Details"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DataGridViewOrderDetails)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 67)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(747, 234)
        Me.Panel4.TabIndex = 23
        '
        'DataGridViewOrderDetails
        '
        Me.DataGridViewOrderDetails.AllowUserToAddRows = False
        Me.DataGridViewOrderDetails.AllowUserToDeleteRows = False
        Me.DataGridViewOrderDetails.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.DataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOrderDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Price, Me.Total, Me.QuantityOrdered})
        Me.DataGridViewOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewOrderDetails.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewOrderDetails.MultiSelect = False
        Me.DataGridViewOrderDetails.Name = "DataGridViewOrderDetails"
        Me.DataGridViewOrderDetails.ReadOnly = True
        Me.DataGridViewOrderDetails.RowHeadersWidth = 51
        Me.DataGridViewOrderDetails.RowTemplate.Height = 29
        Me.DataGridViewOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewOrderDetails.Size = New System.Drawing.Size(747, 234)
        Me.DataGridViewOrderDetails.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtProductName)
        Me.Panel3.Controls.Add(Me.btnAddQuantity)
        Me.Panel3.Controls.Add(Me.btnRemoveDetail)
        Me.Panel3.Controls.Add(Me.btnProductPicker)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 23)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(747, 44)
        Me.Panel3.TabIndex = 22
        '
        'txtProductName
        '
        Me.txtProductName.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtProductName.Enabled = False
        Me.txtProductName.Location = New System.Drawing.Point(78, 6)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.PlaceholderText = "Choose Products"
        Me.txtProductName.Size = New System.Drawing.Size(317, 27)
        Me.txtProductName.TabIndex = 1
        Me.txtProductName.Tag = "fdsf"
        '
        'btnAddQuantity
        '
        Me.btnAddQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddQuantity.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddQuantity.IconChar = FontAwesome.Sharp.IconChar.CartPlus
        Me.btnAddQuantity.IconColor = System.Drawing.Color.Black
        Me.btnAddQuantity.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAddQuantity.IconSize = 25
        Me.btnAddQuantity.Location = New System.Drawing.Point(638, 6)
        Me.btnAddQuantity.Name = "btnAddQuantity"
        Me.btnAddQuantity.Size = New System.Drawing.Size(50, 29)
        Me.btnAddQuantity.TabIndex = 21
        Me.btnAddQuantity.UseVisualStyleBackColor = True
        '
        'btnRemoveDetail
        '
        Me.btnRemoveDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveDetail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveDetail.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.btnRemoveDetail.IconColor = System.Drawing.Color.Black
        Me.btnRemoveDetail.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRemoveDetail.IconSize = 25
        Me.btnRemoveDetail.Location = New System.Drawing.Point(694, 6)
        Me.btnRemoveDetail.Name = "btnRemoveDetail"
        Me.btnRemoveDetail.Size = New System.Drawing.Size(50, 29)
        Me.btnRemoveDetail.TabIndex = 21
        Me.btnRemoveDetail.UseVisualStyleBackColor = True
        '
        'btnProductPicker
        '
        Me.btnProductPicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductPicker.IconChar = FontAwesome.Sharp.IconChar.HandPointer
        Me.btnProductPicker.IconColor = System.Drawing.Color.Black
        Me.btnProductPicker.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnProductPicker.IconSize = 25
        Me.btnProductPicker.Location = New System.Drawing.Point(401, 6)
        Me.btnProductPicker.Name = "btnProductPicker"
        Me.btnProductPicker.Size = New System.Drawing.Size(69, 29)
        Me.btnProductPicker.TabIndex = 21
        Me.btnProductPicker.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(12, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Product"
        '
        'txtOrderNo
        '
        Me.txtOrderNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.txtOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrderNo.Enabled = False
        Me.txtOrderNo.Location = New System.Drawing.Point(133, 80)
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.PlaceholderText = "Autogenerated"
        Me.txtOrderNo.ReadOnly = True
        Me.txtOrderNo.Size = New System.Drawing.Size(392, 27)
        Me.txtOrderNo.TabIndex = 23
        Me.txtOrderNo.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(25, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Order No"
        '
        'dtpOrderDate
        '
        Me.dtpOrderDate.Location = New System.Drawing.Point(133, 126)
        Me.dtpOrderDate.Name = "dtpOrderDate"
        Me.dtpOrderDate.Size = New System.Drawing.Size(392, 27)
        Me.dtpOrderDate.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(25, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Record Status"
        '
        'cbxRecordStatus
        '
        Me.cbxRecordStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.cbxRecordStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRecordStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxRecordStatus.FormattingEnabled = True
        Me.cbxRecordStatus.Items.AddRange(New Object() {"Active", "In Active"})
        Me.cbxRecordStatus.Location = New System.Drawing.Point(133, 170)
        Me.cbxRecordStatus.Name = "cbxRecordStatus"
        Me.cbxRecordStatus.Size = New System.Drawing.Size(392, 28)
        Me.cbxRecordStatus.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(25, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Order Date"
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.btnClear.IconColor = System.Drawing.Color.Black
        Me.btnClear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(14, 315)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(118, 49)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btnUpdate.IconColor = System.Drawing.Color.Black
        Me.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(262, 315)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(118, 49)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.btnDelete.IconColor = System.Drawing.Color.Black
        Me.btnDelete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(386, 315)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(118, 49)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Cancel"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btnSave.IconColor = System.Drawing.Color.Black
        Me.btnSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(138, 315)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(118, 49)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(573, 333)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total Amount:"
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(133, 35)
        Me.txtId.Name = "txtId"
        Me.txtId.PlaceholderText = "Autogenerated"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(392, 27)
        Me.txtId.TabIndex = 1
        Me.txtId.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(25, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        '
        'GroupBoxList
        '
        Me.GroupBoxList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxList.Controls.Add(Me.Panel2)
        Me.GroupBoxList.Controls.Add(Me.Panel1)
        Me.GroupBoxList.Location = New System.Drawing.Point(12, 400)
        Me.GroupBoxList.Name = "GroupBoxList"
        Me.GroupBoxList.Size = New System.Drawing.Size(1340, 319)
        Me.GroupBoxList.TabIndex = 8
        Me.GroupBoxList.TabStop = False
        Me.GroupBoxList.Text = "List"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridViewOrders)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1334, 249)
        Me.Panel2.TabIndex = 20
        '
        'DataGridViewOrders
        '
        Me.DataGridViewOrders.AllowUserToAddRows = False
        Me.DataGridViewOrders.AllowUserToDeleteRows = False
        Me.DataGridViewOrders.AllowUserToOrderColumns = True
        Me.DataGridViewOrders.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.DataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.OrderNo, Me.OrderDate, Me.TotalAmount, Me.CreatedOn, Me.CreatedBy, Me.RecordStatus})
        Me.DataGridViewOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewOrders.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewOrders.MultiSelect = False
        Me.DataGridViewOrders.Name = "DataGridViewOrders"
        Me.DataGridViewOrders.ReadOnly = True
        Me.DataGridViewOrders.RowHeadersWidth = 51
        Me.DataGridViewOrders.RowTemplate.Height = 29
        Me.DataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewOrders.Size = New System.Drawing.Size(1334, 249)
        Me.DataGridViewOrders.TabIndex = 0
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.MinimumWidth = 6
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 125
        '
        'OrderNo
        '
        Me.OrderNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OrderNo.DataPropertyName = "OrderNo"
        Me.OrderNo.HeaderText = "OrderNo"
        Me.OrderNo.MinimumWidth = 250
        Me.OrderNo.Name = "OrderNo"
        Me.OrderNo.ReadOnly = True
        '
        'OrderDate
        '
        Me.OrderDate.DataPropertyName = "OrderDate"
        Me.OrderDate.HeaderText = "Order Date"
        Me.OrderDate.MinimumWidth = 200
        Me.OrderDate.Name = "OrderDate"
        Me.OrderDate.ReadOnly = True
        Me.OrderDate.Width = 200
        '
        'TotalAmount
        '
        Me.TotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TotalAmount.DataPropertyName = "TotalAmount"
        Me.TotalAmount.HeaderText = "Total Amount"
        Me.TotalAmount.MinimumWidth = 150
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.ReadOnly = True
        '
        'CreatedOn
        '
        Me.CreatedOn.DataPropertyName = "CreatedOn"
        Me.CreatedOn.HeaderText = "Created On"
        Me.CreatedOn.MinimumWidth = 200
        Me.CreatedOn.Name = "CreatedOn"
        Me.CreatedOn.ReadOnly = True
        Me.CreatedOn.Width = 200
        '
        'CreatedBy
        '
        Me.CreatedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CreatedBy.DataPropertyName = "CreatedBy"
        Me.CreatedBy.HeaderText = "Created By"
        Me.CreatedBy.MinimumWidth = 150
        Me.CreatedBy.Name = "CreatedBy"
        Me.CreatedBy.ReadOnly = True
        '
        'RecordStatus
        '
        Me.RecordStatus.DataPropertyName = "RecordStatus"
        Me.RecordStatus.HeaderText = "Record Status"
        Me.RecordStatus.MinimumWidth = 250
        Me.RecordStatus.Name = "RecordStatus"
        Me.RecordStatus.ReadOnly = True
        Me.RecordStatus.Width = 250
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSearchClear)
        Me.Panel1.Controls.Add(Me.txtSearchBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1334, 44)
        Me.Panel1.TabIndex = 19
        '
        'btnSearchClear
        '
        Me.btnSearchClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchClear.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.btnSearchClear.IconColor = System.Drawing.Color.Black
        Me.btnSearchClear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSearchClear.IconSize = 23
        Me.btnSearchClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchClear.Location = New System.Drawing.Point(417, 7)
        Me.btnSearchClear.Name = "btnSearchClear"
        Me.btnSearchClear.Size = New System.Drawing.Size(80, 27)
        Me.btnSearchClear.TabIndex = 19
        Me.btnSearchClear.Text = "Clear"
        Me.btnSearchClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchClear.UseVisualStyleBackColor = True
        '
        'txtSearchBox
        '
        Me.txtSearchBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.txtSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchBox.Location = New System.Drawing.Point(19, 7)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.PlaceholderText = "Type To Search"
        Me.txtSearchBox.Size = New System.Drawing.Size(392, 27)
        Me.txtSearchBox.TabIndex = 18
        Me.txtSearchBox.Tag = "fdsf"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProductId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Product Id"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 200
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 130
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 130
        '
        'Price
        '
        Me.Price.DataPropertyName = "Price"
        Me.Price.HeaderText = "Price"
        Me.Price.MinimumWidth = 150
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 150
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 160
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 160
        '
        'QuantityOrdered
        '
        Me.QuantityOrdered.DataPropertyName = "QuantityOrdered"
        Me.QuantityOrdered.HeaderText = "Quantity Ordered"
        Me.QuantityOrdered.MinimumWidth = 6
        Me.QuantityOrdered.Name = "QuantityOrdered"
        Me.QuantityOrdered.ReadOnly = True
        Me.QuantityOrdered.Visible = False
        Me.QuantityOrdered.Width = 125
        '
        'FormOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1364, 731)
        Me.Controls.Add(Me.grbForm)
        Me.Controls.Add(Me.GroupBoxList)
        Me.Name = "FormOrders"
        Me.Text = "Orders"
        Me.grbForm.ResumeLayout(False)
        Me.grbForm.PerformLayout()
        Me.grpOrderDetails.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridViewOrderDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBoxList.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridViewOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbForm As GroupBox
    Friend WithEvents btnProductPicker As FontAwesome.Sharp.IconButton
    Friend WithEvents dtpOrderDate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents cbxRecordStatus As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUpdate As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBoxList As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewOrders As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearchClear As FontAwesome.Sharp.IconButton
    Friend WithEvents txtSearchBox As TextBox
    Friend WithEvents grpOrderDetails As GroupBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridViewOrderDetails As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtOrderNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents OrderNo As DataGridViewTextBoxColumn
    Friend WithEvents OrderDate As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmount As DataGridViewTextBoxColumn
    Friend WithEvents CreatedOn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedBy As DataGridViewTextBoxColumn
    Friend WithEvents RecordStatus As DataGridViewTextBoxColumn
    Friend WithEvents btnAddQuantity As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRemoveDetail As FontAwesome.Sharp.IconButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents QuantityOrdered As DataGridViewTextBoxColumn
End Class
